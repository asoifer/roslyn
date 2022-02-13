// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using System.Reflection.PortableExecutable;
using Roslyn.Test.Utilities;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
[CompilerTrait(CompilerFeature.Determinism)]
    public class DeterministicTests : EmitMetadataTestBase
{
private Guid CompiledGuid(string source, string assemblyName, bool debug, Platform platform = Platform.AnyCpu)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,893,1165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,1028,1154);

return f_23101_1035_1153(this, source, assemblyName, options: (DynAbs.Tracing.TraceSender.Conditional_F1(23101, 1079, 1084)||((debug &&DynAbs.Tracing.TraceSender.Conditional_F2(23101, 1087, 1107))||DynAbs.Tracing.TraceSender.Conditional_F3(23101, 1110, 1132)))?TestOptions.DebugExe :TestOptions.ReleaseExe, platform: platform);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,893,1165);

System.Guid
f_23101_1035_1153(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, options:options, platform:platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 1035, 1153);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,893,1165);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,893,1165);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private Guid CompiledGuid(string source, string assemblyName, CSharpCompilationOptions options, EmitOptions emitOptions = null, Platform platform = Platform.AnyCpu)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,1177,1907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,1366,1594);

var 
compilation = f_23101_1384_1593(source, assemblyName: assemblyName, references: new[] { f_23101_1497_1508()}, options: f_23101_1538_1592(f_23101_1538_1569(options, true), platform))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,1610,1638);

Guid 
result = default(Guid)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,1652,1866);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompileAndVerify(compilation,emitOptions: emitOptions,validator: a =>
            {
                var module = a.Modules[0];
                result = module.GetModuleVersionIdOrThrow();
            }),23101,1652,1865);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,1882,1896);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,1177,1907);

Microsoft.CodeAnalysis.MetadataReference
f_23101_1497_1508()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 1497, 1508);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_1538_1569(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
deterministic)
{
var return_v = this_param.WithDeterministic( deterministic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 1538, 1569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_1538_1592(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.WithPlatform( platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 1538, 1592);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_1384_1593(string
source,string
assemblyName,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 1384, 1593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,1177,1907);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,1177,1907);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private (ImmutableArray<byte> pe, ImmutableArray<byte> pdb) EmitDeterministic(string source, Platform platform, DebugInformationFormat pdbFormat, bool optimize)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,1919,3048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2104,2224);

var 
options = f_23101_2118_2223(f_23101_2118_2199(((DynAbs.Tracing.TraceSender.Conditional_F1(23101, 2119, 2127)||((optimize &&DynAbs.Tracing.TraceSender.Conditional_F2(23101, 2130, 2152))||DynAbs.Tracing.TraceSender.Conditional_F3(23101, 2155, 2175)))?TestOptions.ReleaseExe :TestOptions.DebugExe), platform), true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2240,2401);

var 
compilation = f_23101_2258_2400(source, assemblyName: "DeterminismTest", references: new[] { f_23101_2342_2353(), f_23101_2355_2368(), f_23101_2370_2379()}, options: options)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2591,2721) || true) && (pdbFormat == DebugInformationFormat.Pdb)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23101,2591,2721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2668,2706);

f_23101_2668_2705(TimeSpan.FromSeconds(1));
DynAbs.Tracing.TraceSender.TraceExitCondition(23101,2591,2721);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2737,2828);

var 
pdbStream = (DynAbs.Tracing.TraceSender.Conditional_F1(23101, 2753, 2799)||(((pdbFormat == DebugInformationFormat.Embedded) &&DynAbs.Tracing.TraceSender.Conditional_F2(23101, 2802, 2806))||DynAbs.Tracing.TraceSender.Conditional_F3(23101, 2809, 2827)))?null :f_23101_2809_2827()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,2844,3037);

return (pe: f_23101_2856_2960(compilation, f_23101_2880_2937(EmitOptions.Default, pdbFormat), pdbStream: pdbStream),
                    pdb: f_23101_2988_3035((pdbStream ??(DynAbs.Tracing.TraceSender.Expression_Null<System.IO.MemoryStream?>(23101, 2989, 3020)??f_23101_3002_3020()))));
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,1919,3048);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_2118_2199(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.WithPlatform( platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2118, 2199);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_2118_2223(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
deterministic)
{
var return_v = this_param.WithDeterministic( deterministic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2118, 2223);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23101_2342_2353()
{
var return_v = MscorlibRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 2342, 2353);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23101_2355_2368()
{
var return_v = SystemCoreRef;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 2355, 2368);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23101_2370_2379()
{
var return_v = CSharpRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 2370, 2379);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_2258_2400(string
source,string
assemblyName,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2258, 2400);
return return_v;
}


int
f_23101_2668_2705(System.TimeSpan
timeout)
{
Thread.Sleep( timeout);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2668, 2705);
return 0;
}


System.IO.MemoryStream
f_23101_2809_2827()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2809, 2827);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23101_2880_2937(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
format)
{
var return_v = this_param.WithDebugInformationFormat( format);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2880, 2937);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23101_2856_2960(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options,System.IO.MemoryStream?
pdbStream)
{
var return_v = compilation.EmitToArray( options, pdbStream:(System.IO.Stream?)pdbStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2856, 2960);
return return_v;
}


System.IO.MemoryStream
f_23101_3002_3020()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3002, 3020);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23101_2988_3035(System.IO.MemoryStream
stream)
{
var return_v = stream.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 2988, 3035);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,1919,3048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,1919,3048);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact, WorkItem(4578, "https://github.com/dotnet/roslyn/issues/4578")]
        public void BanVersionWildcards()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,3060,4168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,3198,3296);

string 
source = @"[assembly: System.Reflection.AssemblyVersion(""10101.0.*"")] public class C {}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,3310,3547);

var 
compilationDeterministic = f_23101_3341_3546(source, assemblyName: "DeterminismTest", references: new[] { f_23101_3460_3471()}, options: f_23101_3501_3545(TestOptions.DebugDll, true))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,3561,3819);

var 
compilationNonDeterministic = f_23101_3595_3818(source, assemblyName: "DeterminismTest", references: new[] { f_23101_3731_3742()}, options: f_23101_3772_3817(TestOptions.DebugDll, false))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,3835,3928);

var 
resultDeterministic = f_23101_3861_3927(compilationDeterministic, Stream.Null, pdbStream: Stream.Null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,3942,4041);

var 
resultNonDeterministic = f_23101_3971_4040(compilationNonDeterministic, Stream.Null, pdbStream: Stream.Null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4057,4099);

f_23101_4057_4098(f_23101_4070_4097(resultDeterministic));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4113,4157);

f_23101_4113_4156(f_23101_4125_4155(resultNonDeterministic));
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,3060,4168);

Microsoft.CodeAnalysis.MetadataReference
f_23101_3460_3471()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 3460, 3471);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_3501_3545(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
deterministic)
{
var return_v = this_param.WithDeterministic( deterministic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3501, 3545);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_3341_3546(string
source,string
assemblyName,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3341, 3546);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23101_3731_3742()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 3731, 3742);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_3772_3817(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
deterministic)
{
var return_v = this_param.WithDeterministic( deterministic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3772, 3817);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_3595_3818(string
source,string
assemblyName,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3595, 3818);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23101_3861_3927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.Stream
peStream,System.IO.Stream
pdbStream)
{
var return_v = this_param.Emit( peStream, pdbStream:pdbStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3861, 3927);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23101_3971_4040(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.Stream
peStream,System.IO.Stream
pdbStream)
{
var return_v = this_param.Emit( peStream, pdbStream:pdbStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 3971, 4040);
return return_v;
}


bool
f_23101_4070_4097(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 4070, 4097);
return return_v;
}


int
f_23101_4057_4098(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4057, 4098);
return 0;
}


bool
f_23101_4125_4155(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 4125, 4155);
return return_v;
}


int
f_23101_4113_4156(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4113, 4156);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,3060,4168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,3060,4168);
}
		}

[Fact, WorkItem(372, "https://github.com/dotnet/roslyn/issues/372")]
        public void Simple()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,4180,5377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4303,4387);

var 
source =
@"class Program
{
    public static void Main(string[] args) {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4473,4519);

var 
mvid1 = f_23101_4485_4518(this, source, "X1", false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4533,4579);

var 
mvid2 = f_23101_4545_4578(this, source, "X1", false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4593,4620);

f_23101_4593_4619(mvid1, mvid2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4700,4746);

var 
mvid3 = f_23101_4712_4745(this, source, "X2", false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4760,4790);

f_23101_4760_4789(mvid1, mvid3);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4889,4934);

var 
mvid5 = f_23101_4901_4933(this, source, "X1", true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,4948,4993);

var 
mvid6 = f_23101_4960_4992(this, source, "X1", true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5007,5034);

f_23101_5007_5033(mvid5, mvid6);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5124,5169);

var 
mvid7 = f_23101_5136_5168(this, source, "X2", true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5183,5213);

f_23101_5183_5212(mvid5, mvid7);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5292,5322);

f_23101_5292_5321(mvid1, mvid5);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5336,5366);

f_23101_5336_5365(mvid3, mvid7);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,4180,5377);

System.Guid
f_23101_4485_4518(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4485, 4518);
return return_v;
}


System.Guid
f_23101_4545_4578(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4545, 4578);
return return_v;
}


int
f_23101_4593_4619(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4593, 4619);
return 0;
}


System.Guid
f_23101_4712_4745(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4712, 4745);
return return_v;
}


int
f_23101_4760_4789(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4760, 4789);
return 0;
}


System.Guid
f_23101_4901_4933(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4901, 4933);
return return_v;
}


System.Guid
f_23101_4960_4992(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 4960, 4992);
return return_v;
}


int
f_23101_5007_5033(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5007, 5033);
return 0;
}


System.Guid
f_23101_5136_5168(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5136, 5168);
return return_v;
}


int
f_23101_5183_5212(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5183, 5212);
return 0;
}


int
f_23101_5292_5321(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5292, 5321);
return 0;
}


int
f_23101_5336_5365(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5336, 5365);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,4180,5377);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,4180,5377);
}
		}

[Fact]
        public void PlatformChangeGuid()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,5389,6400);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5462,5546);

var 
source =
@"class Program
{
    public static void Main(string[] args) {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5632,5692);

var 
mvid1 = f_23101_5644_5691(this, source, "X1", false, Platform.X86)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5706,5766);

var 
mvid2 = f_23101_5718_5765(this, source, "X1", false, Platform.X86)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5780,5807);

f_23101_5780_5806(mvid1, mvid2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5823,5883);

var 
mvid3 = f_23101_5835_5882(this, source, "X1", false, Platform.X64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5897,5957);

var 
mvid4 = f_23101_5909_5956(this, source, "X1", false, Platform.X64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,5971,5998);

f_23101_5971_5997(mvid3, mvid4);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6014,6076);

var 
mvid5 = f_23101_6026_6075(this, source, "X1", false, Platform.Arm64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6090,6152);

var 
mvid6 = f_23101_6102_6151(this, source, "X1", false, Platform.Arm64)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6166,6193);

f_23101_6166_6192(mvid5, mvid6);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6271,6301);

f_23101_6271_6300(mvid1, mvid3);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6315,6345);

f_23101_6315_6344(mvid1, mvid5);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6359,6389);

f_23101_6359_6388(mvid3, mvid5);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,5389,6400);

System.Guid
f_23101_5644_5691(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5644, 5691);
return return_v;
}


System.Guid
f_23101_5718_5765(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5718, 5765);
return return_v;
}


int
f_23101_5780_5806(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5780, 5806);
return 0;
}


System.Guid
f_23101_5835_5882(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5835, 5882);
return return_v;
}


System.Guid
f_23101_5909_5956(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5909, 5956);
return return_v;
}


int
f_23101_5971_5997(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 5971, 5997);
return 0;
}


System.Guid
f_23101_6026_6075(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6026, 6075);
return return_v;
}


System.Guid
f_23101_6102_6151(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,bool
debug,Microsoft.CodeAnalysis.Platform
platform)
{
var return_v = this_param.CompiledGuid( source, assemblyName, debug, platform);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6102, 6151);
return return_v;
}


int
f_23101_6166_6192(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6166, 6192);
return 0;
}


int
f_23101_6271_6300(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6271, 6300);
return 0;
}


int
f_23101_6315_6344(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6315, 6344);
return 0;
}


int
f_23101_6359_6388(System.Guid
expected,System.Guid
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6359, 6388);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,5389,6400);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,5389,6400);
}
		}

[Fact]
        public void PlatformChangeTimestamp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,6412,7237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6490,6617);

var 
result1 = f_23101_6504_6616(this, CompareAllBytesEmitted_Source, Platform.X64, DebugInformationFormat.Embedded, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6631,6760);

var 
result2 = f_23101_6645_6759(this, CompareAllBytesEmitted_Source, Platform.Arm64, DebugInformationFormat.Embedded, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6776,6818);

f_23101_6776_6817(result1.pe, result2.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6834,6880);

PEReader 
peReader1 = f_23101_6855_6879(result1.pe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6894,6940);

PEReader 
peReader2 = f_23101_6915_6939(result2.pe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,6954,7022);

f_23101_6954_7021(Machine.Amd64, f_23101_6982_7020(f_23101_6982_7012(f_23101_6982_7001(peReader1))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7036,7104);

f_23101_7036_7103(Machine.Arm64, f_23101_7064_7102(f_23101_7064_7094(f_23101_7064_7083(peReader2))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7118,7226);

f_23101_7118_7225(f_23101_7134_7178(f_23101_7134_7164(f_23101_7134_7153(peReader1))), f_23101_7180_7224(f_23101_7180_7210(f_23101_7180_7199(peReader2))));
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,6412,7237);

(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_6504_6616(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6504, 6616);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_6645_6759(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6645, 6759);
return return_v;
}


int
f_23101_6776_6817(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.NotEqual( (System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6776, 6817);
return 0;
}


System.Reflection.PortableExecutable.PEReader
f_23101_6855_6879(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6855, 6879);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23101_6915_6939(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6915, 6939);
return return_v;
}


System.Reflection.PortableExecutable.PEHeaders
f_23101_6982_7001(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 6982, 7001);
return return_v;
}


System.Reflection.PortableExecutable.CoffHeader
f_23101_6982_7012(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CoffHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 6982, 7012);
return return_v;
}


System.Reflection.PortableExecutable.Machine
f_23101_6982_7020(System.Reflection.PortableExecutable.CoffHeader
this_param)
{
var return_v = this_param.Machine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 6982, 7020);
return return_v;
}


int
f_23101_6954_7021(System.Reflection.PortableExecutable.Machine
expected,System.Reflection.PortableExecutable.Machine
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 6954, 7021);
return 0;
}


System.Reflection.PortableExecutable.PEHeaders
f_23101_7064_7083(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7064, 7083);
return return_v;
}


System.Reflection.PortableExecutable.CoffHeader
f_23101_7064_7094(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CoffHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7064, 7094);
return return_v;
}


System.Reflection.PortableExecutable.Machine
f_23101_7064_7102(System.Reflection.PortableExecutable.CoffHeader
this_param)
{
var return_v = this_param.Machine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7064, 7102);
return return_v;
}


int
f_23101_7036_7103(System.Reflection.PortableExecutable.Machine
expected,System.Reflection.PortableExecutable.Machine
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7036, 7103);
return 0;
}


System.Reflection.PortableExecutable.PEHeaders
f_23101_7134_7153(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7134, 7153);
return return_v;
}


System.Reflection.PortableExecutable.CoffHeader
f_23101_7134_7164(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CoffHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7134, 7164);
return return_v;
}


int
f_23101_7134_7178(System.Reflection.PortableExecutable.CoffHeader
this_param)
{
var return_v = this_param.TimeDateStamp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7134, 7178);
return return_v;
}


System.Reflection.PortableExecutable.PEHeaders
f_23101_7180_7199(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7180, 7199);
return return_v;
}


System.Reflection.PortableExecutable.CoffHeader
f_23101_7180_7210(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CoffHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7180, 7210);
return return_v;
}


int
f_23101_7180_7224(System.Reflection.PortableExecutable.CoffHeader
this_param)
{
var return_v = this_param.TimeDateStamp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 7180, 7224);
return return_v;
}


int
f_23101_7118_7225(int
expected,int
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7118, 7225);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,6412,7237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,6412,7237);
}
		}

[Fact]
        public void RefAssembly()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,7249,7829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7315,7411);

var 
source =
@"class Program
{
    public static void Main(string[] args) {}
    CHANGE
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7425,7527);

var 
emitRefAssembly = f_23101_7447_7526(f_23101_7447_7493(EmitOptions.Default, true), false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7543,7643);

var 
mvid1 = f_23101_7555_7642(this, f_23101_7568_7596(source, "CHANGE", ""), "X1", TestOptions.DebugDll, emitRefAssembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7657,7777);

var 
mvid2 = f_23101_7669_7776(this, f_23101_7682_7730(source, "CHANGE", "private void M() { }"), "X1", TestOptions.DebugDll, emitRefAssembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7791,7818);

f_23101_7791_7817(mvid1, mvid2);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,7249,7829);

Microsoft.CodeAnalysis.Emit.EmitOptions
f_23101_7447_7493(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,bool
value)
{
var return_v = this_param.WithEmitMetadataOnly( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7447, 7493);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23101_7447_7526(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,bool
value)
{
var return_v = this_param.WithIncludePrivateMembers( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7447, 7526);
return return_v;
}


string
f_23101_7568_7596(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7568, 7596);
return return_v;
}


System.Guid
f_23101_7555_7642(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.Emit.EmitOptions
emitOptions)
{
var return_v = this_param.CompiledGuid( source, assemblyName, options, emitOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7555, 7642);
return return_v;
}


string
f_23101_7682_7730(string
this_param,string
oldValue,string
newValue)
{
var return_v = this_param.Replace( oldValue, newValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7682, 7730);
return return_v;
}


System.Guid
f_23101_7669_7776(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.Emit.EmitOptions
emitOptions)
{
var return_v = this_param.CompiledGuid( source, assemblyName, options, emitOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7669, 7776);
return return_v;
}


int
f_23101_7791_7817(System.Guid
expected,System.Guid
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 7791, 7817);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,7249,7829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,7249,7829);
}
		}

const string 
CompareAllBytesEmitted_Source = @"
using System;
using System.Linq;
using System.Collections.Generic;

namespace N
{
    using I4 = System.Int32;
    
    class Program
    {
        public static IEnumerable<int> F() 
        {
            I4 x = 1; 
            yield return 1;
            yield return x;
        }

        public static void Main(string[] args) 
        {
            dynamic x = 1;
            const int a = 1;
            F().ToArray();
            Console.WriteLine(x + a);
        }
    }
}"
;

[Theory]
        [MemberData(nameof(PdbFormats))]
        public void CompareAllBytesEmitted_Release(DebugInformationFormat pdbFormat)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,8409,9851);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,8665,8764) || true) && (pdbFormat == DebugInformationFormat.Pdb)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23101,8665,8764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,8742,8749);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(23101,8665,8764);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,8780,8901);

var 
result1 = f_23101_8794_8900(this, CompareAllBytesEmitted_Source, Platform.AnyCpu32BitPreferred, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,8915,9036);

var 
result2 = f_23101_8929_9035(this, CompareAllBytesEmitted_Source, Platform.AnyCpu32BitPreferred, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9050,9089);

f_23101_9050_9088(result1.pe, result2.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9103,9144);

f_23101_9103_9143(result1.pdb, result2.pdb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9160,9264);

var 
result3 = f_23101_9174_9263(this, CompareAllBytesEmitted_Source, Platform.X64, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9278,9382);

var 
result4 = f_23101_9292_9381(this, CompareAllBytesEmitted_Source, Platform.X64, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9396,9435);

f_23101_9396_9434(result3.pe, result4.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9449,9490);

f_23101_9449_9489(result3.pdb, result4.pdb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9506,9612);

var 
result5 = f_23101_9520_9611(this, CompareAllBytesEmitted_Source, Platform.Arm64, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9626,9732);

var 
result6 = f_23101_9640_9731(this, CompareAllBytesEmitted_Source, Platform.Arm64, pdbFormat, optimize: true)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9746,9785);

f_23101_9746_9784(result5.pe, result6.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,9799,9840);

f_23101_9799_9839(result5.pdb, result6.pdb);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,8409,9851);

(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_8794_8900(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 8794, 8900);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_8929_9035(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 8929, 9035);
return return_v;
}


int
f_23101_9050_9088(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9050, 9088);
return 0;
}


int
f_23101_9103_9143(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9103, 9143);
return 0;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_9174_9263(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9174, 9263);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_9292_9381(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9292, 9381);
return return_v;
}


int
f_23101_9396_9434(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9396, 9434);
return 0;
}


int
f_23101_9449_9489(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9449, 9489);
return 0;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_9520_9611(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9520, 9611);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_9640_9731(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9640, 9731);
return return_v;
}


int
f_23101_9746_9784(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9746, 9784);
return 0;
}


int
f_23101_9799_9839(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 9799, 9839);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,8409,9851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,8409,9851);
}
		}

[WorkItem(926, "https://github.com/dotnet/roslyn/issues/926")]
        [Theory]
        [MemberData(nameof(PdbFormats))]
        public void CompareAllBytesEmitted_Debug(DebugInformationFormat pdbFormat)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,9863,11381);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10189,10288) || true) && (pdbFormat == DebugInformationFormat.Pdb)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23101,10189,10288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10266,10273);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(23101,10189,10288);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10304,10426);

var 
result1 = f_23101_10318_10425(this, CompareAllBytesEmitted_Source, Platform.AnyCpu32BitPreferred, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10440,10562);

var 
result2 = f_23101_10454_10561(this, CompareAllBytesEmitted_Source, Platform.AnyCpu32BitPreferred, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10576,10615);

f_23101_10576_10614(result1.pe, result2.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10629,10670);

f_23101_10629_10669(result1.pdb, result2.pdb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10686,10791);

var 
result3 = f_23101_10700_10790(this, CompareAllBytesEmitted_Source, Platform.X64, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10805,10910);

var 
result4 = f_23101_10819_10909(this, CompareAllBytesEmitted_Source, Platform.X64, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10924,10963);

f_23101_10924_10962(result3.pe, result4.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,10977,11018);

f_23101_10977_11017(result3.pdb, result4.pdb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11034,11141);

var 
result5 = f_23101_11048_11140(this, CompareAllBytesEmitted_Source, Platform.Arm64, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11155,11262);

var 
result6 = f_23101_11169_11261(this, CompareAllBytesEmitted_Source, Platform.Arm64, pdbFormat, optimize: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11276,11315);

f_23101_11276_11314(result5.pe, result6.pe);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11329,11370);

f_23101_11329_11369(result5.pdb, result6.pdb);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,9863,11381);

(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_10318_10425(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10318, 10425);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_10454_10561(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10454, 10561);
return return_v;
}


int
f_23101_10576_10614(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10576, 10614);
return 0;
}


int
f_23101_10629_10669(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10629, 10669);
return 0;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_10700_10790(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10700, 10790);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_10819_10909(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10819, 10909);
return return_v;
}


int
f_23101_10924_10962(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10924, 10962);
return 0;
}


int
f_23101_10977_11017(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 10977, 11017);
return 0;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_11048_11140(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11048, 11140);
return return_v;
}


(System.Collections.Immutable.ImmutableArray<byte> pe, System.Collections.Immutable.ImmutableArray<byte> pdb)
f_23101_11169_11261(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string
source,Microsoft.CodeAnalysis.Platform
platform,Microsoft.CodeAnalysis.Emit.DebugInformationFormat
pdbFormat,bool
optimize)
{
var return_v = this_param.EmitDeterministic( source, platform, pdbFormat, optimize:optimize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11169, 11261);
return return_v;
}


int
f_23101_11276_11314(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11276, 11314);
return 0;
}


int
f_23101_11329_11369(System.Collections.Immutable.ImmutableArray<byte>
expected,System.Collections.Immutable.ImmutableArray<byte>
actual)
{
AssertEx.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11329, 11369);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,9863,11381);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,9863,11381);
}
		}

[Fact]
        public void TestWriteOnlyStream()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,11393,12027);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11467,11549);

var 
tree = f_23101_11478_11548("class Program { static void Main() { } }")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11563,11928);

var 
compilation = f_23101_11581_11927("Program", new[] { tree }, new[] { f_23101_11753_11822(f_23101_11798_11821(typeof(object)))}, f_23101_11882_11926(                                                       TestOptions.DebugExe, true))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11942,11977);

var 
output = f_23101_11955_11976()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,11991,12016);

f_23101_11991_12015(            compilation, output);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,11393,12027);

Microsoft.CodeAnalysis.SyntaxTree
f_23101_11478_11548(string
text)
{
var return_v = CSharpSyntaxTree.ParseText( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11478, 11548);
return return_v;
}


System.Reflection.Assembly
f_23101_11798_11821(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 11798, 11821);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23101_11753_11822(System.Reflection.Assembly
assembly)
{
var return_v = MetadataReference.CreateFromAssemblyInternal( assembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11753, 11822);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23101_11882_11926(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,bool
deterministic)
{
var return_v = this_param.WithDeterministic( deterministic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11882, 11926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_11581_11927(string
assemblyName,Microsoft.CodeAnalysis.SyntaxTree[]
syntaxTrees,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11581, 11927);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests.WriteOnlyStream
f_23101_11955_11976()
{
var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests.WriteOnlyStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11955, 11976);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23101_11991_12015(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests.WriteOnlyStream
peStream)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 11991, 12015);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,11393,12027);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,11393,12027);
}
		}

[Fact, WorkItem(11990, "https://github.com/dotnet/roslyn/issues/11990")]
        public void ForwardedTypesAreEmittedInADeterministicOrder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,12039,16517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,12205,12736);

var 
forwardedToCode = @"
namespace Namespace2 {
    public class GenericType1<T> {}
    public class GenericType3<T> {}
    public class GenericType2<T> {}
}
namespace Namespace1 {
    public class Type3 {}
    public class Type2 {}
    public class Type1 {}
}
namespace Namespace4 {
    namespace Embedded {
        public class Type2 {}
        public class Type1 {}
    }
}
namespace Namespace3 {
    public class GenericType {}
    public class GenericType<T> {}
    public class GenericType<T, U> {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,12750,12844);

var 
forwardedToCompilation1 = f_23101_12780_12843(forwardedToCode, assemblyName: "ForwardedTo")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,12858,12942);

var 
forwardedToReference1 = f_23101_12886_12941(forwardedToCompilation1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,12958,13717);

var 
forwardingCode = @"
using System.Runtime.CompilerServices;
[assembly: TypeForwardedTo(typeof(Namespace2.GenericType1<int>))]
[assembly: TypeForwardedTo(typeof(Namespace2.GenericType3<int>))]
[assembly: TypeForwardedTo(typeof(Namespace2.GenericType2<int>))]
[assembly: TypeForwardedTo(typeof(Namespace1.Type3))]
[assembly: TypeForwardedTo(typeof(Namespace1.Type2))]
[assembly: TypeForwardedTo(typeof(Namespace1.Type1))]
[assembly: TypeForwardedTo(typeof(Namespace4.Embedded.Type2))]
[assembly: TypeForwardedTo(typeof(Namespace4.Embedded.Type1))]
[assembly: TypeForwardedTo(typeof(Namespace3.GenericType))]
[assembly: TypeForwardedTo(typeof(Namespace3.GenericType<int>))]
[assembly: TypeForwardedTo(typeof(Namespace3.GenericType<int, int>))]
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,13733,13846);

var 
forwardingCompilation = f_23101_13761_13845(forwardingCode, new MetadataReference[] { forwardedToReference1 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,13860,13940);

var 
forwardingReference = f_23101_13886_13939(forwardingCompilation)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,13956,14494);

var 
sortedFullNames = new string[]
            {
                "Namespace1.Type1",
                "Namespace1.Type2",
                "Namespace1.Type3",
                "Namespace2.GenericType1`1",
                "Namespace2.GenericType2`1",
                "Namespace2.GenericType3`1",
                "Namespace3.GenericType",
                "Namespace3.GenericType`1",
                "Namespace3.GenericType`2",
                "Namespace4.Embedded.Type1",
                "Namespace4.Embedded.Type2"
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,14510,14734);

Action<ModuleSymbol> 
metadataValidator = module =>
            {
                var assembly = module.ContainingAssembly;
                Assert.Equal(sortedFullNames, getNamesOfForwardedTypes(assembly));
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,14750,14898);

f_23101_14750_14897(this, forwardingCompilation, symbolValidator: metadataValidator, sourceSymbolValidator: metadataValidator, verify: Verification.Skipped);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,14914,15300);
using(var 
stream = f_23101_14934_14970(forwardingCompilation)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15004,15285);
using(var 
block = f_23101_15023_15062(stream)
)                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15104,15195);

var 
metadataFullNames = f_23101_15128_15194(f_23101_15173_15193(block))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15217,15266);

f_23101_15217_15265(sortedFullNames, metadataFullNames);
DynAbs.Tracing.TraceSender.TraceExitUsing(23101,15004,15285);
                }
DynAbs.Tracing.TraceSender.TraceExitUsing(23101,14914,15300);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15316,15410);

var 
forwardedToCompilation2 = f_23101_15346_15409(forwardedToCode, assemblyName: "ForwardedTo")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15424,15508);

var 
forwardedToReference2 = f_23101_15452_15507(forwardedToCompilation2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15524,15640);

var 
withRetargeting = f_23101_15546_15639("", new MetadataReference[] { forwardedToReference2, forwardingReference })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15656,15766);

var 
retargeting = (RetargetingAssemblySymbol)f_23101_15701_15765(withRetargeting, forwardingReference)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15780,15849);

f_23101_15780_15848(sortedFullNames, f_23101_15810_15847(retargeting));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15865,16054);
foreach(var type in f_23101_15886_15916_I(f_23101_15886_15916(retargeting)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(23101,15865,16054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,15950,16039);

f_23101_15950_16038(f_23101_15962_16012(f_23101_15962_15994(forwardedToCompilation2)), f_23101_16014_16037(type));
DynAbs.Tracing.TraceSender.TraceExitCondition(23101,15865,16054);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23101,1,190);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23101,1,190);
}
static IEnumerable<string> getNamesOfForwardedTypes(AssemblySymbol assembly)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23101,16070,16306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,16179,16291);

return f_23101_16186_16213(assembly).Select(t => t.ToDisplayString(SymbolDisplayFormat.QualifiedNameArityFormat));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23101,16070,16306);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
f_23101_16186_16213(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
assembly)
{
var return_v = getForwardedTypes( assembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 16186, 16213);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,16070,16306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,16070,16306);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ImmutableArray<INamedTypeSymbol> getForwardedTypes(AssemblySymbol assembly)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23101,16322,16506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,16437,16491);

return f_23101_16444_16490(f_23101_16444_16470(assembly));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23101,16322,16506);

Microsoft.CodeAnalysis.IAssemblySymbol?
f_23101_16444_16470(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 16444, 16470);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
f_23101_16444_16490(Microsoft.CodeAnalysis.IAssemblySymbol
this_param)
{
var return_v = this_param.GetForwardedTypes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 16444, 16490);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,16322,16506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,16322,16506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,12039,16517);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_12780_12843(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 12780, 12843);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23101_12886_12941(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 12886, 12941);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_13761_13845(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 13761, 13845);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23101_13886_13939(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 13886, 13939);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23101_14750_14897(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator, sourceSymbolValidator:sourceSymbolValidator, verify:verify);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 14750, 14897);
return return_v;
}


System.IO.MemoryStream
f_23101_14934_14970(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 14934, 14970);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23101_15023_15062(System.IO.MemoryStream
peStream)
{
var return_v = ModuleMetadata.CreateFromStream( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15023, 15062);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_23101_15173_15193(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.MetadataReader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 15173, 15193);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_23101_15128_15194(System.Reflection.Metadata.MetadataReader
metadataReader)
{
var return_v = MetadataValidation.GetExportedTypesFullNames( metadataReader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15128, 15194);
return return_v;
}


int
f_23101_15217_15265(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
Assert.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15217, 15265);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_15346_15409(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15346, 15409);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23101_15452_15507(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15452, 15507);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23101_15546_15639(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15546, 15639);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_23101_15701_15765(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
reference)
{
var return_v = compilation.GetReferencedAssemblySymbol( (Microsoft.CodeAnalysis.MetadataReference)reference);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15701, 15765);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_23101_15810_15847(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
assembly)
{
var return_v = getNamesOfForwardedTypes( (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15810, 15847);
return return_v;
}


int
f_23101_15780_15848(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
Assert.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15780, 15848);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
f_23101_15886_15916(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
assembly)
{
var return_v = getForwardedTypes( (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)assembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15886, 15916);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_23101_15962_15994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 15962, 15994);
return return_v;
}


Microsoft.CodeAnalysis.IAssemblySymbol?
f_23101_15962_16012(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15962, 16012);
return return_v;
}


Microsoft.CodeAnalysis.IAssemblySymbol
f_23101_16014_16037(Microsoft.CodeAnalysis.INamedTypeSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 16014, 16037);
return return_v;
}


int
f_23101_15950_16038(Microsoft.CodeAnalysis.IAssemblySymbol
expected,Microsoft.CodeAnalysis.IAssemblySymbol
actual)
{
Assert.Same( (object)expected, (object)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15950, 16038);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
f_23101_15886_15916_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 15886, 15916);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,12039,16517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,12039,16517);
}
		}

[ConditionalFact(typeof(ClrOnly), Reason = "Static execution is runtime defined and this tests Clr behavior only")]
        public void TestPartialPartsDeterministic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,16529,18547);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,16722,16821);

var 
x1 =
@"partial class Partial : I1
{
    public static int a = D.Init(1, ""Partial.a"");
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,16835,17036);

var 
x2 =
@"partial class Partial : I2
{
    public static int c, b = D.Init(2, ""Partial.b"");
    static Partial()
    {
                c = D.Init(3, ""Partial.c"");
            }
        }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,17050,17635);

var 
x3 =
@"class D
{
    public static void Main(string[] args)
    {
        foreach (var i in typeof(Partial).GetInterfaces())
        {
            System.Console.WriteLine(i.Name);
        }
        System.Console.WriteLine($""Partial.a = {Partial.a}"");
        System.Console.WriteLine($""Partial.b = {Partial.b}"");
        System.Console.WriteLine($""Partial.c = {Partial.c}"");
    }
    public static int Init(int value, string message)
    {
        System.Console.WriteLine(message);
        return value;
    }
}

interface I1 { }
interface I2 { }
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,17649,17760);

var 
expectedOutput1 =
@"I1
I2
Partial.a
Partial.b
Partial.c
Partial.a = 1
Partial.b = 2
Partial.c = 3"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,17774,17885);

var 
expectedOutput2 =
@"I2
I1
Partial.b
Partial.a
Partial.c
Partial.a = 1
Partial.b = 2
Partial.c = 3"
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18014,18019);
            // we run more than once to increase the chance of observing a problem due to nondeterminism
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18005,18536) || true) && (i < 2)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18028,18031)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23101,18005,18536))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23101,18005,18536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18065,18161);

var 
cv = f_23101_18074_18160(this, source: new string[] { x1, x2, x3 }, expectedOutput: expectedOutput1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18179,18228);

var 
trees = f_23101_18191_18227(f_23101_18191_18217(f_23101_18191_18205(cv)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18246,18341);

var 
comp2 = f_23101_18258_18340(f_23101_18258_18295(f_23101_18258_18272(cv)), trees[1], trees[0], trees[2])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18359,18416);

f_23101_18359_18415(this, comp2, expectedOutput: expectedOutput2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18434,18521);

f_23101_18434_18520(this, source: new string[] { x2, x1, x3 }, expectedOutput: expectedOutput2);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23101,1,532);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23101,1,532);
}DynAbs.Tracing.TraceSender.TraceExitMethod(23101,16529,18547);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23101_18074_18160(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string[]
source,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18074, 18160);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23101_18191_18205(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 18191, 18205);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
f_23101_18191_18217(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.SyntaxTrees;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 18191, 18217);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTree[]
f_23101_18191_18227(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.SyntaxTree>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18191, 18227);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23101_18258_18272(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23101, 18258, 18272);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23101_18258_18295(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.RemoveAllSyntaxTrees();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18258, 18295);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23101_18258_18340(Microsoft.CodeAnalysis.Compilation
this_param,params Microsoft.CodeAnalysis.SyntaxTree[]
trees)
{
var return_v = this_param.AddSyntaxTrees( trees);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18258, 18340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23101_18359_18415(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,Microsoft.CodeAnalysis.Compilation
compilation,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( compilation, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18359, 18415);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23101_18434_18520(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.DeterministicTests
this_param,string[]
source,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 18434, 18520);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,16529,18547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,16529,18547);
}
		}
private class WriteOnlyStream : Stream
{
private int _length;

public override bool CanRead {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,18687,18708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18693,18706);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,18687,18708);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18656,18710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18656,18710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanSeek {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,18755,18776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18761,18774);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,18755,18776);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18724,18778);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18724,18778);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool CanWrite {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,18824,18844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18830,18842);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,18824,18844);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18792,18846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18792,18846);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override long Length {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,18890,18913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18896,18911);

return _length;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,18890,18913);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18860,18915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18860,18915);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override long Position
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,18991,19014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18997,19012);

return _length;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,18991,19014);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18929,19089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18929,19089);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
set 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19032,19074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,19038,19072);

throw f_23101_19044_19071();
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19032,19074);

System.NotSupportedException
f_23101_19044_19071()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 19044, 19071);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,18929,19089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18929,19089);
}
		}}

public override void Flush() 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19103,19135);
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19103,19135);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,19103,19135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,19103,19135);
}
		}

public override int Read(byte[] buffer, int offset, int count) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19149,19250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,19214,19248);

throw f_23101_19220_19247();
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19149,19250);

System.NotSupportedException
f_23101_19220_19247()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 19220, 19247);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,19149,19250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,19149,19250);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override long Seek(long offset, SeekOrigin origin) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19264,19360);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,19324,19358);

throw f_23101_19330_19357();
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19264,19360);

System.NotSupportedException
f_23101_19330_19357()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 19330, 19357);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,19264,19360);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,19264,19360);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override void SetLength(long value) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19374,19455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,19419,19453);

throw f_23101_19425_19452();
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19374,19455);

System.NotSupportedException
f_23101_19425_19452()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23101, 19425, 19452);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,19374,19455);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,19374,19455);
}
		}

public override void Write(byte[] buffer, int offset, int count) 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(23101,19469,19555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,19536,19553);

_length += count;
DynAbs.Tracing.TraceSender.TraceExitMethod(23101,19469,19555);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23101,19469,19555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,19469,19555);
}
		}

public WriteOnlyStream()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23101,18559,19566);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,18634,18641);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23101,18559,19566);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18559,19566);
}


static WriteOnlyStream()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23101,18559,19566);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23101,18559,19566);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,18559,19566);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23101,18559,19566);
}

public DeterministicTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23101,772,19573);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23101,772,19573);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,772,19573);
}


static DeterministicTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23101,772,19573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23101,7854,8396);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23101,772,19573);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23101,772,19573);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23101,772,19573);
}
}
