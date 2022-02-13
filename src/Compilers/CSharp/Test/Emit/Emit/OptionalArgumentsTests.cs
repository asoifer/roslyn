// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class OptionalArgumentsTests : CSharpTestBase
{
[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [ConditionalFact(typeof(DesktopOnly))]
        public void TestDuplicateConstantAttributesMetadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,630,6250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,848,5257);

var 
ilSource =
@".assembly extern System {}
.class public C
{
  .method public static object F0([opt] object o)
  {
    .param [1]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = {string('s')} // [DefaultParameterValue('s')]
    ldarg.0
    ret
  }
  .method public static object F1([opt] object o)
  {
    .param [1]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = {string('s')} // [DefaultParameterValue('s')]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 ) // [DecimalConstant(2)]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 03 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    ldarg.0
    ret
  }
  .method public static object F2([opt] object o)
  {
    .param [1]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 ) // [DecimalConstant(2)]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 03 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = {string('s')} // [DefaultParameterValue('s')]
    ldarg.0
    ret
  }
  .method public static object F3([opt] object o)
  {
    .param [1]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 03 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = {string('s')} // [DefaultParameterValue('s')]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 ) // [DecimalConstant(2)]
    ldarg.0
    ret
  }
  .method public static int32 F4([opt] int32 i)
  {
    .param [1]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = ( 01 00 08 01 00 00 00 00 00 ) // [DefaultParameterValue(1)]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = ( 01 00 08 02 00 00 00 00 00 ) // [DefaultParameterValue(2)]
    .custom instance void [System]System.Runtime.InteropServices.DefaultParameterValueAttribute::.ctor(object) = ( 01 00 08 03 00 00 00 00 00 ) // [DefaultParameterValue(3)]
    ldarg.0
    ret
  }
  .method public static valuetype [mscorlib]System.DateTime F5([opt] valuetype [mscorlib]System.DateTime d)
  {
    .param [1]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 01 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 02 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    .custom instance void [System]System.Runtime.CompilerServices.DateTimeConstantAttribute::.ctor(int64) = ( 01 00 03 00 00 00 00 00 00 00 00 00 ) // [DateTimeConstant(3)]
    ldarg.0
    ret
  }
  .method public static valuetype [mscorlib]System.Decimal F6([opt] valuetype [mscorlib]System.Decimal d)
  {
    .param [1]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 01 00 00 00 00 00 ) // [DecimalConstant(2)]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 02 00 00 00 00 00 ) // [DecimalConstant(2)]
    .custom instance void [System]System.Runtime.CompilerServices.DecimalConstantAttribute::.ctor(uint8, uint8, uint32, uint32, uint32) = ( 01 00 00 00 00 00 00 00 00 00 00 00 03 00 00 00 00 00 ) // [DecimalConstant(2)]
    ldarg.0
    ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,5271,5756);

var 
csharpSource =
@"class P
{
    static void Main()
    {
        Report(C.F0());
        Report(C.F1());
        Report(C.F2());
        Report(C.F3());
        Report(C.F4());
        Report(C.F5().Ticks);
        Report(C.F6());
    }
    static void Report(object o)
    {
        var value = o is System.DateTime ? ((System.DateTime)o).ToString(""MM'/'dd'/'yyyy HH':'mm':'ss"") : o;
        System.Console.WriteLine(""{0}: {1}"", o.GetType(), value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,5770,5908);

var 
compilation = f_23119_5788_5907(csharpSource, ilSource, TargetFramework.Mscorlib45, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,5922,5954);

f_23119_5922_5953(            compilation);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,5968,6239);

f_23119_5968_6238(this, compilation, expectedOutput:
@"System.Reflection.Missing: System.Reflection.Missing
System.DateTime: 01/01/0001 00:00:00
System.DateTime: 01/01/0001 00:00:00
System.DateTime: 01/01/0001 00:00:00
System.Int32: 0
System.Int64: 3
System.Decimal: 3");
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,630,6250);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_5788_5907(string
source,string
ilSource,Roslyn.Test.Utilities.TargetFramework
targetFramework,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithILAndMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource, targetFramework, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 5788, 5907);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_5922_5953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 5922, 5953);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_5968_6238(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 5968, 6238);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,630,6250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,630,6250);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestDuplicateConstantAttributesSameValues()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,6262,9114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,6450,6918);

var 
source1 =
@"using System.Runtime.CompilerServices;
public class C
{
    public object F([DecimalConstant(0, 0, 0, 0, 1)]decimal o = 1)
    {
        return o;
    }
    public object this[decimal a, [DecimalConstant(0, 0, 0, 0, 2)]decimal b = 2]
    {
        get { return b; }
        set { }
    }
    public static object D(decimal o)
    {
        return o;
    }
}
public delegate object D([DecimalConstant(0, 0, 0, 0, 3)]decimal o = 3);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,6932,7002);

var 
comp1 = f_23119_6944_7001(source1, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,7016,7042);

f_23119_7016_7041(            comp1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,7056,8182);

f_23119_7056_8181(this, comp1, sourceSymbolValidator: module =>
                {
                    var type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("C");
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("F").Parameters[0], "DecimalConstantAttribute", 1, false);
                    VerifyDefaultValueAttribute(type.GetMember<PropertySymbol>("this[]").Parameters[1], "DecimalConstantAttribute", 2, false);
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("get_Item").Parameters[1], "DecimalConstantAttribute", 2, false);
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("set_Item").Parameters[1], "DecimalConstantAttribute", 2, false);
                    type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("D");
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("Invoke").Parameters[0], "DecimalConstantAttribute", 3, false);
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("BeginInvoke").Parameters[0], "DecimalConstantAttribute", 3, false);
                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,8196,8470);

var 
source2 =
@"class P
{
    static void Main()
    {
        var c = new C();
        Report(c.F());
        Report(c[0]);
        D d = C.D;
        Report(d());
    }
    static void Report(object o)
    {
        System.Console.WriteLine(o);   
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,8484,8668);

var 
comp2a = f_23119_8497_8667(source2, references: new[] { f_23119_8579_8616(comp1)}, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,8682,8709);

f_23119_8682_8708(            comp2a);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,8723,8777);

f_23119_8723_8776(this, comp2a, expectedOutput:
@"1
2
3");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,8791,8994);

var 
comp2b = f_23119_8804_8993(source2, references: new[] { f_23119_8886_8942(f_23119_8921_8941(comp1))}, options: TestOptions.DebugExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9008,9035);

f_23119_9008_9034(            comp2b);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9049,9103);

f_23119_9049_9102(this, comp2b, expectedOutput:
@"1
2
3");
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,6262,9114);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_6944_7001(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 6944, 7001);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_7016_7041(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 7016, 7041);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_7056_8181(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, sourceSymbolValidator:sourceSymbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 7056, 8181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23119_8579_8616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8579, 8616);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_8497_8667(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8497, 8667);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_8682_8708(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8682, 8708);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_8723_8776(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8723, 8776);
return return_v;
}


System.IO.MemoryStream
f_23119_8921_8941(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8921, 8941);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23119_8886_8942(System.IO.MemoryStream
peStream)
{
var return_v = MetadataReference.CreateFromStream( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8886, 8942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_8804_8993(string
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 8804, 8993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_9008_9034(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 9008, 9034);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_9049_9102(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 9049, 9102);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,6262,9114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,6262,9114);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestDuplicateConstantAttributesSameValues_PartialMethods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,9126,9983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9329,9548);

var 
source =
@"using System.Runtime.CompilerServices;
partial class C
{
    static partial void F(decimal o = 2);
}
partial class C
{
    static partial void F([DecimalConstant(0, 0, 0, 0, 2)]decimal o) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9562,9599);

var 
comp = f_23119_9573_9598(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9613,9638);

f_23119_9613_9637(            comp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,9652,9972);

f_23119_9652_9971(this, comp, sourceSymbolValidator: module =>
                {
                    var type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("C");
                    VerifyDefaultValueAttribute(type.GetMember<MethodSymbol>("F").Parameters[0], "DecimalConstantAttribute", 2, false);
                });
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,9126,9983);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_9573_9598(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 9573, 9598);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_9613_9637(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 9613, 9637);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_9652_9971(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, sourceSymbolValidator:sourceSymbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 9652, 9971);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,9126,9983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,9126,9983);
}
		}

private static void VerifyDefaultValueAttribute(ParameterSymbol parameter, string expectedAttributeName, object expectedDefault, bool hasDefault)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23119,9995,10972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10165,10208);

var 
attributes = f_23119_10182_10207(parameter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10222,10822) || true) && (expectedAttributeName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23119,10222,10822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10289,10324);

f_23119_10289_10323(0, attributes.Length);
DynAbs.Tracing.TraceSender.TraceExitCondition(23119,10222,10822);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23119,10222,10822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10390,10425);

f_23119_10390_10424(1, attributes.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10443,10473);

var 
attribute = attributes[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10491,10544);

var 
argument = f_23119_10506_10543(f_23119_10506_10536(attribute))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10562,10629);

f_23119_10562_10628(expectedAttributeName, f_23119_10598_10627(f_23119_10598_10622(attribute)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10647,10693);

f_23119_10647_10692(expectedDefault, argument.Value);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10711,10807);

f_23119_10711_10806(hasDefault, f_23119_10736_10805(((Cci.IParameterDefinition)f_23119_10763_10788(parameter))));
DynAbs.Tracing.TraceSender.TraceExitCondition(23119,10222,10822);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10836,10961) || true) && (hasDefault)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23119,10836,10961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,10884,10946);

f_23119_10884_10945(expectedDefault, f_23119_10914_10944(parameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(23119,10836,10961);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23119,9995,10972);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
f_23119_10182_10207(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.GetAttributes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10182, 10207);
return return_v;
}


int
f_23119_10289_10323(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10289, 10323);
return 0;
}


int
f_23119_10390_10424(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10390, 10424);
return 0;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
f_23119_10506_10536(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
this_param)
{
var return_v = this_param.ConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23119, 10506, 10536);
return return_v;
}


Microsoft.CodeAnalysis.TypedConstant
f_23119_10506_10543(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
source)
{
var return_v = source.Last<Microsoft.CodeAnalysis.TypedConstant>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10506, 10543);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_23119_10598_10622(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23119, 10598, 10622);
return return_v;
}


string
f_23119_10598_10627(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23119, 10598, 10627);
return return_v;
}


int
f_23119_10562_10628(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10562, 10628);
return 0;
}


int
f_23119_10647_10692(object
expected,object?
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10647, 10692);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbolAdapter
f_23119_10763_10788(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.GetCciAdapter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10763, 10788);
return return_v;
}


bool
f_23119_10736_10805(Microsoft.Cci.IParameterDefinition
this_param)
{
var return_v = this_param.HasDefaultValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23119, 10736, 10805);
return return_v;
}


int
f_23119_10711_10806(bool
expected,bool
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10711, 10806);
return 0;
}


object
f_23119_10914_10944(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.ExplicitDefaultValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23119, 10914, 10944);
return return_v;
}


int
f_23119_10884_10945(object
expected,object
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 10884, 10945);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,9995,10972);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,9995,10972);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestDuplicateConstantAttributesDifferentValues()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,10984,17349);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,11177,11929);

var 
source =
@"using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
interface I
{
    void F1([DefaultParameterValue(1)]int o = 2);
    void F2([DefaultParameterValue(1)]decimal o = 2);
    void F4([DecimalConstant(0, 0, 0, 0, 1)]decimal o = 2);
    void F6([DateTimeConstant(1), DefaultParameterValue(1), DecimalConstant(0, 0, 0, 0, 1)]int o = 1);
    void F7([DateTimeConstant(2), DecimalConstant(0, 0, 0, 0, 2), DefaultParameterValue(2)]decimal o = 2);
    object this[int a, [DefaultParameterValue(1)]int o = 2] { get; set; }
    object this[[DefaultParameterValue(0), DecimalConstant(0, 0, 0, 0, 0), DateTimeConstant(0)]int o] { get; set; }
}
delegate void D([DecimalConstant(0, 0, 0, 0, 3)]decimal b = 4);
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,11943,17338);

f_23119_11943_17337(f_23119_11943_11968(source), f_23119_12223_12324(f_23119_12223_12304(ErrorCode.ERR_DefaultValueUsedWithAttributes, "DefaultParameterValue"), 5, 14), f_23119_12565_12666(f_23119_12565_12646(ErrorCode.ERR_DefaultValueUsedWithAttributes, "DefaultParameterValue"), 6, 14), f_23119_12853_12941(f_23119_12853_12921(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), 6, 51), f_23119_13134_13222(f_23119_13134_13202(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), 7, 57), f_23119_13512_13613(f_23119_13512_13593(ErrorCode.ERR_DefaultValueUsedWithAttributes, "DefaultParameterValue"), 8, 35), f_23119_13849_13966(f_23119_13849_13946(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DecimalConstant(0, 0, 0, 0, 1)"), 8, 61), f_23119_14203_14292(f_23119_14203_14271(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "1"), 8, 100), f_23119_14532_14649(f_23119_14532_14629(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DecimalConstant(0, 0, 0, 0, 2)"), 9, 35), f_23119_14943_15044(f_23119_14943_15024(ErrorCode.ERR_DefaultValueUsedWithAttributes, "DefaultParameterValue"), 9, 67), f_23119_15285_15374(f_23119_15285_15353(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), 9, 104), f_23119_15636_15738(f_23119_15636_15717(ErrorCode.ERR_DefaultValueUsedWithAttributes, "DefaultParameterValue"), 10, 25), f_23119_15946_16035(f_23119_15946_16014(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), 10, 58), f_23119_16285_16403(f_23119_16285_16382(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DecimalConstant(0, 0, 0, 0, 0)"), 11, 44), f_23119_16653_16760(f_23119_16653_16739(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DateTimeConstant(0)"), 11, 76), f_23119_16943_17031(f_23119_16943_17011(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), 5, 47), f_23119_17229_17318(f_23119_17229_17297(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "4"), 13, 61));
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,10984,17349);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_11943_11968(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 11943, 11968);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12223_12304(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12223, 12304);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12223_12324(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12223, 12324);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12565_12646(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12565, 12646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12565_12666(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12565, 12666);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12853_12921(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12853, 12921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_12853_12941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 12853, 12941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13134_13202(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13134, 13202);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13134_13222(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13134, 13222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13512_13593(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13512, 13593);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13512_13613(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13512, 13613);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13849_13946(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13849, 13946);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_13849_13966(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 13849, 13966);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14203_14271(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14203, 14271);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14203_14292(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14203, 14292);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14532_14629(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14532, 14629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14532_14649(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14532, 14649);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14943_15024(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14943, 15024);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_14943_15044(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 14943, 15044);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15285_15353(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15285, 15353);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15285_15374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15285, 15374);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15636_15717(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15636, 15717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15636_15738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15636, 15738);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15946_16014(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15946, 16014);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_15946_16035(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 15946, 16035);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16285_16382(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16285, 16382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16285_16403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16285, 16403);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16653_16739(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16653, 16739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16653_16760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16653, 16760);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16943_17011(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16943, 17011);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_16943_17031(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 16943, 17031);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_17229_17297(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 17229, 17297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_17229_17318(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 17229, 17318);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_11943_17337(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 11943, 17337);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,10984,17349);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,10984,17349);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestDuplicateConstantAttributesDifferentValues_PartialMethods()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,17361,18824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,17569,17939);

var 
source =
@"using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
partial class C
{
    partial void F1([DefaultParameterValue(1)]int o) {}
    partial void F9([DefaultParameterValue(0)]int o);
}
partial class C
{
    partial void F1(int o = 2);
    partial void F9([DecimalConstant(0, 0, 0, 0, 0), DateTimeConstant(0)]int o) {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,17953,18813);

f_23119_17953_18812(f_23119_17953_17978(source), f_23119_18183_18274(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DefaultParameterValue(0)"), f_23119_18440_18508(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "2"), f_23119_18725_18811(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DateTimeConstant(0)"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,17361,18824);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_17953_17978(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 17953, 17978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_18183_18274(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 18183, 18274);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_18440_18508(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 18440, 18508);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_18725_18811(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 18725, 18811);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_17953_18812(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 17953, 18812);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,17361,18824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,17361,18824);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestDuplicateConstantAttributesDifferentValues_BadValue()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,18950,21129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,19152,19561);

var 
source =
@"using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
interface I
{
    void M1([DefaultParameterValue(typeof(C)), DecimalConstantAttribute(0, 0, 0, 0, 0)] decimal o);
    void M2([DefaultParameterValue(0), DecimalConstantAttribute(0, 0, 0, 0, typeof(C))] decimal o);
    void M3([DefaultParameterValue(0), DecimalConstantAttribute(0, 0, 0, 0, 0)] decimal o);
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,19575,21118);

f_23119_19575_21117(f_23119_19575_19600(source), f_23119_19843_19969(f_23119_19843_19949(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DecimalConstantAttribute(0, 0, 0, 0, 0)"), 7, 40), f_23119_20262_20354(f_23119_20262_20334(f_23119_20262_20315(ErrorCode.ERR_SingleTypeNameNotFound, "C"), "C"), 6, 84), f_23119_20647_20739(f_23119_20647_20719(f_23119_20647_20700(ErrorCode.ERR_SingleTypeNameNotFound, "C"), "C"), 5, 43), f_23119_20972_21098(f_23119_20972_21078(ErrorCode.ERR_ParamDefaultValueDiffersFromAttribute, "DecimalConstantAttribute(0, 0, 0, 0, 0)"), 5, 48));
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,18950,21129);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_19575_19600(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 19575, 19600);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_19843_19949(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 19843, 19949);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_19843_19969(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 19843, 19969);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20262_20315(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20262, 20315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20262_20334(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20262, 20334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20262_20354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20262, 20354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20647_20700(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20647, 20700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20647_20719(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20647, 20719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20647_20739(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20647, 20739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20972_21078(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20972, 21078);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_20972_21098(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 20972, 21098);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_19575_21117(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 19575, 21117);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,18950,21129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,18950,21129);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestExplicitConstantAttributesOnFields_Errors()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,21141,25328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,21333,22454);

var 
source =
@"
using System;
using System.Runtime.CompilerServices;

class C
{
    [DecimalConstant(0, 0, 0, 0, 0)] public decimal F0 = 1;

    [DateTimeConstant(0)] public DateTime F1 = default(DateTime);

    [DecimalConstant(0, 0, 0, 0, 0), DecimalConstant(0, 0, 0, 0, 0)] public DateTime F2 = default(DateTime);

    [DateTimeConstant(0), DateTimeConstant(0)] public DateTime F3 = default(DateTime);

    [DecimalConstant(0, 0, 0, 0, 0), DecimalConstant(0, 0, 0, 0, 1)] public decimal F4 = 0;

    [DateTimeConstant(1), DateTimeConstant(0)] public DateTime F5 = default(DateTime);

    [DecimalConstant(0, 0, 0, 0, 0), DateTimeConstant(0)] public DateTime F6 = default(DateTime);

    [DecimalConstant(0, 0, 0, 0, 0), DateTimeConstant(0)] public decimal F7 = 0;

    [DecimalConstant(0, 0, 0, 0, 0), DateTimeConstant(0)] public int F8 = 0;

    [DecimalConstant(0, 0, 0, 0, 0)] public const int F9 = 0;

    [DateTimeConstant(0)] public const int F10 = 0;

    [DateTimeConstant(0)] public const decimal F12 = 0;

    [DecimalConstant(0, 0, 0, 0, 0)] public const decimal F14 = 1;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,22468,22505);

var 
comp = f_23119_22479_22504(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,22521,25317);

f_23119_22521_25316(
            comp, f_23119_22724_22820(f_23119_22724_22787(ErrorCode.ERR_DuplicateAttribute, "DecimalConstant"), "DecimalConstant"), f_23119_22980_23078(f_23119_22980_23044(ErrorCode.ERR_DuplicateAttribute, "DateTimeConstant"), "DateTimeConstant"), f_23119_23242_23338(f_23119_23242_23305(ErrorCode.ERR_DuplicateAttribute, "DecimalConstant"), "DecimalConstant"), f_23119_23498_23596(f_23119_23498_23562(ErrorCode.ERR_DuplicateAttribute, "DateTimeConstant"), "DateTimeConstant"), f_23119_23777_23864(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DateTimeConstant(0)"), f_23119_24028_24115(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DateTimeConstant(0)"), f_23119_24275_24362(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DateTimeConstant(0)"), f_23119_24506_24604(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DecimalConstant(0, 0, 0, 0, 0)"), f_23119_24738_24825(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DateTimeConstant(0)"), f_23119_24963_25050(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DateTimeConstant(0)"), f_23119_25199_25297(ErrorCode.ERR_FieldHasMultipleDistinctConstantValues, "DecimalConstant(0, 0, 0, 0, 0)"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,21141,25328);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_22479_22504(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22479, 22504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_22724_22787(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22724, 22787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_22724_22820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22724, 22820);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_22980_23044(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22980, 23044);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_22980_23078(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22980, 23078);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_23242_23305(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 23242, 23305);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_23242_23338(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 23242, 23338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_23498_23562(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 23498, 23562);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_23498_23596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 23498, 23596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_23777_23864(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 23777, 23864);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_24028_24115(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 24028, 24115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_24275_24362(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 24275, 24362);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_24506_24604(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 24506, 24604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_24738_24825(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 24738, 24825);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_24963_25050(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 24963, 25050);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23119_25199_25297(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 25199, 25297);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_22521_25316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 22521, 25316);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,21141,25328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,21141,25328);
}
		}

[WorkItem(529684, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529684")]
        [Fact]
        public void TestExplicitConstantAttributesOnFields_Valid()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23119,25340,26214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,25531,25701);

var 
source =
@"
using System;
using System.Runtime.CompilerServices;

class C
{
    [DecimalConstantAttribute(0, 128, 0, 0, 7)] public const decimal F15 = -7;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,25715,25752);

var 
comp = f_23119_25726_25751(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23119,25768,26203);

f_23119_25768_26202(this, comp, symbolValidator: module =>
            {
                var field = (PEFieldSymbol)module.GlobalNamespace.GetTypeMember("C").GetField("F15");
                var attribute = ((PEModuleSymbol)module).GetCustomAttributesForToken(field.Handle).Single();

                Assert.Equal("System.Runtime.CompilerServices.DecimalConstantAttribute", attribute.AttributeClass.ToTestDisplayString());
            });
DynAbs.Tracing.TraceSender.TraceExitMethod(23119,25340,26214);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23119_25726_25751(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 25726, 25751);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23119_25768_26202(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.OptionalArgumentsTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23119, 25768, 26202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23119,25340,26214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,25340,26214);
}
		}

public OptionalArgumentsTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23119,561,26221);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23119,561,26221);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,561,26221);
}


static OptionalArgumentsTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23119,561,26221);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23119,561,26221);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23119,561,26221);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23119,561,26221);
}
}
