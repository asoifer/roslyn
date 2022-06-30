// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Text;
using Microsoft.DiaSymReader;
using static Microsoft.CodeAnalysis.SigningUtilities;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
internal sealed class PeWritingException : Exception
{
public PeWritingException(Exception inner)
:base(f_506_1029_1042_C(f_506_1029_1042(inner)) ,inner)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(506,966,1063);
DynAbs.Tracing.TraceSender.TraceExitConstructor(506,966,1063);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,966,1063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,966,1063);
}
		}

static PeWritingException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(506,897,1070);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(506,897,1070);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,897,1070);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(506,897,1070);

static string
f_506_1029_1042(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 1029, 1042);
return return_v;
}


static string
f_506_1029_1042_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(506, 966, 1063);
return return_v;
}

}
internal static class PeWriter
{
internal static bool WritePeToStream(
            EmitContext context,
            CommonMessageProvider messageProvider,
            Func<Stream> getPeStream,
            Func<Stream> getPortablePdbStreamOpt,
            PdbWriter nativePdbWriterOpt,
            string pdbPathOpt,
            bool metadataOnly,
            bool isDeterministic,
            bool emitTestCoverageData,
            RSAParameters? privateKeyOpt,
            CancellationToken cancellationToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(506,1125,11656);
System.Reflection.Metadata.Blob mvidSectionFixup = default(System.Reflection.Metadata.Blob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,1704,1767);

f_506_1704_1766(nativePdbWriterOpt == null ||(DynAbs.Tracing.TraceSender.Expression_False(506, 1717, 1765)||pdbPathOpt != null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,1783,1972);

var 
mdWriter = f_506_1798_1971(context, messageProvider, metadataOnly, isDeterministic, emitTestCoverageData, getPortablePdbStreamOpt != null, cancellationToken)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,1988,2044);

var 
properties = context.Module.SerializationProperties
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2060,2109);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nativePdbWriterOpt, 506, 2060, 2108)?.SetMetadataEmitter(mdWriter),506,2079,2108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2380,2443);

f_506_2380_2442(properties.PersistentIdentifier == default(Guid));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2459,2502);

var 
ilBuilder = f_506_2475_2501(32 * 1024)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2516,2563);

var 
mappedFieldDataBuilder = f_506_2545_2562()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2577,2628);

var 
managedResourceBuilder = f_506_2606_2627(1024)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2644,2676);

Blob 
mvidFixup
=default(Blob),
mvidStringFixup
=default(Blob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2690,2936);

f_506_2690_2935(            mdWriter, nativePdbWriterOpt, ilBuilder, mappedFieldDataBuilder, managedResourceBuilder, out mvidFixup, out mvidStringFixup);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,2952,2992);

MethodDefinitionHandle 
entryPointHandle
=default(MethodDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3006,3051);

MethodDefinitionHandle 
debugEntryPointHandle
=default(MethodDefinitionHandle);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3065,3138);

f_506_3065_3137(            mdWriter, out entryPointHandle, out debugEntryPointHandle);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3154,3317) || true) && (f_506_3158_3186_M(!debugEntryPointHandle.IsNil))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,3154,3317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3220,3302);

DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nativePdbWriterOpt, 506, 3220, 3301)?.SetEntryPoint(f_506_3254_3300(debugEntryPointHandle)),506,3239,3301);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,3154,3317);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3333,4470) || true) && (nativePdbWriterOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,3333,4470);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3397,3575) || true) && (context.Module.SourceLinkStreamOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,3397,3575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3485,3556);

f_506_3485_3555(                    nativePdbWriterOpt, context.Module.SourceLinkStreamOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,3397,3575);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3595,4333) || true) && (f_506_3599_3614(mdWriter).OutputKind == OutputKind.WindowsRuntimeMetadata)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,3595,4333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,3892,3978);

f_506_3892_3977(                    // Dev12: If compiling to winmdobj, we need to add to PDB source spans of
                    //        all types and members for better error reporting by WinMDExp.
                    nativePdbWriterOpt, f_506_3936_3976(f_506_3936_3951(mdWriter)));
DynAbs.Tracing.TraceSender.TraceExitCondition(506,3595,4333);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,3595,4333);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4214,4306);

f_506_4214_4305(                    // validate that all definitions are writable
                    // if same scenario would happen in a winmdobj project
                    nativePdbWriterOpt, f_506_4264_4304(f_506_4264_4279(mdWriter)));
DynAbs.Tracing.TraceSender.TraceExitCondition(506,3595,4333);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4353,4455);

f_506_4353_4454(
                nativePdbWriterOpt, f_506_4401_4453(f_506_4401_4416(mdWriter).DebugDocumentsBuilder));
DynAbs.Tracing.TraceSender.TraceExitCondition(506,3333,4470);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4486,4518);

Stream 
peStream = f_506_4504_4517(getPeStream)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4532,4614) || true) && (peStream == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,4532,4614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4586,4599);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(506,4532,4614);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4630,4705);

BlobContentId 
pdbContentId = f_506_4659_4693_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(nativePdbWriterOpt, 506, 4659, 4693)?.GetContentId())??(DynAbs.Tracing.TraceSender.Expression_Null<System.Reflection.Metadata.BlobContentId?>(506, 4659, 4704)??default)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4796,4822);

nativePdbWriterOpt = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4838,4868);

ushort 
portablePdbVersion = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4882,4934);

var 
metadataRootBuilder = f_506_4908_4933(mdWriter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,4950,6127);

var 
peHeaderBuilder = f_506_4972_6126(machine: properties.Machine, sectionAlignment: properties.SectionAlignment, fileAlignment: properties.FileAlignment, imageBase: properties.BaseAddress, majorLinkerVersion: properties.LinkerMajorVersion, minorLinkerVersion: properties.LinkerMinorVersion, majorOperatingSystemVersion: 4, minorOperatingSystemVersion: 0, majorImageVersion: 0, minorImageVersion: 0, majorSubsystemVersion: properties.MajorSubsystemVersion, minorSubsystemVersion: properties.MinorSubsystemVersion, subsystem: f_506_5701_5721(properties), dllCharacteristics: f_506_5760_5789(properties), imageCharacteristics: f_506_5830_5861(properties), sizeOfStackReserve: properties.SizeOfStackReserve, sizeOfStackCommit: properties.SizeOfStackCommit, sizeOfHeapReserve: properties.SizeOfHeapReserve, sizeOfHeapCommit: properties.SizeOfHeapCommit)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6143,6353);

var 
peIdProvider = (DynAbs.Tracing.TraceSender.Conditional_F1(506, 6162, 6177)||((isDeterministic &&DynAbs.Tracing.TraceSender.Conditional_F2(506, 6197, 6328))||DynAbs.Tracing.TraceSender.Conditional_F3(506, 6348, 6352)))?                new Func<IEnumerable<Blob>, BlobContentId>(content => BlobContentId.FromHash(CryptographicHashProvider.ComputeSourceHash(content))) :                null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6533,6592);

var 
portablePdbContentHash = default(ImmutableArray<byte>)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6608,6646);

BlobBuilder 
portablePdbToEmbed = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6660,8618) || true) && (f_506_6664_6698(mdWriter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,6660,8618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6732,6822);

f_506_6732_6821(                mdWriter, f_506_6768_6820(f_506_6768_6783(mdWriter).DebugDocumentsBuilder));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,6938,7021);

f_506_6938_7020(!isDeterministic ||(DynAbs.Tracing.TraceSender.Expression_False(506, 6951, 7019)||context.Module.PdbChecksumAlgorithm.Name != null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7041,7359);

var 
portablePdbIdProvider = (DynAbs.Tracing.TraceSender.Conditional_F1(506, 7069, 7119)||(((context.Module.PdbChecksumAlgorithm.Name != null) &&DynAbs.Tracing.TraceSender.Conditional_F2(506, 7143, 7330))||DynAbs.Tracing.TraceSender.Conditional_F3(506, 7354, 7358)))?                    new Func<IEnumerable<Blob>, BlobContentId>(content => BlobContentId.FromHash(portablePdbContentHash = CryptographicHashProvider.ComputeHash(context.Module.PdbChecksumAlgorithm, content))) :                    null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7379,7419);

var 
portablePdbBlob = f_506_7401_7418()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7437,7576);

var 
portablePdbBuilder = f_506_7462_7575(mdWriter, f_506_7493_7528(f_506_7493_7518(metadataRootBuilder)), debugEntryPointHandle, portablePdbIdProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7594,7655);

pdbContentId = f_506_7609_7654(portablePdbBuilder, portablePdbBlob);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7673,7727);

portablePdbVersion = f_506_7694_7726(portablePdbBuilder);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7747,8603) || true) && (getPortablePdbStreamOpt == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,7747,8603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,7874,7911);

portablePdbToEmbed = portablePdbBlob;
DynAbs.Tracing.TraceSender.TraceExitCondition(506,7747,8603);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,7747,8603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8047,8100);

Stream 
portablePdbStream = f_506_8074_8099(getPortablePdbStreamOpt)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8122,8584) || true) && (portablePdbStream != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,8122,8584);
                        try
                        {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8261,8311);

f_506_8261_8310(                            portablePdbBlob, portablePdbStream);
                        }
                        catch (Exception e) when (!(e is OperationCanceledException))
                        {
DynAbs.Tracing.TraceSender.TraceEnterCatch(506,8364,8561);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8482,8534);

throw f_506_8488_8533(f_506_8520_8529(e), e);
DynAbs.Tracing.TraceSender.TraceExitCatch(506,8364,8561);
                        }
DynAbs.Tracing.TraceSender.TraceExitCondition(506,8122,8584);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(506,7747,8603);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(506,6660,8618);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8634,8678);

DebugDirectoryBuilder 
debugDirectoryBuilder
=default(DebugDirectoryBuilder);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8692,10180) || true) && (pdbPathOpt != null ||(DynAbs.Tracing.TraceSender.Expression_False(506, 8696, 8733)||isDeterministic )||(DynAbs.Tracing.TraceSender.Expression_False(506, 8696, 8763)||portablePdbToEmbed != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,8692,10180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8797,8849);

debugDirectoryBuilder = f_506_8821_8848();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8867,9724) || true) && (pdbPathOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,8867,9724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,8931,9005);

string 
paddedPath = (DynAbs.Tracing.TraceSender.Conditional_F1(506, 8951, 8966)||((isDeterministic &&DynAbs.Tracing.TraceSender.Conditional_F2(506, 8969, 8979))||DynAbs.Tracing.TraceSender.Conditional_F3(506, 8982, 9004)))?pdbPathOpt :f_506_8982_9004(pdbPathOpt)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9027,9112);

f_506_9027_9111(                    debugDirectoryBuilder, paddedPath, pdbContentId, portablePdbVersion);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9136,9705) || true) && (f_506_9140_9173_M(!portablePdbContentHash.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,9136,9705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9574,9682);

f_506_9574_9681(                        // Emit PDB Checksum entry for Portable and Embedded PDBs. The checksum is not as useful when the PDB is embedded, 
                        // however it allows the client to efficiently validate a standalone Portable PDB that 
                        // has been extracted from Embedded PDB and placed next to the PE file.
                        debugDirectoryBuilder, context.Module.PdbChecksumAlgorithm.Name, portablePdbContentHash);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,9136,9705);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(506,8867,9724);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9744,9869) || true) && (isDeterministic)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,9744,9869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9805,9850);

f_506_9805_9849(                    debugDirectoryBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,9744,9869);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9889,10070) || true) && (portablePdbToEmbed != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,9889,10070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,9961,10051);

f_506_9961_10050(                    debugDirectoryBuilder, portablePdbToEmbed, portablePdbVersion);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,9889,10070);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(506,8692,10180);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,8692,10180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10136,10165);

debugDirectoryBuilder = null;
DynAbs.Tracing.TraceSender.TraceExitCondition(506,8692,10180);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10196,10281);

var 
strongNameProvider = f_506_10221_10280(f_506_10221_10261(f_506_10221_10253(context.Module)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10295,10330);

var 
corFlags = f_506_10310_10329(properties)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10346,10919);

var 
peBuilder = f_506_10362_10918(peHeaderBuilder, metadataRootBuilder, ilBuilder, mappedFieldDataBuilder, managedResourceBuilder, f_506_10584_10637(context.Module), debugDirectoryBuilder, f_506_10696_10759(context.Module, privateKeyOpt), entryPointHandle, corFlags, peIdProvider, metadataOnly &&(DynAbs.Tracing.TraceSender.Expression_True(506, 10871, 10917)&&f_506_10887_10917_M(!context.IncludePrivateMembers)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10935,10966);

var 
peBlob = f_506_10948_10965()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,10980,11053);

var 
peContentId = f_506_10998_11052(peBuilder, peBlob, out mvidSectionFixup)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11069,11155);

f_506_11069_11154(mvidFixup, mvidSectionFixup, mvidStringFixup, peContentId.Guid);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11171,11363) || true) && (privateKeyOpt != null &&(DynAbs.Tracing.TraceSender.Expression_True(506, 11175, 11243)&&f_506_11200_11243(corFlags, CorFlags.StrongNameSigned)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,11171,11363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11277,11348);

f_506_11277_11347(                strongNameProvider, peBuilder, peBlob, privateKeyOpt.Value);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,11171,11363);
}

            try
            {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11415,11447);

f_506_11415_11446(                peBlob, peStream);
            }
            catch (Exception e) when (!(e is OperationCanceledException))
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(506,11476,11617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11570,11602);

throw f_506_11576_11601(e);
DynAbs.Tracing.TraceSender.TraceExitCatch(506,11476,11617);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11633,11645);

return true;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(506,1125,11656);

int
f_506_1704_1766(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 1704, 1766);
return 0;
}


Microsoft.Cci.MetadataWriter
f_506_1798_1971(Microsoft.CodeAnalysis.Emit.EmitContext
context,Microsoft.CodeAnalysis.CommonMessageProvider
messageProvider,bool
metadataOnly,bool
deterministic,bool
emitTestCoverageData,bool
hasPdbStream,System.Threading.CancellationToken
cancellationToken)
{
var return_v = FullMetadataWriter.Create( context, messageProvider, metadataOnly, deterministic, emitTestCoverageData, hasPdbStream, cancellationToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 1798, 1971);
return return_v;
}


int
f_506_2380_2442(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 2380, 2442);
return 0;
}


System.Reflection.Metadata.BlobBuilder
f_506_2475_2501(int
capacity)
{
var return_v = new System.Reflection.Metadata.BlobBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 2475, 2501);
return return_v;
}


System.Reflection.Metadata.BlobBuilder
f_506_2545_2562()
{
var return_v = new System.Reflection.Metadata.BlobBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 2545, 2562);
return return_v;
}


System.Reflection.Metadata.BlobBuilder
f_506_2606_2627(int
capacity)
{
var return_v = new System.Reflection.Metadata.BlobBuilder( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 2606, 2627);
return return_v;
}


int
f_506_2690_2935(Microsoft.Cci.MetadataWriter
this_param,Microsoft.Cci.PdbWriter?
nativePdbWriterOpt,System.Reflection.Metadata.BlobBuilder
ilBuilder,System.Reflection.Metadata.BlobBuilder
mappedFieldDataBuilder,System.Reflection.Metadata.BlobBuilder
managedResourceDataBuilder,out System.Reflection.Metadata.Blob
mvidFixup,out System.Reflection.Metadata.Blob
mvidStringFixup)
{
this_param.BuildMetadataAndIL( nativePdbWriterOpt, ilBuilder, mappedFieldDataBuilder, managedResourceDataBuilder, out mvidFixup, out mvidStringFixup);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 2690, 2935);
return 0;
}


int
f_506_3065_3137(Microsoft.Cci.MetadataWriter
this_param,out System.Reflection.Metadata.MethodDefinitionHandle
entryPointHandle,out System.Reflection.Metadata.MethodDefinitionHandle
debugEntryPointHandle)
{
this_param.GetEntryPoints( out entryPointHandle, out debugEntryPointHandle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 3065, 3137);
return 0;
}


bool
f_506_3158_3186_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 3158, 3186);
return return_v;
}


int
f_506_3254_3300(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetToken( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 3254, 3300);
return return_v;
}


int
f_506_3485_3555(Microsoft.Cci.PdbWriter
this_param,System.IO.Stream
stream)
{
this_param.EmbedSourceLink( stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 3485, 3555);
return 0;
}


Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
f_506_3599_3614(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 3599, 3614);
return return_v;
}


Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
f_506_3936_3951(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 3936, 3951);
return return_v;
}


Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
f_506_3936_3976(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.GetSymbolToLocationMap();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 3936, 3976);
return return_v;
}


int
f_506_3892_3977(Microsoft.Cci.PdbWriter
this_param,Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
file2definitions)
{
this_param.WriteDefinitionLocations( file2definitions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 3892, 3977);
return 0;
}


Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
f_506_4264_4279(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 4264, 4279);
return return_v;
}


Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
f_506_4264_4304(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.GetSymbolToLocationMap();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4264, 4304);
return return_v;
}


int
f_506_4214_4305(Microsoft.Cci.PdbWriter
this_param,Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
file2definitions)
{
this_param.AssertAllDefinitionsHaveTokens( file2definitions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4214, 4305);
return 0;
}


Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
f_506_4401_4416(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 4401, 4416);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
f_506_4401_4453(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
this_param)
{
var return_v = this_param.DebugDocuments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 4401, 4453);
return return_v;
}


int
f_506_4353_4454(Microsoft.Cci.PdbWriter
this_param,System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
documents)
{
this_param.WriteRemainingDebugDocuments( documents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4353, 4454);
return 0;
}


System.IO.Stream
f_506_4504_4517(System.Func<System.IO.Stream>
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4504, 4517);
return return_v;
}


System.Reflection.Metadata.BlobContentId?
f_506_4659_4693_I(System.Reflection.Metadata.BlobContentId?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4659, 4693);
return return_v;
}


System.Reflection.Metadata.Ecma335.MetadataRootBuilder
f_506_4908_4933(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.GetRootBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4908, 4933);
return return_v;
}


System.Reflection.PortableExecutable.Subsystem
f_506_5701_5721(Microsoft.Cci.ModulePropertiesForSerialization
this_param)
{
var return_v = this_param.Subsystem;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 5701, 5721);
return return_v;
}


System.Reflection.PortableExecutable.DllCharacteristics
f_506_5760_5789(Microsoft.Cci.ModulePropertiesForSerialization
this_param)
{
var return_v = this_param.DllCharacteristics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 5760, 5789);
return return_v;
}


System.Reflection.PortableExecutable.Characteristics
f_506_5830_5861(Microsoft.Cci.ModulePropertiesForSerialization
this_param)
{
var return_v = this_param.ImageCharacteristics;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 5830, 5861);
return return_v;
}


System.Reflection.PortableExecutable.PEHeaderBuilder
f_506_4972_6126(System.Reflection.PortableExecutable.Machine
machine,int
sectionAlignment,int
fileAlignment,ulong
imageBase,byte
majorLinkerVersion,byte
minorLinkerVersion,int
majorOperatingSystemVersion,int
minorOperatingSystemVersion,int
majorImageVersion,int
minorImageVersion,ushort
majorSubsystemVersion,ushort
minorSubsystemVersion,System.Reflection.PortableExecutable.Subsystem
subsystem,System.Reflection.PortableExecutable.DllCharacteristics
dllCharacteristics,System.Reflection.PortableExecutable.Characteristics
imageCharacteristics,ulong
sizeOfStackReserve,ulong
sizeOfStackCommit,ulong
sizeOfHeapReserve,ulong
sizeOfHeapCommit)
{
var return_v = new System.Reflection.PortableExecutable.PEHeaderBuilder( machine: machine, sectionAlignment: sectionAlignment, fileAlignment: fileAlignment, imageBase: imageBase, majorLinkerVersion: majorLinkerVersion, minorLinkerVersion: minorLinkerVersion, majorOperatingSystemVersion: (ushort)majorOperatingSystemVersion, minorOperatingSystemVersion: (ushort)minorOperatingSystemVersion, majorImageVersion: (ushort)majorImageVersion, minorImageVersion: (ushort)minorImageVersion, majorSubsystemVersion: majorSubsystemVersion, minorSubsystemVersion: minorSubsystemVersion, subsystem: subsystem, dllCharacteristics: dllCharacteristics, imageCharacteristics: imageCharacteristics, sizeOfStackReserve: sizeOfStackReserve, sizeOfStackCommit: sizeOfStackCommit, sizeOfHeapReserve: sizeOfHeapReserve, sizeOfHeapCommit: sizeOfHeapCommit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 4972, 6126);
return return_v;
}


bool
f_506_6664_6698(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.EmitPortableDebugMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 6664, 6698);
return return_v;
}


Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
f_506_6768_6783(Microsoft.Cci.MetadataWriter
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 6768, 6783);
return return_v;
}


System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
f_506_6768_6820(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
this_param)
{
var return_v = this_param.DebugDocuments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 6768, 6820);
return return_v;
}


int
f_506_6732_6821(Microsoft.Cci.MetadataWriter
this_param,System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.DebugSourceDocument>
documents)
{
this_param.AddRemainingDebugDocuments( documents);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 6732, 6821);
return 0;
}


int
f_506_6938_7020(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 6938, 7020);
return 0;
}


System.Reflection.Metadata.BlobBuilder
f_506_7401_7418()
{
var return_v = new System.Reflection.Metadata.BlobBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 7401, 7418);
return return_v;
}


System.Reflection.Metadata.Ecma335.MetadataSizes
f_506_7493_7518(System.Reflection.Metadata.Ecma335.MetadataRootBuilder
this_param)
{
var return_v = this_param.Sizes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 7493, 7518);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_506_7493_7528(System.Reflection.Metadata.Ecma335.MetadataSizes
this_param)
{
var return_v = this_param.RowCounts;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 7493, 7528);
return return_v;
}


System.Reflection.Metadata.Ecma335.PortablePdbBuilder
f_506_7462_7575(Microsoft.Cci.MetadataWriter
this_param,System.Collections.Immutable.ImmutableArray<int>
typeSystemRowCounts,System.Reflection.Metadata.MethodDefinitionHandle
debugEntryPoint,System.Func<System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>, System.Reflection.Metadata.BlobContentId>?
deterministicIdProviderOpt)
{
var return_v = this_param.GetPortablePdbBuilder( typeSystemRowCounts, debugEntryPoint, deterministicIdProviderOpt);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 7462, 7575);
return return_v;
}


System.Reflection.Metadata.BlobContentId
f_506_7609_7654(System.Reflection.Metadata.Ecma335.PortablePdbBuilder
this_param,System.Reflection.Metadata.BlobBuilder
builder)
{
var return_v = this_param.Serialize( builder);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 7609, 7654);
return return_v;
}


ushort
f_506_7694_7726(System.Reflection.Metadata.Ecma335.PortablePdbBuilder
this_param)
{
var return_v = this_param.FormatVersion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 7694, 7726);
return return_v;
}


System.IO.Stream
f_506_8074_8099(System.Func<System.IO.Stream>
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 8074, 8099);
return return_v;
}


int
f_506_8261_8310(System.Reflection.Metadata.BlobBuilder
this_param,System.IO.Stream
destination)
{
this_param.WriteContentTo( destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 8261, 8310);
return 0;
}


string
f_506_8520_8529(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 8520, 8529);
return return_v;
}


Microsoft.DiaSymReader.SymUnmanagedWriterException
f_506_8488_8533(string
message,System.Exception
innerException)
{
var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException( message, innerException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 8488, 8533);
return return_v;
}


System.Reflection.PortableExecutable.DebugDirectoryBuilder
f_506_8821_8848()
{
var return_v = new System.Reflection.PortableExecutable.DebugDirectoryBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 8821, 8848);
return return_v;
}


string
f_506_8982_9004(string
path)
{
var return_v = PadPdbPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 8982, 9004);
return return_v;
}


int
f_506_9027_9111(System.Reflection.PortableExecutable.DebugDirectoryBuilder
this_param,string
pdbPath,System.Reflection.Metadata.BlobContentId
pdbContentId,ushort
portablePdbVersion)
{
this_param.AddCodeViewEntry( pdbPath, pdbContentId, portablePdbVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 9027, 9111);
return 0;
}


bool
f_506_9140_9173_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 9140, 9173);
return return_v;
}


int
f_506_9574_9681(System.Reflection.PortableExecutable.DebugDirectoryBuilder
this_param,string?
algorithmName,System.Collections.Immutable.ImmutableArray<byte>
checksum)
{
this_param.AddPdbChecksumEntry( algorithmName, checksum);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 9574, 9681);
return 0;
}


int
f_506_9805_9849(System.Reflection.PortableExecutable.DebugDirectoryBuilder
this_param)
{
this_param.AddReproducibleEntry();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 9805, 9849);
return 0;
}


int
f_506_9961_10050(System.Reflection.PortableExecutable.DebugDirectoryBuilder
this_param,System.Reflection.Metadata.BlobBuilder
debugMetadata,ushort
portablePdbVersion)
{
this_param.AddEmbeddedPortablePdbEntry( debugMetadata, portablePdbVersion);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 9961, 10050);
return 0;
}


Microsoft.CodeAnalysis.Compilation
f_506_10221_10253(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
this_param)
{
var return_v = this_param.CommonCompilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 10221, 10253);
return return_v;
}


Microsoft.CodeAnalysis.CompilationOptions
f_506_10221_10261(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 10221, 10261);
return return_v;
}


Microsoft.CodeAnalysis.StrongNameProvider?
f_506_10221_10280(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.StrongNameProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 10221, 10280);
return return_v;
}


System.Reflection.PortableExecutable.CorFlags
f_506_10310_10329(Microsoft.Cci.ModulePropertiesForSerialization
this_param)
{
var return_v = this_param.CorFlags;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 10310, 10329);
return return_v;
}


System.Reflection.PortableExecutable.ResourceSectionBuilder
f_506_10584_10637(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
module)
{
var return_v = CreateNativeResourceSectionSerializer( module);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 10584, 10637);
return return_v;
}


int
f_506_10696_10759(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
module,System.Security.Cryptography.RSAParameters?
privateKey)
{
var return_v = CalculateStrongNameSignatureSize( module, privateKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 10696, 10759);
return return_v;
}


bool
f_506_10887_10917_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 10887, 10917);
return return_v;
}


Microsoft.Cci.ExtendedPEBuilder
f_506_10362_10918(System.Reflection.PortableExecutable.PEHeaderBuilder
header,System.Reflection.Metadata.Ecma335.MetadataRootBuilder
metadataRootBuilder,System.Reflection.Metadata.BlobBuilder
ilStream,System.Reflection.Metadata.BlobBuilder
mappedFieldData,System.Reflection.Metadata.BlobBuilder
managedResources,System.Reflection.PortableExecutable.ResourceSectionBuilder
nativeResources,System.Reflection.PortableExecutable.DebugDirectoryBuilder?
debugDirectoryBuilder,int
strongNameSignatureSize,System.Reflection.Metadata.MethodDefinitionHandle
entryPoint,System.Reflection.PortableExecutable.CorFlags
flags,System.Func<System.Collections.Generic.IEnumerable<System.Reflection.Metadata.Blob>, System.Reflection.Metadata.BlobContentId>?
deterministicIdProvider,bool
withMvidSection)
{
var return_v = new Microsoft.Cci.ExtendedPEBuilder( header, metadataRootBuilder, ilStream, mappedFieldData, managedResources, nativeResources, debugDirectoryBuilder, strongNameSignatureSize, entryPoint, flags, deterministicIdProvider, withMvidSection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 10362, 10918);
return return_v;
}


System.Reflection.Metadata.BlobBuilder
f_506_10948_10965()
{
var return_v = new System.Reflection.Metadata.BlobBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 10948, 10965);
return return_v;
}


System.Reflection.Metadata.BlobContentId
f_506_10998_11052(Microsoft.Cci.ExtendedPEBuilder
this_param,System.Reflection.Metadata.BlobBuilder
peBlob,out System.Reflection.Metadata.Blob
mvidSectionFixup)
{
var return_v = this_param.Serialize( peBlob, out mvidSectionFixup);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 10998, 11052);
return return_v;
}


int
f_506_11069_11154(System.Reflection.Metadata.Blob
guidFixup,System.Reflection.Metadata.Blob
guidSectionFixup,System.Reflection.Metadata.Blob
stringFixup,System.Guid
mvid)
{
PatchModuleVersionIds( guidFixup, guidSectionFixup, stringFixup, mvid);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11069, 11154);
return 0;
}


bool
f_506_11200_11243(System.Reflection.PortableExecutable.CorFlags
this_param,System.Reflection.PortableExecutable.CorFlags
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11200, 11243);
return return_v;
}


int
f_506_11277_11347(Microsoft.CodeAnalysis.StrongNameProvider?
this_param,Microsoft.Cci.ExtendedPEBuilder
peBuilder,System.Reflection.Metadata.BlobBuilder
peBlob,System.Security.Cryptography.RSAParameters
privateKey)
{
this_param.SignBuilder( peBuilder, peBlob, privateKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11277, 11347);
return 0;
}


int
f_506_11415_11446(System.Reflection.Metadata.BlobBuilder
this_param,System.IO.Stream
destination)
{
this_param.WriteContentTo( destination);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11415, 11446);
return 0;
}


Microsoft.Cci.PeWritingException
f_506_11576_11601(System.Exception
inner)
{
var return_v = new Microsoft.Cci.PeWritingException( inner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11576, 11601);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,1125,11656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,1125,11656);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static MethodInfo s_calculateChecksumMethod;

internal static uint CalculateChecksum(BlobBuilder peBlob, Blob checksumBlob)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(506,11763,12324);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11865,12145) || true) && (s_calculateChecksumMethod == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,11865,12145);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11936,12130);

s_calculateChecksumMethod = f_506_11964_12129(f_506_11964_12098(f_506_11964_12001(typeof(PEBuilder)), m => m.Name == "CalculateChecksum" && m.GetParameters().Length == 2));
DynAbs.Tracing.TraceSender.TraceExitCondition(506,11865,12145);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12161,12313);

return (uint)f_506_12174_12312(s_calculateChecksumMethod, null, new object[]
            {
                peBlob,
                checksumBlob,
            });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(506,11763,12324);

System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
f_506_11964_12001(System.Type
type)
{
var return_v = type.GetRuntimeMethods();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11964, 12001);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
f_506_11964_12098(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
source,System.Func<System.Reflection.MethodInfo, bool>
predicate)
{
var return_v = source.Where<System.Reflection.MethodInfo>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11964, 12098);
return return_v;
}


System.Reflection.MethodInfo
f_506_11964_12129(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>
source)
{
var return_v = source.Single<System.Reflection.MethodInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 11964, 12129);
return return_v;
}


object?
f_506_12174_12312(System.Reflection.MethodInfo
this_param,object?
obj,object[]
parameters)
{
var return_v = this_param.Invoke( obj, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 12174, 12312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,11763,12324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,11763,12324);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void PatchModuleVersionIds(Blob guidFixup, Blob guidSectionFixup, Blob stringFixup, Guid mvid)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(506,12336,13184);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12470,12682) || true) && (f_506_12474_12494_M(!guidFixup.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,12470,12682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12528,12567);

var 
writer = f_506_12541_12566(guidFixup)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12585,12608);

writer.WriteGuid(mvid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12626,12667);

f_506_12626_12666(writer.RemainingBytes == 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,12470,12682);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12698,12924) || true) && (f_506_12702_12729_M(!guidSectionFixup.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,12698,12924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12763,12809);

var 
writer = f_506_12776_12808(guidSectionFixup)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12827,12850);

writer.WriteGuid(mvid);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12868,12909);

f_506_12868_12908(writer.RemainingBytes == 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,12698,12924);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,12940,13173) || true) && (f_506_12944_12966_M(!stringFixup.IsDefault))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,12940,13173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,13000,13041);

var 
writer = f_506_13013_13040(stringFixup)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,13059,13099);

writer.WriteUserString(mvid.ToString());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,13117,13158);

f_506_13117_13157(writer.RemainingBytes == 0);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,12940,13173);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(506,12336,13184);

bool
f_506_12474_12494_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 12474, 12494);
return return_v;
}


System.Reflection.Metadata.BlobWriter
f_506_12541_12566(System.Reflection.Metadata.Blob
blob)
{
var return_v = new System.Reflection.Metadata.BlobWriter( blob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 12541, 12566);
return return_v;
}


int
f_506_12626_12666(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 12626, 12666);
return 0;
}


bool
f_506_12702_12729_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 12702, 12729);
return return_v;
}


System.Reflection.Metadata.BlobWriter
f_506_12776_12808(System.Reflection.Metadata.Blob
blob)
{
var return_v = new System.Reflection.Metadata.BlobWriter( blob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 12776, 12808);
return return_v;
}


int
f_506_12868_12908(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 12868, 12908);
return 0;
}


bool
f_506_12944_12966_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 12944, 12966);
return return_v;
}


System.Reflection.Metadata.BlobWriter
f_506_13013_13040(System.Reflection.Metadata.Blob
blob)
{
var return_v = new System.Reflection.Metadata.BlobWriter( blob);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 13013, 13040);
return return_v;
}


int
f_506_13117_13157(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 13117, 13157);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,12336,13184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,12336,13184);
}
		}

private static string PadPdbPath(string path)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(506,13427,13642);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,13497,13523);

const int 
minLength = 260
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,13537,13631);

return path + f_506_13551_13630('\0', f_506_13568_13629(0, minLength - f_506_13592_13624(f_506_13592_13605(), path)- 1));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(506,13427,13642);

System.Text.Encoding
f_506_13592_13605()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(506, 13592, 13605);
return return_v;
}


int
f_506_13592_13624(System.Text.Encoding
this_param,string
s)
{
var return_v = this_param.GetByteCount( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 13592, 13624);
return return_v;
}


int
f_506_13568_13629(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 13568, 13629);
return return_v;
}


string
f_506_13551_13630(char
c,int
count)
{
var return_v = new string( c, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 13551, 13630);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,13427,13642);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,13427,13642);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ResourceSectionBuilder CreateNativeResourceSectionSerializer(CommonPEModuleBuilder module)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(506,13654,15118);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14572,14631);

var 
nativeResourceSectionOpt = module.Win32ResourceSection
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14645,14797) || true) && (nativeResourceSectionOpt != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,14645,14797);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14715,14782);

return f_506_14722_14781(nativeResourceSectionOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,14645,14797);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14813,14860);

var 
nativeResourcesOpt = module.Win32Resources
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14897,15079) || true) && (nativeResourcesOpt != null &&(DynAbs.Tracing.TraceSender.Expression_True(506, 14901, 14963)&&f_506_14931_14955(nativeResourcesOpt)== true))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(506,14897,15079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,14997,15064);

return f_506_15004_15063(nativeResourcesOpt);
DynAbs.Tracing.TraceSender.TraceExitCondition(506,14897,15079);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15095,15107);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(506,13654,15118);

Microsoft.Cci.PeWriter.ResourceSectionBuilderFromObj
f_506_14722_14781(Microsoft.Cci.ResourceSection
resourceSection)
{
var return_v = new Microsoft.Cci.PeWriter.ResourceSectionBuilderFromObj( resourceSection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 14722, 14781);
return return_v;
}


bool
f_506_14931_14955(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
source)
{
var return_v = source.Any<Microsoft.Cci.IWin32Resource>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 14931, 14955);
return return_v;
}


Microsoft.Cci.PeWriter.ResourceSectionBuilderFromResources
f_506_15004_15063(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
resources)
{
var return_v = new Microsoft.Cci.PeWriter.ResourceSectionBuilderFromResources( resources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 15004, 15063);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,13654,15118);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,13654,15118);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
private class ResourceSectionBuilderFromObj : ResourceSectionBuilder
{
private readonly ResourceSection _resourceSection;

public ResourceSectionBuilderFromObj(ResourceSection resourceSection)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(506,15289,15497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15256,15272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15391,15429);

f_506_15391_15428(resourceSection != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15447,15482);

_resourceSection = resourceSection;
DynAbs.Tracing.TraceSender.TraceExitConstructor(506,15289,15497);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,15289,15497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,15289,15497);
}
		}

protected override void Serialize(BlobBuilder builder, SectionLocation location)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(506,15513,15746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15626,15731);

f_506_15626_15730(builder, _resourceSection, location.RelativeVirtualAddress);
DynAbs.Tracing.TraceSender.TraceExitMethod(506,15513,15746);

int
f_506_15626_15730(System.Reflection.Metadata.BlobBuilder
builder,Microsoft.Cci.ResourceSection
resourceSections,int
resourcesRva)
{
NativeResourceWriter.SerializeWin32Resources( builder, resourceSections, resourcesRva);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 15626, 15730);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,15513,15746);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,15513,15746);
}
		}

static ResourceSectionBuilderFromObj()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(506,15130,15757);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(506,15130,15757);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,15130,15757);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(506,15130,15757);

static int
f_506_15391_15428(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 15391, 15428);
return 0;
}

}
private class ResourceSectionBuilderFromResources : ResourceSectionBuilder
{
private readonly IEnumerable<IWin32Resource> _resources;

public ResourceSectionBuilderFromResources(IEnumerable<IWin32Resource> resources)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(506,15940,16140);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,15913,15923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,16054,16084);

f_506_16054_16083(f_506_16067_16082(resources));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,16102,16125);

_resources = resources;
DynAbs.Tracing.TraceSender.TraceExitConstructor(506,15940,16140);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,15940,16140);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,15940,16140);
}
		}

protected override void Serialize(BlobBuilder builder, SectionLocation location)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(506,16156,16383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,16269,16368);

f_506_16269_16367(builder, _resources, location.RelativeVirtualAddress);
DynAbs.Tracing.TraceSender.TraceExitMethod(506,16156,16383);

int
f_506_16269_16367(System.Reflection.Metadata.BlobBuilder
builder,System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
theResources,int
resourcesRva)
{
NativeResourceWriter.SerializeWin32Resources( builder, theResources, resourcesRva);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 16269, 16367);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(506,16156,16383);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,16156,16383);
}
		}

static ResourceSectionBuilderFromResources()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(506,15769,16394);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(506,15769,16394);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,15769,16394);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(506,15769,16394);

static bool
f_506_16067_16082(System.Collections.Generic.IEnumerable<Microsoft.Cci.IWin32Resource>
source)
{
var return_v = source.Any<Microsoft.Cci.IWin32Resource>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 16067, 16082);
return return_v;
}


static int
f_506_16054_16083(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(506, 16054, 16083);
return 0;
}

}

static PeWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(506,1078,16401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(506,11694,11719);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(506,1078,16401);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(506,1078,16401);
}

}
}
