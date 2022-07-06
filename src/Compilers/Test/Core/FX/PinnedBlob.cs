// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
internal class PinnedBlob : IDisposable
{
private GCHandle _bytes;

public readonly IntPtr Pointer;

public readonly int Size;

public PinnedBlob(ImmutableArray<byte> blob)
:this(f_25093_709_743_C(blob.DangerousGetUnderlyingArray()) )
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25093,644,766);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25093,644,766);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25093,644,766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25093,644,766);
}
		}

public unsafe PinnedBlob(byte[] blob)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25093,778,987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25093,627,631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25093,840,891);

_bytes = GCHandle.Alloc(blob,GCHandleType.Pinned);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25093,905,943);

Pointer = _bytes.AddrOfPinnedObject();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25093,957,976);

Size = f_25093_964_975(blob);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25093,778,987);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25093,778,987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25093,778,987);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25093,999,1070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25093,1045,1059);

_bytes.Free();
DynAbs.Tracing.TraceSender.TraceExitMethod(25093,999,1070);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25093,999,1070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25093,999,1070);
}
		}

static PinnedBlob()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25093,418,1077);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25093,418,1077);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25093,418,1077);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25093,418,1077);

static byte[]
f_25093_709_743_C(byte[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25093, 644, 766);
return return_v;
}


static int
f_25093_964_975(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25093, 964, 975);
return return_v;
}

}
}
