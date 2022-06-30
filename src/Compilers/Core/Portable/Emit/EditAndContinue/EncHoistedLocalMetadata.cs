// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{

internal struct EncHoistedLocalMetadata
    {

public readonly string Name;

public readonly Cci.ITypeReference Type;

public readonly SynthesizedLocalKind SynthesizedKind;

public EncHoistedLocalMetadata(string name, Cci.ITypeReference type, SynthesizedLocalKind synthesizedKind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(762,513,898);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,644,671);

f_762_644_670(name != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,685,712);

f_762_685_711(type != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,726,770);

f_762_726_769(f_762_739_768(synthesizedKind));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,786,803);

this.Name = name;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,817,834);

this.Type = type;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(762,848,887);

this.SynthesizedKind = synthesizedKind;
DynAbs.Tracing.TraceSender.TraceExitConstructor(762,513,898);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(762,513,898);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(762,513,898);
}
		}
static EncHoistedLocalMetadata(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(762,304,905);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(762,304,905);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(762,304,905);
}

static int
f_762_644_670(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(762, 644, 670);
return 0;
}


static int
f_762_685_711(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(762, 685, 711);
return 0;
}


static bool
f_762_739_768(Microsoft.CodeAnalysis.SynthesizedLocalKind
kind)
{
var return_v = kind.IsLongLived();
DynAbs.Tracing.TraceSender.TraceEndInvocation(762, 739, 768);
return return_v;
}


static int
f_762_726_769(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(762, 726, 769);
return 0;
}

    }
}
