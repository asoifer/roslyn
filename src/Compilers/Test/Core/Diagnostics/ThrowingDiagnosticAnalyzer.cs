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
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class ThrowingDiagnosticAnalyzer<TLanguageKindEnum> : TestDiagnosticAnalyzer<TLanguageKindEnum> where TLanguageKindEnum : struct
{[Serializable]
        public class DeliberateException : Exception
{
public DeliberateException()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25082,929,987);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25082,929,987);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,929,987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,929,987);
}
		}

protected DeliberateException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25082,1003,1188);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1137,1173);

throw f_25082_1143_1172();
DynAbs.Tracing.TraceSender.TraceExitConstructor(25082,1003,1188);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,1003,1188);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,1003,1188);
}
		}

public override string Message
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25082,1267,1369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1273,1367);

return "If this goes unhandled, our diagnostics engine is susceptible to malicious analyzers";
DynAbs.Tracing.TraceSender.TraceExitMethod(25082,1267,1369);
}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,1204,1384);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,1204,1384);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

static DeliberateException()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25082,836,1395);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25082,836,1395);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,836,1395);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25082,836,1395);

static System.NotImplementedException
f_25082_1143_1172()
{
var return_v = new System.NotImplementedException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 1143, 1172);
return return_v;
}

}

private readonly List<string> _throwOnList ;

public bool Thrown {get; private set; }

public void ThrowOn(string method)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25082,1535,1630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1594,1619);

f_25082_1594_1618(            _throwOnList, method);
DynAbs.Tracing.TraceSender.TraceExitMethod(25082,1535,1630);

int
f_25082_1594_1618(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 1594, 1618);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,1535,1630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,1535,1630);
}
		}

protected override void OnAbstractMember(string abstractMemberName, SyntaxNode node, ISymbol symbol, string methodName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25082,1642,1947);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1786,1936) || true) && (f_25082_1790_1823(_throwOnList, methodName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25082,1786,1936);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1857,1871);

Thrown = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1889,1921);

throw f_25082_1895_1920();
DynAbs.Tracing.TraceSender.TraceExitCondition(25082,1786,1936);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25082,1642,1947);

bool
f_25082_1790_1823(System.Collections.Generic.List<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 1790, 1823);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.ThrowingDiagnosticAnalyzer<TLanguageKindEnum>.DeliberateException
f_25082_1895_1920()
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.ThrowingDiagnosticAnalyzer<TLanguageKindEnum>.DeliberateException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 1895, 1920);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,1642,1947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,1642,1947);
}
		}

public static void VerifyAnalyzerEngineIsSafeAgainstExceptions(Func<DiagnosticAnalyzer, IEnumerable<Diagnostic>> runAnalysis)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25082,1959,2189);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,2109,2178);

f_25082_2109_2177(f_25082_2109_2170(runAnalysis));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25082,1959,2189);

System.Threading.Tasks.Task
f_25082_2109_2170(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>>
runAnalysis)
{
var return_v = VerifyAnalyzerEngineIsSafeAgainstExceptionsAsync( runAnalysis);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 2109, 2170);
return return_v;
}


int
f_25082_2109_2177(System.Threading.Tasks.Task
this_param)
{
this_param.Wait();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 2109, 2177);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,1959,2189);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,1959,2189);
}
		}

public static async Task VerifyAnalyzerEngineIsSafeAgainstExceptionsAsync(Func<DiagnosticAnalyzer, IEnumerable<Diagnostic>> runAnalysis)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25082,2201,2466);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,2362,2455);

await f_25082_2368_2454(a => Task.FromResult(runAnalysis(a)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25082,2201,2466);

System.Threading.Tasks.Task
f_25082_2368_2454(System.Func<Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>>>
runAnalysis)
{
var return_v = VerifyAnalyzerEngineIsSafeAgainstExceptionsAsync( runAnalysis);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 2368, 2454);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25082,2201,2466);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,2201,2466);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

        public static async Task VerifyAnalyzerEngineIsSafeAgainstExceptionsAsync(Func<DiagnosticAnalyzer, Task<IEnumerable<Diagnostic>>> runAnalysis)
        {
            var handled = new bool?[AllAnalyzerMemberNames.Length];
            for (int i = 0; i < AllAnalyzerMemberNames.Length; i++)
            {
                var member = AllAnalyzerMemberNames[i];
                var analyzer = new ThrowingDiagnosticAnalyzer<TLanguageKindEnum>();
                analyzer.ThrowOn(member);
                try
                {
                    var diagnostics = (await runAnalysis(analyzer)).Distinct();
                    handled[i] = analyzer.Thrown ? true : (bool?)null;
                    if (analyzer.Thrown)
                    {
                        Assert.True(diagnostics.Any(AnalyzerExecutor.IsAnalyzerExceptionDiagnostic));
                    }
                    else
                    {
                        Assert.False(diagnostics.Any(AnalyzerExecutor.IsAnalyzerExceptionDiagnostic));
                    }
                }
                catch (DeliberateException)
                {
                    handled[i] = false;
                }
            }

            var membersHandled = AllAnalyzerMemberNames.Zip(handled, (m, h) => new { Member = m, Handled = h });
            Assert.True(!handled.Any(h => h == false) && handled.Any(h => true), Environment.NewLine +
                "  Exceptions thrown by analyzers in these members were *NOT* handled:" + Environment.NewLine + string.Join(Environment.NewLine, membersHandled.Where(mh => mh.Handled == false).Select(mh => mh.Member)) + Environment.NewLine + Environment.NewLine +
                "  Exceptions thrown from these members were handled gracefully:" + Environment.NewLine + string.Join(Environment.NewLine, membersHandled.Where(mh => mh.Handled == true).Select(mh => mh.Member)) + Environment.NewLine + Environment.NewLine +
                "  These members were not called/accessed by analyzer engine:" + Environment.NewLine + string.Join(Environment.NewLine, membersHandled.Where(mh => mh.Handled == null).Select(mh => mh.Member)));
        }

public ThrowingDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25082,684,4659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1437,1470);
this._throwOnList = f_25082_1452_1470();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25082,1483,1523);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25082,684,4659);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,684,4659);
}


static ThrowingDiagnosticAnalyzer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25082,684,4659);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25082,684,4659);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25082,684,4659);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25082,684,4659);

System.Collections.Generic.List<string>
f_25082_1452_1470()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25082, 1452, 1470);
return return_v;
}

}
}
