// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    internal enum ObsoleteAttributeKind
    {
        None,
        Uninitialized,
        Obsolete,
        Deprecated,
        Experimental,
    }
internal sealed class ObsoleteAttributeData
{
public static readonly ObsoleteAttributeData Uninitialized ;

public static readonly ObsoleteAttributeData Experimental ;

public const string 
DiagnosticIdPropertyName = "DiagnosticId"
;

public const string 
UrlFormatPropertyName = "UrlFormat"
;

public ObsoleteAttributeData(ObsoleteAttributeKind kind, string? message, bool isError, string? diagnosticId, string? urlFormat)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(813,1135,1453);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1503,1507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1741,1748);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1946,1953);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,2198,2210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,3176,3185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1288,1300);

Kind = kind;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1314,1332);

Message = message;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1346,1364);

IsError = isError;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1378,1406);

DiagnosticId = diagnosticId;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1420,1442);

UrlFormat = urlFormat;
DynAbs.Tracing.TraceSender.TraceExitConstructor(813,1135,1453);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(813,1135,1453);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(813,1135,1453);
}
		}

public readonly ObsoleteAttributeKind Kind;

public readonly bool IsError;

public readonly string? Message;

public readonly string? DiagnosticId;

public readonly string? UrlFormat;

internal bool IsUninitialized
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(813,3252,3304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,3258,3302);

return f_813_3265_3301(this, Uninitialized);
DynAbs.Tracing.TraceSender.TraceExitMethod(813,3252,3304);

bool
f_813_3265_3301(Microsoft.CodeAnalysis.ObsoleteAttributeData
objA,Microsoft.CodeAnalysis.ObsoleteAttributeData
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(813, 3265, 3301);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(813,3198,3315);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(813,3198,3315);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static ObsoleteAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(813,531,3322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,636,782);
Uninitialized = f_813_652_782(ObsoleteAttributeKind.Uninitialized, message: null, isError: false, diagnosticId: null, urlFormat: null);DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,838,982);
Experimental = f_813_853_982(ObsoleteAttributeKind.Experimental, message: null, isError: false, diagnosticId: null, urlFormat: null);DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1015,1056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(813,1087,1122);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(813,531,3322);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(813,531,3322);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(813,531,3322);

static Microsoft.CodeAnalysis.ObsoleteAttributeData
f_813_652_782(Microsoft.CodeAnalysis.ObsoleteAttributeKind
kind,string?
message,bool
isError,string?
diagnosticId,string?
urlFormat)
{
var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData( kind, message: message, isError: isError, diagnosticId: diagnosticId, urlFormat: urlFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(813, 652, 782);
return return_v;
}


static Microsoft.CodeAnalysis.ObsoleteAttributeData
f_813_853_982(Microsoft.CodeAnalysis.ObsoleteAttributeKind
kind,string?
message,bool
isError,string?
diagnosticId,string?
urlFormat)
{
var return_v = new Microsoft.CodeAnalysis.ObsoleteAttributeData( kind, message: message, isError: isError, diagnosticId: diagnosticId, urlFormat: urlFormat);
DynAbs.Tracing.TraceSender.TraceEndInvocation(813, 853, 982);
return return_v;
}

}
}
