// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Runtime.InteropServices;

namespace Microsoft.DiaSymReader
{

[StructLayout(LayoutKind.Sequential)]
    internal struct MetadataImportFieldOffset
    {

public int FieldDef;

public uint Offset;
static MetadataImportFieldOffset(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(741,311,468);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(741,311,468);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(741,311,468);
}
    }
}
