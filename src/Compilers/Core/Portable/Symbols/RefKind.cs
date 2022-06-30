// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    /// <summary>
    /// Denotes the kind of reference.
    /// </summary>
    public enum RefKind : byte
    {
        /// <summary>
        /// Indicates a "value" parameter or return type.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates a "ref" parameter or return type.
        /// </summary>
        Ref = 1,

        /// <summary>
        /// Indicates an "out" parameter.
        /// </summary>
        Out = 2,

        /// <summary>
        /// Indicates an "in" parameter.
        /// </summary>
        In = 3,

        /// <summary>
        /// Indicates a "ref readonly" return type.
        /// </summary>
        RefReadOnly = 3,

        // NOTE: There is an additional value of this enum type - RefKindExtensions.StrictIn == RefKind.In + 1
        //       It is used internally during lowering. 
        //       Consider that when adding values or changing this enum in some other way.
    }
internal static class RefKindExtensions
{
internal static string ToParameterDisplayString(this RefKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(640,1333,1697);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1424,1686);

switch (kind)
            {

case RefKind.Out: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1424,1686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1488,1501);

return "out";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1424,1686);

case RefKind.Ref: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1424,1686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1537,1550);

return "ref";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1424,1686);

case RefKind.In: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1424,1686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1585,1597);

return "in";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1424,1686);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1424,1686);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1624,1671);

throw f_640_1630_1670(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1424,1686);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(640,1333,1697);

System.Exception
f_640_1630_1670(Microsoft.CodeAnalysis.RefKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(640, 1630, 1670);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(640,1333,1697);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(640,1333,1697);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ToArgumentDisplayString(this RefKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(640,1709,2072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1799,2061);

switch (kind)
            {

case RefKind.Out: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1799,2061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1863,1876);

return "out";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1799,2061);

case RefKind.Ref: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1799,2061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1912,1925);

return "ref";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1799,2061);

case RefKind.In: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1799,2061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1960,1972);

return "in";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1799,2061);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,1799,2061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,1999,2046);

throw f_640_2005_2045(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(640,1799,2061);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(640,1709,2072);

System.Exception
f_640_2005_2045(Microsoft.CodeAnalysis.RefKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(640, 2005, 2045);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(640,1709,2072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(640,1709,2072);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static string ToParameterPrefix(this RefKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(640,2084,2501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2168,2490);

switch (kind)
            {

case RefKind.Out: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,2168,2490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2232,2246);

return "out ";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,2168,2490);

case RefKind.Ref: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,2168,2490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2282,2296);

return "ref ";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,2168,2490);

case RefKind.In: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,2168,2490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2331,2344);

return "in ";
DynAbs.Tracing.TraceSender.TraceExitCondition(640,2168,2490);

case RefKind.None: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,2168,2490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2381,2401);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(640,2168,2490);

default: DynAbs.Tracing.TraceSender.TraceEnterCondition(640,2168,2490);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2428,2475);

throw f_640_2434_2474(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(640,2168,2490);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(640,2084,2501);

System.Exception
f_640_2434_2474(Microsoft.CodeAnalysis.RefKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(640, 2434, 2474);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(640,2084,2501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(640,2084,2501);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal const RefKind 
StrictIn = RefKind.In + 1
;

static RefKindExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(640,1277,3030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(640,2997,3022);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(640,1277,3030);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(640,1277,3030);
}

}
}
