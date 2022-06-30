
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis
{
internal sealed class UnmanagedCallersOnlyAttributeData
{
internal static readonly UnmanagedCallersOnlyAttributeData Uninitialized ;

internal static readonly UnmanagedCallersOnlyAttributeData AttributePresentDataNotBound ;

private static readonly UnmanagedCallersOnlyAttributeData PlatformDefault ;

public const string 
CallConvsPropertyName = "CallConvs"
;

internal static UnmanagedCallersOnlyAttributeData Create(ImmutableHashSet<INamedTypeSymbolInternal>? callingConventionTypes)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(815,1234,1443);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1237,1443);
return callingConventionTypes switch
            {
                null or { IsEmpty: true } when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1299,1343) && DynAbs.Tracing.TraceSender.Expression_True(815,1299,1343))
=> PlatformDefault,
                _ when(DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1362,1428) && DynAbs.Tracing.TraceSender.Expression_True(815,1362,1428))
=> f_815_1367_1428(callingConventionTypes)            };DynAbs.Tracing.TraceSender.TraceExitMethod(815,1234,1443);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(815,1234,1443);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(815,1234,1443);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
f_815_1367_1428(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
callingConventionTypes)
{
var return_v = new Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData( callingConventionTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(815, 1367, 1428);
return return_v;
}

		}

public readonly ImmutableHashSet<INamedTypeSymbolInternal> CallingConventionTypes;

private UnmanagedCallersOnlyAttributeData(ImmutableHashSet<INamedTypeSymbolInternal> callingConventionTypes)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(815,1550,1742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1515,1537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1683,1731);

CallingConventionTypes = callingConventionTypes;
DynAbs.Tracing.TraceSender.TraceExitConstructor(815,1550,1742);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(815,1550,1742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(815,1550,1742);
}
		}

internal static bool IsCallConvsTypedConstant(string key, bool isField, in TypedConstant value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(815,1754,2127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1874,2116);

return isField
&&(DynAbs.Tracing.TraceSender.Expression_True(815, 1881, 1940)&&key == CallConvsPropertyName
)&&(DynAbs.Tracing.TraceSender.Expression_True(815, 1881, 2001)&&value.Kind == TypedConstantKind.Array
)&&(DynAbs.Tracing.TraceSender.Expression_True(815, 1881, 2115)&&(value.Values.IsDefaultOrEmpty ||(DynAbs.Tracing.TraceSender.Expression_False(815, 2026, 2114)||value.Values.All(v => v.Kind == TypedConstantKind.Type))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(815,1754,2127);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(815,1754,2127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(815,1754,2127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static UnmanagedCallersOnlyAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(815,347,2134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,478,605);
Uninitialized = f_815_494_605(callingConventionTypes: ImmutableHashSet<INamedTypeSymbolInternal>.Empty);DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,675,817);
AttributePresentDataNotBound = f_815_706_817(callingConventionTypes: ImmutableHashSet<INamedTypeSymbolInternal>.Empty);DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,886,1015);
PlatformDefault = f_815_904_1015(callingConventionTypes: ImmutableHashSet<INamedTypeSymbolInternal>.Empty);DynAbs.Tracing.TraceSender.TraceSimpleStatement(815,1048,1083);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(815,347,2134);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(815,347,2134);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(815,347,2134);

static Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
f_815_494_605(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
callingConventionTypes)
{
var return_v = new Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData( callingConventionTypes: callingConventionTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(815, 494, 605);
return return_v;
}


static Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
f_815_706_817(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
callingConventionTypes)
{
var return_v = new Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData( callingConventionTypes: callingConventionTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(815, 706, 817);
return return_v;
}


static Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
f_815_904_1015(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
callingConventionTypes)
{
var return_v = new Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData( callingConventionTypes: callingConventionTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(815, 904, 1015);
return return_v;
}

}
}
