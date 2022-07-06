// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roslyn.Test.Utilities.Syntax
{
internal sealed class RandomizedSourceText : SourceText
{
private readonly char[] _buffer ;

public RandomizedSourceText()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25133,496,727);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,459,483);
this._buffer = new char[2048];DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,550,581);

var 
random = f_25133_563_580(12345)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,604,609);
            for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,595,716) || true) && (i < f_25133_615_629(_buffer))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,631,634)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25133,595,716))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25133,595,716);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,668,701);

_buffer[i] = (char)f_25133_687_700(random);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25133,1,122);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25133,1,122);
}DynAbs.Tracing.TraceSender.TraceExitConstructor(25133,496,727);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25133,496,727);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25133,496,727);
}
		}

        public override char this[int position] => _buffer[position % f_25133_801_815(_buffer)];

public override Encoding Encoding {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25133,863,879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,866,879);
return f_25133_866_879();DynAbs.Tracing.TraceSender.TraceExitMethod(25133,863,879);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25133,863,879);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25133,863,879);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override int Length
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25133,943,1018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,979,1003);

return 40 * 1000 * 1000;
DynAbs.Tracing.TraceSender.TraceExitMethod(25133,943,1018);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25133,892,1029);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25133,892,1029);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25133,1041,1311);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,1172,1177);
            for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,1163,1300) || true) && (i < count)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,1190,1193)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(25133,1163,1300))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25133,1163,1300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25133,1227,1285);

destination[destinationIndex + i] = f_25133_1263_1284(this, sourceIndex + i);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25133,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25133,1,138);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25133,1041,1311);

char
f_25133_1263_1284(Roslyn.Test.Utilities.Syntax.RandomizedSourceText
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25133, 1263, 1284);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25133,1041,1311);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25133,1041,1311);
}
		}

static RandomizedSourceText()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25133,363,1318);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25133,363,1318);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25133,363,1318);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25133,363,1318);

static System.Random
f_25133_563_580(int
Seed)
{
var return_v = new System.Random( Seed);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25133, 563, 580);
return return_v;
}


static int
f_25133_615_629(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25133, 615, 629);
return return_v;
}


static int
f_25133_687_700(System.Random
this_param)
{
var return_v = this_param.Next();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25133, 687, 700);
return return_v;
}


int
f_25133_801_815(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25133, 801, 815);
return return_v;
}


System.Text.Encoding
f_25133_866_879()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25133, 866, 879);
return return_v;
}

}
}
