// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
public sealed class CSharpScriptCompilationInfo : ScriptCompilationInfo
{
public new CSharpCompilation? PreviousScriptCompilation {get; }

internal CSharpScriptCompilationInfo(CSharpCompilation? previousCompilationOpt, Type? returnType, Type? globalsType)
:base(f_10918_601_611_C(returnType) ,globalsType)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10918,464,829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,388,452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,650,751);

f_10918_650_750(previousCompilationOpt == null ||(DynAbs.Tracing.TraceSender.Expression_False(10918, 663, 749)||f_10918_697_734(previousCompilationOpt)== globalsType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,767,818);

PreviousScriptCompilation = previousCompilationOpt;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10918,464,829);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10918,464,829);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10918,464,829);
}
		}

internal override Compilation? CommonPreviousScriptCompilation {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10918,904,932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,907,932);
return f_10918_907_932();DynAbs.Tracing.TraceSender.TraceExitMethod(10918,904,932);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10918,904,932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10918,904,932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CSharpScriptCompilationInfo WithPreviousScriptCompilation(CSharpCompilation? compilation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10918,1042,1182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,1058,1182);
return (DynAbs.Tracing.TraceSender.Conditional_F1(10918, 1058, 1100)||((            (compilation == f_10918_1074_1099()) &&DynAbs.Tracing.TraceSender.Conditional_F2(10918, 1103, 1107))||DynAbs.Tracing.TraceSender.Conditional_F3(10918, 1110, 1182)))?this :f_10918_1110_1182(compilation, f_10918_1155_1168(), f_10918_1170_1181());DynAbs.Tracing.TraceSender.TraceExitMethod(10918,1042,1182);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10918,1042,1182);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10918,1042,1182);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
f_10918_1074_1099()
{
var return_v = PreviousScriptCompilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10918, 1074, 1099);
return return_v;
}


System.Type?
f_10918_1155_1168()
{
var return_v = ReturnTypeOpt;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10918, 1155, 1168);
return return_v;
}


System.Type?
f_10918_1170_1181()
{
var return_v = GlobalsType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10918, 1170, 1181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo
f_10918_1110_1182(Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
previousCompilationOpt,System.Type?
returnType,System.Type?
globalsType)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo( previousCompilationOpt, returnType, globalsType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10918, 1110, 1182);
return return_v;
}

		}

internal override ScriptCompilationInfo CommonWithPreviousScriptCompilation(Compilation? compilation) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10918,1297,1375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10918,1313,1375);
return f_10918_1313_1375(this, compilation);DynAbs.Tracing.TraceSender.TraceExitMethod(10918,1297,1375);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10918,1297,1375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10918,1297,1375);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo
f_10918_1313_1375(Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo
this_param,Microsoft.CodeAnalysis.Compilation?
compilation)
{
var return_v = this_param.WithPreviousScriptCompilation( (Microsoft.CodeAnalysis.CSharp.CSharpCompilation?)compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10918, 1313, 1375);
return return_v;
}

		}

static CSharpScriptCompilationInfo()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10918,300,1383);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10918,300,1383);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10918,300,1383);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10918,300,1383);

System.Type?
f_10918_697_734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.HostObjectType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10918, 697, 734);
return return_v;
}


int
f_10918_650_750(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10918, 650, 750);
return 0;
}


static System.Type?
f_10918_601_611_C(System.Type?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10918, 464, 829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
f_10918_907_932()
{
var return_v = PreviousScriptCompilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10918, 907, 932);
return return_v;
}

}
}
