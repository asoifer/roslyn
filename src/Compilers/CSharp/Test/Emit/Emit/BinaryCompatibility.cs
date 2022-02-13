// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public class BinaryCompatibility : EmitMetadataTestBase
{
[Fact]
        public void InvokeVirtualBoundToOriginal()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23098,474,2523);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,1092,1313);

var 
lib0 = @"
public class Base
{
    public virtual void M() { System.Console.WriteLine(""Base0""); }
}
public class Derived : Base
{
    public override void M() { System.Console.WriteLine(""Derived0""); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,1327,1458);

var 
lib0Image = f_23098_1343_1457(f_23098_1343_1434(lib0, options: TestOptions.ReleaseDll, assemblyName: "lib"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,1474,1698);

var 
lib1 = @"
public class Base
{
    public virtual void M() { System.Console.WriteLine(""Base1""); }
}
public class Derived : Base
{
    public new virtual void M() { System.Console.WriteLine(""Derived1""); }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,1712,1843);

var 
lib1Image = f_23098_1728_1842(f_23098_1728_1819(lib1, options: TestOptions.ReleaseDll, assemblyName: "lib"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,1859,1999);

var 
client = @"
public class Client
{
    public static void M()
    {
        Derived d = new Derived();
        d.M();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,2013,2160);

var 
clientImage = f_23098_2031_2159(f_23098_2031_2136(client, references: new[] { lib0Image }, options: TestOptions.ReleaseDll))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,2176,2290);

var 
program = @"
public class Program
{
    public static void Main()
    {
        Client.M();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,2304,2442);

var 
compilation = f_23098_2322_2441(program, references: new[] { lib1Image, clientImage }, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23098,2456,2512);

f_23098_2456_2511(this, compilation, expectedOutput: @"Base1");
DynAbs.Tracing.TraceSender.TraceExitMethod(23098,474,2523);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23098_1343_1434(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib46( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 1343, 1434);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23098_1343_1457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 1343, 1457);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23098_1728_1819(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib46( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 1728, 1819);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23098_1728_1842(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 1728, 1842);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23098_2031_2136(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib46( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 2031, 2136);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23098_2031_2159(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 2031, 2159);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23098_2322_2441(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib46( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 2322, 2441);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23098_2456_2511(Microsoft.CodeAnalysis.CSharp.UnitTests.BinaryCompatibility
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23098, 2456, 2511);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23098,474,2523);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23098,474,2523);
}
		}

public BinaryCompatibility()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23098,402,2530);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23098,402,2530);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23098,402,2530);
}


static BinaryCompatibility()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23098,402,2530);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23098,402,2530);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23098,402,2530);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23098,402,2530);
}
}
