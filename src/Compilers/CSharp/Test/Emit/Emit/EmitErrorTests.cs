// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.UnitTests.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public class EmitErrorTests : EmitMetadataTestBase
{
[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadConstantInOtherAssemblyUsedByField()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,900,1731);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1084,1158);

string 
source1 = @"
public class A
{
    public const int x = x;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1172,1218);

var 
compilation1 = f_23113_1191_1217(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1232,1476);

f_23113_1232_1475(            compilation1, f_23113_1401_1474(f_23113_1401_1453(CSharp.ErrorCode.ERR_CircConstValue, "x"), "A.x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1492,1661);

string 
source2 = @"
public class B
{
    public const int y = A.x;

    public static void Main()
    {
        System.Console.WriteLine(""Hello"");
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1675,1720);

f_23113_1675_1719(source2, compilation1);
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,900,1731);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_1191_1217(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 1191, 1217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_1401_1453(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 1401, 1453);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_1401_1474(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 1401, 1474);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_1232_1475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 1232, 1475);
return return_v;
}


int
f_23113_1675_1719(string
source2,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation1,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyEmitDiagnostics( source2, compilation1, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 1675, 1719);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,900,1731);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,900,1731);
}
		}

[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadConstantInOtherAssemblyUsedByLocal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,1743,2758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,1927,2001);

string 
source1 = @"
public class A
{
    public const int x = x;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,2015,2061);

var 
compilation1 = f_23113_2034_2060(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,2075,2319);

f_23113_2075_2318(            compilation1, f_23113_2244_2317(f_23113_2244_2296(CSharp.ErrorCode.ERR_CircConstValue, "x"), "A.x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,2335,2499);

string 
source2 = @"
public class B
{
    public static void Main()
    {
        const int y = A.x;
        System.Console.WriteLine(""Hello"");
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,2513,2747);

f_23113_2513_2746(source2, compilation1, f_23113_2676_2745(f_23113_2676_2726(ErrorCode.WRN_UnreferencedVarAssg, "y"), "y"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,1743,2758);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_2034_2060(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2034, 2060);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_2244_2296(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2244, 2296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_2244_2317(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2244, 2317);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_2075_2318(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2075, 2318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_2676_2726(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2676, 2726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_2676_2745(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2676, 2745);
return return_v;
}


int
f_23113_2513_2746(string
source2,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation1,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyEmitDiagnostics( source2, compilation1, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 2513, 2746);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,1743,2758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,1743,2758);
}
		}

[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadDefaultArgumentInOtherAssembly()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,2770,3752);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,2950,3078);

string 
source1 = @"
public class A
{
    public const int x = x;

    public static int Goo(int y = x) { return y; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,3092,3138);

var 
compilation1 = f_23113_3111_3137(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,3152,3396);

f_23113_3152_3395(            compilation1, f_23113_3321_3394(f_23113_3321_3373(CSharp.ErrorCode.ERR_CircConstValue, "x"), "A.x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,3412,3546);

string 
source2 = @"
public class B
{
    public static void Main()
    {
        System.Console.WriteLine(A.Goo());
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,3560,3741);

var 
compilation2 = f_23113_3579_3740(this, source2, new[] { f_23113_3648_3692(compilation1)}, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,2770,3752);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_3111_3137(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3111, 3137);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_3321_3373(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3321, 3373);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_3321_3394(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3321, 3394);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_3152_3395(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3152, 3395);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23113_3648_3692(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3648, 3692);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23113_3579_3740(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitErrorTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 3579, 3740);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,2770,3752);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,2770,3752);
}
		}

[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadDefaultArgumentInOtherAssembly_Decimal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,3764,4759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,3952,4092);

string 
source1 = @"
public class A
{
    public const decimal x = x;

    public static decimal Goo(decimal y = x) { return y; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,4106,4152);

var 
compilation1 = f_23113_4125_4151(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,4166,4403);

f_23113_4166_4402(            compilation1, f_23113_4335_4401(f_23113_4335_4380(ErrorCode.ERR_CircConstValue, "x"), "A.x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,4419,4553);

string 
source2 = @"
public class B
{
    public static void Main()
    {
        System.Console.WriteLine(A.Goo());
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,4567,4748);

var 
compilation2 = f_23113_4586_4747(this, source2, new[] { f_23113_4655_4699(compilation1)}, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,3764,4759);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_4125_4151(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4125, 4151);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_4335_4380(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4335, 4380);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_4335_4401(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4335, 4401);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_4166_4402(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4166, 4402);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23113_4655_4699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4655, 4699);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23113_4586_4747(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitErrorTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 4586, 4747);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,3764,4759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,3764,4759);
}
		}

[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadDefaultArgumentInOtherAssembly_UserDefinedType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,4771,6327);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,4967,5154);

string 
source1 = @"
public struct S 
{
    public override string ToString() { return ""S::ToString""; }
}

public class A
{
    public static S Goo(S p = 42) { return p; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,5168,5214);

var 
compilation1 = f_23113_5187_5213(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,5228,5607);

f_23113_5228_5606(            compilation1, f_23113_5501_5605(f_23113_5501_5585(f_23113_5501_5559(ErrorCode.ERR_NoConversionForDefaultParam, "p"), "int", "S"), 9, 27));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,5623,5757);

string 
source2 = @"
public class B
{
    public static void Main()
    {
        System.Console.WriteLine(A.Goo());
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,5773,5954);

var 
compilation2 = f_23113_5792_5953(this, source2, new[] { f_23113_5861_5905(compilation1)}, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,5968,6316);

f_23113_5968_6315(            compilation2, "B.Main()", @"
{
  // Code size       25 (0x19)
  .maxstack  1
  .locals init (S V_0)
  IL_0000:  ldloca.s   V_0
  IL_0002:  initobj    ""S""
  IL_0008:  ldloc.0
  IL_0009:  call       ""S A.Goo(S)""
  IL_000e:  box        ""S""
  IL_0013:  call       ""void System.Console.WriteLine(object)""
  IL_0018:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,4771,6327);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_5187_5213(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5187, 5213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_5501_5559(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5501, 5559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_5501_5585(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5501, 5585);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_5501_5605(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5501, 5605);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_5228_5606(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5228, 5606);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23113_5861_5905(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5861, 5905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23113_5792_5953(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitErrorTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5792, 5953);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23113_5968_6315(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 5968, 6315);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,4771,6327);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,4771,6327);
}
		}

[WorkItem(543039, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543039")]
        [Fact]
        public void BadReturnTypeInOtherAssembly()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,6339,7218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,6514,6609);

string 
source1 = @"
public class A
{
    public static Missing Goo() { return null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,6623,6669);

var 
compilation1 = f_23113_6642_6668(source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,6683,6978);

f_23113_6683_6977(            compilation1, f_23113_6892_6976(f_23113_6892_6951(ErrorCode.ERR_SingleTypeNameNotFound, "Missing"), "Missing"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,6994,7148);

string 
source2 = @"
public class B
{
    public static void Main()
    {
        var f = A.Goo();
        System.Console.WriteLine(f);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7162,7207);

f_23113_7162_7206(source2, compilation1);
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,6339,7218);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_6642_6668(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 6642, 6668);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_6892_6951(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 6892, 6951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_6892_6976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 6892, 6976);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_6683_6977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 6683, 6977);
return return_v;
}


int
f_23113_7162_7206(string
source2,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation1,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expectedDiagnostics)
{
VerifyEmitDiagnostics( source2, compilation1, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7162, 7206);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,6339,7218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,6339,7218);
}
		}

private static void VerifyEmitDiagnostics(string source2, CSharpCompilation compilation1, params DiagnosticDescription[] expectedDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23113,7230,8510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7396,7516);

var 
compilation2 = f_23113_7415_7515(source2, new MetadataReference[] { f_23113_7468_7512(compilation1)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7530,7582);

f_23113_7530_7581(            compilation2, expectedDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7598,8199);
using(var 
executableStream = f_23113_7628_7646()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7680,7729);

var 
result = f_23113_7693_7728(compilation2, executableStream)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7747,7776);

f_23113_7747_7775(f_23113_7760_7774(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,7796,8184);

result.Diagnostics.Verify(f_23113_7822_8182(f_23113_7822_8172(expectedDiagnostics, new[]
                {
f_23113_8014_8152(f_23113_8014_8057(ErrorCode.ERR_ModuleEmitFailure), f_23113_8072_8097(compilation2), "Unable to determine specific cause of the failure.")                })));
DynAbs.Tracing.TraceSender.TraceExitUsing(23113,7598,8199);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8215,8499);
using(var 
executableStream = f_23113_8245_8263()
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8297,8392);

var 
result = f_23113_8310_8391(compilation2, executableStream, options: f_23113_8355_8390(metadataOnly: true))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8410,8438);

f_23113_8410_8437(f_23113_8422_8436(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8456,8484);

result.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitUsing(23113,8215,8499);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23113,7230,8510);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23113_7468_7512(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7468, 7512);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_7415_7515(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7415, 7515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_7530_7581(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7530, 7581);
return return_v;
}


System.IO.MemoryStream
f_23113_7628_7646()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7628, 7646);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23113_7693_7728(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7693, 7728);
return return_v;
}


bool
f_23113_7760_7774(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23113, 7760, 7774);
return return_v;
}


int
f_23113_7747_7775(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7747, 7775);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_8014_8057(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8014, 8057);
return return_v;
}


string?
f_23113_8072_8097(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23113, 8072, 8097);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_8014_8152(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8014, 8152);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
f_23113_7822_8172(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
first,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
second)
{
var return_v = first.Concat<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>( (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>)second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7822, 8172);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
f_23113_7822_8182(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 7822, 8182);
return return_v;
}


System.IO.MemoryStream
f_23113_8245_8263()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8245, 8263);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23113_8355_8390(bool
metadataOnly)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions( metadataOnly:metadataOnly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8355, 8390);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23113_8310_8391(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8310, 8391);
return return_v;
}


bool
f_23113_8422_8436(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23113, 8422, 8436);
return return_v;
}


int
f_23113_8410_8437(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8410, 8437);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,7230,8510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,7230,8510);
}
		}

[Fact, WorkItem(530211, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/530211")]
        public void ModuleNameMismatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,8522,9710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8677,8712);

var 
moduleSource = "class Test {}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8726,8846);

var 
netModule = f_23113_8742_8845(moduleSource, options: TestOptions.ReleaseModule, assemblyName: "ModuleNameMismatch")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8862,8939);

var 
moduleMetadata = f_23113_8883_8938(f_23113_8914_8937(netModule))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,8955,8989);

var 
source = @"class Module1 { }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9005,9158);

var 
compilationOK = f_23113_9025_9157(source, new MetadataReference[] { f_23113_9077_9154(moduleMetadata, filePath: @"R:\A\B\ModuleNameMismatch.netmodule")})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9174,9206);

f_23113_9174_9205(this, compilationOK);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9222,9372);

var 
compilationError = f_23113_9245_9371(source, new MetadataReference[] { f_23113_9297_9368(moduleMetadata, filePath: @"R:\A\B\ModuleNameMismatch.mod")})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9388,9699);

f_23113_9388_9698(
            compilationError, f_23113_9578_9697(f_23113_9578_9625(ErrorCode.ERR_NetModuleNameMismatch), "ModuleNameMismatch.netmodule", "ModuleNameMismatch.mod"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,8522,9710);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_8742_8845(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8742, 8845);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23113_8914_8937(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8914, 8937);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23113_8883_8938(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 8883, 8938);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23113_9077_9154(Microsoft.CodeAnalysis.ModuleMetadata
this_param,string
filePath)
{
var return_v = this_param.GetReference( filePath:filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9077, 9154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_9025_9157(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9025, 9157);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23113_9174_9205(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitErrorTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9174, 9205);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23113_9297_9368(Microsoft.CodeAnalysis.ModuleMetadata
this_param,string
filePath)
{
var return_v = this_param.GetReference( filePath:filePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9297, 9368);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_9245_9371(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9245, 9371);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_9578_9625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9578, 9625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_9578_9697(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9578, 9697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_9388_9698(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9388, 9698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,8522,9710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,8522,9710);
}
		}

[ConditionalFact(typeof(NoIOperationValidation))]
        public void CS0204_ERR_TooManyLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,9722,11060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9844,9890);

var 
builder = f_23113_9858_9889()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,9904,9987);

f_23113_9904_9986(            builder, @"
public class A
{
    public static int Main ()
        {
");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10010,10015);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10001,10140) || true) && (i < 65536)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10028,10031)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23113,10001,10140))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23113,10001,10140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10065,10125);

f_23113_10065_10124(                builder, f_23113_10084_10123("    int i{0} = {0};", i));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23113,1,140);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23113,1,140);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10156,10211);

f_23113_10156_10210(
            builder, @"
        return 1;
        }
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10405,10490);

var 
warnOpts = f_23113_10420_10489()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10504,10628);

f_23113_10504_10627(            warnOpts, f_23113_10517_10599(MessageProvider.Instance, ErrorCode.WRN_UnreferencedVarAssg), ReportDiagnostic.Suppress);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10642,10767);

var 
compilation1 = f_23113_10661_10766(f_23113_10679_10697(builder), null, f_23113_10705_10765(TestOptions.DebugDll, warnOpts))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,10781,11049);

f_23113_10781_11048(            compilation1, f_23113_11000_11047(ErrorCode.ERR_TooManyLocals, "Main"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,9722,11060);

System.Text.StringBuilder
f_23113_9858_9889()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9858, 9889);
return return_v;
}


System.Text.StringBuilder
f_23113_9904_9986(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 9904, 9986);
return return_v;
}


string
f_23113_10084_10123(string
format,int
arg0)
{
var return_v = string.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10084, 10123);
return return_v;
}


System.Text.StringBuilder
f_23113_10065_10124(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10065, 10124);
return return_v;
}


System.Text.StringBuilder
f_23113_10156_10210(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10156, 10210);
return return_v;
}


System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
f_23113_10420_10489()
{
var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10420, 10489);
return return_v;
}


string
f_23113_10517_10599(Microsoft.CodeAnalysis.CSharp.MessageProvider
this_param,Microsoft.CodeAnalysis.CSharp.ErrorCode
errorCode)
{
var return_v = this_param.GetIdForErrorCode( (int)errorCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10517, 10599);
return return_v;
}


int
f_23113_10504_10627(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
this_param,string
key,Microsoft.CodeAnalysis.ReportDiagnostic
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10504, 10627);
return 0;
}


string
f_23113_10679_10697(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10679, 10697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23113_10705_10765(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
values)
{
var return_v = this_param.WithSpecificDiagnosticOptions( (System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.ReportDiagnostic>>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10705, 10765);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_10661_10766(string
source,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10661, 10766);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_11000_11047(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11000, 11047);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_10781_11048(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 10781, 11048);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,9722,11060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,9722,11060);
}
		}

[Fact, WorkItem(8287, "https://github.com/dotnet/roslyn/issues/8287")]
        public void ToManyUserStrings()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23113,11072,12038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11208,11254);

var 
builder = f_23113_11222_11253()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11268,11352);

f_23113_11268_11351(            builder, @"
public class A
{
    public static void Main ()
        {
");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11375,11380);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11366,11627) || true) && (i < 11)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11390,11393)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23113,11366,11627))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23113,11366,11627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11427,11473);

f_23113_11427_11472(                builder, "System.Console.WriteLine(\"");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11491,11532);

f_23113_11491_11531(                builder, ('A' + i), 1000000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11550,11573);

f_23113_11550_11572(                builder, "\");");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11591,11612);

f_23113_11591_11611(                builder);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23113,1,262);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23113,1,262);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11643,11679);

f_23113_11643_11678(
            builder, @"
        }
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11695,11751);

var 
compilation = f_23113_11713_11750(f_23113_11731_11749(builder))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23113,11767,12027);

f_23113_11767_12026(
            compilation, f_23113_11944_12007(f_23113_11944_11988(ErrorCode.ERR_TooManyUserStrings), 1, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(23113,11072,12038);

System.Text.StringBuilder
f_23113_11222_11253()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11222, 11253);
return return_v;
}


System.Text.StringBuilder
f_23113_11268_11351(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11268, 11351);
return return_v;
}


System.Text.StringBuilder
f_23113_11427_11472(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11427, 11472);
return return_v;
}


System.Text.StringBuilder
f_23113_11491_11531(System.Text.StringBuilder
this_param,int
value,int
repeatCount)
{
var return_v = this_param.Append( (char)value, repeatCount);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11491, 11531);
return return_v;
}


System.Text.StringBuilder
f_23113_11550_11572(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11550, 11572);
return return_v;
}


System.Text.StringBuilder
f_23113_11591_11611(System.Text.StringBuilder
this_param)
{
var return_v = this_param.AppendLine();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11591, 11611);
return return_v;
}


System.Text.StringBuilder
f_23113_11643_11678(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11643, 11678);
return return_v;
}


string
f_23113_11731_11749(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11731, 11749);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_11713_11750(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11713, 11750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_11944_11988(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11944, 11988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23113_11944_12007(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11944, 12007);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23113_11767_12026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23113, 11767, 12026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23113,11072,12038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,11072,12038);
}
		}

public EmitErrorTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23113,794,12067);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23113,794,12067);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,794,12067);
}


static EmitErrorTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23113,794,12067);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23113,794,12067);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23113,794,12067);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23113,794,12067);
}
}
