// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.CodeAnalysis;
using static Roslyn.Test.Utilities.ExceptionHelper;

namespace Roslyn.Test.Utilities
{
[Serializable]
    public class EmitException : Exception
{
[field: NonSerialized]
        public IEnumerable<Diagnostic> Diagnostics {get; }

public EmitException(IEnumerable<Diagnostic> diagnostics, string directory)
:base(f_25058_708_752_C(f_25058_708_752(diagnostics, directory)) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25058,612,820);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25058,517,600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25058,778,809);

this.Diagnostics = diagnostics;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25058,612,820);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25058,612,820);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,612,820);
}
		}

protected EmitException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25058,832,999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25058,517,600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25058,952,988);

throw f_25058_958_987();
DynAbs.Tracing.TraceSender.TraceExitConstructor(25058,832,999);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25058,832,999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,832,999);
}
		}

static EmitException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25058,442,1006);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25058,442,1006);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,442,1006);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25058,442,1006);

static string
f_25058_708_752(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
diagnostics,string
directory)
{
var return_v = GetMessageFromResult( diagnostics, directory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25058, 708, 752);
return return_v;
}


static string
f_25058_708_752_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25058, 612, 820);
return return_v;
}


static System.NotImplementedException
f_25058_958_987()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25058, 958, 987);
return return_v;
}

}
[Serializable]
    public class ExecutionException : Exception
{
public ExecutionException(string expectedOutput, string actualOutput, string exePath)
:base(f_25058_1200_1259_C(f_25058_1200_1259(expectedOutput, actualOutput, exePath)) ) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25058,1094,1264);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25058,1094,1264);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25058,1094,1264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,1094,1264);
}
		}

public ExecutionException(Exception innerException, string exePath)
:base(f_25058_1364_1412_C(f_25058_1364_1412(innerException, exePath)) ,innerException) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25058,1276,1433);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25058,1276,1433);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25058,1276,1433);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,1276,1433);
}
		}

protected ExecutionException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25058,1445,1617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25058,1570,1606);

throw f_25058_1576_1605();
DynAbs.Tracing.TraceSender.TraceExitConstructor(25058,1445,1617);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25058,1445,1617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,1445,1617);
}
		}

static ExecutionException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25058,1014,1624);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25058,1014,1624);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25058,1014,1624);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25058,1014,1624);

static string
f_25058_1200_1259(string
expectedOutput,string
actualOutput,string
exePath)
{
var return_v = GetMessageFromResult( expectedOutput, actualOutput, exePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25058, 1200, 1259);
return return_v;
}


static string
f_25058_1200_1259_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25058, 1094, 1264);
return return_v;
}


static string
f_25058_1364_1412(System.Exception
executionException,string
exePath)
{
var return_v = GetMessageFromException( executionException, exePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25058, 1364, 1412);
return return_v;
}


static string
f_25058_1364_1412_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25058, 1276, 1433);
return return_v;
}


static System.NotImplementedException
f_25058_1576_1605()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25058, 1576, 1605);
return return_v;
}

}
}
