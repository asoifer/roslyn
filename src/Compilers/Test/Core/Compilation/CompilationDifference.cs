// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.DiaSymReader.Tools;
using Microsoft.Metadata.Tools;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public sealed class CompilationDifference
{
public readonly ImmutableArray<byte> MetadataDelta;

public readonly ImmutableArray<byte> ILDelta;

public readonly ImmutableArray<byte> PdbDelta;

internal readonly CompilationTestData TestData;

public readonly EmitDifferenceResult EmitResult;

public readonly ImmutableArray<MethodDefinitionHandle> UpdatedMethods;

internal CompilationDifference(
            ImmutableArray<byte> metadata,
            ImmutableArray<byte> il,
            ImmutableArray<byte> pdb,
            CompilationTestData testData,
            EmitDifferenceResult result,
            ImmutableArray<MethodDefinitionHandle> methodHandles)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25056,1171,1705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1012,1020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1068,1078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1500,1525);

MetadataDelta = metadata;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1539,1552);

ILDelta = il;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1566,1581);

PdbDelta = pdb;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1595,1615);

TestData = testData;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1629,1649);

EmitResult = result;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1663,1694);

UpdatedMethods = methodHandles;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25056,1171,1705);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,1171,1705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,1171,1705);
}
		}

public EmitBaseline NextGeneration
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,1776,1854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1812,1839);

return f_25056_1819_1838(EmitResult);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,1776,1854);

Microsoft.CodeAnalysis.Emit.EmitBaseline
f_25056_1819_1838(Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
this_param)
{
var return_v = this_param.Baseline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 1819, 1838);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,1717,1865);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,1717,1865);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal PinnedMetadata GetMetadata()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,1877,1991);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,1939,1980);

return f_25056_1946_1979(MetadataDelta);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,1877,1991);

Roslyn.Test.Utilities.PinnedMetadata
f_25056_1946_1979(System.Collections.Immutable.ImmutableArray<byte>
metadata)
{
var return_v = new Roslyn.Test.Utilities.PinnedMetadata( metadata);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 1946, 1979);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,1877,1991);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,1877,1991);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void VerifyIL(
            string expectedIL,
            [CallerLineNumber] int callerLine = 0,
            [CallerFilePath] string callerPath = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,2003,2422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,2189,2229);

string 
actualIL = ILDelta.GetMethodIL()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,2243,2411);

f_25056_2243_2410(expectedIL, actualIL, escapeQuotes: true, expectedValueSourcePath: callerPath, expectedValueSourceLine: callerLine);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,2003,2422);

bool
f_25056_2243_2410(string
expected,string
actual,bool
escapeQuotes,string
expectedValueSourcePath,int
expectedValueSourceLine)
{
var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences( expected, actual, escapeQuotes: escapeQuotes, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 2243, 2410);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,2003,2422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,2003,2422);
}
		}

public void VerifyLocalSignature(
            string qualifiedMethodName,
            string expectedSignature,
            [CallerLineNumber] int callerLine = 0,
            [CallerFilePath] string callerPath = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,2434,3063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,2680,2750);

var 
ilBuilder = f_25056_2696_2739(TestData, qualifiedMethodName).ILBuilder
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,2764,2856);

string 
actualSignature = f_25056_2789_2855(ilBuilder, ToLocalInfo)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,2870,3052);

f_25056_2870_3051(expectedSignature, actualSignature, escapeQuotes: true, expectedValueSourcePath: callerPath, expectedValueSourceLine: callerLine);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,2434,3063);

Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_25056_2696_2739(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 2696, 2739);
return return_v;
}


string
f_25056_2789_2855(Microsoft.CodeAnalysis.CodeGen.ILBuilder
builder,System.Func<Microsoft.Cci.ILocalDefinition, Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
mapLocal)
{
var return_v = ILBuilderVisualizer.LocalSignatureToString( builder, mapLocal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 2789, 2855);
return return_v;
}


bool
f_25056_2870_3051(string
expected,string
actual,bool
escapeQuotes,string
expectedValueSourcePath,int
expectedValueSourceLine)
{
var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences( expected, actual, escapeQuotes: escapeQuotes, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 2870, 3051);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,2434,3063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,2434,3063);
}
		}

internal void VerifyIL(
            string qualifiedMethodName,
            string expectedIL,
            Func<Cci.ILocalDefinition, ILVisualizer.LocalInfo> mapLocal = null,
            MethodDefinitionHandle methodToken = default,
            [CallerFilePath] string callerPath = null,
            [CallerLineNumber] int callerLine = 0)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,3075,4344);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3444,3514);

var 
ilBuilder = f_25056_3460_3503(TestData, qualifiedMethodName).ILBuilder
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3530,3582);

Dictionary<int, string> 
sequencePointMarkers = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3596,4021) || true) && (f_25056_3600_3618_M(!methodToken.IsNil))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,3596,4021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3652,3788);

string 
actualPdb = f_25056_3671_3787(f_25056_3703_3738(PdbDelta), new[] { f_25056_3748_3784(methodToken)})
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3806,3877);

sequencePointMarkers = f_25056_3829_3876(actualPdb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,3897,4006);

f_25056_3897_4005(f_25056_3909_3935(sequencePointMarkers)> 0, $"No sequence points found in:{f_25056_3972_3991()}{actualPdb}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,3596,4021);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4037,4151);

string 
actualIL = f_25056_4055_4150(ilBuilder, mapLocal ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Func<Microsoft.Cci.ILocalDefinition, Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>?>(25056, 4104, 4127)??ToLocalInfo), sequencePointMarkers)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4165,4333);

f_25056_4165_4332(expectedIL, actualIL, escapeQuotes: true, expectedValueSourcePath: callerPath, expectedValueSourceLine: callerLine);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,3075,4344);

Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_25056_3460_3503(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3460, 3503);
return return_v;
}


bool
f_25056_3600_3618_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 3600, 3618);
return return_v;
}


Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
f_25056_3703_3738(System.Collections.Immutable.ImmutableArray<byte>
array)
{
var return_v = new Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream( array);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3703, 3738);
return return_v;
}


int
f_25056_3748_3784(System.Reflection.Metadata.MethodDefinitionHandle
handle)
{
var return_v = MetadataTokens.GetToken( (System.Reflection.Metadata.EntityHandle)handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3748, 3784);
return return_v;
}


string
f_25056_3671_3787(Microsoft.CodeAnalysis.Collections.ImmutableMemoryStream
deltaPdb,int[]
methodTokens)
{
var return_v = PdbToXmlConverter.DeltaPdbToXml( (System.IO.Stream)deltaPdb, (System.Collections.Generic.IEnumerable<int>)methodTokens);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3671, 3787);
return return_v;
}


System.Collections.Generic.Dictionary<int, string>
f_25056_3829_3876(string
pdbXml)
{
var return_v = ILValidation.GetSequencePointMarkers( pdbXml);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3829, 3876);
return return_v;
}


int
f_25056_3909_3935(System.Collections.Generic.Dictionary<int, string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 3909, 3935);
return return_v;
}


string
f_25056_3972_3991()
{
var return_v = Environment.NewLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 3972, 3991);
return return_v;
}


int
f_25056_3897_4005(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 3897, 4005);
return 0;
}


string
f_25056_4055_4150(Microsoft.CodeAnalysis.CodeGen.ILBuilder
builder,System.Func<Microsoft.Cci.ILocalDefinition, Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
mapLocal,System.Collections.Generic.Dictionary<int, string>?
markers)
{
var return_v = ILBuilderVisualizer.ILBuilderToString( builder, mapLocal, (System.Collections.Generic.IReadOnlyDictionary<int, string>?)markers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 4055, 4150);
return return_v;
}


bool
f_25056_4165_4332(string
expected,string
actual,bool
escapeQuotes,string
expectedValueSourcePath,int
expectedValueSourceLine)
{
var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences( expected, actual, escapeQuotes: escapeQuotes, expectedValueSourcePath: expectedValueSourcePath, expectedValueSourceLine: expectedValueSourceLine);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 4165, 4332);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,3075,4344);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,3075,4344);
}
		}

internal string GetMethodIL(string qualifiedMethodName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,4356,4565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4436,4554);

return f_25056_4443_4553(f_25056_4481_4529(this.TestData, qualifiedMethodName).ILBuilder, ToLocalInfo);
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,4356,4565);

Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
f_25056_4481_4529(Microsoft.CodeAnalysis.CodeGen.CompilationTestData
data,string
qualifiedMethodName)
{
var return_v = data.GetMethodData( qualifiedMethodName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 4481, 4529);
return return_v;
}


string
f_25056_4443_4553(Microsoft.CodeAnalysis.CodeGen.ILBuilder
builder,System.Func<Microsoft.Cci.ILocalDefinition, Microsoft.Metadata.Tools.ILVisualizer.LocalInfo>
mapLocal)
{
var return_v = ILBuilderVisualizer.ILBuilderToString( builder, mapLocal);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 4443, 4553);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,4356,4565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,4356,4565);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ILVisualizer.LocalInfo ToLocalInfo(Cci.ILocalDefinition local)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25056,4577,5203);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4679,4711);

var 
signature = f_25056_4695_4710(local)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4725,5192) || true) && (signature == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,4725,5192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4780,4873);

return f_25056_4787_4872(f_25056_4814_4824(local), f_25056_4826_4836(local), f_25056_4838_4852(local), f_25056_4854_4871(local));
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,4725,5192);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,4725,5192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,4985,5078);

var 
typeName = (DynAbs.Tracing.TraceSender.Conditional_F1(25056, 5000, 5023)||(((f_25056_5001_5017(signature)== 1) &&DynAbs.Tracing.TraceSender.Conditional_F2(25056, 5026, 5070))||DynAbs.Tracing.TraceSender.Conditional_F3(25056, 5073, 5077)))?f_25056_5026_5070(signature[0]):null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5096,5177);

return f_25056_5103_5176(null, typeName ??(DynAbs.Tracing.TraceSender.Expression_Null<string?>(25056, 5136, 5161)??"[unchanged]"), false, false);
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,4725,5192);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25056,4577,5203);

byte[]?
f_25056_4695_4710(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Signature;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 4695, 4710);
return return_v;
}


string?
f_25056_4814_4824(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 4814, 4824);
return return_v;
}


Microsoft.Cci.ITypeReference
f_25056_4826_4836(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 4826, 4836);
return return_v;
}


bool
f_25056_4838_4852(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.IsPinned;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 4838, 4852);
return return_v;
}


bool
f_25056_4854_4871(Microsoft.Cci.ILocalDefinition
this_param)
{
var return_v = this_param.IsReference;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 4854, 4871);
return return_v;
}


Microsoft.Metadata.Tools.ILVisualizer.LocalInfo
f_25056_4787_4872(string?
name,Microsoft.Cci.ITypeReference
type,bool
isPinned,bool
isByRef)
{
var return_v = new Microsoft.Metadata.Tools.ILVisualizer.LocalInfo( name, (object)type, isPinned, isByRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 4787, 4872);
return return_v;
}


int
f_25056_5001_5017(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 5001, 5017);
return return_v;
}


string
f_25056_5026_5070(byte
typeCode)
{
var return_v = GetTypeName( (System.Reflection.Metadata.SignatureTypeCode)typeCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 5026, 5070);
return return_v;
}


Microsoft.Metadata.Tools.ILVisualizer.LocalInfo
f_25056_5103_5176(string
name,string
type,bool
isPinned,bool
isByRef)
{
var return_v = new Microsoft.Metadata.Tools.ILVisualizer.LocalInfo( name, (object)type, isPinned, isByRef);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 5103, 5176);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,4577,5203);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,4577,5203);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetTypeName(SignatureTypeCode typeCode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25056,5215,5661);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5301,5650);

switch (typeCode)
            {

case SignatureTypeCode.Boolean: DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,5301,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5383,5399);

return "[bool]";
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,5301,5650);

case SignatureTypeCode.Int32: DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,5301,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5447,5462);

return "[int]";
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,5301,5650);

case SignatureTypeCode.String: DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,5301,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5511,5529);

return "[string]";
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,5301,5650);

case SignatureTypeCode.Object: DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,5301,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5578,5596);

return "[object]";
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,5301,5650);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(25056,5301,5650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5623,5635);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(25056,5301,5650);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25056,5215,5661);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,5215,5661);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,5215,5661);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void VerifySynthesizedMembers(params string[] expectedSynthesizedTypesAndMemberCounts)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,5673,6051);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5791,5936);

var 
actual = f_25056_5804_5935(f_25056_5804_5823(EmitResult).SynthesizedMembers, e => e.Key.ToString() + ": {" + string.Join(", ", e.Value.Select(v => v.Name)) + "}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,5950,6040);

f_25056_5950_6039(expectedSynthesizedTypesAndMemberCounts, actual, itemSeparator: "\r\n");
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,5673,6051);

Microsoft.CodeAnalysis.Emit.EmitBaseline
f_25056_5804_5823(Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
this_param)
{
var return_v = this_param.Baseline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 5804, 5823);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25056_5804_5935(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
source,System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>, string>
selector)
{
var return_v = source.Select<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 5804, 5935);
return return_v;
}


int
f_25056_5950_6039(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual,string
itemSeparator)
{
AssertEx.SetEqual( (System.Collections.Generic.IEnumerable<string>)expected, actual, itemSeparator: itemSeparator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 5950, 6039);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,5673,6051);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,5673,6051);
}
		}

public void VerifySynthesizedFields(string typeName, params string[] expectedSynthesizedTypesAndMemberCounts)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,6063,6529);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,6197,6414);

var 
actual = f_25056_6210_6413(f_25056_6210_6377(f_25056_6210_6290(f_25056_6210_6229(EmitResult).SynthesizedMembers, e => e.Key.ToString() == typeName).Value.Where(s => s.Kind == SymbolKind.Field), s => (IFieldSymbol)s.GetISymbol()), f => f.Name + ": " + f.Type)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,6428,6518);

f_25056_6428_6517(expectedSynthesizedTypesAndMemberCounts, actual, itemSeparator: "\r\n");
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,6063,6529);

Microsoft.CodeAnalysis.Emit.EmitBaseline
f_25056_6210_6229(Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
this_param)
{
var return_v = this_param.Baseline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25056, 6210, 6229);
return return_v;
}


System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
f_25056_6210_6290(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
source,System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>, bool>
predicate)
{
var return_v = source.Single<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 6210, 6290);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IFieldSymbol>
f_25056_6210_6377(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
source,System.Func<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, Microsoft.CodeAnalysis.IFieldSymbol>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.Symbols.ISymbolInternal,Microsoft.CodeAnalysis.IFieldSymbol>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 6210, 6377);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25056_6210_6413(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IFieldSymbol>
source,System.Func<Microsoft.CodeAnalysis.IFieldSymbol, string>
selector)
{
var return_v = source.Select<Microsoft.CodeAnalysis.IFieldSymbol,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 6210, 6413);
return return_v;
}


int
f_25056_6428_6517(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual,string
itemSeparator)
{
AssertEx.SetEqual( (System.Collections.Generic.IEnumerable<string>)expected, actual, itemSeparator: itemSeparator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 6428, 6517);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,6063,6529);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,6063,6529);
}
		}

public void VerifyUpdatedMethods(params string[] expectedMethodTokens)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25056,6541,6807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25056,6636,6796);

f_25056_6636_6795(expectedMethodTokens, UpdatedMethods.Select(methodHandle => $"0x{MetadataTokens.GetToken(methodHandle):X8}"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25056,6541,6807);

bool
f_25056_6636_6795(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25056, 6636, 6795);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25056,6541,6807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,6541,6807);
}
		}

static CompilationDifference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25056,744,6814);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25056,744,6814);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25056,744,6814);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25056,744,6814);
}
}
