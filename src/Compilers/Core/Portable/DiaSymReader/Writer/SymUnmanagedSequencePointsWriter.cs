// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.DiaSymReader
{
internal sealed class SymUnmanagedSequencePointsWriter
{
private readonly SymUnmanagedWriter _writer;

private int _currentDocumentIndex;

private int _count;

private int[] _offsets;

private int[] _startLines;

private int[] _startColumns;

private int[] _endLines;

private int[] _endColumns;

public SymUnmanagedSequencePointsWriter(SymUnmanagedWriter writer, int capacity = 64)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(750,664,1259);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,394,401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,424,445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,468,474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,499,507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,532,543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,568,581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,606,615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,640,651);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,774,896) || true) && (capacity <= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,774,896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,825,881);

throw f_750_831_880(nameof(capacity));
DynAbs.Tracing.TraceSender.TraceExitCondition(750,774,896);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,912,980);

_writer = writer ??(DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.DiaSymReader.SymUnmanagedWriter>(750, 922, 979)??throw f_750_938_979(nameof(writer)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,994,1021);

_currentDocumentIndex = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1035,1064);

_offsets = new int[capacity];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1078,1110);

_startLines = new int[capacity];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1124,1158);

_startColumns = new int[capacity];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1172,1202);

_endLines = new int[capacity];
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1216,1248);

_endColumns = new int[capacity];
DynAbs.Tracing.TraceSender.TraceExitConstructor(750,664,1259);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(750,664,1259);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,664,1259);
}
		}

private void EnsureCapacity(int length)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(750,1271,1777);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1335,1766) || true) && (length > f_750_1348_1363(_offsets))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,1335,1766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1397,1457);

int 
newLength = f_750_1413_1456(length, (f_750_1431_1446(_offsets)+ 1) * 2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1477,1515);

f_750_1477_1514(ref _offsets, newLength);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1533,1574);

f_750_1533_1573(ref _startLines, newLength);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1592,1635);

f_750_1592_1634(ref _startColumns, newLength);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1653,1692);

f_750_1653_1691(ref _endLines, newLength);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1710,1751);

f_750_1710_1750(ref _endColumns, newLength);
DynAbs.Tracing.TraceSender.TraceExitCondition(750,1335,1766);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(750,1271,1777);

int
f_750_1348_1363(int[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(750, 1348, 1363);
return return_v;
}


int
f_750_1431_1446(int[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(750, 1431, 1446);
return return_v;
}


int
f_750_1413_1456(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1413, 1456);
return return_v;
}


int
f_750_1477_1514(ref int[]
array,int
newSize)
{
Array.Resize( ref array, newSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1477, 1514);
return 0;
}


int
f_750_1533_1573(ref int[]
array,int
newSize)
{
Array.Resize( ref array, newSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1533, 1573);
return 0;
}


int
f_750_1592_1634(ref int[]
array,int
newSize)
{
Array.Resize( ref array, newSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1592, 1634);
return 0;
}


int
f_750_1653_1691(ref int[]
array,int
newSize)
{
Array.Resize( ref array, newSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1653, 1691);
return 0;
}


int
f_750_1710_1750(ref int[]
array,int
newSize)
{
Array.Resize( ref array, newSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 1710, 1750);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(750,1271,1777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,1271,1777);
}
		}

private void Clear()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(750,1789,1897);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1834,1861);

_currentDocumentIndex = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,1875,1886);

_count = 0;
DynAbs.Tracing.TraceSender.TraceExitMethod(750,1789,1897);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(750,1789,1897);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,1789,1897);
}
		}

public void Add(int documentIndex, int offset, int startLine, int startColumn, int endLine, int endColumn)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(750,1909,2744);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2040,2171) || true) && (documentIndex < 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,2040,2171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2095,2156);

throw f_750_2101_2155(nameof(documentIndex));
DynAbs.Tracing.TraceSender.TraceExitCondition(750,2040,2171);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2187,2436) || true) && (_currentDocumentIndex != documentIndex)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,2187,2436);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2263,2363) || true) && (_currentDocumentIndex != -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,2263,2363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2336,2344);

f_750_2336_2343(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(750,2263,2363);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2383,2421);

_currentDocumentIndex = documentIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(750,2187,2436);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2452,2473);

int 
index = _count++
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2489,2512);

f_750_2489_2511(this, _count);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2528,2553);

_offsets[index] = offset;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2567,2598);

_startLines[index] = startLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2612,2647);

_startColumns[index] = startColumn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2661,2688);

_endLines[index] = endLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2702,2733);

_endColumns[index] = endColumn;
DynAbs.Tracing.TraceSender.TraceExitMethod(750,1909,2744);

System.ArgumentOutOfRangeException
f_750_2101_2155(string
paramName)
{
var return_v = new System.ArgumentOutOfRangeException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 2101, 2155);
return return_v;
}


int
f_750_2336_2343(Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
this_param)
{
this_param.Flush();
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 2336, 2343);
return 0;
}


int
f_750_2489_2511(Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
this_param,int
length)
{
this_param.EnsureCapacity( length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 2489, 2511);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(750,1909,2744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,1909,2744);
}
		}

public void Flush()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(750,2756,3168);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2800,3133) || true) && (_count > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(750,2800,3133);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,2848,3118);

f_750_2848_3117(                _writer, _currentDocumentIndex, _count, _offsets, _startLines, _startColumns, _endLines, _endColumns);
DynAbs.Tracing.TraceSender.TraceExitCondition(750,2800,3133);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(750,3149,3157);

f_750_3149_3156(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(750,2756,3168);

int
f_750_2848_3117(Microsoft.DiaSymReader.SymUnmanagedWriter
this_param,int
documentIndex,int
count,int[]
offsets,int[]
startLines,int[]
startColumns,int[]
endLines,int[]
endColumns)
{
this_param.DefineSequencePoints( documentIndex, count, offsets, startLines, startColumns, endLines, endColumns);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 2848, 3117);
return 0;
}


int
f_750_3149_3156(Microsoft.DiaSymReader.SymUnmanagedSequencePointsWriter
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 3149, 3156);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(750,2756,3168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,2756,3168);
}
		}

static SymUnmanagedSequencePointsWriter()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(750,287,3175);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(750,287,3175);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(750,287,3175);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(750,287,3175);

static System.ArgumentOutOfRangeException
f_750_831_880(string
paramName)
{
var return_v = new System.ArgumentOutOfRangeException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 831, 880);
return return_v;
}


static System.ArgumentNullException
f_750_938_979(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(750, 938, 979);
return return_v;
}

}
}
