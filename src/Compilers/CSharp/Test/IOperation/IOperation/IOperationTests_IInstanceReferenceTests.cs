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
        public void IInstanceReferenceExpression_SimpleBaseReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22040,471,1229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,627,839);

string 
source = @"
using System;

public class C1
{
    public virtual void M1() { }
}

public class C2 : C1
{
    public override void M1()
    {
        /*<bind>*/base/*</bind>*/.M1();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,853,1020);

string 
expectedOperationTree = @"
IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: C1) (Syntax: 'base')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,1034,1087);

var 
expectedDiagnostics = DiagnosticDescription.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,1103,1218);

f_22040_1103_1217(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22040,471,1229);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22040,471,1229);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22040,471,1229);
}
		}

[CompilerTrait(CompilerFeature.IOperation)]
        [Fact]
        public void IInstanceReferenceExpression_BaseNoMemberReference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(22040,1241,2213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,1399,1546);

string 
source = @"
using System;

public class C1
{
    public virtual void M1()
    {
        /*<bind>*/base/*</bind>*/.M1();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,1560,1738);

string 
expectedOperationTree = @"
IInstanceReferenceOperation (ReferenceKind: ContainingTypeInstance) (OperationKind.InstanceReference, Type: System.Object) (Syntax: 'base')
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,1752,2071);

var 
expectedDiagnostics = new DiagnosticDescription[] {
f_22040_1961_2055(f_22040_1961_2035(f_22040_1961_2005(ErrorCode.ERR_NoSuchMember, "M1"), "object", "M1"), 8, 35)            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(22040,2087,2202);

f_22040_2087_2201(source, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(22040,1241,2213);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(22040,1241,2213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(22040,1241,2213);
}
		}

int
f_22040_1103_1217(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BaseExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22040, 1103, 1217);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22040_1961_2005(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22040, 1961, 2005);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22040_1961_2035(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22040, 1961, 2035);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_22040_1961_2055(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22040, 1961, 2055);
return return_v;
}


int
f_22040_2087_2201(string
testSrc,string
expectedOperationTree,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyOperationTreeAndDiagnosticsForTest<BaseExpressionSyntax>( testSrc, expectedOperationTree, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(22040, 2087, 2201);
return 0;
}

}
}
