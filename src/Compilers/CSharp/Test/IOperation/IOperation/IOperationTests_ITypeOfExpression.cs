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
        public void TestTypeOfExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,471,1109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,599,734);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof(int)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,748,898);

string 
expectedOperationTree = @"
ITypeOfOperation (OperationKind.TypeOf, Type: System.Type) (Syntax: 'typeof(int)')
  TypeOperand: System.Int32
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,912,965);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,981,1098);

f_22071_981_1097(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,471,1109);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,471,1109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,471,1109);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestTypeOfExpression_NonPrimitiveTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,1121,1769);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,1274,1407);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof(C)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,1421,1558);

string 
expectedOperationTree = @"
ITypeOfOperation (OperationKind.TypeOf, Type: System.Type) (Syntax: 'typeof(C)')
  TypeOperand: C
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,1572,1625);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,1641,1758);

f_22071_1641_1757(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,1121,1769);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,1121,1769);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,1121,1769);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestTypeOfExpression_ErrorTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,1781,2849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,1927,2072);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof(UndefinedType)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,2086,2258);

string 
expectedOperationTree = @"
ITypeOfOperation (OperationKind.TypeOf, Type: System.Type, IsInvalid) (Syntax: 'typeof(UndefinedType)')
  TypeOperand: UndefinedType
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,2272,2705);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22071_2573_2689(f_22071_2573_2669(f_22071_2573_2638(ErrorCode.ERR_SingleTypeNameNotFound, "UndefinedType"), "UndefinedType"), 8, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,2721,2838);

f_22071_2721_2837(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,1781,2849);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,1781,2849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,1781,2849);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestTypeOfExpression_IdentifierArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,2861,3784);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,3008,3141);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof(t)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,3155,3303);

string 
expectedOperationTree = @"
ITypeOfOperation (OperationKind.TypeOf, Type: System.Type, IsInvalid) (Syntax: 'typeof(t)')
  TypeOperand: t
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,3317,3640);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22071_3524_3624(f_22071_3524_3604(f_22071_3524_3565(ErrorCode.ERR_BadSKknown, "t"), "t", "variable", "type"), 8, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,3656,3773);

f_22071_3656_3772(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,2861,3784);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,2861,3784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,2861,3784);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestTypeOfExpression_ExpressionArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,3796,5513);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,3943,4105);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof(M2()/*</bind>*/);
    }

    Type M2() => null;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,4119,4383);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'typeof(M2()')
  Children(1):
      ITypeOfOperation (OperationKind.TypeOf, Type: System.Type, IsInvalid) (Syntax: 'typeof(M2')
        TypeOperand: M2
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,4397,5365);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22071_4576_4645(f_22071_4576_4625(ErrorCode.ERR_CloseParenExpected, "("), 8, 32),
f_22071_4770_4838(f_22071_4770_4818(ErrorCode.ERR_SemicolonExpected, ")"), 8, 45),
f_22071_4963_5028(f_22071_4963_5008(ErrorCode.ERR_RbraceExpected, ")"), 8, 45),
f_22071_5255_5349(f_22071_5255_5329(f_22071_5255_5309(ErrorCode.ERR_SingleTypeNameNotFound, "M2"), "M2"), 8, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,5381,5502);

f_22071_5381_5501(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,3796,5513);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,3796,5513);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,3796,5513);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestTypeOfExpression_MissingArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,5525,6377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,5669,5801);

string 
source = @"
using System;

class C
{
    void M(Type t)
    {
        t = /*<bind>*/typeof()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,5815,5962);

string 
expectedOperationTree = @"
ITypeOfOperation (OperationKind.TypeOf, Type: System.Type, IsInvalid) (Syntax: 'typeof()')
  TypeOperand: ?
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,5976,6233);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22071_6154_6217(f_22071_6154_6197(ErrorCode.ERR_TypeExpected, ")"), 8, 30)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,6249,6366);

f_22071_6249_6365(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,5525,6377);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,5525,6377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,5525,6377);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void TypeOfFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22071,6389,7699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,6536,6662);

string 
source = @"
class C
{
    void M(System.Type t)
    /*<bind>*/{
        t = typeof(bool);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,6676,6729);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,6745,7576);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 't = typeof(bool);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Type) (Syntax: 't = typeof(bool)')
              Left: 
                IParameterReferenceOperation: t (OperationKind.ParameterReference, Type: System.Type) (Syntax: 't')
              Right: 
                ITypeOfOperation (OperationKind.TypeOf, Type: System.Type) (Syntax: 'typeof(bool)')
                  TypeOperand: System.Boolean

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22071,7590,7688);

f_22071_7590_7687(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22071,6389,7699);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22071,6389,7699);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22071,6389,7699);
}
		}

int
f_22071_981_1097(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TypeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 981, 1097);
return 0;
}


int
f_22071_1641_1757(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TypeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 1641, 1757);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_2573_2638(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 2573, 2638);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_2573_2669(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 2573, 2669);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_2573_2689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 2573, 2689);
return return_v;
}


int
f_22071_2721_2837(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TypeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 2721, 2837);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_3524_3565(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 3524, 3565);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_3524_3604(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 3524, 3604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_3524_3624(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 3524, 3624);
return return_v;
}


int
f_22071_3656_3772(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TypeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 3656, 3772);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4576_4625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4576, 4625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4576_4645(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4576, 4645);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4770_4818(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4770, 4818);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4770_4838(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4770, 4838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4963_5008(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4963, 5008);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_4963_5028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 4963, 5028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_5255_5309(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 5255, 5309);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_5255_5329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 5255, 5329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_5255_5349(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 5255, 5349);
return return_v;
}


int
f_22071_5381_5501(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 5381, 5501);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_6154_6197(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 6154, 6197);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22071_6154_6217(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 6154, 6217);
return return_v;
}


int
f_22071_6249_6365(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<TypeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 6249, 6365);
return 0;
}


int
f_22071_7590_7687(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22071, 7590, 7687);
return 0;
}

}
}
