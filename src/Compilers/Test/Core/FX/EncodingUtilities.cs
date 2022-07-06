// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Text;

namespace Roslyn.Test.Utilities
{
public static class EncodingExtensions
{
public static byte[] GetBytesWithPreamble(this Encoding encoding, string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25088,346,746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,449,487);

var 
preamble = f_25088_464_486(encoding)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,501,539);

var 
content = f_25088_515_538(encoding, text)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,555,613);

byte[] 
bytes = new byte[f_25088_579_594(preamble)+ f_25088_597_611(content)]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,627,653);

f_25088_627_652(            preamble, bytes, 0);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,667,706);

f_25088_667_705(            content, bytes, f_25088_689_704(preamble));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25088,722,735);

return bytes;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25088,346,746);

byte[]
f_25088_464_486(System.Text.Encoding
this_param)
{
var return_v = this_param.GetPreamble();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25088, 464, 486);
return return_v;
}


byte[]
f_25088_515_538(System.Text.Encoding
this_param,string
s)
{
var return_v = this_param.GetBytes( s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25088, 515, 538);
return return_v;
}


int
f_25088_579_594(byte[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25088, 579, 594);
return return_v;
}


int
f_25088_597_611(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25088, 597, 611);
return return_v;
}


int
f_25088_627_652(byte[]
this_param,byte[]
array,int
index)
{
this_param.CopyTo( (System.Array)array, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25088, 627, 652);
return 0;
}


int
f_25088_689_704(byte[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25088, 689, 704);
return return_v;
}


int
f_25088_667_705(byte[]
this_param,byte[]
array,int
index)
{
this_param.CopyTo( (System.Array)array, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25088, 667, 705);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25088,346,746);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25088,346,746);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static EncodingExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25088,291,753);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25088,291,753);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25088,291,753);
}

}
}
