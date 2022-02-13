// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using System.Globalization;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class ResourceTests : CSharpTestBase
{
[DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, uint dwFlags);

[DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeLibrary([In] IntPtr hFile);

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionNeedsDesktopTypes)]
        public void DefaultVersionResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,1048,4824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1220,1313);

string 
source = @"
public class Maine
{
    public static void Main()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1327,1428);

var 
c1 = f_23120_1336_1427(source, assemblyName: "Win32VerNoAttrs", options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1442,1470);

var 
exe = f_23120_1452_1469(f_23120_1452_1456())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1486,1661);
using(FileStream 
output = f_23120_1513_1523(exe)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1557,1646);

f_23120_1557_1645(                c1, output, win32Resources: f_23120_1589_1644(c1, true, false, null, null));
DynAbs.Tracing.TraceSender.TraceExitUsing(23120,1486,1661);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1677,1687);

c1 = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1731,1756);

IntPtr 
lib = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1770,1789);

string 
versionData
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1803,1818);

string 
mftData
=default(string);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1868,1923);

lib = f_23120_1874_1922(f_23120_1888_1896(exe), IntPtr.Zero, 0x00000002);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1941,2040) || true) && (lib == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,1941,2040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,1986,2040);

throw f_23120_1992_2039(f_23120_2011_2038());
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,1941,2040);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2256,2266);

uint 
size
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2284,2354);

IntPtr 
versionRsrc = f_23120_2305_2353(lib, "#1", "#16", out size)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2372,2429);

versionData = f_23120_2386_2428(versionRsrc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2449,2462);

uint 
mftSize
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2480,2549);

IntPtr 
mftRsrc = f_23120_2497_2548(lib, "#1", "#24", out mftSize)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2567,2626);

mftData = f_23120_2577_2625(mftRsrc, mftSize);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(23120,2655,2810);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2695,2795) || true) && (lib != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,2695,2795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2759,2776);

f_23120_2759_2775(lib);
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,2695,2795);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(23120,2655,2810);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,2826,3521);

string 
expected =
@"<?xml version=""1.0"" encoding=""utf-16""?>
<VersionResource Size=""612"">
  <VS_FIXEDFILEINFO FileVersionMS=""00000000"" FileVersionLS=""00000000"" ProductVersionMS=""00000000"" ProductVersionLS=""00000000"" />
  <KeyValuePair Key=""FileDescription"" Value="" "" />
  <KeyValuePair Key=""FileVersion"" Value=""0.0.0.0"" />
  <KeyValuePair Key=""InternalName"" Value=""Win32VerNoAttrs.exe"" />
  <KeyValuePair Key=""LegalCopyright"" Value="" "" />
  <KeyValuePair Key=""OriginalFilename"" Value=""Win32VerNoAttrs.exe"" />
  <KeyValuePair Key=""ProductVersion"" Value=""0.0.0.0"" />
  <KeyValuePair Key=""Assembly Version"" Value=""0.0.0.0"" />
</VersionResource>"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,3537,3573);

f_23120_3537_3572(expected, versionData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,3589,4247);

expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<ManifestResource Size=""490"">
  <Contents><![CDATA[<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>

<assembly xmlns=""urn:schemas-microsoft-com:asm.v1"" manifestVersion=""1.0"">
  <assemblyIdentity version=""1.0.0.0"" name=""MyApplication.app""/>
  <trustInfo xmlns=""urn:schemas-microsoft-com:asm.v2"">
    <security>
      <requestedPrivileges xmlns=""urn:schemas-microsoft-com:asm.v3"">
        <requestedExecutionLevel level=""asInvoker"" uiAccess=""false""/>
      </requestedPrivileges>
    </security>
  </trustInfo>
</assembly>]]></Contents>
</ManifestResource>";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,4263,4295);

f_23120_4263_4294(expected, mftData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,4702,4757);

var 
fileVer = f_23120_4716_4756(f_23120_4747_4755(exe))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,4771,4813);

f_23120_4771_4812(" ", f_23120_4789_4811(fileVer));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,1048,4824);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_1336_1427(string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1336, 1427);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempRoot
f_23120_1452_1456()
{
var return_v = Temp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 1452, 1456);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempFile
f_23120_1452_1469(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
var return_v = this_param.CreateFile();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1452, 1469);
return return_v;
}


System.IO.FileStream
f_23120_1513_1523(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1513, 1523);
return return_v;
}


System.IO.Stream
f_23120_1589_1644(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
versionResource,bool
noManifest,System.IO.Stream?
manifestContents,System.IO.Stream?
iconInIcoFormat)
{
var return_v = this_param.CreateDefaultWin32Resources( versionResource, noManifest, manifestContents, iconInIcoFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1589, 1644);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_1557_1645(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.FileStream
peStream,System.IO.Stream
win32Resources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, win32Resources:win32Resources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1557, 1645);
return return_v;
}


string
f_23120_1888_1896(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 1888, 1896);
return return_v;
}


System.IntPtr
f_23120_1874_1922(string
lpFileName,System.IntPtr
hFile,int
dwFlags)
{
var return_v = LoadLibraryEx( lpFileName, hFile, (uint)dwFlags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1874, 1922);
return return_v;
}


int
f_23120_2011_2038()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2011, 2038);
return return_v;
}


System.ComponentModel.Win32Exception
f_23120_1992_2039(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 1992, 2039);
return return_v;
}


System.IntPtr
f_23120_2305_2353(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2305, 2353);
return return_v;
}


string
f_23120_2386_2428(System.IntPtr
versionRsrc)
{
var return_v = Win32Res.VersionResourceToXml( versionRsrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2386, 2428);
return return_v;
}


System.IntPtr
f_23120_2497_2548(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2497, 2548);
return return_v;
}


string
f_23120_2577_2625(System.IntPtr
mftRsrc,uint
size)
{
var return_v = Win32Res.ManifestResourceToXml( mftRsrc, size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2577, 2625);
return return_v;
}


bool
f_23120_2759_2775(System.IntPtr
hFile)
{
var return_v = FreeLibrary( hFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 2759, 2775);
return return_v;
}


int
f_23120_3537_3572(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 3537, 3572);
return 0;
}


int
f_23120_4263_4294(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 4263, 4294);
return 0;
}


string
f_23120_4747_4755(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 4747, 4755);
return return_v;
}


System.Diagnostics.FileVersionInfo
f_23120_4716_4756(string
fileName)
{
var return_v = FileVersionInfo.GetVersionInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 4716, 4756);
return return_v;
}


string
f_23120_4789_4811(System.Diagnostics.FileVersionInfo
this_param)
{
var return_v = this_param.LegalCopyright;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 4789, 4811);
return return_v;
}


int
f_23120_4771_4812(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 4771, 4812);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,1048,4824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,1048,4824);
}
		}

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionNeedsDesktopTypes)]
        public void ResourcesInCoff()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,4836,8708);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5092,5129);

string 
source = @"
class C
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5143,5242);

var 
c1 = f_23120_5152_5241(source, assemblyName: "Win32WithCoff", options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5256,5284);

var 
exe = f_23120_5266_5283(f_23120_5266_5270())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5300,5523);
using(FileStream 
output = f_23120_5327_5337(exe)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5371,5447);

var 
memStream = f_23120_5387_5446(f_23120_5404_5445())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5465,5508);

f_23120_5465_5507(                c1, output, win32Resources: memStream);
DynAbs.Tracing.TraceSender.TraceExitUsing(23120,5300,5523);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5539,5549);

c1 = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5593,5618);

IntPtr 
lib = IntPtr.Zero
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5632,5651);

string 
versionData
=default(string);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5701,5756);

lib = f_23120_5707_5755(f_23120_5721_5729(exe), IntPtr.Zero, 0x00000002);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5774,5873) || true) && (lib == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,5774,5873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,5819,5873);

throw f_23120_5825_5872(f_23120_5844_5871());
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,5774,5873);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6200,6210);

uint 
size
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6228,6298);

IntPtr 
versionRsrc = f_23120_6249_6297(lib, "#1", "#16", out size)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6316,6373);

versionData = f_23120_6330_6372(versionRsrc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6393,6414);

uint 
stringTableSize
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6432,6512);

IntPtr 
stringTable = f_23120_6453_6511(lib, "#1", "#6", out stringTableSize)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6530,6568);

f_23120_6530_6567(default, stringTable);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6588,6604);

uint 
elevenSize
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6622,6697);

IntPtr 
elevenRsrc = f_23120_6642_6696(lib, "#1", "#11", out elevenSize)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6715,6752);

f_23120_6715_6751(default, elevenRsrc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6772,6786);

uint 
wevtSize
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6804,6885);

IntPtr 
wevtRsrc = f_23120_6822_6884(lib, "#1", "WEVT_TEMPLATE", out wevtSize)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,6903,6938);

f_23120_6903_6937(default, wevtRsrc);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(23120,6967,7122);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,7007,7107) || true) && (lib != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,7007,7107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,7071,7088);

f_23120_7071_7087(lib);
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,7007,7107);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(23120,6967,7122);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,7138,8110);

string 
expected =
@"<?xml version=""1.0"" encoding=""utf-16""?>
<VersionResource Size=""1104"">
  <VS_FIXEDFILEINFO FileVersionMS=""000b0000"" FileVersionLS=""eacc0000"" ProductVersionMS=""000b0000"" ProductVersionLS=""eacc0000"" />
  <KeyValuePair Key=""CompanyName"" Value=""Microsoft Corporation"" />
  <KeyValuePair Key=""FileDescription"" Value=""Team Foundation Server Object Model"" />
  <KeyValuePair Key=""FileVersion"" Value=""11.0.60108.0 built by: TOOLSET_ROSLYN(GNAMBOO-DEV-GNAMBOO)"" />
  <KeyValuePair Key=""InternalName"" Value=""Microsoft.TeamFoundation.Framework.Server.dll"" />
  <KeyValuePair Key=""LegalCopyright"" Value=""© Microsoft Corporation. All rights reserved."" />
  <KeyValuePair Key=""OriginalFilename"" Value=""Microsoft.TeamFoundation.Framework.Server.dll"" />
  <KeyValuePair Key=""ProductName"" Value=""Microsoft® Visual Studio® 2012"" />
  <KeyValuePair Key=""ProductVersion"" Value=""11.0.60108.0"" />
</VersionResource>"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,8126,8162);

f_23120_8126_8161(expected, versionData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,8569,8624);

var 
fileVer = f_23120_8583_8623(f_23120_8614_8622(exe))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,8638,8697);

f_23120_8638_8696("Microsoft Corporation", f_23120_8676_8695(fileVer));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,4836,8708);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_5152_5241(string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5152, 5241);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempRoot
f_23120_5266_5270()
{
var return_v = Temp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 5266, 5270);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempFile
f_23120_5266_5283(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
var return_v = this_param.CreateFile();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5266, 5283);
return return_v;
}


System.IO.FileStream
f_23120_5327_5337(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5327, 5337);
return return_v;
}


byte[]
f_23120_5404_5445()
{
var return_v = TestResources.General.nativeCOFFResources;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 5404, 5445);
return return_v;
}


System.IO.MemoryStream
f_23120_5387_5446(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5387, 5446);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_5465_5507(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.FileStream
peStream,System.IO.MemoryStream
win32Resources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, win32Resources:(System.IO.Stream)win32Resources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5465, 5507);
return return_v;
}


string
f_23120_5721_5729(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 5721, 5729);
return return_v;
}


System.IntPtr
f_23120_5707_5755(string
lpFileName,System.IntPtr
hFile,int
dwFlags)
{
var return_v = LoadLibraryEx( lpFileName, hFile, (uint)dwFlags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5707, 5755);
return return_v;
}


int
f_23120_5844_5871()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5844, 5871);
return return_v;
}


System.ComponentModel.Win32Exception
f_23120_5825_5872(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 5825, 5872);
return return_v;
}


System.IntPtr
f_23120_6249_6297(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6249, 6297);
return return_v;
}


string
f_23120_6330_6372(System.IntPtr
versionRsrc)
{
var return_v = Win32Res.VersionResourceToXml( versionRsrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6330, 6372);
return return_v;
}


System.IntPtr
f_23120_6453_6511(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6453, 6511);
return return_v;
}


int
f_23120_6530_6567(System.IntPtr
expected,System.IntPtr
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6530, 6567);
return 0;
}


System.IntPtr
f_23120_6642_6696(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6642, 6696);
return return_v;
}


int
f_23120_6715_6751(System.IntPtr
expected,System.IntPtr
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6715, 6751);
return 0;
}


System.IntPtr
f_23120_6822_6884(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6822, 6884);
return return_v;
}


int
f_23120_6903_6937(System.IntPtr
expected,System.IntPtr
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 6903, 6937);
return 0;
}


bool
f_23120_7071_7087(System.IntPtr
hFile)
{
var return_v = FreeLibrary( hFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 7071, 7087);
return return_v;
}


int
f_23120_8126_8161(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8126, 8161);
return 0;
}


string
f_23120_8614_8622(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 8614, 8622);
return return_v;
}


System.Diagnostics.FileVersionInfo
f_23120_8583_8623(string
fileName)
{
var return_v = FileVersionInfo.GetVersionInfo( fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8583, 8623);
return return_v;
}


string
f_23120_8676_8695(System.Diagnostics.FileVersionInfo
this_param)
{
var return_v = this_param.CompanyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 8676, 8695);
return return_v;
}


int
f_23120_8638_8696(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8638, 8696);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,4836,8708);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,4836,8708);
}
		}

[Fact]
        public void FaultyResourceDataProvider()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,8720,9867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,8801,8832);

var 
c1 = f_23120_8810_8831("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,8848,9081);

var 
result = f_23120_8861_9080(c1, f_23120_8869_8887(), manifestResources:
                new[]
                {
f_23120_8971_9060("r2", "file", () => { throw new Exception("bad stuff"); }, false)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,9097,9313);

result.Diagnostics.Verify(f_23120_9220_9297(f_23120_9220_9262(ErrorCode.ERR_CantReadResource), "file", "bad stuff"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,9329,9525);

result = f_23120_9338_9524(c1, f_23120_9346_9364(), manifestResources:
                new[]
                {
f_23120_9448_9504("r2", "file", () => null, false)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,9541,9856);

result.Diagnostics.Verify(f_23120_9707_9840(f_23120_9707_9749(ErrorCode.ERR_CantReadResource), "file", f_23120_9772_9839()));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,8720,9867);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_8810_8831(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8810, 8831);
return return_v;
}


System.IO.MemoryStream
f_23120_8869_8887()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8869, 8887);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_8971_9060(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8971, 9060);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_8861_9080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 8861, 9080);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_9220_9262(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9220, 9262);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_9220_9297(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9220, 9297);
return return_v;
}


System.IO.MemoryStream
f_23120_9346_9364()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9346, 9364);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_9448_9504(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9448, 9504);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_9338_9524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9338, 9524);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_9707_9749(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9707, 9749);
return return_v;
}


string
f_23120_9772_9839()
{
var return_v = CodeAnalysisResources.ResourceDataProviderShouldReturnNonNullStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 9772, 9839);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_9707_9840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 9707, 9840);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,8720,9867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,8720,9867);
}
		}

[WorkItem(543501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543501")]
        [Fact]
        public void CS1508_DuplicateManifestResourceIdentifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,9879,10723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10068,10099);

var 
c1 = f_23120_10077_10098("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10113,10180);

Func<Stream> 
dataProvider = () => new MemoryStream(new byte[] { })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10196,10477);

var 
result = f_23120_10209_10476(c1, f_23120_10217_10235(), manifestResources:
                new[]
                {
f_23120_10319_10376("A", "x.goo", dataProvider, true),
f_23120_10399_10456("A", "y.goo", dataProvider, true)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10493,10712);

result.Diagnostics.Verify(f_23120_10634_10696(f_23120_10634_10677(ErrorCode.ERR_ResourceNotUnique), "A"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,9879,10723);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_10077_10098(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10077, 10098);
return return_v;
}


System.IO.MemoryStream
f_23120_10217_10235()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10217, 10235);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_10319_10376(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10319, 10376);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_10399_10456(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10399, 10456);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_10209_10476(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10209, 10476);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_10634_10677(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10634, 10677);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_10634_10696(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10634, 10696);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,9879,10723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,9879,10723);
}
		}

[WorkItem(543501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543501")]
        [Fact]
        public void CS1508_DuplicateManifestResourceIdentifier_EmbeddedResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,10735,12284);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10941,10972);

var 
c1 = f_23120_10950_10971("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,10986,11053);

Func<Stream> 
dataProvider = () => new MemoryStream(new byte[] { })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,11069,11373);

var 
result = f_23120_11082_11372(c1, f_23120_11090_11108(), manifestResources:
                new[]
                {
f_23120_11192_11240("A", dataProvider, true),
f_23120_11263_11352("A", null, dataProvider, true, isEmbedded: true, checkArgs: true)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,11389,11608);

result.Diagnostics.Verify(f_23120_11530_11592(f_23120_11530_11573(ErrorCode.ERR_ResourceNotUnique), "A"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,11690,12038);

result = f_23120_11699_12037(c1, f_23120_11707_11725(), manifestResources:
                new[]
                {
f_23120_11809_11901("A", "x.goo", dataProvider, true, isEmbedded: true, checkArgs: true),
f_23120_11924_12017("A", "x.goo", dataProvider, true, isEmbedded: false, checkArgs: true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,12054,12273);

result.Diagnostics.Verify(f_23120_12195_12257(f_23120_12195_12238(ErrorCode.ERR_ResourceNotUnique), "A"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,10735,12284);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_10950_10971(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 10950, 10971);
return return_v;
}


System.IO.MemoryStream
f_23120_11090_11108()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11090, 11108);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_11192_11240(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11192, 11240);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_11263_11352(string
resourceName,string?
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11263, 11352);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_11082_11372(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11082, 11372);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_11530_11573(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11530, 11573);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_11530_11592(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11530, 11592);
return return_v;
}


System.IO.MemoryStream
f_23120_11707_11725()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11707, 11725);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_11809_11901(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11809, 11901);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_11924_12017(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11924, 12017);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_11699_12037(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 11699, 12037);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_12195_12238(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12195, 12238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_12195_12257(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12195, 12257);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,10735,12284);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,10735,12284);
}
		}

[WorkItem(543501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543501")]
        [Fact]
        public void CS7041_DuplicateManifestResourceFileName()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,12296,13288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,12483,12592);

var 
c1 = f_23120_12492_12591("goo", references: new[] { f_23120_12544_12555()}, options: TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,12606,12673);

Func<Stream> 
dataProvider = () => new MemoryStream(new byte[] { })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,12689,12970);

var 
result = f_23120_12702_12969(c1, f_23120_12710_12728(), manifestResources:
                new[]
                {
f_23120_12812_12869("A", "x.goo", dataProvider, true),
f_23120_12892_12949("B", "x.goo", dataProvider, true)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,12986,13277);

result.Diagnostics.Verify(f_23120_13187_13261(f_23120_13187_13238(ErrorCode.ERR_ResourceFileNameNotUnique), "x.goo"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,12296,13288);

Microsoft.CodeAnalysis.MetadataReference
f_23120_12544_12555()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 12544, 12555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_12492_12591(string
assemblyName,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12492, 12591);
return return_v;
}


System.IO.MemoryStream
f_23120_12710_12728()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12710, 12728);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_12812_12869(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12812, 12869);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_12892_12949(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12892, 12949);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_12702_12969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 12702, 12969);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_13187_13238(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13187, 13238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_13187_13261(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13187, 13261);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,12296,13288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,12296,13288);
}
		}

[WorkItem(543501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543501")]
        [Fact]
        public void NoDuplicateManifestResourceFileNameDiagnosticForEmbeddedResources()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,13300,14473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,13512,13543);

var 
c1 = f_23120_13521_13542("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,13557,13624);

Func<Stream> 
dataProvider = () => new MemoryStream(new byte[] { })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,13640,13944);

var 
result = f_23120_13653_13943(c1, f_23120_13661_13679(), manifestResources:
                new[]
                {
f_23120_13763_13811("A", dataProvider, true),
f_23120_13834_13923("B", null, dataProvider, true, isEmbedded: true, checkArgs: true)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,13960,13988);

result.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,14070,14418);

result = f_23120_14079_14417(c1, f_23120_14087_14105(), manifestResources:
                new[]
                {
f_23120_14189_14281("A", "x.goo", dataProvider, true, isEmbedded: true, checkArgs: true),
f_23120_14304_14397("B", "x.goo", dataProvider, true, isEmbedded: false, checkArgs: true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,14434,14462);

result.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,13300,14473);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_13521_13542(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13521, 13542);
return return_v;
}


System.IO.MemoryStream
f_23120_13661_13679()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13661, 13679);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_13763_13811(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13763, 13811);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_13834_13923(string
resourceName,string?
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13834, 13923);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_13653_13943(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 13653, 13943);
return return_v;
}


System.IO.MemoryStream
f_23120_14087_14105()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14087, 14105);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_14189_14281(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14189, 14281);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_14304_14397(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic,bool
isEmbedded,bool
checkArgs)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic, isEmbedded:isEmbedded, checkArgs:checkArgs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14304, 14397);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_14079_14417(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14079, 14417);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,13300,14473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,13300,14473);
}
		}

[WorkItem(543501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543501"), WorkItem(546297, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/546297")]
        [Fact]
        public void CS1508_CS7041_DuplicateManifestResourceDiagnostics()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,14485,17726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,14764,14795);

var 
c1 = f_23120_14773_14794("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,14809,14876);

Func<Stream> 
dataProvider = () => new MemoryStream(new byte[] { })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,14892,15173);

var 
result = f_23120_14905_15172(c1, f_23120_14913_14931(), manifestResources:
                new[]
                {
f_23120_15015_15072("A", "x.goo", dataProvider, true),
f_23120_15095_15152("A", "x.goo", dataProvider, true)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,15189,15658);

result.Diagnostics.Verify(f_23120_15330_15392(f_23120_15330_15373(ErrorCode.ERR_ResourceNotUnique), "A"),f_23120_15568_15642(f_23120_15568_15619(ErrorCode.ERR_ResourceFileNameNotUnique), "x.goo"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,15674,16031);

result = f_23120_15683_16030(c1, f_23120_15691_15709(), manifestResources:
                new[]
                {
f_23120_15793_15850("A", "x.goo", dataProvider, true),
f_23120_15873_15930("B", "x.goo", dataProvider, true),
f_23120_15953_16010("B", "y.goo", dataProvider, true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,16047,16516);

result.Diagnostics.Verify(f_23120_16248_16322(f_23120_16248_16299(ErrorCode.ERR_ResourceFileNameNotUnique), "x.goo"),f_23120_16438_16500(f_23120_16438_16481(ErrorCode.ERR_ResourceNotUnique), "B"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,16532,16732);

result = f_23120_16541_16731(c1, f_23120_16549_16567(), manifestResources:
                new[]
                {
f_23120_16651_16710("A", "goo.dll", dataProvider, true),
                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,16877,16905);

result.Diagnostics.Verify();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,16921,16987);

var 
netModule1 = f_23120_16938_16986()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,17003,17064);

c1 = f_23120_17008_17063("", references: new[] { netModule1 });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,17080,17293);

result = f_23120_17089_17292(c1, f_23120_17097_17115(), manifestResources:
                new[]
                {
f_23120_17199_17271("A", "netmodule1.netmodule", dataProvider, true),
                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,17394,17715);

result.Diagnostics.Verify(f_23120_17610_17699(f_23120_17610_17661(ErrorCode.ERR_ResourceFileNameNotUnique), "netModule1.netmodule"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,14485,17726);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_14773_14794(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14773, 14794);
return return_v;
}


System.IO.MemoryStream
f_23120_14913_14931()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14913, 14931);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_15015_15072(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15015, 15072);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_15095_15152(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15095, 15152);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_14905_15172(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 14905, 15172);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_15330_15373(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15330, 15373);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_15330_15392(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15330, 15392);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_15568_15619(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15568, 15619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_15568_15642(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15568, 15642);
return return_v;
}


System.IO.MemoryStream
f_23120_15691_15709()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15691, 15709);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_15793_15850(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15793, 15850);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_15873_15930(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15873, 15930);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_15953_16010(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15953, 16010);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_15683_16030(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 15683, 16030);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_16248_16299(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16248, 16299);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_16248_16322(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16248, 16322);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_16438_16481(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16438, 16481);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_16438_16500(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16438, 16500);
return return_v;
}


System.IO.MemoryStream
f_23120_16549_16567()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16549, 16567);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_16651_16710(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16651, 16710);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_16541_16731(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 16541, 16731);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23120_16938_16986()
{
var return_v = TestReferences.SymbolsTests.netModule.netModule1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 16938, 16986);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_17008_17063(string
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17008, 17063);
return return_v;
}


System.IO.MemoryStream
f_23120_17097_17115()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17097, 17115);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_17199_17271(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17199, 17271);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_17089_17292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17089, 17292);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_17610_17661(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17610, 17661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_17610_17699(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 17610, 17699);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,14485,17726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,14485,17726);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void AddManagedResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,17738,19718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,17843,17910);

string 
source = @"public class C { static public void Main() {} }"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18099,18134);

var 
c1 = f_23120_18108_18133(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18150,18198);

var 
resourceFileName = "RoslynResourceFile.goo"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18212,18244);

var 
output = f_23120_18225_18243()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18260,18301);

const string 
r1Name = "some.dotted.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18315,18359);

const string 
r2Name = "another.DoTtEd.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18375,18430);

var 
arrayOfEmbeddedData = new byte[] { 1, 2, 3, 4, 5 }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18444,18512);

var 
resourceFileData = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18528,18883);

var 
result = f_23120_18541_18882(c1, output, manifestResources:
                new ResourceDescription[]
                {
f_23120_18659_18741(r1Name, () => new MemoryStream(arrayOfEmbeddedData), true),
f_23120_18764_18862(r2Name, resourceFileName, () => new MemoryStream(resourceFileData), false)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18899,18927);

f_23120_18899_18926(f_23120_18911_18925(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,18943,19004);

var 
assembly = f_23120_18958_19003(f_23120_18986_19002(output))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19020,19081);

string[] 
resourceNames = f_23120_19045_19080(assembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19095,19133);

f_23120_19095_19132(2, f_23120_19111_19131(resourceNames));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19149,19202);

var 
rInfo = f_23120_19161_19201(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19216,19323);

f_23120_19216_19322(ResourceLocation.Embedded | ResourceLocation.ContainedInManifestFile, f_23120_19299_19321(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19339,19394);

var 
rData = f_23120_19351_19393(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19408,19444);

var 
rBytes = new byte[f_23120_19430_19442(rData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19458,19499);

f_23120_19458_19498(            rData, rBytes, 0, f_23120_19485_19497(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19513,19555);

f_23120_19513_19554(arrayOfEmbeddedData, rBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19571,19620);

rInfo = f_23120_19579_19619(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19634,19681);

f_23120_19634_19680(resourceFileName, f_23120_19665_19679(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19697,19707);

c1 = null;
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,17738,19718);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_18108_18133(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18108, 18133);
return return_v;
}


System.IO.MemoryStream
f_23120_18225_18243()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18225, 18243);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_18659_18741(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18659, 18741);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_18764_18862(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18764, 18862);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_18541_18882(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18541, 18882);
return return_v;
}


bool
f_23120_18911_18925(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 18911, 18925);
return return_v;
}


int
f_23120_18899_18926(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18899, 18926);
return 0;
}


byte[]
f_23120_18986_19002(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18986, 19002);
return return_v;
}


System.Reflection.Assembly
f_23120_18958_19003(byte[]
rawAssembly)
{
var return_v = Assembly.ReflectionOnlyLoad( rawAssembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 18958, 19003);
return return_v;
}


string[]
f_23120_19045_19080(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetManifestResourceNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19045, 19080);
return return_v;
}


int
f_23120_19111_19131(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 19111, 19131);
return return_v;
}


int
f_23120_19095_19132(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19095, 19132);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_19161_19201(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19161, 19201);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_19299_19321(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 19299, 19321);
return return_v;
}


int
f_23120_19216_19322(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19216, 19322);
return 0;
}


System.IO.Stream?
f_23120_19351_19393(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19351, 19393);
return return_v;
}


long
f_23120_19430_19442(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 19430, 19442);
return return_v;
}


long
f_23120_19485_19497(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 19485, 19497);
return return_v;
}


int
f_23120_19458_19498(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19458, 19498);
return return_v;
}


int
f_23120_19513_19554(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19513, 19554);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_19579_19619(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19579, 19619);
return return_v;
}


string
f_23120_19665_19679(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 19665, 19679);
return return_v;
}


int
f_23120_19634_19680(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 19634, 19680);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,17738,19718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,17738,19718);
}
		}

[ConditionalFact(typeof(WindowsDesktopOnly))]
        public void AddResourceToModule()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,19730,34087);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19843,19869);

bool 
metadataOnly = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19883,19967);

Func<Compilation, Stream, ResourceDescription[], CodeAnalysis.Emit.EmitResult> 
emit
=default(Func<Compilation, Stream, ResourceDescription[], CodeAnalysis.Emit.EmitResult>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,19981,20087);

emit = (c, s, r) => c.Emit(s, manifestResources: r, options: new EmitOptions(metadataOnly: metadataOnly));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20103,20154);

var 
sourceTree = f_23120_20120_20153("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20343,20545);

var 
c1 = f_23120_20352_20544(Guid.NewGuid().ToString(), new[] { sourceTree }, new[] { f_23120_20486_20497()}, TestOptions.ReleaseModule)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20561,20609);

var 
resourceFileName = "RoslynResourceFile.goo"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20623,20655);

var 
output = f_23120_20636_20654()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20671,20712);

const string 
r1Name = "some.dotted.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20726,20770);

const string 
r2Name = "another.DoTtEd.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20786,20841);

var 
arrayOfEmbeddedData = new byte[] { 1, 2, 3, 4, 5 }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20855,20923);

var 
resourceFileData = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,20939,21276);

var 
result = f_23120_20952_21275(emit, c1, output, new ResourceDescription[]
                {
f_23120_21052_21134(r1Name, () => new MemoryStream(arrayOfEmbeddedData), true),
f_23120_21157_21255(r2Name, resourceFileName, () => new MemoryStream(resourceFileData), false)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21292,21321);

f_23120_21292_21320(f_23120_21305_21319(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21335,21428);

f_23120_21335_21427(result.Diagnostics.Where(x => x.Code == (int)ErrorCode.ERR_CantRefResource));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21444,21777);

result = f_23120_21453_21776(emit, c1, output, new ResourceDescription[]
                {
f_23120_21553_21651(r2Name, resourceFileName, () => new MemoryStream(resourceFileData), false),
f_23120_21674_21756(r1Name, () => new MemoryStream(arrayOfEmbeddedData), true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21793,21822);

f_23120_21793_21821(f_23120_21806_21820(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21836,21929);

f_23120_21836_21928(result.Diagnostics.Where(x => x.Code == (int)ErrorCode.ERR_CantRefResource));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,21945,22173);

result = f_23120_21954_22172(emit, c1, output, new ResourceDescription[]
                {
f_23120_22054_22152(r2Name, resourceFileName, () => new MemoryStream(resourceFileData), false)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22189,22218);

f_23120_22189_22217(f_23120_22202_22216(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22232,22325);

f_23120_22232_22324(result.Diagnostics.Where(x => x.Code == (int)ErrorCode.ERR_CantRefResource));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22341,22547);

var 
c_mod1 = f_23120_22354_22546(Guid.NewGuid().ToString(), new[] { sourceTree }, new[] { f_23120_22488_22499()}, TestOptions.ReleaseModule)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22563,22600);

var 
output_mod1 = f_23120_22581_22599()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22614,22835);

result = f_23120_22623_22834(emit, c_mod1, output_mod1, new ResourceDescription[]
                {
f_23120_22732_22814(r1Name, () => new MemoryStream(arrayOfEmbeddedData), true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22851,22879);

f_23120_22851_22878(f_23120_22863_22877(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22893,22962);

var 
mod1 = f_23120_22904_22961(f_23120_22935_22960(output_mod1))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,22976,23011);

var 
ref_mod1 = f_23120_22991_23010(mod1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23025,23130);

f_23120_23025_23129(ManifestResourceAttributes.Public, f_23120_23073_23114(f_23120_23073_23084(mod1))[0].Attributes);

            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23165,23248);

var 
c2 = f_23120_23174_23247(sourceTree, new[] { ref_mod1 }, TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23266,23299);

var 
output2 = f_23120_23280_23298()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23317,23348);

var 
result2 = f_23120_23331_23347(c2, output2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23368,23397);

f_23120_23368_23396(f_23120_23380_23395(result2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23415,23495);

var 
assembly = f_23120_23430_23494(f_23120_23476_23493(output2))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23515,23850);

assembly.ModuleResolve += (object sender, ResolveEventArgs e) =>
                {
                    if (e.Name.Equals(c_mod1.SourceModule.Name))
                    {
                        return assembly.LoadModule(e.Name, output_mod1.ToArray());
                    }

                    return null;
                };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23870,23931);

string[] 
resourceNames = f_23120_23895_23930(assembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,23949,23987);

f_23120_23949_23986(1, f_23120_23965_23985(resourceNames));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24007,24060);

var 
rInfo = f_23120_24019_24059(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24078,24160);

f_23120_24078_24159(System.Reflection.ResourceLocation.Embedded, f_23120_24136_24158(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24178,24233);

f_23120_24178_24232(f_23120_24191_24215(f_23120_24191_24210(c_mod1)), f_23120_24217_24231(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24253,24308);

var 
rData = f_23120_24265_24307(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24326,24362);

var 
rBytes = new byte[f_23120_24348_24360(rData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24380,24421);

f_23120_24380_24420(                rData, rBytes, 0, f_23120_24407_24419(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24439,24481);

f_23120_24439_24480(arrayOfEmbeddedData, rBytes);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24512,24718);

var 
c_mod2 = f_23120_24525_24717(Guid.NewGuid().ToString(), new[] { sourceTree }, new[] { f_23120_24659_24670()}, TestOptions.ReleaseModule)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24734,24771);

var 
output_mod2 = f_23120_24752_24770()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,24785,25108);

result = f_23120_24794_25107(emit, c_mod2, output_mod2, new ResourceDescription[]
                {
f_23120_24903_24985(r1Name, () => new MemoryStream(arrayOfEmbeddedData), true),
f_23120_25008_25087(r2Name, () => new MemoryStream(resourceFileData), true)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25124,25152);

f_23120_25124_25151(f_23120_25136_25150(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25166,25254);

var 
ref_mod2 = f_23120_25181_25253(f_23120_25181_25238(f_23120_25212_25237(output_mod2)))
;

            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25289,25372);

var 
c3 = f_23120_25298_25371(sourceTree, new[] { ref_mod2 }, TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25390,25423);

var 
output3 = f_23120_25404_25422()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25441,25472);

var 
result3 = f_23120_25455_25471(c3, output3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25492,25521);

f_23120_25492_25520(f_23120_25504_25519(result3));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25539,25601);

var 
assembly = f_23120_25554_25600(f_23120_25582_25599(output3))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25621,25956);

assembly.ModuleResolve += (object sender, ResolveEventArgs e) =>
                {
                    if (e.Name.Equals(c_mod2.SourceModule.Name))
                    {
                        return assembly.LoadModule(e.Name, output_mod2.ToArray());
                    }

                    return null;
                };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,25976,26037);

string[] 
resourceNames = f_23120_26001_26036(assembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26055,26093);

f_23120_26055_26092(2, f_23120_26071_26091(resourceNames));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26113,26166);

var 
rInfo = f_23120_26125_26165(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26184,26248);

f_23120_26184_26247(ResourceLocation.Embedded, f_23120_26224_26246(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26266,26321);

f_23120_26266_26320(f_23120_26279_26303(f_23120_26279_26298(c_mod2)), f_23120_26305_26319(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26341,26396);

var 
rData = f_23120_26353_26395(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26414,26450);

var 
rBytes = new byte[f_23120_26436_26448(rData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26468,26509);

f_23120_26468_26508(                rData, rBytes, 0, f_23120_26495_26507(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26527,26569);

f_23120_26527_26568(arrayOfEmbeddedData, rBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26589,26638);

rInfo = f_23120_26597_26637(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26656,26720);

f_23120_26656_26719(ResourceLocation.Embedded, f_23120_26696_26718(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26738,26793);

f_23120_26738_26792(f_23120_26751_26775(f_23120_26751_26770(c_mod2)), f_23120_26777_26791(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26813,26864);

rData = f_23120_26821_26863(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26882,26914);

rBytes = new byte[f_23120_26900_26912(rData)];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26932,26973);

f_23120_26932_26972(                rData, rBytes, 0, f_23120_26959_26971(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,26991,27030);

f_23120_26991_27029(resourceFileData, rBytes);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27061,27267);

var 
c_mod3 = f_23120_27074_27266(Guid.NewGuid().ToString(), new[] { sourceTree }, new[] { f_23120_27208_27219()}, TestOptions.ReleaseModule)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27283,27320);

var 
output_mod3 = f_23120_27301_27319()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27334,27553);

result = f_23120_27343_27552(emit, c_mod3, output_mod3, new ResourceDescription[]
                {
f_23120_27452_27532(r2Name, () => new MemoryStream(resourceFileData), false)                });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27569,27597);

f_23120_27569_27596(f_23120_27581_27595(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27611,27680);

var 
mod3 = f_23120_27622_27679(f_23120_27653_27678(output_mod3))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27694,27729);

var 
ref_mod3 = f_23120_27709_27728(mod3)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27743,27849);

f_23120_27743_27848(ManifestResourceAttributes.Private, f_23120_27792_27833(f_23120_27792_27803(mod3))[0].Attributes);

            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27884,27967);

var 
c4 = f_23120_27893_27966(sourceTree, new[] { ref_mod3 }, TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,27985,28018);

var 
output4 = f_23120_27999_28017()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28036,28293);

var 
result4 = f_23120_28050_28292(c4, output4, manifestResources:
                    new ResourceDescription[]
                    {
f_23120_28185_28268(r1Name, () => new MemoryStream(arrayOfEmbeddedData), false)                    })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28313,28342);

f_23120_28313_28341(f_23120_28325_28340(result4));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28360,28440);

var 
assembly = f_23120_28375_28439(f_23120_28421_28438(output4))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28460,28795);

assembly.ModuleResolve += (object sender, ResolveEventArgs e) =>
                {
                    if (e.Name.Equals(c_mod3.SourceModule.Name))
                    {
                        return assembly.LoadModule(e.Name, output_mod3.ToArray());
                    }

                    return null;
                };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28815,28876);

string[] 
resourceNames = f_23120_28840_28875(assembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28894,28932);

f_23120_28894_28931(2, f_23120_28910_28930(resourceNames));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,28952,29005);

var 
rInfo = f_23120_28964_29004(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29023,29130);

f_23120_29023_29129(ResourceLocation.Embedded | ResourceLocation.ContainedInManifestFile, f_23120_29106_29128(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29150,29205);

var 
rData = f_23120_29162_29204(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29223,29259);

var 
rBytes = new byte[f_23120_29245_29257(rData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29277,29318);

f_23120_29277_29317(                rData, rBytes, 0, f_23120_29304_29316(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29336,29378);

f_23120_29336_29377(arrayOfEmbeddedData, rBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29398,29447);

rInfo = f_23120_29406_29446(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29465,29529);

f_23120_29465_29528(ResourceLocation.Embedded, f_23120_29505_29527(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29547,29602);

f_23120_29547_29601(f_23120_29560_29584(f_23120_29560_29579(c_mod3)), f_23120_29586_29600(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29622,29673);

rData = f_23120_29630_29672(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29691,29723);

rBytes = new byte[f_23120_29709_29721(rData)];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29741,29782);

f_23120_29741_29781(                rData, rBytes, 0, f_23120_29768_29780(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29800,29839);

f_23120_29800_29838(resourceFileData, rBytes);
            }

            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,29889,29982);

var 
c5 = f_23120_29898_29981(sourceTree, new[] { ref_mod1, ref_mod3 }, TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30000,30033);

var 
output5 = f_23120_30014_30032()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30051,30089);

var 
result5 = f_23120_30065_30088(emit, c5, output5, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30109,30138);

f_23120_30109_30137(f_23120_30121_30136(result5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30156,30218);

var 
assembly = f_23120_30171_30217(f_23120_30199_30216(output5))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30238,30774);

assembly.ModuleResolve += (object sender, ResolveEventArgs e) =>
                {
                    if (e.Name.Equals(c_mod1.SourceModule.Name))
                    {
                        return assembly.LoadModule(e.Name, output_mod1.ToArray());
                    }
                    else if (e.Name.Equals(c_mod3.SourceModule.Name))
                    {
                        return assembly.LoadModule(e.Name, output_mod3.ToArray());
                    }

                    return null;
                };
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30794,30855);

string[] 
resourceNames = f_23120_30819_30854(assembly)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30873,30911);

f_23120_30873_30910(2, f_23120_30889_30909(resourceNames));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,30931,30984);

var 
rInfo = f_23120_30943_30983(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31002,31066);

f_23120_31002_31065(ResourceLocation.Embedded, f_23120_31042_31064(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31084,31139);

f_23120_31084_31138(f_23120_31097_31121(f_23120_31097_31116(c_mod1)), f_23120_31123_31137(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31159,31214);

var 
rData = f_23120_31171_31213(assembly, r1Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31232,31268);

var 
rBytes = new byte[f_23120_31254_31266(rData)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31286,31327);

f_23120_31286_31326(                rData, rBytes, 0, f_23120_31313_31325(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31345,31387);

f_23120_31345_31386(arrayOfEmbeddedData, rBytes);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31407,31456);

rInfo = f_23120_31415_31455(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31474,31538);

f_23120_31474_31537(ResourceLocation.Embedded, f_23120_31514_31536(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31556,31611);

f_23120_31556_31610(f_23120_31569_31593(f_23120_31569_31588(c_mod3)), f_23120_31595_31609(rInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31631,31682);

rData = f_23120_31639_31681(assembly, r2Name);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31700,31732);

rBytes = new byte[f_23120_31718_31730(rData)];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31750,31791);

f_23120_31750_31790(                rData, rBytes, 0, f_23120_31777_31789(rData));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31809,31848);

f_23120_31809_31847(resourceFileData, rBytes);
            }

            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,31898,31991);

var 
c6 = f_23120_31907_31990(sourceTree, new[] { ref_mod1, ref_mod2 }, TestOptions.ReleaseDll)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32009,32042);

var 
output6 = f_23120_32023_32041()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32060,32098);

var 
result6 = f_23120_32074_32097(emit, c6, output6, null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32118,32636) || true) && (metadataOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,32118,32636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32176,32205);

f_23120_32176_32204(f_23120_32188_32203(result6));
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,32118,32636);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,32118,32636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32287,32317);

f_23120_32287_32316(f_23120_32300_32315(result6));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32339,32617);

result6.Diagnostics.Verify(f_23120_32512_32589(f_23120_32512_32555(ErrorCode.ERR_ResourceNotUnique), "some.dotted.NAME"));
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,32118,32636);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32656,32884);

result6 = f_23120_32666_32883(emit, c6, output6, new ResourceDescription[]
                    {
f_23120_32779_32859(r2Name, () => new MemoryStream(resourceFileData), false)                    });

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32904,33652) || true) && (metadataOnly)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,32904,33652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,32962,32991);

f_23120_32962_32990(f_23120_32974_32989(result6));
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,32904,33652);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,32904,33652);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,33073,33103);

f_23120_33073_33102(f_23120_33086_33101(result6));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,33125,33633);

result6.Diagnostics.Verify(f_23120_33298_33375(f_23120_33298_33341(ErrorCode.ERR_ResourceNotUnique), "some.dotted.NAME"),f_23120_33525_33605(f_23120_33525_33568(ErrorCode.ERR_ResourceNotUnique), "another.DoTtEd.NAME"));
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,32904,33652);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,33672,33764);

c6 = f_23120_33677_33763(sourceTree, new[] { ref_mod1, ref_mod2 }, TestOptions.ReleaseModule);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,33784,34012);

result6 = f_23120_33794_34011(emit, c6, output6, new ResourceDescription[]
                    {
f_23120_33907_33987(r2Name, () => new MemoryStream(resourceFileData), false)                    });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34032,34061);

f_23120_34032_34060(f_23120_34044_34059(result6));
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,19730,34087);

Microsoft.CodeAnalysis.SyntaxTree
f_23120_20120_20153(string
text)
{
var return_v = SyntaxFactory.ParseSyntaxTree( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 20120, 20153);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23120_20486_20497()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 20486, 20497);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_20352_20544(string
assemblyName,Microsoft.CodeAnalysis.SyntaxTree[]
syntaxTrees,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 20352, 20544);
return return_v;
}


System.IO.MemoryStream
f_23120_20636_20654()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 20636, 20654);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_21052_21134(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21052, 21134);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_21157_21255(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21157, 21255);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_20952_21275(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 20952, 21275);
return return_v;
}


bool
f_23120_21305_21319(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 21305, 21319);
return return_v;
}


int
f_23120_21292_21320(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21292, 21320);
return 0;
}


int
f_23120_21335_21427(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
collection)
{
Assert.NotEmpty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21335, 21427);
return 0;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_21553_21651(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21553, 21651);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_21674_21756(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21674, 21756);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_21453_21776(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21453, 21776);
return return_v;
}


bool
f_23120_21806_21820(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 21806, 21820);
return return_v;
}


int
f_23120_21793_21821(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21793, 21821);
return 0;
}


int
f_23120_21836_21928(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
collection)
{
Assert.NotEmpty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21836, 21928);
return 0;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_22054_22152(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22054, 22152);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_21954_22172(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 21954, 22172);
return return_v;
}


bool
f_23120_22202_22216(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 22202, 22216);
return return_v;
}


int
f_23120_22189_22217(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22189, 22217);
return 0;
}


int
f_23120_22232_22324(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
collection)
{
Assert.NotEmpty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22232, 22324);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_23120_22488_22499()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 22488, 22499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_22354_22546(string
assemblyName,Microsoft.CodeAnalysis.SyntaxTree[]
syntaxTrees,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22354, 22546);
return return_v;
}


System.IO.MemoryStream
f_23120_22581_22599()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22581, 22599);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_22732_22814(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22732, 22814);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_22623_22834(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22623, 22834);
return return_v;
}


bool
f_23120_22863_22877(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 22863, 22877);
return return_v;
}


int
f_23120_22851_22878(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22851, 22878);
return 0;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23120_22935_22960(System.IO.MemoryStream
stream)
{
var return_v = stream.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22935, 22960);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23120_22904_22961(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22904, 22961);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23120_22991_23010(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 22991, 23010);
return return_v;
}


Microsoft.CodeAnalysis.PEModule
f_23120_23073_23084(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 23073, 23084);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
f_23120_23073_23114(Microsoft.CodeAnalysis.PEModule
this_param)
{
var return_v = this_param.GetEmbeddedResourcesOrThrow();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23073, 23114);
return return_v;
}


int
f_23120_23025_23129(System.Reflection.ManifestResourceAttributes
expected,System.Reflection.ManifestResourceAttributes
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23025, 23129);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_23174_23247(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23174, 23247);
return return_v;
}


System.IO.MemoryStream
f_23120_23280_23298()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23280, 23298);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_23331_23347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23331, 23347);
return return_v;
}


bool
f_23120_23380_23395(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 23380, 23395);
return return_v;
}


int
f_23120_23368_23396(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23368, 23396);
return 0;
}


byte[]
f_23120_23476_23493(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23476, 23493);
return return_v;
}


System.Reflection.Assembly
f_23120_23430_23494(byte[]
rawAssembly)
{
var return_v = System.Reflection.Assembly.ReflectionOnlyLoad( rawAssembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23430, 23494);
return return_v;
}


string[]
f_23120_23895_23930(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetManifestResourceNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23895, 23930);
return return_v;
}


int
f_23120_23965_23985(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 23965, 23985);
return return_v;
}


int
f_23120_23949_23986(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 23949, 23986);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_24019_24059(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24019, 24059);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_24136_24158(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24136, 24158);
return return_v;
}


int
f_23120_24078_24159(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24078, 24159);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_24191_24210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24191, 24210);
return return_v;
}


string
f_23120_24191_24215(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24191, 24215);
return return_v;
}


string
f_23120_24217_24231(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24217, 24231);
return return_v;
}


int
f_23120_24178_24232(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24178, 24232);
return 0;
}


System.IO.Stream?
f_23120_24265_24307(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24265, 24307);
return return_v;
}


long
f_23120_24348_24360(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24348, 24360);
return return_v;
}


long
f_23120_24407_24419(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24407, 24419);
return return_v;
}


int
f_23120_24380_24420(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24380, 24420);
return return_v;
}


int
f_23120_24439_24480(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24439, 24480);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_23120_24659_24670()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 24659, 24670);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_24525_24717(string
assemblyName,Microsoft.CodeAnalysis.SyntaxTree[]
syntaxTrees,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24525, 24717);
return return_v;
}


System.IO.MemoryStream
f_23120_24752_24770()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24752, 24770);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_24903_24985(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24903, 24985);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_25008_25087(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25008, 25087);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_24794_25107(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 24794, 25107);
return return_v;
}


bool
f_23120_25136_25150(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 25136, 25150);
return return_v;
}


int
f_23120_25124_25151(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25124, 25151);
return 0;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23120_25212_25237(System.IO.MemoryStream
stream)
{
var return_v = stream.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25212, 25237);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23120_25181_25238(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25181, 25238);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23120_25181_25253(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25181, 25253);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_25298_25371(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25298, 25371);
return return_v;
}


System.IO.MemoryStream
f_23120_25404_25422()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25404, 25422);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_25455_25471(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25455, 25471);
return return_v;
}


bool
f_23120_25504_25519(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 25504, 25519);
return return_v;
}


int
f_23120_25492_25520(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25492, 25520);
return 0;
}


byte[]
f_23120_25582_25599(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25582, 25599);
return return_v;
}


System.Reflection.Assembly
f_23120_25554_25600(byte[]
rawAssembly)
{
var return_v = Assembly.ReflectionOnlyLoad( rawAssembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 25554, 25600);
return return_v;
}


string[]
f_23120_26001_26036(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetManifestResourceNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26001, 26036);
return return_v;
}


int
f_23120_26071_26091(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26071, 26091);
return return_v;
}


int
f_23120_26055_26092(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26055, 26092);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_26125_26165(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26125, 26165);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_26224_26246(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26224, 26246);
return return_v;
}


int
f_23120_26184_26247(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26184, 26247);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_26279_26298(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26279, 26298);
return return_v;
}


string
f_23120_26279_26303(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26279, 26303);
return return_v;
}


string
f_23120_26305_26319(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26305, 26319);
return return_v;
}


int
f_23120_26266_26320(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26266, 26320);
return 0;
}


System.IO.Stream?
f_23120_26353_26395(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26353, 26395);
return return_v;
}


long
f_23120_26436_26448(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26436, 26448);
return return_v;
}


long
f_23120_26495_26507(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26495, 26507);
return return_v;
}


int
f_23120_26468_26508(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26468, 26508);
return return_v;
}


int
f_23120_26527_26568(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26527, 26568);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_26597_26637(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26597, 26637);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_26696_26718(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26696, 26718);
return return_v;
}


int
f_23120_26656_26719(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26656, 26719);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_26751_26770(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26751, 26770);
return return_v;
}


string
f_23120_26751_26775(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26751, 26775);
return return_v;
}


string
f_23120_26777_26791(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26777, 26791);
return return_v;
}


int
f_23120_26738_26792(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26738, 26792);
return 0;
}


System.IO.Stream?
f_23120_26821_26863(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26821, 26863);
return return_v;
}


long
f_23120_26900_26912(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26900, 26912);
return return_v;
}


long
f_23120_26959_26971(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 26959, 26971);
return return_v;
}


int
f_23120_26932_26972(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26932, 26972);
return return_v;
}


int
f_23120_26991_27029(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 26991, 27029);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_23120_27208_27219()
{
var return_v = MscorlibRef ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 27208, 27219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_27074_27266(string
assemblyName,Microsoft.CodeAnalysis.SyntaxTree[]
syntaxTrees,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CSharpCompilation.Create( assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27074, 27266);
return return_v;
}


System.IO.MemoryStream
f_23120_27301_27319()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27301, 27319);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_27452_27532(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27452, 27532);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_27343_27552(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27343, 27552);
return return_v;
}


bool
f_23120_27581_27595(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 27581, 27595);
return return_v;
}


int
f_23120_27569_27596(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27569, 27596);
return 0;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23120_27653_27678(System.IO.MemoryStream
stream)
{
var return_v = stream.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27653, 27678);
return return_v;
}


Microsoft.CodeAnalysis.ModuleMetadata
f_23120_27622_27679(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = ModuleMetadata.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27622, 27679);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23120_27709_27728(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.GetReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27709, 27728);
return return_v;
}


Microsoft.CodeAnalysis.PEModule
f_23120_27792_27803(Microsoft.CodeAnalysis.ModuleMetadata
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 27792, 27803);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.EmbeddedResource>
f_23120_27792_27833(Microsoft.CodeAnalysis.PEModule
this_param)
{
var return_v = this_param.GetEmbeddedResourcesOrThrow();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27792, 27833);
return return_v;
}


int
f_23120_27743_27848(System.Reflection.ManifestResourceAttributes
expected,System.Reflection.ManifestResourceAttributes
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27743, 27848);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_27893_27966(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27893, 27966);
return return_v;
}


System.IO.MemoryStream
f_23120_27999_28017()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 27999, 28017);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_28185_28268(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28185, 28268);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_28050_28292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28050, 28292);
return return_v;
}


bool
f_23120_28325_28340(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 28325, 28340);
return return_v;
}


int
f_23120_28313_28341(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28313, 28341);
return 0;
}


byte[]
f_23120_28421_28438(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28421, 28438);
return return_v;
}


System.Reflection.Assembly
f_23120_28375_28439(byte[]
rawAssembly)
{
var return_v = System.Reflection.Assembly.ReflectionOnlyLoad( rawAssembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28375, 28439);
return return_v;
}


string[]
f_23120_28840_28875(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetManifestResourceNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28840, 28875);
return return_v;
}


int
f_23120_28910_28930(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 28910, 28930);
return return_v;
}


int
f_23120_28894_28931(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28894, 28931);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_28964_29004(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 28964, 29004);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_29106_29128(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29106, 29128);
return return_v;
}


int
f_23120_29023_29129(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29023, 29129);
return 0;
}


System.IO.Stream?
f_23120_29162_29204(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29162, 29204);
return return_v;
}


long
f_23120_29245_29257(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29245, 29257);
return return_v;
}


long
f_23120_29304_29316(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29304, 29316);
return return_v;
}


int
f_23120_29277_29317(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29277, 29317);
return return_v;
}


int
f_23120_29336_29377(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29336, 29377);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_29406_29446(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29406, 29446);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_29505_29527(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29505, 29527);
return return_v;
}


int
f_23120_29465_29528(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29465, 29528);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_29560_29579(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29560, 29579);
return return_v;
}


string
f_23120_29560_29584(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29560, 29584);
return return_v;
}


string
f_23120_29586_29600(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29586, 29600);
return return_v;
}


int
f_23120_29547_29601(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29547, 29601);
return 0;
}


System.IO.Stream?
f_23120_29630_29672(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29630, 29672);
return return_v;
}


long
f_23120_29709_29721(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29709, 29721);
return return_v;
}


long
f_23120_29768_29780(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 29768, 29780);
return return_v;
}


int
f_23120_29741_29781(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29741, 29781);
return return_v;
}


int
f_23120_29800_29838(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29800, 29838);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_29898_29981(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 29898, 29981);
return return_v;
}


System.IO.MemoryStream
f_23120_30014_30032()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30014, 30032);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_30065_30088(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30065, 30088);
return return_v;
}


bool
f_23120_30121_30136(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 30121, 30136);
return return_v;
}


int
f_23120_30109_30137(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30109, 30137);
return 0;
}


byte[]
f_23120_30199_30216(System.IO.MemoryStream
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30199, 30216);
return return_v;
}


System.Reflection.Assembly
f_23120_30171_30217(byte[]
rawAssembly)
{
var return_v = Assembly.ReflectionOnlyLoad( rawAssembly);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30171, 30217);
return return_v;
}


string[]
f_23120_30819_30854(System.Reflection.Assembly
this_param)
{
var return_v = this_param.GetManifestResourceNames();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30819, 30854);
return return_v;
}


int
f_23120_30889_30909(string[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 30889, 30909);
return return_v;
}


int
f_23120_30873_30910(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30873, 30910);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_30943_30983(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 30943, 30983);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_31042_31064(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31042, 31064);
return return_v;
}


int
f_23120_31002_31065(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31002, 31065);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_31097_31116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31097, 31116);
return return_v;
}


string
f_23120_31097_31121(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31097, 31121);
return return_v;
}


string
f_23120_31123_31137(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31123, 31137);
return return_v;
}


int
f_23120_31084_31138(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31084, 31138);
return 0;
}


System.IO.Stream?
f_23120_31171_31213(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31171, 31213);
return return_v;
}


long
f_23120_31254_31266(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31254, 31266);
return return_v;
}


long
f_23120_31313_31325(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31313, 31325);
return return_v;
}


int
f_23120_31286_31326(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31286, 31326);
return return_v;
}


int
f_23120_31345_31386(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31345, 31386);
return 0;
}


System.Reflection.ManifestResourceInfo?
f_23120_31415_31455(System.Reflection.Assembly
this_param,string
resourceName)
{
var return_v = this_param.GetManifestResourceInfo( resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31415, 31455);
return return_v;
}


System.Reflection.ResourceLocation
f_23120_31514_31536(System.Reflection.ManifestResourceInfo?
this_param)
{
var return_v = this_param.ResourceLocation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31514, 31536);
return return_v;
}


int
f_23120_31474_31537(System.Reflection.ResourceLocation
expected,System.Reflection.ResourceLocation
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31474, 31537);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
f_23120_31569_31588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.SourceModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31569, 31588);
return return_v;
}


string
f_23120_31569_31593(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31569, 31593);
return return_v;
}


string
f_23120_31595_31609(System.Reflection.ManifestResourceInfo
this_param)
{
var return_v = this_param.FileName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31595, 31609);
return return_v;
}


int
f_23120_31556_31610(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31556, 31610);
return 0;
}


System.IO.Stream?
f_23120_31639_31681(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetManifestResourceStream( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31639, 31681);
return return_v;
}


long
f_23120_31718_31730(System.IO.Stream?
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31718, 31730);
return return_v;
}


long
f_23120_31777_31789(System.IO.Stream
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 31777, 31789);
return return_v;
}


int
f_23120_31750_31790(System.IO.Stream
this_param,byte[]
buffer,int
offset,long
count)
{
var return_v = this_param.Read( buffer, offset, (int)count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31750, 31790);
return return_v;
}


int
f_23120_31809_31847(byte[]
expected,byte[]
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31809, 31847);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_31907_31990(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 31907, 31990);
return return_v;
}


System.IO.MemoryStream
f_23120_32023_32041()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32023, 32041);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_32074_32097(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32074, 32097);
return return_v;
}


bool
f_23120_32188_32203(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 32188, 32203);
return return_v;
}


int
f_23120_32176_32204(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32176, 32204);
return 0;
}


bool
f_23120_32300_32315(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 32300, 32315);
return return_v;
}


int
f_23120_32287_32316(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32287, 32316);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_32512_32555(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32512, 32555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_32512_32589(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32512, 32589);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_32779_32859(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32779, 32859);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_32666_32883(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32666, 32883);
return return_v;
}


bool
f_23120_32974_32989(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 32974, 32989);
return return_v;
}


int
f_23120_32962_32990(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 32962, 32990);
return 0;
}


bool
f_23120_33086_33101(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 33086, 33101);
return return_v;
}


int
f_23120_33073_33102(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33073, 33102);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_33298_33341(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33298, 33341);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_33298_33375(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33298, 33375);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_33525_33568(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33525, 33568);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_33525_33605(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33525, 33605);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_33677_33763(Microsoft.CodeAnalysis.SyntaxTree
source,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33677, 33763);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_33907_33987(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33907, 33987);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_33794_34011(System.Func<Microsoft.CodeAnalysis.Compilation, System.IO.Stream, Microsoft.CodeAnalysis.ResourceDescription[], Microsoft.CodeAnalysis.Emit.EmitResult>
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
arg1,System.IO.MemoryStream
arg2,Microsoft.CodeAnalysis.ResourceDescription[]
arg3)
{
var return_v = this_param.Invoke( (Microsoft.CodeAnalysis.Compilation)arg1, (System.IO.Stream)arg2, arg3);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 33794, 34011);
return return_v;
}


bool
f_23120_34044_34059(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 34044, 34059);
return return_v;
}


int
f_23120_34032_34060(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34032, 34060);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,19730,34087);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,19730,34087);
}
		}

[Fact]
        public void AddManagedLinkedResourceFail()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,34099,34881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34182,34275);

string 
source = @"
public class Maine
{
    static public void Main()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34289,34324);

var 
c1 = f_23120_34298_34323(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34340,34372);

var 
output = f_23120_34353_34371()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34388,34432);

const string 
r2Name = "another.DoTtEd.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34448,34723);

var 
result = f_23120_34461_34722(c1, output, manifestResources:
                new ResourceDescription[]
                {
f_23120_34579_34702(r2Name, "nonExistent", () => { throw new NotSupportedException("error in data provider"); }, false)                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34739,34768);

f_23120_34739_34767(f_23120_34752_34766(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34782,34870);

f_23120_34782_34869(ErrorCode.ERR_CantReadResource, f_23120_34832_34868(result.Diagnostics.ToArray()[0]));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,34099,34881);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_34298_34323(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34298, 34323);
return return_v;
}


System.IO.MemoryStream
f_23120_34353_34371()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34353, 34371);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_34579_34702(string
resourceName,string
fileName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, fileName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34579, 34702);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_34461_34722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34461, 34722);
return return_v;
}


bool
f_23120_34752_34766(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 34752, 34766);
return return_v;
}


int
f_23120_34739_34767(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34739, 34767);
return 0;
}


int
f_23120_34832_34868(Microsoft.CodeAnalysis.Diagnostic
this_param)
{
var return_v = this_param.Code;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 34832, 34868);
return return_v;
}


int
f_23120_34782_34869(Microsoft.CodeAnalysis.CSharp.ErrorCode
expected,int
actual)
{
Assert.Equal( (int)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 34782, 34869);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,34099,34881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,34099,34881);
}
		}

[Fact]
        public void AddManagedEmbeddedResourceFail()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,34893,35604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,34978,35071);

string 
source = @"
public class Maine
{
    static public void Main()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35085,35120);

var 
c1 = f_23120_35094_35119(source)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35136,35168);

var 
output = f_23120_35149_35167()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35184,35228);

const string 
r2Name = "another.DoTtEd.NAME"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35244,35446);

var 
result = f_23120_35257_35445(c1, output, manifestResources:
                new ResourceDescription[]
                {
f_23120_35375_35424(r2Name, () => null, true),
                })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35462,35491);

f_23120_35462_35490(f_23120_35475_35489(result));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35505,35593);

f_23120_35505_35592(ErrorCode.ERR_CantReadResource, f_23120_35555_35591(result.Diagnostics.ToArray()[0]));
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,34893,35604);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_35094_35119(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35094, 35119);
return return_v;
}


System.IO.MemoryStream
f_23120_35149_35167()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35149, 35167);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_35375_35424(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35375, 35424);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_35257_35445(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35257, 35445);
return return_v;
}


bool
f_23120_35475_35489(Microsoft.CodeAnalysis.Emit.EmitResult
this_param)
{
var return_v = this_param.Success;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 35475, 35489);
return return_v;
}


int
f_23120_35462_35490(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35462, 35490);
return 0;
}


int
f_23120_35555_35591(Microsoft.CodeAnalysis.Diagnostic
this_param)
{
var return_v = this_param.Code;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 35555, 35591);
return return_v;
}


int
f_23120_35505_35592(Microsoft.CodeAnalysis.CSharp.ErrorCode
expected,int
actual)
{
Assert.Equal( (int)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 35505, 35592);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,34893,35604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,34893,35604);
}
		}

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionNeedsDesktopTypes)]
        public void ResourceWithAttrSettings()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,35616,38901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,35790,36517);

string 
source = @"
[assembly: System.Reflection.AssemblyVersion(""1.2.3.4"")]
[assembly: System.Reflection.AssemblyFileVersion(""5.6.7.8"")]
[assembly: System.Reflection.AssemblyTitle(""One Hundred Years of Solitude"")] 
[assembly: System.Reflection.AssemblyDescription(""A classic of magical realist literature"")]
[assembly: System.Reflection.AssemblyCompany(""MossBrain"")]
[assembly: System.Reflection.AssemblyProduct(""Sound Cannon"")]
[assembly: System.Reflection.AssemblyCopyright(""circle C"")]
[assembly: System.Reflection.AssemblyTrademark(""circle R"")]
[assembly: System.Reflection.AssemblyInformationalVersion(""1.2.3garbage"")]

public class Maine
{
    public static void Main()
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36531,36630);

var 
c1 = f_23120_36540_36629(source, assemblyName: "Win32VerAttrs", options: TestOptions.ReleaseExe)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36644,36676);

var 
exeFile = f_23120_36658_36675(f_23120_36658_36662())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36692,36871);
using(FileStream 
output = f_23120_36719_36733(exeFile)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36767,36856);

f_23120_36767_36855(                c1, output, win32Resources: f_23120_36799_36854(c1, true, false, null, null));
DynAbs.Tracing.TraceSender.TraceExitUsing(23120,36692,36871);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36887,36897);

c1 = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36911,36930);

string 
versionData
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,36974,36999);

IntPtr 
lib = IntPtr.Zero
;
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37049,37108);

lib = f_23120_37055_37107(f_23120_37069_37081(exeFile), IntPtr.Zero, 0x00000002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37126,37245);

f_23120_37126_37244(lib != IntPtr.Zero, f_23120_37158_37243("LoadLibrary failed with HResult: {0:X}", +f_23120_37215_37242()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37461,37471);

uint 
size
=default(uint);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37489,37559);

IntPtr 
versionRsrc = f_23120_37510_37558(lib, "#1", "#16", out size)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37577,37634);

versionData = f_23120_37591_37633(versionRsrc);
            }
            finally
            {
DynAbs.Tracing.TraceSender.TraceEnterFinally(23120,37663,37818);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37703,37803) || true) && (lib != IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23120,37703,37803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37767,37784);

f_23120_37767_37783(lib);
DynAbs.Tracing.TraceSender.TraceExitCondition(23120,37703,37803);
}
DynAbs.Tracing.TraceSender.TraceExitFinally(23120,37663,37818);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,37834,38838);

string 
expected =
@"<?xml version=""1.0"" encoding=""utf-16""?>
<VersionResource Size=""964"">
  <VS_FIXEDFILEINFO FileVersionMS=""00050006"" FileVersionLS=""00070008"" ProductVersionMS=""00010002"" ProductVersionLS=""00030000"" />
  <KeyValuePair Key=""Comments"" Value=""A classic of magical realist literature"" />
  <KeyValuePair Key=""CompanyName"" Value=""MossBrain"" />
  <KeyValuePair Key=""FileDescription"" Value=""One Hundred Years of Solitude"" />
  <KeyValuePair Key=""FileVersion"" Value=""5.6.7.8"" />
  <KeyValuePair Key=""InternalName"" Value=""Win32VerAttrs.exe"" />
  <KeyValuePair Key=""LegalCopyright"" Value=""circle C"" />
  <KeyValuePair Key=""LegalTrademarks"" Value=""circle R"" />
  <KeyValuePair Key=""OriginalFilename"" Value=""Win32VerAttrs.exe"" />
  <KeyValuePair Key=""ProductName"" Value=""Sound Cannon"" />
  <KeyValuePair Key=""ProductVersion"" Value=""1.2.3garbage"" />
  <KeyValuePair Key=""Assembly Version"" Value=""1.2.3.4"" />
</VersionResource>"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,38854,38890);

f_23120_38854_38889(expected, versionData);
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,35616,38901);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_36540_36629(string
source,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 36540, 36629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempRoot
f_23120_36658_36662()
{
var return_v = Temp;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 36658, 36662);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.TempFile
f_23120_36658_36675(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
this_param)
{
var return_v = this_param.CreateFile();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 36658, 36675);
return return_v;
}


System.IO.FileStream
f_23120_36719_36733(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Open();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 36719, 36733);
return return_v;
}


System.IO.Stream
f_23120_36799_36854(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,bool
versionResource,bool
noManifest,System.IO.Stream?
manifestContents,System.IO.Stream?
iconInIcoFormat)
{
var return_v = this_param.CreateDefaultWin32Resources( versionResource, noManifest, manifestContents, iconInIcoFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 36799, 36854);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_36767_36855(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.FileStream
peStream,System.IO.Stream
win32Resources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, win32Resources:win32Resources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 36767, 36855);
return return_v;
}


string
f_23120_37069_37081(Microsoft.CodeAnalysis.Test.Utilities.TempFile
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23120, 37069, 37081);
return return_v;
}


System.IntPtr
f_23120_37055_37107(string
lpFileName,System.IntPtr
hFile,int
dwFlags)
{
var return_v = LoadLibraryEx( lpFileName, hFile, (uint)dwFlags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37055, 37107);
return return_v;
}


int
f_23120_37215_37242()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37215, 37242);
return return_v;
}


string
f_23120_37158_37243(string
format,int
arg0)
{
var return_v = String.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37158, 37243);
return return_v;
}


int
f_23120_37126_37244(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37126, 37244);
return 0;
}


System.IntPtr
f_23120_37510_37558(System.IntPtr
lib,string
resourceId,string
resourceType,out uint
size)
{
var return_v = Win32Res.GetResource( lib, resourceId, resourceType, out size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37510, 37558);
return return_v;
}


string
f_23120_37591_37633(System.IntPtr
versionRsrc)
{
var return_v = Win32Res.VersionResourceToXml( versionRsrc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37591, 37633);
return return_v;
}


bool
f_23120_37767_37783(System.IntPtr
hFile)
{
var return_v = FreeLibrary( hFile);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 37767, 37783);
return return_v;
}


int
f_23120_38854_38889(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 38854, 38889);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,35616,38901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,35616,38901);
}
		}

[Fact]
        public void ResourceProviderStreamGivesBadLength()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23120,38913,40059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39004,39068);

var 
backingStream = f_23120_39024_39067(new byte[] { 1, 2, 3, 4 })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39082,39359);

var 
stream = f_23120_39095_39358(canRead: true, canSeek: true, readFunc: backingStream.Read, length: 6, getPosition: () => backingStream.Position)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39375,39406);

var 
c1 = f_23120_39384_39405("")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39422,40048);
using(f_23120_39429_39457())            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39491,39702);

var 
result = f_23120_39504_39701(c1, f_23120_39512_39530(), manifestResources:
                    new[]
                    {
f_23120_39626_39677("res", () => stream, false)                    })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23120,39722,40033);

result.Diagnostics.Verify(f_23120_39894_40031(f_23120_39894_40012(f_23120_39894_39936(ErrorCode.ERR_CantReadResource), "res", "Resource stream ended at 4 bytes, expected 6 bytes."), 1, 1));
DynAbs.Tracing.TraceSender.TraceExitUsing(23120,39422,40048);
            }
DynAbs.Tracing.TraceSender.TraceExitMethod(23120,38913,40059);

System.IO.MemoryStream
f_23120_39024_39067(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39024, 39067);
return return_v;
}


Roslyn.Test.Utilities.TestStream
f_23120_39095_39358(bool
canRead,bool
canSeek,System.Func<byte[], int, int, int>
readFunc,int
length,System.Func<long>
getPosition)
{
var return_v = new Roslyn.Test.Utilities.TestStream( canRead:(bool?)canRead, canSeek:(bool?)canSeek, readFunc:readFunc, length:(long?)length, getPosition:getPosition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39095, 39358);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23120_39384_39405(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39384, 39405);
return return_v;
}


Roslyn.Test.Utilities.EnsureEnglishUICulture
f_23120_39429_39457()
{
var return_v = new Roslyn.Test.Utilities.EnsureEnglishUICulture();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39429, 39457);
return return_v;
}


System.IO.MemoryStream
f_23120_39512_39530()
{
var return_v = new System.IO.MemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39512, 39530);
return return_v;
}


Microsoft.CodeAnalysis.ResourceDescription
f_23120_39626_39677(string
resourceName,System.Func<System.IO.Stream>
dataProvider,bool
isPublic)
{
var return_v = new Microsoft.CodeAnalysis.ResourceDescription( resourceName, dataProvider, isPublic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39626, 39677);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitResult
f_23120_39504_39701(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,System.IO.MemoryStream
peStream,Microsoft.CodeAnalysis.ResourceDescription[]
manifestResources)
{
var return_v = this_param.Emit( (System.IO.Stream)peStream, manifestResources:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>)manifestResources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39504, 39701);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_39894_39936(Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = Diagnostic( (object)code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39894, 39936);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_39894_40012(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39894, 40012);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23120_39894_40031(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23120, 39894, 40031);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23120,38913,40059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,38913,40059);
}
		}

public ResourceTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23120,702,40066);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23120,702,40066);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,702,40066);
}


static ResourceTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23120,702,40066);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23120,702,40066);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23120,702,40066);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23120,702,40066);
}
}
