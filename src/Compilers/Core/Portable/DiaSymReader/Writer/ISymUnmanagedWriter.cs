// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#pragma warning disable 436 // SuppressUnmanagedCodeSecurityAttribute defined in source and mscorlib 

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.DiaSymReader
{
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("98ECEE1E-752D-11d3-8D56-00C04F680B2B"), SuppressUnmanagedCodeSecurity]
    internal interface IPdbWriter
    {

int __SetPath(/*[in] const WCHAR* szFullPathName, [in] IStream* pIStream, [in] BOOL fFullBuild*/);

int __OpenMod(/*[in] const WCHAR* szModuleName, [in] const WCHAR* szFileName*/);

int __CloseMod();

int __GetPath(/*[in] DWORD ccData,[out] DWORD* pccData,[out, size_is(ccData),length_is(*pccData)] WCHAR szPath[]*/);

void GetSignatureAge(out uint sig, out int age);
    }

    /// <summary>
    /// The highest version of the interface available on Desktop FX 4.0+.
    /// </summary>
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("DCF7780D-BDE9-45DF-ACFE-21731A32000C"), SuppressUnmanagedCodeSecurity]
    internal unsafe interface ISymUnmanagedWriter5
    {

ISymUnmanagedDocumentWriter DefineDocument(string url, ref Guid language, ref Guid languageVendor, ref Guid documentType);

void SetUserEntryPoint(int entryMethodToken);

void OpenMethod(uint methodToken);

void CloseMethod();

uint OpenScope(int startOffset);

void CloseScope(int endOffset);

void SetScopeRange(uint scopeID, uint startOffset, uint endOffset);

void DefineLocalVariable(string name, uint attributes, uint sig, byte* signature, uint addrKind, uint addr1, uint addr2, uint startOffset, uint endOffset);

void DefineParameter(string name, uint attributes, uint sequence, uint addrKind, uint addr1, uint addr2, uint addr3);

void DefineField(uint parent, string name, uint attributes, uint sig, byte* signature, uint addrKind, uint addr1, uint addr2, uint addr3);

void DefineGlobalVariable(string name, uint attributes, uint sig, byte* signature, uint addrKind, uint addr1, uint addr2, uint addr3);

void Close();

void SetSymAttribute(uint parent, string name, int length, byte* data);

void OpenNamespace(string name);

void CloseNamespace();

void UsingNamespace(string fullName);

void SetMethodSourceRange(ISymUnmanagedDocumentWriter startDoc, uint startLine, uint startColumn, object endDoc, uint endLine, uint endColumn);

void Initialize([MarshalAs(UnmanagedType.IUnknown)] object emitter, string filename, [MarshalAs(UnmanagedType.IUnknown)] object ptrIStream, bool fullBuild);

void GetDebugInfo(ref ImageDebugDirectory debugDirectory, uint dataCount, out uint dataCountPtr, byte* data);

void DefineSequencePoints(ISymUnmanagedDocumentWriter document, int count,
          [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] offsets,
          [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] lines,
          [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] columns,
          [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] endLines,
          [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] endColumns);

void RemapToken(uint oldToken, uint newToken);

void Initialize2([MarshalAs(UnmanagedType.IUnknown)] object emitter, string tempfilename, [MarshalAs(UnmanagedType.IUnknown)] object ptrIStream, bool fullBuild, string finalfilename);

void DefineConstant(string name, object value, uint sig, byte* signature);

void Abort();

void DefineLocalVariable2(string name, int attributes, int localSignatureToken, uint addrKind, int index, uint addr2, uint addr3, uint startOffset, uint endOffset);

void DefineGlobalVariable2(string name, int attributes, int sigToken, uint addrKind, uint addr1, uint addr2, uint addr3);

void DefineConstant2([MarshalAs(UnmanagedType.LPWStr)] string name, VariantStructure value, int constantSignatureToken);

void OpenMethod2(uint methodToken, int sectionIndex, int offsetRelativeOffset);

void Commit();

void GetDebugInfoWithPadding(ref ImageDebugDirectory debugDirectory, uint dataCount, out uint dataCountPtr, byte* data);

void OpenMapTokensToSourceSpans();

void CloseMapTokensToSourceSpans();

void MapTokenToSourceSpan(int token, ISymUnmanagedDocumentWriter document, int startLine, int startColumn, int endLine, int endColumn);

            }

    /// <summary>
    /// The highest version of the interface available in Microsoft.DiaSymReader.Native.
    /// </summary>
    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5ba52f3b-6bf8-40fc-b476-d39c529b331e"), SuppressUnmanagedCodeSecurity]
    internal interface ISymUnmanagedWriter8 : ISymUnmanagedWriter5
    {

void _VtblGap1_33();

void InitializeDeterministic([MarshalAs(UnmanagedType.IUnknown)] object emitter, [MarshalAs(UnmanagedType.IUnknown)] object stream);

unsafe void UpdateSignatureByHashingContent([In] byte* buffer, int size);

void UpdateSignature(Guid pdbId, uint stamp, int age);

unsafe void SetSourceServerData([In] byte* data, int size);

unsafe void SetSourceLinkData([In] byte* data, int size);
    }

[StructLayout(LayoutKind.Explicit)]
    internal struct VariantStructure
    {

public VariantStructure(DateTime date) : this() // Need this to avoid errors about the uninteresting union fields.
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(749,7770,8083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(749,7909,7933);

_longValue = date.Ticks;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(749,8009,8040);

_type = (short)VarEnum.VT_DATE;
DynAbs.Tracing.TraceSender.TraceExitConstructor(749,7770,8083);
#pragma warning restore CS0618
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(749,7770,8083);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(749,7770,8083);
}
		}

[FieldOffset(0)]
        private readonly short _type;

[FieldOffset(8)]
        private readonly long _longValue;

[FieldOffset(8)]
        private readonly VariantPadding _padding;

[FieldOffset(0)] // NB: 0, not 8
        private readonly decimal _decimalValue;

[FieldOffset(8)]
        private readonly bool _boolValue;

[FieldOffset(8)]
        private readonly long _intValue;

[FieldOffset(8)]
        private readonly double _doubleValue;
static VariantStructure(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(749,7680,8904);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(749,7680,8904);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(749,7680,8904);
}
    }

[StructLayout(LayoutKind.Sequential)]
    internal unsafe struct VariantPadding
    {

public readonly byte* Data2;

public readonly byte* Data3;
static VariantPadding(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(749,9037,9207);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(749,9037,9207);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(749,9037,9207);
}
    }

[StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ImageDebugDirectory
    {

internal int Characteristics;

internal int TimeDateStamp;

internal short MajorVersion;

internal short MinorVersion;

internal int Type;

internal int SizeOfData;

internal int AddressOfRawData;

internal int PointerToRawData;
static ImageDebugDirectory(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(749,9215,9611);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(749,9215,9611);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(749,9215,9611);
}
    }
}
