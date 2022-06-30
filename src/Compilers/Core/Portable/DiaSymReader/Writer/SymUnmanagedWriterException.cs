// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.DiaSymReader
{
internal sealed class SymUnmanagedWriterException : Exception
{
public string ImplementationModuleName {get; }

public SymUnmanagedWriterException()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(753,699,757);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(753,640,687);
DynAbs.Tracing.TraceSender.TraceExitConstructor(753,699,757);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(753,699,757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,699,757);
}
		}

public SymUnmanagedWriterException(string message) :base(f_753_827_834_C(message) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(753,769,857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(753,640,687);
DynAbs.Tracing.TraceSender.TraceExitConstructor(753,769,857);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(753,769,857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,769,857);
}
		}

public SymUnmanagedWriterException(string message, Exception innerException)
:base(f_753_966_973_C(message) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(753,869,1012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(753,640,687);
DynAbs.Tracing.TraceSender.TraceExitConstructor(753,869,1012);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(753,869,1012);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,869,1012);
}
		}

public SymUnmanagedWriterException(string message, Exception innerException, string implementationModuleName)
:base(f_753_1154_1161_C(message) ,innerException)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(753,1024,1266);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(753,640,687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(753,1203,1255);

ImplementationModuleName = implementationModuleName;
DynAbs.Tracing.TraceSender.TraceExitConstructor(753,1024,1266);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(753,1024,1266);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,1024,1266);
}
		}

internal SymUnmanagedWriterException(Exception innerException, string implementationModuleName)
:this(f_753_1394_1416_C(f_753_1394_1416(innerException)) ,innerException,implementationModuleName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(753,1278,1481);
DynAbs.Tracing.TraceSender.TraceExitConstructor(753,1278,1481);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(753,1278,1481);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,1278,1481);
}
		}

static SymUnmanagedWriterException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(753,386,1488);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(753,386,1488);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(753,386,1488);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(753,386,1488);

static string
f_753_827_834_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(753, 769, 857);
return return_v;
}


static string
f_753_966_973_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(753, 869, 1012);
return return_v;
}


static string
f_753_1154_1161_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(753, 1024, 1266);
return return_v;
}


static string
f_753_1394_1416(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(753, 1394, 1416);
return return_v;
}


static string
f_753_1394_1416_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(753, 1278, 1481);
return return_v;
}

}
}
