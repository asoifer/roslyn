// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Xunit;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class EmitCustomModifiers : EmitMetadataTestBase
{
[Fact]
        public void Test1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,656,1420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,716,762);

var 
mscorlibRef = f_23112_734_761()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,776,1099);

string 
source = @"
public class A
{
    unsafe public static void Main()
    {
        Modifiers.F1(1);
        Modifiers.F2(1);
        Modifiers.F3(1);

        System.Console.WriteLine(Modifiers.F7());
        Modifiers.F8();
        Modifiers.F9();
        Modifiers.F10();

        C4.M4();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,1113,1289);

var 
c = f_23112_1121_1288(source, new[] { f_23112_1172_1229()}, options: TestOptions.UnsafeReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,1305,1409);

f_23112_1305_1408(this, c, verify: Verification.Passes, expectedOutput:
@"F1
F2
F3
F7
F8
F9
F10
M4
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,656,1420);

Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_734_761()
{
var return_v = TestMetadata.Net40.mscorlib;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 734, 761);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_1172_1229()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.Modifiers.dll ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 1172, 1229);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_1121_1288(string
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 1121, 1288);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_1305_1408(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 1305, 1408);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,656,1420);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,656,1420);
}
		}

[Fact]
        public void TestSingleInterfaceImplementationWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,1552,2687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,1659,2278);

var 
text = @"
class Class : CppCli.CppInterface1
{
    //copy modifiers (even though dev10 doesn't)
    void CppCli.CppInterface1.Method1(int x)
    {
        System.Console.WriteLine(""Class.Method1({0})"", x);
    }

    //synthesize bridge method
    public void Method2(int x)
    {
        System.Console.WriteLine(""Class.Method2({0})"", x);
    }

    public static void Main()
    {
        Class c = new Class();
        CppCli.CppInterface1 ic = c;

        //c.Method1(1); //only available through iface
        c.Method2(2);
        ic.Method1(3);
        ic.Method2(4);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,2294,2387);

var 
expectedOutput = f_23112_2315_2386(@"
Class.Method2(2)
Class.Method1(3)
Class.Method2(4)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,2403,2484);

var 
ilAssemblyReference = f_23112_2429_2483()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,2500,2676);

f_23112_2500_2675(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,1552,2687);

string
f_23112_2315_2386(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 2315, 2386);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_2429_2483()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 2429, 2483);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_2500_2675(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 2500, 2675);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,1552,2687);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,1552,2687);
}
		}

[Fact]
        public void TestMultipleInterfaceImplementationWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,2832,4303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,2941,3856);

var 
text = @"
class Class : CppCli.CppInterface1, CppCli.CppInterface2
{
    //copy modifiers (even though dev10 doesn't)
    void CppCli.CppInterface1.Method1(int x)
    {
        System.Console.WriteLine(""Class.Method1a({0})"", x);
    }

    //copy modifiers (even though dev10 doesn't)
    void CppCli.CppInterface2.Method1(int x)
    {
        System.Console.WriteLine(""Class.Method1b({0})"", x);
    }

    //synthesize two bridge methods
    public void Method2(int x)
    {
        System.Console.WriteLine(""Class.Method2({0})"", x);
    }

    public static void Main()
    {
        Class c = new Class();
        CppCli.CppInterface1 i1c = c;
        CppCli.CppInterface2 i2c = c;

        //c.Method1(1); //only available through ifaces
        c.Method2(2);
        i1c.Method1(3);
        i1c.Method2(4);
        i2c.Method1(5);
        i2c.Method2(6);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,3872,4003);

var 
expectedOutput = f_23112_3893_4002(@"
Class.Method2(2)
Class.Method1a(3)
Class.Method2(4)
Class.Method1b(5)
Class.Method2(6)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,4019,4100);

var 
ilAssemblyReference = f_23112_4045_4099()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,4116,4292);

f_23112_4116_4291(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,2832,4303);

string
f_23112_3893_4002(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 3893, 4002);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_4045_4099()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 4045, 4099);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_4116_4291(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 4116, 4291);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,2832,4303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,2832,4303);
}
		}

[Fact]
        public void TestSingleOverrideWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,4667,5856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,4759,5395);

var 
text = @"
class Class : CppCli.CppBase1
{
    //copies custom modifiers
    public override void VirtualMethod(int x)
    {
        System.Console.WriteLine(""Class.VirtualMethod({0})"", x);
    }

    //new required, does not copy custom modifiers
    public new void NonVirtualMethod(int x)
    {
        System.Console.WriteLine(""Class.NonVirtualMethod({0})"", x);
    }

    public static void Main()
    {
        Class c = new Class();
        CppCli.CppBase1 bc = c;

        c.VirtualMethod(1);
        c.NonVirtualMethod(2);
        bc.VirtualMethod(3);
        bc.NonVirtualMethod(4);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,5411,5556);

var 
expectedOutput = f_23112_5432_5555(@"
Class.VirtualMethod(1)
Class.NonVirtualMethod(2)
Class.VirtualMethod(3)
CppBase1::NonVirtualMethod(4)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,5572,5653);

var 
ilAssemblyReference = f_23112_5598_5652()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,5669,5845);

f_23112_5669_5844(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,4667,5856);

string
f_23112_5432_5555(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 5432, 5555);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_5598_5652()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 5598, 5652);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_5669_5844(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 5669, 5844);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,4667,5856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,4667,5856);
}
		}

[Fact]
        public void TestRepeatedOverrideWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,6113,7848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,6207,7326);

var 
text = @"
class Base : CppCli.CppBase1
{
    //copies custom modifiers
    public override void VirtualMethod(int x)
    {
        System.Console.WriteLine(""Base.VirtualMethod({0})"", x);
    }

    //new required, does not copy custom modifiers
    public new virtual void NonVirtualMethod(int x)
    {
        System.Console.WriteLine(""Base.NonVirtualMethod({0})"", x);
    }
}

class Derived : Base
{
    //copies custom modifiers
    public override void VirtualMethod(int x)
    {
        System.Console.WriteLine(""Derived.VirtualMethod({0})"", x);
    }

    //would copy custom modifiers, but there are none
    public override void NonVirtualMethod(int x)
    {
        System.Console.WriteLine(""Derived.NonVirtualMethod({0})"", x);
    }

    public static void Main()
    {
        Derived d = new Derived();
        Base bd = d;
        CppCli.CppBase1 bbd = d;

        d.VirtualMethod(1);
        d.NonVirtualMethod(2);
        bd.VirtualMethod(3);
        bd.NonVirtualMethod(4);
        bbd.VirtualMethod(5);
        bbd.NonVirtualMethod(6);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,7342,7548);

var 
expectedOutput = f_23112_7363_7547(@"
Derived.VirtualMethod(1)
Derived.NonVirtualMethod(2)
Derived.VirtualMethod(3)
Derived.NonVirtualMethod(4)
Derived.VirtualMethod(5)
CppBase1::NonVirtualMethod(6)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,7564,7645);

var 
ilAssemblyReference = f_23112_7590_7644()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,7661,7837);

f_23112_7661_7836(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,6113,7848);

string
f_23112_7363_7547(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 7363, 7547);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_7590_7644()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 7590, 7644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_7661_7836(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 7661, 7836);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,6113,7848);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,6113,7848);
}
		}

[Fact]
        public void TestImplicitImplementationInBaseWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,8334,10243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,8440,9629);

var 
text = @"
class Class1 : CppCli.CppBase2, CppCli.CppInterface1
{
}

class Class2 : CppCli.CppBase2, CppCli.CppInterface1
{
    //copies custom modifiers
    public override void Method1(int x)
    {
        System.Console.WriteLine(""Class2.Method1({0})"", x);
    }
}

class Class3 : CppCli.CppBase2, CppCli.CppInterface1
{
    //needs a bridge, since custom modifiers are not copied
    public new void Method1(int x)
    {
        System.Console.WriteLine(""Class3.Method1({0})"", x);
    }
}

class E
{
    static void Main()
    {
        Class1 c1 = new Class1();
        CppCli.CppInterface1 ic1 = c1;

        c1.Method1(1);
        c1.Method2(2);
        ic1.Method1(3);
        ic1.Method2(4);

        System.Console.WriteLine();

        Class2 c2 = new Class2();
        CppCli.CppInterface1 ic2 = c2;

        c2.Method1(5);
        c2.Method2(6);
        ic2.Method1(7);
        ic2.Method2(8);

        System.Console.WriteLine();

        Class3 c3 = new Class3();
        CppCli.CppInterface1 ic3 = c3;

        c3.Method1(9);
        c3.Method2(10);
        ic3.Method1(11);
        ic3.Method2(12);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,9645,9943);

var 
expectedOutput = f_23112_9666_9942(@"
CppBase2::Method1(1)
CppBase2::Method2(2)
CppBase2::Method1(3)
CppBase2::Method2(4)

Class2.Method1(5)
CppBase2::Method2(6)
Class2.Method1(7)
CppBase2::Method2(8)

Class3.Method1(9)
CppBase2::Method2(10)
Class3.Method1(11)
CppBase2::Method2(12)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,9959,10040);

var 
ilAssemblyReference = f_23112_9985_10039()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,10056,10232);

f_23112_10056_10231(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,8334,10243);

string
f_23112_9666_9942(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 9666, 9942);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_9985_10039()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 9985, 10039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_10056_10231(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 10056, 10231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,8334,10243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,8334,10243);
}
		}

[Fact]
        public void TestImplicitImplementationBestMatchWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,10541,12618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,10650,11896);

var 
text = @"
    class Class1 : CppCli.CppBestMatchBase2, CppCli.CppBestMatchInterface
    {
    }

    class Class2 : CppCli.CppBestMatchBase2, CppCli.CppBestMatchInterface
    {
        public new virtual void Method(int x, int y)
        {
            System.Console.WriteLine(""Class2.Method({0},{1})"", x, y);
        }
    }

class E
{
    static void Main()
    {
        new Class2().Method(1, 2);
        new Class1().Method(3, 4);
        new CppCli.CppBestMatchBase2().Method(5, 6);
        new CppCli.CppBestMatchBase1().Method(7, 8);

        System.Console.WriteLine();

        Class1 c1 = new Class1();
        CppCli.CppBestMatchBase2 b2c1 = c1;
        CppCli.CppBestMatchBase1 b1c1 = c1;
        CppCli.CppBestMatchInterface ic1 = c1;

        c1.Method(9, 10);
        b2c1.Method(11, 12);
        b1c1.Method(13, 14);
        ic1.Method(15, 16);

        System.Console.WriteLine();

        Class2 c2 = new Class2();
        CppCli.CppBestMatchBase2 b2c2 = c2;
        CppCli.CppBestMatchBase1 b1c2 = c2;
        CppCli.CppBestMatchInterface ic2 = c2;

        c2.Method(17, 18);
        b2c2.Method(19, 20);
        b1c2.Method(21, 22);
        ic2.Method(23, 24);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,11912,12318);

var 
expectedOutput = f_23112_11933_12317(@"
Class2.Method(1,2)
CppBestMatchBase2::Method(3,4)
CppBestMatchBase2::Method(5,6)
CppBestMatchBase1::Method(7,8)

CppBestMatchBase2::Method(9,10)
CppBestMatchBase2::Method(11,12)
CppBestMatchBase1::Method(13,14)
CppBestMatchBase2::Method(15,16)

Class2.Method(17,18)
CppBestMatchBase2::Method(19,20)
CppBestMatchBase1::Method(21,22)
Class2.Method(23,24)
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,12334,12415);

var 
ilAssemblyReference = f_23112_12360_12414()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,12431,12607);

f_23112_12431_12606(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,10541,12618);

string
f_23112_11933_12317(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 11933, 12317);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_12360_12414()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.CppCli.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 12360, 12414);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_12431_12606(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 12431, 12606);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,10541,12618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,10541,12618);
}
		}

[Fact]
        public void TestGenericsWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,12752,14294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,12838,13801);

var 
text = @"
    class Derived1<U, V> : Outer<U>.Inner<V>
    {
        public override void Method<W>(U[] x, V[] y, W[] z)
        {
            System.Console.WriteLine(""Derived1.Method({0}, {1}, {2})"", x.GetType().Name, y.GetType().Name, z.GetType().Name);
        }
    }

    class Derived2 : Derived1<long, short>
    {
        public override void Method<Z>(long[] x, short[] y, Z[] z)
        {
            System.Console.WriteLine(""Derived2.Method({0}, {1}, {2})"", x.GetType().Name, y.GetType().Name, z.GetType().Name);
        }
    }

class E
{
    static void Main()
    {
        Derived2 d2 = new Derived2();
        Derived1<long, short> d1d2 = d2;
        Outer<long>.Inner<short> oid2 = d2;

        d2.Method<string>(new long[0], new short[0], new string[0]);
        d1d2.Method<object>(new long[1], new short[1], new object[1]);
        oid2.Method<float>(new long[2], new short[2], new float[2]);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,13817,13991);

var 
expectedOutput = f_23112_13838_13990(@"
Derived2.Method(Int64[], Int16[], String[])
Derived2.Method(Int64[], Int16[], Object[])
Derived2.Method(Int64[], Int16[], Single[])
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,14007,14091);

var 
ilAssemblyReference = f_23112_14033_14090()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,14107,14283);

f_23112_14107_14282(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,12752,14294);

string
f_23112_13838_13990(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 13838, 13990);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_14033_14090()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.Modifiers.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 14033, 14090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_14107_14282(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 14107, 14282);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,12752,14294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,12752,14294);
}
		}

[Fact]
        public void TestAssignmentWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,14439,15431);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,14527,15038);

var 
text = @"
class C : I3
{
    void I3.M1(int[] arrayWithCustomModifiers)
    {
        System.Console.WriteLine(arrayWithCustomModifiers);
        int[] a = arrayWithCustomModifiers; //RHS type is actually int const [] const
        System.Console.WriteLine(a);
        int i = arrayWithCustomModifiers[0]; //RHS type is actually int const
        System.Console.WriteLine(i);
    }
}

class E
{
    static void Main()
    {
        I3 ic = new C();
        ic.M1(new int[2]);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,15054,15128);

var 
expectedOutput = f_23112_15075_15127(@"
System.Int32[]
System.Int32[]
0
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,15144,15228);

var 
ilAssemblyReference = f_23112_15170_15227()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,15244,15420);

f_23112_15244_15419(this, source: text, references: new MetadataReference[] { ilAssemblyReference }, expectedOutput: expectedOutput);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,14439,15431);

string
f_23112_15075_15127(string
this_param)
{
var return_v = this_param.TrimStart();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 15075, 15127);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23112_15170_15227()
{
var return_v = TestReferences.SymbolsTests.CustomModifiers.Modifiers.dll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 15170, 15227);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_15244_15419(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 15244, 15419);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,14439,15431);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,14439,15431);
}
		}

[Fact]
        [WorkItem(737971, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/737971")]
        public void ByRefBeforeCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,15443,16995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,15616,16207);

var 
il = @"
.class public auto ansi beforefieldinit C
       extends [mscorlib]System.Object
{
  // Increments argument
  .method public hidebysig static void Incr(uint32 modopt([mscorlib]System.Runtime.CompilerServices.IsLong) & a) cil managed
  {
    ldarg.0
    dup
    ldind.u4
    ldc.i4.1
    add
    stind.i4
    ret
  } // end of method Test::Incr

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    ldarg.0
    call       instance void [mscorlib]System.Object::.ctor()
    ret
  }
} // end of class C
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16223,16381);

var 
source = @"
class Test
{
    static void Main()
    {
        uint u = 1;
        C.Incr(ref u);
        System.Console.WriteLine(u);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16395,16516);

var 
comp = f_23112_16406_16515(source, il, TargetFramework.Mscorlib40, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16532,16596);

var 
type = f_23112_16543_16595(f_23112_16543_16563(comp), "C")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16610,16660);

var 
method = f_23112_16623_16659(type, "Incr")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16674,16717);

var 
parameter = method.Parameters.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16733,16778);

f_23112_16733_16777(RefKind.Ref, f_23112_16759_16776(parameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16792,16860);

f_23112_16792_16859(parameter.TypeWithAnnotations.CustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16874,16924);

f_23112_16874_16923(parameter.RefCustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,16940,16984);

f_23112_16940_16983(this, comp, expectedOutput: "2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,15443,16995);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_16406_16515(string
source,string
ilSource,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithILAndMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource, targetFramework, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16406, 16515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
f_23112_16543_16563(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.GlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 16543, 16563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23112_16543_16595(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16543, 16595);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23112_16623_16659(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16623, 16659);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23112_16759_16776(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 16759, 16776);
return return_v;
}


int
f_23112_16733_16777(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16733, 16777);
return 0;
}


int
f_23112_16792_16859(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16792, 16859);
return 0;
}


int
f_23112_16874_16923(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16874, 16923);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_16940_16983(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 16940, 16983);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,15443,16995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,15443,16995);
}
		}

[Fact]
        [WorkItem(737971, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/737971")]
        public void ByRefBeforeCustomModifiersOnSourceParameter()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,17007,19089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,17197,17701);

var 
il = @"
.class public auto ansi beforefieldinit C
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual instance void M(uint32 modopt([mscorlib]System.Runtime.CompilerServices.IsLong) & a) cil managed
  {
    ret
  } // end of method Test::M

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    ldarg.0
    call       instance void [mscorlib]System.Object::.ctor()
    ret
  }
} // end of class D
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,17717,17985);

var 
source = @"
class D : C
{
    public override void M(ref uint u)
    {
        u++;
    }
}

class Test
{
    static void Main()
    {
        uint u = 1;
        D d = new D();
        d.M(ref u);
        System.Console.WriteLine(u);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,17999,18120);

var 
comp = f_23112_18010_18119(source, il, TargetFramework.Mscorlib40, options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18136,18204);

var 
baseType = f_23112_18151_18203(f_23112_18151_18171(comp), "C")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18218,18273);

var 
baseMethod = f_23112_18235_18272(baseType, "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18287,18338);

var 
baseParameter = baseMethod.Parameters.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18354,18403);

f_23112_18354_18402(RefKind.Ref, f_23112_18380_18401(baseParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18417,18489);

f_23112_18417_18488(baseParameter.TypeWithAnnotations.CustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18503,18557);

f_23112_18503_18556(baseParameter.RefCustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18573,18644);

var 
derivedType = f_23112_18591_18643(f_23112_18591_18611(comp), "D")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18658,18719);

var 
derivedMethod = f_23112_18678_18718(derivedType, "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18733,18790);

var 
derivedParameter = derivedMethod.Parameters.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18806,18858);

f_23112_18806_18857(RefKind.Ref, f_23112_18832_18856(derivedParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18872,18947);

f_23112_18872_18946(derivedParameter.TypeWithAnnotations.CustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,18961,19018);

f_23112_18961_19017(derivedParameter.RefCustomModifiers.IsEmpty);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,19034,19078);

f_23112_19034_19077(this, comp, expectedOutput: "2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,17007,19089);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_18010_18119(string
source,string
ilSource,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithILAndMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource, targetFramework, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18010, 18119);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
f_23112_18151_18171(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.GlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 18151, 18171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23112_18151_18203(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18151, 18203);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23112_18235_18272(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18235, 18272);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23112_18380_18401(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 18380, 18401);
return return_v;
}


int
f_23112_18354_18402(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18354, 18402);
return 0;
}


int
f_23112_18417_18488(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18417, 18488);
return 0;
}


int
f_23112_18503_18556(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18503, 18556);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
f_23112_18591_18611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.GlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 18591, 18611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23112_18591_18643(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18591, 18643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23112_18678_18718(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
symbol,string
qualifiedName)
{
var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18678, 18718);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23112_18832_18856(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23112, 18832, 18856);
return return_v;
}


int
f_23112_18806_18857(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18806, 18857);
return 0;
}


int
f_23112_18872_18946(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18872, 18946);
return 0;
}


int
f_23112_18961_19017(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 18961, 19017);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_19034_19077(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 19034, 19077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,17007,19089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,17007,19089);
}
		}

[WorkItem(294553, "https://devdiv.visualstudio.com/DevDiv/_workitems?id=294553")]
        [Fact]
        public void VoidPointerWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,19101,20322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,19277,19846);

var 
ilSource =
@".class public A
{
  // F1(void* p)
  .method public static void F1(void* p) { ret }
  // F2(const void* p)
  .method public static void F2(void modopt([mscorlib]System.Runtime.CompilerServices.IsConst)* p) { ret }
  // F3(void* const p)
  .method public static void F3(void* modopt([mscorlib]System.Runtime.CompilerServices.IsConst) p) { ret }
  // F4(const void* const p)
  .method public static void F4(void modopt([mscorlib]System.Runtime.CompilerServices.IsConst)* modopt([mscorlib]System.Runtime.CompilerServices.IsConst) p) { ret }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,19860,20067);

var 
source =
@"class B
{
    static void Main()
    {
        unsafe
        {
            A.F1(null);
            A.F2(null);
            A.F3(null);
            A.F4(null);
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,20081,20193);

var 
compilation = f_23112_20099_20192(source, ilSource, options: TestOptions.UnsafeReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,20207,20239);

f_23112_20207_20238(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,20253,20311);

f_23112_20253_20310(this, compilation, verify: Verification.Fails);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,19101,20322);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_20099_20192(string
source,string
ilSource,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithILAndMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 20099, 20192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_20207_20238(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 20207, 20238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_20253_20310(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 20253, 20310);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,19101,20322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,19101,20322);
}
		}

[Fact]
        public void IntPointerWithCustomModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23112,20334,21463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,20418,20987);

var 
ilSource =
@".class public A
{
  // F1(int* p)
  .method public static void F1(int32* p) { ret }
  // F2(const int* p)
  .method public static void F2(int32 modopt([mscorlib]System.Runtime.CompilerServices.IsConst)* p) { ret }
  // F3(int* const p)
  .method public static void F3(int32* modopt([mscorlib]System.Runtime.CompilerServices.IsConst) p) { ret }
  // F4(const int* const p)
  .method public static void F4(int32 modopt([mscorlib]System.Runtime.CompilerServices.IsConst)* modopt([mscorlib]System.Runtime.CompilerServices.IsConst) p) { ret }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,21001,21208);

var 
source =
@"class B
{
    static void Main()
    {
        unsafe
        {
            A.F1(null);
            A.F2(null);
            A.F3(null);
            A.F4(null);
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,21222,21334);

var 
compilation = f_23112_21240_21333(source, ilSource, options: TestOptions.UnsafeReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,21348,21380);

f_23112_21348_21379(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23112,21394,21452);

f_23112_21394_21451(this, compilation, verify: Verification.Fails);
DynAbs.Tracing.TraceSender.TraceExitMethod(23112,20334,21463);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_21240_21333(string
source,string
ilSource,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithILAndMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 21240, 21333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23112_21348_21379(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 21348, 21379);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23112_21394_21451(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.EmitCustomModifiers
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23112, 21394, 21451);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23112,20334,21463);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,20334,21463);
}
		}

public EmitCustomModifiers()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23112,584,21470);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23112,584,21470);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,584,21470);
}


static EmitCustomModifiers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23112,584,21470);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23112,584,21470);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23112,584,21470);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23112,584,21470);
}
}
