// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

// #define COLLECT_STATS

using System;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
internal partial class LexerCache
{
private static readonly ObjectPool<CachingIdentityFactory<string, SyntaxKind>> s_keywordKindPool ;

private readonly TextKeyedCache<SyntaxTrivia> _triviaMap;

private readonly TextKeyedCache<SyntaxToken> _tokenMap;

private readonly CachingIdentityFactory<string, SyntaxKind> _keywordKindMap;

internal const int 
MaxKeywordLength = 10
;

internal LexerCache()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10027,1540,1782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1315,1325);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1381,1390);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1461,1476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1586,1642);

_triviaMap = f_10027_1599_1641();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1656,1710);

_tokenMap = f_10027_1668_1709();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1724,1771);

_keywordKindMap = f_10027_1742_1770(s_keywordKindPool);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10027,1540,1782);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10027,1540,1782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,1540,1782);
}
		}

internal void Free()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10027,1794,1936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1839,1862);

f_10027_1839_1861(            _keywordKindMap);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1876,1894);

f_10027_1876_1893(            _triviaMap);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1908,1925);

f_10027_1908_1924(            _tokenMap);
DynAbs.Tracing.TraceSender.TraceExitMethod(10027,1794,1936);

int
f_10027_1839_1861(Microsoft.CodeAnalysis.CachingIdentityFactory<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1839, 1861);
return 0;
}


int
f_10027_1876_1893(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1876, 1893);
return 0;
}


int
f_10027_1908_1924(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1908, 1924);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10027,1794,1936);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,1794,1936);
}
		}

internal bool TryGetKeywordKind(string key, out SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10027,1948,2288);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2037,2173) || true) && (f_10027_2041_2051(key)> MaxKeywordLength)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10027,2037,2173);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2104,2127);

kind = SyntaxKind.None;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2145,2158);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10027,2037,2173);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2189,2232);

kind = f_10027_2196_2231(_keywordKindMap, key);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2246,2277);

return kind != SyntaxKind.None;
DynAbs.Tracing.TraceSender.TraceExitMethod(10027,1948,2288);

int
f_10027_2041_2051(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10027, 2041, 2051);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10027_2196_2231(Microsoft.CodeAnalysis.CachingIdentityFactory<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>
this_param,string
key)
{
var return_v = this_param.GetOrMakeValue( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 2196, 2231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10027,1948,2288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,1948,2288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal SyntaxTrivia LookupTrivia(
            char[] textBuffer,
            int keyStart,
            int keyLength,
            int hashCode,
            Func<SyntaxTrivia> createTriviaFunction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10027,2300,2843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2528,2603);

var 
value = f_10027_2540_2602(_triviaMap, textBuffer, keyStart, keyLength, hashCode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2619,2803) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10027,2619,2803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2670,2701);

value = f_10027_2678_2700(createTriviaFunction);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2719,2788);

f_10027_2719_2787(                _triviaMap, textBuffer, keyStart, keyLength, hashCode, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(10027,2619,2803);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,2819,2832);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(10027,2300,2843);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia?
f_10027_2540_2602(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>
this_param,char[]
chars,int
start,int
len,int
hashCode)
{
var return_v = this_param.FindItem( chars, start, len, hashCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 2540, 2602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
f_10027_2678_2700(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 2678, 2700);
return return_v;
}


int
f_10027_2719_2787(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>
this_param,char[]
chars,int
start,int
len,int
hashCode,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
item)
{
this_param.AddItem( chars, start, len, hashCode, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 2719, 2787);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10027,2300,2843);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,2300,2843);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal SyntaxToken LookupToken(
            char[] textBuffer,
            int keyStart,
            int keyLength,
            int hashCode,
            Func<SyntaxToken> createTokenFunction)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10027,3405,4100);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,3629,3703);

var 
value = f_10027_3641_3702(_tokenMap, textBuffer, keyStart, keyLength, hashCode)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,3719,4060) || true) && (value == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10027,3719,4060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,3826,3856);

value = f_10027_3834_3855(createTokenFunction);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,3874,3942);

f_10027_3874_3941(                _tokenMap, textBuffer, keyStart, keyLength, hashCode, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(10027,3719,4060);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10027,3719,4060);
DynAbs.Tracing.TraceSender.TraceExitCondition(10027,3719,4060);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,4076,4089);

return value;
DynAbs.Tracing.TraceSender.TraceExitMethod(10027,3405,4100);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken?
f_10027_3641_3702(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
this_param,char[]
chars,int
start,int
len,int
hashCode)
{
var return_v = this_param.FindItem( chars, start, len, hashCode);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 3641, 3702);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10027_3834_3855(System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
this_param)
{
var return_v = this_param.Invoke();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 3834, 3855);
return return_v;
}


int
f_10027_3874_3941(Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
this_param,char[]
chars,int
start,int
len,int
hashCode,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
item)
{
this_param.AddItem( chars, start, len, hashCode, item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 3874, 3941);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10027,3405,4100);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,3405,4100);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static LexerCache()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10027,561,4107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,690,1256);
s_keywordKindPool = f_10027_723_1256(512, (key) =>
                            {
                                var kind = SyntaxFacts.GetKeywordKind(key);
                                if (kind == SyntaxKind.None)
                                {
                                    kind = SyntaxFacts.GetContextualKeywordKind(key);
                                }

                                return kind;
                            });DynAbs.Tracing.TraceSender.TraceSimpleStatement(10027,1506,1527);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10027,561,4107);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10027,561,4107);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10027,561,4107);

static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CachingIdentityFactory<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>>
f_10027_723_1256(int
size,System.Func<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>
valueFactory)
{
var return_v = CachingIdentityFactory<string, SyntaxKind>.CreatePool( size, valueFactory);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 723, 1256);
return return_v;
}


Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia>
f_10027_1599_1641()
{
var return_v = TextKeyedCache<SyntaxTrivia>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1599, 1641);
return return_v;
}


Roslyn.Utilities.TextKeyedCache<Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken>
f_10027_1668_1709()
{
var return_v = TextKeyedCache<SyntaxToken>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1668, 1709);
return return_v;
}


Microsoft.CodeAnalysis.CachingIdentityFactory<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>
f_10027_1742_1770(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CachingIdentityFactory<string, Microsoft.CodeAnalysis.CSharp.SyntaxKind>>
this_param)
{
var return_v = this_param.Allocate();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10027, 1742, 1770);
return return_v;
}

}
}
