// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
internal static class SymbolInfoFactory
{
internal static SymbolInfo Create(ImmutableArray<Symbol> symbols, LookupResultKind resultKind, bool isDynamic)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10929,505,1634);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,640,1623) || true) && (isDynamic)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,640,1623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,687,1009) || true) && (symbols.Length == 1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,687,1009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,752,831);

return f_10929_759_830(f_10929_774_802(symbols[0]), CandidateReason.LateBound);
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,687,1009);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,687,1009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,913,990);

return f_10929_920_989(symbols.GetPublicSymbols(), CandidateReason.LateBound);
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,687,1009);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,640,1623);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,640,1623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1043,1623) || true) && (resultKind == LookupResultKind.Viable)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,1043,1623);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1118,1414) || true) && (symbols.Length > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,1118,1414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1182,1216);

f_10929_1182_1215(symbols.Length == 1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1238,1290);

return f_10929_1245_1289(f_10929_1260_1288(symbols[0]));
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,1118,1414);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,1118,1414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1372,1395);

return SymbolInfo.None;
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,1118,1414);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,1043,1623);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10929,1043,1623);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10929,1480,1608);

return f_10929_1487_1607(symbols.GetPublicSymbols(), (DynAbs.Tracing.TraceSender.Conditional_F1(10929, 1530, 1550)||(((symbols.Length > 0) &&DynAbs.Tracing.TraceSender.Conditional_F2(10929, 1553, 1583))||DynAbs.Tracing.TraceSender.Conditional_F3(10929, 1586, 1606)))?f_10929_1553_1583(resultKind):CandidateReason.None);
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,1043,1623);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10929,640,1623);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10929,505,1634);

Microsoft.CodeAnalysis.ISymbol?
f_10929_774_802(Microsoft.CodeAnalysis.CSharp.Symbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 774, 802);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10929_759_830(Microsoft.CodeAnalysis.ISymbol
symbol,Microsoft.CodeAnalysis.CandidateReason
reason)
{
var return_v = new Microsoft.CodeAnalysis.SymbolInfo( symbol, reason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 759, 830);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10929_920_989(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
candidateSymbols,Microsoft.CodeAnalysis.CandidateReason
candidateReason)
{
var return_v = new Microsoft.CodeAnalysis.SymbolInfo( candidateSymbols, candidateReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 920, 989);
return return_v;
}


int
f_10929_1182_1215(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 1182, 1215);
return 0;
}


Microsoft.CodeAnalysis.ISymbol?
f_10929_1260_1288(Microsoft.CodeAnalysis.CSharp.Symbol
symbol)
{
var return_v = symbol.GetPublicSymbol();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 1260, 1288);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10929_1245_1289(Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = new Microsoft.CodeAnalysis.SymbolInfo( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 1245, 1289);
return return_v;
}


Microsoft.CodeAnalysis.CandidateReason
f_10929_1553_1583(Microsoft.CodeAnalysis.CSharp.LookupResultKind
resultKind)
{
var return_v = resultKind.ToCandidateReason();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 1553, 1583);
return return_v;
}


Microsoft.CodeAnalysis.SymbolInfo
f_10929_1487_1607(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
candidateSymbols,Microsoft.CodeAnalysis.CandidateReason
candidateReason)
{
var return_v = new Microsoft.CodeAnalysis.SymbolInfo( candidateSymbols, candidateReason);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10929, 1487, 1607);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10929,505,1634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10929,505,1634);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SymbolInfoFactory()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10929,449,1641);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10929,449,1641);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10929,449,1641);
}

}
}
