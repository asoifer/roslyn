// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
internal sealed class CSharpInstrumentationChecker : BaseInstrumentationChecker
{
public string ExpectedOutput {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,1442,1489);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1448,1487);

return f_25035_1455_1486(_consoleExpectations);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,1442,1489);

string
f_25035_1455_1486(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 1455, 1486);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,1411,1491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,1411,1491);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override void AddConsoleExpectation(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,1503,1634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1585,1623);

f_25035_1585_1622(            _consoleExpectations, text);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,1503,1634);

System.Text.StringBuilder
f_25035_1585_1622(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 1585, 1622);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,1503,1634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,1503,1634);
}
		}

internal override void Dump(DynamicAnalysisDataReader reader, string[] sourceLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,1646,3245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1754,1801);

var 
output = f_25035_1767_1800()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1815,1896);

f_25035_1815_1895(            output.Builder, "Template code for checking instrumentation results:");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1921,1931);

            for (int 
method = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1912,3180) || true) && (method <= reader.Methods.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,1966,1974)
,method++,DynAbs.Tracing.TraceSender.TraceExitCondition(25035,1912,3180))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,1912,3180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2008,2070);

var 
snippets = f_25035_2023_2069(method, reader, sourceLines)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2088,2182) || true) && (snippets.Length == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2088,2182);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2154,2163);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2088,2182);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2202,2264);

string 
methodTermination = f_25035_2229_2263(0, snippets.Length)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2282,2621) || true) && (snippets[0] == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2282,2621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2347,2424);

f_25035_2347_2423(                    output.Builder, $"checker.Method({method}, 1){methodTermination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2282,2621);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2282,2621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2506,2602);

f_25035_2506_2601(                    output.Builder, $"checker.Method({method}, 1, \"{snippets[0]}\"){methodTermination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2282,2621);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2650,2659);

                for (int 
index = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2641,3165) || true) && (index < snippets.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2686,2693)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2641,3165))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2641,3165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2735,2795);

string 
termination = f_25035_2756_2794(index, snippets.Length)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2817,3146) || true) && (snippets[index] == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2817,3146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,2894,2949);

f_25035_2894_2948(                        output.Builder, $"    .True(){termination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2817,3146);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,2817,3146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,3047,3123);

f_25035_3047_3122(                        output.Builder, $"    .True(\"{snippets[index]}\"){termination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,2817,3146);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25035,1,525);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25035,1,525);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25035,1,1269);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25035,1,1269);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,3194,3234);

f_25035_3194_3233(f_25035_3208_3232(output));
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,1646,3245);

Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
f_25035_1767_1800()
{
var return_v = PooledStringBuilder.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 1767, 1800);
return return_v;
}


System.Text.StringBuilder
f_25035_1815_1895(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 1815, 1895);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_25035_2023_2069(int
method,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,string[]
sourceLines)
{
var return_v = GetActualSnippets( method, reader, sourceLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2023, 2069);
return return_v;
}


string
f_25035_2229_2263(int
index,int
length)
{
var return_v = GetTermination( index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2229, 2263);
return return_v;
}


System.Text.StringBuilder
f_25035_2347_2423(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2347, 2423);
return return_v;
}


System.Text.StringBuilder
f_25035_2506_2601(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2506, 2601);
return return_v;
}


string
f_25035_2756_2794(int
index,int
length)
{
var return_v = GetTermination( index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2756, 2794);
return return_v;
}


System.Text.StringBuilder
f_25035_2894_2948(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 2894, 2948);
return return_v;
}


System.Text.StringBuilder
f_25035_3047_3122(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 3047, 3122);
return return_v;
}


string
f_25035_3208_3232(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
this_param)
{
var return_v = this_param.ToStringAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 3208, 3232);
return return_v;
}


int
f_25035_3194_3233(string
message)
{
AssertEx.Fail( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 3194, 3233);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,1646,3245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,1646,3245);
}
		}

private static string GetTermination(int index, int length)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25035,3257,3392);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,3341,3381);

return (DynAbs.Tracing.TraceSender.Conditional_F1(25035, 3348, 3369)||(((index == length - 1) &&DynAbs.Tracing.TraceSender.Conditional_F2(25035, 3372, 3375))||DynAbs.Tracing.TraceSender.Conditional_F3(25035, 3378, 3380)))?";" :"";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25035,3257,3392);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,3257,3392);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,3257,3392);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public const string 
InstrumentationHelperSource = @"
namespace Microsoft.CodeAnalysis.Runtime
{
    public static class Instrumentation
    {
        private static bool[][] _payloads;
        private static int[][] _fileIndices;
        private static System.Guid _mvid;

        public static bool[] CreatePayload(System.Guid mvid, int methodIndex, int[] fileIndices, ref bool[] payload, int payloadLength)
        {
            if (_mvid != mvid)
            {
                _payloads = new bool[100][];
                _fileIndices = new int[100][];
                _mvid = mvid;
            }

            if (System.Threading.Interlocked.CompareExchange(ref payload, new bool[payloadLength], null) == null)
            {
                _payloads[methodIndex] = payload;
                _fileIndices[methodIndex] = fileIndices;
                return payload;
            }

            return _payloads[methodIndex];
        }

        public static void FlushPayload()
        {
            Console.WriteLine(""Flushing"");
            if (_payloads == null)
            {
                return;
            }
            for (int i = 0; i < _payloads.Length; i++)
            {
                bool[] payload = _payloads[i];
                if (payload != null)
                {
                    Console.WriteLine(""Method "" + i.ToString());
                    for (int j = 0; j < _fileIndices[i].Length; j++)
                    {
                        Console.WriteLine(""File "" + _fileIndices[i][j].ToString());
                    }
                    for (int j = 0; j < payload.Length; j++)
                    {
                        Console.WriteLine(payload[j]);
                        payload[j] = false;
                    }
                }
            }
        }

        public static bool[] CreatePayload(System.Guid mvid, int methodIndex, int fileIndex, ref bool[] payload, int payloadLength)
        {
            return CreatePayload(mvid, methodIndex, new[] { fileIndex }, ref payload, payloadLength);
        }
    }
}
"
;

public CSharpInstrumentationChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25035,1315,5540);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25035,1315,5540);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,1315,5540);
}


static CSharpInstrumentationChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25035,1315,5540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,3424,5532);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25035,1315,5540);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,1315,5540);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25035,1315,5540);
}
public sealed class VBInstrumentationChecker : BaseInstrumentationChecker
{
private readonly string tab ;

public XCData ExpectedOutput {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,6417,6476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6423,6474);

return f_25035_6430_6473(f_25035_6441_6472(_consoleExpectations));
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,6417,6476);

string
f_25035_6441_6472(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6441, 6472);
return return_v;
}


System.Xml.Linq.XCData
f_25035_6430_6473(string
value)
{
var return_v = new System.Xml.Linq.XCData( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6430, 6473);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,6386,6478);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6386,6478);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override void AddConsoleExpectation(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,6490,6665);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6572,6606);

f_25035_6572_6605(            _consoleExpectations, text);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6620,6654);

f_25035_6620_6653(            _consoleExpectations, '\n');
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,6490,6665);

System.Text.StringBuilder
f_25035_6572_6605(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6572, 6605);
return return_v;
}


System.Text.StringBuilder
f_25035_6620_6653(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6620, 6653);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,6490,6665);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6490,6665);
}
		}

public void CompleteCheck(Compilation compilation, XElement source)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,6677,6849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6769,6838);

f_25035_6769_6837(this, compilation, f_25035_6796_6836(f_25035_6796_6829((f_25035_6797_6813(source)as XText))));
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,6677,6849);

System.Xml.Linq.XNode
f_25035_6797_6813(System.Xml.Linq.XElement
this_param)
{
var return_v = this_param.FirstNode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 6797, 6813);
return return_v;
}


string
f_25035_6796_6829(System.Xml.Linq.XText?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 6796, 6829);
return return_v;
}


string
f_25035_6796_6836(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6796, 6836);
return return_v;
}


int
f_25035_6769_6837(Microsoft.CodeAnalysis.Test.Utilities.VBInstrumentationChecker
this_param,Microsoft.CodeAnalysis.Compilation
compilation,string
source)
{
this_param.CompleteCheck( compilation, source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6769, 6837);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,6677,6849);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6677,6849);
}
		}

internal override void Dump(DynamicAnalysisDataReader reader, string[] sourceLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,6861,8517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6969,7016);

var 
output = f_25035_6982_7015()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7030,7111);

f_25035_7030_7110(            output.Builder, "Template code for checking instrumentation results:");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7136,7146);

            for (int 
method = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7127,8452) || true) && (method <= reader.Methods.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7181,7189)
,method++,DynAbs.Tracing.TraceSender.TraceExitCondition(25035,7127,8452))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,7127,8452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7223,7285);

var 
snippets = f_25035_7238_7284(method, reader, sourceLines)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7303,7397) || true) && (snippets.Length == 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,7303,7397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7369,7378);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,7303,7397);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7417,7476);

var 
methodTermination = f_25035_7441_7475(0, snippets.Length)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7494,7863) || true) && (snippets[0] == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,7494,7863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7559,7651);

f_25035_7559_7650(                    output.Builder, $"{tab}{tab}{tab}checker.Method({method}, 1){methodTermination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,7494,7863);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,7494,7863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7733,7844);

f_25035_7733_7843(                    output.Builder, $"{tab}{tab}{tab}checker.Method({method}, 1, \"{snippets[0]}\"){methodTermination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,7494,7863);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7892,7901);

                for (int 
index = 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7883,8437) || true) && (index < snippets.Length)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7928,7935)
,index++,DynAbs.Tracing.TraceSender.TraceExitCondition(25035,7883,8437))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,7883,8437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,7977,8037);

string 
termination = f_25035_7998_8036(index, snippets.Length)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8059,8418) || true) && (snippets[index] == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,8059,8418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8136,8206);

f_25035_8136_8205(                        output.Builder, $"{tab}{tab}{tab}{tab}True(){termination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,8059,8418);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,8059,8418);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8304,8395);

f_25035_8304_8394(                        output.Builder, $"{tab}{tab}{tab}{tab}True(\"{snippets[index]}\"){termination}");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,8059,8418);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25035,1,555);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25035,1,555);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25035,1,1326);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25035,1,1326);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8466,8506);

f_25035_8466_8505(f_25035_8480_8504(output));
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,6861,8517);

Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
f_25035_6982_7015()
{
var return_v = PooledStringBuilder.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 6982, 7015);
return return_v;
}


System.Text.StringBuilder
f_25035_7030_7110(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7030, 7110);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_25035_7238_7284(int
method,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,string[]
sourceLines)
{
var return_v = GetActualSnippets( method, reader, sourceLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7238, 7284);
return return_v;
}


string
f_25035_7441_7475(int
index,int
length)
{
var return_v = GetTermination( index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7441, 7475);
return return_v;
}


System.Text.StringBuilder
f_25035_7559_7650(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7559, 7650);
return return_v;
}


System.Text.StringBuilder
f_25035_7733_7843(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7733, 7843);
return return_v;
}


string
f_25035_7998_8036(int
index,int
length)
{
var return_v = GetTermination( index, length);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 7998, 8036);
return return_v;
}


System.Text.StringBuilder
f_25035_8136_8205(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8136, 8205);
return return_v;
}


System.Text.StringBuilder
f_25035_8304_8394(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8304, 8394);
return return_v;
}


string
f_25035_8480_8504(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
this_param)
{
var return_v = this_param.ToStringAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8480, 8504);
return return_v;
}


int
f_25035_8466_8505(string
message)
{
AssertEx.Fail( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8466, 8505);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,6861,8517);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6861,8517);
}
		}

private static string GetTermination(int index, int length)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25035,8529,8664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8613,8653);

return (DynAbs.Tracing.TraceSender.Conditional_F1(25035, 8620, 8641)||(((index == length - 1) &&DynAbs.Tracing.TraceSender.Conditional_F2(25035, 8644, 8646))||DynAbs.Tracing.TraceSender.Conditional_F3(25035, 8649, 8652)))?"" :".";
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25035,8529,8664);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,8529,8664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,8529,8664);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static readonly XElement InstrumentationHelperSource ;

public const string 
InstrumentationHelperSourceStr = @"
Namespace Microsoft.CodeAnalysis.Runtime

    Public Class Instrumentation

        Private Shared _payloads As Boolean()()
        Private Shared _fileIndices As Integer()()
        Private Shared _mvid As System.Guid

        Public Shared Function CreatePayload(mvid As System.Guid, methodIndex As Integer, fileIndices As Integer(), ByRef payload As Boolean(), payloadLength As Integer) As Boolean()
            If _mvid <> mvid Then
                _payloads = New Boolean(100)() {}
                _fileIndices = New Integer(100)() {}
                _mvid = mvid
            End If

            If System.Threading.Interlocked.CompareExchange(payload, new Boolean(payloadLength - 1) {}, Nothing) Is Nothing Then    
                If _payloads(methodIndex) IsNot Nothing Then
                    Throw New System.ArgumentException(""Overwriting existing payload array."")
                End If
                _payloads(methodIndex) = payload
                _fileIndices(methodIndex) = fileIndices
                Return payload
            End If

            Return _payloads(methodIndex)
        End Function

        Public Shared Sub FlushPayload()
            System.Console.WriteLine(""Flushing"")
            If _payloads Is Nothing Then
                Return
            End If
            For i As Integer = 0 To _payloads.Length - 1
                Dim payload As Boolean() = _payloads(i)
                if payload IsNot Nothing
                    System.Console.WriteLine(""Method "" & i.ToString())
                    For j As Integer = 0 To _fileIndices(i).Length - 1
                        System.Console.WriteLine(""File "" & _fileIndices(i)(j).ToString())
                    Next
                    For j As Integer = 0 To payload.Length - 1
                        System.Console.WriteLine(payload(j))
                        payload(j) = False
                    Next
                End If
            Next
        End Sub

        Public Shared Function CreatePayload(mvid As System.Guid, methodIndex As Integer, fileIndex As Integer, ByRef payload As Boolean(), payloadLength As Integer) As Boolean()
            Return CreatePayload(mvid, methodIndex, { fileIndex }, payload, payloadLength)
        End Function
    End Class
End Namespace
"
;

public VBInstrumentationChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25035,6247,11231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,6361,6373);
this.tab = "    ";DynAbs.Tracing.TraceSender.TraceExitConstructor(25035,6247,11231);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6247,11231);
}


static VBInstrumentationChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25035,6247,11231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8708,8822);
InstrumentationHelperSource = f_25035_8738_8822("file", f_25035_8759_8789("name", "c.vb"), InstrumentationHelperSourceStr);DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,8853,11223);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25035,6247,11231);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,6247,11231);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25035,6247,11231);

static System.Xml.Linq.XAttribute
f_25035_8759_8789(string
name,string
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8759, 8789);
return return_v;
}


static System.Xml.Linq.XElement
f_25035_8738_8822(string
name,params object[]
content)
{
var return_v = new System.Xml.Linq.XElement( (System.Xml.Linq.XName)name, content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 8738, 8822);
return return_v;
}

}
public abstract class BaseInstrumentationChecker
{
protected StringBuilder _consoleExpectations ;

private readonly Dictionary<int /*method*/, MethodChecker> _spanExpectations ;

protected BaseInstrumentationChecker()
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25035,11509,11618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,11328,11370);
this._consoleExpectations = f_25035_11351_11370();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,11440,11496);
this._spanExpectations = f_25035_11460_11496();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,11572,11607);

f_25035_11572_11606(this, $"Flushing");
DynAbs.Tracing.TraceSender.TraceExitConstructor(25035,11509,11618);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,11509,11618);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,11509,11618);
}
		}

public MethodChecker Method(int method, int file, string snippet = null, bool expectBodySpan = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,12498,13163);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,12623,12665);

f_25035_12623_12664(this, $"Method {method}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,12679,12717);

f_25035_12679_12716(this, $"File {file}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,12731,12797);

var 
result = f_25035_12744_12796(this, noSnippets: snippet == null)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,12903,13000) || true) && (expectBodySpan)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,12903,13000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,12955,12985);

result = f_25035_12964_12984(result, snippet);
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,12903,13000);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13016,13122) || true) && (snippet != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,13016,13122);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13069,13107);

f_25035_13069_13106(                _spanExpectations, method, result);
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,13016,13122);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13138,13152);

return result;
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,12498,13163);

int
f_25035_12623_12664(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
this_param,string
text)
{
this_param.AddConsoleExpectation( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 12623, 12664);
return 0;
}


int
f_25035_12679_12716(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
this_param,string
text)
{
this_param.AddConsoleExpectation( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 12679, 12716);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
f_25035_12744_12796(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
checker,bool
noSnippets)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker( checker, noSnippets: noSnippets);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 12744, 12796);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
f_25035_12964_12984(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
this_param,string?
expectedSourceSnippet)
{
var return_v = this_param.True( expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 12964, 12984);
return return_v;
}


int
f_25035_13069_13106(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>
this_param,int
key,Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
value)
{
this_param.Add( key, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13069, 13106);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,12498,13163);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,12498,13163);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void CompleteCheck(Compilation compilation, string source)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,13269,14269);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13359,13500);

var 
peImage = f_25035_13373_13499(compilation, f_25035_13397_13498(EmitOptions.Default, f_25035_13442_13497(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13514,13551);

var 
peReader = f_25035_13529_13550(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13565,13655);

var 
reader = f_25035_13578_13654(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13669,13711);

string[] 
sourceLines = f_25035_13692_13710(source, '\n')
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13727,13859) || true) && (f_25035_13731_13754(_spanExpectations)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,13727,13859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13793,13819);

f_25035_13793_13818(this, reader, sourceLines);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13837,13844);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,13727,13859);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13875,14258);
foreach(int method in f_25035_13898_13920_I(f_25035_13898_13920(_spanExpectations)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,13875,14258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,13954,14022);

var 
actualSnippets = f_25035_13975_14021(method, reader, sourceLines)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,14040,14109);

var 
expectedSnippets = f_25035_14063_14108(f_25035_14063_14088(_spanExpectations, method))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,14129,14243);

f_25035_14129_14242(expectedSnippets, actualSnippets, f_25035_14178_14199(), $"Validation of method {method} failed.");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,13875,14258);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25035,1,384);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25035,1,384);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25035,13269,14269);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_25035_13442_13497(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13442, 13497);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_25035_13397_13498(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13397, 13498);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_25035_13373_13499(Microsoft.CodeAnalysis.Compilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13373, 13499);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_25035_13529_13550(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13529, 13550);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_25035_13578_13654(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13578, 13654);
return return_v;
}


string[]
f_25035_13692_13710(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13692, 13710);
return return_v;
}


int
f_25035_13731_13754(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 13731, 13754);
return return_v;
}


int
f_25035_13793_13818(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
this_param,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,string[]
sourceLines)
{
this_param.Dump( reader, sourceLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13793, 13818);
return 0;
}


System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>.KeyCollection
f_25035_13898_13920(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>
this_param)
{
var return_v = this_param.Keys;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 13898, 13920);
return return_v;
}


System.Collections.Immutable.ImmutableArray<string>
f_25035_13975_14021(int
method,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,string[]
sourceLines)
{
var return_v = GetActualSnippets( method, reader, sourceLines);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13975, 14021);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
f_25035_14063_14088(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 14063, 14088);
return return_v;
}


string[]
f_25035_14063_14108(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
this_param)
{
var return_v = this_param.SnippetExpectations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 14063, 14108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.SnippetComparer
f_25035_14178_14199()
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.SnippetComparer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 14178, 14199);
return return_v;
}


int
f_25035_14129_14242(string[]
expected,System.Collections.Immutable.ImmutableArray<string>
actual,Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.SnippetComparer
comparer,string
message)
{
AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual, (System.Collections.Generic.IEqualityComparer<string>)comparer, message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 14129, 14242);
return 0;
}


System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>.KeyCollection
f_25035_13898_13920_I(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>.KeyCollection
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 13898, 13920);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,13269,14269);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,13269,14269);
}
		}

internal abstract void Dump(DynamicAnalysisDataReader reader, string[] sourceLines);

internal abstract void AddConsoleExpectation(string text);

internal static ImmutableArray<string> GetActualSnippets(int method, DynamicAnalysisDataReader reader, string[] sourceLines)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25035,14555,15127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,14704,14771);

var 
actualSpans = f_25035_14722_14770(reader, f_25035_14738_14752(reader)[method - 1].Blob)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,14787,15116);

return actualSpans.SelectAsArray((span, lines) =>
            {
                if (span.StartLine >= lines.Length)
                {
                    return null;
                }
                return lines[span.StartLine].Substring(span.StartColumn).TrimEnd(new[] { '\r', '\n', ' ' });
            },sourceLines);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25035,14555,15127);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_25035_14738_14752(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25035, 14738, 14752);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
f_25035_14722_14770(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetSpans( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 14722, 14770);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,14555,15127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,14555,15127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
public class MethodChecker
{
private readonly List<string> _snippetExpectations;

private readonly BaseInstrumentationChecker _checker;

public MethodChecker(BaseInstrumentationChecker checker, bool noSnippets = false)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25035,15324,15610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15220,15240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15299,15307);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15438,15457);

_checker = checker;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15477,15595) || true) && (!noSnippets)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,15477,15595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15534,15576);

_snippetExpectations = f_25035_15557_15575();
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,15477,15595);
}
DynAbs.Tracing.TraceSender.TraceExitConstructor(25035,15324,15610);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,15324,15610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,15324,15610);
}
		}

public string[] SnippetExpectations {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,15664,15710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15670,15708);

return f_25035_15677_15707(_snippetExpectations);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,15664,15710);

string[]
f_25035_15677_15707(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 15677, 15707);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,15626,15712);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,15626,15712);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public MethodChecker True(string expectedSourceSnippet = null)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,15900,16055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,15995,16040);

return f_25035_16002_16039(this, "True", expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,15900,16055);

Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
f_25035_16002_16039(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
this_param,string
text,string?
expectedSourceSnippet)
{
var return_v = this_param.Expect( text, expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 16002, 16039);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,15900,16055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,15900,16055);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public MethodChecker False(string expectedSourceSnippet = null)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,16249,16406);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,16345,16391);

return f_25035_16352_16390(this, "False", expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,16249,16406);

Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
f_25035_16352_16390(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
this_param,string
text,string?
expectedSourceSnippet)
{
var return_v = this_param.Expect( text, expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 16352, 16390);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,16249,16406);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,16249,16406);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private MethodChecker Expect(string text, string expectedSourceSnippet)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,16422,17030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,16526,16563);

f_25035_16526_16562(                _checker, text);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,16581,16983) || true) && (_snippetExpectations != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,16581,16983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,16655,16703);

f_25035_16655_16702(                    _snippetExpectations, expectedSourceSnippet);
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,16581,16983);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,16581,16983);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,16785,16964);

f_25035_16785_16963(expectedSourceSnippet == null, "You must pass a snippet when checking the method with M if you intend to verify snippets within the method.");
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,16581,16983);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,17003,17015);

return this;
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,16422,17030);

int
f_25035_16526_16562(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
this_param,string
text)
{
this_param.AddConsoleExpectation( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 16526, 16562);
return 0;
}


int
f_25035_16655_16702(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 16655, 16702);
return 0;
}


int
f_25035_16785_16963(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 16785, 16963);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,16422,17030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,16422,17030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static MethodChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25035,15139,17041);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25035,15139,17041);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,15139,17041);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25035,15139,17041);

static System.Collections.Generic.List<string>
f_25035_15557_15575()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 15557, 15575);
return return_v;
}

}
private class SnippetComparer : IEqualityComparer<string>
{
public bool Equals(string expected, string actual)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,17135,17399);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,17218,17331) || true) && (f_25035_17222_17257(expected))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25035,17218,17331);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,17299,17312);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25035,17218,17331);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,17349,17384);

return f_25035_17356_17383(actual, expected);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,17135,17399);

bool
f_25035_17222_17257(string
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 17222, 17257);
return return_v;
}


bool
f_25035_17356_17383(string
this_param,string
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 17356, 17383);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,17135,17399);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,17135,17399);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public int GetHashCode(string obj)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25035,17415,17522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25035,17482,17507);

return f_25035_17489_17506(obj);
DynAbs.Tracing.TraceSender.TraceExitMethod(25035,17415,17522);

int
f_25035_17489_17506(string
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 17489, 17506);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25035,17415,17522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,17415,17522);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SnippetComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25035,17053,17533);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25035,17053,17533);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,17053,17533);
}


static SnippetComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25035,17053,17533);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25035,17053,17533);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,17053,17533);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25035,17053,17533);
}

static BaseInstrumentationChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25035,11239,17540);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25035,11239,17540);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25035,11239,17540);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25035,11239,17540);

System.Text.StringBuilder
f_25035_11351_11370()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 11351, 11370);
return return_v;
}


System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>
f_25035_11460_11496()
{
var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 11460, 11496);
return return_v;
}


static int
f_25035_11572_11606(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker
this_param,string
text)
{
this_param.AddConsoleExpectation( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25035, 11572, 11606);
return 0;
}

}
}
