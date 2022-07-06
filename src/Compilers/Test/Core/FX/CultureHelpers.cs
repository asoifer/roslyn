
#nullable disable

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;

namespace Roslyn.Test.Utilities
{
public static class CultureHelpers
{
public static readonly CultureInfo EnglishCulture ;

static CultureHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25085,302,434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25085,388,426);
EnglishCulture = f_25085_405_426("en");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25085,302,434);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25085,302,434);
}


static System.Globalization.CultureInfo
f_25085_405_426(string
name)
{
var return_v = new System.Globalization.CultureInfo( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25085, 405, 426);
return return_v;
}

}
}
