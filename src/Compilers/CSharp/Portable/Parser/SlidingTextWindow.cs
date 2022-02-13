// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
internal sealed class SlidingTextWindow : IDisposable
{
public const char 
InvalidCharacter = char.MaxValue
;

private const int 
DefaultWindowLength = 2048
;

private readonly SourceText _text;

private int _basis;

private int _offset;

private readonly int _textEnd;

private char[] _characterWindow;

private int _characterWindowCount;

private int _lexemeStart;

private readonly StringTable _strings;

private static readonly ObjectPool<char[]> s_windowPool ;

public SlidingTextWindow(SourceText text)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10018,3377,3694);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2103,2108);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2175,2181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2293,2300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2402,2410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2481,2497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2583,2604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2686,2698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3226,3234);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3443,3456);

_text = text;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3470,3481);

_basis = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3495,3507);

_offset = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3521,3544);

_textEnd = f_10018_3532_3543(text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3558,3595);

_strings = f_10018_3569_3594();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3609,3652);

_characterWindow = f_10018_3628_3651(s_windowPool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3666,3683);

_lexemeStart = 0;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10018,3377,3694);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,3377,3694);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,3377,3694);
}
		}

public void Dispose()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,3706,3952);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3752,3941) || true) && (_characterWindow != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,3752,3941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3814,3850);

f_10018_3814_3849(                s_windowPool, _characterWindow);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3868,3892);

_characterWindow = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3910,3926);

f_10018_3910_3925(                _strings);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,3752,3941);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,3706,3952);

int
f_10018_3814_3849(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
this_param,char[]
obj)
{
this_param.Free( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 3814, 3849);
return 0;
}


int
f_10018_3910_3925(Roslyn.Utilities.StringTable
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 3910, 3925);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,3706,3952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,3706,3952);
}
		}

public SourceText Text {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,3987,3995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3990,3995);
return _text;DynAbs.Tracing.TraceSender.TraceExitMethod(10018,3987,3995);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,3987,3995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,3987,3995);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int Position
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,4160,4235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,4196,4220);

return _basis + _offset;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,4160,4235);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,4116,4246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,4116,4246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int Offset
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,4429,4495);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,4465,4480);

return _offset;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,4429,4495);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,4387,4506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,4387,4506);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public char[] CharacterWindow
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,4671,4746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,4707,4731);

return _characterWindow;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,4671,4746);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,4617,4757);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,4617,4757);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int LexemeRelativeStart
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,4954,5025);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,4990,5010);

return _lexemeStart;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,4954,5025);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,4899,5036);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,4899,5036);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int CharacterWindowCount
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,5210,5290);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,5246,5275);

return _characterWindowCount;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,5210,5290);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,5154,5301);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,5154,5301);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int LexemeStartPosition
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,5523,5603);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,5559,5588);

return _basis + _lexemeStart;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,5523,5603);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,5468,5614);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,5468,5614);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public int Width
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,5775,5856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,5811,5841);

return _offset - _lexemeStart;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,5775,5856);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,5734,5867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,5734,5867);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public void Start()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,5967,6045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6011,6034);

_lexemeStart = _offset;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,5967,6045);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,5967,6045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,5967,6045);
}
		}

public void Reset(int position)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,6057,6966);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6207,6240);

int 
relative = position - _basis
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6254,6955) || true) && (relative >= 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 6258, 6308)&&relative <= _characterWindowCount))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,6254,6955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6342,6361);

_offset = relative;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,6254,6955);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,6254,6955);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6477,6566);

int 
amountToRead = f_10018_6496_6554(f_10018_6505_6517(_text), position + f_10018_6530_6553(_characterWindow))- position
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6584,6625);

amountToRead = f_10018_6599_6624(amountToRead, 0);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6643,6782) || true) && (amountToRead > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,6643,6782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6705,6763);

f_10018_6705_6762(                    _text, position, _characterWindow, 0, amountToRead);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,6643,6782);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6802,6819);

_lexemeStart = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6837,6849);

_offset = 0;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6867,6885);

_basis = position;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,6903,6940);

_characterWindowCount = amountToRead;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,6254,6955);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,6057,6966);

int
f_10018_6505_6517(Microsoft.CodeAnalysis.Text.SourceText
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 6505, 6517);
return return_v;
}


int
f_10018_6530_6553(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 6530, 6553);
return return_v;
}


int
f_10018_6496_6554(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 6496, 6554);
return return_v;
}


int
f_10018_6599_6624(int
val1,int
val2)
{
var return_v = Math.Max( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 6599, 6624);
return return_v;
}


int
f_10018_6705_6762(Microsoft.CodeAnalysis.Text.SourceText
this_param,int
sourceIndex,char[]
destination,int
destinationIndex,int
count)
{
this_param.CopyTo( sourceIndex, destination, destinationIndex, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 6705, 6762);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,6057,6966);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,6057,6966);
}
		}

private bool MoreChars()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,6978,8890);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7027,8851) || true) && (_offset >= _characterWindowCount)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,7027,8851);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7097,7200) || true) && (f_10018_7101_7114(this)>= _textEnd)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,7097,7200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7168,7181);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,7097,7200);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7358,7857) || true) && (_lexemeStart > (_characterWindowCount / 4))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,7358,7857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7446,7648);

f_10018_7446_7647(_characterWindow, _lexemeStart, _characterWindow, 0, _characterWindowCount - _lexemeStart);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7670,7708);

_characterWindowCount -= _lexemeStart;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7730,7754);

_offset -= _lexemeStart;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7776,7799);

_basis += _lexemeStart;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7821,7838);

_lexemeStart = 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,7358,7857);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,7877,8394) || true) && (_characterWindowCount >= f_10018_7906_7929(_characterWindow))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,7877,8394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8048,8084);

char[] 
oldWindow = _characterWindow
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8106,8163);

char[] 
newWindow = new char[f_10018_8134_8157(_characterWindow)* 2]
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8185,8247);

f_10018_8185_8246(oldWindow, 0, newWindow, 0, _characterWindowCount);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8269,8324);

f_10018_8269_8323(                    s_windowPool, oldWindow, newWindow);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8346,8375);

_characterWindow = newWindow;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,7877,8394);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8414,8557);

int 
amountToRead = f_10018_8433_8556(_textEnd - (_basis + _characterWindowCount), f_10018_8508_8531(_characterWindow)- _characterWindowCount)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8575,8738);

f_10018_8575_8737(                _text, _basis + _characterWindowCount, _characterWindow, _characterWindowCount, amountToRead);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8756,8794);

_characterWindowCount += amountToRead;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8812,8836);

return amountToRead > 0;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,7027,8851);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,8867,8879);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,6978,8890);

int
f_10018_7101_7114(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 7101, 7114);
return return_v;
}


int
f_10018_7446_7647(char[]
sourceArray,int
sourceIndex,char[]
destinationArray,int
destinationIndex,int
length)
{
Array.Copy( (System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 7446, 7647);
return 0;
}


int
f_10018_7906_7929(char[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 7906, 7929);
return return_v;
}


int
f_10018_8134_8157(char[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 8134, 8157);
return return_v;
}


int
f_10018_8185_8246(char[]
sourceArray,int
sourceIndex,char[]
destinationArray,int
destinationIndex,int
length)
{
Array.Copy( (System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 8185, 8246);
return 0;
}


int
f_10018_8269_8323(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
this_param,char[]
old,char[]
replacement)
{
this_param.ForgetTrackedObject( old, replacement);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 8269, 8323);
return 0;
}


int
f_10018_8508_8531(char[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 8508, 8531);
return return_v;
}


int
f_10018_8433_8556(int
val1,int
val2)
{
var return_v = Math.Min( val1, val2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 8433, 8556);
return return_v;
}


int
f_10018_8575_8737(Microsoft.CodeAnalysis.Text.SourceText
this_param,int
sourceIndex,char[]
destination,int
destinationIndex,int
count)
{
this_param.CopyTo( sourceIndex, destination, destinationIndex, count);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 8575, 8737);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,6978,8890);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,6978,8890);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal bool IsReallyAtEnd()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,9246,9375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,9300,9364);

return _offset >= _characterWindowCount &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 9307, 9363)&&f_10018_9343_9351()>= _textEnd);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,9246,9375);

int
f_10018_9343_9351()
{
var return_v = Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 9343, 9351);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,9246,9375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,9246,9375);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void AdvanceChar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,9539,9610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,9589,9599);

_offset++;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,9539,9610);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,9539,9610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,9539,9610);
}
		}

public void AdvanceChar(int n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,9772,9851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,9827,9840);

_offset += n;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,9772,9851);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,9772,9851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,9772,9851);
}
		}

public char NextChar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,10138,10346);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10185,10205);

char 
c = f_10018_10194_10204(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10219,10312) || true) && (c != InvalidCharacter)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,10219,10312);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10278,10297);

f_10018_10278_10296(                this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,10219,10312);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10326,10335);

return c;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,10138,10346);

char
f_10018_10194_10204(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 10194, 10204);
return return_v;
}


int
f_10018_10278_10296(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 10278, 10296);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,10138,10346);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,10138,10346);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char PeekChar()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,10677,10980);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10724,10866) || true) && (_offset >= _characterWindowCount
&&(DynAbs.Tracing.TraceSender.Expression_True(10018, 10728, 10793)&&!f_10018_10782_10793(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,10724,10866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10827,10851);

return InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,10724,10866);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,10936,10969);

return _characterWindow[_offset];
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,10677,10980);

bool
f_10018_10782_10793(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.MoreChars();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 10782, 10793);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,10677,10980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,10677,10980);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char PeekChar(int delta)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,11305,11833);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11361,11390);

int 
position = f_10018_11376_11389(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11404,11428);

f_10018_11404_11427(            this, delta);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11444,11452);

char 
ch
=default(char);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11466,11761) || true) && (_offset >= _characterWindowCount
&&(DynAbs.Tracing.TraceSender.Expression_True(10018, 11470, 11535)&&!f_10018_11524_11535(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,11466,11761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11569,11591);

ch = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,11466,11761);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,11466,11761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11715,11746);

ch = _characterWindow[_offset];
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,11466,11761);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11777,11798);

f_10018_11777_11797(
            this, position);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11812,11822);

return ch;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,11305,11833);

int
f_10018_11376_11389(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 11376, 11389);
return return_v;
}


int
f_10018_11404_11427(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
n)
{
this_param.AdvanceChar( n);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 11404, 11427);
return 0;
}


bool
f_10018_11524_11535(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.MoreChars();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 11524, 11535);
return return_v;
}


int
f_10018_11777_11797(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
position)
{
this_param.Reset( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 11777, 11797);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,11305,11833);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,11305,11833);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool IsUnicodeEscape()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,11845,12161);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11899,12121) || true) && (f_10018_11903_11918(this)== '\\')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,11899,12121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,11960,11987);

var 
ch2 = f_10018_11970_11986(this, 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12005,12106) || true) && (ch2 == 'U' ||(DynAbs.Tracing.TraceSender.Expression_False(10018, 12009, 12033)||ch2 == 'u'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,12005,12106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12075,12087);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,12005,12106);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,11899,12121);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12137,12150);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,11845,12161);

char
f_10018_11903_11918(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 11903, 11918);
return return_v;
}


char
f_10018_11970_11986(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
delta)
{
var return_v = this_param.PeekChar( delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 11970, 11986);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,11845,12161);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,11845,12161);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char PeekCharOrUnicodeEscape(out char surrogateCharacter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,12173,12547);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12262,12536) || true) && (f_10018_12266_12288(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,12262,12536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12322,12376);

return f_10018_12329_12375(this, out surrogateCharacter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,12262,12536);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,12262,12536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12442,12480);

surrogateCharacter = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12498,12521);

return f_10018_12505_12520(this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,12262,12536);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,12173,12547);

bool
f_10018_12266_12288(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.IsUnicodeEscape();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 12266, 12288);
return return_v;
}


char
f_10018_12329_12375(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,out char
surrogateCharacter)
{
var return_v = this_param.PeekUnicodeEscape( out surrogateCharacter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 12329, 12375);
return return_v;
}


char
f_10018_12505_12520(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 12505, 12520);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,12173,12547);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,12173,12547);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char PeekUnicodeEscape(out char surrogateCharacter)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,12559,13063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12642,12671);

int 
position = f_10018_12657_12670(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12763,12789);

SyntaxDiagnosticInfo 
info
=default(SyntaxDiagnosticInfo);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12803,12907);

var 
ch = f_10018_12812_12906(this, peek: true, surrogateCharacter: out surrogateCharacter, info: out info)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,12921,12993);

f_10018_12921_12992(info == null, "Never produce a diagnostic while peeking.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13007,13028);

f_10018_13007_13027(            this, position);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13042,13052);

return ch;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,12559,13063);

int
f_10018_12657_12670(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 12657, 12670);
return return_v;
}


char
f_10018_12812_12906(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,bool
peek,out char
surrogateCharacter,out Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
info)
{
var return_v = this_param.ScanUnicodeEscape( peek:peek, out surrogateCharacter, out info);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 12812, 12906);
return return_v;
}


int
f_10018_12921_12992(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 12921, 12992);
return 0;
}


int
f_10018_13007_13027(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
position)
{
this_param.Reset( position);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13007, 13027);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,12559,13063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,12559,13063);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char NextCharOrUnicodeEscape(out char surrogateCharacter, out SyntaxDiagnosticInfo info)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,13075,13825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13195,13220);

var 
ch = f_10018_13204_13219(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13234,13363);

f_10018_13234_13362(ch != InvalidCharacter, "Precondition established by all callers; required for correctness of AdvanceChar() call.");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13377,13677) || true) && (ch == '\\')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,13377,13677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13425,13452);

var 
ch2 = f_10018_13435_13451(this, 1)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13470,13662) || true) && (ch2 == 'U' ||(DynAbs.Tracing.TraceSender.Expression_False(10018, 13474, 13498)||ch2 == 'u'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,13470,13662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13540,13643);

return f_10018_13547_13642(this, peek: false, surrogateCharacter: out surrogateCharacter, info: out info);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,13470,13662);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,13377,13677);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13693,13731);

surrogateCharacter = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13745,13757);

info = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13771,13790);

f_10018_13771_13789(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13804,13814);

return ch;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,13075,13825);

char
f_10018_13204_13219(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13204, 13219);
return return_v;
}


int
f_10018_13234_13362(bool
condition,string
message)
{
Debug.Assert( condition, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13234, 13362);
return 0;
}


char
f_10018_13435_13451(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
delta)
{
var return_v = this_param.PeekChar( delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13435, 13451);
return return_v;
}


char
f_10018_13547_13642(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,bool
peek,out char
surrogateCharacter,out Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
info)
{
var return_v = this_param.ScanUnicodeEscape( peek:peek, out surrogateCharacter, out info);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13547, 13642);
return return_v;
}


int
f_10018_13771_13789(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13771, 13789);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,13075,13825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,13075,13825);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public char NextUnicodeEscape(out char surrogateCharacter, out SyntaxDiagnosticInfo info)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,13837,14060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,13951,14049);

return f_10018_13958_14048(this, peek: false, surrogateCharacter: out surrogateCharacter, info: out info);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,13837,14060);

char
f_10018_13958_14048(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,bool
peek,out char
surrogateCharacter,out Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
info)
{
var return_v = this_param.ScanUnicodeEscape( peek:peek, out surrogateCharacter, out info);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 13958, 14048);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,13837,14060);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,13837,14060);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private char ScanUnicodeEscape(bool peek, out char surrogateCharacter, out SyntaxDiagnosticInfo info)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,14072,17300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14198,14236);

surrogateCharacter = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14250,14262);

info = null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14278,14304);

int 
start = f_10018_14290_14303(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14318,14351);

char 
character = f_10018_14335_14350(this)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14365,14397);

f_10018_14365_14396(character == '\\');
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14411,14430);

f_10018_14411_14429(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14446,14474);

character = f_10018_14458_14473(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14488,17256) || true) && (character == 'U')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14488,17256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14542,14560);

uint 
uintChar = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14580,14599);

f_10018_14580_14598(
                this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14617,15958) || true) && (!f_10018_14622_14661(f_10018_14645_14660(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14617,15958);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14703,14829) || true) && (!peek)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14703,14829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14762,14806);

info = f_10018_14769_14805(this, start);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14703,14829);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14617,15958);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14617,15958);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14920,14925);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14911,15517) || true) && (i < 8)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14934,14937)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14911,15517))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14911,15517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,14987,15015);

character = f_10018_14999_15014(this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15041,15352) || true) && (!f_10018_15046_15079(character))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,15041,15352);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15137,15287) || true) && (!peek)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,15137,15287);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15212,15256);

info = f_10018_15219_15255(this, start);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,15137,15287);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,15319,15325);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,15041,15352);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15380,15449);

uintChar = (uint)((uintChar << 4) + f_10018_15416_15447(character));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15475,15494);

f_10018_15475_15493(                        this);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10018,1,607);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10018,1,607);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15541,15939) || true) && (uintChar > 0x0010FFFF)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,15541,15939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15616,15754) || true) && (!peek)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,15616,15754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15683,15727);

info = f_10018_15690_15726(this, start);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,15616,15754);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,15541,15939);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,15541,15939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,15852,15916);

character = f_10018_15864_15915(uintChar, out surrogateCharacter);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,15541,15939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14617,15958);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14488,17256);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,14488,17256);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16024,16075);

f_10018_16024_16074(character == 'u' ||(DynAbs.Tracing.TraceSender.Expression_False(10018, 16037, 16073)||character == 'x'));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16095,16111);

int 
intChar = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16129,16148);

f_10018_16129_16147(                this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16166,17241) || true) && (!f_10018_16171_16210(f_10018_16194_16209(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16166,17241);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16252,16378) || true) && (!peek)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16252,16378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16311,16355);

info = f_10018_16318_16354(this, start);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16252,16378);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16166,17241);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16166,17241);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16469,16474);
                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16460,17172) || true) && (i < 4)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16483,16486)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16460,17172))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16460,17172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16536,16563);

char 
ch2 = f_10018_16547_16562(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16589,17023) || true) && (!f_10018_16594_16621(ch2))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16589,17023);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16679,16958) || true) && (character == 'u')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16679,16958);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16765,16927) || true) && (!peek)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,16765,16927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,16848,16892);

info = f_10018_16855_16891(this, start);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16765,16927);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16679,16958);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,16990,16996);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16589,17023);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,17051,17104);

intChar = (intChar << 4) + f_10018_17078_17103(ch2);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,17130,17149);

f_10018_17130_17148(                        this);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10018,1,713);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10018,1,713);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,17196,17222);

character = (char)intChar;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,16166,17241);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,14488,17256);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,17272,17289);

return character;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,14072,17300);

int
f_10018_14290_14303(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 14290, 14303);
return return_v;
}


char
f_10018_14335_14350(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14335, 14350);
return return_v;
}


int
f_10018_14365_14396(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14365, 14396);
return 0;
}


int
f_10018_14411_14429(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14411, 14429);
return 0;
}


char
f_10018_14458_14473(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14458, 14473);
return return_v;
}


int
f_10018_14580_14598(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14580, 14598);
return 0;
}


char
f_10018_14645_14660(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14645, 14660);
return return_v;
}


bool
f_10018_14622_14661(char
c)
{
var return_v = SyntaxFacts.IsHexDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14622, 14661);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_14769_14805(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
start)
{
var return_v = this_param.CreateIllegalEscapeDiagnostic( start);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14769, 14805);
return return_v;
}


char
f_10018_14999_15014(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 14999, 15014);
return return_v;
}


bool
f_10018_15046_15079(char
c)
{
var return_v = SyntaxFacts.IsHexDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15046, 15079);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_15219_15255(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
start)
{
var return_v = this_param.CreateIllegalEscapeDiagnostic( start);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15219, 15255);
return return_v;
}


int
f_10018_15416_15447(char
c)
{
var return_v = SyntaxFacts.HexValue( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15416, 15447);
return return_v;
}


int
f_10018_15475_15493(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15475, 15493);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_15690_15726(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
start)
{
var return_v = this_param.CreateIllegalEscapeDiagnostic( start);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15690, 15726);
return return_v;
}


char
f_10018_15864_15915(uint
codepoint,out char
lowSurrogate)
{
var return_v = GetCharsFromUtf32( codepoint, out lowSurrogate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 15864, 15915);
return return_v;
}


int
f_10018_16024_16074(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16024, 16074);
return 0;
}


int
f_10018_16129_16147(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16129, 16147);
return 0;
}


char
f_10018_16194_16209(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16194, 16209);
return return_v;
}


bool
f_10018_16171_16210(char
c)
{
var return_v = SyntaxFacts.IsHexDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16171, 16210);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_16318_16354(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
start)
{
var return_v = this_param.CreateIllegalEscapeDiagnostic( start);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16318, 16354);
return return_v;
}


char
f_10018_16547_16562(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16547, 16562);
return return_v;
}


bool
f_10018_16594_16621(char
c)
{
var return_v = SyntaxFacts.IsHexDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16594, 16621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_16855_16891(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
start)
{
var return_v = this_param.CreateIllegalEscapeDiagnostic( start);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 16855, 16891);
return return_v;
}


int
f_10018_17078_17103(char
c)
{
var return_v = SyntaxFacts.HexValue( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 17078, 17103);
return return_v;
}


int
f_10018_17130_17148(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 17130, 17148);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,14072,17300);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,14072,17300);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public bool TryScanXmlEntity(out char ch, out char surrogate)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,17990,21416);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18076,18113);

f_10018_18076_18112(f_10018_18089_18104(this)== '&');
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18129,18138);

ch = '&';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18152,18171);

f_10018_18152_18170(            this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18187,18216);

surrogate = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18232,21376);

switch (f_10018_18240_18255(this))
            {

case 'l':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18232,21376);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18320,18467) || true) && (f_10018_18324_18347(this, "lt;"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18320,18467);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18397,18406);

ch = '<';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18432,18444);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18320,18467);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,18489,18495);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18232,21376);

case 'g':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18232,21376);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18544,18691) || true) && (f_10018_18548_18571(this, "gt;"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18544,18691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18621,18630);

ch = '>';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18656,18668);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18544,18691);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,18713,18719);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18232,21376);

case 'a':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18232,21376);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18768,19093) || true) && (f_10018_18772_18796(this, "amp;"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18768,19093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18846,18855);

ch = '&';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18881,18893);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18768,19093);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18768,19093);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,18943,19093) || true) && (f_10018_18947_18972(this, "apos;"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18943,19093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19022,19032);

ch = '\'';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19058,19070);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18943,19093);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18768,19093);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,19115,19121);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18232,21376);

case 'q':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18232,21376);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19170,19319) || true) && (f_10018_19174_19199(this, "quot;"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19170,19319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19249,19258);

ch = '"';
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19284,19296);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19170,19319);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,19341,19347);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18232,21376);

case '#':
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,18232,21376);
                    {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19423,19442);

f_10018_19423_19441(                        this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19474,19492);

uint 
uintChar = 0
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19520,21076) || true) && (f_10018_19524_19545(this, "x"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19520,21076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19603,19614);

char 
digit
=default(char);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19644,20260) || true) && (f_10018_19651_19698(digit = f_10018_19682_19697(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19644,20260);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19764,19783);

f_10018_19764_19782(                                this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19873,20229) || true) && (uintChar <= 0x7FFFFFF)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19873,20229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,19972,20035);

uintChar = (uintChar << 4) + (uint)f_10018_20007_20034(digit);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19873,20229);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19873,20229);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20181,20194);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19873,20229);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19644,20260);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10018,19644,20260);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10018,19644,20260);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19520,21076);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,19520,21076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20374,20385);

char 
digit
=default(char);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20415,21049) || true) && (f_10018_20422_20469(digit = f_10018_20453_20468(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,20415,21049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20535,20554);

f_10018_20535_20553(                                this);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20644,21018) || true) && (uintChar <= 0x7FFFFFF)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,20644,21018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20743,20824);

uintChar = (uintChar << 3) + (uintChar << 1) + (uint)f_10018_20796_20823(digit);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,20644,21018);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,20644,21018);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,20970,20983);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,20644,21018);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,20415,21049);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10018,20415,21049);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10018,20415,21049);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10018,19520,21076);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21104,21304) || true) && (f_10018_21108_21129(this, ";"))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,21104,21304);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21187,21235);

ch = f_10018_21192_21234(uintChar, out surrogate);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21265,21277);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,21104,21304);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,21332,21338);

break;
                    }
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,18232,21376);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21392,21405);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,17990,21416);

char
f_10018_18089_18104(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18089, 18104);
return return_v;
}


int
f_10018_18076_18112(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18076, 18112);
return 0;
}


int
f_10018_18152_18170(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18152, 18170);
return 0;
}


char
f_10018_18240_18255(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18240, 18255);
return return_v;
}


bool
f_10018_18324_18347(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18324, 18347);
return return_v;
}


bool
f_10018_18548_18571(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18548, 18571);
return return_v;
}


bool
f_10018_18772_18796(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18772, 18796);
return return_v;
}


bool
f_10018_18947_18972(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 18947, 18972);
return return_v;
}


bool
f_10018_19174_19199(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19174, 19199);
return return_v;
}


int
f_10018_19423_19441(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19423, 19441);
return 0;
}


bool
f_10018_19524_19545(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19524, 19545);
return return_v;
}


char
f_10018_19682_19697(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19682, 19697);
return return_v;
}


bool
f_10018_19651_19698(char
c)
{
var return_v = SyntaxFacts.IsHexDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19651, 19698);
return return_v;
}


int
f_10018_19764_19782(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 19764, 19782);
return 0;
}


int
f_10018_20007_20034(char
c)
{
var return_v = SyntaxFacts.HexValue( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 20007, 20034);
return return_v;
}


char
f_10018_20453_20468(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.PeekChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 20453, 20468);
return return_v;
}


bool
f_10018_20422_20469(char
c)
{
var return_v = SyntaxFacts.IsDecDigit( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 20422, 20469);
return return_v;
}


int
f_10018_20535_20553(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
this_param.AdvanceChar();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 20535, 20553);
return 0;
}


int
f_10018_20796_20823(char
c)
{
var return_v = SyntaxFacts.DecValue( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 20796, 20823);
return return_v;
}


bool
f_10018_21108_21129(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,string
desired)
{
var return_v = this_param.AdvanceIfMatches( desired);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 21108, 21129);
return return_v;
}


char
f_10018_21192_21234(uint
codepoint,out char
lowSurrogate)
{
var return_v = GetCharsFromUtf32( codepoint, out lowSurrogate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 21192, 21234);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,17990,21416);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,17990,21416);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool AdvanceIfMatches(string desired)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,21622,21992);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21692,21720);

int 
length = f_10018_21705_21719(desired)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21745,21750);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21736,21919) || true) && (i < length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21764,21767)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(10018,21736,21919))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,21736,21919);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21801,21904) || true) && (f_10018_21805_21816(this, i)!= f_10018_21820_21830(desired, i))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,21801,21904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21872,21885);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,21801,21904);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10018,1,184);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10018,1,184);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21935,21955);

f_10018_21935_21954(this, length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,21969,21981);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,21622,21992);

int
f_10018_21705_21719(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 21705, 21719);
return return_v;
}


char
f_10018_21805_21816(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
delta)
{
var return_v = this_param.PeekChar( delta);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 21805, 21816);
return return_v;
}


char
f_10018_21820_21830(string
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 21820, 21830);
return return_v;
}


int
f_10018_21935_21954(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
n)
{
this_param.AdvanceChar( n);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 21935, 21954);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,21622,21992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,21622,21992);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SyntaxDiagnosticInfo CreateIllegalEscapeDiagnostic(int start)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22004,22261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22098,22250);

return f_10018_22105_22249(start - f_10018_22138_22162(this), f_10018_22181_22194(this)- start, ErrorCode.ERR_IllegalEscape);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22004,22261);

int
f_10018_22138_22162(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.LexemeStartPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 22138, 22162);
return return_v;
}


int
f_10018_22181_22194(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 22181, 22194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo
f_10018_22105_22249(int
offset,int
width,Microsoft.CodeAnalysis.CSharp.ErrorCode
code)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.SyntaxDiagnosticInfo( offset, width, code);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 22105, 22249);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22004,22261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22004,22261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string Intern(StringBuilder text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22273,22375);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22338,22364);

return f_10018_22345_22363(_strings, text);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22273,22375);

string
f_10018_22345_22363(Roslyn.Utilities.StringTable
this_param,System.Text.StringBuilder
chars)
{
var return_v = this_param.Add( chars);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 22345, 22363);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22273,22375);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22273,22375);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string Intern(char[] array, int start, int length)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22387,22522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22469,22511);

return f_10018_22476_22510(_strings, array, start, length);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22387,22522);

string
f_10018_22476_22510(Roslyn.Utilities.StringTable
this_param,char[]
chars,int
start,int
len)
{
var return_v = this_param.Add( chars, start, len);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 22476, 22510);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22387,22522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22387,22522);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string GetInternedText()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22534,22664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22590,22653);

return f_10018_22597_22652(this, _characterWindow, _lexemeStart, f_10018_22641_22651(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22534,22664);

int
f_10018_22641_22651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Width;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 22641, 22651);
return return_v;
}


string
f_10018_22597_22652(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,char[]
array,int
start,int
length)
{
var return_v = this_param.Intern( array, start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 22597, 22652);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22534,22664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22534,22664);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string GetText(bool intern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22676,22812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22735,22801);

return f_10018_22742_22800(this, f_10018_22755_22779(this), f_10018_22781_22791(this), intern);
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22676,22812);

int
f_10018_22755_22779(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.LexemeStartPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 22755, 22779);
return return_v;
}


int
f_10018_22781_22791(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param)
{
var return_v = this_param.Width;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 22781, 22791);
return return_v;
}


string
f_10018_22742_22800(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,int
position,int
length,bool
intern)
{
var return_v = this_param.GetText( position, length, intern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 22742, 22800);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22676,22812);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22676,22812);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public string GetText(int position, int length, bool intern)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10018,22824,24530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,22909,22940);

int 
offset = position - _basis
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23091,24273);

switch (length)
            {

case 0:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23091,24273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23168,23188);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23091,24273);

case 1:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23091,24273);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23237,23356) || true) && (_characterWindow[offset] == ' ')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23237,23356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23322,23333);

return " ";
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23237,23356);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23378,23499) || true) && (_characterWindow[offset] == '\n')
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23378,23499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23464,23476);

return "\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23378,23499);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,23521,23527);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23091,24273);

case 2:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23091,24273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23576,23618);

char 
firstChar = _characterWindow[offset]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23640,23788) || true) && (firstChar == '\r' &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 23644, 23701)&&_characterWindow[offset + 1] == '\n'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23640,23788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23751,23765);

return "\r\n";
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23640,23788);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23810,23954) || true) && (firstChar == '/' &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 23814, 23869)&&_characterWindow[offset + 1] == '/'))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23810,23954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,23919,23931);

return "//";
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23810,23954);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,23976,23982);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23091,24273);

case 3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,23091,24273);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24031,24230) || true) && (_characterWindow[offset] == '/' &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 24035, 24105)&&_characterWindow[offset + 1] == '/' )&&(DynAbs.Tracing.TraceSender.Expression_True(10018, 24035, 24144)&&_characterWindow[offset + 2] == ' '))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,24031,24230);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24194,24207);

return "// ";
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,24031,24230);
}
DynAbs.Tracing.TraceSender.TraceBreak(10018,24252,24258);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,23091,24273);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24289,24519) || true) && (intern)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,24289,24519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24333,24386);

return f_10018_24340_24385(this, _characterWindow, offset, length);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,24289,24519);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,24289,24519);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24452,24504);

return f_10018_24459_24503(_characterWindow, offset, length);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,24289,24519);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10018,22824,24530);

string
f_10018_24340_24385(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SlidingTextWindow
this_param,char[]
array,int
start,int
length)
{
var return_v = this_param.Intern( array, start, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 24340, 24385);
return return_v;
}


string
f_10018_24459_24503(char[]
value,int
startIndex,int
length)
{
var return_v = new string( value, startIndex, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 24459, 24503);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,22824,24530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,22824,24530);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static char GetCharsFromUtf32(uint codepoint, out char lowSurrogate)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10018,24542,25099);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24644,25088) || true) && (codepoint < (uint)0x00010000)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,24644,25088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24710,24742);

lowSurrogate = InvalidCharacter;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24760,24783);

return (char)codepoint;
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,24644,25088);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10018,24644,25088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24849,24913);

f_10018_24849_24912(codepoint > 0x0000FFFF &&(DynAbs.Tracing.TraceSender.Expression_True(10018, 24862, 24911)&&codepoint <= 0x0010FFFF));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,24931,24997);

lowSurrogate = (char)((codepoint - 0x00010000) % 0x0400 + 0xDC00);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,25015,25073);

return (char)((codepoint - 0x00010000) / 0x0400 + 0xD800);
DynAbs.Tracing.TraceSender.TraceExitCondition(10018,24644,25088);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10018,24542,25099);

int
f_10018_24849_24912(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 24849, 24912);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10018,24542,25099);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,24542,25099);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SlidingTextWindow()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10018,1063,25106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,1973,2005);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,2036,2062);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10018,3290,3364);
s_windowPool = f_10018_3305_3364(() => new char[DefaultWindowLength]);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10018,1063,25106);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10018,1063,25106);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10018,1063,25106);

static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
f_10018_3305_3364(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>.Factory
factory)
{
var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>( factory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 3305, 3364);
return return_v;
}


int
f_10018_3532_3543(Microsoft.CodeAnalysis.Text.SourceText
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10018, 3532, 3543);
return return_v;
}


Roslyn.Utilities.StringTable
f_10018_3569_3594()
{
var return_v = StringTable.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 3569, 3594);
return return_v;
}


char[]
f_10018_3628_3651(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
this_param)
{
var return_v = this_param.Allocate();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10018, 3628, 3651);
return return_v;
}

}
}
