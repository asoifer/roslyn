// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
internal static class ModuleInitializer
{
[ModuleInitializer]
        internal static void Initialize()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25037,425,610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25037,512,536);

f_25037_512_535(f_25037_512_527());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25037,550,599);

f_25037_550_598(f_25037_550_565(), f_25037_570_597());
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25037,425,610);

System.Diagnostics.TraceListenerCollection
f_25037_512_527()
{
var return_v =             Trace.Listeners;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25037, 512, 527);
return return_v;
}


int
f_25037_512_535(System.Diagnostics.TraceListenerCollection
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25037, 512, 535);
return 0;
}


System.Diagnostics.TraceListenerCollection
f_25037_550_565()
{
var return_v =             Trace.Listeners;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25037, 550, 565);
return return_v;
}


Microsoft.CodeAnalysis.ThrowingTraceListener
f_25037_570_597()
{
var return_v = new Microsoft.CodeAnalysis.ThrowingTraceListener();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25037, 570, 597);
return return_v;
}


int
f_25037_550_598(System.Diagnostics.TraceListenerCollection
this_param,Microsoft.CodeAnalysis.ThrowingTraceListener
listener)
{
var return_v = this_param.Add( (System.Diagnostics.TraceListener)listener);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25037, 550, 598);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25037,425,610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25037,425,610);
}
		}

static ModuleInitializer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25037,369,617);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25037,369,617);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25037,369,617);
}

}
}
