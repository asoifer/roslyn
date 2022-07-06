// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Cci;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Xunit;

namespace Roslyn.Test.Utilities.PDB
{
internal static partial class DeterministicBuildCompilationTestHelpers
{
public static void VerifyPdbOption<T>(this ImmutableDictionary<string, string> pdbOptions, string pdbName, T expectedValue, Func<T, bool> isDefault = null, Func<T, string> toString = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,690,1328);
string actualValueString = default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,903,1036);

bool 
expectedIsDefault = (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 928, 947)||(((isDefault != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 950, 974))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 977, 1035)))?f_25124_950_974(isDefault, expectedValue):f_25124_977_1035(f_25124_977_1004(), expectedValue, default)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1050,1175);

var 
expectedValueString = (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 1076, 1093)||((expectedIsDefault &&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 1096, 1100))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 1103, 1174)))?null :(DynAbs.Tracing.TraceSender.Conditional_F1(25124, 1103, 1121)||(((toString != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 1124, 1147))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 1150, 1174)))?f_25124_1124_1147(toString, expectedValue):f_25124_1150_1174(expectedValue)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1191,1250);

f_25124_1191_1249(
            pdbOptions, pdbName, out actualValueString);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1264,1317);

f_25124_1264_1316(expectedValueString, actualValueString);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,690,1328);

bool
f_25124_950_974(System.Func<T, bool>
this_param,T
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 950, 974);
return return_v;
}


System.Collections.Generic.EqualityComparer<T>
f_25124_977_1004()
{
var return_v = EqualityComparer<T>.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 977, 1004);
return return_v;
}


bool
f_25124_977_1035(System.Collections.Generic.EqualityComparer<T>
this_param,T
x,T?
y)
{
var return_v = this_param.Equals( x, y);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 977, 1035);
return return_v;
}


string
f_25124_1124_1147(System.Func<T, string>
this_param,T
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1124, 1147);
return return_v;
}


string?
f_25124_1150_1174(T
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1150, 1174);
return return_v;
}


bool
f_25124_1191_1249(System.Collections.Immutable.ImmutableDictionary<string, string>
this_param,string
key,out string
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1191, 1249);
return return_v;
}


int
f_25124_1264_1316(string?
expected,string?
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1264, 1316);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,690,1328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,690,1328);
}
		}

public static IEnumerable<EmitOptions> GetEmitOptions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,1340,2049);

var listYield= new List<EmitOptions>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1420,1654);

var 
emitOptions = f_25124_1438_1653(debugInformationFormat: DebugInformationFormat.Embedded, pdbChecksumAlgorithm: HashAlgorithmName.SHA256, defaultSourceFileEncoding: f_25124_1638_1652())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1670,1695);

listYield.Add(emitOptions);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1709,1780);

listYield.Add(f_25124_1722_1779(emitOptions, f_25124_1764_1778()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1794,1904);

listYield.Add(f_25124_1807_1903(f_25124_1807_1854(emitOptions, null), f_25124_1886_1902()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,1918,2038);

listYield.Add(f_25124_1931_2037(f_25124_1931_1991(emitOptions, f_25124_1974_1990()), f_25124_2022_2036()));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,1340,2049);

return listYield;

System.Text.Encoding
f_25124_1638_1652()
{
var return_v = Encoding.UTF32;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 1638, 1652);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1438_1653(Microsoft.CodeAnalysis.Emit.DebugInformationFormat
debugInformationFormat,System.Security.Cryptography.HashAlgorithmName
pdbChecksumAlgorithm,System.Text.Encoding
defaultSourceFileEncoding)
{
var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions( debugInformationFormat: debugInformationFormat, pdbChecksumAlgorithm: (System.Security.Cryptography.HashAlgorithmName?)pdbChecksumAlgorithm, defaultSourceFileEncoding: defaultSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1438, 1653);
return return_v;
}


System.Text.Encoding
f_25124_1764_1778()
{
var return_v = Encoding.ASCII;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 1764, 1778);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1722_1779(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Text.Encoding
defaultSourceFileEncoding)
{
var return_v = this_param.WithDefaultSourceFileEncoding( defaultSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1722, 1779);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1807_1854(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Text.Encoding?
defaultSourceFileEncoding)
{
var return_v = this_param.WithDefaultSourceFileEncoding( defaultSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1807, 1854);
return return_v;
}


System.Text.Encoding
f_25124_1886_1902()
{
var return_v = Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 1886, 1902);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1807_1903(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Text.Encoding
fallbackSourceFileEncoding)
{
var return_v = this_param.WithFallbackSourceFileEncoding( fallbackSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1807, 1903);
return return_v;
}


System.Text.Encoding
f_25124_1974_1990()
{
var return_v = Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 1974, 1990);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1931_1991(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Text.Encoding
fallbackSourceFileEncoding)
{
var return_v = this_param.WithFallbackSourceFileEncoding( fallbackSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1931, 1991);
return return_v;
}


System.Text.Encoding
f_25124_2022_2036()
{
var return_v = Encoding.ASCII;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 2022, 2036);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25124_1931_2037(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Text.Encoding
defaultSourceFileEncoding)
{
var return_v = this_param.WithDefaultSourceFileEncoding( defaultSourceFileEncoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 1931, 2037);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,1340,2049);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,1340,2049);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void AssertCommonOptions(EmitOptions emitOptions, CompilationOptions compilationOptions, Compilation compilation, ImmutableDictionary<string, string> pdbOptions)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,2061,3958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2263,2349);

f_25124_2263_2348(            pdbOptions, "version", MetadataWriter.CompilationOptionsSchemaVersion);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2363,2477);

f_25124_2363_2476(            pdbOptions, "fallback-encoding", f_25124_2411_2449(emitOptions), toString: v => v.WebName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2491,2603);

f_25124_2491_2602(            pdbOptions, "default-encoding", f_25124_2538_2575(emitOptions), toString: v => v.WebName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2619,2645);

int 
portabilityPolicy = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2659,3055) || true) && (f_25124_2663_2706(compilationOptions)is DesktopAssemblyIdentityComparer identityComparer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,2659,3055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2792,2906);

portabilityPolicy |= (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 2813, 2895)||((identityComparer.PortabilityPolicy.SuppressSilverlightLibraryAssembliesPortability &&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 2898, 2901))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 2904, 2905)))?0b1 :0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,2924,3040);

portabilityPolicy |= (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 2945, 3028)||((identityComparer.PortabilityPolicy.SuppressSilverlightPlatformAssembliesPortability &&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 3031, 3035))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 3038, 3039)))?0b10 :0;
DynAbs.Tracing.TraceSender.TraceExitCondition(25124,2659,3055);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3071,3139);

f_25124_3071_3138(
            pdbOptions, "portability-policy", portabilityPolicy);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3155,3288);

var 
compilerVersion = f_25124_3177_3287_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25124_3177_3265(f_25124_3177_3205(typeof(Compilation))), 25124, 3177, 3287)?.InformationalVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3302,3375);

f_25124_3302_3374(f_25124_3315_3341(compilerVersion), f_25124_3343_3373(pdbOptions, "compiler-version"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3391,3518);

var 
runtimeVersion = f_25124_3412_3517_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_25124_3412_3495(f_25124_3412_3435(typeof(object))), 25124, 3412, 3517)?.InformationalVersion)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3532,3612);

f_25124_3532_3611(runtimeVersion, f_25124_3561_3610(pdbOptions, CompilationOptionNames.RuntimeVersion));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3628,3872);

f_25124_3628_3871(
            pdbOptions, "optimization", (f_25124_3707_3743(compilationOptions), f_25124_3745_3777(compilationOptions)), toString: v => v.OptimizationLevel.ToPdbSerializedString(v.DebugPlusMode));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,3888,3947);

f_25124_3888_3946(f_25124_3901_3921(compilation), f_25124_3923_3945(pdbOptions, "language"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,2061,3958);

int
f_25124_2263_2348(System.Collections.Immutable.ImmutableDictionary<string, string>
pdbOptions,string
pdbName,int
expectedValue)
{
pdbOptions.VerifyPdbOption<int>( pdbName, expectedValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 2263, 2348);
return 0;
}


System.Text.Encoding?
f_25124_2411_2449(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param)
{
var return_v = this_param.FallbackSourceFileEncoding;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 2411, 2449);
return return_v;
}


int
f_25124_2363_2476(System.Collections.Immutable.ImmutableDictionary<string, string>
pdbOptions,string
pdbName,System.Text.Encoding?
expectedValue,System.Func<System.Text.Encoding, string>
toString)
{
pdbOptions.VerifyPdbOption<System.Text.Encoding?>( pdbName, expectedValue, toString: toString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 2363, 2476);
return 0;
}


System.Text.Encoding?
f_25124_2538_2575(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param)
{
var return_v = this_param.DefaultSourceFileEncoding;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 2538, 2575);
return return_v;
}


int
f_25124_2491_2602(System.Collections.Immutable.ImmutableDictionary<string, string>
pdbOptions,string
pdbName,System.Text.Encoding?
expectedValue,System.Func<System.Text.Encoding, string>
toString)
{
pdbOptions.VerifyPdbOption<System.Text.Encoding?>( pdbName, expectedValue, toString: toString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 2491, 2602);
return 0;
}


Microsoft.CodeAnalysis.AssemblyIdentityComparer
f_25124_2663_2706(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.AssemblyIdentityComparer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 2663, 2706);
return return_v;
}


int
f_25124_3071_3138(System.Collections.Immutable.ImmutableDictionary<string, string>
pdbOptions,string
pdbName,int
expectedValue)
{
pdbOptions.VerifyPdbOption<int>( pdbName, expectedValue);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3071, 3138);
return 0;
}


System.Reflection.Assembly
f_25124_3177_3205(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3177, 3205);
return return_v;
}


System.Reflection.AssemblyInformationalVersionAttribute?
f_25124_3177_3265(System.Reflection.Assembly
element)
{
var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3177, 3265);
return return_v;
}


string?
f_25124_3177_3287_M(string?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3177, 3287);
return return_v;
}


string
f_25124_3315_3341(string?
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3315, 3341);
return return_v;
}


string
f_25124_3343_3373(System.Collections.Immutable.ImmutableDictionary<string, string>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3343, 3373);
return return_v;
}


int
f_25124_3302_3374(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3302, 3374);
return 0;
}


System.Reflection.Assembly
f_25124_3412_3435(System.Type
this_param)
{
var return_v = this_param.Assembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3412, 3435);
return return_v;
}


System.Reflection.AssemblyInformationalVersionAttribute?
f_25124_3412_3495(System.Reflection.Assembly
element)
{
var return_v = element.GetCustomAttribute<System.Reflection.AssemblyInformationalVersionAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3412, 3495);
return return_v;
}


string?
f_25124_3412_3517_M(string?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3412, 3517);
return return_v;
}


string
f_25124_3561_3610(System.Collections.Immutable.ImmutableDictionary<string, string>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3561, 3610);
return return_v;
}


int
f_25124_3532_3611(string?
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3532, 3611);
return 0;
}


Microsoft.CodeAnalysis.OptimizationLevel
f_25124_3707_3743(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.OptimizationLevel;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3707, 3743);
return return_v;
}


bool
f_25124_3745_3777(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.DebugPlusMode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3745, 3777);
return return_v;
}


int
f_25124_3628_3871(System.Collections.Immutable.ImmutableDictionary<string, string>
pdbOptions,string
pdbName,(Microsoft.CodeAnalysis.OptimizationLevel OptimizationLevel, bool DebugPlusMode)
expectedValue,System.Func<(Microsoft.CodeAnalysis.OptimizationLevel OptimizationLevel, bool DebugPlusMode), string>
toString)
{
pdbOptions.VerifyPdbOption<(Microsoft.CodeAnalysis.OptimizationLevel OptimizationLevel, bool DebugPlusMode)>( pdbName, expectedValue, toString: toString);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3628, 3871);
return 0;
}


string
f_25124_3901_3921(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.Language;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3901, 3921);
return return_v;
}


string
f_25124_3923_3945(System.Collections.Immutable.ImmutableDictionary<string, string>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25124, 3923, 3945);
return return_v;
}


int
f_25124_3888_3946(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 3888, 3946);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,2061,3958);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,2061,3958);
}
		}

public static void VerifyReferenceInfo(TestMetadataReferenceInfo[] references, BlobReader metadataReferenceReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,3970,4511);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4109,4381);
foreach(var reference in f_25124_4135_4145_I(references) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,4109,4381);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4179,4246);

var 
info = f_25124_4190_4245(ref metadataReferenceReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4264,4315);

var 
originalInfo = reference.MetadataReferenceInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4335,4366);

originalInfo.AssertEqual(info);
DynAbs.Tracing.TraceSender.TraceExitCondition(25124,4109,4381);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25124,1,273);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25124,1,273);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4444,4500);

f_25124_4444_4499(0, metadataReferenceReader.RemainingBytes);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,3970,4511);

Roslyn.Test.Utilities.PDB.MetadataReferenceInfo
f_25124_4190_4245(ref System.Reflection.Metadata.BlobReader
blobReader)
{
var return_v = ParseMetadataReferenceInfo( ref blobReader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 4190, 4245);
return return_v;
}


Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
f_25124_4135_4145_I(Roslyn.Test.Utilities.PDB.TestMetadataReferenceInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 4135, 4145);
return return_v;
}


int
f_25124_4444_4499(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 4444, 4499);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,3970,4511);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,3970,4511);
}
		}

public static BlobReader GetSingleBlob(Guid infoGuid, MetadataReader pdbReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,4523,4949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,4627,4938);

return f_25124_4634_4937((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from cdiHandle in pdbReader.GetCustomDebugInformation(EntityHandle.ModuleDefinition)
                    let cdi = pdbReader.GetCustomDebugInformation(cdiHandle)
                    where pdbReader.GetGuid(cdi.Kind) == infoGuid
                    select pdbReader.GetBlobReader(cdi.Value),25124,4635,4927)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,4523,4949);

System.Reflection.Metadata.BlobReader
f_25124_4634_4937(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.BlobReader>
source)
{
var return_v = source.Single<System.Reflection.Metadata.BlobReader>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 4634, 4937);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,4523,4949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,4523,4949);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static MetadataReferenceInfo ParseMetadataReferenceInfo(ref BlobReader blobReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,4961,6759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5449,5493);

var 
terminatorIndex = blobReader.IndexOf(0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5507,5544);

f_25124_5507_5543(-1, terminatorIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5560,5608);

var 
name = blobReader.ReadUTF8(terminatorIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5665,5687);

blobReader.ReadByte();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5703,5743);

terminatorIndex = blobReader.IndexOf(0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5757,5794);

f_25124_5757_5793(-1, terminatorIndex);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5810,5867);

var 
externAliases = blobReader.ReadUTF8(terminatorIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5883,5905);

blobReader.ReadByte();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5921,5974);

var 
embedInteropTypesAndKind = blobReader.ReadByte()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,5988,6054);

var 
embedInteropTypes = (embedInteropTypesAndKind & 0b10) == 0b10
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6068,6209);

var 
kind = (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 6079, 6118)||(((embedInteropTypesAndKind & 0b1) == 0b1
&&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 6138, 6164))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 6184, 6208)))?MetadataImageKind.Assembly
:MetadataImageKind.Module
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6225,6264);

var 
timestamp = blobReader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6278,6317);

var 
imageSize = blobReader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6331,6364);

var 
mvid = blobReader.ReadGuid()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6380,6748);

return f_25124_6387_6747(timestamp, imageSize, name, mvid, (DynAbs.Tracing.TraceSender.Conditional_F1(25124, 6533, 6568)||((f_25124_6533_6568(externAliases)&&DynAbs.Tracing.TraceSender.Conditional_F2(25124, 6592, 6620))||DynAbs.Tracing.TraceSender.Conditional_F3(25124, 6644, 6687)))?ImmutableArray<string>.Empty
:f_25124_6644_6687(f_25124_6644_6668(externAliases, ',')), kind, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,4961,6759);

int
f_25124_5507_5543(int
expected,int
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 5507, 5543);
return 0;
}


int
f_25124_5757_5793(int
expected,int
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 5757, 5793);
return 0;
}


bool
f_25124_6533_6568(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 6533, 6568);
return return_v;
}


string[]
f_25124_6644_6668(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 6644, 6668);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_25124_6644_6687(string[]
items)
{
var return_v = items.ToImmutableArray<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 6644, 6687);
return return_v;
}


Roslyn.Test.Utilities.PDB.MetadataReferenceInfo
f_25124_6387_6747(int
timestamp,int
imageSize,string
name,System.Guid
mvid,System.Collections.Immutable.ImmutableArray<string>
externAliases,Microsoft.CodeAnalysis.MetadataImageKind
kind,bool
embedInteropTypes)
{
var return_v = new Roslyn.Test.Utilities.PDB.MetadataReferenceInfo( timestamp, imageSize, name, mvid, externAliases, kind, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 6387, 6747);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,4961,6759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,4961,6759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static ImmutableDictionary<string, string> ParseCompilationOptions(BlobReader blobReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25124,6771,7824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,6972,6990);

string 
key = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7004,7070);

Dictionary<string, string> 
kvp = f_25124_7037_7069()
;
try {            for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7084,7674) || true) && (true)
; DynAbs.Tracing.TraceSender.TraceExitCondition(25124,7084,7674))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,7084,7674);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7127,7165);

var 
nullIndex = blobReader.IndexOf(0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7183,7269) || true) && (nullIndex == -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,7183,7269);
DynAbs.Tracing.TraceSender.TraceBreak(25124,7244,7250);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25124,7183,7269);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7289,7332);

var 
value = blobReader.ReadUTF8(nullIndex)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7397,7419);

blobReader.ReadByte();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7439,7659) || true) && (key is null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,7439,7659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7496,7508);

key = value;
DynAbs.Tracing.TraceSender.TraceExitCondition(25124,7439,7659);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25124,7439,7659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7590,7607);

kvp[key] = value;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7629,7640);

key = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25124,7439,7659);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25124,1,591);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25124,1,591);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7690,7707);

f_25124_7690_7706(key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7721,7764);

f_25124_7721_7763(0, blobReader.RemainingBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25124,7778,7813);

return f_25124_7785_7812(kvp);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25124,6771,7824);

System.Collections.Generic.Dictionary<string, string>
f_25124_7037_7069()
{
var return_v = new System.Collections.Generic.Dictionary<string, string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 7037, 7069);
return return_v;
}


int
f_25124_7690_7706(string?
@object)
{
Assert.Null( (object?)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 7690, 7706);
return 0;
}


int
f_25124_7721_7763(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 7721, 7763);
return 0;
}


System.Collections.Immutable.ImmutableDictionary<string, string>
f_25124_7785_7812(System.Collections.Generic.Dictionary<string, string>
source)
{
var return_v = source.ToImmutableDictionary<string,string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25124, 7785, 7812);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25124,6771,7824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,6771,7824);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DeterministicBuildCompilationTestHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25124,603,7831);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25124,603,7831);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25124,603,7831);
}

}
}
