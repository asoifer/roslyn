// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.DiaSymReader
{
internal static class EmptyArray<T>
{
public static readonly T[] Instance ;

static EmptyArray()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(745,353,459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,432,451);
Instance = new T[0];DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(745,353,459);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,353,459);
}

}
internal class InteropUtilities
{
private static readonly IntPtr s_ignoreIErrorInfo ;

internal static T[] NullToEmpty<T>(T[] items) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(745,640,691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,643,691);
return (DynAbs.Tracing.TraceSender.Conditional_F1(745, 643, 658)||(((items == null) &&DynAbs.Tracing.TraceSender.Conditional_F2(745, 661, 683))||DynAbs.Tracing.TraceSender.Conditional_F3(745, 686, 691)))?EmptyArray<T>.Instance :items;DynAbs.Tracing.TraceSender.TraceExitMethod(745,640,691);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(745,640,691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,640,691);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void ThrowExceptionForHR(int hr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(745,704,1102);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,929,1091) || true) && (hr < 0 &&(DynAbs.Tracing.TraceSender.Expression_True(745, 933, 963)&&hr != HResult.E_FAIL )&&(DynAbs.Tracing.TraceSender.Expression_True(745, 933, 990)&&hr != HResult.E_NOTIMPL))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,929,1091);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1024,1076);

f_745_1024_1075(hr, s_ignoreIErrorInfo);
DynAbs.Tracing.TraceSender.TraceExitCondition(745,929,1091);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(745,704,1102);

int
f_745_1024_1075(int
errorCode,System.IntPtr
errorInfo)
{
Marshal.ThrowExceptionForHR( errorCode, errorInfo);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 1024, 1075);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(745,704,1102);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,704,1102);
}
		}

internal static unsafe void CopyQualifiedTypeName(char* qualifiedName, int qualifiedNameBufferLength, int* qualifiedNameLength, string namespaceStr, string nameStr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(745,1114,3226);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1303,1333);

f_745_1303_1332(nameStr != null);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1349,1450) || true) && (namespaceStr == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,1349,1450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1407,1435);

namespaceStr = string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(745,1349,1450);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1466,2270) || true) && (qualifiedNameLength != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,1466,2270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1531,1621);

int 
fullLength = ((DynAbs.Tracing.TraceSender.Conditional_F1(745, 1549, 1572)||((f_745_1549_1568(namespaceStr)> 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(745, 1575, 1598))||DynAbs.Tracing.TraceSender.Conditional_F3(745, 1601, 1602)))?f_745_1575_1594(namespaceStr)+ 1 :0) + f_745_1606_1620(nameStr)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1639,2255) || true) && (qualifiedName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,1639,2255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,1952,2040);

*qualifiedNameLength = f_745_1975_2039(fullLength, f_745_1996_2038(0, qualifiedNameBufferLength - 1));
DynAbs.Tracing.TraceSender.TraceExitCondition(745,1639,2255);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,1639,2255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2202,2236);

*qualifiedNameLength = fullLength;
DynAbs.Tracing.TraceSender.TraceExitCondition(745,1639,2255);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(745,1466,2270);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2286,3215) || true) && (qualifiedName != null &&(DynAbs.Tracing.TraceSender.Expression_True(745, 2290, 2344)&&qualifiedNameBufferLength > 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,2286,3215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2378,2404);

char* 
dst = qualifiedName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2422,2476);

char* 
dstEndPtr = dst + qualifiedNameBufferLength - 1
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2496,2934) || true) && (f_745_2500_2519(namespaceStr)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,2496,2934);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2574,2579);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2565,2756) || true) && (i < f_745_2585_2604(namespaceStr)&&(DynAbs.Tracing.TraceSender.Expression_True(745, 2581, 2623)&&dst < dstEndPtr))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2625,2628)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(745,2565,2756))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,2565,2756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2678,2701);

*dst = f_745_2685_2700(namespaceStr, i);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2727,2733);

dst++;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(745,1,192);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(745,1,192);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2780,2915) || true) && (dst < dstEndPtr)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,2780,2915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2849,2860);

*dst = '.';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2886,2892);

dst++;
DynAbs.Tracing.TraceSender.TraceExitCondition(745,2780,2915);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(745,2496,2934);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2963,2968);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,2954,3119) || true) && (i < f_745_2974_2988(nameStr)&&(DynAbs.Tracing.TraceSender.Expression_True(745, 2970, 3007)&&dst < dstEndPtr))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,3009,3012)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(745,2954,3119))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(745,2954,3119);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,3054,3072);

*dst = f_745_3061_3071(nameStr, i);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,3094,3100);

dst++;
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(745,1,166);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(745,1,166);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,3139,3170);

f_745_3139_3169(dst <= dstEndPtr);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,3188,3200);

*dst = '\0';
DynAbs.Tracing.TraceSender.TraceExitCondition(745,2286,3215);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(745,1114,3226);

int
f_745_1303_1332(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 1303, 1332);
return 0;
}


int
f_745_1549_1568(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 1549, 1568);
return return_v;
}


int
f_745_1575_1594(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 1575, 1594);
return return_v;
}


int
f_745_1606_1620(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 1606, 1620);
return return_v;
}


int
f_745_1996_2038(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 1996, 2038);
return return_v;
}


int
f_745_1975_2039(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 1975, 2039);
return return_v;
}


int
f_745_2500_2519(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 2500, 2519);
return return_v;
}


int
f_745_2585_2604(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 2585, 2604);
return return_v;
}


char
f_745_2685_2700(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 2685, 2700);
return return_v;
}


int
f_745_2974_2988(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 2974, 2988);
return return_v;
}


char
f_745_3061_3071(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(745, 3061, 3071);
return return_v;
}


int
f_745_3139_3169(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 3139, 3169);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(745,1114,3226);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,1114,3226);
}
		}

public InteropUtilities()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(745,467,3233);
DynAbs.Tracing.TraceSender.TraceExitConstructor(745,467,3233);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,467,3233);
}


static InteropUtilities()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(745,467,3233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(745,546,581);
s_ignoreIErrorInfo = f_745_567_581(-1);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(745,467,3233);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(745,467,3233);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(745,467,3233);

static System.IntPtr
f_745_567_581(int
value)
{
var return_v = new System.IntPtr( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(745, 567, 581);
return return_v;
}

}
}
