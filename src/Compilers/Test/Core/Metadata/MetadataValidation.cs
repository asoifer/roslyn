// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis;
using Microsoft.Metadata.Tools;
using Roslyn.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
public static class MetadataValidation
{
internal static string GetAttributeName(MetadataReader metadataReader, CustomAttributeHandle customAttribute)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,767,1490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,901,981);

var 
ctorHandle = f_25107_918_968(metadataReader, customAttribute).Constructor
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,995,1479) || true) && (ctorHandle.Kind == HandleKind.MemberReference)
) // MemberRef

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,995,1479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1091,1183);

var 
container = f_25107_1107_1175(metadataReader, ctorHandle).Parent
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1201,1281);

var 
name = f_25107_1212_1275(metadataReader, container).Name
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1299,1337);

return f_25107_1306_1336(metadataReader, name);
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,995,1479);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,995,1479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1403,1434);

f_25107_1403_1433(false, "not impl");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1452,1464);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,995,1479);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,767,1490);

System.Reflection.Metadata.CustomAttribute
f_25107_918_968(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.CustomAttributeHandle
handle)
{
var return_v = this_param.GetCustomAttribute( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 918, 968);
return return_v;
}


System.Reflection.Metadata.MemberReference
f_25107_1107_1175(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = this_param.GetMemberReference( (System.Reflection.Metadata.MemberReferenceHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1107, 1175);
return return_v;
}


System.Reflection.Metadata.TypeReference
f_25107_1212_1275(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.EntityHandle
handle)
{
var return_v = this_param.GetTypeReference( (System.Reflection.Metadata.TypeReferenceHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1212, 1275);
return return_v;
}


string
f_25107_1306_1336(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1306, 1336);
return return_v;
}


int
f_25107_1403_1433(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1403, 1433);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,767,1490);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,767,1490);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CustomAttributeHandle FindCustomAttribute(MetadataReader metadataReader, string attributeClassName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,1502,1996);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1642,1931);
foreach(var caHandle in f_25107_1667_1698_I(f_25107_1667_1698(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,1642,1931);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1732,1916) || true) && (f_25107_1736_1839(f_25107_1750_1792(metadataReader, caHandle), attributeClassName, StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,1732,1916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1881,1897);

return caHandle;
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,1732,1916);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,1642,1931);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,290);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,290);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,1947,1985);

return default(CustomAttributeHandle);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,1502,1996);

System.Reflection.Metadata.CustomAttributeHandleCollection
f_25107_1667_1698(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 1667, 1698);
return return_v;
}


string
f_25107_1750_1792(System.Reflection.Metadata.MetadataReader
metadataReader,System.Reflection.Metadata.CustomAttributeHandle
customAttribute)
{
var return_v = GetAttributeName( metadataReader, customAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1750, 1792);
return return_v;
}


bool
f_25107_1736_1839(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1736, 1839);
return return_v;
}


System.Reflection.Metadata.CustomAttributeHandleCollection
f_25107_1667_1698_I(System.Reflection.Metadata.CustomAttributeHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 1667, 1698);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,1502,1996);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,1502,1996);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void MarshalAsMetadataValidator(PEAssembly assembly, Func<string, PEAssembly, byte[]> getExpectedBlob, bool isField = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,2123,5638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2287,2337);

var 
metadataReader = f_25107_2308_2336(assembly)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2442,2617);
foreach(var ca in f_25107_2461_2492_I(f_25107_2461_2492(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,2442,2617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2526,2602);

f_25107_2526_2601("MarshalAsAttribute", f_25107_2564_2600(metadataReader, ca));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,2442,2617);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,176);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,176);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2633,2662);

int 
expectedMarshalCount = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2678,5518) || true) && (isField)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,2678,5518);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2750,3880);
foreach(var fieldDef in f_25107_2775_2806_I(f_25107_2775_2806(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,2750,3880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2848,2904);

var 
field = f_25107_2860_2903(metadataReader, fieldDef)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,2926,2982);

string 
fieldName = f_25107_2945_2981(metadataReader, field.Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3006,3065);

byte[] 
expectedBlob = f_25107_3028_3064(getExpectedBlob, fieldName, assembly)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3087,3861) || true) && (expectedBlob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,3087,3861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3161,3256);

BlobHandle 
descriptor = f_25107_3185_3228(metadataReader, fieldDef).GetMarshallingDescriptor()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3282,3355);

f_25107_3282_3354(descriptor.IsNil, "Expecting record in FieldMarshal table");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3383,3461);

f_25107_3383_3460(0, (field.Attributes & FieldAttributes.HasFieldMarshal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3487,3510);

expectedMarshalCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3538,3598);

byte[] 
actualBlob = f_25107_3558_3597(metadataReader, descriptor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3624,3665);

f_25107_3624_3664(expectedBlob, actualBlob);
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,3087,3861);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,3087,3861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3763,3838);

f_25107_3763_3837(0, (field.Attributes & FieldAttributes.HasFieldMarshal));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,3087,3861);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,2750,3880);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,1131);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,1131);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25107,2678,5518);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,2678,5518);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,3977,5503);
foreach(var methodHandle in f_25107_4006_4038_I(f_25107_4006_4038(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,3977,5503);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4080,4145);

var 
methodDef = f_25107_4096_4144(metadataReader, methodHandle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4167,4228);

string 
memberName = f_25107_4187_4227(metadataReader, methodDef.Name)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4250,5484);
foreach(var paramHandle in f_25107_4278_4303_I(methodDef.GetParameters()) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,4250,5484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4353,4409);

var 
paramRow = f_25107_4368_4408(metadataReader, paramHandle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4435,4494);

string 
paramName = f_25107_4454_4493(metadataReader, paramRow.Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4522,4600);

byte[] 
expectedBlob = f_25107_4544_4599(getExpectedBlob, memberName + ":" + paramName, assembly)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4626,5461) || true) && (expectedBlob != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,4626,5461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4708,4793);

f_25107_4708_4792(0, (paramRow.Attributes & ParameterAttributes.HasFieldMarshal));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4823,4846);

expectedMarshalCount++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,4878,4970);

BlobHandle 
descriptor = f_25107_4902_4942(metadataReader, paramHandle).GetMarshallingDescriptor()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5000,5073);

f_25107_5000_5072(descriptor.IsNil, "Expecting record in FieldMarshal table");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5105,5165);

byte[] 
actualBlob = f_25107_5125_5164(metadataReader, descriptor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5197,5238);

f_25107_5197_5237(expectedBlob, actualBlob);
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,4626,5461);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,4626,5461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5352,5434);

f_25107_5352_5433(0, (paramRow.Attributes & ParameterAttributes.HasFieldMarshal));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,4626,5461);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,4250,5484);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,1235);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,1235);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25107,3977,5503);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,1527);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,1527);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25107,2678,5518);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5534,5627);

f_25107_5534_5626(expectedMarshalCount, f_25107_5569_5625(metadataReader, TableIndex.FieldMarshal));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,2123,5638);

System.Reflection.Metadata.MetadataReader
f_25107_2308_2336(Microsoft.CodeAnalysis.PEAssembly
assembly)
{
var return_v = assembly.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2308, 2336);
return return_v;
}


System.Reflection.Metadata.CustomAttributeHandleCollection
f_25107_2461_2492(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 2461, 2492);
return return_v;
}


string
f_25107_2564_2600(System.Reflection.Metadata.MetadataReader
metadataReader,System.Reflection.Metadata.CustomAttributeHandle
customAttribute)
{
var return_v = GetAttributeName( metadataReader, customAttribute);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2564, 2600);
return return_v;
}


int
f_25107_2526_2601(string
expected,string
actual)
{
Assert.NotEqual( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2526, 2601);
return 0;
}


System.Reflection.Metadata.CustomAttributeHandleCollection
f_25107_2461_2492_I(System.Reflection.Metadata.CustomAttributeHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2461, 2492);
return return_v;
}


System.Reflection.Metadata.FieldDefinitionHandleCollection
f_25107_2775_2806(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.FieldDefinitions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 2775, 2806);
return return_v;
}


System.Reflection.Metadata.FieldDefinition
f_25107_2860_2903(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.FieldDefinitionHandle
handle)
{
var return_v = this_param.GetFieldDefinition( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2860, 2903);
return return_v;
}


string
f_25107_2945_2981(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2945, 2981);
return return_v;
}


byte[]
f_25107_3028_3064(System.Func<string, Microsoft.CodeAnalysis.PEAssembly, byte[]>
this_param,string
arg1,Microsoft.CodeAnalysis.PEAssembly
arg2)
{
var return_v = this_param.Invoke( arg1, arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3028, 3064);
return return_v;
}


System.Reflection.Metadata.FieldDefinition
f_25107_3185_3228(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.FieldDefinitionHandle
handle)
{
var return_v = this_param.GetFieldDefinition( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3185, 3228);
return return_v;
}


int
f_25107_3282_3354(bool
condition,string
userMessage)
{
Assert.False( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3282, 3354);
return 0;
}


int
f_25107_3383_3460(int
expected,System.Reflection.FieldAttributes
actual)
{
Assert.NotEqual( expected, (int)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3383, 3460);
return 0;
}


byte[]
f_25107_3558_3597(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobBytes( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3558, 3597);
return return_v;
}


bool
f_25107_3624_3664(byte[]
expected,byte[]
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3624, 3664);
return return_v;
}


int
f_25107_3763_3837(int
expected,System.Reflection.FieldAttributes
actual)
{
Assert.Equal( expected, (int)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 3763, 3837);
return 0;
}


System.Reflection.Metadata.FieldDefinitionHandleCollection
f_25107_2775_2806_I(System.Reflection.Metadata.FieldDefinitionHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 2775, 2806);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandleCollection
f_25107_4006_4038(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.MethodDefinitions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 4006, 4038);
return return_v;
}


System.Reflection.Metadata.MethodDefinition
f_25107_4096_4144(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = this_param.GetMethodDefinition( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4096, 4144);
return return_v;
}


string
f_25107_4187_4227(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4187, 4227);
return return_v;
}


System.Reflection.Metadata.Parameter
f_25107_4368_4408(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.ParameterHandle
handle)
{
var return_v = this_param.GetParameter( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4368, 4408);
return return_v;
}


string
f_25107_4454_4493(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4454, 4493);
return return_v;
}


byte[]
f_25107_4544_4599(System.Func<string, Microsoft.CodeAnalysis.PEAssembly, byte[]>
this_param,string
arg1,Microsoft.CodeAnalysis.PEAssembly
arg2)
{
var return_v = this_param.Invoke( arg1, arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4544, 4599);
return return_v;
}


int
f_25107_4708_4792(int
expected,System.Reflection.ParameterAttributes
actual)
{
Assert.NotEqual( expected, (int)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4708, 4792);
return 0;
}


System.Reflection.Metadata.Parameter
f_25107_4902_4942(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.ParameterHandle
handle)
{
var return_v = this_param.GetParameter( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4902, 4942);
return return_v;
}


int
f_25107_5000_5072(bool
condition,string
userMessage)
{
Assert.False( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5000, 5072);
return 0;
}


byte[]
f_25107_5125_5164(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetBlobBytes( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5125, 5164);
return return_v;
}


bool
f_25107_5197_5237(byte[]
expected,byte[]
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5197, 5237);
return return_v;
}


int
f_25107_5352_5433(int
expected,System.Reflection.ParameterAttributes
actual)
{
Assert.Equal( expected, (int)actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5352, 5433);
return 0;
}


System.Reflection.Metadata.ParameterHandleCollection
f_25107_4278_4303_I(System.Reflection.Metadata.ParameterHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4278, 4303);
return return_v;
}


System.Reflection.Metadata.MethodDefinitionHandleCollection
f_25107_4006_4038_I(System.Reflection.Metadata.MethodDefinitionHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 4006, 4038);
return return_v;
}


int
f_25107_5569_5625(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.TableIndex
tableIndex)
{
var return_v = reader.GetTableRowCount( tableIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5569, 5625);
return return_v;
}


int
f_25107_5534_5626(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5534, 5626);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,2123,5638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,2123,5638);
}
		}

internal static IEnumerable<string> GetFullTypeNames(MetadataReader metadataReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,5650,6156);

var listYield= new List<String>();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5758,6145);
foreach(var typeDefHandle in f_25107_5788_5818_I(f_25107_5788_5818(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,5758,6145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5852,5914);

var 
typeDef = f_25107_5866_5913(metadataReader, typeDefHandle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,5932,5985);

var 
ns = f_25107_5941_5984(metadataReader, typeDef.Namespace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6003,6053);

var 
name = f_25107_6014_6052(metadataReader, typeDef.Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6073,6130);

listYield.Add((DynAbs.Tracing.TraceSender.Conditional_F1(25107, 6086, 6102)||(((f_25107_6087_6096(ns)== 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(25107, 6105, 6109))||DynAbs.Tracing.TraceSender.Conditional_F3(25107, 6112, 6129)))?name :(ns + "." + name));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,5758,6145);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,388);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,388);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,5650,6156);

return listYield;

System.Reflection.Metadata.TypeDefinitionHandleCollection
f_25107_5788_5818(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.TypeDefinitions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 5788, 5818);
return return_v;
}


System.Reflection.Metadata.TypeDefinition
f_25107_5866_5913(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.TypeDefinitionHandle
handle)
{
var return_v = this_param.GetTypeDefinition( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5866, 5913);
return return_v;
}


string
f_25107_5941_5984(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5941, 5984);
return return_v;
}


string
f_25107_6014_6052(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6014, 6052);
return return_v;
}


int
f_25107_6087_6096(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 6087, 6096);
return return_v;
}


System.Reflection.Metadata.TypeDefinitionHandleCollection
f_25107_5788_5818_I(System.Reflection.Metadata.TypeDefinitionHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 5788, 5818);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,5650,6156);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,5650,6156);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static IEnumerable<string> GetExportedTypesFullNames(MetadataReader metadataReader)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,6168,6679);

var listYield= new List<String>();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6285,6668);
foreach(var typeDefHandle in f_25107_6315_6343_I(f_25107_6315_6343(metadataReader)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,6285,6668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6377,6437);

var 
typeDef = f_25107_6391_6436(metadataReader, typeDefHandle)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6455,6508);

var 
ns = f_25107_6464_6507(metadataReader, typeDef.Namespace)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6526,6576);

var 
name = f_25107_6537_6575(metadataReader, typeDef.Name)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6596,6653);

listYield.Add((DynAbs.Tracing.TraceSender.Conditional_F1(25107, 6609, 6625)||(((f_25107_6610_6619(ns)== 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(25107, 6628, 6632))||DynAbs.Tracing.TraceSender.Conditional_F3(25107, 6635, 6652)))?name :(ns + "." + name));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,6285,6668);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25107,1,384);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25107,1,384);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,6168,6679);

return listYield;

System.Reflection.Metadata.ExportedTypeHandleCollection
f_25107_6315_6343(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.ExportedTypes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 6315, 6343);
return return_v;
}


System.Reflection.Metadata.ExportedType
f_25107_6391_6436(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.ExportedTypeHandle
handle)
{
var return_v = this_param.GetExportedType( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6391, 6436);
return return_v;
}


string
f_25107_6464_6507(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6464, 6507);
return return_v;
}


string
f_25107_6537_6575(System.Reflection.Metadata.MetadataReader
this_param,System.Reflection.Metadata.StringHandle
handle)
{
var return_v = this_param.GetString( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6537, 6575);
return return_v;
}


int
f_25107_6610_6619(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25107, 6610, 6619);
return return_v;
}


System.Reflection.Metadata.ExportedTypeHandleCollection
f_25107_6315_6343_I(System.Reflection.Metadata.ExportedTypeHandleCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6315, 6343);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,6168,6679);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,6168,6679);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static void VerifyMetadataEqualModuloMvid(Stream peStream1, Stream peStream2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25107,6691,8147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6800,6823);

peStream1.Position = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6837,6860);

peStream2.Position = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6876,6916);

var 
peReader1 = f_25107_6892_6915(peStream1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6930,6970);

var 
peReader2 = f_25107_6946_6969(peStream2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,6986,7033);

var 
md1 = f_25107_6996_7019(peReader1).GetContent()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7047,7094);

var 
md2 = f_25107_7057_7080(peReader2).GetContent()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7110,7156);

var 
mdReader1 = f_25107_7126_7155(peReader1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7170,7216);

var 
mdReader2 = f_25107_7186_7215(peReader2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7232,7286);

var 
mvidIndex1 = f_25107_7249_7280(mdReader1).Mvid
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7300,7354);

var 
mvidIndex2 = f_25107_7317_7348(mdReader2).Mvid
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7370,7490);

var 
mvidOffset1 = f_25107_7388_7435(mdReader1, HeapIndex.Guid)+ 16 * (f_25107_7444_7484(mvidIndex1)- 1)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7504,7624);

var 
mvidOffset2 = f_25107_7522_7569(mdReader2, HeapIndex.Guid)+ 16 * (f_25107_7578_7618(mvidIndex2)- 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7640,8136) || true) && (!md1.RemoveRange(mvidOffset1,16).SequenceEqual(md1.RemoveRange(mvidOffset2,16)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25107,7640,8136);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7759,7789);

var 
mdw1 = f_25107_7770_7788()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7807,7837);

var 
mdw2 = f_25107_7818_7836()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7855,7907);

f_25107_7855_7906(f_25107_7855_7894(mdReader1, mdw1));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7925,7977);

f_25107_7925_7976(f_25107_7925_7964(mdReader2, mdw2));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,7995,8008);

f_25107_7995_8007(                mdw1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,8026,8039);

f_25107_8026_8038(                mdw2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25107,8059,8121);

f_25107_8059_8120(f_25107_8087_8102(mdw1), f_25107_8104_8119(mdw2));
DynAbs.Tracing.TraceSender.TraceExitCondition(25107,7640,8136);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25107,6691,8147);

System.Reflection.PortableExecutable.PEReader
f_25107_6892_6915(System.IO.Stream
peStream)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6892, 6915);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_25107_6946_6969(System.IO.Stream
peStream)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peStream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6946, 6969);
return return_v;
}


System.Reflection.PortableExecutable.PEMemoryBlock
f_25107_6996_7019(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 6996, 7019);
return return_v;
}


System.Reflection.PortableExecutable.PEMemoryBlock
f_25107_7057_7080(System.Reflection.PortableExecutable.PEReader
this_param)
{
var return_v = this_param.GetMetadata();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7057, 7080);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_25107_7126_7155(System.Reflection.PortableExecutable.PEReader
peReader)
{
var return_v = peReader.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7126, 7155);
return return_v;
}


System.Reflection.Metadata.MetadataReader
f_25107_7186_7215(System.Reflection.PortableExecutable.PEReader
peReader)
{
var return_v = peReader.GetMetadataReader();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7186, 7215);
return return_v;
}


System.Reflection.Metadata.ModuleDefinition
f_25107_7249_7280(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.GetModuleDefinition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7249, 7280);
return return_v;
}


System.Reflection.Metadata.ModuleDefinition
f_25107_7317_7348(System.Reflection.Metadata.MetadataReader
this_param)
{
var return_v = this_param.GetModuleDefinition();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7317, 7348);
return return_v;
}


int
f_25107_7388_7435(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapMetadataOffset( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7388, 7435);
return return_v;
}


int
f_25107_7444_7484(System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = MetadataTokens.GetHeapOffset( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7444, 7484);
return return_v;
}


int
f_25107_7522_7569(System.Reflection.Metadata.MetadataReader
reader,System.Reflection.Metadata.Ecma335.HeapIndex
heapIndex)
{
var return_v = reader.GetHeapMetadataOffset( heapIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7522, 7569);
return return_v;
}


int
f_25107_7578_7618(System.Reflection.Metadata.GuidHandle
handle)
{
var return_v = MetadataTokens.GetHeapOffset( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7578, 7618);
return return_v;
}


System.IO.StringWriter
f_25107_7770_7788()
{
var return_v = new System.IO.StringWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7770, 7788);
return return_v;
}


System.IO.StringWriter
f_25107_7818_7836()
{
var return_v = new System.IO.StringWriter();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7818, 7836);
return return_v;
}


Microsoft.Metadata.Tools.MetadataVisualizer
f_25107_7855_7894(System.Reflection.Metadata.MetadataReader
reader,System.IO.StringWriter
writer)
{
var return_v = new Microsoft.Metadata.Tools.MetadataVisualizer( reader, (System.IO.TextWriter)writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7855, 7894);
return return_v;
}


int
f_25107_7855_7906(Microsoft.Metadata.Tools.MetadataVisualizer
this_param)
{
this_param.Visualize();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7855, 7906);
return 0;
}


Microsoft.Metadata.Tools.MetadataVisualizer
f_25107_7925_7964(System.Reflection.Metadata.MetadataReader
reader,System.IO.StringWriter
writer)
{
var return_v = new Microsoft.Metadata.Tools.MetadataVisualizer( reader, (System.IO.TextWriter)writer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7925, 7964);
return return_v;
}


int
f_25107_7925_7976(Microsoft.Metadata.Tools.MetadataVisualizer
this_param)
{
this_param.Visualize();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7925, 7976);
return 0;
}


int
f_25107_7995_8007(System.IO.StringWriter
this_param)
{
this_param.Flush();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 7995, 8007);
return 0;
}


int
f_25107_8026_8038(System.IO.StringWriter
this_param)
{
this_param.Flush();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 8026, 8038);
return 0;
}


string
f_25107_8087_8102(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 8087, 8102);
return return_v;
}


string
f_25107_8104_8119(System.IO.StringWriter
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 8104, 8119);
return return_v;
}


int
f_25107_8059_8120(string
result1,string
result2)
{
AssertEx.AssertResultsEqual( result1, result2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25107, 8059, 8120);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25107,6691,8147);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,6691,8147);
}
		}

static MetadataValidation()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25107,611,8154);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25107,611,8154);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25107,611,8154);
}

}
}
