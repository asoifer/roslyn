// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.DiaSymReader
{
internal abstract class SymUnmanagedWriter : IDisposable
{
public abstract void Dispose();

public abstract IEnumerable<ArraySegment<byte>> GetUnderlyingData();

public abstract void WriteTo(Stream stream);

public abstract int DocumentTableCapacity {get; set; }

public abstract int DefineDocument(string name, Guid language, Guid vendor, Guid type, Guid algorithmId, ReadOnlySpan<byte> checksum, ReadOnlySpan<byte> source);

public abstract void DefineSequencePoints(int documentIndex, int count, int[] offsets, int[] startLines, int[] startColumns, int[] endLines, int[] endColumns);

public abstract void OpenMethod(int methodToken);

public abstract void CloseMethod();

public abstract void OpenScope(int startOffset);

public abstract void CloseScope(int endOffset);

public abstract void DefineLocalVariable(int index, string name, int attributes, int localSignatureToken);

public abstract bool DefineLocalConstant(string name, object value, int constantSignatureToken);

public abstract void UsingNamespace(string importString);

public abstract void SetAsyncInfo(
            int moveNextMethodToken,
            int kickoffMethodToken,
            int catchHandlerOffset,
            ReadOnlySpan<int> yieldOffsets,
            ReadOnlySpan<int> resumeOffsets);

public abstract void DefineCustomMetadata(byte[] metadata);

public abstract void SetEntryPoint(int entryMethodToken);

public abstract void UpdateSignature(Guid guid, uint stamp, int age);

public abstract void GetSignature(out Guid guid, out uint stamp, out int age);

public abstract void SetSourceServerData(byte[] data);

public abstract void SetSourceLinkData(byte[] data);

public abstract void OpenTokensToSourceSpansMap();

public abstract void MapTokenToSourceSpan(int token, int documentIndex, int startLine, int startColumn, int endLine, int endColumn);

public abstract void CloseTokensToSourceSpansMap();

public SymUnmanagedWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(751,408,12604);
DynAbs.Tracing.TraceSender.TraceExitConstructor(751,408,12604);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(751,408,12604);
}


static SymUnmanagedWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(751,408,12604);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(751,408,12604);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(751,408,12604);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(751,408,12604);
}
}
