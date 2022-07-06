// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.Diagnostics;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public abstract class TrackingDiagnosticAnalyzer<TLanguageKindEnum> : TestDiagnosticAnalyzer<TLanguageKindEnum> where TLanguageKindEnum : struct
{public class Entry
{
public readonly string AbstractMemberName;

public readonly string CallerName;

public readonly TLanguageKindEnum SyntaxKind;

public readonly SymbolKind? SymbolKind;

public readonly MethodKind? MethodKind;

public readonly bool ReturnsVoid;

public Entry(string abstractMemberName, string callerName, SyntaxNode node, ISymbol symbol)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25083,1169,1807);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,874,892);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,930,940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,989,999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1042,1052);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1095,1105);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1141,1152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1293,1333);

AbstractMemberName = abstractMemberName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1351,1375);

CallerName = callerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1393,1498);

SyntaxKind = (DynAbs.Tracing.TraceSender.Conditional_F1(25083, 1406, 1418)||((node == null &&DynAbs.Tracing.TraceSender.Conditional_F2(25083, 1421, 1447))||DynAbs.Tracing.TraceSender.Conditional_F3(25083, 1450, 1497)))?default(TLanguageKindEnum) :(TLanguageKindEnum)(object)(ushort)f_25083_1485_1497(node);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1516,1578);

SymbolKind = (DynAbs.Tracing.TraceSender.Conditional_F1(25083, 1529, 1543)||((symbol == null &&DynAbs.Tracing.TraceSender.Conditional_F2(25083, 1546, 1563))||DynAbs.Tracing.TraceSender.Conditional_F3(25083, 1566, 1577)))?(SymbolKind?)null :f_25083_1566_1577(symbol);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1596,1690);

MethodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(25083, 1609, 1632)||((symbol is IMethodSymbol &&DynAbs.Tracing.TraceSender.Conditional_F2(25083, 1635, 1669))||DynAbs.Tracing.TraceSender.Conditional_F3(25083, 1672, 1689)))?f_25083_1635_1669(((IMethodSymbol)symbol)):(MethodKind?)null;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1708,1792);

ReturnsVoid = (DynAbs.Tracing.TraceSender.Conditional_F1(25083, 1722, 1745)||((symbol is IMethodSymbol &&DynAbs.Tracing.TraceSender.Conditional_F2(25083, 1748, 1783))||DynAbs.Tracing.TraceSender.Conditional_F3(25083, 1786, 1791)))?f_25083_1748_1783(((IMethodSymbol)symbol)):false;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25083,1169,1807);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,1169,1807);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,1169,1807);
}
		}

public override string ToString()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,1823,1990);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,1889,1975);

return CallerName + "(" + f_25083_1915_1968(", ", SymbolKind, MethodKind, SyntaxKind)+ ")";
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,1823,1990);

string
f_25083_1915_1968(string
separator,params object?[]
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 1915, 1968);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,1823,1990);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,1823,1990);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static Entry()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25083,808,2001);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25083,808,2001);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,808,2001);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25083,808,2001);

static int
f_25083_1485_1497(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.RawKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 1485, 1497);
return return_v;
}


static Microsoft.CodeAnalysis.SymbolKind
f_25083_1566_1577(Microsoft.CodeAnalysis.ISymbol
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 1566, 1577);
return return_v;
}


static Microsoft.CodeAnalysis.MethodKind
f_25083_1635_1669(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.MethodKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 1635, 1669);
return return_v;
}


static bool
f_25083_1748_1783(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.ReturnsVoid ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 1748, 1783);
return return_v;
}

}

private readonly ConcurrentQueue<Entry> _callLog ;

protected override void OnAbstractMember(string abstractMemberName, SyntaxNode node, ISymbol symbol, string callerName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,2105,2334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,2249,2323);

f_25083_2249_2322(            _callLog, f_25083_2266_2321(abstractMemberName, callerName, node, symbol));
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,2105,2334);

Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry
f_25083_2266_2321(string
abstractMemberName,string
callerName,Microsoft.CodeAnalysis.SyntaxNode
node,Microsoft.CodeAnalysis.ISymbol
symbol)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry( abstractMemberName, callerName, node, symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 2266, 2321);
return return_v;
}


int
f_25083_2249_2322(System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry>
this_param,Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry
item)
{
this_param.Enqueue( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 2249, 2322);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,2105,2334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,2105,2334);
}
		}

public IEnumerable<Entry> CallLog
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,2404,2428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,2410,2426);

return _callLog;
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,2404,2428);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,2346,2439);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,2346,2439);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

private static readonly Regex s_omittedSyntaxKindRegex ;

private bool FilterByAbstractName(Entry entry, string abstractMemberName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,2800,2963);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,2898,2952);

return abstractMemberName == entry.AbstractMemberName;
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,2800,2963);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,2800,2963);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,2800,2963);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        public void VerifyAllAnalyzerMembersWereCalled()
        {
            var actualMembers = _callLog.Select(e => e.CallerName).Distinct();
            AssertSequenceEqual(AllAnalyzerMemberNames, actualMembers);
        }

        public void VerifyAnalyzeSymbolCalledForAllSymbolKinds()
        {
            var expectedSymbolKinds = new[]
            {
                SymbolKind.Event, SymbolKind.Field, SymbolKind.Method, SymbolKind.NamedType, SymbolKind.Namespace, SymbolKind.Parameter, SymbolKind.Property
            };

            var actualSymbolKinds = _callLog.Where(a => FilterByAbstractName(a, "Symbol")).Where(e => e.SymbolKind.HasValue).Select(e => e.SymbolKind.Value).Distinct();
            AssertSequenceEqual(expectedSymbolKinds, actualSymbolKinds);
        }

        protected virtual bool IsAnalyzeNodeSupported(TLanguageKindEnum syntaxKind)
        {
            return !s_omittedSyntaxKindRegex.IsMatch(syntaxKind.ToString());
        }

        public void VerifyAnalyzeNodeCalledForAllSyntaxKinds(HashSet<TLanguageKindEnum> expectedMissingSyntaxKinds)
        {
            var expectedSyntaxKinds = AllSyntaxKinds.Where(IsAnalyzeNodeSupported);
            var actualSyntaxKinds = new HashSet<TLanguageKindEnum>(_callLog.Where(a => FilterByAbstractName(a, "SyntaxNode")).Select(e => e.SyntaxKind));
            var savedSyntaxKindsPatterns = new HashSet<TLanguageKindEnum>(expectedMissingSyntaxKinds);
            expectedMissingSyntaxKinds.IntersectWith(actualSyntaxKinds);
            Assert.True(expectedMissingSyntaxKinds.Count == 0, "AllInOne test contains ignored SyntaxKinds: " + string.Join(", ", expectedMissingSyntaxKinds));
            actualSyntaxKinds.UnionWith(savedSyntaxKindsPatterns);
            AssertIsSuperset(expectedSyntaxKinds, actualSyntaxKinds);
        }

protected virtual bool IsOnCodeBlockSupported(SymbolKind symbolKind, MethodKind methodKind, bool returnsVoid)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,4826,4983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,4960,4972);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,4826,4983);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,4826,4983);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,4826,4983);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        public void VerifyOnCodeBlockCalledForAllSymbolAndMethodKinds(HashSet<SymbolKind> symbolKindsWithNoCodeBlocks = null, bool allowUnexpectedCalls = false)
        {
            const MethodKind InvalidMethodKind = (MethodKind)(-1);
            var expectedArguments = new[]
            {
                new { SymbolKind = SymbolKind.Event,  MethodKind = InvalidMethodKind, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Field,  MethodKind = InvalidMethodKind, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.Constructor, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.Conversion, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.Destructor, ReturnsVoid = true }, // C# only
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.EventAdd, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.EventRemove, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.EventRaise, ReturnsVoid = true }, // VB only
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.ExplicitInterfaceImplementation, ReturnsVoid = true }, // C# only
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.Ordinary, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.Ordinary, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.PropertyGet, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.PropertySet, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.StaticConstructor, ReturnsVoid = true },
                new { SymbolKind = SymbolKind.Method, MethodKind = MethodKind.UserDefinedOperator, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Property, MethodKind = InvalidMethodKind, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.NamedType, MethodKind = InvalidMethodKind, ReturnsVoid = false },
                new { SymbolKind = SymbolKind.Namespace, MethodKind = InvalidMethodKind, ReturnsVoid = false }
            }.AsEnumerable();

            if (symbolKindsWithNoCodeBlocks != null)
            {
                expectedArguments = expectedArguments.Where(a => !symbolKindsWithNoCodeBlocks.Contains(a.SymbolKind));
            }

            expectedArguments = expectedArguments.Where(a => IsOnCodeBlockSupported(a.SymbolKind, a.MethodKind, a.ReturnsVoid));

            var actualOnCodeBlockStartedArguments = _callLog.Where(a => FilterByAbstractName(a, "CodeBlockStart"))
                .Select(e => new { SymbolKind = e.SymbolKind.Value, MethodKind = e.MethodKind ?? InvalidMethodKind, e.ReturnsVoid }).Distinct();
            var actualOnCodeBlockEndedArguments = _callLog.Where(a => FilterByAbstractName(a, "CodeBlock"))
                .Select(e => new { SymbolKind = e.SymbolKind.Value, MethodKind = e.MethodKind ?? InvalidMethodKind, e.ReturnsVoid }).Distinct();

            if (!allowUnexpectedCalls)
            {
                AssertSequenceEqual(expectedArguments, actualOnCodeBlockStartedArguments, items => items.OrderBy(p => p.SymbolKind).ThenBy(p => p.MethodKind).ThenBy(p => p.ReturnsVoid));
                AssertSequenceEqual(expectedArguments, actualOnCodeBlockEndedArguments, items => items.OrderBy(p => p.SymbolKind).ThenBy(p => p.MethodKind).ThenBy(p => p.ReturnsVoid));
            }
            else
            {
                AssertIsSuperset(expectedArguments, actualOnCodeBlockStartedArguments);
                AssertIsSuperset(expectedArguments, actualOnCodeBlockEndedArguments);
            }
        }

private void AssertSequenceEqual<T>(IEnumerable<T> expected, IEnumerable<T> actual, Func<IEnumerable<T>, IOrderedEnumerable<T>> sorter = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,8963,9543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9130,9229);

sorter = sorter ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Func<System.Collections.Generic.IEnumerable<T>, System.Linq.IOrderedEnumerable<T>>?>(25083, 9139, 9228)??new Func<IEnumerable<T>, IOrderedEnumerable<T>>(items => items.OrderBy(i => i)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9243,9271);

expected = f_25083_9254_9270(sorter, expected);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9285,9309);

actual = f_25083_9294_9308(sorter, actual);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9323,9532);

f_25083_9323_9531(f_25083_9335_9365(expected, actual), f_25083_9384_9403()+ "Expected: " + f_25083_9421_9448(", ", expected)+
f_25083_9468_9487()+ "Actual:   " + f_25083_9505_9530(", ", actual));
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,8963,9543);

System.Linq.IOrderedEnumerable<T>
f_25083_9254_9270(System.Func<System.Collections.Generic.IEnumerable<T>, System.Linq.IOrderedEnumerable<T>>
this_param,System.Collections.Generic.IEnumerable<T>
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9254, 9270);
return return_v;
}


System.Linq.IOrderedEnumerable<T>
f_25083_9294_9308(System.Func<System.Collections.Generic.IEnumerable<T>, System.Linq.IOrderedEnumerable<T>>
this_param,System.Collections.Generic.IEnumerable<T>
arg)
{
var return_v = this_param.Invoke( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9294, 9308);
return return_v;
}


bool
f_25083_9335_9365(System.Collections.Generic.IEnumerable<T>
first,System.Collections.Generic.IEnumerable<T>
second)
{
var return_v = first.SequenceEqual<T>( second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9335, 9365);
return return_v;
}


string
f_25083_9384_9403()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 9384, 9403);
return return_v;
}


string
f_25083_9421_9448(string
separator,System.Collections.Generic.IEnumerable<T>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9421, 9448);
return return_v;
}


string
f_25083_9468_9487()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 9468, 9487);
return return_v;
}


string
f_25083_9505_9530(string
separator,System.Collections.Generic.IEnumerable<T>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9505, 9530);
return return_v;
}


int
f_25083_9323_9531(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9323, 9531);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,8963,9543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,8963,9543);
}
		}

private void AssertIsSuperset<T>(IEnumerable<T> expectedSubset, IEnumerable<T> actualSuperset)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25083,9555,10199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9674,9880);

var 
missingElements = f_25083_9696_9879(f_25083_9696_9870(f_25083_9696_9847(f_25083_9696_9805(expectedSubset, actualSuperset, e => e, a => a, (e, a) => new { Element = e, IsMissing = !a.Any() }), p => p.IsMissing), p => p.Element))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9894,9955);

var 
presentElements = f_25083_9916_9954(expectedSubset, missingElements)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,9969,10188);

f_25083_9969_10187(f_25083_9981_10002(missingElements)== 0, f_25083_10026_10045()+ "Missing: " + f_25083_10062_10096(", ", missingElements)+
f_25083_10116_10135()+ "Present: " + f_25083_10152_10186(", ", presentElements));
DynAbs.Tracing.TraceSender.TraceExitMethod(25083,9555,10199);

System.Collections.Generic.IEnumerable<dynamic>
f_25083_9696_9805(System.Collections.Generic.IEnumerable<T>
outer,System.Collections.Generic.IEnumerable<T>
inner,System.Func<T, T>
outerKeySelector,System.Func<T, T>
innerKeySelector,System.Func<T, System.Collections.Generic.IEnumerable<T>, dynamic>
resultSelector)
{
var return_v = outer.GroupJoin<T,T,T,dynamic>( inner, outerKeySelector, innerKeySelector, resultSelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9696, 9805);
return return_v;
}


System.Collections.Generic.IEnumerable<dynamic>
f_25083_9696_9847(System.Collections.Generic.IEnumerable<dynamic>
source,System.Func<dynamic, bool>
predicate)
{
var return_v = source.Where<dynamic>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9696, 9847);
return return_v;
}


System.Collections.Generic.IEnumerable<T>
f_25083_9696_9870(System.Collections.Generic.IEnumerable<dynamic>
source,System.Func<dynamic, T>
selector)
{
var return_v = source.Select<dynamic,T>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9696, 9870);
return return_v;
}


System.Collections.Generic.List<T>
f_25083_9696_9879(System.Collections.Generic.IEnumerable<T>
source)
{
var return_v = source.ToList<T>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9696, 9879);
return return_v;
}


System.Collections.Generic.IEnumerable<T>
f_25083_9916_9954(System.Collections.Generic.IEnumerable<T>
first,System.Collections.Generic.List<T>
second)
{
var return_v = first.Except<T>( (System.Collections.Generic.IEnumerable<T>)second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9916, 9954);
return return_v;
}


int
f_25083_9981_10002(System.Collections.Generic.List<T>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 9981, 10002);
return return_v;
}


string
f_25083_10026_10045()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 10026, 10045);
return return_v;
}


string
f_25083_10062_10096(string
separator,System.Collections.Generic.List<T>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<T>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 10062, 10096);
return return_v;
}


string
f_25083_10116_10135()
{
var return_v =                 Environment.NewLine ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25083, 10116, 10135);
return return_v;
}


string
f_25083_10152_10186(string
separator,System.Collections.Generic.IEnumerable<T>
values)
{
var return_v = string.Join( separator, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 10152, 10186);
return return_v;
}


int
f_25083_9969_10187(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 9969, 10187);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25083,9555,10199);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,9555,10199);
}
		}

public TrackingDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25083,619,10228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,2053,2092);
this._callLog = f_25083_2064_2092();DynAbs.Tracing.TraceSender.TraceExitConstructor(25083,619,10228);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,619,10228);
}


static TrackingDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25083,619,10228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25083,2531,2787);
s_omittedSyntaxKindRegex = f_25083_2571_2787(@"None|Trivia|Token|Keyword|List|Xml|Cref|Compilation|Namespace|Class|Struct|Enum|Interface|Delegate|Field|Property|Indexer|Event|Operator|Constructor|Access|Incomplete|Attribute|Filter|InterpolatedString");DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25083,619,10228);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25083,619,10228);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25083,619,10228);

System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry>
f_25083_2064_2092()
{
var return_v = new System.Collections.Concurrent.ConcurrentQueue<Microsoft.CodeAnalysis.Test.Utilities.TrackingDiagnosticAnalyzer<TLanguageKindEnum>.Entry>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 2064, 2092);
return return_v;
}


static System.Text.RegularExpressions.Regex
f_25083_2571_2787(string
pattern)
{
var return_v = new System.Text.RegularExpressions.Regex( pattern);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25083, 2571, 2787);
return return_v;
}

}
}
