// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Microsoft.DiaSymReader
{
internal unsafe class MetadataAdapterBase : IMetadataImport, IMetadataEmit
{
public virtual int GetTokenFromSig(byte* voidPointerSig, int byteCountSig)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,531,569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,534,569);
throw f_740_540_569();DynAbs.Tracing.TraceSender.TraceExitMethod(740,531,569);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,531,569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,531,569);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_540_569()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 540, 569);
return return_v;
}

		}

public virtual int GetSigFromToken(
            int standaloneSignature,
            [Out] byte** signature,
            [Out] int* signatureLength)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,747,785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,750,785);
throw f_740_756_785();DynAbs.Tracing.TraceSender.TraceExitMethod(740,747,785);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,747,785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,747,785);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_756_785()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 756, 785);
return return_v;
}

		}

public virtual int GetTypeDefProps(
            int typeDef,
            [Out] char* qualifiedName,
            int qualifiedNameBufferLength,
            [Out] int* qualifiedNameLength,
            [Out] TypeAttributes* attributes,
            [Out] int* baseType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,1083,1121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,1086,1121);
throw f_740_1092_1121();DynAbs.Tracing.TraceSender.TraceExitMethod(740,1083,1121);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,1083,1121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,1083,1121);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_1092_1121()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 1092, 1121);
return return_v;
}

		}

public virtual int GetTypeRefProps(
            int typeRef,
            [Out] int* resolutionScope, // ModuleRef or AssemblyRef
            [Out] char* qualifiedName,
            int qualifiedNameBufferLength,
            [Out] int* qualifiedNameLength)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,1407,1445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,1410,1445);
throw f_740_1416_1445();DynAbs.Tracing.TraceSender.TraceExitMethod(740,1407,1445);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,1407,1445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,1407,1445);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_1416_1445()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 1416, 1445);
return return_v;
}

		}

public virtual int GetNestedClassProps(int nestedClass, out int enclosingClass)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,1551,1589);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,1554,1589);
throw f_740_1560_1589();DynAbs.Tracing.TraceSender.TraceExitMethod(740,1551,1589);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,1551,1589);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,1551,1589);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_1560_1589()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 1560, 1589);
return return_v;
}

		}

public virtual int GetMethodProps(
            int methodDef,
            [Out] int* declaringTypeDef,
            [Out] char* name,
            int nameBufferLength,
            [Out] int* nameLength,
            [Out] MethodAttributes* attributes,
            [Out] byte** signature,
            [Out] int* signatureLength,
            [Out] int* relativeVirtualAddress,
            [Out] MethodImplAttributes* implAttributes)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2054,2092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2057,2092);
throw f_740_2063_2092();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2054,2092);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2054,2092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2054,2092);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2063_2092()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2063, 2092);
return return_v;
}

		}

void IMetadataImport.CloseEnum(void* enumHandle) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2154,2192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2157,2192);
throw f_740_2163_2192();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2154,2192);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2154,2192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2154,2192);
}

System.NotImplementedException
f_740_2163_2192()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2163, 2192);
return return_v;
}

		}

int IMetadataImport.CountEnum(void* enumHandle, out int count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2266,2304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2269,2304);
throw f_740_2275_2304();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2266,2304);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2266,2304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2266,2304);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2275_2304()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2275, 2304);
return return_v;
}

		}

int IMetadataImport.ResetEnum(void* enumHandle, int position) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2377,2415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2380,2415);
throw f_740_2386_2415();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2377,2415);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2377,2415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2377,2415);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2386_2415()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2386, 2415);
return return_v;
}

		}

int IMetadataImport.EnumTypeDefs(ref void* enumHandle, int* typeDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2526,2564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2529,2564);
throw f_740_2535_2564();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2526,2564);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2526,2564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2526,2564);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2535_2564()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2535, 2564);
return return_v;
}

		}

int IMetadataImport.EnumInterfaceImpls(ref void* enumHandle, int typeDef, int* interfaceImpls, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2700,2738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2703,2738);
throw f_740_2709_2738();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2700,2738);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2700,2738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2700,2738);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2709_2738()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2709, 2738);
return return_v;
}

		}

int IMetadataImport.EnumTypeRefs(ref void* enumHandle, int* typeRefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2849,2887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2852,2887);
throw f_740_2858_2887();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2849,2887);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2849,2887);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2849,2887);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2858_2887()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2858, 2887);
return return_v;
}

		}

int IMetadataImport.FindTypeDefByName(string name, int enclosingClass, out int typeDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,2986,3024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,2989,3024);
throw f_740_2995_3024();DynAbs.Tracing.TraceSender.TraceExitMethod(740,2986,3024);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,2986,3024);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,2986,3024);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_2995_3024()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 2995, 3024);
return return_v;
}

		}

int IMetadataImport.GetScopeProps(char* name, int bufferLength, int* nameLength, Guid* mvid) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3128,3166);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3131,3166);
throw f_740_3137_3166();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3128,3166);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3128,3166);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3128,3166);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3137_3166()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3137, 3166);
return return_v;
}

		}

int IMetadataImport.GetModuleFromScope(out int moduleDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3235,3273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3238,3273);
throw f_740_3244_3273();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3235,3273);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3235,3273);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3235,3273);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3244_3273()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3244, 3273);
return return_v;
}

		}

int IMetadataImport.GetInterfaceImplProps(int interfaceImpl, int* typeDef, int* interfaceDefRefSpec) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3385,3423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3388,3423);
throw f_740_3394_3423();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3385,3423);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3385,3423);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3385,3423);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3394_3423()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3394, 3423);
return return_v;
}

		}

int IMetadataImport.ResolveTypeRef(int typeRef, ref Guid scopeInterfaceId, out object scope, out int typeDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3544,3582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3547,3582);
throw f_740_3553_3582();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3544,3582);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3544,3582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3544,3582);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3553_3582()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3553, 3582);
return return_v;
}

		}

int IMetadataImport.EnumMembers(ref void* enumHandle, int typeDef, int* memberDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3707,3745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3710,3745);
throw f_740_3716_3745();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3707,3745);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3707,3745);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3707,3745);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3716_3745()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3716, 3745);
return return_v;
}

		}

int IMetadataImport.EnumMembersWithName(ref void* enumHandle, int typeDef, string name, int* memberDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,3891,3929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,3894,3929);
throw f_740_3900_3929();DynAbs.Tracing.TraceSender.TraceExitMethod(740,3891,3929);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,3891,3929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,3891,3929);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_3900_3929()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 3900, 3929);
return return_v;
}

		}

int IMetadataImport.EnumMethods(ref void* enumHandle, int typeDef, int* methodDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4054,4092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4057,4092);
throw f_740_4063_4092();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4054,4092);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4054,4092);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4054,4092);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4063_4092()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4063, 4092);
return return_v;
}

		}

int IMetadataImport.EnumMethodsWithName(ref void* enumHandle, int typeDef, string name, int* methodDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4238,4276);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4241,4276);
throw f_740_4247_4276();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4238,4276);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4238,4276);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4238,4276);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4247_4276()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4247, 4276);
return return_v;
}

		}

int IMetadataImport.EnumFields(ref void* enumHandle, int typeDef, int* fieldDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4399,4437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4402,4437);
throw f_740_4408_4437();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4399,4437);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4399,4437);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4399,4437);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4408_4437()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4408, 4437);
return return_v;
}

		}

int IMetadataImport.EnumFieldsWithName(ref void* enumHandle, int typeDef, string name, int* fieldDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4581,4619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4584,4619);
throw f_740_4590_4619();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4581,4619);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4581,4619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4581,4619);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4590_4619()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4590, 4619);
return return_v;
}

		}

int IMetadataImport.EnumParams(ref void* enumHandle, int methodDef, int* paramDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4744,4782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4747,4782);
throw f_740_4753_4782();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4744,4782);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4744,4782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4744,4782);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4753_4782()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4753, 4782);
return return_v;
}

		}

int IMetadataImport.EnumMemberRefs(ref void* enumHandle, int parentToken, int* memberRefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,4914,4952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,4917,4952);
throw f_740_4923_4952();DynAbs.Tracing.TraceSender.TraceExitMethod(740,4914,4952);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,4914,4952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,4914,4952);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_4923_4952()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 4923, 4952);
return return_v;
}

		}

int IMetadataImport.EnumMethodImpls(ref void* enumHandle, int typeDef, int* implementationTokens, int* declarationTokens, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5115,5153);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5118,5153);
throw f_740_5124_5153();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5115,5153);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5115,5153);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5115,5153);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5124_5153()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5124, 5153);
return return_v;
}

		}

int IMetadataImport.EnumPermissionSets(ref void* enumHandle, int token, uint action, int* declSecurityTokens, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5304,5342);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5307,5342);
throw f_740_5313_5342();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5304,5342);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5304,5342);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5304,5342);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5313_5342()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5313, 5342);
return return_v;
}

		}

int IMetadataImport.FindMember(int typeDef, string name, byte* signature, int signatureLength, out int memberDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5467,5505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5470,5505);
throw f_740_5476_5505();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5467,5505);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5467,5505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5467,5505);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5476_5505()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5476, 5505);
return return_v;
}

		}

int IMetadataImport.FindMethod(int typeDef, string name, byte* signature, int signatureLength, out int methodDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5630,5668);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5633,5668);
throw f_740_5639_5668();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5630,5668);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5630,5668);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5630,5668);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5639_5668()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5639, 5668);
return return_v;
}

		}

int IMetadataImport.FindField(int typeDef, string name, byte* signature, int signatureLength, out int fieldDef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5791,5829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5794,5829);
throw f_740_5800_5829();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5791,5829);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5791,5829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5791,5829);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5800_5829()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5800, 5829);
return return_v;
}

		}

int IMetadataImport.FindMemberRef(int typeDef, string name, byte* signature, int signatureLength, out int memberRef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,5957,5995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,5960,5995);
throw f_740_5966_5995();DynAbs.Tracing.TraceSender.TraceExitMethod(740,5957,5995);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,5957,5995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,5957,5995);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_5966_5995()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 5966, 5995);
return return_v;
}

		}

int IMetadataImport.GetMemberRefProps(int memberRef, int* declaringType, char* name, int nameBufferLength, int* nameLength, byte** signature, int* signatureLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,6170,6208);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,6173,6208);
throw f_740_6179_6208();DynAbs.Tracing.TraceSender.TraceExitMethod(740,6170,6208);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,6170,6208);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,6170,6208);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_6179_6208()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 6179, 6208);
return return_v;
}

		}

int IMetadataImport.EnumProperties(ref void* enumHandle, int typeDef, int* properties, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,6336,6374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,6339,6374);
throw f_740_6345_6374();DynAbs.Tracing.TraceSender.TraceExitMethod(740,6336,6374);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,6336,6374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,6336,6374);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_6345_6374()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 6345, 6374);
return return_v;
}

		}

uint IMetadataImport.EnumEvents(ref void* enumHandle, int typeDef, int* events, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,6495,6533);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,6498,6533);
throw f_740_6504_6533();DynAbs.Tracing.TraceSender.TraceExitMethod(740,6495,6533);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,6495,6533);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,6495,6533);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_6504_6533()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 6504, 6533);
return return_v;
}

		}

int IMetadataImport.GetEventProps(int @event, int* declaringTypeDef, char* name, int nameBufferLength, int* nameLength, int* attributes, int* eventType, int* adderMethodDef, int* removerMethodDef, int* raiserMethodDef, int* otherMethodDefs, int otherMethodDefBufferLength, int* methodMethodDefsLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,6846,6884);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,6849,6884);
throw f_740_6855_6884();DynAbs.Tracing.TraceSender.TraceExitMethod(740,6846,6884);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,6846,6884);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,6846,6884);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_6855_6884()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 6855, 6884);
return return_v;
}

		}

int IMetadataImport.EnumMethodSemantics(ref void* enumHandle, int methodDef, int* eventsAndProperties, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7028,7066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7031,7066);
throw f_740_7037_7066();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7028,7066);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7028,7066);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7028,7066);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7037_7066()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7037, 7066);
return return_v;
}

		}

int IMetadataImport.GetMethodSemantics(int methodDef, int eventOrProperty, int* semantics) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7168,7206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7171,7206);
throw f_740_7177_7206();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7168,7206);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7168,7206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7168,7206);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7177_7206()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7177, 7206);
return return_v;
}

		}

int IMetadataImport.GetClassLayout(int typeDef, int* packSize, MetadataImportFieldOffset* fieldOffsets, int bufferLength, int* count, int* typeSize) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7366,7404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7369,7404);
throw f_740_7375_7404();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7366,7404);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7366,7404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7366,7404);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7375_7404()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7375, 7404);
return return_v;
}

		}

int IMetadataImport.GetFieldMarshal(int fieldDef, byte** nativeTypeSignature, int* nativeTypeSignatureLengvth) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7526,7564);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7529,7564);
throw f_740_7535_7564();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7526,7564);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7526,7564);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7526,7564);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7535_7564()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7535, 7564);
return return_v;
}

		}

int IMetadataImport.GetRVA(int methodDef, int* relativeVirtualAddress, int* implAttributes) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7667,7705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7670,7705);
throw f_740_7676_7705();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7667,7705);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7667,7705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7667,7705);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7676_7705()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7676, 7705);
return return_v;
}

		}

int IMetadataImport.GetPermissionSetProps(int declSecurity, uint* action, byte** permissionBlob, int* permissionBlobLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7840,7878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7843,7878);
throw f_740_7849_7878();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7840,7878);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7840,7878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7840,7878);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_7849_7878()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 7849, 7878);
return return_v;
}

		}

int IMetadataImport.GetModuleRefProps(int moduleRef, char* name, int nameBufferLength, int* nameLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,7993,8031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,7996,8031);
throw f_740_8002_8031();DynAbs.Tracing.TraceSender.TraceExitMethod(740,7993,8031);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,7993,8031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,7993,8031);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8002_8031()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8002, 8031);
return return_v;
}

		}

int IMetadataImport.EnumModuleRefs(ref void* enumHandle, int* moduleRefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8146,8184);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8149,8184);
throw f_740_8155_8184();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8146,8184);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8146,8184);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8146,8184);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8155_8184()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8155, 8184);
return return_v;
}

		}

int IMetadataImport.GetTypeSpecFromToken(int typeSpec, byte** signature, int* signatureLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8290,8328);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8293,8328);
throw f_740_8299_8328();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8290,8328);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8290,8328);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8290,8328);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8299_8328()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8299, 8328);
return return_v;
}

		}

int IMetadataImport.GetNameFromToken(int token, byte* nameUTF8) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8403,8441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8406,8441);
throw f_740_8412_8441();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8403,8441);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8403,8441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8403,8441);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8412_8441()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8412, 8441);
return return_v;
}

		}

int IMetadataImport.EnumUnresolvedMethods(ref void* enumHandle, int* methodDefs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8563,8601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8566,8601);
throw f_740_8572_8601();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8563,8601);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8563,8601);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8563,8601);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8572_8601()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8572, 8601);
return return_v;
}

		}

int IMetadataImport.GetUserString(int userStringToken, char* buffer, int bufferLength, int* length) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8712,8750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8715,8750);
throw f_740_8721_8750();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8712,8750);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8712,8750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8712,8750);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8721_8750()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8721, 8750);
return return_v;
}

		}

int IMetadataImport.GetPinvokeMap(int memberDef, int* attributes, char* importName, int importNameBufferLength, int* importNameLength, int* moduleRef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,8912,8950);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,8915,8950);
throw f_740_8921_8950();DynAbs.Tracing.TraceSender.TraceExitMethod(740,8912,8950);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,8912,8950);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,8912,8950);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_8921_8950()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 8921, 8950);
return return_v;
}

		}

int IMetadataImport.EnumSignatures(ref void* enumHandle, int* signatureTokens, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9070,9108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9073,9108);
throw f_740_9079_9108();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9070,9108);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9070,9108);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9070,9108);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9079_9108()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9079, 9108);
return return_v;
}

		}

int IMetadataImport.EnumTypeSpecs(ref void* enumHandle, int* typeSpecs, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9221,9259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9224,9259);
throw f_740_9230_9259();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9221,9259);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9221,9259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9221,9259);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9230_9259()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9230, 9259);
return return_v;
}

		}

int IMetadataImport.EnumUserStrings(ref void* enumHandle, int* userStrings, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9376,9414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9379,9414);
throw f_740_9385_9414();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9376,9414);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9376,9414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9376,9414);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9385_9414()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9385, 9414);
return return_v;
}

		}

int IMetadataImport.GetParamForMethodIndex(int methodDef, int sequenceNumber, out int parameterToken) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9527,9565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9530,9565);
throw f_740_9536_9565();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9527,9565);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9527,9565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9527,9565);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9536_9565()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9536, 9565);
return return_v;
}

		}

int IMetadataImport.EnumCustomAttributes(ref void* enumHandle, int parent, int attributeType, int* customAttributes, int bufferLength, int* count) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9723,9761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9726,9761);
throw f_740_9732_9761();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9723,9761);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9723,9761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9723,9761);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9732_9761()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9732, 9761);
return return_v;
}

		}

int IMetadataImport.GetCustomAttributeProps(int customAttribute, int* parent, int* constructor, byte** value, int* valueLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,9900,9938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,9903,9938);
throw f_740_9909_9938();DynAbs.Tracing.TraceSender.TraceExitMethod(740,9900,9938);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,9900,9938);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,9900,9938);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_9909_9938()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 9909, 9938);
return return_v;
}

		}

int IMetadataImport.FindTypeRef(int resolutionScope, string name, out int typeRef) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,10032,10070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,10035,10070);
throw f_740_10041_10070();DynAbs.Tracing.TraceSender.TraceExitMethod(740,10032,10070);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,10032,10070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,10032,10070);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_10041_10070()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 10041, 10070);
return return_v;
}

		}

int IMetadataImport.GetMemberProps(int member, int* declaringTypeDef, char* name, int nameBufferLength, int* nameLength, int* attributes, byte** signature, int* signatureLength, int* relativeVirtualAddress, int* implAttributes, int* constantType, byte** constantValue, int* constantValueLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,10376,10414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,10379,10414);
throw f_740_10385_10414();DynAbs.Tracing.TraceSender.TraceExitMethod(740,10376,10414);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,10376,10414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,10376,10414);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_10385_10414()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 10385, 10414);
return return_v;
}

		}

int IMetadataImport.GetFieldProps(int fieldDef, int* declaringTypeDef, char* name, int nameBufferLength, int* nameLength, int* attributes, byte** signature, int* signatureLength, int* constantType, byte** constantValue, int* constantValueLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,10671,10709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,10674,10709);
throw f_740_10680_10709();DynAbs.Tracing.TraceSender.TraceExitMethod(740,10671,10709);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,10671,10709);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,10671,10709);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_10680_10709()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 10680, 10709);
return return_v;
}

		}

int IMetadataImport.GetPropertyProps(int propertyDef, int* declaringTypeDef, char* name, int nameBufferLength, int* nameLength, int* attributes, byte** signature, int* signatureLength, int* constantType, byte** constantValue, int* constantValueLength, int* setterMethodDef, int* getterMethodDef, int* outerMethodDefs, int outerMethodDefsBufferLength, int* otherMethodDefCount) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11097,11135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11100,11135);
throw f_740_11106_11135();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11097,11135);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11097,11135);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11097,11135);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11106_11135()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11106, 11135);
return return_v;
}

		}

int IMetadataImport.GetParamProps(int parameter, int* declaringMethodDef, int* sequenceNumber, char* name, int nameBufferLength, int* nameLength, int* attributes, int* constantType, byte** constantValue, int* constantValueLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11376,11414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11379,11414);
throw f_740_11385_11414();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11376,11414);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11376,11414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11376,11414);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11385_11414()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11385, 11414);
return return_v;
}

		}

int IMetadataImport.GetCustomAttributeByName(int parent, string name, byte** value, int* valueLength) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11527,11565);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11530,11565);
throw f_740_11536_11565();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11527,11565);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11527,11565);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11527,11565);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11536_11565()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11536, 11565);
return return_v;
}

		}

bool IMetadataImport.IsValidToken(int token) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11621,11659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11624,11659);
throw f_740_11630_11659();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11621,11659);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11621,11659);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11621,11659);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11630_11659()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11630, 11659);
return return_v;
}

		}

int IMetadataImport.GetNativeCallConvFromSig(byte* signature, int signatureLength, int* callingConvention) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11777,11815);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11780,11815);
throw f_740_11786_11815();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11777,11815);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11777,11815);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11777,11815);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11786_11815()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11786, 11815);
return return_v;
}

		}

int IMetadataImport.IsGlobal(int token, bool value) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11878,11916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11881,11916);
throw f_740_11887_11916();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11878,11916);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11878,11916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11878,11916);
}
			throw new System.Exception("Slicer error: unreachable code");

System.NotImplementedException
f_740_11887_11916()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11887, 11916);
return return_v;
}

		}

void IMetadataEmit.__SetModuleProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,11967,12005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,11970,12005);
throw f_740_11976_12005();DynAbs.Tracing.TraceSender.TraceExitMethod(740,11967,12005);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,11967,12005);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,11967,12005);
}

System.NotImplementedException
f_740_11976_12005()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 11976, 12005);
return return_v;
}

		}

void IMetadataEmit.__Save() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12044,12082);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12047,12082);
throw f_740_12053_12082();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12044,12082);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12044,12082);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12044,12082);
}

System.NotImplementedException
f_740_12053_12082()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12053, 12082);
return return_v;
}

		}

void IMetadataEmit.__SaveToStream() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12129,12167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12132,12167);
throw f_740_12138_12167();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12129,12167);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12129,12167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12129,12167);
}

System.NotImplementedException
f_740_12138_12167()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12138, 12167);
return return_v;
}

		}

void IMetadataEmit.__GetSaveSize() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12213,12251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12216,12251);
throw f_740_12222_12251();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12213,12251);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12213,12251);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12213,12251);
}

System.NotImplementedException
f_740_12222_12251()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12222, 12251);
return return_v;
}

		}

void IMetadataEmit.__DefineTypeDef() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12299,12337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12302,12337);
throw f_740_12308_12337();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12299,12337);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12299,12337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12299,12337);
}

System.NotImplementedException
f_740_12308_12337()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12308, 12337);
return return_v;
}

		}

void IMetadataEmit.__DefineNestedType() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12388,12426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12391,12426);
throw f_740_12397_12426();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12388,12426);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12388,12426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12388,12426);
}

System.NotImplementedException
f_740_12397_12426()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12397, 12426);
return return_v;
}

		}

void IMetadataEmit.__SetHandler() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12471,12509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12474,12509);
throw f_740_12480_12509();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12471,12509);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12471,12509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12471,12509);
}

System.NotImplementedException
f_740_12480_12509()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12480, 12509);
return return_v;
}

		}

void IMetadataEmit.__DefineMethod() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12556,12594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12559,12594);
throw f_740_12565_12594();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12556,12594);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12556,12594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12556,12594);
}

System.NotImplementedException
f_740_12565_12594()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12565, 12594);
return return_v;
}

		}

void IMetadataEmit.__DefineMethodImpl() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12645,12683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12648,12683);
throw f_740_12654_12683();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12645,12683);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12645,12683);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12645,12683);
}

System.NotImplementedException
f_740_12654_12683()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12654, 12683);
return return_v;
}

		}

void IMetadataEmit.__DefineTypeRefByName() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12737,12775);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12740,12775);
throw f_740_12746_12775();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12737,12775);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12737,12775);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12737,12775);
}

System.NotImplementedException
f_740_12746_12775()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12746, 12775);
return return_v;
}

		}

void IMetadataEmit.__DefineImportType() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12826,12864);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12829,12864);
throw f_740_12835_12864();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12826,12864);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12826,12864);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12826,12864);
}

System.NotImplementedException
f_740_12835_12864()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12835, 12864);
return return_v;
}

		}

void IMetadataEmit.__DefineMemberRef() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,12914,12952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,12917,12952);
throw f_740_12923_12952();DynAbs.Tracing.TraceSender.TraceExitMethod(740,12914,12952);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,12914,12952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,12914,12952);
}

System.NotImplementedException
f_740_12923_12952()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 12923, 12952);
return return_v;
}

		}

void IMetadataEmit.__DefineImportMember() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13005,13043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13008,13043);
throw f_740_13014_13043();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13005,13043);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13005,13043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13005,13043);
}

System.NotImplementedException
f_740_13014_13043()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13014, 13043);
return return_v;
}

		}

void IMetadataEmit.__DefineEvent() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13089,13127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13092,13127);
throw f_740_13098_13127();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13089,13127);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13089,13127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13089,13127);
}

System.NotImplementedException
f_740_13098_13127()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13098, 13127);
return return_v;
}

		}

void IMetadataEmit.__SetClassLayout() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13176,13214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13179,13214);
throw f_740_13185_13214();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13176,13214);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13176,13214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13176,13214);
}

System.NotImplementedException
f_740_13185_13214()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13185, 13214);
return return_v;
}

		}

void IMetadataEmit.__DeleteClassLayout() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13266,13304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13269,13304);
throw f_740_13275_13304();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13266,13304);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13266,13304);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13266,13304);
}

System.NotImplementedException
f_740_13275_13304()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13275, 13304);
return return_v;
}

		}

void IMetadataEmit.__SetFieldMarshal() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13354,13392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13357,13392);
throw f_740_13363_13392();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13354,13392);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13354,13392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13354,13392);
}

System.NotImplementedException
f_740_13363_13392()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13363, 13392);
return return_v;
}

		}

void IMetadataEmit.__DeleteFieldMarshal() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13445,13483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13448,13483);
throw f_740_13454_13483();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13445,13483);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13445,13483);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13445,13483);
}

System.NotImplementedException
f_740_13454_13483()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13454, 13483);
return return_v;
}

		}

void IMetadataEmit.__DefinePermissionSet() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13537,13575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13540,13575);
throw f_740_13546_13575();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13537,13575);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13537,13575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13537,13575);
}

System.NotImplementedException
f_740_13546_13575()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13546, 13575);
return return_v;
}

		}

void IMetadataEmit.__SetRVA() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13616,13654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13619,13654);
throw f_740_13625_13654();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13616,13654);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13616,13654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13616,13654);
}

System.NotImplementedException
f_740_13625_13654()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13625, 13654);
return return_v;
}

		}

void IMetadataEmit.__DefineModuleRef() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13704,13742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13707,13742);
throw f_740_13713_13742();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13704,13742);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13704,13742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13704,13742);
}

System.NotImplementedException
f_740_13713_13742()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13713, 13742);
return return_v;
}

		}

void IMetadataEmit.__SetParent() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13786,13824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13789,13824);
throw f_740_13795_13824();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13786,13824);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13786,13824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13786,13824);
}

System.NotImplementedException
f_740_13795_13824()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13795, 13824);
return return_v;
}

		}

void IMetadataEmit.__GetTokenFromTypeSpec() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13879,13917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13882,13917);
throw f_740_13888_13917();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13879,13917);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13879,13917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13879,13917);
}

System.NotImplementedException
f_740_13888_13917()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13888, 13917);
return return_v;
}

		}

void IMetadataEmit.__SaveToMemory() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,13964,14002);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,13967,14002);
throw f_740_13973_14002();DynAbs.Tracing.TraceSender.TraceExitMethod(740,13964,14002);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,13964,14002);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,13964,14002);
}

System.NotImplementedException
f_740_13973_14002()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 13973, 14002);
return return_v;
}

		}

void IMetadataEmit.__DefineUserString() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14053,14091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14056,14091);
throw f_740_14062_14091();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14053,14091);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14053,14091);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14053,14091);
}

System.NotImplementedException
f_740_14062_14091()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14062, 14091);
return return_v;
}

		}

void IMetadataEmit.__DeleteToken() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14137,14175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14140,14175);
throw f_740_14146_14175();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14137,14175);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14137,14175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14137,14175);
}

System.NotImplementedException
f_740_14146_14175()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14146, 14175);
return return_v;
}

		}

void IMetadataEmit.__SetMethodProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14224,14262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14227,14262);
throw f_740_14233_14262();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14224,14262);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14224,14262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14224,14262);
}

System.NotImplementedException
f_740_14233_14262()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14233, 14262);
return return_v;
}

		}

void IMetadataEmit.__SetTypeDefProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14312,14350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14315,14350);
throw f_740_14321_14350();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14312,14350);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14312,14350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14312,14350);
}

System.NotImplementedException
f_740_14321_14350()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14321, 14350);
return return_v;
}

		}

void IMetadataEmit.__SetEventProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14398,14436);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14401,14436);
throw f_740_14407_14436();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14398,14436);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14398,14436);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14398,14436);
}

System.NotImplementedException
f_740_14407_14436()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14407, 14436);
return return_v;
}

		}

void IMetadataEmit.__SetPermissionSetProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14492,14530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14495,14530);
throw f_740_14501_14530();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14492,14530);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14492,14530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14492,14530);
}

System.NotImplementedException
f_740_14501_14530()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14501, 14530);
return return_v;
}

		}

void IMetadataEmit.__DefinePinvokeMap() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14581,14619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14584,14619);
throw f_740_14590_14619();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14581,14619);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14581,14619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14581,14619);
}

System.NotImplementedException
f_740_14590_14619()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14590, 14619);
return return_v;
}

		}

void IMetadataEmit.__SetPinvokeMap() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14667,14705);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14670,14705);
throw f_740_14676_14705();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14667,14705);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14667,14705);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14667,14705);
}

System.NotImplementedException
f_740_14676_14705()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14676, 14705);
return return_v;
}

		}

void IMetadataEmit.__DeletePinvokeMap() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14756,14794);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14759,14794);
throw f_740_14765_14794();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14756,14794);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14756,14794);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14756,14794);
}

System.NotImplementedException
f_740_14765_14794()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14765, 14794);
return return_v;
}

		}

void IMetadataEmit.__DefineCustomAttribute() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14850,14888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14853,14888);
throw f_740_14859_14888();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14850,14888);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14850,14888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14850,14888);
}

System.NotImplementedException
f_740_14859_14888()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14859, 14888);
return return_v;
}

		}

void IMetadataEmit.__SetCustomAttributeValue() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,14946,14984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,14949,14984);
throw f_740_14955_14984();DynAbs.Tracing.TraceSender.TraceExitMethod(740,14946,14984);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,14946,14984);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,14946,14984);
}

System.NotImplementedException
f_740_14955_14984()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 14955, 14984);
return return_v;
}

		}

void IMetadataEmit.__DefineField() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15030,15068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15033,15068);
throw f_740_15039_15068();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15030,15068);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15030,15068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15030,15068);
}

System.NotImplementedException
f_740_15039_15068()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15039, 15068);
return return_v;
}

		}

void IMetadataEmit.__DefineProperty() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15117,15155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15120,15155);
throw f_740_15126_15155();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15117,15155);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15117,15155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15117,15155);
}

System.NotImplementedException
f_740_15126_15155()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15126, 15155);
return return_v;
}

		}

void IMetadataEmit.__DefineParam() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15201,15239);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15204,15239);
throw f_740_15210_15239();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15201,15239);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15201,15239);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15201,15239);
}

System.NotImplementedException
f_740_15210_15239()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15210, 15239);
return return_v;
}

		}

void IMetadataEmit.__SetFieldProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15287,15325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15290,15325);
throw f_740_15296_15325();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15287,15325);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15287,15325);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15287,15325);
}

System.NotImplementedException
f_740_15296_15325()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15296, 15325);
return return_v;
}

		}

void IMetadataEmit.__SetPropertyProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15376,15414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15379,15414);
throw f_740_15385_15414();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15376,15414);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15376,15414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15376,15414);
}

System.NotImplementedException
f_740_15385_15414()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15385, 15414);
return return_v;
}

		}

void IMetadataEmit.__SetParamProps() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15462,15500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15465,15500);
throw f_740_15471_15500();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15462,15500);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15462,15500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15462,15500);
}

System.NotImplementedException
f_740_15471_15500()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15471, 15500);
return return_v;
}

		}

void IMetadataEmit.__DefineSecurityAttributeSet() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15561,15599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15564,15599);
throw f_740_15570_15599();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15561,15599);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15561,15599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15561,15599);
}

System.NotImplementedException
f_740_15570_15599()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15570, 15599);
return return_v;
}

		}

void IMetadataEmit.__ApplyEditAndContinue() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15654,15692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15657,15692);
throw f_740_15663_15692();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15654,15692);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15654,15692);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15654,15692);
}

System.NotImplementedException
f_740_15663_15692()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15663, 15692);
return return_v;
}

		}

void IMetadataEmit.__TranslateSigWithScope() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15748,15786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15751,15786);
throw f_740_15757_15786();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15748,15786);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15748,15786);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15748,15786);
}

System.NotImplementedException
f_740_15757_15786()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15757, 15786);
return return_v;
}

		}

void IMetadataEmit.__SetMethodImplFlags() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15839,15877);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15842,15877);
throw f_740_15848_15877();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15839,15877);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15839,15877);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15839,15877);
}

System.NotImplementedException
f_740_15848_15877()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15848, 15877);
return return_v;
}

		}

void IMetadataEmit.__SetFieldRVA() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,15923,15961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,15926,15961);
throw f_740_15932_15961();DynAbs.Tracing.TraceSender.TraceExitMethod(740,15923,15961);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,15923,15961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,15923,15961);
}

System.NotImplementedException
f_740_15932_15961()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 15932, 15961);
return return_v;
}

		}

void IMetadataEmit.__Merge() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,16001,16039);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,16004,16039);
throw f_740_16010_16039();DynAbs.Tracing.TraceSender.TraceExitMethod(740,16001,16039);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,16001,16039);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,16001,16039);
}

System.NotImplementedException
f_740_16010_16039()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 16010, 16039);
return return_v;
}

		}

void IMetadataEmit.__MergeEnd() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(740,16082,16120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(740,16085,16120);
throw f_740_16091_16120();DynAbs.Tracing.TraceSender.TraceExitMethod(740,16082,16120);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(740,16082,16120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,16082,16120);
}

System.NotImplementedException
f_740_16091_16120()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(740, 16091, 16120);
return return_v;
}

		}

public MetadataAdapterBase()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(740,352,16128);
DynAbs.Tracing.TraceSender.TraceExitConstructor(740,352,16128);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,352,16128);
}


static MetadataAdapterBase()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(740,352,16128);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(740,352,16128);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(740,352,16128);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(740,352,16128);
}
}
