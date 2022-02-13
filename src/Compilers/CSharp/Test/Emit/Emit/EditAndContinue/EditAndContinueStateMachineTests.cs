// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using static Roslyn.Test.Utilities.TestMetadata;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
public class EditAndContinueStateMachineTests : EditAndContinueTestBase
{
[Fact]
        [WorkItem(1068894, "DevDiv"), WorkItem(1137300, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1137300")]
        public void AddIteratorMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,816,14034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1011,1177);

var 
source0 = f_23107_1025_1176(@"using System.Collections.Generic;
class C
{
    static IEnumerable<object> F()
    {
        yield return 0;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1191,1429);

var 
source1 = f_23107_1205_1428(@"using System.Collections.Generic;
class C
{
    static IEnumerable<object> F()
    {
        yield return 0;
    }
    static IEnumerable<int> G()
    {
        yield return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1443,1559);

var 
compilation0 = f_23107_1462_1558(new[] { f_23107_1502_1524(source0, "a.cs")}, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1573,1689);

var 
compilation1 = f_23107_1592_1688(new[] { f_23107_1632_1654(source1, "a.cs")}, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1705,1745);

var 
bytes0 = f_23107_1718_1744(compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1759,1873);

var 
generation0 = f_23107_1777_1872(f_23107_1812_1850(bytes0), EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,1887,2095);

var 
diff1 = f_23107_1899_2094(compilation1, generation0, f_23107_1975_2093(SemanticEdit.Create(SemanticEditKind.Insert,null,f_23107_2048_2091(compilation1, "C.G"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,2111,2147);

using var 
md1 = f_23107_2127_2146(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,2161,2186);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,2202,9146);

f_23107_2202_9145(reader1, f_23107_2240_2304(2, TableIndex.AssemblyRef, EditAndContinueOperation.Default), f_23107_2323_2386(17, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2405_2468(18, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2487_2550(19, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2569_2632(20, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2651_2714(21, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2733_2796(22, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2815_2878(23, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2897_2960(24, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_2979_3042(25, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_3061_3124(26, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_3143_3206(27, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_3225_3288(28, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_3307_3370(29, TableIndex.MemberRef, EditAndContinueOperation.Default), f_23107_3389_3450(16, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3469_3530(17, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3549_3610(18, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3629_3690(19, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3709_3770(20, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3789_3850(21, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3869_3930(22, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_3949_4010(23, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_4029_4090(24, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_4109_4170(25, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_4189_4250(26, TableIndex.TypeRef, EditAndContinueOperation.Default), f_23107_4269_4330(3, TableIndex.TypeSpec, EditAndContinueOperation.Default), f_23107_4349_4410(4, TableIndex.TypeSpec, EditAndContinueOperation.Default), f_23107_4429_4495(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_4514_4580(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_4599_4659(4, TableIndex.TypeDef, EditAndContinueOperation.Default), f_23107_4678_4742(2, TableIndex.PropertyMap, EditAndContinueOperation.Default), f_23107_4761_4822(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_4841_4899(4, TableIndex.Field, EditAndContinueOperation.Default), f_23107_4918_4979(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_4998_5056(5, TableIndex.Field, EditAndContinueOperation.Default), f_23107_5075_5136(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_5155_5213(6, TableIndex.Field, EditAndContinueOperation.Default), f_23107_5232_5294(2, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_5313_5376(11, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_5395_5457(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_5476_5539(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_5558_5620(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_5639_5702(13, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_5721_5783(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_5802_5865(14, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_5884_5946(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_5965_6028(15, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_6047_6109(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_6128_6191(16, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_6210_6272(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_6291_6354(17, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_6373_6435(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_6454_6517(18, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_6536_6598(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_6617_6680(19, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_6699_6767(2, TableIndex.PropertyMap, EditAndContinueOperation.AddProperty), f_23107_6786_6847(3, TableIndex.Property, EditAndContinueOperation.Default), f_23107_6866_6934(2, TableIndex.PropertyMap, EditAndContinueOperation.AddProperty), f_23107_6953_7014(4, TableIndex.Property, EditAndContinueOperation.Default), f_23107_7033_7101(12, TableIndex.MethodDef, EditAndContinueOperation.AddParameter), f_23107_7120_7178(2, TableIndex.Param, EditAndContinueOperation.Default), f_23107_7197_7266(12, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7285_7354(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7373_7442(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7461_7530(15, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7549_7618(16, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7637_7706(17, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7725_7794(18, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7813_7882(19, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_7901_7969(3, TableIndex.MethodSemantics, EditAndContinueOperation.Default), f_23107_7988_8056(4, TableIndex.MethodSemantics, EditAndContinueOperation.Default), f_23107_8075_8138(8, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8157_8220(9, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8239_8303(10, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8322_8386(11, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8405_8469(12, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8488_8552(13, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8571_8635(14, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_8654_8718(2, TableIndex.NestedClass, EditAndContinueOperation.Default), f_23107_8737_8803(6, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_8822_8888(7, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_8907_8973(8, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_8992_9058(9, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_9077_9144(10, TableIndex.InterfaceImpl, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,9162,12737);

f_23107_9162_12736(reader1, f_23107_9200_9230(16, TableIndex.TypeRef), f_23107_9249_9279(17, TableIndex.TypeRef), f_23107_9298_9328(18, TableIndex.TypeRef), f_23107_9347_9377(19, TableIndex.TypeRef), f_23107_9396_9426(20, TableIndex.TypeRef), f_23107_9445_9475(21, TableIndex.TypeRef), f_23107_9494_9524(22, TableIndex.TypeRef), f_23107_9543_9573(23, TableIndex.TypeRef), f_23107_9592_9622(24, TableIndex.TypeRef), f_23107_9641_9671(25, TableIndex.TypeRef), f_23107_9690_9720(26, TableIndex.TypeRef), f_23107_9739_9768(4, TableIndex.TypeDef), f_23107_9787_9814(4, TableIndex.Field), f_23107_9833_9860(5, TableIndex.Field), f_23107_9879_9906(6, TableIndex.Field), f_23107_9925_9957(11, TableIndex.MethodDef), f_23107_9976_10008(12, TableIndex.MethodDef), f_23107_10027_10059(13, TableIndex.MethodDef), f_23107_10078_10110(14, TableIndex.MethodDef), f_23107_10129_10161(15, TableIndex.MethodDef), f_23107_10180_10212(16, TableIndex.MethodDef), f_23107_10231_10263(17, TableIndex.MethodDef), f_23107_10282_10314(18, TableIndex.MethodDef), f_23107_10333_10365(19, TableIndex.MethodDef), f_23107_10384_10411(2, TableIndex.Param), f_23107_10430_10465(6, TableIndex.InterfaceImpl), f_23107_10484_10519(7, TableIndex.InterfaceImpl), f_23107_10538_10573(8, TableIndex.InterfaceImpl), f_23107_10592_10627(9, TableIndex.InterfaceImpl), f_23107_10646_10682(10, TableIndex.InterfaceImpl), f_23107_10701_10733(17, TableIndex.MemberRef), f_23107_10752_10784(18, TableIndex.MemberRef), f_23107_10803_10835(19, TableIndex.MemberRef), f_23107_10854_10886(20, TableIndex.MemberRef), f_23107_10905_10937(21, TableIndex.MemberRef), f_23107_10956_10988(22, TableIndex.MemberRef), f_23107_11007_11039(23, TableIndex.MemberRef), f_23107_11058_11090(24, TableIndex.MemberRef), f_23107_11109_11141(25, TableIndex.MemberRef), f_23107_11160_11192(26, TableIndex.MemberRef), f_23107_11211_11243(27, TableIndex.MemberRef), f_23107_11262_11294(28, TableIndex.MemberRef), f_23107_11313_11345(29, TableIndex.MemberRef), f_23107_11364_11402(12, TableIndex.CustomAttribute), f_23107_11421_11459(13, TableIndex.CustomAttribute), f_23107_11478_11516(14, TableIndex.CustomAttribute), f_23107_11535_11573(15, TableIndex.CustomAttribute), f_23107_11592_11630(16, TableIndex.CustomAttribute), f_23107_11649_11687(17, TableIndex.CustomAttribute), f_23107_11706_11744(18, TableIndex.CustomAttribute), f_23107_11763_11801(19, TableIndex.CustomAttribute), f_23107_11820_11855(3, TableIndex.StandAloneSig), f_23107_11874_11909(4, TableIndex.StandAloneSig), f_23107_11928_11961(2, TableIndex.PropertyMap), f_23107_11980_12010(3, TableIndex.Property), f_23107_12029_12059(4, TableIndex.Property), f_23107_12078_12115(3, TableIndex.MethodSemantics), f_23107_12134_12171(4, TableIndex.MethodSemantics), f_23107_12190_12222(8, TableIndex.MethodImpl), f_23107_12241_12273(9, TableIndex.MethodImpl), f_23107_12292_12325(10, TableIndex.MethodImpl), f_23107_12344_12377(11, TableIndex.MethodImpl), f_23107_12396_12429(12, TableIndex.MethodImpl), f_23107_12448_12481(13, TableIndex.MethodImpl), f_23107_12500_12533(14, TableIndex.MethodImpl), f_23107_12552_12582(3, TableIndex.TypeSpec), f_23107_12601_12631(4, TableIndex.TypeSpec), f_23107_12650_12683(2, TableIndex.AssemblyRef), f_23107_12702_12735(2, TableIndex.NestedClass));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,12753,14023);

f_23107_12753_14022(
            diff1, f_23107_12769_12803(0x06000001, 0x20), @"
<symbols>
  <files>
    <file id=""1"" name=""a.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""61-E4-46-A3-DE-2B-DE-69-1A-31-07-F6-EA-02-CE-B0-5F-38-03-79"" />
  </files>
  <methods>
    <method token=""0x600000b"">
      <customDebugInfo>
        <forwardIterator name=""&lt;G&gt;d__1#1"" />
      </customDebugInfo>
    </method>
    <method token=""0x600000e"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x1f"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x20"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""24"" document=""1"" />
        <entry offset=""0x30"" hidden=""true"" document=""1"" />
        <entry offset=""0x37"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x39"">
        <namespace name=""System.Collections.Generic"" />
      </scope>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,816,14034);

string
f_23107_1025_1176(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1025, 1176);
return return_v;
}


string
f_23107_1205_1428(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1205, 1428);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23107_1502_1524(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1502, 1524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_1462_1558(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1462, 1558);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree
f_23107_1632_1654(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1632, 1654);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_1592_1688(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1592, 1688);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23107_1718_1744(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1718, 1744);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_1812_1850(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1812, 1850);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_1777_1872(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1777, 1872);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_2048_2091(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2048, 2091);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_1975_2093(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1975, 2093);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_1899_2094(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 1899, 2094);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_2127_2146(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2127, 2146);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2240_2304(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2240, 2304);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2323_2386(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2323, 2386);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2405_2468(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2405, 2468);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2487_2550(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2487, 2550);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2569_2632(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2569, 2632);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2651_2714(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2651, 2714);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2733_2796(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2733, 2796);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2815_2878(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2815, 2878);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2897_2960(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2897, 2960);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_2979_3042(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2979, 3042);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3061_3124(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3061, 3124);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3143_3206(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3143, 3206);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3225_3288(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3225, 3288);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3307_3370(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3307, 3370);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3389_3450(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3389, 3450);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3469_3530(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3469, 3530);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3549_3610(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3549, 3610);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3629_3690(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3629, 3690);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3709_3770(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3709, 3770);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3789_3850(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3789, 3850);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3869_3930(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3869, 3930);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_3949_4010(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 3949, 4010);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4029_4090(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4029, 4090);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4109_4170(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4109, 4170);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4189_4250(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4189, 4250);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4269_4330(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4269, 4330);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4349_4410(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4349, 4410);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4429_4495(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4429, 4495);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4514_4580(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4514, 4580);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4599_4659(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4599, 4659);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4678_4742(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4678, 4742);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4761_4822(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4761, 4822);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4841_4899(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4841, 4899);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4918_4979(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4918, 4979);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_4998_5056(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 4998, 5056);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5075_5136(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5075, 5136);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5155_5213(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5155, 5213);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5232_5294(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5232, 5294);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5313_5376(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5313, 5376);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5395_5457(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5395, 5457);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5476_5539(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5476, 5539);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5558_5620(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5558, 5620);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5639_5702(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5639, 5702);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5721_5783(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5721, 5783);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5802_5865(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5802, 5865);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5884_5946(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5884, 5946);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_5965_6028(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 5965, 6028);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6047_6109(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6047, 6109);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6128_6191(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6128, 6191);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6210_6272(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6210, 6272);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6291_6354(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6291, 6354);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6373_6435(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6373, 6435);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6454_6517(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6454, 6517);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6536_6598(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6536, 6598);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6617_6680(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6617, 6680);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6699_6767(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6699, 6767);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6786_6847(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6786, 6847);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6866_6934(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6866, 6934);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_6953_7014(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 6953, 7014);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7033_7101(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7033, 7101);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7120_7178(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7120, 7178);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7197_7266(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7197, 7266);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7285_7354(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7285, 7354);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7373_7442(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7373, 7442);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7461_7530(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7461, 7530);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7549_7618(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7549, 7618);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7637_7706(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7637, 7706);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7725_7794(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7725, 7794);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7813_7882(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7813, 7882);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7901_7969(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7901, 7969);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_7988_8056(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 7988, 8056);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8075_8138(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8075, 8138);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8157_8220(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8157, 8220);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8239_8303(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8239, 8303);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8322_8386(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8322, 8386);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8405_8469(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8405, 8469);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8488_8552(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8488, 8552);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8571_8635(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8571, 8635);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8654_8718(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8654, 8718);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8737_8803(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8737, 8803);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8822_8888(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8822, 8888);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8907_8973(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8907, 8973);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_8992_9058(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 8992, 9058);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_9077_9144(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9077, 9144);
return return_v;
}


int
f_23107_2202_9145(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLog( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 2202, 9145);
return 0;
}


System.Reflection.Metadata.EntityHandle
f_23107_9200_9230(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9200, 9230);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9249_9279(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9249, 9279);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9298_9328(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9298, 9328);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9347_9377(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9347, 9377);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9396_9426(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9396, 9426);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9445_9475(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9445, 9475);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9494_9524(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9494, 9524);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9543_9573(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9543, 9573);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9592_9622(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9592, 9622);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9641_9671(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9641, 9671);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9690_9720(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9690, 9720);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9739_9768(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9739, 9768);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9787_9814(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9787, 9814);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9833_9860(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9833, 9860);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9879_9906(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9879, 9906);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9925_9957(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9925, 9957);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_9976_10008(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9976, 10008);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10027_10059(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10027, 10059);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10078_10110(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10078, 10110);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10129_10161(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10129, 10161);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10180_10212(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10180, 10212);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10231_10263(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10231, 10263);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10282_10314(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10282, 10314);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10333_10365(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10333, 10365);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10384_10411(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10384, 10411);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10430_10465(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10430, 10465);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10484_10519(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10484, 10519);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10538_10573(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10538, 10573);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10592_10627(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10592, 10627);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10646_10682(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10646, 10682);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10701_10733(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10701, 10733);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10752_10784(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10752, 10784);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10803_10835(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10803, 10835);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10854_10886(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10854, 10886);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10905_10937(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10905, 10937);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_10956_10988(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 10956, 10988);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11007_11039(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11007, 11039);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11058_11090(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11058, 11090);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11109_11141(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11109, 11141);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11160_11192(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11160, 11192);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11211_11243(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11211, 11243);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11262_11294(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11262, 11294);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11313_11345(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11313, 11345);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11364_11402(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11364, 11402);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11421_11459(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11421, 11459);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11478_11516(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11478, 11516);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11535_11573(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11535, 11573);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11592_11630(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11592, 11630);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11649_11687(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11649, 11687);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11706_11744(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11706, 11744);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11763_11801(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11763, 11801);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11820_11855(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11820, 11855);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11874_11909(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11874, 11909);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11928_11961(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11928, 11961);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_11980_12010(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 11980, 12010);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12029_12059(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12029, 12059);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12078_12115(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12078, 12115);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12134_12171(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12134, 12171);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12190_12222(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12190, 12222);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12241_12273(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12241, 12273);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12292_12325(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12292, 12325);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12344_12377(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12344, 12377);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12396_12429(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12396, 12429);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12448_12481(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12448, 12481);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12500_12533(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12500, 12533);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12552_12582(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12552, 12582);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12601_12631(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12601, 12631);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12650_12683(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12650, 12683);
return return_v;
}


System.Reflection.Metadata.EntityHandle
f_23107_12702_12735(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table)
{
var return_v = Handle( rowNumber, table);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12702, 12735);
return return_v;
}


int
f_23107_9162_12736(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.EntityHandle[]
handles)
{
CheckEncMap( reader, handles);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 9162, 12736);
return 0;
}


System.Collections.Generic.IEnumerable<int>
f_23107_12769_12803(int
start,int
count)
{
var return_v = Enumerable.Range( start, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12769, 12803);
return return_v;
}


int
f_23107_12753_14022(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
diff,System.Collections.Generic.IEnumerable<int>
methodTokens,string
expectedPdb)
{
diff.VerifyPdb( methodTokens, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 12753, 14022);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,816,14034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,816,14034);
}
		}

[Fact]
        public void AddAsyncMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,14046,17805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14115,14181);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14195,14364);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        await Task.FromResult(10);
        return 20;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14378,14469);

var 
compilation0 = f_23107_14397_14468(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14483,14535);

var 
compilation1 = f_23107_14502_14534(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14549,14589);

var 
v0 = f_23107_14558_14588(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14605,14735);

var 
generation0 = f_23107_14623_14734(f_23107_14658_14712(v0.EmittedAssemblyData), EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14749,14957);

var 
diff1 = f_23107_14761_14956(compilation1, generation0, f_23107_14837_14955(SemanticEdit.Create(SemanticEditKind.Insert,null,f_23107_14910_14953(compilation1, "C.F"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,14973,17794);
using(var 
md1 = f_23107_14990_15009(diff1)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,15043,15068);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,15428,17779);

f_23107_15428_17778(reader1, f_23107_15481_15547(1, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_15570_15636(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_15659_15719(3, TableIndex.TypeDef, EditAndContinueOperation.Default), f_23107_15742_15803(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_15826_15884(1, TableIndex.Field, EditAndContinueOperation.Default), f_23107_15907_15968(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_15991_16049(2, TableIndex.Field, EditAndContinueOperation.Default), f_23107_16072_16133(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_16156_16214(3, TableIndex.Field, EditAndContinueOperation.Default), f_23107_16237_16299(2, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_16322_16384(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_16407_16469(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_16492_16554(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_16577_16639(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_16662_16724(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_16747_16809(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_16832_16894(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_16917_16984(5, TableIndex.MethodDef, EditAndContinueOperation.AddParameter), f_23107_17007_17065(1, TableIndex.Param, EditAndContinueOperation.Default), f_23107_17088_17156(4, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_17179_17247(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_17270_17338(6, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_17361_17429(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_17452_17515(1, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_17538_17601(2, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_17624_17688(1, TableIndex.NestedClass, EditAndContinueOperation.Default), f_23107_17711_17777(1, TableIndex.InterfaceImpl, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,14973,17794);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,14046,17805);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_14397_14468(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14397, 14468);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_14502_14534(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14502, 14534);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_14558_14588(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14558, 14588);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_14658_14712(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14658, 14712);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_14623_14734(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14623, 14734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_14910_14953(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14910, 14953);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_14837_14955(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14837, 14955);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_14761_14956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14761, 14956);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_14990_15009(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 14990, 15009);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15481_15547(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15481, 15547);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15570_15636(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15570, 15636);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15659_15719(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15659, 15719);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15742_15803(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15742, 15803);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15826_15884(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15826, 15884);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15907_15968(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15907, 15968);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_15991_16049(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15991, 16049);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16072_16133(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16072, 16133);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16156_16214(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16156, 16214);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16237_16299(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16237, 16299);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16322_16384(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16322, 16384);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16407_16469(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16407, 16469);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16492_16554(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16492, 16554);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16577_16639(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16577, 16639);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16662_16724(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16662, 16724);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16747_16809(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16747, 16809);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16832_16894(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16832, 16894);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_16917_16984(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 16917, 16984);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17007_17065(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17007, 17065);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17088_17156(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17088, 17156);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17179_17247(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17179, 17247);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17270_17338(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17270, 17338);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17361_17429(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17361, 17429);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17452_17515(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17452, 17515);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17538_17601(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17538, 17601);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17624_17688(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17624, 17688);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_17711_17777(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 17711, 17777);
return return_v;
}


int
f_23107_15428_17778(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 15428, 17778);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,14046,17805);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,14046,17805);
}
		}

[Fact]
        public void MethodToIteratorMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,17817,24345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,17894,18051);

var 
source0 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        return new int[] { 1, 2, 3 };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18065,18208);

var 
source1 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        yield return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18222,18313);

var 
compilation0 = f_23107_18241_18312(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18327,18379);

var 
compilation1 = f_23107_18346_18378(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18395,18435);

var 
v0 = f_23107_18404_18434(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18451,24334);
using(var 
md0 = f_23107_18468_18522(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18556,18614);

var 
method0 = f_23107_18570_18613(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18632,18690);

var 
method1 = f_23107_18646_18689(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18710,18789);

var 
generation0 = f_23107_18728_18788(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,18807,18990);

var 
diff1 = f_23107_18819_18989(compilation1, generation0, f_23107_18903_18988(SemanticEdit.Create(SemanticEditKind.Update,method0,method1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,19010,24319);
using(var 
md1 = f_23107_19027_19046(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,19088,24300);

f_23107_19088_24299(md1.Reader, f_23107_19148_19214(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_19241_19307(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_19334_19394(5, TableIndex.TypeDef, EditAndContinueOperation.Default), f_23107_19421_19485(1, TableIndex.PropertyMap, EditAndContinueOperation.Default), f_23107_19512_19573(5, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_19600_19658(2, TableIndex.Field, EditAndContinueOperation.Default), f_23107_19685_19746(5, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_19773_19831(3, TableIndex.Field, EditAndContinueOperation.Default), f_23107_19858_19919(5, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_19946_20004(4, TableIndex.Field, EditAndContinueOperation.Default), f_23107_20031_20093(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_20120_20182(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_20209_20271(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_20298_20360(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_20387_20449(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_20476_20538(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_20565_20627(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_20654_20716(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_20743_20805(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_20832_20894(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_20921_20983(7, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_21010_21072(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_21099_21161(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_21188_21250(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_21277_21339(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_21366_21428(5, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_21455_21518(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_21545_21613(1, TableIndex.PropertyMap, EditAndContinueOperation.AddProperty), f_23107_21640_21701(1, TableIndex.Property, EditAndContinueOperation.Default), f_23107_21728_21796(1, TableIndex.PropertyMap, EditAndContinueOperation.AddProperty), f_23107_21823_21884(2, TableIndex.Property, EditAndContinueOperation.Default), f_23107_21911_21978(3, TableIndex.MethodDef, EditAndContinueOperation.AddParameter), f_23107_22005_22063(1, TableIndex.Param, EditAndContinueOperation.Default), f_23107_22090_22158(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22185_22253(6, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22280_22348(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22375_22443(8, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22470_22538(9, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22565_22634(10, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22661_22730(11, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22757_22826(12, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22853_22922(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_22949_23017(1, TableIndex.MethodSemantics, EditAndContinueOperation.Default), f_23107_23044_23112(2, TableIndex.MethodSemantics, EditAndContinueOperation.Default), f_23107_23139_23202(1, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23229_23292(2, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23319_23382(3, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23409_23472(4, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23499_23562(5, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23589_23652(6, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23679_23742(7, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_23769_23833(2, TableIndex.NestedClass, EditAndContinueOperation.Default), f_23107_23860_23926(1, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_23953_24019(2, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_24046_24112(3, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_24139_24205(4, TableIndex.InterfaceImpl, EditAndContinueOperation.Default), f_23107_24232_24298(5, TableIndex.InterfaceImpl, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,19010,24319);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,18451,24334);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,17817,24345);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_18241_18312(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18241, 18312);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_18346_18378(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18346, 18378);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_18404_18434(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18404, 18434);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_18468_18522(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18468, 18522);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_18570_18613(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18570, 18613);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_18646_18689(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18646, 18689);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_18728_18788(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18728, 18788);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_18903_18988(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18903, 18988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_18819_18989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 18819, 18989);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_19027_19046(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19027, 19046);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19148_19214(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19148, 19214);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19241_19307(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19241, 19307);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19334_19394(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19334, 19394);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19421_19485(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19421, 19485);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19512_19573(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19512, 19573);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19600_19658(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19600, 19658);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19685_19746(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19685, 19746);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19773_19831(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19773, 19831);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19858_19919(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19858, 19919);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_19946_20004(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19946, 20004);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20031_20093(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20031, 20093);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20120_20182(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20120, 20182);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20209_20271(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20209, 20271);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20298_20360(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20298, 20360);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20387_20449(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20387, 20449);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20476_20538(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20476, 20538);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20565_20627(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20565, 20627);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20654_20716(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20654, 20716);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20743_20805(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20743, 20805);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20832_20894(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20832, 20894);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_20921_20983(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 20921, 20983);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21010_21072(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21010, 21072);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21099_21161(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21099, 21161);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21188_21250(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21188, 21250);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21277_21339(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21277, 21339);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21366_21428(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21366, 21428);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21455_21518(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21455, 21518);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21545_21613(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21545, 21613);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21640_21701(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21640, 21701);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21728_21796(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21728, 21796);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21823_21884(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21823, 21884);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_21911_21978(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 21911, 21978);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22005_22063(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22005, 22063);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22090_22158(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22090, 22158);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22185_22253(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22185, 22253);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22280_22348(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22280, 22348);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22375_22443(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22375, 22443);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22470_22538(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22470, 22538);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22565_22634(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22565, 22634);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22661_22730(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22661, 22730);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22757_22826(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22757, 22826);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22853_22922(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22853, 22922);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_22949_23017(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 22949, 23017);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23044_23112(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23044, 23112);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23139_23202(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23139, 23202);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23229_23292(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23229, 23292);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23319_23382(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23319, 23382);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23409_23472(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23409, 23472);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23499_23562(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23499, 23562);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23589_23652(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23589, 23652);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23679_23742(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23679, 23742);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23769_23833(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23769, 23833);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23860_23926(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23860, 23926);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_23953_24019(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 23953, 24019);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_24046_24112(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24046, 24112);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_24139_24205(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24139, 24205);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_24232_24298(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24232, 24298);
return return_v;
}


int
f_23107_19088_24299(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 19088, 24299);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,17817,24345);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,17817,24345);
}
		}

[Fact]
        public void MethodToAsyncMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,24357,28214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24431,24574);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static Task<int> F() 
    {
        return Task.FromResult(1);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24588,24743);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        return await Task.FromResult(1);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24757,24848);

var 
compilation0 = f_23107_24776_24847(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24862,24914);

var 
compilation1 = f_23107_24881_24913(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24930,24970);

var 
v0 = f_23107_24939_24969(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,24986,28203);
using(var 
md0 = f_23107_25003_25057(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25091,25149);

var 
method0 = f_23107_25105_25148(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25167,25225);

var 
method1 = f_23107_25181_25224(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25245,25324);

var 
generation0 = f_23107_25263_25323(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25342,25525);

var 
diff1 = f_23107_25354_25524(compilation1, generation0, f_23107_25438_25523(SemanticEdit.Create(SemanticEditKind.Update,method0,method1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25545,28188);
using(var 
md1 = f_23107_25562_25581(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,25623,28169);

f_23107_25623_28168(md1.Reader, f_23107_25683_25749(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_25776_25842(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_25869_25929(3, TableIndex.TypeDef, EditAndContinueOperation.Default), f_23107_25956_26017(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_26044_26102(1, TableIndex.Field, EditAndContinueOperation.Default), f_23107_26129_26190(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_26217_26275(2, TableIndex.Field, EditAndContinueOperation.Default), f_23107_26302_26363(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_26390_26448(3, TableIndex.Field, EditAndContinueOperation.Default), f_23107_26475_26536(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_26563_26621(4, TableIndex.Field, EditAndContinueOperation.Default), f_23107_26648_26710(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_26737_26799(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_26826_26888(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_26915_26977(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_27004_27066(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_27093_27155(3, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23107_27182_27244(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_27271_27338(5, TableIndex.MethodDef, EditAndContinueOperation.AddParameter), f_23107_27365_27423(1, TableIndex.Param, EditAndContinueOperation.Default), f_23107_27450_27518(4, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_27545_27613(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_27640_27708(6, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_27735_27803(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_27830_27893(1, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_27920_27983(2, TableIndex.MethodImpl, EditAndContinueOperation.Default), f_23107_28010_28074(1, TableIndex.NestedClass, EditAndContinueOperation.Default), f_23107_28101_28167(1, TableIndex.InterfaceImpl, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,25545,28188);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,24986,28203);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,24357,28214);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_24776_24847(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24776, 24847);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_24881_24913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24881, 24913);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_24939_24969(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 24939, 24969);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_25003_25057(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25003, 25057);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_25105_25148(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25105, 25148);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_25181_25224(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25181, 25224);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_25263_25323(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25263, 25323);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_25438_25523(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25438, 25523);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_25354_25524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25354, 25524);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_25562_25581(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25562, 25581);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_25683_25749(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25683, 25749);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_25776_25842(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25776, 25842);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_25869_25929(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25869, 25929);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_25956_26017(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25956, 26017);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26044_26102(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26044, 26102);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26129_26190(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26129, 26190);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26217_26275(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26217, 26275);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26302_26363(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26302, 26363);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26390_26448(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26390, 26448);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26475_26536(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26475, 26536);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26563_26621(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26563, 26621);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26648_26710(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26648, 26710);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26737_26799(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26737, 26799);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26826_26888(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26826, 26888);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_26915_26977(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 26915, 26977);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27004_27066(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27004, 27066);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27093_27155(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27093, 27155);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27182_27244(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27182, 27244);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27271_27338(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27271, 27338);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27365_27423(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27365, 27423);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27450_27518(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27450, 27518);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27545_27613(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27545, 27613);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27640_27708(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27640, 27708);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27735_27803(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27735, 27803);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27830_27893(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27830, 27893);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_27920_27983(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 27920, 27983);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_28010_28074(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28010, 28074);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_28101_28167(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28101, 28167);
return return_v;
}


int
f_23107_25623_28168(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 25623, 28168);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,24357,28214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,24357,28214);
}
		}

[Fact]
        public void IteratorMethodToMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,28226,29759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28303,28446);

var 
source0 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        yield return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28460,28617);

var 
source1 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        return new int[] { 1, 2, 3 };
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28631,28722);

var 
compilation0 = f_23107_28650_28721(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28736,28788);

var 
compilation1 = f_23107_28755_28787(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28804,28844);

var 
v0 = f_23107_28813_28843(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28860,29748);
using(var 
md0 = f_23107_28877_28931(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,28965,29023);

var 
method0 = f_23107_28979_29022(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29041,29099);

var 
method1 = f_23107_29055_29098(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29119,29198);

var 
generation0 = f_23107_29137_29197(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29216,29399);

var 
diff1 = f_23107_29228_29398(compilation1, generation0, f_23107_29312_29397(SemanticEdit.Create(SemanticEditKind.Update,method0,method1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29419,29733);
using(var 
md1 = f_23107_29436_29455(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29497,29714);

f_23107_29497_29713(md1.Reader, f_23107_29557_29623(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_29650_29712(1, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,29419,29733);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,28860,29748);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,28226,29759);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_28650_28721(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28650, 28721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_28755_28787(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28755, 28787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_28813_28843(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28813, 28843);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_28877_28931(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28877, 28931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_28979_29022(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 28979, 29022);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_29055_29098(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29055, 29098);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_29137_29197(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29137, 29197);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_29312_29397(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29312, 29397);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_29228_29398(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29228, 29398);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_29436_29455(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29436, 29455);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_29557_29623(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29557, 29623);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_29650_29712(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29650, 29712);
return return_v;
}


int
f_23107_29497_29713(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 29497, 29713);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,28226,29759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,28226,29759);
}
		}

[Fact]
        public void AsyncMethodToMethod()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,29771,31299);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,29845,30000);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        return await Task.FromResult(1);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30014,30157);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static Task<int> F() 
    {
        return Task.FromResult(1);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30171,30262);

var 
compilation0 = f_23107_30190_30261(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30276,30328);

var 
compilation1 = f_23107_30295_30327(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30344,30384);

var 
v0 = f_23107_30353_30383(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30400,31288);
using(var 
md0 = f_23107_30417_30471(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30505,30563);

var 
method0 = f_23107_30519_30562(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30581,30639);

var 
method1 = f_23107_30595_30638(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30659,30738);

var 
generation0 = f_23107_30677_30737(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30756,30939);

var 
diff1 = f_23107_30768_30938(compilation1, generation0, f_23107_30852_30937(SemanticEdit.Create(SemanticEditKind.Update,method0,method1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,30959,31273);
using(var 
md1 = f_23107_30976_30995(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,31037,31254);

f_23107_31037_31253(md1.Reader, f_23107_31097_31163(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_31190_31252(1, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,30959,31273);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,30400,31288);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,29771,31299);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_30190_30261(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30190, 30261);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_30295_30327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30295, 30327);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_30353_30383(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30353, 30383);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_30417_30471(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30417, 30471);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_30519_30562(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30519, 30562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_30595_30638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30595, 30638);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_30677_30737(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30677, 30737);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_30852_30937(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30852, 30937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_30768_30938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30768, 30938);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_30976_30995(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 30976, 30995);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_31097_31163(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 31097, 31163);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_31190_31252(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 31190, 31252);
return return_v;
}


int
f_23107_31037_31253(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 31037, 31253);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,29771,31299);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,29771,31299);
}
		}

[Fact]
        public void AsyncMethodOverloads()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,31311,36014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,31386,31741);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F(long a) 
    {
        return await Task.FromResult(1);
    }

    static async Task<int> F(int a) 
    {
        return await Task.FromResult(1);
    }

    static async Task<int> F(short a) 
    {
        return await Task.FromResult(1);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,31755,32110);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F(short a) 
    {
        return await Task.FromResult(2);
    }

    static async Task<int> F(long a) 
    {
        return await Task.FromResult(3);
    }

    static async Task<int> F(int a) 
    {
        return await Task.FromResult(4);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32124,32215);

var 
compilation0 = f_23107_32143_32214(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32229,32281);

var 
compilation1 = f_23107_32248_32280(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32297,32337);

var 
v0 = f_23107_32306_32336(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32353,36003);
using(var 
md0 = f_23107_32370_32424(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32458,32612);

var 
methodShort0 = f_23107_32477_32507(compilation0, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int16 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32630,32784);

var 
methodShort1 = f_23107_32649_32679(compilation1, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int16 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32804,32956);

var 
methodInt0 = f_23107_32821_32851(compilation0, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int32 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,32974,33126);

var 
methodInt1 = f_23107_32991_33021(compilation1, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int32 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,33146,33299);

var 
methodLong0 = f_23107_33164_33194(compilation0, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int64 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,33317,33470);

var 
methodLong1 = f_23107_33335_33365(compilation1, "C.F").Single(m => m.ToTestDisplayString() == "System.Threading.Tasks.Task<System.Int32> C.F(System.Int64 a)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,33490,33569);

var 
generation0 = f_23107_33508_33568(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,33587,34110);

var 
diff1 = f_23107_33599_34109(compilation1, generation0, f_23107_33683_34108(SemanticEdit.Create(SemanticEditKind.Update,methodShort0,methodShort1,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,methodInt0,methodInt1,preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,methodLong0,methodLong1,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,34130,35988);
using(var 
md1 = f_23107_34147_34166(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,34262,35969);

f_23107_34262_35968(md1.Reader, f_23107_34322_34388(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34415_34481(8, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34508_34574(9, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34601_34668(10, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34695_34762(11, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34789_34856(12, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_34883_34945(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_34972_35034(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_35061_35123(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_35150_35212(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_35239_35301(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_35328_35391(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_35418_35487(16, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_35514_35583(17, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_35610_35679(18, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_35706_35775(19, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_35802_35871(20, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_35898_35967(21, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,34130,35988);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,32353,36003);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,31311,36014);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_32143_32214(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32143, 32214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_32248_32280(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32248, 32280);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_32306_32336(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32306, 32336);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_32370_32424(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32370, 32424);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_32477_32507(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32477, 32507);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_32649_32679(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32649, 32679);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_32821_32851(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32821, 32851);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_32991_33021(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 32991, 33021);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_33164_33194(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 33164, 33194);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_33335_33365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 33335, 33365);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_33508_33568(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 33508, 33568);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_33683_34108(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2,Microsoft.CodeAnalysis.Emit.SemanticEdit
item3)
{
var return_v = ImmutableArray.Create( item1, item2, item3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 33683, 34108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_33599_34109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 33599, 34109);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_34147_34166(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34147, 34166);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34322_34388(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34322, 34388);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34415_34481(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34415, 34481);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34508_34574(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34508, 34574);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34601_34668(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34601, 34668);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34695_34762(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34695, 34762);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34789_34856(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34789, 34856);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34883_34945(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34883, 34945);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_34972_35034(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34972, 35034);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35061_35123(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35061, 35123);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35150_35212(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35150, 35212);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35239_35301(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35239, 35301);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35328_35391(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35328, 35391);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35418_35487(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35418, 35487);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35514_35583(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35514, 35583);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35610_35679(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35610, 35679);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35706_35775(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35706, 35775);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35802_35871(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35802, 35871);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_35898_35967(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 35898, 35967);
return return_v;
}


int
f_23107_34262_35968(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 34262, 35968);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,31311,36014);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,31311,36014);
}
		}

[Fact]
        public void UpdateIterator_NoVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,36026,40591);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36107,36250);

var 
source0 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        yield return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36264,36407);

var 
source1 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        yield return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36421,36512);

var 
compilation0 = f_23107_36440_36511(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36526,36578);

var 
compilation1 = f_23107_36545_36577(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36594,36634);

var 
v0 = f_23107_36603_36633(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36650,40580);
using(var 
md0 = f_23107_36667_36721(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36755,36813);

var 
method0 = f_23107_36769_36812(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36831,36889);

var 
method1 = f_23107_36845_36888(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,36909,36988);

var 
generation0 = f_23107_36927_36987(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,37006,37219);

var 
diff1 = f_23107_37018_37218(compilation1, generation0, f_23107_37102_37217(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,37329,37370);

f_23107_37329_37369(
                // only methods with sequence points should be listed in UpdatedMethods:
                diff1, "0x06000005");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,37456,40565);
using(var 
md1 = f_23107_37473_37492(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,37864,38451);

f_23107_37864_38450(md1.Reader, f_23107_37924_37990(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_38017_38079(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_38106_38168(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_38195_38257(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_38284_38353(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_38380_38449(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,38475,39501);

f_23107_38475_39500(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       57 (0x39)
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
  IL_0014:  br.s       IL_0030
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.2
  IL_0022:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0027:  ldarg.0
  IL_0028:  ldc.i4.1
  IL_0029:  stfld      ""int C.<F>d__0.<>1__state""
  IL_002e:  ldc.i4.1
  IL_002f:  ret
  IL_0030:  ldarg.0
  IL_0031:  ldc.i4.m1
  IL_0032:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0037:  ldc.i4.0
  IL_0038:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,39523,40546);

f_23107_39523_40545(                    v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       57 (0x39)
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
  IL_0014:  br.s       IL_0030
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.1
  IL_0022:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0027:  ldarg.0
  IL_0028:  ldc.i4.1
  IL_0029:  stfld      ""int C.<F>d__0.<>1__state""
  IL_002e:  ldc.i4.1
  IL_002f:  ret
  IL_0030:  ldarg.0
  IL_0031:  ldc.i4.m1
  IL_0032:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0037:  ldc.i4.0
  IL_0038:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,37456,40565);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,36650,40580);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,36026,40591);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_36440_36511(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36440, 36511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_36545_36577(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36545, 36577);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_36603_36633(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36603, 36633);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_36667_36721(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36667, 36721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_36769_36812(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36769, 36812);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_36845_36888(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36845, 36888);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_36927_36987(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 36927, 36987);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_37102_37217(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37102, 37217);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_37018_37218(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37018, 37218);
return return_v;
}


int
f_23107_37329_37369(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedMethodTokens)
{
this_param.VerifyUpdatedMethods( expectedMethodTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37329, 37369);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_37473_37492(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37473, 37492);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_37924_37990(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37924, 37990);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_38017_38079(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38017, 38079);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_38106_38168(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38106, 38168);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_38195_38257(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38195, 38257);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_38284_38353(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38284, 38353);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_38380_38449(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38380, 38449);
return return_v;
}


int
f_23107_37864_38450(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 37864, 38450);
return 0;
}


int
f_23107_38475_39500(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 38475, 39500);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_39523_40545(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 39523, 40545);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,36026,40591);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,36026,40591);
}
		}

[Fact]
        public void UpdateAsync_NoVariables()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,40603,51970);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,40681,40871);

var 
source0 = f_23107_40695_40870(@"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        await Task.FromResult(1);
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,40885,41077);

var 
source1 = f_23107_40899_41076(@"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        await Task.FromResult(10);
        return 20;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41091,41182);

var 
compilation0 = f_23107_41110_41181(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41196,41248);

var 
compilation1 = f_23107_41215_41247(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41264,41304);

var 
v0 = f_23107_41273_41303(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41320,51959);
using(var 
md0 = f_23107_41337_41391(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41425,41483);

var 
method0 = f_23107_41439_41482(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41501,41559);

var 
method1 = f_23107_41515_41558(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41579,41658);

var 
generation0 = f_23107_41597_41657(md0, EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41676,41889);

var 
diff1 = f_23107_41688_41888(compilation1, generation0, f_23107_41772_41887(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,41999,42040);

f_23107_41999_42039(
                // only methods with sequence points should be listed in UpdatedMethods:
                diff1, "0x06000004");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,42060,51944);
using(var 
md1 = f_23107_42077_42096(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,42421,43010);

f_23107_42421_43009(md1.Reader, f_23107_42481_42547(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_42574_42640(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_42667_42729(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_42756_42818(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_42845_42913(8, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_42940_43008(9, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,43034,46543);

f_23107_43034_46542(
                    diff1, "C.<F>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      162 (0xa2)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter<int> V_2,
                C.<F>d__0 V_3,
                System.Exception V_4)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_000c
    IL_000a:  br.s       IL_000e
    IL_000c:  br.s       IL_0049
    IL_000e:  nop
    IL_000f:  ldc.i4.s   10
    IL_0011:  call       ""System.Threading.Tasks.Task<int> System.Threading.Tasks.Task.FromResult<int>(int)""
    IL_0016:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<int> System.Threading.Tasks.Task<int>.GetAwaiter()""
    IL_001b:  stloc.2
    IL_001c:  ldloca.s   V_2
    IL_001e:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<int>.IsCompleted.get""
    IL_0023:  brtrue.s   IL_0065
    IL_0025:  ldarg.0
    IL_0026:  ldc.i4.0
    IL_0027:  dup
    IL_0028:  stloc.0
    IL_0029:  stfld      ""int C.<F>d__0.<>1__state""
    IL_002e:  ldarg.0
    IL_002f:  ldloc.2
    IL_0030:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_0035:  ldarg.0
    IL_0036:  stloc.3
    IL_0037:  ldarg.0
    IL_0038:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_003d:  ldloca.s   V_2
    IL_003f:  ldloca.s   V_3
    IL_0041:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<int>, C.<F>d__0>(ref System.Runtime.CompilerServices.TaskAwaiter<int>, ref C.<F>d__0)""
    IL_0046:  nop
    IL_0047:  leave.s    IL_00a1
    IL_0049:  ldarg.0
    IL_004a:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_004f:  stloc.2
    IL_0050:  ldarg.0
    IL_0051:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_0056:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<int>""
    IL_005c:  ldarg.0
    IL_005d:  ldc.i4.m1
    IL_005e:  dup
    IL_005f:  stloc.0
    IL_0060:  stfld      ""int C.<F>d__0.<>1__state""
    IL_0065:  ldloca.s   V_2
    IL_0067:  call       ""int System.Runtime.CompilerServices.TaskAwaiter<int>.GetResult()""
    IL_006c:  pop
    IL_006d:  ldc.i4.s   20
    IL_006f:  stloc.1
    IL_0070:  leave.s    IL_008c
  }
  catch System.Exception
  {
    IL_0072:  stloc.s    V_4
    IL_0074:  ldarg.0
    IL_0075:  ldc.i4.s   -2
    IL_0077:  stfld      ""int C.<F>d__0.<>1__state""
    IL_007c:  ldarg.0
    IL_007d:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_0082:  ldloc.s    V_4
    IL_0084:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_0089:  nop
    IL_008a:  leave.s    IL_00a1
  }
  IL_008c:  ldarg.0
  IL_008d:  ldc.i4.s   -2
  IL_008f:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0094:  ldarg.0
  IL_0095:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
  IL_009a:  ldloc.1
  IL_009b:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_00a0:  nop
  IL_00a1:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,46565,50099);

f_23107_46565_50098(                    v0, "C.<F>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      160 (0xa0)
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
    IL_000a:  br.s       IL_000e
    IL_000c:  br.s       IL_0048
   -IL_000e:  nop
   -IL_000f:  ldc.i4.1
    IL_0010:  call       ""System.Threading.Tasks.Task<int> System.Threading.Tasks.Task.FromResult<int>(int)""
    IL_0015:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<int> System.Threading.Tasks.Task<int>.GetAwaiter()""
    IL_001a:  stloc.2
   ~IL_001b:  ldloca.s   V_2
    IL_001d:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<int>.IsCompleted.get""
    IL_0022:  brtrue.s   IL_0064
    IL_0024:  ldarg.0
    IL_0025:  ldc.i4.0
    IL_0026:  dup
    IL_0027:  stloc.0
    IL_0028:  stfld      ""int C.<F>d__0.<>1__state""
   <IL_002d:  ldarg.0
    IL_002e:  ldloc.2
    IL_002f:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_0034:  ldarg.0
    IL_0035:  stloc.3
    IL_0036:  ldarg.0
    IL_0037:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_003c:  ldloca.s   V_2
    IL_003e:  ldloca.s   V_3
    IL_0040:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<int>, C.<F>d__0>(ref System.Runtime.CompilerServices.TaskAwaiter<int>, ref C.<F>d__0)""
    IL_0045:  nop
    IL_0046:  leave.s    IL_009f
   >IL_0048:  ldarg.0
    IL_0049:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_004e:  stloc.2
    IL_004f:  ldarg.0
    IL_0050:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__0.<>u__1""
    IL_0055:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<int>""
    IL_005b:  ldarg.0
    IL_005c:  ldc.i4.m1
    IL_005d:  dup
    IL_005e:  stloc.0
    IL_005f:  stfld      ""int C.<F>d__0.<>1__state""
    IL_0064:  ldloca.s   V_2
    IL_0066:  call       ""int System.Runtime.CompilerServices.TaskAwaiter<int>.GetResult()""
    IL_006b:  pop
   -IL_006c:  ldc.i4.2
    IL_006d:  stloc.1
    IL_006e:  leave.s    IL_008a
  }
  catch System.Exception
  {
   ~IL_0070:  stloc.s    V_4
    IL_0072:  ldarg.0
    IL_0073:  ldc.i4.s   -2
    IL_0075:  stfld      ""int C.<F>d__0.<>1__state""
    IL_007a:  ldarg.0
    IL_007b:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_0080:  ldloc.s    V_4
    IL_0082:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_0087:  nop
    IL_0088:  leave.s    IL_009f
  }
 -IL_008a:  ldarg.0
  IL_008b:  ldc.i4.s   -2
  IL_008d:  stfld      ""int C.<F>d__0.<>1__state""
 ~IL_0092:  ldarg.0
  IL_0093:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
  IL_0098:  ldloc.1
  IL_0099:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_009e:  nop
  IL_009f:  ret
}", sequencePoints: "C+<F>d__0.MoveNext");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,50123,51925);

f_23107_50123_51924(
                    v0, "C+<F>d__0.MoveNext", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;F&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""20"" offset=""0"" />
          <slot kind=""33"" offset=""11"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" hidden=""true"" document=""1"" />
        <entry offset=""0xe"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0xf"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""34"" document=""1"" />
        <entry offset=""0x1b"" hidden=""true"" document=""1"" />
        <entry offset=""0x6c"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""18"" document=""1"" />
        <entry offset=""0x70"" hidden=""true"" document=""1"" />
        <entry offset=""0x8a"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x92"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xa0"">
        <namespace name=""System.Threading.Tasks"" />
      </scope>
      <asyncInfo>
        <kickoffMethod declaringType=""C"" methodName=""F"" />
        <await yield=""0x2d"" resume=""0x48"" declaringType=""C+&lt;F&gt;d__0"" methodName=""MoveNext"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,42060,51944);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,41320,51959);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,40603,51970);

string
f_23107_40695_40870(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 40695, 40870);
return return_v;
}


string
f_23107_40899_41076(string
source)
{
var return_v = WithWindowsLineBreaks( source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 40899, 41076);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_41110_41181(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41110, 41181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_41215_41247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41215, 41247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_41273_41303(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41273, 41303);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_41337_41391(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41337, 41391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_41439_41482(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41439, 41482);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_41515_41558(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41515, 41558);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_41597_41657(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41597, 41657);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_41772_41887(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41772, 41887);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_41688_41888(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41688, 41888);
return return_v;
}


int
f_23107_41999_42039(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedMethodTokens)
{
this_param.VerifyUpdatedMethods( expectedMethodTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 41999, 42039);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_42077_42096(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42077, 42096);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42481_42547(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42481, 42547);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42574_42640(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42574, 42640);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42667_42729(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42667, 42729);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42756_42818(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42756, 42818);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42845_42913(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42845, 42913);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_42940_43008(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42940, 43008);
return return_v;
}


int
f_23107_42421_43009(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 42421, 43009);
return 0;
}


int
f_23107_43034_46542(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 43034, 46542);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_46565_50098(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL,string
sequencePoints)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL, sequencePoints:sequencePoints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 46565, 50098);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_50123_51924(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier,string
qualifiedMethodName,string
expectedPdb)
{
var return_v = verifier.VerifyPdb( qualifiedMethodName, expectedPdb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 50123, 51924);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,40603,51970);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,40603,51970);
}
		}

[Fact]
        public void UpdateIterator_UserDefinedVariables_NoChange()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,51982,55656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52081,52249);

var 
source0 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int x = p;
        yield return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52263,52431);

var 
source1 = @"
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int x = p;
        yield return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52445,52531);

var 
compilation0 = f_23107_52464_52530(source0, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52545,52597);

var 
compilation1 = f_23107_52564_52596(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52613,52653);

var 
v0 = f_23107_52622_52652(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52667,52704);

var 
symReader = f_23107_52683_52703(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52720,55645);
using(var 
md0 = f_23107_52737_52791(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52825,52883);

var 
method0 = f_23107_52839_52882(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52901,52959);

var 
method1 = f_23107_52915_52958(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,52979,53070);

var 
generation0 = f_23107_52997_53069(md0, symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,53090,53344);

var 
diff1 = f_23107_53102_53343(compilation1, generation0, f_23107_53186_53342(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23107_53271_53310(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,53430,55630);
using(var 
md1 = f_23107_53447_53466(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,53838,54425);

f_23107_53838_54424(md1.Reader, f_23107_53898_53964(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_53991_54053(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_54080_54142(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_54169_54231(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_54258_54327(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_54354_54423(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,54449,55611);

f_23107_54449_55610(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       69 (0x45)
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
  IL_0014:  br.s       IL_003c
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldarg.0
  IL_0022:  ldfld      ""int C.<F>d__0.p""
  IL_0027:  stfld      ""int C.<F>d__0.<x>5__1""
  IL_002c:  ldarg.0
  IL_002d:  ldc.i4.2
  IL_002e:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0033:  ldarg.0
  IL_0034:  ldc.i4.1
  IL_0035:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003a:  ldc.i4.1
  IL_003b:  ret
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.m1
  IL_003e:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0043:  ldc.i4.0
  IL_0044:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,53430,55630);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,52720,55645);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,51982,55656);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_52464_52530(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52464, 52530);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_52564_52596(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52564, 52596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_52622_52652(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52622, 52652);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_52683_52703(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52683, 52703);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_52737_52791(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52737, 52791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_52839_52882(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52839, 52882);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_52915_52958(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52915, 52958);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_52997_53069(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 52997, 53069);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_53271_53310(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53271, 53310);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_53186_53342(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53186, 53342);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_53102_53343(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53102, 53343);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_53447_53466(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53447, 53466);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_53898_53964(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53898, 53964);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_53991_54053(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53991, 54053);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_54080_54142(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 54080, 54142);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_54169_54231(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 54169, 54231);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_54258_54327(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 54258, 54327);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_54354_54423(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 54354, 54423);
return return_v;
}


int
f_23107_53838_54424(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 53838, 54424);
return 0;
}


int
f_23107_54449_55610(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 54449, 55610);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,51982,55656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,51982,55656);
}
		}

[Fact]
        public void UpdateIterator_UserDefinedVariables_AddVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,55668,59633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,55770,55953);

var 
source0 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int x = p;
        yield return x;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,55967,56204);

var 
source1 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int y = 1234;
        int x = p;
        yield return y;
        Console.WriteLine(x);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56218,56304);

var 
compilation0 = f_23107_56237_56303(source0, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56318,56370);

var 
compilation1 = f_23107_56337_56369(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56386,56426);

var 
v0 = f_23107_56395_56425(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56440,56477);

var 
symReader = f_23107_56456_56476(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56493,59622);
using(var 
md0 = f_23107_56510_56564(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56598,56656);

var 
method0 = f_23107_56612_56655(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56674,56732);

var 
method1 = f_23107_56688_56731(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56752,56843);

var 
generation0 = f_23107_56770_56842(md0, symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,56861,57115);

var 
diff1 = f_23107_56873_57114(compilation1, generation0, f_23107_56957_57113(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23107_57042_57081(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,57201,59607);
using(var 
md1 = f_23107_57218_57237(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,57341,58101);

f_23107_57341_58100(md1.Reader, f_23107_57401_57467(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_57494_57555(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_57582_57640(7, TableIndex.Field, EditAndContinueOperation.Default), f_23107_57667_57729(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_57756_57818(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_57845_57907(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_57934_58003(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_58030_58099(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,58125,59588);

f_23107_58125_59587(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       97 (0x61)
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
  IL_0014:  br.s       IL_004c
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4     0x4d2
  IL_0026:  stfld      ""int C.<F>d__0.<y>5__2""
  IL_002b:  ldarg.0
  IL_002c:  ldarg.0
  IL_002d:  ldfld      ""int C.<F>d__0.p""
  IL_0032:  stfld      ""int C.<F>d__0.<x>5__1""
  IL_0037:  ldarg.0
  IL_0038:  ldarg.0
  IL_0039:  ldfld      ""int C.<F>d__0.<y>5__2""
  IL_003e:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0043:  ldarg.0
  IL_0044:  ldc.i4.1
  IL_0045:  stfld      ""int C.<F>d__0.<>1__state""
  IL_004a:  ldc.i4.1
  IL_004b:  ret
  IL_004c:  ldarg.0
  IL_004d:  ldc.i4.m1
  IL_004e:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0053:  ldarg.0
  IL_0054:  ldfld      ""int C.<F>d__0.<x>5__1""
  IL_0059:  call       ""void System.Console.WriteLine(int)""
  IL_005e:  nop
  IL_005f:  ldc.i4.0
  IL_0060:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,57201,59607);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,56493,59622);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,55668,59633);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_56237_56303(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56237, 56303);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_56337_56369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56337, 56369);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_56395_56425(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56395, 56425);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_56456_56476(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56456, 56476);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_56510_56564(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56510, 56564);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_56612_56655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56612, 56655);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_56688_56731(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56688, 56731);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_56770_56842(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56770, 56842);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_57042_57081(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57042, 57081);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_56957_57113(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56957, 57113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_56873_57114(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 56873, 57114);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_57218_57237(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57218, 57237);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57401_57467(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57401, 57467);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57494_57555(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57494, 57555);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57582_57640(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57582, 57640);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57667_57729(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57667, 57729);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57756_57818(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57756, 57818);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57845_57907(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57845, 57907);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_57934_58003(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57934, 58003);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_58030_58099(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 58030, 58099);
return return_v;
}


int
f_23107_57341_58100(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 57341, 58100);
return 0;
}


int
f_23107_58125_59587(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 58125, 59587);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,55668,59633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,55668,59633);
}
		}

[Fact]
        public void UpdateIterator_UserDefinedVariables_AddAndRemoveVariable()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,59645,63457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,59756,59939);

var 
source0 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int x = p;
        yield return x;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,59953,60170);

var 
source1 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F(int p) 
    {
        int y = 1234;
        yield return y;
        Console.WriteLine(p);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60184,60270);

var 
compilation0 = f_23107_60203_60269(source0, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60284,60336);

var 
compilation1 = f_23107_60303_60335(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60352,60392);

var 
v0 = f_23107_60361_60391(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60406,60443);

var 
symReader = f_23107_60422_60442(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60459,63446);
using(var 
md0 = f_23107_60476_60530(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60564,60622);

var 
method0 = f_23107_60578_60621(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60640,60698);

var 
method1 = f_23107_60654_60697(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60718,60809);

var 
generation0 = f_23107_60736_60808(md0, symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,60827,61081);

var 
diff1 = f_23107_60839_61080(compilation1, generation0, f_23107_60923_61079(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23107_61008_61047(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,61167,63431);
using(var 
md1 = f_23107_61184_61203(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,61307,62067);

f_23107_61307_62066(md1.Reader, f_23107_61367_61433(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_61460_61521(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_61548_61606(7, TableIndex.Field, EditAndContinueOperation.Default), f_23107_61633_61695(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_61722_61784(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_61811_61873(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_61900_61969(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_61996_62065(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,62091,63412);

f_23107_62091_63411(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       85 (0x55)
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
  IL_0014:  br.s       IL_0040
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4     0x4d2
  IL_0026:  stfld      ""int C.<F>d__0.<y>5__2""
  IL_002b:  ldarg.0
  IL_002c:  ldarg.0
  IL_002d:  ldfld      ""int C.<F>d__0.<y>5__2""
  IL_0032:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0037:  ldarg.0
  IL_0038:  ldc.i4.1
  IL_0039:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003e:  ldc.i4.1
  IL_003f:  ret
  IL_0040:  ldarg.0
  IL_0041:  ldc.i4.m1
  IL_0042:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0047:  ldarg.0
  IL_0048:  ldfld      ""int C.<F>d__0.p""
  IL_004d:  call       ""void System.Console.WriteLine(int)""
  IL_0052:  nop
  IL_0053:  ldc.i4.0
  IL_0054:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,61167,63431);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,60459,63446);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,59645,63457);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_60203_60269(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60203, 60269);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_60303_60335(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60303, 60335);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_60361_60391(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60361, 60391);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_60422_60442(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60422, 60442);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_60476_60530(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60476, 60530);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_60578_60621(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60578, 60621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_60654_60697(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60654, 60697);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_60736_60808(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60736, 60808);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_61008_61047(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61008, 61047);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_60923_61079(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60923, 61079);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_60839_61080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 60839, 61080);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_61184_61203(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61184, 61203);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61367_61433(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61367, 61433);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61460_61521(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61460, 61521);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61548_61606(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61548, 61606);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61633_61695(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61633, 61695);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61722_61784(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61722, 61784);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61811_61873(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61811, 61873);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61900_61969(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61900, 61969);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_61996_62065(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61996, 62065);
return return_v;
}


int
f_23107_61307_62066(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 61307, 62066);
return 0;
}


int
f_23107_62091_63411(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 62091, 63411);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,59645,63457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,59645,63457);
}
		}

[Fact]
        public void UpdateIterator_UserDefinedVariables_ChangeVariableType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,63469,67261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,63578,63787);

var 
source0 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        var x = 1;
        yield return 1;
        Console.WriteLine(x);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,63801,64012);

var 
source1 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        var x = 1.0;
        yield return 2;
        Console.WriteLine(x);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64026,64112);

var 
compilation0 = f_23107_64045_64111(source0, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64126,64178);

var 
compilation1 = f_23107_64145_64177(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64194,64234);

var 
v0 = f_23107_64203_64233(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64248,64285);

var 
symReader = f_23107_64264_64284(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64301,67250);
using(var 
md0 = f_23107_64318_64372(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64406,64464);

var 
method0 = f_23107_64420_64463(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64482,64540);

var 
method1 = f_23107_64496_64539(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64560,64651);

var 
generation0 = f_23107_64578_64650(md0, symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,64669,64923);

var 
diff1 = f_23107_64681_64922(compilation1, generation0, f_23107_64765_64921(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23107_64850_64889(method1, method0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,65009,67235);
using(var 
md1 = f_23107_65026_65045(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,65149,65909);

f_23107_65149_65908(md1.Reader, f_23107_65209_65275(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_65302_65363(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_65390_65448(5, TableIndex.Field, EditAndContinueOperation.Default), f_23107_65475_65537(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_65564_65626(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_65653_65715(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_65742_65811(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_65838_65907(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,65933,67216);

f_23107_65933_67215(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size       84 (0x54)
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
  IL_0014:  br.s       IL_003f
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.r8     1
  IL_002a:  stfld      ""double C.<F>d__0.<x>5__2""
  IL_002f:  ldarg.0
  IL_0030:  ldc.i4.2
  IL_0031:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0036:  ldarg.0
  IL_0037:  ldc.i4.1
  IL_0038:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003d:  ldc.i4.1
  IL_003e:  ret
  IL_003f:  ldarg.0
  IL_0040:  ldc.i4.m1
  IL_0041:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0046:  ldarg.0
  IL_0047:  ldfld      ""double C.<F>d__0.<x>5__2""
  IL_004c:  call       ""void System.Console.WriteLine(double)""
  IL_0051:  nop
  IL_0052:  ldc.i4.0
  IL_0053:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,65009,67235);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,64301,67250);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,63469,67261);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_64045_64111(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64045, 64111);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_64145_64177(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64145, 64177);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_64203_64233(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64203, 64233);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_64264_64284(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64264, 64284);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_64318_64372(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64318, 64372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_64420_64463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64420, 64463);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_64496_64539(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64496, 64539);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_64578_64650(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64578, 64650);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_64850_64889(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64850, 64889);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_64765_64921(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64765, 64921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_64681_64922(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 64681, 64922);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_65026_65045(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65026, 65045);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65209_65275(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65209, 65275);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65302_65363(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65302, 65363);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65390_65448(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65390, 65448);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65475_65537(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65475, 65537);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65564_65626(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65564, 65626);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65653_65715(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65653, 65715);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65742_65811(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65742, 65811);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_65838_65907(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65838, 65907);
return return_v;
}


int
f_23107_65149_65908(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65149, 65908);
return 0;
}


int
f_23107_65933_67215(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 65933, 67215);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,63469,67261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,63469,67261);
}
		}

[Fact]
        public void UpdateIterator_SynthesizedVariables_ChangeVariableType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,67273,72611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,67382,67581);

var 
source0 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        foreach (object item in new[] { 1 }) { yield return 1; }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,67595,67796);

var 
source1 = @"
using System;
using System.Collections.Generic;

class C
{
    static IEnumerable<int> F() 
    {
        foreach (object item in new[] { 1.0 }) { yield return 1; }
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,67873,68012);

var 
compilation0 = f_23107_67892_68011(source0, options: f_23107_67942_68010(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68026,68078);

var 
compilation1 = f_23107_68045_68077(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68094,68559);

var 
v0 = f_23107_68103_68558(this, compilation0, symbolValidator: module =>
            {
                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>2__current: int",
                    "<>l__initialThreadId: int",
                    "<>s__1: int[]",
                    "<>s__2: int",
                    "<item>5__3: object"
                }, module.GetFieldNamesAndTypes("C.<F>d__0"));
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68575,68612);

var 
symReader = f_23107_68591_68611(v0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68628,72600);
using(var 
md0 = f_23107_68645_68699(v0.EmittedAssemblyData)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68733,68791);

var 
method0 = f_23107_68747_68790(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68809,68867);

var 
method1 = f_23107_68823_68866(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68887,68978);

var 
generation0 = f_23107_68905_68977(md0, symReader.GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,68996,69267);

var 
diff1 = f_23107_69008_69266(compilation1, generation0, f_23107_69092_69265(SemanticEdit.Create(SemanticEditKind.Update,method0,method1,f_23107_69177_69233(method0, SyntaxKind.ForEachStatement),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,69353,72585);
using(var 
md1 = f_23107_69370_69389(diff1)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,69493,70253);

f_23107_69493_70252(md1.Reader, f_23107_69553_69619(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_69646_69707(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_69734_69792(7, TableIndex.Field, EditAndContinueOperation.Default), f_23107_69819_69881(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_69908_69970(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_69997_70059(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_70086_70155(13, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_70182_70251(14, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,70277,72566);

f_23107_70277_72565(
                    diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext", @"
{
  // Code size      161 (0xa1)
  .maxstack  5
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
  IL_0014:  br.s       IL_006b
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  nop
  IL_0021:  ldarg.0
  IL_0022:  ldc.i4.1
  IL_0023:  newarr     ""double""
  IL_0028:  dup
  IL_0029:  ldc.i4.0
  IL_002a:  ldc.r8     1
  IL_0033:  stelem.r8
  IL_0034:  stfld      ""double[] C.<F>d__0.<>s__4""
  IL_0039:  ldarg.0
  IL_003a:  ldc.i4.0
  IL_003b:  stfld      ""int C.<F>d__0.<>s__2""
  IL_0040:  br.s       IL_0088
  IL_0042:  ldarg.0
  IL_0043:  ldarg.0
  IL_0044:  ldfld      ""double[] C.<F>d__0.<>s__4""
  IL_0049:  ldarg.0
  IL_004a:  ldfld      ""int C.<F>d__0.<>s__2""
  IL_004f:  ldelem.r8
  IL_0050:  box        ""double""
  IL_0055:  stfld      ""object C.<F>d__0.<item>5__3""
  IL_005a:  nop
  IL_005b:  ldarg.0
  IL_005c:  ldc.i4.1
  IL_005d:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0062:  ldarg.0
  IL_0063:  ldc.i4.1
  IL_0064:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0069:  ldc.i4.1
  IL_006a:  ret
  IL_006b:  ldarg.0
  IL_006c:  ldc.i4.m1
  IL_006d:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0072:  nop
  IL_0073:  ldarg.0
  IL_0074:  ldnull
  IL_0075:  stfld      ""object C.<F>d__0.<item>5__3""
  IL_007a:  ldarg.0
  IL_007b:  ldarg.0
  IL_007c:  ldfld      ""int C.<F>d__0.<>s__2""
  IL_0081:  ldc.i4.1
  IL_0082:  add
  IL_0083:  stfld      ""int C.<F>d__0.<>s__2""
  IL_0088:  ldarg.0
  IL_0089:  ldfld      ""int C.<F>d__0.<>s__2""
  IL_008e:  ldarg.0
  IL_008f:  ldfld      ""double[] C.<F>d__0.<>s__4""
  IL_0094:  ldlen
  IL_0095:  conv.i4
  IL_0096:  blt.s      IL_0042
  IL_0098:  ldarg.0
  IL_0099:  ldnull
  IL_009a:  stfld      ""double[] C.<F>d__0.<>s__4""
  IL_009f:  ldc.i4.0
  IL_00a0:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,69353,72585);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23107,68628,72600);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,67273,72611);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_67942_68010(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 67942, 68010);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_67892_68011(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 67892, 68011);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_68045_68077(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68045, 68077);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_68103_68558(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68103, 68558);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_68591_68611(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68591, 68611);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_68645_68699(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68645, 68699);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_68747_68790(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68747, 68790);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_68823_68866(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68823, 68866);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_68905_68977(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 68905, 68977);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_69177_69233(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69177, 69233);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_69092_69265(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69092, 69265);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_69008_69266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69008, 69266);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_69370_69389(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69370, 69389);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69553_69619(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69553, 69619);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69646_69707(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69646, 69707);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69734_69792(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69734, 69792);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69819_69881(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69819, 69881);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69908_69970(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69908, 69970);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_69997_70059(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69997, 70059);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_70086_70155(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 70086, 70155);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_70182_70251(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 70182, 70251);
return return_v;
}


int
f_23107_69493_70252(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 69493, 70252);
return 0;
}


int
f_23107_70277_72565(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 70277, 72565);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,67273,72611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,67273,72611);
}
		}

[Fact]
        public void HoistedVariables_MultipleGenerations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,72623,90759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,72714,73297);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() // testing type changes G0 -> G1, G1 -> G2
    {
        bool a1 = true; 
        int a2 = 3;
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> G() // testing G1 -> G3
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> H() // testing G0 -> G3
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,73311,73836);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() // updated 
    {
        C a1 = new C(); 
        int a2 = 3;
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> G() // updated 
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 2;
    }

    static async Task<int> H() 
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,73850,74367);

var 
source2 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F()  // updated
    {
        bool a1 = true; 
        C a2 = new C();
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> G()
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 2;
    }

    static async Task<int> H() 
    {
        C c = new C();
        bool a1 = true;
        await Task.Delay(0);
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,74381,74908);

var 
source3 = @"
using System.Threading.Tasks;

class C
{
    static async Task<int> F() 
    {
        bool a1 = true; 
        C a2 = new C();
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> G() // updated
    {
        C c = new C();
        C a1 = new C();
        await Task.Delay(0);
        return 1;
    }

    static async Task<int> H() // updated
    {
        C c = new C();
        C a1 = new C();
        await Task.Delay(0);
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,74987,75126);

var 
compilation0 = f_23107_75006_75125(source0, options: f_23107_75056_75124(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75140,75192);

var 
compilation1 = f_23107_75159_75191(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75206,75258);

var 
compilation2 = f_23107_75225_75257(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75272,75324);

var 
compilation3 = f_23107_75291_75323(compilation2, source3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75340,75393);

var 
f0 = f_23107_75349_75392(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75407,75460);

var 
f1 = f_23107_75416_75459(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75474,75527);

var 
f2 = f_23107_75483_75526(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75541,75594);

var 
f3 = f_23107_75550_75593(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75610,75663);

var 
g0 = f_23107_75619_75662(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75677,75730);

var 
g1 = f_23107_75686_75729(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75744,75797);

var 
g2 = f_23107_75753_75796(compilation2, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75811,75864);

var 
g3 = f_23107_75820_75863(compilation3, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75880,75933);

var 
h0 = f_23107_75889_75932(compilation0, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,75947,76000);

var 
h1 = f_23107_75956_75999(compilation1, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76014,76067);

var 
h2 = f_23107_76023_76066(compilation2, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76081,76134);

var 
h3 = f_23107_76090_76133(compilation3, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76150,76657);

var 
v0 = f_23107_76159_76656(this, compilation0, symbolValidator: module =>
            {
                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>",
                    "<a1>5__1: bool",
                    "<a2>5__2: int",
                    "<>u__1: System.Runtime.CompilerServices.TaskAwaiter"
                }, module.GetFieldNamesAndTypes("C.<F>d__0"));
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76673,76738);

var 
md0 = f_23107_76683_76737(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76754,76856);

var 
generation0 = f_23107_76772_76855(md0, f_23107_76812_76832(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,76870,77254);

var 
diff1 = f_23107_76882_77253(compilation1, generation0, f_23107_76958_77252(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_77055_77084(f1, f0),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,g0,g1,f_23107_77191_77220(g1, g0),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,77270,77569);

f_23107_77270_77568(
            diff1, "C: {<F>d__0, <G>d__1}", "C.<F>d__0: {<>1__state, <>t__builder, <a1>5__3, <a2>5__2, <>u__1, MoveNext, SetStateMachine}", "C.<G>d__1: {<>1__state, <>t__builder, <c>5__1, <a1>5__2, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,77585,77842);

var 
diff2 = f_23107_77597_77841(compilation2, f_23107_77643_77663(diff1), f_23107_77682_77840(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_77779_77808(f2, f1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,77858,78177);

f_23107_77858_78176(
            diff2, "C: {<F>d__0, <G>d__1}", "C.<F>d__0: {<>1__state, <>t__builder, <a1>5__4, <a2>5__5, <>u__1, MoveNext, SetStateMachine, <a1>5__3, <a2>5__2}", "C.<G>d__1: {<>1__state, <>t__builder, <c>5__1, <a1>5__2, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,78193,78586);

var 
diff3 = f_23107_78205_78585(compilation3, f_23107_78251_78271(diff2), f_23107_78290_78584(SemanticEdit.Create(SemanticEditKind.Update,g2,g3,f_23107_78387_78416(g3, g2),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,h2,h3,f_23107_78523_78552(h3, h2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,78602,79052);

f_23107_78602_79051(
            diff3, "C: {<G>d__1, <H>d__2, <F>d__0}", "C.<F>d__0: {<>1__state, <>t__builder, <a1>5__4, <a2>5__5, <>u__1, MoveNext, SetStateMachine, <a1>5__3, <a2>5__2}", "C.<G>d__1: {<>1__state, <>t__builder, <c>5__1, <a1>5__3, <>u__1, MoveNext, SetStateMachine, <a1>5__2}", "C.<H>d__2: {<>1__state, <>t__builder, <c>5__1, <a1>5__3, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,79130,79160);

var 
md1 = f_23107_79140_79159(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,79174,79204);

var 
md2 = f_23107_79184_79203(diff2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,79218,79248);

var 
md3 = f_23107_79228_79247(diff3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,79353,80563);

f_23107_79353_80562(md1.Reader, f_23107_79405_79471(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_79490_79556(8, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_79575_79641(9, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_79660_79727(10, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_79746_79807(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_79826_79885(16, TableIndex.Field, EditAndContinueOperation.Default), f_23107_79904_79966(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_79985_80047(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_80066_80128(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_80147_80209(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_80228_80297(16, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_80316_80385(17, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_80404_80473(18, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_80492_80561(19, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,80579,84409);

f_23107_80579_84408(
            diff1, "C.<F>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      192 (0xc0)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter V_2,
                C.<F>d__0 V_3,
                System.Exception V_4)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_000c
    IL_000a:  br.s       IL_000e
    IL_000c:  br.s       IL_005a
    IL_000e:  nop
    IL_000f:  ldarg.0
    IL_0010:  newobj     ""C..ctor()""
    IL_0015:  stfld      ""C C.<F>d__0.<a1>5__3""
    IL_001a:  ldarg.0
    IL_001b:  ldc.i4.3
    IL_001c:  stfld      ""int C.<F>d__0.<a2>5__2""
    IL_0021:  ldc.i4.0
    IL_0022:  call       ""System.Threading.Tasks.Task System.Threading.Tasks.Task.Delay(int)""
    IL_0027:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter System.Threading.Tasks.Task.GetAwaiter()""
    IL_002c:  stloc.2
    IL_002d:  ldloca.s   V_2
    IL_002f:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter.IsCompleted.get""
    IL_0034:  brtrue.s   IL_0076
    IL_0036:  ldarg.0
    IL_0037:  ldc.i4.0
    IL_0038:  dup
    IL_0039:  stloc.0
    IL_003a:  stfld      ""int C.<F>d__0.<>1__state""
    IL_003f:  ldarg.0
    IL_0040:  ldloc.2
    IL_0041:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0046:  ldarg.0
    IL_0047:  stloc.3
    IL_0048:  ldarg.0
    IL_0049:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_004e:  ldloca.s   V_2
    IL_0050:  ldloca.s   V_3
    IL_0052:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter, C.<F>d__0>(ref System.Runtime.CompilerServices.TaskAwaiter, ref C.<F>d__0)""
    IL_0057:  nop
    IL_0058:  leave.s    IL_00bf
    IL_005a:  ldarg.0
    IL_005b:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0060:  stloc.2
    IL_0061:  ldarg.0
    IL_0062:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0067:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter""
    IL_006d:  ldarg.0
    IL_006e:  ldc.i4.m1
    IL_006f:  dup
    IL_0070:  stloc.0
    IL_0071:  stfld      ""int C.<F>d__0.<>1__state""
    IL_0076:  ldloca.s   V_2
    IL_0078:  call       ""void System.Runtime.CompilerServices.TaskAwaiter.GetResult()""
    IL_007d:  nop
    IL_007e:  ldc.i4.1
    IL_007f:  stloc.1
    IL_0080:  leave.s    IL_00a3
  }
  catch System.Exception
  {
    IL_0082:  stloc.s    V_4
    IL_0084:  ldarg.0
    IL_0085:  ldc.i4.s   -2
    IL_0087:  stfld      ""int C.<F>d__0.<>1__state""
    IL_008c:  ldarg.0
    IL_008d:  ldnull
    IL_008e:  stfld      ""C C.<F>d__0.<a1>5__3""
    IL_0093:  ldarg.0
    IL_0094:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_0099:  ldloc.s    V_4
    IL_009b:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_00a0:  nop
    IL_00a1:  leave.s    IL_00bf
  }
  IL_00a3:  ldarg.0
  IL_00a4:  ldc.i4.s   -2
  IL_00a6:  stfld      ""int C.<F>d__0.<>1__state""
  IL_00ab:  ldarg.0
  IL_00ac:  ldnull
  IL_00ad:  stfld      ""C C.<F>d__0.<a1>5__3""
  IL_00b2:  ldarg.0
  IL_00b3:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
  IL_00b8:  ldloc.1
  IL_00b9:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_00be:  nop
  IL_00bf:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,84530,85391);

f_23107_84530_85390(md2.Reader, f_23107_84582_84649(11, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_84668_84735(12, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_84754_84815(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_84834_84893(17, TableIndex.Field, EditAndContinueOperation.Default), f_23107_84912_84973(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_84992_85051(18, TableIndex.Field, EditAndContinueOperation.Default), f_23107_85070_85132(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_85151_85213(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_85232_85301(20, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_85320_85389(21, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,85407,89238);

f_23107_85407_89237(
            diff2, "C.<F>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      192 (0xc0)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter V_2,
                C.<F>d__0 V_3,
                System.Exception V_4)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_000c
    IL_000a:  br.s       IL_000e
    IL_000c:  br.s       IL_005a
    IL_000e:  nop
    IL_000f:  ldarg.0
    IL_0010:  ldc.i4.1
    IL_0011:  stfld      ""bool C.<F>d__0.<a1>5__4""
    IL_0016:  ldarg.0
    IL_0017:  newobj     ""C..ctor()""
    IL_001c:  stfld      ""C C.<F>d__0.<a2>5__5""
    IL_0021:  ldc.i4.0
    IL_0022:  call       ""System.Threading.Tasks.Task System.Threading.Tasks.Task.Delay(int)""
    IL_0027:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter System.Threading.Tasks.Task.GetAwaiter()""
    IL_002c:  stloc.2
    IL_002d:  ldloca.s   V_2
    IL_002f:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter.IsCompleted.get""
    IL_0034:  brtrue.s   IL_0076
    IL_0036:  ldarg.0
    IL_0037:  ldc.i4.0
    IL_0038:  dup
    IL_0039:  stloc.0
    IL_003a:  stfld      ""int C.<F>d__0.<>1__state""
    IL_003f:  ldarg.0
    IL_0040:  ldloc.2
    IL_0041:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0046:  ldarg.0
    IL_0047:  stloc.3
    IL_0048:  ldarg.0
    IL_0049:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_004e:  ldloca.s   V_2
    IL_0050:  ldloca.s   V_3
    IL_0052:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter, C.<F>d__0>(ref System.Runtime.CompilerServices.TaskAwaiter, ref C.<F>d__0)""
    IL_0057:  nop
    IL_0058:  leave.s    IL_00bf
    IL_005a:  ldarg.0
    IL_005b:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0060:  stloc.2
    IL_0061:  ldarg.0
    IL_0062:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter C.<F>d__0.<>u__1""
    IL_0067:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter""
    IL_006d:  ldarg.0
    IL_006e:  ldc.i4.m1
    IL_006f:  dup
    IL_0070:  stloc.0
    IL_0071:  stfld      ""int C.<F>d__0.<>1__state""
    IL_0076:  ldloca.s   V_2
    IL_0078:  call       ""void System.Runtime.CompilerServices.TaskAwaiter.GetResult()""
    IL_007d:  nop
    IL_007e:  ldc.i4.1
    IL_007f:  stloc.1
    IL_0080:  leave.s    IL_00a3
  }
  catch System.Exception
  {
    IL_0082:  stloc.s    V_4
    IL_0084:  ldarg.0
    IL_0085:  ldc.i4.s   -2
    IL_0087:  stfld      ""int C.<F>d__0.<>1__state""
    IL_008c:  ldarg.0
    IL_008d:  ldnull
    IL_008e:  stfld      ""C C.<F>d__0.<a2>5__5""
    IL_0093:  ldarg.0
    IL_0094:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
    IL_0099:  ldloc.s    V_4
    IL_009b:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_00a0:  nop
    IL_00a1:  leave.s    IL_00bf
  }
  IL_00a3:  ldarg.0
  IL_00a4:  ldc.i4.s   -2
  IL_00a6:  stfld      ""int C.<F>d__0.<>1__state""
  IL_00ab:  ldarg.0
  IL_00ac:  ldnull
  IL_00ad:  stfld      ""C C.<F>d__0.<a2>5__5""
  IL_00b2:  ldarg.0
  IL_00b3:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__0.<>t__builder""
  IL_00b8:  ldloc.1
  IL_00b9:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_00be:  nop
  IL_00bf:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,89376,90748);

f_23107_89376_90747(md3.Reader, f_23107_89428_89495(13, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_89514_89581(14, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_89600_89667(15, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_89686_89753(16, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_89772_89833(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_89852_89911(19, TableIndex.Field, EditAndContinueOperation.Default), f_23107_89930_89991(5, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_90010_90069(20, TableIndex.Field, EditAndContinueOperation.Default), f_23107_90088_90150(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_90169_90231(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_90250_90312(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_90331_90394(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_90413_90482(22, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_90501_90570(23, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_90589_90658(24, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_90677_90746(25, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,72623,90759);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_75056_75124(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75056, 75124);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_75006_75125(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75006, 75125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_75159_75191(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75159, 75191);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_75225_75257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75225, 75257);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_75291_75323(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75291, 75323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75349_75392(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75349, 75392);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75416_75459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75416, 75459);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75483_75526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75483, 75526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75550_75593(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75550, 75593);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75619_75662(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75619, 75662);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75686_75729(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75686, 75729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75753_75796(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75753, 75796);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75820_75863(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75820, 75863);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75889_75932(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75889, 75932);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_75956_75999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 75956, 75999);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_76023_76066(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76023, 76066);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_76090_76133(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76090, 76133);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_76159_76656(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76159, 76656);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_76683_76737(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76683, 76737);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_76812_76832(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76812, 76832);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_76772_76855(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76772, 76855);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_77055_77084(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77055, 77084);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_77191_77220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77191, 77220);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_76958_77252(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76958, 77252);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_76882_77253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 76882, 77253);
return return_v;
}


int
f_23107_77270_77568(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77270, 77568);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_77643_77663(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 77643, 77663);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_77779_77808(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77779, 77808);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_77682_77840(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77682, 77840);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_77597_77841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77597, 77841);
return return_v;
}


int
f_23107_77858_78176(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 77858, 78176);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_78251_78271(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 78251, 78271);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_78387_78416(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 78387, 78416);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_78523_78552(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method1,Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0)
{
var return_v = GetEquivalentNodesMap( method1, method0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 78523, 78552);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_78290_78584(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 78290, 78584);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_78205_78585(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 78205, 78585);
return return_v;
}


int
f_23107_78602_79051(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 78602, 79051);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_79140_79159(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79140, 79159);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_79184_79203(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79184, 79203);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_79228_79247(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79228, 79247);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79405_79471(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79405, 79471);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79490_79556(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79490, 79556);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79575_79641(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79575, 79641);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79660_79727(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79660, 79727);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79746_79807(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79746, 79807);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79826_79885(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79826, 79885);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79904_79966(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79904, 79966);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_79985_80047(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79985, 80047);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80066_80128(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80066, 80128);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80147_80209(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80147, 80209);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80228_80297(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80228, 80297);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80316_80385(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80316, 80385);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80404_80473(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80404, 80473);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_80492_80561(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80492, 80561);
return return_v;
}


int
f_23107_79353_80562(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 79353, 80562);
return 0;
}


int
f_23107_80579_84408(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 80579, 84408);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84582_84649(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84582, 84649);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84668_84735(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84668, 84735);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84754_84815(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84754, 84815);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84834_84893(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84834, 84893);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84912_84973(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84912, 84973);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_84992_85051(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84992, 85051);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_85070_85132(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 85070, 85132);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_85151_85213(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 85151, 85213);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_85232_85301(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 85232, 85301);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_85320_85389(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 85320, 85389);
return return_v;
}


int
f_23107_84530_85390(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 84530, 85390);
return 0;
}


int
f_23107_85407_89237(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 85407, 89237);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89428_89495(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89428, 89495);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89514_89581(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89514, 89581);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89600_89667(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89600, 89667);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89686_89753(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89686, 89753);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89772_89833(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89772, 89833);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89852_89911(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89852, 89911);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_89930_89991(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89930, 89991);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90010_90069(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90010, 90069);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90088_90150(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90088, 90150);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90169_90231(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90169, 90231);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90250_90312(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90250, 90312);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90331_90394(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90331, 90394);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90413_90482(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90413, 90482);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90501_90570(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90501, 90570);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90589_90658(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90589, 90658);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_90677_90746(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 90677, 90746);
return return_v;
}


int
f_23107_89376_90747(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 89376, 90747);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,72623,90759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,72623,90759);
}
		}

[Fact]
        public void HoistedVariables_Dynamic1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,90771,100786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,90851,91094);

var 
template = @"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        dynamic <N:0>x = 1</N:0>;
        yield return 1;
        Console.WriteLine((int)x + <<VALUE>>);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91108,91171);

var 
source0 = f_23107_91122_91170(f_23107_91135_91169(template, "<<VALUE>>", "0"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91185,91248);

var 
source1 = f_23107_91199_91247(f_23107_91212_91246(template, "<<VALUE>>", "1"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91262,91325);

var 
source2 = f_23107_91276_91324(f_23107_91289_91323(template, "<<VALUE>>", "2"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91341,91478);

var 
compilation0 = f_23107_91360_91477(new[] { source0.Tree }, new[] { f_23107_91424_91437(), f_23107_91439_91448()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91492,91549);

var 
compilation1 = f_23107_91511_91548(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91563,91620);

var 
compilation2 = f_23107_91582_91619(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91636,91676);

var 
v0 = f_23107_91645_91675(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91690,91713);

f_23107_91690_91712(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91727,91792);

var 
md0 = f_23107_91737_91791(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91808,91861);

var 
f0 = f_23107_91817_91860(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91875,91928);

var 
f1 = f_23107_91884_91927(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,91942,91995);

var 
f2 = f_23107_91951_91994(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,92011,92113);

var 
generation0 = f_23107_92029_92112(md0, f_23107_92069_92089(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,92129,95220);

var 
baselineIL0 = @"
{
  // Code size      147 (0x93)
  .maxstack  3
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
  IL_0014:  br.s       IL_003c
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.1
  IL_0022:  box        ""int""
  IL_0027:  stfld      ""dynamic C.<F>d__0.<x>5__1""
  IL_002c:  ldarg.0
  IL_002d:  ldc.i4.1
  IL_002e:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0033:  ldarg.0
  IL_0034:  ldc.i4.1
  IL_0035:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003a:  ldc.i4.1
  IL_003b:  ret
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.m1
  IL_003e:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0043:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<>o__0.<>p__0""
  IL_0048:  brfalse.s  IL_004c
  IL_004a:  br.s       IL_0071
  IL_004c:  ldc.i4.s   16
  IL_004e:  ldtoken    ""int""
  IL_0053:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0058:  ldtoken    ""C""
  IL_005d:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0062:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_0067:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_006c:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<>o__0.<>p__0""
  IL_0071:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<>o__0.<>p__0""
  IL_0076:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>>.Target""
  IL_007b:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<>o__0.<>p__0""
  IL_0080:  ldarg.0
  IL_0081:  ldfld      ""dynamic C.<F>d__0.<x>5__1""
  IL_0086:  callvirt   ""int System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_008b:  call       ""void System.Console.WriteLine(int)""
  IL_0090:  nop
  IL_0091:  ldc.i4.0
  IL_0092:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,95234,95314);

f_23107_95234_95313(            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", baselineIL0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,95330,95590);

var 
diff1 = f_23107_95342_95589(compilation1, generation0, f_23107_95418_95588(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_95515_95556(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,95606,98823);

var 
baselineIL = @"
{
  // Code size      149 (0x95)
  .maxstack  3
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
  IL_0014:  br.s       IL_003c
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.1
  IL_0022:  box        ""int""
  IL_0027:  stfld      ""dynamic C.<F>d__0.<x>5__1""
  IL_002c:  ldarg.0
  IL_002d:  ldc.i4.1
  IL_002e:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0033:  ldarg.0
  IL_0034:  ldc.i4.1
  IL_0035:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003a:  ldc.i4.1
  IL_003b:  ret
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.m1
  IL_003e:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0043:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<<DYNAMIC_CONTAINER_NAME>>.<>p__0""
  IL_0048:  brfalse.s  IL_004c
  IL_004a:  br.s       IL_0071
  IL_004c:  ldc.i4.s   16
  IL_004e:  ldtoken    ""int""
  IL_0053:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0058:  ldtoken    ""C""
  IL_005d:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0062:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_0067:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_006c:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<<DYNAMIC_CONTAINER_NAME>>.<>p__0""
  IL_0071:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<<DYNAMIC_CONTAINER_NAME>>.<>p__0""
  IL_0076:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>>.Target""
  IL_007b:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>> C.<<DYNAMIC_CONTAINER_NAME>>.<>p__0""
  IL_0080:  ldarg.0
  IL_0081:  ldfld      ""dynamic C.<F>d__0.<x>5__1""
  IL_0086:  callvirt   ""int System.Func<System.Runtime.CompilerServices.CallSite, dynamic, int>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_008b:  ldc.i4.<<VALUE>>
  IL_008c:  add
  IL_008d:  call       ""void System.Console.WriteLine(int)""
  IL_0092:  nop
  IL_0093:  ldc.i4.0
  IL_0094:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,98839,99457);

f_23107_98839_99456(
            diff1, "C: {<>o__0#1, <F>d__0}", "C.<>o__0#1: {<>p__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,99473,99631);

f_23107_99473_99630(
            diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_99543_99629(f_23107_99543_99579(baselineIL, "<<VALUE>>", "1"), "<<DYNAMIC_CONTAINER_NAME>>", "<>o__0#1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,99647,99916);

var 
diff2 = f_23107_99659_99915(compilation2, f_23107_99705_99725(diff1), f_23107_99744_99914(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_99841_99882(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,99932,100601);

f_23107_99932_100600(
            diff2, "C: {<>o__0#2, <F>d__0, <>o__0#1}", "C.<>o__0#1: {<>p__0}", "C.<>o__0#2: {<>p__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,100617,100775);

f_23107_100617_100774(
            diff2, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_100687_100773(f_23107_100687_100723(baselineIL, "<<VALUE>>", "2"), "<<DYNAMIC_CONTAINER_NAME>>", "<>o__0#2"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,90771,100786);

string
f_23107_91135_91169(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91135, 91169);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_91122_91170(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91122, 91170);
return return_v;
}


string
f_23107_91212_91246(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91212, 91246);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_91199_91247(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91199, 91247);
return return_v;
}


string
f_23107_91289_91323(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91289, 91323);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_91276_91324(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91276, 91324);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_91424_91437()
{
var return_v = SystemCoreRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 91424, 91437);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_91439_91448()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 91439, 91448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_91360_91477(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91360, 91477);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_91511_91548(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91511, 91548);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_91582_91619(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91582, 91619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_91645_91675(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91645, 91675);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_91690_91712(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91690, 91712);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_91737_91791(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91737, 91791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_91817_91860(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91817, 91860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_91884_91927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91884, 91927);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_91951_91994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 91951, 91994);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_92069_92089(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 92069, 92089);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_92029_92112(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 92029, 92112);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_95234_95313(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 95234, 95313);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_95515_95556(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 95515, 95556);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_95418_95588(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 95418, 95588);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_95342_95589(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 95342, 95589);
return return_v;
}


int
f_23107_98839_99456(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 98839, 99456);
return 0;
}


string
f_23107_99543_99579(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99543, 99579);
return return_v;
}


string
f_23107_99543_99629(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99543, 99629);
return return_v;
}


int
f_23107_99473_99630(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99473, 99630);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_99705_99725(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 99705, 99725);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_99841_99882(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99841, 99882);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_99744_99914(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99744, 99914);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_99659_99915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99659, 99915);
return return_v;
}


int
f_23107_99932_100600(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 99932, 100600);
return 0;
}


string
f_23107_100687_100723(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 100687, 100723);
return return_v;
}


string
f_23107_100687_100773(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 100687, 100773);
return return_v;
}


int
f_23107_100617_100774(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 100617, 100774);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,90771,100786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,90771,100786);
}
		}

[Fact]
        public void HoistedVariables_Dynamic2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,100798,104362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,100878,101132);

var 
source0 = f_23107_100892_101131(@"
using System;
using System.Collections.Generic;

class C
{
    private static IEnumerable<string> F()
    {
        dynamic <N:0>d = ""x""</N:0>;
        yield return d;
        Console.WriteLine(0);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101146,101411);

var 
source1 = f_23107_101160_101410(@"
using System;
using System.Collections.Generic;

class C
{
    private static IEnumerable<string> F()
    {
        dynamic <N:0>d = ""x""</N:0>;
        yield return d.ToString();
        Console.WriteLine(1);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101425,101679);

var 
source2 = f_23107_101439_101678(@"
using System;
using System.Collections.Generic;

class C
{
    private static IEnumerable<string> F()
    {
        dynamic <N:0>d = ""x""</N:0>;
        yield return d;
        Console.WriteLine(2);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101693,101830);

var 
compilation0 = f_23107_101712_101829(new[] { source0.Tree }, new[] { f_23107_101776_101789(), f_23107_101791_101800()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101844,101901);

var 
compilation1 = f_23107_101863_101900(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101915,101972);

var 
compilation2 = f_23107_101934_101971(compilation0, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,101988,102028);

var 
v0 = f_23107_101997_102027(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102042,102065);

f_23107_102042_102064(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102079,102144);

var 
md0 = f_23107_102089_102143(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102160,102213);

var 
f0 = f_23107_102169_102212(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102227,102280);

var 
f1 = f_23107_102236_102279(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102294,102347);

var 
f2 = f_23107_102303_102346(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102363,102465);

var 
generation0 = f_23107_102381_102464(md0, f_23107_102421_102441(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102481,102744);

var 
diff1 = f_23107_102493_102743(compilation1, generation0, f_23107_102571_102742(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_102669_102710(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,102760,103378);

f_23107_102760_103377(
            diff1, "C: {<>o__0#1, <F>d__0}", "C.<>o__0#1: {<>p__0, <>p__1}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <d>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.String>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.String>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.String>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,103394,103666);

var 
diff2 = f_23107_103406_103665(compilation2, f_23107_103453_103473(diff1), f_23107_103493_103664(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_103591_103632(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,103682,104351);

f_23107_103682_104350(
            diff2, "C: {<>o__0#2, <F>d__0, <>o__0#1}", "C.<>o__0#1: {<>p__0, <>p__1}", "C.<>o__0#2: {<>p__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <d>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.String>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.String>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.String>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,100798,104362);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_100892_101131(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 100892, 101131);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_101160_101410(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101160, 101410);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_101439_101678(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101439, 101678);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_101776_101789()
{
var return_v = SystemCoreRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 101776, 101789);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_101791_101800()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 101791, 101800);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_101712_101829(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101712, 101829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_101863_101900(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101863, 101900);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_101934_101971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101934, 101971);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_101997_102027(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 101997, 102027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_102042_102064(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102042, 102064);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_102089_102143(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102089, 102143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_102169_102212(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102169, 102212);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_102236_102279(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102236, 102279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_102303_102346(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102303, 102346);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_102421_102441(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102421, 102441);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_102381_102464(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102381, 102464);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_102669_102710(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102669, 102710);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_102571_102742(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102571, 102742);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_102493_102743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102493, 102743);
return return_v;
}


int
f_23107_102760_103377(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 102760, 103377);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_103453_103473(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 103453, 103473);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_103591_103632(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 103591, 103632);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_103493_103664(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 103493, 103664);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_103406_103665(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 103406, 103665);
return return_v;
}


int
f_23107_103682_104350(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 103682, 104350);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,100798,104362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,100798,104362);
}
		}

[Fact]
        public void Awaiters1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,104374,105947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,104438,104838);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<double> A3() => null;

    static async Task<int> F() 
    {
        await A1(); 
        await A2();
        return 1;
    }

    static async Task<int> G() 
    {
        await A2(); 
        await A1();
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,104852,104991);

var 
compilation0 = f_23107_104871_104990(source0, options: f_23107_104921_104989(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,105007,105936);

f_23107_105007_105935(this, compilation0, symbolValidator: module =>
            {
                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>",
                    "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<bool>",
                    "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<int>"
                }, module.GetFieldNamesAndTypes("C.<F>d__3"));

                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>",
                    "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<int>",
                    "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<bool>"
                }, module.GetFieldNamesAndTypes("C.<G>d__4"));
            });
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,104374,105947);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_104921_104989(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 104921, 104989);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_104871_104990(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 104871, 104990);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_105007_105935(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 105007, 105935);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,104374,105947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,104374,105947);
}
		}

[Fact]
        public void Awaiters_MultipleGenerations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,105959,127140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,106042,106584);

var 
source0 = @"
using System.Threading.Tasks;

class C
{
    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<C> A3() => null;

    static async Task<int> F() // testing type changes G0 -> G1, G1 -> G2
    {
        await A1(); 
        await A2();
        return 1;
    }

    static async Task<int> G() // testing G1 -> G3
    {
        await A1();
        return 1;
    }

    static async Task<int> H() // testing G0 -> G3
    {
        await A1();
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,106598,107082);

var 
source1 = @"
using System.Threading.Tasks;

class C
{
    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<C> A3() => null;

    static async Task<int> F() // updated 
    {
        await A3(); 
        await A2();
        return 1;
    }

    static async Task<int> G() // updated 
    {
        await A1();
        return 2;
    }

    static async Task<int> H() 
    {
        await A1();
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,107096,107568);

var 
source2 = @"
using System.Threading.Tasks;

class C
{
    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<C> A3() => null;

    static async Task<int> F()  // updated
    {
        await A1(); 
        await A3();
        return 1;
    }

    static async Task<int> G()
    {
        await A1();
        return 2;
    }

    static async Task<int> H() 
    {
        await A1();
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,107582,108064);

var 
source3 = @"
using System.Threading.Tasks;

class C
{
    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<C> A3() => null;

    static async Task<int> F() 
    {
        await A1(); 
        await A3();
        return 1;
    }

    static async Task<int> G() // updated
    {
        await A3();
        return 1;
    }

    static async Task<int> H() // updated
    {
        await A3();
        return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108143,108301);

var 
compilation0 = f_23107_108162_108300(source0, options: f_23107_108212_108280(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108315,108367);

var 
compilation1 = f_23107_108334_108366(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108381,108433);

var 
compilation2 = f_23107_108400_108432(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108447,108499);

var 
compilation3 = f_23107_108466_108498(compilation2, source3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108515,108568);

var 
f0 = f_23107_108524_108567(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108582,108635);

var 
f1 = f_23107_108591_108634(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108649,108702);

var 
f2 = f_23107_108658_108701(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108716,108769);

var 
f3 = f_23107_108725_108768(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108785,108838);

var 
g0 = f_23107_108794_108837(compilation0, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108852,108905);

var 
g1 = f_23107_108861_108904(compilation1, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108919,108972);

var 
g2 = f_23107_108928_108971(compilation2, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,108986,109039);

var 
g3 = f_23107_108995_109038(compilation3, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109055,109108);

var 
h0 = f_23107_109064_109107(compilation0, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109122,109175);

var 
h1 = f_23107_109131_109174(compilation1, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109189,109242);

var 
h2 = f_23107_109198_109241(compilation2, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109256,109309);

var 
h3 = f_23107_109265_109308(compilation3, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109325,109842);

var 
v0 = f_23107_109334_109841(this, compilation0, symbolValidator: module =>
            {
                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>",
                    "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<bool>",
                    "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<int>"
                }, module.GetFieldNamesAndTypes("C.<F>d__3"));
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109858,109923);

var 
md0 = f_23107_109868_109922(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,109939,110041);

var 
generation0 = f_23107_109957_110040(md0, f_23107_109997_110017(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,110055,110461);

var 
diff1 = f_23107_110067_110460(compilation1, generation0, f_23107_110143_110459(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_110240_110280(f0, SyntaxKind.Block),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,g0,g1,f_23107_110387_110427(g0, SyntaxKind.Block),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,110477,110745);

f_23107_110477_110744(
            diff1, "C: {<F>d__3, <G>d__4}", "C.<F>d__3: {<>1__state, <>t__builder, <>u__3, <>u__2, MoveNext, SetStateMachine}", "C.<G>d__4: {<>1__state, <>t__builder, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,110761,111029);

var 
diff2 = f_23107_110773_111028(compilation2, f_23107_110819_110839(diff1), f_23107_110858_111027(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_110955_110995(f1, SyntaxKind.Block),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,111045,111321);

f_23107_111045_111320(
            diff2, "C: {<F>d__3, <G>d__4}", "C.<F>d__3: {<>1__state, <>t__builder, <>u__4, <>u__3, MoveNext, SetStateMachine, <>u__2}", "C.<G>d__4: {<>1__state, <>t__builder, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,111337,111752);

var 
diff3 = f_23107_111349_111751(compilation3, f_23107_111395_111415(diff2), f_23107_111434_111750(SemanticEdit.Create(SemanticEditKind.Update,g2,g3,f_23107_111531_111571(g2, SyntaxKind.Block),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,h2,h3,f_23107_111678_111718(h2, SyntaxKind.Block),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,111768,112154);

f_23107_111768_112153(
            diff3, "C: {<G>d__4, <H>d__5, <F>d__3}", "C.<G>d__4: {<>1__state, <>t__builder, <>u__2, MoveNext, SetStateMachine, <>u__1}", "C.<H>d__5: {<>1__state, <>t__builder, <>u__2, MoveNext, SetStateMachine}", "C.<F>d__3: {<>1__state, <>t__builder, <>u__4, <>u__3, MoveNext, SetStateMachine, <>u__2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,112232,112262);

var 
md1 = f_23107_112242_112261(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,112276,112306);

var 
md2 = f_23107_112286_112305(diff2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,112320,112350);

var 
md3 = f_23107_112330_112349(diff3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,112455,113666);

f_23107_112455_113665(md1.Reader, f_23107_112507_112573(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_112592_112658(8, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_112677_112743(9, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_112762_112829(10, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_112848_112909(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_112928_112987(11, TableIndex.Field, EditAndContinueOperation.Default), f_23107_113006_113068(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_113087_113149(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_113168_113230(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_113249_113312(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_113331_113400(16, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_113419_113488(17, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_113507_113576(18, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_113595_113664(19, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,113784,119273);

f_23107_113784_119272(
            // Note that the new awaiter is allocated slot <>u__3 since <>u__1 and <>u__2 are taken.
            diff1, "C.<F>d__3.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      268 (0x10c)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter<C> V_2,
                C.<F>d__3 V_3,
                System.Runtime.CompilerServices.TaskAwaiter<int> V_4,
                System.Exception V_5)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__3.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_0012
    IL_000a:  br.s       IL_000c
    IL_000c:  ldloc.0
    IL_000d:  ldc.i4.1
    IL_000e:  beq.s      IL_0014
    IL_0010:  br.s       IL_0019
    IL_0012:  br.s       IL_0055
    IL_0014:  br         IL_00b3
    IL_0019:  nop
    IL_001a:  call       ""System.Threading.Tasks.Task<C> C.A3()""
    IL_001f:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<C> System.Threading.Tasks.Task<C>.GetAwaiter()""
    IL_0024:  stloc.2
    IL_0025:  ldloca.s   V_2
    IL_0027:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<C>.IsCompleted.get""
    IL_002c:  brtrue.s   IL_0071
    IL_002e:  ldarg.0
    IL_002f:  ldc.i4.0
    IL_0030:  dup
    IL_0031:  stloc.0
    IL_0032:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0037:  ldarg.0
    IL_0038:  ldloc.2
    IL_0039:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_003e:  ldarg.0
    IL_003f:  stloc.3
    IL_0040:  ldarg.0
    IL_0041:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_0046:  ldloca.s   V_2
    IL_0048:  ldloca.s   V_3
    IL_004a:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<C>, C.<F>d__3>(ref System.Runtime.CompilerServices.TaskAwaiter<C>, ref C.<F>d__3)""
    IL_004f:  nop
    IL_0050:  leave      IL_010b
    IL_0055:  ldarg.0
    IL_0056:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_005b:  stloc.2
    IL_005c:  ldarg.0
    IL_005d:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_0062:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<C>""
    IL_0068:  ldarg.0
    IL_0069:  ldc.i4.m1
    IL_006a:  dup
    IL_006b:  stloc.0
    IL_006c:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0071:  ldloca.s   V_2
    IL_0073:  call       ""C System.Runtime.CompilerServices.TaskAwaiter<C>.GetResult()""
    IL_0078:  pop
    IL_0079:  call       ""System.Threading.Tasks.Task<int> C.A2()""
    IL_007e:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<int> System.Threading.Tasks.Task<int>.GetAwaiter()""
    IL_0083:  stloc.s    V_4
    IL_0085:  ldloca.s   V_4
    IL_0087:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<int>.IsCompleted.get""
    IL_008c:  brtrue.s   IL_00d0
    IL_008e:  ldarg.0
    IL_008f:  ldc.i4.1
    IL_0090:  dup
    IL_0091:  stloc.0
    IL_0092:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0097:  ldarg.0
    IL_0098:  ldloc.s    V_4
    IL_009a:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__3.<>u__2""
    IL_009f:  ldarg.0
    IL_00a0:  stloc.3
    IL_00a1:  ldarg.0
    IL_00a2:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_00a7:  ldloca.s   V_4
    IL_00a9:  ldloca.s   V_3
    IL_00ab:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<int>, C.<F>d__3>(ref System.Runtime.CompilerServices.TaskAwaiter<int>, ref C.<F>d__3)""
    IL_00b0:  nop
    IL_00b1:  leave.s    IL_010b
    IL_00b3:  ldarg.0
    IL_00b4:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__3.<>u__2""
    IL_00b9:  stloc.s    V_4
    IL_00bb:  ldarg.0
    IL_00bc:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<int> C.<F>d__3.<>u__2""
    IL_00c1:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<int>""
    IL_00c7:  ldarg.0
    IL_00c8:  ldc.i4.m1
    IL_00c9:  dup
    IL_00ca:  stloc.0
    IL_00cb:  stfld      ""int C.<F>d__3.<>1__state""
    IL_00d0:  ldloca.s   V_4
    IL_00d2:  call       ""int System.Runtime.CompilerServices.TaskAwaiter<int>.GetResult()""
    IL_00d7:  pop
    IL_00d8:  ldc.i4.1
    IL_00d9:  stloc.1
    IL_00da:  leave.s    IL_00f6
  }
  catch System.Exception
  {
    IL_00dc:  stloc.s    V_5
    IL_00de:  ldarg.0
    IL_00df:  ldc.i4.s   -2
    IL_00e1:  stfld      ""int C.<F>d__3.<>1__state""
    IL_00e6:  ldarg.0
    IL_00e7:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_00ec:  ldloc.s    V_5
    IL_00ee:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_00f3:  nop
    IL_00f4:  leave.s    IL_010b
  }
  IL_00f6:  ldarg.0
  IL_00f7:  ldc.i4.s   -2
  IL_00f9:  stfld      ""int C.<F>d__3.<>1__state""
  IL_00fe:  ldarg.0
  IL_00ff:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
  IL_0104:  ldloc.1
  IL_0105:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_010a:  nop
  IL_010b:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,119341,120044);

f_23107_119341_120043(md2.Reader, f_23107_119393_119460(11, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_119479_119546(12, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_119565_119626(3, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_119645_119704(12, TableIndex.Field, EditAndContinueOperation.Default), f_23107_119723_119785(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_119804_119866(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_119885_119954(20, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_119973_120042(21, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,120139,125641);

f_23107_120139_125640(
            // Note that the new awaiters are allocated slots <>u__4, <>u__5.
            diff2, "C.<F>d__3.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext", @"
{
  // Code size      268 (0x10c)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                System.Runtime.CompilerServices.TaskAwaiter<bool> V_2,
                C.<F>d__3 V_3,
                System.Runtime.CompilerServices.TaskAwaiter<C> V_4,
                System.Exception V_5)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<F>d__3.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    IL_0007:  ldloc.0
    IL_0008:  brfalse.s  IL_0012
    IL_000a:  br.s       IL_000c
    IL_000c:  ldloc.0
    IL_000d:  ldc.i4.1
    IL_000e:  beq.s      IL_0014
    IL_0010:  br.s       IL_0019
    IL_0012:  br.s       IL_0055
    IL_0014:  br         IL_00b3
    IL_0019:  nop
    IL_001a:  call       ""System.Threading.Tasks.Task<bool> C.A1()""
    IL_001f:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<bool> System.Threading.Tasks.Task<bool>.GetAwaiter()""
    IL_0024:  stloc.2
    IL_0025:  ldloca.s   V_2
    IL_0027:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<bool>.IsCompleted.get""
    IL_002c:  brtrue.s   IL_0071
    IL_002e:  ldarg.0
    IL_002f:  ldc.i4.0
    IL_0030:  dup
    IL_0031:  stloc.0
    IL_0032:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0037:  ldarg.0
    IL_0038:  ldloc.2
    IL_0039:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<bool> C.<F>d__3.<>u__4""
    IL_003e:  ldarg.0
    IL_003f:  stloc.3
    IL_0040:  ldarg.0
    IL_0041:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_0046:  ldloca.s   V_2
    IL_0048:  ldloca.s   V_3
    IL_004a:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<bool>, C.<F>d__3>(ref System.Runtime.CompilerServices.TaskAwaiter<bool>, ref C.<F>d__3)""
    IL_004f:  nop
    IL_0050:  leave      IL_010b
    IL_0055:  ldarg.0
    IL_0056:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<bool> C.<F>d__3.<>u__4""
    IL_005b:  stloc.2
    IL_005c:  ldarg.0
    IL_005d:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<bool> C.<F>d__3.<>u__4""
    IL_0062:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<bool>""
    IL_0068:  ldarg.0
    IL_0069:  ldc.i4.m1
    IL_006a:  dup
    IL_006b:  stloc.0
    IL_006c:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0071:  ldloca.s   V_2
    IL_0073:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<bool>.GetResult()""
    IL_0078:  pop
    IL_0079:  call       ""System.Threading.Tasks.Task<C> C.A3()""
    IL_007e:  callvirt   ""System.Runtime.CompilerServices.TaskAwaiter<C> System.Threading.Tasks.Task<C>.GetAwaiter()""
    IL_0083:  stloc.s    V_4
    IL_0085:  ldloca.s   V_4
    IL_0087:  call       ""bool System.Runtime.CompilerServices.TaskAwaiter<C>.IsCompleted.get""
    IL_008c:  brtrue.s   IL_00d0
    IL_008e:  ldarg.0
    IL_008f:  ldc.i4.1
    IL_0090:  dup
    IL_0091:  stloc.0
    IL_0092:  stfld      ""int C.<F>d__3.<>1__state""
    IL_0097:  ldarg.0
    IL_0098:  ldloc.s    V_4
    IL_009a:  stfld      ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_009f:  ldarg.0
    IL_00a0:  stloc.3
    IL_00a1:  ldarg.0
    IL_00a2:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_00a7:  ldloca.s   V_4
    IL_00a9:  ldloca.s   V_3
    IL_00ab:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<C>, C.<F>d__3>(ref System.Runtime.CompilerServices.TaskAwaiter<C>, ref C.<F>d__3)""
    IL_00b0:  nop
    IL_00b1:  leave.s    IL_010b
    IL_00b3:  ldarg.0
    IL_00b4:  ldfld      ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_00b9:  stloc.s    V_4
    IL_00bb:  ldarg.0
    IL_00bc:  ldflda     ""System.Runtime.CompilerServices.TaskAwaiter<C> C.<F>d__3.<>u__3""
    IL_00c1:  initobj    ""System.Runtime.CompilerServices.TaskAwaiter<C>""
    IL_00c7:  ldarg.0
    IL_00c8:  ldc.i4.m1
    IL_00c9:  dup
    IL_00ca:  stloc.0
    IL_00cb:  stfld      ""int C.<F>d__3.<>1__state""
    IL_00d0:  ldloca.s   V_4
    IL_00d2:  call       ""C System.Runtime.CompilerServices.TaskAwaiter<C>.GetResult()""
    IL_00d7:  pop
    IL_00d8:  ldc.i4.1
    IL_00d9:  stloc.1
    IL_00da:  leave.s    IL_00f6
  }
  catch System.Exception
  {
    IL_00dc:  stloc.s    V_5
    IL_00de:  ldarg.0
    IL_00df:  ldc.i4.s   -2
    IL_00e1:  stfld      ""int C.<F>d__3.<>1__state""
    IL_00e6:  ldarg.0
    IL_00e7:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
    IL_00ec:  ldloc.s    V_5
    IL_00ee:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetException(System.Exception)""
    IL_00f3:  nop
    IL_00f4:  leave.s    IL_010b
  }
  IL_00f6:  ldarg.0
  IL_00f7:  ldc.i4.s   -2
  IL_00f9:  stfld      ""int C.<F>d__3.<>1__state""
  IL_00fe:  ldarg.0
  IL_00ff:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int> C.<F>d__3.<>t__builder""
  IL_0104:  ldloc.1
  IL_0105:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.SetResult(int)""
  IL_010a:  nop
  IL_010b:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,125756,127129);

f_23107_125756_127128(md3.Reader, f_23107_125808_125875(13, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_125894_125961(14, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_125980_126047(15, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_126066_126133(16, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23107_126152_126213(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_126232_126291(13, TableIndex.Field, EditAndContinueOperation.Default), f_23107_126310_126371(5, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23107_126390_126449(14, TableIndex.Field, EditAndContinueOperation.Default), f_23107_126468_126530(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_126549_126611(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_126630_126693(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_126712_126775(15, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23107_126794_126863(22, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_126882_126951(23, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_126970_127039(24, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23107_127058_127127(25, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,105959,127140);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_108212_108280(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108212, 108280);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_108162_108300(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108162, 108300);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_108334_108366(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108334, 108366);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_108400_108432(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108400, 108432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_108466_108498(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108466, 108498);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108524_108567(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108524, 108567);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108591_108634(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108591, 108634);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108658_108701(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108658, 108701);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108725_108768(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108725, 108768);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108794_108837(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108794, 108837);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108861_108904(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108861, 108904);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108928_108971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108928, 108971);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_108995_109038(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 108995, 109038);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_109064_109107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109064, 109107);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_109131_109174(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109131, 109174);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_109198_109241(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109198, 109241);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_109265_109308(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109265, 109308);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_109334_109841(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109334, 109841);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_109868_109922(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109868, 109922);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_109997_110017(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109997, 110017);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_109957_110040(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 109957, 110040);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_110240_110280(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110240, 110280);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_110387_110427(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110387, 110427);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_110143_110459(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110143, 110459);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_110067_110460(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110067, 110460);
return return_v;
}


int
f_23107_110477_110744(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110477, 110744);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_110819_110839(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 110819, 110839);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_110955_110995(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110955, 110995);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_110858_111027(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110858, 111027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_110773_111028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 110773, 111028);
return return_v;
}


int
f_23107_111045_111320(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111045, 111320);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_111395_111415(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 111395, 111415);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_111531_111571(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111531, 111571);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_111678_111718(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111678, 111718);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_111434_111750(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111434, 111750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_111349_111751(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111349, 111751);
return return_v;
}


int
f_23107_111768_112153(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 111768, 112153);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_112242_112261(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112242, 112261);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_112286_112305(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112286, 112305);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_112330_112349(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112330, 112349);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112507_112573(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112507, 112573);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112592_112658(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112592, 112658);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112677_112743(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112677, 112743);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112762_112829(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112762, 112829);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112848_112909(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112848, 112909);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_112928_112987(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112928, 112987);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113006_113068(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113006, 113068);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113087_113149(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113087, 113149);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113168_113230(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113168, 113230);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113249_113312(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113249, 113312);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113331_113400(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113331, 113400);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113419_113488(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113419, 113488);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113507_113576(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113507, 113576);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_113595_113664(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113595, 113664);
return return_v;
}


int
f_23107_112455_113665(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 112455, 113665);
return 0;
}


int
f_23107_113784_119272(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 113784, 119272);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119393_119460(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119393, 119460);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119479_119546(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119479, 119546);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119565_119626(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119565, 119626);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119645_119704(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119645, 119704);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119723_119785(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119723, 119785);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119804_119866(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119804, 119866);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119885_119954(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119885, 119954);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_119973_120042(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119973, 120042);
return return_v;
}


int
f_23107_119341_120043(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 119341, 120043);
return 0;
}


int
f_23107_120139_125640(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 120139, 125640);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_125808_125875(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 125808, 125875);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_125894_125961(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 125894, 125961);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_125980_126047(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 125980, 126047);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126066_126133(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126066, 126133);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126152_126213(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126152, 126213);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126232_126291(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126232, 126291);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126310_126371(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126310, 126371);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126390_126449(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126390, 126449);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126468_126530(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126468, 126530);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126549_126611(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126549, 126611);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126630_126693(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126630, 126693);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126712_126775(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126712, 126775);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126794_126863(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126794, 126863);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126882_126951(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126882, 126951);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_126970_127039(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 126970, 127039);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23107_127058_127127(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 127058, 127127);
return return_v;
}


int
f_23107_125756_127128(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 125756, 127128);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,105959,127140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,105959,127140);
}
		}

[Fact]
        public void SynthesizedMembersMerging()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,127152,133135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,127232,127313);

var 
source0 = @"
using System.Collections.Generic;

public class C
{    
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,127327,127509);

var 
source1 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F() 
    {
        yield return 1;
        yield return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,127523,127705);

var 
source2 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F() 
    {
        yield return 1;
        yield return 3;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,127719,127988);

var 
source3 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F() 
    {
        yield return 1;
        yield return 3;
    }

    public static void G() 
    {
        System.Console.WriteLine(1);    
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128002,128353);

var 
source4 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F() 
    {
        yield return 1;
        yield return 3;
    }

    public static void G() 
    {
        System.Console.WriteLine(1);    
    }

    public static IEnumerable<int> H() 
    {
        yield return 1;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128432,128590);

var 
compilation0 = f_23107_128451_128589(source0, options: f_23107_128501_128569(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128604,128656);

var 
compilation1 = f_23107_128623_128655(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128670,128722);

var 
compilation2 = f_23107_128689_128721(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128736,128788);

var 
compilation3 = f_23107_128755_128787(compilation2, source3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128802,128854);

var 
compilation4 = f_23107_128821_128853(compilation3, source4)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128870,128923);

var 
f1 = f_23107_128879_128922(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,128937,128990);

var 
f2 = f_23107_128946_128989(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129004,129057);

var 
f3 = f_23107_129013_129056(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129073,129126);

var 
g3 = f_23107_129082_129125(compilation3, "C.G")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129140,129193);

var 
h4 = f_23107_129149_129192(compilation4, "C.H")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129209,129249);

var 
v0 = f_23107_129218_129248(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129263,129328);

var 
md0 = f_23107_129273_129327(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129344,129446);

var 
generation0 = f_23107_129362_129445(md0, f_23107_129402_129422(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129460,129649);

var 
diff1 = f_23107_129472_129648(compilation1, generation0, f_23107_129548_129647(SemanticEdit.Create(SemanticEditKind.Insert,null,f1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,129665,130216);

f_23107_129665_130215(
            diff1, "C: {<F>d__0#1}", "C.<F>d__0#1: {<>1__state, <>2__current, <>l__initialThreadId, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,130232,130500);

var 
diff2 = f_23107_130244_130499(compilation2, f_23107_130290_130310(diff1), f_23107_130329_130498(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_130426_130466(f1, SyntaxKind.Block),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,130516,131067);

f_23107_130516_131066(
            diff2, "C: {<F>d__0#1}", "C.<F>d__0#1: {<>1__state, <>2__current, <>l__initialThreadId, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,131083,131281);

var 
diff3 = f_23107_131095_131280(compilation3, f_23107_131141_131161(diff2), f_23107_131180_131279(SemanticEdit.Create(SemanticEditKind.Insert,null,g3)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,131297,131848);

f_23107_131297_131847(
            diff3, "C: {<F>d__0#1}", "C.<F>d__0#1: {<>1__state, <>2__current, <>l__initialThreadId, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,131864,132062);

var 
diff4 = f_23107_131876_132061(compilation4, f_23107_131922_131942(diff3), f_23107_131961_132060(SemanticEdit.Create(SemanticEditKind.Insert,null,h4)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,132078,133124);

f_23107_132078_133123(
            diff4, "C: {<H>d__2#4, <F>d__0#1}", "C.<F>d__0#1: {<>1__state, <>2__current, <>l__initialThreadId, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "C.<H>d__2#4: {<>1__state, <>2__current, <>l__initialThreadId, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,127152,133135);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_128501_128569(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128501, 128569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_128451_128589(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128451, 128589);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_128623_128655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128623, 128655);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_128689_128721(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128689, 128721);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_128755_128787(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128755, 128787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_128821_128853(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128821, 128853);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_128879_128922(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128879, 128922);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_128946_128989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 128946, 128989);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_129013_129056(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129013, 129056);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_129082_129125(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129082, 129125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_129149_129192(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129149, 129192);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_129218_129248(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129218, 129248);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_129273_129327(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129273, 129327);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_129402_129422(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129402, 129422);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_129362_129445(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129362, 129445);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_129548_129647(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129548, 129647);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_129472_129648(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129472, 129648);
return return_v;
}


int
f_23107_129665_130215(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 129665, 130215);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_130290_130310(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 130290, 130310);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_130426_130466(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method0,params Microsoft.CodeAnalysis.CSharp.SyntaxKind[]
kinds)
{
var return_v = GetSyntaxMapByKind( method0, kinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 130426, 130466);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_130329_130498(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 130329, 130498);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_130244_130499(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 130244, 130499);
return return_v;
}


int
f_23107_130516_131066(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 130516, 131066);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_131141_131161(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 131141, 131161);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_131180_131279(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 131180, 131279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_131095_131280(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 131095, 131280);
return return_v;
}


int
f_23107_131297_131847(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 131297, 131847);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_131922_131942(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 131922, 131942);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_131961_132060(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 131961, 132060);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_131876_132061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 131876, 132061);
return return_v;
}


int
f_23107_132078_133123(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 132078, 133123);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,127152,133135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,127152,133135);
}
		}

[Fact]
        public void UniqueSynthesizedNames()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,133147,135510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,133224,133366);

var 
source0 = @"
using System.Collections.Generic;

public class C
{    
    public static IEnumerable<int> F()  { yield return 1; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,133380,133584);

var 
source1 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F(int a)  { yield return 2; }
    public static IEnumerable<int> F()  { yield return 1; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,133598,133869);

var 
source2 = @"
using System.Collections.Generic;

public class C
{
    public static IEnumerable<int> F(int a)  { yield return 2; }
    public static IEnumerable<int> F(byte a)  { yield return 3; }
    public static IEnumerable<int> F()  { yield return 1; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,133885,134043);

var 
compilation0 = f_23107_133904_134042(source0, options: f_23107_133954_134022(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134057,134109);

var 
compilation1 = f_23107_134076_134108(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134123,134175);

var 
compilation2 = f_23107_134142_134174(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134191,134275);

var 
f_int1 = f_23107_134204_134234(compilation1, "C.F").Single(m => m.ToString() == "C.F(int)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134289,134375);

var 
f_byte2 = f_23107_134303_134333(compilation2, "C.F").Single(m => m.ToString() == "C.F(byte)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134391,134431);

var 
v0 = f_23107_134400_134430(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134445,134510);

var 
md0 = f_23107_134455_134509(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134526,134628);

var 
generation0 = f_23107_134544_134627(md0, f_23107_134584_134604(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134642,134835);

var 
diff1 = f_23107_134654_134834(compilation1, generation0, f_23107_134730_134833(SemanticEdit.Create(SemanticEditKind.Insert,null,f_int1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,134851,135054);

var 
diff2 = f_23107_134863_135053(compilation2, f_23107_134909_134929(diff1), f_23107_134948_135052(SemanticEdit.Create(SemanticEditKind.Insert,null,f_byte2)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135070,135103);

var 
reader0 = f_23107_135084_135102(md0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135117,135158);

var 
reader1 = f_23107_135131_135150(diff1).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135172,135213);

var 
reader2 = f_23107_135186_135205(diff2).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135229,135304);

f_23107_135229_135303(reader0, f_23107_135249_135274(reader0), "<Module>", "C", "<F>d__0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135318,135397);

f_23107_135318_135396(new[] { reader0, reader1 }, f_23107_135357_135382(reader1), "<F>d__0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135411,135499);

f_23107_135411_135498(new[] { reader0, reader1, reader2 }, f_23107_135459_135484(reader2), "<F>d__1#2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,133147,135510);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_133954_134022(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 133954, 134022);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_133904_134042(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 133904, 134042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_134076_134108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134076, 134108);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_134142_134174(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134142, 134174);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_134204_134234(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134204, 134234);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23107_134303_134333(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134303, 134333);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_134400_134430(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134400, 134430);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_134455_134509(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134455, 134509);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_134584_134604(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134584, 134604);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_134544_134627(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134544, 134627);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_134730_134833(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134730, 134833);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_134654_134834(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134654, 134834);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_134909_134929(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 134909, 134929);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_134948_135052(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134948, 135052);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_134863_135053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 134863, 135053);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23107_135084_135102(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 135084, 135102);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_135131_135150(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135131, 135150);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23107_135186_135205(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135186, 135205);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23107_135249_135274(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135249, 135274);
return return_v;
}


int
f_23107_135229_135303(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135229, 135303);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23107_135357_135382(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135357, 135382);
return return_v;
}


int
f_23107_135318_135396(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135318, 135396);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23107_135459_135484(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135459, 135484);
return return_v;
}


int
f_23107_135411_135498(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135411, 135498);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,133147,135510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,133147,135510);
}
		}

[Fact]
        public void UpdateAsyncLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,135522,139628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135594,135969);

var 
source0 = f_23107_135608_135968(@"using System;
using System.Threading.Tasks;
class C
{
    static void F()
    {
        Func<Task> <N:0>g1 = <N:1>async () =>
        {
            await A1(); 
            await A2();
        }</N:1></N:0>;
    }

    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<double> A3() => null;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,135983,136386);

var 
source1 = f_23107_135997_136385(@"using System;
using System.Threading.Tasks;
class C
{
    static int G() => 1;

    static void F()
    {
        Func<Task> <N:0>g1 = <N:1>async () =>
        {
            await A2(); 
            await A1();
        }</N:1></N:0>;
    }

    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<double> A3() => null;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,136400,136804);

var 
source2 = f_23107_136414_136803(@"using System;
using System.Threading.Tasks;
class C
{
    static int G() => 1;

    static void F()
    {
        Func<Task> <N:0>g1 = <N:1>async () =>
        {
            await A1(); 
            await A2();
        }</N:1></N:0>;
    }

    static Task<bool> A1() => null;
    static Task<int> A2() => null;
    static Task<double> A3() => null;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,136820,136974);

var 
compilation0 = f_23107_136839_136973(new[] { source0.Tree }, options: f_23107_136904_136972(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,136988,137045);

var 
compilation1 = f_23107_137007_137044(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137059,137116);

var 
compilation2 = f_23107_137078_137115(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137132,137694);

var 
v0 = f_23107_137141_137693(this, compilation0, symbolValidator: module =>
            {
                Assert.Equal(new[]
                {
                    "<>1__state: int",
                    "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder",
                    "<>4__this: C.<>c",
                    "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<bool>",
                    "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<int>"
                }, module.GetFieldNamesAndTypes("C.<>c.<<F>b__0_0>d"));
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137710,137775);

var 
md0 = f_23107_137720_137774(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137791,137893);

var 
generation0 = f_23107_137809_137892(md0, f_23107_137849_137869(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137909,137962);

var 
f0 = f_23107_137918_137961(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,137976,138029);

var 
f1 = f_23107_137985_138028(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,138043,138096);

var 
f2 = f_23107_138052_138095(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,138112,138350);

var 
diff1 = f_23107_138124_138349(compilation1, generation0, f_23107_138200_138348(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_138275_138316(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,138483,138852);

f_23107_138483_138851(
            // note that the types of the awaiter fields <>u__1, <>u__2 are the same as in the previous generation:
            diff1, "C.<>c.<<F>b__0_0>d", "<>1__state: int", "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder", "<>4__this: C.<>c", "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<bool>", "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<int>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,138868,139115);

var 
diff2 = f_23107_138880_139114(compilation2, f_23107_138926_138946(diff1), f_23107_138965_139113(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_139040_139081(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,139248,139617);

f_23107_139248_139616(
            // note that the types of the awaiter fields <>u__1, <>u__2 are the same as in the previous generation:
            diff2, "C.<>c.<<F>b__0_0>d", "<>1__state: int", "<>t__builder: System.Runtime.CompilerServices.AsyncTaskMethodBuilder", "<>4__this: C.<>c", "<>u__1: System.Runtime.CompilerServices.TaskAwaiter<bool>", "<>u__2: System.Runtime.CompilerServices.TaskAwaiter<int>");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,135522,139628);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_135608_135968(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135608, 135968);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_135997_136385(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 135997, 136385);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_136414_136803(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 136414, 136803);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_136904_136972(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 136904, 136972);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_136839_136973(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 136839, 136973);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_137007_137044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137007, 137044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_137078_137115(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137078, 137115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_137141_137693(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137141, 137693);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_137720_137774(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137720, 137774);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_137849_137869(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137849, 137869);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_137809_137892(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137809, 137892);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_137918_137961(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137918, 137961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_137985_138028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 137985, 138028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_138052_138095(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138052, 138095);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_138275_138316(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138275, 138316);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_138200_138348(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138200, 138348);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_138124_138349(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138124, 138349);
return return_v;
}


int
f_23107_138483_138851(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
typeName,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedFields( typeName, expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138483, 138851);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_138926_138946(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 138926, 138946);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_139040_139081(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 139040, 139081);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_138965_139113(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138965, 139113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_138880_139114(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 138880, 139114);
return return_v;
}


int
f_23107_139248_139616(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
typeName,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedFields( typeName, expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 139248, 139616);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,135522,139628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,135522,139628);
}
		}

[Fact, WorkItem(1170899, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1170899")]
        public void HoistedAnonymousTypes1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,139640,145064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,139801,140054);

var 
source0 = f_23107_139815_140053(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new { A = 1 }</N:0>;
        yield return 1;
        Console.WriteLine(x.A + 1);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140068,140321);

var 
source1 = f_23107_140082_140320(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new { A = 1 }</N:0>;
        yield return 1;
        Console.WriteLine(x.A + 2);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140335,140588);

var 
source2 = f_23107_140349_140587(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new { A = 1 }</N:0>;
        yield return 1;
        Console.WriteLine(x.A + 3);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140602,140703);

var 
compilation0 = f_23107_140621_140702(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140717,140774);

var 
compilation1 = f_23107_140736_140773(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140788,140845);

var 
compilation2 = f_23107_140807_140844(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140861,140901);

var 
v0 = f_23107_140870_140900(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140915,140938);

f_23107_140915_140937(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,140952,141017);

var 
md0 = f_23107_140962_141016(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,141033,141086);

var 
f0 = f_23107_141042_141085(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,141100,141153);

var 
f1 = f_23107_141109_141152(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,141167,141220);

var 
f2 = f_23107_141176_141219(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,141236,141338);

var 
generation0 = f_23107_141254_141337(md0, f_23107_141294_141314(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,141354,142786);

var 
baselineIL = @"
{
  // Code size       88 (0x58)
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
  IL_0014:  br.s       IL_003c
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.1
  IL_0022:  newobj     ""<>f__AnonymousType0<int>..ctor(int)""
  IL_0027:  stfld      ""<anonymous type: int A> C.<F>d__0.<x>5__1""
  IL_002c:  ldarg.0
  IL_002d:  ldc.i4.1
  IL_002e:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0033:  ldarg.0
  IL_0034:  ldc.i4.1
  IL_0035:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003a:  ldc.i4.1
  IL_003b:  ret
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.m1
  IL_003e:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0043:  ldarg.0
  IL_0044:  ldfld      ""<anonymous type: int A> C.<F>d__0.<x>5__1""
  IL_0049:  callvirt   ""int <>f__AnonymousType0<int>.A.get""
  IL_004e:  ldc.i4.<<VALUE>>
  IL_004f:  add
  IL_0050:  call       ""void System.Console.WriteLine(int)""
  IL_0055:  nop
  IL_0056:  ldc.i4.0
  IL_0057:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,142800,142905);

f_23107_142800_142904(            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_142867_142903(baselineIL, "<<VALUE>>", "1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,142921,143181);

var 
diff1 = f_23107_142933_143180(compilation1, generation0, f_23107_143009_143179(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_143106_143147(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,143197,143849);

f_23107_143197_143848(
            diff1, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,143865,143973);

f_23107_143865_143972(
            diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_143935_143971(baselineIL, "<<VALUE>>", "2"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,143989,144258);

var 
diff2 = f_23107_144001_144257(compilation2, f_23107_144047_144067(diff1), f_23107_144086_144256(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_144183_144224(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,144274,144929);

f_23107_144274_144928(
            diff2, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,144945,145053);

f_23107_144945_145052(
            diff2, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_145015_145051(baselineIL, "<<VALUE>>", "3"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,139640,145064);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_139815_140053(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 139815, 140053);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_140082_140320(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140082, 140320);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_140349_140587(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140349, 140587);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_140621_140702(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140621, 140702);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_140736_140773(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140736, 140773);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_140807_140844(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140807, 140844);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_140870_140900(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140870, 140900);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_140915_140937(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140915, 140937);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_140962_141016(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 140962, 141016);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_141042_141085(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 141042, 141085);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_141109_141152(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 141109, 141152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_141176_141219(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 141176, 141219);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_141294_141314(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 141294, 141314);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_141254_141337(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 141254, 141337);
return return_v;
}


string
f_23107_142867_142903(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 142867, 142903);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_142800_142904(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 142800, 142904);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_143106_143147(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 143106, 143147);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_143009_143179(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 143009, 143179);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_142933_143180(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 142933, 143180);
return return_v;
}


int
f_23107_143197_143848(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 143197, 143848);
return 0;
}


string
f_23107_143935_143971(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 143935, 143971);
return return_v;
}


int
f_23107_143865_143972(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 143865, 143972);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_144047_144067(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 144047, 144067);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_144183_144224(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 144183, 144224);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_144086_144256(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 144086, 144256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_144001_144257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 144001, 144257);
return return_v;
}


int
f_23107_144274_144928(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 144274, 144928);
return 0;
}


string
f_23107_145015_145051(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 145015, 145051);
return return_v;
}


int
f_23107_144945_145052(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 144945, 145052);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,139640,145064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,139640,145064);
}
		}

[Fact, WorkItem(3192, "https://github.com/dotnet/roslyn/issues/3192")]
        public void HoistedAnonymousTypes_Nested()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,145076,151189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,145223,145503);

var 
source0 = f_23107_145237_145502(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new[] { new { A = new { B = 1 } } }</N:0>;
        yield return 1;
        Console.WriteLine(x[0].A.B + 1);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,145517,145797);

var 
source1 = f_23107_145531_145796(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new[] { new { A = new { B = 1 } } }</N:0>;
        yield return 1;
        Console.WriteLine(x[0].A.B + 2);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,145811,146091);

var 
source2 = f_23107_145825_146090(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new[] { new { A = new { B = 1 } } }</N:0>;
        yield return 1;
        Console.WriteLine(x[0].A.B + 3);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146105,146206);

var 
compilation0 = f_23107_146124_146205(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146220,146277);

var 
compilation1 = f_23107_146239_146276(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146291,146348);

var 
compilation2 = f_23107_146310_146347(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146364,146404);

var 
v0 = f_23107_146373_146403(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146418,146441);

f_23107_146418_146440(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146455,146520);

var 
md0 = f_23107_146465_146519(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146536,146589);

var 
f0 = f_23107_146545_146588(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146603,146656);

var 
f1 = f_23107_146612_146655(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146670,146723);

var 
f2 = f_23107_146679_146722(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146739,146841);

var 
generation0 = f_23107_146757_146840(md0, f_23107_146797_146817(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,146857,148744);

var 
baselineIL = @"
{
  // Code size      109 (0x6d)
  .maxstack  5
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
  IL_0014:  br.s       IL_004a
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldc.i4.1
  IL_0022:  newarr     ""<>f__AnonymousType0<<anonymous type: int B>>""
  IL_0027:  dup
  IL_0028:  ldc.i4.0
  IL_0029:  ldc.i4.1
  IL_002a:  newobj     ""<>f__AnonymousType1<int>..ctor(int)""
  IL_002f:  newobj     ""<>f__AnonymousType0<<anonymous type: int B>>..ctor(<anonymous type: int B>)""
  IL_0034:  stelem.ref
  IL_0035:  stfld      ""<anonymous type: <anonymous type: int B> A>[] C.<F>d__0.<x>5__1""
  IL_003a:  ldarg.0
  IL_003b:  ldc.i4.1
  IL_003c:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0041:  ldarg.0
  IL_0042:  ldc.i4.1
  IL_0043:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0048:  ldc.i4.1
  IL_0049:  ret
  IL_004a:  ldarg.0
  IL_004b:  ldc.i4.m1
  IL_004c:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0051:  ldarg.0
  IL_0052:  ldfld      ""<anonymous type: <anonymous type: int B> A>[] C.<F>d__0.<x>5__1""
  IL_0057:  ldc.i4.0
  IL_0058:  ldelem.ref
  IL_0059:  callvirt   ""<anonymous type: int B> <>f__AnonymousType0<<anonymous type: int B>>.A.get""
  IL_005e:  callvirt   ""int <>f__AnonymousType1<int>.B.get""
  IL_0063:  ldc.i4.<<VALUE>>
  IL_0064:  add
  IL_0065:  call       ""void System.Console.WriteLine(int)""
  IL_006a:  nop
  IL_006b:  ldc.i4.0
  IL_006c:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,148758,148863);

f_23107_148758_148862(            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_148825_148861(baselineIL, "<<VALUE>>", "1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,148879,149139);

var 
diff1 = f_23107_148891_149138(compilation1, generation0, f_23107_148967_149137(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_149064_149105(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,149155,149892);

f_23107_149155_149891(
            diff1, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType1<<B>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,149908,150016);

f_23107_149908_150015(
            diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_149978_150014(baselineIL, "<<VALUE>>", "2"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,150032,150301);

var 
diff2 = f_23107_150044_150300(compilation2, f_23107_150090_150110(diff1), f_23107_150129_150299(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_150226_150267(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,150317,151054);

f_23107_150317_151053(
            diff2, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType1<<B>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,151070,151178);

f_23107_151070_151177(
            diff2, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_151140_151176(baselineIL, "<<VALUE>>", "3"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,145076,151189);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_145237_145502(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 145237, 145502);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_145531_145796(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 145531, 145796);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_145825_146090(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 145825, 146090);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_146124_146205(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146124, 146205);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_146239_146276(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146239, 146276);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_146310_146347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146310, 146347);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_146373_146403(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146373, 146403);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_146418_146440(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146418, 146440);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_146465_146519(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146465, 146519);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_146545_146588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146545, 146588);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_146612_146655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146612, 146655);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_146679_146722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146679, 146722);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_146797_146817(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146797, 146817);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_146757_146840(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 146757, 146840);
return return_v;
}


string
f_23107_148825_148861(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 148825, 148861);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_148758_148862(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 148758, 148862);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_149064_149105(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 149064, 149105);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_148967_149137(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 148967, 149137);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_148891_149138(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 148891, 149138);
return return_v;
}


int
f_23107_149155_149891(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 149155, 149891);
return 0;
}


string
f_23107_149978_150014(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 149978, 150014);
return return_v;
}


int
f_23107_149908_150015(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 149908, 150015);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_150090_150110(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 150090, 150110);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_150226_150267(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 150226, 150267);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_150129_150299(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 150129, 150299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_150044_150300(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 150044, 150300);
return return_v;
}


int
f_23107_150317_151053(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 150317, 151053);
return 0;
}


string
f_23107_151140_151176(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 151140, 151176);
return return_v;
}


int
f_23107_151070_151177(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 151070, 151177);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,145076,151189);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,145076,151189);
}
		}

[Fact, WorkItem(3192, "https://github.com/dotnet/roslyn/issues/3192")]
        public void HoistedGenericTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,151201,156907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,151339,151710);

var 
source0 = f_23107_151353_151709(@"
using System;
using System.Collections.Generic;

class Z<T1>
{
    public class S<T2> { public T1 a = default(T1); public T2 b = default(T2); }
}

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new Z<double>.S<int>()</N:0>;
        yield return 1;
        Console.WriteLine(x.a + x.b + 1);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,151724,152095);

var 
source1 = f_23107_151738_152094(@"
using System;
using System.Collections.Generic;

class Z<T1>
{
    public class S<T2> { public T1 a = default(T1); public T2 b = default(T2); }
}

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new Z<double>.S<int>()</N:0>;
        yield return 1;
        Console.WriteLine(x.a + x.b + 2);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152109,152480);

var 
source2 = f_23107_152123_152479(@"
using System;
using System.Collections.Generic;

class Z<T1>
{
    public class S<T2> { public T1 a = default(T1); public T2 b = default(T2); }
}

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new Z<double>.S<int>()</N:0>;
        yield return 1;
        Console.WriteLine(x.a + x.b + 3);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152494,152595);

var 
compilation0 = f_23107_152513_152594(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152609,152666);

var 
compilation1 = f_23107_152628_152665(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152680,152737);

var 
compilation2 = f_23107_152699_152736(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152753,152793);

var 
v0 = f_23107_152762_152792(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152807,152830);

f_23107_152807_152829(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152844,152909);

var 
md0 = f_23107_152854_152908(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152925,152978);

var 
f0 = f_23107_152934_152977(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,152992,153045);

var 
f1 = f_23107_153001_153044(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,153059,153112);

var 
f2 = f_23107_153068_153111(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,153128,153230);

var 
generation0 = f_23107_153146_153229(md0, f_23107_153186_153206(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,153246,154802);

var 
baselineIL = @"
{
  // Code size      108 (0x6c)
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
  IL_0014:  br.s       IL_003b
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  newobj     ""Z<double>.S<int>..ctor()""
  IL_0026:  stfld      ""Z<double>.S<int> C.<F>d__0.<x>5__1""
  IL_002b:  ldarg.0
  IL_002c:  ldc.i4.1
  IL_002d:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0032:  ldarg.0
  IL_0033:  ldc.i4.1
  IL_0034:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0039:  ldc.i4.1
  IL_003a:  ret
  IL_003b:  ldarg.0
  IL_003c:  ldc.i4.m1
  IL_003d:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0042:  ldarg.0
  IL_0043:  ldfld      ""Z<double>.S<int> C.<F>d__0.<x>5__1""
  IL_0048:  ldfld      ""double Z<double>.S<int>.a""
  IL_004d:  ldarg.0
  IL_004e:  ldfld      ""Z<double>.S<int> C.<F>d__0.<x>5__1""
  IL_0053:  ldfld      ""int Z<double>.S<int>.b""
  IL_0058:  conv.r8
  IL_0059:  add
  IL_005a:  ldc.r8     <<VALUE>>
  IL_0063:  add
  IL_0064:  call       ""void System.Console.WriteLine(double)""
  IL_0069:  nop
  IL_006a:  ldc.i4.0
  IL_006b:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,154816,154921);

f_23107_154816_154920(            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_154883_154919(baselineIL, "<<VALUE>>", "1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,154937,155197);

var 
diff1 = f_23107_154949_155196(compilation1, generation0, f_23107_155025_155195(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_155122_155163(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,155213,155780);

f_23107_155213_155779(
            diff1, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,155796,155904);

f_23107_155796_155903(
            diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_155866_155902(baselineIL, "<<VALUE>>", "2"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,155920,156189);

var 
diff2 = f_23107_155932_156188(compilation2, f_23107_155978_155998(diff1), f_23107_156017_156187(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_156114_156155(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,156205,156772);

f_23107_156205_156771(
            diff2, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,156788,156896);

f_23107_156788_156895(
            diff2, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_156858_156894(baselineIL, "<<VALUE>>", "3"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,151201,156907);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_151353_151709(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 151353, 151709);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_151738_152094(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 151738, 152094);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_152123_152479(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152123, 152479);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_152513_152594(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152513, 152594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_152628_152665(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152628, 152665);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_152699_152736(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152699, 152736);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_152762_152792(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152762, 152792);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_152807_152829(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152807, 152829);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_152854_152908(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152854, 152908);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_152934_152977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 152934, 152977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_153001_153044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 153001, 153044);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_153068_153111(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 153068, 153111);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_153186_153206(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 153186, 153206);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_153146_153229(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 153146, 153229);
return return_v;
}


string
f_23107_154883_154919(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 154883, 154919);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_154816_154920(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 154816, 154920);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_155122_155163(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155122, 155163);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_155025_155195(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155025, 155195);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_154949_155196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 154949, 155196);
return return_v;
}


int
f_23107_155213_155779(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155213, 155779);
return 0;
}


string
f_23107_155866_155902(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155866, 155902);
return return_v;
}


int
f_23107_155796_155903(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155796, 155903);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_155978_155998(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 155978, 155998);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_156114_156155(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 156114, 156155);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_156017_156187(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 156017, 156187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_155932_156188(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 155932, 156188);
return return_v;
}


int
f_23107_156205_156771(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 156205, 156771);
return 0;
}


string
f_23107_156858_156894(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 156858, 156894);
return return_v;
}


int
f_23107_156788_156895(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 156788, 156895);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,151201,156907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,151201,156907);
}
		}

[Fact]
        public void HoistedAnonymousTypes_Dynamic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,156919,163515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157003,157270);

var 
template = @"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        var <N:0>x = new { A = (dynamic)null, B = 1 }</N:0>;
        yield return 1;
        Console.WriteLine(x.B + <<VALUE>>);
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157284,157347);

var 
source0 = f_23107_157298_157346(f_23107_157311_157345(template, "<<VALUE>>", "0"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157361,157424);

var 
source1 = f_23107_157375_157423(f_23107_157388_157422(template, "<<VALUE>>", "1"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157438,157501);

var 
source2 = f_23107_157452_157500(f_23107_157465_157499(template, "<<VALUE>>", "2"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157517,157618);

var 
compilation0 = f_23107_157536_157617(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157632,157689);

var 
compilation1 = f_23107_157651_157688(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157703,157760);

var 
compilation2 = f_23107_157722_157759(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157776,157816);

var 
v0 = f_23107_157785_157815(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157830,157853);

f_23107_157830_157852(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157867,157932);

var 
md0 = f_23107_157877_157931(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,157948,158001);

var 
f0 = f_23107_157957_158000(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,158015,158068);

var 
f1 = f_23107_158024_158067(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,158082,158135);

var 
f2 = f_23107_158091_158134(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,158151,158253);

var 
generation0 = f_23107_158169_158252(md0, f_23107_158209_158229(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,158269,159724);

var 
baselineIL0 = @"
{
  // Code size       87 (0x57)
  .maxstack  3
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
  IL_0014:  br.s       IL_003d
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldnull
  IL_0022:  ldc.i4.1
  IL_0023:  newobj     ""<>f__AnonymousType0<dynamic, int>..ctor(dynamic, int)""
  IL_0028:  stfld      ""<anonymous type: dynamic A, int B> C.<F>d__0.<x>5__1""
  IL_002d:  ldarg.0
  IL_002e:  ldc.i4.1
  IL_002f:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0034:  ldarg.0
  IL_0035:  ldc.i4.1
  IL_0036:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003b:  ldc.i4.1
  IL_003c:  ret
  IL_003d:  ldarg.0
  IL_003e:  ldc.i4.m1
  IL_003f:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0044:  ldarg.0
  IL_0045:  ldfld      ""<anonymous type: dynamic A, int B> C.<F>d__0.<x>5__1""
  IL_004a:  callvirt   ""int <>f__AnonymousType0<dynamic, int>.B.get""
  IL_004f:  call       ""void System.Console.WriteLine(int)""
  IL_0054:  nop
  IL_0055:  ldc.i4.0
  IL_0056:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,159738,159818);

f_23107_159738_159817(            v0, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", baselineIL0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,159834,160094);

var 
diff1 = f_23107_159846_160093(compilation1, generation0, f_23107_159922_160092(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_160019_160060(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,160110,161611);

var 
baselineIL = @"
{
  // Code size       89 (0x59)
  .maxstack  3
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
  IL_0014:  br.s       IL_003d
  IL_0016:  ldc.i4.0
  IL_0017:  ret
  IL_0018:  ldarg.0
  IL_0019:  ldc.i4.m1
  IL_001a:  stfld      ""int C.<F>d__0.<>1__state""
  IL_001f:  nop
  IL_0020:  ldarg.0
  IL_0021:  ldnull
  IL_0022:  ldc.i4.1
  IL_0023:  newobj     ""<>f__AnonymousType0<dynamic, int>..ctor(dynamic, int)""
  IL_0028:  stfld      ""<anonymous type: dynamic A, int B> C.<F>d__0.<x>5__1""
  IL_002d:  ldarg.0
  IL_002e:  ldc.i4.1
  IL_002f:  stfld      ""int C.<F>d__0.<>2__current""
  IL_0034:  ldarg.0
  IL_0035:  ldc.i4.1
  IL_0036:  stfld      ""int C.<F>d__0.<>1__state""
  IL_003b:  ldc.i4.1
  IL_003c:  ret
  IL_003d:  ldarg.0
  IL_003e:  ldc.i4.m1
  IL_003f:  stfld      ""int C.<F>d__0.<>1__state""
  IL_0044:  ldarg.0
  IL_0045:  ldfld      ""<anonymous type: dynamic A, int B> C.<F>d__0.<x>5__1""
  IL_004a:  callvirt   ""int <>f__AnonymousType0<dynamic, int>.B.get""
  IL_004f:  ldc.i4.<<VALUE>>
  IL_0050:  add
  IL_0051:  call       ""void System.Console.WriteLine(int)""
  IL_0056:  nop
  IL_0057:  ldc.i4.0
  IL_0058:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,161627,162291);

f_23107_161627_162290(
            diff1, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar, <B>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,162307,162415);

f_23107_162307_162414(
            diff1, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_162377_162413(baselineIL, "<<VALUE>>", "1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,162431,162700);

var 
diff2 = f_23107_162443_162699(compilation2, f_23107_162489_162509(diff1), f_23107_162528_162698(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_162625_162666(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,162716,163380);

f_23107_162716_163379(
            diff2, "C: {<F>d__0}", "C.<F>d__0: {<>1__state, <>2__current, <>l__initialThreadId, <>4__this, <x>5__1, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.Int32>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.Int32>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType0<<A>j__TPar, <B>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,163396,163504);

f_23107_163396_163503(
            diff2, "C.<F>d__0.System.Collections.IEnumerator.MoveNext()", f_23107_163466_163502(baselineIL, "<<VALUE>>", "2"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,156919,163515);

string
f_23107_157311_157345(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157311, 157345);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_157298_157346(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157298, 157346);
return return_v;
}


string
f_23107_157388_157422(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157388, 157422);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_157375_157423(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157375, 157423);
return return_v;
}


string
f_23107_157465_157499(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157465, 157499);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_157452_157500(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157452, 157500);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_157536_157617(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157536, 157617);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_157651_157688(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157651, 157688);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_157722_157759(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157722, 157759);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_157785_157815(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157785, 157815);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_157830_157852(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157830, 157852);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_157877_157931(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157877, 157931);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_157957_158000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 157957, 158000);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_158024_158067(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 158024, 158067);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_158091_158134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 158091, 158134);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_158209_158229(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 158209, 158229);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_158169_158252(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 158169, 158252);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_159738_159817(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 159738, 159817);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_160019_160060(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 160019, 160060);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_159922_160092(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 159922, 160092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_159846_160093(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 159846, 160093);
return return_v;
}


int
f_23107_161627_162290(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 161627, 162290);
return 0;
}


string
f_23107_162377_162413(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162377, 162413);
return return_v;
}


int
f_23107_162307_162414(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162307, 162414);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_162489_162509(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 162489, 162509);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_162625_162666(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162625, 162666);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_162528_162698(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162528, 162698);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_162443_162699(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162443, 162699);
return return_v;
}


int
f_23107_162716_163379(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 162716, 163379);
return 0;
}


string
f_23107_163466_163502(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 163466, 163502);
return return_v;
}


int
f_23107_163396_163503(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 163396, 163503);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,156919,163515);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,156919,163515);
}
		}

[Fact, WorkItem(3192, "https://github.com/dotnet/roslyn/issues/3192")]
        public void HoistedAnonymousTypes_Delete()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,163527,169115);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,163674,163964);

var 
source0 = f_23107_163688_163963(@"
using System.Linq;
using System.Threading.Tasks;

class C
{
    static async Task<int> F()
    {
        var <N:1>x = from b in new[] { 1, 2, 3 } <N:0>select new { A = b }</N:0></N:1>;
        return <N:2>await Task.FromResult(1)</N:2>;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,163978,164296);

var 
source1 = f_23107_163992_164295(@"
using System.Linq;
using System.Threading.Tasks;

class C
{
    static async Task<int> F()
    {
        var <N:1>x = from b in new[] { 1, 2, 3 } <N:0>select new { A = b }</N:0></N:1>;
        var y = x.First();
        return <N:2>await Task.FromResult(1)</N:2>;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164310,164332);

var 
source2 = source0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164346,164368);

var 
source3 = source1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164382,164404);

var 
source4 = source0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164418,164440);

var 
source5 = source1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164456,164582);

var 
compilation0 = f_23107_164475_164581(new[] { source0.Tree }, new[] { f_23107_164539_164552()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164596,164653);

var 
compilation1 = f_23107_164615_164652(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164667,164724);

var 
compilation2 = f_23107_164686_164723(compilation0, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164738,164795);

var 
compilation3 = f_23107_164757_164794(compilation0, source3.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164809,164866);

var 
compilation4 = f_23107_164828_164865(compilation0, source4.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164880,164937);

var 
compilation5 = f_23107_164899_164936(compilation0, source5.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,164953,164993);

var 
v0 = f_23107_164962_164992(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165007,165072);

var 
md0 = f_23107_165017_165071(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165088,165141);

var 
f0 = f_23107_165097_165140(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165155,165208);

var 
f1 = f_23107_165164_165207(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165222,165275);

var 
f2 = f_23107_165231_165274(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165289,165342);

var 
f3 = f_23107_165298_165341(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165356,165409);

var 
f4 = f_23107_165365_165408(compilation4, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165423,165476);

var 
f5 = f_23107_165432_165475(compilation5, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165492,165594);

var 
generation0 = f_23107_165510_165593(md0, f_23107_165550_165570(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165638,165898);

var 
diff1 = f_23107_165650_165897(compilation1, generation0, f_23107_165726_165896(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_165823_165864(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,165914,166237);

f_23107_165914_166236(
            diff1, "C: {<>c, <F>d__0}", "C.<>c: {<>9__0_0, <F>b__0_0}", "C.<F>d__0: {<>1__state, <>t__builder, <x>5__1, <y>5__3, <>s__2, <>u__1, MoveNext, SetStateMachine}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,166282,166551);

var 
diff2 = f_23107_166294_166550(compilation2, f_23107_166340_166360(diff1), f_23107_166379_166549(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_166476_166517(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,166752,167075);

f_23107_166752_167074(
            // Synthesized members collection still includes y field since members are only added to it and never deleted.
            // The corresponding CLR field is also present.
            diff2, "C: {<>c, <F>d__0}", "C.<>c: {<>9__0_0, <F>b__0_0}", "C.<F>d__0: {<>1__state, <>t__builder, <x>5__1, <>s__2, <>u__1, MoveNext, SetStateMachine, <y>5__3}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,167159,167427);

var 
diff3 = f_23107_167171_167426(compilation3, f_23107_167217_167237(diff2), f_23107_167256_167425(SemanticEdit.Create(SemanticEditKind.Update,f2,f3,f_23107_167352_167393(source2, source3),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,167443,167775);

f_23107_167443_167774(
            diff3, "C: {<>c, <F>d__0}", "C.<>c: {<>9__0_0, <F>b__0_0}", "C.<F>d__0: {<>1__state, <>t__builder, <x>5__1, <y>5__4, <>s__2, <>u__1, MoveNext, SetStateMachine, <y>5__3}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,167820,168088);

var 
diff4 = f_23107_167832_168087(compilation4, f_23107_167878_167898(diff3), f_23107_167917_168086(SemanticEdit.Create(SemanticEditKind.Update,f3,f4,f_23107_168013_168054(source3, source4),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,168104,168436);

f_23107_168104_168435(
            diff4, "C: {<>c, <F>d__0}", "C.<>c: {<>9__0_0, <F>b__0_0}", "C.<F>d__0: {<>1__state, <>t__builder, <x>5__1, <>s__2, <>u__1, MoveNext, SetStateMachine, <y>5__4, <y>5__3}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,168479,168747);

var 
diff5 = f_23107_168491_168746(compilation5, f_23107_168537_168557(diff4), f_23107_168576_168745(SemanticEdit.Create(SemanticEditKind.Update,f4,f5,f_23107_168672_168713(source4, source5),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,168763,169104);

f_23107_168763_169103(
            diff5, "C: {<>c, <F>d__0}", "C.<>c: {<>9__0_0, <F>b__0_0}", "C.<F>d__0: {<>1__state, <>t__builder, <x>5__1, <y>5__5, <>s__2, <>u__1, MoveNext, SetStateMachine, <y>5__4, <y>5__3}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,163527,169115);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_163688_163963(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 163688, 163963);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_163992_164295(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 163992, 164295);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_164539_164552()
{
var return_v = SystemCoreRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 164539, 164552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164475_164581(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164475, 164581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164615_164652(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164615, 164652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164686_164723(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164686, 164723);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164757_164794(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164757, 164794);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164828_164865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164828, 164865);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_164899_164936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164899, 164936);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_164962_164992(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 164962, 164992);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_165017_165071(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165017, 165071);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165097_165140(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165097, 165140);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165164_165207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165164, 165207);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165231_165274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165231, 165274);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165298_165341(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165298, 165341);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165365_165408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165365, 165408);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_165432_165475(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165432, 165475);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_165550_165570(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165550, 165570);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_165510_165593(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165510, 165593);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_165823_165864(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165823, 165864);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_165726_165896(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165726, 165896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_165650_165897(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165650, 165897);
return return_v;
}


int
f_23107_165914_166236(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 165914, 166236);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_166340_166360(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 166340, 166360);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_166476_166517(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 166476, 166517);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_166379_166549(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 166379, 166549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_166294_166550(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 166294, 166550);
return return_v;
}


int
f_23107_166752_167074(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 166752, 167074);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_167217_167237(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 167217, 167237);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_167352_167393(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167352, 167393);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_167256_167425(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167256, 167425);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_167171_167426(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167171, 167426);
return return_v;
}


int
f_23107_167443_167774(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167443, 167774);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_167878_167898(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 167878, 167898);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_168013_168054(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168013, 168054);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_167917_168086(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167917, 168086);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_167832_168087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 167832, 168087);
return return_v;
}


int
f_23107_168104_168435(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168104, 168435);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_168537_168557(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 168537, 168557);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_168672_168713(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168672, 168713);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_168576_168745(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168576, 168745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_168491_168746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168491, 168746);
return return_v;
}


int
f_23107_168763_169103(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 168763, 169103);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,163527,169115);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,163527,169115);
}
		}

[Fact]
        public void HoistedAnonymousTypes_Dynamic2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,169127,237211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,169212,171009);

var 
source0 = f_23107_169226_171008(@"
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        args = Iterator().ToArray();
    }

    private static IEnumerable<string> Iterator()
    {
        string[] <N:15>args = new[] { ""a"", ""bB"", ""Cc"", ""DD"" }</N:15>;
        var <N:16>list = false ? null : new { Head = (dynamic)null, Tail = (dynamic)null }</N:16>;
        for (int <N:18>i = 0</N:18>; i < 10; i++)
        {
            var <N:6>result =
                from a in args
                <N:0>let x = a.Reverse()</N:0>
                <N:1>let y = x.Reverse()</N:1>
                <N:2>where x.SequenceEqual(y)</N:2>
                orderby <N:3>a.Length ascending</N:3>, <N:4>a descending</N:4>
                <N:5>select new { Value = a, Length = x.Count() }</N:5></N:6>;

            var <N:8>linked = result.Aggregate(
                false ? new { Head = (string)null, Tail = (dynamic)null } : null,
                <N:7>(total, curr) => new { Head = curr.Value, Tail = (dynamic)total }</N:7>)</N:8>;

            while (linked != null)
            {
                <N:9>yield return linked.Head</N:9>;
                linked = linked.Tail;
            }

            var <N:14>newArgs =
                from a in result
                <N:10>let value = a.Value</N:10>
                <N:11>let length = a.Length</N:11>
                <N:12>where value.Length == length</N:12>
                <N:13>select value + value</N:13></N:14>;

            args = args.Concat(newArgs).ToArray();
            list = new { Head = (dynamic)i, Tail = (dynamic)list };
            System.Diagnostics.Debugger.Break();
        }
        System.Diagnostics.Debugger.Break();
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,171023,172855);

var 
source1 = f_23107_171037_172854(@"
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        args = Iterator().ToArray();
    }

    private static IEnumerable<string> Iterator()
    {
        string[] <N:15>args = new[] { ""a"", ""bB"", ""Cc"", ""DD"" }</N:15>;
        var <N:16>list = false ? null : new { Head = (dynamic)null, Tail = (dynamic)null }</N:16>;
        for (int <N:18>i = 0</N:18>; i < 10; i++)
        {
            var <N:6>result =
                from a in args
                <N:0>let x = a.Reverse()</N:0>
                <N:1>let y = x.Reverse()</N:1>
                <N:2>where x.SequenceEqual(y)</N:2>
                orderby <N:3>a.Length ascending</N:3>, <N:4>a descending</N:4>
                <N:5>select new { Value = a, Length = x.Count() }</N:5></N:6>;

            var <N:8>linked = result.Aggregate(
                false ? new { Head = (string)null, Tail = (dynamic)null } : null,
                <N:7>(total, curr) => new { Head = curr.Value, Tail = (dynamic)total }</N:7>)</N:8>;

            var <N:17>temp = list</N:17>;
            while (temp != null)
            {
                <N:9>yield return temp.Head</N:9>;
                temp = temp.Tail;
            }

            var <N:14>newArgs =
                from a in result
                <N:10>let value = a.Value</N:10>
                <N:11>let length = a.Length</N:11>
                <N:12>where value.Length == length</N:12>
                <N:13>select value + value</N:13></N:14>;

            args = args.Concat(newArgs).ToArray();
            list = new { Head = (dynamic)i, Tail = (dynamic)list };
            System.Diagnostics.Debugger.Break();
        }
        System.Diagnostics.Debugger.Break();
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,172869,174712);

var 
source2 = f_23107_172883_174711(@"
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        args = Iterator().ToArray();
    }

    private static IEnumerable<string> Iterator()
    {
        string[] <N:15>args = new[] { ""a"", ""bB"", ""Cc"", ""DD"" }</N:15>;
        var <N:16>list = false ? null : new { Head = (dynamic)null, Tail = (dynamic)null }</N:16>;
        for (int <N:18>i = 0</N:18>; i < 10; i++)
        {
            var <N:6>result =
                from a in args
                <N:0>let x = a.Reverse()</N:0>
                <N:1>let y = x.Reverse()</N:1>
                <N:2>where x.SequenceEqual(y)</N:2>
                orderby <N:3>a.Length ascending</N:3>, <N:4>a descending</N:4>
                <N:5>select new { Value = a, Length = x.Count() }</N:5></N:6>;

            var <N:8>linked = result.Aggregate(
                false ? new { Head = (string)null, Tail = (dynamic)null } : null,
                <N:7>(total, curr) => new { Head = curr.Value, Tail = (dynamic)total }</N:7>)</N:8>;

            var <N:17>temp = list</N:17>;
            while (temp != null)
            {
                <N:9>yield return temp.Head.ToString()</N:9>;
                temp = temp.Tail;
            }

            var <N:14>newArgs =
                from a in result
                <N:10>let value = a.Value</N:10>
                <N:11>let length = a.Length</N:11>
                <N:12>where value.Length == length</N:12>
                <N:13>select value + value</N:13></N:14>;

            args = args.Concat(newArgs).ToArray();
            list = new { Head = (dynamic)i, Tail = (dynamic)list };
            System.Diagnostics.Debugger.Break();
        }
        System.Diagnostics.Debugger.Break();
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,174726,174863);

var 
compilation0 = f_23107_174745_174862(new[] { source0.Tree }, new[] { f_23107_174809_174822(), f_23107_174824_174833()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,174877,174934);

var 
compilation1 = f_23107_174896_174933(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,174948,175005);

var 
compilation2 = f_23107_174967_175004(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175021,175061);

var 
v0 = f_23107_175030_175060(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175075,175098);

f_23107_175075_175097(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175112,175177);

var 
md0 = f_23107_175122_175176(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175193,175259);

var 
f0 = f_23107_175202_175258(compilation0, "Program.Iterator")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175273,175339);

var 
f1 = f_23107_175282_175338(compilation1, "Program.Iterator")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175353,175419);

var 
f2 = f_23107_175362_175418(compilation2, "Program.Iterator")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175435,175537);

var 
generation0 = f_23107_175453_175536(md0, f_23107_175493_175513(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,175553,203138);

f_23107_175553_203137(
            v0, "Program.<Iterator>d__1.System.Collections.IEnumerator.MoveNext()", @"
{
  // Code size      798 (0x31e)
  .maxstack  5
  .locals init (int V_0,
                bool V_1,
                int V_2,
                bool V_3)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0012
  IL_000a:  br.s       IL_000c
  IL_000c:  ldloc.0
  IL_000d:  ldc.i4.1
  IL_000e:  beq.s      IL_0014
  IL_0010:  br.s       IL_0019
  IL_0012:  br.s       IL_001b
  IL_0014:  br         IL_019b
  IL_0019:  ldc.i4.0
  IL_001a:  ret
  IL_001b:  ldarg.0
  IL_001c:  ldc.i4.m1
  IL_001d:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_0022:  nop
  IL_0023:  ldarg.0
  IL_0024:  ldc.i4.4
  IL_0025:  newarr     ""string""
  IL_002a:  dup
  IL_002b:  ldc.i4.0
  IL_002c:  ldstr      ""a""
  IL_0031:  stelem.ref
  IL_0032:  dup
  IL_0033:  ldc.i4.1
  IL_0034:  ldstr      ""bB""
  IL_0039:  stelem.ref
  IL_003a:  dup
  IL_003b:  ldc.i4.2
  IL_003c:  ldstr      ""Cc""
  IL_0041:  stelem.ref
  IL_0042:  dup
  IL_0043:  ldc.i4.3
  IL_0044:  ldstr      ""DD""
  IL_0049:  stelem.ref
  IL_004a:  stfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_004f:  ldarg.0
  IL_0050:  ldnull
  IL_0051:  ldnull
  IL_0052:  newobj     ""<>f__AnonymousType0<dynamic, dynamic>..ctor(dynamic, dynamic)""
  IL_0057:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_005c:  ldarg.0
  IL_005d:  ldc.i4.0
  IL_005e:  stfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0063:  br         IL_0305
  IL_0068:  nop
  IL_0069:  ldarg.0
  IL_006a:  ldarg.0
  IL_006b:  ldfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_0070:  ldsfld     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> Program.<>c.<>9__1_0""
  IL_0075:  dup
  IL_0076:  brtrue.s   IL_008f
  IL_0078:  pop
  IL_0079:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_007e:  ldftn      ""<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> Program.<>c.<Iterator>b__1_0(string)""
  IL_0084:  newobj     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>..ctor(object, System.IntPtr)""
  IL_0089:  dup
  IL_008a:  stsfld     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> Program.<>c.<>9__1_0""
  IL_008f:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> System.Linq.Enumerable.Select<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>(System.Collections.Generic.IEnumerable<string>, System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>)""
  IL_0094:  ldsfld     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> Program.<>c.<>9__1_1""
  IL_0099:  dup
  IL_009a:  brtrue.s   IL_00b3
  IL_009c:  pop
  IL_009d:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00a2:  ldftn      ""<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y> Program.<>c.<Iterator>b__1_1(<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>)""
  IL_00a8:  newobj     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>..ctor(object, System.IntPtr)""
  IL_00ad:  dup
  IL_00ae:  stsfld     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> Program.<>c.<>9__1_1""
  IL_00b3:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.Select<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>(System.Collections.Generic.IEnumerable<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>, System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>)""
  IL_00b8:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool> Program.<>c.<>9__1_2""
  IL_00bd:  dup
  IL_00be:  brtrue.s   IL_00d7
  IL_00c0:  pop
  IL_00c1:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00c6:  ldftn      ""bool Program.<>c.<Iterator>b__1_2(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_00cc:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool>..ctor(object, System.IntPtr)""
  IL_00d1:  dup
  IL_00d2:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool> Program.<>c.<>9__1_2""
  IL_00d7:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.Where<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool>)""
  IL_00dc:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int> Program.<>c.<>9__1_3""
  IL_00e1:  dup
  IL_00e2:  brtrue.s   IL_00fb
  IL_00e4:  pop
  IL_00e5:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00ea:  ldftn      ""int Program.<>c.<Iterator>b__1_3(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_00f0:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>..ctor(object, System.IntPtr)""
  IL_00f5:  dup
  IL_00f6:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int> Program.<>c.<>9__1_3""
  IL_00fb:  call       ""System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.OrderBy<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>)""
  IL_0100:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string> Program.<>c.<>9__1_4""
  IL_0105:  dup
  IL_0106:  brtrue.s   IL_011f
  IL_0108:  pop
  IL_0109:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_010e:  ldftn      ""string Program.<>c.<Iterator>b__1_4(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_0114:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>..ctor(object, System.IntPtr)""
  IL_0119:  dup
  IL_011a:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string> Program.<>c.<>9__1_4""
  IL_011f:  call       ""System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.ThenByDescending<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>(System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>)""
  IL_0124:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>> Program.<>c.<>9__1_5""
  IL_0129:  dup
  IL_012a:  brtrue.s   IL_0143
  IL_012c:  pop
  IL_012d:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0132:  ldftn      ""<anonymous type: string Value, int Length> Program.<>c.<Iterator>b__1_5(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_0138:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>..ctor(object, System.IntPtr)""
  IL_013d:  dup
  IL_013e:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>> Program.<>c.<>9__1_5""
  IL_0143:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>)""
  IL_0148:  stfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_014d:  ldarg.0
  IL_014e:  ldarg.0
  IL_014f:  ldfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_0154:  ldnull
  IL_0155:  ldsfld     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>> Program.<>c.<>9__1_6""
  IL_015a:  dup
  IL_015b:  brtrue.s   IL_0174
  IL_015d:  pop
  IL_015e:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0163:  ldftn      ""<anonymous type: string Head, dynamic Tail> Program.<>c.<Iterator>b__1_6(<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>)""
  IL_0169:  newobj     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>..ctor(object, System.IntPtr)""
  IL_016e:  dup
  IL_016f:  stsfld     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>> Program.<>c.<>9__1_6""
  IL_0174:  call       ""<anonymous type: string Head, dynamic Tail> System.Linq.Enumerable.Aggregate<<anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>(System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>>, <anonymous type: string Head, dynamic Tail>, System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>)""
  IL_0179:  stfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_017e:  br.s       IL_01f5
  IL_0180:  nop
  IL_0181:  ldarg.0
  IL_0182:  ldarg.0
  IL_0183:  ldfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_0188:  callvirt   ""string <>f__AnonymousType0<string, dynamic>.Head.get""
  IL_018d:  stfld      ""string Program.<Iterator>d__1.<>2__current""
  IL_0192:  ldarg.0
  IL_0193:  ldc.i4.1
  IL_0194:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_0199:  ldc.i4.1
  IL_019a:  ret
  IL_019b:  ldarg.0
  IL_019c:  ldc.i4.m1
  IL_019d:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_01a2:  ldarg.0
  IL_01a3:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>> Program.<>o__1.<>p__0""
  IL_01a8:  brfalse.s  IL_01ac
  IL_01aa:  br.s       IL_01d0
  IL_01ac:  ldc.i4.0
  IL_01ad:  ldtoken    ""<>f__AnonymousType0<string, dynamic>""
  IL_01b2:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_01b7:  ldtoken    ""Program""
  IL_01bc:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_01c1:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_01c6:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_01cb:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>> Program.<>o__1.<>p__0""
  IL_01d0:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>> Program.<>o__1.<>p__0""
  IL_01d5:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>>.Target""
  IL_01da:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>> Program.<>o__1.<>p__0""
  IL_01df:  ldarg.0
  IL_01e0:  ldfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_01e5:  callvirt   ""dynamic <>f__AnonymousType0<string, dynamic>.Tail.get""
  IL_01ea:  callvirt   ""<anonymous type: string Head, dynamic Tail> System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: string Head, dynamic Tail>>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_01ef:  stfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_01f4:  nop
  IL_01f5:  ldarg.0
  IL_01f6:  ldfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_01fb:  ldnull
  IL_01fc:  cgt.un
  IL_01fe:  stloc.1
  IL_01ff:  ldloc.1
  IL_0200:  brtrue     IL_0180
  IL_0205:  ldarg.0
  IL_0206:  ldarg.0
  IL_0207:  ldfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_020c:  ldsfld     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>> Program.<>c.<>9__1_7""
  IL_0211:  dup
  IL_0212:  brtrue.s   IL_022b
  IL_0214:  pop
  IL_0215:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_021a:  ldftn      ""<anonymous type: <anonymous type: string Value, int Length> a, string value> Program.<>c.<Iterator>b__1_7(<anonymous type: string Value, int Length>)""
  IL_0220:  newobj     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>..ctor(object, System.IntPtr)""
  IL_0225:  dup
  IL_0226:  stsfld     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>> Program.<>c.<>9__1_7""
  IL_022b:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string Value, int Length> a, string value>> System.Linq.Enumerable.Select<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>(System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>>, System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>)""
  IL_0230:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> Program.<>c.<>9__1_8""
  IL_0235:  dup
  IL_0236:  brtrue.s   IL_024f
  IL_0238:  pop
  IL_0239:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_023e:  ldftn      ""<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length> Program.<>c.<Iterator>b__1_8(<anonymous type: <anonymous type: string Value, int Length> a, string value>)""
  IL_0244:  newobj     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>..ctor(object, System.IntPtr)""
  IL_0249:  dup
  IL_024a:  stsfld     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> Program.<>c.<>9__1_8""
  IL_024f:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string Value, int Length> a, string value>>, System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>)""
  IL_0254:  ldsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool> Program.<>c.<>9__1_9""
  IL_0259:  dup
  IL_025a:  brtrue.s   IL_0273
  IL_025c:  pop
  IL_025d:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0262:  ldftn      ""bool Program.<>c.<Iterator>b__1_9(<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>)""
  IL_0268:  newobj     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool>..ctor(object, System.IntPtr)""
  IL_026d:  dup
  IL_026e:  stsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool> Program.<>c.<>9__1_9""
  IL_0273:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> System.Linq.Enumerable.Where<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>, System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool>)""
  IL_0278:  ldsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string> Program.<>c.<>9__1_10""
  IL_027d:  dup
  IL_027e:  brtrue.s   IL_0297
  IL_0280:  pop
  IL_0281:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0286:  ldftn      ""string Program.<>c.<Iterator>b__1_10(<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>)""
  IL_028c:  newobj     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>..ctor(object, System.IntPtr)""
  IL_0291:  dup
  IL_0292:  stsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string> Program.<>c.<>9__1_10""
  IL_0297:  call       ""System.Collections.Generic.IEnumerable<string> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>, System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>)""
  IL_029c:  stfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_02a1:  ldarg.0
  IL_02a2:  ldarg.0
  IL_02a3:  ldfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_02a8:  ldarg.0
  IL_02a9:  ldfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_02ae:  call       ""System.Collections.Generic.IEnumerable<string> System.Linq.Enumerable.Concat<string>(System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>)""
  IL_02b3:  call       ""string[] System.Linq.Enumerable.ToArray<string>(System.Collections.Generic.IEnumerable<string>)""
  IL_02b8:  stfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_02bd:  ldarg.0
  IL_02be:  ldarg.0
  IL_02bf:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_02c4:  box        ""int""
  IL_02c9:  ldarg.0
  IL_02ca:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_02cf:  newobj     ""<>f__AnonymousType0<dynamic, dynamic>..ctor(dynamic, dynamic)""
  IL_02d4:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_02d9:  call       ""void System.Diagnostics.Debugger.Break()""
  IL_02de:  nop
  IL_02df:  nop
  IL_02e0:  ldarg.0
  IL_02e1:  ldnull
  IL_02e2:  stfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_02e7:  ldarg.0
  IL_02e8:  ldnull
  IL_02e9:  stfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_02ee:  ldarg.0
  IL_02ef:  ldnull
  IL_02f0:  stfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_02f5:  ldarg.0
  IL_02f6:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_02fb:  stloc.2
  IL_02fc:  ldarg.0
  IL_02fd:  ldloc.2
  IL_02fe:  ldc.i4.1
  IL_02ff:  add
  IL_0300:  stfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0305:  ldarg.0
  IL_0306:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_030b:  ldc.i4.s   10
  IL_030d:  clt
  IL_030f:  stloc.3
  IL_0310:  ldloc.3
  IL_0311:  brtrue     IL_0068
  IL_0316:  call       ""void System.Diagnostics.Debugger.Break()""
  IL_031b:  nop
  IL_031c:  ldc.i4.0
  IL_031d:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,203154,203414);

var 
diff1 = f_23107_203166_203413(compilation1, generation0, f_23107_203242_203412(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_203339_203380(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,203430,205166);

f_23107_203430_205165(
            diff1, "Program.<>o__1#1: {<>p__0, <>p__1}", "Program: {<>o__1#1, <>c, <Iterator>d__1}", "Program.<>c: {<>9__1_0, <>9__1_1, <>9__1_2, <>9__1_3, <>9__1_4, <>9__1_5, <>9__1_6, <>9__1_7, <>9__1_8, <>9__1_9, <>9__1_10, <Iterator>b__1_0, <Iterator>b__1_1, <Iterator>b__1_2, <Iterator>b__1_3, <Iterator>b__1_4, <Iterator>b__1_5, <Iterator>b__1_6, <Iterator>b__1_7, <Iterator>b__1_8, <Iterator>b__1_9, <Iterator>b__1_10}", "Program.<Iterator>d__1: {<>1__state, <>2__current, <>l__initialThreadId, <args>5__1, <list>5__2, <i>5__3, <result>5__4, <linked>5__5, <temp>5__7, <newArgs>5__6, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.String>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.String>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.String>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType4<<a>j__TPar, <value>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType3<<Value>j__TPar, <Length>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType5<<<>h__TransparentIdentifier0>j__TPar, <length>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType2<<<>h__TransparentIdentifier0>j__TPar, <y>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType0<<Head>j__TPar, <Tail>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType1<<a>j__TPar, <x>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,205182,235090);

f_23107_205182_235089(
            diff1, "Program.<Iterator>d__1.System.Collections.IEnumerator.MoveNext()", @"
{
  // Code size      885 (0x375)
  .maxstack  5
  .locals init (int V_0,
                bool V_1,
                int V_2,
                bool V_3)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0012
  IL_000a:  br.s       IL_000c
  IL_000c:  ldloc.0
  IL_000d:  ldc.i4.1
  IL_000e:  beq.s      IL_0014
  IL_0010:  br.s       IL_0019
  IL_0012:  br.s       IL_001b
  IL_0014:  br         IL_01eb
  IL_0019:  ldc.i4.0
  IL_001a:  ret
  IL_001b:  ldarg.0
  IL_001c:  ldc.i4.m1
  IL_001d:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_0022:  nop
  IL_0023:  ldarg.0
  IL_0024:  ldc.i4.4
  IL_0025:  newarr     ""string""
  IL_002a:  dup
  IL_002b:  ldc.i4.0
  IL_002c:  ldstr      ""a""
  IL_0031:  stelem.ref
  IL_0032:  dup
  IL_0033:  ldc.i4.1
  IL_0034:  ldstr      ""bB""
  IL_0039:  stelem.ref
  IL_003a:  dup
  IL_003b:  ldc.i4.2
  IL_003c:  ldstr      ""Cc""
  IL_0041:  stelem.ref
  IL_0042:  dup
  IL_0043:  ldc.i4.3
  IL_0044:  ldstr      ""DD""
  IL_0049:  stelem.ref
  IL_004a:  stfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_004f:  ldarg.0
  IL_0050:  ldnull
  IL_0051:  ldnull
  IL_0052:  newobj     ""<>f__AnonymousType0<dynamic, dynamic>..ctor(dynamic, dynamic)""
  IL_0057:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_005c:  ldarg.0
  IL_005d:  ldc.i4.0
  IL_005e:  stfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0063:  br         IL_035c
  IL_0068:  nop
  IL_0069:  ldarg.0
  IL_006a:  ldarg.0
  IL_006b:  ldfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_0070:  ldsfld     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> Program.<>c.<>9__1_0""
  IL_0075:  dup
  IL_0076:  brtrue.s   IL_008f
  IL_0078:  pop
  IL_0079:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_007e:  ldftn      ""<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> Program.<>c.<Iterator>b__1_0(string)""
  IL_0084:  newobj     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>..ctor(object, System.IntPtr)""
  IL_0089:  dup
  IL_008a:  stsfld     ""System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> Program.<>c.<>9__1_0""
  IL_008f:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>> System.Linq.Enumerable.Select<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>(System.Collections.Generic.IEnumerable<string>, System.Func<string, <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>)""
  IL_0094:  ldsfld     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> Program.<>c.<>9__1_1""
  IL_0099:  dup
  IL_009a:  brtrue.s   IL_00b3
  IL_009c:  pop
  IL_009d:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00a2:  ldftn      ""<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y> Program.<>c.<Iterator>b__1_1(<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>)""
  IL_00a8:  newobj     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>..ctor(object, System.IntPtr)""
  IL_00ad:  dup
  IL_00ae:  stsfld     ""System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> Program.<>c.<>9__1_1""
  IL_00b3:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.Select<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>(System.Collections.Generic.IEnumerable<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>>, System.Func<<anonymous type: string a, System.Collections.Generic.IEnumerable<char> x>, <anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>)""
  IL_00b8:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool> Program.<>c.<>9__1_2""
  IL_00bd:  dup
  IL_00be:  brtrue.s   IL_00d7
  IL_00c0:  pop
  IL_00c1:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00c6:  ldftn      ""bool Program.<>c.<Iterator>b__1_2(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_00cc:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool>..ctor(object, System.IntPtr)""
  IL_00d1:  dup
  IL_00d2:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool> Program.<>c.<>9__1_2""
  IL_00d7:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.Where<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, bool>)""
  IL_00dc:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int> Program.<>c.<>9__1_3""
  IL_00e1:  dup
  IL_00e2:  brtrue.s   IL_00fb
  IL_00e4:  pop
  IL_00e5:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_00ea:  ldftn      ""int Program.<>c.<Iterator>b__1_3(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_00f0:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>..ctor(object, System.IntPtr)""
  IL_00f5:  dup
  IL_00f6:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int> Program.<>c.<>9__1_3""
  IL_00fb:  call       ""System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.OrderBy<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, int>)""
  IL_0100:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string> Program.<>c.<>9__1_4""
  IL_0105:  dup
  IL_0106:  brtrue.s   IL_011f
  IL_0108:  pop
  IL_0109:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_010e:  ldftn      ""string Program.<>c.<Iterator>b__1_4(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_0114:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>..ctor(object, System.IntPtr)""
  IL_0119:  dup
  IL_011a:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string> Program.<>c.<>9__1_4""
  IL_011f:  call       ""System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>> System.Linq.Enumerable.ThenByDescending<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>(System.Linq.IOrderedEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, string>)""
  IL_0124:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>> Program.<>c.<>9__1_5""
  IL_0129:  dup
  IL_012a:  brtrue.s   IL_0143
  IL_012c:  pop
  IL_012d:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0132:  ldftn      ""<anonymous type: string Value, int Length> Program.<>c.<Iterator>b__1_5(<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>)""
  IL_0138:  newobj     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>..ctor(object, System.IntPtr)""
  IL_013d:  dup
  IL_013e:  stsfld     ""System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>> Program.<>c.<>9__1_5""
  IL_0143:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>>, System.Func<<anonymous type: <anonymous type: string a, System.Collections.Generic.IEnumerable<char> x> <>h__TransparentIdentifier0, System.Collections.Generic.IEnumerable<char> y>, <anonymous type: string Value, int Length>>)""
  IL_0148:  stfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_014d:  ldarg.0
  IL_014e:  ldarg.0
  IL_014f:  ldfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_0154:  ldnull
  IL_0155:  ldsfld     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>> Program.<>c.<>9__1_6""
  IL_015a:  dup
  IL_015b:  brtrue.s   IL_0174
  IL_015d:  pop
  IL_015e:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_0163:  ldftn      ""<anonymous type: string Head, dynamic Tail> Program.<>c.<Iterator>b__1_6(<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>)""
  IL_0169:  newobj     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>..ctor(object, System.IntPtr)""
  IL_016e:  dup
  IL_016f:  stsfld     ""System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>> Program.<>c.<>9__1_6""
  IL_0174:  call       ""<anonymous type: string Head, dynamic Tail> System.Linq.Enumerable.Aggregate<<anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>(System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>>, <anonymous type: string Head, dynamic Tail>, System.Func<<anonymous type: string Head, dynamic Tail>, <anonymous type: string Value, int Length>, <anonymous type: string Head, dynamic Tail>>)""
  IL_0179:  stfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_017e:  ldarg.0
  IL_017f:  ldarg.0
  IL_0180:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_0185:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_018a:  br         IL_0245
  IL_018f:  nop
  IL_0190:  ldarg.0
  IL_0191:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>> Program.<>o__1#1.<>p__0""
  IL_0196:  brfalse.s  IL_019a
  IL_0198:  br.s       IL_01be
  IL_019a:  ldc.i4.0
  IL_019b:  ldtoken    ""string""
  IL_01a0:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_01a5:  ldtoken    ""Program""
  IL_01aa:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_01af:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_01b4:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_01b9:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>> Program.<>o__1#1.<>p__0""
  IL_01be:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>> Program.<>o__1#1.<>p__0""
  IL_01c3:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>>.Target""
  IL_01c8:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>> Program.<>o__1#1.<>p__0""
  IL_01cd:  ldarg.0
  IL_01ce:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_01d3:  callvirt   ""dynamic <>f__AnonymousType0<dynamic, dynamic>.Head.get""
  IL_01d8:  callvirt   ""string System.Func<System.Runtime.CompilerServices.CallSite, dynamic, string>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_01dd:  stfld      ""string Program.<Iterator>d__1.<>2__current""
  IL_01e2:  ldarg.0
  IL_01e3:  ldc.i4.1
  IL_01e4:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_01e9:  ldc.i4.1
  IL_01ea:  ret
  IL_01eb:  ldarg.0
  IL_01ec:  ldc.i4.m1
  IL_01ed:  stfld      ""int Program.<Iterator>d__1.<>1__state""
  IL_01f2:  ldarg.0
  IL_01f3:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>> Program.<>o__1#1.<>p__1""
  IL_01f8:  brfalse.s  IL_01fc
  IL_01fa:  br.s       IL_0220
  IL_01fc:  ldc.i4.0
  IL_01fd:  ldtoken    ""<>f__AnonymousType0<dynamic, dynamic>""
  IL_0202:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0207:  ldtoken    ""Program""
  IL_020c:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_0211:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.Convert(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, System.Type, System.Type)""
  IL_0216:  call       ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_021b:  stsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>> Program.<>o__1#1.<>p__1""
  IL_0220:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>> Program.<>o__1#1.<>p__1""
  IL_0225:  ldfld      ""System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>> System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>>.Target""
  IL_022a:  ldsfld     ""System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>> Program.<>o__1#1.<>p__1""
  IL_022f:  ldarg.0
  IL_0230:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_0235:  callvirt   ""dynamic <>f__AnonymousType0<dynamic, dynamic>.Tail.get""
  IL_023a:  callvirt   ""<anonymous type: dynamic Head, dynamic Tail> System.Func<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: dynamic Head, dynamic Tail>>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic)""
  IL_023f:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_0244:  nop
  IL_0245:  ldarg.0
  IL_0246:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_024b:  ldnull
  IL_024c:  cgt.un
  IL_024e:  stloc.1
  IL_024f:  ldloc.1
  IL_0250:  brtrue     IL_018f
  IL_0255:  ldarg.0
  IL_0256:  ldarg.0
  IL_0257:  ldfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_025c:  ldsfld     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>> Program.<>c.<>9__1_7""
  IL_0261:  dup
  IL_0262:  brtrue.s   IL_027b
  IL_0264:  pop
  IL_0265:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_026a:  ldftn      ""<anonymous type: <anonymous type: string Value, int Length> a, string value> Program.<>c.<Iterator>b__1_7(<anonymous type: string Value, int Length>)""
  IL_0270:  newobj     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>..ctor(object, System.IntPtr)""
  IL_0275:  dup
  IL_0276:  stsfld     ""System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>> Program.<>c.<>9__1_7""
  IL_027b:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string Value, int Length> a, string value>> System.Linq.Enumerable.Select<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>(System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>>, System.Func<<anonymous type: string Value, int Length>, <anonymous type: <anonymous type: string Value, int Length> a, string value>>)""
  IL_0280:  ldsfld     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> Program.<>c.<>9__1_8""
  IL_0285:  dup
  IL_0286:  brtrue.s   IL_029f
  IL_0288:  pop
  IL_0289:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_028e:  ldftn      ""<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length> Program.<>c.<Iterator>b__1_8(<anonymous type: <anonymous type: string Value, int Length> a, string value>)""
  IL_0294:  newobj     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>..ctor(object, System.IntPtr)""
  IL_0299:  dup
  IL_029a:  stsfld     ""System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> Program.<>c.<>9__1_8""
  IL_029f:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: string Value, int Length> a, string value>>, System.Func<<anonymous type: <anonymous type: string Value, int Length> a, string value>, <anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>)""
  IL_02a4:  ldsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool> Program.<>c.<>9__1_9""
  IL_02a9:  dup
  IL_02aa:  brtrue.s   IL_02c3
  IL_02ac:  pop
  IL_02ad:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_02b2:  ldftn      ""bool Program.<>c.<Iterator>b__1_9(<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>)""
  IL_02b8:  newobj     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool>..ctor(object, System.IntPtr)""
  IL_02bd:  dup
  IL_02be:  stsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool> Program.<>c.<>9__1_9""
  IL_02c3:  call       ""System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>> System.Linq.Enumerable.Where<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>, System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, bool>)""
  IL_02c8:  ldsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string> Program.<>c.<>9__1_10""
  IL_02cd:  dup
  IL_02ce:  brtrue.s   IL_02e7
  IL_02d0:  pop
  IL_02d1:  ldsfld     ""Program.<>c Program.<>c.<>9""
  IL_02d6:  ldftn      ""string Program.<>c.<Iterator>b__1_10(<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>)""
  IL_02dc:  newobj     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>..ctor(object, System.IntPtr)""
  IL_02e1:  dup
  IL_02e2:  stsfld     ""System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string> Program.<>c.<>9__1_10""
  IL_02e7:  call       ""System.Collections.Generic.IEnumerable<string> System.Linq.Enumerable.Select<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>(System.Collections.Generic.IEnumerable<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>>, System.Func<<anonymous type: <anonymous type: <anonymous type: string Value, int Length> a, string value> <>h__TransparentIdentifier0, int length>, string>)""
  IL_02ec:  stfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_02f1:  ldarg.0
  IL_02f2:  ldarg.0
  IL_02f3:  ldfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_02f8:  ldarg.0
  IL_02f9:  ldfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_02fe:  call       ""System.Collections.Generic.IEnumerable<string> System.Linq.Enumerable.Concat<string>(System.Collections.Generic.IEnumerable<string>, System.Collections.Generic.IEnumerable<string>)""
  IL_0303:  call       ""string[] System.Linq.Enumerable.ToArray<string>(System.Collections.Generic.IEnumerable<string>)""
  IL_0308:  stfld      ""string[] Program.<Iterator>d__1.<args>5__1""
  IL_030d:  ldarg.0
  IL_030e:  ldarg.0
  IL_030f:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0314:  box        ""int""
  IL_0319:  ldarg.0
  IL_031a:  ldfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_031f:  newobj     ""<>f__AnonymousType0<dynamic, dynamic>..ctor(dynamic, dynamic)""
  IL_0324:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<list>5__2""
  IL_0329:  call       ""void System.Diagnostics.Debugger.Break()""
  IL_032e:  nop
  IL_032f:  nop
  IL_0330:  ldarg.0
  IL_0331:  ldnull
  IL_0332:  stfld      ""System.Collections.Generic.IEnumerable<<anonymous type: string Value, int Length>> Program.<Iterator>d__1.<result>5__4""
  IL_0337:  ldarg.0
  IL_0338:  ldnull
  IL_0339:  stfld      ""<anonymous type: string Head, dynamic Tail> Program.<Iterator>d__1.<linked>5__5""
  IL_033e:  ldarg.0
  IL_033f:  ldnull
  IL_0340:  stfld      ""<anonymous type: dynamic Head, dynamic Tail> Program.<Iterator>d__1.<temp>5__7""
  IL_0345:  ldarg.0
  IL_0346:  ldnull
  IL_0347:  stfld      ""System.Collections.Generic.IEnumerable<string> Program.<Iterator>d__1.<newArgs>5__6""
  IL_034c:  ldarg.0
  IL_034d:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0352:  stloc.2
  IL_0353:  ldarg.0
  IL_0354:  ldloc.2
  IL_0355:  ldc.i4.1
  IL_0356:  add
  IL_0357:  stfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_035c:  ldarg.0
  IL_035d:  ldfld      ""int Program.<Iterator>d__1.<i>5__3""
  IL_0362:  ldc.i4.s   10
  IL_0364:  clt
  IL_0366:  stloc.3
  IL_0367:  ldloc.3
  IL_0368:  brtrue     IL_0068
  IL_036d:  call       ""void System.Diagnostics.Debugger.Break()""
  IL_0372:  nop
  IL_0373:  ldc.i4.0
  IL_0374:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,235106,235375);

var 
diff2 = f_23107_235118_235374(compilation2, f_23107_235164_235184(diff1), f_23107_235203_235373(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23107_235300_235341(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,235391,237200);

f_23107_235391_237199(
            diff2, "Program.<>o__1#1: {<>p__0, <>p__1}", "Program.<>o__1#2: {<>p__0, <>p__1, <>p__2}", "Program: {<>o__1#2, <>c, <Iterator>d__1, <>o__1#1}", "Program.<>c: {<>9__1_0, <>9__1_1, <>9__1_2, <>9__1_3, <>9__1_4, <>9__1_5, <>9__1_6, <>9__1_7, <>9__1_8, <>9__1_9, <>9__1_10, <Iterator>b__1_0, <Iterator>b__1_1, <Iterator>b__1_2, <Iterator>b__1_3, <Iterator>b__1_4, <Iterator>b__1_5, <Iterator>b__1_6, <Iterator>b__1_7, <Iterator>b__1_8, <Iterator>b__1_9, <Iterator>b__1_10}", "Program.<Iterator>d__1: {<>1__state, <>2__current, <>l__initialThreadId, <args>5__1, <list>5__2, <i>5__3, <result>5__4, <linked>5__5, <temp>5__7, <newArgs>5__6, System.IDisposable.Dispose, MoveNext, System.Collections.Generic.IEnumerator<System.String>.get_Current, System.Collections.IEnumerator.Reset, System.Collections.IEnumerator.get_Current, System.Collections.Generic.IEnumerable<System.String>.GetEnumerator, System.Collections.IEnumerable.GetEnumerator, System.Collections.Generic.IEnumerator<System.String>.Current, System.Collections.IEnumerator.Current}", "<>f__AnonymousType4<<a>j__TPar, <value>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType1<<a>j__TPar, <x>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType3<<Value>j__TPar, <Length>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType0<<Head>j__TPar, <Tail>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType5<<<>h__TransparentIdentifier0>j__TPar, <length>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType2<<<>h__TransparentIdentifier0>j__TPar, <y>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,169127,237211);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_169226_171008(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 169226, 171008);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_171037_172854(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 171037, 172854);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_172883_174711(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 172883, 174711);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_174809_174822()
{
var return_v = SystemCoreRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 174809, 174822);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23107_174824_174833()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 174824, 174833);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_174745_174862(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 174745, 174862);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_174896_174933(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 174896, 174933);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_174967_175004(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 174967, 175004);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_175030_175060(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175030, 175060);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_175075_175097(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175075, 175097);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_175122_175176(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175122, 175176);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_175202_175258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175202, 175258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_175282_175338(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175282, 175338);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_175362_175418(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175362, 175418);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_175493_175513(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175493, 175513);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_175453_175536(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175453, 175536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_175553_203137(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 175553, 203137);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_203339_203380(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 203339, 203380);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_203242_203412(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 203242, 203412);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_203166_203413(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 203166, 203413);
return return_v;
}


int
f_23107_203430_205165(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 203430, 205165);
return 0;
}


int
f_23107_205182_235089(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 205182, 235089);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_235164_235184(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 235164, 235184);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_235300_235341(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 235300, 235341);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_235203_235373(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 235203, 235373);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_235118_235374(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 235118, 235374);
return return_v;
}


int
f_23107_235391_237199(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 235391, 237199);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,169127,237211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,169127,237211);
}
		}

[Fact, WorkItem(9119, "https://github.com/dotnet/roslyn/issues/9119")]
        public void MissingIteratorStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,237223,239415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,237378,237624);

var 
source0 = f_23107_237392_237623(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>yield return 0;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,237638,237884);

var 
source1 = f_23107_237652_237883(@"
using System;
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return 1;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,237900,238001);

var 
compilation0 = f_23107_237919_238000(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238015,238072);

var 
compilation1 = f_23107_238034_238071(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238175,238309);

f_23107_238175_238308(f_23107_238187_238307(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238325,238365);

var 
v0 = f_23107_238334_238364(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238379,238402);

f_23107_238379_238401(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238416,238481);

var 
md0 = f_23107_238426_238480(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238497,238550);

var 
f0 = f_23107_238506_238549(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238564,238617);

var 
f1 = f_23107_238573_238616(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238633,238735);

var 
generation0 = f_23107_238651_238734(md0, f_23107_238691_238711(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,238751,239011);

var 
diff1 = f_23107_238763_239010(compilation1, generation0, f_23107_238839_239009(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_238936_238977(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,239027,239404);

diff1.EmitResult.Diagnostics.Verify(f_23107_239232_239402(f_23107_239232_239382(f_23107_239232_239294(ErrorCode.ERR_EncUpdateFailedMissingAttribute, "F"), "C.F()", "System.Runtime.CompilerServices.IteratorStateMachineAttribute"), 7, 29));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,237223,239415);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_237392_237623(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 237392, 237623);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_237652_237883(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 237652, 237883);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_237919_238000(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 237919, 238000);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_238034_238071(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238034, 238071);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_238187_238307(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238187, 238307);
return return_v;
}


int
f_23107_238175_238308(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238175, 238308);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_238334_238364(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238334, 238364);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_238379_238401(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238379, 238401);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_238426_238480(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238426, 238480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_238506_238549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238506, 238549);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_238573_238616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238573, 238616);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_238691_238711(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238691, 238711);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_238651_238734(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238651, 238734);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_238936_238977(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238936, 238977);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_238839_239009(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238839, 239009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_238763_239010(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 238763, 239010);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_239232_239294(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 239232, 239294);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_239232_239382(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 239232, 239382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_239232_239402(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 239232, 239402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,237223,239415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,237223,239415);
}
		}

[Fact, WorkItem(9119, "https://github.com/dotnet/roslyn/issues/9119")]
        public void BadIteratorStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,239427,241846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,239578,239939);

var 
source0 = f_23107_239592_239938(@"
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>yield return 0;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,239953,240314);

var 
source1 = f_23107_239967_240313(@"
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return 1;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240330,240417);

var 
compilation0 = f_23107_240349_240416(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240431,240488);

var 
compilation1 = f_23107_240450_240487(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240552,240686);

f_23107_240552_240685(f_23107_240564_240684(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240702,240742);

var 
v0 = f_23107_240711_240741(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240756,240779);

f_23107_240756_240778(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240793,240858);

var 
md0 = f_23107_240803_240857(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240874,240927);

var 
f0 = f_23107_240883_240926(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,240941,240994);

var 
f1 = f_23107_240950_240993(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,241010,241112);

var 
generation0 = f_23107_241028_241111(md0, f_23107_241068_241088(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,241128,241388);

var 
diff1 = f_23107_241140_241387(compilation1, generation0, f_23107_241216_241386(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_241313_241354(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,241404,241835);

diff1.EmitResult.Diagnostics.Verify(f_23107_241662_241833(f_23107_241662_241812(f_23107_241662_241724(ErrorCode.ERR_EncUpdateFailedMissingAttribute, "F"), "C.F()", "System.Runtime.CompilerServices.IteratorStateMachineAttribute"), 12, 29));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,239427,241846);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_239592_239938(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 239592, 239938);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_239967_240313(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 239967, 240313);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_240349_240416(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240349, 240416);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_240450_240487(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240450, 240487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_240564_240684(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240564, 240684);
return return_v;
}


int
f_23107_240552_240685(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240552, 240685);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_240711_240741(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240711, 240741);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_240756_240778(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240756, 240778);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_240803_240857(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240803, 240857);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_240883_240926(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240883, 240926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_240950_240993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 240950, 240993);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_241068_241088(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241068, 241088);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_241028_241111(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241028, 241111);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_241313_241354(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241313, 241354);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_241216_241386(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241216, 241386);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_241140_241387(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241140, 241387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_241662_241724(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241662, 241724);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_241662_241812(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241662, 241812);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_241662_241833(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241662, 241833);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,239427,241846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,239427,241846);
}
		}

[Fact]
        public void AddedIteratorStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,241858,244156);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,241947,242195);

var 
source0 = f_23107_241961_242194(@"
using System;
using System.Collections.Generic;


class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>yield return 0;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,242209,242622);

var 
source1 = f_23107_242223_242621(@"
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { public IteratorStateMachineAttribute(Type type) { } }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return 1;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,242638,242739);

var 
compilation0 = f_23107_242657_242738(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,242753,242810);

var 
compilation1 = f_23107_242772_242809(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,242913,243047);

f_23107_242913_243046(f_23107_242925_243045(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243063,243103);

var 
v0 = f_23107_243072_243102(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243117,243140);

f_23107_243117_243139(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243154,243219);

var 
md0 = f_23107_243164_243218(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243235,243288);

var 
f0 = f_23107_243244_243287(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243302,243355);

var 
f1 = f_23107_243311_243354(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243369,243480);

var 
ism1 = f_23107_243380_243479(compilation1, "System.Runtime.CompilerServices.IteratorStateMachineAttribute")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243496,243598);

var 
generation0 = f_23107_243514_243597(md0, f_23107_243554_243574(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,243614,243953);

var 
diff1 = f_23107_243626_243952(compilation1, generation0, f_23107_243702_243951(SemanticEdit.Create(SemanticEditKind.Insert,null,ism1), SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_243878_243919(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,244107,244145);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,241858,244156);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_241961_242194(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 241961, 242194);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_242223_242621(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 242223, 242621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_242657_242738(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 242657, 242738);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_242772_242809(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 242772, 242809);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_242925_243045(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 242925, 243045);
return return_v;
}


int
f_23107_242913_243046(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 242913, 243046);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_243072_243102(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243072, 243102);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_243117_243139(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243117, 243139);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_243164_243218(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243164, 243218);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_243244_243287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243244, 243287);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_243311_243354(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243311, 243354);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_23107_243380_243479(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243380, 243479);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_243554_243574(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243554, 243574);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_243514_243597(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243514, 243597);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_243878_243919(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243878, 243919);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_243702_243951(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243702, 243951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_243626_243952(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 243626, 243952);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,241858,244156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,241858,244156);
}
		}

[Fact]
        public void SourceIteratorStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,244168,246279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,244258,244671);

var 
source0 = f_23107_244272_244670(@"
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { public IteratorStateMachineAttribute(Type type) { } }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>yield return 0;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,244685,245098);

var 
source1 = f_23107_244699_245097(@"
using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { public IteratorStateMachineAttribute(Type type) { } }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return 1;</N:1>
        Console.WriteLine(a);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245114,245201);

var 
compilation0 = f_23107_245133_245200(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245215,245272);

var 
compilation1 = f_23107_245234_245271(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245375,245512);

f_23107_245375_245511(f_23107_245390_245510(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245528,245568);

var 
v0 = f_23107_245537_245567(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245582,245605);

f_23107_245582_245604(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245619,245684);

var 
md0 = f_23107_245629_245683(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245700,245753);

var 
f0 = f_23107_245709_245752(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245767,245820);

var 
f1 = f_23107_245776_245819(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245836,245938);

var 
generation0 = f_23107_245854_245937(md0, f_23107_245894_245914(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,245954,246214);

var 
diff1 = f_23107_245966_246213(compilation1, generation0, f_23107_246042_246212(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_246139_246180(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,246230,246268);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,244168,246279);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_244272_244670(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 244272, 244670);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_244699_245097(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 244699, 245097);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_245133_245200(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245133, 245200);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_245234_245271(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245234, 245271);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_245390_245510(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245390, 245510);
return return_v;
}


int
f_23107_245375_245511(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245375, 245511);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_245537_245567(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245537, 245567);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_245582_245604(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245582, 245604);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_245629_245683(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245629, 245683);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_245709_245752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245709, 245752);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_245776_245819(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245776, 245819);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_245894_245914(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245894, 245914);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_245854_245937(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245854, 245937);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_246139_246180(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 246139, 246180);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_246042_246212(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 246042, 246212);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_245966_246213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 245966, 246213);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,244168,246279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,244168,246279);
}
		}

[Fact, WorkItem(9119, "https://github.com/dotnet/roslyn/issues/9119")]
        public void MissingAsyncStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,246291,248658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,246443,246659);

var 
source0 = f_23107_246457_246658(@"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>await new Task();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,246673,246889);

var 
source1 = f_23107_246687_246888(@"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>await new Task();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,246905,247086);

var 
compilation0 = f_23107_246924_247085(new[] { source0.Tree }, new[] { f_23107_246979_247017(), f_23107_247019_247056()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247100,247157);

var 
compilation1 = f_23107_247119_247156(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247288,247419);

f_23107_247288_247418(f_23107_247300_247417(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247433,247567);

f_23107_247433_247566(f_23107_247445_247565(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247583,247651);

var 
v0 = f_23107_247592_247650(this, compilation0, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247665,247730);

var 
md0 = f_23107_247675_247729(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247746,247799);

var 
f0 = f_23107_247755_247798(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247813,247866);

var 
f1 = f_23107_247822_247865(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,247882,247984);

var 
generation0 = f_23107_247900_247983(md0, f_23107_247940_247960(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,248000,248260);

var 
diff1 = f_23107_248012_248259(compilation1, generation0, f_23107_248088_248258(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_248185_248226(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,248276,248647);

diff1.EmitResult.Diagnostics.Verify(f_23107_248478_248645(f_23107_248478_248625(f_23107_248478_248540(ErrorCode.ERR_EncUpdateFailedMissingAttribute, "F"), "C.F()", "System.Runtime.CompilerServices.AsyncStateMachineAttribute"), 6, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,246291,248658);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_246457_246658(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 246457, 246658);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_246687_246888(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 246687, 246888);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_246979_247017()
{
var return_v = TestReferences.NetFx.Minimal.mincorlib;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 246979, 247017);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_247019_247056()
{
var return_v = TestReferences.NetFx.Minimal.minasync ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 247019, 247056);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_246924_247085(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 246924, 247085);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_247119_247156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247119, 247156);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_247300_247417(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247300, 247417);
return return_v;
}


int
f_23107_247288_247418(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247288, 247418);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_247445_247565(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247445, 247565);
return return_v;
}


int
f_23107_247433_247566(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247433, 247566);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_247592_247650(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247592, 247650);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_247675_247729(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247675, 247729);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_247755_247798(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247755, 247798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_247822_247865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247822, 247865);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_247940_247960(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247940, 247960);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_247900_247983(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 247900, 247983);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_248185_248226(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248185, 248226);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_248088_248258(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248088, 248258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_248012_248259(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248012, 248259);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_248478_248540(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248478, 248540);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_248478_248625(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248478, 248625);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_248478_248645(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248478, 248645);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,246291,248658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,246291,248658);
}
		}

[Fact]
        public void AddedAsyncStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,248670,250871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,248756,248977);

var 
source0 = f_23107_248770_248976(@"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>await new Task<int>();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,248991,249373);

var 
source1 = f_23107_249005_249372(@"
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public class AsyncStateMachineAttribute : Attribute { public AsyncStateMachineAttribute(Type type) { } }
}

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>await new Task<int>();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,249389,249570);

var 
compilation0 = f_23107_249408_249569(new[] { source0.Tree }, new[] { f_23107_249463_249501(), f_23107_249503_249540()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,249584,249641);

var 
compilation1 = f_23107_249603_249640(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,249744,249875);

f_23107_249744_249874(f_23107_249756_249873(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,249891,249959);

var 
v0 = f_23107_249900_249958(this, compilation0, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,249973,249996);

f_23107_249973_249995(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250010,250075);

var 
md0 = f_23107_250020_250074(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250091,250144);

var 
f0 = f_23107_250100_250143(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250158,250211);

var 
f1 = f_23107_250167_250210(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250225,250333);

var 
asm1 = f_23107_250236_250332(compilation1, "System.Runtime.CompilerServices.AsyncStateMachineAttribute")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250349,250451);

var 
generation0 = f_23107_250367_250450(md0, f_23107_250407_250427(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250467,250806);

var 
diff1 = f_23107_250479_250805(compilation1, generation0, f_23107_250555_250804(SemanticEdit.Create(SemanticEditKind.Insert,null,asm1), SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_250731_250772(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250822,250860);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,248670,250871);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_248770_248976(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 248770, 248976);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_249005_249372(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249005, 249372);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_249463_249501()
{
var return_v = TestReferences.NetFx.Minimal.mincorlib;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 249463, 249501);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_249503_249540()
{
var return_v = TestReferences.NetFx.Minimal.minasync ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 249503, 249540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_249408_249569(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249408, 249569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_249603_249640(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249603, 249640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_249756_249873(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249756, 249873);
return return_v;
}


int
f_23107_249744_249874(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249744, 249874);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_249900_249958(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249900, 249958);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_249973_249995(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 249973, 249995);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_250020_250074(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250020, 250074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_250100_250143(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250100, 250143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_250167_250210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250167, 250210);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_23107_250236_250332(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250236, 250332);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_250407_250427(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250407, 250427);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_250367_250450(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250367, 250450);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_250731_250772(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250731, 250772);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_250555_250804(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250555, 250804);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_250479_250805(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250479, 250805);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,248670,250871);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,248670,250871);
}
		}

[Fact]
        public void SourceAsyncStateMachineAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,250883,252961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,250970,251352);

var 
source0 = f_23107_250984_251351(@"
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public class AsyncStateMachineAttribute : Attribute { public AsyncStateMachineAttribute(Type type) { } }
}

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>await new Task<int>();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,251366,251748);

var 
source1 = f_23107_251380_251747(@"
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    public class AsyncStateMachineAttribute : Attribute { public AsyncStateMachineAttribute(Type type) { } }
}

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>await new Task<int>();</N:1>
        return a;
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,251764,251945);

var 
compilation0 = f_23107_251783_251944(new[] { source0.Tree }, new[] { f_23107_251838_251876(), f_23107_251878_251915()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,251959,252016);

var 
compilation1 = f_23107_251978_252015(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252032,252166);

f_23107_252032_252165(f_23107_252047_252164(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252182,252250);

var 
v0 = f_23107_252191_252249(this, compilation0, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252264,252287);

f_23107_252264_252286(            v0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252301,252366);

var 
md0 = f_23107_252311_252365(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252382,252435);

var 
f0 = f_23107_252391_252434(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252449,252502);

var 
f1 = f_23107_252458_252501(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252518,252620);

var 
generation0 = f_23107_252536_252619(md0, f_23107_252576_252596(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252636,252896);

var 
diff1 = f_23107_252648_252895(compilation1, generation0, f_23107_252724_252894(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_252821_252862(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,252912,252950);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,250883,252961);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_250984_251351(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 250984, 251351);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_251380_251747(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 251380, 251747);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_251838_251876()
{
var return_v = TestReferences.NetFx.Minimal.mincorlib;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 251838, 251876);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_251878_251915()
{
var return_v = TestReferences.NetFx.Minimal.minasync ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 251878, 251915);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_251783_251944(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 251783, 251944);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_251978_252015(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 251978, 252015);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_252047_252164(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252047, 252164);
return return_v;
}


int
f_23107_252032_252165(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252032, 252165);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_252191_252249(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252191, 252249);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_252264_252286(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252264, 252286);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_252311_252365(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252311, 252365);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_252391_252434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252391, 252434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_252458_252501(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252458, 252501);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_252576_252596(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252576, 252596);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_252536_252619(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252536, 252619);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_252821_252862(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252821, 252862);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_252724_252894(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252724, 252894);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_252648_252895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 252648, 252895);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,250883,252961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,250883,252961);
}
		}

[Fact, WorkItem(10190, "https://github.com/dotnet/roslyn/issues/10190")]
        public void NonAsyncToAsync()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,252973,254650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253109,253309);

var 
source0 = f_23107_253123_253308(@"
using System.Threading.Tasks;

class C
{
    public Task<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>return Task.FromResult(a);</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253323,253535);

var 
source1 = f_23107_253337_253534(@"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>return await Task.FromResult(a);</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253551,253670);

var 
compilation0 = f_23107_253570_253669(new[] { source0.Tree }, new[] { f_23107_253625_253640()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253684,253741);

var 
compilation1 = f_23107_253703_253740(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253757,253891);

f_23107_253757_253890(f_23107_253772_253889(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253907,253976);

var 
v0 = f_23107_253916_253975(this, compilation0, verify: Verification.Passes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,253990,254055);

var 
md0 = f_23107_254000_254054(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254071,254124);

var 
f0 = f_23107_254080_254123(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254138,254191);

var 
f1 = f_23107_254147_254190(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254207,254309);

var 
generation0 = f_23107_254225_254308(md0, f_23107_254265_254285(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254325,254585);

var 
diff1 = f_23107_254337_254584(compilation1, generation0, f_23107_254413_254583(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_254510_254551(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254601,254639);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,252973,254650);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_253123_253308(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253123, 253308);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_253337_253534(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253337, 253534);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_253625_253640()
{
var return_v = Net451.mscorlib ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 253625, 253640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_253570_253669(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253570, 253669);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_253703_253740(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253703, 253740);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_253772_253889(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253772, 253889);
return return_v;
}


int
f_23107_253757_253890(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253757, 253890);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_253916_253975(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 253916, 253975);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_254000_254054(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254000, 254054);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_254080_254123(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254080, 254123);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_254147_254190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254147, 254190);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_254265_254285(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254265, 254285);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_254225_254308(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254225, 254308);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_254510_254551(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254510, 254551);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_254413_254583(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254413, 254583);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_254337_254584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254337, 254584);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,252973,254650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,252973,254650);
}
		}

[Fact]
        public void NonAsyncToAsync_MissingAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,254662,256703);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254749,254960);

var 
source0 = f_23107_254763_254959(@"
using System.Threading.Tasks;

class C
{
    public Task<int> F()
    {
        int <N:0>a = 0</N:0>;
        a++;
        <N:1>return new Task<int>();</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,254974,255197);

var 
source1 = f_23107_254988_255196(@"
using System.Threading.Tasks;

class C
{
    public async Task<int> F()
    {
        int <N:0>a = 1</N:0>;
        a++;
        <N:1>return await new Task<int>();</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255213,255394);

var 
compilation0 = f_23107_255232_255393(new[] { source0.Tree }, new[] { f_23107_255287_255325(), f_23107_255327_255364()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255408,255465);

var 
compilation1 = f_23107_255427_255464(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255481,255612);

f_23107_255481_255611(f_23107_255493_255610(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255628,255696);

var 
v0 = f_23107_255637_255695(this, compilation0, verify: Verification.Fails)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255710,255775);

var 
md0 = f_23107_255720_255774(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255791,255844);

var 
f0 = f_23107_255800_255843(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255858,255911);

var 
f1 = f_23107_255867_255910(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,255927,256029);

var 
generation0 = f_23107_255945_256028(md0, f_23107_255985_256005(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,256045,256305);

var 
diff1 = f_23107_256057_256304(compilation1, generation0, f_23107_256133_256303(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_256230_256271(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,256321,256692);

diff1.EmitResult.Diagnostics.Verify(f_23107_256523_256690(f_23107_256523_256670(f_23107_256523_256585(ErrorCode.ERR_EncUpdateFailedMissingAttribute, "F"), "C.F()", "System.Runtime.CompilerServices.AsyncStateMachineAttribute"), 6, 28));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,254662,256703);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_254763_254959(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254763, 254959);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_254988_255196(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 254988, 255196);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_255287_255325()
{
var return_v = TestReferences.NetFx.Minimal.mincorlib;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 255287, 255325);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_255327_255364()
{
var return_v = TestReferences.NetFx.Minimal.minasync ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 255327, 255364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_255232_255393(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255232, 255393);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_255427_255464(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255427, 255464);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_255493_255610(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255493, 255610);
return return_v;
}


int
f_23107_255481_255611(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255481, 255611);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_255637_255695(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255637, 255695);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_255720_255774(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255720, 255774);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_255800_255843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255800, 255843);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_255867_255910(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255867, 255910);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_255985_256005(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255985, 256005);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_255945_256028(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 255945, 256028);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_256230_256271(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256230, 256271);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_256133_256303(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256133, 256303);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_256057_256304(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256057, 256304);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_256523_256585(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256523, 256585);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_256523_256670(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256523, 256670);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_256523_256690(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256523, 256690);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,254662,256703);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,254662,256703);
}
		}

[Fact]
        public void NonIteratorToIterator_MissingAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,256715,258683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,256808,257016);

var 
source0 = f_23107_256822_257015(@"
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>return new int[] { a };</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257030,257230);

var 
source1 = f_23107_257044_257229(@"
using System.Collections.Generic;

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return a;</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257246,257364);

var 
compilation0 = f_23107_257265_257363(new[] { source0.Tree }, new[] { f_23107_257320_257334()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257378,257435);

var 
compilation1 = f_23107_257397_257434(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257451,257585);

f_23107_257451_257584(f_23107_257463_257583(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257601,257670);

var 
v0 = f_23107_257610_257669(this, compilation0, verify: Verification.Passes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257684,257749);

var 
md0 = f_23107_257694_257748(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257765,257818);

var 
f0 = f_23107_257774_257817(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257832,257885);

var 
f1 = f_23107_257841_257884(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,257901,258003);

var 
generation0 = f_23107_257919_258002(md0, f_23107_257959_257979(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,258019,258279);

var 
diff1 = f_23107_258031_258278(compilation1, generation0, f_23107_258107_258277(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_258204_258245(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,258295,258672);

diff1.EmitResult.Diagnostics.Verify(f_23107_258500_258670(f_23107_258500_258650(f_23107_258500_258562(ErrorCode.ERR_EncUpdateFailedMissingAttribute, "F"), "C.F()", "System.Runtime.CompilerServices.IteratorStateMachineAttribute"), 6, 29));
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,256715,258683);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_256822_257015(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 256822, 257015);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_257044_257229(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257044, 257229);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_257320_257334()
{
var return_v = Net20.mscorlib ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 257320, 257334);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_257265_257363(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257265, 257363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_257397_257434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257397, 257434);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_257463_257583(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257463, 257583);
return return_v;
}


int
f_23107_257451_257584(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257451, 257584);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_257610_257669(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257610, 257669);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_257694_257748(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257694, 257748);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_257774_257817(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257774, 257817);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_257841_257884(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257841, 257884);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_257959_257979(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257959, 257979);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_257919_258002(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 257919, 258002);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_258204_258245(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258204, 258245);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_258107_258277(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258107, 258277);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_258031_258278(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258031, 258278);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_258500_258562(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258500, 258562);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_258500_258650(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258500, 258650);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23107_258500_258670(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258500, 258670);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,256715,258683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,256715,258683);
}
		}

[Fact]
        public void NonIteratorToIterator_SourceAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,258695,260660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,258787,259162);

var 
source0 = f_23107_258801_259161(@"
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { public IteratorStateMachineAttribute(Type type) { } }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 0</N:0>;
        <N:1>return new int[] { a };</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,259176,259543);

var 
source1 = f_23107_259190_259542(@"
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
    public class IteratorStateMachineAttribute : Attribute { public IteratorStateMachineAttribute(Type type) { } }
}

class C
{
    public IEnumerable<int> F()
    {
        int <N:0>a = 1</N:0>;
        <N:1>yield return a;</N:1>
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,259559,259677);

var 
compilation0 = f_23107_259578_259676(new[] { source0.Tree }, new[] { f_23107_259633_259647()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,259691,259748);

var 
compilation1 = f_23107_259710_259747(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,259764,259901);

f_23107_259764_259900(f_23107_259779_259899(compilation0, WellKnownMember.System_Runtime_CompilerServices_IteratorStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,259917,259986);

var 
v0 = f_23107_259926_259985(this, compilation0, verify: Verification.Passes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260000,260065);

var 
md0 = f_23107_260010_260064(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260081,260134);

var 
f0 = f_23107_260090_260133(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260148,260201);

var 
f1 = f_23107_260157_260200(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260217,260319);

var 
generation0 = f_23107_260235_260318(md0, f_23107_260275_260295(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260335,260595);

var 
diff1 = f_23107_260347_260594(compilation1, generation0, f_23107_260423_260593(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_260520_260561(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260611,260649);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,258695,260660);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_258801_259161(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 258801, 259161);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_259190_259542(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259190, 259542);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_259633_259647()
{
var return_v = Net20.mscorlib ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 259633, 259647);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_259578_259676(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259578, 259676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_259710_259747(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259710, 259747);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_259779_259899(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259779, 259899);
return return_v;
}


int
f_23107_259764_259900(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259764, 259900);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_259926_259985(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 259926, 259985);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_260010_260064(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260010, 260064);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_260090_260133(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260090, 260133);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_260157_260200(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260157, 260200);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_260275_260295(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260275, 260295);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_260235_260318(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260235, 260318);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_260520_260561(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260520, 260561);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_260423_260593(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260423, 260593);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_260347_260594(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260347, 260594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,258695,260660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,258695,260660);
}
		}

[Fact]
        public void NonAsyncToAsyncLambda()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,260672,262808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,260748,261046);

var 
source0 = f_23107_260762_261045(@"
using System.Threading.Tasks;

class C
{
    public object F()
    {
        return new System.Func<Task<int>>(<N:2>() =>
        <N:3>{
           int <N:0>a = 0</N:0>;
           <N:1>return Task.FromResult(a);</N:1>
        }</N:3></N:2>);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261060,261370);

var 
source1 = f_23107_261074_261369(@"
using System.Threading.Tasks;

class C
{
    public object F()
    {
        return new System.Func<Task<int>>(<N:2>async () =>
        <N:3>{
           int <N:0>a = 0</N:0>;
           <N:1>return await Task.FromResult(a);</N:1>
        }</N:3></N:2>);
    }
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261386,261558);

var 
compilation0 = f_23107_261405_261557(new[] { source0.Tree }, new[] { f_23107_261460_261475()}, options: f_23107_261488_261556(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261572,261629);

var 
compilation1 = f_23107_261591_261628(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261645,261779);

f_23107_261645_261778(f_23107_261660_261777(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261795,261864);

var 
v0 = f_23107_261804_261863(this, compilation0, verify: Verification.Passes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261878,261943);

var 
md0 = f_23107_261888_261942(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,261959,262012);

var 
f0 = f_23107_261968_262011(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262026,262079);

var 
f1 = f_23107_262035_262078(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262095,262197);

var 
generation0 = f_23107_262113_262196(md0, f_23107_262153_262173(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262213,262473);

var 
diff1 = f_23107_262225_262472(compilation1, generation0, f_23107_262301_262471(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_262398_262439(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262489,262527);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262543,262797);

f_23107_262543_262796(
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <F>b__0_0, <<F>b__0_0>d}", "C.<>c.<<F>b__0_0>d: {<>1__state, <>t__builder, <>4__this, <a>5__1, <>s__2, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,260672,262808);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_260762_261045(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 260762, 261045);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_261074_261369(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261074, 261369);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23107_261460_261475()
{
var return_v = Net451.mscorlib ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 261460, 261475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23107_261488_261556(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261488, 261556);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_261405_261557(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261405, 261557);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_261591_261628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261591, 261628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_261660_261777(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261660, 261777);
return return_v;
}


int
f_23107_261645_261778(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261645, 261778);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_261804_261863(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261804, 261863);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_261888_261942(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261888, 261942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_261968_262011(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 261968, 262011);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_262035_262078(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262035, 262078);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_262153_262173(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262153, 262173);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_262113_262196(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262113, 262196);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_262398_262439(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262398, 262439);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_262301_262471(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262301, 262471);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_262225_262472(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262225, 262472);
return return_v;
}


int
f_23107_262543_262796(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262543, 262796);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,260672,262808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,260672,262808);
}
		}

[Fact]
        public void AsyncMethodWithNullableParameterAddingNullCheck()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23107,262820,266564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,262922,263438);

var 
source0 = f_23107_262936_263437(@"
using System;
using System.Threading.Tasks;
#nullable enable

class C
{
    static T id<T>(T t) => t;
    static Task<T> G<T>(Func<T> f) => Task.FromResult(f());
    static T H<T>(Func<T> f) => f();

    public async void F(string? x)
    <N:4>{</N:4>
        var <N:2>y = await G(<N:0>() => new { A = id(x) }</N:0>)</N:2>;
        var <N:3>z = H(<N:1>() => y.A</N:1>)</N:3>;
    }
}
", options: f_23107_263365_263436(f_23107_263365_263391(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,263452,264015);

var 
source1 = f_23107_263466_264014(@"
using System;
using System.Threading.Tasks;
#nullable enable

class C
{
    static T id<T>(T t) => t;
    static Task<T> G<T>(Func<T> f) => Task.FromResult(f());
    static T H<T>(Func<T> f) => f();

    public async void F(string? x)
    <N:4>{</N:4>
        if (x is null) throw new Exception();
        var <N:2>y = await G(<N:0>() => new { A = id(x) }</N:0>)</N:2>;
        var <N:3>z = H(<N:1>() => y.A</N:1>)</N:3>;
    }
}
", options: f_23107_263942_264013(f_23107_263942_263968(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264031,264132);

var 
compilation0 = f_23107_264050_264131(new[] { source0.Tree }, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264146,264203);

var 
compilation1 = f_23107_264165_264202(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264219,264353);

f_23107_264219_264352(f_23107_264234_264351(compilation0, WellKnownMember.System_Runtime_CompilerServices_AsyncStateMachineAttribute__ctor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264369,264438);

var 
v0 = f_23107_264378_264437(this, compilation0, verify: Verification.Passes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264452,264517);

var 
md0 = f_23107_264462_264516(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264533,264586);

var 
f0 = f_23107_264542_264585(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264600,264653);

var 
f1 = f_23107_264609_264652(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264669,264771);

var 
generation0 = f_23107_264687_264770(md0, f_23107_264727_264747(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,264787,265047);

var 
diff1 = f_23107_264799_265046(compilation1, generation0, f_23107_264875_265045(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23107_264972_265013(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,265063,265101);

diff1.EmitResult.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,265117,265887);

f_23107_265117_265886(
            diff1, "C.<>c__DisplayClass3_0: {x, y, <F>b__1, <F>b__0}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}", "System.Runtime.CompilerServices: {NullableAttribute, NullableContextAttribute}", "Microsoft.CodeAnalysis: {EmbeddedAttribute}", "Microsoft: {CodeAnalysis}", "System.Runtime: {CompilerServices, CompilerServices}", "C: {<>c__DisplayClass3_0, <F>d__3}", "<global namespace>: {Microsoft, System, System}", "System: {Runtime, Runtime}", "C.<F>d__3: {<>1__state, <>t__builder, x, <>4__this, <>8__4, <z>5__2, <>s__5, <>u__1, MoveNext, SetStateMachine}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,265903,266239);

f_23107_265903_266238(
            diff1, "C.<>c__DisplayClass3_0.<F>b__1()", @"
{
  // Code size       17 (0x11)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""string C.<>c__DisplayClass3_0.x""
  IL_0006:  call       ""string C.id<string>(string)""
  IL_000b:  newobj     ""<>f__AnonymousType0<string>..ctor(string)""
  IL_0010:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23107,266255,266553);

f_23107_266255_266552(
            diff1, "C.<>c__DisplayClass3_0.<F>b__0()", @"
{
  // Code size       12 (0xc)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""<anonymous type: string A> C.<>c__DisplayClass3_0.y""
  IL_0006:  callvirt   ""string <>f__AnonymousType0<string>.A.get""
  IL_000b:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23107,262820,266564);

Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23107_263365_263391()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 263365, 263391);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23107_263365_263436(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 263365, 263436);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_262936_263437(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 262936, 263437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23107_263942_263968()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23107, 263942, 263968);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23107_263942_264013(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 263942, 264013);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23107_263466_264014(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 263466, 264014);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_264050_264131(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264050, 264131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23107_264165_264202(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264165, 264202);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol?
f_23107_264234_264351(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.WellKnownMember
member)
{
var return_v = this_param.GetWellKnownTypeMember( member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264234, 264351);
return return_v;
}


int
f_23107_264219_264352(Microsoft.CodeAnalysis.CSharp.Symbol?
@object)
{
Assert.NotNull( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264219, 264352);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23107_264378_264437(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueStateMachineTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264378, 264437);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23107_264462_264516(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264462, 264516);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_264542_264585(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264542, 264585);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23107_264609_264652(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264609, 264652);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23107_264727_264747(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264727, 264747);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23107_264687_264770(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264687, 264770);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23107_264972_265013(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264972, 265013);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23107_264875_265045(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264875, 265045);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23107_264799_265046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 264799, 265046);
return return_v;
}


int
f_23107_265117_265886(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 265117, 265886);
return 0;
}


int
f_23107_265903_266238(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 265903, 266238);
return 0;
}


int
f_23107_266255_266552(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23107, 266255, 266552);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23107,262820,266564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,262820,266564);
}
		}

public EditAndContinueStateMachineTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23107,728,266571);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23107,728,266571);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,728,266571);
}


static EditAndContinueStateMachineTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23107,728,266571);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23107,728,266571);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23107,728,266571);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23107,728,266571);
}
}
