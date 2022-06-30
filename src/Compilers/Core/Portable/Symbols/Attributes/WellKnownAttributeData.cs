// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
internal abstract class WellKnownAttributeData
{
public static readonly string StringMissingValue ;

private bool _isSealed;

private bool _anyDataStored;

public WellKnownAttributeData()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(816,1173,1314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1105,1114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1138,1152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1240,1258);

_isSealed = false;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1272,1295);

_anyDataStored = false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(816,1173,1314);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(816,1173,1314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,1173,1314);
}
		}

[Conditional("DEBUG")]
        protected void VerifySealed(bool expected = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(816,1326,1498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1443,1479);

f_816_1443_1478(_isSealed == expected);
DynAbs.Tracing.TraceSender.TraceExitMethod(816,1326,1498);

int
f_816_1443_1478(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(816, 1443, 1478);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(816,1326,1498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,1326,1498);
}
		}

[Conditional("DEBUG")]
        internal void VerifyDataStored(bool expected = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(816,1510,1690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1630,1671);

f_816_1630_1670(_anyDataStored == expected);
DynAbs.Tracing.TraceSender.TraceExitMethod(816,1510,1690);

int
f_816_1630_1670(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(816, 1630, 1670);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(816,1510,1690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,1510,1690);
}
		}

[Conditional("DEBUG")]
        protected void SetDataStored()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(816,1702,1841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1800,1822);

_anyDataStored = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(816,1702,1841);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(816,1702,1841);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,1702,1841);
}
		}

[Conditional("DEBUG")]
        internal static void Seal(WellKnownAttributeData data)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(816,1853,2181);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,1975,2162) || true) && (data != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(816,1975,2162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,2025,2055);

f_816_2025_2054(!data._isSealed);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,2073,2107);

f_816_2073_2106(data._anyDataStored);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,2125,2147);

data._isSealed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(816,1975,2162);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(816,1853,2181);

int
f_816_2025_2054(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(816, 2025, 2054);
return 0;
}


int
f_816_2073_2106(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(816, 2073, 2106);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(816,1853,2181);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,1853,2181);
}
		}

static WellKnownAttributeData()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(816,476,2188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(816,989,1036);
StringMissingValue = nameof(StringMissingValue);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(816,476,2188);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(816,476,2188);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(816,476,2188);
}
}
