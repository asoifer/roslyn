// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Interop;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
internal static class SigningTestHelpers
{
public static readonly StrongNameProvider DefaultDesktopStrongNameProvider ;

internal static readonly string KeyFileDirectory ;

internal static readonly string KeyPairFile ;

internal static readonly string PublicKeyFile ;

internal static readonly string KeyPairFile2 ;

internal static readonly string PublicKeyFile2 ;

internal static readonly string MaxSizeKeyFile ;

private static bool s_keyInstalled;

internal const string 
TestContainerName = "RoslynTestContainer"
;

internal static readonly ImmutableArray<byte> PublicKey ;

internal static object s_keyInstalledLock ;

internal static unsafe void InstallKey()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25146,2020,2465);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2085,2454) || true) && (f_25146_2089_2121())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,2085,2454);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2161,2179);
                lock (s_keyInstalledLock)
                {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2221,2420) || true) && (!s_keyInstalled)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,2221,2420);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2290,2349);

f_25146_2290_2348(f_25146_2301_2328(), TestContainerName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2375,2397);

s_keyInstalled = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,2221,2420);
}
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,2085,2454);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25146,2020,2465);

bool
f_25146_2089_2121()
{
var return_v = ExecutionConditionUtil.IsWindows;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 2089, 2121);
return return_v;
}


byte[]
f_25146_2301_2328()
{
var return_v = TestResources.General.snKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 2301, 2328);
return return_v;
}


int
f_25146_2290_2348(byte[]
keyBlob,string
keyName)
{
InstallKey( keyBlob, keyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 2290, 2348);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,2020,2465);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,2020,2465);
}
		}

private static unsafe void InstallKey(byte[] keyBlob, string keyName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25146,2477,3104);
            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2607,2692);

IClrStrongName 
strongName = f_25146_2635_2691(f_25146_2635_2666())
;

                //EDMAURER use marshal to be safe?
                fixed (byte* 
p = keyBlob
)
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,2830,2898);

f_25146_2830_2897(                    strongName, keyName, p, f_25146_2882_2896(keyBlob));
                }
            }
            catch (COMException ex)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(25146,2946,3093);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,3002,3078) || true) && (unchecked((uint)f_25146_3022_3034(ex)) != 0x8009000F)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,3002,3078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,3072,3078);

throw;
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,3002,3078);
}
DynAbs.Tracing.TraceSender.TraceExitCatch(25146,2946,3093);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25146,2477,3104);

Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_25146_2635_2666()
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 2635, 2666);
return return_v;
}


Microsoft.CodeAnalysis.Interop.IClrStrongName
f_25146_2635_2691(Microsoft.CodeAnalysis.DesktopStrongNameProvider
this_param)
{
var return_v = this_param.GetStrongNameInterface();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 2635, 2691);
return return_v;
}


int
f_25146_2882_2896(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 2882, 2896);
return return_v;
}


unsafe int
f_25146_2830_2897(Microsoft.CodeAnalysis.Interop.IClrStrongName
this_param,string
pwzKeyContainer,byte*
pbKeyBlob,int
cbKeyBlob)
{
this_param.StrongNameKeyInstall( pwzKeyContainer, (System.IntPtr)pbKeyBlob, cbKeyBlob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 2830, 2897);
return 0;
}


int
f_25146_3022_3034(System.Runtime.InteropServices.COMException
this_param)
{
var return_v = this_param.ErrorCode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 3022, 3034);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,2477,3104);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,2477,3104);
}
		}
internal sealed class VirtualizedStrongNameFileSystem : StrongNameFileSystem
{
internal VirtualizedStrongNameFileSystem(string tempPath = null) :base(f_25146_3289_3297_C(tempPath) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25146,3217,3330);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25146,3217,3330);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,3217,3330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,3217,3330);
}
		}

private static bool PathEquals(string left, string right)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25146,3344,3657);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,3434,3642);

return f_25146_3441_3641(f_25146_3477_3518(left), f_25146_3541_3583(right), StringComparison.OrdinalIgnoreCase);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25146,3344,3657);

string
f_25146_3477_3518(string
path)
{
var return_v = FileUtilities.NormalizeAbsolutePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3477, 3518);
return return_v;
}


string
f_25146_3541_3583(string
path)
{
var return_v = FileUtilities.NormalizeAbsolutePath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3541, 3583);
return return_v;
}


bool
f_25146_3441_3641(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3441, 3641);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,3344,3657);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,3344,3657);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool FileExists(string fullPath)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25146,3673,3851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,3756,3836);

return f_25146_3763_3796(fullPath, KeyPairFile)||(DynAbs.Tracing.TraceSender.Expression_False(25146, 3763, 3835)||f_25146_3800_3835(fullPath, PublicKeyFile));
DynAbs.Tracing.TraceSender.TraceExitMethod(25146,3673,3851);

bool
f_25146_3763_3796(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3763, 3796);
return return_v;
}


bool
f_25146_3800_3835(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3800, 3835);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,3673,3851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,3673,3851);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override byte[] ReadAllBytes(string fullPath)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25146,3867,4836);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,3954,4741) || true) && (f_25146_3958_3991(fullPath, KeyPairFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,3954,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4033,4068);

return f_25146_4040_4067();
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,3954,4741);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,3954,4741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4110,4741) || true) && (f_25146_4114_4149(fullPath, PublicKeyFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4110,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4191,4232);

return f_25146_4198_4231();
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4110,4741);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4110,4741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4274,4741) || true) && (f_25146_4278_4312(fullPath, KeyPairFile2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4274,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4354,4390);

return f_25146_4361_4389();
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4274,4741);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4274,4741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4432,4741) || true) && (f_25146_4436_4472(fullPath, PublicKeyFile2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4432,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4514,4556);

return f_25146_4521_4555();
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4432,4741);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4432,4741);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4598,4741) || true) && (f_25146_4602_4638(fullPath, MaxSizeKeyFile))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25146,4598,4741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4680,4722);

return f_25146_4687_4721();
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4598,4741);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4432,4741);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4274,4741);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,4110,4741);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25146,3954,4741);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,4761,4821);

throw f_25146_4767_4820("File not found", fullPath);
DynAbs.Tracing.TraceSender.TraceExitMethod(25146,3867,4836);

bool
f_25146_3958_3991(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 3958, 3991);
return return_v;
}


byte[]
f_25146_4040_4067()
{
var return_v = TestResources.General.snKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 4040, 4067);
return return_v;
}


bool
f_25146_4114_4149(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 4114, 4149);
return return_v;
}


byte[]
f_25146_4198_4231()
{
var return_v = TestResources.General.snPublicKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 4198, 4231);
return return_v;
}


bool
f_25146_4278_4312(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 4278, 4312);
return return_v;
}


byte[]
f_25146_4361_4389()
{
var return_v = TestResources.General.snKey2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 4361, 4389);
return return_v;
}


bool
f_25146_4436_4472(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 4436, 4472);
return return_v;
}


byte[]
f_25146_4521_4555()
{
var return_v = TestResources.General.snPublicKey2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 4521, 4555);
return return_v;
}


bool
f_25146_4602_4638(string
left,string
right)
{
var return_v = PathEquals( left, right);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 4602, 4638);
return return_v;
}


byte[]
f_25146_4687_4721()
{
var return_v = TestResources.General.snMaxSizeKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 4687, 4721);
return return_v;
}


System.IO.FileNotFoundException
f_25146_4767_4820(string
message,string
fileName)
{
var return_v = new System.IO.FileNotFoundException( message, fileName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 4767, 4820);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25146,3867,4836);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,3867,4836);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static VirtualizedStrongNameFileSystem()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25146,3116,4847);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25146,3116,4847);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,3116,4847);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25146,3116,4847);

static string?
f_25146_3289_3297_C(string?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25146, 3217, 3330);
return return_v;
}

}

static SigningTestHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25146,510,4854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,609,755);
DefaultDesktopStrongNameProvider = f_25146_657_755(ImmutableArray<string>.Empty, f_25146_717_754());DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,861,973);
KeyFileDirectory = (DynAbs.Tracing.TraceSender.Conditional_F1(25146, 880, 912)||((f_25146_880_912()&&DynAbs.Tracing.TraceSender.Conditional_F2(25146, 928, 943))||DynAbs.Tracing.TraceSender.Conditional_F3(25146, 959, 973)))?@"R:\__Test__\"
:"/r/__Test__/";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1016,1086);
KeyPairFile = KeyFileDirectory + @"KeyPair_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(),25146,1063,1077)+ ".snk";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1129,1203);
PublicKeyFile = KeyFileDirectory + @"PublicKey_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(),25146,1180,1194)+ ".snk";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1248,1320);
KeyPairFile2 = KeyFileDirectory + @"KeyPair2_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(),25146,1297,1311)+ ".snk";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1363,1439);
PublicKeyFile2 = KeyFileDirectory + @"PublicKey2_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(),25146,1416,1430)+ ".snk";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1484,1560);
MaxSizeKeyFile = KeyFileDirectory + @"MaxSizeKey_" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Guid.NewGuid()).ToString(),25146,1537,1551)+ ".snk";DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1593,1607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1640,1681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1740,1808);
PublicKey = f_25146_1752_1808(f_25146_1774_1807());DynAbs.Tracing.TraceSender.TraceSimpleStatement(25146,1844,1877);
s_keyInstalledLock = f_25146_1865_1877();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25146,510,4854);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25146,510,4854);
}


static Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
f_25146_717_754()
{
var return_v = new Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 717, 754);
return return_v;
}


static Microsoft.CodeAnalysis.DesktopStrongNameProvider
f_25146_657_755(System.Collections.Immutable.ImmutableArray<string>
keyFileSearchPaths,Roslyn.Test.Utilities.SigningTestHelpers.VirtualizedStrongNameFileSystem
strongNameFileSystem)
{
var return_v = new Microsoft.CodeAnalysis.DesktopStrongNameProvider( keyFileSearchPaths, (Microsoft.CodeAnalysis.StrongNameFileSystem)strongNameFileSystem);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 657, 755);
return return_v;
}


static bool
f_25146_880_912()
{
var return_v = ExecutionConditionUtil.IsWindows
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 880, 912);
return return_v;
}


static byte[]
f_25146_1774_1807()
{
var return_v = TestResources.General.snPublicKey;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25146, 1774, 1807);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<byte>
f_25146_1752_1808(params byte[]
items)
{
var return_v = ImmutableArray.Create( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 1752, 1808);
return return_v;
}


static object
f_25146_1865_1877()
{
var return_v = new object();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25146, 1865, 1877);
return return_v;
}

}
}
