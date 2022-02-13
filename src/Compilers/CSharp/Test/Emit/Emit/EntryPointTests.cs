// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class EntryPointTests : EmitMetadataTestBase
{
private CSharpCompilation CompileConsoleApp(string source, CSharpParseOptions parseOptions = null, string mainTypeName = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,505,812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,656,801);

return f_23116_663_800(source, options: f_23116_698_771(f_23116_698_740(TestOptions.ReleaseExe, 5), mainTypeName), parseOptions: parseOptions);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,505,812);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_698_740(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,int
warningLevel)
{
var return_v = this_param.WithWarningLevel( warningLevel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 698, 740);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_698_771(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string?
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 698, 771);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_663_800(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions?
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 663, 800);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,505,812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,505,812);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public void MainOverloads()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,824,1459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,892,1067);

string 
source = @"
public class C
{
  public static void Main(int goo) { System.Console.WriteLine(1); }
  public static void Main() { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1081,1125);

var 
compilation = f_23116_1099_1124(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1139,1205);

var 
verifier = f_23116_1154_1204(this, compilation, expectedOutput: "2")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1221,1448);

f_23116_1221_1447(
            verifier, f_23116_1369_1446(f_23116_1369_1417(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(int)"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,824,1459);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_1099_1124(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1099, 1124);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_1154_1204(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1154, 1204);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_1369_1417(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1369, 1417);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_1369_1446(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1369, 1446);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_1221_1447(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1221, 1447);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,824,1459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,824,1459);
}
		}

[Fact]
        public void MainOverloads_Dll()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,1471,2110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1543,1718);

string 
source = @"
public class C
{
  public static void Main(int goo) { System.Console.WriteLine(1); }
  public static void Main() { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1732,1809);

var 
compilation = f_23116_1750_1808(source, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,1825,1870);

var 
verifier = f_23116_1840_1869(this, compilation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,2070,2099);

f_23116_2070_2098(
            // Dev10 reports warning CS0028: 'C.Main(int)' has the wrong signature to be an entry point, 
            // but that seems like a bug since we are not compiling an exe.
            verifier);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,1471,2110);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_1750_1808(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1750, 1808);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_1840_1869(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 1840, 1869);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_2070_2098(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 2070, 2098);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,1471,2110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,1471,2110);
}
		}

[Fact]
        public void ERR_NoEntryPoint_Overloads()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,2236,3479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,2317,2577);

string 
source = @"
public class C
{
  public static void Main(int goo) { System.Console.WriteLine(1); }
  public static void Main(double goo) { System.Console.WriteLine(2); }
  public static void Main(string[,] goo) { System.Console.WriteLine(3); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,2591,2635);

var 
compilation = f_23116_2609_2634(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,2651,3468);

f_23116_2651_3467(
            compilation, f_23116_2802_2879(f_23116_2802_2850(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(int)"), f_23116_3004_3084(f_23116_3004_3052(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(double)"), f_23116_3214_3299(f_23116_3214_3262(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(string[*,*])"), f_23116_3428_3466(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,2236,3479);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_2609_2634(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 2609, 2634);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_2802_2850(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 2802, 2850);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_2802_2879(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 2802, 2879);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_3004_3052(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3004, 3052);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_3004_3084(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3004, 3084);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_3214_3262(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3214, 3262);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_3214_3299(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3214, 3299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_3428_3466(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3428, 3466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_2651_3467(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 2651, 3467);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,2236,3479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,2236,3479);
}
		}

[Fact]
        public void ERR_MultipleEntryPoints()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,3605,4503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,3683,3962);

string 
source = @"
public class C
{
  public static void Main() { System.Console.WriteLine(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}

public class D
{
  public static string Main() { System.Console.WriteLine(3); return null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,3976,4020);

var 
compilation = f_23116_3994_4019(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,4036,4492);

f_23116_4036_4491(
            compilation, f_23116_4185_4259(f_23116_4185_4233(ErrorCode.WRN_InvalidMainSig, "Main"), "D.Main()"), f_23116_4437_4490(ErrorCode.ERR_MultipleEntryPoints, "Main"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,3605,4503);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_3994_4019(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 3994, 4019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_4185_4233(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 4185, 4233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_4185_4259(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 4185, 4259);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_4437_4490(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 4437, 4490);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_4036_4491(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 4036, 4491);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,3605,4503);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,3605,4503);
}
		}

[Fact]
        [WorkItem(46831, "https://github.com/dotnet/roslyn/issues/46831")]
        public void WRN_SyncAndAsyncEntryPoints_CSharp71()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,4515,5348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,4682,4891);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static async Task Main() { await Task.Delay(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,4905,4987);

var 
compilation = f_23116_4923_4986(this, source, parseOptions: TestOptions.Regular7_1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,5003,5337);

f_23116_5003_5336(
            compilation, f_23116_5212_5335(f_23116_5212_5315(f_23116_5212_5269(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "C.Main()", "C.Main(string[])"), 6, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,4515,5348);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_4923_4986(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = this_param.CompileConsoleApp( source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 4923, 4986);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_5212_5269(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5212, 5269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_5212_5315(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5212, 5315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_5212_5335(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5212, 5335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_5003_5336(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5003, 5336);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,4515,5348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,4515,5348);
}
		}

[Fact]
        public void SyncAndAsyncEntryPointsBeforeAsyncMainFeature_NoDiagnostics()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,5360,5836);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,5474,5683);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static async Task Main() { await Task.Delay(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,5697,5777);

var 
compilation = f_23116_5715_5776(this, source, parseOptions: TestOptions.Regular7)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,5793,5825);

f_23116_5793_5824(
            compilation);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,5360,5836);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_5715_5776(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = this_param.CompileConsoleApp( source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5715, 5776);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_5793_5824(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 5793, 5824);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,5360,5836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,5360,5836);
}
		}

[Fact]
        [WorkItem(46831, "https://github.com/dotnet/roslyn/issues/46831")]
        public void WRN_SyncAndAsyncEntryPointsCSharpLatest_SyncAndAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,5848,6659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,6031,6240);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static async Task Main() { await Task.Delay(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,6254,6298);

var 
compilation = f_23116_6272_6297(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,6314,6648);

f_23116_6314_6647(
            compilation, f_23116_6523_6646(f_23116_6523_6626(f_23116_6523_6580(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "C.Main()", "C.Main(string[])"), 6, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,5848,6659);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_6272_6297(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 6272, 6297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_6523_6580(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 6523, 6580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_6523_6626(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 6523, 6626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_6523_6646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 6523, 6646);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_6314_6647(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 6314, 6647);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,5848,6659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,5848,6659);
}
		}

[Fact]
        [WorkItem(46831, "https://github.com/dotnet/roslyn/issues/46831")]
        public void ERR_And_WRN_MultipleEntryPointsCSharpLatest_TwoSyncAndOneAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,6671,7809);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,6864,7159);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static async Task Main() { await Task.Delay(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}

public class D
{
  public static void Main() { System.Console.WriteLine(3); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,7173,7217);

var 
compilation = f_23116_7191_7216(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,7233,7798);

f_23116_7233_7797(
            compilation, f_23116_7440_7493(ErrorCode.ERR_MultipleEntryPoints, "Main"), f_23116_7673_7796(f_23116_7673_7776(f_23116_7673_7730(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "C.Main()", "C.Main(string[])"), 6, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,6671,7809);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_7191_7216(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7191, 7216);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_7440_7493(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7440, 7493);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_7673_7730(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7673, 7730);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_7673_7776(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7673, 7776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_7673_7796(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7673, 7796);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_7233_7797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 7233, 7797);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,6671,7809);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,6671,7809);
}
		}

[Fact]
        [WorkItem(46831, "https://github.com/dotnet/roslyn/issues/46831")]
        public void WRN_SyncAndAsyncEntryPointsCSharpLatest_TwoAsyncAndOneSync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,7821,9027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,8010,8303);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static async Task Main() { await Task.Delay(1); }
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}

public class D
{
  public static async Task Main() { await Task.Delay(1); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,8317,8361);

var 
compilation = f_23116_8335_8360(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,8377,9016);

f_23116_8377_9015(
            compilation, f_23116_8586_8709(f_23116_8586_8689(f_23116_8586_8643(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "C.Main()", "C.Main(string[])"), 6, 28), f_23116_8890_9014(f_23116_8890_8993(f_23116_8890_8947(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "D.Main()", "C.Main(string[])"), 12, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,7821,9027);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_8335_8360(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8335, 8360);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8586_8643(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8586, 8643);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8586_8689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8586, 8689);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8586_8709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8586, 8709);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8890_8947(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8890, 8947);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8890_8993(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8890, 8993);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_8890_9014(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8890, 9014);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_8377_9015(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 8377, 9015);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,7821,9027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,7821,9027);
}
		}

[Fact]
        public void MultipleEntryPointsWithTypeDefined_NoDiagnostic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,9039,9635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9141,9374);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static void Main(string[] a) { System.Console.WriteLine(2); }
}

public class D
{
  public static async Task Main() { await Task.Delay(1); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9388,9451);

var 
compilation = f_23116_9406_9450(this, source, mainTypeName: "D")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9465,9497);

f_23116_9465_9496(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9513,9577);

var 
compilation2 = f_23116_9532_9576(this, source, mainTypeName: "C")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9591,9624);

f_23116_9591_9623(            compilation2);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,9039,9635);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_9406_9450(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,string
mainTypeName)
{
var return_v = this_param.CompileConsoleApp( source, mainTypeName:mainTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 9406, 9450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_9465_9496(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 9465, 9496);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_9532_9576(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,string
mainTypeName)
{
var return_v = this_param.CompileConsoleApp( source, mainTypeName:mainTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 9532, 9576);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_9591_9623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 9591, 9623);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,9039,9635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,9039,9635);
}
		}

[Fact]
        [WorkItem(46831, "https://github.com/dotnet/roslyn/issues/46831")]
        public void WRN_SyncAndAsyncEntryPoints_WithTypeDefined()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,9647,10468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,9821,10032);

string 
source = @"
using System.Threading.Tasks;

public class C
{
  public static void Main(string[] a) { System.Console.WriteLine(2); }

  public static async Task Main() { await Task.Delay(1); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,10046,10109);

var 
compilation = f_23116_10064_10108(this, source, mainTypeName: "C")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,10123,10457);

f_23116_10123_10456(            compilation, f_23116_10332_10455(f_23116_10332_10435(f_23116_10332_10389(ErrorCode.WRN_SyncAndAsyncEntryPoints, "Main"), "C.Main()", "C.Main(string[])"), 8, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,9647,10468);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_10064_10108(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,string
mainTypeName)
{
var return_v = this_param.CompileConsoleApp( source, mainTypeName:mainTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10064, 10108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_10332_10389(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10332, 10389);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_10332_10435(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10332, 10435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_10332_10455(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10332, 10455);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_10123_10456(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10123, 10456);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,9647,10468);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,9647,10468);
}
		}

[Fact]
        public void ERR_MultipleEntryPoints_Script()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,10480,11562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,10565,10644);

string 
csx = @"
public static void Main() { System.Console.WriteLine(1); }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,10660,10764);

string 
cs = @"
public class C 
{
   public static void Main() { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,10780,11066);

var 
compilation = f_23116_10798_11065(new[]
                {
f_23116_10894_10933(csx, options: TestOptions.Script),
f_23116_10956_10995(cs, options: TestOptions.Regular)                }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,11082,11551);

f_23116_11082_11550(
            compilation, f_23116_11259_11328(f_23116_11259_11304(ErrorCode.WRN_MainIgnored, "Main"), "Main()"), f_23116_11478_11549(f_23116_11478_11523(ErrorCode.WRN_MainIgnored, "Main"), "C.Main()"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,10480,11562);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_10894_10933(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = Parse( text, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10894, 10933);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23116_10956_10995(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = Parse( text, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10956, 10995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_10798_11065(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 10798, 11065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_11259_11304(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11259, 11304);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_11259_11328(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11259, 11328);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_11478_11523(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11478, 11523);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_11478_11549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11478, 11549);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_11082_11550(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11082, 11550);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,10480,11562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,10480,11562);
}
		}

[WorkItem(528677, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/528677")]
        [Fact]
        public void ERR_OneEntryPointAndOverload()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,11574,12294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,11749,11929);

string 
source = @"public class MyClass
{
    static int Main()
    {
        return 0;
    }
    static int Main(string[] args, int i)
    {
        return i;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,11943,11987);

var 
compilation = f_23116_11961_11986(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,12003,12283);

f_23116_12003_12282(
            compilation, f_23116_12170_12263(f_23116_12170_12218(ErrorCode.WRN_InvalidMainSig, "Main"), "MyClass.Main(string[], int)"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,11574,12294);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_11961_11986(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 11961, 11986);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_12170_12218(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12170, 12218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_12170_12263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12170, 12263);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_12003_12282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12003, 12282);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,11574,12294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,11574,12294);
}
		}

[Fact]
        public void ERR_NoEntryPoint_PartialClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,12473,13210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,12557,12722);

string 
source = @"
public partial class A
{
  static partial void Main(double d);
}

public partial class A
{
  static partial void Main(double d) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,12736,12780);

var 
compilation = f_23116_12754_12779(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,12796,13199);

f_23116_12796_13198(
            compilation, f_23116_12950_13030(f_23116_12950_12998(ErrorCode.WRN_InvalidMainSig, "Main"), "A.Main(double)"), f_23116_13159_13197(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,12473,13210);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_12754_12779(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12754, 12779);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_12950_12998(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12950, 12998);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_12950_13030(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12950, 13030);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_13159_13197(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13159, 13197);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_12796_13198(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 12796, 13198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,12473,13210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,12473,13210);
}
		}

[Fact]
        public void ERR_NoEntryPoint_PartialClass_1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,13222,13668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,13308,13431);

string 
source = @"
public partial class A
{
  static partial void Main(double d);
}

public partial class A
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,13445,13657);

f_23116_13445_13656(f_23116_13445_13470(this, source), f_23116_13617_13655(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,13222,13668);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_13445_13470(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13445, 13470);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_13617_13655(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13617, 13655);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_13445_13656(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13445, 13656);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,13222,13668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,13222,13668);
}
		}

[Fact]
        public void ScriptNonMethodMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,13680,14226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,13754,13835);

string 
csx = @"
public static int Main = 1;
System.Console.WriteLine(Main);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,13851,14100);

var 
compilation = f_23116_13869_14099(new[]
                {
f_23116_13965_14028(csx, options: TestOptions.Script),
                }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14116,14148);

f_23116_14116_14147(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14164,14215);

f_23116_14164_14214(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,13680,14226);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_13965_14028(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13965, 14028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_13869_14099(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 13869, 14099);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_14116_14147(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14116, 14147);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_14164_14214(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14164, 14214);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,13680,14226);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,13680,14226);
}
		}

[Fact]
        public void ScriptInstanceMethodMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,14238,14824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14317,14433);

string 
csx = @"
int Main() { return 1; }
int Main(string[] x) { return 2; }
System.Console.WriteLine(Main());
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14449,14698);

var 
compilation = f_23116_14467_14697(new[]
                {
f_23116_14563_14626(csx, options: TestOptions.Script),
                }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14714,14746);

f_23116_14714_14745(
            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14762,14813);

f_23116_14762_14812(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,14238,14824);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_14563_14626(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14563, 14626);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_14467_14697(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14467, 14697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_14714_14745(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14714, 14745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_14762_14812(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14762, 14812);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,14238,14824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,14238,14824);
}
		}

[Fact]
        public void Namespace()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,14836,15346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14900,14955);

string 
source = @"
namespace N { namespace M { } }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,14969,15070);

var 
compilation = f_23116_14987_15069(source, options: f_23116_15022_15068(TestOptions.ReleaseExe, "N.M"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,15084,15335);

f_23116_15084_15334(            compilation, f_23116_15264_15333(f_23116_15264_15312(ErrorCode.ERR_MainClassNotClass, "M"), "N.M"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,14836,15346);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_15022_15068(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15022, 15068);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_14987_15069(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 14987, 15069);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_15264_15312(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15264, 15312);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_15264_15333(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15264, 15333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_15084_15334(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15084, 15334);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,14836,15346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,14836,15346);
}
		}

[Fact]
        public void NestedGenericMainType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,15358,15944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,15434,15547);

string 
source = @"
class C<T> 
{ 
    struct D 
    {
        public static void Main() { }   
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,15561,15662);

var 
compilation = f_23116_15579_15661(source, options: f_23116_15614_15660(TestOptions.ReleaseExe, "C.D"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,15676,15933);

f_23116_15676_15932(            compilation, f_23116_15859_15931(f_23116_15859_15907(ErrorCode.ERR_MainClassNotClass, "D"), "C<T>.D"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,15358,15944);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_15614_15660(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15614, 15660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_15579_15661(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15579, 15661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_15859_15907(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15859, 15907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_15859_15931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15859, 15931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_15676_15932(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 15676, 15932);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,15358,15944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,15358,15944);
}
		}

[Fact]
        public void Struct()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,15956,16299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16017,16127);

string 
source = @"
struct C
{ 
    struct D 
    {
        public static void Main() { }   
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16141,16242);

var 
compilation = f_23116_16159_16241(source, options: f_23116_16194_16240(TestOptions.ReleaseExe, "C.D"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16256,16288);

f_23116_16256_16287(            compilation);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,15956,16299);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_16194_16240(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 16194, 16240);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_16159_16241(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 16159, 16241);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_16256_16287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 16256, 16287);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,15956,16299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,15956,16299);
}
		}

[Fact]
        public void GenericMainMethods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,16311,18946);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16384,16866);

string 
cs = @"
using System;

public static class C 
{
    static void Main<T>() { Console.WriteLine(1); }

    public static class CC<T>
    {
        static void Main() { Console.WriteLine(2); }
    }
}

public static class D<T>
{
    static void Main() { Console.WriteLine(3); }

    public static class DD
    {
        static void Main() { Console.WriteLine(4); }
    }
}

public static class E
{
    static void Main() { Console.WriteLine(5); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16880,16953);

var 
compilation = f_23116_16898_16952(cs, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,16967,17860);

f_23116_16967_17859(            compilation, f_23116_17128_17208(f_23116_17128_17179(ErrorCode.WRN_MainCantBeGeneric, "Main"), "C.Main<T>()"), f_23116_17343_17426(f_23116_17343_17394(ErrorCode.WRN_MainCantBeGeneric, "Main"), "C.CC<T>.Main()"), f_23116_17559_17639(f_23116_17559_17610(ErrorCode.WRN_MainCantBeGeneric, "Main"), "D<T>.Main()"), f_23116_17775_17858(f_23116_17775_17826(ErrorCode.WRN_MainCantBeGeneric, "Main"), "D<T>.DD.Main()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,17876,17927);

f_23116_17876_17926(this, compilation, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,17943,18034);

compilation = f_23116_17957_18033(cs, options: f_23116_17988_18032(TestOptions.ReleaseExe, "C"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,18048,18463);

f_23116_18048_18462(            compilation, f_23116_18209_18289(f_23116_18209_18260(ErrorCode.WRN_MainCantBeGeneric, "Main"), "C.Main<T>()"), f_23116_18398_18461(f_23116_18398_18442(ErrorCode.ERR_NoMainInClass, "C"), "C"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,18566,18660);

compilation = f_23116_18580_18659(cs, options: f_23116_18611_18658(TestOptions.ReleaseExe, "D.DD"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,18674,18935);

f_23116_18674_18934(            compilation, f_23116_18859_18933(f_23116_18859_18908(ErrorCode.ERR_MainClassNotClass, "DD"), "D<T>.DD"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,16311,18946);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_16898_16952(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 16898, 16952);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17128_17179(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17128, 17179);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17128_17208(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17128, 17208);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17343_17394(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17343, 17394);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17343_17426(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17343, 17426);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17559_17610(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17559, 17610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17559_17639(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17559, 17639);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17775_17826(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17775, 17826);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_17775_17858(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17775, 17858);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_16967_17859(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 16967, 17859);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_17876_17926(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17876, 17926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_17988_18032(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17988, 18032);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_17957_18033(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 17957, 18033);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18209_18260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18209, 18260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18209_18289(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18209, 18289);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18398_18442(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18398, 18442);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18398_18461(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18398, 18461);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_18048_18462(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18048, 18462);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_18611_18658(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18611, 18658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_18580_18659(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18580, 18659);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18859_18908(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18859, 18908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_18859_18933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18859, 18933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_18674_18934(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 18674, 18934);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,16311,18946);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,16311,18946);
}
		}

[Fact]
        public void MultipleArities1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,18958,19447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,19029,19317);

string 
source = @"
public class A
{
  public class B
  {
    class C 
    {
     	public static void Main() { System.Console.WriteLine(1); }
    }
  }
  
  public class B<T>
  {
    class C 
    {
	   public static void Main() { System.Console.WriteLine(2); }
	}
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,19331,19436);

f_23116_19331_19435(this, source, options: f_23116_19365_19413(TestOptions.ReleaseExe, "A.B.C"), expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,18958,19447);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_19365_19413(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 19365, 19413);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_19331_19435(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 19331, 19435);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,18958,19447);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,18958,19447);
}
		}

[Fact]
        public void MultipleArities2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,19459,19944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,19530,19814);

string 
source = @"
public class A
{
  public class B<T>
  {
    class C 
    {
	   public static void Main() { System.Console.WriteLine(2); }
	}
  }
  public class B
  {
    class C 
    {
     	public static void Main() { System.Console.WriteLine(1); }
    }
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,19828,19933);

f_23116_19828_19932(this, source, options: f_23116_19862_19910(TestOptions.ReleaseExe, "A.B.C"), expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,19459,19944);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_19862_19910(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 19862, 19910);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_19828_19932(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 19828, 19932);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,19459,19944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,19459,19944);
}
		}

[Fact]
        public void MultipleArities3()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,19956,20767);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,20027,20320);

string 
source = @"
public class A
{
  public class B<S,T>
  {
    class C 
    {
     	public static void Main() { System.Console.WriteLine(1); }
    }
  }
  
  public class B<T>
  {
    class C 
    {
	   public static void Main() { System.Console.WriteLine(2); }
	}
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,20421,20756);

f_23116_20421_20755(f_23116_20421_20505(source, options: f_23116_20456_20504(TestOptions.ReleaseExe, "A.B.C")), f_23116_20680_20754(f_23116_20680_20728(ErrorCode.ERR_MainClassNotClass, "C"), "A.B<T>.C"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,19956,20767);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_20456_20504(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 20456, 20504);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_20421_20505(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 20421, 20505);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_20680_20728(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 20680, 20728);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_20680_20754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 20680, 20754);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_20421_20755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 20421, 20755);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,19956,20767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,19956,20767);
}
		}

[Fact]
        public void ExplicitMainTypeName_GenericAndNonGeneric()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,20863,21244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,20959,21074);

string 
source = @"
class C<T> 
{
    static void Main() { }
}

class C 
{
    static void Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,21088,21187);

var 
compilation = f_23116_21106_21186(source, options: f_23116_21141_21185(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,21201,21233);

f_23116_21201_21232(            compilation);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,20863,21244);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_21141_21185(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21141, 21185);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_21106_21186(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21106, 21186);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_21201_21232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21201, 21232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,20863,21244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,20863,21244);
}
		}

[Fact]
        public void ExplicitMainTypeName_GenericMultipleArities()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,21441,22049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,21539,21659);

string 
source = @"
class C<S, T>
{
    static void Main() { }
}

class C<T> 
{
    static void Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,21673,21772);

var 
compilation = f_23116_21691_21771(source, options: f_23116_21726_21770(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,21786,22038);

f_23116_21786_22037(            compilation, f_23116_21966_22036(f_23116_21966_22014(ErrorCode.ERR_MainClassNotClass, "C"), "C<T>"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,21441,22049);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_21726_21770(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21726, 21770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_21691_21771(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21691, 21771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_21966_22014(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21966, 22014);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_21966_22036(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21966, 22036);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_21786_22037(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 21786, 22037);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,21441,22049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,21441,22049);
}
		}

[Fact]
        public void ExplicitMainTypeHasMultipleMains_NoViable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,22366,23635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,22462,22678);

string 
source = @"
public class C 
{
    int Main(bool b) { return 1; }
    static int Main(string a) { return 1; }
    static int Main(int a) { return 1; }  
    static int Main<T>() { return 1; }      
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,22692,22791);

var 
compilation = f_23116_22710_22790(source, options: f_23116_22745_22789(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,22805,23624);

f_23116_22805_23623(            compilation, f_23116_22959_23039(f_23116_22959_23007(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(string)"), f_23116_23161_23238(f_23116_23161_23209(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(int)"), f_23116_23370_23450(f_23116_23370_23421(ErrorCode.WRN_MainCantBeGeneric, "Main"), "C.Main<T>()"), f_23116_23559_23622(f_23116_23559_23603(ErrorCode.ERR_NoMainInClass, "C"), "C"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,22366,23635);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_22745_22789(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 22745, 22789);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_22710_22790(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 22710, 22790);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_22959_23007(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 22959, 23007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_22959_23039(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 22959, 23039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23161_23209(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23161, 23209);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23161_23238(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23161, 23238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23370_23421(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23370, 23421);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23370_23450(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23370, 23450);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23559_23603(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23559, 23603);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_23559_23622(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 23559, 23622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_22805_23623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 22805, 23623);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,22366,23635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,22366,23635);
}
		}

[Fact]
        public void ExplicitMainTypeHasMultipleMains_SingleViable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,23739,24262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,23839,24092);

string 
source = @"
public class C 
{
    int Main(bool b) { return 1; }
    static int Main() { return 1; }
    static int Main(string a) { return 1; }
    static int Main(int a) { return 1; }  
    static int Main<T>() { return 1; }      
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,24106,24205);

var 
compilation = f_23116_24124_24204(source, options: f_23116_24159_24203(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,24219,24251);

f_23116_24219_24250(            compilation);
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,23739,24262);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_24159_24203(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24159, 24203);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_24124_24204(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24124, 24204);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_24219_24250(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24219, 24250);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,23739,24262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,23739,24262);
}
		}

[Fact]
        public void ExplicitMainTypeHasMultipleMains_MultipleViable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,24414,25208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,24516,24808);

string 
source = @"
public class C 
{
    int Main(bool b) { return 1; }
    static int Main() { return 1; }
    static int Main(string a) { return 1; }
    static int Main(int a) { return 1; }
    static int Main(string[] a) { return 1; }
    static int Main<T>() { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,24822,24921);

var 
compilation = f_23116_24840_24920(source, options: f_23116_24875_24919(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,24935,25197);

f_23116_24935_25196(            compilation, f_23116_25142_25195(ErrorCode.ERR_MultipleEntryPoints, "Main"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,24414,25208);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_24875_24919(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24875, 24919);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_24840_24920(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24840, 24920);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_25142_25195(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25142, 25195);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_24935_25196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 24935, 25196);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,24414,25208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,24414,25208);
}
		}

[Fact]
        public void ERR_NoEntryPoint_NonMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,25220,25661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,25301,25378);

string 
source = @"
public class G 
{
   public static int Main = 1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,25392,25436);

var 
compilation = f_23116_25410_25435(this, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,25452,25650);

f_23116_25452_25649(
            compilation, f_23116_25610_25648(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,25220,25661);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_25410_25435(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25410, 25435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_25610_25648(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25610, 25648);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_25452_25649(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25452, 25649);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,25220,25661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,25220,25661);
}
		}

[Fact]
        public void Script()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,25673,26076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,25734,25786);

string 
source = @"
System.Console.WriteLine(1);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,25802,25998);

var 
compilation = f_23116_25820_25997(new[] { f_23116_25878_25944(source, options: TestOptions.Script)}, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26014,26065);

f_23116_26014_26064(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,25673,26076);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_25878_25944(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25878, 25944);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_25820_25997(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 25820, 25997);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_26014_26064(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26014, 26064);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,25673,26076);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,25673,26076);
}
		}

[Fact]
        public void ScriptAndRegularFile_ExplicitMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,26088,27041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26176,26225);

string 
csx = @"
System.Console.WriteLine(1);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26241,26345);

string 
cs = @"
public class C 
{
   public static void Main() { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26361,26695);

var 
compilation = f_23116_26379_26694(new[]
                {
f_23116_26475_26538(csx, options: TestOptions.Script),
f_23116_26561_26624(cs, options: TestOptions.Regular)                }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26711,26963);

f_23116_26711_26962(
            compilation, f_23116_26890_26961(f_23116_26890_26935(ErrorCode.WRN_MainIgnored, "Main"), "C.Main()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,26979,27030);

f_23116_26979_27029(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,26088,27041);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_26475_26538(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26475, 26538);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23116_26561_26624(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26561, 26624);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_26379_26694(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26379, 26694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_26890_26935(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26890, 26935);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_26890_26961(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26890, 26961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_26711_26962(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26711, 26962);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_26979_27029(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 26979, 27029);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,26088,27041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,26088,27041);
}
		}

[Fact]
        public void ScriptAndRegularFile_ExplicitMains()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,27053,28316);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,27142,27191);

string 
csx = @"
System.Console.WriteLine(1);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,27207,27399);

string 
cs = @"
public class C 
{
   public static void Main() { System.Console.WriteLine(2); }
}

public class D 
{
   public static void Main() { System.Console.WriteLine(3); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,27415,27749);

var 
compilation = f_23116_27433_27748(new[]
                {
f_23116_27529_27592(csx, options: TestOptions.Script),
f_23116_27615_27678(cs, options: TestOptions.Regular)                }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,27765,28238);

f_23116_27765_28237(
            compilation, f_23116_27944_28015(f_23116_27944_27989(ErrorCode.WRN_MainIgnored, "Main"), "C.Main()"), f_23116_28165_28236(f_23116_28165_28210(ErrorCode.WRN_MainIgnored, "Main"), "D.Main()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28254,28305);

f_23116_28254_28304(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,27053,28316);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_27529_27592(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27529, 27592);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23116_27615_27678(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27615, 27678);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_27433_27748(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27433, 27748);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_27944_27989(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27944, 27989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_27944_28015(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27944, 28015);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_28165_28210(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28165, 28210);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_28165_28236(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28165, 28236);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_27765_28237(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 27765, 28237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_28254_28304(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28254, 28304);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,27053,28316);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,27053,28316);
}
		}

[Fact]
        public void ExplicitMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,28328,28929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28395,28562);

string 
source = @"
class C 
{
   static void Main() { System.Console.WriteLine(1); }
}

class D
{
   static void Main() { System.Console.WriteLine(2); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28578,28677);

var 
compilation = f_23116_28596_28676(source, options: f_23116_28631_28675(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28691,28742);

f_23116_28691_28741(this, compilation, expectedOutput: "1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28758,28853);

compilation = f_23116_28772_28852(source, options: f_23116_28807_28851(TestOptions.ReleaseExe, "D"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,28867,28918);

f_23116_28867_28917(this, compilation, expectedOutput: "2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,28328,28929);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_28631_28675(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28631, 28675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_28596_28676(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28596, 28676);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_28691_28741(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28691, 28741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_28807_28851(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28807, 28851);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_28772_28852(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28772, 28852);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23116_28867_28917(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 28867, 28917);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,28328,28929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,28328,28929);
}
		}

[Fact]
        public void ERR_MainClassNotFound()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,28941,29479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29017,29111);

string 
source = @"
class C 
{
   static void Main() { System.Console.WriteLine(1); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29127,29261);

var 
compilation = f_23116_29145_29260(source, options: f_23116_29215_29259(TestOptions.ReleaseExe, "D"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29277,29468);

f_23116_29277_29467(
            compilation, f_23116_29404_29466(f_23116_29404_29447(ErrorCode.ERR_MainClassNotFound), "D"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,28941,29479);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_29215_29259(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29215, 29259);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_29145_29260(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29145, 29260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_29404_29447(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29404, 29447);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_29404_29466(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29404, 29466);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_29277_29467(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29277, 29467);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,28941,29479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,28941,29479);
}
		}

[Fact]
        public void ERR_MainClassNotClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,29491,30861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29567,29638);

string 
source = @"
enum C { }
delegate void D();
interface I { }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29654,29788);

var 
compilation = f_23116_29672_29787(source, options: f_23116_29742_29786(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,29804,30024);

f_23116_29804_30023(
            compilation, f_23116_29955_30022(f_23116_29955_30003(ErrorCode.ERR_MainClassNotClass, "C"), "C"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,30042,30172);

compilation = f_23116_30056_30171(source, options: f_23116_30126_30170(TestOptions.ReleaseExe, "D"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,30188,30409);

f_23116_30188_30408(
            compilation, f_23116_30340_30407(f_23116_30340_30388(ErrorCode.ERR_MainClassNotClass, "D"), "D"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,30427,30557);

compilation = f_23116_30441_30556(source, options: f_23116_30511_30555(TestOptions.ReleaseExe, "I"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,30573,30850);

f_23116_30573_30849(
            compilation, f_23116_30747_30830(f_23116_30747_30810(f_23116_30747_30791(ErrorCode.ERR_NoMainInClass, "I"), "I"), 4, 11));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,29491,30861);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_29742_29786(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29742, 29786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_29672_29787(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29672, 29787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_29955_30003(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29955, 30003);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_29955_30022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29955, 30022);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_29804_30023(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 29804, 30023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_30126_30170(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30126, 30170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_30056_30171(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30056, 30171);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_30340_30388(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30340, 30388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_30340_30407(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30340, 30407);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_30188_30408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30188, 30408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_30511_30555(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30511, 30555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_30441_30556(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30441, 30556);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_30747_30791(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30747, 30791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_30747_30810(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30747, 30810);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_30747_30830(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30747, 30830);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_30573_30849(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 30573, 30849);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,29491,30861);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,29491,30861);
}
		}

[Fact]
        public void ERR_NoMainInClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,30873,32499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,30945,31197);

string 
source = @"
class C 
{
   void Main() { System.Console.WriteLine(1); }
}

class D
{
   static void Main(double args) { System.Console.WriteLine(1); }
}

class E
{
   int Main { get { System.Console.WriteLine(1); return 1; } }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,31314,31413);

var 
compilation = f_23116_31332_31412(source, options: f_23116_31367_31411(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,31427,31629);

f_23116_31427_31628(            compilation, f_23116_31564_31627(f_23116_31564_31608(ErrorCode.ERR_NoMainInClass, "C"), "C"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,31645,31740);

compilation = f_23116_31659_31739(source, options: f_23116_31694_31738(TestOptions.ReleaseExe, "D"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,31754,32161);

f_23116_31754_32160(            compilation, f_23116_31908_31988(f_23116_31908_31956(ErrorCode.WRN_InvalidMainSig, "Main"), "D.Main(double)"), f_23116_32096_32159(f_23116_32096_32140(ErrorCode.ERR_NoMainInClass, "D"), "D"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,32177,32272);

compilation = f_23116_32191_32271(source, options: f_23116_32226_32270(TestOptions.ReleaseExe, "E"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,32286,32488);

f_23116_32286_32487(            compilation, f_23116_32423_32486(f_23116_32423_32467(ErrorCode.ERR_NoMainInClass, "E"), "E"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,30873,32499);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_31367_31411(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31367, 31411);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_31332_31412(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31332, 31412);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_31564_31608(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31564, 31608);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_31564_31627(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31564, 31627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_31427_31628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31427, 31628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_31694_31738(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31694, 31738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_31659_31739(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31659, 31739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_31908_31956(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31908, 31956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_31908_31988(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31908, 31988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_32096_32140(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32096, 32140);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_32096_32159(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32096, 32159);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_31754_32160(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 31754, 32160);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_32226_32270(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32226, 32270);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_32191_32271(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32191, 32271);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_32423_32467(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32423, 32467);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_32423_32486(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32423, 32486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_32286_32487(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32286, 32487);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,30873,32499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,30873,32499);
}
		}

[Fact]
        public void ERR_NoMainInClass_Script()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,32511,33367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,32590,32639);

string 
csx = @"
System.Console.WriteLine(2);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,32655,32738);

string 
cs = @"
class C 
{
   void Main() { System.Console.WriteLine(1); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,32754,33111);

var 
compilation = f_23116_32772_33110(new[]
                {
f_23116_32868_32931(csx, options: TestOptions.Script),
f_23116_32954_33017(cs, options: TestOptions.Regular),
                }, options: f_23116_33065_33109(TestOptions.ReleaseExe, "C"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,33127,33356);

f_23116_33127_33355(
            compilation, f_23116_33298_33354(f_23116_33298_33335(ErrorCode.WRN_MainIgnored), "C"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,32511,33367);

Microsoft.CodeAnalysis.SyntaxTree
f_23116_32868_32931(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32868, 32931);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23116_32954_33017(string
text,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text, options:(Microsoft.CodeAnalysis.ParseOptions)options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32954, 33017);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_33065_33109(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33065, 33109);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_32772_33110(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 32772, 33110);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_33298_33335(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33298, 33335);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_33298_33354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33298, 33354);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_33127_33355(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33127, 33355);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,32511,33367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,32511,33367);
}
		}

[Fact]
        public void WRN_InvalidMainSig_MultiDimensionalArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,33379,34109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,33474,33571);

string 
source = @"
class B
{
    public static void Main(string[,] args)
    {
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,33585,34098);

f_23116_33585_34097(f_23116_33585_33610(this, source), f_23116_33844_33929(f_23116_33844_33892(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(string[*,*])"), f_23116_34058_34096(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,33379,34109);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_33585_33610(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33585, 33610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_33844_33892(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33844, 33892);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_33844_33929(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33844, 33929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_34058_34096(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34058, 34096);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_33585_34097(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 33585, 34097);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,33379,34109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,33379,34109);
}
		}

[Fact]
        public void WRN_InvalidMainSig_JaggedArray()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,34121,34841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,34206,34304);

string 
source = @"
class B
{
    public static void Main(string[][] args)
    {
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,34318,34830);

f_23116_34318_34829(f_23116_34318_34343(this, source), f_23116_34577_34661(f_23116_34577_34625(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(string[][])"), f_23116_34790_34828(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,34121,34841);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_34318_34343(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34318, 34343);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_34577_34625(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34577, 34625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_34577_34661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34577, 34661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_34790_34828(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34790, 34828);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_34318_34829(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 34318, 34829);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,34121,34841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,34121,34841);
}
		}

[Fact]
        public void WRN_InvalidMainSig_Array()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,34853,35576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,34932,35040);

string 
source = @"
using System;
class B
{
    public static void Main(Array args)
    {
    }
} 
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,35054,35565);

f_23116_35054_35564(f_23116_35054_35079(this, source), f_23116_35310_35396(f_23116_35310_35358(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(System.Array)"), f_23116_35525_35563(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,34853,35576);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_35054_35079(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35054, 35079);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_35310_35358(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35310, 35358);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_35310_35396(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35310, 35396);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_35525_35563(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35525, 35563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_35054_35564(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35054, 35564);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,34853,35576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,34853,35576);
}
		}

[Fact]
        public void ERR_NoEntryPoint_MainIsProperty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,35588,35982);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,35674,35745);

string 
source = @"
class Program
{
    int Main { get; set; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,35759,35971);

f_23116_35759_35970(f_23116_35759_35784(this, source), f_23116_35931_35969(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,35588,35982);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_35759_35784(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35759, 35784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_35931_35969(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35931, 35969);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_35759_35970(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 35759, 35970);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,35588,35982);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,35588,35982);
}
		}

[Fact]
        public void WRN_InvalidMainSig_ReturnTypeOtherThanIntVoid()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,35994,36722);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,36094,36212);

string 
source = @"
class B
{
    public static int[] Main(string[] args)
    {
        return null;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,36226,36711);

f_23116_36226_36710(f_23116_36226_36251(this, source), f_23116_36460_36542(f_23116_36460_36508(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(string[])"), f_23116_36671_36709(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,35994,36722);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_36226_36251(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36226, 36251);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_36460_36508(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36460, 36508);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_36460_36542(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36460, 36542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_36671_36709(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36671, 36709);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_36226_36710(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36226, 36710);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,35994,36722);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,35994,36722);
}
		}

[Fact]
        public void ParamParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,36734,36980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,36810,36909);

string 
source = @"
class B
{
    public static void Main(params string[] x)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,36923,36969);

f_23116_36923_36968(f_23116_36923_36948(this, source));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,36734,36980);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_36923_36948(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36923, 36948);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_36923_36968(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 36923, 36968);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,36734,36980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,36734,36980);
}
		}

[Fact]
        public void ParamParameterForMain_1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,36992,37748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,37070,37179);

string 
source = @"
class B
{
    public static void Main(int x=1,params string[] str)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,37193,37737);

f_23116_37193_37736(f_23116_37193_37218(this, source), f_23116_37474_37568(f_23116_37474_37522(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(int, params string[])"), f_23116_37697_37735(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,36992,37748);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_37193_37218(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37193, 37218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_37474_37522(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37474, 37522);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_37474_37568(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37474, 37568);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_37697_37735(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37697, 37735);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_37193_37736(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37193, 37736);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,36992,37748);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,36992,37748);
}
		}

[Fact]
        public void ParamParameterForMain_2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,37760,38538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,37838,37953);

string 
source = @"
class B
{
    public static void Main(string[] str,params string[] str1)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,37967,38527);

f_23116_37967_38526(f_23116_37967_37992(this, source), f_23116_38259_38358(f_23116_38259_38307(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(string[], params string[])"), f_23116_38487_38525(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,37760,38538);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_37967_37992(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37967, 37992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_38259_38307(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38259, 38307);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_38259_38358(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38259, 38358);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_38487_38525(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38487, 38525);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_37967_38526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 37967, 38526);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,37760,38538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,37760,38538);
}
		}

[Fact]
        public void ParamParameterForMain_3()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,38550,39264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,38628,38724);

string 
source = @"
class B
{
    public static void Main(params int[] x)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,38738,39253);

f_23116_38738_39252(f_23116_38738_38763(this, source), f_23116_38998_39084(f_23116_38998_39046(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(params int[])"), f_23116_39213_39251(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,38550,39264);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_38738_38763(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38738, 38763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_38998_39046(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38998, 39046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_38998_39084(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38998, 39084);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_39213_39251(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39213, 39251);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_38738_39252(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 38738, 39252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,38550,39264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,38550,39264);
}
		}

[Fact]
        public void OptionalParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,39276,39527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,39355,39456);

string 
source = @"
class B
{
    public static void Main(string[] arg = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,39470,39516);

f_23116_39470_39515(f_23116_39470_39495(this, source));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,39276,39527);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_39470_39495(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39470, 39495);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_39470_39515(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39470, 39515);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,39276,39527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,39276,39527);
}
		}

[Fact]
        public void OptionalParameterForMain_1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,39539,40228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,39620,39711);

string 
source = @"
class B
{
    public static void Main(int x = 1)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,39725,40217);

f_23116_39725_40216(f_23116_39725_39750(this, source), f_23116_39971_40048(f_23116_39971_40019(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(int)"), f_23116_40177_40215(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,39539,40228);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_39725_39750(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39725, 39750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_39971_40019(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39971, 40019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_39971_40048(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39971, 40048);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_40177_40215(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40177, 40215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_39725_40216(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 39725, 40216);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,39539,40228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,39539,40228);
}
		}

[Fact]
        public void OptionalParameterForMain_2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,40240,40967);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,40321,40423);

string 
source = @"
class B
{
    public static void Main(string[,] arg = null)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,40437,40956);

f_23116_40437_40955(f_23116_40437_40462(this, source), f_23116_40702_40787(f_23116_40702_40750(ErrorCode.WRN_InvalidMainSig, "Main"), "B.Main(string[*,*])"), f_23116_40916_40954(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,40240,40967);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_40437_40462(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40437, 40462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_40702_40750(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40702, 40750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_40702_40787(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40702, 40787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_40916_40954(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40916, 40954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_40437_40955(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 40437, 40955);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,40240,40967);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,40240,40967);
}
		}

[Fact]
        public void MainAsExtensionMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,40979,41868);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,41055,41185);

string 
source = @"
class B
{
}
static class Extension
{
    public static void Main(this B x, string[] args)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,41199,41857);

f_23116_41199_41856(f_23116_41199_41284(source, options: TestOptions.ReleaseExe), f_23116_41595_41688(f_23116_41595_41643(ErrorCode.WRN_InvalidMainSig, "Main"), "Extension.Main(B, string[])"), f_23116_41817_41855(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,40979,41868);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_41199_41284(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40AndSystemCore( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 41199, 41284);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_41595_41643(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 41595, 41643);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_41595_41688(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 41595, 41688);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_41817_41855(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 41817, 41855);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_41199_41856(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 41199, 41856);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,40979,41868);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,40979,41868);
}
		}

[Fact]
        public void MainAsExtensionMethod_1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,41880,42729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,41958,42082);

string 
source = @"
class B
{
}
static class Extension
{
    public static int Main(this B x)
    { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,42096,42718);

f_23116_42096_42717(f_23116_42096_42181(source, options: TestOptions.ReleaseExe), f_23116_42466_42549(f_23116_42466_42514(ErrorCode.WRN_InvalidMainSig, "Main"), "Extension.Main(B)"), f_23116_42678_42716(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,41880,42729);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_42096_42181(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40AndSystemCore( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42096, 42181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_42466_42514(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42466, 42514);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_42466_42549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42466, 42549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_42678_42716(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42678, 42716);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_42096_42717(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42096, 42717);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,41880,42729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,41880,42729);
}
		}

[Fact]
        public void MainAsExtensionMethod_2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,42741,43599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,42819,42935);

string 
source = @"
static class Extension
{
    public static int Main(this string str)
    { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,42949,43588);

f_23116_42949_43587(f_23116_42949_43034(source, options: TestOptions.ReleaseExe), f_23116_43331_43419(f_23116_43331_43379(ErrorCode.WRN_InvalidMainSig, "Main"), "Extension.Main(string)"), f_23116_43548_43586(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,42741,43599);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_42949_43034(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40AndSystemCore( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42949, 43034);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_43331_43379(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 43331, 43379);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_43331_43419(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 43331, 43419);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_43548_43586(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 43548, 43586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_42949_43587(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 42949, 43587);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,42741,43599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,42741,43599);
}
		}

[Fact]
        public void MainIsCaseSensitive()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,43611,44442);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,43685,44205);

string 
source = @"
class B
{
    static void main() { }
    static void main(string[] args) { }
    static void MAIN() { }
    static void MAIN(string[] args) { }
    static void mAin() { }
    static void mAin(string[] args) { }
}
class C
{
    static int main() { return 1; }
    static int main(string[] args) { return 1; }
    static int MAIN() { return 1; }
    static int MAIN(string[] args) { return 1; }
    static int maiN() { return 1; }
    static int maiN(string[] args) { return 1; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,44219,44431);

f_23116_44219_44430(f_23116_44219_44244(this, source), f_23116_44391_44429(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,43611,44442);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_44219_44244(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44219, 44244);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_44391_44429(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44391, 44429);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_44219_44430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44219, 44430);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,43611,44442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,43611,44442);
}
		}

[WorkItem(543468, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543468")]
        [Fact()]
        public void RefParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,44454,45158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,44622,44704);

string 
source = @"
class C
{
    static void Main(ref string[] args) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,44718,45147);

f_23116_44718_45146(f_23116_44718_44743(this, source), f_23116_44892_44978(f_23116_44892_44940(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(ref string[])"), f_23116_45107_45145(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,44454,45158);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_44718_44743(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44718, 44743);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_44892_44940(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44892, 44940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_44892_44978(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44892, 44978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_45107_45145(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45107, 45145);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_44718_45146(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 44718, 45146);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,44454,45158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,44454,45158);
}
		}

[WorkItem(544478, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/544478")]
        [Fact()]
        public void ArglistParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,45170,46165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,45342,45486);

string 
source = @"
class C
{
    static void Main(__arglist) { }
}

class D
{
    static void Main(string[] array, __arglist) { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,45500,46154);

f_23116_45500_46153(f_23116_45500_45525(this, source), f_23116_45671_45754(f_23116_45671_45719(ErrorCode.WRN_InvalidMainSig, "Main"), "C.Main(__arglist)"), f_23116_45892_45985(f_23116_45892_45940(ErrorCode.WRN_InvalidMainSig, "Main"), "D.Main(string[], __arglist)"), f_23116_46114_46152(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,45170,46165);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_45500_45525(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45500, 45525);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_45671_45719(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45671, 45719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_45671_45754(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45671, 45754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_45892_45940(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45892, 45940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_45892_45985(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45892, 45985);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_46114_46152(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46114, 46152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_45500_46153(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 45500, 46153);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,45170,46165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,45170,46165);
}
		}

[WorkItem(543467, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543467")]
        [Fact()]
        public void OutParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,46177,46987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,46345,46445);

string 
source = @"
class Program
{
    static void Main(out string[] args) {args = null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,46459,46976);

f_23116_46459_46975(f_23116_46459_46484(this, source), f_23116_46715_46807(f_23116_46715_46763(ErrorCode.WRN_InvalidMainSig, "Main"), "Program.Main(out string[])"), f_23116_46936_46974(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,46177,46987);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_46459_46484(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46459, 46484);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_46715_46763(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46715, 46763);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_46715_46807(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46715, 46807);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_46936_46974(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46936, 46974);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_46459_46975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 46459, 46975);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,46177,46987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,46177,46987);
}
		}

[Fact()]
        public void MainInPrivateClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,46999,47270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47074,47199);

string 
source = @"
class C1
{
    private struct C2
    {
        static void Main()
        {
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47213,47259);

f_23116_47213_47258(f_23116_47213_47238(this, source));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,46999,47270);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47213_47238(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47213, 47238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47213_47258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47213, 47258);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,46999,47270);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,46999,47270);
}
		}

[Fact()]
        public void PrivateMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,47282,47517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47350,47446);

string 
source = @"
class C
{
    private static void Main(string[] args)
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47460,47506);

f_23116_47460_47505(f_23116_47460_47485(this, source));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,47282,47517);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47460_47485(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47460, 47485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47460_47505(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47460, 47505);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,47282,47517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,47282,47517);
}
		}

[Fact()]
        public void MultipleEntryPoint_Inherit()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,47529,48435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47612,47770);

string 
source = @"
class BaseClass
{
    public static void Main()
    { }
}
class Derived : BaseClass
{
    public static void Main()
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,47784,48424);

f_23116_47784_48423(f_23116_47784_47809(this, source), f_23116_48044_48141(f_23116_48044_48089(ErrorCode.WRN_NewRequired, "Main"), "Derived.Main()", "BaseClass.Main()"), f_23116_48369_48422(ErrorCode.ERR_MultipleEntryPoints, "Main"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,47529,48435);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47784_47809(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47784, 47809);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_48044_48089(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48044, 48089);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_48044_48141(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48044, 48141);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_48369_48422(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48369, 48422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_47784_48423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 47784, 48423);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,47529,48435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,47529,48435);
}
		}

[Fact()]
        public void ERR_NoEntryPoint_MainMustStatic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,48447,48918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,48535,48681);

string 
source = @"
class C
{
    private void Main(string[] args)
    {
    }
    private int Main()
    {
        return 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,48695,48907);

f_23116_48695_48906(f_23116_48695_48720(this, source), f_23116_48867_48905(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,48447,48918);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_48695_48720(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48695, 48720);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_48867_48905(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48867, 48905);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_48695_48906(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 48695, 48906);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,48447,48918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,48447,48918);
}
		}

[Fact()]
        public void ERR_NoEntryPoint_MainAsConstructor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,48930,49328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,49021,49091);

string 
source = @"
static class Main
{
    static Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,49105,49317);

f_23116_49105_49316(f_23116_49105_49130(this, source), f_23116_49277_49315(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,48930,49328);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_49105_49130(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EntryPointTests
this_param,string
source)
{
var return_v = this_param.CompileConsoleApp( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49105, 49130);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_49277_49315(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49277, 49315);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_49105_49316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49105, 49316);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,48930,49328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,48930,49328);
}
		}

[Fact()]
        public void ExplicitMainType_MainIsNotStatic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,49340,49811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,49429,49487);

string 
source = @"
class D
{
    void Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,49501,49800);

f_23116_49501_49799(f_23116_49501_49581(source, options: f_23116_49536_49580(TestOptions.ReleaseExe, "D")), f_23116_49735_49798(f_23116_49735_49779(ErrorCode.ERR_NoMainInClass, "D"), "D"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,49340,49811);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_49536_49580(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49536, 49580);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_49501_49581(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49501, 49581);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_49735_49779(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49735, 49779);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_49735_49798(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49735, 49798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_49501_49799(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 49501, 49799);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,49340,49811);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,49340,49811);
}
		}

[WorkItem(753028, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/753028")]
        [Fact]
        public void RootMemberNamedScript()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,49823,51858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,49991,50005);

string 
source
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50021,50054);

source = @"namespace Script { }";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50068,50313);

f_23116_50068_50312(f_23116_50068_50126(source, options: TestOptions.ReleaseExe), f_23116_50273_50311(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50329,50358);

source = @"class Script { }";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50372,50617);

f_23116_50372_50616(f_23116_50372_50430(source, options: TestOptions.ReleaseExe), f_23116_50577_50615(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50633,50663);

source = @"struct Script { }";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50677,50922);

f_23116_50677_50921(f_23116_50677_50735(source, options: TestOptions.ReleaseExe), f_23116_50882_50920(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50938,50974);

source = @"interface Script<T> { }";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,50988,51233);

f_23116_50988_51232(f_23116_50988_51046(source, options: TestOptions.ReleaseExe), f_23116_51193_51231(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,51249,51277);

source = @"enum Script { }";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,51291,51536);

f_23116_51291_51535(f_23116_51291_51349(source, options: TestOptions.ReleaseExe), f_23116_51496_51534(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,51552,51588);

source = @"delegate void Script();";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,51602,51847);

f_23116_51602_51846(f_23116_51602_51660(source, options: TestOptions.ReleaseExe), f_23116_51807_51845(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,49823,51858);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50068_50126(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50068, 50126);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_50273_50311(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50273, 50311);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50068_50312(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50068, 50312);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50372_50430(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50372, 50430);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_50577_50615(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50577, 50615);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50372_50616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50372, 50616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50677_50735(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50677, 50735);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_50882_50920(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50882, 50920);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50677_50921(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50677, 50921);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50988_51046(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50988, 51046);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_51193_51231(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51193, 51231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_50988_51232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 50988, 51232);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_51291_51349(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51291, 51349);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_51496_51534(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51496, 51534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_51291_51535(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51291, 51535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_51602_51660(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51602, 51660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_51807_51845(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51807, 51845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_51602_51846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 51602, 51846);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,49823,51858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,49823,51858);
}
		}

[Fact()]
        public void ExplicitMainType_ClassNameIsEmpty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,51870,52325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,51960,52025);

string 
source = @"
class D
{
    static void Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,52039,52314);

f_23116_52039_52313(f_23116_52039_52128(source, options: f_23116_52074_52127(TestOptions.ReleaseExe, string.Empty)), f_23116_52209_52294(f_23116_52209_52260(ErrorCode.ERR_BadCompilationOptionValue), "MainTypeName", ""));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,51870,52325);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_52074_52127(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52074, 52127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52039_52128(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52039, 52128);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_52209_52260(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52209, 52260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_52209_52294(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52209, 52294);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52039_52313(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52039, 52313);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,51870,52325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,51870,52325);
}
		}

[Fact()]
        public void ExplicitMainType_NoMainInClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,52337,52785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,52424,52461);

string 
source = @"
class D
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,52475,52774);

f_23116_52475_52773(f_23116_52475_52555(source, options: f_23116_52510_52554(TestOptions.ReleaseExe, "D")), f_23116_52709_52772(f_23116_52709_52753(ErrorCode.ERR_NoMainInClass, "D"), "D"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,52337,52785);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_52510_52554(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52510, 52554);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52475_52555(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52475, 52555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_52709_52753(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52709, 52753);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_52709_52772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52709, 52772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52475_52773(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52475, 52773);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,52337,52785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,52337,52785);
}
		}

[Fact()]
        public void ExplicitMainType_CaseSensitive()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,52797,53232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,52884,52947);

string 
source = @"
class D
{
    static void Main(){}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,52961,53221);

f_23116_52961_53220(f_23116_52961_53041(source, options: f_23116_52996_53040(TestOptions.ReleaseExe, "d")), f_23116_53157_53219(f_23116_53157_53200(ErrorCode.ERR_MainClassNotFound), "d"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,52797,53232);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_52996_53040(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52996, 53040);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52961_53041(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52961, 53041);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_53157_53200(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53157, 53200);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_53157_53219(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53157, 53219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_52961_53220(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 52961, 53220);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,52797,53232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,52797,53232);
}
		}

[Fact()]
        public void ExplicitMainType_Extension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,53244,54502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,53327,53457);

string 
source = @"
class B
{
}
static class extension
{
    public static void Main(this B x, string[] args)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,53471,53797);

f_23116_53471_53796(f_23116_53471_53578(source, options: f_23116_53533_53577(TestOptions.ReleaseExe, "B")), f_23116_53732_53795(f_23116_53732_53776(ErrorCode.ERR_NoMainInClass, "B"), "B"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,53813,54491);

f_23116_53813_54490(f_23116_53813_53928(source, options: f_23116_53875_53927(TestOptions.ReleaseExe, "extension")), f_23116_54157_54250(f_23116_54157_54205(ErrorCode.WRN_InvalidMainSig, "Main"), "extension.Main(B, string[])"), f_23116_54410_54489(f_23116_54410_54462(ErrorCode.ERR_NoMainInClass, "extension"), "extension"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,53244,54502);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_53533_53577(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53533, 53577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_53471_53578(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40AndSystemCore( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53471, 53578);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_53732_53776(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53732, 53776);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_53732_53795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53732, 53795);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_53471_53796(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53471, 53796);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_53875_53927(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53875, 53927);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_53813_53928(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40AndSystemCore( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53813, 53928);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54157_54205(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54157, 54205);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54157_54250(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54157, 54250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54410_54462(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54410, 54462);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54410_54489(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54410, 54489);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_53813_54490(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 53813, 54490);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,53244,54502);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,53244,54502);
}
		}

[Fact()]
        public void ExplicitMainType_MainAsConstructor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,54514,55022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,54605,54675);

string 
source = @"
static class Main
{
    static Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,54689,55011);

f_23116_54689_55010(f_23116_54689_54772(source, options: f_23116_54724_54771(TestOptions.ReleaseExe, "Main")), f_23116_54940_55009(f_23116_54940_54987(ErrorCode.ERR_NoMainInClass, "Main"), "Main"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,54514,55022);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_54724_54771(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54724, 54771);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_54689_54772(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54689, 54772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54940_54987(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54940, 54987);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_54940_55009(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54940, 55009);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_54689_55010(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 54689, 55010);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,54514,55022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,54514,55022);
}
		}

[WorkItem(543511, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543511")]
        [Fact()]
        public void ExplicitMainType_OneDefineTwoDeclareValidMainForPartial()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,55034,55583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,55238,55451);

string 
source = @"
partial class Program
{
}
partial class Program
{
    static partial void Main();
    static partial void Main(string[] args);
    static partial void Main(string[] args)
    { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,55465,55572);

f_23116_55465_55571(f_23116_55465_55551(source, options: f_23116_55500_55550(TestOptions.ReleaseExe, "Program")));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,55034,55583);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23116_55500_55550(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
name)
{
var return_v = this_param.WithMainTypeName( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 55500, 55550);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_55465_55551(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 55465, 55551);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_55465_55571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 55465, 55571);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,55034,55583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,55034,55583);
}
		}

[Fact, WorkItem(543512, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543512")]
        public void DynamicParameterForMain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,55595,56290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,55904,56043);

string 
source = @"
class Mybase
{
static void Main(dynamic x=null) { }
}
class Myderive : Mybase
{
    static void Main() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56057,56279);

f_23116_56057_56278(f_23116_56057_56132(source, options: TestOptions.ReleaseExe), f_23116_56191_56277(f_23116_56191_56239(ErrorCode.WRN_InvalidMainSig, "Main"), "Mybase.Main(dynamic)"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,55595,56290);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56057_56132(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56057, 56132);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_56191_56239(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56191, 56239);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_56191_56277(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56191, 56277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56057_56278(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56057, 56278);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,55595,56290);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,55595,56290);
}
		}

[WorkItem(630763, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/630763")]
        [Fact()]
        public void Bug630763()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,56302,57359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56460,56562);

var 
source = @"
public class C
{
    public static int Main()
    {
        return 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56578,56655);

var 
compilation = f_23116_56596_56654(source, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56669,56701);

f_23116_56669_56700(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56717,56795);

var 
netModule = f_23116_56733_56794(source, options: TestOptions.ReleaseModule)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,56811,57140);

compilation = f_23116_56825_57139("", new MetadataReference[] { f_23116_56930_56962(netModule)}, options: TestOptions.ReleaseExe, assemblyName: "Bug630763");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57156,57348);

f_23116_57156_57347(
            compilation, f_23116_57290_57328(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,56302,57359);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56596_56654(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56596, 56654);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56669_56700(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56669, 56700);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56733_56794(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56733, 56794);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23116_56930_56962(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56930, 56962);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_56825_57139(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 56825, 57139);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_57290_57328(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57290, 57328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_57156_57347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57156, 57347);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,56302,57359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,56302,57359);
}
		}

[Fact, WorkItem(12113, "https://github.com/dotnet/roslyn/issues/12113")]
        public void LazyEntryPoint()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,57371,58231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57506,57630);

string 
source = @"
class Program
{
    public static void Main() {}
    public static void Main(string[] args) {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57644,57719);

var 
compilation = f_23116_57662_57718(source, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57733,57802);

var 
model = f_23116_57745_57801(compilation, f_23116_57774_57797(compilation)[0])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57816,57853);

f_23116_57816_57852(f_23116_57829_57851(model));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,57867,58220);

f_23116_57867_58219(            compilation, f_23116_58127_58200(f_23116_58127_58180(ErrorCode.ERR_MultipleEntryPoints, "Main"), 4, 24));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,57371,58231);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_57662_57718(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57662, 57718);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
f_23116_57774_57797(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23116, 57774, 57797);
return return_v;
}


Microsoft.CodeAnalysis.SemanticModel
f_23116_57745_57801(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree)
{
var return_v = this_param.GetSemanticModel( syntaxTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57745, 57801);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
f_23116_57829_57851(Microsoft.CodeAnalysis.SemanticModel
this_param)
{
var return_v = this_param.GetDiagnostics();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57829, 57851);
return return_v;
}


int
f_23116_57816_57852(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57816, 57852);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_58127_58180(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58127, 58180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_58127_58200(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58127, 58200);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_57867_58219(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 57867, 58219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,57371,58231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,57371,58231);
}
		}

[WorkItem(17923, "https://github.com/dotnet/roslyn/issues/17923")]
        [Fact]
        [CompilerTrait(CompilerFeature.RefLocalsReturns)]
        public void RefIntReturnMainEmpty()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,58243,59174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,58454,58560);

var 
source = @"
class Program
{
    public static ref int Main() { throw new System.Exception(); }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,58576,58651);

var 
compilation = f_23116_58594_58650(source, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,58665,59163);

f_23116_58665_59162(            compilation, f_23116_58875_58975(f_23116_58875_58955(f_23116_58875_58923(ErrorCode.WRN_InvalidMainSig, "Main"), "Program.Main()"), 4, 27), f_23116_59104_59161(f_23116_59104_59142(ErrorCode.ERR_NoEntryPoint), 1, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,58243,59174);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_58594_58650(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58594, 58650);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_58875_58923(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58875, 58923);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_58875_58955(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58875, 58955);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_58875_58975(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58875, 58975);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_59104_59142(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59104, 59142);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_59104_59161(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59104, 59161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_58665_59162(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 58665, 59162);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,58243,59174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,58243,59174);
}
		}

[WorkItem(17923, "https://github.com/dotnet/roslyn/issues/17923")]
        [Fact]
        [CompilerTrait(CompilerFeature.RefLocalsReturns)]
        public void RefIntReturnMainWithParams()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23116,59186,60156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,59402,59521);

var 
source = @"
class Program
{
    public static ref int Main(string[] args) { throw new System.Exception(); }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,59537,59612);

var 
compilation = f_23116_59555_59611(source, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23116,59626,60145);

f_23116_59626_60144(            compilation, f_23116_59888_59976(f_23116_59888_59936(ErrorCode.WRN_InvalidMainSig, "Main"), "Program.Main(string[])"), f_23116_60105_60143(ErrorCode.ERR_NoEntryPoint));
DynAbs.Tracing.TraceSender.TraceExitMethod(23116,59186,60156);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_59555_59611(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59555, 59611);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_59888_59936(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59888, 59936);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_59888_59976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59888, 59976);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23116_60105_60143(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 60105, 60143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23116_59626_60144(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23116, 59626, 60144);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23116,59186,60156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,59186,60156);
}
		}

public EntryPointTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23116,437,60163);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23116,437,60163);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,437,60163);
}


static EntryPointTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23116,437,60163);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23116,437,60163);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23116,437,60163);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23116,437,60163);
}
}
