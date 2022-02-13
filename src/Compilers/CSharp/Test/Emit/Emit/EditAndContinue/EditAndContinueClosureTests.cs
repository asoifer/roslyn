// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
public class EditAndContinueClosureTests : EditAndContinueTestBase
{
[Fact]
        public void MethodToMethodWithClosure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,800,2999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,880,998);

var 
source0 =
@"delegate object D();
class C
{
    static object F(object o)
    {
        return o;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1012,1145);

var 
source1 =
@"delegate object D();
class C
{
    static object F(object o)
    {
        return ((D)(() => o))();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1159,1236);

var 
compilation0 = f_23105_1178_1235(source0, options: TestOptions.DebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1250,1302);

var 
compilation1 = f_23105_1269_1301(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1316,1356);

var 
bytes0 = f_23105_1329_1355(compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1370,1484);

var 
generation0 = f_23105_1388_1483(f_23105_1423_1461(bytes0), EmptyLocalsProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1500,1747);

var 
diff1 = f_23105_1512_1746(compilation1, generation0, f_23105_1588_1745(SemanticEdit.Create(SemanticEditKind.Update,f_23105_1655_1698(compilation0, "C.F"),f_23105_1700_1743(compilation1, "C.F"))))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1763,2988);
using(var 
md1 = f_23105_1780_1799(diff1)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,1833,1858);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,2001,2973);

f_23105_2001_2972(reader1, f_23105_2054_2120(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_2143_2203(4, TableIndex.TypeDef, EditAndContinueOperation.Default), f_23105_2226_2287(4, TableIndex.TypeDef, EditAndContinueOperation.AddField), f_23105_2310_2368(1, TableIndex.Field, EditAndContinueOperation.Default), f_23105_2391_2453(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_2476_2538(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23105_2561_2623(7, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_2646_2708(4, TableIndex.TypeDef, EditAndContinueOperation.AddMethod), f_23105_2731_2793(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_2816_2884(4, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23105_2907_2971(1, TableIndex.NestedClass, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitUsing(23105,1763,2988);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,800,2999);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_1178_1235(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1178, 1235);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_1269_1301(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1269, 1301);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23105_1329_1355(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1329, 1355);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_1423_1461(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1423, 1461);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_1388_1483(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1388, 1483);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_1655_1698(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1655, 1698);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_1700_1743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1700, 1743);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_1588_1745(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1588, 1745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_1512_1746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1512, 1746);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_1780_1799(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 1780, 1799);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2054_2120(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2054, 2120);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2143_2203(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2143, 2203);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2226_2287(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2226, 2287);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2310_2368(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2310, 2368);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2391_2453(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2391, 2453);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2476_2538(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2476, 2538);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2561_2623(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2561, 2623);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2646_2708(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2646, 2708);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2731_2793(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2731, 2793);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2816_2884(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2816, 2884);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_2907_2971(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2907, 2971);
return return_v;
}


int
f_23105_2001_2972(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 2001, 2972);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,800,2999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,800,2999);
}
		}

[Fact]
        public void MethodWithStaticLambda1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,3011,4852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3089,3224);

var 
source0 = f_23105_3103_3223(@"
using System;

class C
{
    void F()
    {
        Func<int> x = <N:0>() => 1</N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3238,3373);

var 
source1 = f_23105_3252_3372(@"
using System;

class C
{
    void F()
    {
        Func<int> x = <N:0>() => 2</N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3387,3517);

var 
compilation0 = f_23105_3406_3516(source0.Tree, options: f_23105_3447_3515(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3531,3588);

var 
compilation1 = f_23105_3550_3587(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3604,3644);

var 
v0 = f_23105_3613_3643(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3658,3723);

var 
md0 = f_23105_3668_3722(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3739,3792);

var 
f0 = f_23105_3748_3791(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3806,3859);

var 
f1 = f_23105_3815_3858(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3875,3977);

var 
generation0 = f_23105_3893_3976(md0, f_23105_3933_3953(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,3993,4231);

var 
diff1 = f_23105_4005_4230(compilation1, generation0, f_23105_4081_4229(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_4156_4197(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,4320,4430);

f_23105_4320_4429(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <F>b__0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,4446,4476);

var 
md1 = f_23105_4456_4475(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,4490,4515);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,4562,4841);

f_23105_4562_4840(reader1, f_23105_4611_4677(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_4696_4758(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_4777_4839(5, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,3011,4852);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_3103_3223(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3103, 3223);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_3252_3372(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3252, 3372);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_3447_3515(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3447, 3515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_3406_3516(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3406, 3516);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_3550_3587(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3550, 3587);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_3613_3643(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3613, 3643);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_3668_3722(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3668, 3722);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_3748_3791(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3748, 3791);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_3815_3858(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3815, 3858);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_3933_3953(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3933, 3953);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_3893_3976(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 3893, 3976);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_4156_4197(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4156, 4197);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_4081_4229(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4081, 4229);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_4005_4230(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4005, 4230);
return return_v;
}


int
f_23105_4320_4429(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4320, 4429);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_4456_4475(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4456, 4475);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_4611_4677(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4611, 4677);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_4696_4758(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4696, 4758);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_4777_4839(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4777, 4839);
return return_v;
}


int
f_23105_4562_4840(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4562, 4840);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,3011,4852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,3011,4852);
}
		}

[Fact]
        public void MethodWithStaticLocalFunction1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,4864,6584);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,4949,5075);

var 
source0 = f_23105_4963_5074(@"
using System;

class C
{
    void F()
    {
        <N:0>int x() => 1;</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5089,5215);

var 
source1 = f_23105_5103_5214(@"
using System;

class C
{
    void F()
    {
        <N:0>int x() => 2;</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5231,5361);

var 
compilation0 = f_23105_5250_5360(source0.Tree, options: f_23105_5291_5359(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5375,5432);

var 
compilation1 = f_23105_5394_5431(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5448,5488);

var 
v0 = f_23105_5457_5487(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5502,5567);

var 
md0 = f_23105_5512_5566(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5583,5636);

var 
f0 = f_23105_5592_5635(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5650,5703);

var 
f1 = f_23105_5659_5702(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5719,5821);

var 
generation0 = f_23105_5737_5820(md0, f_23105_5777_5797(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,5837,6075);

var 
diff1 = f_23105_5849_6074(compilation1, generation0, f_23105_5925_6073(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_6000_6041(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6091,6160);

f_23105_6091_6159(
            diff1, "C: {<F>g__x|0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6176,6206);

var 
md1 = f_23105_6186_6205(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6220,6245);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6292,6573);

f_23105_6292_6572(reader1, f_23105_6341_6403(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_6422_6484(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_6503_6571(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,4864,6584);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_4963_5074(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 4963, 5074);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_5103_5214(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5103, 5214);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_5291_5359(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5291, 5359);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_5250_5360(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5250, 5360);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_5394_5431(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5394, 5431);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_5457_5487(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5457, 5487);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_5512_5566(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5512, 5566);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_5592_5635(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5592, 5635);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_5659_5702(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5659, 5702);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_5777_5797(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5777, 5797);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_5737_5820(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5737, 5820);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_6000_6041(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6000, 6041);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_5925_6073(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5925, 6073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_5849_6074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 5849, 6074);
return return_v;
}


int
f_23105_6091_6159(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6091, 6159);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_6186_6205(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6186, 6205);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_6341_6403(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6341, 6403);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_6422_6484(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6422, 6484);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_6503_6571(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6503, 6571);
return return_v;
}


int
f_23105_6292_6572(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6292, 6572);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,4864,6584);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,4864,6584);
}
		}

[Fact]
        public void MethodWithStaticLocalFunction_ChangeStatic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,6596,8808);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6693,6819);

var 
source0 = f_23105_6707_6818(@"
using System;

class C
{
    void F()
    {
        <N:0>int x() => 1;</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6833,6966);

var 
source1 = f_23105_6847_6965(@"
using System;

class C
{
    void F()
    {
        <N:0>static int x() => 1;</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,6982,7112);

var 
compilation0 = f_23105_7001_7111(source0.Tree, options: f_23105_7042_7110(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7126,7183);

var 
compilation1 = f_23105_7145_7182(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7199,7239);

var 
v0 = f_23105_7208_7238(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7253,7318);

var 
md0 = f_23105_7263_7317(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7332,7365);

var 
reader0 = f_23105_7346_7364(md0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7381,7434);

var 
f0 = f_23105_7390_7433(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7448,7501);

var 
f1 = f_23105_7457_7500(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7517,7619);

var 
generation0 = f_23105_7535_7618(md0, f_23105_7575_7595(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7635,7873);

var 
diff1 = f_23105_7647_7872(compilation1, generation0, f_23105_7723_7871(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_7798_7839(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7889,7958);

f_23105_7889_7957(
            diff1, "C: {<F>g__x|0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,7974,8004);

var 
md1 = f_23105_7984_8003(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8018,8043);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8090,8371);

f_23105_8090_8370(reader1, f_23105_8139_8201(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_8220_8282(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_8301_8369(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8387,8429);

var 
testData0 = f_23105_8403_8428()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8443,8502);

var 
bytes0 = f_23105_8456_8501(compilation0, testData: testData0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8516,8585);

var 
localFunction0 = f_23105_8537_8577(testData0, "C.<F>g__x|0_0").Method
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8599,8646);

f_23105_8599_8645(f_23105_8611_8644(((Symbol)localFunction0)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8662,8736);

var 
localFunction1 = f_23105_8683_8728(diff1.TestData, "C.<F>g__x|0_0").Method
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8750,8797);

f_23105_8750_8796(f_23105_8762_8795(((Symbol)localFunction1)));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,6596,8808);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_6707_6818(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6707, 6818);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_6847_6965(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 6847, 6965);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_7042_7110(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7042, 7110);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_7001_7111(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7001, 7111);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_7145_7182(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7145, 7182);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_7208_7238(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7208, 7238);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_7263_7317(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7263, 7317);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23105_7346_7364(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 7346, 7364);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_7390_7433(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7390, 7433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_7457_7500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7457, 7500);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_7575_7595(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7575, 7595);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_7535_7618(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7535, 7618);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_7798_7839(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7798, 7839);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_7723_7871(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7723, 7871);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_7647_7872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7647, 7872);
return return_v;
}


int
f_23105_7889_7957(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7889, 7957);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_7984_8003(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 7984, 8003);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_8139_8201(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8139, 8201);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_8220_8282(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8220, 8282);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_8301_8369(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8301, 8369);
return return_v;
}


int
f_23105_8090_8370(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8090, 8370);
return 0;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData
f_23105_8403_8428()
{
var return_v = new Microsoft.CodeAnalysis.CodeGen.CompilationTestData();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8403, 8428);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23105_8456_8501(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CodeGen.CompilationTestData
testData)
{
var return_v = compilation.EmitToArray( testData:testData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8456, 8501);
return return_v;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23105_8537_8577(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8537, 8577);
return return_v;
}


bool
f_23105_8611_8644(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 8611, 8644);
return return_v;
}


int
f_23105_8599_8645(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8599, 8645);
return 0;
}


Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_23105_8683_8728(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8683, 8728);
return return_v;
}


bool
f_23105_8762_8795(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 8762, 8795);
return return_v;
}


int
f_23105_8750_8796(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8750, 8796);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,6596,8808);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,6596,8808);
}
		}

[Fact]
        public void MethodWithStaticLambdaGeneric1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,8820,10782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,8905,9050);

var 
source0 = f_23105_8919_9049(@"
using System;

class C
{
    void F<T>()
    {
        Func<T> x = <N:0>() => default(T)</N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9064,9209);

var 
source1 = f_23105_9078_9208(@"
using System;

class C
{
    void F<T>()
    {
        Func<T> x = <N:0>() => default(T)</N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9223,9353);

var 
compilation0 = f_23105_9242_9352(source0.Tree, options: f_23105_9283_9351(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9367,9424);

var 
compilation1 = f_23105_9386_9423(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9440,9480);

var 
v0 = f_23105_9449_9479(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9494,9559);

var 
md0 = f_23105_9504_9558(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9575,9628);

var 
f0 = f_23105_9584_9627(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9642,9695);

var 
f1 = f_23105_9651_9694(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9711,9813);

var 
generation0 = f_23105_9729_9812(md0, f_23105_9769_9789(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,9829,10067);

var 
diff1 = f_23105_9841_10066(compilation1, generation0, f_23105_9917_10065(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_9992_10033(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,10156,10275);

f_23105_10156_10274(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<>c__0}", "C.<>c__0<T>: {<>9__0_0, <F>b__0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,10291,10321);

var 
md1 = f_23105_10301_10320(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,10335,10360);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,10407,10771);

f_23105_10407_10770(reader1, f_23105_10456_10522(3, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_10541_10607(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_10626_10688(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_10707_10769(5, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,8820,10782);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_8919_9049(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 8919, 9049);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_9078_9208(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9078, 9208);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_9283_9351(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9283, 9351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_9242_9352(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9242, 9352);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_9386_9423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9386, 9423);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_9449_9479(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9449, 9479);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_9504_9558(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9504, 9558);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_9584_9627(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9584, 9627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_9651_9694(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9651, 9694);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_9769_9789(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9769, 9789);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_9729_9812(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9729, 9812);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_9992_10033(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9992, 10033);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_9917_10065(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9917, 10065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_9841_10066(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 9841, 10066);
return return_v;
}


int
f_23105_10156_10274(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10156, 10274);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_10301_10320(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10301, 10320);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_10456_10522(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10456, 10522);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_10541_10607(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10541, 10607);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_10626_10688(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10626, 10688);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_10707_10769(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10707, 10769);
return return_v;
}


int
f_23105_10407_10770(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10407, 10770);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,8820,10782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,8820,10782);
}
		}

[Fact]
        public void MethodWithStaticLocalFunctionGeneric1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,10794,12697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,10886,11022);

var 
source0 = f_23105_10900_11021(@"
using System;

class C
{
    void F<T>()
    {
        <N:0>T x() => default(T);</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11036,11172);

var 
source1 = f_23105_11050_11171(@"
using System;

class C
{
    void F<T>()
    {
        <N:0>T x() => default(T);</N:0>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11186,11316);

var 
compilation0 = f_23105_11205_11315(source0.Tree, options: f_23105_11246_11314(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11330,11387);

var 
compilation1 = f_23105_11349_11386(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11403,11443);

var 
v0 = f_23105_11412_11442(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11457,11522);

var 
md0 = f_23105_11467_11521(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11538,11591);

var 
f0 = f_23105_11547_11590(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11605,11658);

var 
f1 = f_23105_11614_11657(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11674,11776);

var 
generation0 = f_23105_11692_11775(md0, f_23105_11732_11752(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,11792,12030);

var 
diff1 = f_23105_11804_12029(compilation1, generation0, f_23105_11880_12028(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_11955_11996(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12119,12188);

f_23105_12119_12187(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<F>g__x|0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12204,12234);

var 
md1 = f_23105_12214_12233(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12248,12273);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12320,12686);

f_23105_12320_12685(reader1, f_23105_12369_12435(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_12454_12516(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_12535_12597(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_12616_12684(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,10794,12697);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_10900_11021(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 10900, 11021);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_11050_11171(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11050, 11171);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_11246_11314(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11246, 11314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_11205_11315(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11205, 11315);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_11349_11386(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11349, 11386);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_11412_11442(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11412, 11442);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_11467_11521(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11467, 11521);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_11547_11590(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11547, 11590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_11614_11657(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11614, 11657);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_11732_11752(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11732, 11752);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_11692_11775(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11692, 11775);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_11955_11996(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11955, 11996);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_11880_12028(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11880, 12028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_11804_12029(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 11804, 12029);
return return_v;
}


int
f_23105_12119_12187(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12119, 12187);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_12214_12233(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12214, 12233);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_12369_12435(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12369, 12435);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_12454_12516(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12454, 12516);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_12535_12597(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12535, 12597);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_12616_12684(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12616, 12684);
return return_v;
}


int
f_23105_12320_12685(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12320, 12685);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,10794,12697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,10794,12697);
}
		}

[Fact]
        public void MethodWithThisOnlyClosure1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,12709,14649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12790,12951);

var 
source0 = f_23105_12804_12950(@"
using System;

class C
{
    int F(int a)
    {
        Func<int> x = <N:0>() => F(1)</N:0>;
        return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,12965,13126);

var 
source1 = f_23105_12979_13125(@"
using System;

class C
{
    int F(int a)
    {
        Func<int> x = <N:0>() => F(2)</N:0>;
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13140,13270);

var 
compilation0 = f_23105_13159_13269(source0.Tree, options: f_23105_13200_13268(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13284,13341);

var 
compilation1 = f_23105_13303_13340(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13357,13397);

var 
v0 = f_23105_13366_13396(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13411,13476);

var 
md0 = f_23105_13421_13475(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13492,13545);

var 
f0 = f_23105_13501_13544(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13559,13612);

var 
f1 = f_23105_13568_13611(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13628,13730);

var 
generation0 = f_23105_13646_13729(md0, f_23105_13686_13706(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,13746,13984);

var 
diff1 = f_23105_13758_13983(compilation1, generation0, f_23105_13834_13982(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_13909_13950(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14073,14140);

f_23105_14073_14139(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<F>b__0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14156,14186);

var 
md1 = f_23105_14166_14185(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14200,14225);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14272,14638);

f_23105_14272_14637(reader1, f_23105_14321_14387(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_14406_14468(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_14487_14549(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_14568_14636(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,12709,14649);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_12804_12950(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12804, 12950);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_12979_13125(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 12979, 13125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_13200_13268(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13200, 13268);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_13159_13269(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13159, 13269);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_13303_13340(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13303, 13340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_13366_13396(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13366, 13396);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_13421_13475(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13421, 13475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_13501_13544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13501, 13544);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_13568_13611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13568, 13611);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_13686_13706(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13686, 13706);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_13646_13729(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13646, 13729);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_13909_13950(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13909, 13950);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_13834_13982(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13834, 13982);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_13758_13983(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 13758, 13983);
return return_v;
}


int
f_23105_14073_14139(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14073, 14139);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_14166_14185(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14166, 14185);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_14321_14387(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14321, 14387);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_14406_14468(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14406, 14468);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_14487_14549(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14487, 14549);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_14568_14636(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14568, 14636);
return return_v;
}


int
f_23105_14272_14637(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14272, 14637);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,12709,14649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,12709,14649);
}
		}

[Fact]
        public void MethodWithThisOnlyLocalFunctionClosure1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,14661,16525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14755,14907);

var 
source0 = f_23105_14769_14906(@"
using System;

class C
{
    int F(int a)
    {
        <N:0>int x() => F(1);</N:0>
        return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,14921,15073);

var 
source1 = f_23105_14935_15072(@"
using System;

class C
{
    int F(int a)
    {
        <N:0>int x() => F(2);</N:0>
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15087,15217);

var 
compilation0 = f_23105_15106_15216(source0.Tree, options: f_23105_15147_15215(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15231,15288);

var 
compilation1 = f_23105_15250_15287(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15304,15344);

var 
v0 = f_23105_15313_15343(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15358,15423);

var 
md0 = f_23105_15368_15422(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15439,15492);

var 
f0 = f_23105_15448_15491(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15506,15559);

var 
f1 = f_23105_15515_15558(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15575,15677);

var 
generation0 = f_23105_15593_15676(md0, f_23105_15633_15653(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15693,15931);

var 
diff1 = f_23105_15705_15930(compilation1, generation0, f_23105_15781_15929(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_15856_15897(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,15947,16016);

f_23105_15947_16015(
            diff1, "C: {<F>g__x|0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16032,16062);

var 
md1 = f_23105_16042_16061(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16076,16101);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16148,16514);

f_23105_16148_16513(reader1, f_23105_16197_16263(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_16282_16344(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_16363_16425(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_16444_16512(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,14661,16525);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_14769_14906(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14769, 14906);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_14935_15072(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 14935, 15072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_15147_15215(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15147, 15215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_15106_15216(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15106, 15216);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_15250_15287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15250, 15287);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_15313_15343(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15313, 15343);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_15368_15422(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15368, 15422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_15448_15491(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15448, 15491);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_15515_15558(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15515, 15558);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_15633_15653(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15633, 15653);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_15593_15676(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15593, 15676);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_15856_15897(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15856, 15897);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_15781_15929(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15781, 15929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_15705_15930(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15705, 15930);
return return_v;
}


int
f_23105_15947_16015(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 15947, 16015);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_16042_16061(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16042, 16061);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_16197_16263(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16197, 16263);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_16282_16344(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16282, 16344);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_16363_16425(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16363, 16425);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_16444_16512(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16444, 16512);
return return_v;
}


int
f_23105_16148_16513(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16148, 16513);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,14661,16525);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,14661,16525);
}
		}

[Fact]
        public void MethodWithClosure1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,16537,18491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16610,16786);

var 
source0 = f_23105_16624_16785(@"
using System;

class C
{
    int F(int a)
    <N:0>{</N:0>
        Func<int> x = <N:1>() => F(a + 1)</N:1>;
        return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16800,16976);

var 
source1 = f_23105_16814_16975(@"
using System;

class C
{
    int F(int a)
    <N:0>{</N:0>
        Func<int> x = <N:1>() => F(a + 2)</N:1>;
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,16990,17120);

var 
compilation0 = f_23105_17009_17119(source0.Tree, options: f_23105_17050_17118(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17134,17191);

var 
compilation1 = f_23105_17153_17190(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17207,17247);

var 
v0 = f_23105_17216_17246(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17261,17326);

var 
md0 = f_23105_17271_17325(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17342,17395);

var 
f0 = f_23105_17351_17394(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17409,17462);

var 
f1 = f_23105_17418_17461(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17478,17580);

var 
generation0 = f_23105_17496_17579(md0, f_23105_17536_17556(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17596,17834);

var 
diff1 = f_23105_17608_17833(compilation1, generation0, f_23105_17684_17832(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_17759_17800(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,17923,18069);

f_23105_17923_18068(
            // no new synthesized members generated (with #1 in names):
            diff1, "C.<>c__DisplayClass0_0: {<>4__this, a, <F>b__0}", "C: {<>c__DisplayClass0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,18085,18115);

var 
md1 = f_23105_18095_18114(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,18129,18154);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,18201,18480);

f_23105_18201_18479(reader1, f_23105_18250_18316(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_18335_18397(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_18416_18478(4, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,16537,18491);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_16624_16785(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16624, 16785);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_16814_16975(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 16814, 16975);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_17050_17118(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17050, 17118);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_17009_17119(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17009, 17119);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_17153_17190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17153, 17190);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_17216_17246(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17216, 17246);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_17271_17325(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17271, 17325);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_17351_17394(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17351, 17394);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_17418_17461(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17418, 17461);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_17536_17556(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17536, 17556);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_17496_17579(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17496, 17579);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_17759_17800(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17759, 17800);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_17684_17832(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17684, 17832);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_17608_17833(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17608, 17833);
return return_v;
}


int
f_23105_17923_18068(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 17923, 18068);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_18095_18114(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18095, 18114);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_18250_18316(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18250, 18316);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_18335_18397(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18335, 18397);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_18416_18478(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18416, 18478);
return return_v;
}


int
f_23105_18201_18479(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18201, 18479);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,16537,18491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,16537,18491);
}
		}

[Fact]
        public void MethodWithNullable_AddingNullCheck()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,18503,22040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,18592,19059);

var 
source0 = f_23105_18606_19058(@"
using System;
#nullable enable

class C
{
    static T id<T>(T t) => t;
    static T G<T>(Func<T> f) => f();

    public void F(string? x)
    <N:0>{</N:0>
        var <N:1>y1</N:1> = new { A = id(x) };
        var <N:2>y2</N:2> = G(<N:3>() => new { B = id(x) }</N:3>);
        var <N:4>z</N:4> = G(<N:5>() => y1.A + y2.B</N:5>);
    }
}", options: f_23105_18986_19057(f_23105_18986_19012(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19073,19587);

var 
source1 = f_23105_19087_19586(@"
using System;
#nullable enable

class C
{
    static T id<T>(T t) => t;
    static T G<T>(Func<T> f) => f();

    public void F(string? x)
    <N:0>{</N:0>
        if (x is null) throw new Exception();
        var <N:1>y1</N:1> = new { A = id(x) };
        var <N:2>y2</N:2> = G(<N:3>() => new { B = id(x) }</N:3>);
        var <N:4>z</N:4> = G(<N:5>() => y1.A + y2.B</N:5>);
    }
}", options: f_23105_19514_19585(f_23105_19514_19540(), LanguageVersion.CSharp9))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19601,19678);

var 
compilation0 = f_23105_19620_19677(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19694,19751);

var 
compilation1 = f_23105_19713_19750(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19767,19807);

var 
v0 = f_23105_19776_19806(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19821,19886);

var 
md0 = f_23105_19831_19885(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19902,19955);

var 
f0 = f_23105_19911_19954(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,19969,20022);

var 
f1 = f_23105_19978_20021(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,20038,20140);

var 
generation0 = f_23105_20056_20139(md0, f_23105_20096_20116(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,20156,20394);

var 
diff1 = f_23105_20168_20393(compilation1, generation0, f_23105_20244_20392(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_20319_20360(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,20410,21129);

f_23105_20410_21128(
            diff1, "Microsoft.CodeAnalysis: {EmbeddedAttribute}", "Microsoft: {CodeAnalysis}", "System.Runtime: {CompilerServices, CompilerServices}", "<global namespace>: {Microsoft, System, System}", "C: {<>c__DisplayClass2_0}", "System: {Runtime, Runtime}", "C.<>c__DisplayClass2_0: {x, y1, y2, <F>b__0, <F>b__1}", "<>f__AnonymousType1<<B>j__TPar>: {Equals, GetHashCode, ToString}", "System.Runtime.CompilerServices: {NullableAttribute, NullableContextAttribute}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,21145,21679);

f_23105_21145_21678(
            diff1, "C.<>c__DisplayClass2_0.<F>b__1()", @"
{
  // Code size       28 (0x1c)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""<anonymous type: string A> C.<>c__DisplayClass2_0.y1""
  IL_0006:  callvirt   ""string <>f__AnonymousType0<string>.A.get""
  IL_000b:  ldarg.0
  IL_000c:  ldfld      ""<anonymous type: string B> C.<>c__DisplayClass2_0.y2""
  IL_0011:  callvirt   ""string <>f__AnonymousType1<string>.B.get""
  IL_0016:  call       ""string string.Concat(string, string)""
  IL_001b:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,21695,22029);

f_23105_21695_22028(
            diff1, "C.<>c__DisplayClass2_0.<F>b__0()", @"
{
  // Code size       17 (0x11)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""string C.<>c__DisplayClass2_0.x""
  IL_0006:  call       ""string C.id<string>(string)""
  IL_000b:  newobj     ""<>f__AnonymousType1<string>..ctor(string)""
  IL_0010:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,18503,22040);

Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23105_18986_19012()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 18986, 19012);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23105_18986_19057(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18986, 19057);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_18606_19058(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 18606, 19058);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23105_19514_19540()
{
var return_v = CSharpParseOptions.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 19514, 19540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
f_23105_19514_19585(Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
this_param,Microsoft.CodeAnalysis.CSharp.LanguageVersion
version)
{
var return_v = this_param.WithLanguageVersion( version);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19514, 19585);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_19087_19586(string
markedSource,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
options)
{
var return_v = MarkedSource( markedSource, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19087, 19586);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_19620_19677(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19620, 19677);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_19713_19750(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19713, 19750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_19776_19806(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19776, 19806);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_19831_19885(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19831, 19885);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_19911_19954(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19911, 19954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_19978_20021(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 19978, 20021);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_20096_20116(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20096, 20116);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_20056_20139(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20056, 20139);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_20319_20360(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20319, 20360);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_20244_20392(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20244, 20392);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_20168_20393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20168, 20393);
return return_v;
}


int
f_23105_20410_21128(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 20410, 21128);
return 0;
}


int
f_23105_21145_21678(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 21145, 21678);
return 0;
}


int
f_23105_21695_22028(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 21695, 22028);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,18503,22040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,18503,22040);
}
		}

[Fact]
        public void MethodWithLocalFunctionClosure1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,22052,24019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22138,22305);

var 
source0 = f_23105_22152_22304(@"
using System;

class C
{
    int F(int a)
    <N:0>{</N:0>
        <N:1>int x() => F(a + 1);</N:1>
        return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22319,22486);

var 
source1 = f_23105_22333_22485(@"
using System;

class C
{
    int F(int a)
    <N:0>{</N:0>
        <N:1>int x() => F(a + 2);</N:1>
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22500,22630);

var 
compilation0 = f_23105_22519_22629(source0.Tree, options: f_23105_22560_22628(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22644,22701);

var 
compilation1 = f_23105_22663_22700(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22717,22757);

var 
v0 = f_23105_22726_22756(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22771,22836);

var 
md0 = f_23105_22781_22835(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22852,22905);

var 
f0 = f_23105_22861_22904(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22919,22972);

var 
f1 = f_23105_22928_22971(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,22988,23090);

var 
generation0 = f_23105_23006_23089(md0, f_23105_23046_23066(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,23106,23344);

var 
diff1 = f_23105_23118_23343(compilation1, generation0, f_23105_23194_23342(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_23269_23310(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,23360,23510);

f_23105_23360_23509(
            diff1, "C: {<F>g__x|0_0, <>c__DisplayClass0_0}", "C.<>c__DisplayClass0_0: {<>4__this, a}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,23526,23556);

var 
md1 = f_23105_23536_23555(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,23570,23595);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,23642,24008);

f_23105_23642_24007(reader1, f_23105_23691_23757(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_23776_23838(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_23857_23919(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_23938_24006(6, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,22052,24019);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_22152_22304(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22152, 22304);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_22333_22485(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22333, 22485);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_22560_22628(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22560, 22628);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_22519_22629(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22519, 22629);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_22663_22700(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22663, 22700);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_22726_22756(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22726, 22756);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_22781_22835(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22781, 22835);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_22861_22904(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22861, 22904);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_22928_22971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 22928, 22971);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_23046_23066(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23046, 23066);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_23006_23089(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23006, 23089);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_23269_23310(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23269, 23310);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_23194_23342(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23194, 23342);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_23118_23343(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23118, 23343);
return return_v;
}


int
f_23105_23360_23509(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23360, 23509);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_23536_23555(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23536, 23555);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_23691_23757(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23691, 23757);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_23776_23838(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23776, 23838);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_23857_23919(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23857, 23919);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_23938_24006(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23938, 24006);
return return_v;
}


int
f_23105_23642_24007(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 23642, 24007);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,22052,24019);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,22052,24019);
}
		}

[Fact]
        public void ConstructorWithClosure1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,24031,27458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,24109,24640);

var 
source0 = f_23105_24123_24639(@"
using System;

class D { public D(Func<int> f) { } } 

class C : D
{
    <N:0>public C(int a, int b)</N:0>
      : base(<N:8>() => a</N:8>) 
    <N:1>{</N:1>
        int c = 0;

        Func<int> f1 = <N:2>() => a + 1</N:2>;        
        Func<int> f2 = <N:3>() => b + 2</N:3>;
        Func<int> f3 = <N:4>() => c + 3</N:4>;
        Func<int> f4 = <N:5>() => a + b + c</N:5>;
        Func<int> f5 = <N:6>() => a + c</N:6>;
        Func<int> f6 = <N:7>() => b + c</N:7>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,24654,25220);

var 
source1 = f_23105_24668_25219(@"
using System;

class D { public D(Func<int> f) { } } 

class C : D
{
    <N:0>public C(int a, int b)</N:0>
      : base(<N:8>() => a * 10</N:8>) 
    <N:1>{</N:1>
        int c = 0;

        Func<int> f1 = <N:2>() => a * 10 + 1</N:2>;        
        Func<int> f2 = <N:3>() => b * 10 + 2</N:3>;
        Func<int> f3 = <N:4>() => c * 10 + 3</N:4>;
        Func<int> f4 = <N:5>() => a * 10 + b + c</N:5>;
        Func<int> f5 = <N:6>() => a * 10 + c</N:6>;
        Func<int> f6 = <N:7>() => b * 10 + c</N:7>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25234,25364);

var 
compilation0 = f_23105_25253_25363(source0.Tree, options: f_23105_25294_25362(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25378,25435);

var 
compilation1 = f_23105_25397_25434(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25451,25491);

var 
v0 = f_23105_25460_25490(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25505,25570);

var 
md0 = f_23105_25515_25569(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25586,25673);

var 
ctor0 = f_23105_25598_25642(compilation0, "C").InstanceConstructors.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25687,25774);

var 
ctor1 = f_23105_25699_25743(compilation1, "C").InstanceConstructors.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25790,25892);

var 
generation0 = f_23105_25808_25891(md0, f_23105_25848_25868(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,25908,26152);

var 
diff1 = f_23105_25920_26151(compilation1, generation0, f_23105_25996_26150(SemanticEdit.Create(SemanticEditKind.Update,ctor0,ctor1,f_23105_26077_26118(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,26241,26548);

f_23105_26241_26547(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<>c__DisplayClass0_0, <>c__DisplayClass0_1}", "C.<>c__DisplayClass0_0: {a, b, <.ctor>b__0, <.ctor>b__1, <.ctor>b__2}", "C.<>c__DisplayClass0_1: {c, CS$<>8__locals1, <.ctor>b__3, <.ctor>b__4, <.ctor>b__5, <.ctor>b__6}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,26564,26594);

var 
md1 = f_23105_26574_26593(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,26608,26633);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,26680,27447);

f_23105_26680_27446(reader1, f_23105_26729_26795(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_26814_26876(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_26895_26957(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_26976_27038(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_27057_27119(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_27138_27200(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_27219_27281(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_27300_27363(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_27382_27445(11, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,24031,27458);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_24123_24639(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 24123, 24639);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_24668_25219(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 24668, 25219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_25294_25362(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25294, 25362);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_25253_25363(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25253, 25363);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_25397_25434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25397, 25434);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_25460_25490(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25460, 25490);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_25515_25569(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25515, 25569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23105_25598_25642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25598, 25642);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23105_25699_25743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25699, 25743);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_25848_25868(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25848, 25868);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_25808_25891(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25808, 25891);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_26077_26118(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26077, 26118);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_25996_26150(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25996, 26150);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_25920_26151(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 25920, 26151);
return return_v;
}


int
f_23105_26241_26547(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26241, 26547);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_26574_26593(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26574, 26593);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_26729_26795(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26729, 26795);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_26814_26876(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26814, 26876);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_26895_26957(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26895, 26957);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_26976_27038(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26976, 27038);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_27057_27119(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27057, 27119);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_27138_27200(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27138, 27200);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_27219_27281(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27219, 27281);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_27300_27363(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27300, 27363);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_27382_27445(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27382, 27445);
return return_v;
}


int
f_23105_26680_27446(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 26680, 27446);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,24031,27458);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,24031,27458);
}
		}

[Fact]
        public void PartialClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,27470,29487);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,27537,27716);

var 
source0 = f_23105_27551_27715(@"
using System;

partial class C
{
    Func<int> m1 = <N:0>() => 1</N:0>;
}

partial class C
{
    Func<int> m2 = <N:1>() => 1</N:1>;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,27730,27909);

var 
source1 = f_23105_27744_27908(@"
using System;

partial class C
{
    Func<int> m1 = <N:0>() => 10</N:0>;
}

partial class C
{
    Func<int> m2 = <N:1>() => 10</N:1>;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,27923,28053);

var 
compilation0 = f_23105_27942_28052(source0.Tree, options: f_23105_27983_28051(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28067,28124);

var 
compilation1 = f_23105_28086_28123(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28140,28180);

var 
v0 = f_23105_28149_28179(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28194,28259);

var 
md0 = f_23105_28204_28258(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28275,28362);

var 
ctor0 = f_23105_28287_28331(compilation0, "C").InstanceConstructors.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28376,28463);

var 
ctor1 = f_23105_28388_28432(compilation1, "C").InstanceConstructors.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28479,28581);

var 
generation0 = f_23105_28497_28580(md0, f_23105_28537_28557(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28597,28841);

var 
diff1 = f_23105_28609_28840(compilation1, generation0, f_23105_28685_28839(SemanticEdit.Create(SemanticEditKind.Update,ctor0,ctor1,f_23105_28766_28807(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,28930,29069);

f_23105_28930_29068(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<>c}", "C.<>c: {<>9__2_0, <>9__2_1, <.ctor>b__2_0, <.ctor>b__2_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,29085,29115);

var 
md1 = f_23105_29095_29114(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,29129,29154);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,29201,29476);

f_23105_29201_29475(reader1, f_23105_29250_29312(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_29331_29393(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_29412_29474(5, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,27470,29487);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_27551_27715(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27551, 27715);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_27744_27908(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27744, 27908);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_27983_28051(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27983, 28051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_27942_28052(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 27942, 28052);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_28086_28123(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28086, 28123);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_28149_28179(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28149, 28179);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_28204_28258(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28204, 28258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23105_28287_28331(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28287, 28331);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23105_28388_28432(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28388, 28432);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_28537_28557(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28537, 28557);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_28497_28580(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28497, 28580);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_28766_28807(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28766, 28807);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_28685_28839(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28685, 28839);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_28609_28840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28609, 28840);
return return_v;
}


int
f_23105_28930_29068(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 28930, 29068);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_29095_29114(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29095, 29114);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_29250_29312(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29250, 29312);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_29331_29393(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29331, 29393);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_29412_29474(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29412, 29474);
return return_v;
}


int
f_23105_29201_29475(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29201, 29475);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,27470,29487);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,27470,29487);
}
		}

[Fact]
        public void JoinAndGroupByClauses()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,29499,32528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,29575,29945);

var 
source0 = f_23105_29589_29944(@"
using System.Linq;

class C
{
    void F()
    {
        var result = <N:0>from a in new[] { 1, 2, 3 }</N:0>
                     <N:1>join b in new[] { 5 } on a + 1 equals b - 1</N:1>
                     <N:2>group</N:2> new { a, b = a + 5 } by new { c = a + 4 } into d
                     <N:3>select d.Key</N:3>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,29959,30337);

var 
source1 = f_23105_29973_30336(@"
using System.Linq;

class C
{
    void F()
    {
        var result = <N:0>from a in new[] { 10, 20, 30 }</N:0>
                     <N:1>join b in new[] { 50 } on a + 10 equals b - 10</N:1>
                     <N:2>group</N:2> new { a, b = a + 50 } by new { c = a + 40 } into d
                     <N:3>select d.Key</N:3>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30351,30481);

var 
compilation0 = f_23105_30370_30480(source0.Tree, options: f_23105_30411_30479(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30495,30552);

var 
compilation1 = f_23105_30514_30551(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30568,30608);

var 
v0 = f_23105_30577_30607(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30622,30687);

var 
md0 = f_23105_30632_30686(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30703,30756);

var 
f0 = f_23105_30712_30755(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30770,30823);

var 
f1 = f_23105_30779_30822(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30839,30941);

var 
generation0 = f_23105_30857_30940(md0, f_23105_30897_30917(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,30957,31195);

var 
diff1 = f_23105_30969_31194(compilation1, generation0, f_23105_31045_31193(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_31120_31161(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,31284,31681);

f_23105_31284_31680(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1, <>9__0_2, <>9__0_3, <>9__0_4, <>9__0_5, <F>b__0_0, <F>b__0_1, <F>b__0_2, <F>b__0_3, <F>b__0_4, <F>b__0_5}", "<>f__AnonymousType1<<c>j__TPar>: {Equals, GetHashCode, ToString}", "<>f__AnonymousType0<<a>j__TPar, <b>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,31697,31727);

var 
md1 = f_23105_31707_31726(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,31741,31766);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,31826,32517);

f_23105_31826_32516(reader1, f_23105_31875_31941(6, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_31960_32023(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32042_32105(16, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32124_32187(17, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32206_32269(18, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32288_32351(19, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32370_32433(20, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_32452_32515(21, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,29499,32528);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_29589_29944(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29589, 29944);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_29973_30336(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 29973, 30336);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_30411_30479(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30411, 30479);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_30370_30480(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30370, 30480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_30514_30551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30514, 30551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_30577_30607(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30577, 30607);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_30632_30686(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30632, 30686);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_30712_30755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30712, 30755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_30779_30822(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30779, 30822);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_30897_30917(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30897, 30917);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_30857_30940(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30857, 30940);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_31120_31161(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31120, 31161);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_31045_31193(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31045, 31193);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_30969_31194(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 30969, 31194);
return return_v;
}


int
f_23105_31284_31680(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31284, 31680);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_31707_31726(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31707, 31726);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_31875_31941(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31875, 31941);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_31960_32023(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31960, 32023);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32042_32105(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32042, 32105);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32124_32187(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32124, 32187);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32206_32269(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32206, 32269);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32288_32351(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32288, 32351);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32370_32433(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32370, 32433);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_32452_32515(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32452, 32515);
return return_v;
}


int
f_23105_31826_32516(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 31826, 32516);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,29499,32528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,29499,32528);
}
		}

[Fact]
        public void TransparentIdentifiers_FromClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,32540,36304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,32628,33107);

var 
source0 = f_23105_32642_33106(@"
using System;
using System.Linq;

class C
{
	int Z(Func<int> f)
	{
		return 1;
	}

    void F()
    {
		var <N:10>result = <N:0>from a in new[] { 1 }</N:0>
		                   <N:1>from b in <N:9>new[] { 1 }</N:9></N:1>
		                   <N:2>where <N:7>Z(<N:5>() => a</N:5>) > 0</N:7></N:2>
		                   <N:3>where <N:8>Z(<N:6>() => b</N:6>) > 0</N:8></N:3>
		                   <N:4>select a</N:4></N:10>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33123,33602);

var 
source1 = f_23105_33137_33601(@"
using System;
using System.Linq;

class C
{
	int Z(Func<int> f)
	{
		return 1;
	}

    void F()
    {
		var <N:10>result = <N:0>from a in new[] { 1 }</N:0>
		                   <N:1>from b in <N:9>new[] { 2 }</N:9></N:1>
		                   <N:2>where <N:7>Z(<N:5>() => a</N:5>) > 1</N:7></N:2>
		                   <N:3>where <N:8>Z(<N:6>() => b</N:6>) > 2</N:8></N:3>
		                   <N:4>select a</N:4></N:10>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33616,33746);

var 
compilation0 = f_23105_33635_33745(source0.Tree, options: f_23105_33676_33744(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33760,33817);

var 
compilation1 = f_23105_33779_33816(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33833,33873);

var 
v0 = f_23105_33842_33872(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33887,33952);

var 
md0 = f_23105_33897_33951(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,33968,34021);

var 
f0 = f_23105_33977_34020(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,34035,34088);

var 
f1 = f_23105_34044_34087(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,34104,34206);

var 
generation0 = f_23105_34122_34205(md0, f_23105_34162_34182(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,34222,34460);

var 
diff1 = f_23105_34234_34459(compilation1, generation0, f_23105_34310_34458(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_34385_34426(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,34549,35030);

f_23105_34549_35029(
            // no new synthesized members generated (with #1 in names):
            diff1, "C.<>c__DisplayClass1_1: {<>h__TransparentIdentifier0, <F>b__6}", "C.<>c__DisplayClass1_0: {<>h__TransparentIdentifier0, <F>b__5}", "C.<>c: {<>9__1_0, <>9__1_1, <>9__1_4, <F>b__1_0, <F>b__1_1, <F>b__1_4}", "C: {<F>b__1_2, <F>b__1_3, <>c__DisplayClass1_0, <>c__DisplayClass1_1, <>c}", "<>f__AnonymousType0<<a>j__TPar, <b>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,35046,35076);

var 
md1 = f_23105_35056_35075(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,35090,35115);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,35175,36293);

f_23105_35175_36292(reader1, f_23105_35224_35290(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_35309_35375(8, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_35394_35460(9, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_35479_35541(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35560_35623(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35642_35705(11, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35724_35787(13, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35806_35869(15, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35888_35951(18, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_35970_36033(19, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_36052_36115(20, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_36134_36203(17, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23105_36222_36291(18, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,32540,36304);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_32642_33106(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 32642, 33106);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_33137_33601(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33137, 33601);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_33676_33744(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33676, 33744);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_33635_33745(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33635, 33745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_33779_33816(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33779, 33816);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_33842_33872(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33842, 33872);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_33897_33951(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33897, 33951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_33977_34020(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 33977, 34020);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_34044_34087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34044, 34087);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_34162_34182(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34162, 34182);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_34122_34205(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34122, 34205);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_34385_34426(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34385, 34426);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_34310_34458(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34310, 34458);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_34234_34459(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34234, 34459);
return return_v;
}


int
f_23105_34549_35029(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 34549, 35029);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_35056_35075(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35056, 35075);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35224_35290(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35224, 35290);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35309_35375(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35309, 35375);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35394_35460(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35394, 35460);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35479_35541(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35479, 35541);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35560_35623(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35560, 35623);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35642_35705(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35642, 35705);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35724_35787(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35724, 35787);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35806_35869(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35806, 35869);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35888_35951(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35888, 35951);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_35970_36033(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35970, 36033);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_36052_36115(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 36052, 36115);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_36134_36203(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 36134, 36203);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_36222_36291(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 36222, 36291);
return return_v;
}


int
f_23105_35175_36292(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 35175, 36292);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,32540,36304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,32540,36304);
}
		}

[Fact]
        public void TransparentIdentifiers_LetClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,36316,39090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,36403,36728);

var 
source0 = f_23105_36417_36727(@"
using System;
using System.Linq;

class C
{
	int Z(Func<int> f)
	{
		return 1;
	}

    void F()
    {
		var result = <N:0>from a in new[] { 1 }</N:0>
		             <N:1>let b = <N:2>Z(<N:3>() => a</N:3>)</N:2></N:1>
		             <N:4>select <N:5>a + b</N:5></N:4>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,36744,37073);

var 
source1 = f_23105_36758_37072(@"
using System;
using System.Linq;

class C
{
	int Z(Func<int> f)
	{
		return 1;
	}

    void F()
    {
		var result = <N:0>from a in new[] { 1 }</N:0>
		             <N:1>let b = <N:2>Z(<N:3>() => a</N:3>) + 1</N:2></N:1>
		             <N:4>select <N:5>a + b</N:5></N:4>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37087,37217);

var 
compilation0 = f_23105_37106_37216(source0.Tree, options: f_23105_37147_37215(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37231,37288);

var 
compilation1 = f_23105_37250_37287(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37304,37344);

var 
v0 = f_23105_37313_37343(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37358,37423);

var 
md0 = f_23105_37368_37422(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37439,37492);

var 
f0 = f_23105_37448_37491(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37506,37559);

var 
f1 = f_23105_37515_37558(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37575,37677);

var 
generation0 = f_23105_37593_37676(md0, f_23105_37633_37653(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,37693,37931);

var 
diff1 = f_23105_37705_37930(compilation1, generation0, f_23105_37781_37929(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_37856_37897(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,38020,38317);

f_23105_38020_38316(
            // no new synthesized members generated (with #1 in names):
            diff1, "C.<>c: {<>9__1_1, <F>b__1_1}", "<>f__AnonymousType0<<a>j__TPar, <b>j__TPar>: {Equals, GetHashCode, ToString}", "C.<>c__DisplayClass1_0: {a, <F>b__2}", "C: {<F>b__1_0, <>c__DisplayClass1_0, <>c}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,38333,38363);

var 
md1 = f_23105_38343_38362(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,38377,38402);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,38462,39079);

f_23105_38462_39078(reader1, f_23105_38511_38577(6, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_38596_38662(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_38681_38743(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_38762_38825(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_38844_38907(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_38926_38989(15, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_39008_39077(15, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,36316,39090);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_36417_36727(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 36417, 36727);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_36758_37072(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 36758, 37072);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_37147_37215(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37147, 37215);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_37106_37216(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37106, 37216);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_37250_37287(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37250, 37287);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_37313_37343(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37313, 37343);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_37368_37422(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37368, 37422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_37448_37491(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37448, 37491);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_37515_37558(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37515, 37558);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_37633_37653(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37633, 37653);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_37593_37676(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37593, 37676);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_37856_37897(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37856, 37897);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_37781_37929(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37781, 37929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_37705_37930(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 37705, 37930);
return return_v;
}


int
f_23105_38020_38316(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38020, 38316);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_38343_38362(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38343, 38362);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38511_38577(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38511, 38577);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38596_38662(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38596, 38662);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38681_38743(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38681, 38743);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38762_38825(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38762, 38825);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38844_38907(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38844, 38907);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_38926_38989(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38926, 38989);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_39008_39077(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 39008, 39077);
return return_v;
}


int
f_23105_38462_39078(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 38462, 39078);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,36316,39090);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,36316,39090);
}
		}

[Fact]
        public void TransparentIdentifiers_JoinClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,39102,43011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,39190,39774);

var 
source0 = f_23105_39204_39773(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>join b in new[] { 3 } on 
                          <N:3>Z(<N:4>() => <N:5>a + 1</N:5></N:4>)</N:3> 
                          equals 
                          <N:6>Z(<N:7>() => <N:8>b - 1</N:8></N:7>)</N:6></N:2>
                     <N:9>select <N:10>Z(<N:11>() => <N:12>a + b</N:12></N:11>)</N:10></N:9>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,39790,40374);

var 
source1 = f_23105_39804_40373(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>join b in new[] { 3 } on 
                          <N:3>Z(<N:4>() => <N:5>a + 1</N:5></N:4>)</N:3> 
                          equals 
                          <N:6>Z(<N:7>() => <N:8>b - 1</N:8></N:7>)</N:6></N:2>
                     <N:9>select <N:10>Z(<N:11>() => <N:12>a - b</N:12></N:11>)</N:10></N:9>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40388,40518);

var 
compilation0 = f_23105_40407_40517(source0.Tree, options: f_23105_40448_40516(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40532,40589);

var 
compilation1 = f_23105_40551_40588(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40605,40645);

var 
v0 = f_23105_40614_40644(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40659,40724);

var 
md0 = f_23105_40669_40723(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40740,40793);

var 
f0 = f_23105_40749_40792(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40807,40860);

var 
f1 = f_23105_40816_40859(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40876,40978);

var 
generation0 = f_23105_40894_40977(md0, f_23105_40934_40954(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,40994,41232);

var 
diff1 = f_23105_41006_41231(compilation1, generation0, f_23105_41082_41230(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_41157_41198(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,41321,41650);

f_23105_41321_41649(
            // no new synthesized members generated (with #1 in names):
            diff1, "C.<>c__DisplayClass1_1: {b, <F>b__4}", "C.<>c__DisplayClass1_2: {a, b, <F>b__5}", "C.<>c__DisplayClass1_0: {a, <F>b__3}", "C: {<F>b__1_0, <F>b__1_1, <F>b__1_2, <>c__DisplayClass1_0, <>c__DisplayClass1_1, <>c__DisplayClass1_2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,41666,41696);

var 
md1 = f_23105_41676_41695(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,41710,41735);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,41795,43000);

f_23105_41795_42999(reader1, f_23105_41844_41910(6, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_41929_41995(7, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_42014_42080(8, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_42099_42165(9, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_42184_42246(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42265_42327(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42346_42408(5, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42427_42489(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42508_42570(8, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42589_42652(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42671_42734(12, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_42753_42822(10, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23105_42841_42910(11, TableIndex.CustomAttribute, EditAndContinueOperation.Default), f_23105_42929_42998(12, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,39102,43011);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_39204_39773(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 39204, 39773);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_39804_40373(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 39804, 40373);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_40448_40516(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40448, 40516);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_40407_40517(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40407, 40517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_40551_40588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40551, 40588);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_40614_40644(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40614, 40644);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_40669_40723(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40669, 40723);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_40749_40792(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40749, 40792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_40816_40859(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40816, 40859);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_40934_40954(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40934, 40954);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_40894_40977(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 40894, 40977);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_41157_41198(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41157, 41198);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_41082_41230(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41082, 41230);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_41006_41231(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41006, 41231);
return return_v;
}


int
f_23105_41321_41649(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41321, 41649);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_41676_41695(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41676, 41695);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_41844_41910(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41844, 41910);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_41929_41995(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41929, 41995);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42014_42080(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42014, 42080);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42099_42165(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42099, 42165);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42184_42246(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42184, 42246);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42265_42327(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42265, 42327);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42346_42408(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42346, 42408);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42427_42489(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42427, 42489);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42508_42570(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42508, 42570);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42589_42652(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42589, 42652);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42671_42734(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42671, 42734);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42753_42822(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42753, 42822);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42841_42910(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42841, 42910);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_42929_42998(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 42929, 42998);
return return_v;
}


int
f_23105_41795_42999(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 41795, 42999);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,39102,43011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,39102,43011);
}
		}

[Fact]
        public void TransparentIdentifiers_JoinIntoClause()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,43023,46145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,43115,43613);

var 
source0 = f_23105_43129_43612(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>join b in new[] { 3 } on 
                          <N:3>a + 1</N:3> equals <N:4>b - 1</N:4>
                          into g</N:2>
                     <N:5>select <N:6>Z(<N:7>() => <N:8>g.First()</N:8></N:7>)</N:6></N:5>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,43629,44126);

var 
source1 = f_23105_43643_44125(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>join b in new[] { 3 } on 
                          <N:3>a + 1</N:3> equals <N:4>b - 1</N:4>
                          into g</N:2>
                     <N:5>select <N:6>Z(<N:7>() => <N:8>g.Last()</N:8></N:7>)</N:6></N:5>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44140,44270);

var 
compilation0 = f_23105_44159_44269(source0.Tree, options: f_23105_44200_44268(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44284,44341);

var 
compilation1 = f_23105_44303_44340(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44357,44397);

var 
v0 = f_23105_44366_44396(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44411,44476);

var 
md0 = f_23105_44421_44475(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44492,44545);

var 
f0 = f_23105_44501_44544(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44559,44612);

var 
f1 = f_23105_44568_44611(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44628,44730);

var 
generation0 = f_23105_44646_44729(md0, f_23105_44686_44706(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,44746,44984);

var 
diff1 = f_23105_44758_44983(compilation1, generation0, f_23105_44834_44982(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_44909_44950(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,45073,45294);

f_23105_45073_45293(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<F>b__1_2, <>c__DisplayClass1_0, <>c}", "C.<>c: {<>9__1_0, <>9__1_1, <F>b__1_0, <F>b__1_1}", "C.<>c__DisplayClass1_0: {g, <F>b__3}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,45310,45340);

var 
md1 = f_23105_45320_45339(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,45354,45379);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,45439,46134);

f_23105_45439_46133(reader1, f_23105_45488_45554(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_45573_45639(5, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_45658_45720(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_45739_45801(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_45820_45882(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_45901_45963(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_45982_46045(10, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_46064_46132(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,43023,46145);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_43129_43612(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 43129, 43612);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_43643_44125(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 43643, 44125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_44200_44268(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44200, 44268);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_44159_44269(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44159, 44269);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_44303_44340(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44303, 44340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_44366_44396(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44366, 44396);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_44421_44475(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44421, 44475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_44501_44544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44501, 44544);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_44568_44611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44568, 44611);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_44686_44706(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44686, 44706);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_44646_44729(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44646, 44729);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_44909_44950(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44909, 44950);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_44834_44982(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44834, 44982);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_44758_44983(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 44758, 44983);
return return_v;
}


int
f_23105_45073_45293(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45073, 45293);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_45320_45339(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45320, 45339);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45488_45554(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45488, 45554);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45573_45639(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45573, 45639);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45658_45720(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45658, 45720);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45739_45801(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45739, 45801);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45820_45882(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45820, 45882);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45901_45963(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45901, 45963);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_45982_46045(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45982, 46045);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_46064_46132(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 46064, 46132);
return return_v;
}


int
f_23105_45439_46133(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 45439, 46133);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,43023,46145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,43023,46145);
}
		}

[Fact]
        public void TransparentIdentifiers_QueryContinuation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,46157,49059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,46252,46690);

var 
source0 = f_23105_46266_46689(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>group a by <N:3>a + 1</N:3></N:2>
                     <N:4>into g
                     <N:5>select <N:6>Z(<N:7>() => <N:8>g.First()</N:8></N:7>)</N:6></N:5></N:4>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,46706,47143);

var 
source1 = f_23105_46720_47142(@"
using System;
using System.Linq;

class C
{
    int Z(Func<int> f)
    {
        return 1;
    }

    public void F()
    {
        var result = <N:0>from a in <N:1>new[] { 1 }</N:1></N:0>
                     <N:2>group a by <N:3>a + 1</N:3></N:2>
                     <N:4>into g
                     <N:5>select <N:6>Z(<N:7>() => <N:8>g.Last()</N:8></N:7>)</N:6></N:5></N:4>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47157,47287);

var 
compilation0 = f_23105_47176_47286(source0.Tree, options: f_23105_47217_47285(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47301,47358);

var 
compilation1 = f_23105_47320_47357(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47374,47414);

var 
v0 = f_23105_47383_47413(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47428,47493);

var 
md0 = f_23105_47438_47492(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47509,47562);

var 
f0 = f_23105_47518_47561(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47576,47629);

var 
f1 = f_23105_47585_47628(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47645,47747);

var 
generation0 = f_23105_47663_47746(md0, f_23105_47703_47723(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,47763,48001);

var 
diff1 = f_23105_47775_48000(compilation1, generation0, f_23105_47851_47999(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_47926_47967(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,48090,48290);

f_23105_48090_48289(
            // no new synthesized members generated (with #1 in names):
            diff1, "C: {<F>b__1_1, <>c__DisplayClass1_0, <>c}", "C.<>c: {<>9__1_0, <F>b__1_0}", "C.<>c__DisplayClass1_0: {g, <F>b__2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,48306,48336);

var 
md1 = f_23105_48316_48335(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,48350,48375);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,48435,49048);

f_23105_48435_49047(reader1, f_23105_48484_48550(4, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_48569_48635(5, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_48654_48716(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_48735_48797(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_48816_48878(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_48897_48959(9, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_48978_49046(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,46157,49059);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_46266_46689(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 46266, 46689);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_46720_47142(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 46720, 47142);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_47217_47285(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47217, 47285);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_47176_47286(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47176, 47286);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_47320_47357(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47320, 47357);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_47383_47413(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47383, 47413);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_47438_47492(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47438, 47492);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_47518_47561(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47518, 47561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_47585_47628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47585, 47628);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_47703_47723(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47703, 47723);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_47663_47746(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47663, 47746);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_47926_47967(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47926, 47967);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_47851_47999(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47851, 47999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_47775_48000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 47775, 48000);
return return_v;
}


int
f_23105_48090_48289(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48090, 48289);
return 0;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_48316_48335(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48316, 48335);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48484_48550(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48484, 48550);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48569_48635(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48569, 48635);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48654_48716(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48654, 48716);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48735_48797(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48735, 48797);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48816_48878(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48816, 48878);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48897_48959(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48897, 48959);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_48978_49046(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48978, 49046);
return return_v;
}


int
f_23105_48435_49047(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 48435, 49047);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,46157,49059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,46157,49059);
}
		}

[Fact]
        public void Lambdas_UpdateAfterAdd()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,49071,51804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49148,49318);

var 
source0 = f_23105_49162_49317(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(null);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49332,49519);

var 
source1 = f_23105_49346_49518(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 1</N:0>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49533,49720);

var 
source2 = f_23105_49547_49719(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 2</N:0>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49736,49866);

var 
compilation0 = f_23105_49755_49865(source0.Tree, options: f_23105_49796_49864(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49880,49937);

var 
compilation1 = f_23105_49899_49936(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,49951,50008);

var 
compilation2 = f_23105_49970_50007(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50022,50062);

var 
v0 = f_23105_50031_50061(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50076,50141);

var 
md0 = f_23105_50086_50140(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50157,50210);

var 
f0 = f_23105_50166_50209(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50224,50277);

var 
f1 = f_23105_50233_50276(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50291,50344);

var 
f2 = f_23105_50300_50343(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50360,50462);

var 
generation0 = f_23105_50378_50461(md0, f_23105_50418_50438(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50478,50716);

var 
diff1 = f_23105_50490_50715(compilation1, generation0, f_23105_50566_50714(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_50641_50682(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50732,50762);

var 
md1 = f_23105_50742_50761(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50776,50801);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,50872,50982);

f_23105_50872_50981(
            // new lambda "<F>b__0#1" has been added:
            diff1, "C: {<>c}", "C.<>c: {<>9__0#1, <F>b__0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,51021,51192);

f_23105_51021_51191(
            // added:
            diff1, "C.<>c.<F>b__0#1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.1
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,51208,51455);

var 
diff2 = f_23105_51220_51454(compilation2, f_23105_51266_51286(diff1), f_23105_51305_51453(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_51380_51421(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,51471,51581);

f_23105_51471_51580(
            diff2, "C: {<>c}", "C.<>c: {<>9__0#1, <F>b__0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,51622,51793);

f_23105_51622_51792(
            // updated:
            diff2, "C.<>c.<F>b__0#1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.2
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,49071,51804);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_49162_49317(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49162, 49317);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_49346_49518(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49346, 49518);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_49547_49719(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49547, 49719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_49796_49864(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49796, 49864);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_49755_49865(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49755, 49865);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_49899_49936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49899, 49936);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_49970_50007(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 49970, 50007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_50031_50061(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50031, 50061);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_50086_50140(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50086, 50140);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_50166_50209(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50166, 50209);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_50233_50276(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50233, 50276);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_50300_50343(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50300, 50343);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_50418_50438(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50418, 50438);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_50378_50461(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50378, 50461);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_50641_50682(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50641, 50682);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_50566_50714(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50566, 50714);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_50490_50715(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50490, 50715);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_50742_50761(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50742, 50761);
return return_v;
}


int
f_23105_50872_50981(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 50872, 50981);
return 0;
}


int
f_23105_51021_51191(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51021, 51191);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_51266_51286(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 51266, 51286);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_51380_51421(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51380, 51421);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_51305_51453(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51305, 51453);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_51220_51454(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51220, 51454);
return return_v;
}


int
f_23105_51471_51580(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51471, 51580);
return 0;
}


int
f_23105_51622_51792(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51622, 51792);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,49071,51804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,49071,51804);
}
		}

[Fact]
        public void LocalFunctions_UpdateAfterAdd()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,51816,54526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,51900,52070);

var 
source0 = f_23105_51914_52069(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(null);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52084,52294);

var 
source1 = f_23105_52098_52293(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f(int a) => a + 1;</N:0>
        return G(f);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52308,52518);

var 
source2 = f_23105_52322_52517(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f(int a) => a + 2;</N:0>
        return G(f);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52534,52664);

var 
compilation0 = f_23105_52553_52663(source0.Tree, options: f_23105_52594_52662(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52678,52735);

var 
compilation1 = f_23105_52697_52734(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52749,52806);

var 
compilation2 = f_23105_52768_52805(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52820,52860);

var 
v0 = f_23105_52829_52859(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52874,52939);

var 
md0 = f_23105_52884_52938(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,52955,53008);

var 
f0 = f_23105_52964_53007(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53022,53075);

var 
f1 = f_23105_53031_53074(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53089,53142);

var 
f2 = f_23105_53098_53141(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53158,53260);

var 
generation0 = f_23105_53176_53259(md0, f_23105_53216_53236(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53276,53514);

var 
diff1 = f_23105_53288_53513(compilation1, generation0, f_23105_53364_53512(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_53439_53480(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53530,53560);

var 
md1 = f_23105_53540_53559(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53574,53599);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53670,53739);

f_23105_53670_53738(
            // new lambda "<F>b__0#1" has been added:
            diff1, "C: {<F>g__f|0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53778,53952);

f_23105_53778_53951(
            // added:
            diff1, "C.<F>g__f|0#1(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.1
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,53968,54215);

var 
diff2 = f_23105_53980_54214(compilation2, f_23105_54026_54046(diff1), f_23105_54065_54213(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_54140_54181(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,54231,54300);

f_23105_54231_54299(
            diff2, "C: {<F>g__f|0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,54341,54515);

f_23105_54341_54514(
            // updated:
            diff2, "C.<F>g__f|0#1(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.2
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,51816,54526);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_51914_52069(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 51914, 52069);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_52098_52293(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52098, 52293);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_52322_52517(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52322, 52517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_52594_52662(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52594, 52662);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_52553_52663(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52553, 52663);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_52697_52734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52697, 52734);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_52768_52805(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52768, 52805);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_52829_52859(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52829, 52859);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_52884_52938(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52884, 52938);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_52964_53007(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 52964, 53007);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_53031_53074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53031, 53074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_53098_53141(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53098, 53141);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_53216_53236(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53216, 53236);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_53176_53259(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53176, 53259);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_53439_53480(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53439, 53480);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_53364_53512(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53364, 53512);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_53288_53513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53288, 53513);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_53540_53559(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53540, 53559);
return return_v;
}


int
f_23105_53670_53738(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53670, 53738);
return 0;
}


int
f_23105_53778_53951(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53778, 53951);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_54026_54046(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 54026, 54046);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_54140_54181(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54140, 54181);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_54065_54213(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54065, 54213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_53980_54214(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 53980, 54214);
return return_v;
}


int
f_23105_54231_54299(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54231, 54299);
return 0;
}


int
f_23105_54341_54514(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54341, 54514);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,51816,54526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,51816,54526);
}
		}

[Fact]
        public void LocalFunctions_UpdateAfterAdd_NoDelegatePassing()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,54538,57122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,54640,54760);

var 
source0 = f_23105_54654_54759(@"
using System;

class C
{
    static object F()
    {
        return 0;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,54774,54937);

var 
source1 = f_23105_54788_54936(@"
using System;

class C
{
    static object F()
    {
        <N:0>int f(int a) => a + 1;</N:0>
        return 1;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,54951,55114);

var 
source2 = f_23105_54965_55113(@"
using System;

class C
{
    static object F()
    {
        <N:0>int f(int a) => a + 2;</N:0>
        return 2;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55130,55260);

var 
compilation0 = f_23105_55149_55259(source0.Tree, options: f_23105_55190_55258(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55274,55331);

var 
compilation1 = f_23105_55293_55330(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55345,55402);

var 
compilation2 = f_23105_55364_55401(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55416,55456);

var 
v0 = f_23105_55425_55455(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55470,55535);

var 
md0 = f_23105_55480_55534(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55551,55604);

var 
f0 = f_23105_55560_55603(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55618,55671);

var 
f1 = f_23105_55627_55670(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55685,55738);

var 
f2 = f_23105_55694_55737(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55754,55856);

var 
generation0 = f_23105_55772_55855(md0, f_23105_55812_55832(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,55872,56110);

var 
diff1 = f_23105_55884_56109(compilation1, generation0, f_23105_55960_56108(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_56035_56076(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56126,56156);

var 
md1 = f_23105_56136_56155(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56170,56195);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56266,56335);

f_23105_56266_56334(
            // new lambda "<F>b__0#1" has been added:
            diff1, "C: {<F>g__f|0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56374,56548);

f_23105_56374_56547(
            // added:
            diff1, "C.<F>g__f|0#1(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.1
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56564,56811);

var 
diff2 = f_23105_56576_56810(compilation2, f_23105_56622_56642(diff1), f_23105_56661_56809(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_56736_56777(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56827,56896);

f_23105_56827_56895(
            diff2, "C: {<F>g__f|0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,56937,57111);

f_23105_56937_57110(
            // updated:
            diff2, "C.<F>g__f|0#1(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.2
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,54538,57122);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_54654_54759(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54654, 54759);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_54788_54936(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54788, 54936);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_54965_55113(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 54965, 55113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_55190_55258(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55190, 55258);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_55149_55259(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55149, 55259);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_55293_55330(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55293, 55330);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_55364_55401(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55364, 55401);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_55425_55455(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55425, 55455);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_55480_55534(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55480, 55534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_55560_55603(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55560, 55603);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_55627_55670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55627, 55670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_55694_55737(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55694, 55737);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_55812_55832(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55812, 55832);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_55772_55855(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55772, 55855);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_56035_56076(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56035, 56076);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_55960_56108(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55960, 56108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_55884_56109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 55884, 56109);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_56136_56155(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56136, 56155);
return return_v;
}


int
f_23105_56266_56334(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56266, 56334);
return 0;
}


int
f_23105_56374_56547(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56374, 56547);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_56622_56642(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 56622, 56642);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_56736_56777(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56736, 56777);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_56661_56809(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56661, 56809);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_56576_56810(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56576, 56810);
return return_v;
}


int
f_23105_56827_56895(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56827, 56895);
return 0;
}


int
f_23105_56937_57110(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 56937, 57110);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,54538,57122);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,54538,57122);
}
		}

[Fact]
        public void LambdasMultipleGenerations1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,57134,62252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,57216,57403);

var 
source0 = f_23105_57230_57402(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 1</N:0>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,57417,57632);

var 
source1 = f_23105_57431_57631(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 2</N:0>) + G(<N:1>b => b + 20</N:1>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,57646,57892);

var 
source2 = f_23105_57660_57891(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 3</N:0>) + G(<N:1>b => b + 30</N:1>) + G(<N:2>c => c + 0x300</N:2>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,57906,58152);

var 
source3 = f_23105_57920_58151(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + 4</N:0>) + G(<N:1>b => b + 40</N:1>) + G(<N:2>c => c + 0x400</N:2>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58168,58298);

var 
compilation0 = f_23105_58187_58297(source0.Tree, options: f_23105_58228_58296(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58312,58369);

var 
compilation1 = f_23105_58331_58368(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58383,58440);

var 
compilation2 = f_23105_58402_58439(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58454,58511);

var 
compilation3 = f_23105_58473_58510(compilation2, source3.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58525,58565);

var 
v0 = f_23105_58534_58564(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58579,58644);

var 
md0 = f_23105_58589_58643(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58660,58713);

var 
f0 = f_23105_58669_58712(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58727,58780);

var 
f1 = f_23105_58736_58779(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58794,58847);

var 
f2 = f_23105_58803_58846(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58861,58914);

var 
f3 = f_23105_58870_58913(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,58930,59032);

var 
generation0 = f_23105_58948_59031(md0, f_23105_58988_59008(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59048,59286);

var 
diff1 = f_23105_59060_59285(compilation1, generation0, f_23105_59136_59284(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_59211_59252(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59302,59332);

var 
md1 = f_23105_59312_59331(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59346,59371);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59444,59579);

f_23105_59444_59578(
            // new lambda "<F>b__1_1#1" has been added:
            diff1, "C: {<>c}", "C.<>c: {<>9__1_0, <>9__1_1#1, <F>b__1_0, <F>b__1_1#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59620,59791);

f_23105_59620_59790(
            // updated:
            diff1, "C.<>c.<F>b__1_0", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.2
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,59828,60006);

f_23105_59828_60005(            // added:
            diff1, "C.<>c.<F>b__1_1#1", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.s   20
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,60022,60269);

var 
diff2 = f_23105_60034_60268(compilation2, f_23105_60080_60100(diff1), f_23105_60119_60267(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_60194_60235(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,60342,60502);

f_23105_60342_60501(
            // new lambda "<F>b__1_2#2" has been added:
            diff2, "C: {<>c}", "C.<>c: {<>9__1_0, <>9__1_1#1, <>9__1_2#2, <F>b__1_0, <F>b__1_1#1, <F>b__1_2#2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,60543,60714);

f_23105_60543_60713(
            // updated:
            diff2, "C.<>c.<F>b__1_0", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.3
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,60753,60931);

f_23105_60753_60930(            // updated:
            diff2, "C.<>c.<F>b__1_1#1", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.s   30
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,60970,61151);

f_23105_60970_61150(
            // added:
            diff2, "C.<>c.<F>b__1_2#2", @"
{
  // Code size        8 (0x8)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4     0x300
  IL_0006:  add
  IL_0007:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,61167,61414);

var 
diff3 = f_23105_61179_61413(compilation3, f_23105_61225_61245(diff2), f_23105_61264_61412(SemanticEdit.Create(SemanticEditKind.Update,f2,f3,f_23105_61339_61380(source2, source3),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,61430,61590);

f_23105_61430_61589(
            diff3, "C: {<>c}", "C.<>c: {<>9__1_0, <>9__1_1#1, <>9__1_2#2, <F>b__1_0, <F>b__1_1#1, <F>b__1_2#2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,61631,61802);

f_23105_61631_61801(
            // updated:
            diff3, "C.<>c.<F>b__1_0", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.4
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,61841,62019);

f_23105_61841_62018(            // updated:
            diff3, "C.<>c.<F>b__1_1#1", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.s   40
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,62060,62241);

f_23105_62060_62240(
            // updated:
            diff3, "C.<>c.<F>b__1_2#2", @"
{
  // Code size        8 (0x8)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4     0x400
  IL_0006:  add
  IL_0007:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,57134,62252);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_57230_57402(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 57230, 57402);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_57431_57631(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 57431, 57631);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_57660_57891(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 57660, 57891);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_57920_58151(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 57920, 58151);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_58228_58296(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58228, 58296);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_58187_58297(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58187, 58297);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_58331_58368(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58331, 58368);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_58402_58439(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58402, 58439);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_58473_58510(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58473, 58510);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_58534_58564(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58534, 58564);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_58589_58643(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58589, 58643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_58669_58712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58669, 58712);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_58736_58779(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58736, 58779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_58803_58846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58803, 58846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_58870_58913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58870, 58913);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_58988_59008(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58988, 59008);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_58948_59031(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 58948, 59031);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_59211_59252(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59211, 59252);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_59136_59284(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59136, 59284);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_59060_59285(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59060, 59285);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_59312_59331(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59312, 59331);
return return_v;
}


int
f_23105_59444_59578(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59444, 59578);
return 0;
}


int
f_23105_59620_59790(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59620, 59790);
return 0;
}


int
f_23105_59828_60005(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 59828, 60005);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_60080_60100(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 60080, 60100);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_60194_60235(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60194, 60235);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_60119_60267(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60119, 60267);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_60034_60268(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60034, 60268);
return return_v;
}


int
f_23105_60342_60501(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60342, 60501);
return 0;
}


int
f_23105_60543_60713(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60543, 60713);
return 0;
}


int
f_23105_60753_60930(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60753, 60930);
return 0;
}


int
f_23105_60970_61150(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 60970, 61150);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_61225_61245(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 61225, 61245);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_61339_61380(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61339, 61380);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_61264_61412(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61264, 61412);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_61179_61413(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61179, 61413);
return return_v;
}


int
f_23105_61430_61589(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61430, 61589);
return 0;
}


int
f_23105_61631_61801(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61631, 61801);
return 0;
}


int
f_23105_61841_62018(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 61841, 62018);
return 0;
}


int
f_23105_62060_62240(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 62060, 62240);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,57134,62252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,57134,62252);
}
		}

[Fact]
        public void LocalFunctionsMultipleGenerations1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,62264,67369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,62353,62565);

var 
source0 = f_23105_62367_62564(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f1(int a) => a + 1;</N:0>
        return G(f1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,62579,62844);

var 
source1 = f_23105_62593_62843(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f1(int a) => a + 2;</N:0>
        <N:1>int f2(int b) => b + 20;</N:1>
        return G(f1) + G(f2);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,62858,63179);

var 
source2 = f_23105_62872_63178(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f1(int a) => a + 3;</N:0>
        <N:1>int f2(int b) => b + 30;</N:1>
        <N:2>int f3(int c) => c + 0x300;</N:2>
        return G(f1) + G(f2) + G(f3);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63193,63514);

var 
source3 = f_23105_63207_63513(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        <N:0>int f1(int a) => a + 4;</N:0>
        <N:1>int f2(int b) => b + 40;</N:1>
        <N:2>int f3(int c) => c + 0x400;</N:2>
        return G(f1) + G(f2) + G(f3);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63530,63660);

var 
compilation0 = f_23105_63549_63659(source0.Tree, options: f_23105_63590_63658(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63674,63731);

var 
compilation1 = f_23105_63693_63730(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63745,63802);

var 
compilation2 = f_23105_63764_63801(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63816,63873);

var 
compilation3 = f_23105_63835_63872(compilation2, source3.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63887,63927);

var 
v0 = f_23105_63896_63926(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,63941,64006);

var 
md0 = f_23105_63951_64005(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64022,64075);

var 
f0 = f_23105_64031_64074(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64089,64142);

var 
f1 = f_23105_64098_64141(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64156,64209);

var 
f2 = f_23105_64165_64208(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64223,64276);

var 
f3 = f_23105_64232_64275(compilation3, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64292,64394);

var 
generation0 = f_23105_64310_64393(md0, f_23105_64350_64370(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64410,64648);

var 
diff1 = f_23105_64422_64647(compilation1, generation0, f_23105_64498_64646(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_64573_64614(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64664,64694);

var 
md1 = f_23105_64674_64693(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64708,64733);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64749,64835);

f_23105_64749_64834(
            diff1, "C: {<F>g__f1|1_0, <F>g__f2|1_1#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,64876,65051);

f_23105_64876_65050(
            // updated:
            diff1, "C.<F>g__f1|1_0(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.2
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,65090,65272);

f_23105_65090_65271(
            // added:
            diff1, "C.<F>g__f2|1_1#1(int)", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.s   20
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,65288,65535);

var 
diff2 = f_23105_65300_65534(compilation2, f_23105_65346_65366(diff1), f_23105_65385_65533(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_65460_65501(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,65551,65653);

f_23105_65551_65652(
            diff2, "C: {<F>g__f1|1_0, <F>g__f2|1_1#1, <F>g__f3|1_2#2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,65694,65869);

f_23105_65694_65868(
            // updated:
            diff2, "C.<F>g__f1|1_0(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.3
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,65908,66090);

f_23105_65908_66089(            // updated:
            diff2, "C.<F>g__f2|1_1#1(int)", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.s   30
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,66129,66314);

f_23105_66129_66313(
            // added:
            diff2, "C.<F>g__f3|1_2#2(int)", @"
{
  // Code size        8 (0x8)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4     0x300
  IL_0006:  add
  IL_0007:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,66330,66577);

var 
diff3 = f_23105_66342_66576(compilation3, f_23105_66388_66408(diff2), f_23105_66427_66575(SemanticEdit.Create(SemanticEditKind.Update,f2,f3,f_23105_66502_66543(source2, source3),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,66593,66695);

f_23105_66593_66694(
            diff3, "C: {<F>g__f1|1_0, <F>g__f2|1_1#1, <F>g__f3|1_2#2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,66736,66911);

f_23105_66736_66910(
            // updated:
            diff3, "C.<F>g__f1|1_0(int)", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.4
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,66950,67132);

f_23105_66950_67131(            // updated:
            diff3, "C.<F>g__f2|1_1#1(int)", @"
{
  // Code size        5 (0x5)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4.s   40
  IL_0003:  add
  IL_0004:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,67173,67358);

f_23105_67173_67357(
            // updated:
            diff3, "C.<F>g__f3|1_2#2(int)", @"
{
  // Code size        8 (0x8)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldc.i4     0x400
  IL_0006:  add
  IL_0007:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,62264,67369);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_62367_62564(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 62367, 62564);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_62593_62843(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 62593, 62843);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_62872_63178(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 62872, 63178);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_63207_63513(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63207, 63513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_63590_63658(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63590, 63658);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_63549_63659(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63549, 63659);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_63693_63730(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63693, 63730);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_63764_63801(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63764, 63801);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_63835_63872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63835, 63872);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_63896_63926(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63896, 63926);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_63951_64005(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 63951, 64005);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_64031_64074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64031, 64074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_64098_64141(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64098, 64141);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_64165_64208(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64165, 64208);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_64232_64275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64232, 64275);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_64350_64370(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64350, 64370);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_64310_64393(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64310, 64393);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_64573_64614(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64573, 64614);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_64498_64646(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64498, 64646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_64422_64647(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64422, 64647);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_64674_64693(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64674, 64693);
return return_v;
}


int
f_23105_64749_64834(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64749, 64834);
return 0;
}


int
f_23105_64876_65050(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 64876, 65050);
return 0;
}


int
f_23105_65090_65271(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65090, 65271);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_65346_65366(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 65346, 65366);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_65460_65501(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65460, 65501);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_65385_65533(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65385, 65533);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_65300_65534(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65300, 65534);
return return_v;
}


int
f_23105_65551_65652(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65551, 65652);
return 0;
}


int
f_23105_65694_65868(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65694, 65868);
return 0;
}


int
f_23105_65908_66089(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 65908, 66089);
return 0;
}


int
f_23105_66129_66313(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66129, 66313);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_66388_66408(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 66388, 66408);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_66502_66543(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66502, 66543);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_66427_66575(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66427, 66575);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_66342_66576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66342, 66576);
return return_v;
}


int
f_23105_66593_66694(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66593, 66694);
return 0;
}


int
f_23105_66736_66910(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66736, 66910);
return 0;
}


int
f_23105_66950_67131(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 66950, 67131);
return 0;
}


int
f_23105_67173_67357(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 67173, 67357);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,62264,67369);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,62264,67369);
}
		}

[Fact, WorkItem(2284, "https://github.com/dotnet/roslyn/issues/2284")]
        public void LambdasMultipleGenerations2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,67381,71460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,67527,68010);

var 
source0 = f_23105_67541_68009(@"
using System;
using System.Linq;

class C
{
    private int[] _titles = new int[] { 1, 2 };
    Action A;

    private void F()
    {
        // edit 1
        // var z = from title in _titles
        //         where title > 0 
        //         select title;

        A += <N:0>() =>
        <N:1>{
            Console.WriteLine(1);

            // edit 2
            // Console.WriteLine(2);
        }</N:1></N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,68024,68530);

var 
source1 = f_23105_68038_68529(@"
using System;
using System.Linq;

class C
{
    private int[] _titles = new int[] { 1, 2 };
    Action A;

    private void F()
    {
        // edit 1
        var <N:3>z = from title in _titles 
                     <N:2>where title > 0</N:2>
                     select title</N:3>;

        A += <N:0>() =>
        <N:1>{
            Console.WriteLine(1);

            // edit 2
            // Console.WriteLine(2);
        }</N:1></N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,68544,69047);

var 
source2 = f_23105_68558_69046(@"
using System;
using System.Linq;

class C
{
    private int[] _titles = new int[] { 1, 2 };
    Action A;

    private void F()
    {
        // edit 1
        var <N:3>z = from title in _titles
                     <N:2>where title > 0</N:2> 
                     select title</N:3>;

        A += <N:0>() =>
        <N:1>{
            Console.WriteLine(1);

            // edit 2
            Console.WriteLine(2);
        }</N:1></N:0>;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69063,69193);

var 
compilation0 = f_23105_69082_69192(source0.Tree, options: f_23105_69123_69191(ComSafeDebugDll, MetadataImportOptions.All))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69207,69264);

var 
compilation1 = f_23105_69226_69263(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69278,69335);

var 
compilation2 = f_23105_69297_69334(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69349,69389);

var 
v0 = f_23105_69358_69388(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69403,69468);

var 
md0 = f_23105_69413_69467(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69484,69537);

var 
f0 = f_23105_69493_69536(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69551,69604);

var 
f1 = f_23105_69560_69603(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69618,69671);

var 
f2 = f_23105_69627_69670(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69687,69789);

var 
generation0 = f_23105_69705_69788(md0, f_23105_69745_69765(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,69805,70043);

var 
diff1 = f_23105_69817_70042(compilation1, generation0, f_23105_69893_70041(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_69968_70009(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70059,70089);

var 
md1 = f_23105_70069_70088(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70103,70128);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70201,70336);

f_23105_70201_70335(
            // new lambda "<F>b__2_0#1" has been added:
            diff1, "C: {<>c}", "C.<>c: {<>9__2_0#1, <>9__2_0, <F>b__2_0#1, <F>b__2_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70391,70619);

f_23105_70391_70618(
            // lambda body unchanged:
            diff1, "C.<>c.<F>b__2_0", @"
{
  // Code size        9 (0x9)
  .maxstack  1
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  call       ""void System.Console.WriteLine(int)""
  IL_0007:  nop
  IL_0008:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70635,70882);

var 
diff2 = f_23105_70647_70881(compilation2, f_23105_70693_70713(diff1), f_23105_70732_70880(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_70807_70848(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,70930,71065);

f_23105_70930_71064(
            // no new members:
            diff2, "C: {<>c}", "C.<>c: {<>9__2_0#1, <>9__2_0, <F>b__2_0#1, <F>b__2_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,71118,71449);

f_23105_71118_71448(
            // lambda body updated:
            diff2, "C.<>c.<F>b__2_0", @"
{
  // Code size       16 (0x10)
  .maxstack  1
  IL_0000:  nop
  IL_0001:  ldc.i4.1
  IL_0002:  call       ""void System.Console.WriteLine(int)""
  IL_0007:  nop
  IL_0008:  ldc.i4.2
  IL_0009:  call       ""void System.Console.WriteLine(int)""
  IL_000e:  nop
  IL_000f:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,67381,71460);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_67541_68009(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 67541, 68009);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_68038_68529(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 68038, 68529);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_68558_69046(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 68558, 69046);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_69123_69191(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69123, 69191);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_69082_69192(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69082, 69192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_69226_69263(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69226, 69263);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_69297_69334(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69297, 69334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_69358_69388(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69358, 69388);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_69413_69467(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69413, 69467);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_69493_69536(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69493, 69536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_69560_69603(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69560, 69603);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_69627_69670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69627, 69670);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_69745_69765(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69745, 69765);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_69705_69788(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69705, 69788);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_69968_70009(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69968, 70009);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_69893_70041(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69893, 70041);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_69817_70042(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 69817, 70042);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_70069_70088(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70069, 70088);
return return_v;
}


int
f_23105_70201_70335(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70201, 70335);
return 0;
}


int
f_23105_70391_70618(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70391, 70618);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_70693_70713(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 70693, 70713);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_70807_70848(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70807, 70848);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_70732_70880(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70732, 70880);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_70647_70881(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70647, 70881);
return return_v;
}


int
f_23105_70930_71064(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 70930, 71064);
return 0;
}


int
f_23105_71118_71448(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 71118, 71448);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,67381,71460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,67381,71460);
}
		}

[Fact]
        public void UniqueSynthesizedNames1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,71472,75724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,71550,71815);

var 
source0 = @"
using System;

public class C
{    
    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,71829,72301);

var 
source1 = @"
using System;

public class C
{
    public int F(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,72315,72999);

var 
source2 = @"
using System;

public class C
{
    public int F(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F(byte x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73015,73173);

var 
compilation0 = f_23105_73034_73172(source0, options: f_23105_73084_73152(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73187,73239);

var 
compilation1 = f_23105_73206_73238(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73253,73305);

var 
compilation2 = f_23105_73272_73304(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73321,73405);

var 
f_int1 = f_23105_73334_73364(compilation1, "C.F").Single(m => m.ToString() == "C.F(int)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73419,73505);

var 
f_byte2 = f_23105_73433_73463(compilation2, "C.F").Single(m => m.ToString() == "C.F(byte)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73521,73561);

var 
v0 = f_23105_73530_73560(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73575,73640);

var 
md0 = f_23105_73585_73639(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73656,73689);

var 
reader0 = f_23105_73670_73688(md0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73703,73798);

f_23105_73703_73797(reader0, f_23105_73723_73748(reader0), "<Module>", "C", "<>c__DisplayClass0_0", "<>c");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73812,73938);

f_23105_73812_73937(reader0, f_23105_73832_73859(reader0), "F", ".ctor", ".ctor", "<F>b__1", "<F>b__2", ".cctor", ".ctor", "<F>b__0_0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,73952,74037);

f_23105_73952_74036(reader0, f_23105_73972_73998(reader0), "<>4__this", "a", "<>9", "<>9__0_0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74053,74155);

var 
generation0 = f_23105_74071_74154(md0, f_23105_74111_74131(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74169,74362);

var 
diff1 = f_23105_74181_74361(compilation1, generation0, f_23105_74257_74360(SemanticEdit.Create(SemanticEditKind.Insert,null,f_int1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74378,74419);

var 
reader1 = f_23105_74392_74411(diff1).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74435,74529);

f_23105_74435_74528(new[] { reader0, reader1 }, f_23105_74474_74499(reader1), "<>c__DisplayClass0#1_0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74543,74677);

f_23105_74543_74676(new[] { reader0, reader1 }, f_23105_74582_74609(reader1), ".ctor", "F", ".ctor", "<F>b__1#1", "<F>b__2#1", "<F>b__0#1_0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74691,74792);

f_23105_74691_74791(new[] { reader0, reader1 }, f_23105_74730_74756(reader1), "<>4__this", "a", "<>9__0#1_0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,74808,75037);

f_23105_74808_75036(
            diff1, "C: {<>c__DisplayClass0#1_0#1, <>c}", "C.<>c__DisplayClass0#1_0#1: {<>4__this, a, <F>b__1#1, <F>b__2#1}", "C.<>c: {<>9__0#1_0#1, <F>b__0#1_0#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75053,75256);

var 
diff2 = f_23105_75065_75255(compilation2, f_23105_75111_75131(diff1), f_23105_75150_75254(SemanticEdit.Create(SemanticEditKind.Insert,null,f_byte2)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75272,75313);

var 
reader2 = f_23105_75286_75305(diff2).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75329,75432);

f_23105_75329_75431(new[] { reader0, reader1, reader2 }, f_23105_75377_75402(reader2), "<>c__DisplayClass1#2_0#2");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75446,75589);

f_23105_75446_75588(new[] { reader0, reader1, reader2 }, f_23105_75494_75521(reader2), ".ctor", "F", ".ctor", "<F>b__1#2", "<F>b__2#2", "<F>b__1#2_0#2");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75603,75713);

f_23105_75603_75712(new[] { reader0, reader1, reader2 }, f_23105_75651_75677(reader2), "<>4__this", "a", "<>9__1#2_0#2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,71472,75724);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_73084_73152(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73084, 73152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_73034_73172(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73034, 73172);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_73206_73238(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73206, 73238);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_73272_73304(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73272, 73304);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_73334_73364(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73334, 73364);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_73433_73463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73433, 73463);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_73530_73560(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73530, 73560);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_73585_73639(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73585, 73639);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23105_73670_73688(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 73670, 73688);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_73723_73748(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73723, 73748);
return return_v;
}


int
f_23105_73703_73797(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73703, 73797);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_73832_73859(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73832, 73859);
return return_v;
}


int
f_23105_73812_73937(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73812, 73937);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_73972_73998(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73972, 73998);
return return_v;
}


int
f_23105_73952_74036(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 73952, 74036);
return 0;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_74111_74131(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74111, 74131);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_74071_74154(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74071, 74154);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_74257_74360(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74257, 74360);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_74181_74361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74181, 74361);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_74392_74411(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74392, 74411);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_74474_74499(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74474, 74499);
return return_v;
}


int
f_23105_74435_74528(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74435, 74528);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_74582_74609(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74582, 74609);
return return_v;
}


int
f_23105_74543_74676(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74543, 74676);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_74730_74756(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74730, 74756);
return return_v;
}


int
f_23105_74691_74791(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74691, 74791);
return 0;
}


int
f_23105_74808_75036(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 74808, 75036);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_75111_75131(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 75111, 75131);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_75150_75254(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75150, 75254);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_75065_75255(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75065, 75255);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_75286_75305(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75286, 75305);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_75377_75402(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75377, 75402);
return return_v;
}


int
f_23105_75329_75431(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75329, 75431);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_75494_75521(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75494, 75521);
return return_v;
}


int
f_23105_75446_75588(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75446, 75588);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_75651_75677(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75651, 75677);
return return_v;
}


int
f_23105_75603_75712(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 75603, 75712);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,71472,75724);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,71472,75724);
}
		}

[Fact]
        public void UniqueSynthesizedNames1_Generic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,75736,80127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,75822,76093);

var 
source0 = @"
using System;

public class C
{    
    public int F<T>() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,76107,76591);

var 
source1 = @"
using System;

public class C
{
    public int F<T>(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F<T>() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,76605,77307);

var 
source2 = @"
using System;

public class C
{
    public int F<T>(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F<T>(byte x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F<T>() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F<T>());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77323,77481);

var 
compilation0 = f_23105_77342_77480(source0, options: f_23105_77392_77460(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77495,77547);

var 
compilation1 = f_23105_77514_77546(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77561,77613);

var 
compilation2 = f_23105_77580_77612(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77629,77716);

var 
f_int1 = f_23105_77642_77672(compilation1, "C.F").Single(m => m.ToString() == "C.F<T>(int)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77730,77819);

var 
f_byte2 = f_23105_77744_77774(compilation2, "C.F").Single(m => m.ToString() == "C.F<T>(byte)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77835,77875);

var 
v0 = f_23105_77844_77874(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77889,77954);

var 
md0 = f_23105_77899_77953(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,77970,78003);

var 
reader0 = f_23105_77984_78002(md0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78017,78119);

f_23105_78017_78118(reader0, f_23105_78037_78062(reader0), "<Module>", "C", "<>c__DisplayClass0_0`1", "<>c__0`1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78133,78259);

f_23105_78133_78258(reader0, f_23105_78153_78180(reader0), "F", ".ctor", ".ctor", "<F>b__1", "<F>b__2", ".cctor", ".ctor", "<F>b__0_0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78273,78358);

f_23105_78273_78357(reader0, f_23105_78293_78319(reader0), "<>4__this", "a", "<>9", "<>9__0_0");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78374,78476);

var 
generation0 = f_23105_78392_78475(md0, f_23105_78432_78452(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78490,78683);

var 
diff1 = f_23105_78502_78682(compilation1, generation0, f_23105_78578_78681(SemanticEdit.Create(SemanticEditKind.Insert,null,f_int1)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78699,78740);

var 
reader1 = f_23105_78713_78732(diff1).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78756,78866);

f_23105_78756_78865(new[] { reader0, reader1 }, f_23105_78795_78820(reader1), "<>c__DisplayClass0#1_0#1`1", "<>c__0#1`1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,78880,79024);

f_23105_78880_79023(new[] { reader0, reader1 }, f_23105_78919_78946(reader1), "F", ".ctor", "<F>b__1#1", "<F>b__2#1", ".cctor", ".ctor", "<F>b__0#1_0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79038,79146);

f_23105_79038_79145(new[] { reader0, reader1 }, f_23105_79077_79103(reader1), "<>4__this", "a", "<>9", "<>9__0#1_0#1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79162,79407);

f_23105_79162_79406(
            diff1, "C.<>c__0#1<T>: {<>9__0#1_0#1, <F>b__0#1_0#1}", "C: {<>c__DisplayClass0#1_0#1, <>c__0#1}", "C.<>c__DisplayClass0#1_0#1<T>: {<>4__this, a, <F>b__1#1, <F>b__2#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79423,79626);

var 
diff2 = f_23105_79435_79625(compilation2, f_23105_79481_79501(diff1), f_23105_79520_79624(SemanticEdit.Create(SemanticEditKind.Insert,null,f_byte2)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79642,79683);

var 
reader2 = f_23105_79656_79675(diff2).Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79699,79818);

f_23105_79699_79817(new[] { reader0, reader1, reader2 }, f_23105_79747_79772(reader2), "<>c__DisplayClass1#2_0#2`1", "<>c__1#2`1");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79832,79985);

f_23105_79832_79984(new[] { reader0, reader1, reader2 }, f_23105_79880_79907(reader2), "F", ".ctor", "<F>b__1#2", "<F>b__2#2", ".cctor", ".ctor", "<F>b__1#2_0#2");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,79999,80116);

f_23105_79999_80115(new[] { reader0, reader1, reader2 }, f_23105_80047_80073(reader2), "<>4__this", "a", "<>9", "<>9__1#2_0#2");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,75736,80127);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_77392_77460(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77392, 77460);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_77342_77480(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77342, 77480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_77514_77546(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77514, 77546);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_77580_77612(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77580, 77612);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_77642_77672(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77642, 77672);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_77744_77774(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77744, 77774);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_77844_77874(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77844, 77874);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_77899_77953(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 77899, 77953);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23105_77984_78002(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 77984, 78002);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_78037_78062(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78037, 78062);
return return_v;
}


int
f_23105_78017_78118(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78017, 78118);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_78153_78180(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78153, 78180);
return return_v;
}


int
f_23105_78133_78258(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78133, 78258);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_78293_78319(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78293, 78319);
return return_v;
}


int
f_23105_78273_78357(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( reader, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78273, 78357);
return 0;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_78432_78452(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78432, 78452);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_78392_78475(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78392, 78475);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_78578_78681(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78578, 78681);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_78502_78682(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78502, 78682);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_78713_78732(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78713, 78732);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_78795_78820(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78795, 78820);
return return_v;
}


int
f_23105_78756_78865(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78756, 78865);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_78919_78946(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78919, 78946);
return return_v;
}


int
f_23105_78880_79023(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 78880, 79023);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_79077_79103(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79077, 79103);
return return_v;
}


int
f_23105_79038_79145(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79038, 79145);
return 0;
}


int
f_23105_79162_79406(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79162, 79406);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_79481_79501(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 79481, 79501);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_79520_79624(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79520, 79624);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_79435_79625(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79435, 79625);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_79656_79675(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79656, 79675);
return return_v;
}


System.Reflection.Metadata.StringHandle[]
f_23105_79747_79772(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetTypeDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79747, 79772);
return return_v;
}


int
f_23105_79699_79817(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79699, 79817);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_79880_79907(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetMethodDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79880, 79907);
return return_v;
}


int
f_23105_79832_79984(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79832, 79984);
return 0;
}


System.Reflection.Metadata.StringHandle[]
f_23105_80047_80073(System.Reflection.Metadata.MetadataReader
reader)
{
var return_v = reader.GetFieldDefNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 80047, 80073);
return return_v;
}


int
f_23105_79999_80115(System.Reflection.Metadata.MetadataReader[]
readers,System.Reflection.Metadata.StringHandle[]
handles,params string[]
expectedNames)
{
CheckNames( (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>)readers, (System.Collections.Generic.IEnumerable<System.Reflection.Metadata.StringHandle>)handles, expectedNames);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 79999, 80115);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,75736,80127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,75736,80127);
}
		}

[Fact]
        public void UniqueSynthesizedNames2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,80139,84785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,80217,80324);

var 
source0 = @"
using System;

public class C
{    
    public static void Main() 
    {
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,80338,80669);

var 
source1 = @"
using System;

public class C
{
    public static void Main() 
    {
        new C().F();
    }

    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,80683,81248);

var 
source2 = @"
using System;

public class C
{
    public static void Main() 
    {
        new C().F(1);
        new C().F();
    }

    public int F(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,81264,81784);

var 
source3 = @"
using System;

public class C
{
    public static void Main() 
    {
    }

    public int F(int x) 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }

    public int F() 
    { 
        var a = 1; 
        var f1 = new Func<int>(() => 1);
        var f2 = new Func<int>(() => F());
        var f3 = new Func<int>(() => a);
        return 2;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,81800,81958);

var 
compilation0 = f_23105_81819_81957(source0, options: f_23105_81869_81937(ComSafeDebugDll, MetadataImportOptions.All), assemblyName: "A")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,81972,82024);

var 
compilation1 = f_23105_81991_82023(compilation0, source1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82038,82090);

var 
compilation2 = f_23105_82057_82089(compilation1, source2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82104,82156);

var 
compilation3 = f_23105_82123_82155(compilation2, source3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82172,82231);

var 
main0 = f_23105_82184_82230(compilation0, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82245,82304);

var 
main1 = f_23105_82257_82303(compilation1, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82318,82377);

var 
main2 = f_23105_82330_82376(compilation2, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82391,82450);

var 
main3 = f_23105_82403_82449(compilation3, "C.Main")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82464,82517);

var 
f1 = f_23105_82473_82516(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82531,82615);

var 
f_int2 = f_23105_82544_82574(compilation2, "C.F").Single(m => m.ToString() == "C.F(int)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82631,82671);

var 
v0 = f_23105_82640_82670(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82685,82750);

var 
md0 = f_23105_82695_82749(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82766,82868);

var 
generation0 = f_23105_82784_82867(md0, f_23105_82824_82844(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,82882,83182);

var 
diff1 = f_23105_82894_83181(compilation1, generation0, f_23105_82970_83180(SemanticEdit.Create(SemanticEditKind.Insert,null,f1), SemanticEdit.Create(SemanticEditKind.Update,main0,main1,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,83198,83427);

f_23105_83198_83426(
            diff1, "C.<>c: {<>9__1#1_0#1, <F>b__1#1_0#1}", "C.<>c__DisplayClass1#1_0#1: {<>4__this, a, <F>b__1#1, <F>b__2#1}", "C: {<>c__DisplayClass1#1_0#1, <>c}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,83443,83756);

var 
diff2 = f_23105_83455_83755(compilation2, f_23105_83501_83521(diff1), f_23105_83540_83754(SemanticEdit.Create(SemanticEditKind.Insert,null,f_int2), SemanticEdit.Create(SemanticEditKind.Update,main1,main2,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,83772,84141);

f_23105_83772_84140(
            diff2, "C.<>c__DisplayClass1#2_0#2: {<>4__this, a, <F>b__1#2, <F>b__2#2}", "C: {<>c__DisplayClass1#2_0#2, <>c, <>c__DisplayClass1#1_0#1}", "C.<>c: {<>9__1#2_0#2, <F>b__1#2_0#2, <>9__1#1_0#1, <F>b__1#1_0#1}", "C.<>c__DisplayClass1#1_0#1: {<>4__this, a, <F>b__1#1, <F>b__2#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,84157,84389);

var 
diff3 = f_23105_84169_84388(compilation3, f_23105_84215_84235(diff2), f_23105_84254_84387(SemanticEdit.Create(SemanticEditKind.Update,main2,main3,preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,84405,84774);

f_23105_84405_84773(
            diff3, "C.<>c__DisplayClass1#1_0#1: {<>4__this, a, <F>b__1#1, <F>b__2#1}", "C.<>c: {<>9__1#2_0#2, <F>b__1#2_0#2, <>9__1#1_0#1, <F>b__1#1_0#1}", "C.<>c__DisplayClass1#2_0#2: {<>4__this, a, <F>b__1#2, <F>b__2#2}", "C: {<>c__DisplayClass1#2_0#2, <>c, <>c__DisplayClass1#1_0#1}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,80139,84785);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23105_81869_81937(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 81869, 81937);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_81819_81957(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 81819, 81957);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_81991_82023(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 81991, 82023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_82057_82089(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82057, 82089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_82123_82155(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
newSource)
{
var return_v = compilation.WithSource( newSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82123, 82155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_82184_82230(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82184, 82230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_82257_82303(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82257, 82303);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_82330_82376(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82330, 82376);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_82403_82449(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82403, 82449);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_82473_82516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82473, 82516);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_82544_82574(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82544, 82574);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_82640_82670(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82640, 82670);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_82695_82749(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82695, 82749);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_82824_82844(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82824, 82844);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_82784_82867(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82784, 82867);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_82970_83180(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82970, 83180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_82894_83181(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 82894, 83181);
return return_v;
}


int
f_23105_83198_83426(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 83198, 83426);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_83501_83521(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 83501, 83521);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_83540_83754(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 83540, 83754);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_83455_83755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 83455, 83755);
return return_v;
}


int
f_23105_83772_84140(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 83772, 84140);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_84215_84235(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 84215, 84235);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_84254_84387(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 84254, 84387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_84169_84388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 84169, 84388);
return return_v;
}


int
f_23105_84405_84773(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 84405, 84773);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,80139,84785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,80139,84785);
}
		}

[Fact]
        public void NestedLambdas()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,84797,86856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,84865,85071);

var 
source0 = f_23105_84879_85070(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + G(<N:1>b => 1</N:1>)</N:0>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85085,85291);

var 
source1 = f_23105_85099_85290(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    static object F()
    {
        return G(<N:0>a => a + G(<N:1>b => 2</N:1>)</N:0>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85305,85382);

var 
compilation0 = f_23105_85324_85381(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85396,85453);

var 
compilation1 = f_23105_85415_85452(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85467,85507);

var 
v0 = f_23105_85476_85506(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85521,85586);

var 
md0 = f_23105_85531_85585(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85602,85655);

var 
f0 = f_23105_85611_85654(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85669,85722);

var 
f1 = f_23105_85678_85721(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85738,85840);

var 
generation0 = f_23105_85756_85839(md0, f_23105_85796_85816(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,85856,86094);

var 
diff1 = f_23105_85868_86093(compilation1, generation0, f_23105_85944_86092(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_86019_86060(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,86110,86140);

var 
md1 = f_23105_86120_86139(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,86154,86179);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,86485,86845);

f_23105_86485_86844(reader1, f_23105_86534_86600(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_86619_86681(2, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_86700_86762(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_86781_86843(7, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,84797,86856);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_84879_85070(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 84879, 85070);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_85099_85290(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85099, 85290);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_85324_85381(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85324, 85381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_85415_85452(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85415, 85452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_85476_85506(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85476, 85506);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_85531_85585(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85531, 85585);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_85611_85654(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85611, 85654);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_85678_85721(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85678, 85721);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_85796_85816(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85796, 85816);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_85756_85839(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85756, 85839);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_86019_86060(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86019, 86060);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_85944_86092(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85944, 86092);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_85868_86093(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 85868, 86093);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_86120_86139(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86120, 86139);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_86534_86600(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86534, 86600);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_86619_86681(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86619, 86681);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_86700_86762(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86700, 86762);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_86781_86843(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86781, 86843);
return return_v;
}


int
f_23105_86485_86844(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86485, 86844);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,84797,86856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,84797,86856);
}
		}

[Fact]
        public void LambdasInInitializers1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,86868,90005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,86945,87271);

var 
source0 = f_23105_86959_87270(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    public int A = G(<N:0>a => a + 1</N:0>);

    public C() : this(G(<N:1>a => a + 2</N:1>))
    {
        G(<N:2>a => a + 3</N:2>);
    }

    public C(int x)
    {
        G(<N:3>a => a + 4</N:3>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87285,87611);

var 
source1 = f_23105_87299_87610(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    public int A = G(<N:0>a => a - 1</N:0>);

    public C() : this(G(<N:1>a => a - 2</N:1>))
    {
        G(<N:2>a => a - 3</N:2>);
    }

    public C(int x)
    {
        G(<N:3>a => a - 4</N:3>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87625,87702);

var 
compilation0 = f_23105_87644_87701(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87716,87773);

var 
compilation1 = f_23105_87735_87772(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87787,87827);

var 
v0 = f_23105_87796_87826(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87841,87906);

var 
md0 = f_23105_87851_87905(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,87922,88022);

var 
ctor00 = f_23105_87935_87969(compilation0, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor()")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88036,88150);

var 
ctor10 = f_23105_88049_88083(compilation0, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor(System.Int32 x)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88164,88264);

var 
ctor01 = f_23105_88177_88211(compilation1, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor()")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88278,88392);

var 
ctor11 = f_23105_88291_88325(compilation1, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor(System.Int32 x)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88408,88510);

var 
generation0 = f_23105_88426_88509(md0, f_23105_88466_88486(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88526,88950);

var 
diff1 = f_23105_88538_88949(compilation1, generation0, f_23105_88614_88948(SemanticEdit.Create(SemanticEditKind.Update,ctor00,ctor01,f_23105_88719_88760(source0, source1),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,ctor10,ctor11,f_23105_88875_88916(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,88966,88996);

var 
md1 = f_23105_88976_88995(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89010,89035);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89051,89240);

f_23105_89051_89239(
            diff1, "C: {<>c}", "C.<>c: {<>9__2_0, <>9__2_1, <>9__3_0, <>9__3_1, <.ctor>b__2_0, <.ctor>b__2_1, <.ctor>b__3_0, <.ctor>b__3_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89256,89429);

f_23105_89256_89428(
            diff1, "C.<>c.<.ctor>b__2_0", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.2
  IL_0002:  sub
  IL_0003:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89445,89618);

f_23105_89445_89617(
            diff1, "C.<>c.<.ctor>b__2_1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.3
  IL_0002:  sub
  IL_0003:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89634,89807);

f_23105_89634_89806(
            diff1, "C.<>c.<.ctor>b__3_0", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.4
  IL_0002:  sub
  IL_0003:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,89821,89994);

f_23105_89821_89993(            diff1, "C.<>c.<.ctor>b__3_1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.1
  IL_0002:  sub
  IL_0003:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,86868,90005);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_86959_87270(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 86959, 87270);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_87299_87610(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87299, 87610);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_87644_87701(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87644, 87701);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_87735_87772(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87735, 87772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_87796_87826(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87796, 87826);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_87851_87905(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87851, 87905);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_87935_87969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 87935, 87969);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_88049_88083(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88049, 88083);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_88177_88211(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88177, 88211);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_88291_88325(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88291, 88325);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_88466_88486(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88466, 88486);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_88426_88509(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88426, 88509);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_88719_88760(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88719, 88760);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_88875_88916(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88875, 88916);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_88614_88948(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88614, 88948);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_88538_88949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88538, 88949);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_88976_88995(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 88976, 88995);
return return_v;
}


int
f_23105_89051_89239(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 89051, 89239);
return 0;
}


int
f_23105_89256_89428(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 89256, 89428);
return 0;
}


int
f_23105_89445_89617(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 89445, 89617);
return 0;
}


int
f_23105_89634_89806(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 89634, 89806);
return 0;
}


int
f_23105_89821_89993(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 89821, 89993);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,86868,90005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,86868,90005);
}
		}

[Fact]
        public void LambdasInInitializers2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,90017,94150);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,90094,90544);

var 
source0 = f_23105_90108_90543(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    public int A = G(<N:0>a => { int <N:4>v1 = 1</N:4>; return 1; }</N:0>);

    public C() : this(G(<N:1>a => { int <N:5>v2 = 1</N:5>; return 2; }</N:1>))
    {
        G(<N:2>a => { int <N:6>v3 = 1</N:6>; return 3; }</N:2>);
    }

    public C(int x)
    {
        G(<N:3>a => { int <N:7>v4 = 1</N:7>; return 4; }</N:3>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,90558,91012);

var 
source1 = f_23105_90572_91011(@"
using System;

class C
{
    static int G(Func<int, int> f) => 1;

    public int A = G(<N:0>a => { int <N:4>v1 = 10</N:4>; return 1; }</N:0>);

    public C() : this(G(<N:1>a => { int <N:5>v2 = 10</N:5>; return 2; }</N:1>))
    {
        G(<N:2>a => { int <N:6>v3 = 10</N:6>; return 3; }</N:2>);
    }

    public C(int x)
    {
        G(<N:3>a => { int <N:7>v4 = 10</N:7>; return 4; }</N:3>);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91026,91103);

var 
compilation0 = f_23105_91045_91102(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91117,91174);

var 
compilation1 = f_23105_91136_91173(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91188,91228);

var 
v0 = f_23105_91197_91227(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91242,91307);

var 
md0 = f_23105_91252_91306(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91323,91423);

var 
ctor00 = f_23105_91336_91370(compilation0, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor()")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91437,91551);

var 
ctor10 = f_23105_91450_91484(compilation0, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor(System.Int32 x)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91565,91665);

var 
ctor01 = f_23105_91578_91612(compilation1, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor()")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91679,91793);

var 
ctor11 = f_23105_91692_91726(compilation1, "C..ctor").Single(m => m.ToTestDisplayString() == "C..ctor(System.Int32 x)")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91809,91911);

var 
generation0 = f_23105_91827_91910(md0, f_23105_91867_91887(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,91927,92351);

var 
diff1 = f_23105_91939_92350(compilation1, generation0, f_23105_92015_92349(SemanticEdit.Create(SemanticEditKind.Update,ctor00,ctor01,f_23105_92120_92161(source0, source1),preserveLocalVariables: true), SemanticEdit.Create(SemanticEditKind.Update,ctor10,ctor11,f_23105_92276_92317(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,92367,92397);

var 
md1 = f_23105_92377_92396(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,92411,92436);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,92452,92641);

f_23105_92452_92640(
            diff1, "C: {<>c}", "C.<>c: {<>9__2_0, <>9__2_1, <>9__3_0, <>9__3_1, <.ctor>b__2_0, <.ctor>b__2_1, <.ctor>b__3_0, <.ctor>b__3_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,92657,93016);

f_23105_92657_93015(
            diff1, "C.<>c.<.ctor>b__2_0", @"
{
  // Code size       10 (0xa)
  .maxstack  1
  .locals init (int V_0, //v2
                [int] V_1,
                int V_2)
  IL_0000:  nop
  IL_0001:  ldc.i4.s   10
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.2
  IL_0005:  stloc.2
  IL_0006:  br.s       IL_0008
  IL_0008:  ldloc.2
  IL_0009:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,93032,93391);

f_23105_93032_93390(
            diff1, "C.<>c.<.ctor>b__2_1", @"
{
  // Code size       10 (0xa)
  .maxstack  1
  .locals init (int V_0, //v3
                [int] V_1,
                int V_2)
  IL_0000:  nop
  IL_0001:  ldc.i4.s   10
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.3
  IL_0005:  stloc.2
  IL_0006:  br.s       IL_0008
  IL_0008:  ldloc.2
  IL_0009:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,93407,93766);

f_23105_93407_93765(
            diff1, "C.<>c.<.ctor>b__3_0", @"
{
  // Code size       10 (0xa)
  .maxstack  1
  .locals init (int V_0, //v4
                [int] V_1,
                int V_2)
  IL_0000:  nop
  IL_0001:  ldc.i4.s   10
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.4
  IL_0005:  stloc.2
  IL_0006:  br.s       IL_0008
  IL_0008:  ldloc.2
  IL_0009:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,93780,94139);

f_23105_93780_94138(            diff1, "C.<>c.<.ctor>b__3_1", @"
{
  // Code size       10 (0xa)
  .maxstack  1
  .locals init (int V_0, //v1
                [int] V_1,
                int V_2)
  IL_0000:  nop
  IL_0001:  ldc.i4.s   10
  IL_0003:  stloc.0
  IL_0004:  ldc.i4.1
  IL_0005:  stloc.2
  IL_0006:  br.s       IL_0008
  IL_0008:  ldloc.2
  IL_0009:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,90017,94150);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_90108_90543(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 90108, 90543);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_90572_91011(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 90572, 91011);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_91045_91102(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91045, 91102);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_91136_91173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91136, 91173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_91197_91227(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91197, 91227);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_91252_91306(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91252, 91306);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_91336_91370(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91336, 91370);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_91450_91484(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91450, 91484);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_91578_91612(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91578, 91612);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23105_91692_91726(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMembers( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91692, 91726);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_91867_91887(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91867, 91887);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_91827_91910(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91827, 91910);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_92120_92161(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92120, 92161);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_92276_92317(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92276, 92317);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_92015_92349(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92015, 92349);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_91939_92350(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 91939, 92350);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_92377_92396(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92377, 92396);
return return_v;
}


int
f_23105_92452_92640(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92452, 92640);
return 0;
}


int
f_23105_92657_93015(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 92657, 93015);
return 0;
}


int
f_23105_93032_93390(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 93032, 93390);
return 0;
}


int
f_23105_93407_93765(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 93407, 93765);
return 0;
}


int
f_23105_93780_94138(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 93780, 94138);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,90017,94150);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,90017,94150);
}
		}

[Fact]
        public void UpdateParameterlessConstructorInPresenceOfFieldInitializersWithLambdas()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,94162,97658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94287,94434);

var 
source0 = f_23105_94301_94433(@"
using System;

class C
{
    static int F(Func<int, int> x) => 1;

    int A = F(<N:0>a => a + 1</N:0>);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94448,94754);

var 
source1 = f_23105_94462_94753(@"
using System;

class C
{
    static int F(Func<int, int> x) => 1;

    int A = F(<N:0>a => a + 1</N:0>);
    int B = F(b => b + 1);                    // new field

    public C()                                // new ctor
    {
        F(c => c + 1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94768,94845);

var 
compilation0 = f_23105_94787_94844(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94859,94916);

var 
compilation1 = f_23105_94878_94915(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94930,94970);

var 
v0 = f_23105_94939_94969(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,94984,95049);

var 
md0 = f_23105_94994_95048(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95065,95117);

var 
b1 = f_23105_95074_95116(compilation1, "C.B")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95131,95191);

var 
ctor0 = f_23105_95143_95190(compilation0, "C..ctor")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95205,95265);

var 
ctor1 = f_23105_95217_95264(compilation1, "C..ctor")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95281,95383);

var 
generation0 = f_23105_95299_95382(md0, f_23105_95339_95359(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95399,95742);

var 
diff1 = f_23105_95411_95741(compilation1, generation0, f_23105_95487_95740(SemanticEdit.Create(SemanticEditKind.Insert,null,b1), SemanticEdit.Create(SemanticEditKind.Update,ctor0,ctor1,f_23105_95667_95708(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95758,95930);

f_23105_95758_95929(
            diff1, "C: {<>c}", "C.<>c: {<>9__2_0#1, <>9__2_0, <>9__2_2#1, <.ctor>b__2_0#1, <.ctor>b__2_0, <.ctor>b__2_2#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,95946,97647);

f_23105_95946_97646(
            diff1, "C..ctor", @"
{
  // Code size      130 (0x82)
  .maxstack  3
  IL_0000:  ldarg.0
  IL_0001:  ldsfld     ""System.Func<int, int> C.<>c.<>9__2_0""
  IL_0006:  dup
  IL_0007:  brtrue.s   IL_0020
  IL_0009:  pop
  IL_000a:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_000f:  ldftn      ""int C.<>c.<.ctor>b__2_0(int)""
  IL_0015:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_001a:  dup
  IL_001b:  stsfld     ""System.Func<int, int> C.<>c.<>9__2_0""
  IL_0020:  call       ""int C.F(System.Func<int, int>)""
  IL_0025:  stfld      ""int C.A""
  IL_002a:  ldarg.0
  IL_002b:  ldsfld     ""System.Func<int, int> C.<>c.<>9__2_2#1""
  IL_0030:  dup
  IL_0031:  brtrue.s   IL_004a
  IL_0033:  pop
  IL_0034:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0039:  ldftn      ""int C.<>c.<.ctor>b__2_2#1(int)""
  IL_003f:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0044:  dup
  IL_0045:  stsfld     ""System.Func<int, int> C.<>c.<>9__2_2#1""
  IL_004a:  call       ""int C.F(System.Func<int, int>)""
  IL_004f:  stfld      ""int C.B""
  IL_0054:  ldarg.0
  IL_0055:  call       ""object..ctor()""
  IL_005a:  nop
  IL_005b:  nop
  IL_005c:  ldsfld     ""System.Func<int, int> C.<>c.<>9__2_0#1""
  IL_0061:  dup
  IL_0062:  brtrue.s   IL_007b
  IL_0064:  pop
  IL_0065:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_006a:  ldftn      ""int C.<>c.<.ctor>b__2_0#1(int)""
  IL_0070:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0075:  dup
  IL_0076:  stsfld     ""System.Func<int, int> C.<>c.<>9__2_0#1""
  IL_007b:  call       ""int C.F(System.Func<int, int>)""
  IL_0080:  pop
  IL_0081:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,94162,97658);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_94301_94433(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94301, 94433);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_94462_94753(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94462, 94753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_94787_94844(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94787, 94844);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_94878_94915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94878, 94915);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_94939_94969(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94939, 94969);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_94994_95048(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 94994, 95048);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_23105_95074_95116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95074, 95116);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_95143_95190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95143, 95190);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_95217_95264(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95217, 95264);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_95339_95359(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95339, 95359);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_95299_95382(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95299, 95382);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_95667_95708(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95667, 95708);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_95487_95740(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95487, 95740);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_95411_95741(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95411, 95741);
return return_v;
}


int
f_23105_95758_95929(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95758, 95929);
return 0;
}


int
f_23105_95946_97646(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 95946, 97646);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,94162,97658);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,94162,97658);
}
		}

[Fact(Skip = "2504"), WorkItem(2504, "https://github.com/dotnet/roslyn/issues/2504")]
        public void InsertConstructorInPresenceOfFieldInitializersWithLambdas()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,97670,99526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,97861,98008);

var 
source0 = f_23105_97875_98007(@"
using System;

class C
{
    static int F(Func<int, int> x) => 1;

    int A = F(<N:0>a => a + 1</N:0>);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98022,98328);

var 
source1 = f_23105_98036_98327(@"
using System;

class C
{
    static int F(Func<int, int> x) => 1;

    int A = F(<N:0>a => a + 1</N:0>);
    int B = F(b => b + 1);                    // new field

    public C(int x)                           // new ctor
    {
        F(c => c + 1);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98342,98419);

var 
compilation0 = f_23105_98361_98418(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98433,98490);

var 
compilation1 = f_23105_98452_98489(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98504,98544);

var 
v0 = f_23105_98513_98543(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98558,98623);

var 
md0 = f_23105_98568_98622(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98639,98691);

var 
b1 = f_23105_98648_98690(compilation1, "C.B")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98705,98765);

var 
ctor1 = f_23105_98717_98764(compilation1, "C..ctor")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98781,98883);

var 
generation0 = f_23105_98799_98882(md0, f_23105_98839_98859(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,98899,99241);

var 
diff1 = f_23105_98911_99240(compilation1, generation0, f_23105_98987_99239(SemanticEdit.Create(SemanticEditKind.Insert,null,b1), SemanticEdit.Create(SemanticEditKind.Insert,null,ctor1,f_23105_99166_99207(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,99257,99287);

var 
md1 = f_23105_99267_99286(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,99301,99326);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,99342,99515);

f_23105_99342_99514(
            diff1, "C: {<> c}", "C.<>c: {<>9__2_0#1, <>9__2_0, <>9__2_2#1, <.ctor>b__2_0#1, <.ctor>b__2_0, <.ctor>b__2_2#1}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,97670,99526);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_97875_98007(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 97875, 98007);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_98036_98327(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98036, 98327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_98361_98418(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98361, 98418);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_98452_98489(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98452, 98489);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_98513_98543(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98513, 98543);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_98568_98622(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98568, 98622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
f_23105_98648_98690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98648, 98690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_98717_98764(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98717, 98764);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_98839_98859(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98839, 98859);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_98799_98882(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98799, 98882);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_99166_99207(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 99166, 99207);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_98987_99239(Microsoft.CodeAnalysis.Emit.SemanticEdit
item1,Microsoft.CodeAnalysis.Emit.SemanticEdit
item2)
{
var return_v = ImmutableArray.Create( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98987, 99239);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_98911_99240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 98911, 99240);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_99267_99286(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 99267, 99286);
return return_v;
}


int
f_23105_99342_99514(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 99342, 99514);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,97670,99526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,97670,99526);
}
		}

[Fact]
        public void Queries_Select_Reduced1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,99538,103933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,99616,99939);

var 
source0 = f_23105_99630_99938(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>where a > 0</N:1>
                          <N:2>select a</N:2></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,99953,100280);

var 
source1 = f_23105_99967_100279(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>where a > 0</N:1>
                          <N:2>select a + 1</N:2></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100294,100371);

var 
compilation0 = f_23105_100313_100370(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100385,100442);

var 
compilation1 = f_23105_100404_100441(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100456,100496);

var 
v0 = f_23105_100465_100495(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100510,100575);

var 
md0 = f_23105_100520_100574(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100591,100644);

var 
f0 = f_23105_100600_100643(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100658,100711);

var 
f1 = f_23105_100667_100710(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100727,100829);

var 
generation0 = f_23105_100745_100828(md0, f_23105_100785_100805(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,100845,101105);

var 
diff1 = f_23105_100857_101104(compilation1, generation0, f_23105_100933_101103(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_101030_101071(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,101121,101151);

var 
md1 = f_23105_101131_101150(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,101165,101190);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,101256,101391);

f_23105_101256_101390(
            // new lambda for Select(a => a + 1)
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1#1, <F>b__0_0, <F>b__0_1#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,101407,101580);

f_23105_101407_101579(
            diff1, "C.<>c.<F>b__0_1#1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.1
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,101621,102462);

f_23105_101621_102461(            // old query:
            v0, "C.F", @"
{
  // Code size       45 (0x2d)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<int> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""bool C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, bool>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Where<int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, bool>)""
  IL_002b:  stloc.0
  IL_002c:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,102503,103922);

f_23105_102503_103921(            // new query:
            diff1, "C.F", @"
{
  // Code size       81 (0x51)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<int> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""bool C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, bool>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Where<int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, bool>)""
  IL_002b:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_1#1""
  IL_0030:  dup
  IL_0031:  brtrue.s   IL_004a
  IL_0033:  pop
  IL_0034:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0039:  ldftn      ""int C.<>c.<F>b__0_1#1(int)""
  IL_003f:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0044:  dup
  IL_0045:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_1#1""
  IL_004a:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Select<int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>)""
  IL_004f:  stloc.0
  IL_0050:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,99538,103933);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_99630_99938(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 99630, 99938);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_99967_100279(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 99967, 100279);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_100313_100370(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100313, 100370);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_100404_100441(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100404, 100441);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_100465_100495(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100465, 100495);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_100520_100574(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100520, 100574);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_100600_100643(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100600, 100643);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_100667_100710(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100667, 100710);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_100785_100805(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100785, 100805);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_100745_100828(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100745, 100828);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_101030_101071(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 101030, 101071);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_100933_101103(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100933, 101103);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_100857_101104(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 100857, 101104);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_101131_101150(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 101131, 101150);
return return_v;
}


int
f_23105_101256_101390(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 101256, 101390);
return 0;
}


int
f_23105_101407_101579(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 101407, 101579);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_101621_102461(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 101621, 102461);
return return_v;
}


int
f_23105_102503_103921(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 102503, 103921);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,99538,103933);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,99538,103933);
}
		}

[Fact]
        public void Queries_Select_Reduced2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,103945,108126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104023,104350);

var 
source0 = f_23105_104037_104349(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>where a > 0</N:1>
                          <N:2>select a + 1</N:2></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104364,104687);

var 
source1 = f_23105_104378_104686(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>where a > 0</N:1>
                          <N:2>select a</N:2></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104701,104778);

var 
compilation0 = f_23105_104720_104777(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104792,104849);

var 
compilation1 = f_23105_104811_104848(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104863,104903);

var 
v0 = f_23105_104872_104902(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104917,104982);

var 
md0 = f_23105_104927_104981(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,104998,105051);

var 
f0 = f_23105_105007_105050(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105065,105118);

var 
f1 = f_23105_105074_105117(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105134,105236);

var 
generation0 = f_23105_105152_105235(md0, f_23105_105192_105212(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105252,105512);

var 
diff1 = f_23105_105264_105511(compilation1, generation0, f_23105_105340_105510(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_105437_105478(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105528,105558);

var 
md1 = f_23105_105538_105557(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105572,105597);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105667,105777);

f_23105_105667_105776(
            // lambda for Select(a => a + 1) is gone
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <F>b__0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,105820,107230);

f_23105_105820_107229(
            // old query:
            v0, "C.F", @"
{
  // Code size       81 (0x51)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<int> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""bool C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, bool>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Where<int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, bool>)""
  IL_002b:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_1""
  IL_0030:  dup
  IL_0031:  brtrue.s   IL_004a
  IL_0033:  pop
  IL_0034:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0039:  ldftn      ""int C.<>c.<F>b__0_1(int)""
  IL_003f:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0044:  dup
  IL_0045:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_1""
  IL_004a:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Select<int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>)""
  IL_004f:  stloc.0
  IL_0050:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,107271,108115);

f_23105_107271_108114(            // new query:
            diff1, "C.F", @"
{
  // Code size       45 (0x2d)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<int> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""bool C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, bool>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, bool> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<int> System.Linq.Enumerable.Where<int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, bool>)""
  IL_002b:  stloc.0
  IL_002c:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,103945,108126);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_104037_104349(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104037, 104349);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_104378_104686(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104378, 104686);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_104720_104777(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104720, 104777);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_104811_104848(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104811, 104848);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_104872_104902(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104872, 104902);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_104927_104981(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 104927, 104981);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_105007_105050(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105007, 105050);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_105074_105117(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105074, 105117);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_105192_105212(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105192, 105212);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_105152_105235(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105152, 105235);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_105437_105478(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105437, 105478);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_105340_105510(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105340, 105510);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_105264_105511(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105264, 105511);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_105538_105557(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105538, 105557);
return return_v;
}


int
f_23105_105667_105776(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105667, 105776);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_105820_107229(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 105820, 107229);
return return_v;
}


int
f_23105_107271_108114(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 107271, 108114);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,103945,108126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,103945,108126);
}
		}

[Fact]
        public void Queries_GroupBy_Reduced1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,108138,112412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,108217,108494);

var 
source0 = f_23105_108231_108493(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>group a by a</N:1></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,108508,108789);

var 
source1 = f_23105_108522_108788(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>group a + 1 by a</N:1></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,108803,108880);

var 
compilation0 = f_23105_108822_108879(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,108894,108951);

var 
compilation1 = f_23105_108913_108950(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,108965,109005);

var 
v0 = f_23105_108974_109004(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109019,109084);

var 
md0 = f_23105_109029_109083(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109100,109153);

var 
f0 = f_23105_109109_109152(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109167,109220);

var 
f1 = f_23105_109176_109219(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109236,109338);

var 
generation0 = f_23105_109254_109337(md0, f_23105_109294_109314(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109354,109614);

var 
diff1 = f_23105_109366_109613(compilation1, generation0, f_23105_109442_109612(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_109539_109580(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109630,109660);

var 
md1 = f_23105_109640_109659(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109674,109699);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109771,109906);

f_23105_109771_109905(
            // new lambda for GroupBy(..., a => a + 1)
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1#1, <F>b__0_0, <F>b__0_1#1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,109922,110095);

f_23105_109922_110094(
            diff1, "C.<>c.<F>b__0_1#1", @"
{
  // Code size        4 (0x4)
  .maxstack  2
  IL_0000:  ldarg.1
  IL_0001:  ldc.i4.1
  IL_0002:  add
  IL_0003:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,110136,111035);

f_23105_110136_111034(            // old query:
            v0, "C.F", @"
{
  // Code size       45 (0x2d)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""int C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> System.Linq.Enumerable.GroupBy<int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>)""
  IL_002b:  stloc.0
  IL_002c:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,111076,112401);

f_23105_111076_112400(            // new query:
            diff1, "C.F", @"
{
  // Code size       76 (0x4c)
  .maxstack  4
  .locals init (System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""int C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_0026:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_1#1""
  IL_002b:  dup
  IL_002c:  brtrue.s   IL_0045
  IL_002e:  pop
  IL_002f:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0034:  ldftn      ""int C.<>c.<F>b__0_1#1(int)""
  IL_003a:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_003f:  dup
  IL_0040:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_1#1""
  IL_0045:  call       ""System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> System.Linq.Enumerable.GroupBy<int, int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>, System.Func<int, int>)""
  IL_004a:  stloc.0
  IL_004b:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,108138,112412);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_108231_108493(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 108231, 108493);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_108522_108788(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 108522, 108788);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_108822_108879(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 108822, 108879);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_108913_108950(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 108913, 108950);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_108974_109004(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 108974, 109004);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_109029_109083(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109029, 109083);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_109109_109152(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109109, 109152);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_109176_109219(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109176, 109219);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_109294_109314(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109294, 109314);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_109254_109337(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109254, 109337);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_109539_109580(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109539, 109580);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_109442_109612(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109442, 109612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_109366_109613(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109366, 109613);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_109640_109659(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109640, 109659);
return return_v;
}


int
f_23105_109771_109905(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109771, 109905);
return 0;
}


int
f_23105_109922_110094(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 109922, 110094);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_110136_111034(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 110136, 111034);
return return_v;
}


int
f_23105_111076_112400(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 111076, 112400);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,108138,112412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,108138,112412);
}
		}

[Fact]
        public void Queries_GroupBy_Reduced2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,112424,116484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,112503,112784);

var 
source0 = f_23105_112517_112783(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>group a + 1 by a</N:1></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,112798,113075);

var 
source1 = f_23105_112812_113074(@"
using System;
using System.Linq;
using System.Collections.Generic;

class C
{
    void F()
    {
        var <N:0>result = from a in array
                          <N:1>group a by a</N:1></N:0>;
    }

    int[] array = null;
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113089,113166);

var 
compilation0 = f_23105_113108_113165(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113180,113237);

var 
compilation1 = f_23105_113199_113236(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113251,113291);

var 
v0 = f_23105_113260_113290(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113305,113370);

var 
md0 = f_23105_113315_113369(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113386,113439);

var 
f0 = f_23105_113395_113438(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113453,113506);

var 
f1 = f_23105_113462_113505(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113522,113624);

var 
generation0 = f_23105_113540_113623(md0, f_23105_113580_113600(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113640,113900);

var 
diff1 = f_23105_113652_113899(compilation1, generation0, f_23105_113728_113898(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_113825_113866(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113916,113946);

var 
md1 = f_23105_113926_113945(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,113960,113985);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,114061,114171);

f_23105_114061_114170(
            // lambda for GroupBy(..., a => a + 1) is gone
            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <F>b__0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,114214,115530);

f_23105_114214_115529(
            // old query:
            v0, "C.F", @"
{
  // Code size       76 (0x4c)
  .maxstack  4
  .locals init (System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""int C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_0026:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_1""
  IL_002b:  dup
  IL_002c:  brtrue.s   IL_0045
  IL_002e:  pop
  IL_002f:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0034:  ldftn      ""int C.<>c.<F>b__0_1(int)""
  IL_003a:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_003f:  dup
  IL_0040:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_1""
  IL_0045:  call       ""System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> System.Linq.Enumerable.GroupBy<int, int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>, System.Func<int, int>)""
  IL_004a:  stloc.0
  IL_004b:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,115571,116473);

f_23105_115571_116472(            // new query:
            diff1, "C.F", @"
{
  // Code size       45 (0x2d)
  .maxstack  3
  .locals init (System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> V_0) //result
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      ""int[] C.array""
  IL_0007:  ldsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_000c:  dup
  IL_000d:  brtrue.s   IL_0026
  IL_000f:  pop
  IL_0010:  ldsfld     ""C.<>c C.<>c.<>9""
  IL_0015:  ldftn      ""int C.<>c.<F>b__0_0(int)""
  IL_001b:  newobj     ""System.Func<int, int>..ctor(object, System.IntPtr)""
  IL_0020:  dup
  IL_0021:  stsfld     ""System.Func<int, int> C.<>c.<>9__0_0""
  IL_0026:  call       ""System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, int>> System.Linq.Enumerable.GroupBy<int, int>(System.Collections.Generic.IEnumerable<int>, System.Func<int, int>)""
  IL_002b:  stloc.0
  IL_002c:  ret
}
");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,112424,116484);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_112517_112783(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 112517, 112783);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_112812_113074(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 112812, 113074);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_113108_113165(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113108, 113165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_113199_113236(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113199, 113236);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_113260_113290(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113260, 113290);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_113315_113369(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113315, 113369);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_113395_113438(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113395, 113438);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_113462_113505(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113462, 113505);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_113580_113600(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113580, 113600);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_113540_113623(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113540, 113623);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_113825_113866(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113825, 113866);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_113728_113898(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113728, 113898);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_113652_113899(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113652, 113899);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_113926_113945(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 113926, 113945);
return return_v;
}


int
f_23105_114061_114170(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 114061, 114170);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_114214_115529(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 114214, 115529);
return return_v;
}


int
f_23105_115571_116472(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 115571, 116472);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,112424,116484);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,112424,116484);
}
		}

[Fact, WorkItem(1170899, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1170899")]
        public void CapturedAnonymousTypes1()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,116496,121485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,116658,116909);

var 
source0 = f_23105_116672_116908(@"
using System;

class C
{
    static void F()
    <N:0>{
        var <N:1>x = new { A = 1 }</N:1>;
        var <N:2>y = new Func<int>(<N:3>() => x.A</N:3>)</N:2>;
        Console.WriteLine(1);
    }</N:0>
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,116923,117174);

var 
source1 = f_23105_116937_117173(@"
using System;

class C
{
    static void F()
    <N:0>{
        var <N:1>x = new { A = 1 }</N:1>;
        var <N:2>y = new Func<int>(<N:3>() => x.A</N:3>)</N:2>;
        Console.WriteLine(2);
    }</N:0>
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117188,117439);

var 
source2 = f_23105_117202_117438(@"
using System;

class C
{
    static void F()
    <N:0>{
        var <N:1>x = new { A = 1 }</N:1>;
        var <N:2>y = new Func<int>(<N:3>() => x.A</N:3>)</N:2>;
        Console.WriteLine(3);
    }</N:0>
}
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117453,117530);

var 
compilation0 = f_23105_117472_117529(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117544,117601);

var 
compilation1 = f_23105_117563_117600(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117615,117672);

var 
compilation2 = f_23105_117634_117671(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117688,117728);

var 
v0 = f_23105_117697_117727(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117742,117807);

var 
md0 = f_23105_117752_117806(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117823,117876);

var 
f0 = f_23105_117832_117875(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117890,117943);

var 
f1 = f_23105_117899_117942(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,117957,118010);

var 
f2 = f_23105_117966_118009(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,118026,118128);

var 
generation0 = f_23105_118044_118127(md0, f_23105_118084_118104(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,118144,118909);

f_23105_118144_118908(
            v0, "C.F", @"
{
  // Code size       40 (0x28)
  .maxstack  2
  .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                System.Func<int> V_1) //y
  IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
  IL_0005:  stloc.0
  IL_0006:  nop
  IL_0007:  ldloc.0
  IL_0008:  ldc.i4.1
  IL_0009:  newobj     ""<>f__AnonymousType0<int>..ctor(int)""
  IL_000e:  stfld      ""<anonymous type: int A> C.<>c__DisplayClass0_0.x""
  IL_0013:  ldloc.0
  IL_0014:  ldftn      ""int C.<>c__DisplayClass0_0.<F>b__0()""
  IL_001a:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_001f:  stloc.1
  IL_0020:  ldc.i4.1
  IL_0021:  call       ""void System.Console.WriteLine(int)""
  IL_0026:  nop
  IL_0027:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,118925,119167);

var 
diff1 = f_23105_118937_119166(compilation1, generation0, f_23105_118995_119165(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_119092_119133(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,119183,119403);

f_23105_119183_119402(
            diff1, "C: {<>c__DisplayClass0_0}", "C.<>c__DisplayClass0_0: {x, <F>b__0}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,119419,120187);

f_23105_119419_120186(
            diff1, "C.F", @"
{
  // Code size       40 (0x28)
  .maxstack  2
  .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                System.Func<int> V_1) //y
  IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
  IL_0005:  stloc.0
  IL_0006:  nop
  IL_0007:  ldloc.0
  IL_0008:  ldc.i4.1
  IL_0009:  newobj     ""<>f__AnonymousType0<int>..ctor(int)""
  IL_000e:  stfld      ""<anonymous type: int A> C.<>c__DisplayClass0_0.x""
  IL_0013:  ldloc.0
  IL_0014:  ldftn      ""int C.<>c__DisplayClass0_0.<F>b__0()""
  IL_001a:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_001f:  stloc.1
  IL_0020:  ldc.i4.2
  IL_0021:  call       ""void System.Console.WriteLine(int)""
  IL_0026:  nop
  IL_0027:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,120203,120454);

var 
diff2 = f_23105_120215_120453(compilation2, f_23105_120243_120263(diff1), f_23105_120282_120452(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_120379_120420(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,120470,120690);

f_23105_120470_120689(
            diff2, "C: {<>c__DisplayClass0_0}", "C.<>c__DisplayClass0_0: {x, <F>b__0}", "<>f__AnonymousType0<<A>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,120706,121474);

f_23105_120706_121473(
            diff2, "C.F", @"
{
  // Code size       40 (0x28)
  .maxstack  2
  .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                System.Func<int> V_1) //y
  IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
  IL_0005:  stloc.0
  IL_0006:  nop
  IL_0007:  ldloc.0
  IL_0008:  ldc.i4.1
  IL_0009:  newobj     ""<>f__AnonymousType0<int>..ctor(int)""
  IL_000e:  stfld      ""<anonymous type: int A> C.<>c__DisplayClass0_0.x""
  IL_0013:  ldloc.0
  IL_0014:  ldftn      ""int C.<>c__DisplayClass0_0.<F>b__0()""
  IL_001a:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_001f:  stloc.1
  IL_0020:  ldc.i4.3
  IL_0021:  call       ""void System.Console.WriteLine(int)""
  IL_0026:  nop
  IL_0027:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,116496,121485);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_116672_116908(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 116672, 116908);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_116937_117173(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 116937, 117173);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_117202_117438(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117202, 117438);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_117472_117529(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117472, 117529);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_117563_117600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117563, 117600);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_117634_117671(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117634, 117671);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_117697_117727(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117697, 117727);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_117752_117806(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117752, 117806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_117832_117875(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117832, 117875);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_117899_117942(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117899, 117942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_117966_118009(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 117966, 118009);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_118084_118104(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 118084, 118104);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_118044_118127(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 118044, 118127);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_118144_118908(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 118144, 118908);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_119092_119133(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 119092, 119133);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_118995_119165(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 118995, 119165);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_118937_119166(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 118937, 119166);
return return_v;
}


int
f_23105_119183_119402(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 119183, 119402);
return 0;
}


int
f_23105_119419_120186(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 119419, 120186);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_120243_120263(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 120243, 120263);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_120379_120420(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 120379, 120420);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_120282_120452(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 120282, 120452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_120215_120453(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 120215, 120453);
return return_v;
}


int
f_23105_120470_120689(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 120470, 120689);
return 0;
}


int
f_23105_120706_121473(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 120706, 121473);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,116496,121485);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,116496,121485);
}
		}

[Fact, WorkItem(1170899, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1170899")]
        public void CapturedAnonymousTypes2()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,121497,124924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,121659,121887);

var 
template = @"
using System;

class C
{
    static void F()
    <N:0>{
        var x = new { X = <<VALUE>> };
        Func<int> <N:2>y = <N:1>() => x.X</N:1></N:2>;
        Console.WriteLine(y());
    }</N:0>
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,121901,121964);

var 
source0 = f_23105_121915_121963(f_23105_121928_121962(template, "<<VALUE>>", "0"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,121978,122041);

var 
source1 = f_23105_121992_122040(f_23105_122005_122039(template, "<<VALUE>>", "1"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122055,122118);

var 
source2 = f_23105_122069_122117(f_23105_122082_122116(template, "<<VALUE>>", "2"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122134,122211);

var 
compilation0 = f_23105_122153_122210(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122225,122282);

var 
compilation1 = f_23105_122244_122281(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122296,122353);

var 
compilation2 = f_23105_122315_122352(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122369,122409);

var 
v0 = f_23105_122378_122408(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122423,122488);

var 
md0 = f_23105_122433_122487(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122504,122557);

var 
f0 = f_23105_122513_122556(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122571,122624);

var 
f1 = f_23105_122580_122623(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122638,122691);

var 
f2 = f_23105_122647_122690(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122707,122809);

var 
generation0 = f_23105_122725_122808(md0, f_23105_122765_122785(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,122825,123655);

string 
expectedIL = @"
{
  // Code size       45 (0x2d)
  .maxstack  2
  .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                System.Func<int> V_1) //y
  IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
  IL_0005:  stloc.0
  IL_0006:  nop
  IL_0007:  ldloc.0
  IL_0008:  ldc.i4.<<VALUE>>
  IL_0009:  newobj     ""<>f__AnonymousType0<int>..ctor(int)""
  IL_000e:  stfld      ""<anonymous type: int X> C.<>c__DisplayClass0_0.x""
  IL_0013:  ldloc.0
  IL_0014:  ldftn      ""int C.<>c__DisplayClass0_0.<F>b__0()""
  IL_001a:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_001f:  stloc.1
  IL_0020:  ldloc.1
  IL_0021:  callvirt   ""int System.Func<int>.Invoke()""
  IL_0026:  call       ""void System.Console.WriteLine(int)""
  IL_002b:  nop
  IL_002c:  ret
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,123671,123728);

f_23105_123671_123727(
            v0, "C.F", f_23105_123690_123726(expectedIL, "<<VALUE>>", "0"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,123744,124004);

var 
diff1 = f_23105_123756_124003(compilation1, generation0, f_23105_123832_124002(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_123929_123970(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,124020,124240);

f_23105_124020_124239(
            diff1, "C: {<>c__DisplayClass0_0}", "C.<>c__DisplayClass0_0: {x, <F>b__0}", "<>f__AnonymousType0<<X>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,124256,124316);

f_23105_124256_124315(
            diff1, "C.F", f_23105_124278_124314(expectedIL, "<<VALUE>>", "1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,124332,124601);

var 
diff2 = f_23105_124344_124600(compilation2, f_23105_124390_124410(diff1), f_23105_124429_124599(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_124526_124567(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,124617,124837);

f_23105_124617_124836(
            diff2, "C: {<>c__DisplayClass0_0}", "C.<>c__DisplayClass0_0: {x, <F>b__0}", "<>f__AnonymousType0<<X>j__TPar>: {Equals, GetHashCode, ToString}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,124853,124913);

f_23105_124853_124912(
            diff2, "C.F", f_23105_124875_124911(expectedIL, "<<VALUE>>", "2"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,121497,124924);

string
f_23105_121928_121962(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 121928, 121962);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_121915_121963(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 121915, 121963);
return return_v;
}


string
f_23105_122005_122039(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122005, 122039);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_121992_122040(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 121992, 122040);
return return_v;
}


string
f_23105_122082_122116(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122082, 122116);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_122069_122117(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122069, 122117);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_122153_122210(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122153, 122210);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_122244_122281(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122244, 122281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_122315_122352(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122315, 122352);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_122378_122408(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122378, 122408);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_122433_122487(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122433, 122487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_122513_122556(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122513, 122556);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_122580_122623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122580, 122623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_122647_122690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122647, 122690);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_122765_122785(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122765, 122785);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_122725_122808(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 122725, 122808);
return return_v;
}


string
f_23105_123690_123726(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 123690, 123726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_123671_123727(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 123671, 123727);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_123929_123970(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 123929, 123970);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_123832_124002(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 123832, 124002);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_123756_124003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 123756, 124003);
return return_v;
}


int
f_23105_124020_124239(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124020, 124239);
return 0;
}


string
f_23105_124278_124314(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124278, 124314);
return return_v;
}


int
f_23105_124256_124315(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124256, 124315);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_124390_124410(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 124390, 124410);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_124526_124567(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124526, 124567);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_124429_124599(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124429, 124599);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_124344_124600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124344, 124600);
return return_v;
}


int
f_23105_124617_124836(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124617, 124836);
return 0;
}


string
f_23105_124875_124911(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124875, 124911);
return return_v;
}


int
f_23105_124853_124912(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 124853, 124912);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,121497,124924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,121497,124924);
}
		}

[WorkItem(179990, "https://devdiv.visualstudio.com:443/defaultcollection/DevDiv/_workitems/edit/179990")]
        [Fact]
        public void SynthesizedDelegates()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,124936,137454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125126,125257);

var 
template =
@"class C
{
    static void F(dynamic d, out object x, object y)
    <N:0>{
        <<CALL>>;
    }</N:0>
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125271,125351);

var 
source0 = f_23105_125285_125350(f_23105_125298_125349(template, "<<CALL>>", "d.F(out x, new { })"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125365,125447);

var 
source1 = f_23105_125379_125446(f_23105_125392_125445(template, "<<CALL>>", "d.F(out x, new { y })"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125461,125543);

var 
source2 = f_23105_125475_125542(f_23105_125488_125541(template, "<<CALL>>", "d.F(new { y }, out x)"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125559,125708);

var 
compilation0 = f_23105_125578_125707(new[] { source0.Tree }, references: new[] { f_23105_125654_125667(), f_23105_125669_125678()}, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125722,125779);

var 
compilation1 = f_23105_125741_125778(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125793,125850);

var 
compilation2 = f_23105_125812_125849(compilation1, source2.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125866,125906);

var 
v0 = f_23105_125875_125905(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,125920,125985);

var 
md0 = f_23105_125930_125984(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,126001,126054);

var 
f0 = f_23105_126010_126053(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,126068,126121);

var 
f1 = f_23105_126077_126120(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,126135,126188);

var 
f2 = f_23105_126144_126187(compilation2, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,126204,126306);

var 
generation0 = f_23105_126222_126305(md0, f_23105_126262_126282(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,126320,129762);

f_23105_126320_129761(            v0, "C.F", @"{
  // Code size      112 (0x70)
  .maxstack  9
  IL_0000:  nop
  IL_0001:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>> C.<>o__0.<>p__0""
  IL_0006:  brfalse.s  IL_000a
  IL_0008:  br.s       IL_0053
  IL_000a:  ldc.i4     0x100
  IL_000f:  ldstr      ""F""
  IL_0014:  ldnull
  IL_0015:  ldtoken    ""C""
  IL_001a:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_001f:  ldc.i4.3
  IL_0020:  newarr     ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo""
  IL_0025:  dup
  IL_0026:  ldc.i4.0
  IL_0027:  ldc.i4.0
  IL_0028:  ldnull
  IL_0029:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_002e:  stelem.ref
  IL_002f:  dup
  IL_0030:  ldc.i4.1
  IL_0031:  ldc.i4.s   17
  IL_0033:  ldnull
  IL_0034:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0039:  stelem.ref
  IL_003a:  dup
  IL_003b:  ldc.i4.2
  IL_003c:  ldc.i4.1
  IL_003d:  ldnull
  IL_003e:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0043:  stelem.ref
  IL_0044:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, string, System.Collections.Generic.IEnumerable<System.Type>, System.Type, System.Collections.Generic.IEnumerable<Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo>)""
  IL_0049:  call       ""System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>> System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_004e:  stsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>> C.<>o__0.<>p__0""
  IL_0053:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>> C.<>o__0.<>p__0""
  IL_0058:  ldfld      ""<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>> System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>>.Target""
  IL_005d:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>> C.<>o__0.<>p__0""
  IL_0062:  ldarg.0
  IL_0063:  ldarg.1
  IL_0064:  newobj     ""<>f__AnonymousType0..ctor()""
  IL_0069:  callvirt   ""void <>A{00000004}<System.Runtime.CompilerServices.CallSite, dynamic, object, <empty anonymous type>>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic, ref object, <empty anonymous type>)""
  IL_006e:  nop
  IL_006f:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,129778,130038);

var 
diff1 = f_23105_129790_130037(compilation1, generation0, f_23105_129866_130036(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_129963_130004(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,130052,133598);

f_23105_130052_133597(            diff1, "C.F", @"{
  // Code size      113 (0x71)
  .maxstack  9
  IL_0000:  nop
  IL_0001:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>> C.<>o__0#1.<>p__0""
  IL_0006:  brfalse.s  IL_000a
  IL_0008:  br.s       IL_0053
  IL_000a:  ldc.i4     0x100
  IL_000f:  ldstr      ""F""
  IL_0014:  ldnull
  IL_0015:  ldtoken    ""C""
  IL_001a:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_001f:  ldc.i4.3
  IL_0020:  newarr     ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo""
  IL_0025:  dup
  IL_0026:  ldc.i4.0
  IL_0027:  ldc.i4.0
  IL_0028:  ldnull
  IL_0029:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_002e:  stelem.ref
  IL_002f:  dup
  IL_0030:  ldc.i4.1
  IL_0031:  ldc.i4.s   17
  IL_0033:  ldnull
  IL_0034:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0039:  stelem.ref
  IL_003a:  dup
  IL_003b:  ldc.i4.2
  IL_003c:  ldc.i4.1
  IL_003d:  ldnull
  IL_003e:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0043:  stelem.ref
  IL_0044:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, string, System.Collections.Generic.IEnumerable<System.Type>, System.Type, System.Collections.Generic.IEnumerable<Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo>)""
  IL_0049:  call       ""System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>> System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_004e:  stsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>> C.<>o__0#1.<>p__0""
  IL_0053:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>> C.<>o__0#1.<>p__0""
  IL_0058:  ldfld      ""<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>> System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>>.Target""
  IL_005d:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>> C.<>o__0#1.<>p__0""
  IL_0062:  ldarg.0
  IL_0063:  ldarg.1
  IL_0064:  ldarg.2
  IL_0065:  newobj     ""<>f__AnonymousType1<object>..ctor(object)""
  IL_006a:  callvirt   ""void <>A{00000004}#1<System.Runtime.CompilerServices.CallSite, dynamic, object, <anonymous type: object y>>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic, ref object, <anonymous type: object y>)""
  IL_006f:  nop
  IL_0070:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,133614,133883);

var 
diff2 = f_23105_133626_133882(compilation2, f_23105_133672_133692(diff1), f_23105_133711_133881(SemanticEdit.Create(SemanticEditKind.Update,f1,f2,f_23105_133808_133849(source1, source2),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,133897,137443);

f_23105_133897_137442(            diff2, "C.F", @"{
  // Code size      113 (0x71)
  .maxstack  9
  IL_0000:  nop
  IL_0001:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>> C.<>o__0#2.<>p__0""
  IL_0006:  brfalse.s  IL_000a
  IL_0008:  br.s       IL_0053
  IL_000a:  ldc.i4     0x100
  IL_000f:  ldstr      ""F""
  IL_0014:  ldnull
  IL_0015:  ldtoken    ""C""
  IL_001a:  call       ""System.Type System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)""
  IL_001f:  ldc.i4.3
  IL_0020:  newarr     ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo""
  IL_0025:  dup
  IL_0026:  ldc.i4.0
  IL_0027:  ldc.i4.0
  IL_0028:  ldnull
  IL_0029:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_002e:  stelem.ref
  IL_002f:  dup
  IL_0030:  ldc.i4.1
  IL_0031:  ldc.i4.1
  IL_0032:  ldnull
  IL_0033:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0038:  stelem.ref
  IL_0039:  dup
  IL_003a:  ldc.i4.2
  IL_003b:  ldc.i4.s   17
  IL_003d:  ldnull
  IL_003e:  call       ""Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, string)""
  IL_0043:  stelem.ref
  IL_0044:  call       ""System.Runtime.CompilerServices.CallSiteBinder Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, string, System.Collections.Generic.IEnumerable<System.Type>, System.Type, System.Collections.Generic.IEnumerable<Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo>)""
  IL_0049:  call       ""System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>> System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>>.Create(System.Runtime.CompilerServices.CallSiteBinder)""
  IL_004e:  stsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>> C.<>o__0#2.<>p__0""
  IL_0053:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>> C.<>o__0#2.<>p__0""
  IL_0058:  ldfld      ""<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object> System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>>.Target""
  IL_005d:  ldsfld     ""System.Runtime.CompilerServices.CallSite<<>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>> C.<>o__0#2.<>p__0""
  IL_0062:  ldarg.0
  IL_0063:  ldarg.2
  IL_0064:  newobj     ""<>f__AnonymousType1<object>..ctor(object)""
  IL_0069:  ldarg.1
  IL_006a:  callvirt   ""void <>A{00000008}#2<System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, object>.Invoke(System.Runtime.CompilerServices.CallSite, dynamic, <anonymous type: object y>, ref object)""
  IL_006f:  nop
  IL_0070:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,124936,137454);

string
f_23105_125298_125349(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125298, 125349);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_125285_125350(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125285, 125350);
return return_v;
}


string
f_23105_125392_125445(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125392, 125445);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_125379_125446(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125379, 125446);
return return_v;
}


string
f_23105_125488_125541(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125488, 125541);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_125475_125542(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125475, 125542);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23105_125654_125667()
{
var return_v = SystemCoreRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 125654, 125667);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23105_125669_125678()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 125669, 125678);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_125578_125707(Microsoft.CodeAnalysis.SyntaxTree[]
source,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilationWithMscorlib40( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125578, 125707);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_125741_125778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125741, 125778);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_125812_125849(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125812, 125849);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_125875_125905(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125875, 125905);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_125930_125984(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 125930, 125984);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_126010_126053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126010, 126053);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_126077_126120(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126077, 126120);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_126144_126187(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126144, 126187);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_126262_126282(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126262, 126282);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_126222_126305(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126222, 126305);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_126320_129761(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 126320, 129761);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_129963_130004(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 129963, 130004);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_129866_130036(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 129866, 130036);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_129790_130037(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 129790, 130037);
return return_v;
}


int
f_23105_130052_133597(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 130052, 133597);
return 0;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_133672_133692(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.NextGeneration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23105, 133672, 133692);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_133808_133849(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 133808, 133849);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_133711_133881(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 133711, 133881);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_133626_133882(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 133626, 133882);
return return_v;
}


int
f_23105_133897_137442(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 133897, 137442);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,124936,137454);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,124936,137454);
}
		}

[Fact]
        public void TwoStructClosures()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,137466,140403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,137538,137837);

var 
source0 = f_23105_137552_137836(@"
public class C 
{
    public void F()            
    <N:0>{</N:0>
        int <N:1>x</N:1> = 0;
        <N:2>{</N:2>
            int <N:3>y</N:3> = 0;
            // Captures two struct closures
            <N:4>int L() => x + y;</N:4>
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,137853,138152);

var 
source1 = f_23105_137867_138151(@"
public class C 
{
    public void F()            
<N:0>{</N:0>
        int <N:1>x</N:1> = 0;
        <N:2>{</N:2>
            int <N:3>y</N:3> = 0;
            // Captures two struct closures
            <N:4>int L() => x + y + 1;</N:4>
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138168,138245);

var 
compilation0 = f_23105_138187_138244(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138259,138316);

var 
compilation1 = f_23105_138278_138315(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138330,138370);

var 
v0 = f_23105_138339_138369(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138384,138449);

var 
md0 = f_23105_138394_138448(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138465,138518);

var 
f0 = f_23105_138474_138517(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138532,138585);

var 
f1 = f_23105_138541_138584(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138601,138703);

var 
generation0 = f_23105_138619_138702(md0, f_23105_138659_138679(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138719,138957);

var 
diff1 = f_23105_138731_138956(compilation1, generation0, f_23105_138807_138955(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_138882_138923(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,138973,139003);

var 
md1 = f_23105_138983_139002(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,139017,139042);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,139058,139267);

f_23105_139058_139266(
            diff1, "C.<>c__DisplayClass0_0: {x}", "C.<>c__DisplayClass0_1: {y}", "C: {<F>g__L|0_0, <>c__DisplayClass0_0, <>c__DisplayClass0_1}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,139283,139616);

f_23105_139283_139615(
            v0, "C.<F>g__L|0_0(ref C.<>c__DisplayClass0_0, ref C.<>c__DisplayClass0_1)", @"
{
  // Code size       14 (0xe)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_000c:  add
  IL_000d:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,139632,140010);

f_23105_139632_140009(
            diff1, "C.<F>g__L|0_0(ref C.<>c__DisplayClass0_0, ref C.<>c__DisplayClass0_1)", @"
{
  // Code size       16 (0x10)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_000c:  add
  IL_000d:  ldc.i4.1
  IL_000e:  add
  IL_000f:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,140026,140392);

f_23105_140026_140391(reader1, f_23105_140075_140141(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_140160_140222(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_140241_140303(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_140322_140390(7, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,137466,140403);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_137552_137836(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 137552, 137836);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_137867_138151(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 137867, 138151);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_138187_138244(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138187, 138244);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_138278_138315(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138278, 138315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_138339_138369(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138339, 138369);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_138394_138448(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138394, 138448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_138474_138517(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138474, 138517);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_138541_138584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138541, 138584);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_138659_138679(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138659, 138679);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_138619_138702(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138619, 138702);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_138882_138923(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138882, 138923);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_138807_138955(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138807, 138955);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_138731_138956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138731, 138956);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_138983_139002(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 138983, 139002);
return return_v;
}


int
f_23105_139058_139266(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 139058, 139266);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_139283_139615(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 139283, 139615);
return return_v;
}


int
f_23105_139632_140009(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 139632, 140009);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_140075_140141(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140075, 140141);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_140160_140222(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140160, 140222);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_140241_140303(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140241, 140303);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_140322_140390(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140322, 140390);
return return_v;
}


int
f_23105_140026_140391(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140026, 140391);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,137466,140403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,137466,140403);
}
		}

[Fact]
        public void ThisClosureAndStructClosure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,140415,143107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,140497,140744);

var 
source0 = f_23105_140511_140743(@"
public class C 
{
    int <N:0>x</N:0> = 0;
    public void F() 
    <N:1>{</N:1>
        int <N:2>y</N:2> = 0;
        // This + struct closures
        <N:3>int L() => x + y;</N:3>
        L();
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,140760,141011);

var 
source1 = f_23105_140774_141010(@"
public class C 
{
    int <N:0>x</N:0> = 0;
    public void F() 
    <N:1>{</N:1>
        int <N:2>y</N:2> = 0;
        // This + struct closures
        <N:3>int L() => x + y + 1;</N:3>
        L();
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141027,141104);

var 
compilation0 = f_23105_141046_141103(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141118,141175);

var 
compilation1 = f_23105_141137_141174(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141189,141229);

var 
v0 = f_23105_141198_141228(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141243,141308);

var 
md0 = f_23105_141253_141307(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141324,141377);

var 
f0 = f_23105_141333_141376(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141391,141444);

var 
f1 = f_23105_141400_141443(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141460,141562);

var 
generation0 = f_23105_141478_141561(md0, f_23105_141518_141538(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141578,141816);

var 
diff1 = f_23105_141590_141815(compilation1, generation0, f_23105_141666_141814(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_141741_141782(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141832,141862);

var 
md1 = f_23105_141842_141861(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141876,141901);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,141917,142067);

f_23105_141917_142066(
            diff1, "C.<>c__DisplayClass1_0: {<>4__this, y}", "C: {<F>g__L|1_0, <>c__DisplayClass1_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,142083,142369);

f_23105_142083_142368(
            v0, "C.<F>g__L|1_0(ref C.<>c__DisplayClass1_0)", @"
{
  // Code size       14 (0xe)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass1_0.y""
  IL_000c:  add
  IL_000d:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,142385,142714);

f_23105_142385_142713(
            diff1, "C.<F>g__L|1_0(ref C.<>c__DisplayClass1_0)", @"
{
  // Code size       16 (0x10)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass1_0.y""
  IL_000c:  add
  IL_000d:  ldc.i4.1
  IL_000e:  add
  IL_000f:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,142730,143096);

f_23105_142730_143095(reader1, f_23105_142779_142845(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_142864_142926(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_142945_143007(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_143026_143094(6, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,140415,143107);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_140511_140743(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140511, 140743);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_140774_141010(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 140774, 141010);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_141046_141103(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141046, 141103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_141137_141174(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141137, 141174);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_141198_141228(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141198, 141228);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_141253_141307(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141253, 141307);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_141333_141376(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141333, 141376);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_141400_141443(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141400, 141443);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_141518_141538(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141518, 141538);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_141478_141561(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141478, 141561);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_141741_141782(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141741, 141782);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_141666_141814(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141666, 141814);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_141590_141815(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141590, 141815);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_141842_141861(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141842, 141861);
return return_v;
}


int
f_23105_141917_142066(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 141917, 142066);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_142083_142368(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142083, 142368);
return return_v;
}


int
f_23105_142385_142713(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142385, 142713);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_142779_142845(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142779, 142845);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_142864_142926(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142864, 142926);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_142945_143007(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142945, 143007);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_143026_143094(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143026, 143094);
return return_v;
}


int
f_23105_142730_143095(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 142730, 143095);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,140415,143107);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,140415,143107);
}
		}

[Fact]
        public void ThisOnlyClosure()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,143119,145306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143189,143396);

var 
source0 = f_23105_143203_143395(@"
public class C 
{
    int <N:0>x</N:0> = 0;
    public void F() 
    <N:1>{</N:1>
        // This-only closure
        <N:2>int L() => x;</N:2>
        L();
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143412,143623);

var 
source1 = f_23105_143426_143622(@"
public class C 
{
    int <N:0>x</N:0> = 0;
    public void F() 
    <N:1>{</N:1>
        // This-only closure
        <N:2>int L() => x + 1;</N:2>
        L();
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143637,143714);

var 
compilation0 = f_23105_143656_143713(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143728,143785);

var 
compilation1 = f_23105_143747_143784(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143799,143839);

var 
v0 = f_23105_143808_143838(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143853,143918);

var 
md0 = f_23105_143863_143917(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,143934,143987);

var 
f0 = f_23105_143943_143986(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144001,144054);

var 
f1 = f_23105_144010_144053(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144070,144172);

var 
generation0 = f_23105_144088_144171(md0, f_23105_144128_144148(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144188,144426);

var 
diff1 = f_23105_144200_144425(compilation1, generation0, f_23105_144276_144424(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_144351_144392(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144442,144472);

var 
md1 = f_23105_144452_144471(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144486,144511);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144527,144596);

f_23105_144527_144595(
            diff1, "C: {<F>g__L|1_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144612,144775);

f_23105_144612_144774(
            v0, "C.<F>g__L|1_0()", @"
{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.x""
  IL_0006:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,144791,144998);

f_23105_144791_144997(
            diff1, "C.<F>g__L|1_0()", @"
{
  // Code size        9 (0x9)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.x""
  IL_0006:  ldc.i4.1
  IL_0007:  add
  IL_0008:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,145014,145295);

f_23105_145014_145294(reader1, f_23105_145063_145125(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_145144_145206(3, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_145225_145293(5, TableIndex.CustomAttribute, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,143119,145306);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_143203_143395(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143203, 143395);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_143426_143622(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143426, 143622);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_143656_143713(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143656, 143713);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_143747_143784(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143747, 143784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_143808_143838(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143808, 143838);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_143863_143917(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143863, 143917);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_143943_143986(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 143943, 143986);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_144010_144053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144010, 144053);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_144128_144148(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144128, 144148);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_144088_144171(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144088, 144171);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_144351_144392(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144351, 144392);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_144276_144424(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144276, 144424);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_144200_144425(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144200, 144425);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_144452_144471(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144452, 144471);
return return_v;
}


int
f_23105_144527_144595(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144527, 144595);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_144612_144774(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144612, 144774);
return return_v;
}


int
f_23105_144791_144997(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 144791, 144997);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_145063_145125(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145063, 145125);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_145144_145206(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145144, 145206);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_145225_145293(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145225, 145293);
return return_v;
}


int
f_23105_145014_145294(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145014, 145294);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,143119,145306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,143119,145306);
}
		}

[Fact]
        public void LocatedInSameClosureEnvironment()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,145318,147837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,145404,145651);

var 
source0 = f_23105_145418_145650(@"
using System;
public class C 
{
    public void F(int x) 
    <N:0>{</N:0>
        Func<int> f = <N:1>() => x</N:1>;
        // Located in same closure environment
        <N:2>int L() => x;</N:2>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,145667,145918);

var 
source1 = f_23105_145681_145917(@"
using System;
public class C 
{
    public void F(int x) 
    <N:0>{</N:0>
        Func<int> f = <N:1>() => x</N:1>;
        // Located in same closure environment
        <N:2>int L() => x + 1;</N:2>
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,145932,146009);

var 
compilation0 = f_23105_145951_146008(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146023,146080);

var 
compilation1 = f_23105_146042_146079(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146094,146134);

var 
v0 = f_23105_146103_146133(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146148,146213);

var 
md0 = f_23105_146158_146212(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146229,146282);

var 
f0 = f_23105_146238_146281(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146296,146349);

var 
f1 = f_23105_146305_146348(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146365,146467);

var 
generation0 = f_23105_146383_146466(md0, f_23105_146423_146443(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146483,146721);

var 
diff1 = f_23105_146495_146720(compilation1, generation0, f_23105_146571_146719(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_146646_146687(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146737,146767);

var 
md1 = f_23105_146747_146766(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146781,146806);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146822,146968);

f_23105_146822_146967(
            diff1, "C.<>c__DisplayClass0_0: {x, <F>b__0, <F>g__L|1}", "C: {<>c__DisplayClass0_0}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,146984,147187);

f_23105_146984_147186(
            v0, "C.<>c__DisplayClass0_0.<F>g__L|1()", @"
{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,147203,147450);

f_23105_147203_147449(
            diff1, "C.<>c__DisplayClass0_0.<F>g__L|1()", @"
{
  // Code size        9 (0x9)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ldc.i4.1
  IL_0007:  add
  IL_0008:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,147466,147826);

f_23105_147466_147825(reader1, f_23105_147515_147581(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_147600_147662(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_147681_147743(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_147762_147824(5, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,145318,147837);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_145418_145650(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145418, 145650);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_145681_145917(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145681, 145917);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_145951_146008(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 145951, 146008);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_146042_146079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146042, 146079);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_146103_146133(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146103, 146133);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_146158_146212(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146158, 146212);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_146238_146281(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146238, 146281);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_146305_146348(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146305, 146348);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_146423_146443(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146423, 146443);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_146383_146466(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146383, 146466);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_146646_146687(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146646, 146687);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_146571_146719(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146571, 146719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_146495_146720(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146495, 146720);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_146747_146766(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146747, 146766);
return return_v;
}


int
f_23105_146822_146967(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146822, 146967);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_146984_147186(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 146984, 147186);
return return_v;
}


int
f_23105_147203_147449(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147203, 147449);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_147515_147581(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147515, 147581);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_147600_147662(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147600, 147662);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_147681_147743(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147681, 147743);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_147762_147824(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147762, 147824);
return return_v;
}


int
f_23105_147466_147825(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147466, 147825);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,145318,147837);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,145318,147837);
}
		}

[Fact]
        public void SameClassEnvironmentWithStruct()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,147849,150856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,147934,148269);

var 
source0 = f_23105_147948_148268(@"
using System;
public class C 
{
    public void F(int x) 
    <N:0>{</N:0>
        <N:1>{</N:1>
            int <N:2>y</N:2> = 0;
            Func<int> f = <N:3>() => x</N:3>;
            // Same class environment, with struct env
            <N:4>int L() => x + y;</N:4>
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148285,148624);

var 
source1 = f_23105_148299_148623(@"
using System;
public class C 
{
    public void F(int x) 
    <N:0>{</N:0>
        <N:1>{</N:1>
            int <N:2>y</N:2> = 0;
            Func<int> f = <N:3>() => x</N:3>;
            // Same class environment, with struct env
            <N:4>int L() => x + y + 1;</N:4>
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148638,148715);

var 
compilation0 = f_23105_148657_148714(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148729,148786);

var 
compilation1 = f_23105_148748_148785(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148800,148840);

var 
v0 = f_23105_148809_148839(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148854,148919);

var 
md0 = f_23105_148864_148918(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,148935,148988);

var 
f0 = f_23105_148944_148987(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149002,149055);

var 
f1 = f_23105_149011_149054(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149071,149173);

var 
generation0 = f_23105_149089_149172(md0, f_23105_149129_149149(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149189,149427);

var 
diff1 = f_23105_149201_149426(compilation1, generation0, f_23105_149277_149425(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_149352_149393(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149443,149473);

var 
md1 = f_23105_149453_149472(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149487,149512);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149528,149744);

f_23105_149528_149743(
            diff1, "C: {<>c__DisplayClass0_0, <>c__DisplayClass0_1}", "C.<>c__DisplayClass0_0: {x, <F>b__0, <F>g__L|1}", "C.<>c__DisplayClass0_1: {y}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,149760,150084);

f_23105_149760_150083(
            v0, "C.<>c__DisplayClass0_0.<F>g__L|1(ref C.<>c__DisplayClass0_1)", @"
{
  // Code size       14 (0xe)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_000c:  add
  IL_000d:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,150100,150469);

f_23105_150100_150468(
            diff1, "C.<>c__DisplayClass0_0.<F>g__L|1(ref C.<>c__DisplayClass0_1)", @"
{
  // Code size       16 (0x10)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_0006:  ldarg.1
  IL_0007:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_000c:  add
  IL_000d:  ldc.i4.1
  IL_000e:  add
  IL_000f:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,150485,150845);

f_23105_150485_150844(reader1, f_23105_150534_150600(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_150619_150681(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_150700_150762(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_150781_150843(5, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,147849,150856);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_147948_148268(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 147948, 148268);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_148299_148623(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148299, 148623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_148657_148714(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148657, 148714);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_148748_148785(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148748, 148785);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_148809_148839(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148809, 148839);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_148864_148918(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148864, 148918);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_148944_148987(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 148944, 148987);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_149011_149054(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149011, 149054);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_149129_149149(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149129, 149149);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_149089_149172(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149089, 149172);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_149352_149393(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149352, 149393);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_149277_149425(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149277, 149425);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_149201_149426(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149201, 149426);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_149453_149472(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149453, 149472);
return return_v;
}


int
f_23105_149528_149743(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149528, 149743);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_149760_150083(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 149760, 150083);
return return_v;
}


int
f_23105_150100_150468(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150100, 150468);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_150534_150600(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150534, 150600);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_150619_150681(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150619, 150681);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_150700_150762(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150700, 150762);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_150781_150843(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150781, 150843);
return return_v;
}


int
f_23105_150485_150844(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150485, 150844);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,147849,150856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,147849,150856);
}
		}

[Fact]
        public void CaptureStructAndThroughClassEnvChain()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23105,150868,154727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,150959,151445);

var 
source0 = f_23105_150973_151444(@"
using System;
public class C 
{
    public void F(int x) 
    <N:0>{</N:0>
        <N:1>{</N:1>
            int <N:2>y</N:2> = 0;
            Func<int> f = <N:3>() => x</N:3>;
            <N:4>{</N:4>
                Func<int> f2 = <N:5>() => x + y</N:5>;
                int <N:6>z</N:6> = 0;
                // Capture struct and through class env chain
                <N:7>int L() => x + y + z;</N:7>
            }
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,151461,151947);

var 
source1 = f_23105_151475_151946(@"
using System;
public class C 
{
    public void F(int x) 
<N:0>{</N:0>
        <N:1>{</N:1>
            int <N:2>y</N:2> = 0;
            Func<int> f = <N:3>() => x</N:3>;
            <N:4>{</N:4>
                Func<int> f2 = <N:5>() => x + y</N:5>;
                int <N:6>z</N:6> = 0;
                // Capture struct and through class env chain
                <N:7>int L() => x + y + z + 1;</N:7>
            }
        }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,151961,152038);

var 
compilation0 = f_23105_151980_152037(source0.Tree, options: ComSafeDebugDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152052,152109);

var 
compilation1 = f_23105_152071_152108(compilation0, source1.Tree)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152123,152163);

var 
v0 = f_23105_152132_152162(this, compilation0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152177,152242);

var 
md0 = f_23105_152187_152241(v0.EmittedAssemblyData)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152258,152311);

var 
f0 = f_23105_152267_152310(compilation0, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152325,152378);

var 
f1 = f_23105_152334_152377(compilation1, "C.F")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152394,152496);

var 
generation0 = f_23105_152412_152495(md0, f_23105_152452_152472(v0).GetEncMethodDebugInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152512,152750);

var 
diff1 = f_23105_152524_152749(compilation1, generation0, f_23105_152600_152748(SemanticEdit.Create(SemanticEditKind.Update,f0,f1,f_23105_152675_152716(source0, source1),preserveLocalVariables: true)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152766,152796);

var 
md1 = f_23105_152776_152795(diff1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152810,152835);

var 
reader1 = md1.Reader
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,152851,153163);

f_23105_152851_153162(
            diff1, "C.<>c__DisplayClass0_2: {z}", "C.<>c__DisplayClass0_0: {x, <F>b__0}", "C: {<>c__DisplayClass0_0, <>c__DisplayClass0_1, <>c__DisplayClass0_2}", "C.<>c__DisplayClass0_1: {y, CS$<>8__locals1, <F>b__1, <F>g__L|2}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,153179,153689);

f_23105_153179_153688(
            v0, "C.<>c__DisplayClass0_1.<F>g__L|2(ref C.<>c__DisplayClass0_2)", @"
{
  // Code size       26 (0x1a)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""C.<>c__DisplayClass0_0 C.<>c__DisplayClass0_1.CS$<>8__locals1""
  IL_0006:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_000b:  ldarg.0
  IL_000c:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_0011:  add
  IL_0012:  ldarg.1
  IL_0013:  ldfld      ""int C.<>c__DisplayClass0_2.z""
  IL_0018:  add
  IL_0019:  ret
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,153705,154259);

f_23105_153705_154258(
            diff1, "C.<>c__DisplayClass0_1.<F>g__L|2(ref C.<>c__DisplayClass0_2)", @"
{
  // Code size       28 (0x1c)
  .maxstack  2
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""C.<>c__DisplayClass0_0 C.<>c__DisplayClass0_1.CS$<>8__locals1""
  IL_0006:  ldfld      ""int C.<>c__DisplayClass0_0.x""
  IL_000b:  ldarg.0
  IL_000c:  ldfld      ""int C.<>c__DisplayClass0_1.y""
  IL_0011:  add
  IL_0012:  ldarg.1
  IL_0013:  ldfld      ""int C.<>c__DisplayClass0_2.z""
  IL_0018:  add
  IL_0019:  ldc.i4.1
  IL_001a:  add
  IL_001b:  ret
}
");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23105,154275,154716);

f_23105_154275_154715(reader1, f_23105_154324_154390(2, TableIndex.StandAloneSig, EditAndContinueOperation.Default), f_23105_154409_154471(1, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_154490_154552(4, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_154571_154633(6, TableIndex.MethodDef, EditAndContinueOperation.Default), f_23105_154652_154714(7, TableIndex.MethodDef, EditAndContinueOperation.Default));
DynAbs.Tracing.TraceSender.TraceExitMethod(23105,150868,154727);

Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_150973_151444(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 150973, 151444);
return return_v;
}


Roslyn.Test.Utilities.SourceWithMarkedNodes
f_23105_151475_151946(string
markedSource)
{
var return_v = MarkedSource( markedSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 151475, 151946);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_151980_152037(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 151980, 152037);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23105_152071_152108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.SyntaxTree
newTree)
{
var return_v = compilation.WithSource( newTree);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152071, 152108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_152132_152162(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.EditAndContinueClosureTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152132, 152162);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23105_152187_152241(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152187, 152241);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_152267_152310(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152267, 152310);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23105_152334_152377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152334, 152377);
return return_v;
}


Microsoft.DiaSymReader.ISymUnmanagedReader3
f_23105_152452_152472(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
verifier)
{
var return_v = verifier.CreateSymReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152452, 152472);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitBaseline
f_23105_152412_152495(Microsoft.CodeAnalysis.ModuleMetadata
module,System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
debugInformationProvider)
{
var return_v = EmitBaseline.CreateInitialBaseline( module, debugInformationProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152412, 152495);
return return_v;
}


System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
f_23105_152675_152716(Roslyn.Test.Utilities.SourceWithMarkedNodes
source0,Roslyn.Test.Utilities.SourceWithMarkedNodes
source1)
{
var return_v = GetSyntaxMapFromMarkers( source0, source1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152675, 152716);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
f_23105_152600_152748(Microsoft.CodeAnalysis.Emit.SemanticEdit
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152600, 152748);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
f_23105_152524_152749(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitBaseline
baseline,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
edits)
{
var return_v = compilation.EmitDifference( baseline, edits);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152524, 152749);
return return_v;
}


Roslyn.Test.Utilities.PinnedMetadata
f_23105_152776_152795(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152776, 152795);
return return_v;
}


int
f_23105_152851_153162(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,params string[]
expectedSynthesizedTypesAndMemberCounts)
{
this_param.VerifySynthesizedMembers( expectedSynthesizedTypesAndMemberCounts);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 152851, 153162);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23105_153179_153688(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 153179, 153688);
return return_v;
}


int
f_23105_153705_154258(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
this_param,string
qualifiedMethodName,string
expectedIL)
{
this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 153705, 154258);
return 0;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_154324_154390(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154324, 154390);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_154409_154471(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154409, 154471);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_154490_154552(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154490, 154552);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_154571_154633(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154571, 154633);
return return_v;
}


System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry
f_23105_154652_154714(int
rowNumber,System.Reflection.Metadata.Ecma335.TableIndex
table,System.Reflection.Metadata.Ecma335.EditAndContinueOperation
operation)
{
var return_v = Row( rowNumber, table, operation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154652, 154714);
return return_v;
}


int
f_23105_154275_154715(System.Reflection.Metadata.MetadataReader
reader,params System.Reflection.Metadata.Ecma335.EditAndContinueLogEntry[]
rows)
{
CheckEncLogDefinitions( reader, rows);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23105, 154275, 154715);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23105,150868,154727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,150868,154727);
}
		}

public EditAndContinueClosureTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23105,717,154734);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23105,717,154734);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,717,154734);
}


static EditAndContinueClosureTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23105,717,154734);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23105,717,154734);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23105,717,154734);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23105,717,154734);
}
}
