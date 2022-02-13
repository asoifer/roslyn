// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;
using Roslyn.Test.Utilities;
using static Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker;

namespace Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests
{
    public class DynamicInstrumentationTests : CSharpTestBase
    {
        [Fact]
        public void HelpersInstrumentation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 737, 9002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 814, 1011);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 1027, 1210);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
Method 4
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 1226, 1726);

                string
                expectedCreatePayloadForMethodsSpanningSingleFileIL = @"{
  // Code size       21 (0x15)
  .maxstack  6
  IL_0000:  ldarg.0
  IL_0001:  ldarg.1
  IL_0002:  ldc.i4.1
  IL_0003:  newarr     ""int""
  IL_0008:  dup
  IL_0009:  ldc.i4.0
  IL_000a:  ldarg.2
  IL_000b:  stelem.i4
  IL_000c:  ldarg.3
  IL_000d:  ldarg.s    V_4
  IL_000f:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int[], ref bool[], int)""
  IL_0014:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 1742, 3334);

                string
                expectedCreatePayloadForMethodsSpanningMultipleFilesIL = @"{
  // Code size       87 (0x57)
  .maxstack  3
  IL_0000:  ldsfld     ""System.Guid Microsoft.CodeAnalysis.Runtime.Instrumentation._mvid""
  IL_0005:  ldarg.0
  IL_0006:  call       ""bool System.Guid.op_Inequality(System.Guid, System.Guid)""
  IL_000b:  brfalse.s  IL_002b
  IL_000d:  ldc.i4.s   100
  IL_000f:  newarr     ""bool[]""
  IL_0014:  stsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_0019:  ldc.i4.s   100
  IL_001b:  newarr     ""int[]""
  IL_0020:  stsfld     ""int[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._fileIndices""
  IL_0025:  ldarg.0
  IL_0026:  stsfld     ""System.Guid Microsoft.CodeAnalysis.Runtime.Instrumentation._mvid""
  IL_002b:  ldarg.3
  IL_002c:  ldarg.s    V_4
  IL_002e:  newarr     ""bool""
  IL_0033:  ldnull
  IL_0034:  call       ""bool[] System.Threading.Interlocked.CompareExchange<bool[]>(ref bool[], bool[], bool[])""
  IL_0039:  brtrue.s   IL_004f
  IL_003b:  ldsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_0040:  ldarg.1
  IL_0041:  ldarg.3
  IL_0042:  ldind.ref
  IL_0043:  stelem.ref
  IL_0044:  ldsfld     ""int[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._fileIndices""
  IL_0049:  ldarg.1
  IL_004a:  ldarg.2
  IL_004b:  stelem.ref
  IL_004c:  ldarg.3
  IL_004d:  ldind.ref
  IL_004e:  ret
  IL_004f:  ldsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_0054:  ldarg.1
  IL_0055:  ldelem.ref
  IL_0056:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 3350, 8312);

                string
                expectedFlushPayloadIL = @"{
  // Code size      288 (0x120)
  .maxstack  5
  .locals init (bool[] V_0,
                int V_1, //i
                bool[] V_2, //payload
                int V_3, //j
                int V_4) //j
  IL_0000:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0005:  ldtoken    ""void Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload()""
  IL_000a:  ldelem.ref
  IL_000b:  stloc.0
  IL_000c:  ldloc.0
  IL_000d:  brtrue.s   IL_0035
  IL_000f:  ldsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0014:  ldtoken    ""void Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload()""
  IL_0019:  ldtoken    Source Document 0
  IL_001e:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0023:  ldtoken    ""void Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload()""
  IL_0028:  ldelema    ""bool[]""
  IL_002d:  ldc.i4.s   16
  IL_002f:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)""
  IL_0034:  stloc.0
  IL_0035:  ldloc.0
  IL_0036:  ldc.i4.0
  IL_0037:  ldc.i4.1
  IL_0038:  stelem.i1
  IL_0039:  ldloc.0
  IL_003a:  ldc.i4.1
  IL_003b:  ldc.i4.1
  IL_003c:  stelem.i1
  IL_003d:  ldstr      ""Flushing""
  IL_0042:  call       ""void System.Console.WriteLine(string)""
  IL_0047:  ldloc.0
  IL_0048:  ldc.i4.3
  IL_0049:  ldc.i4.1
  IL_004a:  stelem.i1
  IL_004b:  ldsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_0050:  brtrue.s   IL_0057
  IL_0052:  ldloc.0
  IL_0053:  ldc.i4.2
  IL_0054:  ldc.i4.1
  IL_0055:  stelem.i1
  IL_0056:  ret
  IL_0057:  ldloc.0
  IL_0058:  ldc.i4.4
  IL_0059:  ldc.i4.1
  IL_005a:  stelem.i1
  IL_005b:  ldc.i4.0
  IL_005c:  stloc.1
  IL_005d:  br         IL_0112
  IL_0062:  ldloc.0
  IL_0063:  ldc.i4.6
  IL_0064:  ldc.i4.1
  IL_0065:  stelem.i1
  IL_0066:  ldsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_006b:  ldloc.1
  IL_006c:  ldelem.ref
  IL_006d:  stloc.2
  IL_006e:  ldloc.0
  IL_006f:  ldc.i4.s   15
  IL_0071:  ldc.i4.1
  IL_0072:  stelem.i1
  IL_0073:  ldloc.2
  IL_0074:  brfalse    IL_010a
  IL_0079:  ldloc.0
  IL_007a:  ldc.i4.7
  IL_007b:  ldc.i4.1
  IL_007c:  stelem.i1
  IL_007d:  ldstr      ""Method ""
  IL_0082:  ldloca.s   V_1
  IL_0084:  call       ""string int.ToString()""
  IL_0089:  call       ""string string.Concat(string, string)""
  IL_008e:  call       ""void System.Console.WriteLine(string)""
  IL_0093:  ldloc.0
  IL_0094:  ldc.i4.8
  IL_0095:  ldc.i4.1
  IL_0096:  stelem.i1
  IL_0097:  ldc.i4.0
  IL_0098:  stloc.3
  IL_0099:  br.s       IL_00ca
  IL_009b:  ldloc.0
  IL_009c:  ldc.i4.s   10
  IL_009e:  ldc.i4.1
  IL_009f:  stelem.i1
  IL_00a0:  ldstr      ""File ""
  IL_00a5:  ldsfld     ""int[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._fileIndices""
  IL_00aa:  ldloc.1
  IL_00ab:  ldelem.ref
  IL_00ac:  ldloc.3
  IL_00ad:  ldelema    ""int""
  IL_00b2:  call       ""string int.ToString()""
  IL_00b7:  call       ""string string.Concat(string, string)""
  IL_00bc:  call       ""void System.Console.WriteLine(string)""
  IL_00c1:  ldloc.0
  IL_00c2:  ldc.i4.s   9
  IL_00c4:  ldc.i4.1
  IL_00c5:  stelem.i1
  IL_00c6:  ldloc.3
  IL_00c7:  ldc.i4.1
  IL_00c8:  add
  IL_00c9:  stloc.3
  IL_00ca:  ldloc.3
  IL_00cb:  ldsfld     ""int[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._fileIndices""
  IL_00d0:  ldloc.1
  IL_00d1:  ldelem.ref
  IL_00d2:  ldlen
  IL_00d3:  conv.i4
  IL_00d4:  blt.s      IL_009b
  IL_00d6:  ldloc.0
  IL_00d7:  ldc.i4.s   11
  IL_00d9:  ldc.i4.1
  IL_00da:  stelem.i1
  IL_00db:  ldc.i4.0
  IL_00dc:  stloc.s    V_4
  IL_00de:  br.s       IL_0103
  IL_00e0:  ldloc.0
  IL_00e1:  ldc.i4.s   13
  IL_00e3:  ldc.i4.1
  IL_00e4:  stelem.i1
  IL_00e5:  ldloc.2
  IL_00e6:  ldloc.s    V_4
  IL_00e8:  ldelem.u1
  IL_00e9:  call       ""void System.Console.WriteLine(bool)""
  IL_00ee:  ldloc.0
  IL_00ef:  ldc.i4.s   14
  IL_00f1:  ldc.i4.1
  IL_00f2:  stelem.i1
  IL_00f3:  ldloc.2
  IL_00f4:  ldloc.s    V_4
  IL_00f6:  ldc.i4.0
  IL_00f7:  stelem.i1
  IL_00f8:  ldloc.0
  IL_00f9:  ldc.i4.s   12
  IL_00fb:  ldc.i4.1
  IL_00fc:  stelem.i1
  IL_00fd:  ldloc.s    V_4
  IL_00ff:  ldc.i4.1
  IL_0100:  add
  IL_0101:  stloc.s    V_4
  IL_0103:  ldloc.s    V_4
  IL_0105:  ldloc.2
  IL_0106:  ldlen
  IL_0107:  conv.i4
  IL_0108:  blt.s      IL_00e0
  IL_010a:  ldloc.0
  IL_010b:  ldc.i4.5
  IL_010c:  ldc.i4.1
  IL_010d:  stelem.i1
  IL_010e:  ldloc.1
  IL_010f:  ldc.i4.1
  IL_0110:  add
  IL_0111:  stloc.1
  IL_0112:  ldloc.1
  IL_0113:  ldsfld     ""bool[][] Microsoft.CodeAnalysis.Runtime.Instrumentation._payloads""
  IL_0118:  ldlen
  IL_0119:  conv.i4
  IL_011a:  blt        IL_0062
  IL_011f:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 8328, 8446);

                CompilationVerifier
                verifier = f_23103_8359_8445(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 8460, 8635);

                f_23103_8460_8634(verifier, "Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)", expectedCreatePayloadForMethodsSpanningSingleFileIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 8649, 8829);

                f_23103_8649_8828(verifier, "Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int[], ref bool[], int)", expectedCreatePayloadForMethodsSpanningMultipleFilesIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 8843, 8948);

                f_23103_8843_8947(verifier, "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload", expectedFlushPayloadIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 8962, 8991);

                f_23103_8962_8990(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 737, 9002);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_8359_8445(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 8359, 8445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_8460_8634(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 8460, 8634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_8649_8828(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 8649, 8828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_8843_8947(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 8843, 8947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_8962_8990(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 8962, 8990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 737, 9002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 737, 9002);
            }
        }

        [Fact]
        public void GotoCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 9014, 13011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 9081, 10006);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()
    {
        Console.WriteLine(""goo"");
        goto bar;
        Console.Write(""you won't see me"");
        bar: Console.WriteLine(""bar"");
        Fred();
        return;
    }

    static void Wilma()
    {
        Betty(true);
        Barney(true);
        Barney(false);
        Betty(true);
    }

    static int Barney(bool b)
    {
        if (b)
            return 10;
        if (b)
            return 100;
        return 20;
    }

    static int Betty(bool b)
    {
        if (b)
            return 30;
        if (b)
            return 100;
        return 40;
    }

    static void Fred()
    {
        Wilma();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 10020, 10470);

                string
                expectedOutput = @"goo
bar
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
False
True
True
True
Method 3
File 1
True
True
True
True
True
Method 4
File 1
True
True
True
False
True
True
Method 5
File 1
True
True
True
False
False
False
Method 6
File 1
True
True
Method 9
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 10486, 12115);

                string
                expectedBarneyIL = @"{
  // Code size       91 (0x5b)
  .maxstack  5
  .locals init (bool[] V_0)
  IL_0000:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0005:  ldtoken    ""int Program.Barney(bool)""
  IL_000a:  ldelem.ref
  IL_000b:  stloc.0
  IL_000c:  ldloc.0
  IL_000d:  brtrue.s   IL_0034
  IL_000f:  ldsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0014:  ldtoken    ""int Program.Barney(bool)""
  IL_0019:  ldtoken    Source Document 0
  IL_001e:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0023:  ldtoken    ""int Program.Barney(bool)""
  IL_0028:  ldelema    ""bool[]""
  IL_002d:  ldc.i4.6
  IL_002e:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)""
  IL_0033:  stloc.0
  IL_0034:  ldloc.0
  IL_0035:  ldc.i4.0
  IL_0036:  ldc.i4.1
  IL_0037:  stelem.i1
  IL_0038:  ldloc.0
  IL_0039:  ldc.i4.2
  IL_003a:  ldc.i4.1
  IL_003b:  stelem.i1
  IL_003c:  ldarg.0
  IL_003d:  brfalse.s  IL_0046
  IL_003f:  ldloc.0
  IL_0040:  ldc.i4.1
  IL_0041:  ldc.i4.1
  IL_0042:  stelem.i1
  IL_0043:  ldc.i4.s   10
  IL_0045:  ret
  IL_0046:  ldloc.0
  IL_0047:  ldc.i4.4
  IL_0048:  ldc.i4.1
  IL_0049:  stelem.i1
  IL_004a:  ldarg.0
  IL_004b:  brfalse.s  IL_0054
  IL_004d:  ldloc.0
  IL_004e:  ldc.i4.3
  IL_004f:  ldc.i4.1
  IL_0050:  stelem.i1
  IL_0051:  ldc.i4.s   100
  IL_0053:  ret
  IL_0054:  ldloc.0
  IL_0055:  ldc.i4.5
  IL_0056:  ldc.i4.1
  IL_0057:  stelem.i1
  IL_0058:  ldc.i4.s   20
  IL_005a:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 12131, 12609);

                string
                expectedPIDStaticConstructorIL = @"{
  // Code size       33 (0x21)
  .maxstack  2
  IL_0000:  ldtoken    Max Method Token Index
  IL_0005:  ldc.i4.1
  IL_0006:  add
  IL_0007:  newarr     ""bool[]""
  IL_000c:  stsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0011:  ldstr      ##MVID##
  IL_0016:  newobj     ""System.Guid..ctor(string)""
  IL_001b:  stsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0020:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 12625, 12743);

                CompilationVerifier
                verifier = f_23103_12656_12742(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 12757, 12811);

                f_23103_12757_12810(verifier, "Program.Barney", expectedBarneyIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 12825, 12885);

                f_23103_12825_12884(verifier, ".cctor", expectedPIDStaticConstructorIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 12899, 13000);

                f_23103_12899_12999(verifier, f_23103_12926_12998(f_23103_12926_12978(ErrorCode.WRN_UnreachableCode, "Console"), 16, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 9014, 13011);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_12656_12742(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12656, 12742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_12757_12810(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12757, 12810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_12825_12884(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12825, 12884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_12926_12978(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12926, 12978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_12926_12998(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12926, 12998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_12899_12999(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 12899, 12999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 9014, 13011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 9014, 13011);
            }
        }

        [Fact]
        public void MethodsOfGenericTypesCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 13023, 18562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 13107, 13917);

                string
                source = @"
using System;

class MyBox<T> where T : class
{
    readonly T _value;

    public MyBox(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        if (_value == null)
        {
            return null;
        }

        return _value;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()
    {
        MyBox<object> x = new MyBox<object>(null);
        Console.WriteLine(x.GetValue() == null ? ""null"" : x.GetValue().ToString());
        MyBox<string> s = new MyBox<string>(""Hello"");
        Console.WriteLine(s.GetValue() == null ? ""null"" : s.GetValue());
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 14292, 14614);

                string
                expectedOutput = @"null
Hello
Flushing
Method 1
File 1
True
True
Method 2
File 1
True
True
True
True
Method 3
File 1
True
True
True
Method 4
File 1
True
True
True
True
True
Method 7
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 14630, 16177);

                string
                expectedReleaseGetValueIL = @"{
  // Code size       98 (0x62)
  .maxstack  5
  .locals init (bool[] V_0,
                T V_1)
  IL_0000:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0005:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_000a:  ldelem.ref
  IL_000b:  stloc.0
  IL_000c:  ldloc.0
  IL_000d:  brtrue.s   IL_0034
  IL_000f:  ldsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0014:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_0019:  ldtoken    Source Document 0
  IL_001e:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0023:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_0028:  ldelema    ""bool[]""
  IL_002d:  ldc.i4.4
  IL_002e:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)""
  IL_0033:  stloc.0
  IL_0034:  ldloc.0
  IL_0035:  ldc.i4.0
  IL_0036:  ldc.i4.1
  IL_0037:  stelem.i1
  IL_0038:  ldloc.0
  IL_0039:  ldc.i4.2
  IL_003a:  ldc.i4.1
  IL_003b:  stelem.i1
  IL_003c:  ldarg.0
  IL_003d:  ldfld      ""T MyBox<T>._value""
  IL_0042:  box        ""T""
  IL_0047:  brtrue.s   IL_0057
  IL_0049:  ldloc.0
  IL_004a:  ldc.i4.1
  IL_004b:  ldc.i4.1
  IL_004c:  stelem.i1
  IL_004d:  ldloca.s   V_1
  IL_004f:  initobj    ""T""
  IL_0055:  ldloc.1
  IL_0056:  ret
  IL_0057:  ldloc.0
  IL_0058:  ldc.i4.3
  IL_0059:  ldc.i4.1
  IL_005a:  stelem.i1
  IL_005b:  ldarg.0
  IL_005c:  ldfld      ""T MyBox<T>._value""
  IL_0061:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 16193, 17995);

                string
                expectedDebugGetValueIL = @"{
  // Code size      110 (0x6e)
  .maxstack  5
  .locals init (bool[] V_0,
                bool V_1,
                T V_2,
                T V_3)
  IL_0000:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0005:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_000a:  ldelem.ref
  IL_000b:  stloc.0
  IL_000c:  ldloc.0
  IL_000d:  brtrue.s   IL_0034
  IL_000f:  ldsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0014:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_0019:  ldtoken    Source Document 0
  IL_001e:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0023:  ldtoken    ""T MyBox<T>.GetValue()""
  IL_0028:  ldelema    ""bool[]""
  IL_002d:  ldc.i4.4
  IL_002e:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)""
  IL_0033:  stloc.0
  IL_0034:  ldloc.0
  IL_0035:  ldc.i4.0
  IL_0036:  ldc.i4.1
  IL_0037:  stelem.i1
  IL_0038:  ldloc.0
  IL_0039:  ldc.i4.2
  IL_003a:  ldc.i4.1
  IL_003b:  stelem.i1
  IL_003c:  ldarg.0
  IL_003d:  ldfld      ""T MyBox<T>._value""
  IL_0042:  box        ""T""
  IL_0047:  ldnull
  IL_0048:  ceq
  IL_004a:  stloc.1
  IL_004b:  ldloc.1
  IL_004c:  brfalse.s  IL_005f
  IL_004e:  nop
  IL_004f:  ldloc.0
  IL_0050:  ldc.i4.1
  IL_0051:  ldc.i4.1
  IL_0052:  stelem.i1
  IL_0053:  ldloca.s   V_2
  IL_0055:  initobj    ""T""
  IL_005b:  ldloc.2
  IL_005c:  stloc.3
  IL_005d:  br.s       IL_006c
  IL_005f:  ldloc.0
  IL_0060:  ldc.i4.3
  IL_0061:  ldc.i4.1
  IL_0062:  stelem.i1
  IL_0063:  ldarg.0
  IL_0064:  ldfld      ""T MyBox<T>._value""
  IL_0069:  stloc.3
  IL_006a:  br.s       IL_006c
  IL_006c:  ldloc.3
  IL_006d:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18011, 18162);

                CompilationVerifier
                verifier = f_23103_18042_18161(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18176, 18242);

                f_23103_18176_18241(verifier, "MyBox<T>.GetValue", expectedReleaseGetValueIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18256, 18285);

                f_23103_18256_18284(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18301, 18430);

                verifier = f_23103_18312_18429(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18444, 18508);

                f_23103_18444_18507(verifier, "MyBox<T>.GetValue", expectedDebugGetValueIL);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18522, 18551);

                f_23103_18522_18550(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 13023, 18562);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18042_18161(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18042, 18161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18176_18241(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18176, 18241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18256_18284(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18256, 18284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18312_18429(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18312, 18429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18444_18507(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18444, 18507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_18522_18550(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 18522, 18550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 13023, 18562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 13023, 18562);
            }
        }

        [Fact]
        public void NonStaticImplicitBlockMethodsCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 18574, 20848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 18666, 19313);

                string
                source = @"
using System;

public class Program
{
    public int Prop { get; }

    public int Prop2 { get; } = 25;

    public int Prop3 { get; set; }                                              // Methods 3 and 4

    public Program()                                                            // Method 5
    {
        Prop = 12;
        Prop3 = 12;
        Prop2 = Prop3;
    }

    public static void Main(string[] args)                                      // Method 6
    {
        new Program();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19329, 19378);

                var
                checker = f_23103_19343_19377()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19392, 19463);

                f_23103_19392_19462(f_23103_19392_19432(checker, 3, 1, "public int Prop3"), "get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19477, 19548);

                f_23103_19477_19547(f_23103_19477_19517(checker, 4, 1, "public int Prop3"), "set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19562, 19748);

                f_23103_19562_19747(f_23103_19562_19706(f_23103_19562_19668(f_23103_19562_19631(f_23103_19562_19602(checker, 5, 1, "public Program()"), "25"), "Prop = 12;"), "Prop3 = 12;"), "Prop2 = Prop3;");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19762, 19940);

                f_23103_19762_19939(f_23103_19762_19850(f_23103_19762_19809(checker, 6, 1, "public static void Main"), "new Program();"), "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 19954, 20351);

                f_23103_19954_20350(f_23103_19954_20325(f_23103_19954_20300(f_23103_19954_20275(f_23103_19954_20250(f_23103_19954_20225(f_23103_19954_20200(f_23103_19954_20175(f_23103_19954_20150(f_23103_19954_20125(f_23103_19954_20100(f_23103_19954_20075(f_23103_19954_20050(f_23103_19954_20025(f_23103_19954_19999(f_23103_19954_19974(checker, 8, 1))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20367, 20496);

                CompilationVerifier
                verifier = f_23103_20398_20495(this, source, expectedOutput: f_23103_20439_20461(checker), options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20510, 20539);

                f_23103_20510_20538(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20553, 20605);

                f_23103_20553_20604(checker, f_23103_20575_20595(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20621, 20728);

                verifier = f_23103_20632_20727(this, source, expectedOutput: f_23103_20673_20695(checker), options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20742, 20771);

                f_23103_20742_20770(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20785, 20837);

                f_23103_20785_20836(checker, f_23103_20807_20827(verifier), source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 18574, 20848);

                Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                f_23103_19343_19377()
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19343, 19377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19392_19432(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19392, 19432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19392_19462(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19392, 19462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19477_19517(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19477, 19517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19477_19547(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19477, 19547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19562_19602(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19562, 19602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19562_19631(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19562, 19631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19562_19668(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19562, 19668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19562_19706(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19562, 19706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19562_19747(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19562, 19747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19762_19809(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19762, 19809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19762_19850(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19762, 19850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19762_19939(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19762, 19939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_19974(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file)
                {
                    var return_v = this_param.Method(method, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 19974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_19999(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 19999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20025(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20050(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20075(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20100(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20125(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20150(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20175(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20200(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20225(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20250(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20275(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20300(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20325(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_19954_20350(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 19954, 20350);
                    return return_v;
                }


                string
                f_23103_20439_20461(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 20439, 20461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_20398_20495(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20398, 20495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_20510_20538(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20510, 20538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_20575_20595(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 20575, 20595);
                    return return_v;
                }


                int
                f_23103_20553_20604(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20553, 20604);
                    return 0;
                }


                string
                f_23103_20673_20695(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 20673, 20695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_20632_20727(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20632, 20727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_20742_20770(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20742, 20770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_20807_20827(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 20807, 20827);
                    return return_v;
                }


                int
                f_23103_20785_20836(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 20785, 20836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 18574, 20848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 18574, 20848);
            }
        }

        [Fact]
        public void ImplicitBlockMethodsCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 20860, 22707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 20943, 21738);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }
    
    static void TestMain()                                                  // Method 2
    {
        int x = Count;
        x += Prop;
        Prop = x;
        x += Prop2;
        Lambda(x, (y) => y + 1);
    }

    static int Function(int x) => x;

    static int Count => Function(44);

    static int Prop { get; set; }

    static int Prop2 { get; set; } = 12;

    static int Lambda(int x, Func<int, int> l)
    {
        return l(x);
    }

    // Method 11 is a synthesized static constructor.
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 21847, 22302);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
True
True
True
Method 3
File 1
True
True
Method 4
File 1
True
True
Method 5
File 1
True
True
Method 6
File 1
True
True
Method 7
File 1
True
True
Method 9
File 1
True
True
Method 11
File 1
True
Method 13
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 22316, 22467);

                CompilationVerifier
                verifier = f_23103_22347_22466(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 22481, 22510);

                f_23103_22481_22509(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 22524, 22653);

                verifier = f_23103_22535_22652(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 22667, 22696);

                f_23103_22667_22695(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 20860, 22707);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_22347_22466(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 22347, 22466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_22481_22509(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 22481, 22509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_22535_22652(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 22535, 22652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_22667_22695(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 22667, 22695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 20860, 22707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 20860, 22707);
            }
        }

        [Fact]
        public void LocalFunctionWithLambdaCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 22719, 25667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 22805, 23855);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }
    
    static void TestMain()                                                  // Method 2
    {
        new D().M1();
    } 
}

public class D
{
    public void M1()                                                        // Method 4
    {
        L1();
        void L1()
        {
            var f = new Func<int>(
                () => 1
            );

            var f1 = new Func<int>(
                () => 2
            );

            var f2 = new Func<int, int>(
                (x) => x + 3
            );

            var f3 = new Func<int, int>(
                x => x + 4
            );

            f();
            f3(2);
        }
    }

    // Method 5 is the synthesized instance constructor for D.
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 23871, 23920);

                var
                checker = f_23103_23885_23919()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 23934, 24109);

                f_23103_23934_24108(f_23103_23934_24019(f_23103_23934_23981(checker, 1, 1, "public static void Main"), "TestMain();"), "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 24123, 24208);

                f_23103_24123_24207(f_23103_24123_24167(checker, 2, 1, "static void TestMain"), "new D().M1();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 24222, 24686);

                f_23103_24222_24685(f_23103_24222_24652(f_23103_24222_24621(f_23103_24222_24567(f_23103_24222_24535(f_23103_24222_24481(f_23103_24222_24448(f_23103_24222_24399(f_23103_24222_24370(f_23103_24222_24322(f_23103_24222_24294(f_23103_24222_24262(checker, 4, 1, "public void M1()"), "L1();"), "1"), "var f = new Func<int>"), "2"), "var f1 = new Func<int>"), "x + 3"), "var f2 = new Func<int, int>"), "x + 4"), "var f3 = new Func<int, int>"), "f();"), "f3(2);");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 24700, 24759);

                f_23103_24700_24758(checker, 5, 1, snippet: null, expectBodySpan: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 24773, 25170);

                f_23103_24773_25169(f_23103_24773_25144(f_23103_24773_25119(f_23103_24773_25094(f_23103_24773_25069(f_23103_24773_25044(f_23103_24773_25019(f_23103_24773_24994(f_23103_24773_24969(f_23103_24773_24944(f_23103_24773_24919(f_23103_24773_24894(f_23103_24773_24869(f_23103_24773_24844(f_23103_24773_24818(f_23103_24773_24793(checker, 7, 1))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25186, 25315);

                CompilationVerifier
                verifier = f_23103_25217_25314(this, source, expectedOutput: f_23103_25258_25280(checker), options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25329, 25358);

                f_23103_25329_25357(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25372, 25424);

                f_23103_25372_25423(checker, f_23103_25394_25414(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25440, 25547);

                verifier = f_23103_25451_25546(this, source, expectedOutput: f_23103_25492_25514(checker), options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25561, 25590);

                f_23103_25561_25589(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25604, 25656);

                f_23103_25604_25655(checker, f_23103_25626_25646(verifier), source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 22719, 25667);

                Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                f_23103_23885_23919()
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 23885, 23919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_23934_23981(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 23934, 23981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_23934_24019(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 23934, 24019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_23934_24108(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 23934, 24108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24123_24167(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24123, 24167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24123_24207(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24123, 24207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24262(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24294(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24322(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24370(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24399(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.False(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24448(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24481(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.False(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24535(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24567(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24621(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24652(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24222_24685(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24222, 24685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24700_24758(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet, bool
                expectBodySpan)
                {
                    var return_v = this_param.Method(method, file, snippet: snippet, expectBodySpan: expectBodySpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24700, 24758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24793(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file)
                {
                    var return_v = this_param.Method(method, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24818(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24844(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24869(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24894(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24919(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24944(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24969(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_24994(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 24994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25019(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25044(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25069(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25094(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25119(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25144(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_24773_25169(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 24773, 25169);
                    return return_v;
                }


                string
                f_23103_25258_25280(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 25258, 25280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_25217_25314(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25217, 25314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_25329_25357(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25329, 25357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_25394_25414(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 25394, 25414);
                    return return_v;
                }


                int
                f_23103_25372_25423(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25372, 25423);
                    return 0;
                }


                string
                f_23103_25492_25514(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 25492, 25514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_25451_25546(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25451, 25546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_25561_25589(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25561, 25589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_25626_25646(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 25626, 25646);
                    return return_v;
                }


                int
                f_23103_25604_25655(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 25604, 25655);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 22719, 25667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 22719, 25667);
            }
        }

        [Fact]
        public void MultipleFilesCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 25679, 27248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 25755, 26546);

                string
                source = @"
using System;

public class Program
{
#line 10 ""File1.cs""
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }
    
#line 20 ""File2.cs""
    static void TestMain()                                                  // Method 2
    {
        Fred();
        Program p = new Program();
        return;
    }

#line 30 ""File3.cs""
    static void Fred()                                                      // Method 3
    {
        return;
    }

#line 40 ""File5.cs""

    // The synthesized instance constructor is method 4 and
    // appears in the original source file, which gets file index 4.
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 26562, 26841);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 2
True
True
True
True
Method 3
File 3
True
True
Method 4
File 4
Method 6
File 5
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 26857, 27008);

                CompilationVerifier
                verifier = f_23103_26888_27007(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 27022, 27051);

                f_23103_27022_27050(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 27065, 27194);

                verifier = f_23103_27076_27193(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 27208, 27237);

                f_23103_27208_27236(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 25679, 27248);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_26888_27007(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 26888, 27007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_27022_27050(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 27022, 27050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_27076_27193(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 27076, 27193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_27208_27236(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 27208, 27236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 25679, 27248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 25679, 27248);
            }
        }

        [Fact]
        public void MultipleDeclarationsCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 27260, 29193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 27343, 28335);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)                                      // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                                      // Method 2
    {
        int x;
        int a, b;
        DoubleDeclaration(5);
        DoubleForDeclaration(5);
    }

    static int DoubleDeclaration(int x)                                         // Method 3
    {
        int c = x;
        int a, b;
        int f;

        a = b = f = c;
        int d = a, e = b;
        return d + e + f;
    }

    static int DoubleForDeclaration(int x)                                      // Method 4
    {
        for(int a = x, b = x; a + b < 10; a++)
        {
            Console.WriteLine(""Cannot get here."");
            x++;
        }

        return x;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 28349, 28691);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
Method 3
File 1
True
True
True
True
True
True
Method 4
File 1
True
True
True
False
False
False
True
Method 7
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 28707, 28825);

                CompilationVerifier
                verifier = f_23103_28738_28824(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 28839, 29182);

                f_23103_28839_29181(verifier, f_23103_28884_28970(f_23103_28884_28949(f_23103_28884_28930(ErrorCode.WRN_UnreferencedVar, "x"), "x"), 14, 13), f_23103_28989_29075(f_23103_28989_29054(f_23103_28989_29035(ErrorCode.WRN_UnreferencedVar, "a"), "a"), 15, 13), f_23103_29094_29180(f_23103_29094_29159(f_23103_29094_29140(ErrorCode.WRN_UnreferencedVar, "b"), "b"), 15, 16));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 27260, 29193);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_28738_28824(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28738, 28824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28884_28930(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28884, 28930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28884_28949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28884, 28949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28884_28970(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28884, 28970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28989_29035(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28989, 29035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28989_29054(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28989, 29054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_28989_29075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28989, 29075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_29094_29140(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 29094, 29140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_29094_29159(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 29094, 29159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_29094_29180(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 29094, 29180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_28839_29181(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 28839, 29181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 27260, 29193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 27260, 29193);
            }
        }

        [Fact]
        public void UsingAndFixedCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 29205, 30824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 29281, 30260);

                string
                source = @"
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)                                          // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                                          // Method 2
    {
        using (var memoryStream = new MemoryStream())
        {
            ;
        }

        using (MemoryStream s1 = new MemoryStream(), s2 = new MemoryStream())
        {
            ;
        }

        var otherStream = new MemoryStream();
        using (otherStream)
        {
            ;
        }

        unsafe
        {
            double[] a = { 1, 2, 3 };
            fixed(double* p = a)
            {
                ;
            }
            fixed(double* q = a, r = a)
            {
                ;
            }
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 30274, 30571);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
True
True
True
True
True
True
True
True
True
True
True
Method 5
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 30587, 30770);

                CompilationVerifier
                verifier = f_23103_30618_30769(this, source + InstrumentationHelperSource, options: TestOptions.UnsafeDebugExe, expectedOutput: expectedOutput, verify: Verification.Fails)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 30784, 30813);

                f_23103_30784_30812(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 29205, 30824);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_30618_30769(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, string
                expectedOutput, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options, expectedOutput: expectedOutput, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 30618, 30769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_30784_30812(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 30784, 30812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 29205, 30824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 29205, 30824);
            }
        }

        [Fact]
        public void ManyStatementsCoverage()                                    // Method 3
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 30836, 33643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 30960, 32959);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()
    {
        VariousStatements(2);
        Empty();
    }

    static void VariousStatements(int z)
    {
        int x = z + 10;
        switch (z)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                break;
        }

        if (x > 10)
        {
            x++;
        }
        else
        {
            x--;
        }

        for (int y = 0; y < 50; y++)
        {
            if (y < 30)
            {
                x++;
                continue;
            }
            else
                break;
        }

        int[] a = new int[] { 1, 2, 3, 4 };
        foreach (int i in a)
        {
            x++;
        }

        while (x < 100)
        {
            x++;
        }

        try
        {
            x++;
            if (x > 10)
            {
                throw new System.Exception();
            }
            x++;
        }
        catch (System.Exception)
        {
            x++;
        }
        finally
        {
            x++;
        }

        lock (new object())
        {
            ;
        }

        Console.WriteLine(x);

        try
        {
            using ((System.IDisposable)new object())
            {
                ;
            }
        }
        catch (System.Exception)
        {
        }

        // Include an infinite loop to make sure that a compiler optimization doesn't eliminate the instrumentation.
        while (true)
        {
            return;
        }
    }

    static void Empty()                                 // Method 4
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 32973, 33455);

                string
                expectedOutput = @"103
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
Method 3
File 1
True
True
False
True
False
False
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
True
True
False
True
True
True
True
True
False
True
True
True
Method 4
File 1
True
Method 7
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 33471, 33589);

                CompilationVerifier
                verifier = f_23103_33502_33588(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 33603, 33632);

                f_23103_33603_33631(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 30836, 33643);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_33502_33588(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 33502, 33588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_33603_33631(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 33603, 33631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 30836, 33643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 30836, 33643);
            }
        }

        [Fact]
        public void PatternsCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 33655, 35525);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 33726, 34865);

                string
                source = @"
using System;

public class C
{
    public static void Main()
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                 // Method 2
    {
        Student s = new Student();
        s.Name = ""Bozo"";
        s.GPA = s.Name switch { _ => 2.3 }; // switch expression is not instrumented
        Operate(s);
    }
     
    static string Operate(Person p)                         // Method 3
    {
        switch (p)
        {
            case Student s when s.GPA > 3.5:
                return $""Student {s.Name} ({s.GPA:N1})"";
            case Student s:
                return $""Student {s.Name} ({s.GPA:N1})"";
            case Teacher t:
                return $""Teacher {t.Name} of {t.Subject}"";
            default:
                return $""Person {p.Name}"";
        }
    }
}

class Person { public string Name; }
class Teacher : Person { public string Subject; }
class Student : Person { public double GPA; }

    // Methods 5 and 7 are implicit constructors.
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 34879, 35215);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
True
Method 3
File 1
True
True
False
True
False
False
True
Method 5
File 1
Method 7
File 1
Method 9
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 35231, 35349);

                CompilationVerifier
                verifier = f_23103_35262_35348(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 35363, 35514);

                f_23103_35363_35513(verifier, f_23103_35390_35512(f_23103_35390_35491(f_23103_35390_35450(ErrorCode.WRN_UnassignedInternalField, "Subject"), "Teacher.Subject", "null"), 37, 40));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 33655, 35525);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_35262_35348(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 35262, 35348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_35390_35450(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 35390, 35450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_35390_35491(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 35390, 35491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23103_35390_35512(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 35390, 35512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_35363_35513(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 35363, 35513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 33655, 35525);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 33655, 35525);
            }
        }

        [Fact]
        public void DeconstructionStatementCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 35537, 36677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 35623, 36241);

                string
                source = @"
using System;

public class C
{
    public static void Main() // Method 1
    {
        TestMain2();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain2() // Method 2
    {
        var (x, y) = new C();
    }

    static void TestMain3() // Method 3
    {
        var (x, y) = new C();
    }

    public C() // Method 4
    {
    }

    public void Deconstruct(out int x, out int y) // Method 5
    {
        x = 1;
        y = 1 switch { 1 => 2, 3 => 4, _ => 5 }; // switch expression is not instrumented
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 36255, 36534);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
Method 4
File 1
True
Method 5
File 1
True
True
True
Method 7
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 36548, 36666);

                CompilationVerifier
                verifier = f_23103_36579_36665(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 35537, 36677);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_36579_36665(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 36579, 36665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 35537, 36677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 35537, 36677);
            }
        }

        [Fact]
        public void DeconstructionForeachStatementCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 36689, 37965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 36782, 37479);

                string
                source = @"
using System;

public class C
{
    public static void Main() // Method 1
    {
        TestMain2(new C[] { new C() });
        TestMain3(new C[] { });
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain2(C[] a) // Method 2
    {
        foreach (
            var (x, y)
            in a)
            ;
    }

    static void TestMain3(C[] a) // Method 3
    {
        foreach (
            var (x, y)
            in a)
            ;
    }

    public C() // Method 4
    {
    }

    public void Deconstruct(out int x, out int y) // Method 5
    {
        x = 1;
        y = 2;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 37493, 37822);

                string
                expectedOutput = @"Flushing
Method 1
File 1
True
True
True
True
Method 2
File 1
True
True
True
Method 3
File 1
True
False
False
Method 4
File 1
True
Method 5
File 1
True
True
True
Method 7
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 37836, 37954);

                CompilationVerifier
                verifier = f_23103_37867_37953(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 36689, 37965);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_37867_37953(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 37867, 37953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 36689, 37965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 36689, 37965);
            }
        }

        [Fact]
        public void LambdaCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 37977, 39182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 38046, 38707);

                string
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();      // Method 2
    }

    static void TestMain()
    {
        int y = 5;
        Func<int, int> tester = (x) =>
        {
            while (x > 10)
            {
                return y;
            }

            return x;
        };

        y = 75;
        if (tester(20) > 50)
            Console.WriteLine(""OK"");
        else
            Console.WriteLine(""Bad"");
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 38721, 38994);

                string
                expectedOutput = @"OK
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
False
True
True
True
False
True
Method 5
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 39010, 39128);

                CompilationVerifier
                verifier = f_23103_39041_39127(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 39142, 39171);

                f_23103_39142_39170(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 37977, 39182);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_39041_39127(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 39041, 39127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_39142_39170(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 39142, 39170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 37977, 39182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 37977, 39182);
            }
        }

        [Fact]
        public void AsyncCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 39194, 41080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 39262, 40489);

                string
                source = @"
using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                                  // Method 2
    {
        Console.WriteLine(Outer(""Goo"").Result);
    }

    async static Task<string> Outer(string s)                               // Method 3
    {
        string s1 = await First(s);
        string s2 = await Second(s);

        return s1 + s2;
    }

    async static Task<string> First(string s)                               // Method 4
    {
        string result = await Second(s) + ""Glue"";
        if (result.Length > 2)
            return result;
        else
            return ""Too short"";
    }

    async static Task<string> Second(string s)                              // Method 5
    {
        string doubled = """";
        if (s.Length > 2)
            doubled = s + s;
        else
            doubled = ""HuhHuh"";
        return await Task.Factory.StartNew(() => doubled);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 40503, 40892);

                string
                expectedOutput = @"GooGooGlueGooGoo
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
Method 3
File 1
True
True
True
True
Method 4
File 1
True
True
True
False
True
Method 5
File 1
True
True
True
False
True
True
True
Method 8
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 40908, 41026);

                CompilationVerifier
                verifier = f_23103_40939_41025(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 41040, 41069);

                f_23103_41040_41068(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 39194, 41080);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_40939_41025(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 40939, 41025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_41040_41068(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 41040, 41068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 39194, 41080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 39194, 41080);
            }
        }

        [Fact]
        public void IteratorCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 41092, 42424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 41163, 41913);

                string
                source = @"
using System;                 

public class Program
{
    public static void Main(string[] args)                                  // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                                  // Method 2
    {
        foreach (var i in Goo())
        {    
            Console.WriteLine(i);
        }  
        foreach (var i in Goo())
        {    
            Console.WriteLine(i);
        }
    }

    public static System.Collections.Generic.IEnumerable<int> Goo()
    {
        for (int i = 0; i < 5; ++i)
        {
            yield return i;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 41927, 42236);

                string
                expectedOutput = @"0
1
2
3
4
0
1
2
3
4
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
True
Method 3
File 1
True
True
True
True
Method 6
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 42252, 42370);

                CompilationVerifier
                verifier = f_23103_42283_42369(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 42384, 42413);

                f_23103_42384_42412(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 41092, 42424);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_42283_42369(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 42283, 42369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_42384_42412(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 42384, 42412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 41092, 42424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 41092, 42424);
            }
        }

        [Fact]
        public void TestFieldInitializerCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 42436, 44260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 42519, 43656);

                string
                source = @"
using System;

public class C
{
    public static void Main()                                   // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                      // Method 2
    {
        C local = new C(); local = new C(1, s_z);
    }

    static int Init() => 33;                                    // Method 3

    C()                                                         // Method 4
    {
        _z = 12;
    }

    static C()                                                  // Method 5
    {
        s_z = 123;
    }

    int _x = Init();
    int _y = Init() + 12;
    int _z;
    static int s_x = Init();
    static int s_y = Init() + 153;
    static int s_z;

    C(int x)                                                    // Method 6
    {
        _z = x;
    }

    C(int a, int b)                                             // Method 7
    {
        _z = a + b;
    }

    int Prop1 { get; } = 15;
    static int Prop2 { get; } = 255;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 43670, 44072);

                string
                expectedOutput = @"
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
Method 3
File 1
True
True
Method 4
File 1
True
True
True
True
True
Method 5
File 1
True
True
True
True
True
Method 7
File 1
True
True
True
True
True
Method 11
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 44088, 44206);

                CompilationVerifier
                verifier = f_23103_44119_44205(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 44220, 44249);

                f_23103_44220_44248(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 42436, 44260);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_44119_44205(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 44119, 44205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_44220_44248(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 44220, 44248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 42436, 44260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 42436, 44260);
            }
        }

        [Fact]
        public void TestImplicitConstructorCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 44272, 45726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 44358, 45189);

                string
                source = @"
using System;

public class C
{
    public static void Main()                                   // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                      // Method 2
    {
        C local = new C();
        int x = local._x + local._y + C.s_x + C.s_y + C.s_z;
    }

    static int Init() => 33;                                    // Method 3

    // Method 6 is the implicit instance constructor.
    // Method 7 is the implicit shared constructor.

    int _x = Init();
    int _y = Init() + 12;
    static int s_x = Init();
    static int s_y = Init() + 153;
    static int s_z = 144;

    int Prop1 { get; } = 15;
    static int Prop2 { get; } = 255;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 45203, 45538);

                string
                expectedOutput = @"
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
Method 3
File 1
True
True
Method 6
File 1
True
True
True
Method 7
File 1
True
True
True
True
Method 9
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 45554, 45672);

                CompilationVerifier
                verifier = f_23103_45585_45671(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 45686, 45715);

                f_23103_45686_45714(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 44272, 45726);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_45585_45671(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 45585, 45671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_45686_45714(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 45686, 45714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 44272, 45726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 44272, 45726);
            }
        }

        [Fact]
        public void TestImplicitConstructorsWithLambdasCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 45738, 47754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 45836, 47162);

                string
                source = @"
using System;

public class C
{
    public static void Main()                                               // Method 1
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void TestMain()                                                  // Method 2
    {
        int y = s_c._function();
        D d = new D();
        int z = d._c._function();
        int zz = D.s_c._function();
        int zzz = d._c1._function();
    }

    public C(Func<int> f)                                                   // Method 3
    {
        _function = f;
    }

    static C s_c = new C(() => 115);
    Func<int> _function;
}

partial class D
{
}

partial class D
{
}

partial class D
{
    public C _c = new C(() => 120);
    public static C s_c = new C(() => 144);
    public C _c1 = new C(() => 130);
    public static C s_c1 = new C(() => 156);
}

partial class D
{
}

partial struct E
{
}

partial struct E
{
    public static C s_c = new C(() => 1444);
    public static C s_c1 = new C(() => { return 1567; });
}

// Method 4 is the synthesized static constructor for C.
// Method 5 is the synthesized instance constructor for D.
// Method 6 is the synthesized static constructor for D.
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 47176, 47566);

                string
                expectedOutput = @"
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
True
True
True
True
True
True
Method 3
File 1
True
True
Method 4
File 1
True
True
Method 5
File 1
True
True
True
True
Method 6
File 1
True
False
True
True
Method 9
File 1
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 47582, 47700);

                CompilationVerifier
                verifier = f_23103_47613_47699(this, source + InstrumentationHelperSource, expectedOutput: expectedOutput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 47714, 47743);

                f_23103_47714_47742(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 45738, 47754);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_47613_47699(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 47613, 47699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_47714_47742(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 47714, 47742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 45738, 47754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 45738, 47754);
            }
        }

        [Fact]
        public void MissingMethodNeededForAnalysis()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 47766, 49229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 47851, 48589);

                string
                source = @"
namespace System
{
    public class Object { }  
    public struct Int32 { }  
    public struct Boolean { }  
    public class String { }  
    public class Exception { }  
    public class ValueType { }  
    public class Enum { }  
    public struct Void { }  
    public class Guid { }
}

public class Console
{
    public static void WriteLine(string s) { }
    public static void WriteLine(int i) { }
    public static void WriteLine(bool b) { }
}

public class Program
{
    public static void Main(string[] args)
    {
        TestMain();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static int TestMain()
    {
        return 3;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 48605, 48829);

                ImmutableArray<Diagnostic>
                diagnostics = f_23103_48646_48828(f_23103_48646_48706(source + InstrumentationHelperSource), f_23103_48726_48827(EmitOptions.Default, f_23103_48771_48826(InstrumentationKind.TestCoverage)))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 48843, 49183);
                    foreach (Diagnostic diagnostic in f_23103_48877_48888_I(diagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23103, 48843, 49183);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 48922, 49168) || true) && (f_23103_48926_48941(diagnostic) == (int)ErrorCode.ERR_MissingPredefinedMember && (DynAbs.Tracing.TraceSender.Expression_True(23103, 48926, 49057) && f_23103_49012_49057(f_23103_49012_49035(f_23103_49012_49032(diagnostic), 0), "System.Guid")) && (DynAbs.Tracing.TraceSender.Expression_True(23103, 48926, 49100) && f_23103_49061_49100(f_23103_49061_49084(f_23103_49061_49081(diagnostic), 1), ".ctor")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(23103, 48922, 49168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49142, 49149);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(23103, 48922, 49168);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23103, 48843, 49183);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23103, 1, 341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23103, 1, 341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49199, 49218);

                f_23103_49199_49217(false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 47766, 49229);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_48646_48706(string
                source)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 48646, 48706);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_23103_48771_48826(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 48771, 48826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23103_48726_48827(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds)
                {
                    var return_v = this_param.WithInstrumentationKinds(instrumentationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 48726, 48827);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_23103_48646_48828(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, Microsoft.CodeAnalysis.Emit.EmitOptions
                options)
                {
                    var return_v = c.GetEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 48646, 48828);
                    return return_v;
                }


                int
                f_23103_48926_48941(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 48926, 48941);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_23103_49012_49032(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 49012, 49032);
                    return return_v;
                }


                object?
                f_23103_49012_49035(System.Collections.Generic.IReadOnlyList<object?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 49012, 49035);
                    return return_v;
                }


                bool
                f_23103_49012_49057(object?
                this_param, string
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49012, 49057);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_23103_49061_49081(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 49061, 49081);
                    return return_v;
                }


                object?
                f_23103_49061_49084(System.Collections.Generic.IReadOnlyList<object?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 49061, 49084);
                    return return_v;
                }


                bool
                f_23103_49061_49100(object?
                this_param, string
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49061, 49100);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_23103_48877_48888_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 48877, 48888);
                    return return_v;
                }


                int
                f_23103_49199_49217(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49199, 49217);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 47766, 49229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 47766, 49229);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Method()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 49241, 49779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49335, 49544);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    [ExcludeFromCodeCoverage]
    void M1() { Console.WriteLine(1); }

    void M2() { Console.WriteLine(1); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49558, 49661);

                var
                verifier = f_23103_49573_49660(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49677, 49717);

                f_23103_49677_49716(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49731, 49768);

                f_23103_49731_49767(verifier, "C.M2");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 49241, 49779);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_49573_49660(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49573, 49660);
                    return return_v;
                }


                int
                f_23103_49677_49716(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49677, 49716);
                    return 0;
                }


                int
                f_23103_49731_49767(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 49731, 49767);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 49241, 49779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 49241, 49779);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Ctor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 49791, 50255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 49883, 50068);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    int a = 1;

    [ExcludeFromCodeCoverage]
    public C() { Console.WriteLine(3); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50082, 50185);

                var
                verifier = f_23103_50097_50184(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50201, 50244);

                f_23103_50201_50243(verifier, "C..ctor");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 49791, 50255);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_50097_50184(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 50097, 50184);
                    return return_v;
                }


                int
                f_23103_50201_50243(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 50201, 50243);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 49791, 50255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 49791, 50255);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Cctor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 50267, 50738);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50360, 50552);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    static int a = 1;

    [ExcludeFromCodeCoverage]
    static C() { Console.WriteLine(3); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50566, 50669);

                var
                verifier = f_23103_50581_50668(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50683, 50727);

                f_23103_50683_50726(verifier, "C..cctor");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 50267, 50738);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_50581_50668(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 50581, 50668);
                    return return_v;
                }


                int
                f_23103_50683_50726(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 50683, 50726);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 50267, 50738);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 50267, 50738);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionsAndLambdas_InMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 50750, 51804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 50871, 51252);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    [ExcludeFromCodeCoverage]
    static void M1() { L1(); void L1() { new Action(() => { Console.WriteLine(1); }).Invoke(); } }
                                                      
    static void M2() { L2(); void L2() { new Action(() => { Console.WriteLine(2); }).Invoke(); } }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51266, 51369);

                var
                verifier = f_23103_51281_51368(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51385, 51425);

                f_23103_51385_51424(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51439, 51490);

                f_23103_51439_51489(verifier, "C.<M1>g__L1|0_0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51504, 51556);

                f_23103_51504_51555(verifier, "C.<>c.<M1>b__0_1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51572, 51609);

                f_23103_51572_51608(verifier, "C.M2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51623, 51690);

                f_23103_51623_51689(verifier, "C.<>c__DisplayClass1_0.<M2>g__L2|0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51713, 51777);

                f_23103_51713_51776(verifier, "C.<>c__DisplayClass1_0.<M2>b__1");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 50750, 51804);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_51281_51368(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51281, 51368);
                    return return_v;
                }


                int
                f_23103_51385_51424(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51385, 51424);
                    return 0;
                }


                int
                f_23103_51439_51489(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51439, 51489);
                    return 0;
                }


                int
                f_23103_51504_51555(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51504, 51555);
                    return 0;
                }


                int
                f_23103_51572_51608(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51572, 51608);
                    return 0;
                }


                int
                f_23103_51623_51689(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51623, 51689);
                    return 0;
                }


                int
                f_23103_51713_51776(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 51713, 51776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 50750, 51804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 50750, 51804);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 51816, 52572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 51927, 52186);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    static void M1()
    {
        L1();

        [ExcludeFromCodeCoverage]
        void L1() { new Action(() => { Console.WriteLine(1); }).Invoke(); }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 52200, 52373);

                var
                verifier = f_23103_52215_52372(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll, parseOptions: TestOptions.Regular9)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 52389, 52426);

                f_23103_52389_52425(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 52440, 52493);

                f_23103_52440_52492(verifier, "C.<M1>g__L1|0_0()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 52507, 52561);

                f_23103_52507_52560(verifier, "C.<>c.<M1>b__0_1()");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 51816, 52572);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_52215_52372(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 52215, 52372);
                    return return_v;
                }


                int
                f_23103_52389_52425(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 52389, 52425);
                    return 0;
                }


                int
                f_23103_52440_52492(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 52440, 52492);
                    return 0;
                }


                int
                f_23103_52507_52560(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 52507, 52560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 51816, 52572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 51816, 52572);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionAttributes_Multiple()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 52584, 53567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 52704, 53069);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    static void M1()
    {
#pragma warning disable 8321 // Unreferenced local function
        void L1() { Console.WriteLine(1); }

        [ExcludeFromCodeCoverage]
        void L2() { Console.WriteLine(2); }

        void L3() { Console.WriteLine(3); }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53083, 53256);

                var
                verifier = f_23103_53098_53255(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll, parseOptions: TestOptions.Regular9)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53272, 53309);

                f_23103_53272_53308(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53323, 53399);

                f_23103_53323_53398(verifier, "C.<M1>g__L1|0_0(ref C.<>c__DisplayClass0_0)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53413, 53466);

                f_23103_53413_53465(verifier, "C.<M1>g__L2|0_1()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53480, 53556);

                f_23103_53480_53555(verifier, "C.<M1>g__L3|0_2(ref C.<>c__DisplayClass0_0)");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 52584, 53567);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_53098_53255(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 53098, 53255);
                    return return_v;
                }


                int
                f_23103_53272_53308(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 53272, 53308);
                    return 0;
                }


                int
                f_23103_53323_53398(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 53323, 53398);
                    return 0;
                }


                int
                f_23103_53413_53465(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 53413, 53465);
                    return 0;
                }


                int
                f_23103_53480_53555(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 53480, 53555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 52584, 53567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 52584, 53567);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionAttributes_Nested()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 53579, 54971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 53697, 54357);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    static void M1()
    {
        L1();

        void L1()
        {
            new Action(() =>
            {
                L2();

                [ExcludeFromCodeCoverage]
                void L2()
                {
                    new Action(() =>
                    {
                        L3();

                        void L3()
                        {
                            Console.WriteLine(1);
                        }
                    }).Invoke();
                }
            }).Invoke();
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54371, 54544);

                var
                verifier = f_23103_54386_54543(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll, parseOptions: TestOptions.Regular9)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54560, 54597);

                f_23103_54560_54596(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54611, 54680);

                f_23103_54611_54679(verifier, "C.<>c__DisplayClass0_0.<M1>g__L1|0()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54694, 54760);

                f_23103_54694_54759(verifier, "C.<>c__DisplayClass0_0.<M1>b__1()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54774, 54827);

                f_23103_54774_54826(verifier, "C.<M1>g__L2|0_2()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54841, 54893);

                f_23103_54841_54892(verifier, "C.<>c.<M1>b__0_3");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 54907, 54960);

                f_23103_54907_54959(verifier, "C.<M1>g__L3|0_4()");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 53579, 54971);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_54386_54543(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54386, 54543);
                    return return_v;
                }


                int
                f_23103_54560_54596(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54560, 54596);
                    return 0;
                }


                int
                f_23103_54611_54679(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54611, 54679);
                    return 0;
                }


                int
                f_23103_54694_54759(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54694, 54759);
                    return 0;
                }


                int
                f_23103_54774_54826(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54774, 54826);
                    return 0;
                }


                int
                f_23103_54841_54892(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54841, 54892);
                    return 0;
                }


                int
                f_23103_54907_54959(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 54907, 54959);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 53579, 54971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 53579, 54971);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionsAndLambdas_InInitializers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 54983, 56098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55110, 55552);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    Action IF = new Action(() => { Console.WriteLine(1); });
    Action IP { get; } = new Action(() => { Console.WriteLine(2); });

    static Action SF = new Action(() => { Console.WriteLine(3); });
    static Action SP { get; } = new Action(() => { Console.WriteLine(4); });

    [ExcludeFromCodeCoverage]
    C() {}

    static C() {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55566, 55669);

                var
                verifier = f_23103_55581_55668(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55685, 55728);

                f_23103_55685_55727(verifier, "C..ctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55742, 55797);

                f_23103_55742_55796(verifier, "C.<>c.<.ctor>b__8_0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55811, 55866);

                f_23103_55811_55865(verifier, "C.<>c.<.ctor>b__8_1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55882, 55923);

                f_23103_55882_55922(verifier, "C..cctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 55937, 56005);

                f_23103_55937_56004(verifier, "C.<>c__DisplayClass9_0.<.cctor>b__0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56019, 56087);

                f_23103_56019_56086(verifier, "C.<>c__DisplayClass9_0.<.cctor>b__1");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 54983, 56098);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_55581_55668(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55581, 55668);
                    return return_v;
                }


                int
                f_23103_55685_55727(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55685, 55727);
                    return 0;
                }


                int
                f_23103_55742_55796(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55742, 55796);
                    return 0;
                }


                int
                f_23103_55811_55865(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55811, 55865);
                    return 0;
                }


                int
                f_23103_55882_55922(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55882, 55922);
                    return 0;
                }


                int
                f_23103_55937_56004(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 55937, 56004);
                    return 0;
                }


                int
                f_23103_56019_56086(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56019, 56086);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 54983, 56098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 54983, 56098);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_LocalFunctionsAndLambdas_InAccessors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 56110, 57304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56234, 56676);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    [ExcludeFromCodeCoverage]
    int P1 
    { 
        get { L1(); void L1() { Console.WriteLine(1); } return 1; } 
        set { L2(); void L2() { Console.WriteLine(2); } } 
    }

    int P2
    { 
        get { L3(); void L3() { Console.WriteLine(3); } return 3; } 
        set { L4(); void L4() { Console.WriteLine(4); } } 
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56690, 56793);

                var
                verifier = f_23103_56705_56792(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56809, 56853);

                f_23103_56809_56852(verifier, "C.P1.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56867, 56911);

                f_23103_56867_56910(verifier, "C.P1.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56925, 56980);

                f_23103_56925_56979(verifier, "C.<get_P1>g__L1|1_0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 56994, 57049);

                f_23103_56994_57048(verifier, "C.<set_P1>g__L2|2_0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57065, 57106);

                f_23103_57065_57105(verifier, "C.P2.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57120, 57161);

                f_23103_57120_57160(verifier, "C.P2.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57175, 57227);

                f_23103_57175_57226(verifier, "C.<get_P2>g__L3|4_0");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57241, 57293);

                f_23103_57241_57292(verifier, "C.<set_P2>g__L4|5_0");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 56110, 57304);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_56705_56792(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56705, 56792);
                    return return_v;
                }


                int
                f_23103_56809_56852(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56809, 56852);
                    return 0;
                }


                int
                f_23103_56867_56910(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56867, 56910);
                    return 0;
                }


                int
                f_23103_56925_56979(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56925, 56979);
                    return 0;
                }


                int
                f_23103_56994_57048(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 56994, 57048);
                    return 0;
                }


                int
                f_23103_57065_57105(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 57065, 57105);
                    return 0;
                }


                int
                f_23103_57120_57160(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 57120, 57160);
                    return 0;
                }


                int
                f_23103_57175_57226(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 57175, 57226);
                    return 0;
                }


                int
                f_23103_57241_57292(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 57241, 57292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 56110, 57304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 56110, 57304);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Type()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 57316, 58779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57408, 57868);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
class C
{
    int x = 1;

    static C() { }

    void M1() { Console.WriteLine(1); }

    int P { get => 1; set { } }

    event Action E { add { } remove { } }
}

class D
{
    int x = 1;

    static D() { }

    void M1() { Console.WriteLine(1); }

    int P { get => 1; set { } }

    event Action E { add { } remove { } }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 57882, 57985);

                var
                verifier = f_23103_57897_57984(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58001, 58044);

                f_23103_58001_58043(verifier, "C..ctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58058, 58102);

                f_23103_58058_58101(verifier, "C..cctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58116, 58156);

                f_23103_58116_58155(verifier, "C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58170, 58213);

                f_23103_58170_58212(verifier, "C.P.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58227, 58270);

                f_23103_58227_58269(verifier, "C.P.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58284, 58327);

                f_23103_58284_58326(verifier, "C.E.add");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58341, 58387);

                f_23103_58341_58386(verifier, "C.E.remove");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58403, 58443);

                f_23103_58403_58442(verifier, "D..ctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58457, 58498);

                f_23103_58457_58497(verifier, "D..cctor");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58512, 58549);

                f_23103_58512_58548(verifier, "D.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58563, 58603);

                f_23103_58563_58602(verifier, "D.P.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58617, 58657);

                f_23103_58617_58656(verifier, "D.P.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58671, 58711);

                f_23103_58671_58710(verifier, "D.E.add");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58725, 58768);

                f_23103_58725_58767(verifier, "D.E.remove");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 57316, 58779);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_57897_57984(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 57897, 57984);
                    return return_v;
                }


                int
                f_23103_58001_58043(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58001, 58043);
                    return 0;
                }


                int
                f_23103_58058_58101(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58058, 58101);
                    return 0;
                }


                int
                f_23103_58116_58155(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58116, 58155);
                    return 0;
                }


                int
                f_23103_58170_58212(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58170, 58212);
                    return 0;
                }


                int
                f_23103_58227_58269(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58227, 58269);
                    return 0;
                }


                int
                f_23103_58284_58326(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58284, 58326);
                    return 0;
                }


                int
                f_23103_58341_58386(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58341, 58386);
                    return 0;
                }


                int
                f_23103_58403_58442(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58403, 58442);
                    return 0;
                }


                int
                f_23103_58457_58497(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58457, 58497);
                    return 0;
                }


                int
                f_23103_58512_58548(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58512, 58548);
                    return 0;
                }


                int
                f_23103_58563_58602(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58563, 58602);
                    return 0;
                }


                int
                f_23103_58617_58656(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58617, 58656);
                    return 0;
                }


                int
                f_23103_58671_58710(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58671, 58710);
                    return 0;
                }


                int
                f_23103_58725_58767(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 58725, 58767);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 57316, 58779);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 57316, 58779);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_NestedType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 58791, 60276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 58889, 59745);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class A
{
    class B1
    {
        [ExcludeFromCodeCoverage]
        class C
        {
            void M1() { Console.WriteLine(1); }
        }

        void M2() { Console.WriteLine(2); }
    }

    [ExcludeFromCodeCoverage]
    partial class B2
    {
        partial class C1
        {
            void M3() { Console.WriteLine(3); }
        }

        class C2
        {
            void M4() { Console.WriteLine(4); }
        }

        void M5() { Console.WriteLine(5); }
    }

    partial class B2
    {
        [ExcludeFromCodeCoverage]
        partial class C1
        {
            void M6() { Console.WriteLine(6); }
        }

        void M7() { Console.WriteLine(7); }
    }

    void M8() { Console.WriteLine(8); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 59759, 59862);

                var
                verifier = f_23103_59774_59861(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 59878, 59923);

                f_23103_59878_59922(verifier, "A.B1.C.M1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 59937, 59977);

                f_23103_59937_59976(verifier, "A.B1.M2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 59991, 60037);

                f_23103_59991_60036(verifier, "A.B2.C1.M3");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60051, 60097);

                f_23103_60051_60096(verifier, "A.B2.C2.M4");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60111, 60157);

                f_23103_60111_60156(verifier, "A.B2.C1.M6");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60171, 60214);

                f_23103_60171_60213(verifier, "A.B2.M7");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60228, 60265);

                f_23103_60228_60264(verifier, "A.M8");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 58791, 60276);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_59774_59861(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 59774, 59861);
                    return return_v;
                }


                int
                f_23103_59878_59922(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 59878, 59922);
                    return 0;
                }


                int
                f_23103_59937_59976(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 59937, 59976);
                    return 0;
                }


                int
                f_23103_59991_60036(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 59991, 60036);
                    return 0;
                }


                int
                f_23103_60051_60096(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60051, 60096);
                    return 0;
                }


                int
                f_23103_60111_60156(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60111, 60156);
                    return 0;
                }


                int
                f_23103_60171_60213(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60171, 60213);
                    return 0;
                }


                int
                f_23103_60228_60264(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60228, 60264);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 58791, 60276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 58791, 60276);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Accessors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 60288, 61343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60385, 60753);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    [ExcludeFromCodeCoverage]
    int P1 { get => 1; set {} }
          
    [ExcludeFromCodeCoverage]
    event Action E1 { add { } remove { } }
                                            
    int P2 { get => 1; set {} }
    event Action E2 { add { } remove { } }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60767, 60870);

                var
                verifier = f_23103_60782_60869(this, source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60886, 60930);

                f_23103_60886_60929(verifier, "C.P1.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 60944, 60988);

                f_23103_60944_60987(verifier, "C.P1.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61002, 61046);

                f_23103_61002_61045(verifier, "C.E1.add");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61060, 61107);

                f_23103_61060_61106(verifier, "C.E1.remove");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61123, 61164);

                f_23103_61123_61163(verifier, "C.P2.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61178, 61219);

                f_23103_61178_61218(verifier, "C.P2.set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61233, 61274);

                f_23103_61233_61273(verifier, "C.E2.add");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61288, 61332);

                f_23103_61288_61331(verifier, "C.E2.remove");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 60288, 61343);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_60782_60869(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60782, 60869);
                    return return_v;
                }


                int
                f_23103_60886_60929(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60886, 60929);
                    return 0;
                }


                int
                f_23103_60944_60987(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 60944, 60987);
                    return 0;
                }


                int
                f_23103_61002_61045(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61002, 61045);
                    return 0;
                }


                int
                f_23103_61060_61106(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61060, 61106);
                    return 0;
                }


                int
                f_23103_61123_61163(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61123, 61163);
                    return 0;
                }


                int
                f_23103_61178_61218(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61178, 61218);
                    return 0;
                }


                int
                f_23103_61233_61273(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61233, 61273);
                    return 0;
                }


                int
                f_23103_61288_61331(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61288, 61331);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 60288, 61343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 60288, 61343);
            }
        }

        [CompilerTrait(CompilerFeature.InitOnlySetters)]
        [Fact]
        public void ExcludeFromCodeCoverageAttribute_Accessors_Init()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 61355, 62154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61515, 61710);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

class C
{
    [ExcludeFromCodeCoverage]
    int P1 { get => 1; init {} }

    int P2 { get => 1; init {} }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61724, 61911);

                var
                verifier = f_23103_61739_61910(this, source + InstrumentationHelperSource + IsExternalInitTypeDefinition, options: TestOptions.ReleaseDll, parseOptions: TestOptions.Regular9)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61927, 61971);

                f_23103_61927_61970(verifier, "C.P1.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 61985, 62030);

                f_23103_61985_62029(verifier, "C.P1.init");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62046, 62087);

                f_23103_62046_62086(verifier, "C.P2.get");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62101, 62143);

                f_23103_62101_62142(verifier, "C.P2.init");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 61355, 62154);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_61739_61910(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61739, 61910);
                    return return_v;
                }


                int
                f_23103_61927_61970(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61927, 61970);
                    return 0;
                }


                int
                f_23103_61985_62029(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 61985, 62029);
                    return 0;
                }


                int
                f_23103_62046_62086(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62046, 62086);
                    return 0;
                }


                int
                f_23103_62101_62142(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62101, 62142);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 61355, 62154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 61355, 62154);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_CustomDefinition_Good()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 62166, 63166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62275, 62682);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ExcludeFromCodeCoverageAttribute : Attribute
    {
        public ExcludeFromCodeCoverageAttribute() {}
    }
}

[ExcludeFromCodeCoverage]
class C
{
    void M() {}
}

class D
{
    void M() {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62696, 62807);

                var
                c = f_23103_62704_62806(source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62821, 62843);

                f_23103_62821_62842(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 62859, 63010);

                var
                verifier = f_23103_62874_63009(this, c, emitOptions: f_23103_62907_63008(EmitOptions.Default, f_23103_62952_63007(InstrumentationKind.TestCoverage)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63024, 63050);

                f_23103_63024_63049(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63066, 63105);

                f_23103_63066_63104(verifier, "C.M");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63119, 63155);

                f_23103_63119_63154(verifier, "D.M");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 62166, 63166);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_62704_62806(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62704, 62806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_62821_62842(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62821, 62842);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_23103_62952_63007(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62952, 63007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23103_62907_63008(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds)
                {
                    var return_v = this_param.WithInstrumentationKinds(instrumentationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62907, 63008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_62874_63009(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 62874, 63009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_63024_63049(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63024, 63049);
                    return return_v;
                }


                int
                f_23103_63066_63104(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertNotInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63066, 63104);
                    return 0;
                }


                int
                f_23103_63119_63154(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63119, 63154);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 62166, 63166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 62166, 63166);
            }
        }

        [Fact]
        public void ExcludeFromCodeCoverageAttribute_CustomDefinition_Bad()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 63178, 64182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63286, 63701);

                string
                source = @"
using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ExcludeFromCodeCoverageAttribute : Attribute
    {
        public ExcludeFromCodeCoverageAttribute(int x) {}
    }
}

[ExcludeFromCodeCoverage(1)]
class C
{
    void M() {}
}

class D
{
    void M() {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63715, 63826);

                var
                c = f_23103_63723_63825(source + InstrumentationHelperSource, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63840, 63862);

                f_23103_63840_63861(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 63878, 64029);

                var
                verifier = f_23103_63893_64028(this, c, emitOptions: f_23103_63926_64027(EmitOptions.Default, f_23103_63971_64026(InstrumentationKind.TestCoverage)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 64043, 64069);

                f_23103_64043_64068(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 64085, 64121);

                f_23103_64085_64120(verifier, "C.M");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 64135, 64171);

                f_23103_64135_64170(verifier, "D.M");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 63178, 64182);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_63723_63825(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63723, 63825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_63840_63861(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63840, 63861);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_23103_63971_64026(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63971, 64026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23103_63926_64027(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds)
                {
                    var return_v = this_param.WithInstrumentationKinds(instrumentationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63926, 64027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_63893_64028(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, emitOptions: emitOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 63893, 64028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_64043_64068(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyEmitDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 64043, 64068);
                    return return_v;
                }


                int
                f_23103_64085_64120(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 64085, 64120);
                    return 0;
                }


                int
                f_23103_64135_64170(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName)
                {
                    AssertInstrumented(verifier, qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 64135, 64170);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 63178, 64182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 63178, 64182);
            }
        }

        [Fact]
        public void TestPartialMethodsWithImplementation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 64194, 67299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 64285, 65226);

                var
                source = @"
using System;

public partial class Class1<T>
{
    partial void Method1<U>(int x);
    public void Method2(int x) 
    {
        Console.WriteLine($""Method2: x = {x}"");
        Method1<T>(x);
    }
}

public partial class Class1<T>
{
    partial void Method1<U>(int x)
    {
        Console.WriteLine($""Method1: x = {x}"");
        if (x > 0)
        {
             Console.WriteLine(""Method1: x > 0"");
             Method1<U>(0);
        }
        else if (x < 0)
        {
            Console.WriteLine(""Method1: x < 0"");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Test();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void Test()
    {
        Console.WriteLine(""Test"");
        var c = new Class1<int>();
        c.Method2(1);
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 65242, 65291);

                var
                checker = f_23103_65256_65290()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 65305, 65669);

                f_23103_65305_65668(f_23103_65305_65635(f_23103_65305_65602(f_23103_65305_65535(f_23103_65305_65494(f_23103_65305_65428(f_23103_65305_65359(checker, 1, 1, "partial void Method1<U>(int x)"), @"Console.WriteLine($""Method1: x = {x}"");"), @"Console.WriteLine(""Method1: x > 0"");"), "Method1<U>(0);"), @"Console.WriteLine(""Method1: x < 0"");"), "x < 0)"), "x > 0)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 65683, 65844);

                f_23103_65683_65843(f_23103_65683_65802(f_23103_65683_65733(checker, 2, 1, "public void Method2(int x)"), @"Console.WriteLine($""Method2: x = {x}"");"), "Method1<T>(x);");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 65858, 65913);

                f_23103_65858_65912(checker, 3, 1, ".ctor()", expectBodySpan: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 65927, 66113);

                f_23103_65927_66112(f_23103_65927_66023(f_23103_65927_65989(checker, 4, 1, "public static void Main(string[] args)"), "Test();"), "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 66127, 66319);

                f_23103_66127_66318(f_23103_66127_66278(f_23103_66127_66225(f_23103_66127_66169(checker, 5, 1, "static void Test()"), @"Console.WriteLine(""Test"");"), "var c = new Class1<int>();"), "c.Method2(1);");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 66333, 66730);

                f_23103_66333_66729(f_23103_66333_66704(f_23103_66333_66679(f_23103_66333_66654(f_23103_66333_66629(f_23103_66333_66604(f_23103_66333_66579(f_23103_66333_66554(f_23103_66333_66529(f_23103_66333_66504(f_23103_66333_66479(f_23103_66333_66454(f_23103_66333_66429(f_23103_66333_66404(f_23103_66333_66378(f_23103_66333_66353(checker, 8, 1))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 66746, 66866);

                var
                expectedOutput = @"Test
Method2: x = 1
Method1: x = 1
Method1: x > 0
Method1: x = 0
" + f_23103_66843_66865(checker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 66882, 66971);

                var
                verifier = f_23103_66897_66970(this, source, expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 66985, 67037);

                f_23103_66985_67036(checker, f_23103_67007_67027(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67051, 67080);

                f_23103_67051_67079(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67096, 67179);

                verifier = f_23103_67107_67178(this, source, expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67193, 67245);

                f_23103_67193_67244(checker, f_23103_67215_67235(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67259, 67288);

                f_23103_67259_67287(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 64194, 67299);

                Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                f_23103_65256_65290()
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65256, 65290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65359(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65428(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65494(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65535(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65602(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.False(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65635(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65305_65668(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65305, 65668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65683_65733(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65683, 65733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65683_65802(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65683, 65802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65683_65843(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65683, 65843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65858_65912(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet, bool
                expectBodySpan)
                {
                    var return_v = this_param.Method(method, file, snippet, expectBodySpan: expectBodySpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65858, 65912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65927_65989(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65927, 65989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65927_66023(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65927, 66023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_65927_66112(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 65927, 66112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66127_66169(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66127, 66169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66127_66225(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66127, 66225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66127_66278(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66127, 66278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66127_66318(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66127, 66318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66353(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file)
                {
                    var return_v = this_param.Method(method, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66378(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66404(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66429(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66454(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66479(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66504(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66529(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66554(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66579(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66604(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66629(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66654(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66679(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66704(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_66333_66729(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66333, 66729);
                    return return_v;
                }


                string
                f_23103_66843_66865(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 66843, 66865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_66897_66970(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66897, 66970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_67007_67027(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 67007, 67027);
                    return return_v;
                }


                int
                f_23103_66985_67036(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 66985, 67036);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_67051_67079(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 67051, 67079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_67107_67178(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 67107, 67178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_67215_67235(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 67215, 67235);
                    return return_v;
                }


                int
                f_23103_67193_67244(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 67193, 67244);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_67259_67287(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 67259, 67287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 64194, 67299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 64194, 67299);
            }
        }

        [Fact]
        public void TestPartialMethodsWithoutImplementation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 67311, 69588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67405, 67982);

                var
                source = @"
using System;

public partial class Class1<T>
{
    partial void Method1<U>(int x);
    public void Method2(int x) 
    {
        Console.WriteLine($""Method2: x = {x}"");
        Method1<T>(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Test();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void Test()
    {
        Console.WriteLine(""Test"");
        var c = new Class1<int>();
        c.Method2(1);
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 67998, 68047);

                var
                checker = f_23103_68012_68046()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 68061, 68181);

                f_23103_68061_68180(f_23103_68061_68111(checker, 1, 1, "public void Method2(int x)"), @"Console.WriteLine($""Method2: x = {x}"");");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 68195, 68250);

                f_23103_68195_68249(checker, 2, 1, ".ctor()", expectBodySpan: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 68264, 68450);

                f_23103_68264_68449(f_23103_68264_68360(f_23103_68264_68326(checker, 3, 1, "public static void Main(string[] args)"), "Test();"), "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 68464, 68656);

                f_23103_68464_68655(f_23103_68464_68615(f_23103_68464_68562(f_23103_68464_68506(checker, 4, 1, "static void Test()"), @"Console.WriteLine(""Test"");"), "var c = new Class1<int>();"), "c.Method2(1);");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 68670, 69067);

                f_23103_68670_69066(f_23103_68670_69041(f_23103_68670_69016(f_23103_68670_68991(f_23103_68670_68966(f_23103_68670_68941(f_23103_68670_68916(f_23103_68670_68891(f_23103_68670_68866(f_23103_68670_68841(f_23103_68670_68816(f_23103_68670_68791(f_23103_68670_68766(f_23103_68670_68741(f_23103_68670_68715(f_23103_68670_68690(checker, 7, 1))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69083, 69155);

                var
                expectedOutput = @"Test
Method2: x = 1
" + f_23103_69132_69154(checker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69171, 69260);

                var
                verifier = f_23103_69186_69259(this, source, expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69274, 69326);

                f_23103_69274_69325(checker, f_23103_69296_69316(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69340, 69369);

                f_23103_69340_69368(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69385, 69468);

                verifier = f_23103_69396_69467(this, source, expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69482, 69534);

                f_23103_69482_69533(checker, f_23103_69504_69524(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69548, 69577);

                f_23103_69548_69576(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 67311, 69588);

                Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                f_23103_68012_68046()
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68012, 68046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68061_68111(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68061, 68111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68061_68180(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68061, 68180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68195_68249(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet, bool
                expectBodySpan)
                {
                    var return_v = this_param.Method(method, file, snippet, expectBodySpan: expectBodySpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68195, 68249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68264_68326(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68264, 68326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68264_68360(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68264, 68360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68264_68449(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68264, 68449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68464_68506(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet)
                {
                    var return_v = this_param.Method(method, file, snippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68464, 68506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68464_68562(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68464, 68562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68464_68615(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68464, 68615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68464_68655(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68464, 68655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68690(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file)
                {
                    var return_v = this_param.Method(method, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68715(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68741(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68766(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68791(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68816(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68841(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68866(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68891(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68916(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68941(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68966(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_68991(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 68991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_69016(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 69016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_69041(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 69041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_68670_69066(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 68670, 69066);
                    return return_v;
                }


                string
                f_23103_69132_69154(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 69132, 69154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_69186_69259(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69186, 69259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_69296_69316(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 69296, 69316);
                    return return_v;
                }


                int
                f_23103_69274_69325(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69274, 69325);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_69340_69368(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69340, 69368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_69396_69467(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69396, 69467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_69504_69524(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 69504, 69524);
                    return return_v;
                }


                int
                f_23103_69482_69533(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69482, 69533);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_69548_69576(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 69548, 69576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 67311, 69588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 67311, 69588);
            }
        }

        [Fact]
        public void TestSynthesizedConstructorWithSpansInMultipleFilesCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 69600, 71535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 69713, 70156);

                var
                source1 = @"
using System;

public partial class Class1<T>
{
    private int x = 1;
}

public class Program
{
    public static void Main(string[] args)
    {
        Test();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void Test()
    {
        Console.WriteLine(""Test"");
        var c = new Class1<int>();
        c.Method1(1);
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 70172, 70316);

                var
                source2 = @"
public partial class Class1<T>
{
    private int y = 2;
}

public partial class Class1<T>
{
    private int z = 3;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 70332, 70653);

                var
                source3 = @"
using System;

public partial class Class1<T>
{
    private Action<int> a = i =>
        {
            Console.WriteLine(i);
        };

    public void Method1(int i)
    {
        a(i);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 70669, 70858);

                var
                sources = new[] {
                (Name: "b.cs", Content: source1),
                (Name: "c.cs", Content: source2),
                (Name: "a.cs", Content: source3)
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 70874, 71232);

                var
                expectedOutput = @"Test
1
1
2
3
Flushing
Method 1
File 1
True
True
True
True
True
Method 2
File 1
File 2
File 3
True
True
True
True
True
Method 3
File 2
True
True
True
Method 4
File 2
True
True
True
True
Method 7
File 2
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 71248, 71338);

                var
                verifier = f_23103_71263_71337(this, sources, expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 71352, 71381);

                f_23103_71352_71380(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 71397, 71481);

                verifier = f_23103_71408_71480(this, sources, expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 71495, 71524);

                f_23103_71495_71523(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 69600, 71535);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_71263_71337(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, (string Name, string Content)[]
                sources, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(sources, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 71263, 71337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_71352_71380(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 71352, 71380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_71408_71480(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, (string Name, string Content)[]
                sources, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(sources, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 71408, 71480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_71495_71523(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 71495, 71523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 69600, 71535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 69600, 71535);
            }
        }

        [Fact]
        public void TestSynthesizedStaticConstructorWithSpansInMultipleFilesCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 71547, 73551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 71666, 72126);

                var
                source1 = @"
using System;

public partial class Class1<T>
{
    private static int x = 1;
}

public class Program
{
    public static void Main(string[] args)
    {
        Test();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void Test()
    {
        Console.WriteLine(""Test"");
        var c = new Class1<int>();
        Class1<int>.Method1(1);
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 72142, 72300);

                var
                source2 = @"
public partial class Class1<T>
{
    private static int y = 2;
}

public partial class Class1<T>
{
    private static int z = 3;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 72316, 72651);

                var
                source3 = @"
using System;

public partial class Class1<T>
{
    private static Action<int> a = i =>
        {
            Console.WriteLine(i);
        };

    public static void Method1(int i)
    {
        a(i);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 72667, 72856);

                var
                sources = new[] {
                (Name: "b.cs", Content: source1),
                (Name: "c.cs", Content: source2),
                (Name: "a.cs", Content: source3)
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 72872, 73248);

                var
                expectedOutput = @"Test
1
1
2
3
Flushing
Method 1
File 1
True
True
True
True
True
Method 2
File 2
Method 3
File 1
File 2
File 3
True
True
True
True
True
Method 4
File 2
True
True
True
Method 5
File 2
True
True
True
True
Method 8
File 2
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 73264, 73354);

                var
                verifier = f_23103_73279_73353(this, sources, expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 73368, 73397);

                f_23103_73368_73396(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 73413, 73497);

                verifier = f_23103_73424_73496(this, sources, expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 73511, 73540);

                f_23103_73511_73539(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 71547, 73551);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_73279_73353(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, (string Name, string Content)[]
                sources, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(sources, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 73279, 73353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_73368_73396(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 73368, 73396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_73424_73496(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, (string Name, string Content)[]
                sources, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(sources, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 73424, 73496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_73511_73539(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 73511, 73539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 71547, 73551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 71547, 73551);
            }
        }

        [Fact]
        public void TestLineDirectiveCoverage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 73563, 74754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 73643, 74158);

                var
                source = @"
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Test();
        Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();
    }

    static void Test()
    {
#line 300 ""File2.cs""
        Console.WriteLine(""Start"");
#line hidden
        Console.WriteLine(""Hidden"");
#line default
        Console.WriteLine(""Visible"");
#line 400 ""File3.cs""
        Console.WriteLine(""End"");
    }
}
" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74174, 74453);

                var
                expectedOutput = @"Start
Hidden
Visible
End
Flushing
Method 1
File 1
True
True
True
Method 2
File 1
File 2
File 3
True
True
True
True
True
Method 5
File 3
True
True
False
True
True
True
True
True
True
True
True
True
True
True
True
True
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74469, 74558);

                var
                verifier = f_23103_74484_74557(this, source, expectedOutput, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74572, 74601);

                f_23103_74572_74600(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74617, 74700);

                verifier = f_23103_74628_74699(this, source, expectedOutput, options: TestOptions.DebugExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74714, 74743);

                f_23103_74714_74742(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 73563, 74754);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_74484_74557(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 74484, 74557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_74572_74600(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 74572, 74600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_74628_74699(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 74628, 74699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_74714_74742(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 74714, 74742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 73563, 74754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 73563, 74754);
            }
        }

        [Fact]
        [CompilerTrait(CompilerFeature.TopLevelStatements)]
        public void TopLevelStatements_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 74766, 76409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 74903, 75106);

                var
                source = @"
using System;

Test();
Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();

static void Test()
{
    Console.WriteLine(""Test"");
}

" + InstrumentationHelperSource
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 75122, 75171);

                var
                checker = f_23103_75136_75170()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 75185, 75421);

                f_23103_75185_75420(f_23103_75185_75364(f_23103_75185_75275(f_23103_75185_75241(checker, 1, 1, snippet: "", expectBodySpan: false), "Test();"), "Microsoft.CodeAnalysis.Runtime.Instrumentation.FlushPayload();"), @"Console.WriteLine(""Test"");");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 75435, 75832);

                f_23103_75435_75831(f_23103_75435_75806(f_23103_75435_75781(f_23103_75435_75756(f_23103_75435_75731(f_23103_75435_75706(f_23103_75435_75681(f_23103_75435_75656(f_23103_75435_75631(f_23103_75435_75606(f_23103_75435_75581(f_23103_75435_75556(f_23103_75435_75531(f_23103_75435_75506(f_23103_75435_75480(f_23103_75435_75455(checker, 4, 1))))))))))))))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 75848, 75904);

                var
                expectedOutput = @"Test
" + f_23103_75881_75903(checker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 75920, 76045);

                var
                verifier = f_23103_75935_76044(this, source, expectedOutput, options: TestOptions.ReleaseExe, parseOptions: TestOptions.Regular9)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76059, 76111);

                f_23103_76059_76110(checker, f_23103_76081_76101(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76125, 76154);

                f_23103_76125_76153(verifier);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76170, 76289);

                verifier = f_23103_76181_76288(this, source, expectedOutput, options: TestOptions.DebugExe, parseOptions: TestOptions.Regular9);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76303, 76355);

                f_23103_76303_76354(checker, f_23103_76325_76345(verifier), source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76369, 76398);

                f_23103_76369_76397(verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 74766, 76409);

                Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                f_23103_75136_75170()
                {
                    var return_v = new Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75136, 75170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75185_75241(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file, string
                snippet, bool
                expectBodySpan)
                {
                    var return_v = this_param.Method(method, file, snippet: snippet, expectBodySpan: expectBodySpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75185, 75241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75185_75275(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75185, 75275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75185_75364(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75185, 75364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75185_75420(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param, string
                expectedSourceSnippet)
                {
                    var return_v = this_param.True(expectedSourceSnippet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75185, 75420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75455(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, int
                method, int
                file)
                {
                    var return_v = this_param.Method(method, file);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75480(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75506(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.False();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75531(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75556(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75581(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75606(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75631(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75656(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75681(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75706(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75731(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75756(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75781(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75806(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                f_23103_75435_75831(Microsoft.CodeAnalysis.Test.Utilities.BaseInstrumentationChecker.MethodChecker
                this_param)
                {
                    var return_v = this_param.True();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75435, 75831);
                    return return_v;
                }


                string
                f_23103_75881_75903(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param)
                {
                    var return_v = this_param.ExpectedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 75881, 75903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_75935_76044(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 75935, 76044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_76081_76101(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 76081, 76101);
                    return return_v;
                }


                int
                f_23103_76059_76110(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76059, 76110);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_76125_76153(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76125, 76153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_76181_76288(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicInstrumentationTests
                this_param, string
                source, string
                expectedOutput, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = this_param.CompileAndVerify(source, expectedOutput, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76181, 76288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_23103_76325_76345(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 76325, 76345);
                    return return_v;
                }


                int
                f_23103_76303_76354(Microsoft.CodeAnalysis.Test.Utilities.CSharpInstrumentationChecker
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, string
                source)
                {
                    this_param.CompleteCheck(compilation, source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76303, 76354);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23103_76369_76397(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76369, 76397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 74766, 76409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 74766, 76409);
            }
        }

        private static void AssertNotInstrumented(CompilationVerifier verifier, string qualifiedMethodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 76534, 76603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76537, 76603);
                f_23103_76537_76603(verifier, qualifiedMethodName, expected: false); DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 76534, 76603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 76534, 76603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 76534, 76603);
            }
        }

        private static void AssertInstrumented(CompilationVerifier verifier, string qualifiedMethodName, bool expected = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23103, 76616, 77271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 76759, 76813);

                string
                il = f_23103_76771_76812(verifier, qualifiedMethodName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 77009, 77083);

                bool
                instrumented = f_23103_77029_77057(il, "CreatePayload") || (DynAbs.Tracing.TraceSender.Expression_False(23103, 77029, 77082) || f_23103_77061_77082(il, "bool[]"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 77099, 77260);

                f_23103_77099_77259(expected == instrumented, $"Method '{qualifiedMethodName}' should {((DynAbs.Tracing.TraceSender.Conditional_F1(23103, 77179, 77187) || ((expected && DynAbs.Tracing.TraceSender.Conditional_F2(23103, 77190, 77194)) || DynAbs.Tracing.TraceSender.Conditional_F3(23103, 77197, 77205))) ? "be" : "not be")} instrumented. Actual IL:{f_23103_77233_77252()}{il}");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23103, 76616, 77271);

                string
                f_23103_76771_76812(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName)
                {
                    var return_v = this_param.VisualizeIL(qualifiedMethodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76771, 76812);
                    return return_v;
                }


                bool
                f_23103_77029_77057(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77029, 77057);
                    return return_v;
                }


                bool
                f_23103_77061_77082(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77061, 77082);
                    return return_v;
                }


                string
                f_23103_77233_77252()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23103, 77233, 77252);
                    return return_v;
                }


                int
                f_23103_77099_77259(bool
                condition, string
                userMessage)
                {
                    Assert.True(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77099, 77259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 76616, 77271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 76616, 77271);
            }
        }

        private CompilationVerifier CompileAndVerify(string source, string expectedOutput = null, CSharpCompilationOptions options = null, CSharpParseOptions parseOptions = null, Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 77283, 77934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 77521, 77923);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompileAndVerify(source, expectedOutput: expectedOutput, options: f_23103_77651_77710((options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(23103, 77652, 77685) ?? TestOptions.ReleaseExe)), true), parseOptions: parseOptions, emitOptions: f_23103_77787_77888(EmitOptions.Default, f_23103_77832_77887(InstrumentationKind.TestCoverage)), verify: verify), 23103, 77528, 77922);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 77283, 77934);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23103_77651_77710(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.WithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77651, 77710);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_23103_77832_77887(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77832, 77887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23103_77787_77888(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds)
                {
                    var return_v = this_param.WithInstrumentationKinds(instrumentationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 77787, 77888);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 77283, 77934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 77283, 77934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CompilationVerifier CompileAndVerify((string Path, string Content)[] sources, string expectedOutput = null, CSharpCompilationOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23103, 77946, 78821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78127, 78178);

                var
                trees = f_23103_78139_78177()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78192, 78440);
                    foreach (var source in f_23103_78215_78222_I(sources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23103, 78192, 78440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78369, 78425);

                        f_23103_78369_78424(                // The trees must be assigned unique file names in order for instrumentation to work correctly.
                                        trees, f_23103_78379_78423(source.Content, filename: source.Path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23103, 78192, 78440);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(23103, 1, 249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(23103, 1, 249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78456, 78579);

                var
                compilation = f_23103_78474_78578(f_23103_78492_78507(trees), options: f_23103_78518_78577((options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(23103, 78519, 78552) ?? TestOptions.ReleaseExe)), true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78593, 78606);

                f_23103_78593_78605(trees);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23103, 78620, 78810);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CompileAndVerify(compilation, expectedOutput: expectedOutput, emitOptions: f_23103_78707_78808(EmitOptions.Default, f_23103_78752_78807(InstrumentationKind.TestCoverage))), 23103, 78627, 78809);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23103, 77946, 78821);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_23103_78139_78177()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78139, 78177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23103_78379_78423(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename: filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78379, 78423);
                    return return_v;
                }


                int
                f_23103_78369_78424(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78369, 78424);
                    return 0;
                }


                (string Path, string Content)[]
                f_23103_78215_78222_I((string Path, string Content)[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78215, 78222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree[]
                f_23103_78492_78507(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78492, 78507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23103_78518_78577(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.WithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78518, 78577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23103_78474_78578(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78474, 78578);
                    return return_v;
                }


                int
                f_23103_78593_78605(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78593, 78605);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                f_23103_78752_78807(Microsoft.CodeAnalysis.Emit.InstrumentationKind
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78752, 78807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23103_78707_78808(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
                instrumentationKinds)
                {
                    var return_v = this_param.WithInstrumentationKinds(instrumentationKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 78707, 78808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23103, 77946, 78821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 77946, 78821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DynamicInstrumentationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23103, 663, 78830);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23103, 663, 78830);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 663, 78830);
        }


        static DynamicInstrumentationTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23103, 663, 78830);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23103, 663, 78830);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23103, 663, 78830);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23103, 663, 78830);

        static int
        f_23103_76537_76603(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        verifier, string
        qualifiedMethodName, bool
        expected)
        {
            AssertInstrumented(verifier, qualifiedMethodName, expected: expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(23103, 76537, 76603);
            return 0;
        }

    }
}
