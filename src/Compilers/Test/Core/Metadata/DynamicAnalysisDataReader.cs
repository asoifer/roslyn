// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

// TODO (https://github.com/dotnet/testimpact/issues/84): delete this

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis
{

internal struct DynamicAnalysisDocument
    {

public readonly BlobHandle Name;

public readonly GuidHandle HashAlgorithm;

public readonly BlobHandle Hash;

public DynamicAnalysisDocument(BlobHandle name, GuidHandle hashAlgorithm, BlobHandle hash)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25103,854,1062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,969,981);

Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,995,1025);

HashAlgorithm = hashAlgorithm;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1039,1051);

Hash = hash;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25103,854,1062);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,854,1062);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,854,1062);
}
		}
static DynamicAnalysisDocument(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25103,661,1069);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25103,661,1069);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,661,1069);
}
    }

internal struct DynamicAnalysisMethod
    {

public readonly BlobHandle Blob;

public DynamicAnalysisMethod(BlobHandle blob)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25103,1175,1268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1245,1257);

Blob = blob;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25103,1175,1268);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,1175,1268);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,1175,1268);
}
		}
static DynamicAnalysisMethod(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25103,1077,1275);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25103,1077,1275);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,1077,1275);
}
    }

internal struct DynamicAnalysisSpan
    {

public readonly int DocumentRowId;

public readonly int StartLine;

public readonly int StartColumn;

public readonly int EndLine;

public readonly int EndColumn;

public DynamicAnalysisSpan(int documentRowId, int startLine, int startColumn, int endLine, int endColumn)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25103,1541,1856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1671,1701);

DocumentRowId = documentRowId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1715,1737);

StartLine = startLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1751,1777);

StartColumn = startColumn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1791,1809);

EndLine = endLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,1823,1845);

EndColumn = endColumn;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25103,1541,1856);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,1541,1856);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,1541,1856);
}
		}
static DynamicAnalysisSpan(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25103,1283,1863);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25103,1283,1863);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,1283,1863);
}
    }
internal sealed unsafe class DynamicAnalysisDataReader
{
public ImmutableArray<DynamicAnalysisDocument> Documents {get; }

public ImmutableArray<DynamicAnalysisMethod> Methods {get; }

private readonly Blob _guidHeapBlob;

private readonly Blob _blobHeapBlob;

private const int 
GuidSize = 16
;

public DynamicAnalysisDataReader(byte* buffer, int size)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25103,2228,5114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2309,2351);

var 
reader = f_25103_2322_2350(buffer, size)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2391,2588) || true) && (reader.ReadByte()!= 'D' ||(DynAbs.Tracing.TraceSender.Expression_False(25103, 2395, 2447)||reader.ReadByte()!= 'A' )||(DynAbs.Tracing.TraceSender.Expression_False(25103, 2395, 2475)||reader.ReadByte()!= 'M' )||(DynAbs.Tracing.TraceSender.Expression_False(25103, 2395, 2503)||reader.ReadByte()!= 'D'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,2391,2588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2537,2573);

throw f_25103_2543_2572();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,2391,2588);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2628,2659);

byte 
major = reader.ReadByte()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2673,2704);

byte 
minor = reader.ReadByte()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2718,2841) || true) && (major != 0 ||(DynAbs.Tracing.TraceSender.Expression_False(25103, 2722, 2745)||minor < 1 )||(DynAbs.Tracing.TraceSender.Expression_False(25103, 2722, 2758)||minor > 2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,2718,2841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2792,2826);

throw f_25103_2798_2825();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,2718,2841);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2886,2928);

int 
documentRowCount = reader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2942,2986);

int 
methodSpanRowCount = reader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3035,3094);

int 
stringHeapSize = (DynAbs.Tracing.TraceSender.Conditional_F1(25103, 3056, 3068)||(((minor == 1) &&DynAbs.Tracing.TraceSender.Conditional_F2(25103, 3071, 3089))||DynAbs.Tracing.TraceSender.Conditional_F3(25103, 3092, 3093)))?reader.ReadInt32():0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3108,3171);

int 
userStringHeapSize = (DynAbs.Tracing.TraceSender.Conditional_F1(25103, 3133, 3145)||(((minor == 1) &&DynAbs.Tracing.TraceSender.Conditional_F2(25103, 3148, 3166))||DynAbs.Tracing.TraceSender.Conditional_F3(25103, 3169, 3170)))?reader.ReadInt32():0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3185,3223);

int 
guidHeapSize = reader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3237,3275);

int 
blobHeapSize = reader.ReadInt32()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3333,3388);

bool 
isBlobHeapSmall = blobHeapSize <= ushort.MaxValue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3402,3468);

bool 
isGuidHeapSmall = guidHeapSize / GuidSize <= ushort.MaxValue
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3484,3575);

var 
documentsBuilder = f_25103_3507_3574(documentRowCount)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3600,3605);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3591,4066) || true) && (i < documentRowCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3629,3632)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25103,3591,4066))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,3591,4066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3666,3747);

var 
name = f_25103_3677_3746(f_25103_3703_3745(ref reader, isBlobHeapSmall))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3765,3855);

var 
hashAlgorithm = f_25103_3785_3854(f_25103_3811_3853(ref reader, isGuidHeapSmall))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3873,3954);

var 
hash = f_25103_3884_3953(f_25103_3910_3952(ref reader, isBlobHeapSmall))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,3974,4051);

f_25103_3974_4050(
                documentsBuilder, f_25103_3995_4049(name, hashAlgorithm, hash));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25103,1,476);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25103,1,476);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4082,4132);

Documents = f_25103_4094_4131(documentsBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4148,4237);

var 
methodsBuilder = f_25103_4169_4236(methodSpanRowCount)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4262,4267);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4253,4462) || true) && (i < methodSpanRowCount)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4293,4296)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25103,4253,4462))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,4253,4462);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4330,4447);

f_25103_4330_4446(                methodsBuilder, f_25103_4349_4445(f_25103_4375_4444(f_25103_4401_4443(ref reader, isBlobHeapSmall))));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25103,1,210);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25103,1,210);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4478,4524);

Methods = f_25103_4488_4523(methodsBuilder);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4540,4577);

int 
stringHeapOffset = reader.Offset
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4591,4652);

int 
userStringHeapOffset = stringHeapOffset + stringHeapSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4666,4729);

int 
guidHeapOffset = userStringHeapOffset + userStringHeapSize
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4743,4794);

int 
blobHeapOffset = guidHeapOffset + guidHeapSize
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4810,4945) || true) && (reader.Length != blobHeapOffset + blobHeapSize)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,4810,4945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4894,4930);

throw f_25103_4900_4929();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,4810,4945);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,4961,5025);

_guidHeapBlob = f_25103_4977_5024(buffer + guidHeapOffset, guidHeapSize);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5039,5103);

_blobHeapBlob = f_25103_5055_5102(buffer + blobHeapOffset, blobHeapSize);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25103,2228,5114);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,2228,5114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,2228,5114);
}
		}

public static DynamicAnalysisDataReader TryCreateFromPE(PEReader peReader, string resourceName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25103,5126,6898);
int start = default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5317,5361);

var 
mdReader = f_25103_5332_5360(peReader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5375,5392);

long 
offset = -1
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5406,5875);
foreach(var resourceHandle in f_25103_5437_5463_I(f_25103_5437_5463(mdReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,5406,5875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5497,5557);

var 
resource = f_25103_5512_5556(mdReader, resourceHandle)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5575,5860) || true) && (resource.Implementation.IsNil &&(DynAbs.Tracing.TraceSender.Expression_True(25103, 5579, 5690)&&                    resource.Attributes == ManifestResourceAttributes.Private )&&(DynAbs.Tracing.TraceSender.Expression_True(25103, 5579, 5774)&&                    mdReader.StringComparer.Equals(resource.Name,resourceName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,5575,5860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5816,5841);

offset = resource.Offset;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,5575,5860);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,5406,5875);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25103,1,470);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25103,1,470);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5891,5966) || true) && (offset < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,5891,5966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5939,5951);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,5891,5966);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,5982,6049);

var 
resourcesDir = f_25103_6001_6048(f_25103_6001_6029(f_25103_6001_6019(peReader)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6063,6173) || true) && (resourcesDir.Size < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,6063,6173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6122,6158);

throw f_25103_6128_6157();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,6063,6173);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6189,6324) || true) && (!f_25103_6194_6263(f_25103_6194_6212(peReader), resourcesDir, out start))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,6189,6324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6297,6309);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,6189,6324);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6340,6380);

var 
peImage = f_25103_6354_6379(peReader)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6394,6526) || true) && (start >= peImage.Length - resourcesDir.Size)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,6394,6526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6475,6511);

throw f_25103_6481_6510();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,6394,6526);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6542,6588);

byte* 
resourceStart = peImage.Pointer + start
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6602,6642);

int 
resourceSize = *(int*)resourceStart
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6656,6791) || true) && (resourceSize > resourcesDir.Size - sizeof(int))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,6656,6791);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6740,6776);

throw f_25103_6746_6775();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,6656,6791);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,6807,6887);

return f_25103_6814_6886(resourceStart + sizeof(int), resourceSize);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25103,5126,6898);

System.Reflection.Metadata.MetadataReader
f_25103_5332_5360(System.Reflection.PortableExecutable.PEReader
peReader)
{
var return_v = peReader.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 5332, 5360);
return return_v;
}


System.Reflection.Metadata.ManifestResourceHandleCollection
f_25103_5437_5463(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.ManifestResources;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25103, 5437, 5463);
return return_v;
}


System.Reflection.Metadata.ManifestResource
f_25103_5512_5556(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.ManifestResourceHandle
handle)
{
var return_v = this_param.GetManifestResource( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 5512, 5556);
return return_v;
}


System.Reflection.Metadata.ManifestResourceHandleCollection
f_25103_5437_5463_I(System.Reflection.Metadata.ManifestResourceHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 5437, 5463);
return return_v;
}


System.Reflection.PortableExecutable.PEHeaders
f_25103_6001_6019(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25103, 6001, 6019);
return return_v;
}


System.Reflection.PortableExecutable.CorHeader?
f_25103_6001_6029(System.Reflection.PortableExecutable.PEHeaders
this_param)
{
var return_v = this_param.CorHeader;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25103, 6001, 6029);
return return_v;
}


System.Reflection.PortableExecutable.DirectoryEntry
f_25103_6001_6048(System.Reflection.PortableExecutable.CorHeader?
this_param)
{
var return_v = this_param.ResourcesDirectory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25103, 6001, 6048);
return return_v;
}


System.BadImageFormatException
f_25103_6128_6157()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6128, 6157);
return return_v;
}


System.Reflection.PortableExecutable.PEHeaders
f_25103_6194_6212(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.PEHeaders;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25103, 6194, 6212);
return return_v;
}


bool
f_25103_6194_6263(System.Reflection.PortableExecutable.PEHeaders
this_param,System.Reflection.PortableExecutable.DirectoryEntry
directory,out int
offset)
{
var return_v = this_param.TryGetDirectoryOffset( directory, out offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6194, 6263);
return return_v;
}


System.Reflection.PortableExecutable.PEMemoryBlock
f_25103_6354_6379(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.GetEntireImage();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6354, 6379);
return return_v;
}


System.BadImageFormatException
f_25103_6481_6510()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6481, 6510);
return return_v;
}


System.BadImageFormatException
f_25103_6746_6775()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6746, 6775);
return return_v;
}


unsafe Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_25103_6814_6886(byte*
buffer,int
size)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisDataReader( buffer, size);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 6814, 6886);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,5126,6898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,5126,6898);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int ReadReference(ref BlobReader reader, bool smallRefSize)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25103,6910,7083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7009,7072);

return (DynAbs.Tracing.TraceSender.Conditional_F1(25103, 7016, 7028)||((smallRefSize &&DynAbs.Tracing.TraceSender.Conditional_F2(25103, 7031, 7050))||DynAbs.Tracing.TraceSender.Conditional_F3(25103, 7053, 7071)))?reader.ReadUInt16():reader.ReadInt32();
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25103,6910,7083);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,6910,7083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,6910,7083);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public ImmutableArray<DynamicAnalysisSpan> GetSpans(BlobHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,7095,9158);
int deltaLines = default(int);
int deltaColumns = default(int);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7190,7304) || true) && (handle.IsNil)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,7190,7304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7240,7289);

return ImmutableArray<DynamicAnalysisSpan>.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,7190,7304);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7320,7382);

var 
builder = f_25103_7334_7381()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7398,7433);

var 
reader = f_25103_7411_7432(this, handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7473,7523);

int 
documentRowId = f_25103_7493_7522(this, ref reader)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7537,7564);

int 
previousStartLine = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7578,7609);

ushort 
previousStartColumn = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7650,9095) || true) && (reader.RemainingBytes > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,7650,9095);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7716,7795);

f_25103_7716_7794(this, ref reader, out deltaLines, out deltaColumns);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7845,8023) || true) && (deltaLines == 0 &&(DynAbs.Tracing.TraceSender.Expression_True(25103, 7849, 7885)&&deltaColumns == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,7845,8023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7927,7973);

documentRowId = f_25103_7943_7972(this, ref reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,7995,8004);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,7845,8023);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8043,8057);

int 
startLine
=default(int);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8075,8094);

ushort 
startColumn
=default(ushort);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8161,8668) || true) && (previousStartLine < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,8161,8668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8228,8267);

f_25103_8228_8266(previousStartColumn == 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8291,8324);

startLine = f_25103_8303_8323(this, ref reader);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8346,8383);

startColumn = f_25103_8360_8382(this, ref reader);
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,8161,8668);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,8161,8668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8465,8543);

startLine = f_25103_8477_8542(this, previousStartLine, reader.ReadCompressedSignedInteger());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8565,8649);

startColumn = f_25103_8579_8648(this, previousStartColumn, reader.ReadCompressedSignedInteger());
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,8161,8668);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8688,8718);

previousStartLine = startLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8736,8770);

previousStartColumn = startColumn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8790,8836);

int 
endLine = f_25103_8804_8835(this, startLine, deltaLines)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8854,8908);

int 
endColumn = f_25103_8870_8907(this, startColumn, deltaColumns)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,8926,9032);

var 
linePositionSpan = f_25103_8949_9031(documentRowId, startLine, startColumn, endLine, endColumn)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9050,9080);

f_25103_9050_9079(                builder, linePositionSpan);
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,7650,9095);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25103,7650,9095);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25103,7650,9095);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9111,9147);

return f_25103_9118_9146(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,7095,9158);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
f_25103_7334_7381()
{
var return_v = ArrayBuilder<DynamicAnalysisSpan>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 7334, 7381);
return return_v;
}


System.Reflection.Metadata.BlobReader
f_25103_7411_7432(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobReader( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 7411, 7432);
return return_v;
}


int
f_25103_7493_7522(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ref System.Reflection.Metadata.BlobReader
reader)
{
var return_v = this_param.ReadDocumentRowId( ref reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 7493, 7522);
return return_v;
}


int
f_25103_7716_7794(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ref System.Reflection.Metadata.BlobReader
reader,out int
deltaLines,out int
deltaColumns)
{
this_param.ReadDeltaLinesAndColumns( ref reader, out deltaLines, out deltaColumns);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 7716, 7794);
return 0;
}


int
f_25103_7943_7972(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ref System.Reflection.Metadata.BlobReader
reader)
{
var return_v = this_param.ReadDocumentRowId( ref reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 7943, 7972);
return return_v;
}


int
f_25103_8228_8266(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8228, 8266);
return 0;
}


int
f_25103_8303_8323(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ref System.Reflection.Metadata.BlobReader
reader)
{
var return_v = this_param.ReadLine( ref reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8303, 8323);
return return_v;
}


ushort
f_25103_8360_8382(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ref System.Reflection.Metadata.BlobReader
reader)
{
var return_v = this_param.ReadColumn( ref reader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8360, 8382);
return return_v;
}


int
f_25103_8477_8542(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,int
value,int
delta)
{
var return_v = this_param.AddLines( value, delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8477, 8542);
return return_v;
}


ushort
f_25103_8579_8648(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ushort
value,int
delta)
{
var return_v = this_param.AddColumns( value, delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8579, 8648);
return return_v;
}


int
f_25103_8804_8835(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,int
value,int
delta)
{
var return_v = this_param.AddLines( value, delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8804, 8835);
return return_v;
}


ushort
f_25103_8870_8907(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,ushort
value,int
delta)
{
var return_v = this_param.AddColumns( value, delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8870, 8907);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisSpan
f_25103_8949_9031(int
documentRowId,int
startLine,ushort
startColumn,int
endLine,int
endColumn)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisSpan( documentRowId, startLine, (int)startColumn, endLine, endColumn);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 8949, 9031);
return return_v;
}


int
f_25103_9050_9079(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
this_param,Microsoft.CodeAnalysis.DynamicAnalysisSpan
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 9050, 9079);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
f_25103_9118_9146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 9118, 9146);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,7095,9158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,7095,9158);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private unsafe struct Blob
        {

public readonly byte* Pointer;

public readonly int Length;

public Blob(byte* pointer, int length)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25103,9402,9540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9473,9491);

Pointer = pointer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9509,9525);

Length = length;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25103,9402,9540);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,9402,9540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,9402,9540);
}
		}
static Blob(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25103,9264,9551);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25103,9264,9551);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,9264,9551);
}
        }

public Guid GetGuid(GuidHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,9563,10013);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9626,9712) || true) && (handle.IsNil)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,9626,9712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9676,9697);

return default(Guid);
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,9626,9712);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9728,9795);

int 
offset = (f_25103_9742_9778(handle)- 1) * GuidSize
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9809,9938) || true) && (offset + GuidSize > _guidHeapBlob.Length)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,9809,9938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9887,9923);

throw f_25103_9893_9922();
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,9809,9938);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,9954,10002);

return *(Guid*)(_guidHeapBlob.Pointer + offset);
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,9563,10013);

int
f_25103_9742_9778(System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = MetadataTokens.GetHeapOffset( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 9742, 9778);
return return_v;
}


System.BadImageFormatException
f_25103_9893_9922()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 9893, 9922);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,9563,10013);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,9563,10013);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal byte[] GetBytes(BlobHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,10025,10192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10093,10128);

var 
reader = f_25103_10106_10127(this, handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10142,10181);

return reader.ReadBytes(reader.Length);
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,10025,10192);

System.Reflection.Metadata.BlobReader
f_25103_10106_10127(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobReader( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10106, 10127);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,10025,10192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,10025,10192);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private BlobReader GetBlobReader(BlobHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,10204,10601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10280,10330);

int 
offset = f_25103_10293_10329(handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10344,10389);

byte* 
start = _blobHeapBlob.Pointer + offset
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10403,10469);

var 
reader = f_25103_10416_10468(start, _blobHeapBlob.Length - offset)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10483,10525);

int 
size = reader.ReadCompressedInteger()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10539,10590);

return f_25103_10546_10589(start + reader.Offset, size);
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,10204,10601);

int
f_25103_10293_10329(System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = MetadataTokens.GetHeapOffset( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10293, 10329);
return return_v;
}


unsafe System.Reflection.Metadata.BlobReader
f_25103_10416_10468(byte*
buffer,int
length)
{
var return_v = new System.Reflection.Metadata.BlobReader( buffer, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10416, 10468);
return return_v;
}


unsafe System.Reflection.Metadata.BlobReader
f_25103_10546_10589(byte*
buffer,int
length)
{
var return_v = new System.Reflection.Metadata.BlobReader( buffer, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10546, 10589);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,10204,10601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,10204,10601);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string GetDocumentName(BlobHandle handle)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,10613,11820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10686,10725);

var 
blobReader = f_25103_10703_10724(this, handle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10869,10907);

int 
separator = blobReader.ReadByte()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10921,11075) || true) && (separator > 0x7f)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,10921,11075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,10975,11060);

throw f_25103_10981_11059(f_25103_11009_11058("Invalid document name", separator));
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,10921,11075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11091,11145);

var 
pooledBuilder = f_25103_11111_11144()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11159,11195);

var 
builder = pooledBuilder.Builder
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11209,11233);

bool 
isFirstPart = true
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11247,11754) || true) && (blobReader.RemainingBytes > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,11247,11754);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11317,11444) || true) && (separator != 0 &&(DynAbs.Tracing.TraceSender.Expression_True(25103, 11321, 11351)&&!isFirstPart))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,11317,11444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11393,11425);

f_25103_11393_11424(                    builder, separator);
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,11317,11444);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11464,11524);

var 
partReader = f_25103_11481_11523(this, blobReader.ReadBlobHandle())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11646,11701);

f_25103_11646_11700(
                // TODO: avoid allocating temp string (https://github.com/dotnet/corefx/issues/2102)
                builder, partReader.ReadUTF8(partReader.Length));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11719,11739);

isFirstPart = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,11247,11754);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25103,11247,11754);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25103,11247,11754);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11770,11809);

return f_25103_11777_11808(pooledBuilder);
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,10613,11820);

System.Reflection.Metadata.BlobReader
f_25103_10703_10724(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobReader( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10703, 10724);
return return_v;
}


string
f_25103_11009_11058(string
format,int
arg0)
{
var return_v = string.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11009, 11058);
return return_v;
}


System.BadImageFormatException
f_25103_10981_11059(string
message)
{
var return_v = new System.BadImageFormatException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 10981, 11059);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
f_25103_11111_11144()
{
var return_v = PooledStringBuilder.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11111, 11144);
return return_v;
}


System.Text.StringBuilder
f_25103_11393_11424(System.Text.StringBuilder
this_param,int
value)
{
var return_v = this_param.Append( (char)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11393, 11424);
return return_v;
}


System.Reflection.Metadata.BlobReader
f_25103_11481_11523(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobReader( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11481, 11523);
return return_v;
}


System.Text.StringBuilder
f_25103_11646_11700(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11646, 11700);
return return_v;
}


string
f_25103_11777_11808(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
this_param)
{
var return_v = this_param.ToStringAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 11777, 11808);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,10613,11820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,10613,11820);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void ReadDeltaLinesAndColumns(ref BlobReader reader, out int deltaLines, out int deltaColumns)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,11832,12133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,11959,12003);

deltaLines = reader.ReadCompressedInteger();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12017,12122);

deltaColumns = (DynAbs.Tracing.TraceSender.Conditional_F1(25103, 12032, 12049)||(((deltaLines == 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(25103, 12052, 12082))||DynAbs.Tracing.TraceSender.Conditional_F3(25103, 12085, 12121)))?reader.ReadCompressedInteger():reader.ReadCompressedSignedInteger();
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,11832,12133);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,11832,12133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,11832,12133);
}
		}

private int ReadLine(ref BlobReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,12145,12262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12213,12251);

return reader.ReadCompressedInteger();
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,12145,12262);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,12145,12262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,12145,12262);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ushort ReadColumn(ref BlobReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,12274,12597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12347,12391);

int 
column = reader.ReadCompressedInteger()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12405,12548) || true) && (column > ushort.MaxValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,12405,12548);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12467,12533);

throw f_25103_12473_12532("SequencePointValueOutOfRange");
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,12405,12548);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12564,12586);

return (ushort)column;
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,12274,12597);

System.BadImageFormatException
f_25103_12473_12532(string
message)
{
var return_v = new System.BadImageFormatException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 12473, 12532);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,12274,12597);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,12274,12597);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int AddLines(int value, int delta)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,12609,12898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12676,12714);

int 
result = unchecked(value + delta)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12728,12857) || true) && (result < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,12728,12857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12776,12842);

throw f_25103_12782_12841("SequencePointValueOutOfRange");
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,12728,12857);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12873,12887);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,12609,12898);

System.BadImageFormatException
f_25103_12782_12841(string
message)
{
var return_v = new System.BadImageFormatException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 12782, 12841);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,12609,12898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,12609,12898);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ushort AddColumns(ushort value, int delta)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,12910,13244);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,12985,13023);

int 
result = unchecked(value + delta)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13037,13195) || true) && (result < 0 ||(DynAbs.Tracing.TraceSender.Expression_False(25103, 13041, 13080)||result >= ushort.MaxValue))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,13037,13195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13114,13180);

throw f_25103_13120_13179("SequencePointValueOutOfRange");
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,13037,13195);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13211,13233);

return (ushort)result;
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,12910,13244);

System.BadImageFormatException
f_25103_13120_13179(string
message)
{
var return_v = new System.BadImageFormatException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 13120, 13179);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,12910,13244);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,12910,13244);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private int ReadDocumentRowId(ref BlobReader reader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25103,13256,13545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13333,13376);

int 
rowId = reader.ReadCompressedInteger()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13390,13505) || true) && (rowId == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25103,13390,13505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13438,13490);

throw f_25103_13444_13489("Invalid handle");
DynAbs.Tracing.TraceSender.TraceExitCondition(25103,13390,13505);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,13521,13534);

return rowId;
DynAbs.Tracing.TraceSender.TraceExitMethod(25103,13256,13545);

System.BadImageFormatException
f_25103_13444_13489(string
message)
{
var return_v = new System.BadImageFormatException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 13444, 13489);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25103,13256,13545);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,13256,13545);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DynamicAnalysisDataReader()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25103,1871,13552);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25103,2202,2215);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25103,1871,13552);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25103,1871,13552);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25103,1871,13552);

unsafe static System.Reflection.Metadata.BlobReader
f_25103_2322_2350(byte*
buffer,int
length)
{
var return_v = new System.Reflection.Metadata.BlobReader( buffer, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 2322, 2350);
return return_v;
}


static System.BadImageFormatException
f_25103_2543_2572()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 2543, 2572);
return return_v;
}


static System.NotSupportedException
f_25103_2798_2825()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 2798, 2825);
return return_v;
}


static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
f_25103_3507_3574(int
capacity)
{
var return_v = ArrayBuilder<DynamicAnalysisDocument>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3507, 3574);
return return_v;
}


static int
f_25103_3703_3745(ref System.Reflection.Metadata.BlobReader
reader,bool
smallRefSize)
{
var return_v = ReadReference( ref reader, smallRefSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3703, 3745);
return return_v;
}


static System.Reflection.Metadata.BlobHandle
f_25103_3677_3746(int
offset)
{
var return_v = MetadataTokens.BlobHandle( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3677, 3746);
return return_v;
}


static int
f_25103_3811_3853(ref System.Reflection.Metadata.BlobReader
reader,bool
smallRefSize)
{
var return_v = ReadReference( ref reader, smallRefSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3811, 3853);
return return_v;
}


static System.Reflection.Metadata.GuidHandle
f_25103_3785_3854(int
offset)
{
var return_v = MetadataTokens.GuidHandle( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3785, 3854);
return return_v;
}


static int
f_25103_3910_3952(ref System.Reflection.Metadata.BlobReader
reader,bool
smallRefSize)
{
var return_v = ReadReference( ref reader, smallRefSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3910, 3952);
return return_v;
}


static System.Reflection.Metadata.BlobHandle
f_25103_3884_3953(int
offset)
{
var return_v = MetadataTokens.BlobHandle( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3884, 3953);
return return_v;
}


static Microsoft.CodeAnalysis.DynamicAnalysisDocument
f_25103_3995_4049(System.Reflection.Metadata.BlobHandle
name,System.Reflection.Metadata.GuidHandle
hashAlgorithm,System.Reflection.Metadata.BlobHandle
hash)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisDocument( name, hashAlgorithm, hash);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3995, 4049);
return return_v;
}


static int
f_25103_3974_4050(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
this_param,Microsoft.CodeAnalysis.DynamicAnalysisDocument
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 3974, 4050);
return 0;
}


static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
f_25103_4094_4131(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4094, 4131);
return return_v;
}


static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_25103_4169_4236(int
capacity)
{
var return_v = ArrayBuilder<DynamicAnalysisMethod>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4169, 4236);
return return_v;
}


static int
f_25103_4401_4443(ref System.Reflection.Metadata.BlobReader
reader,bool
smallRefSize)
{
var return_v = ReadReference( ref reader, smallRefSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4401, 4443);
return return_v;
}


static System.Reflection.Metadata.BlobHandle
f_25103_4375_4444(int
offset)
{
var return_v = MetadataTokens.BlobHandle( offset);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4375, 4444);
return return_v;
}


static Microsoft.CodeAnalysis.DynamicAnalysisMethod
f_25103_4349_4445(System.Reflection.Metadata.BlobHandle
blob)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisMethod( blob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4349, 4445);
return return_v;
}


static int
f_25103_4330_4446(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
this_param,Microsoft.CodeAnalysis.DynamicAnalysisMethod
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4330, 4446);
return 0;
}


static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_25103_4488_4523(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
this_param)
{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4488, 4523);
return return_v;
}


static System.BadImageFormatException
f_25103_4900_4929()
{
var return_v = new System.BadImageFormatException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4900, 4929);
return return_v;
}


unsafe static Microsoft.CodeAnalysis.DynamicAnalysisDataReader.Blob
f_25103_4977_5024(byte*
pointer,int
length)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisDataReader.Blob( pointer, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 4977, 5024);
return return_v;
}


unsafe static Microsoft.CodeAnalysis.DynamicAnalysisDataReader.Blob
f_25103_5055_5102(byte*
pointer,int
length)
{
var return_v = new Microsoft.CodeAnalysis.DynamicAnalysisDataReader.Blob( pointer, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25103, 5055, 5102);
return return_v;
}

}
}
