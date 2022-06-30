// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;

namespace Microsoft.DiaSymReader
{
internal static class SymUnmanagedWriterFactory
{
public static SymUnmanagedWriter CreateWriter(
            ISymWriterMetadataProvider metadataProvider,
            SymUnmanagedWriterCreationOptions options = SymUnmanagedWriterCreationOptions.Default)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(754,2103,4726);
string implModuleName = default(string);
System.Exception loadException = default(System.Exception);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,2332,2467) || true) && (metadataProvider == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,2332,2467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,2394,2452);

throw f_754_2400_2451(nameof(metadataProvider));
DynAbs.Tracing.TraceSender.TraceExitCondition(754,2332,2467);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,2483,2895);

var 
symWriter = f_754_2499_2894(createReader: false, useAlternativeLoadPath: (options & SymUnmanagedWriterCreationOptions.UseAlternativeLoadPath) != 0, useComRegistry: (options & SymUnmanagedWriterCreationOptions.UseComRegistry) != 0, moduleName: out implModuleName, loadException: out loadException)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,2911,3248) || true) && (symWriter == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,2911,3248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,2966,3002);

f_754_2966_3001(loadException != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3022,3144) || true) && (loadException is DllNotFoundException)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3022,3144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3105,3125);

throw loadException;
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3022,3144);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3164,3233);

throw f_754_3170_3232(f_754_3195_3216(loadException), loadException);
DynAbs.Tracing.TraceSender.TraceExitCondition(754,2911,3248);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3264,3447) || true) && (!(symWriter is ISymUnmanagedWriter5 symWriter5))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3264,3447);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3349,3432);

throw f_754_3355_3431(f_754_3387_3414(), implModuleName);
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3264,3447);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3463,3541);

object 
metadataEmitAndImport = f_754_3494_3540(metadataProvider)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3555,3593);

var 
pdbStream = f_754_3571_3592()
;

            try
            {

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3645,4473) || true) && ((options & SymUnmanagedWriterCreationOptions.Deterministic) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3645,4473);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3755,4077) || true) && (symWriter is ISymUnmanagedWriter8 symWriter8)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3755,4077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,3853,3922);

f_754_3853_3921(                        symWriter8, metadataEmitAndImport, pdbStream);
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3755,4077);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3755,4077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,4020,4054);

throw f_754_4026_4053();
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3755,4077);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3645,4473);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(754,3645,4473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,4365,4454);

f_754_4365_4453(                    // The file name is irrelevant as long as it's specified.
                    // SymWriter only uses it for filling CodeView debug directory data when asked for them, but we never do.
                    symWriter5, metadataEmitAndImport, "filename.pdb", pdbStream, fullBuild: true);
DynAbs.Tracing.TraceSender.TraceExitCondition(754,3645,4473);
}
            }
            catch (Exception e)
            {
DynAbs.Tracing.TraceSender.TraceEnterCatch(754,4502,4626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,4554,4611);

throw f_754_4560_4610(e, implModuleName);
DynAbs.Tracing.TraceSender.TraceExitCatch(754,4502,4626);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(754,4642,4715);

return f_754_4649_4714(pdbStream, symWriter5, implModuleName);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(754,2103,4726);

System.ArgumentNullException
f_754_2400_2451(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 2400, 2451);
return return_v;
}


object
f_754_2499_2894(bool
createReader,bool
useAlternativeLoadPath,bool
useComRegistry,out string
moduleName,out System.Exception
loadException)
{
var return_v = SymUnmanagedFactory.CreateObject( createReader: createReader, useAlternativeLoadPath: useAlternativeLoadPath, useComRegistry: useComRegistry, out moduleName, out loadException);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 2499, 2894);
return return_v;
}


int
f_754_2966_3001(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 2966, 3001);
return 0;
}


string
f_754_3195_3216(System.Exception
this_param)
{
var return_v = this_param.Message;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(754, 3195, 3216);
return return_v;
}


System.DllNotFoundException
f_754_3170_3232(string
message,System.Exception
inner)
{
var return_v = new System.DllNotFoundException( message, inner);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3170, 3232);
return return_v;
}


System.NotSupportedException
f_754_3387_3414()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3387, 3414);
return return_v;
}


Microsoft.DiaSymReader.SymUnmanagedWriterException
f_754_3355_3431(System.NotSupportedException
innerException,string
implementationModuleName)
{
var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException( (System.Exception)innerException, implementationModuleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3355, 3431);
return return_v;
}


Microsoft.DiaSymReader.SymWriterMetadataAdapter
f_754_3494_3540(Microsoft.DiaSymReader.ISymWriterMetadataProvider
metadataProvider)
{
var return_v = new Microsoft.DiaSymReader.SymWriterMetadataAdapter( metadataProvider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3494, 3540);
return return_v;
}


Microsoft.DiaSymReader.ComMemoryStream
f_754_3571_3592()
{
var return_v = new Microsoft.DiaSymReader.ComMemoryStream();
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3571, 3592);
return return_v;
}


int
f_754_3853_3921(Microsoft.DiaSymReader.ISymUnmanagedWriter8
this_param,object
emitter,Microsoft.DiaSymReader.ComMemoryStream
stream)
{
this_param.InitializeDeterministic( emitter, (object)stream);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 3853, 3921);
return 0;
}


System.NotSupportedException
f_754_4026_4053()
{
var return_v = new System.NotSupportedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 4026, 4053);
return return_v;
}


int
f_754_4365_4453(Microsoft.DiaSymReader.ISymUnmanagedWriter5
this_param,object
emitter,string
filename,Microsoft.DiaSymReader.ComMemoryStream
ptrIStream,bool
fullBuild)
{
this_param.Initialize( emitter, filename, (object)ptrIStream, fullBuild: fullBuild);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 4365, 4453);
return 0;
}


Microsoft.DiaSymReader.SymUnmanagedWriterException
f_754_4560_4610(System.Exception
innerException,string
implementationModuleName)
{
var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException( innerException, implementationModuleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 4560, 4610);
return return_v;
}


Microsoft.DiaSymReader.SymUnmanagedWriterImpl
f_754_4649_4714(Microsoft.DiaSymReader.ComMemoryStream
pdbStream,Microsoft.DiaSymReader.ISymUnmanagedWriter5
symWriter,string
symWriterModuleName)
{
var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterImpl( pdbStream, symWriter, symWriterModuleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(754, 4649, 4714);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(754,2103,4726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(754,2103,4726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SymUnmanagedWriterFactory()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(754,314,4733);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(754,314,4733);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(754,314,4733);
}

}
}
