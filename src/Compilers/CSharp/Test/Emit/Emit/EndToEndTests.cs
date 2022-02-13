// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Test.Utilities;
using System;
using System.Text;
using Xunit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class EndToEndTests : EmitMetadataTestBase
{
private static void RunInThread(Action action)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23115,887,1457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,958,985);

Exception 
exception = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,999,1283);

var 
thread = f_23115_1012_1282(() =>
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
            }, 0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1299,1314);

f_23115_1299_1313(
            thread);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1328,1342);

f_23115_1328_1341(            thread);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1358,1446) || true) && (exception is object)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,1358,1446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1415,1431);

throw exception;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,1358,1446);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23115,887,1457);

System.Threading.Thread
f_23115_1012_1282(System.Threading.ThreadStart
start,int
maxStackSize)
{
var return_v = new System.Threading.Thread( start, maxStackSize);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 1012, 1282);
return return_v;
}


int
f_23115_1299_1313(System.Threading.Thread
this_param)
{
this_param.Start();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 1299, 1313);
return 0;
}


int
f_23115_1328_1341(System.Threading.Thread
this_param)
{
this_param.Join();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 1328, 1341);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,887,1457);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,887,1457);
}
		}

private static void RunTest(int expectedDepth, Action<int> runTest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23115,1469,2784);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1561,1651) || true) && (f_23115_1565_1595(expectedDepth))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,1561,1651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1629,1636);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,1561,1651);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1667,1684);

int 
minDepth = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1698,1727);

int 
maxDepth = expectedDepth
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1741,1757);

int 
actualDepth
=default(int);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1771,2403) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,1771,2403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1816,1865);

int 
depth = (maxDepth - minDepth) / 2 + minDepth
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1883,2016) || true) && (depth <= minDepth)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,1883,2016);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,1946,1969);

actualDepth = minDepth;
DynAbs.Tracing.TraceSender.TraceBreak(23115,1991,1997);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,1883,2016);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2034,2167) || true) && (depth >= maxDepth)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,2034,2167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2097,2120);

actualDepth = maxDepth;
DynAbs.Tracing.TraceSender.TraceBreak(23115,2142,2148);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,2034,2167);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2185,2388) || true) && (f_23115_2189_2211(depth))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,2185,2388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2253,2270);

minDepth = depth;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,2185,2388);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,2185,2388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2352,2369);

maxDepth = depth;
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,2185,2388);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,1771,2403);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1771,2403);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1771,2403);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2417,2458);

f_23115_2417_2457(expectedDepth, actualDepth);

bool runTestAndCatch(int depth)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,2474,2773);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2582,2597);

f_23115_2582_2596(runTest, depth);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2619,2631);

return true;
                }
                catch (Exception)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(23115,2668,2758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,2726,2739);

return false;
DynAbs.Tracing.TraceSender.TraceExitCatch(23115,2668,2758);
                }
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,2474,2773);

int
f_23115_2582_2596(System.Action<int>
this_param,int
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 2582, 2596);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,2474,2773);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,2474,2773);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23115,1469,2784);

bool
f_23115_1565_1595(int
depth)
{
var return_v = runTestAndCatch( depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 1565, 1595);
return return_v;
}


bool
f_23115_2189_2211(int
depth)
{
var return_v = runTestAndCatch( depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 2189, 2211);
return return_v;
}


int
f_23115_2417_2457(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 2417, 2457);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,1469,2784);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,1469,2784);
}
		}

[WorkItem(16669, "https://github.com/dotnet/roslyn/issues/16669")]
        [ConditionalFact(typeof(WindowsOrLinuxOnly)), WorkItem(34880, "https://github.com/dotnet/roslyn/issues/34880")]
        public void OverflowOnFluentCall()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,2942,5522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,3198,3820);

int 
numberFluentCalls = (f_23115_3223_3258(), f_23115_3260_3296()) switch
            {
                (ExecutionArchitecture.x86, ExecutionConfiguration.Debug) => 510,
                (ExecutionArchitecture.x86, ExecutionConfiguration.Release) => 1310,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Debug) => 225,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Release) => 620,
                _ => throw f_23115_3685_3804($"Unexpected configuration {f_23115_3727_3762()} {f_23115_3765_3801()}")            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4542,4587);

f_23115_4542_4586(numberFluentCalls);

void tryCompileDeepFluentCalls(int depth)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,4603,5511);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4677,4711);

var 
builder = f_23115_4691_4710()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4729,4844);

f_23115_4729_4843(                builder, @"class C {
    C M(string x) { return this; }
    void M2() {
        new C()
");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4871,4876);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4862,5001) || true) && (i < depth)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4889,4892)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,4862,5001))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,4862,5001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,4934,4982);

f_23115_4934_4981(                    builder, @"            .M(""test"")");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,140);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,140);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,5019,5099);

f_23115_5019_5098(                builder, @"            .M(""test"");
    }
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,5119,5151);

var 
source = f_23115_5132_5150(builder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,5169,5496);

f_23115_5169_5495(() =>
                {
                    var options = TestOptions.DebugDll.WithConcurrentBuild(false);
                    var compilation = CreateCompilation(source, options: options);
                    compilation.VerifyDiagnostics();
                    compilation.EmitToArray();
                });
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,4603,5511);

System.Text.StringBuilder
f_23115_4691_4710()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 4691, 4710);
return return_v;
}


System.Text.StringBuilder
f_23115_4729_4843(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 4729, 4843);
return return_v;
}


System.Text.StringBuilder
f_23115_4934_4981(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 4934, 4981);
return return_v;
}


System.Text.StringBuilder
f_23115_5019_5098(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 5019, 5098);
return return_v;
}


string
f_23115_5132_5150(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 5132, 5150);
return return_v;
}


int
f_23115_5169_5495(System.Action
action)
{
RunInThread( action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 5169, 5495);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,4603,5511);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,4603,5511);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,2942,5522);

Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_3223_3258()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 3223, 3258);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_3260_3296()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 3260, 3296);
return return_v;
}


Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_3727_3762()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 3727, 3762);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_3765_3801()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 3765, 3801);
return return_v;
}


System.Exception
f_23115_3685_3804(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 3685, 3804);
return return_v;
}


int
f_23115_4542_4586(int
depth)
{
tryCompileDeepFluentCalls( depth);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 4542, 4586);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,2942,5522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,2942,5522);
}
		}

[Fact]
        [WorkItem(33909, "https://github.com/dotnet/roslyn/issues/33909")]
        [WorkItem(34880, "https://github.com/dotnet/roslyn/issues/34880")]
        public void DeeplyNestedGeneric()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,5534,9056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,5760,6877);

int 
nestingLevel = (f_23115_5780_5815(), f_23115_5817_5853()) switch
            {
                // Legacy baselines are indicated by comments
                (ExecutionArchitecture.x64, ExecutionConfiguration.Debug) when f_23115_6020_6050()=> 180, // 100
                (ExecutionArchitecture.x64, ExecutionConfiguration.Release) when f_23115_6148_6178()=> 520, // 100
                _ when f_23115_6218_6254()=> 1200, // 1200
                _ when f_23115_6296_6332()=> 730, // 730
                (ExecutionArchitecture.x86, ExecutionConfiguration.Debug) => 450, // 270
                (ExecutionArchitecture.x86, ExecutionConfiguration.Release) => 1290, // 1290
                (ExecutionArchitecture.x64, ExecutionConfiguration.Debug) => 250, // 170
                (ExecutionArchitecture.x64, ExecutionConfiguration.Release) => 730, // 730
                _ => throw f_23115_6742_6861($"Unexpected configuration {f_23115_6784_6819()} {f_23115_6822_6858()}")            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7316,7357);

f_23115_7316_7356(nestingLevel);

void runDeeplyNestedGenericTest(int nestingLevel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,7373,9045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7455,7489);

var 
builder = f_23115_7469_7488()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7507,7668);

f_23115_7507_7667(                builder, @"
#pragma warning disable 168 // Unused local
using System;

public class Test
{
    public static void Main(string[] args)
    {
");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7697,7702);

                for (var 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7688,7946) || true) && (i < nestingLevel)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7722,7725)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,7688,7946))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,7688,7946);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7767,7869) || true) && (i > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,7767,7869);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7826,7846);

f_23115_7826_7845(                        builder, '.');
DynAbs.Tracing.TraceSender.TraceExitCondition(23115,7767,7869);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7891,7927);

f_23115_7891_7926(                    builder, $"MyStruct{i}<int>");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,259);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,259);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,7966,7996);

f_23115_7966_7995(
                builder, " local;");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8014,8086);

f_23115_8014_8085(                builder, @"
        Console.WriteLine(""Pass"");
    }
}");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8115,8120);

                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8106,8262) || true) && (i < nestingLevel)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8140,8143)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,8106,8262))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,8106,8262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8185,8243);

f_23115_8185_8242(                    builder, $"public struct MyStruct{i}<T{i}> {{");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,157);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,157);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8289,8294);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8280,8402) || true) && (i < nestingLevel)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8314,8317)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,8280,8402))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,8280,8402);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8359,8383);

f_23115_8359_8382(                    builder, "}");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,123);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,123);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8422,8454);

var 
source = f_23115_8435_8453(builder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,8472,9030);

f_23115_8472_9029(() =>
                {
                    var compilation = CreateCompilation(source, options: TestOptions.DebugExe.WithConcurrentBuild(false));
                    compilation.VerifyDiagnostics();

                    // PEVerify is skipped here as it doesn't scale to this level of nested generics. After 
                    // about 600 levels of nesting it will not return in any reasonable amount of time.
                    CompileAndVerify(compilation, expectedOutput: "Pass", verify: Verification.Skipped);
                });
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,7373,9045);

System.Text.StringBuilder
f_23115_7469_7488()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7469, 7488);
return return_v;
}


System.Text.StringBuilder
f_23115_7507_7667(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7507, 7667);
return return_v;
}


System.Text.StringBuilder
f_23115_7826_7845(System.Text.StringBuilder
this_param,char
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7826, 7845);
return return_v;
}


System.Text.StringBuilder
f_23115_7891_7926(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7891, 7926);
return return_v;
}


System.Text.StringBuilder
f_23115_7966_7995(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7966, 7995);
return return_v;
}


System.Text.StringBuilder
f_23115_8014_8085(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 8014, 8085);
return return_v;
}


System.Text.StringBuilder
f_23115_8185_8242(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 8185, 8242);
return return_v;
}


System.Text.StringBuilder
f_23115_8359_8382(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 8359, 8382);
return return_v;
}


string
f_23115_8435_8453(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 8435, 8453);
return return_v;
}


int
f_23115_8472_9029(System.Action
action)
{
RunInThread( action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 8472, 9029);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,7373,9045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,7373,9045);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,5534,9056);

Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_5780_5815()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 5780, 5815);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_5817_5853()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 5817, 5853);
return return_v;
}


bool
f_23115_6020_6050()
{
var return_v = ExecutionConditionUtil.IsMacOS ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6020, 6050);
return return_v;
}


bool
f_23115_6148_6178()
{
var return_v = ExecutionConditionUtil.IsMacOS ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6148, 6178);
return return_v;
}


bool
f_23115_6218_6254()
{
var return_v = ExecutionConditionUtil.IsCoreClrUnix ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6218, 6254);
return return_v;
}


bool
f_23115_6296_6332()
{
var return_v = ExecutionConditionUtil.IsMonoDesktop ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6296, 6332);
return return_v;
}


Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_6784_6819()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6784, 6819);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_6822_6858()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 6822, 6858);
return return_v;
}


System.Exception
f_23115_6742_6861(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 6742, 6861);
return return_v;
}


int
f_23115_7316_7356(int
nestingLevel)
{
runDeeplyNestedGenericTest( nestingLevel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 7316, 7356);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,5534,9056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,5534,9056);
}
		}

[ConditionalFact(typeof(WindowsOrLinuxOnly))]
        public void NestedIfStatements()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,9068,10779);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,9180,9797);

int 
nestingLevel = (f_23115_9200_9235(), f_23115_9237_9273()) switch
            {
                (ExecutionArchitecture.x86, ExecutionConfiguration.Debug) => 310,
                (ExecutionArchitecture.x86, ExecutionConfiguration.Release) => 1650,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Debug) => 200,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Release) => 780,
                _ => throw f_23115_9662_9781($"Unexpected configuration {f_23115_9704_9739()} {f_23115_9742_9778()}")            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,9813,9844);

f_23115_9813_9843(nestingLevel, runTest);

static void runTest(int nestingLevel)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23115,9860,10768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,9930,9964);

var 
builder = f_23115_9944_9963()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,9982,10090);

f_23115_9982_10089(                builder, @"class Program
{
    static bool F(int i) => true;
    static void Main()
    {");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10117,10122);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10108,10264) || true) && (i < nestingLevel)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10142,10145)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,10108,10264))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,10108,10264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10187,10245);

f_23115_10187_10244(                    builder, $@"        if (F({i}))
        {{");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,157);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,157);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10291,10296);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10282,10412) || true) && (i < nestingLevel)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10316,10319)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,10282,10412))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,10282,10412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10361,10393);

f_23115_10361_10392(                    builder, "        }");
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,131);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,131);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10430,10464);

f_23115_10430_10463(                builder, @"    }
}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10482,10514);

var 
source = f_23115_10495_10513(builder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10532,10753);

f_23115_10532_10752(() =>
                {
                    var comp = CreateCompilation(source, options: TestOptions.DebugDll.WithConcurrentBuild(false));
                    comp.VerifyDiagnostics();
                });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23115,9860,10768);

System.Text.StringBuilder
f_23115_9944_9963()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 9944, 9963);
return return_v;
}


System.Text.StringBuilder
f_23115_9982_10089(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 9982, 10089);
return return_v;
}


System.Text.StringBuilder
f_23115_10187_10244(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 10187, 10244);
return return_v;
}


System.Text.StringBuilder
f_23115_10361_10392(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 10361, 10392);
return return_v;
}


System.Text.StringBuilder
f_23115_10430_10463(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 10430, 10463);
return return_v;
}


string
f_23115_10495_10513(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 10495, 10513);
return return_v;
}


int
f_23115_10532_10752(System.Action
action)
{
RunInThread( action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 10532, 10752);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,9860,10768);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,9860,10768);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,9068,10779);

Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_9200_9235()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 9200, 9235);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_9237_9273()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 9237, 9273);
return return_v;
}


Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_9704_9739()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 9704, 9739);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_9742_9778()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 9742, 9778);
return return_v;
}


System.Exception
f_23115_9662_9781(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 9662, 9781);
return return_v;
}


int
f_23115_9813_9843(int
expectedDepth,System.Action<int>
runTest)
{
RunTest( expectedDepth, runTest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 9813, 9843);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,9068,10779);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,9068,10779);
}
		}

[WorkItem(42361, "https://github.com/dotnet/roslyn/issues/42361")]
        [ConditionalFact(typeof(WindowsOrLinuxOnly))]
        public void Constraints()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23115,10791,13004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,10972,11578);

int 
n = (f_23115_10981_11016(), f_23115_11018_11054()) switch
            {
                (ExecutionArchitecture.x86, ExecutionConfiguration.Debug) => 420,
                (ExecutionArchitecture.x86, ExecutionConfiguration.Release) => 1100,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Debug) => 180,
                (ExecutionArchitecture.x64, ExecutionConfiguration.Release) => 480,
                _ => throw f_23115_11443_11562($"Unexpected configuration {f_23115_11485_11520()} {f_23115_11523_11559()}")            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,11594,11614);

f_23115_11594_11613(n, runTest);

static void runTest(int n)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23115,11630,12993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,11869,11909);

var 
sourceBuilder = f_23115_11889_11908()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,11927,12002);

var 
diagnosticsBuilder = f_23115_11952_12001()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12029,12034);
                for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12020,12397) || true) && (i <= n)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12044,12047)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(23115,12020,12397))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(23115,12020,12397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12089,12121);

int 
next = (DynAbs.Tracing.TraceSender.Conditional_F1(23115, 12100, 12108)||(((i == n) &&DynAbs.Tracing.TraceSender.Conditional_F2(23115, 12111, 12112))||DynAbs.Tracing.TraceSender.Conditional_F3(23115, 12115, 12120)))?0 :i + 1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12143,12213);

f_23115_12143_12212(                    sourceBuilder, $"class C{i}<T> where T : C{next}<T> {{ }}");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12235,12378);

f_23115_12235_12377(                    diagnosticsBuilder, f_23115_12258_12376(f_23115_12258_12325(ErrorCode.ERR_GenericConstraintNotSatisfiedRefType, "T"), $"C{i}<T>", $"C{next}<T>", "T", "T"));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23115,1,378);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23115,1,378);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12415,12453);

var 
source = f_23115_12428_12452(sourceBuilder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12471,12525);

var 
diagnostics = f_23115_12489_12524(diagnosticsBuilder)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23115,12545,12978);

f_23115_12545_12977(() =>
                {
                    var comp = CreateCompilation(source, options: TestOptions.DebugDll.WithConcurrentBuild(false));
                    var type = comp.GetMember<NamedTypeSymbol>("C0");
                    var typeParameter = type.TypeParameters[0];
                    Assert.True(typeParameter.IsReferenceType);
                    comp.VerifyDiagnostics(diagnostics);
                });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23115,11630,12993);

System.Text.StringBuilder
f_23115_11889_11908()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 11889, 11908);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
f_23115_11952_12001()
{
var return_v = ArrayBuilder<DiagnosticDescription>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 11952, 12001);
return return_v;
}


System.Text.StringBuilder
f_23115_12143_12212(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12143, 12212);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23115_12258_12325(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12258, 12325);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23115_12258_12376(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12258, 12376);
return return_v;
}


int
f_23115_12235_12377(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
this_param,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12235, 12377);
return 0;
}


string
f_23115_12428_12452(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12428, 12452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
f_23115_12489_12524(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription>
this_param)
{
var return_v = this_param.ToArrayAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12489, 12524);
return return_v;
}


int
f_23115_12545_12977(System.Action
action)
{
RunInThread( action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 12545, 12977);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,11630,12993);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,11630,12993);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23115,10791,13004);

Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_10981_11016()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 10981, 11016);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_11018_11054()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 11018, 11054);
return return_v;
}


Roslyn.Test.Utilities.ExecutionArchitecture
f_23115_11485_11520()
{
var return_v = ExecutionConditionUtil.Architecture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 11485, 11520);
return return_v;
}


Roslyn.Test.Utilities.ExecutionConfiguration
f_23115_11523_11559()
{
var return_v = ExecutionConditionUtil.Configuration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23115, 11523, 11559);
return return_v;
}


System.Exception
f_23115_11443_11562(string
message)
{
var return_v = new System.Exception( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 11443, 11562);
return return_v;
}


int
f_23115_11594_11613(int
expectedDepth,System.Action<int>
runTest)
{
RunTest( expectedDepth, runTest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23115, 11594, 11613);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23115,10791,13004);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,10791,13004);
}
		}

public EndToEndTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23115,563,13011);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23115,563,13011);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,563,13011);
}


static EndToEndTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23115,563,13011);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23115,563,13011);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23115,563,13011);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23115,563,13011);
}
}
