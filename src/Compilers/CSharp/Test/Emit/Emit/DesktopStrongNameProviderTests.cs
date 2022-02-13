// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using static Roslyn.Test.Utilities.SigningTestHelpers;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
public partial class DesktopStrongNameProviderTests : CSharpTestBase
{
[WorkItem(13995, "https://github.com/dotnet/roslyn/issues/13995")]
        [Fact]
        public void RespectCustomTempPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23100,582,941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,734,771);

var 
tempDir = f_23100_748_770(f_23100_748_752())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,785,854);

var 
provider = f_23100_800_853(tempPath: f_23100_840_852(tempDir))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,868,930);

f_23100_868_929(f_23100_881_893(tempDir), f_23100_895_928(f_23100_895_914(provider)));
DynAbs.Tracing.TraceSender.TraceExitMethod(23100,582,941);

Microsoft.CodeAnalysis.Test.Utilities.TempRoot
f_23100_748_752()
{
var return_v = Temp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 748, 752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
f_23100_748_770(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
var return_v = this_param.CreateDirectory();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 748, 770);
return return_v;
}


string
f_23100_840_852(Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 840, 852);
return return_v;
}


Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_23100_800_853(string
tempPath)
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider( tempPath:tempPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 800, 853);
return return_v;
}


string
f_23100_881_893(Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 881, 893);
return return_v;
}


Microsoft.CodeAnalysis.StrongNameFileSystem
f_23100_895_914(Microsoft.CodeAnalysis.DesktopStrongNameProvider
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 895, 914);
return return_v;
}


string
f_23100_895_928(Microsoft.CodeAnalysis.StrongNameFileSystem
this_param)
{
var return_v = this_param.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 895, 928);
return return_v;
}


int
f_23100_868_929(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 868, 929);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23100,582,941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,582,941);
}
		}

[Fact]
        public void RespectDefaultTempPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23100,953,1184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1030,1091);

var 
provider = f_23100_1045_1090(tempPath: null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1105,1173);

f_23100_1105_1172(f_23100_1118_1136(), f_23100_1138_1171(f_23100_1138_1157(provider)));
DynAbs.Tracing.TraceSender.TraceExitMethod(23100,953,1184);

Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_23100_1045_1090(string?
tempPath)
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider( tempPath:tempPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1045, 1090);
return return_v;
}


string
f_23100_1118_1136()
{
var return_v = Path.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1118, 1136);
return return_v;
}


Microsoft.CodeAnalysis.StrongNameFileSystem
f_23100_1138_1157(Microsoft.CodeAnalysis.DesktopStrongNameProvider
this_param)
{
var return_v = this_param.FileSystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 1138, 1157);
return return_v;
}


string
f_23100_1138_1171(Microsoft.CodeAnalysis.StrongNameFileSystem
this_param)
{
var return_v = this_param.GetTempPath();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1138, 1171);
return return_v;
}


int
f_23100_1105_1172(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1105, 1172);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23100,953,1184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,953,1184);
}
		}

[Fact]
        public void EmitWithCustomTempPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23100,1196,1852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1273,1353);

string 
src = @"
class C
{
    public static void Main(string[] args) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1367,1404);

var 
tempDir = f_23100_1381_1403(f_23100_1381_1385())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1418,1544);

var 
provider = f_23100_1433_1543(ImmutableArray<string>.Empty, f_23100_1493_1542(f_23100_1529_1541(tempDir)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1560,1732);

var 
options = f_23100_1574_1731(f_23100_1574_1663(TestOptions
                .DebugExe
, provider), SigningTestHelpers.KeyPairFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1746,1798);

var 
comp = f_23100_1757_1797(src, options: options)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1812,1841);

f_23100_1812_1840(            comp);
DynAbs.Tracing.TraceSender.TraceExitMethod(23100,1196,1852);

Microsoft.CodeAnalysis.Test.Utilities.TempRoot
f_23100_1381_1385()
{
var return_v = Temp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 1381, 1385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
f_23100_1381_1403(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
var return_v = this_param.CreateDirectory();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1381, 1403);
return return_v;
}


string
f_23100_1529_1541(Microsoft.CodeAnalysis.Test.Utilities.TempDirectory
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23100, 1529, 1541);
return return_v;
}


Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
f_23100_1493_1542(string
tempPath)
{
var return_v = new Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem( tempPath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1493, 1542);
return return_v;
}


Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_23100_1433_1543(System.Collections.Immutable.ImmutableArray<string>
keyFileSearchPaths,Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
strongNameFileSystem)
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider( keyFileSearchPaths, (Microsoft.CodeAnalysis.StrongNameFileSystem)strongNameFileSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1433, 1543);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23100_1574_1663(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.DesktopStrongNameProvider
provider)
{
var return_v = this_param.WithStrongNameProvider( (Microsoft.CodeAnalysis.StrongNameProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1574, 1663);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23100_1574_1731(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
path)
{
var return_v = this_param.WithCryptoKeyFile( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1574, 1731);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23100_1757_1797(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1757, 1797);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23100_1812_1840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 1812, 1840);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23100,1196,1852);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,1196,1852);
}
		}

[Fact]
        public void EmitWithDefaultTempPath()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23100,1864,2456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,1942,2022);

string 
src = @"
class C
{
    public static void Main(string[] args) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,2036,2150);

var 
provider = f_23100_2051_2149(ImmutableArray<string>.Empty, f_23100_2111_2148())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,2164,2336);

var 
options = f_23100_2178_2335(f_23100_2178_2267(TestOptions
                .DebugExe
, provider), SigningTestHelpers.KeyPairFile)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,2350,2402);

var 
comp = f_23100_2361_2401(src, options: options)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23100,2416,2445);

f_23100_2416_2444(            comp);
DynAbs.Tracing.TraceSender.TraceExitMethod(23100,1864,2456);

Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
f_23100_2111_2148()
{
var return_v = new Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2111, 2148);
return return_v;
}


Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_23100_2051_2149(System.Collections.Immutable.ImmutableArray<string>
keyFileSearchPaths,Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
strongNameFileSystem)
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider( keyFileSearchPaths, (Microsoft.CodeAnalysis.StrongNameFileSystem)strongNameFileSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2051, 2149);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23100_2178_2267(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.DesktopStrongNameProvider
provider)
{
var return_v = this_param.WithStrongNameProvider( (Microsoft.CodeAnalysis.StrongNameProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2178, 2267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23100_2178_2335(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,string
path)
{
var return_v = this_param.WithCryptoKeyFile( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2178, 2335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23100_2361_2401(string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2361, 2401);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23100_2416_2444(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23100, 2416, 2444);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23100,1864,2456);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,1864,2456);
}
		}

public DesktopStrongNameProviderTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23100,497,2463);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23100,497,2463);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,497,2463);
}


static DesktopStrongNameProviderTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23100,497,2463);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23100,497,2463);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23100,497,2463);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23100,497,2463);
}
}
