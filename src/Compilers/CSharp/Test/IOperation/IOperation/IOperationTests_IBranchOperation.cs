// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class IOperationTests : SemanticModelTestBase
{
[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,526,1354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,673,765);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
label1: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,781,825);

var 
compilation = f_22012_799_824(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,841,1089);

f_22012_841_1088(
            compilation, f_22012_997_1069(f_22012_997_1050(ErrorCode.WRN_UnreferencedLabel, "label1"), 6, 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1105,1265);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Exit
    Predecessors: [B0]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1279,1343);

f_22012_1279_1342(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,526,1354);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,526,1354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,526,1354);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,1366,3480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1513,1722);

var 
source = @"
class C
{
    void F(bool a, bool b, bool c)
    /*<bind>*/{
label1: if (a) goto label2;
        c = true;
label2: if (b) goto label1;
        if (c) goto label1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1738,1782);

var 
compilation = f_22012_1756_1781(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1798,1830);

f_22012_1798_1829(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,1846,3391);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3] [B4]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = true')
              Left: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B1] [B2]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B1]
Block[B4] - Block
    Predecessors: [B3]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B1]
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,3405,3469);

f_22012_3405_3468(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,1366,3480);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,1366,3480);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,1366,3480);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,3492,5606);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,3639,3848);

var 
source = @"
class C
{
    void F(bool a, bool b, bool c)
    /*<bind>*/{
label1: if (a) goto label2;
        if (b) goto label2;
        c = true;
label2: if (c) goto label1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,3864,3908);

var 
compilation = f_22012_3882_3907(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,3924,3956);

f_22012_3924_3955(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,3972,5517);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B4]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B4]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = true')
              Left: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B1] [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B1]
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,5531,5595);

f_22012_5531_5594(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,3492,5606);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,3492,5606);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,3492,5606);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_04()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,5618,7809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,5765,6051);

var 
source = @"
class C
{
    void F(bool a, bool b, bool c)
    /*<bind>*/{
label1: if (a) goto label2;
        goto label3;
label2: c = true;
label3: if (b) goto label4;
        goto label1;
label4: if (c) goto label5;
        goto label1;
label5: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,6067,6111);

var 
compilation = f_22012_6085_6110(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,6127,6159);

f_22012_6127_6158(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,6175,7720);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3] [B4]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = true')
              Left: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B1] [B2]
    Statements (0)
    Jump if False (Regular) to Block[B1]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B3]
    Statements (0)
    Jump if False (Regular) to Block[B1]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B5]
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,7734,7798);

f_22012_7734_7797(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,5618,7809);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,5618,7809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,5618,7809);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_05()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,7821,10012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,7968,8254);

var 
source = @"
class C
{
    void F(bool a, bool b, bool c)
    /*<bind>*/{
label1: if (a) goto label2;
        goto label4;
label2: if (b) goto label3;
        goto label4;
label3: c = true;
label4: if (c) goto label5;
        goto label1;
label5: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,8270,8314);

var 
compilation = f_22012_8288_8313(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,8330,8362);

f_22012_8330_8361(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,8378,9923);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B4]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'c = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'c = true')
              Left: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B1] [B2] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B1]
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'c')

    Next (Regular) Block[B5]
Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,9937,10001);

f_22012_9937_10000(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,7821,10012);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,7821,10012);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,7821,10012);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_06()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,10024,11253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,10171,10274);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        goto label1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,10290,10334);

var 
compilation = f_22012_10308_10333(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,10350,10656);

f_22012_10350_10655(
            compilation, f_22012_10543_10636(f_22012_10543_10616(f_22012_10543_10592(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 6, 14));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,10672,11164);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,11178,11242);

f_22012_11178_11241(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,10024,11253);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,10024,11253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,10024,11253);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_07()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,11265,13012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,11412,11537);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        goto label1;
        goto label1;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,11553,11597);

var 
compilation = f_22012_11571_11596(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,11613,12176);

f_22012_11613_12175(
            compilation, f_22012_11806_11899(f_22012_11806_11879(f_22012_11806_11855(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 6, 14), f_22012_12063_12156(f_22012_12063_12136(f_22012_12063_12112(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 7, 14));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,12192,12923);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (4)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,12937,13001);

f_22012_12937_13000(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,11265,13012);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,11265,13012);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,11265,13012);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_08()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,13024,14527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,13171,13287);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        if (a) goto label2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,13303,13347);

var 
compilation = f_22012_13321_13346(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,13363,13676);

f_22012_13363_13675(
            compilation, f_22012_13563_13656(f_22012_13563_13636(f_22012_13563_13612(ErrorCode.ERR_LabelNotFound, "label2"), "label2"), 6, 21));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,13692,14438);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label2')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label2;')
          Children(0)

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,14452,14516);

f_22012_14452_14515(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,13024,14527);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,13024,14527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,13024,14527);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_09()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,14539,16929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,14686,14839);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
        if (a) goto label2;
        if (b) goto label2;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,14855,14899);

var 
compilation = f_22012_14873_14898(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,14915,15492);

f_22012_14915_15491(
            compilation, f_22012_15115_15208(f_22012_15115_15188(f_22012_15115_15164(ErrorCode.ERR_LabelNotFound, "label2"), "label2"), 6, 21), f_22012_15379_15472(f_22012_15379_15452(f_22012_15379_15428(ErrorCode.ERR_LabelNotFound, "label2"), "label2"), 7, 21));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,15508,16840);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label2')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label2;')
          Children(0)

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B1] [B2]
    Statements (0)
    Jump if False (Regular) to Block[B5]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B4] - Block
    Predecessors: [B3]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label2')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label2;')
          Children(0)

    Next (Regular) Block[B5]
Block[B5] - Exit
    Predecessors: [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,16854,16918);

f_22012_16854_16917(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,14539,16929);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,14539,16929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,14539,16929);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_10()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,16941,18470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,17088,17237);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        if (a) goto label2;
        goto label1;
label2: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,17253,17297);

var 
compilation = f_22012_17271_17296(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,17313,17619);

f_22012_17313_17618(
            compilation, f_22012_17506_17599(f_22012_17506_17579(f_22012_17506_17555(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 7, 14));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,17635,18381);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B1]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,18395,18459);

f_22012_18395_18458(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,16941,18470);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,16941,18470);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,16941,18470);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_11()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,18482,20913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,18629,18837);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
        if (a) goto label2;
        goto label1;
label2: if (b) goto label3;
        goto label1;
label3: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,18853,18897);

var 
compilation = f_22012_18871_18896(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,18913,19476);

f_22012_18913_19475(
            compilation, f_22012_19106_19199(f_22012_19106_19179(f_22012_19106_19155(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 7, 14), f_22012_19363_19456(f_22012_19363_19436(f_22012_19363_19412(ErrorCode.ERR_LabelNotFound, "label1"), "label1"), 9, 14));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,19492,20824);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B1]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

    Next (Regular) Block[B3]
Block[B3] - Block
    Predecessors: [B1] [B2]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B5]
Block[B4] - Block
    Predecessors: [B3]
    Statements (2)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'label1')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto label1;')
          Children(0)

    Next (Regular) Block[B5]
Block[B5] - Exit
    Predecessors: [B3] [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,20838,20902);

f_22012_20838_20901(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,18482,20913);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,18482,20913);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,18482,20913);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_12()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,20925,22767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,21072,21259);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
        while (a)
        {
            if (b) break;
            a = false;
        }
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,21275,21319);

var 
compilation = f_22012_21293_21318(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,21335,21367);

f_22012_21335_21366(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,21383,22678);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3]
    Statements (0)
    Jump if False (Regular) to Block[B4]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Block
    Predecessors: [B1]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B4]
Block[B3] - Block
    Predecessors: [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = false')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B1]
Block[B4] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,22692,22756);

f_22012_22692_22755(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,20925,22767);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,20925,22767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,20925,22767);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_15()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,22779,23839);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,22926,23023);

var 
source = @"
class C
{
    void F()
    /*<bind>*/{
        break;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,23039,23083);

var 
compilation = f_22012_23057_23082(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,23099,23363);

f_22012_23099_23362(
            compilation, f_22012_23275_23343(f_22012_23275_23324(ErrorCode.ERR_NoBreakOrCont, "break;"), 6, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,23379,23750);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'break;')
          Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,23764,23828);

f_22012_23764_23827(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,22779,23839);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,22779,23839);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,22779,23839);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_16()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,23851,27100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,23998,24248);

string 
source = @"
class P
{
    void M(bool x, bool y)
/*<bind>*/{
        while (filter(out var j))
        {
            if (x) continue;
            y = false;
        }
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,24262,26912);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B3] [B4]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B5]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B3]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (0)
        Jump if False (Regular) to Block[B4]
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Next (Regular) Block[B1]
            Leaving: {R1}
    Block[B4] - Block
        Predecessors: [B3]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'y = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'y = false')
                  Left: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B1]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,26926,26979);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,26995,27089);

f_22012_26995_27088(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,23851,27100);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,23851,27100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,23851,27100);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_17()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,27112,30347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,27259,27523);

string 
source = @"
class P
{
    void M(bool x, bool y)
/*<bind>*/{
        do
        {
            if (x) continue;
            y = false;
        }
        while  (filter(out var j));
    }/*</bind>*/
    bool filter(out int i) => throw null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,27537,30159);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B4]
    Statements (0)
    Next (Regular) Block[B2]
        Entering: {R1}

.locals {R1}
{
    Locals: [System.Int32 j]
    Block[B2] - Block
        Predecessors: [B1]
        Statements (0)
        Jump if False (Regular) to Block[B3]
            IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')

        Next (Regular) Block[B4]
    Block[B3] - Block
        Predecessors: [B2]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'y = false;')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'y = false')
                  Left: 
                    IParameterReferenceOperation: y (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'y')
                  Right: 
                    ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

        Next (Regular) Block[B4]
    Block[B4] - Block
        Predecessors: [B2] [B3]
        Statements (0)
        Jump if True (Regular) to Block[B1]
            IInvocationOperation ( System.Boolean P.filter(out System.Int32 i)) (OperationKind.Invocation, Type: System.Boolean) (Syntax: 'filter(out var j)')
              Instance Receiver: 
                IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: P, IsImplicit) (Syntax: 'filter')
              Arguments(1):
                  IArgumentOperation (ArgumentKind.Explicit, Matching Parameter: i) (OperationKind.Argument, Type: null) (Syntax: 'out var j')
                    IDeclarationExpressionOperation (OperationKind.DeclarationExpression, Type: System.Int32) (Syntax: 'var j')
                      ILocalReferenceOperation: j (IsDeclaration: True) (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'j')
                    InConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
                    OutConversion: CommonConversion (Exists: True, IsIdentity: True, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Leaving: {R1}

        Next (Regular) Block[B5]
            Leaving: {R1}
}

Block[B5] - Exit
    Predecessors: [B4]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,30173,30226);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,30242,30336);

f_22012_30242_30335(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,27112,30347);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,27112,30347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,27112,30347);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_19()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,30359,31406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,30506,30607);

string 
source = @"
class P
{
    void M()
/*<bind>*/{
        continue;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,30621,30995);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'continue;')
          Children(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,31009,31285);

var 
expectedDiagnostics = new[] {
f_22012_31198_31269(f_22012_31198_31250(ErrorCode.ERR_NoBreakOrCont, "continue;"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,31301,31395);

f_22012_31301_31394(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,30359,31406);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,30359,31406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,30359,31406);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_25()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,31418,40029);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,31565,32196);

string 
source = @"
class P
{
    void M(bool x)
/*<bind>*/{
        goto finallyLabel;
        goto catchlabel;
        goto trylabel;

        try
        {
trylabel:
            goto finallyLabel;
            goto catchlabel;
            goto outsideLabel;
        }
        catch
        {
catchlabel:
            goto finallyLabel;
            goto trylabel;
            goto outsideLabel;
        }
        finally
        {
finallyLabel:
            goto catchlabel;
            goto trylabel;
            goto outsideLabel;
        }

        x = true;
outsideLabel:;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,32210,36208);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (6)
        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'finallyLabel')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto finallyLabel;')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'catchlabel')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto catchlabel;')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'trylabel')
          Children(0)

        IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto trylabel;')
          Children(0)

    Next (Regular) Block[B2]
        Entering: {R1} {R2} {R3} {R4}

.try {R1, R2}
{
    .try {R3, R4}
    {
        Block[B2] - Block
            Predecessors: [B1]
            Statements (4)
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'finallyLabel')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto finallyLabel;')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'catchlabel')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto catchlabel;')
                  Children(0)

            Next (Regular) Block[B6]
                Finalizing: {R6}
                Leaving: {R4} {R3} {R2} {R1}
    }
    .catch {R5} (System.Object)
    {
        Block[B3] - Block
            Predecessors (0)
            Statements (4)
                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'finallyLabel')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto finallyLabel;')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'trylabel')
                  Children(0)

                IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto trylabel;')
                  Children(0)

            Next (Regular) Block[B6]
                Finalizing: {R6}
                Leaving: {R5} {R3} {R2} {R1}
    }
}
.finally {R6}
{
    Block[B4] - Block
        Predecessors (0)
        Statements (4)
            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'catchlabel')
              Children(0)

            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto catchlabel;')
              Children(0)

            IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'trylabel')
              Children(0)

            IInvalidOperation (OperationKind.Invalid, Type: null, IsInvalid) (Syntax: 'goto trylabel;')
              Children(0)

        Next (Regular) Block[B6]
            Leaving: {R6} {R1}
}

Block[B5] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'x = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'x = true')
              Left: 
                IParameterReferenceOperation: x (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'x')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B6]
Block[B6] - Exit
    Predecessors: [B2] [B3] [B4] [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,36222,39908);

var 
expectedDiagnostics = new[] {
f_22012_36437_36542(f_22012_36437_36522(f_22012_36437_36492(ErrorCode.ERR_LabelNotFound, "finallyLabel"), "finallyLabel"), 6, 14),
f_22012_36721_36822(f_22012_36721_36802(f_22012_36721_36774(ErrorCode.ERR_LabelNotFound, "catchlabel"), "catchlabel"), 7, 14),
f_22012_36997_37094(f_22012_36997_37074(f_22012_36997_37048(ErrorCode.ERR_LabelNotFound, "trylabel"), "trylabel"), 8, 14),
f_22012_37282_37388(f_22012_37282_37367(f_22012_37282_37337(ErrorCode.ERR_LabelNotFound, "finallyLabel"), "finallyLabel"), 13, 18),
f_22012_37572_37674(f_22012_37572_37653(f_22012_37572_37625(ErrorCode.ERR_LabelNotFound, "catchlabel"), "catchlabel"), 14, 18),
f_22012_37862_37968(f_22012_37862_37947(f_22012_37862_37917(ErrorCode.ERR_LabelNotFound, "finallyLabel"), "finallyLabel"), 20, 18),
f_22012_38148_38246(f_22012_38148_38225(f_22012_38148_38199(ErrorCode.ERR_LabelNotFound, "trylabel"), "trylabel"), 21, 18),
f_22012_38430_38532(f_22012_38430_38511(f_22012_38430_38483(ErrorCode.ERR_LabelNotFound, "catchlabel"), "catchlabel"), 27, 18),
f_22012_38712_38810(f_22012_38712_38789(f_22012_38712_38763(ErrorCode.ERR_LabelNotFound, "trylabel"), "trylabel"), 28, 18),
f_22012_38980_39050(f_22012_38980_39029(ErrorCode.ERR_BadFinallyLeave, "goto"), 29, 13),
f_22012_39184_39250(f_22012_39184_39230(ErrorCode.WRN_UnreachableCode, "x"), 32, 9),
f_22012_39385_39460(f_22012_39385_39440(ErrorCode.WRN_UnreferencedLabel, "trylabel"), 12, 1),
f_22012_39597_39674(f_22012_39597_39654(ErrorCode.WRN_UnreferencedLabel, "catchlabel"), 19, 1),
f_22012_39813_39892(f_22012_39813_39872(ErrorCode.WRN_UnreferencedLabel, "finallyLabel"), 26, 1)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,39924,40018);

f_22012_39924_40017(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,31418,40029);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,31418,40029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,31418,40029);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_49()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,40041,40969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,40188,40345);

var 
source = @"
class C
{
    void F(bool a)
    /*<bind>*/{
        if (a) goto label1;
        goto label1;

label1: return;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,40361,40405);

var 
compilation = f_22012_40379_40404(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,40421,40453);

f_22012_40421_40452(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,40469,40880);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B2]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1*2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,40894,40958);

f_22012_40894_40957(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,40041,40969);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,40041,40969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,40041,40969);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_50()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,40981,42253);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,41128,41378);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
        goto label2;
label1:
        if (a) goto label3;
        goto label3;
label2:
        if (b) goto label1;
        goto label1;

label3: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,41394,41438);

var 
compilation = f_22012_41412_41437(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,41454,41486);

f_22012_41454_41485(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,41502,42164);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B2]
Block[B1] - Block
    Predecessors: [B2*2]
    Statements (0)
    Jump if False (Regular) to Block[B3]
        IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')

    Next (Regular) Block[B3]
Block[B2] - Block
    Predecessors: [B0]
    Statements (0)
    Jump if False (Regular) to Block[B1]
        IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')

    Next (Regular) Block[B1]
Block[B3] - Exit
    Predecessors: [B1*2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,42178,42242);

f_22012_42178_42241(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,40981,42253);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,40981,42253);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,40981,42253);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_51()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,42265,44495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,42412,42621);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
        goto label1;
label1:
        a = true;
        goto label3;
label1:
        b = false;

label3: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,42637,42681);

var 
compilation = f_22012_42655_42680(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,42697,42963);

f_22012_42697_42962(
            compilation, f_22012_42849_42943(f_22012_42849_42923(f_22012_42849_42899(ErrorCode.ERR_DuplicateLabel, "label1"), "label1"), 10, 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,42979,44406);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B2] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = false')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B3]
Block[B3] - Exit
    Predecessors: [B1] [B2]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,44420,44484);

f_22012_44420_44483(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,42265,44495);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,42265,44495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,42265,44495);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_52()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,44507,46735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,44654,44863);

var 
source = @"
class C
{
    void F(bool a, bool b)
    /*<bind>*/{
label1:
        a = true;
        goto label3;
label1:
        b = false;
        goto label1;

label3: ;
    }/*</bind>*/
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,44879,44923);

var 
compilation = f_22012_44897_44922(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,44939,45203);

f_22012_44939_45202(
            compilation, f_22012_45090_45183(f_22012_45090_45164(f_22012_45090_45140(ErrorCode.ERR_DuplicateLabel, "label1"), "label1"), 9, 1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,45219,46646);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0] [B2]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'a = true;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'a = true')
              Left: 
                IParameterReferenceOperation: a (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'a')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: True) (Syntax: 'true')

    Next (Regular) Block[B3]
Block[B2] - Block [UnReachable]
    Predecessors (0)
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'b = false;')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Boolean) (Syntax: 'b = false')
              Left: 
                IParameterReferenceOperation: b (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'b')
              Right: 
                ILiteralOperation (OperationKind.Literal, Type: System.Boolean, Constant: False) (Syntax: 'false')

    Next (Regular) Block[B1]
Block[B3] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,46660,46724);

f_22012_46660_46723(compilation, expectedGraph);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,44507,46735);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,44507,46735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,44507,46735);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_54()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,46747,48303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,46894,47092);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local()
        {
            goto label;
        } 

label:  ;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,47106,47856);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local()]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local()
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (0)
            Next (Error) Block[null]
        Block[B2#0R1] - Exit [UnReachable]
            Predecessors (0)
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,47870,48182);

var 
expectedDiagnostics = new[] {
f_22012_48075_48165(f_22012_48075_48145(f_22012_48075_48122(ErrorCode.ERR_LabelNotFound, "goto"), "label"), 9, 13),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,48198,48292);

f_22012_48198_48291(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,46747,48303);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,46747,48303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,46747,48303);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_55()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,48315,50133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,48462,48704);

string 
source = @"
#pragma warning disable CS8321
struct C
{
    void M()
/*<bind>*/{
        void local(bool input)
        {
            if (input) return;

            goto label;
        } 

label:  ;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,48718,49684);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
        Entering: {R1}

.locals {R1}
{
    Methods: [void local(System.Boolean input)]
    Block[B1] - Block
        Predecessors: [B0]
        Statements (0)
        Next (Regular) Block[B2]
            Leaving: {R1}
    
    {   void local(System.Boolean input)
    
        Block[B0#0R1] - Entry
            Statements (0)
            Next (Regular) Block[B1#0R1]
        Block[B1#0R1] - Block
            Predecessors: [B0#0R1]
            Statements (0)
            Jump if False (Error) to Block[null]
                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

            Next (Regular) Block[B2#0R1]
        Block[B2#0R1] - Exit
            Predecessors: [B1#0R1]
            Statements (0)
    }
}

Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,49698,50012);

var 
expectedDiagnostics = new[] {
f_22012_49904_49995(f_22012_49904_49974(f_22012_49904_49951(ErrorCode.ERR_LabelNotFound, "goto"), "label"), 11, 13),
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,50028,50122);

f_22012_50028_50121(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,48315,50133);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,48315,50133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,48315,50133);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void BranchFlow_56()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22012,50145,53038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,50292,50520);

string 
source = @"
struct C
{
    void M(System.Action<bool> d)
/*<bind>*/{
        d = (bool input) =>
        {
            if (input) return;

            goto label;
        };

label:  ;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,50534,52383);

string 
expectedGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'd = (bool i ... };')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Action<System.Boolean>, IsInvalid) (Syntax: 'd = (bool i ... }')
              Left: 
                IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: System.Action<System.Boolean>) (Syntax: 'd')
              Right: 
                IDelegateCreationOperation (OperationKind.DelegateCreation, Type: System.Action<System.Boolean>, IsInvalid, IsImplicit) (Syntax: '(bool input ... }')
                  Target: 
                    IFlowAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.FlowAnonymousFunction, Type: null, IsInvalid) (Syntax: '(bool input ... }')
                    {
                        Block[B0#A0] - Entry
                            Statements (0)
                            Next (Regular) Block[B1#A0]
                        Block[B1#A0] - Block
                            Predecessors: [B0#A0]
                            Statements (0)
                            Jump if False (Error) to Block[null]
                                IParameterReferenceOperation: input (OperationKind.ParameterReference, Type: System.Boolean) (Syntax: 'input')

                            Next (Regular) Block[B2#A0]
                        Block[B2#A0] - Exit
                            Predecessors: [B1#A0]
                            Statements (0)
                    }

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,52397,52917);

var 
expectedDiagnostics = new[] {
f_22012_52603_52694(f_22012_52603_52673(f_22012_52603_52650(ErrorCode.ERR_LabelNotFound, "goto"), "label"), 10, 13),
f_22012_52829_52901(f_22012_52829_52881(ErrorCode.WRN_UnreferencedLabel, "label"), 13, 1)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22012,52933,53027);

f_22012_52933_53026(source, expectedGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22012,50145,53038);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22012,50145,53038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22012,50145,53038);
}
		}

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_799_824(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 799, 824);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_997_1050(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 997, 1050);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_997_1069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 997, 1069);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_841_1088(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 841, 1088);
return return_v;
}


int
f_22012_1279_1342(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 1279, 1342);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_1756_1781(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 1756, 1781);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_1798_1829(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 1798, 1829);
return return_v;
}


int
f_22012_3405_3468(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 3405, 3468);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_3882_3907(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 3882, 3907);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_3924_3955(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 3924, 3955);
return return_v;
}


int
f_22012_5531_5594(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 5531, 5594);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_6085_6110(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 6085, 6110);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_6127_6158(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 6127, 6158);
return return_v;
}


int
f_22012_7734_7797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 7734, 7797);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_8288_8313(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 8288, 8313);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_8330_8361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 8330, 8361);
return return_v;
}


int
f_22012_9937_10000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 9937, 10000);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_10308_10333(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 10308, 10333);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_10543_10592(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 10543, 10592);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_10543_10616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 10543, 10616);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_10543_10636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 10543, 10636);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_10350_10655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 10350, 10655);
return return_v;
}


int
f_22012_11178_11241(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11178, 11241);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_11571_11596(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11571, 11596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_11806_11855(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11806, 11855);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_11806_11879(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11806, 11879);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_11806_11899(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11806, 11899);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_12063_12112(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 12063, 12112);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_12063_12136(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 12063, 12136);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_12063_12156(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 12063, 12156);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_11613_12175(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 11613, 12175);
return return_v;
}


int
f_22012_12937_13000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 12937, 13000);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_13321_13346(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 13321, 13346);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_13563_13612(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 13563, 13612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_13563_13636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 13563, 13636);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_13563_13656(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 13563, 13656);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_13363_13675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 13363, 13675);
return return_v;
}


int
f_22012_14452_14515(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 14452, 14515);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_14873_14898(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 14873, 14898);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15115_15164(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15115, 15164);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15115_15188(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15115, 15188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15115_15208(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15115, 15208);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15379_15428(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15379, 15428);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15379_15452(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15379, 15452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_15379_15472(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 15379, 15472);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_14915_15491(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 14915, 15491);
return return_v;
}


int
f_22012_16854_16917(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 16854, 16917);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_17271_17296(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 17271, 17296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_17506_17555(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 17506, 17555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_17506_17579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 17506, 17579);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_17506_17599(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 17506, 17599);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_17313_17618(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 17313, 17618);
return return_v;
}


int
f_22012_18395_18458(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 18395, 18458);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_18871_18896(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 18871, 18896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19106_19155(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19106, 19155);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19106_19179(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19106, 19179);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19106_19199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19106, 19199);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19363_19412(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19363, 19412);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19363_19436(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19363, 19436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_19363_19456(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 19363, 19456);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_18913_19475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 18913, 19475);
return return_v;
}


int
f_22012_20838_20901(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 20838, 20901);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_21293_21318(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 21293, 21318);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_21335_21366(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 21335, 21366);
return return_v;
}


int
f_22012_22692_22755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 22692, 22755);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_23057_23082(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 23057, 23082);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_23275_23324(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 23275, 23324);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_23275_23343(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 23275, 23343);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_23099_23362(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 23099, 23362);
return return_v;
}


int
f_22012_23764_23827(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 23764, 23827);
return 0;
}


int
f_22012_26995_27088(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 26995, 27088);
return 0;
}


int
f_22012_30242_30335(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 30242, 30335);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_31198_31250(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 31198, 31250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_31198_31269(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 31198, 31269);
return return_v;
}


int
f_22012_31301_31394(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 31301, 31394);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36437_36492(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36437, 36492);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36437_36522(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36437, 36522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36437_36542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36437, 36542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36721_36774(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36721, 36774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36721_36802(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36721, 36802);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36721_36822(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36721, 36822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36997_37048(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36997, 37048);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36997_37074(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36997, 37074);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_36997_37094(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 36997, 37094);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37282_37337(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37282, 37337);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37282_37367(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37282, 37367);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37282_37388(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37282, 37388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37572_37625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37572, 37625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37572_37653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37572, 37653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37572_37674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37572, 37674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37862_37917(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37862, 37917);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37862_37947(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37862, 37947);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_37862_37968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 37862, 37968);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38148_38199(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38148, 38199);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38148_38225(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38148, 38225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38148_38246(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38148, 38246);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38430_38483(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38430, 38483);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38430_38511(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38430, 38511);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38430_38532(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38430, 38532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38712_38763(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38712, 38763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38712_38789(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38712, 38789);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38712_38810(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38712, 38810);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38980_39029(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38980, 39029);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_38980_39050(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 38980, 39050);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39184_39230(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39184, 39230);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39184_39250(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39184, 39250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39385_39440(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39385, 39440);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39385_39460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39385, 39460);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39597_39654(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39597, 39654);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39597_39674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39597, 39674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39813_39872(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39813, 39872);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_39813_39892(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39813, 39892);
return return_v;
}


int
f_22012_39924_40017(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 39924, 40017);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_40379_40404(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 40379, 40404);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_40421_40452(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 40421, 40452);
return return_v;
}


int
f_22012_40894_40957(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 40894, 40957);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_41412_41437(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 41412, 41437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_41454_41485(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 41454, 41485);
return return_v;
}


int
f_22012_42178_42241(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42178, 42241);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_42655_42680(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42655, 42680);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_42849_42899(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42849, 42899);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_42849_42923(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42849, 42923);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_42849_42943(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42849, 42943);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_42697_42962(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 42697, 42962);
return return_v;
}


int
f_22012_44420_44483(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 44420, 44483);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_44897_44922(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 44897, 44922);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_45090_45140(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 45090, 45140);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_45090_45164(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 45090, 45164);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_45090_45183(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 45090, 45183);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_22012_44939_45202(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 44939, 45202);
return return_v;
}


int
f_22012_46660_46723(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedFlowGraph)
{
VerifyFlowGraphForTest<BlockSyntax>( compilation, expectedFlowGraph);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 46660, 46723);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_48075_48122(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 48075, 48122);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_48075_48145(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 48075, 48145);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_48075_48165(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 48075, 48165);
return return_v;
}


int
f_22012_48198_48291(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 48198, 48291);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_49904_49951(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 49904, 49951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_49904_49974(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 49904, 49974);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_49904_49995(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 49904, 49995);
return return_v;
}


int
f_22012_50028_50121(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 50028, 50121);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_52603_52650(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52603, 52650);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_52603_52673(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52603, 52673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_52603_52694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52603, 52694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_52829_52881(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52829, 52881);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22012_52829_52901(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52829, 52901);
return return_v;
}


int
f_22012_52933_53026(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22012, 52933, 53026);
return 0;
}

}
}
