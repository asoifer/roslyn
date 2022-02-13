// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
[CompilerTrait(CompilerFeature.IOperation)]
    public partial class IOperationTests : SemanticModelTestBase
{
[Fact]
        public void DiscardExpression_AsAssignment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22011,520,1091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,605,729);

string 
source = @"
class C
{
    int P { get; }

    void M()
    {
        /*<bind>*/_/*</bind>*/ = P;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,743,882);

string 
expectedOperationTree = @"
IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,896,949);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,965,1080);

f_22011_965_1079(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22011,520,1091);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22011,520,1091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22011,520,1091);
}
		}

[Fact]
        public void DiscardExpression_AsAssignment_EntireStatement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22011,1103,2262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,1204,1328);

string 
source = @"
class C
{
    int P { get; }

    void M()
    {
        /*<bind>*/_ = P;/*</bind>*/
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,1342,2048);

string 
expectedOperationTree = @"
IExpressionStatementOperation (OperationKind.ExpressionStatement, Type: null) (Syntax: '_ = P;')
  Expression: 
    ISimpleAssignmentOperation (OperationKind.SimpleAssignment, Type: System.Int32) (Syntax: '_ = P')
      Left: 
        IDiscardOperation (Symbol: System.Int32 _) (OperationKind.Discard, Type: System.Int32) (Syntax: '_')
      Right: 
        IPropertyReferenceOperation: System.Int32 C.P { get; } (OperationKind.PropertyReference, Type: System.Int32) (Syntax: 'P')
          Instance Receiver: 
            IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C, IsImplicit) (Syntax: 'P')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,2062,2115);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22011,2131,2251);

f_22011_2131_2250(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22011,1103,2262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22011,1103,2262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22011,1103,2262);
}
		}

int
f_22011_965_1079(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<IdentifierNameSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22011, 965, 1079);
return 0;
}


int
f_22011_2131_2250(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<ExpressionStatementSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22011, 2131, 2250);
return 0;
}

}
}
