// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class Perf : CSharpTestBase
{
[Fact]
        public void Test()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23141,412,1849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23141,1491,1838);

f_23141_1491_1837(f_23141_1491_1543(this, f_23141_1508_1542()), f_23141_1773_1836(ErrorCode.HDN_UnusedUsingDirective, "using nested;"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23141,412,1849);

string
f_23141_1508_1542()
{
var return_v = TestResources.PerfTests.CSPerfTest;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23141, 1508, 1542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23141_1491_1543(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.Perf
this_param,string
source)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23141, 1491, 1543);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23141_1773_1836(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23141, 1773, 1836);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23141_1491_1837(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23141, 1491, 1837);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23141,412,1849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23141,412,1849);
}
		}

public Perf()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23141,361,1856);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23141,361,1856);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23141,361,1856);
}


static Perf()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23141,361,1856);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23141,361,1856);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23141,361,1856);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23141,361,1856);
}
}
