// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Collections;

namespace Microsoft.CodeAnalysis
{
public static partial class ISymbolExtensions
{
internal static IVTConclusion PerformIVTCheck(
            this AssemblyIdentity assemblyGrantingAccessIdentity,
            ImmutableArray<byte> assemblyWantingAccessKey,
            ImmutableArray<byte> grantedToPublicKey)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(625,830,7200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6512,6566);

bool 
q1 = f_625_6522_6565(assemblyGrantingAccessIdentity)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6580,6627);

bool 
q2 = f_625_6590_6626_M(!grantedToPublicKey.IsDefaultOrEmpty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6641,6694);

bool 
q3 = f_625_6651_6693_M(!assemblyWantingAccessKey.IsDefaultOrEmpty)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6708,6805);

bool 
q4 = (q2 & q3) &&(DynAbs.Tracing.TraceSender.Expression_True(625, 6718, 6804)&&f_625_6731_6804(grantedToPublicKey, assemblyWantingAccessKey))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6858,6962) || true) && (q2 &&(DynAbs.Tracing.TraceSender.Expression_True(625, 6862, 6871)&&!q4))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(625,6858,6962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,6905,6947);

return IVTConclusion.PublicKeyDoesntMatch;
DynAbs.Tracing.TraceSender.TraceExitCondition(625,6858,6962);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,7009,7108) || true) && (!q1 &&(DynAbs.Tracing.TraceSender.Expression_True(625, 7013, 7022)&&q3))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(625,7009,7108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,7056,7093);

return IVTConclusion.OneSignedOneNot;
DynAbs.Tracing.TraceSender.TraceExitCondition(625,7009,7108);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(625,7162,7189);

return IVTConclusion.Match;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(625,830,7200);

bool
f_625_6522_6565(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.IsStrongName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(625, 6522, 6565);
return return_v;
}


bool
f_625_6590_6626_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(625, 6590, 6626);
return return_v;
}


bool
f_625_6651_6693_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(625, 6651, 6693);
return return_v;
}


bool
f_625_6731_6804(System.Collections.Immutable.ImmutableArray<byte>
x,System.Collections.Immutable.ImmutableArray<byte>
y)
{
var return_v = ByteSequenceComparer.Equals( x, y);
DynAbs.Tracing.TraceSender.TraceEndInvocation(625, 6731, 6804);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(625,830,7200);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(625,830,7200);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
