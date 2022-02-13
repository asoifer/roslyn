// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp;

namespace Microsoft.CodeAnalysis.Diagnostics.CSharp
{
[DiagnosticAnalyzer(LanguageNames.CSharp)]
    internal sealed class CSharpCompilerDiagnosticAnalyzer : CompilerDiagnosticAnalyzer
{
internal override CommonMessageProvider MessageProvider
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10916,735,838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,771,823);

return CodeAnalysis.CSharp.MessageProvider.Instance;
DynAbs.Tracing.TraceSender.TraceExitMethod(10916,735,838);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10916,655,849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10916,655,849);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override ImmutableArray<int> GetSupportedErrorCodes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10916,861,4097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,948,999);

var 
errorCodes = f_10916_965_998(typeof(ErrorCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1013,1080);

var 
builder = f_10916_1027_1079(f_10916_1061_1078(errorCodes))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1094,4041);
foreach(int errorCode in f_10916_1120_1130_I(errorCodes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1094,4041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1164,4026);

switch (errorCode)
                {

case InternalErrorCode.Void:
                    case InternalErrorCode.Unknown:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1330,1339);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

case (int)ErrorCode.WRN_ALinkWarn:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1568,1577);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

case (int)ErrorCode.WRN_UnreferencedField:
                    case (int)ErrorCode.WRN_UnreferencedFieldAssg:
                    case (int)ErrorCode.WRN_UnreferencedEvent:
                    case (int)ErrorCode.WRN_UnassignedInternalField:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,1954,1963);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

case (int)ErrorCode.ERR_MissingPredefinedMember:
                    case (int)ErrorCode.ERR_PredefinedTypeNotFound:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,2184,2193);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

case (int)ErrorCode.ERR_NoEntryPoint:
                    case (int)ErrorCode.WRN_InvalidMainSig:
                    case (int)ErrorCode.ERR_MultipleEntryPoints:
                    case (int)ErrorCode.WRN_MainIgnored:
                    case (int)ErrorCode.ERR_MainClassNotClass:
                    case (int)ErrorCode.WRN_MainCantBeGeneric:
                    case (int)ErrorCode.ERR_NoMainInClass:
                    case (int)ErrorCode.ERR_MainClassNotFound:
                    case (int)ErrorCode.WRN_SyncAndAsyncEntryPoints:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,2852,2861);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

case (int)ErrorCode.ERR_BadDelegateConstructor:
                    case (int)ErrorCode.ERR_InsufficientStack:
                    case (int)ErrorCode.ERR_ModuleEmitFailure:
                    case (int)ErrorCode.ERR_TooManyLocals:
                    case (int)ErrorCode.ERR_BindToBogus:
                    case (int)ErrorCode.ERR_ExportedTypeConflictsWithDeclaration:
                    case (int)ErrorCode.ERR_ForwardedTypeConflictsWithDeclaration:
                    case (int)ErrorCode.ERR_ExportedTypesConflict:
                    case (int)ErrorCode.ERR_ForwardedTypeConflictsWithExportedType:
                    case (int)ErrorCode.ERR_ByRefTypeAndAwait:
                    case (int)ErrorCode.ERR_RefReturningCallAndAwait:
                    case (int)ErrorCode.ERR_SpecialByRefInLambda:
                    case (int)ErrorCode.ERR_DynamicRequiredTypesMissing:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,3887,3896);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10916,1164,4026);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,3952,3975);

f_10916_3952_3974(                        builder, errorCode);
DynAbs.Tracing.TraceSender.TraceBreak(10916,4001,4007);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1164,4026);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10916,1094,4041);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10916,1,2948);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10916,1,2948);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10916,4057,4086);

return f_10916_4064_4085(builder);
DynAbs.Tracing.TraceSender.TraceExitMethod(10916,861,4097);

System.Array
f_10916_965_998(System.Type
enumType)
{
var return_v = Enum.GetValues( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10916, 965, 998);
return return_v;
}


int
f_10916_1061_1078(System.Array
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10916, 1061, 1078);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>.Builder
f_10916_1027_1079(int
initialCapacity)
{
var return_v = ImmutableArray.CreateBuilder<int>( initialCapacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10916, 1027, 1079);
return return_v;
}


int
f_10916_3952_3974(System.Collections.Immutable.ImmutableArray<int>.Builder
this_param,int
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10916, 3952, 3974);
return 0;
}


System.Array
f_10916_1120_1130_I(System.Array
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10916, 1120, 1130);
return return_v;
}


System.Collections.Immutable.ImmutableArray<int>
f_10916_4064_4085(System.Collections.Immutable.ImmutableArray<int>.Builder
this_param)
{
var return_v = this_param.ToImmutable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10916, 4064, 4085);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10916,861,4097);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10916,861,4097);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public CSharpCompilerDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(10916,507,4104);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10916,507,4104);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10916,507,4104);
}


static CSharpCompilerDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10916,507,4104);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10916,507,4104);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10916,507,4104);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10916,507,4104);
}
}
