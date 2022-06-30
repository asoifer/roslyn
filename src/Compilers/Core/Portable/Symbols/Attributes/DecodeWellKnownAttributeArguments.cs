// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{

internal struct DecodeWellKnownAttributeArguments<TAttributeSyntax, TAttributeData, TAttributeLocation>
        where TAttributeSyntax : SyntaxNode
        where TAttributeData : AttributeData
    {

private WellKnownAttributeData? _lazyDecodeData;

public T GetOrCreateData<T>() where T : WellKnownAttributeData, new()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(804,1169,1418);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1263,1365) || true) && (_lazyDecodeData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(804,1263,1365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1324,1350);

_lazyDecodeData = f_804_1342_1349();
DynAbs.Tracing.TraceSender.TraceExitCondition(804,1263,1365);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1381,1407);

return (T)_lazyDecodeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(804,1169,1418);

T
f_804_1342_1349()
{
var return_v = new T();
DynAbs.Tracing.TraceSender.TraceEndInvocation(804, 1342, 1349);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(804,1169,1418);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(804,1169,1418);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public readonly bool HasDecodedData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(804,1636,1891);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1672,1843) || true) && (_lazyDecodeData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(804,1672,1843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1741,1790);

f_804_1741_1789(                    _lazyDecodeData, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1812,1824);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(804,1672,1843);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,1863,1876);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(804,1636,1891);

int
f_804_1741_1789(Microsoft.CodeAnalysis.WellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifyDataStored( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(804, 1741, 1789);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(804,1576,1902);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(804,1576,1902);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public readonly WellKnownAttributeData DecodedData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(804,2185,2312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,2221,2255);

f_804_2221_2254(this.HasDecodedData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(804,2273,2297);

return _lazyDecodeData!;
DynAbs.Tracing.TraceSender.TraceExitMethod(804,2185,2312);

int
f_804_2221_2254(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(804, 2221, 2254);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(804,2110,2323);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(804,2110,2323);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public TAttributeSyntax? AttributeSyntaxOpt {get; set; }

public TAttributeData Attribute {get; set; }

public int Index {get; set; }

public int AttributesCount {get; set; }

public DiagnosticBag Diagnostics {get; set; }

public TAttributeLocation SymbolPart {get; set; }
static DecodeWellKnownAttributeArguments(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(804,426,3587);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(804,426,3587);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(804,426,3587);
}
    }
}
