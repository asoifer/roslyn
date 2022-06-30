// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{

internal struct EarlyDecodeWellKnownAttributeArguments<TEarlyBinder, TNamedTypeSymbol, TAttributeSyntax, TAttributeLocation>
        where TNamedTypeSymbol : INamedTypeSymbolInternal
        where TAttributeSyntax : SyntaxNode
    {

private EarlyWellKnownAttributeData _lazyDecodeData;

public T GetOrCreateData<T>() where T : EarlyWellKnownAttributeData, new()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(805,1314,1568);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1413,1515) || true) && (_lazyDecodeData == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(805,1413,1515);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1474,1500);

_lazyDecodeData = f_805_1492_1499();
DynAbs.Tracing.TraceSender.TraceExitCondition(805,1413,1515);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1531,1557);

return (T)_lazyDecodeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(805,1314,1568);

T
f_805_1492_1499()
{
var return_v = new T();
DynAbs.Tracing.TraceSender.TraceEndInvocation(805, 1492, 1499);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(805,1314,1568);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(805,1314,1568);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool HasDecodedData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(805,1777,2032);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1813,1984) || true) && (_lazyDecodeData != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(805,1813,1984);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1882,1931);

f_805_1882_1930(                    _lazyDecodeData, expected: true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,1953,1965);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(805,1813,1984);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,2004,2017);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(805,1777,2032);

int
f_805_1882_1930(Microsoft.CodeAnalysis.EarlyWellKnownAttributeData
this_param,bool
expected)
{
this_param.VerifyDataStored( expected: expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(805, 1882, 1930);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(805,1726,2043);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(805,1726,2043);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public EarlyWellKnownAttributeData DecodedData
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(805,2322,2448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,2358,2392);

f_805_2358_2391(this.HasDecodedData);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(805,2410,2433);

return _lazyDecodeData;
DynAbs.Tracing.TraceSender.TraceExitMethod(805,2322,2448);

int
f_805_2358_2391(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(805, 2358, 2391);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(805,2251,2459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(805,2251,2459);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public TEarlyBinder Binder {get; set; }

public TNamedTypeSymbol AttributeType {get; set; }

public TAttributeSyntax AttributeSyntax {get; set; }

public TAttributeLocation SymbolPart {get; set; }
static EarlyDecodeWellKnownAttributeArguments(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(805,527,3267);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(805,527,3267);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(805,527,3267);
}
    }
}
