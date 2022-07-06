// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Roslyn.Test.Utilities
{
    public enum ClrOnlyReason
    {
        Unknown,

        // The Mono version of ilasm doesn't have all of the features we need to run 
        // our tests.  In particular it doesn't appear to support the full range of 
        // modopt operators that our tests invoke.
        Ilasm,

        // Mono lists certain methods in a different order than the CLR.  For example
        // Equals, GetHashCode, ToString, etc ... which breaks our tests which hard
        // code the order. 
        MemberOrder,

        // Can't emit a PDB.
        Pdb,

        // The documentation comment compiler has a dependency on a resource in the 
        // System.Xml assembly.  This is a non-portable / implementation detail 
        // that Mono doesn't mirror.  We need to make this test more robust so it can
        // run on all runtimes. 
        //
        // See DocumentationCommentCompiler.GetDescription 
        DocumentationComment,

        // Can't sign. 
        Signing,

        Fusion,
    }
public sealed class ClrOnlyFactAttribute : FactAttribute
{
public readonly ClrOnlyReason Reason;

public ClrOnlyFactAttribute(ClrOnlyReason reason = ClrOnlyReason.Unknown)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25045,1617,1869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,1598,1604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,1715,1731);

Reason = reason;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,1747,1858) || true) && (f_25045_1751_1780())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1747,1858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,1814,1843);

Skip = f_25045_1821_1842(Reason);
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1747,1858);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(25045,1617,1869);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25045,1617,1869);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25045,1617,1869);
}
		}

private static string GetSkipReason(ClrOnlyReason reason)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25045,1881,2855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,1963,2844);

switch (reason)
            {

case ClrOnlyReason.Ilasm:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2058,2122);

return "Mono ilasm doesn't support all of the features we need";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

case ClrOnlyReason.MemberOrder:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2193,2272);

return "Mono returns certain symbols in different order than we are expecting";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

case ClrOnlyReason.Pdb:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2335,2378);

return "Can't emit a PDB in this scenario";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

case ClrOnlyReason.Signing:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2445,2493);

return "Can't sign assemblies in this scenario";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

case ClrOnlyReason.DocumentationComment:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2573,2641);

return "Documentation comment compiler can't run this test on Mono";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

case ClrOnlyReason.Fusion:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2707,2745);

return "Fusion not available on Mono";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,1963,2844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,2793,2829);

return "Test supported only on CLR";
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,1963,2844);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25045,1881,2855);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25045,1881,2855);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25045,1881,2855);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ClrOnlyFactAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25045,1495,2862);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25045,1495,2862);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25045,1495,2862);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25045,1495,2862);

static bool
f_25045_1751_1780()
{
var return_v = MonoHelpers.IsRunningOnMono();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25045, 1751, 1780);
return return_v;
}


static string
f_25045_1821_1842(Roslyn.Test.Utilities.ClrOnlyReason
reason)
{
var return_v = GetSkipReason( reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25045, 1821, 1842);
return return_v;
}

}
public sealed class MonoOnlyFactAttribute : FactAttribute
{
public MonoOnlyFactAttribute(string reason)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25045,2944,3120);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,3012,3109) || true) && (!f_25045_3017_3046())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25045,3012,3109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25045,3080,3094);

Skip = reason;
DynAbs.Tracing.TraceSender.TraceExitCondition(25045,3012,3109);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(25045,2944,3120);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25045,2944,3120);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25045,2944,3120);
}
		}

static MonoOnlyFactAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25045,2870,3127);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25045,2870,3127);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25045,2870,3127);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25045,2870,3127);

static bool
f_25045_3017_3046()
{
var return_v = MonoHelpers.IsRunningOnMono();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25045, 3017, 3046);
return return_v;
}

}
}
