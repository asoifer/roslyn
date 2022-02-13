// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.DiaSymReader.Tools;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
public class LocalSlotMappingTests : EditAndContinueTestBase
{
[Fact]
        public void SlotMappingWithNoChanges()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,1084,3204);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1163,1382);

var 
source0 = @"
using System;

class C
{
    static void Main(string[] args)
    {
        var b = true;
        do
        {
            Console.WriteLine(""hi"");
        } while (b == true);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1396,1473);

var 
compilation0 = f_23110_1415_1472(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1487,1539);

var 
compilation1 = f_23110_1506_1538(compilation0, source0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1555,1595);

var 
v0 = f_23110_1564_1594(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1611,1665);

var 
methodData0 = f_23110_1629_1664(f_23110_1629_1640(v0), "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1679,1740);

var 
method0 = f_23110_1693_1739(compilation0, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1754,1815);

var 
method1 = f_23110_1768_1814(compilation1, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1829,1974);

var 
generation0 = f_23110_1847_1973(f_23110_1882_1936(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,1990,2475);

f_23110_1990_2474(
            v0, "C.Main", @"
{
  // Code size       22 (0x16)
  .maxstack  1
  .locals init (bool V_0, //b
                bool V_1)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
 -IL_0003:  nop
 -IL_0004:  ldstr      ""hi""
  IL_0009:  call       ""void System.Console.WriteLine(string)""
  IL_000e:  nop
 -IL_000f:  nop
 -IL_0010:  ldloc.0
  IL_0011:  stloc.1
 ~IL_0012:  ldloc.1
  IL_0013:  brtrue.s   IL_0003
 -IL_0015:  ret
}", sequencePoints: "C.Main");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,2491,2713);

var 
diff1 = f_23110_2503_2712(compilation1, generation0, f_23110_2579_2711(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,syntaxMap: null,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,2729,3193);

f_23110_2729_3192(
            diff1, "C.Main", @"
{
  // Code size       22 (0x16)
  .maxstack  1
  .locals init (bool V_0, //b
                bool V_1)
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  IL_0003:  nop
  IL_0004:  ldstr      ""hi""
  IL_0009:  call       ""void System.Console.WriteLine(string)""
  IL_000e:  nop
  IL_000f:  nop
  IL_0010:  ldloc.0
  IL_0011:  stloc.1
  IL_0012:  ldloc.1
  IL_0013:  brtrue.s   IL_0003
  IL_0015:  ret

}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,1084,3204);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_1415_1472(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1415, 1472);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_1506_1538(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1506, 1538);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_1564_1594(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1564, 1594);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_1629_1640(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 1629, 1640);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_1629_1664(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1629, 1664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_1693_1739(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1693, 1739);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_1768_1814(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1768, 1814);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_1882_1936(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1882, 1936);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_1847_1973(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1847, 1973);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_1990_2474(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 1990, 2474);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_2579_2711(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 2579, 2711);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_2503_2712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 2503, 2712);
return return_v;
}


int
f_23110_2729_3192(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 2729, 3192);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,1084,3204);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,1084,3204);
}
		}

[Fact]
        public void OutOfOrderUserLocals()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,3216,11011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,3291,3603);

var 
source = f_23110_3304_3602(@"
using System;

public class C
{
    public static void M()
    {
        for (int i = 1; i < 1; i++) Console.WriteLine(1);
        for (int i = 1; i < 2; i++) Console.WriteLine(2);

        int j;
        for (j = 1; j < 3; j++) Console.WriteLine(3);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,3617,3688);

var 
compilation0 = f_23110_3636_3687(source, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,3702,3753);

var 
compilation1 = f_23110_3721_3752(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,3769,3809);

var 
v0 = f_23110_3778_3808(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,3823,5312);

f_23110_3823_5311(            v0, "C.M", @"
{
  // Code size       75 (0x4b)
  .maxstack  2
  .locals init (int V_0, //j
                int V_1, //i
                bool V_2,
                int V_3, //i
                bool V_4,
                bool V_5)
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.1
  IL_0003:  br.s       IL_0010
  IL_0005:  ldc.i4.1
  IL_0006:  call       ""void System.Console.WriteLine(int)""
  IL_000b:  nop
  IL_000c:  ldloc.1
  IL_000d:  ldc.i4.1
  IL_000e:  add
  IL_000f:  stloc.1
  IL_0010:  ldloc.1
  IL_0011:  ldc.i4.1
  IL_0012:  clt
  IL_0014:  stloc.2
  IL_0015:  ldloc.2
  IL_0016:  brtrue.s   IL_0005
  IL_0018:  ldc.i4.1
  IL_0019:  stloc.3
  IL_001a:  br.s       IL_0027
  IL_001c:  ldc.i4.2
  IL_001d:  call       ""void System.Console.WriteLine(int)""
  IL_0022:  nop
  IL_0023:  ldloc.3
  IL_0024:  ldc.i4.1
  IL_0025:  add
  IL_0026:  stloc.3
  IL_0027:  ldloc.3
  IL_0028:  ldc.i4.2
  IL_0029:  clt
  IL_002b:  stloc.s    V_4
  IL_002d:  ldloc.s    V_4
  IL_002f:  brtrue.s   IL_001c
  IL_0031:  ldc.i4.1
  IL_0032:  stloc.0
  IL_0033:  br.s       IL_0040
  IL_0035:  ldc.i4.3
  IL_0036:  call       ""void System.Console.WriteLine(int)""
  IL_003b:  nop
  IL_003c:  ldloc.0
  IL_003d:  ldc.i4.1
  IL_003e:  add
  IL_003f:  stloc.0
  IL_0040:  ldloc.0
  IL_0041:  ldc.i4.3
  IL_0042:  clt
  IL_0044:  stloc.s    V_5
  IL_0046:  ldloc.s    V_5
  IL_0048:  brtrue.s   IL_0035
  IL_004a:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,5326,8607);

f_23110_5326_8606(            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""135"" />
          <slot kind=""0"" offset=""20"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""0"" offset=""79"" />
          <slot kind=""1"" offset=""70"" />
          <slot kind=""1"" offset=""147"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""14"" endLine=""8"" endColumn=""23"" document=""1"" />
        <entry offset=""0x3"" hidden=""true"" document=""1"" />
        <entry offset=""0x5"" startLine=""8"" startColumn=""37"" endLine=""8"" endColumn=""58"" document=""1"" />
        <entry offset=""0xc"" startLine=""8"" startColumn=""32"" endLine=""8"" endColumn=""35"" document=""1"" />
        <entry offset=""0x10"" startLine=""8"" startColumn=""25"" endLine=""8"" endColumn=""30"" document=""1"" />
        <entry offset=""0x15"" hidden=""true"" document=""1"" />
        <entry offset=""0x18"" startLine=""9"" startColumn=""14"" endLine=""9"" endColumn=""23"" document=""1"" />
        <entry offset=""0x1a"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""9"" startColumn=""37"" endLine=""9"" endColumn=""58"" document=""1"" />
        <entry offset=""0x23"" startLine=""9"" startColumn=""32"" endLine=""9"" endColumn=""35"" document=""1"" />
        <entry offset=""0x27"" startLine=""9"" startColumn=""25"" endLine=""9"" endColumn=""30"" document=""1"" />
        <entry offset=""0x2d"" hidden=""true"" document=""1"" />
        <entry offset=""0x31"" startLine=""12"" startColumn=""14"" endLine=""12"" endColumn=""19"" document=""1"" />
        <entry offset=""0x33"" hidden=""true"" document=""1"" />
        <entry offset=""0x35"" startLine=""12"" startColumn=""33"" endLine=""12"" endColumn=""54"" document=""1"" />
        <entry offset=""0x3c"" startLine=""12"" startColumn=""28"" endLine=""12"" endColumn=""31"" document=""1"" />
        <entry offset=""0x40"" startLine=""12"" startColumn=""21"" endLine=""12"" endColumn=""26"" document=""1"" />
        <entry offset=""0x46"" hidden=""true"" document=""1"" />
        <entry offset=""0x4a"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x4b"">
        <namespace name=""System"" />
        <local name=""j"" il_index=""0"" il_start=""0x0"" il_end=""0x4b"" attributes=""0"" />
        <scope startOffset=""0x1"" endOffset=""0x18"">
          <local name=""i"" il_index=""1"" il_start=""0x1"" il_end=""0x18"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x18"" endOffset=""0x31"">
          <local name=""i"" il_index=""3"" il_start=""0x18"" il_end=""0x31"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8621,8658);

var 
symReader = f_23110_8637_8657(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8674,8716);

var 
testData0 = f_23110_8690_8715()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8730,8789);

var 
bytes0 = f_23110_8743_8788(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8803,8852);

var 
methodData0 = f_23110_8821_8851(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8866,8924);

var 
method0 = f_23110_8880_8923(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,8938,9064);

var 
generation0 = f_23110_8956_9063(f_23110_8991_9029(bytes0), symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,9080,9138);

var 
method1 = f_23110_9094_9137(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,9152,9398);

var 
diff1 = f_23110_9164_9397(compilation1, generation0, f_23110_9240_9396(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_9325_9364(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,9508,11000);

f_23110_9508_10999(
            // check that all user-defined and long-lived synthesized local slots are reused
            diff1, "C.M", @"
{
  // Code size       75 (0x4b)
  .maxstack  2
  .locals init (int V_0, //j
                int V_1, //i
                bool V_2,
                int V_3, //i
                bool V_4,
                bool V_5)
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.1
  IL_0003:  br.s       IL_0010
  IL_0005:  ldc.i4.1
  IL_0006:  call       ""void System.Console.WriteLine(int)""
  IL_000b:  nop
  IL_000c:  ldloc.1
  IL_000d:  ldc.i4.1
  IL_000e:  add
  IL_000f:  stloc.1
  IL_0010:  ldloc.1
  IL_0011:  ldc.i4.1
  IL_0012:  clt
  IL_0014:  stloc.2
  IL_0015:  ldloc.2
  IL_0016:  brtrue.s   IL_0005
  IL_0018:  ldc.i4.1
  IL_0019:  stloc.3
  IL_001a:  br.s       IL_0027
  IL_001c:  ldc.i4.2
  IL_001d:  call       ""void System.Console.WriteLine(int)""
  IL_0022:  nop
  IL_0023:  ldloc.3
  IL_0024:  ldc.i4.1
  IL_0025:  add
  IL_0026:  stloc.3
  IL_0027:  ldloc.3
  IL_0028:  ldc.i4.2
  IL_0029:  clt
  IL_002b:  stloc.s    V_4
  IL_002d:  ldloc.s    V_4
  IL_002f:  brtrue.s   IL_001c
  IL_0031:  ldc.i4.1
  IL_0032:  stloc.0
  IL_0033:  br.s       IL_0040
  IL_0035:  ldc.i4.3
  IL_0036:  call       ""void System.Console.WriteLine(int)""
  IL_003b:  nop
  IL_003c:  ldloc.0
  IL_003d:  ldc.i4.1
  IL_003e:  add
  IL_003f:  stloc.0
  IL_0040:  ldloc.0
  IL_0041:  ldc.i4.3
  IL_0042:  clt
  IL_0044:  stloc.s    V_5
  IL_0046:  ldloc.s    V_5
  IL_0048:  brtrue.s   IL_0035
  IL_004a:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,3216,11011);

string
f_23110_3304_3602(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 3304, 3602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_3636_3687(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 3636, 3687);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_3721_3752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 3721, 3752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_3778_3808(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 3778, 3808);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_3823_5311(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 3823, 5311);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_5326_8606(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 5326, 8606);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23110_8637_8657(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8637, 8657);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_8690_8715()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8690, 8715);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_8743_8788(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8743, 8788);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_8821_8851(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8821, 8851);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_8880_8923(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8880, 8923);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_8991_9029(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8991, 9029);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_8956_9063(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 8956, 9063);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_9094_9137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 9094, 9137);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_9325_9364(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 9325, 9364);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_9240_9396(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 9240, 9396);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_9164_9397(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 9164, 9397);
return return_v;
}


int
f_23110_9508_10999(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 9508, 10999);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,3216,11011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,3216,11011);
}
		}

[Fact]
        public void DebugOnly()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,11131,14623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,11195,11405);

var 
source = f_23110_11208_11404(@"class C
{
    static System.IDisposable F()
    {
        return null;
    }
    static void M()
    {
        lock (F()) { }
        using (F()) { }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,11419,11488);

var 
debug = f_23110_11431_11487(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,11502,11575);

var 
release = f_23110_11516_11574(source, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,11591,13362);

f_23110_11591_13361(f_23110_11591_11614(this, debug), "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""3"" offset=""11"" />
          <slot kind=""2"" offset=""11"" />
          <slot kind=""4"" offset=""35"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""19"" document=""1"" />
        <entry offset=""0x12"" startLine=""9"" startColumn=""20"" endLine=""9"" endColumn=""21"" document=""1"" />
        <entry offset=""0x13"" startLine=""9"" startColumn=""22"" endLine=""9"" endColumn=""23"" document=""1"" />
        <entry offset=""0x16"" hidden=""true"" document=""1"" />
        <entry offset=""0x20"" hidden=""true"" document=""1"" />
        <entry offset=""0x21"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""20"" document=""1"" />
        <entry offset=""0x27"" startLine=""10"" startColumn=""21"" endLine=""10"" endColumn=""22"" document=""1"" />
        <entry offset=""0x28"" startLine=""10"" startColumn=""23"" endLine=""10"" endColumn=""24"" document=""1"" />
        <entry offset=""0x2b"" hidden=""true"" document=""1"" />
        <entry offset=""0x35"" hidden=""true"" document=""1"" />
        <entry offset=""0x36"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,13376,14612);

f_23110_13376_14611(f_23110_13376_13401(this, release), "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""19"" document=""1"" />
        <entry offset=""0x10"" startLine=""9"" startColumn=""22"" endLine=""9"" endColumn=""23"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
        <entry offset=""0x1b"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""20"" document=""1"" />
        <entry offset=""0x22"" startLine=""10"" startColumn=""23"" endLine=""10"" endColumn=""24"" document=""1"" />
        <entry offset=""0x24"" hidden=""true"" document=""1"" />
        <entry offset=""0x2d"" hidden=""true"" document=""1"" />
        <entry offset=""0x2e"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,11131,14623);

string
f_23110_11208_11404(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 11208, 11404);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_11431_11487(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 11431, 11487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_11516_11574(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 11516, 11574);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_11591_11614(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 11591, 11614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_11591_13361(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 11591, 13361);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_13376_13401(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 13376, 13401);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_13376_14611(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 13376, 14611);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,11131,14623);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,11131,14623);
}
		}

[Fact]
        public void Using()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,14635,17439);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,14695,15082);

var 
source = f_23110_14708_15081(@"class C : System.IDisposable
{
    public void Dispose()
    {
    }
    static System.IDisposable F()
    {
        return new C();
    }
    static void M()
    {
        using (F())
        {
            using (var u = F())
            {
            }
            using (F())
            {
            }
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15096,15172);

var 
compilation0 = f_23110_15115_15171(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15186,15237);

var 
compilation1 = f_23110_15205_15236(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15253,15295);

var 
testData0 = f_23110_15269_15294()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15309,15368);

var 
bytes0 = f_23110_15322_15367(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15382,15431);

var 
methodData0 = f_23110_15400_15430(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15445,15503);

var 
method0 = f_23110_15459_15502(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15517,15646);

var 
generation0 = f_23110_15535_15645(f_23110_15570_15608(bytes0), m => methodData0.GetEncDebugInfo())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15662,15720);

var 
method1 = f_23110_15676_15719(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15734,15980);

var 
diff1 = f_23110_15746_15979(compilation1, generation0, f_23110_15822_15978(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_15907_15946(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,15996,17428);

f_23110_15996_17427(
            diff1, "C.M", @"
{
  // Code size       65 (0x41)
  .maxstack  1
  .locals init (System.IDisposable V_0,
                System.IDisposable V_1, //u
                System.IDisposable V_2)
  IL_0000:  nop
  IL_0001:  call       ""System.IDisposable C.F()""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  nop
    IL_0008:  call       ""System.IDisposable C.F()""
    IL_000d:  stloc.1
    .try
    {
      IL_000e:  nop
      IL_000f:  nop
      IL_0010:  leave.s    IL_001d
    }
    finally
    {
      IL_0012:  ldloc.1
      IL_0013:  brfalse.s  IL_001c
      IL_0015:  ldloc.1
      IL_0016:  callvirt   ""void System.IDisposable.Dispose()""
      IL_001b:  nop
      IL_001c:  endfinally
    }
    IL_001d:  call       ""System.IDisposable C.F()""
    IL_0022:  stloc.2
    .try
    {
      IL_0023:  nop
      IL_0024:  nop
      IL_0025:  leave.s    IL_0032
    }
    finally
    {
      IL_0027:  ldloc.2
      IL_0028:  brfalse.s  IL_0031
      IL_002a:  ldloc.2
      IL_002b:  callvirt   ""void System.IDisposable.Dispose()""
      IL_0030:  nop
      IL_0031:  endfinally
    }
    IL_0032:  nop
    IL_0033:  leave.s    IL_0040
  }
  finally
  {
    IL_0035:  ldloc.0
    IL_0036:  brfalse.s  IL_003f
    IL_0038:  ldloc.0
    IL_0039:  callvirt   ""void System.IDisposable.Dispose()""
    IL_003e:  nop
    IL_003f:  endfinally
  }
  IL_0040:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,14635,17439);

string
f_23110_14708_15081(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 14708, 15081);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_15115_15171(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15115, 15171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_15205_15236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15205, 15236);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_15269_15294()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15269, 15294);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_15322_15367(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15322, 15367);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_15400_15430(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15400, 15430);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_15459_15502(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15459, 15502);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_15570_15608(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15570, 15608);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_15535_15645(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15535, 15645);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_15676_15719(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15676, 15719);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_15907_15946(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15907, 15946);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_15822_15978(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15822, 15978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_15746_15979(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15746, 15979);
return return_v;
}


int
f_23110_15996_17427(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 15996, 17427);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,14635,17439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,14635,17439);
}
		}

[Fact]
        public void Lock()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,17451,20115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,17510,17731);

var 
source =
@"class C
{
    static object F()
    {
        return null;
    }
    static void M()
    {
        lock (F())
        {
            lock (F())
            {
            }
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,17745,17821);

var 
compilation0 = f_23110_17764_17820(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,17835,17886);

var 
compilation1 = f_23110_17854_17885(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,17902,17944);

var 
testData0 = f_23110_17918_17943()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,17958,18017);

var 
bytes0 = f_23110_17971_18016(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18031,18080);

var 
methodData0 = f_23110_18049_18079(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18094,18152);

var 
method0 = f_23110_18108_18151(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18166,18295);

var 
generation0 = f_23110_18184_18294(f_23110_18219_18257(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18311,18369);

var 
method1 = f_23110_18325_18368(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18383,18629);

var 
diff1 = f_23110_18395_18628(compilation1, generation0, f_23110_18471_18627(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_18556_18595(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,18645,20104);

f_23110_18645_20103(
            diff1, "C.M", @"
{
  // Code size       66 (0x42)
  .maxstack  2
  .locals init (object V_0,
                bool V_1,
                object V_2,
                bool V_3)
 -IL_0000:  nop
 -IL_0001:  call       ""object C.F()""
  IL_0006:  stloc.0
  IL_0007:  ldc.i4.0
  IL_0008:  stloc.1
  .try
  {
    IL_0009:  ldloc.0
    IL_000a:  ldloca.s   V_1
    IL_000c:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0011:  nop
   -IL_0012:  nop
   -IL_0013:  call       ""object C.F()""
    IL_0018:  stloc.2
    IL_0019:  ldc.i4.0
    IL_001a:  stloc.3
    .try
    {
      IL_001b:  ldloc.2
      IL_001c:  ldloca.s   V_3
      IL_001e:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
      IL_0023:  nop
     -IL_0024:  nop
     -IL_0025:  nop
      IL_0026:  leave.s    IL_0033
    }
    finally
    {
     ~IL_0028:  ldloc.3
      IL_0029:  brfalse.s  IL_0032
      IL_002b:  ldloc.2
      IL_002c:  call       ""void System.Threading.Monitor.Exit(object)""
      IL_0031:  nop
     ~IL_0032:  endfinally
    }
   -IL_0033:  nop
    IL_0034:  leave.s    IL_0041
  }
  finally
  {
   ~IL_0036:  ldloc.1
    IL_0037:  brfalse.s  IL_0040
    IL_0039:  ldloc.0
    IL_003a:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_003f:  nop
   ~IL_0040:  endfinally
  }
 -IL_0041:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,17451,20115);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_17764_17820(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 17764, 17820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_17854_17885(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 17854, 17885);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_17918_17943()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 17918, 17943);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_17971_18016(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 17971, 18016);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_18049_18079(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18049, 18079);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_18108_18151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18108, 18151);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_18219_18257(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18219, 18257);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_18184_18294(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18184, 18294);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_18325_18368(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18325, 18368);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_18556_18595(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18556, 18595);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_18471_18627(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18471, 18627);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_18395_18628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18395, 18628);
return return_v;
}


int
f_23110_18645_20103(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 18645, 20103);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,17451,20115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,17451,20115);
}
		}

[Fact]
        public void Lock_Pre40()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,20216,22053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20281,20448);

var 
source =
@"class C
{
    static object F()
    {
        return null;
    }
    static void M()
    {
        lock (F())
        {
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20462,20582);

var 
compilation0 = f_23110_20481_20581(source, options: TestOptions.DebugDll, references: new[] { f_23110_20563_20578()})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20596,20716);

var 
compilation1 = f_23110_20615_20715(source, options: TestOptions.DebugDll, references: new[] { f_23110_20697_20712()})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20732,20774);

var 
testData0 = f_23110_20748_20773()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20788,20847);

var 
bytes0 = f_23110_20801_20846(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20861,20910);

var 
methodData0 = f_23110_20879_20909(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20924,20982);

var 
method0 = f_23110_20938_20981(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,20996,21125);

var 
generation0 = f_23110_21014_21124(f_23110_21049_21087(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,21141,21199);

var 
method1 = f_23110_21155_21198(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,21213,21459);

var 
diff1 = f_23110_21225_21458(compilation1, generation0, f_23110_21301_21457(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_21386_21425(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,21475,22042);

f_23110_21475_22041(
            diff1, "C.M", @"{
  // Code size       27 (0x1b)
  .maxstack  1
  .locals init (object V_0)
  IL_0000:  nop
  IL_0001:  call       ""object C.F()""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  call       ""void System.Threading.Monitor.Enter(object)""
  IL_000d:  nop
  .try
  {
    IL_000e:  nop
    IL_000f:  nop
    IL_0010:  leave.s    IL_001a
  }
  finally
  {
    IL_0012:  ldloc.0
    IL_0013:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0018:  nop
    IL_0019:  endfinally
  }
  IL_001a:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,20216,22053);

Microsoft.CodeAnalysis.MetadataReference
f_23110_20563_20578()
{
var return_v = MscorlibRef_v20 ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 20563, 20578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_20481_20581(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20481, 20581);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23110_20697_20712()
{
var return_v = MscorlibRef_v20 ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 20697, 20712);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_20615_20715(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20615, 20715);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_20748_20773()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20748, 20773);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_20801_20846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20801, 20846);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_20879_20909(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20879, 20909);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_20938_20981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 20938, 20981);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_21049_21087(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21049, 21087);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_21014_21124(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21014, 21124);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_21155_21198(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21155, 21198);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_21386_21425(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21386, 21425);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_21301_21457(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21301, 21457);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_21225_21458(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21225, 21458);
return return_v;
}


int
f_23110_21475_22041(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 21475, 22041);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,20216,22053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,20216,22053);
}
		}

[Fact]
        public void Fixed()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,22065,25042);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22125,22391);

var 
source =
@"class C
{
    unsafe static void M(string s, int[] i)
    {
        fixed (char *p = s)
        {
            fixed (int *q = i)
            {
            }
            fixed (char *r = s)
            {
            }
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22405,22487);

var 
compilation0 = f_23110_22424_22486(source, options: TestOptions.UnsafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22501,22552);

var 
compilation1 = f_23110_22520_22551(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22568,22610);

var 
testData0 = f_23110_22584_22609()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22624,22683);

var 
bytes0 = f_23110_22637_22682(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22697,22746);

var 
methodData0 = f_23110_22715_22745(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22760,22818);

var 
method0 = f_23110_22774_22817(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,22832,22996);

var 
generation0 = f_23110_22850_22995(f_23110_22903_22941(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,23012,23070);

var 
method1 = f_23110_23026_23069(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,23084,23330);

var 
diff1 = f_23110_23096_23329(compilation1, generation0, f_23110_23172_23328(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_23257_23296(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,23346,25031);

f_23110_23346_25030(
            diff1, "C.M", @"
{
  // Code size       81 (0x51)
  .maxstack  2
  .locals init (char* V_0, //p
                pinned string V_1,
                int* V_2, //q
                [unchanged] V_3,
                char* V_4, //r
                pinned string V_5,
                pinned int[] V_6)
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  stloc.1
  IL_0003:  ldloc.1
  IL_0004:  conv.u
  IL_0005:  stloc.0
  IL_0006:  ldloc.0
  IL_0007:  brfalse.s  IL_0011
  IL_0009:  ldloc.0
  IL_000a:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_000f:  add
  IL_0010:  stloc.0
  IL_0011:  nop
  IL_0012:  ldarg.1
  IL_0013:  dup
  IL_0014:  stloc.s    V_6
  IL_0016:  brfalse.s  IL_001e
  IL_0018:  ldloc.s    V_6
  IL_001a:  ldlen
  IL_001b:  conv.i4
  IL_001c:  brtrue.s   IL_0023
  IL_001e:  ldc.i4.0
  IL_001f:  conv.u
  IL_0020:  stloc.2
  IL_0021:  br.s       IL_002d
  IL_0023:  ldloc.s    V_6
  IL_0025:  ldc.i4.0
  IL_0026:  ldelema    ""int""
  IL_002b:  conv.u
  IL_002c:  stloc.2
  IL_002d:  nop
  IL_002e:  nop
  IL_002f:  ldnull
  IL_0030:  stloc.s    V_6
  IL_0032:  ldarg.0
  IL_0033:  stloc.s    V_5
  IL_0035:  ldloc.s    V_5
  IL_0037:  conv.u
  IL_0038:  stloc.s    V_4
  IL_003a:  ldloc.s    V_4
  IL_003c:  brfalse.s  IL_0048
  IL_003e:  ldloc.s    V_4
  IL_0040:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_0045:  add
  IL_0046:  stloc.s    V_4
  IL_0048:  nop
  IL_0049:  nop
  IL_004a:  ldnull
  IL_004b:  stloc.s    V_5
  IL_004d:  nop
  IL_004e:  ldnull
  IL_004f:  stloc.1
  IL_0050:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,22065,25042);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_22424_22486(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22424, 22486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_22520_22551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22520, 22551);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_22584_22609()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22584, 22609);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_22637_22682(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22637, 22682);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_22715_22745(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22715, 22745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_22774_22817(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22774, 22817);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_22903_22941(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22903, 22941);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_22850_22995(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 22850, 22995);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_23026_23069(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 23026, 23069);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_23257_23296(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 23257, 23296);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_23172_23328(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 23172, 23328);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_23096_23329(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 23096, 23329);
return return_v;
}


int
f_23110_23346_25030(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 23346, 25030);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,22065,25042);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,22065,25042);
}
		}

[WorkItem(770053, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/770053")]
        [Fact]
        public void FixedMultiple()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,25054,29973);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25214,25627);

var 
source =
@"class C
{
    unsafe static void M(string s1, string s2, string s3, string s4)
    {
        fixed (char* p1 = s1, p2 = s2)
        {
            *p1 = *p2;
        }
        fixed (char* p1 = s1, p3 = s3, p2 = s4)
        {
            *p1 = *p2;
            *p2 = *p3;
            fixed (char *p4 = s2)
            {
                *p3 = *p4;
            }
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25641,25723);

var 
compilation0 = f_23110_25660_25722(source, options: TestOptions.UnsafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25737,25788);

var 
compilation1 = f_23110_25756_25787(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25804,25846);

var 
testData0 = f_23110_25820_25845()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25860,25919);

var 
bytes0 = f_23110_25873_25918(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25933,25982);

var 
methodData0 = f_23110_25951_25981(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,25996,26054);

var 
method0 = f_23110_26010_26053(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,26068,26232);

var 
generation0 = f_23110_26086_26231(f_23110_26139_26177(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,26248,26306);

var 
method1 = f_23110_26262_26305(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,26320,26566);

var 
diff1 = f_23110_26332_26565(compilation1, generation0, f_23110_26408_26564(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_26493_26532(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,26582,29962);

f_23110_26582_29961(
            diff1, "C.M", @"
{
  // Code size      166 (0xa6)
  .maxstack  2
  .locals init (char* V_0, //p1
                char* V_1, //p2
                pinned string V_2,
                pinned string V_3,
                char* V_4, //p1
                char* V_5, //p3
                char* V_6, //p2
                pinned string V_7,
                pinned string V_8,
                pinned string V_9,
                char* V_10, //p4
                pinned string V_11)
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  stloc.2
  IL_0003:  ldloc.2
  IL_0004:  conv.u
  IL_0005:  stloc.0
  IL_0006:  ldloc.0
  IL_0007:  brfalse.s  IL_0011
  IL_0009:  ldloc.0
  IL_000a:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_000f:  add
  IL_0010:  stloc.0
  IL_0011:  ldarg.1
  IL_0012:  stloc.3
  IL_0013:  ldloc.3
  IL_0014:  conv.u
  IL_0015:  stloc.1
  IL_0016:  ldloc.1
  IL_0017:  brfalse.s  IL_0021
  IL_0019:  ldloc.1
  IL_001a:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_001f:  add
  IL_0020:  stloc.1
  IL_0021:  nop
  IL_0022:  ldloc.0
  IL_0023:  ldloc.1
  IL_0024:  ldind.u2
  IL_0025:  stind.i2
  IL_0026:  nop
  IL_0027:  ldnull
  IL_0028:  stloc.2
  IL_0029:  ldnull
  IL_002a:  stloc.3
  IL_002b:  ldarg.0
  IL_002c:  stloc.s    V_7
  IL_002e:  ldloc.s    V_7
  IL_0030:  conv.u
  IL_0031:  stloc.s    V_4
  IL_0033:  ldloc.s    V_4
  IL_0035:  brfalse.s  IL_0041
  IL_0037:  ldloc.s    V_4
  IL_0039:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_003e:  add
  IL_003f:  stloc.s    V_4
  IL_0041:  ldarg.2
  IL_0042:  stloc.s    V_8
  IL_0044:  ldloc.s    V_8
  IL_0046:  conv.u
  IL_0047:  stloc.s    V_5
  IL_0049:  ldloc.s    V_5
  IL_004b:  brfalse.s  IL_0057
  IL_004d:  ldloc.s    V_5
  IL_004f:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_0054:  add
  IL_0055:  stloc.s    V_5
  IL_0057:  ldarg.3
  IL_0058:  stloc.s    V_9
  IL_005a:  ldloc.s    V_9
  IL_005c:  conv.u
  IL_005d:  stloc.s    V_6
  IL_005f:  ldloc.s    V_6
  IL_0061:  brfalse.s  IL_006d
  IL_0063:  ldloc.s    V_6
  IL_0065:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_006a:  add
  IL_006b:  stloc.s    V_6
  IL_006d:  nop
  IL_006e:  ldloc.s    V_4
  IL_0070:  ldloc.s    V_6
  IL_0072:  ldind.u2
  IL_0073:  stind.i2
  IL_0074:  ldloc.s    V_6
  IL_0076:  ldloc.s    V_5
  IL_0078:  ldind.u2
  IL_0079:  stind.i2
  IL_007a:  ldarg.1
  IL_007b:  stloc.s    V_11
  IL_007d:  ldloc.s    V_11
  IL_007f:  conv.u
  IL_0080:  stloc.s    V_10
  IL_0082:  ldloc.s    V_10
  IL_0084:  brfalse.s  IL_0090
  IL_0086:  ldloc.s    V_10
  IL_0088:  call       ""int System.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData.get""
  IL_008d:  add
  IL_008e:  stloc.s    V_10
  IL_0090:  nop
  IL_0091:  ldloc.s    V_5
  IL_0093:  ldloc.s    V_10
  IL_0095:  ldind.u2
  IL_0096:  stind.i2
  IL_0097:  nop
  IL_0098:  ldnull
  IL_0099:  stloc.s    V_11
  IL_009b:  nop
  IL_009c:  ldnull
  IL_009d:  stloc.s    V_7
  IL_009f:  ldnull
  IL_00a0:  stloc.s    V_8
  IL_00a2:  ldnull
  IL_00a3:  stloc.s    V_9
  IL_00a5:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,25054,29973);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_25660_25722(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 25660, 25722);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_25756_25787(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 25756, 25787);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_25820_25845()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 25820, 25845);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_25873_25918(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 25873, 25918);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_25951_25981(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 25951, 25981);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_26010_26053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26010, 26053);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_26139_26177(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26139, 26177);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_26086_26231(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26086, 26231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_26262_26305(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26262, 26305);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_26493_26532(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26493, 26532);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_26408_26564(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26408, 26564);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_26332_26565(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26332, 26565);
return return_v;
}


int
f_23110_26582_29961(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 26582, 29961);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,25054,29973);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,25054,29973);
}
		}

[Fact]
        public void ForEach()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,29985,37095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30047,30598);

var 
source =
@"using System.Collections;
using System.Collections.Generic;
class C
{
    static IEnumerable F1() { return null; }
    static List<object> F2() { return null; }
    static IEnumerable F3() { return null; }
    static List<object> F4() { return null; }
    static void M()
    {
        foreach (var @x in F1())
        {
            foreach (object y in F2()) { }
        }
        foreach (var x in F4())
        {
            foreach (var y in F3()) { }
            foreach (var z in F2()) { }
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30612,30688);

var 
compilation0 = f_23110_30631_30687(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30702,30753);

var 
compilation1 = f_23110_30721_30752(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30769,30811);

var 
testData0 = f_23110_30785_30810()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30825,30884);

var 
bytes0 = f_23110_30838_30883(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30898,30947);

var 
methodData0 = f_23110_30916_30946(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,30961,31019);

var 
method0 = f_23110_30975_31018(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,31033,31197);

var 
generation0 = f_23110_31051_31196(f_23110_31104_31142(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,31213,31271);

var 
method1 = f_23110_31227_31270(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,31285,31531);

var 
diff1 = f_23110_31297_31530(compilation1, generation0, f_23110_31373_31529(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_31458_31497(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,31547,37084);

f_23110_31547_37083(
            diff1, "C.M", @"{
  // Code size      272 (0x110)
  .maxstack  1
  .locals init (System.Collections.IEnumerator V_0,
                object V_1, //x
                System.Collections.Generic.List<object>.Enumerator V_2,
                object V_3, //y
                [unchanged] V_4,
                System.Collections.Generic.List<object>.Enumerator V_5,
                object V_6, //x
                System.Collections.IEnumerator V_7,
                object V_8, //y
                System.Collections.Generic.List<object>.Enumerator V_9,
                object V_10, //z
                System.IDisposable V_11)
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  call       ""System.Collections.IEnumerable C.F1()""
  IL_0007:  callvirt   ""System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()""
  IL_000c:  stloc.0
  .try
  {
    IL_000d:  br.s       IL_004a
    IL_000f:  ldloc.0
    IL_0010:  callvirt   ""object System.Collections.IEnumerator.Current.get""
    IL_0015:  stloc.1
    IL_0016:  nop
    IL_0017:  nop
    IL_0018:  call       ""System.Collections.Generic.List<object> C.F2()""
    IL_001d:  callvirt   ""System.Collections.Generic.List<object>.Enumerator System.Collections.Generic.List<object>.GetEnumerator()""
    IL_0022:  stloc.2
    .try
    {
      IL_0023:  br.s       IL_002f
      IL_0025:  ldloca.s   V_2
      IL_0027:  call       ""object System.Collections.Generic.List<object>.Enumerator.Current.get""
      IL_002c:  stloc.3
      IL_002d:  nop
      IL_002e:  nop
      IL_002f:  ldloca.s   V_2
      IL_0031:  call       ""bool System.Collections.Generic.List<object>.Enumerator.MoveNext()""
      IL_0036:  brtrue.s   IL_0025
      IL_0038:  leave.s    IL_0049
    }
    finally
    {
      IL_003a:  ldloca.s   V_2
      IL_003c:  constrained. ""System.Collections.Generic.List<object>.Enumerator""
      IL_0042:  callvirt   ""void System.IDisposable.Dispose()""
      IL_0047:  nop
      IL_0048:  endfinally
    }
    IL_0049:  nop
    IL_004a:  ldloc.0
    IL_004b:  callvirt   ""bool System.Collections.IEnumerator.MoveNext()""
    IL_0050:  brtrue.s   IL_000f
    IL_0052:  leave.s    IL_0069
  }
  finally
  {
    IL_0054:  ldloc.0
    IL_0055:  isinst     ""System.IDisposable""
    IL_005a:  stloc.s    V_11
    IL_005c:  ldloc.s    V_11
    IL_005e:  brfalse.s  IL_0068
    IL_0060:  ldloc.s    V_11
    IL_0062:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0067:  nop
    IL_0068:  endfinally
  }
  IL_0069:  nop
  IL_006a:  call       ""System.Collections.Generic.List<object> C.F4()""
  IL_006f:  callvirt   ""System.Collections.Generic.List<object>.Enumerator System.Collections.Generic.List<object>.GetEnumerator()""
  IL_0074:  stloc.s    V_5
  .try
  {
    IL_0076:  br.s       IL_00f2
    IL_0078:  ldloca.s   V_5
    IL_007a:  call       ""object System.Collections.Generic.List<object>.Enumerator.Current.get""
    IL_007f:  stloc.s    V_6
    IL_0081:  nop
    IL_0082:  nop
    IL_0083:  call       ""System.Collections.IEnumerable C.F3()""
    IL_0088:  callvirt   ""System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()""
    IL_008d:  stloc.s    V_7
    .try
    {
      IL_008f:  br.s       IL_009c
      IL_0091:  ldloc.s    V_7
      IL_0093:  callvirt   ""object System.Collections.IEnumerator.Current.get""
      IL_0098:  stloc.s    V_8
      IL_009a:  nop
      IL_009b:  nop
      IL_009c:  ldloc.s    V_7
      IL_009e:  callvirt   ""bool System.Collections.IEnumerator.MoveNext()""
      IL_00a3:  brtrue.s   IL_0091
      IL_00a5:  leave.s    IL_00bd
    }
    finally
    {
      IL_00a7:  ldloc.s    V_7
      IL_00a9:  isinst     ""System.IDisposable""
      IL_00ae:  stloc.s    V_11
      IL_00b0:  ldloc.s    V_11
      IL_00b2:  brfalse.s  IL_00bc
      IL_00b4:  ldloc.s    V_11
      IL_00b6:  callvirt   ""void System.IDisposable.Dispose()""
      IL_00bb:  nop
      IL_00bc:  endfinally
    }
    IL_00bd:  nop
    IL_00be:  call       ""System.Collections.Generic.List<object> C.F2()""
    IL_00c3:  callvirt   ""System.Collections.Generic.List<object>.Enumerator System.Collections.Generic.List<object>.GetEnumerator()""
    IL_00c8:  stloc.s    V_9
    .try
    {
      IL_00ca:  br.s       IL_00d7
      IL_00cc:  ldloca.s   V_9
      IL_00ce:  call       ""object System.Collections.Generic.List<object>.Enumerator.Current.get""
      IL_00d3:  stloc.s    V_10
      IL_00d5:  nop
      IL_00d6:  nop
      IL_00d7:  ldloca.s   V_9
      IL_00d9:  call       ""bool System.Collections.Generic.List<object>.Enumerator.MoveNext()""
      IL_00de:  brtrue.s   IL_00cc
      IL_00e0:  leave.s    IL_00f1
    }
    finally
    {
      IL_00e2:  ldloca.s   V_9
      IL_00e4:  constrained. ""System.Collections.Generic.List<object>.Enumerator""
      IL_00ea:  callvirt   ""void System.IDisposable.Dispose()""
      IL_00ef:  nop
      IL_00f0:  endfinally
    }
    IL_00f1:  nop
    IL_00f2:  ldloca.s   V_5
    IL_00f4:  call       ""bool System.Collections.Generic.List<object>.Enumerator.MoveNext()""
    IL_00f9:  brtrue     IL_0078
    IL_00fe:  leave.s    IL_010f
  }
  finally
  {
    IL_0100:  ldloca.s   V_5
    IL_0102:  constrained. ""System.Collections.Generic.List<object>.Enumerator""
    IL_0108:  callvirt   ""void System.IDisposable.Dispose()""
    IL_010d:  nop
    IL_010e:  endfinally
  }
  IL_010f:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,29985,37095);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_30631_30687(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30631, 30687);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_30721_30752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30721, 30752);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_30785_30810()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30785, 30810);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_30838_30883(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30838, 30883);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_30916_30946(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30916, 30946);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_30975_31018(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 30975, 31018);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_31104_31142(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31104, 31142);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_31051_31196(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31051, 31196);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_31227_31270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31227, 31270);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_31458_31497(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31458, 31497);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_31373_31529(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31373, 31529);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_31297_31530(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31297, 31530);
return return_v;
}


int
f_23110_31547_37083(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 31547, 37083);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,29985,37095);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,29985,37095);
}
		}

[Fact]
        public void ForEachArray1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,37107,42301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,37175,37305);

var 
source =
@"class C
{
    static void M(double[,,] c)
    {
        foreach (var x in c)
        {
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,37319,37395);

var 
compilation0 = f_23110_37338_37394(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,37409,37460);

var 
compilation1 = f_23110_37428_37459(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,37476,37516);

var 
v0 = f_23110_37485_37515(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,37532,39574);

f_23110_37532_39573(
            v0, "C.M", @"
{
  // Code size      111 (0x6f)
  .maxstack  4
  .locals init (double[,,] V_0,
                int V_1,
                int V_2,
                int V_3,
                int V_4,
                int V_5,
                int V_6,
                double V_7) //x
 -IL_0000:  nop
 -IL_0001:  nop
 -IL_0002:  ldarg.0
  IL_0003:  stloc.0
  IL_0004:  ldloc.0
  IL_0005:  ldc.i4.0
  IL_0006:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_000b:  stloc.1
  IL_000c:  ldloc.0
  IL_000d:  ldc.i4.1
  IL_000e:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0013:  stloc.2
  IL_0014:  ldloc.0
  IL_0015:  ldc.i4.2
  IL_0016:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_001b:  stloc.3
  IL_001c:  ldloc.0
  IL_001d:  ldc.i4.0
  IL_001e:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0023:  stloc.s    V_4
 ~IL_0025:  br.s       IL_0069
  IL_0027:  ldloc.0
  IL_0028:  ldc.i4.1
  IL_0029:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_002e:  stloc.s    V_5
 ~IL_0030:  br.s       IL_005e
  IL_0032:  ldloc.0
  IL_0033:  ldc.i4.2
  IL_0034:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0039:  stloc.s    V_6
 ~IL_003b:  br.s       IL_0053
 -IL_003d:  ldloc.0
  IL_003e:  ldloc.s    V_4
  IL_0040:  ldloc.s    V_5
  IL_0042:  ldloc.s    V_6
  IL_0044:  call       ""double[*,*,*].Get""
  IL_0049:  stloc.s    V_7
 -IL_004b:  nop
 -IL_004c:  nop
 ~IL_004d:  ldloc.s    V_6
  IL_004f:  ldc.i4.1
  IL_0050:  add
  IL_0051:  stloc.s    V_6
 -IL_0053:  ldloc.s    V_6
  IL_0055:  ldloc.3
  IL_0056:  ble.s      IL_003d
 ~IL_0058:  ldloc.s    V_5
  IL_005a:  ldc.i4.1
  IL_005b:  add
  IL_005c:  stloc.s    V_5
 -IL_005e:  ldloc.s    V_5
  IL_0060:  ldloc.2
  IL_0061:  ble.s      IL_0032
 ~IL_0063:  ldloc.s    V_4
  IL_0065:  ldc.i4.1
  IL_0066:  add
  IL_0067:  stloc.s    V_4
 -IL_0069:  ldloc.s    V_4
  IL_006b:  ldloc.1
  IL_006c:  ble.s      IL_0027
 -IL_006e:  ret
}", sequencePoints: "C.M");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,39590,39641);

var 
methodData0 = f_23110_39608_39640(f_23110_39608_39619(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,39655,39713);

var 
method0 = f_23110_39669_39712(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,39727,39872);

var 
generation0 = f_23110_39745_39871(f_23110_39780_39834(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,39888,39946);

var 
method1 = f_23110_39902_39945(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,39960,40206);

var 
diff1 = f_23110_39972_40205(compilation1, generation0, f_23110_40048_40204(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_40133_40172(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,40222,42290);

f_23110_40222_42289(
            diff1, "C.M", @"
{
  // Code size      111 (0x6f)
  .maxstack  4
  .locals init (double[,,] V_0,
                int V_1,
                int V_2,
                int V_3,
                int V_4,
                int V_5,
                int V_6,
                double V_7) //x
 -IL_0000:  nop
 -IL_0001:  nop
 -IL_0002:  ldarg.0
  IL_0003:  stloc.0
  IL_0004:  ldloc.0
  IL_0005:  ldc.i4.0
  IL_0006:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_000b:  stloc.1
  IL_000c:  ldloc.0
  IL_000d:  ldc.i4.1
  IL_000e:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0013:  stloc.2
  IL_0014:  ldloc.0
  IL_0015:  ldc.i4.2
  IL_0016:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_001b:  stloc.3
  IL_001c:  ldloc.0
  IL_001d:  ldc.i4.0
  IL_001e:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0023:  stloc.s    V_4
 ~IL_0025:  br.s       IL_0069
  IL_0027:  ldloc.0
  IL_0028:  ldc.i4.1
  IL_0029:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_002e:  stloc.s    V_5
 ~IL_0030:  br.s       IL_005e
  IL_0032:  ldloc.0
  IL_0033:  ldc.i4.2
  IL_0034:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0039:  stloc.s    V_6
 ~IL_003b:  br.s       IL_0053
 -IL_003d:  ldloc.0
  IL_003e:  ldloc.s    V_4
  IL_0040:  ldloc.s    V_5
  IL_0042:  ldloc.s    V_6
  IL_0044:  call       ""double[*,*,*].Get""
  IL_0049:  stloc.s    V_7
 -IL_004b:  nop
 -IL_004c:  nop
 ~IL_004d:  ldloc.s    V_6
  IL_004f:  ldc.i4.1
  IL_0050:  add
  IL_0051:  stloc.s    V_6
 -IL_0053:  ldloc.s    V_6
  IL_0055:  ldloc.3
  IL_0056:  ble.s      IL_003d
 ~IL_0058:  ldloc.s    V_5
  IL_005a:  ldc.i4.1
  IL_005b:  add
  IL_005c:  stloc.s    V_5
 -IL_005e:  ldloc.s    V_5
  IL_0060:  ldloc.2
  IL_0061:  ble.s      IL_0032
 ~IL_0063:  ldloc.s    V_4
  IL_0065:  ldc.i4.1
  IL_0066:  add
  IL_0067:  stloc.s    V_4
 -IL_0069:  ldloc.s    V_4
  IL_006b:  ldloc.1
  IL_006c:  ble.s      IL_0027
 -IL_006e:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,37107,42301);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_37338_37394(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 37338, 37394);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_37428_37459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 37428, 37459);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_37485_37515(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 37485, 37515);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_37532_39573(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 37532, 39573);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_39608_39619(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 39608, 39619);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_39608_39640(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39608, 39640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_39669_39712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39669, 39712);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_39780_39834(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39780, 39834);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_39745_39871(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39745, 39871);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_39902_39945(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39902, 39945);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_40133_40172(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 40133, 40172);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_40048_40204(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 40048, 40204);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_39972_40205(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 39972, 40205);
return return_v;
}


int
f_23110_40222_42289(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 40222, 42289);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,37107,42301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,37107,42301);
}
		}

[Fact]
        public void ForEachArray2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,42313,46908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42381,42649);

var 
source =
@"class C
{
    static void M(string a, object[] b, double[,,] c)
    {
        foreach (var x in a)
        {
            foreach (var y in b)
            {
            }
        }
        foreach (var x in c)
        {
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42663,42739);

var 
compilation0 = f_23110_42682_42738(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42753,42804);

var 
compilation1 = f_23110_42772_42803(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42820,42862);

var 
testData0 = f_23110_42836_42861()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42876,42935);

var 
bytes0 = f_23110_42889_42934(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,42949,42998);

var 
methodData0 = f_23110_42967_42997(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,43012,43070);

var 
method0 = f_23110_43026_43069(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,43084,43248);

var 
generation0 = f_23110_43102_43247(f_23110_43155_43193(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,43264,43322);

var 
method1 = f_23110_43278_43321(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,43336,43582);

var 
diff1 = f_23110_43348_43581(compilation1, generation0, f_23110_43424_43580(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_43509_43548(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,43598,46897);

f_23110_43598_46896(
            diff1, "C.M", @"
{
  // Code size      184 (0xb8)
  .maxstack  4
  .locals init (string V_0,
                int V_1,
                char V_2, //x
                object[] V_3,
                int V_4,
                object V_5, //y
                double[,,] V_6,
                int V_7,
                int V_8,
                int V_9,
                int V_10,
                int V_11,
                int V_12,
                double V_13) //x
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  ldarg.0
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.0
  IL_0005:  stloc.1
  IL_0006:  br.s       IL_0033
  IL_0008:  ldloc.0
  IL_0009:  ldloc.1
  IL_000a:  callvirt   ""char string.this[int].get""
  IL_000f:  stloc.2
  IL_0010:  nop
  IL_0011:  nop
  IL_0012:  ldarg.1
  IL_0013:  stloc.3
  IL_0014:  ldc.i4.0
  IL_0015:  stloc.s    V_4
  IL_0017:  br.s       IL_0027
  IL_0019:  ldloc.3
  IL_001a:  ldloc.s    V_4
  IL_001c:  ldelem.ref
  IL_001d:  stloc.s    V_5
  IL_001f:  nop
  IL_0020:  nop
  IL_0021:  ldloc.s    V_4
  IL_0023:  ldc.i4.1
  IL_0024:  add
  IL_0025:  stloc.s    V_4
  IL_0027:  ldloc.s    V_4
  IL_0029:  ldloc.3
  IL_002a:  ldlen
  IL_002b:  conv.i4
  IL_002c:  blt.s      IL_0019
  IL_002e:  nop
  IL_002f:  ldloc.1
  IL_0030:  ldc.i4.1
  IL_0031:  add
  IL_0032:  stloc.1
  IL_0033:  ldloc.1
  IL_0034:  ldloc.0
  IL_0035:  callvirt   ""int string.Length.get""
  IL_003a:  blt.s      IL_0008
  IL_003c:  nop
  IL_003d:  ldarg.2
  IL_003e:  stloc.s    V_6
  IL_0040:  ldloc.s    V_6
  IL_0042:  ldc.i4.0
  IL_0043:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0048:  stloc.s    V_7
  IL_004a:  ldloc.s    V_6
  IL_004c:  ldc.i4.1
  IL_004d:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0052:  stloc.s    V_8
  IL_0054:  ldloc.s    V_6
  IL_0056:  ldc.i4.2
  IL_0057:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_005c:  stloc.s    V_9
  IL_005e:  ldloc.s    V_6
  IL_0060:  ldc.i4.0
  IL_0061:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0066:  stloc.s    V_10
  IL_0068:  br.s       IL_00b1
  IL_006a:  ldloc.s    V_6
  IL_006c:  ldc.i4.1
  IL_006d:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0072:  stloc.s    V_11
  IL_0074:  br.s       IL_00a5
  IL_0076:  ldloc.s    V_6
  IL_0078:  ldc.i4.2
  IL_0079:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_007e:  stloc.s    V_12
  IL_0080:  br.s       IL_0099
  IL_0082:  ldloc.s    V_6
  IL_0084:  ldloc.s    V_10
  IL_0086:  ldloc.s    V_11
  IL_0088:  ldloc.s    V_12
  IL_008a:  call       ""double[*,*,*].Get""
  IL_008f:  stloc.s    V_13
  IL_0091:  nop
  IL_0092:  nop
  IL_0093:  ldloc.s    V_12
  IL_0095:  ldc.i4.1
  IL_0096:  add
  IL_0097:  stloc.s    V_12
  IL_0099:  ldloc.s    V_12
  IL_009b:  ldloc.s    V_9
  IL_009d:  ble.s      IL_0082
  IL_009f:  ldloc.s    V_11
  IL_00a1:  ldc.i4.1
  IL_00a2:  add
  IL_00a3:  stloc.s    V_11
  IL_00a5:  ldloc.s    V_11
  IL_00a7:  ldloc.s    V_8
  IL_00a9:  ble.s      IL_0076
  IL_00ab:  ldloc.s    V_10
  IL_00ad:  ldc.i4.1
  IL_00ae:  add
  IL_00af:  stloc.s    V_10
  IL_00b1:  ldloc.s    V_10
  IL_00b3:  ldloc.s    V_7
  IL_00b5:  ble.s      IL_006a
  IL_00b7:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,42313,46908);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_42682_42738(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 42682, 42738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_42772_42803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 42772, 42803);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_42836_42861()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 42836, 42861);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_42889_42934(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 42889, 42934);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_42967_42997(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 42967, 42997);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_43026_43069(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43026, 43069);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_43155_43193(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43155, 43193);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_43102_43247(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43102, 43247);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_43278_43321(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43278, 43321);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_43509_43548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43509, 43548);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_43424_43580(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43424, 43580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_43348_43581(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43348, 43581);
return return_v;
}


int
f_23110_43598_46896(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 43598, 46896);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,42313,46908);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,42313,46908);
}
		}

[Fact]
        public void ForEachArray_ToManyDimensions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,47044,48690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47128,47521);

var 
source =
@"class C
{
    static void M(object o)
    {
        foreach (var x in (object[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,])o)
        {
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47616,47657);

var 
tooManyCommas = f_23110_47636_47656(',', 256)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47671,47744);

f_23110_47671_47743(f_23110_47683_47738(source, tooManyCommas, StringComparison.Ordinal)> 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47760,47836);

var 
compilation0 = f_23110_47779_47835(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47850,47901);

var 
compilation1 = f_23110_47869_47900(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47917,47959);

var 
testData0 = f_23110_47933_47958()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,47973,48032);

var 
bytes0 = f_23110_47986_48031(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48046,48095);

var 
methodData0 = f_23110_48064_48094(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48109,48167);

var 
method0 = f_23110_48123_48166(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48181,48345);

var 
generation0 = f_23110_48199_48344(f_23110_48252_48290(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48361,48419);

var 
method1 = f_23110_48375_48418(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48433,48679);

var 
diff1 = f_23110_48445_48678(compilation1, generation0, f_23110_48521_48677(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_48606_48645(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,47044,48690);

string
f_23110_47636_47656(char
c,int
count)
{
var return_v = new string( c, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47636, 47656);
return return_v;
}


int
f_23110_47683_47738(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.IndexOf( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47683, 47738);
return return_v;
}


int
f_23110_47671_47743(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47671, 47743);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_47779_47835(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47779, 47835);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_47869_47900(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47869, 47900);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_47933_47958()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47933, 47958);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_47986_48031(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 47986, 48031);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_48064_48094(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48064, 48094);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_48123_48166(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48123, 48166);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_48252_48290(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48252, 48290);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_48199_48344(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48199, 48344);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_48375_48418(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48375, 48418);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_48606_48645(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48606, 48645);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_48521_48677(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48521, 48677);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_48445_48678(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48445, 48678);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,47044,48690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,47044,48690);
}
		}

[Fact]
        public void ForEachWithDynamicAndTuple()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,48702,53303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48783,48923);

var 
source =
@"class C
{
    static void M((dynamic, int) t)
    {
        foreach (var o in t.Item1)
        {
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,48937,49098);

var 
compilation0 = f_23110_48956_49097(source, options: TestOptions.DebugDll, references: new[] { f_23110_49085_49094()})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49112,49163);

var 
compilation1 = f_23110_49131_49162(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49179,49221);

var 
testData0 = f_23110_49195_49220()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49235,49294);

var 
bytes0 = f_23110_49248_49293(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49308,49357);

var 
methodData0 = f_23110_49326_49356(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49371,49429);

var 
method0 = f_23110_49385_49428(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49443,49607);

var 
generation0 = f_23110_49461_49606(f_23110_49514_49552(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49623,49681);

var 
method1 = f_23110_49637_49680(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49695,49941);

var 
diff1 = f_23110_49707_49940(compilation1, generation0, f_23110_49783_49939(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_49868_49907(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,49957,53292);

f_23110_49957_53291(
            diff1, "C.M", @"{
  // Code size      119 (0x77)
  .maxstack  3
  .locals init (System.Collections.IEnumerator V_0,
                object V_1, //o
                [unchanged] V_2,
                System.IDisposable V_3)
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>> C.<>o__0#1.<>p__0""
  IL_0007:  brfalse.s  IL_000b
  IL_0009:  br.s       IL_002f
  IL_000b:  ldc.i4.0
  IL_000c:  ldtoken    ""System.Collections.IEnumerable""
  IL_0011:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0016:  ldtoken    ""C""
  IL_001b:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0020:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_0025:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_002a:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>> C.<>o__0#1.<>p__0""
  IL_002f:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>> C.<>o__0#1.<>p__0""
  IL_0034:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>>.Target""
  IL_0039:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>> C.<>o__0#1.<>p__0""
  IL_003e:  ldarg.0
  IL_003f:  ldfld      ""dynamic System.ValueTuple<dynamic, int>.Item1""
  IL_0044:  callvirt   ""System.Collections.IEnumerable System.Func<System.Runtime.CompilerServices.CallSite, dynamic, System.Collections.IEnumerable>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_0049:  callvirt   ""System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()""
  IL_004e:  stloc.0
  .try
  {
    IL_004f:  br.s       IL_005a
    IL_0051:  ldloc.0
    IL_0052:  callvirt   ""object System.Collections.IEnumerator.Current.get""
    IL_0057:  stloc.1
    IL_0058:  nop
    IL_0059:  nop
    IL_005a:  ldloc.0
    IL_005b:  callvirt   ""bool System.Collections.IEnumerator.MoveNext()""
    IL_0060:  brtrue.s   IL_0051
    IL_0062:  leave.s    IL_0076
  }
  finally
  {
    IL_0064:  ldloc.0
    IL_0065:  isinst     ""System.IDisposable""
    IL_006a:  stloc.3
    IL_006b:  ldloc.3
    IL_006c:  brfalse.s  IL_0075
    IL_006e:  ldloc.3
    IL_006f:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0074:  nop
    IL_0075:  endfinally
  }
  IL_0076:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,48702,53303);

Microsoft.CodeAnalysis.MetadataReference
f_23110_49085_49094()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 49085, 49094);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_48956_49097(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 48956, 49097);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_49131_49162(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49131, 49162);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_49195_49220()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49195, 49220);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_49248_49293(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49248, 49293);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_49326_49356(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49326, 49356);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_49385_49428(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49385, 49428);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_49514_49552(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49514, 49552);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_49461_49606(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49461, 49606);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_49637_49680(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49637, 49680);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_49868_49907(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49868, 49907);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_49783_49939(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49783, 49939);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_49707_49940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49707, 49940);
return return_v;
}


int
f_23110_49957_53291(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 49957, 53291);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,48702,53303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,48702,53303);
}
		}

[Fact]
        public void RemoveRestoreNullableAtArrayElement()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,53315,58331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,53405,53664);

var 
source0 = f_23110_53419_53663(@"using System;
class C
{
    public static void M()
    {
        var <N:1>arr</N:1> = new string?[] { ""0"" };
        <N:0>foreach</N:0> (var s in arr)
        {
            Console.WriteLine(1);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,53710,53968);

var 
source1 = f_23110_53724_53967(@"using System;
class C
{
    public static void M()
    {
        var <N:1>arr</N:1> = new string[] { ""0"" };
        <N:0>foreach</N:0> (var s in arr)
        {
            Console.WriteLine(1);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,54015,54037);

var 
source2 = source0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,54053,54135);

var 
compilation0 = f_23110_54072_54134(source0.Tree, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,54151,54191);

var 
v0 = f_23110_54160_54190(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,54205,55167);

f_23110_54205_55166(            v0, "C.M", @"
{
  // Code size       47 (0x2f)
  .maxstack  4
  .locals init (string[] V_0, //arr
                string[] V_1,
                int V_2,
                string V_3) //s
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  newarr     ""string""
  IL_0007:  dup
  IL_0008:  ldc.i4.0
  IL_0009:  ldstr      ""0""
  IL_000e:  stelem.ref
  IL_000f:  stloc.0
  IL_0010:  nop
  IL_0011:  ldloc.0
  IL_0012:  stloc.1
  IL_0013:  ldc.i4.0
  IL_0014:  stloc.2
  IL_0015:  br.s       IL_0028
  IL_0017:  ldloc.1
  IL_0018:  ldloc.2
  IL_0019:  ldelem.ref
  IL_001a:  stloc.3
  IL_001b:  nop
  IL_001c:  ldc.i4.1
  IL_001d:  call       ""void System.Console.WriteLine(int)""
  IL_0022:  nop
  IL_0023:  nop
  IL_0024:  ldloc.2
  IL_0025:  ldc.i4.1
  IL_0026:  add
  IL_0027:  stloc.2
  IL_0028:  ldloc.2
  IL_0029:  ldloc.1
  IL_002a:  ldlen
  IL_002b:  conv.i4
  IL_002c:  blt.s      IL_0017
  IL_002e:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55183,55265);

var 
compilation1 = f_23110_55202_55264(source1.Tree, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55279,55336);

var 
compilation2 = f_23110_55298_55335(compilation0, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55352,55403);

var 
methodData0 = f_23110_55370_55402(f_23110_55370_55381(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55417,55475);

var 
method0 = f_23110_55431_55474(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55489,55634);

var 
generation0 = f_23110_55507_55633(f_23110_55542_55596(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55650,55708);

var 
method1 = f_23110_55664_55707(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55722,55970);

var 
diff1 = f_23110_55734_55969(compilation1, generation0, f_23110_55810_55968(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_55895_55936(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,55986,56951);

f_23110_55986_56950(
            diff1, "C.M", @"
{
  // Code size       47 (0x2f)
  .maxstack  4
  .locals init (string[] V_0, //arr
                string[] V_1,
                int V_2,
                string V_3) //s
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  newarr     ""string""
  IL_0007:  dup
  IL_0008:  ldc.i4.0
  IL_0009:  ldstr      ""0""
  IL_000e:  stelem.ref
  IL_000f:  stloc.0
  IL_0010:  nop
  IL_0011:  ldloc.0
  IL_0012:  stloc.1
  IL_0013:  ldc.i4.0
  IL_0014:  stloc.2
  IL_0015:  br.s       IL_0028
  IL_0017:  ldloc.1
  IL_0018:  ldloc.2
  IL_0019:  ldelem.ref
  IL_001a:  stloc.3
  IL_001b:  nop
  IL_001c:  ldc.i4.1
  IL_001d:  call       ""void System.Console.WriteLine(int)""
  IL_0022:  nop
  IL_0023:  nop
  IL_0024:  ldloc.2
  IL_0025:  ldc.i4.1
  IL_0026:  add
  IL_0027:  stloc.2
  IL_0028:  ldloc.2
  IL_0029:  ldloc.1
  IL_002a:  ldlen
  IL_002b:  conv.i4
  IL_002c:  blt.s      IL_0017
  IL_002e:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,56967,57025);

var 
method2 = f_23110_56981_57024(compilation2, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,57039,57296);

var 
diff2 = f_23110_57051_57295(compilation2, f_23110_57097_57117(diff1), f_23110_57136_57294(SemanticEdit.Create(SemanticEditKind.Update,method1,method2,f_23110_57221_57262(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,57312,58320);

f_23110_57312_58319(
            diff2, "C.M", @"{
  // Code size       47 (0x2f)
  .maxstack  4
  .locals init (string[] V_0, //arr
                string[] V_1,
                int V_2,
                string V_3) //s
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  newarr     ""string""
  IL_0007:  dup
  IL_0008:  ldc.i4.0
  IL_0009:  ldstr      ""0""
  IL_000e:  stelem.ref
  IL_000f:  stloc.0
 -IL_0010:  nop
 -IL_0011:  ldloc.0
  IL_0012:  stloc.1
  IL_0013:  ldc.i4.0
  IL_0014:  stloc.2
 ~IL_0015:  br.s       IL_0028
 -IL_0017:  ldloc.1
  IL_0018:  ldloc.2
  IL_0019:  ldelem.ref
  IL_001a:  stloc.3
 -IL_001b:  nop
 -IL_001c:  ldc.i4.1
  IL_001d:  call       ""void System.Console.WriteLine(int)""
  IL_0022:  nop
 -IL_0023:  nop
 ~IL_0024:  ldloc.2
  IL_0025:  ldc.i4.1
  IL_0026:  add
  IL_0027:  stloc.2
 -IL_0028:  ldloc.2
  IL_0029:  ldloc.1
  IL_002a:  ldlen
  IL_002b:  conv.i4
  IL_002c:  blt.s      IL_0017
 -IL_002e:  ret
}", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,53315,58331);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_53419_53663(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 53419, 53663);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_53724_53967(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 53724, 53967);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_54072_54134(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 54072, 54134);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_54160_54190(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 54160, 54190);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_54205_55166(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 54205, 55166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_55202_55264(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55202, 55264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_55298_55335(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55298, 55335);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_55370_55381(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 55370, 55381);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_55370_55402(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55370, 55402);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_55431_55474(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55431, 55474);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_55542_55596(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55542, 55596);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_55507_55633(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55507, 55633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_55664_55707(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55664, 55707);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_55895_55936(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55895, 55936);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_55810_55968(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55810, 55968);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_55734_55969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55734, 55969);
return return_v;
}


int
f_23110_55986_56950(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 55986, 56950);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_56981_57024(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 56981, 57024);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_57097_57117(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 57097, 57117);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_57221_57262(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 57221, 57262);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_57136_57294(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 57136, 57294);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_57051_57295(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 57051, 57295);
return return_v;
}


int
f_23110_57312_58319(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 57312, 58319);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,53315,58331);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,53315,58331);
}
		}

[Fact]
        public void AddAndDelete()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,58343,65729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,58410,58700);

var 
source0 =
@"class C
{
    static object F1() { return null; }
    static string F2() { return null; }
    static System.IDisposable F3() { return null; }
    static void M()
    {
        lock (F1()) { }
        foreach (var c in F2()) { }
        using (F3()) { }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,58752,59016);

var 
source1 =
@"class C
{
    static object F1() { return null; }
    static string F2() { return null; }
    static System.IDisposable F3() { return null; }
    static void M()
    {
        lock (F1()) { }
        foreach (var c in F2()) { }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,59081,59371);

var 
source2 =
@"class C
{
    static object F1() { return null; }
    static string F2() { return null; }
    static System.IDisposable F3() { return null; }
    static void M()
    {
        using (F3()) { }
        lock (F1()) { }
        foreach (var c in F2()) { }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,59385,59462);

var 
compilation0 = f_23110_59404_59461(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,59478,59518);

var 
v0 = f_23110_59487_59517(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,59532,61312);

f_23110_59532_61311(            v0, "C.M", @"
{
  // Code size       93 (0x5d)
  .maxstack  2
  .locals init (object V_0,
                bool V_1,
                string V_2,
                int V_3,
                char V_4, //c
                System.IDisposable V_5)
  IL_0000:  nop
  IL_0001:  call       ""object C.F1()""
  IL_0006:  stloc.0
  IL_0007:  ldc.i4.0
  IL_0008:  stloc.1
  .try
  {
    IL_0009:  ldloc.0
    IL_000a:  ldloca.s   V_1
    IL_000c:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0011:  nop
    IL_0012:  nop
    IL_0013:  nop
    IL_0014:  leave.s    IL_0021
  }
  finally
  {
    IL_0016:  ldloc.1
    IL_0017:  brfalse.s  IL_0020
    IL_0019:  ldloc.0
    IL_001a:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_001f:  nop
    IL_0020:  endfinally
  }
  IL_0021:  nop
  IL_0022:  call       ""string C.F2()""
  IL_0027:  stloc.2
  IL_0028:  ldc.i4.0
  IL_0029:  stloc.3
  IL_002a:  br.s       IL_003b
  IL_002c:  ldloc.2
  IL_002d:  ldloc.3
  IL_002e:  callvirt   ""char string.this[int].get""
  IL_0033:  stloc.s    V_4
  IL_0035:  nop
  IL_0036:  nop
  IL_0037:  ldloc.3
  IL_0038:  ldc.i4.1
  IL_0039:  add
  IL_003a:  stloc.3
  IL_003b:  ldloc.3
  IL_003c:  ldloc.2
  IL_003d:  callvirt   ""int string.Length.get""
  IL_0042:  blt.s      IL_002c
  IL_0044:  call       ""System.IDisposable C.F3()""
  IL_0049:  stloc.s    V_5
  .try
  {
    IL_004b:  nop
    IL_004c:  nop
    IL_004d:  leave.s    IL_005c
  }
  finally
  {
    IL_004f:  ldloc.s    V_5
    IL_0051:  brfalse.s  IL_005b
    IL_0053:  ldloc.s    V_5
    IL_0055:  callvirt   ""void System.IDisposable.Dispose()""
    IL_005a:  nop
    IL_005b:  endfinally
  }
  IL_005c:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61328,61405);

var 
compilation1 = f_23110_61347_61404(source1, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61419,61471);

var 
compilation2 = f_23110_61438_61470(compilation0, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61487,61538);

var 
methodData0 = f_23110_61505_61537(f_23110_61505_61516(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61552,61610);

var 
method0 = f_23110_61566_61609(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61624,61769);

var 
generation0 = f_23110_61642_61768(f_23110_61677_61731(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61785,61843);

var 
method1 = f_23110_61799_61842(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,61857,62103);

var 
diff1 = f_23110_61869_62102(compilation1, generation0, f_23110_61945_62101(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_62030_62069(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,62119,63499);

f_23110_62119_63498(
            diff1, "C.M", @"
{
  // Code size       69 (0x45)
  .maxstack  2
  .locals init (object V_0,
                bool V_1,
                string V_2,
                int V_3,
                char V_4, //c
                [unchanged] V_5)
  IL_0000:  nop
  IL_0001:  call       ""object C.F1()""
  IL_0006:  stloc.0
  IL_0007:  ldc.i4.0
  IL_0008:  stloc.1
  .try
  {
    IL_0009:  ldloc.0
    IL_000a:  ldloca.s   V_1
    IL_000c:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0011:  nop
    IL_0012:  nop
    IL_0013:  nop
    IL_0014:  leave.s    IL_0021
  }
  finally
  {
    IL_0016:  ldloc.1
    IL_0017:  brfalse.s  IL_0020
    IL_0019:  ldloc.0
    IL_001a:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_001f:  nop
    IL_0020:  endfinally
  }
  IL_0021:  nop
  IL_0022:  call       ""string C.F2()""
  IL_0027:  stloc.2
  IL_0028:  ldc.i4.0
  IL_0029:  stloc.3
  IL_002a:  br.s       IL_003b
  IL_002c:  ldloc.2
  IL_002d:  ldloc.3
  IL_002e:  callvirt   ""char string.this[int].get""
  IL_0033:  stloc.s    V_4
  IL_0035:  nop
  IL_0036:  nop
  IL_0037:  ldloc.3
  IL_0038:  ldc.i4.1
  IL_0039:  add
  IL_003a:  stloc.3
  IL_003b:  ldloc.3
  IL_003c:  ldloc.2
  IL_003d:  callvirt   ""int string.Length.get""
  IL_0042:  blt.s      IL_002c
  IL_0044:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,63515,63573);

var 
method2 = f_23110_63529_63572(compilation2, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,63587,63842);

var 
diff2 = f_23110_63599_63841(compilation2, f_23110_63645_63665(diff1), f_23110_63684_63840(SemanticEdit.Create(SemanticEditKind.Update,method1,method2,f_23110_63769_63808(method2, method1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,63858,65718);

f_23110_63858_65717(
            diff2, "C.M", @"{
  // Code size       93 (0x5d)
  .maxstack  2
  .locals init (object V_0,
                bool V_1,
                string V_2,
                int V_3,
                char V_4, //c
                [unchanged] V_5,
                System.IDisposable V_6)
 -IL_0000:  nop
 -IL_0001:  call       ""System.IDisposable C.F3()""
  IL_0006:  stloc.s    V_6
  .try
  {
   -IL_0008:  nop
   -IL_0009:  nop
    IL_000a:  leave.s    IL_0019
  }
  finally
  {
   ~IL_000c:  ldloc.s    V_6
    IL_000e:  brfalse.s  IL_0018
    IL_0010:  ldloc.s    V_6
    IL_0012:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0017:  nop
   ~IL_0018:  endfinally
  }
 -IL_0019:  call       ""object C.F1()""
  IL_001e:  stloc.0
  IL_001f:  ldc.i4.0
  IL_0020:  stloc.1
  .try
  {
    IL_0021:  ldloc.0
    IL_0022:  ldloca.s   V_1
    IL_0024:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0029:  nop
   -IL_002a:  nop
   -IL_002b:  nop
    IL_002c:  leave.s    IL_0039
  }
  finally
  {
   ~IL_002e:  ldloc.1
    IL_002f:  brfalse.s  IL_0038
    IL_0031:  ldloc.0
    IL_0032:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0037:  nop
   ~IL_0038:  endfinally
  }
 -IL_0039:  nop
 -IL_003a:  call       ""string C.F2()""
  IL_003f:  stloc.2
  IL_0040:  ldc.i4.0
  IL_0041:  stloc.3
 ~IL_0042:  br.s       IL_0053
 -IL_0044:  ldloc.2
  IL_0045:  ldloc.3
  IL_0046:  callvirt   ""char string.this[int].get""
  IL_004b:  stloc.s    V_4
 -IL_004d:  nop
 -IL_004e:  nop
 ~IL_004f:  ldloc.3
  IL_0050:  ldc.i4.1
  IL_0051:  add
  IL_0052:  stloc.3
 -IL_0053:  ldloc.3
  IL_0054:  ldloc.2
  IL_0055:  callvirt   ""int string.Length.get""
  IL_005a:  blt.s      IL_0044
 -IL_005c:  ret
}", methodToken: diff2.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,58343,65729);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_59404_59461(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 59404, 59461);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_59487_59517(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 59487, 59517);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_59532_61311(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 59532, 61311);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_61347_61404(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61347, 61404);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_61438_61470(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61438, 61470);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_61505_61516(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 61505, 61516);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_61505_61537(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61505, 61537);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_61566_61609(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61566, 61609);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_61677_61731(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61677, 61731);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_61642_61768(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61642, 61768);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_61799_61842(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61799, 61842);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_62030_62069(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 62030, 62069);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_61945_62101(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61945, 62101);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_61869_62102(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 61869, 62102);
return return_v;
}


int
f_23110_62119_63498(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 62119, 63498);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_63529_63572(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 63529, 63572);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_63645_63665(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 63645, 63665);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_63769_63808(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 63769, 63808);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_63684_63840(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 63684, 63840);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_63599_63841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 63599, 63841);
return return_v;
}


int
f_23110_63858_65717(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 63858, 65717);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,58343,65729);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,58343,65729);
}
		}

[Fact]
        public void Insert()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,65741,69822);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,65802,66083);

var 
source0 =
@"class C
{
    static object F1() { return null; }
    static object F2() { return null; }
    static object F3() { return null; }
    static object F4() { return null; }
    static void M()
    {
        lock (F1()) { }
        lock (F2()) { }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66097,66424);

var 
source1 =
@"class C
{
    static object F1() { return null; }
    static object F2() { return null; }
    static object F3() { return null; }
    static object F4() { return null; }
    static void M()
    {
        lock (F3()) { } // added
        lock (F1()) { }
        lock (F4()) { } // replaced
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66438,66515);

var 
compilation0 = f_23110_66457_66514(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66529,66581);

var 
compilation1 = f_23110_66548_66580(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66597,66639);

var 
testData0 = f_23110_66613_66638()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66653,66712);

var 
bytes0 = f_23110_66666_66711(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66726,66775);

var 
methodData0 = f_23110_66744_66774(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66789,66847);

var 
method0 = f_23110_66803_66846(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,66861,67025);

var 
generation0 = f_23110_66879_67024(f_23110_66932_66970(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,67041,67099);

var 
method1 = f_23110_67055_67098(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,67113,67359);

var 
diff1 = f_23110_67125_67358(compilation1, generation0, f_23110_67201_67357(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_67286_67325(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,67686,69811);

f_23110_67686_69810(
            // Note that the order of unique ids in temporaries follows the
            // order of declaration in the updated method. Specifically, the
            // original temporary names (and unique ids) are not preserved.
            // (Should not be an issue since the names are used by EnC only.)
            diff1, "C.M", @"{
  // Code size      108 (0x6c)
  .maxstack  2
  .locals init (object V_0,
                bool V_1,
                [object] V_2,
                [bool] V_3,
                object V_4,
                bool V_5,
                object V_6,
                bool V_7)
  IL_0000:  nop
  IL_0001:  call       ""object C.F3()""
  IL_0006:  stloc.s    V_4
  IL_0008:  ldc.i4.0
  IL_0009:  stloc.s    V_5
  .try
  {
    IL_000b:  ldloc.s    V_4
    IL_000d:  ldloca.s   V_5
    IL_000f:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0014:  nop
    IL_0015:  nop
    IL_0016:  nop
    IL_0017:  leave.s    IL_0026
  }
  finally
  {
    IL_0019:  ldloc.s    V_5
    IL_001b:  brfalse.s  IL_0025
    IL_001d:  ldloc.s    V_4
    IL_001f:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0024:  nop
    IL_0025:  endfinally
  }
  IL_0026:  call       ""object C.F1()""
  IL_002b:  stloc.0
  IL_002c:  ldc.i4.0
  IL_002d:  stloc.1
  .try
  {
    IL_002e:  ldloc.0
    IL_002f:  ldloca.s   V_1
    IL_0031:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0036:  nop
    IL_0037:  nop
    IL_0038:  nop
    IL_0039:  leave.s    IL_0046
  }
  finally
  {
    IL_003b:  ldloc.1
    IL_003c:  brfalse.s  IL_0045
    IL_003e:  ldloc.0
    IL_003f:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0044:  nop
    IL_0045:  endfinally
  }
  IL_0046:  call       ""object C.F4()""
  IL_004b:  stloc.s    V_6
  IL_004d:  ldc.i4.0
  IL_004e:  stloc.s    V_7
  .try
  {
    IL_0050:  ldloc.s    V_6
    IL_0052:  ldloca.s   V_7
    IL_0054:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0059:  nop
    IL_005a:  nop
    IL_005b:  nop
    IL_005c:  leave.s    IL_006b
  }
  finally
  {
    IL_005e:  ldloc.s    V_7
    IL_0060:  brfalse.s  IL_006a
    IL_0062:  ldloc.s    V_6
    IL_0064:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0069:  nop
    IL_006a:  endfinally
  }
  IL_006b:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,65741,69822);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_66457_66514(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66457, 66514);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_66548_66580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66548, 66580);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_66613_66638()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66613, 66638);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_66666_66711(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66666, 66711);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_66744_66774(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66744, 66774);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_66803_66846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66803, 66846);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_66932_66970(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66932, 66970);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_66879_67024(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 66879, 67024);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_67055_67098(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 67055, 67098);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_67286_67325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 67286, 67325);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_67201_67357(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 67201, 67357);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_67125_67358(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 67125, 67358);
return return_v;
}


int
f_23110_67686_69810(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 67686, 69810);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,65741,69822);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,65741,69822);
}
		}

[Fact]
        public void NoReuseDifferentTempKind()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,69975,73903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70054,70582);

var 
source =
@"class A : System.IDisposable
{
    public object Current { get { return null; } }
    public bool MoveNext() { return false; }
    public void Dispose() { }
    internal int this[A a] { get { return 0; } set { } }
}
class B
{
    public A GetEnumerator() { return null; }
}
class C
{
    static A F() { return null; }
    static B G() { return null; }
    static void M(A a)
    {
        a[F()]++;
        using (F()) { }
        lock (F()) { }
        foreach (var o in G()) { }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70598,70674);

var 
compilation0 = f_23110_70617_70673(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70688,70739);

var 
compilation1 = f_23110_70707_70738(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70755,70797);

var 
testData0 = f_23110_70771_70796()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70811,70870);

var 
bytes0 = f_23110_70824_70869(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70884,70933);

var 
methodData0 = f_23110_70902_70932(testData0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,70947,71005);

var 
method0 = f_23110_70961_71004(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,71019,71183);

var 
generation0 = f_23110_71037_71182(f_23110_71090_71128(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,71199,71257);

var 
method1 = f_23110_71213_71256(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,71271,71517);

var 
diff1 = f_23110_71283_71516(compilation1, generation0, f_23110_71359_71515(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_71444_71483(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,71533,73892);

f_23110_71533_73891(
            diff1, "C.M", @"
{
  // Code size      137 (0x89)
  .maxstack  4
  .locals init ([unchanged] V_0,
                [int] V_1,
                A V_2,
                A V_3,
                bool V_4,
                A V_5,
                object V_6, //o
                A V_7,
                int V_8)
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  call       ""A C.F()""
  IL_0007:  stloc.s    V_7
  IL_0009:  dup
  IL_000a:  ldloc.s    V_7
  IL_000c:  callvirt   ""int A.this[A].get""
  IL_0011:  stloc.s    V_8
  IL_0013:  ldloc.s    V_7
  IL_0015:  ldloc.s    V_8
  IL_0017:  ldc.i4.1
  IL_0018:  add
  IL_0019:  callvirt   ""void A.this[A].set""
  IL_001e:  nop
  IL_001f:  call       ""A C.F()""
  IL_0024:  stloc.2
  .try
  {
    IL_0025:  nop
    IL_0026:  nop
    IL_0027:  leave.s    IL_0034
  }
  finally
  {
    IL_0029:  ldloc.2
    IL_002a:  brfalse.s  IL_0033
    IL_002c:  ldloc.2
    IL_002d:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0032:  nop
    IL_0033:  endfinally
  }
  IL_0034:  call       ""A C.F()""
  IL_0039:  stloc.3
  IL_003a:  ldc.i4.0
  IL_003b:  stloc.s    V_4
  .try
  {
    IL_003d:  ldloc.3
    IL_003e:  ldloca.s   V_4
    IL_0040:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0045:  nop
    IL_0046:  nop
    IL_0047:  nop
    IL_0048:  leave.s    IL_0056
  }
  finally
  {
    IL_004a:  ldloc.s    V_4
    IL_004c:  brfalse.s  IL_0055
    IL_004e:  ldloc.3
    IL_004f:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0054:  nop
    IL_0055:  endfinally
  }
  IL_0056:  nop
  IL_0057:  call       ""B C.G()""
  IL_005c:  callvirt   ""A B.GetEnumerator()""
  IL_0061:  stloc.s    V_5
  .try
  {
    IL_0063:  br.s       IL_0070
    IL_0065:  ldloc.s    V_5
    IL_0067:  callvirt   ""object A.Current.get""
    IL_006c:  stloc.s    V_6
    IL_006e:  nop
    IL_006f:  nop
    IL_0070:  ldloc.s    V_5
    IL_0072:  callvirt   ""bool A.MoveNext()""
    IL_0077:  brtrue.s   IL_0065
    IL_0079:  leave.s    IL_0088
  }
  finally
  {
    IL_007b:  ldloc.s    V_5
    IL_007d:  brfalse.s  IL_0087
    IL_007f:  ldloc.s    V_5
    IL_0081:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0086:  nop
    IL_0087:  endfinally
  }
  IL_0088:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,69975,73903);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_70617_70673(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70617, 70673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_70707_70738(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70707, 70738);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_70771_70796()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70771, 70796);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_70824_70869(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70824, 70869);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_70902_70932(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70902, 70932);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_70961_71004(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 70961, 71004);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_71090_71128(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71090, 71128);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_71037_71182(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71037, 71182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_71213_71256(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71213, 71256);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_71444_71483(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71444, 71483);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_71359_71515(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71359, 71515);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_71283_71516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71283, 71516);
return return_v;
}


int
f_23110_71533_73891(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 71533, 73891);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,69975,73903);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,69975,73903);
}
		}

[Fact]
        public void Switch_String()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,73915,77425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,73983,74263);

var 
source0 =
@"class C
{
    static string F() { return null; }
    
    static void M()
    {
        switch (F())
        {
            case ""a"": System.Console.WriteLine(1); break;
            case ""b"": System.Console.WriteLine(2); break; 
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,74277,74571);

var 
source1 =
            @"class C
{
    static string F() { return null; }
    
    static void M()
    {
        switch (F())
        {
            case ""a"": System.Console.WriteLine(10); break;
            case ""b"": System.Console.WriteLine(20); break; 
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,74585,74662);

var 
compilation0 = f_23110_74604_74661(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,74676,74728);

var 
compilation1 = f_23110_74695_74727(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,74744,74784);

var 
v0 = f_23110_74753_74783(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,74918,75817);

f_23110_74918_75816(
            // Validate presence of a hidden sequence point @IL_0007 that is required for proper function remapping.
            v0, "C.M", @"
{
  // Code size       56 (0x38)
  .maxstack  2
  .locals init (string V_0,
                string V_1)
 -IL_0000:  nop
 -IL_0001:  call       ""string C.F()""
  IL_0006:  stloc.1
 ~IL_0007:  ldloc.1
  IL_0008:  stloc.0
 ~IL_0009:  ldloc.0
  IL_000a:  ldstr      ""a""
  IL_000f:  call       ""bool string.op_Equality(string, string)""
  IL_0014:  brtrue.s   IL_0025
  IL_0016:  ldloc.0
  IL_0017:  ldstr      ""b""
  IL_001c:  call       ""bool string.op_Equality(string, string)""
  IL_0021:  brtrue.s   IL_002e
  IL_0023:  br.s       IL_0037
 -IL_0025:  ldc.i4.1
  IL_0026:  call       ""void System.Console.WriteLine(int)""
  IL_002b:  nop
 -IL_002c:  br.s       IL_0037
 -IL_002e:  ldc.i4.2
  IL_002f:  call       ""void System.Console.WriteLine(int)""
  IL_0034:  nop
 -IL_0035:  br.s       IL_0037
 -IL_0037:  ret
}", sequencePoints: "C.M");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,75833,75884);

var 
methodData0 = f_23110_75851_75883(f_23110_75851_75862(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,75898,75956);

var 
method0 = f_23110_75912_75955(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,75970,76028);

var 
method1 = f_23110_75984_76027(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,76042,76187);

var 
generation0 = f_23110_76060_76186(f_23110_76095_76149(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,76203,76465);

var 
diff1 = f_23110_76215_76464(compilation1, generation0, f_23110_76291_76463(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_76376_76431(method0, SyntaxKind.SwitchStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,76481,77414);

f_23110_76481_77413(
            diff1, "C.M", @"
{
  // Code size       58 (0x3a)
  .maxstack  2
  .locals init (string V_0,
                string V_1)
 -IL_0000:  nop
 -IL_0001:  call       ""string C.F()""
  IL_0006:  stloc.1
 ~IL_0007:  ldloc.1
  IL_0008:  stloc.0
 ~IL_0009:  ldloc.0
  IL_000a:  ldstr      ""a""
  IL_000f:  call       ""bool string.op_Equality(string, string)""
  IL_0014:  brtrue.s   IL_0025
  IL_0016:  ldloc.0
  IL_0017:  ldstr      ""b""
  IL_001c:  call       ""bool string.op_Equality(string, string)""
  IL_0021:  brtrue.s   IL_002f
  IL_0023:  br.s       IL_0039
 -IL_0025:  ldc.i4.s   10
  IL_0027:  call       ""void System.Console.WriteLine(int)""
  IL_002c:  nop
 -IL_002d:  br.s       IL_0039
 -IL_002f:  ldc.i4.s   20
  IL_0031:  call       ""void System.Console.WriteLine(int)""
  IL_0036:  nop
 -IL_0037:  br.s       IL_0039
 -IL_0039:  ret
}", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,73915,77425);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_74604_74661(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 74604, 74661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_74695_74727(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 74695, 74727);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_74753_74783(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 74753, 74783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_74918_75816(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 74918, 75816);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_75851_75862(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 75851, 75862);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_75851_75883(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 75851, 75883);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_75912_75955(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 75912, 75955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_75984_76027(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 75984, 76027);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_76095_76149(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76095, 76149);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_76060_76186(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76060, 76186);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_76376_76431(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76376, 76431);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_76291_76463(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76291, 76463);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_76215_76464(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76215, 76464);
return return_v;
}


int
f_23110_76481_77413(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 76481, 77413);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,73915,77425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,73915,77425);
}
		}

[Fact]
        public void Switch_Integer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,77437,82052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,77506,77796);

var 
source0 = f_23110_77520_77795(@"class C
{
    static int F() { return 1; }
    
    static void M()
    {
        switch (F())
        {
            case 1: System.Console.WriteLine(1); break;
            case 2: System.Console.WriteLine(2); break; 
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,77810,78102);

var 
source1 = f_23110_77824_78101(@"class C
{
    static int F() { return 1; }
    
    static void M()
    {
        switch (F())
        {
            case 1: System.Console.WriteLine(10); break;
            case 2: System.Console.WriteLine(20); break; 
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,78116,78193);

var 
compilation0 = f_23110_78135_78192(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,78207,78259);

var 
compilation1 = f_23110_78226_78258(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,78275,78315);

var 
v0 = f_23110_78284_78314(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,78331,79078);

f_23110_78331_79077(
            v0, "C.M", @"
{
  // Code size       40 (0x28)
  .maxstack  2
  .locals init (int V_0,
                int V_1)
  IL_0000:  nop
  IL_0001:  call       ""int C.F()""
  IL_0006:  stloc.1
  IL_0007:  ldloc.1
  IL_0008:  stloc.0
  IL_0009:  ldloc.0
  IL_000a:  ldc.i4.1
  IL_000b:  beq.s      IL_0015
  IL_000d:  br.s       IL_000f
  IL_000f:  ldloc.0
  IL_0010:  ldc.i4.2
  IL_0011:  beq.s      IL_001e
  IL_0013:  br.s       IL_0027
  IL_0015:  ldc.i4.1
  IL_0016:  call       ""void System.Console.WriteLine(int)""
  IL_001b:  nop
  IL_001c:  br.s       IL_0027
  IL_001e:  ldc.i4.2
  IL_001f:  call       ""void System.Console.WriteLine(int)""
  IL_0024:  nop
  IL_0025:  br.s       IL_0027
  IL_0027:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,79164,80617);

f_23110_79164_80616(            // Validate that we emit a hidden sequence point @IL_0007.
            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""35"" offset=""11"" />
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""21"" document=""1"" />
        <entry offset=""0x7"" hidden=""true"" document=""1"" />
        <entry offset=""0x9"" hidden=""true"" document=""1"" />
        <entry offset=""0x15"" startLine=""9"" startColumn=""21"" endLine=""9"" endColumn=""49"" document=""1"" />
        <entry offset=""0x1c"" startLine=""9"" startColumn=""50"" endLine=""9"" endColumn=""56"" document=""1"" />
        <entry offset=""0x1e"" startLine=""10"" startColumn=""21"" endLine=""10"" endColumn=""49"" document=""1"" />
        <entry offset=""0x25"" startLine=""10"" startColumn=""50"" endLine=""10"" endColumn=""56"" document=""1"" />
        <entry offset=""0x27"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,80633,80684);

var 
methodData0 = f_23110_80651_80683(f_23110_80651_80662(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,80698,80756);

var 
method0 = f_23110_80712_80755(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,80770,80828);

var 
method1 = f_23110_80784_80827(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,80842,80987);

var 
generation0 = f_23110_80860_80986(f_23110_80895_80949(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,81003,81265);

var 
diff1 = f_23110_81015_81264(compilation1, generation0, f_23110_81091_81263(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_81176_81231(method0, SyntaxKind.SwitchStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,81281,82041);

f_23110_81281_82040(
            diff1, "C.M", @"
{
  // Code size       42 (0x2a)
  .maxstack  2
  .locals init (int V_0,
                int V_1)
  IL_0000:  nop
  IL_0001:  call       ""int C.F()""
  IL_0006:  stloc.1
  IL_0007:  ldloc.1
  IL_0008:  stloc.0
  IL_0009:  ldloc.0
  IL_000a:  ldc.i4.1
  IL_000b:  beq.s      IL_0015
  IL_000d:  br.s       IL_000f
  IL_000f:  ldloc.0
  IL_0010:  ldc.i4.2
  IL_0011:  beq.s      IL_001f
  IL_0013:  br.s       IL_0029
  IL_0015:  ldc.i4.s   10
  IL_0017:  call       ""void System.Console.WriteLine(int)""
  IL_001c:  nop
  IL_001d:  br.s       IL_0029
  IL_001f:  ldc.i4.s   20
  IL_0021:  call       ""void System.Console.WriteLine(int)""
  IL_0026:  nop
  IL_0027:  br.s       IL_0029
  IL_0029:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,77437,82052);

string
f_23110_77520_77795(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 77520, 77795);
return return_v;
}


string
f_23110_77824_78101(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 77824, 78101);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_78135_78192(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 78135, 78192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_78226_78258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 78226, 78258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_78284_78314(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 78284, 78314);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_78331_79077(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 78331, 79077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_79164_80616(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 79164, 80616);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_80651_80662(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 80651, 80662);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_80651_80683(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 80651, 80683);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_80712_80755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 80712, 80755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_80784_80827(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 80784, 80827);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_80895_80949(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 80895, 80949);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_80860_80986(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 80860, 80986);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_81176_81231(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 81176, 81231);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_81091_81263(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 81091, 81263);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_81015_81264(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 81015, 81264);
return return_v;
}


int
f_23110_81281_82040(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 81281, 82040);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,77437,82052);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,77437,82052);
}
		}

[Fact]
        public void Switch_Patterns()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,82064,88635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,82134,82681);

var 
source = f_23110_82147_82680(@"
using static System.Console;
class C
{
    static object F() => 1;
    static bool P() => false;
    
    static void M()
    {
        switch (F())
        {
            case 1: WriteLine(""int 1""); break;
            case byte b when P(): WriteLine(b); break; 
            case int i when P(): WriteLine(i); break;
            case (byte)1: WriteLine(""byte 1""); break; 
            case int j: WriteLine(j); break; 
            case object o: WriteLine(o); break; 
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,82695,82771);

var 
compilation0 = f_23110_82714_82770(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,82785,82836);

var 
compilation1 = f_23110_82804_82835(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,82852,82892);

var 
v0 = f_23110_82861_82891(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,82908,83599);

f_23110_82908_83598(
            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""106"" />
          <slot kind=""0"" offset=""162"" />
          <slot kind=""0"" offset=""273"" />
          <slot kind=""0"" offset=""323"" />
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
    </method>
  </methods>
</symbols>", options: PdbValidationOptions.ExcludeScopes | PdbValidationOptions.ExcludeSequencePoints);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,83615,85795);

f_23110_83615_85794(
            v0, "C.M", @"
{
  // Code size      147 (0x93)
  .maxstack  2
  .locals init (byte V_0, //b
                int V_1, //i
                int V_2, //j
                object V_3, //o
                object V_4)
  IL_0000:  nop
  IL_0001:  call       ""object C.F()""
  IL_0006:  stloc.s    V_4
  IL_0008:  ldloc.s    V_4
  IL_000a:  stloc.3
  IL_000b:  ldloc.3
  IL_000c:  isinst     ""int""
  IL_0011:  brfalse.s  IL_0020
  IL_0013:  ldloc.3
  IL_0014:  unbox.any  ""int""
  IL_0019:  stloc.1
  IL_001a:  ldloc.1
  IL_001b:  ldc.i4.1
  IL_001c:  beq.s      IL_003c
  IL_001e:  br.s       IL_005b
  IL_0020:  ldloc.3
  IL_0021:  isinst     ""byte""
  IL_0026:  brfalse.s  IL_0037
  IL_0028:  ldloc.3
  IL_0029:  unbox.any  ""byte""
  IL_002e:  stloc.0
  IL_002f:  br.s       IL_0049
  IL_0031:  ldloc.0
  IL_0032:  ldc.i4.1
  IL_0033:  beq.s      IL_006d
  IL_0035:  br.s       IL_0087
  IL_0037:  ldloc.3
  IL_0038:  brtrue.s   IL_0087
  IL_003a:  br.s       IL_0092
  IL_003c:  ldstr      ""int 1""
  IL_0041:  call       ""void System.Console.WriteLine(string)""
  IL_0046:  nop
  IL_0047:  br.s       IL_0092
  IL_0049:  call       ""bool C.P()""
  IL_004e:  brtrue.s   IL_0052
  IL_0050:  br.s       IL_0031
  IL_0052:  ldloc.0
  IL_0053:  call       ""void System.Console.WriteLine(int)""
  IL_0058:  nop
  IL_0059:  br.s       IL_0092
  IL_005b:  call       ""bool C.P()""
  IL_0060:  brtrue.s   IL_0064
  IL_0062:  br.s       IL_007a
  IL_0064:  ldloc.1
  IL_0065:  call       ""void System.Console.WriteLine(int)""
  IL_006a:  nop
  IL_006b:  br.s       IL_0092
  IL_006d:  ldstr      ""byte 1""
  IL_0072:  call       ""void System.Console.WriteLine(string)""
  IL_0077:  nop
  IL_0078:  br.s       IL_0092
  IL_007a:  ldloc.1
  IL_007b:  stloc.2
  IL_007c:  br.s       IL_007e
  IL_007e:  ldloc.2
  IL_007f:  call       ""void System.Console.WriteLine(int)""
  IL_0084:  nop
  IL_0085:  br.s       IL_0092
  IL_0087:  br.s       IL_0089
  IL_0089:  ldloc.3
  IL_008a:  call       ""void System.Console.WriteLine(object)""
  IL_008f:  nop
  IL_0090:  br.s       IL_0092
  IL_0092:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,85809,85860);

var 
methodData0 = f_23110_85827_85859(f_23110_85827_85838(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,85874,85932);

var 
method0 = f_23110_85888_85931(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,85946,86004);

var 
method1 = f_23110_85960_86003(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,86018,86163);

var 
generation0 = f_23110_86036_86162(f_23110_86071_86125(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,86179,86425);

var 
diff1 = f_23110_86191_86424(compilation1, generation0, f_23110_86267_86423(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_86352_86391(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,86441,88624);

f_23110_86441_88623(
            diff1, "C.M", @"
{
  // Code size      147 (0x93)
  .maxstack  2
  .locals init (byte V_0, //b
                int V_1, //i
                int V_2, //j
                object V_3, //o
                object V_4)
  IL_0000:  nop
  IL_0001:  call       ""object C.F()""
  IL_0006:  stloc.s    V_4
  IL_0008:  ldloc.s    V_4
  IL_000a:  stloc.3
  IL_000b:  ldloc.3
  IL_000c:  isinst     ""int""
  IL_0011:  brfalse.s  IL_0020
  IL_0013:  ldloc.3
  IL_0014:  unbox.any  ""int""
  IL_0019:  stloc.1
  IL_001a:  ldloc.1
  IL_001b:  ldc.i4.1
  IL_001c:  beq.s      IL_003c
  IL_001e:  br.s       IL_005b
  IL_0020:  ldloc.3
  IL_0021:  isinst     ""byte""
  IL_0026:  brfalse.s  IL_0037
  IL_0028:  ldloc.3
  IL_0029:  unbox.any  ""byte""
  IL_002e:  stloc.0
  IL_002f:  br.s       IL_0049
  IL_0031:  ldloc.0
  IL_0032:  ldc.i4.1
  IL_0033:  beq.s      IL_006d
  IL_0035:  br.s       IL_0087
  IL_0037:  ldloc.3
  IL_0038:  brtrue.s   IL_0087
  IL_003a:  br.s       IL_0092
  IL_003c:  ldstr      ""int 1""
  IL_0041:  call       ""void System.Console.WriteLine(string)""
  IL_0046:  nop
  IL_0047:  br.s       IL_0092
  IL_0049:  call       ""bool C.P()""
  IL_004e:  brtrue.s   IL_0052
  IL_0050:  br.s       IL_0031
  IL_0052:  ldloc.0
  IL_0053:  call       ""void System.Console.WriteLine(int)""
  IL_0058:  nop
  IL_0059:  br.s       IL_0092
  IL_005b:  call       ""bool C.P()""
  IL_0060:  brtrue.s   IL_0064
  IL_0062:  br.s       IL_007a
  IL_0064:  ldloc.1
  IL_0065:  call       ""void System.Console.WriteLine(int)""
  IL_006a:  nop
  IL_006b:  br.s       IL_0092
  IL_006d:  ldstr      ""byte 1""
  IL_0072:  call       ""void System.Console.WriteLine(string)""
  IL_0077:  nop
  IL_0078:  br.s       IL_0092
  IL_007a:  ldloc.1
  IL_007b:  stloc.2
  IL_007c:  br.s       IL_007e
  IL_007e:  ldloc.2
  IL_007f:  call       ""void System.Console.WriteLine(int)""
  IL_0084:  nop
  IL_0085:  br.s       IL_0092
  IL_0087:  br.s       IL_0089
  IL_0089:  ldloc.3
  IL_008a:  call       ""void System.Console.WriteLine(object)""
  IL_008f:  nop
  IL_0090:  br.s       IL_0092
  IL_0092:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,82064,88635);

string
f_23110_82147_82680(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 82147, 82680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_82714_82770(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 82714, 82770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_82804_82835(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 82804, 82835);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_82861_82891(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 82861, 82891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_82908_83598(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb,Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
options)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 82908, 83598);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_83615_85794(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 83615, 85794);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_85827_85838(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 85827, 85838);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_85827_85859(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 85827, 85859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_85888_85931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 85888, 85931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_85960_86003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 85960, 86003);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_86071_86125(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86071, 86125);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_86036_86162(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86036, 86162);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_86352_86391(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86352, 86391);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_86267_86423(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86267, 86423);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_86191_86424(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86191, 86424);
return return_v;
}


int
f_23110_86441_88623(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 86441, 88623);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,82064,88635);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,82064,88635);
}
		}

[Fact]
        public void If()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,88647,92193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,88704,88921);

var 
source0 = f_23110_88718_88920(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        if (F())
        {
            System.Console.WriteLine(1);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,88935,89153);

var 
source1 = f_23110_88949_89152(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        if (F())
        {
            System.Console.WriteLine(10);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,89167,89244);

var 
compilation0 = f_23110_89186_89243(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,89258,89310);

var 
compilation1 = f_23110_89277_89309(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,89326,89366);

var 
v0 = f_23110_89335_89365(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,89382,89772);

f_23110_89382_89771(
            v0, "C.M", @"
{
  // Code size       20 (0x14)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  call       ""bool C.F()""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0013
  IL_000a:  nop
  IL_000b:  ldc.i4.1
  IL_000c:  call       ""void System.Console.WriteLine(int)""
  IL_0011:  nop
  IL_0012:  nop
  IL_0013:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,89904,91126);

f_23110_89904_91125(            // Validate presence of a hidden sequence point @IL_0007 that is required for proper function remapping.
            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""17"" document=""1"" />
        <entry offset=""0x7"" hidden=""true"" document=""1"" />
        <entry offset=""0xa"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0xb"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""41"" document=""1"" />
        <entry offset=""0x12"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x13"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91142,91193);

var 
methodData0 = f_23110_91160_91192(f_23110_91160_91171(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91207,91265);

var 
method0 = f_23110_91221_91264(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91279,91337);

var 
method1 = f_23110_91293_91336(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91351,91496);

var 
generation0 = f_23110_91369_91495(f_23110_91404_91458(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91512,91770);

var 
diff1 = f_23110_91524_91769(compilation1, generation0, f_23110_91600_91768(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_91685_91736(method0, SyntaxKind.IfStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,91786,92182);

f_23110_91786_92181(
            diff1, "C.M", @"
{
  // Code size       21 (0x15)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  call       ""bool C.F()""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0014
  IL_000a:  nop
  IL_000b:  ldc.i4.s   10
  IL_000d:  call       ""void System.Console.WriteLine(int)""
  IL_0012:  nop
  IL_0013:  nop
  IL_0014:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,88647,92193);

string
f_23110_88718_88920(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 88718, 88920);
return return_v;
}


string
f_23110_88949_89152(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 88949, 89152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_89186_89243(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 89186, 89243);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_89277_89309(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 89277, 89309);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_89335_89365(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 89335, 89365);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_89382_89771(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 89382, 89771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_89904_91125(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 89904, 91125);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_91160_91171(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 91160, 91171);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_91160_91192(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91160, 91192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_91221_91264(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91221, 91264);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_91293_91336(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91293, 91336);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_91404_91458(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91404, 91458);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_91369_91495(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91369, 91495);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_91685_91736(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91685, 91736);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_91600_91768(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91600, 91768);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_91524_91769(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91524, 91769);
return return_v;
}


int
f_23110_91786_92181(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 91786, 92181);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,88647,92193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,88647,92193);
}
		}

[Fact]
        public void While()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,92205,95892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92265,92485);

var 
source0 = f_23110_92279_92484(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        while (F())
        {
            System.Console.WriteLine(1);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92499,92720);

var 
source1 = f_23110_92513_92719(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        while (F())
        {
            System.Console.WriteLine(10);
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92734,92811);

var 
compilation0 = f_23110_92753_92810(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92825,92877);

var 
compilation1 = f_23110_92844_92876(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92893,92933);

var 
v0 = f_23110_92902_92932(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,92949,93371);

f_23110_92949_93370(
            v0, "C.M", @"
{
  // Code size       22 (0x16)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  br.s       IL_000c
  IL_0003:  nop
  IL_0004:  ldc.i4.1
  IL_0005:  call       ""void System.Console.WriteLine(int)""
  IL_000a:  nop
  IL_000b:  nop
  IL_000c:  call       ""bool C.F()""
  IL_0011:  stloc.0
  IL_0012:  ldloc.0
  IL_0013:  brtrue.s   IL_0003
  IL_0015:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,93503,94790);

f_23110_93503_94789(            // Validate presence of a hidden sequence point @IL_0012 that is required for proper function remapping.
            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" hidden=""true"" document=""1"" />
        <entry offset=""0x3"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""41"" document=""1"" />
        <entry offset=""0xb"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0xc"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""20"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
        <entry offset=""0x15"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,94806,94857);

var 
methodData0 = f_23110_94824_94856(f_23110_94824_94835(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,94871,94929);

var 
method0 = f_23110_94885_94928(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,94943,95001);

var 
method1 = f_23110_94957_95000(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,95015,95160);

var 
generation0 = f_23110_95033_95159(f_23110_95068_95122(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,95176,95437);

var 
diff1 = f_23110_95188_95436(compilation1, generation0, f_23110_95264_95435(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_95349_95403(method0, SyntaxKind.WhileStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,95453,95881);

f_23110_95453_95880(
            diff1, "C.M", @"
{
  // Code size       23 (0x17)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  br.s       IL_000d
  IL_0003:  nop
  IL_0004:  ldc.i4.s   10
  IL_0006:  call       ""void System.Console.WriteLine(int)""
  IL_000b:  nop
  IL_000c:  nop
  IL_000d:  call       ""bool C.F()""
  IL_0012:  stloc.0
  IL_0013:  ldloc.0
  IL_0014:  brtrue.s   IL_0003
  IL_0016:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,92205,95892);

string
f_23110_92279_92484(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92279, 92484);
return return_v;
}


string
f_23110_92513_92719(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92513, 92719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_92753_92810(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92753, 92810);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_92844_92876(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92844, 92876);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_92902_92932(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92902, 92932);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_92949_93370(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 92949, 93370);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_93503_94789(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 93503, 94789);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_94824_94835(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 94824, 94835);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_94824_94856(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 94824, 94856);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_94885_94928(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 94885, 94928);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_94957_95000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 94957, 95000);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_95068_95122(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95068, 95122);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_95033_95159(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95033, 95159);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_95349_95403(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95349, 95403);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_95264_95435(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95264, 95435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_95188_95436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95188, 95436);
return return_v;
}


int
f_23110_95453_95880(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95453, 95880);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,92205,95892);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,92205,95892);
}
		}

[Fact]
        public void Do1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,95904,99485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,95962,96195);

var 
source0 = f_23110_95976_96194(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        do
        {
            System.Console.WriteLine(1);
        }
        while (F());
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,96209,96443);

var 
source1 = f_23110_96223_96442(@"
class C
{
    static bool F() { return true; }
    
    static void M()
    {
        do
        {
            System.Console.WriteLine(10);
        }
        while (F());
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,96459,96536);

var 
compilation0 = f_23110_96478_96535(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,96550,96602);

var 
compilation1 = f_23110_96569_96601(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,96618,96658);

var 
v0 = f_23110_96627_96657(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,96674,97062);

f_23110_96674_97061(
            v0, "C.M", @"
{
  // Code size       20 (0x14)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  ldc.i4.1
  IL_0003:  call       ""void System.Console.WriteLine(int)""
  IL_0008:  nop
  IL_0009:  nop
  IL_000a:  call       ""bool C.F()""
  IL_000f:  stloc.0
  IL_0010:  ldloc.0
  IL_0011:  brtrue.s   IL_0001
  IL_0013:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,97194,98418);

f_23110_97194_98417(            // Validate presence of a hidden sequence point @IL_0010 that is required for proper function remapping.
            v0, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""41"" document=""1"" />
        <entry offset=""0x9"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0xa"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""21"" document=""1"" />
        <entry offset=""0x10"" hidden=""true"" document=""1"" />
        <entry offset=""0x13"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,98434,98485);

var 
methodData0 = f_23110_98452_98484(f_23110_98452_98463(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,98499,98557);

var 
method0 = f_23110_98513_98556(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,98571,98629);

var 
method1 = f_23110_98585_98628(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,98643,98788);

var 
generation0 = f_23110_98661_98787(f_23110_98696_98750(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,98804,99062);

var 
diff1 = f_23110_98816_99061(compilation1, generation0, f_23110_98892_99060(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_98977_99028(method0, SyntaxKind.DoStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,99078,99474);

f_23110_99078_99473(
            diff1, "C.M", @"
{
  // Code size       21 (0x15)
  .maxstack  1
  .locals init (bool V_0)
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  ldc.i4.s   10
  IL_0004:  call       ""void System.Console.WriteLine(int)""
  IL_0009:  nop
  IL_000a:  nop
  IL_000b:  call       ""bool C.F()""
  IL_0010:  stloc.0
  IL_0011:  ldloc.0
  IL_0012:  brtrue.s   IL_0001
  IL_0014:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,95904,99485);

string
f_23110_95976_96194(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 95976, 96194);
return return_v;
}


string
f_23110_96223_96442(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 96223, 96442);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_96478_96535(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 96478, 96535);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_96569_96601(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 96569, 96601);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_96627_96657(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 96627, 96657);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_96674_97061(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 96674, 97061);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_97194_98417(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 97194, 98417);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_98452_98463(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 98452, 98463);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_98452_98484(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98452, 98484);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_98513_98556(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98513, 98556);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_98585_98628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98585, 98628);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_98696_98750(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98696, 98750);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_98661_98787(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98661, 98787);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_98977_99028(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98977, 99028);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_98892_99060(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98892, 99060);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_98816_99061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 98816, 99061);
return return_v;
}


int
f_23110_99078_99473(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 99078, 99473);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,95904,99485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,95904,99485);
}
		}

[Fact]
        public void For()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,99497,102343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,99555,99803);

var 
source0 = @"
class C
{
    static bool F(int i) { return true; }
    static void G(int i) { }
    
    static void M()
    {
        for (int i = 1; F(i); G(i))
        {
            System.Console.WriteLine(1);
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,99817,100066);

var 
source1 = @"
class C
{
    static bool F(int i) { return true; }
    static void G(int i) { }
    
    static void M()
    {
        for (int i = 1; F(i); G(i))
        {
            System.Console.WriteLine(10);
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,100080,100157);

var 
compilation0 = f_23110_100099_100156(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,100171,100223);

var 
compilation1 = f_23110_100190_100222(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,100239,100279);

var 
v0 = f_23110_100248_100278(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,100413,101033);

f_23110_100413_101032(
            // Validate presence of a hidden sequence point @IL_001c that is required for proper function remapping.
            v0, "C.M", @"
{
  // Code size       32 (0x20)
  .maxstack  1
  .locals init (int V_0, //i
                bool V_1)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
 ~IL_0003:  br.s       IL_0015
 -IL_0005:  nop
 -IL_0006:  ldc.i4.1
  IL_0007:  call       ""void System.Console.WriteLine(int)""
  IL_000c:  nop
 -IL_000d:  nop
 -IL_000e:  ldloc.0
  IL_000f:  call       ""void C.G(int)""
  IL_0014:  nop
 -IL_0015:  ldloc.0
  IL_0016:  call       ""bool C.F(int)""
  IL_001b:  stloc.1
 ~IL_001c:  ldloc.1
  IL_001d:  brtrue.s   IL_0005
 -IL_001f:  ret
}", sequencePoints: "C.M");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101049,101100);

var 
methodData0 = f_23110_101067_101099(f_23110_101067_101078(v0), "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101114,101172);

var 
method0 = f_23110_101128_101171(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101186,101244);

var 
method1 = f_23110_101200_101243(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101258,101403);

var 
generation0 = f_23110_101276_101402(f_23110_101311_101365(v0.EmittedAssemblyData), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101419,101709);

var 
diff1 = f_23110_101431_101708(compilation1, generation0, f_23110_101507_101707(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_101592_101675(method0, SyntaxKind.ForStatement, SyntaxKind.VariableDeclarator),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,101725,102332);

f_23110_101725_102331(
            diff1, "C.M", @"
{
  // Code size       33 (0x21)
  .maxstack  1
  .locals init (int V_0, //i
                bool V_1)
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  IL_0003:  br.s       IL_0016
  IL_0005:  nop
  IL_0006:  ldc.i4.s   10
  IL_0008:  call       ""void System.Console.WriteLine(int)""
  IL_000d:  nop
  IL_000e:  nop
  IL_000f:  ldloc.0
  IL_0010:  call       ""void C.G(int)""
  IL_0015:  nop
  IL_0016:  ldloc.0
  IL_0017:  call       ""bool C.F(int)""
  IL_001c:  stloc.1
  IL_001d:  ldloc.1
  IL_001e:  brtrue.s   IL_0005
  IL_0020:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,99497,102343);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_100099_100156(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 100099, 100156);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_100190_100222(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 100190, 100222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_100248_100278(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 100248, 100278);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_100413_101032(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 100413, 101032);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_101067_101078(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.TestData;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 101067, 101078);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_101067_101099(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101067, 101099);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_101128_101171(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101128, 101171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_101200_101243(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101200, 101243);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_101311_101365(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101311, 101365);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_101276_101402(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101276, 101402);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_101592_101675(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101592, 101675);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_101507_101707(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101507, 101707);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_101431_101708(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101431, 101708);
return return_v;
}


int
f_23110_101725_102331(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 101725, 102331);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,99497,102343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,99497,102343);
}
		}

[Fact]
        public void SynthesizedVariablesInLambdas1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,102355,104559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,102440,102751);

var 
source =
@"class C
{
    static object F()
    {
        return null;
    }
    static void M()
    {
        lock (F())
        {
            var f = new System.Action(() => 
            {
                lock (F())
                {
                }
            });
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,102765,102841);

var 
compilation0 = f_23110_102784_102840(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,102855,102906);

var 
compilation1 = f_23110_102874_102905(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,102922,102962);

var 
v0 = f_23110_102931_102961(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,102976,103728);

f_23110_102976_103727(            v0, "C.<>c.<M>b__1_0()", @"
{
  // Code size       34 (0x22)
  .maxstack  2
  .locals init (object V_0,
                bool V_1)
  IL_0000:  nop
  IL_0001:  call       ""object C.F()""
  IL_0006:  stloc.0
  IL_0007:  ldc.i4.0
  IL_0008:  stloc.1
  .try
  {
    IL_0009:  ldloc.0
    IL_000a:  ldloca.s   V_1
    IL_000c:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0011:  nop
    IL_0012:  nop
    IL_0013:  nop
    IL_0014:  leave.s    IL_0021
  }
  finally
  {
    IL_0016:  ldloc.1
    IL_0017:  brfalse.s  IL_0020
    IL_0019:  ldloc.0
    IL_001a:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_001f:  nop
    IL_0020:  endfinally
  }
  IL_0021:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,102355,104559);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_102784_102840(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 102784, 102840);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_102874_102905(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 102874, 102905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_102931_102961(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 102931, 102961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_102976_103727(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 102976, 103727);
return return_v;
}


        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,102355,104559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,102355,104559);
}
		}

[Fact]
        public void SynthesizedVariablesInLambdas2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,104571,108951);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,104656,105278);

var 
source0 = f_23110_104670_105277(@"
using System;

class C
{
    static void M()
    {
        var <N:0>f1</N:0> = new Action<int[], int>(<N:1>(a, _) =>
        {
            <N:2>foreach</N:2> (var x in a)
            {
                Console.WriteLine(1); // change to 10 and then to 100
            }
        }</N:1>);

        var <N:3>f2</N:3> = new Action<int[], int>(<N:4>(a, _) =>
        {
            <N:5>foreach</N:5> (var x in a)
            {
                Console.WriteLine(20);
            }
        }</N:4>);

        f1(new[] { 1, 2 }, 1);
        f2(new[] { 1, 2 }, 1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,105292,105915);

var 
source1 = f_23110_105306_105914(@"
using System;

class C
{
    static void M()
    {
        var <N:0>f1</N:0> = new Action<int[], int>(<N:1>(a, _) =>
        {
            <N:2>foreach</N:2> (var x in a)
            {
                Console.WriteLine(10); // change to 10 and then to 100
            }
        }</N:1>);

        var <N:3>f2</N:3> = new Action<int[], int>(<N:4>(a, _) =>
        {
            <N:5>foreach</N:5> (var x in a)
            {
                Console.WriteLine(20);
            }
        }</N:4>);

        f1(new[] { 1, 2 }, 1);
        f2(new[] { 1, 2 }, 1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,105929,106553);

var 
source2 = f_23110_105943_106552(@"
using System;

class C
{
    static void M()
    {
        var <N:0>f1</N:0> = new Action<int[], int>(<N:1>(a, _) =>
        {
            <N:2>foreach</N:2> (var x in a)
            {
                Console.WriteLine(100); // change to 10 and then to 100
            }
        }</N:1>);

        var <N:3>f2</N:3> = new Action<int[], int>(<N:4>(a, _) =>
        {
            <N:5>foreach</N:5> (var x in a)
            {
                Console.WriteLine(20);
            }
        }</N:4>);

        f1(new[] { 1, 2 }, 1);
        f2(new[] { 1, 2 }, 1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106567,106644);

var 
compilation0 = f_23110_106586_106643(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106658,106715);

var 
compilation1 = f_23110_106677_106714(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106729,106786);

var 
compilation2 = f_23110_106748_106785(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106802,106855);

var 
m0 = f_23110_106811_106854(compilation0, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106869,106922);

var 
m1 = f_23110_106878_106921(compilation1, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,106936,106989);

var 
m2 = f_23110_106945_106988(compilation2, "C.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107005,107045);

var 
v0 = f_23110_107014_107044(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107059,107124);

var 
md0 = f_23110_107069_107123(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107138,107240);

var 
generation0 = f_23110_107156_107239(md0, f_23110_107196_107216(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107256,107494);

var 
diff1 = f_23110_107268_107493(compilation1, generation0, f_23110_107344_107492(SemanticEdit.Create(SemanticEditKind.Update,m0,m1,f_23110_107419_107460(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107510,107757);

var 
diff2 = f_23110_107522_107756(compilation2, f_23110_107568_107588(diff1), f_23110_107607_107755(SemanticEdit.Create(SemanticEditKind.Update,m1,m2,f_23110_107682_107723(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107773,107904);

f_23110_107773_107903(
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1, <M>b__0_0, <M>b__0_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,107920,108051);

f_23110_107920_108050(
            diff2, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1, <M>b__0_0, <M>b__0_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,108067,108816);

var 
expectedIL = @"
{
  // Code size       33 (0x21)
  .maxstack  2
  .locals init (int[] V_0,
                int V_1,
                int V_2) //x
  IL_0000:  nop
  IL_0001:  nop
  IL_0002:  ldarg.1
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.0
  IL_0005:  stloc.1
  IL_0006:  br.s       IL_001a
  IL_0008:  ldloc.0
  IL_0009:  ldloc.1
  IL_000a:  ldelem.i4
  IL_000b:  stloc.2
  IL_000c:  nop
  IL_000d:  ldc.i4.s   20
  IL_000f:  call       ""void System.Console.WriteLine(int)""
  IL_0014:  nop
  IL_0015:  nop
  IL_0016:  ldloc.1
  IL_0017:  ldc.i4.1
  IL_0018:  add
  IL_0019:  stloc.1
  IL_001a:  ldloc.1
  IL_001b:  ldloc.0
  IL_001c:  ldlen
  IL_001d:  conv.i4
  IL_001e:  blt.s      IL_0008
  IL_0020:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,108832,108879);

f_23110_108832_108878(
            diff1, @"C.<>c.<M>b__0_1", expectedIL);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,108893,108940);

f_23110_108893_108939(            diff2, @"C.<>c.<M>b__0_1", expectedIL);
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,104571,108951);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_104670_105277(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 104670, 105277);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_105306_105914(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 105306, 105914);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_105943_106552(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 105943, 106552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_106586_106643(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106586, 106643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_106677_106714(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106677, 106714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_106748_106785(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106748, 106785);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_106811_106854(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106811, 106854);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_106878_106921(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106878, 106921);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_106945_106988(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 106945, 106988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_107014_107044(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107014, 107044);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_107069_107123(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107069, 107123);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23110_107196_107216(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107196, 107216);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_107156_107239(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107156, 107239);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_107419_107460(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107419, 107460);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_107344_107492(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107344, 107492);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_107268_107493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107268, 107493);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_107568_107588(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 107568, 107588);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_107682_107723(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107682, 107723);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_107607_107755(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107607, 107755);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_107522_107756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107522, 107756);
return return_v;
}


int
f_23110_107773_107903(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107773, 107903);
return 0;
}


int
f_23110_107920_108050(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 107920, 108050);
return 0;
}


int
f_23110_108832_108878(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 108832, 108878);
return 0;
}


int
f_23110_108893_108939(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 108893, 108939);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,104571,108951);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,104571,108951);
}
		}

[Fact]
        public void SynthesizedVariablesInIterator1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,108963,112451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,109049,109216);

var 
source = @"
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        lock (F()) { }
        yield return 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,109230,109306);

var 
compilation0 = f_23110_109249_109305(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,109320,109371);

var 
compilation1 = f_23110_109339_109370(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,109387,109427);

var 
v0 = f_23110_109396_109426(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,109443,111692);

f_23110_109443_111691(
            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size      131 (0x83)
  .maxstack  2
  .locals init (int V_0)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__0.<>1__state""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0012
  IL_000a:  br.s       IL_000c
  IL_000c:  ldloc.0
  IL_000d:  ldc.i4.1
  IL_000e:  beq.s      IL_0014
  IL_0010:  br.s       IL_0016
  IL_0012:  br.s       IL_0018
  IL_0014:  br.s       IL_007a
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldarg.0
  IL_0022:  ldfld      ""C C.<F>d__0.<>4__this""
  IL_0027:  call       ""System.Collections.Generic.IEnumerable<int> C.F()""
  IL_002c:  stfld      ""System.Collections.Generic.IEnumerable<int> C.<F>d__0.<>s__1""
  IL_0031:  ldarg.0
  IL_0032:  ldc.i4.0
  IL_0033:  stfld      ""bool C.<F>d__0.<>s__2""
  .try
  {
    IL_0038:  ldarg.0
    IL_0039:  ldfld      ""System.Collections.Generic.IEnumerable<int> C.<F>d__0.<>s__1""
    IL_003e:  ldarg.0
    IL_003f:  ldflda     ""bool C.<F>d__0.<>s__2""
    IL_0044:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0049:  nop
    IL_004a:  nop
    IL_004b:  nop
    IL_004c:  leave.s    IL_0063
  }
  finally
  {
    IL_004e:  ldarg.0
    IL_004f:  ldfld      ""bool C.<F>d__0.<>s__2""
    IL_0054:  brfalse.s  IL_0062
    IL_0056:  ldarg.0
    IL_0057:  ldfld      ""System.Collections.Generic.IEnumerable<int> C.<F>d__0.<>s__1""
    IL_005c:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0061:  nop
    IL_0062:  endfinally
  }
  IL_0063:  ldarg.0
  IL_0064:  ldnull
  IL_0065:  stfld      ""System.Collections.Generic.IEnumerable<int> C.<F>d__0.<>s__1""
  IL_006a:  ldarg.0
  IL_006b:  ldc.i4.1
  IL_006c:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0071:  ldarg.0
  IL_0072:  ldc.i4.1
  IL_0073:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0078:  ldc.i4.1
  IL_0079:  ret
  IL_007a:  ldarg.0
  IL_007b:  ldc.i4.m1
  IL_007c:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0081:  ldc.i4.0
  IL_0082:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,108963,112451);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_109249_109305(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 109249, 109305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_109339_109370(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 109339, 109370);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_109396_109426(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 109396, 109426);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_109443_111691(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 109443, 111691);
return return_v;
}


        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,108963,112451);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,108963,112451);
}
		}

[Fact]
        public void SynthesizedVariablesInAsyncMethod1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,112463,118595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,112552,112728);

var 
source = @"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        lock (F()) { }
        await F();
        return 1;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,112742,112832);

var 
compilation0 = f_23110_112761_112831(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,112846,112897);

var 
compilation1 = f_23110_112865_112896(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,112913,112953);

var 
v0 = f_23110_112922_112952(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,112969,117837);

f_23110_112969_117836(
            v0, "C.<F>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      246 (0xf6)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter<int> V_2,
                C.<F>d__0 V_3,
                System.Exception V_4)
 ~IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
   ~IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_000c
    IL_000a:  br.s       IL_0011
    IL_000c:  br         IL_009e
   -IL_0011:  nop
   -IL_0012:  ldarg.0
    IL_0013:  ldarg.0
    IL_0014:  ldfld      ""C C.<F>d__0.<>4__this""
    IL_0019:  call       ""System.Threading.Tasks.Task<int> C.F()""
    IL_001e:  stfld      ""System.Threading.Tasks.Task<int> C.<F>d__0.<>s__1""
    IL_0023:  ldarg.0
    IL_0024:  ldc.i4.0
    IL_0025:  stfld      ""bool C.<F>d__0.<>s__2""
    .try
    {
      IL_002a:  ldarg.0
      IL_002b:  ldfld      ""System.Threading.Tasks.Task<int> C.<F>d__0.<>s__1""
      IL_0030:  ldarg.0
      IL_0031:  ldflda     ""bool C.<F>d__0.<>s__2""
      IL_0036:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
      IL_003b:  nop
     -IL_003c:  nop
     -IL_003d:  nop
      IL_003e:  leave.s    IL_0059
    }
    finally
    {
     ~IL_0040:  ldloc.0
      IL_0041:  ldc.i4.0
      IL_0042:  bge.s      IL_0058
      IL_0044:  ldarg.0
      IL_0045:  ldfld      ""bool C.<F>d__0.<>s__2""
      IL_004a:  brfalse.s  IL_0058
      IL_004c:  ldarg.0
      IL_004d:  ldfld      ""System.Threading.Tasks.Task<int> C.<F>d__0.<>s__1""
      IL_0052:  call       ""void System.Threading.Monitor.Exit(object)""
      IL_0057:  nop
     ~IL_0058:  endfinally
    }
   ~IL_0059:  ldarg.0
    IL_005a:  ldnull
    IL_005b:  stfld      ""System.Threading.Tasks.Task<int> C.<F>d__0.<>s__1""
   -IL_0060:  ldarg.0
    IL_0061:  ldfld      ""C C.<F>d__0.<>4__this""
    IL_0066:  call       ""System.Threading.Tasks.Task<int> C.F()""
    IL_006b:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<int> System.Threading.Tasks.Task<int>.GetAwaiter()""
    IL_0070:  stloc.2
   ~IL_0071:  ldloca.s   V_2
    IL_0073:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<int>.IsCompleted.get""
    IL_0078:  brtrue.s   IL_00ba
    IL_007a:  ldarg.0
    IL_007b:  ldc.i4.0
    IL_007c:  dup
    IL_007d:  stloc.0
    IL_007e:  stfld      ""int C.<F>d__0.<>1__state""
   <IL_0083:  ldarg.0
    IL_0084:  ldloc.2
    IL_0085:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_008a:  ldarg.0
    IL_008b:  stloc.3
    IL_008c:  ldarg.0
    IL_008d:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_0092:  ldloca.s   V_2
    IL_0094:  ldloca.s   V_3
    IL_0096:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<int>, C.<F>d__0>(ref System.Runtime.CompilerServices.TaskAwaiter<int>, ref C.<F>d__0)""
    IL_009b:  nop
    IL_009c:  leave.s    IL_00f5
   >IL_009e:  ldarg.0
    IL_009f:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_00a4:  stloc.2
    IL_00a5:  ldarg.0
    IL_00a6:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_00ab:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<int>""
    IL_00b1:  ldarg.0
    IL_00b2:  ldc.i4.m1
    IL_00b3:  dup
    IL_00b4:  stloc.0
    IL_00b5:  stfld      ""int C.<F>d__0.<>1__state""
    IL_00ba:  ldloca.s   V_2
    IL_00bc:  call       ""int System.Runtime.CompilerServices.TaskAwaiter<int>.GetResult()""
    IL_00c1:  pop
   -IL_00c2:  ldc.i4.1
    IL_00c3:  stloc.1
    IL_00c4:  leave.s    IL_00e0
  }
  catch System.Exception
  {
   ~IL_00c6:  stloc.s    V_4
    IL_00c8:  ldarg.0
    IL_00c9:  ldc.i4.s   -2
    IL_00cb:  stfld      ""int C.<F>d__0.<>1__state""
    IL_00d0:  ldarg.0
    IL_00d1:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_00d6:  ldloc.s    V_4
    IL_00d8:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_00dd:  nop
    IL_00de:  leave.s    IL_00f5
  }
 -IL_00e0:  ldarg.0
  IL_00e1:  ldc.i4.s   -2
  IL_00e3:  stfld      ""int C.<F>d__0.<>1__state""
 ~IL_00e8:  ldarg.0
  IL_00e9:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
  IL_00ee:  ldloc.1
  IL_00ef:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_00f4:  nop
  IL_00f5:  ret
}", sequencePoints: "C+<F>d__0.MoveNext");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,112463,118595);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_112761_112831(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 112761, 112831);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_112865_112896(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 112865, 112896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_112922_112952(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 112922, 112952);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_112969_117836(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 112969, 117836);
return return_v;
}


        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,112463,118595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,112463,118595);
}
		}

[Fact]
        public void OutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,118607,120285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,118668,118822);

var 
source = @"
class C
{
    static void F(out int x, out int y) { x = 1; y = 2; }
    static int G() { F(out int x, out var y); return x + y; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,118838,118914);

var 
compilation0 = f_23110_118857_118913(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,118928,118979);

var 
compilation1 = f_23110_118947_118978(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,118995,119037);

var 
testData0 = f_23110_119011_119036()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119051,119110);

var 
bytes0 = f_23110_119064_119109(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119124,119173);

var 
methodData0 = f_23110_119142_119172(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119187,119245);

var 
method0 = f_23110_119201_119244(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119259,119388);

var 
generation0 = f_23110_119277_119387(f_23110_119312_119350(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119404,119462);

var 
method1 = f_23110_119418_119461(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119476,119722);

var 
diff1 = f_23110_119488_119721(compilation1, generation0, f_23110_119564_119720(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_119649_119688(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,119738,120274);

f_23110_119738_120273(
            diff1, "C.G", @"
{
  // Code size       19 (0x13)
  .maxstack  2
  .locals init (int V_0, //x
                int V_1, //y
                [int] V_2,
                int V_3)
 -IL_0000:  nop
 -IL_0001:  ldloca.s   V_0
  IL_0003:  ldloca.s   V_1
  IL_0005:  call       ""void C.F(out int, out int)""
  IL_000a:  nop
 -IL_000b:  ldloc.0
  IL_000c:  ldloc.1
  IL_000d:  add
  IL_000e:  stloc.3
  IL_000f:  br.s       IL_0011
 -IL_0011:  ldloc.3
  IL_0012:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,118607,120285);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_118857_118913(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 118857, 118913);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_118947_118978(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 118947, 118978);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_119011_119036()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119011, 119036);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_119064_119109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119064, 119109);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_119142_119172(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119142, 119172);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_119201_119244(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119201, 119244);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_119312_119350(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119312, 119350);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_119277_119387(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119277, 119387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_119418_119461(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119418, 119461);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_119649_119688(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119649, 119688);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_119564_119720(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119564, 119720);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_119488_119721(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119488, 119721);
return return_v;
}


int
f_23110_119738_120273(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 119738, 120273);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,118607,120285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,118607,120285);
}
		}

[Fact]
        public void PatternVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,120297,122164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120367,120471);

var 
source = @"
class C
{
    static int F(object o) { if (o is int i) { return i; } return 0; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120487,120563);

var 
compilation0 = f_23110_120506_120562(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120577,120628);

var 
compilation1 = f_23110_120596_120627(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120644,120686);

var 
testData0 = f_23110_120660_120685()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120700,120759);

var 
bytes0 = f_23110_120713_120758(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120773,120822);

var 
methodData0 = f_23110_120791_120821(testData0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120836,120894);

var 
method0 = f_23110_120850_120893(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,120908,121037);

var 
generation0 = f_23110_120926_121036(f_23110_120961_120999(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,121053,121111);

var 
method1 = f_23110_121067_121110(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,121125,121371);

var 
diff1 = f_23110_121137_121370(compilation1, generation0, f_23110_121213_121369(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_121298_121337(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,121387,122153);

f_23110_121387_122152(
            diff1, "C.F", @"
{
  // Code size       35 (0x23)
  .maxstack  1
  .locals init (int V_0, //i
                bool V_1,
                [int] V_2,
                int V_3)
 -IL_0000:  nop
 -IL_0001:  ldarg.0
  IL_0002:  isinst     ""int""
  IL_0007:  brfalse.s  IL_0013
  IL_0009:  ldarg.0
  IL_000a:  unbox.any  ""int""
  IL_000f:  stloc.0
  IL_0010:  ldc.i4.1
  IL_0011:  br.s       IL_0014
  IL_0013:  ldc.i4.0
  IL_0014:  stloc.1
 ~IL_0015:  ldloc.1
  IL_0016:  brfalse.s  IL_001d
 -IL_0018:  nop
 -IL_0019:  ldloc.0
  IL_001a:  stloc.3
  IL_001b:  br.s       IL_0021
 -IL_001d:  ldc.i4.0
  IL_001e:  stloc.3
  IL_001f:  br.s       IL_0021
 -IL_0021:  ldloc.3
  IL_0022:  ret
}", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,120297,122164);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_120506_120562(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120506, 120562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_120596_120627(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120596, 120627);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_120660_120685()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120660, 120685);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_120713_120758(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120713, 120758);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_120791_120821(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120791, 120821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_120850_120893(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120850, 120893);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_120961_120999(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120961, 120999);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_120926_121036(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 120926, 121036);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_121067_121110(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 121067, 121110);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_121298_121337(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 121298, 121337);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_121213_121369(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 121213, 121369);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_121137_121370(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 121137, 121370);
return return_v;
}


int
f_23110_121387_122152(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 121387, 122152);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,120297,122164);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,120297,122164);
}
		}

[Fact]
        public void Tuple_Parenthesized()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,122176,124516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122250,122389);

var 
source = @"
class C
{
    static int F() { (int, (int, int)) x = (1, (2, 3)); return x.Item1 + x.Item2.Item1 + x.Item2.Item2; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122405,122481);

var 
compilation0 = f_23110_122424_122480(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122495,122546);

var 
compilation1 = f_23110_122514_122545(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122562,122604);

var 
testData0 = f_23110_122578_122603()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122618,122677);

var 
bytes0 = f_23110_122631_122676(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122691,122740);

var 
methodData0 = f_23110_122709_122739(testData0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122754,122812);

var 
method0 = f_23110_122768_122811(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122826,122955);

var 
generation0 = f_23110_122844_122954(f_23110_122879_122917(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,122971,123029);

var 
method1 = f_23110_122985_123028(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,123043,123289);

var 
diff1 = f_23110_123055_123288(compilation1, generation0, f_23110_123131_123287(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_123216_123255(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,123305,124505);

f_23110_123305_124504(
            diff1, "C.F", @"
{
  // Code size       51 (0x33)
  .maxstack  4
  .locals init (System.ValueTuple<int, System.ValueTuple<int, int>> V_0, //x
                [int] V_1,
                int V_2)
 -IL_0000:  nop
 -IL_0001:  ldloca.s   V_0
  IL_0003:  ldc.i4.1
  IL_0004:  ldc.i4.2
  IL_0005:  ldc.i4.3
  IL_0006:  newobj     ""System.ValueTuple<int, int>..ctor(int, int)""
  IL_000b:  call       ""System.ValueTuple<int, System.ValueTuple<int, int>>..ctor(int, System.ValueTuple<int, int>)""
 -IL_0010:  ldloc.0
  IL_0011:  ldfld      ""int System.ValueTuple<int, System.ValueTuple<int, int>>.Item1""
  IL_0016:  ldloc.0
  IL_0017:  ldfld      ""System.ValueTuple<int, int> System.ValueTuple<int, System.ValueTuple<int, int>>.Item2""
  IL_001c:  ldfld      ""int System.ValueTuple<int, int>.Item1""
  IL_0021:  add
  IL_0022:  ldloc.0
  IL_0023:  ldfld      ""System.ValueTuple<int, int> System.ValueTuple<int, System.ValueTuple<int, int>>.Item2""
  IL_0028:  ldfld      ""int System.ValueTuple<int, int>.Item2""
  IL_002d:  add
  IL_002e:  stloc.2
  IL_002f:  br.s       IL_0031
 -IL_0031:  ldloc.2
  IL_0032:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,122176,124516);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_122424_122480(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122424, 122480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_122514_122545(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122514, 122545);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_122578_122603()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122578, 122603);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_122631_122676(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122631, 122676);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_122709_122739(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122709, 122739);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_122768_122811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122768, 122811);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_122879_122917(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122879, 122917);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_122844_122954(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122844, 122954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_122985_123028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 122985, 123028);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_123216_123255(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 123216, 123255);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_123131_123287(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 123131, 123287);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_123055_123288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 123055, 123288);
return return_v;
}


int
f_23110_123305_124504(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 123305, 124504);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,122176,124516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,122176,124516);
}
		}

[Fact]
        public void Tuple_Decomposition()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,124528,126261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,124602,124715);

var 
source = @"
class C
{
    static int F() { (int x, (int y, int z)) = (1, (2, 3)); return x + y + z; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,124731,124807);

var 
compilation0 = f_23110_124750_124806(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,124821,124872);

var 
compilation1 = f_23110_124840_124871(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,124888,124930);

var 
testData0 = f_23110_124904_124929()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,124944,125003);

var 
bytes0 = f_23110_124957_125002(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125017,125066);

var 
methodData0 = f_23110_125035_125065(testData0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125080,125138);

var 
method0 = f_23110_125094_125137(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125152,125281);

var 
generation0 = f_23110_125170_125280(f_23110_125205_125243(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125297,125355);

var 
method1 = f_23110_125311_125354(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125369,125615);

var 
diff1 = f_23110_125381_125614(compilation1, generation0, f_23110_125457_125613(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_125542_125581(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,125631,126250);

f_23110_125631_126249(
            diff1, "C.F", @"
{
  // Code size       19 (0x13)
  .maxstack  2
  .locals init (int V_0, //x
                int V_1, //y
                int V_2, //z
                [int] V_3,
                int V_4)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  IL_0003:  ldc.i4.2
  IL_0004:  stloc.1
  IL_0005:  ldc.i4.3
  IL_0006:  stloc.2
 -IL_0007:  ldloc.0
  IL_0008:  ldloc.1
  IL_0009:  add
  IL_000a:  ldloc.2
  IL_000b:  add
  IL_000c:  stloc.s    V_4
  IL_000e:  br.s       IL_0010
 -IL_0010:  ldloc.s    V_4
  IL_0012:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,124528,126261);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_124750_124806(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 124750, 124806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_124840_124871(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 124840, 124871);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_124904_124929()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 124904, 124929);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_124957_125002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 124957, 125002);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_125035_125065(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125035, 125065);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_125094_125137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125094, 125137);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_125205_125243(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125205, 125243);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_125170_125280(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125170, 125280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_125311_125354(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125311, 125354);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_125542_125581(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125542, 125581);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_125457_125613(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125457, 125613);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_125381_125614(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125381, 125614);
return return_v;
}


int
f_23110_125631_126249(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 125631, 126249);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,124528,126261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,124528,126261);
}
		}

[Fact]
        public void PatternMatching_Variable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,126273,128149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126352,126456);

var 
source = @"
class C
{
    static int F(object o) { if (o is int i) { return i; } return 0; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126472,126548);

var 
compilation0 = f_23110_126491_126547(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126562,126613);

var 
compilation1 = f_23110_126581_126612(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126629,126671);

var 
testData0 = f_23110_126645_126670()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126685,126744);

var 
bytes0 = f_23110_126698_126743(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126758,126807);

var 
methodData0 = f_23110_126776_126806(testData0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126821,126879);

var 
method0 = f_23110_126835_126878(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,126893,127022);

var 
generation0 = f_23110_126911_127021(f_23110_126946_126984(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,127038,127096);

var 
method1 = f_23110_127052_127095(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,127110,127356);

var 
diff1 = f_23110_127122_127355(compilation1, generation0, f_23110_127198_127354(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_127283_127322(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,127372,128138);

f_23110_127372_128137(
            diff1, "C.F", @"
{
  // Code size       35 (0x23)
  .maxstack  1
  .locals init (int V_0, //i
                bool V_1,
                [int] V_2,
                int V_3)
 -IL_0000:  nop
 -IL_0001:  ldarg.0
  IL_0002:  isinst     ""int""
  IL_0007:  brfalse.s  IL_0013
  IL_0009:  ldarg.0
  IL_000a:  unbox.any  ""int""
  IL_000f:  stloc.0
  IL_0010:  ldc.i4.1
  IL_0011:  br.s       IL_0014
  IL_0013:  ldc.i4.0
  IL_0014:  stloc.1
 ~IL_0015:  ldloc.1
  IL_0016:  brfalse.s  IL_001d
 -IL_0018:  nop
 -IL_0019:  ldloc.0
  IL_001a:  stloc.3
  IL_001b:  br.s       IL_0021
 -IL_001d:  ldc.i4.0
  IL_001e:  stloc.3
  IL_001f:  br.s       IL_0021
 -IL_0021:  ldloc.3
  IL_0022:  ret
}", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,126273,128149);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_126491_126547(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126491, 126547);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_126581_126612(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126581, 126612);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_126645_126670()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126645, 126670);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_126698_126743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126698, 126743);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_126776_126806(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126776, 126806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_126835_126878(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126835, 126878);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_126946_126984(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126946, 126984);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_126911_127021(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 126911, 127021);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_127052_127095(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 127052, 127095);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_127283_127322(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 127283, 127322);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_127198_127354(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 127198, 127354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_127122_127355(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 127122, 127355);
return return_v;
}


int
f_23110_127372_128137(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 127372, 128137);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,126273,128149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,126273,128149);
}
		}

[Fact]
        public void PatternMatching_NoVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,128161,130159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128242,128359);

var 
source = @"
class C
{
    static int F(object o) { if ((o is bool) || (o is 0)) { return 0; } return 1; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128375,128451);

var 
compilation0 = f_23110_128394_128450(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128465,128516);

var 
compilation1 = f_23110_128484_128515(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128532,128574);

var 
testData0 = f_23110_128548_128573()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128588,128647);

var 
bytes0 = f_23110_128601_128646(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128661,128710);

var 
methodData0 = f_23110_128679_128709(testData0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128724,128782);

var 
method0 = f_23110_128738_128781(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128796,128925);

var 
generation0 = f_23110_128814_128924(f_23110_128849_128887(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,128941,128999);

var 
method1 = f_23110_128955_128998(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,129013,129259);

var 
diff1 = f_23110_129025_129258(compilation1, generation0, f_23110_129101_129257(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_129186_129225(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,129275,130148);

f_23110_129275_130147(
            diff1, "C.F", @"
{
  // Code size       47 (0x2f)
  .maxstack  2
  .locals init (bool V_0,
                [int] V_1,
                int V_2)
 -IL_0000:  nop
 -IL_0001:  ldarg.0
  IL_0002:  isinst     ""bool""
  IL_0007:  brtrue.s   IL_001f
  IL_0009:  ldarg.0
  IL_000a:  isinst     ""int""
  IL_000f:  brfalse.s  IL_001c
  IL_0011:  ldarg.0
  IL_0012:  unbox.any  ""int""
  IL_0017:  ldc.i4.0
  IL_0018:  ceq
  IL_001a:  br.s       IL_001d
  IL_001c:  ldc.i4.0
  IL_001d:  br.s       IL_0020
  IL_001f:  ldc.i4.1
  IL_0020:  stloc.0
 ~IL_0021:  ldloc.0
  IL_0022:  brfalse.s  IL_0029
 -IL_0024:  nop
 -IL_0025:  ldc.i4.0
  IL_0026:  stloc.2
  IL_0027:  br.s       IL_002d
 -IL_0029:  ldc.i4.1
  IL_002a:  stloc.2
  IL_002b:  br.s       IL_002d
 -IL_002d:  ldloc.2
  IL_002e:  ret
}", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,128161,130159);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_128394_128450(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128394, 128450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_128484_128515(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128484, 128515);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_128548_128573()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128548, 128573);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_128601_128646(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128601, 128646);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_128679_128709(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128679, 128709);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_128738_128781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128738, 128781);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_128849_128887(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128849, 128887);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_128814_128924(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128814, 128924);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_128955_128998(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 128955, 128998);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_129186_129225(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 129186, 129225);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_129101_129257(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 129101, 129257);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_129025_129258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 129025, 129258);
return return_v;
}


int
f_23110_129275_130147(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 129275, 130147);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,128161,130159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,128161,130159);
}
		}

[Fact]
        public void VarPattern()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,130171,132709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130236,130470);

var 
source = @"
using System.Threading.Tasks;

class C
{
    static object G(object o1, object o2)
    {
        return (o1, o2) switch
        {
            (int a, string b) => a,
            _ => 0
        };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130486,130562);

var 
compilation0 = f_23110_130505_130561(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130576,130627);

var 
compilation1 = f_23110_130595_130626(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130643,130685);

var 
testData0 = f_23110_130659_130684()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130699,130758);

var 
bytes0 = f_23110_130712_130757(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130772,130821);

var 
methodData0 = f_23110_130790_130820(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130835,130893);

var 
method0 = f_23110_130849_130892(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,130907,131036);

var 
generation0 = f_23110_130925_131035(f_23110_130960_130998(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,131052,131110);

var 
method1 = f_23110_131066_131109(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,131124,131370);

var 
diff1 = f_23110_131136_131369(compilation1, generation0, f_23110_131212_131368(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_131297_131336(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,131386,132698);

f_23110_131386_132697(
            diff1, "C.G", @"
    {
      // Code size       62 (0x3e)
      .maxstack  1
      .locals init (int V_0, //a
                    string V_1, //b
                    [int] V_2,
                    [object] V_3,
                    int V_4,
                    object V_5)
     -IL_0000:  nop
     -IL_0001:  ldc.i4.1
      IL_0002:  brtrue.s   IL_0005
     -IL_0004:  nop
     ~IL_0005:  ldarg.0
      IL_0006:  isinst     ""int""
      IL_000b:  brfalse.s  IL_0027
      IL_000d:  ldarg.0
      IL_000e:  unbox.any  ""int""
      IL_0013:  stloc.0
     ~IL_0014:  ldarg.1
      IL_0015:  isinst     ""string""
      IL_001a:  stloc.1
      IL_001b:  ldloc.1
      IL_001c:  brtrue.s   IL_0020
      IL_001e:  br.s       IL_0027
     ~IL_0020:  br.s       IL_0022
     -IL_0022:  ldloc.0
      IL_0023:  stloc.s    V_4
      IL_0025:  br.s       IL_002c
     -IL_0027:  ldc.i4.0
      IL_0028:  stloc.s    V_4
      IL_002a:  br.s       IL_002c
     ~IL_002c:  ldc.i4.1
      IL_002d:  brtrue.s   IL_0030
     -IL_002f:  nop
     ~IL_0030:  ldloc.s    V_4
      IL_0032:  box        ""int""
      IL_0037:  stloc.s    V_5
      IL_0039:  br.s       IL_003b
     -IL_003b:  ldloc.s    V_5
      IL_003d:  ret
    }
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,130171,132709);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_130505_130561(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130505, 130561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_130595_130626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130595, 130626);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_130659_130684()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130659, 130684);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_130712_130757(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130712, 130757);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_130790_130820(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130790, 130820);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_130849_130892(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130849, 130892);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_130960_130998(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130960, 130998);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_130925_131035(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 130925, 131035);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_131066_131109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 131066, 131109);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_131297_131336(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 131297, 131336);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_131212_131368(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 131212, 131368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_131136_131369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 131136, 131369);
return return_v;
}


int
f_23110_131386_132697(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 131386, 132697);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,130171,132709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,130171,132709);
}
		}

[Fact]
        public void RecursiveSwitchExpression()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,132721,135631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,132801,133059);

var 
source = @"
class C
{
    static object G(object o)
    {
        return o switch
        {
            int i => i switch
            {
                0  => 1,
                _ => 2,
            },
            _ => 3
        };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133075,133151);

var 
compilation0 = f_23110_133094_133150(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133165,133216);

var 
compilation1 = f_23110_133184_133215(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133232,133274);

var 
testData0 = f_23110_133248_133273()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133288,133347);

var 
bytes0 = f_23110_133301_133346(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133361,133410);

var 
methodData0 = f_23110_133379_133409(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133424,133482);

var 
method0 = f_23110_133438_133481(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133496,133625);

var 
generation0 = f_23110_133514_133624(f_23110_133549_133587(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133641,133699);

var 
method1 = f_23110_133655_133698(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133713,133959);

var 
diff1 = f_23110_133725_133958(compilation1, generation0, f_23110_133801_133957(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_133886_133925(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,133975,135620);

f_23110_133975_135619(
            diff1, "C.G", @"
    {
      // Code size       76 (0x4c)
      .maxstack  1
      .locals init (int V_0, //i
                    [int] V_1,
                    [int] V_2,
                    [object] V_3,
                    int V_4,
                    int V_5,
                    object V_6)
     -IL_0000:  nop
     -IL_0001:  ldc.i4.1
      IL_0002:  brtrue.s   IL_0005
     -IL_0004:  nop
     ~IL_0005:  ldarg.0
      IL_0006:  isinst     ""int""
      IL_000b:  brfalse.s  IL_0035
      IL_000d:  ldarg.0
      IL_000e:  unbox.any  ""int""
      IL_0013:  stloc.0
     ~IL_0014:  br.s       IL_0016
     ~IL_0016:  br.s       IL_0018
      IL_0018:  ldc.i4.1
      IL_0019:  brtrue.s   IL_001c
     -IL_001b:  nop
     ~IL_001c:  ldloc.0
      IL_001d:  brfalse.s  IL_0021
      IL_001f:  br.s       IL_0026
     -IL_0021:  ldc.i4.1
      IL_0022:  stloc.s    V_5
      IL_0024:  br.s       IL_002b
     -IL_0026:  ldc.i4.2
      IL_0027:  stloc.s    V_5
      IL_0029:  br.s       IL_002b
     ~IL_002b:  ldc.i4.1
      IL_002c:  brtrue.s   IL_002f
     -IL_002e:  nop
     -IL_002f:  ldloc.s    V_5
      IL_0031:  stloc.s    V_4
      IL_0033:  br.s       IL_003a
     -IL_0035:  ldc.i4.3
      IL_0036:  stloc.s    V_4
      IL_0038:  br.s       IL_003a
     ~IL_003a:  ldc.i4.1
      IL_003b:  brtrue.s   IL_003e
     -IL_003d:  nop
     ~IL_003e:  ldloc.s    V_4
      IL_0040:  box        ""int""
      IL_0045:  stloc.s    V_6
      IL_0047:  br.s       IL_0049
     -IL_0049:  ldloc.s    V_6
      IL_004b:  ret
    }
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,132721,135631);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_133094_133150(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133094, 133150);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_133184_133215(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133184, 133215);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_133248_133273()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133248, 133273);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_133301_133346(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133301, 133346);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_133379_133409(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133379, 133409);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_133438_133481(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133438, 133481);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_133549_133587(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133549, 133587);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_133514_133624(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133514, 133624);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_133655_133698(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133655, 133698);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_133886_133925(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133886, 133925);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_133801_133957(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133801, 133957);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_133725_133958(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133725, 133958);
return return_v;
}


int
f_23110_133975_135619(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 133975, 135619);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,132721,135631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,132721,135631);
}
		}

[Fact]
        public void RecursiveSwitchExpressionWithAwait()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,135643,138347);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,135732,136063);

var 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task<object> G(object o)
    {
        return o switch
        {
            Task<int> i when await i > 0 => await i switch
            {
                1 => 1,
                _ => 2,
            },
            _ => 3
        };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136079,136155);

var 
compilation0 = f_23110_136098_136154(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136169,136220);

var 
compilation1 = f_23110_136188_136219(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136236,136289);

var 
g0 = f_23110_136245_136288(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136303,136356);

var 
g1 = f_23110_136312_136355(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136372,136414);

var 
testData0 = f_23110_136388_136413()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136428,136487);

var 
bytes0 = f_23110_136441_136486(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136501,136550);

var 
methodData0 = f_23110_136519_136549(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136564,136693);

var 
generation0 = f_23110_136582_136692(f_23110_136617_136655(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136709,136935);

var 
diff1 = f_23110_136721_136934(compilation1, generation0, f_23110_136797_136933(SemanticEdit.Create(SemanticEditKind.Update,g0,g1,f_23110_136872_136901(g1, g0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,136951,138336);

f_23110_136951_138335(
            diff1, "C.G", @"
    {
      // Code size       56 (0x38)
      .maxstack  2
      .locals init (C.<G>d__0 V_0)
     ~IL_0000:  newobj     ""C.<G>d__0..ctor()""
      IL_0005:  stloc.0
      IL_0006:  ldloc.0
     ~IL_0007:  call       ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create()""
      IL_000c:  stfld      ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0011:  ldloc.0
      IL_0012:  ldarg.0
      IL_0013:  stfld      ""object C.<G>d__0.o""
      IL_0018:  ldloc.0
     -IL_0019:  ldc.i4.m1
     -IL_001a:  stfld      ""int C.<G>d__0.<>1__state""
      IL_001f:  ldloc.0
      IL_0020:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0025:  ldloca.s   V_0
      IL_0027:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<C.<G>d__0>(ref C.<G>d__0)""
      IL_002c:  ldloc.0
      IL_002d:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0032:  call       ""System.Threading.Tasks.Task<object> System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Task.get""
      IL_0037:  ret
    }
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,135643,138347);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_136098_136154(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136098, 136154);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_136188_136219(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136188, 136219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_136245_136288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136245, 136288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_136312_136355(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136312, 136355);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_136388_136413()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136388, 136413);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_136441_136486(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136441, 136486);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_136519_136549(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136519, 136549);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_136617_136655(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136617, 136655);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_136582_136692(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136582, 136692);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_136872_136901(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136872, 136901);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_136797_136933(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136797, 136933);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_136721_136934(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136721, 136934);
return return_v;
}


int
f_23110_136951_138335(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 136951, 138335);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,135643,138347);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,135643,138347);
}
		}

[Fact]
        public void SwitchExpressionInsideAwait()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,138359,141010);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138441,138669);

var 
source = @"
using System.Threading.Tasks;

class C
{
    static async Task<object> G(Task<object> o)
    {
        return await o switch 
        {
            int i => 0,
            _ => 1
        };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138685,138761);

var 
compilation0 = f_23110_138704_138760(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138775,138826);

var 
compilation1 = f_23110_138794_138825(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138842,138884);

var 
testData0 = f_23110_138858_138883()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138898,138957);

var 
bytes0 = f_23110_138911_138956(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,138971,139020);

var 
methodData0 = f_23110_138989_139019(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,139034,139092);

var 
method0 = f_23110_139048_139091(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,139106,139235);

var 
generation0 = f_23110_139124_139234(f_23110_139159_139197(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,139251,139309);

var 
method1 = f_23110_139265_139308(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,139323,139569);

var 
diff1 = f_23110_139335_139568(compilation1, generation0, f_23110_139411_139567(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_139496_139535(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,139585,140999);

f_23110_139585_140998(
            diff1, "C.G", @"
    {
      // Code size       56 (0x38)
      .maxstack  2
      .locals init (C.<G>d__0 V_0)
     ~IL_0000:  newobj     ""C.<G>d__0..ctor()""
      IL_0005:  stloc.0
      IL_0006:  ldloc.0
     ~IL_0007:  call       ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create()""
      IL_000c:  stfld      ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0011:  ldloc.0
      IL_0012:  ldarg.0
      IL_0013:  stfld      ""System.Threading.Tasks.Task<object> C.<G>d__0.o""
      IL_0018:  ldloc.0
      IL_0019:  ldc.i4.m1
      IL_001a:  stfld      ""int C.<G>d__0.<>1__state""
      IL_001f:  ldloc.0
      IL_0020:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0025:  ldloca.s   V_0
      IL_0027:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Start<C.<G>d__0>(ref C.<G>d__0)""
      IL_002c:  ldloc.0
     <IL_002d:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object> C.<G>d__0.<>t__builder""
      IL_0032:  call       ""System.Threading.Tasks.Task<object> System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Task.get""
      IL_0037:  ret
    }
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,138359,141010);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_138704_138760(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 138704, 138760);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_138794_138825(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 138794, 138825);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_138858_138883()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 138858, 138883);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_138911_138956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 138911, 138956);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_138989_139019(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 138989, 139019);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_139048_139091(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139048, 139091);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_139159_139197(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139159, 139197);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_139124_139234(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139124, 139234);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_139265_139308(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139265, 139308);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_139496_139535(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139496, 139535);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_139411_139567(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139411, 139567);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_139335_139568(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139335, 139568);
return return_v;
}


int
f_23110_139585_140998(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 139585, 140998);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,138359,141010);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,138359,141010);
}
		}

[Fact]
        public void SwitchExpressionWithOutVar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,141022,143991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141103,141360);

var 
source = @"
class C
{
    static object G()
    {
        return N(out var x) switch 
        {
            null => x switch {1 =>  1, _ => 2 },
            _ => 1
        };
    }

    static object N(out int x) { x = 1; return null; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141376,141452);

var 
compilation0 = f_23110_141395_141451(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141466,141517);

var 
compilation1 = f_23110_141485_141516(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141533,141575);

var 
testData0 = f_23110_141549_141574()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141589,141648);

var 
bytes0 = f_23110_141602_141647(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141662,141711);

var 
methodData0 = f_23110_141680_141710(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141725,141783);

var 
method0 = f_23110_141739_141782(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141797,141926);

var 
generation0 = f_23110_141815_141925(f_23110_141850_141888(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,141942,142000);

var 
method1 = f_23110_141956_141999(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,142014,142260);

var 
diff1 = f_23110_142026_142259(compilation1, generation0, f_23110_142102_142258(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_142187_142226(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,142276,143980);

f_23110_142276_143979(
            diff1, "C.G", @"
    {
      // Code size       73 (0x49)
      .maxstack  2
      .locals init (int V_0, //x
                    [int] V_1,
                    [object] V_2,
                    [int] V_3,
                    [object] V_4,
                    int V_5,
                    object V_6,
                    int V_7,
                    object V_8)
     -IL_0000:  nop
     -IL_0001:  ldloca.s   V_0
      IL_0003:  call       ""object C.N(out int)""
      IL_0008:  stloc.s    V_6
      IL_000a:  ldc.i4.1
      IL_000b:  brtrue.s   IL_000e
     -IL_000d:  nop
     ~IL_000e:  ldloc.s    V_6
      IL_0010:  brfalse.s  IL_0014
      IL_0012:  br.s       IL_0032
     ~IL_0014:  ldc.i4.1
      IL_0015:  brtrue.s   IL_0018
     -IL_0017:  nop
     ~IL_0018:  ldloc.0
      IL_0019:  ldc.i4.1
      IL_001a:  beq.s      IL_001e
      IL_001c:  br.s       IL_0023
     -IL_001e:  ldc.i4.1
      IL_001f:  stloc.s    V_7
      IL_0021:  br.s       IL_0028
     -IL_0023:  ldc.i4.2
      IL_0024:  stloc.s    V_7
      IL_0026:  br.s       IL_0028
     ~IL_0028:  ldc.i4.1
      IL_0029:  brtrue.s   IL_002c
     -IL_002b:  nop
     -IL_002c:  ldloc.s    V_7
      IL_002e:  stloc.s    V_5
      IL_0030:  br.s       IL_0037
     -IL_0032:  ldc.i4.1
      IL_0033:  stloc.s    V_5
      IL_0035:  br.s       IL_0037
     ~IL_0037:  ldc.i4.1
      IL_0038:  brtrue.s   IL_003b
     -IL_003a:  nop
     ~IL_003b:  ldloc.s    V_5
      IL_003d:  box        ""int""
      IL_0042:  stloc.s    V_8
      IL_0044:  br.s       IL_0046
     -IL_0046:  ldloc.s    V_8
      IL_0048:  ret
    }
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,141022,143991);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_141395_141451(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141395, 141451);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_141485_141516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141485, 141516);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_141549_141574()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141549, 141574);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_141602_141647(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141602, 141647);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_141680_141710(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141680, 141710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_141739_141782(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141739, 141782);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_141850_141888(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141850, 141888);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_141815_141925(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141815, 141925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_141956_141999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 141956, 141999);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_142187_142226(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 142187, 142226);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_142102_142258(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 142102, 142258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_142026_142259(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 142026, 142259);
return return_v;
}


int
f_23110_142276_143979(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 142276, 143979);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,141022,143991);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,141022,143991);
}
		}

[Fact]
        public void ForEachStatement_Deconstruction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,144003,147043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144089,144357);

var 
source = @"
class C
{
    public static (int, (bool, double))[] F() => new[] { (1, (true, 2.0)) };

    public static void G()
    {        
        foreach (var (x, (y, z)) in F())
        {
            System.Console.WriteLine(x);
        }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144373,144449);

var 
compilation0 = f_23110_144392_144448(source, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144463,144514);

var 
compilation1 = f_23110_144482_144513(compilation0, source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144530,144572);

var 
testData0 = f_23110_144546_144571()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144586,144645);

var 
bytes0 = f_23110_144599_144644(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144659,144708);

var 
methodData0 = f_23110_144677_144707(testData0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144722,144780);

var 
method0 = f_23110_144736_144779(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144794,144923);

var 
generation0 = f_23110_144812_144922(f_23110_144847_144885(bytes0), methodData0.EncDebugInfoProvider())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,144939,144997);

var 
method1 = f_23110_144953_144996(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,145011,145257);

var 
diff1 = f_23110_145023_145256(compilation1, generation0, f_23110_145099_145255(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23110_145184_145223(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,145273,147032);

f_23110_145273_147031(
            diff1, "C.G", @"
{
  // Code size       78 (0x4e)
  .maxstack  2
  .locals init ([unchanged] V_0,
                [int] V_1,
                int V_2, //x
                bool V_3, //y
                double V_4, //z
                [unchanged] V_5,
                System.ValueTuple<int, System.ValueTuple<bool, double>>[] V_6,
                int V_7,
                System.ValueTuple<bool, double> V_8)
 -IL_0000:  nop
 -IL_0001:  nop
 -IL_0002:  call       ""System.ValueTuple<int, System.ValueTuple<bool, double>>[] C.F()""
  IL_0007:  stloc.s    V_6
  IL_0009:  ldc.i4.0
  IL_000a:  stloc.s    V_7
 ~IL_000c:  br.s       IL_0045
 -IL_000e:  ldloc.s    V_6
  IL_0010:  ldloc.s    V_7
  IL_0012:  ldelem     ""System.ValueTuple<int, System.ValueTuple<bool, double>>""
  IL_0017:  dup
  IL_0018:  ldfld      ""System.ValueTuple<bool, double> System.ValueTuple<int, System.ValueTuple<bool, double>>.Item2""
  IL_001d:  stloc.s    V_8
  IL_001f:  ldfld      ""int System.ValueTuple<int, System.ValueTuple<bool, double>>.Item1""
  IL_0024:  stloc.2
  IL_0025:  ldloc.s    V_8
  IL_0027:  ldfld      ""bool System.ValueTuple<bool, double>.Item1""
  IL_002c:  stloc.3
  IL_002d:  ldloc.s    V_8
  IL_002f:  ldfld      ""double System.ValueTuple<bool, double>.Item2""
  IL_0034:  stloc.s    V_4
 -IL_0036:  nop
 -IL_0037:  ldloc.2
  IL_0038:  call       ""void System.Console.WriteLine(int)""
  IL_003d:  nop
 -IL_003e:  nop
 ~IL_003f:  ldloc.s    V_7
  IL_0041:  ldc.i4.1
  IL_0042:  add
  IL_0043:  stloc.s    V_7
 -IL_0045:  ldloc.s    V_7
  IL_0047:  ldloc.s    V_6
  IL_0049:  ldlen
  IL_004a:  conv.i4
  IL_004b:  blt.s      IL_000e
 -IL_004d:  ret
}
", methodToken: diff1.UpdatedMethods.Single());
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,144003,147043);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_144392_144448(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144392, 144448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_144482_144513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144482, 144513);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23110_144546_144571()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144546, 144571);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23110_144599_144644(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144599, 144644);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23110_144677_144707(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144677, 144707);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_144736_144779(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144736, 144779);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_144847_144885(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144847, 144885);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_144812_144922(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144812, 144922);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_144953_144996(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 144953, 144996);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_145184_145223(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 145184, 145223);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_145099_145255(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 145099, 145255);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_145023_145256(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 145023, 145256);
return return_v;
}


int
f_23110_145273_147031(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL,System.Reflection.Metadata.MethodDefinitionHandle
methodToken)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL, methodToken:methodToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 145273, 147031);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,144003,147043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,144003,147043);
}
		}

[Fact]
        public void ComplexTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23110,147055,157330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,147122,147761);

var 
sourceText = @"
using System;
using System.Collections.Generic;

class C1<T>
{
    public enum E
    {
        A
    }
}

class C
{
    public unsafe static void G()
    {        
        var <N:0>a</N:0> = new { key = ""a"", value = new List<(int, int)>()};
        var <N:1>b</N:1> = (number: 5, value: a);
        var <N:2>c</N:2> = new[] { b };
        int[] <N:3>array</N:3> = { 1, 2, 3 };
        ref int <N:4>d</N:4> = ref array[0];
        ref readonly int <N:5>e</N:5> = ref array[0];
        C1<(int, dynamic)>.E***[,,] <N:6>x</N:6> = null;
        var <N:7>f</N:7> = new List<string?>();
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,147775,147896);

var 
source0 = f_23110_147789_147895(sourceText, options: f_23110_147823_147894(f_23110_147823_147849(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,147910,148031);

var 
source1 = f_23110_147924_148030(sourceText, options: f_23110_147958_148029(f_23110_147958_147984(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148045,148166);

var 
source2 = f_23110_148059_148165(sourceText, options: f_23110_148093_148164(f_23110_148093_148119(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148182,148281);

var 
compilation0 = f_23110_148201_148280(source0.Tree, options: f_23110_148242_148279(ComSafeDebugDll, true))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148297,148354);

var 
compilation1 = f_23110_148316_148353(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148368,148425);

var 
compilation2 = f_23110_148387_148424(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148441,148494);

var 
f0 = f_23110_148450_148493(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148508,148561);

var 
f1 = f_23110_148517_148560(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148575,148628);

var 
f2 = f_23110_148584_148627(compilation2, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148644,148684);

var 
v0 = f_23110_148653_148683(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,148698,151490);

f_23110_148698_151489(            v0, "C.G", @"
    {
      // Code size       88 (0x58)
      .maxstack  4
      .locals init (<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>> V_0, //a
                    System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>> V_1, //b
                    System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>[] V_2, //c
                    int[] V_3, //array
                    int& V_4, //d
                    int& V_5, //e
                    C1<System.ValueTuple<int, dynamic>>.E***[,,] V_6, //x
                    System.Collections.Generic.List<string> V_7) //f
      IL_0000:  nop
      IL_0001:  ldstr      ""a""
      IL_0006:  newobj     ""System.Collections.Generic.List<System.ValueTuple<int, int>>..ctor()""
      IL_000b:  newobj     ""<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>>..ctor(string, System.Collections.Generic.List<System.ValueTuple<int, int>>)""
      IL_0010:  stloc.0
      IL_0011:  ldloca.s   V_1
      IL_0013:  ldc.i4.5
      IL_0014:  ldloc.0
      IL_0015:  call       ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>..ctor(int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>)""
      IL_001a:  ldc.i4.1
      IL_001b:  newarr     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
      IL_0020:  dup
      IL_0021:  ldc.i4.0
      IL_0022:  ldloc.1
      IL_0023:  stelem     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
      IL_0028:  stloc.2
      IL_0029:  ldc.i4.3
      IL_002a:  newarr     ""int""
      IL_002f:  dup
      IL_0030:  ldtoken    ""<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>.4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D""
      IL_0035:  call       ""void System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(System.Array, System.RuntimeFieldHandle)""
      IL_003a:  stloc.3
      IL_003b:  ldloc.3
      IL_003c:  ldc.i4.0
      IL_003d:  ldelema    ""int""
      IL_0042:  stloc.s    V_4
      IL_0044:  ldloc.3
      IL_0045:  ldc.i4.0
      IL_0046:  ldelema    ""int""
      IL_004b:  stloc.s    V_5
      IL_004d:  ldnull
      IL_004e:  stloc.s    V_6
      IL_0050:  newobj     ""System.Collections.Generic.List<string>..ctor()""
      IL_0055:  stloc.s    V_7
      IL_0057:  ret
    }
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,151506,151571);

var 
md0 = f_23110_151516_151570(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,151587,151689);

var 
generation0 = f_23110_151605_151688(md0, f_23110_151645_151665(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,151703,151963);

var 
diff1 = f_23110_151715_151962(compilation1, generation0, f_23110_151791_151961(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23110_151888_151929(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,151979,154500);

f_23110_151979_154499(
            diff1, "C.G", @"
{
  // Code size       89 (0x59)
  .maxstack  4
  .locals init (<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>> V_0, //a
                System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>> V_1, //b
                System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>[] V_2, //c
                int[] V_3, //array
                int& V_4, //d
                int& V_5, //e
                C1<System.ValueTuple<int, dynamic>>.E***[,,] V_6, //x
                System.Collections.Generic.List<string> V_7) //f
  IL_0000:  nop
  IL_0001:  ldstr      ""a""
  IL_0006:  newobj     ""System.Collections.Generic.List<System.ValueTuple<int, int>>..ctor()""
  IL_000b:  newobj     ""<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>>..ctor(string, System.Collections.Generic.List<System.ValueTuple<int, int>>)""
  IL_0010:  stloc.0
  IL_0011:  ldloca.s   V_1
  IL_0013:  ldc.i4.5
  IL_0014:  ldloc.0
  IL_0015:  call       ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>..ctor(int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>)""
  IL_001a:  ldc.i4.1
  IL_001b:  newarr     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
  IL_0020:  dup
  IL_0021:  ldc.i4.0
  IL_0022:  ldloc.1
  IL_0023:  stelem     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
  IL_0028:  stloc.2
  IL_0029:  ldc.i4.3
  IL_002a:  newarr     ""int""
  IL_002f:  dup
  IL_0030:  ldc.i4.0
  IL_0031:  ldc.i4.1
  IL_0032:  stelem.i4
  IL_0033:  dup
  IL_0034:  ldc.i4.1
  IL_0035:  ldc.i4.2
  IL_0036:  stelem.i4
  IL_0037:  dup
  IL_0038:  ldc.i4.2
  IL_0039:  ldc.i4.3
  IL_003a:  stelem.i4
  IL_003b:  stloc.3
  IL_003c:  ldloc.3
  IL_003d:  ldc.i4.0
  IL_003e:  ldelema    ""int""
  IL_0043:  stloc.s    V_4
  IL_0045:  ldloc.3
  IL_0046:  ldc.i4.0
  IL_0047:  ldelema    ""int""
  IL_004c:  stloc.s    V_5
  IL_004e:  ldnull
  IL_004f:  stloc.s    V_6
  IL_0051:  newobj     ""System.Collections.Generic.List<string>..ctor()""
  IL_0056:  stloc.s    V_7
  IL_0058:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,154516,154782);

var 
diff2 = f_23110_154528_154781(compilation2, f_23110_154573_154593(diff1), f_23110_154611_154780(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23110_154707_154748(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23110,154798,157319);

f_23110_154798_157318(
            diff2, "C.G", @"
{
  // Code size       89 (0x59)
  .maxstack  4
  .locals init (<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>> V_0, //a
                System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>> V_1, //b
                System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>[] V_2, //c
                int[] V_3, //array
                int& V_4, //d
                int& V_5, //e
                C1<System.ValueTuple<int, dynamic>>.E***[,,] V_6, //x
                System.Collections.Generic.List<string> V_7) //f
  IL_0000:  nop
  IL_0001:  ldstr      ""a""
  IL_0006:  newobj     ""System.Collections.Generic.List<System.ValueTuple<int, int>>..ctor()""
  IL_000b:  newobj     ""<>f__AnonymousType0<string, System.Collections.Generic.List<System.ValueTuple<int, int>>>..ctor(string, System.Collections.Generic.List<System.ValueTuple<int, int>>)""
  IL_0010:  stloc.0
  IL_0011:  ldloca.s   V_1
  IL_0013:  ldc.i4.5
  IL_0014:  ldloc.0
  IL_0015:  call       ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>..ctor(int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>)""
  IL_001a:  ldc.i4.1
  IL_001b:  newarr     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
  IL_0020:  dup
  IL_0021:  ldc.i4.0
  IL_0022:  ldloc.1
  IL_0023:  stelem     ""System.ValueTuple<int, <anonymous type: string key, System.Collections.Generic.List<System.ValueTuple<int, int>> value>>""
  IL_0028:  stloc.2
  IL_0029:  ldc.i4.3
  IL_002a:  newarr     ""int""
  IL_002f:  dup
  IL_0030:  ldc.i4.0
  IL_0031:  ldc.i4.1
  IL_0032:  stelem.i4
  IL_0033:  dup
  IL_0034:  ldc.i4.1
  IL_0035:  ldc.i4.2
  IL_0036:  stelem.i4
  IL_0037:  dup
  IL_0038:  ldc.i4.2
  IL_0039:  ldc.i4.3
  IL_003a:  stelem.i4
  IL_003b:  stloc.3
  IL_003c:  ldloc.3
  IL_003d:  ldc.i4.0
  IL_003e:  ldelema    ""int""
  IL_0043:  stloc.s    V_4
  IL_0045:  ldloc.3
  IL_0046:  ldc.i4.0
  IL_0047:  ldelema    ""int""
  IL_004c:  stloc.s    V_5
  IL_004e:  ldnull
  IL_004f:  stloc.s    V_6
  IL_0051:  newobj     ""System.Collections.Generic.List<string>..ctor()""
  IL_0056:  stloc.s    V_7
  IL_0058:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23110,147055,157330);

Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_147823_147849()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 147823, 147849);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_147823_147894(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 147823, 147894);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_147789_147895(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 147789, 147895);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_147958_147984()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 147958, 147984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_147958_148029(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 147958, 148029);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_147924_148030(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 147924, 148030);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_148093_148119()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 148093, 148119);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23110_148093_148164(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148093, 148164);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23110_148059_148165(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148059, 148165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23110_148242_148279(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
enabled)
{
var return_v = this_param.WithAllowUnsafe( enabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148242, 148279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_148201_148280(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148201, 148280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_148316_148353(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148316, 148353);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23110_148387_148424(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148387, 148424);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_148450_148493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148450, 148493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_148517_148560(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148517, 148560);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23110_148584_148627(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148584, 148627);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_148653_148683(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.LocalSlotMappingTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148653, 148683);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23110_148698_151489(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 148698, 151489);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23110_151516_151570(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151516, 151570);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23110_151645_151665(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151645, 151665);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_151605_151688(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151605, 151688);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_151888_151929(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151888, 151929);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_151791_151961(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151791, 151961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_151715_151962(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151715, 151962);
return return_v;
}


int
f_23110_151979_154499(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 151979, 154499);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23110_154573_154593(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23110, 154573, 154593);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23110_154707_154748(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 154707, 154748);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23110_154611_154780(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 154611, 154780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23110_154528_154781(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 154528, 154781);
return return_v;
}


int
f_23110_154798_157318(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23110, 154798, 157318);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23110,147055,157330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,147055,157330);
}
		}

public LocalSlotMappingTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23110,751,157337);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23110,751,157337);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,751,157337);
}


static LocalSlotMappingTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23110,751,157337);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23110,751,157337);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23110,751,157337);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23110,751,157337);
}
}
