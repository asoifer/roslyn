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
[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,524,1175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,652,786);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof(int)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,800,964);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, Constant: 4) (Syntax: 'sizeof(int)')
  TypeOperand: System.Int32
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,978,1031);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,1047,1164);

f_22063_1047_1163(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,524,1175);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,524,1175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,524,1175);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_NonPrimitiveTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,1187,2509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,1340,1472);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof(C)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,1486,1635);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, IsInvalid) (Syntax: 'sizeof(C)')
  TypeOperand: C
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,1649,2365);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22063_1904_1993(f_22063_1904_1973(f_22063_1904_1954(ErrorCode.ERR_ManagedAddr, "sizeof(C)"), "C"), 8, 23),
f_22063_2259_2349(f_22063_2259_2329(f_22063_2259_2310(ErrorCode.ERR_SizeofUnsafe, "sizeof(C)"), "C"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,2381,2498);

f_22063_2381_2497(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,1187,2509);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,1187,2509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,1187,2509);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_PointerTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,2521,3243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,2669,2813);

string 
source = @"
using System;

class C
{
    unsafe void M(int i)
    {
        i = /*<bind>*/sizeof(void**)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,2827,2982);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32) (Syntax: 'sizeof(void**)')
  TypeOperand: System.Void**
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,2996,3049);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,3065,3232);

f_22063_3065_3231(source, expectedOperationTree, expectedDiagnostics, compilationOptions: TestOptions.UnsafeReleaseDll);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,2521,3243);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,2521,3243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,2521,3243);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_ErrorTypeArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,3255,4727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,3401,3545);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof(UndefinedType)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,3559,3732);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, IsInvalid) (Syntax: 'sizeof(UndefinedType)')
  TypeOperand: UndefinedType
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,3746,4583);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22063_4047_4163(f_22063_4047_4143(f_22063_4047_4112(ErrorCode.ERR_SingleTypeNameNotFound, "UndefinedType"), "UndefinedType"), 8, 30),
f_22063_4453_4567(f_22063_4453_4547(f_22063_4453_4516(ErrorCode.ERR_SizeofUnsafe, "sizeof(UndefinedType)"), "UndefinedType"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,4599,4716);

f_22063_4599_4715(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,3255,4727);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,3255,4727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,3255,4727);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_IdentifierArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,4739,6018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,4886,5018);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof(i)/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,5032,5181);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, IsInvalid) (Syntax: 'sizeof(i)')
  TypeOperand: i
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,5195,5874);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22063_5402_5502(f_22063_5402_5482(f_22063_5402_5443(ErrorCode.ERR_BadSKknown, "i"), "i", "variable", "type"), 8, 30),
f_22063_5768_5858(f_22063_5768_5838(f_22063_5768_5819(ErrorCode.ERR_SizeofUnsafe, "sizeof(i)"), "i"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,5890,6007);

f_22063_5890_6006(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,4739,6018);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,4739,6018);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,4739,6018);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_ExpressionArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,6030,8104);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,6177,6334);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof(M2()/*</bind>*/);
    }

    int M2() => 0;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,6348,6613);

string 
expectedOperationTree = @"
IInvalidOperation (OperationKind.Invalid, Type: ?, IsInvalid) (Syntax: 'sizeof(M2()')
  Children(1):
      ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, IsInvalid) (Syntax: 'sizeof(M2')
        TypeOperand: M2
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,6627,7956);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22063_6806_6875(f_22063_6806_6855(ErrorCode.ERR_CloseParenExpected, "("), 8, 32),
f_22063_7000_7068(f_22063_7000_7048(ErrorCode.ERR_SemicolonExpected, ")"), 8, 45),
f_22063_7193_7258(f_22063_7193_7238(ErrorCode.ERR_RbraceExpected, ")"), 8, 45),
f_22063_7485_7579(f_22063_7485_7559(f_22063_7485_7539(ErrorCode.ERR_SingleTypeNameNotFound, "M2"), "M2"), 8, 30),
f_22063_7849_7940(f_22063_7849_7920(f_22063_7849_7900(ErrorCode.ERR_SizeofUnsafe, "sizeof(M2"), "M2"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,7972,8093);

f_22063_7972_8092(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,6030,8104);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,6030,8104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,6030,8104);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void TestSizeOfExpression_MissingArgument()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,8116,9322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,8260,8391);

string 
source = @"
using System;

class C
{
    void M(int i)
    {
        i = /*<bind>*/sizeof()/*</bind>*/;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,8405,8553);

string 
expectedOperationTree = @"
ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, IsInvalid) (Syntax: 'sizeof()')
  TypeOperand: ?
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,8567,9178);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22063_8745_8808(f_22063_8745_8788(ErrorCode.ERR_TypeExpected, ")"), 8, 30),
f_22063_9073_9162(f_22063_9073_9142(f_22063_9073_9123(ErrorCode.ERR_SizeofUnsafe, "sizeof()"), "?"), 8, 23)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,9194,9311);

f_22063_9194_9310(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,8116,9322);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,8116,9322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,8116,9322);
}
		}

[CompilerTrait(CompilerFeature.IOperation, CompilerFeature.Dataflow)]
        [Fact]
        public void SizeOfFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22063,9334,10654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,9481,9606);

string 
source = @"
public class C
{
    void M(int i)
    /*<bind>*/{
        i = sizeof(int); 
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,9620,9673);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,9689,10531);

string 
expectedFlowGraph = @"
Block[B0] - Entry
    Statements (0)
    Next (Regular) Block[B1]
Block[B1] - Block
    Predecessors: [B0]
    Statements (1)
        IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = sizeof(int);')
          Expression: 
            ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = sizeof(int)')
              Left: 
                IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
              Right: 
                ISizeOfOperation (OperationKind.SizeOf, Type: System.Int32, Constant: 4) (Syntax: 'sizeof(int)')
                  TypeOperand: System.Int32

    Next (Regular) Block[B2]
Block[B2] - Exit
    Predecessors: [B1]
    Statements (0)
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22063,10545,10643);

f_22063_10545_10642(source, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22063,9334,10654);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22063,9334,10654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22063,9334,10654);
}
		}

int
f_22063_1047_1163(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 1047, 1163);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_1904_1954(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 1904, 1954);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_1904_1973(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 1904, 1973);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_1904_1993(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 1904, 1993);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_2259_2310(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 2259, 2310);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_2259_2329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 2259, 2329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_2259_2349(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 2259, 2349);
return return_v;
}


int
f_22063_2381_2497(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 2381, 2497);
return 0;
}


int
f_22063_3065_3231(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
compilationOptions)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics, compilationOptions:compilationOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 3065, 3231);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4047_4112(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4047, 4112);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4047_4143(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4047, 4143);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4047_4163(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4047, 4163);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4453_4516(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4453, 4516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4453_4547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4453, 4547);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_4453_4567(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4453, 4567);
return return_v;
}


int
f_22063_4599_4715(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 4599, 4715);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5402_5443(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5402, 5443);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5402_5482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5402, 5482);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5402_5502(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5402, 5502);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5768_5819(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5768, 5819);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5768_5838(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5768, 5838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_5768_5858(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5768, 5858);
return return_v;
}


int
f_22063_5890_6006(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 5890, 6006);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_6806_6855(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 6806, 6855);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_6806_6875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 6806, 6875);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7000_7048(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7000, 7048);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7000_7068(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7000, 7068);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7193_7238(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7193, 7238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7193_7258(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7193, 7258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7485_7539(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7485, 7539);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7485_7559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7485, 7559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7485_7579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7485, 7579);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7849_7900(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7849, 7900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7849_7920(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7849, 7920);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_7849_7940(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7849, 7940);
return return_v;
}


int
f_22063_7972_8092(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<InvocationExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 7972, 8092);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_8745_8788(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 8745, 8788);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_8745_8808(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 8745, 8808);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_9073_9123(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 9073, 9123);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_9073_9142(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 9073, 9142);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22063_9073_9162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 9073, 9162);
return return_v;
}


int
f_22063_9194_9310(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<SizeOfExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 9194, 9310);
return 0;
}


int
f_22063_10545_10642(string
testSrc,string
expectedFlowGraph,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyFlowGraphAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedFlowGraph, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22063, 10545, 10642);
return 0;
}

}
}
