// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
public class EditAndContinuePdbTests : EditAndContinueTestBase
{
[Theory]
        [MemberData(nameof(ExternalPdbFormats))]
        public void MethodExtents(DebugInformationFormat format)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23106,739,16800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,888,1692);

var 
source0 = f_23106_902_1691(f_23106_915_1665(@"#pragma checksum ""C:\Enc1.cs"" ""{ff1816ec-aa5e-4d10-87f7-6f4963833460}"" ""1111111111111111111111111111111111111111""
using System;

public class C
{
    int A() => 1;                  
                                   
    void F()                       
    {                              
#line 10 ""C:\F\A.cs""               
        Console.WriteLine();
#line 20 ""C:\F\B.cs""
        Console.WriteLine();
#line default
    }

    int E() => 1;

    void G()
    {
        Func<int> <N:4>H1</N:4> = <N:0>() => 1</N:0>;

        Action <N:5>H2</N:5> = <N:1>() =>
        {
            Func<int> <N:6>H3</N:6> = <N:2>() => 3</N:2>;

        }</N:1>;
    }
}                              
"), fileName: @"C:\Enc1.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,1708,2525);

var 
source1 = f_23106_1722_2524(f_23106_1735_2498(@"#pragma checksum ""C:\Enc1.cs"" ""{ff1816ec-aa5e-4d10-87f7-6f4963833460}"" ""2222222222222222222222222222222222222222""
using System;

public class C
{
    int A() => 1;                 
                              
    void F()                      
    {                             
#line 10 ""C:\F\A.cs""         
        Console.WriteLine();
#line 10 ""C:\F\C.cs""
        Console.WriteLine();
#line default
    }

    void G()
    {
        Func<int> <N:4>H1</N:4> = <N:0>() => 1</N:0>;

        Action <N:5>H2</N:5> = <N:1>() =>
        {
            Func<int> <N:6>H3</N:6> = <N:2>() => 3</N:2>;
            Func<int> <N:7>H4</N:7> = <N:3>() => 4</N:3>;
        }</N:1>;
    }

    int E() => 1;
}
"), fileName: @"C:\Enc1.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,2541,3242);

var 
source2 = f_23106_2555_3241(f_23106_2568_3215(@"#pragma checksum ""C:\Enc1.cs"" ""{ff1816ec-aa5e-4d10-87f7-6f4963833460}"" ""3333333333333333333333333333333333333333""
using System;

public class C
{
    int A() => 3;                 
                              
    void F()       
    {    
#line 10 ""C:\F\B.cs""
        Console.WriteLine();
#line 10 ""C:\F\E.cs""
        Console.WriteLine();
#line default
    }

    void G()
    {
        

        Action <N:5>H2</N:5> = <N:1>() =>
        {
            
            Func<int> <N:7>H4</N:7> = <N:3>() => 4</N:3>;
        }</N:1>;
    }

    int E() => 1;  

    int B() => 4;
}
"), fileName: @"C:\Enc1.cs")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3258,3422);

var 
compilation0 = f_23106_3277_3421(source0.Tree, options: f_23106_3318_3386(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "EncMethodExtents")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3436,3493);

var 
compilation1 = f_23106_3455_3492(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3507,3564);

var 
compilation2 = f_23106_3526_3563(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3580,3613);

f_23106_3580_3612(
            compilation0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3627,3660);

f_23106_3627_3659(            compilation1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3674,3707);

f_23106_3674_3706(            compilation2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3723,3832);

var 
v0 = f_23106_3732_3831(this, compilation0, emitOptions: f_23106_3776_3830(EmitOptions.Default, format))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3846,3911);

var 
md0 = f_23106_3856_3910(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3927,3980);

var 
f0 = f_23106_3936_3979(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,3994,4047);

var 
f1 = f_23106_4003_4046(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4061,4114);

var 
f2 = f_23106_4070_4113(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4130,4183);

var 
g0 = f_23106_4139_4182(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4197,4250);

var 
g1 = f_23106_4206_4249(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4264,4317);

var 
g2 = f_23106_4273_4316(compilation2, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4333,4386);

var 
a1 = f_23106_4342_4385(compilation1, "C.A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4400,4453);

var 
a2 = f_23106_4409_4452(compilation2, "C.A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4469,4522);

var 
b2 = f_23106_4478_4521(compilation2, "C.B")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4538,4640);

var 
generation0 = f_23106_4556_4639(md0, f_23106_4596_4616(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4656,4715);

var 
syntaxMap1 = f_23106_4673_4714(source0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,4729,5075);

var 
diff1 = f_23106_4741_5074(compilation1, generation0, f_23106_4817_5073(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,syntaxMap1,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,g0,g1,syntaxMap1,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,5091,5268);

f_23106_5091_5267(
            diff1, "C: {<>c}", "C.<>c: {<>9__3_0, <>9__3_2, <>9__3_3#1, <>9__3_1, <G>b__3_0, <G>b__3_1, <G>b__3_2, <G>b__3_3#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,5284,5325);

var 
reader1 = f_23106_5298_5317(diff1).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,5341,6269);

f_23106_5341_6268(reader1, f_23106_5390_5456(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23106_5475_5541(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23106_5560_5621(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23106_5640_5698(5, TableIndex.Field, EditAndContinueOperation.Default), f_23106_5717_5779(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_5798_5860(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_5879_5941(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_5960_6022(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_6041_6104(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_6123_6185(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23106_6204_6267(11, TableIndex.MethodDef, EditAndContinueOperation.Default));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,6285,6935) || true) && (format == DebugInformationFormat.PortablePdb)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23106,6285,6935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,6367,6451);

using var 
pdbProvider = f_23106_6391_6450(diff1.PdbDelta)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,6471,6920);

f_23106_6471_6919(f_23106_6483_6514(pdbProvider), f_23106_6537_6581(2, TableIndex.MethodDebugInformation), f_23106_6604_6648(4, TableIndex.MethodDebugInformation), f_23106_6671_6715(8, TableIndex.MethodDebugInformation), f_23106_6738_6782(9, TableIndex.MethodDebugInformation), f_23106_6805_6850(10, TableIndex.MethodDebugInformation), f_23106_6873_6918(11, TableIndex.MethodDebugInformation));
DynAbs.Tracing.TraceSender.TraceExitCondition(23106,6285,6935);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,6951,10907);

f_23106_6951_10906(
            diff1, f_23106_6967_6999(0x06000001, 20), @"
<symbols>
  <files>
    <file id=""1"" name=""C:\Enc1.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""0B-95-CB-78-00-AE-C7-34-45-D9-FB-31-E4-30-A4-0E-FC-EA-9E-95"" />
    <file id=""2"" name=""C:\F\A.cs"" language=""C#"" />
    <file id=""3"" name=""C:\F\C.cs"" language=""C#"" />
  </files>
  <methods>
    <method token=""0x6000002"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""29"" document=""2"" />
        <entry offset=""0x7"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""29"" document=""3"" />
        <entry offset=""0xd"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xe"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method token=""0x6000004"">
      <customDebugInfo>
        <forward token=""0x6000002"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""18"" startColumn=""5"" endLine=""18"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""19"" startColumn=""9"" endLine=""19"" endColumn=""54"" document=""1"" />
        <entry offset=""0x21"" startLine=""21"" startColumn=""9"" endLine=""25"" endColumn=""17"" document=""1"" />
        <entry offset=""0x41"" startLine=""26"" startColumn=""5"" endLine=""26"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x42"">
        <local name=""H1"" il_index=""0"" il_start=""0x0"" il_end=""0x42"" attributes=""0"" />
        <local name=""H2"" il_index=""1"" il_start=""0x0"" il_end=""0x42"" attributes=""0"" />
      </scope>
    </method>
    <method token=""0x6000008"">
      <customDebugInfo>
        <forward token=""0x6000002"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""19"" startColumn=""46"" endLine=""19"" endColumn=""47"" document=""1"" />
      </sequencePoints>
    </method>
    <method token=""0x6000009"">
      <customDebugInfo>
        <forward token=""0x6000002"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""22"" startColumn=""9"" endLine=""22"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""23"" startColumn=""13"" endLine=""23"" endColumn=""58"" document=""1"" />
        <entry offset=""0x21"" startLine=""24"" startColumn=""13"" endLine=""24"" endColumn=""58"" document=""1"" />
        <entry offset=""0x41"" startLine=""25"" startColumn=""9"" endLine=""25"" endColumn=""10"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x42"">
        <local name=""H3"" il_index=""0"" il_start=""0x0"" il_end=""0x42"" attributes=""0"" />
        <local name=""H4"" il_index=""1"" il_start=""0x0"" il_end=""0x42"" attributes=""0"" />
      </scope>
    </method>
    <method token=""0x600000a"">
      <customDebugInfo>
        <forward token=""0x6000002"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""23"" startColumn=""50"" endLine=""23"" endColumn=""51"" document=""1"" />
      </sequencePoints>
    </method>
    <method token=""0x600000b"">
      <customDebugInfo>
        <forward token=""0x6000002"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""24"" startColumn=""50"" endLine=""24"" endColumn=""51"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,10921,10980);

var 
syntaxMap2 = f_23106_10938_10979(source1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,10994,11543);

var 
diff2 = f_23106_11006_11542(compilation2, f_23106_11052_11072(diff1), f_23106_11091_11541(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,syntaxMap2,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,g1,g2,syntaxMap2,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,a1,a2,syntaxMap2,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Insert,null,b2)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,11559,11736);

f_23106_11559_11735(
            diff2, "C: {<>c}", "C.<>c: {<>9__3_3#1, <>9__3_1, <G>b__3_1, <G>b__3_3#1, <>9__3_0, <>9__3_2, <G>b__3_0, <G>b__3_2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,11752,11793);

var 
reader2 = f_23106_11766_11785(diff2).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,11809,12580);

f_23106_11809_12579(reader2, f_23106_11858_11924(5, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23106_11943_12009(6, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23106_12028_12090(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_12109_12171(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_12190_12252(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_12271_12333(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_12352_12415(11, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23106_12434_12496(2, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23106_12515_12578(12, TableIndex.MethodDef, EditAndContinueOperation.Default));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,12596,13246) || true) && (format == DebugInformationFormat.PortablePdb)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23106,12596,13246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,12678,12762);

using var 
pdbProvider = f_23106_12702_12761(diff2.PdbDelta)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,12782,13231);

f_23106_12782_13230(f_23106_12794_12825(pdbProvider), f_23106_12848_12892(1, TableIndex.MethodDebugInformation), f_23106_12915_12959(2, TableIndex.MethodDebugInformation), f_23106_12982_13026(4, TableIndex.MethodDebugInformation), f_23106_13049_13093(9, TableIndex.MethodDebugInformation), f_23106_13116_13161(11, TableIndex.MethodDebugInformation), f_23106_13184_13229(12, TableIndex.MethodDebugInformation));
DynAbs.Tracing.TraceSender.TraceExitCondition(23106,12596,13246);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23106,13262,16789);

f_23106_13262_16788(
            diff2, f_23106_13278_13310(0x06000001, 20), @"
<symbols>
  <files>
    <file id=""1"" name=""C:\Enc1.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""9C-B9-FF-18-0E-9F-A4-22-93-85-A8-5A-06-11-43-1E-64-3E-88-06"" />
    <file id=""2"" name=""C:\F\B.cs"" language=""C#"" />
    <file id=""3"" name=""C:\F\E.cs"" language=""C#"" />
  </files>
  <methods>
    <method token=""0x6000001"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""16"" endLine=""6"" endColumn=""17"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method token=""0x6000002"">
      <customDebugInfo>
        <forward token=""0x6000001"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""29"" document=""2"" />
        <entry offset=""0x7"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""29"" document=""3"" />
        <entry offset=""0xd"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
    <method token=""0x6000004"">
      <customDebugInfo>
        <forward token=""0x6000001"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""18"" startColumn=""5"" endLine=""18"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""21"" startColumn=""9"" endLine=""25"" endColumn=""17"" document=""1"" />
        <entry offset=""0x21"" startLine=""26"" startColumn=""5"" endLine=""26"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x22"">
        <local name=""H2"" il_index=""1"" il_start=""0x0"" il_end=""0x22"" attributes=""0"" />
      </scope>
    </method>
    <method token=""0x6000009"">
      <customDebugInfo>
        <forward token=""0x6000001"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""22"" startColumn=""9"" endLine=""22"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""24"" startColumn=""13"" endLine=""24"" endColumn=""58"" document=""1"" />
        <entry offset=""0x21"" startLine=""25"" startColumn=""9"" endLine=""25"" endColumn=""10"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x22"">
        <local name=""H4"" il_index=""1"" il_start=""0x0"" il_end=""0x22"" attributes=""0"" />
      </scope>
    </method>
    <method token=""0x600000b"">
      <customDebugInfo>
        <forward token=""0x6000001"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""24"" startColumn=""50"" endLine=""24"" endColumn=""51"" document=""1"" />
      </sequencePoints>
    </method>
    <method token=""0x600000c"">
      <customDebugInfo>
        <forward token=""0x6000001"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""30"" startColumn=""16"" endLine=""30"" endColumn=""17"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23106,739,16800);

string
f_23106_915_1665(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 915, 1665);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23106_902_1691(string
markedSource,string
fileName)
{
var return_v = MarkedSource( markedSource, fileName:fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 902, 1691);
return return_v;
}


string
f_23106_1735_2498(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 1735, 2498);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23106_1722_2524(string
markedSource,string
fileName)
{
var return_v = MarkedSource( markedSource, fileName:fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 1722, 2524);
return return_v;
}


string
f_23106_2568_3215(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 2568, 3215);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23106_2555_3241(string
markedSource,string
fileName)
{
var return_v = MarkedSource( markedSource, fileName:fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 2555, 3241);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23106_3318_3386(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3318, 3386);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3277_3421(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3277, 3421);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3455_3492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3455, 3492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3526_3563(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3526, 3563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3580_3612(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3580, 3612);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3627_3659(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3627, 3659);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23106_3674_3706(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3674, 3706);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23106_3776_3830(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
format)
{
var return_v = this_param.WithDebugInformationFormat( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3776, 3830);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23106_3732_3831(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinuePdbTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
emitOptions)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, emitOptions:emitOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3732, 3831);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23106_3856_3910(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3856, 3910);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_3936_3979(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 3936, 3979);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4003_4046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4003, 4046);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4070_4113(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4070, 4113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4139_4182(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4139, 4182);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4206_4249(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4206, 4249);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4273_4316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4273, 4316);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4342_4385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4342, 4385);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4409_4452(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4409, 4452);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23106_4478_4521(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4478, 4521);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23106_4596_4616(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4596, 4616);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23106_4556_4639(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4556, 4639);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23106_4673_4714(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4673, 4714);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23106_4817_5073(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4817, 5073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23106_4741_5074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 4741, 5074);
return return_v;
}


int
f_23106_5091_5267(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5091, 5267);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23106_5298_5317(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5298, 5317);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5390_5456(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5390, 5456);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5475_5541(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5475, 5541);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5560_5621(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5560, 5621);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5640_5698(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5640, 5698);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5717_5779(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5717, 5779);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5798_5860(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5798, 5860);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5879_5941(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5879, 5941);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_5960_6022(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5960, 6022);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_6041_6104(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6041, 6104);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_6123_6185(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6123, 6185);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_6204_6267(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6204, 6267);
return return_v;
}


int
f_23106_5341_6268(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 5341, 6268);
return 0;
}


System.Reflection.Metadata.MetadataReaderProvider
f_23106_6391_6450(System.Collections.Immutable.ImmutableArray<byte>
image)
{
var return_v = MetadataReaderProvider.FromPortablePdbImage( image);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6391, 6450);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23106_6483_6514(System.Reflection.Metadata.MetadataReaderProvider
this_param)
{
var return_v = this_param.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6483, 6514);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6537_6581(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6537, 6581);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6604_6648(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6604, 6648);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6671_6715(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6671, 6715);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6738_6782(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6738, 6782);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6805_6850(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6805, 6850);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_6873_6918(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6873, 6918);
return return_v;
}


int
f_23106_6471_6919(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.EntityHandle[]
handles)
{
CheckEncMap( reader, handles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6471, 6919);
return 0;
}


System.Collections.Generic.IEnumerable<int>
f_23106_6967_6999(int
start,int
count)
{
var return_v = Enumerable.Range( start, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6967, 6999);
return return_v;
}


int
f_23106_6951_10906(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
diff,System.Collections.Generic.IEnumerable<int>
methodTokens,string
expectedPdb)
{
diff.VerifyPdb( methodTokens, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 6951, 10906);
return 0;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23106_10938_10979(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 10938, 10979);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23106_11052_11072(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23106, 11052, 11072);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23106_11091_11541(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2,Microsoft.CodeAnalysis.Emit.SemanticEdit
item3,Microsoft.CodeAnalysis.Emit.SemanticEdit
item4)
{
var return_v = ImmutableArray.Create( item1, item2, item3, item4);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11091, 11541);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23106_11006_11542(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11006, 11542);
return return_v;
}


int
f_23106_11559_11735(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11559, 11735);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23106_11766_11785(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11766, 11785);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_11858_11924(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11858, 11924);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_11943_12009(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11943, 12009);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12028_12090(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12028, 12090);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12109_12171(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12109, 12171);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12190_12252(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12190, 12252);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12271_12333(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12271, 12333);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12352_12415(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12352, 12415);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12434_12496(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12434, 12496);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23106_12515_12578(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12515, 12578);
return return_v;
}


int
f_23106_11809_12579(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 11809, 12579);
return 0;
}


System.Reflection.Metadata.MetadataReaderProvider
f_23106_12702_12761(System.Collections.Immutable.ImmutableArray<byte>
image)
{
var return_v = MetadataReaderProvider.FromPortablePdbImage( image);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12702, 12761);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23106_12794_12825(System.Reflection.Metadata.MetadataReaderProvider
this_param)
{
var return_v = this_param.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12794, 12825);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_12848_12892(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12848, 12892);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_12915_12959(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12915, 12959);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_12982_13026(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12982, 13026);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_13049_13093(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 13049, 13093);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_13116_13161(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 13116, 13161);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23106_13184_13229(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 13184, 13229);
return return_v;
}


int
f_23106_12782_13230(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.EntityHandle[]
handles)
{
CheckEncMap( reader, handles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 12782, 13230);
return 0;
}


System.Collections.Generic.IEnumerable<int>
f_23106_13278_13310(int
start,int
count)
{
var return_v = Enumerable.Range( start, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 13278, 13310);
return return_v;
}


int
f_23106_13262_16788(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
diff,System.Collections.Generic.IEnumerable<int>
methodTokens,string
expectedPdb)
{
diff.VerifyPdb( methodTokens, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23106, 13262, 16788);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23106,739,16800);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23106,739,16800);
}
		}

public EditAndContinuePdbTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23106,660,16807);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23106,660,16807);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23106,660,16807);
}


static EditAndContinuePdbTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23106,660,16807);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23106,660,16807);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23106,660,16807);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23106,660,16807);
}
}
