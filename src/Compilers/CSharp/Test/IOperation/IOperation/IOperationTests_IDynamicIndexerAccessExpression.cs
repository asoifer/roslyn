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
        public void DynamicIndexerAccessExpression_DynamicArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,471,1428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,625,784);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        var x = /*<bind>*/c[d]/*</bind>*/;
    }

    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,798,1210);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,1224,1277);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,1293,1417);

f_22026_1293_1416(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,471,1428);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,471,1428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,471,1428);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_MultipleApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,1440,2444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,1604,1800);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        var x = /*<bind>*/c[d]/*</bind>*/;
    }

    public int this[int i] => 0;

    public int this[long i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,1814,2226);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,2240,2293);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,2309,2433);

f_22026_2309_2432(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,1440,2444);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,1440,2444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,1440,2444);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_MultipleArgumentsAndApplicableSymbols()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,2456,3623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,2632,2874);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        char ch = 'c';
        var x = /*<bind>*/c[d, ch]/*</bind>*/;
    }

    public int this[int i, char ch] => 0;

    public int this[long i, char ch] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,2888,3405);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d, ch]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      ILocalReferenceOperation: ch (OperationKind.LocalReference, Type: System.Char) (Syntax: 'ch')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,3419,3472);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,3488,3612);

f_22026_3488_3611(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,2456,3623);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,2456,3623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,2456,3623);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_ArgumentNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,3635,4803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,3787,4022);

string 
source = @"
class C
{
    void M(C c, dynamic d, dynamic e)
    {
        var x = /*<bind>*/c[i: d, ch: e]/*</bind>*/;
    }

    public int this[int i, char ch] => 0;

    public int this[long i, char ch] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,4036,4585);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[i: d, ch: e]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(2):
    ""i""
    ""ch""
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,4599,4652);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,4668,4792);

f_22026_4668_4791(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,3635,4803);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,3635,4803);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,3635,4803);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_ArgumentRefKinds()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,4815,6218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,4970,5170);

string 
source = @"
class C
{
    void M(C c, dynamic d, dynamic e)
    {
        var x = /*<bind>*/c[i: d, ch: ref e]/*</bind>*/;
    }

    public int this[int i, ref dynamic ch] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,5184,5757);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[i: d, ch: ref e]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
      IParameterReferenceOperation: e (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'e')
  ArgumentNames(2):
    ""i""
    ""ch""
  ArgumentRefKinds(2):
    None
    Ref
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,5771,6067);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22026_5983_6051(f_22026_5983_6031(ErrorCode.ERR_IllegalRefParam, "ref"), 9, 28)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,6083,6207);

f_22026_6083_6206(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,4815,6218);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,4815,6218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,4815,6218);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_WithDynamicReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,6230,7168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,6388,6513);

string 
source = @"
class C
{
    void M(dynamic d, int i)
    {
        var x = /*<bind>*/d[i]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,6527,6950);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'd[i]')
  Expression: 
    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,6964,7017);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,7033,7157);

f_22026_7033_7156(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,6230,7168);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,6230,7168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,6230,7168);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_WithDynamicMemberReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,7180,8340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,7344,7472);

string 
source = @"
class C
{
    void M(dynamic c, int i)
    {
        var x = /*<bind>*/c.M2[i]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,7486,8122);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c.M2[i]')
  Expression: 
    IDynamicMemberReferenceOperation (Member Name: ""M2"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'c.M2')
      Type Arguments(0)
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,8136,8189);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,8205,8329);

f_22026_8205_8328(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,7180,8340);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,7180,8340);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,7180,8340);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_WithDynamicTypedMemberReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,8352,9459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,8521,8669);

string 
source = @"
class C
{
    dynamic M2 = null;

    void M(C c, int i)
    {
        var x = /*<bind>*/c.M2[i]/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,8683,9241);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c.M2[i]')
  Expression: 
    IFieldReferenceOperation: dynamic C.M2 (OperationKind.FieldReference, Type: dynamic) (Syntax: 'c.M2')
      Instance Receiver: 
        IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(1):
      IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,9255,9308);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,9324,9448);

f_22026_9324_9447(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,8352,9459);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,8352,9459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,8352,9459);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_AllFields()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,9471,11129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,9619,9866);

string 
source = @"
class C
{
    void M(C c, dynamic d)
    {
        int i = 0;
        var x = /*<bind>*/c[ref i, c: d]/*</bind>*/;
    }

    public int this[ref int i, char c] => 0;
    public int this[ref int i, long c] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,9880,10448);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[ref i, c: d]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      ILocalReferenceOperation: i (OperationKind.LocalReference, Type: System.Int32) (Syntax: 'i')
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
  ArgumentNames(2):
    ""null""
    ""c""
  ArgumentRefKinds(2):
    Ref
    None
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,10462,10978);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22026_10670_10739(f_22026_10670_10718(ErrorCode.ERR_IllegalRefParam, "ref"), 10, 21),
f_22026_10893_10962(f_22026_10893_10941(ErrorCode.ERR_IllegalRefParam, "ref"), 11, 21)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,10994,11118);

f_22026_10994_11117(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,9471,11129);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,9471,11129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,9471,11129);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_ErrorBadDynamicMethodArgLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,11141,12970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,11310,11536);

string 
source = @"
using System;

class C
{
    public void M(C c)
    {
        dynamic y = null;
        var x = /*<bind>*/c[delegate { }, y]/*</bind>*/;
    }

    public int this[Action a, Action y] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,11550,12376);

string 
expectedOperationTree = @"
IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic, IsInvalid) (Syntax: 'c[delegate { }, y]')
  Expression: 
    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
  Arguments(2):
      IAnonymousFunctionOperation (Symbol: lambda expression) (OperationKind.AnonymousFunction, Type: null, IsInvalid) (Syntax: 'delegate { }')
        IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ }')
          IReturnOperation (OperationKind.Return, Type: null, IsInvalid, IsImplicit) (Syntax: '{ }')
            ReturnedValue: 
              null
      ILocalReferenceOperation: y (OperationKind.LocalReference, Type: dynamic) (Syntax: 'y')
  ArgumentNames(0)
  ArgumentRefKinds(0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,12390,12819);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22026_12716_12803(f_22026_12716_12783(ErrorCode.ERR_BadDynamicMethodArgLambda, "delegate { }"), 9, 29)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,12835,12959);

f_22026_12835_12958(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,11141,12970);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,11141,12970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,11141,12970);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DynamicIndexerAccessExpression_OverloadResolutionFailure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,12982,14242);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,13146,13377);

string 
source = @"
using System;

class C
{
    void M(C c, dynamic d)
    {
        var x = /*<bind>*/c[d]/*</bind>*/;
    }

    public int this[int i, int j] => 0;
    public int this[int i, int j, int k] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,13391,13757);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: System.Int32, IsInvalid) (Syntax: 'c[d]')
  Children(2):
      IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C, IsInvalid) (Syntax: 'c')
      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic, IsInvalid) (Syntax: 'd')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,13771,14091);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22026_13983_14075(f_22026_13983_14055(f_22026_13983_14028(ErrorCode.ERR_BadArgCount, "c[d]"), "this", "1"), 8, 27)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,14107,14231);

f_22026_14107_14230(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,12982,14242);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,12982,14242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,12982,14242);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_NoControlFlow()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,14254,15940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,14422,14588);

string 
source = @"
class C
{
    void M(C c, dynamic d, dynamic p)
    /*<bind>*/{
        p = c[d];
    }/*</bind>*/

    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,14602,15748);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[d];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = c[d]')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')
              Right: 
                IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d]')
                  Expression: 
                    IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,15762,15815);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,15831,15929);

f_22026_15831_15928(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,14254,15940);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,14254,15940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,14254,15940);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_NullReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,15952,18358);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,16119,16287);

string 
source = @"
class C
{
    void M(dynamic d, dynamic p)
    /*<bind>*/{
        p = C[d];
    }/*</bind>*/

    public static int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,16301,17612);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'p = C[d];')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic, IsInvalid) (Syntax: 'p = C[d]')
              Left: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')
              Right: 
                IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic, IsInvalid) (Syntax: 'C[d]')
                  Expression: 
                    IInvalidOperation (OperationKind.Invalid, Type: C, IsInvalid, IsImplicit) (Syntax: 'C')
                      Children(1):
                          IOperation:  (OperationKind.None, Type: null, IsInvalid) (Syntax: 'C')
                  Arguments(1):
                      IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                  ArgumentNames(0)
                  ArgumentRefKinds(0)

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,17628,18233);

var 
expectedDiagnostics = new DiagnosticDescription[] {                
f_22026_17875_17966(f_22026_17875_17946(f_22026_17875_17922(ErrorCode.ERR_BadMemberFlag, "this"), "static"), 9, 23),
f_22026_18127_18217(f_22026_18127_18197(f_22026_18127_18170(ErrorCode.ERR_BadSKunknown, "C"), "C", "type"), 6, 13)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,18249,18347);

f_22026_18249_18346(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,15952,18358);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,15952,18358);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,15952,18358);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,18370,22250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,18546,18728);

string 
source = @"
class C
{
    void M(C c1, C c2, dynamic d, dynamic p)
    /*<bind>*/{
        p = (c1 ?? c2)[d];
    }/*</bind>*/

    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,18742,22058);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (c1 ?? c2)[d];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = (c1 ?? c2)[d]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '(c1 ?? c2)[d]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                      Arguments(1):
                          IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,22072,22125);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,22141,22239);

f_22026_22141_22238(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,18370,22250);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,18370,22250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,18370,22250);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,22262,26420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,22438,22624);

string 
source = @"
class C
{
    void M(C c, dynamic d1, dynamic d2, dynamic p)
    /*<bind>*/{
        p = c[d1 ?? d2];
    }/*</bind>*/

    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,22638,26228);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[d1 ?? d2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = c[d1 ?? d2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d1 ?? d2]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(1):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,26242,26295);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,26311,26409);

f_22026_26311_26408(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,22262,26420);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,22262,26420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,22262,26420);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInReceiverAndArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,26432,32034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,26619,26821);

string 
source = @"
class C
{
    void M(C c1, C c2, dynamic d1, dynamic d2, dynamic p)
    /*<bind>*/{
        p = (c1 ?? c2)[d1 ?? d2];
    }/*</bind>*/

    public int this[int i] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,26835,31842);

string 
expectedFlowGraph = @"
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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [1]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IParameterReferenceOperation: c1 (OperationKind.ParameterReference, Type: C) (Syntax: 'c1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'c1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c1')
                  Value: 
                    IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1')

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c2')
              Value: 
                IParameterReferenceOperation: c2 (OperationKind.ParameterReference, Type: C) (Syntax: 'c2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [3]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = (c1 ??  ... [d1 ?? d2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = (c1 ?? c2)[d1 ?? d2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: '(c1 ?? c2)[d1 ?? d2]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c1 ?? c2')
                      Arguments(1):
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,31856,31909);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,31925,32023);

f_22026_31925_32022(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,26432,32034);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,26432,32034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,26432,32034);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInFirstArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,32046,36363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,32227,32430);

string 
source = @"
class C
{
    void M(C c, dynamic d1, dynamic d2, dynamic p, int j)
    /*<bind>*/{
        p = c[d1 ?? d2, j];
    }/*</bind>*/

    public int this[int i, int j] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,32444,36171);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[d1 ?? d2, j];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = c[d1 ?? d2, j]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[d1 ?? d2, j]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(2):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                          IParameterReferenceOperation: j (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,36185,36238);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,36254,36352);

f_22026_36254_36351(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,32046,36363);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,32046,36363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,32046,36363);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInSecondArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,36375,40960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,36557,36760);

string 
source = @"
class C
{
    void M(C c, dynamic d1, dynamic d2, dynamic p, int j)
    /*<bind>*/{
        p = c[j, d1 ?? d2];
    }/*</bind>*/

    public int this[int i, int j] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,36774,40768);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

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
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B5]
                Leaving: {R2}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B5]
    Block[B5] - Block
        Predecessors: [B3] [B4]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[j, d1 ?? d2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = c[j, d1 ?? d2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[j, d1 ?? d2]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(2):
                          IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j')
                          IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,40782,40835);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,40851,40949);

f_22026_40851_40948(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,36375,40960);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,36375,40960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,36375,40960);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowInMultipleArguments()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,40972,47274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,41157,41377);

string 
source = @"
class C
{
    void M(C c, dynamic d1, dynamic d2, dynamic p, int? j1, int j2)
    /*<bind>*/{
        p = c[j1 ?? j2, d1 ?? d2];
    }/*</bind>*/

    public int this[int i, int j] => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,41391,47082);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'c')
              Value: 
                IParameterReferenceOperation: c (OperationKind.ParameterReference, Type: C) (Syntax: 'c')

        Next (Regular) Block[B2]
            Entering: {R2}

    .locals {R2}
    {
        CaptureIds: [2]
        Block[B2] - Block
            Predecessors: [B1]
            Statements (1)
                IFlowCaptureOperation: 2 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IParameterReferenceOperation: j1 (OperationKind.ParameterReference, Type: System.Int32?) (Syntax: 'j1')

            Jump if True (Regular) to Block[B4]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'j1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                Leaving: {R2}

            Next (Regular) Block[B3]
        Block[B3] - Block
            Predecessors: [B2]
            Statements (1)
                IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j1')
                  Value: 
                    IInvocationOperation ( System.Int32 System.Int32?.GetValueOrDefault()) (OperationKind.Invocation, Type: System.Int32, IsImplicit) (Syntax: 'j1')
                      Instance Receiver: 
                        IFlowCaptureReferenceOperation: 2 (OperationKind.FlowCaptureReference, Type: System.Int32?, IsImplicit) (Syntax: 'j1')
                      Arguments(0)

            Next (Regular) Block[B5]
                Leaving: {R2}
                Entering: {R3}
    }

    Block[B4] - Block
        Predecessors: [B2]
        Statements (1)
            IFlowCaptureOperation: 3 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'j2')
              Value: 
                IParameterReferenceOperation: j2 (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'j2')

        Next (Regular) Block[B5]
            Entering: {R3}

    .locals {R3}
    {
        CaptureIds: [4]
        Block[B5] - Block
            Predecessors: [B3] [B4]
            Statements (1)
                IFlowCaptureOperation: 4 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IParameterReferenceOperation: d1 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd1')

            Jump if True (Regular) to Block[B7]
                IIsNullOperation (OperationKind.IsNull, Type: System.Boolean, IsImplicit) (Syntax: 'd1')
                  Operand: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')
                Leaving: {R3}

            Next (Regular) Block[B6]
        Block[B6] - Block
            Predecessors: [B5]
            Statements (1)
                IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd1')
                  Value: 
                    IFlowCaptureReferenceOperation: 4 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1')

            Next (Regular) Block[B8]
                Leaving: {R3}
    }

    Block[B7] - Block
        Predecessors: [B5]
        Statements (1)
            IFlowCaptureOperation: 5 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd2')
              Value: 
                IParameterReferenceOperation: d2 (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd2')

        Next (Regular) Block[B8]
    Block[B8] - Block
        Predecessors: [B6] [B7]
        Statements (1)
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = c[j1 ?? ...  d1 ?? d2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = c[j1 ?? ... , d1 ?? d2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'c[j1 ?? j2, d1 ?? d2]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: C, IsImplicit) (Syntax: 'c')
                      Arguments(2):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'j1 ?? j2')
                          IFlowCaptureReferenceOperation: 5 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd1 ?? d2')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B9]
            Leaving: {R1}
}

Block[B9] - Exit
    Predecessors: [B8]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,47096,47149);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,47165,47263);

f_22026_47165_47262(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,40972,47274);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,40972,47274);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,40972,47274);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void DynamicIndexerAccess_ControlFlowWithDynamicReceiver()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22026,47286,51961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,47471,47622);

string 
source = @"
class C
{
    void M(dynamic d, int? i1, int i2, dynamic p)
    /*<bind>*/{
        p = d.M[i1 ?? i2];
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,47636,51769);

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
            IFlowCaptureOperation: 0 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'p')
              Value: 
                IParameterReferenceOperation: p (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'p')

            IFlowCaptureOperation: 1 (OperationKind.FlowCapture, Type: null, IsImplicit) (Syntax: 'd.M')
              Value: 
                IDynamicMemberReferenceOperation (Member Name: ""M"", Containing Type: null) (OperationKind.DynamicMemberReference, Type: dynamic) (Syntax: 'd.M')
                  Type Arguments(0)
                  Instance Receiver: 
                    IParameterReferenceOperation: d (OperationKind.ParameterReference, Type: dynamic) (Syntax: 'd')

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
            IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'p = d.M[i1 ?? i2];')
              Expression: 
                ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: dynamic) (Syntax: 'p = d.M[i1 ?? i2]')
                  Left: 
                    IFlowCaptureReferenceOperation: 0 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'p')
                  Right: 
                    IDynamicIndexerAccessOperation (OperationKind.DynamicIndexerAccess, Type: dynamic) (Syntax: 'd.M[i1 ?? i2]')
                      Expression: 
                        IFlowCaptureReferenceOperation: 1 (OperationKind.FlowCaptureReference, Type: dynamic, IsImplicit) (Syntax: 'd.M')
                      Arguments(1):
                          IFlowCaptureReferenceOperation: 3 (OperationKind.FlowCaptureReference, Type: System.Int32, IsImplicit) (Syntax: 'i1 ?? i2')
                      ArgumentNames(0)
                      ArgumentRefKinds(0)

        Next (Regular) Block[B6]
            Leaving: {R1}
}

Block[B6] - Exit
    Predecessors: [B5]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,51783,51836);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22026,51852,51950);

f_22026_51852_51949(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22026,47286,51961);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22026,47286,51961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22026,47286,51961);
}
		}

int
f_22026_1293_1416(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 1293, 1416);
return 0;
}


int
f_22026_2309_2432(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 2309, 2432);
return 0;
}


int
f_22026_3488_3611(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 3488, 3611);
return 0;
}


int
f_22026_4668_4791(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 4668, 4791);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_5983_6031(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 5983, 6031);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_5983_6051(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 5983, 6051);
return return_v;
}


int
f_22026_6083_6206(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 6083, 6206);
return 0;
}


int
f_22026_7033_7156(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 7033, 7156);
return 0;
}


int
f_22026_8205_8328(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 8205, 8328);
return 0;
}


int
f_22026_9324_9447(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 9324, 9447);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_10670_10718(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 10670, 10718);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_10670_10739(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 10670, 10739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_10893_10941(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 10893, 10941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_10893_10962(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 10893, 10962);
return return_v;
}


int
f_22026_10994_11117(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 10994, 11117);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_12716_12783(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 12716, 12783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_12716_12803(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 12716, 12803);
return return_v;
}


int
f_22026_12835_12958(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 12835, 12958);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_13983_14028(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 13983, 14028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_13983_14055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 13983, 14055);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_13983_14075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 13983, 14075);
return return_v;
}


int
f_22026_14107_14230(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ElementAccessExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 14107, 14230);
return 0;
}


int
f_22026_15831_15928(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 15831, 15928);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_17875_17922(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 17875, 17922);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_17875_17946(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 17875, 17946);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_17875_17966(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 17875, 17966);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_18127_18170(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 18127, 18170);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_18127_18197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 18127, 18197);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22026_18127_18217(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 18127, 18217);
return return_v;
}


int
f_22026_18249_18346(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 18249, 18346);
return 0;
}


int
f_22026_22141_22238(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 22141, 22238);
return 0;
}


int
f_22026_26311_26408(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 26311, 26408);
return 0;
}


int
f_22026_31925_32022(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 31925, 32022);
return 0;
}


int
f_22026_36254_36351(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 36254, 36351);
return 0;
}


int
f_22026_40851_40948(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 40851, 40948);
return 0;
}


int
f_22026_47165_47262(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 47165, 47262);
return 0;
}


int
f_22026_51852_51949(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22026, 51852, 51949);
return 0;
}

}
}
