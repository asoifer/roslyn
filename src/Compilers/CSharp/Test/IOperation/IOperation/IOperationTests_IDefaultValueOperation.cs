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
        public void DefaultValueFlow_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22023,471,1568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,598,716);

string 
source = @"
class C
{
    void M(int i)
    /*<bind>*/{
        i = default(int);
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,732,785);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,801,1435);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 'i = default(int);')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: 'i = default(int)')
        Left: 
          IParameterReferenceOperation: i (OperationKind.ParameterReference, Type: System.Int32) (Syntax: 'i')
        Right: 
          IDefaultValueOperation (OperationKind.DefaultValue, Type: System.Int32, Constant: 0) (Syntax: 'default(int)')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,1451,1557);

f_22023_1451_1556(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22023,471,1568);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22023,471,1568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22023,471,1568);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueFlow_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22023,1580,3004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,1707,1823);

string 
source = @"
class C
{
    void M(string s)
    /*<bind>*/{
        s = default;
    }/*</bind>*/
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,1839,1892);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,1908,2871);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: 's = default;')
    Expression: 
      ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.String) (Syntax: 's = default')
        Left: 
          IParameterReferenceOperation: s (OperationKind.ParameterReference, Type: System.String) (Syntax: 's')
        Right: 
          IConversionOperation (TryCast: False, Unchecked) (OperationKind.Conversion, Type: System.String, Constant: null, IsImplicit) (Syntax: 'default')
            Conversion: CommonConversion (Exists: True, IsIdentity: False, IsNumeric: False, IsReference: False, IsUserDefined: False) (MethodSymbol: null)
            Operand: 
              IDefaultValueOperation (OperationKind.DefaultValue, Type: System.String, Constant: null) (Syntax: 'default')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,2887,2993);

f_22023_2887_2992(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22023,1580,3004);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22023,1580,3004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22023,1580,3004);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void DefaultValueFlow_03()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22023,3016,4356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,3143,3326);

string 
source = @"
class C
{
    void M(string s)
    /*<bind>*/{
        M2(default);
    }/*</bind>*/

    static void M2(int x) { }
    static void M2(string x) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,3342,3721);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22023_3602_3705(f_22023_3602_3686(f_22023_3602_3643(ErrorCode.ERR_AmbigCall, "M2"), "C.M2(int)", "C.M2(string)"), 6, 9)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,3737,4223);

string 
expectedOperationTree = @"
IBlockOperation (1 statements) (OperationKind.Block, Type: null, IsInvalid) (Syntax: '{ ... }')
  IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null, IsInvalid) (Syntax: 'M2(default);')
    Expression: 
      IInvalidOperation (OperationKind.Invalid, Type: System.Void, IsInvalid) (Syntax: 'M2(default)')
        Children(1):
            IDefaultValueOperation (OperationKind.DefaultValue, Type: ?) (Syntax: 'default')"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22023,4239,4345);

f_22023_4239_4344(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22023,3016,4356);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22023,3016,4356);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22023,3016,4356);
}
		}

int
f_22023_1451_1556(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 1451, 1556);
return 0;
}


int
f_22023_2887_2992(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 2887, 2992);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22023_3602_3643(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 3602, 3643);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22023_3602_3686(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 3602, 3686);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22023_3602_3705(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 3602, 3705);
return return_v;
}


int
f_22023_4239_4344(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BlockSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22023, 4239, 4344);
return 0;
}

}
}
