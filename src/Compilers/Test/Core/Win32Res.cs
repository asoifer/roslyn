// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class Win32Res
{
[DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);

[DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);

[DllImport("kernel32.dll")]
        private static extern IntPtr LockResource(IntPtr hResData);

[DllImport("kernel32.dll", SetLastError = true)]
        private static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);

public static IntPtr GetResource(IntPtr lib, string resourceId, string resourceType, out uint size)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,1075,1804);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1199,1258);

IntPtr 
hrsrc = f_25044_1214_1257(lib, resourceId, resourceType)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1272,1369) || true) && (hrsrc == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,1272,1369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1315,1369);

throw f_25044_1321_1368(f_25044_1340_1367());
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,1272,1369);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1385,1419);

size = f_25044_1392_1418(lib, hrsrc);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1433,1476);

IntPtr 
resource = f_25044_1451_1475(lib, hrsrc)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1490,1590) || true) && (resource == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,1490,1590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1536,1590);

throw f_25044_1542_1589(f_25044_1561_1588());
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,1490,1590);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1606,1647);

IntPtr 
manifest = f_25044_1624_1646(resource)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1661,1761) || true) && (resource == IntPtr.Zero)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,1661,1761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1707,1761);

throw f_25044_1713_1760(f_25044_1732_1759());
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,1661,1761);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1777,1793);

return manifest;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,1075,1804);

System.IntPtr
f_25044_1214_1257(System.IntPtr
hModule,string
lpName,string
lpType)
{
var return_v = FindResource( hModule, lpName, lpType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1214, 1257);
return return_v;
}


int
f_25044_1340_1367()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1340, 1367);
return return_v;
}


System.ComponentModel.Win32Exception
f_25044_1321_1368(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1321, 1368);
return return_v;
}


uint
f_25044_1392_1418(System.IntPtr
hModule,System.IntPtr
hResInfo)
{
var return_v = SizeofResource( hModule, hResInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1392, 1418);
return return_v;
}


System.IntPtr
f_25044_1451_1475(System.IntPtr
hModule,System.IntPtr
hResInfo)
{
var return_v = LoadResource( hModule, hResInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1451, 1475);
return return_v;
}


int
f_25044_1561_1588()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1561, 1588);
return return_v;
}


System.ComponentModel.Win32Exception
f_25044_1542_1589(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1542, 1589);
return return_v;
}


System.IntPtr
f_25044_1624_1646(System.IntPtr
hResData)
{
var return_v = LockResource( hResData);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1624, 1646);
return return_v;
}


int
f_25044_1732_1759()
{
var return_v = Marshal.GetLastWin32Error();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1732, 1759);
return return_v;
}


System.ComponentModel.Win32Exception
f_25044_1713_1760(int
error)
{
var return_v = new System.ComponentModel.Win32Exception( error);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1713, 1760);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,1075,1804);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,1075,1804);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetManifestString(IntPtr ptr, int offset, int length, Encoding encoding)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,1816,2127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1935,1971);

byte[] 
fullmanif = new byte[length]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,1985,2054);

f_25044_1985_2053((ptr.ToInt64()+ offset), fullmanif, 0, length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2068,2116);

return f_25044_2075_2115(encoding, fullmanif, 0, length);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,1816,2127);

int
f_25044_1985_2053(long
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( (System.IntPtr)source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 1985, 2053);
return 0;
}


string
f_25044_2075_2115(System.Text.Encoding
this_param,byte[]
bytes,int
index,int
count)
{
var return_v = this_param.GetString( bytes, index, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 2075, 2115);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,1816,2127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,1816,2127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetDecodedManifest(IntPtr mfRsrc, uint rsrcSize)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,2139,3441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2234,2258);

byte[] 
ar = new byte[3]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2272,2303);

f_25044_2272_2302(mfRsrc, ar, 0, 3);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2317,2333);

string 
xmlManif
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2347,2365);

Encoding 
encoding
=default(Encoding);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2421,3398) || true) && (ar[0] == 0xFF &&(DynAbs.Tracing.TraceSender.Expression_True(25044, 2425, 2455)&&ar[1] == 0xFE))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2421,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2489,2517);

encoding = f_25044_2500_2516();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2535,2604);

xmlManif = f_25044_2546_2603(mfRsrc, 2, (int)rsrcSize - 2, encoding);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2421,3398);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2421,3398);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2678,3398) || true) && (ar[0] == 0xFE &&(DynAbs.Tracing.TraceSender.Expression_True(25044, 2682, 2712)&&ar[1] == 0xFF))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2678,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2746,2783);

encoding = f_25044_2757_2782();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2801,2870);

xmlManif = f_25044_2812_2869(mfRsrc, 2, (int)rsrcSize - 2, encoding);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2678,3398);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2678,3398);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,2929,3398) || true) && (ar[0] == 0xEF &&(DynAbs.Tracing.TraceSender.Expression_True(25044, 2933, 2963)&&ar[1] == 0xBB )&&(DynAbs.Tracing.TraceSender.Expression_True(25044, 2933, 2980)&&ar[2] == 0xBF))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2929,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3014,3039);

encoding = f_25044_3025_3038();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3057,3126);

xmlManif = f_25044_3068_3125(mfRsrc, 3, (int)rsrcSize - 3, encoding);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2929,3398);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,2929,3398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3274,3300);

encoding = f_25044_3285_3299();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3318,3383);

xmlManif = f_25044_3329_3382(mfRsrc, 0, rsrcSize, encoding);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2929,3398);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2678,3398);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,2421,3398);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3414,3430);

return xmlManif;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,2139,3441);

int
f_25044_2272_2302(System.IntPtr
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 2272, 2302);
return 0;
}


System.Text.Encoding
f_25044_2500_2516()
{
var return_v = Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 2500, 2516);
return return_v;
}


string
f_25044_2546_2603(System.IntPtr
ptr,int
offset,int
length,System.Text.Encoding
encoding)
{
var return_v = GetManifestString( ptr, offset, length, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 2546, 2603);
return return_v;
}


System.Text.Encoding
f_25044_2757_2782()
{
var return_v = Encoding.BigEndianUnicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 2757, 2782);
return return_v;
}


string
f_25044_2812_2869(System.IntPtr
ptr,int
offset,int
length,System.Text.Encoding
encoding)
{
var return_v = GetManifestString( ptr, offset, length, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 2812, 2869);
return return_v;
}


System.Text.Encoding
f_25044_3025_3038()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 3025, 3038);
return return_v;
}


string
f_25044_3068_3125(System.IntPtr
ptr,int
offset,int
length,System.Text.Encoding
encoding)
{
var return_v = GetManifestString( ptr, offset, length, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3068, 3125);
return return_v;
}


System.Text.Encoding
f_25044_3285_3299()
{
var return_v = Encoding.ASCII;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 3285, 3299);
return return_v;
}


string
f_25044_3329_3382(System.IntPtr
ptr,int
offset,uint
length,System.Text.Encoding
encoding)
{
var return_v = GetManifestString( ptr, offset, (int)length, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3329, 3382);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,2139,3441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,2139,3441);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string ManifestResourceToXml(IntPtr mftRsrc, uint size)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,3453,4317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3547,3573);

var 
doc = f_25044_3557_3572()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3587,4153);
using(XmlWriter 
xw = f_25044_3609_3627(doc)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3661,3685);

f_25044_3661_3684(                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3703,3744);

f_25044_3703_3743(                xw, "ManifestResource");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3762,3811);

f_25044_3762_3810(                xw, "Size", f_25044_3794_3809(size));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3829,3862);

f_25044_3829_3861(                xw, "Contents");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3880,3929);

f_25044_3880_3928(                xw, f_25044_3894_3927(mftRsrc, size));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,3947,3968);

f_25044_3947_3967(                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4077,4098);

f_25044_4077_4097(
                //xw.WriteAttributeString("Data", GetDecodedManifest(mftRsrc, size));

                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4116,4138);

f_25044_4116_4137(                xw);
DynAbs.Tracing.TraceSender.TraceExitUsing(25044,3587,4153);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4167,4244);

var 
sw = f_25044_4176_4243(f_25044_4193_4242())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4258,4271);

f_25044_4258_4270(            doc, sw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4285,4306);

return f_25044_4292_4305(sw);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,3453,4317);

System.Xml.Linq.XDocument
f_25044_3557_3572()
{
var return_v = new System.Xml.Linq.XDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3557, 3572);
return return_v;
}


System.Xml.XmlWriter
f_25044_3609_3627(System.Xml.Linq.XDocument
this_param)
{
var return_v = this_param.CreateWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3609, 3627);
return return_v;
}


int
f_25044_3661_3684(System.Xml.XmlWriter
this_param)
{
this_param.WriteStartDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3661, 3684);
return 0;
}


int
f_25044_3703_3743(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3703, 3743);
return 0;
}


string
f_25044_3794_3809(uint
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3794, 3809);
return return_v;
}


int
f_25044_3762_3810(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3762, 3810);
return 0;
}


int
f_25044_3829_3861(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3829, 3861);
return 0;
}


string
f_25044_3894_3927(System.IntPtr
mfRsrc,uint
rsrcSize)
{
var return_v = GetDecodedManifest( mfRsrc, rsrcSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3894, 3927);
return return_v;
}


int
f_25044_3880_3928(System.Xml.XmlWriter
this_param,string
text)
{
this_param.WriteCData( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3880, 3928);
return 0;
}


int
f_25044_3947_3967(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 3947, 3967);
return 0;
}


int
f_25044_4077_4097(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4077, 4097);
return 0;
}


int
f_25044_4116_4137(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4116, 4137);
return 0;
}


System.Globalization.CultureInfo
f_25044_4193_4242()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 4193, 4242);
return return_v;
}


System.IO.StringWriter
f_25044_4176_4243(System.Globalization.CultureInfo
formatProvider)
{
var return_v = new System.IO.StringWriter( (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4176, 4243);
return return_v;
}


int
f_25044_4258_4270(System.Xml.Linq.XDocument
this_param,System.IO.StringWriter
textWriter)
{
this_param.Save( (System.IO.TextWriter)textWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4258, 4270);
return 0;
}


string
f_25044_4292_4305(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4292, 4305);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,3453,4317);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,3453,4317);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string ReadString(BinaryReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,4329,4701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4407,4417);

int 
i = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4431,4458);

var 
cbuffer = new char[16]
;
{try {
do

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,4472,4618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4507,4538);

cbuffer[i] = f_25044_4520_4537(reader);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,4472,4618);
}
            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4472,4618) || true) && (cbuffer[i] != '\0' &&(DynAbs.Tracing.TraceSender.Expression_True(25044, 4574, 4616)&&++i < f_25044_4602_4616(cbuffer)))
);
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,4472,4618);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,4472,4618);
}}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4634,4690);

return f_25044_4641_4689(f_25044_4641_4660(cbuffer), new char[] { '\0' });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,4329,4701);

char
f_25044_4520_4537(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4520, 4537);
return return_v;
}


int
f_25044_4602_4616(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 4602, 4616);
return return_v;
}


string
f_25044_4641_4660(char[]
value)
{
var return_v = new string( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4641, 4660);
return return_v;
}


string
f_25044_4641_4689(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimEnd( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4641, 4689);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,4329,4701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,4329,4701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void ReadVarFileInfo(BinaryReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,4713,5321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4794,4804);

ushort 
us
=default(ushort);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4818,4827);

string 
s
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4843,4868);

us = f_25044_4848_4867(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4882,4907);

us = f_25044_4887_4906(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4928,4953);

us = f_25044_4933_4952(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,4974,4997);

s = f_25044_4978_4996(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5038,5105);

f_25044_5038_5055(reader).Position = (f_25044_5068_5094(f_25044_5068_5085(reader))+ 3) & ~3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5150,5175);

us = f_25044_5155_5174(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5249,5274);

us = f_25044_5254_5273(reader);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,4713,5321);

ushort
f_25044_4848_4867(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4848, 4867);
return return_v;
}


ushort
f_25044_4887_4906(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4887, 4906);
return return_v;
}


ushort
f_25044_4933_4952(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4933, 4952);
return return_v;
}


string
f_25044_4978_4996(System.IO.BinaryReader
reader)
{
var return_v = ReadString( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 4978, 4996);
return return_v;
}


System.IO.Stream
f_25044_5038_5055(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5038, 5055);
return return_v;
}


System.IO.Stream
f_25044_5068_5085(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5068, 5085);
return return_v;
}


long
f_25044_5068_5094(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5068, 5094);
return return_v;
}


ushort
f_25044_5155_5174(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5155, 5174);
return return_v;
}


ushort
f_25044_5254_5273(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5254, 5273);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,4713,5321);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,4713,5321);
}
		}

public static IEnumerable<Tuple<string, string>> ReadStringFileInfo(BinaryReader reader, int sizeTotalStringFileInfo)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,5333,6302);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5475,5522);

var 
result = f_25044_5488_5521()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5536,5576);

int 
sizeConsumed = 2 + 2 + 2 + (16 * 2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5590,5638);

long 
startPosition = f_25044_5611_5637(f_25044_5611_5628(reader))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5654,5663);

string 
s
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5679,5699);

f_25044_5679_5698(
            reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5724,5744);

f_25044_5724_5743(            reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5765,5785);

f_25044_5765_5784(            reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5806,5829);

s = f_25044_5810_5828(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5859,5926);

f_25044_5859_5876(reader).Position = (f_25044_5889_5915(f_25044_5889_5906(reader))+ 3) & ~3;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,5971,6261) || true) && (f_25044_5978_6004(f_25044_5978_5995(reader))- startPosition + sizeConsumed < sizeTotalStringFileInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,5971,6261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6095,6132);

f_25044_6095_6131(                result, f_25044_6106_6130(reader));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6150,6217);

f_25044_6150_6167(reader).Position = (f_25044_6180_6206(f_25044_6180_6197(reader))+ 3) & ~3;
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,5971,6261);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,5971,6261);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,5971,6261);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6277,6291);

return result;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,5333,6302);

System.Collections.Generic.List<System.Tuple<string, string>>
f_25044_5488_5521()
{
var return_v = new System.Collections.Generic.List<System.Tuple<string, string>>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5488, 5521);
return return_v;
}


System.IO.Stream
f_25044_5611_5628(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5611, 5628);
return return_v;
}


long
f_25044_5611_5637(System.IO.Stream
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5611, 5637);
return return_v;
}


ushort
f_25044_5679_5698(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5679, 5698);
return return_v;
}


ushort
f_25044_5724_5743(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5724, 5743);
return return_v;
}


ushort
f_25044_5765_5784(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5765, 5784);
return return_v;
}


string
f_25044_5810_5828(System.IO.BinaryReader
reader)
{
var return_v = ReadString( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 5810, 5828);
return return_v;
}


System.IO.Stream
f_25044_5859_5876(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5859, 5876);
return return_v;
}


System.IO.Stream
f_25044_5889_5906(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5889, 5906);
return return_v;
}


long
f_25044_5889_5915(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5889, 5915);
return return_v;
}


System.IO.Stream
f_25044_5978_5995(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5978, 5995);
return return_v;
}


long
f_25044_5978_6004(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 5978, 6004);
return return_v;
}


System.Tuple<string, string>
f_25044_6106_6130(System.IO.BinaryReader
reader)
{
var return_v = GetVerStringPair( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6106, 6130);
return return_v;
}


int
f_25044_6095_6131(System.Collections.Generic.List<System.Tuple<string, string>>
this_param,System.Tuple<string, string>
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6095, 6131);
return 0;
}


System.IO.Stream
f_25044_6150_6167(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 6150, 6167);
return return_v;
}


System.IO.Stream
f_25044_6180_6197(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 6180, 6197);
return return_v;
}


long
f_25044_6180_6206(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 6180, 6206);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,5333,6302);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,5333,6302);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string VersionResourceToXml(IntPtr versionRsrc)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,6314,10231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6400,6430);

var 
shortArray = new short[1]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6444,6488);

f_25044_6444_6487(versionRsrc, shortArray, 0, 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6502,6527);

int 
size = shortArray[0]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6543,6584);

var 
entireResourceBytes = new byte[size]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6598,6676);

f_25044_6598_6675(versionRsrc, entireResourceBytes, 0, f_25044_6648_6674(entireResourceBytes));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6692,6749);

var 
memoryStream = f_25044_6711_6748(entireResourceBytes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6763,6825);

var 
reader = f_25044_6776_6824(memoryStream, f_25044_6807_6823())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6841,6867);

var 
doc = f_25044_6851_6866()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6881,10067);
using(XmlWriter 
xw = f_25044_6903_6921(doc)
)            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6955,6979);

f_25044_6955_6978(                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,6997,7037);

f_25044_6997_7036(                xw, "VersionResource");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7055,7104);

f_25044_7055_7103(                xw, "Size", f_25044_7087_7102(size));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7185,7232);

f_25044_7185_7231(f_25044_7185_7202(reader), 0x28, SeekOrigin.Begin);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7316,7364);

f_25044_7316_7363(f_25044_7316_7333(reader), 0x8, SeekOrigin.Current);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7384,7425);

f_25044_7384_7424(
                xw, "VS_FIXEDFILEINFO");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7443,7530);

f_25044_7443_7529(                xw, "FileVersionMS", f_25044_7484_7528("{0:x8}", f_25044_7508_7527(reader)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7548,7635);

f_25044_7548_7634(                xw, "FileVersionLS", f_25044_7589_7633("{0:x8}", f_25044_7613_7632(reader)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7653,7743);

f_25044_7653_7742(                xw, "ProductVersionMS", f_25044_7697_7741("{0:x8}", f_25044_7721_7740(reader)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7761,7851);

f_25044_7761_7850(                xw, "ProductVersionLS", f_25044_7805_7849("{0:x8}", f_25044_7829_7848(reader)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7869,7890);

f_25044_7869_7889(                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7910,7917);

long 
l
=default(long);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,7935,7959);

l = f_25044_7939_7958(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8071,8095);

l = f_25044_8075_8094(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8143,8167);

l = f_25044_8147_8166(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8227,8251);

l = f_25044_8231_8250(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8295,8319);

l = f_25044_8299_8318(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8369,8393);

l = f_25044_8373_8392(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8444,8468);

l = f_25044_8448_8467(reader);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8639,9971) || true) && (f_25044_8646_8672(f_25044_8646_8663(reader))< size)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,8639,9971);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8721,8731);

ushort 
us
=default(ushort);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8753,8762);

string 
s
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8786,8822);

ushort 
length = f_25044_8802_8821(reader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8844,8869);

us = f_25044_8849_8868(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,8898,8923);

us = f_25044_8903_8922(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9034,9057);

s = f_25044_9038_9056(reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9079,9146);

f_25044_9079_9096(reader).Position = (f_25044_9109_9135(f_25044_9109_9126(reader))+ 3) & ~3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9199,9246);

IEnumerable<Tuple<string, string>> 
keyValPairs
=default(IEnumerable<Tuple<string, string>>);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9268,9952) || true) && (s == "VarFileInfo")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,9268,9952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9317,9341);

f_25044_9317_9340(reader);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,9268,9952);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,9268,9952);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9368,9952) || true) && (s == "StringFileInfo")
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,9368,9952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9443,9492);

keyValPairs = f_25044_9457_9491(reader, length);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9518,9929);
foreach(var pair in f_25044_9539_9550_I(keyValPairs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,9518,9929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9608,9645);

f_25044_9608_9644(                            xw, "KeyValuePair");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9675,9747);

f_25044_9675_9746(                            xw, "Key", f_25044_9706_9745(f_25044_9706_9716(pair), new char[] { '\0' }));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9777,9851);

f_25044_9777_9850(                            xw, "Value", f_25044_9810_9849(f_25044_9810_9820(pair), new char[] { '\0' }));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9881,9902);

f_25044_9881_9901(                            xw);
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,9518,9929);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,1,412);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,1,412);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25044,9368,9952);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,9268,9952);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25044,8639,9971);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,8639,9971);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,8639,9971);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,9991,10012);

f_25044_9991_10011(
                xw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10030,10052);

f_25044_10030_10051(                xw);
DynAbs.Tracing.TraceSender.TraceExitUsing(25044,6881,10067);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10081,10158);

var 
sw = f_25044_10090_10157(f_25044_10107_10156())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10172,10185);

f_25044_10172_10184(            doc, sw);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10199,10220);

return f_25044_10206_10219(sw);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,6314,10231);

int
f_25044_6444_6487(System.IntPtr
source,short[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6444, 6487);
return 0;
}


int
f_25044_6648_6674(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 6648, 6674);
return return_v;
}


int
f_25044_6598_6675(System.IntPtr
source,byte[]
destination,int
startIndex,int
length)
{
Marshal.Copy( source, destination, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6598, 6675);
return 0;
}


System.IO.MemoryStream
f_25044_6711_6748(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6711, 6748);
return return_v;
}


System.Text.Encoding
f_25044_6807_6823()
{
var return_v = Encoding.Unicode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 6807, 6823);
return return_v;
}


System.IO.BinaryReader
f_25044_6776_6824(System.IO.MemoryStream
input,System.Text.Encoding
encoding)
{
var return_v = new System.IO.BinaryReader( (System.IO.Stream)input, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6776, 6824);
return return_v;
}


System.Xml.Linq.XDocument
f_25044_6851_6866()
{
var return_v = new System.Xml.Linq.XDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6851, 6866);
return return_v;
}


System.Xml.XmlWriter
f_25044_6903_6921(System.Xml.Linq.XDocument
this_param)
{
var return_v = this_param.CreateWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6903, 6921);
return return_v;
}


int
f_25044_6955_6978(System.Xml.XmlWriter
this_param)
{
this_param.WriteStartDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6955, 6978);
return 0;
}


int
f_25044_6997_7036(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 6997, 7036);
return 0;
}


string
f_25044_7087_7102(int
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7087, 7102);
return return_v;
}


int
f_25044_7055_7103(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7055, 7103);
return 0;
}


System.IO.Stream
f_25044_7185_7202(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 7185, 7202);
return return_v;
}


long
f_25044_7185_7231(System.IO.Stream
this_param,int
offset,System.IO.SeekOrigin
origin)
{
var return_v = this_param.Seek( (long)offset, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7185, 7231);
return return_v;
}


System.IO.Stream
f_25044_7316_7333(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 7316, 7333);
return return_v;
}


long
f_25044_7316_7363(System.IO.Stream
this_param,int
offset,System.IO.SeekOrigin
origin)
{
var return_v = this_param.Seek( (long)offset, origin);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7316, 7363);
return return_v;
}


int
f_25044_7384_7424(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7384, 7424);
return 0;
}


uint
f_25044_7508_7527(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7508, 7527);
return return_v;
}


string
f_25044_7484_7528(string
format,uint
arg0)
{
var return_v = String.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7484, 7528);
return return_v;
}


int
f_25044_7443_7529(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7443, 7529);
return 0;
}


uint
f_25044_7613_7632(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7613, 7632);
return return_v;
}


string
f_25044_7589_7633(string
format,uint
arg0)
{
var return_v = String.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7589, 7633);
return return_v;
}


int
f_25044_7548_7634(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7548, 7634);
return 0;
}


uint
f_25044_7721_7740(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7721, 7740);
return return_v;
}


string
f_25044_7697_7741(string
format,uint
arg0)
{
var return_v = String.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7697, 7741);
return return_v;
}


int
f_25044_7653_7742(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7653, 7742);
return 0;
}


uint
f_25044_7829_7848(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7829, 7848);
return return_v;
}


string
f_25044_7805_7849(string
format,uint
arg0)
{
var return_v = String.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7805, 7849);
return return_v;
}


int
f_25044_7761_7850(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7761, 7850);
return 0;
}


int
f_25044_7869_7889(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7869, 7889);
return 0;
}


uint
f_25044_7939_7958(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 7939, 7958);
return return_v;
}


uint
f_25044_8075_8094(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8075, 8094);
return return_v;
}


uint
f_25044_8147_8166(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8147, 8166);
return return_v;
}


uint
f_25044_8231_8250(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8231, 8250);
return return_v;
}


uint
f_25044_8299_8318(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8299, 8318);
return return_v;
}


uint
f_25044_8373_8392(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8373, 8392);
return return_v;
}


uint
f_25044_8448_8467(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt32();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8448, 8467);
return return_v;
}


System.IO.Stream
f_25044_8646_8663(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 8646, 8663);
return return_v;
}


long
f_25044_8646_8672(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 8646, 8672);
return return_v;
}


ushort
f_25044_8802_8821(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8802, 8821);
return return_v;
}


ushort
f_25044_8849_8868(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8849, 8868);
return return_v;
}


ushort
f_25044_8903_8922(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 8903, 8922);
return return_v;
}


string
f_25044_9038_9056(System.IO.BinaryReader
reader)
{
var return_v = ReadString( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9038, 9056);
return return_v;
}


System.IO.Stream
f_25044_9079_9096(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 9079, 9096);
return return_v;
}


System.IO.Stream
f_25044_9109_9126(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 9109, 9126);
return return_v;
}


long
f_25044_9109_9135(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 9109, 9135);
return return_v;
}


int
f_25044_9317_9340(System.IO.BinaryReader
reader)
{
ReadVarFileInfo( reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9317, 9340);
return 0;
}


System.Collections.Generic.IEnumerable<System.Tuple<string, string>>
f_25044_9457_9491(System.IO.BinaryReader
reader,ushort
sizeTotalStringFileInfo)
{
var return_v = ReadStringFileInfo( reader, (int)sizeTotalStringFileInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9457, 9491);
return return_v;
}


int
f_25044_9608_9644(System.Xml.XmlWriter
this_param,string
localName)
{
this_param.WriteStartElement( localName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9608, 9644);
return 0;
}


string
f_25044_9706_9716(System.Tuple<string, string>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 9706, 9716);
return return_v;
}


string
f_25044_9706_9745(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimEnd( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9706, 9745);
return return_v;
}


int
f_25044_9675_9746(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9675, 9746);
return 0;
}


string
f_25044_9810_9820(System.Tuple<string, string>
this_param)
{
var return_v = this_param.Item2;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 9810, 9820);
return return_v;
}


string
f_25044_9810_9849(string
this_param,params char[]
trimChars)
{
var return_v = this_param.TrimEnd( trimChars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9810, 9849);
return return_v;
}


int
f_25044_9777_9850(System.Xml.XmlWriter
this_param,string
localName,string
value)
{
this_param.WriteAttributeString( localName, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9777, 9850);
return 0;
}


int
f_25044_9881_9901(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9881, 9901);
return 0;
}


System.Collections.Generic.IEnumerable<System.Tuple<string, string>>
f_25044_9539_9550_I(System.Collections.Generic.IEnumerable<System.Tuple<string, string>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9539, 9550);
return return_v;
}


int
f_25044_9991_10011(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndElement();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 9991, 10011);
return 0;
}


int
f_25044_10030_10051(System.Xml.XmlWriter
this_param)
{
this_param.WriteEndDocument();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10030, 10051);
return 0;
}


System.Globalization.CultureInfo
f_25044_10107_10156()
{
var return_v = System.Globalization.CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 10107, 10156);
return return_v;
}


System.IO.StringWriter
f_25044_10090_10157(System.Globalization.CultureInfo
formatProvider)
{
var return_v = new System.IO.StringWriter( (System.IFormatProvider)formatProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10090, 10157);
return return_v;
}


int
f_25044_10172_10184(System.Xml.Linq.XDocument
this_param,System.IO.StringWriter
textWriter)
{
this_param.Save( (System.IO.TextWriter)textWriter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10172, 10184);
return 0;
}


string
f_25044_10206_10219(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10206, 10219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,6314,10231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,6314,10231);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Tuple<string, string> GetVerStringPair(BinaryReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25044,10243,11611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10342,10413);

f_25044_10342_10412((f_25044_10375_10401(f_25044_10375_10392(reader))& 3) == 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10427,10470);

long 
startPos = f_25044_10443_10469(f_25044_10443_10460(reader))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10486,10519);

int 
length = f_25044_10499_10518(reader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10708,10746);

int 
valueLength = f_25044_10726_10745(reader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10774,10828);

f_25044_10774_10827(length > valueLength);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10844,10875);

int 
type = f_25044_10855_10874(reader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10891,10934);

f_25044_10891_10933(type == 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,10959,11024);

int 
keyLength = length - (valueLength * 2) - (3 * sizeof(short))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11040,11088);

char[] 
key = new char[keyLength / sizeof(char)]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11111,11116);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11102,11183) || true) && (i < f_25044_11122_11132(key))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11134,11137)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25044,11102,11183))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,11102,11183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11156,11183);

key[i] = f_25044_11165_11182(reader);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,1,82);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,1,82);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11199,11266);

f_25044_11199_11216(reader).Position = (f_25044_11229_11255(f_25044_11229_11246(reader))+ 3) & ~3;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11282,11319);

char[] 
value = new char[valueLength]
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11342,11347);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11333,11418) || true) && (i < f_25044_11353_11365(value))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11367,11370)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25044,11333,11418))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25044,11333,11418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11389,11418);

value[i] = f_25044_11400_11417(reader);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25044,1,86);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25044,1,86);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11434,11517);

f_25044_11434_11516(length == (f_25044_11477_11503(f_25044_11477_11494(reader))- startPos));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25044,11531,11600);

return f_25044_11538_11599(f_25044_11564_11579(key), f_25044_11581_11598(value));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25044,10243,11611);

System.IO.Stream
f_25044_10375_10392(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 10375, 10392);
return return_v;
}


long
f_25044_10375_10401(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 10375, 10401);
return return_v;
}


int
f_25044_10342_10412(bool
condition)
{
System.Diagnostics.Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10342, 10412);
return 0;
}


System.IO.Stream
f_25044_10443_10460(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 10443, 10460);
return return_v;
}


long
f_25044_10443_10469(System.IO.Stream
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 10443, 10469);
return return_v;
}


ushort
f_25044_10499_10518(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10499, 10518);
return return_v;
}


ushort
f_25044_10726_10745(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10726, 10745);
return return_v;
}


int
f_25044_10774_10827(bool
condition)
{
System.Diagnostics.Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10774, 10827);
return 0;
}


ushort
f_25044_10855_10874(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadUInt16();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10855, 10874);
return return_v;
}


int
f_25044_10891_10933(bool
condition)
{
System.Diagnostics.Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 10891, 10933);
return 0;
}


int
f_25044_11122_11132(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11122, 11132);
return return_v;
}


char
f_25044_11165_11182(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11165, 11182);
return return_v;
}


System.IO.Stream
f_25044_11199_11216(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11199, 11216);
return return_v;
}


System.IO.Stream
f_25044_11229_11246(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11229, 11246);
return return_v;
}


long
f_25044_11229_11255(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11229, 11255);
return return_v;
}


int
f_25044_11353_11365(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11353, 11365);
return return_v;
}


char
f_25044_11400_11417(System.IO.BinaryReader
this_param)
{
var return_v = this_param.ReadChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11400, 11417);
return return_v;
}


System.IO.Stream
f_25044_11477_11494(System.IO.BinaryReader
this_param)
{
var return_v = this_param.BaseStream;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11477, 11494);
return return_v;
}


long
f_25044_11477_11503(System.IO.Stream
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25044, 11477, 11503);
return return_v;
}


int
f_25044_11434_11516(bool
condition)
{
System.Diagnostics.Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11434, 11516);
return 0;
}


string
f_25044_11564_11579(char[]
value)
{
var return_v = new string( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11564, 11579);
return return_v;
}


string
f_25044_11581_11598(char[]
value)
{
var return_v = new string( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11581, 11598);
return return_v;
}


System.Tuple<string, string>
f_25044_11538_11599(string
item1,string
item2)
{
var return_v = new System.Tuple<string, string>( item1, item2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25044, 11538, 11599);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25044,10243,11611);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,10243,11611);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public Win32Res()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25044,487,11618);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25044,487,11618);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,487,11618);
}


static Win32Res()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25044,487,11618);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25044,487,11618);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25044,487,11618);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25044,487,11618);
}
}
