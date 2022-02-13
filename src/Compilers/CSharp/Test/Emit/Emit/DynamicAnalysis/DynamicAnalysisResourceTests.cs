// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.PortableExecutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests
{
public class DynamicAnalysisResourceTests : CSharpTestBase
{
const string 
InstrumentationHelperSource = @"
namespace Microsoft.CodeAnalysis.Runtime
{
    public static class Instrumentation
    {
        public static bool[] CreatePayload(System.Guid mvid, int methodToken, int fileIndex, ref bool[] payload, int payloadLength)
        {
            return payload;
        }

        public static bool[] CreatePayload(System.Guid mvid, int methodToken, int[] fileIndices, ref bool[] payload, int payloadLength)
        {
            return payload;
        }

        public static void FlushPayload()
        {
        }
    }
}
"
;

const string 
ExampleSource = @"
using System;

public class C
{
    public static void Main()
    {
        Console.WriteLine(123);
        Console.WriteLine(123);
    }

    public static int Fred => 3;

    public static int Barney(int x) => x;

    public static int Wilma
    {
        get { return 12; }
        set { }
    }

    public static int Betty { get; }

    public static int Pebbles { get; set; }
}
"
;

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionHasNewLineDependency)]
        public void TestSpansPresentInResource()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,1827,4720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2006,2109);

var 
c = f_23102_2014_2108(f_23102_2032_2107(ExampleSource + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2123,2254);

var 
peImage = f_23102_2137_2253(c, f_23102_2151_2252(EmitOptions.Default, f_23102_2196_2251(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2270,2307);

var 
peReader = f_23102_2285_2306(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2321,2411);

var 
reader = f_23102_2334_2410(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2427,2580);

f_23102_2427_2579(this, reader, f_23102_2451_2467(reader), @"'C:\myproject\doc1.cs' 44-3F-7C-A1-EF-CA-A8-16-40-D2-09-4F-3E-52-7C-44-8D-22-C8-02 (SHA1)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2596,2636);

f_23102_2596_2635(13, reader.Methods.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2652,2701);

string[] 
sourceLines = f_23102_2675_2700(ExampleSource, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,2717,3019);

f_23102_2717_3018(reader, f_23102_2737_2751(reader)[0], sourceLines, f_23102_2818_2873(5, 4, 9, 5, "public static void Main()"), f_23102_2892_2945(7, 8, 7, 31, "Console.WriteLine(123)"), f_23102_2964_3017(8, 8, 8, 31, "Console.WriteLine(123)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,3035,3256);

f_23102_3035_3255(reader, f_23102_3055_3069(reader)[1], sourceLines, f_23102_3140_3200(11, 4, 11, 32, "public static int Fred => 3"), f_23102_3219_3254(11, 30, 11, 31, "3"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,3272,3500);

f_23102_3272_3499(reader, f_23102_3292_3306(reader)[2], sourceLines, f_23102_3375_3444(13, 4, 13, 41, "public static int Barney(int x) => x"), f_23102_3463_3498(13, 39, 13, 40, "x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,3516,3737);

f_23102_3516_3736(reader, f_23102_3536_3550(reader)[3], sourceLines, f_23102_3622_3673(17, 8, 17, 26, "get { return 12; }"), f_23102_3692_3735(17, 14, 17, 24, "return 12"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,3753,3901);

f_23102_3753_3900(reader, f_23102_3773_3787(reader)[4], sourceLines, f_23102_3859_3899(18, 8, 18, 15, "set { }"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,3917,4146);

f_23102_3917_4145(reader, f_23102_3937_3951(reader)[5], sourceLines, f_23102_4023_4088(21, 4, 21, 36, "public static int Betty { get; }"), f_23102_4107_4144(21, 30, 21, 34, "get"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,4162,4400);

f_23102_4162_4399(reader, f_23102_4182_4196(reader)[6], sourceLines, f_23102_4270_4342(23, 4, 23, 43, "public static int Pebbles { get; set; }"), f_23102_4361_4398(23, 32, 23, 36, "get"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,4416,4654);

f_23102_4416_4653(reader, f_23102_4436_4450(reader)[7], sourceLines, f_23102_4524_4596(23, 4, 23, 43, "public static int Pebbles { get; set; }"), f_23102_4615_4652(23, 37, 23, 41, "set"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,4670,4709);

f_23102_4670_4708(reader, f_23102_4690_4704(reader)[8]);
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,1827,4720);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_2032_2107(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2032, 2107);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_2014_2108(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2014, 2108);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_2196_2251(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2196, 2251);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_2151_2252(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2151, 2252);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_2137_2253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2137, 2253);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_2285_2306(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2285, 2306);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_2334_2410(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2334, 2410);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
f_23102_2451_2467(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Documents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 2451, 2467);
return return_v;
}


int
f_23102_2427_2579(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests
this_param,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
documents,params string[]
expected)
{
this_param.VerifyDocuments( reader, documents, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2427, 2579);
return 0;
}


int
f_23102_2596_2635(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2596, 2635);
return 0;
}


string[]
f_23102_2675_2700(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2675, 2700);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_2737_2751(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 2737, 2751);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_2818_2873(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2818, 2873);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_2892_2945(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2892, 2945);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_2964_3017(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2964, 3017);
return return_v;
}


int
f_23102_2717_3018(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 2717, 3018);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_3055_3069(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 3055, 3069);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3140_3200(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3140, 3200);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3219_3254(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3219, 3254);
return return_v;
}


int
f_23102_3035_3255(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3035, 3255);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_3292_3306(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 3292, 3306);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3375_3444(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3375, 3444);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3463_3498(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3463, 3498);
return return_v;
}


int
f_23102_3272_3499(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3272, 3499);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_3536_3550(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 3536, 3550);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3622_3673(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3622, 3673);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3692_3735(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3692, 3735);
return return_v;
}


int
f_23102_3516_3736(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3516, 3736);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_3773_3787(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 3773, 3787);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_3859_3899(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3859, 3899);
return return_v;
}


int
f_23102_3753_3900(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3753, 3900);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_3937_3951(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 3937, 3951);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4023_4088(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4023, 4088);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4107_4144(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4107, 4144);
return return_v;
}


int
f_23102_3917_4145(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 3917, 4145);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_4182_4196(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 4182, 4196);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4270_4342(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4270, 4342);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4361_4398(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4361, 4398);
return return_v;
}


int
f_23102_4162_4399(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4162, 4399);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_4436_4450(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 4436, 4450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4524_4596(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4524, 4596);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_4615_4652(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4615, 4652);
return return_v;
}


int
f_23102_4416_4653(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4416, 4653);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_4690_4704(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 4690, 4704);
return return_v;
}


int
f_23102_4670_4708(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,params string[]
expected)
{
VerifySpans( reader, methodData, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 4670, 4708);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,1827,4720);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,1827,4720);
}
		}

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionHasNewLineDependency)]
        public void ResourceStatementKinds()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,4732,9313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,4907,6417);

string 
source = @"
using System;

public class C
{
    public static void Main()
    {
        int z = 11;
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
        catch (System.Exception e)
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
        catch (System.Exception e)
        {
        }

        return;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,6433,6529);

var 
c = f_23102_6441_6528(f_23102_6459_6527(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,6543,6674);

var 
peImage = f_23102_6557_6673(c, f_23102_6571_6672(EmitOptions.Default, f_23102_6616_6671(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,6690,6727);

var 
peReader = f_23102_6705_6726(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,6741,6831);

var 
reader = f_23102_6754_6830(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,6847,7000);

f_23102_6847_6999(this, reader, f_23102_6871_6887(reader), @"'C:\myproject\doc1.cs' 6A-DC-C0-8A-16-CB-7C-A5-99-8B-2E-0C-3C-81-69-2C-B2-10-EE-F1 (SHA1)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,7016,7055);

f_23102_7016_7054(6, reader.Methods.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,7071,7113);

string[] 
sourceLines = f_23102_7094_7112(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,7129,9247);

f_23102_7129_9246(reader, f_23102_7149_7163(reader)[0], sourceLines, f_23102_7198_7254(5, 4, 89, 5, "public static void Main()"), f_23102_7273_7314(7, 8, 7, 19, "int z = 11"), f_23102_7333_7378(8, 8, 8, 23, "int x = z + 10"), f_23102_7397_7436(12, 16, 12, 22, "break"), f_23102_7455_7494(14, 16, 14, 22, "break"), f_23102_7513_7552(16, 16, 16, 22, "break"), f_23102_7571_7610(18, 16, 18, 22, "break"), f_23102_7629_7662(9, 16, 9, 17, "z"), f_23102_7681_7718(23, 12, 23, 16, "x++"), f_23102_7737_7774(27, 12, 27, 16, "x--"), f_23102_7793_7833(21, 12, 21, 18, "x > 10"), f_23102_7852_7891(30, 17, 30, 22, "y = 0"), f_23102_7910_7947(30, 32, 30, 35, "y++"), f_23102_7966_8003(34, 16, 34, 20, "x++"), f_23102_8022_8064(35, 16, 35, 25, "continue"), f_23102_8083_8122(38, 16, 38, 22, "break"), f_23102_8141_8181(32, 16, 32, 22, "y < 30"), f_23102_8200_8267(41, 8, 41, 43, "int[] a = new int[] { 1, 2, 3, 4 }"), f_23102_8286_8323(44, 12, 44, 16, "x++"), f_23102_8342_8377(42, 26, 42, 27, "a"), f_23102_8396_8433(49, 12, 49, 16, "x++"), f_23102_8452_8493(47, 15, 47, 22, "x < 100"), f_23102_8512_8549(54, 12, 54, 16, "x++"), f_23102_8568_8630(57, 16, 57, 45, "throw new System.Exception()"), f_23102_8649_8689(55, 16, 55, 22, "x > 10"), f_23102_8708_8745(59, 12, 59, 16, "x++"), f_23102_8764_8801(63, 12, 63, 16, "x++"), f_23102_8820_8857(67, 12, 67, 16, "x++"), f_23102_8876_8911(72, 12, 72, 13, ";"), f_23102_8930_8976(70, 14, 70, 26, "new object()"), f_23102_8995_9048(75, 8, 75, 29, "Console.WriteLine(x)"), f_23102_9067_9102(81, 16, 81, 17, ";"), f_23102_9121_9187(79, 19, 79, 51, "(System.IDisposable)new object()"), f_23102_9206_9245(88, 8, 88, 15, "return"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,9263,9302);

f_23102_9263_9301(reader, f_23102_9283_9297(reader)[1]);
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,4732,9313);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_6459_6527(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6459, 6527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_6441_6528(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6441, 6528);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_6616_6671(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6616, 6671);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_6571_6672(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6571, 6672);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_6557_6673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6557, 6673);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_6705_6726(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6705, 6726);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_6754_6830(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6754, 6830);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
f_23102_6871_6887(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Documents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 6871, 6887);
return return_v;
}


int
f_23102_6847_6999(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests
this_param,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
documents,params string[]
expected)
{
this_param.VerifyDocuments( reader, documents, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 6847, 6999);
return 0;
}


int
f_23102_7016_7054(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7016, 7054);
return 0;
}


string[]
f_23102_7094_7112(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7094, 7112);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_7149_7163(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 7149, 7163);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7198_7254(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7198, 7254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7273_7314(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7273, 7314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7333_7378(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7333, 7378);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7397_7436(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7397, 7436);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7455_7494(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7455, 7494);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7513_7552(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7513, 7552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7571_7610(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7571, 7610);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7629_7662(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7629, 7662);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7681_7718(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7681, 7718);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7737_7774(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7737, 7774);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7793_7833(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7793, 7833);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7852_7891(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7852, 7891);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7910_7947(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7910, 7947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_7966_8003(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7966, 8003);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8022_8064(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8022, 8064);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8083_8122(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8083, 8122);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8141_8181(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8141, 8181);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8200_8267(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8200, 8267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8286_8323(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8286, 8323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8342_8377(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8342, 8377);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8396_8433(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8396, 8433);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8452_8493(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8452, 8493);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8512_8549(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8512, 8549);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8568_8630(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8568, 8630);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8649_8689(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8649, 8689);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8708_8745(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8708, 8745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8764_8801(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8764, 8801);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8820_8857(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8820, 8857);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8876_8911(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8876, 8911);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8930_8976(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8930, 8976);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_8995_9048(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 8995, 9048);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_9067_9102(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 9067, 9102);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_9121_9187(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 9121, 9187);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_9206_9245(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 9206, 9245);
return return_v;
}


int
f_23102_7129_9246(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 7129, 9246);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_9283_9297(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 9283, 9297);
return return_v;
}


int
f_23102_9263_9301(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,params string[]
expected)
{
VerifySpans( reader, methodData, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 9263, 9301);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,4732,9313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,4732,9313);
}
		}

[ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.TestExecutionHasNewLineDependency)]
        public void TestMethodSpansWithAttributes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,9325,13440);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,9507,10793);

string 
source = @"
using System;
using System.Security;

public class C
{
    static int x;

    public static void Main()                       // Method 0
    {
        Fred();
    }
            
    [Obsolete()]
    static void Fred()                              // Method 1
    {
    }

    static C()                                      // Method 2
    {
        x = 12;
    }

    [Obsolete()]
    public C()                                      // Method 3
    {
    }

    int Wilma
    {
        [SecurityCritical]
        get { return 12; }                          // Method 4
    }

    [Obsolete()]
    int Betty => 13;                                // Method 5

    [SecurityCritical]
    int Pebbles()                                   // Method 6
    {
        return 3;
    }

    [SecurityCritical]
    ref int BamBam(ref int x)                       // Method 7
    {
        return ref x;
    }

    [SecurityCritical]
    C(int x)                                        // Method 8
    {
    }

    [Obsolete()]
    public int Barney => 13;                        // Method 9

    [SecurityCritical]
    public static C operator +(C a, C b)            // Method 10
    {
        return a;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,10809,10905);

var 
c = f_23102_10817_10904(f_23102_10835_10903(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,10919,11050);

var 
peImage = f_23102_10933_11049(c, f_23102_10947_11048(EmitOptions.Default, f_23102_10992_11047(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11066,11103);

var 
peReader = f_23102_11081_11102(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11117,11207);

var 
reader = f_23102_11130_11206(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11223,11376);

f_23102_11223_11375(this, reader, f_23102_11247_11263(reader), @"'C:\myproject\doc1.cs' A3-08-94-55-7C-64-8D-C7-61-7A-11-0B-4B-68-2C-3B-51-C3-C4-58 (SHA1)");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11392,11432);

f_23102_11392_11431(15, reader.Methods.Length);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11448,11490);

string[] 
sourceLines = f_23102_11471_11489(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11506,11691);

f_23102_11506_11690(reader, f_23102_11526_11540(reader)[0], sourceLines, f_23102_11575_11631(8, 4, 11, 5, "public static void Main()"), f_23102_11650_11689(10, 8, 10, 15, "Fred()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11707,11828);

f_23102_11707_11827(reader, f_23102_11727_11741(reader)[1], sourceLines, f_23102_11776_11826(14, 4, 16, 5, "static void Fred()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,11844,12015);

f_23102_11844_12014(reader, f_23102_11864_11878(reader)[2], sourceLines, f_23102_11913_11955(18, 4, 21, 5, "static C()"), f_23102_11974_12013(20, 8, 20, 15, "x = 12"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12031,12144);

f_23102_12031_12143(reader, f_23102_12051_12065(reader)[3], sourceLines, f_23102_12100_12142(24, 4, 26, 5, "public C()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12160,12331);

f_23102_12160_12330(reader, f_23102_12180_12194(reader)[4], sourceLines, f_23102_12229_12267(31, 8, 31, 26, "get {"), f_23102_12286_12329(31, 14, 31, 24, "return 12"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12347,12515);

f_23102_12347_12514(reader, f_23102_12367_12381(reader)[5], sourceLines, f_23102_12416_12458(35, 4, 35, 20, "int Betty"), f_23102_12477_12513(35, 17, 35, 19, "13"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12531,12707);

f_23102_12531_12706(reader, f_23102_12551_12565(reader)[6], sourceLines, f_23102_12600_12645(38, 4, 41, 5, "int Pebbles()"), f_23102_12664_12705(40, 8, 40, 17, "return 3"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12723,12904);

f_23102_12723_12903(reader, f_23102_12743_12757(reader)[7], sourceLines, f_23102_12792_12838(44, 4, 47, 5, "ref int BamBam"), f_23102_12857_12902(46, 8, 46, 21, "return ref x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,12920,13031);

f_23102_12920_13030(reader, f_23102_12940_12954(reader)[8], sourceLines, f_23102_12989_13029(50, 4, 52, 5, "C(int x)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,13047,13223);

f_23102_13047_13222(reader, f_23102_13067_13081(reader)[9], sourceLines, f_23102_13116_13166(55, 4, 55, 28, "public int Barney"), f_23102_13185_13221(55, 25, 55, 27, "13"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,13239,13429);

f_23102_13239_13428(reader, f_23102_13259_13273(reader)[10], sourceLines, f_23102_13309_13367(58, 4, 61, 5, "public static C operator +"), f_23102_13386_13427(60, 8, 60, 17, "return a"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,9325,13440);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_10835_10903(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 10835, 10903);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_10817_10904(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 10817, 10904);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_10992_11047(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 10992, 11047);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_10947_11048(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 10947, 11048);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_10933_11049(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 10933, 11049);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_11081_11102(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11081, 11102);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_11130_11206(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11130, 11206);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
f_23102_11247_11263(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Documents;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 11247, 11263);
return return_v;
}


int
f_23102_11223_11375(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests
this_param,Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisDocument>
documents,params string[]
expected)
{
this_param.VerifyDocuments( reader, documents, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11223, 11375);
return 0;
}


int
f_23102_11392_11431(int
expected,int
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11392, 11431);
return 0;
}


string[]
f_23102_11471_11489(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11471, 11489);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_11526_11540(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 11526, 11540);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_11575_11631(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11575, 11631);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_11650_11689(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11650, 11689);
return return_v;
}


int
f_23102_11506_11690(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11506, 11690);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_11727_11741(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 11727, 11741);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_11776_11826(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11776, 11826);
return return_v;
}


int
f_23102_11707_11827(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11707, 11827);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_11864_11878(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 11864, 11878);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_11913_11955(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11913, 11955);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_11974_12013(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11974, 12013);
return return_v;
}


int
f_23102_11844_12014(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 11844, 12014);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12051_12065(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12051, 12065);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12100_12142(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12100, 12142);
return return_v;
}


int
f_23102_12031_12143(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12031, 12143);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12180_12194(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12180, 12194);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12229_12267(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12229, 12267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12286_12329(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12286, 12329);
return return_v;
}


int
f_23102_12160_12330(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12160, 12330);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12367_12381(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12367, 12381);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12416_12458(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12416, 12458);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12477_12513(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12477, 12513);
return return_v;
}


int
f_23102_12347_12514(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12347, 12514);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12551_12565(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12551, 12565);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12600_12645(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12600, 12645);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12664_12705(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12664, 12705);
return return_v;
}


int
f_23102_12531_12706(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12531, 12706);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12743_12757(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12743, 12757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12792_12838(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12792, 12838);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12857_12902(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12857, 12902);
return return_v;
}


int
f_23102_12723_12903(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12723, 12903);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_12940_12954(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 12940, 12954);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_12989_13029(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12989, 13029);
return return_v;
}


int
f_23102_12920_13030(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 12920, 13030);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_13067_13081(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 13067, 13081);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_13116_13166(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13116, 13166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_13185_13221(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13185, 13221);
return return_v;
}


int
f_23102_13047_13222(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13047, 13222);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_13259_13273(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 13259, 13273);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_13309_13367(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13309, 13367);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_13386_13427(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13386, 13427);
return return_v;
}


int
f_23102_13239_13428(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 13239, 13428);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,9325,13440);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,9325,13440);
}
		}

[Fact]
        public void TestPatternSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,13452,16231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,13523,14530);

string 
source = @"
using System;

public class C
{
    public static void Main()                                   // Method 0
    {
        Student s = new Student();
        s.Name = ""Bozo"";
        s.GPA = 2.3;
        Operate(s);
    }
     
    static string Operate(Person p)                             // Method 1
    {
        switch (p)
        {
            case Student s when s.GPA > 3.5:
                return $""Student {s.Name} ({s.GPA:N1})"";
            case Student s when (s.GPA < 2.0):
                return $""Failing Student {s.Name} ({s.GPA:N1})"";
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
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,14546,14642);

var 
c = f_23102_14554_14641(f_23102_14572_14640(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,14656,14787);

var 
peImage = f_23102_14670_14786(c, f_23102_14684_14785(EmitOptions.Default, f_23102_14729_14784(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,14803,14840);

var 
peReader = f_23102_14818_14839(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,14854,14944);

var 
reader = f_23102_14867_14943(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,14960,15002);

string[] 
sourceLines = f_23102_14983_15001(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,15018,15410);

f_23102_15018_15409(reader, f_23102_15038_15052(reader)[0], sourceLines, f_23102_15087_15143(5, 4, 11, 5, "public static void Main()"), f_23102_15162_15218(7, 8, 7, 34, "Student s = new Student()"), f_23102_15237_15285(8, 8, 8, 24, "s.Name = \"Bozo\""), f_23102_15304_15346(9, 8, 9, 20, "s.GPA = 2.3"), f_23102_15365_15408(10, 8, 10, 19, "Operate(s)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,15426,16220);

f_23102_15426_16219(reader, f_23102_15446_15460(reader)[1], sourceLines, f_23102_15495_15558(13, 4, 28, 5, "static string Operate(Person p)"), f_23102_15577_15627(17, 27, 17, 43, "when s.GPA > 3.5"), f_23102_15646_15698(19, 27, 19, 45, "when (s.GPA < 2.0)"), f_23102_15717_15792(18, 16, 18, 56, "return $\"Student {s.Name} ({s.GPA:N1})\""), f_23102_15811_15894(20, 16, 20, 64, "return $\"Failing Student {s.Name} ({s.GPA:N1})\""), f_23102_15913_15988(22, 16, 22, 56, "return $\"Student {s.Name} ({s.GPA:N1})\""), f_23102_16007_16084(24, 16, 24, 58, "return $\"Teacher {t.Name} of {t.Subject}\""), f_23102_16103_16164(26, 16, 26, 42, "return $\"Person {p.Name}\""), f_23102_16183_16218(15, 16, 15, 17, "p"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,13452,16231);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_14572_14640(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14572, 14640);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_14554_14641(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14554, 14641);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_14729_14784(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14729, 14784);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_14684_14785(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14684, 14785);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_14670_14786(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14670, 14786);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_14818_14839(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14818, 14839);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_14867_14943(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14867, 14943);
return return_v;
}


string[]
f_23102_14983_15001(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 14983, 15001);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_15038_15052(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 15038, 15052);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15087_15143(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15087, 15143);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15162_15218(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15162, 15218);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15237_15285(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15237, 15285);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15304_15346(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15304, 15346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15365_15408(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15365, 15408);
return return_v;
}


int
f_23102_15018_15409(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15018, 15409);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_15446_15460(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 15446, 15460);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15495_15558(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15495, 15558);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15577_15627(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15577, 15627);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15646_15698(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15646, 15698);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15717_15792(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15717, 15792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15811_15894(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15811, 15894);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_15913_15988(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15913, 15988);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_16007_16084(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16007, 16084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_16103_16164(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16103, 16164);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_16183_16218(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16183, 16218);
return return_v;
}


int
f_23102_15426_16219(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 15426, 16219);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,13452,16231);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,13452,16231);
}
		}

[Fact]
        public void TestDeconstructionSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,16243,17262);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16321,16569);

string 
source = @"
using System;

public class C
{
    public static void Main() // Method 1
    {
        var (x, y) = new C();
    }

    public void Deconstruct(out int x, out int y)
    {
        x = 1;
        y = 2;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16583,16679);

var 
c = f_23102_16591_16678(f_23102_16609_16677(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16693,16824);

var 
peImage = f_23102_16707_16823(c, f_23102_16721_16822(EmitOptions.Default, f_23102_16766_16821(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16840,16877);

var 
peReader = f_23102_16855_16876(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16891,16981);

var 
reader = f_23102_16904_16980(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,16997,17039);

string[] 
sourceLines = f_23102_17020_17038(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17055,17251);

f_23102_17055_17250(reader, f_23102_17075_17089(reader)[0], sourceLines, f_23102_17124_17179(5, 4, 8, 5, "public static void Main()"), f_23102_17198_17249(7, 8, 7, 29, "var (x, y) = new C()"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,16243,17262);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_16609_16677(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16609, 16677);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_16591_16678(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16591, 16678);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_16766_16821(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16766, 16821);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_16721_16822(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16721, 16822);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_16707_16823(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16707, 16823);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_16855_16876(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16855, 16876);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_16904_16980(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 16904, 16980);
return return_v;
}


string[]
f_23102_17020_17038(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17020, 17038);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_17075_17089(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 17075, 17089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_17124_17179(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17124, 17179);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_17198_17249(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17198, 17249);
return return_v;
}


int
f_23102_17055_17250(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17055, 17250);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,16243,17262);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,16243,17262);
}
		}

[Fact]
        public void TestForeachSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,17274,18369);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17345,17557);

string 
source = @"
using System;

public class C
{
    public static void Main() // Method 1
    {
        C[] a = null;
        foreach
            (var x
            in a)
            ;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17571,17667);

var 
c = f_23102_17579_17666(f_23102_17597_17665(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17681,17812);

var 
peImage = f_23102_17695_17811(c, f_23102_17709_17810(EmitOptions.Default, f_23102_17754_17809(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17828,17865);

var 
peReader = f_23102_17843_17864(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17879,17969);

var 
reader = f_23102_17892_17968(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,17985,18027);

string[] 
sourceLines = f_23102_18008_18026(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,18043,18358);

f_23102_18043_18357(reader, f_23102_18063_18077(reader)[0], sourceLines, f_23102_18112_18168(5, 4, 12, 5, "public static void Main()"), f_23102_18187_18230(7, 8, 7, 21, "C[] a = null"), f_23102_18249_18284(11, 12, 11, 13, ";"), f_23102_18303_18338(10, 15, 10, 16, "a"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,17274,18369);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_17597_17665(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17597, 17665);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_17579_17666(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17579, 17666);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_17754_17809(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17754, 17809);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_17709_17810(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17709, 17810);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_17695_17811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17695, 17811);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_17843_17864(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17843, 17864);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_17892_17968(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 17892, 17968);
return return_v;
}


string[]
f_23102_18008_18026(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18008, 18026);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_18063_18077(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 18063, 18077);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_18112_18168(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18112, 18168);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_18187_18230(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18187, 18230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_18249_18284(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18249, 18284);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_18303_18338(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18303, 18338);
return return_v;
}


int
f_23102_18043_18357(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18043, 18357);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,17274,18369);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,17274,18369);
}
		}

[Fact]
        public void TestForeachDeconstructionSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,18381,19594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,18466,18782);

string 
source = @"
using System;

public class C
{
    public static void Main() // Method 1
    {
        C[] a = null;
        foreach
            (var (x, y)
            in a)
            ;
    }

    public void Deconstruct(out int x, out int y)
    {
        x = 1;
        y = 2;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,18796,18892);

var 
c = f_23102_18804_18891(f_23102_18822_18890(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,18906,19037);

var 
peImage = f_23102_18920_19036(c, f_23102_18934_19035(EmitOptions.Default, f_23102_18979_19034(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,19053,19090);

var 
peReader = f_23102_19068_19089(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,19104,19194);

var 
reader = f_23102_19117_19193(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,19210,19252);

string[] 
sourceLines = f_23102_19233_19251(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,19268,19583);

f_23102_19268_19582(reader, f_23102_19288_19302(reader)[0], sourceLines, f_23102_19337_19393(5, 4, 12, 5, "public static void Main()"), f_23102_19412_19455(7, 8, 7, 21, "C[] a = null"), f_23102_19474_19509(11, 12, 11, 13, ";"), f_23102_19528_19563(10, 15, 10, 16, "a"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,18381,19594);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_18822_18890(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18822, 18890);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_18804_18891(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18804, 18891);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_18979_19034(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18979, 19034);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_18934_19035(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18934, 19035);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_18920_19036(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 18920, 19036);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_19068_19089(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19068, 19089);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_19117_19193(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19117, 19193);
return return_v;
}


string[]
f_23102_19233_19251(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19233, 19251);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_19288_19302(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 19288, 19302);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_19337_19393(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19337, 19393);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_19412_19455(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19412, 19455);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_19474_19509(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19474, 19509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_19528_19563(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19528, 19563);
return return_v;
}


int
f_23102_19268_19582(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 19268, 19582);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,18381,19594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,18381,19594);
}
		}

[Fact]
        public void TestFieldInitializerSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,19606,23380);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,19686,20749);

string 
source = @"
using System;

public class C
{
    public static void Main()                                   // Method 0
    {
        TestMain();
    }

    static void TestMain()                                      // Method 1
    {
        C local = new C(); local = new C(1, 2);
    }

    static int Init() => 33;                                    // Method 2

    C()                                                         // Method 3
    {
        _z = 12;
    }

    static C()                                                  // Method 4
    {
        s_z = 123;
    }

    int _x = Init();
    int _y = Init() + 12;
    int _z;
    static int s_x = Init();
    static int s_y = Init() + 153;
    static int s_z;

    C(int x)                                                    // Method 5
    {
        _z = x;
    }

    C(int a, int b)                                             // Method 6
    {
        _z = a + b;
    }

    int Prop1 { get; } = 15;
    static int Prop2 { get; } = 255;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,20765,20861);

var 
c = f_23102_20773_20860(f_23102_20791_20859(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,20875,21006);

var 
peImage = f_23102_20889_21005(c, f_23102_20903_21004(EmitOptions.Default, f_23102_20948_21003(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21022,21059);

var 
peReader = f_23102_21037_21058(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21073,21163);

var 
reader = f_23102_21086_21162(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21179,21221);

string[] 
sourceLines = f_23102_21202_21220(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21237,21423);

f_23102_21237_21422(reader, f_23102_21257_21271(reader)[0], sourceLines, f_23102_21306_21361(5, 4, 8, 5, "public static void Main()"), f_23102_21380_21421(7, 8, 7, 19, "TestMain()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21439,21705);

f_23102_21439_21704(reader, f_23102_21459_21473(reader)[1], sourceLines, f_23102_21508_21562(10, 4, 13, 5, "static void TestMain()"), f_23102_21581_21631(12, 8, 12, 26, "C local = new C()"), f_23102_21650_21703(12, 27, 12, 47, "local = new C(1, 2)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21721,21903);

f_23102_21721_21902(reader, f_23102_21741_21755(reader)[2], sourceLines, f_23102_21790_21846(15, 4, 15, 28, "static int Init() => 33"), f_23102_21865_21901(15, 25, 15, 27, "33"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,21919,22262);

f_23102_21919_22261(reader, f_23102_21939_21953(reader)[3], sourceLines, f_23102_21988_22023(17, 4, 20, 5, "C()"), f_23102_22042_22082(27, 13, 27, 19, "Init()"), f_23102_22101_22146(28, 13, 28, 24, "Init() + 12"), f_23102_22165_22201(44, 25, 44, 27, "15"), f_23102_22220_22260(19, 8, 19, 16, "_z = 12"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,22278,22632);

f_23102_22278_22631(reader, f_23102_22298_22312(reader)[4], sourceLines, f_23102_22347_22389(22, 4, 25, 5, "static C()"), f_23102_22408_22448(30, 21, 30, 27, "Init()"), f_23102_22467_22513(31, 21, 31, 33, "Init() + 153"), f_23102_22532_22569(45, 32, 45, 35, "255"), f_23102_22588_22630(24, 8, 24, 18, "s_z = 123"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,22648,22995);

f_23102_22648_22994(reader, f_23102_22668_22682(reader)[5], sourceLines, f_23102_22717_22757(34, 4, 37, 5, "C(int x)"), f_23102_22776_22816(27, 13, 27, 19, "Init()"), f_23102_22835_22880(28, 13, 28, 24, "Init() + 12"), f_23102_22899_22935(44, 25, 44, 27, "15"), f_23102_22954_22993(36, 8, 36, 15, "_z = x"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,23011,23369);

f_23102_23011_23368(reader, f_23102_23031_23045(reader)[6], sourceLines, f_23102_23080_23127(39, 4, 42, 5, "C(int a, int b)"), f_23102_23146_23186(27, 13, 27, 19, "Init()"), f_23102_23205_23250(28, 13, 28, 24, "Init() + 12"), f_23102_23269_23305(44, 25, 44, 27, "15"), f_23102_23324_23367(41, 8, 41, 19, "_z = a + b"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,19606,23380);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_20791_20859(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 20791, 20859);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_20773_20860(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 20773, 20860);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_20948_21003(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 20948, 21003);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_20903_21004(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 20903, 21004);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_20889_21005(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 20889, 21005);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_21037_21058(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21037, 21058);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_21086_21162(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21086, 21162);
return return_v;
}


string[]
f_23102_21202_21220(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21202, 21220);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_21257_21271(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 21257, 21271);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21306_21361(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21306, 21361);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21380_21421(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21380, 21421);
return return_v;
}


int
f_23102_21237_21422(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21237, 21422);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_21459_21473(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 21459, 21473);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21508_21562(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21508, 21562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21581_21631(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21581, 21631);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21650_21703(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21650, 21703);
return return_v;
}


int
f_23102_21439_21704(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21439, 21704);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_21741_21755(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 21741, 21755);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21790_21846(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21790, 21846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21865_21901(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21865, 21901);
return return_v;
}


int
f_23102_21721_21902(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21721, 21902);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_21939_21953(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 21939, 21953);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_21988_22023(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21988, 22023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22042_22082(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22042, 22082);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22101_22146(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22101, 22146);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22165_22201(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22165, 22201);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22220_22260(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22220, 22260);
return return_v;
}


int
f_23102_21919_22261(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 21919, 22261);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_22298_22312(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 22298, 22312);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22347_22389(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22347, 22389);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22408_22448(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22408, 22448);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22467_22513(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22467, 22513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22532_22569(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22532, 22569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22588_22630(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22588, 22630);
return return_v;
}


int
f_23102_22278_22631(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22278, 22631);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_22668_22682(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 22668, 22682);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22717_22757(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22717, 22757);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22776_22816(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22776, 22816);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22835_22880(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22835, 22880);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22899_22935(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22899, 22935);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_22954_22993(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22954, 22993);
return return_v;
}


int
f_23102_22648_22994(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 22648, 22994);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_23031_23045(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 23031, 23045);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_23080_23127(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23080, 23127);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_23146_23186(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23146, 23186);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_23205_23250(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23205, 23250);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_23269_23305(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23269, 23305);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_23324_23367(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23324, 23367);
return return_v;
}


int
f_23102_23011_23368(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 23011, 23368);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,19606,23380);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,19606,23380);
}
		}

[Fact]
        public void TestImplicitConstructorSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,23392,25813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,23475,24062);

string 
source = @"
using System;

public class C
{
    public static void Main()                                   // Method 0
    {
        TestMain();
    }

    static void TestMain()                                      // Method 1
    {
        C local = new C();
    }

    static int Init() => 33;                                    // Method 2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24078,24174);

var 
c = f_23102_24086_24173(f_23102_24104_24172(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24188,24319);

var 
peImage = f_23102_24202_24318(c, f_23102_24216_24317(EmitOptions.Default, f_23102_24261_24316(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24335,24372);

var 
peReader = f_23102_24350_24371(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24386,24476);

var 
reader = f_23102_24399_24475(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24492,24534);

string[] 
sourceLines = f_23102_24515_24533(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24550,24736);

f_23102_24550_24735(reader, f_23102_24570_24584(reader)[0], sourceLines, f_23102_24619_24674(5, 4, 8, 5, "public static void Main()"), f_23102_24693_24734(7, 8, 7, 19, "TestMain()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24752,24946);

f_23102_24752_24945(reader, f_23102_24772_24786(reader)[1], sourceLines, f_23102_24821_24875(10, 4, 13, 5, "static void TestMain()"), f_23102_24894_24944(12, 8, 12, 26, "C local = new C()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,24962,25142);

f_23102_24962_25141(reader, f_23102_24982_24996(reader)[2], sourceLines, f_23102_25030_25086(15, 4, 15, 28, "static int Init() => 33"), f_23102_25104_25140(15, 25, 15, 27, "33"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,25158,25444);

f_23102_25158_25443(reader, f_23102_25178_25192(reader)[5], sourceLines, f_23102_25283_25323(17, 13, 17, 19, "Init()"), f_23102_25342_25387(18, 13, 18, 24, "Init() + 12"), f_23102_25406_25442(23, 25, 23, 27, "15"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,25460,25802);

f_23102_25460_25801(reader, f_23102_25480_25494(reader)[6], sourceLines, f_23102_25583_25623(19, 21, 19, 27, "Init()"), f_23102_25642_25688(20, 21, 20, 33, "Init() + 153"), f_23102_25707_25744(21, 21, 21, 24, "144"), f_23102_25763_25800(24, 32, 24, 35, "255"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,23392,25813);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_24104_24172(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24104, 24172);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_24086_24173(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24086, 24173);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_24261_24316(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24261, 24316);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_24216_24317(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24216, 24317);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_24202_24318(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24202, 24318);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_24350_24371(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24350, 24371);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_24399_24475(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24399, 24475);
return return_v;
}


string[]
f_23102_24515_24533(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24515, 24533);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_24570_24584(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 24570, 24584);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_24619_24674(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24619, 24674);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_24693_24734(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24693, 24734);
return return_v;
}


int
f_23102_24550_24735(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24550, 24735);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_24772_24786(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 24772, 24786);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_24821_24875(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24821, 24875);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_24894_24944(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24894, 24944);
return return_v;
}


int
f_23102_24752_24945(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24752, 24945);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_24982_24996(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 24982, 24996);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25030_25086(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25030, 25086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25104_25140(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25104, 25140);
return return_v;
}


int
f_23102_24962_25141(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 24962, 25141);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_25178_25192(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 25178, 25192);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25283_25323(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25283, 25323);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25342_25387(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25342, 25387);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25406_25442(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25406, 25442);
return return_v;
}


int
f_23102_25158_25443(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25158, 25443);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_25480_25494(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 25480, 25494);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25583_25623(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25583, 25623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25642_25688(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25642, 25688);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25707_25744(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25707, 25744);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_25763_25800(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25763, 25800);
return return_v;
}


int
f_23102_25460_25801(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 25460, 25801);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,23392,25813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,23392,25813);
}
		}

[Fact]
        public void TestImplicitConstructorsWithLambdasSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,25825,29575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,25920,26839);

string 
source = @"
using System;

public class C
{
    public static void Main()                                   // Method 0
    {
        TestMain();
    }

    static void TestMain()                                      // Method 1
    {
        int y = s_c._function();
        D d = new D();
        int z = d._c._function();
        int zz = D.s_c._function();
    }

    public C(Func<int> f)                                       // Method 2
    {
        _function = f;
    }

    static C s_c = new C(() => 115);
    Func<int> _function;
}

class D
{
    public C _c = new C(() => 120);
    public static C s_c = new C(() => 144);
    public C _c1 = new C(() => 130);
    public static C s_c1 = new C(() => 156);
}

partial struct E
{
}

partial struct E
{
    public static C s_c = new C(() => 1444);
    public static C s_c1 = new C(() => { return 1567; });
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,26855,26951);

var 
c = f_23102_26863_26950(f_23102_26881_26949(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,26965,27096);

var 
peImage = f_23102_26979_27095(c, f_23102_26993_27094(EmitOptions.Default, f_23102_27038_27093(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27112,27149);

var 
peReader = f_23102_27127_27148(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27163,27253);

var 
reader = f_23102_27176_27252(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27269,27311);

string[] 
sourceLines = f_23102_27292_27310(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27327,27513);

f_23102_27327_27512(reader, f_23102_27347_27361(reader)[0], sourceLines, f_23102_27396_27451(5, 4, 8, 5, "public static void Main()"), f_23102_27470_27511(7, 8, 7, 19, "TestMain()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27529,27948);

f_23102_27529_27947(reader, f_23102_27549_27563(reader)[1], sourceLines, f_23102_27598_27652(10, 4, 16, 5, "static void TestMain()"), f_23102_27671_27727(12, 8, 12, 32, "int y = s_c._function()"), f_23102_27746_27792(13, 8, 13, 22, "D d = new D()"), f_23102_27811_27868(14, 8, 14, 33, "int z = d._c._function()"), f_23102_27887_27946(15, 8, 15, 35, "int zz = D.s_c._function()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,27964,28153);

f_23102_27964_28152(reader, f_23102_27984_27998(reader)[2], sourceLines, f_23102_28033_28086(18, 4, 21, 5, "public C(Func<int> f)"), f_23102_28105_28151(20, 8, 20, 22, "_function = f"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,28169,28406);

f_23102_28169_28405(reader, f_23102_28189_28203(reader)[3], sourceLines, f_23102_28298_28335(23, 31, 23, 34, "115"), f_23102_28354_28404(23, 19, 23, 35, "new C(() => 115)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,28422,28786);

f_23102_28422_28785(reader, f_23102_28442_28456(reader)[4], sourceLines, f_23102_28553_28590(29, 30, 29, 33, "120"), f_23102_28609_28646(31, 31, 31, 34, "130"), f_23102_28665_28715(29, 18, 29, 34, "new C(() => 120)"), f_23102_28734_28784(31, 19, 31, 35, "new C(() => 130)"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,28802,29163);

f_23102_28802_29162(reader, f_23102_28822_28836(reader)[5], sourceLines, f_23102_28931_28968(30, 38, 30, 41, "144"), f_23102_28987_29024(32, 39, 32, 42, "156"), f_23102_29043_29093(30, 26, 30, 42, "new C(() => 144)"), f_23102_29112_29161(32, 27, 32, 43, "new C(() => 156"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,29179,29564);

f_23102_29179_29563(reader, f_23102_29199_29213(reader)[6], sourceLines, f_23102_29308_29346(41, 38, 41, 42, "1444"), f_23102_29365_29410(42, 41, 42, 53, "return 1567"), f_23102_29429_29480(41, 26, 41, 43, "new C(() => 1444)"), f_23102_29499_29562(42, 27, 42, 56, "new C(() => { return 1567; })"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,25825,29575);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_26881_26949(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 26881, 26949);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_26863_26950(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 26863, 26950);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_27038_27093(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27038, 27093);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_26993_27094(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 26993, 27094);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_26979_27095(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 26979, 27095);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_27127_27148(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27127, 27148);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_27176_27252(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27176, 27252);
return return_v;
}


string[]
f_23102_27292_27310(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27292, 27310);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_27347_27361(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 27347, 27361);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27396_27451(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27396, 27451);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27470_27511(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27470, 27511);
return return_v;
}


int
f_23102_27327_27512(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27327, 27512);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_27549_27563(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 27549, 27563);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27598_27652(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27598, 27652);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27671_27727(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27671, 27727);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27746_27792(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27746, 27792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27811_27868(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27811, 27868);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_27887_27946(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27887, 27946);
return return_v;
}


int
f_23102_27529_27947(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27529, 27947);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_27984_27998(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 27984, 27998);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28033_28086(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28033, 28086);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28105_28151(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28105, 28151);
return return_v;
}


int
f_23102_27964_28152(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 27964, 28152);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_28189_28203(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 28189, 28203);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28298_28335(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28298, 28335);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28354_28404(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28354, 28404);
return return_v;
}


int
f_23102_28169_28405(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28169, 28405);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_28442_28456(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 28442, 28456);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28553_28590(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28553, 28590);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28609_28646(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28609, 28646);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28665_28715(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28665, 28715);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28734_28784(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28734, 28784);
return return_v;
}


int
f_23102_28422_28785(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28422, 28785);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_28822_28836(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 28822, 28836);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28931_28968(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28931, 28968);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_28987_29024(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28987, 29024);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29043_29093(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29043, 29093);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29112_29161(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29112, 29161);
return return_v;
}


int
f_23102_28802_29162(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 28802, 29162);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_29199_29213(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 29199, 29213);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29308_29346(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29308, 29346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29365_29410(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29365, 29410);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29429_29480(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29429, 29480);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_29499_29562(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29499, 29562);
return return_v;
}


int
f_23102_29179_29563(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 29179, 29563);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,25825,29575);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,25825,29575);
}
		}

[Fact]
        public void TestLocalFunctionWithLambdaSpans()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,29587,32178);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,29674,30501);

string 
source = @"
using System;

public class C
{
    public static void Main()                                   // Method 0
    {
        TestMain();
    }

    static void TestMain()                                      // Method 1
    {
        new D().M1();
    }
}

public class D
{
    public void M1()                                            // Method 3
    {
        L1();
        void L1()
        {
            var f = new Func<int>(
                () => 1
            );

            f();

            var f1 = new Func<int>(
                () => { return 2; }
            );

            var f2 = new Func<int, int>(
                (x) => x + 3
            );

            var f3 = new Func<int, int>(
                x => x + 4
            );
        }
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30517,30613);

var 
c = f_23102_30525_30612(f_23102_30543_30611(source + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30627,30758);

var 
peImage = f_23102_30641_30757(c, f_23102_30655_30756(EmitOptions.Default, f_23102_30700_30755(InstrumentationKind.TestCoverage)))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30774,30811);

var 
peReader = f_23102_30789_30810(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30825,30915);

var 
reader = f_23102_30838_30914(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30931,30973);

string[] 
sourceLines = f_23102_30954_30972(source, '\n')
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,30989,31175);

f_23102_30989_31174(reader, f_23102_31009_31023(reader)[0], sourceLines, f_23102_31058_31113(5, 4, 8, 5, "public static void Main()"), f_23102_31132_31173(7, 8, 7, 19, "TestMain()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,31191,31380);

f_23102_31191_31379(reader, f_23102_31211_31225(reader)[1], sourceLines, f_23102_31260_31314(10, 4, 13, 5, "static void TestMain()"), f_23102_31333_31378(12, 8, 12, 21, "new D().M1()"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,31396,32167);

f_23102_31396_32166(reader, f_23102_31416_31430(reader)[3], sourceLines, f_23102_31465_31513(18, 4, 41, 5, "public void M1()"), f_23102_31532_31569(20, 8, 20, 13, "L1()"), f_23102_31588_31623(24, 22, 24, 23, "1"), f_23102_31642_31697(23, 12, 25, 14, "var f = new Func<int>"), f_23102_31716_31753(27, 12, 27, 16, "f()"), f_23102_31772_31814(30, 24, 30, 33, "return 2"), f_23102_31833_31889(29, 12, 31, 14, "var f1 = new Func<int>"), f_23102_31908_31947(34, 23, 34, 28, "x + 3"), f_23102_31966_32027(33, 12, 35, 14, "var f2 = new Func<int, int>"), f_23102_32046_32085(38, 21, 38, 26, "x + 4"), f_23102_32104_32165(37, 12, 39, 14, "var f3 = new Func<int, int>"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,29587,32178);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_30543_30611(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30543, 30611);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_30525_30612(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30525, 30612);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_30700_30755(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30700, 30755);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_30655_30756(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30655, 30756);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_30641_30757(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30641, 30757);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_30789_30810(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30789, 30810);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_30838_30914(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30838, 30914);
return return_v;
}


string[]
f_23102_30954_30972(string
this_param,char
separator)
{
var return_v = this_param.Split( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30954, 30972);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_31009_31023(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 31009, 31023);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31058_31113(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31058, 31113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31132_31173(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31132, 31173);
return return_v;
}


int
f_23102_30989_31174(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 30989, 31174);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_31211_31225(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 31211, 31225);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31260_31314(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31260, 31314);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31333_31378(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31333, 31378);
return return_v;
}


int
f_23102_31191_31379(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31191, 31379);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisMethod>
f_23102_31416_31430(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param)
{
var return_v = this_param.Methods;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 31416, 31430);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31465_31513(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31465, 31513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31532_31569(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31532, 31569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31588_31623(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31588, 31623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31642_31697(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31642, 31697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31716_31753(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31716, 31753);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31772_31814(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31772, 31814);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31833_31889(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31833, 31889);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31908_31947(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31908, 31947);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_31966_32027(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31966, 32027);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_32046_32085(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32046, 32085);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
f_23102_32104_32165(int
startLine,int
startColumn,int
endLine,int
endColumn,string
textStart)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult( startLine, startColumn, endLine, endColumn, textStart);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32104, 32165);
return return_v;
}


int
f_23102_31396_32166(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,string[]
sourceLines,params Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
expected)
{
VerifySpans( reader, methodData, sourceLines, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 31396, 32166);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,29587,32178);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,29587,32178);
}
		}

[Fact]
        public void TestDynamicAnalysisResourceMissingWhenInstrumentationFlagIsDisabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,32190,32682);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32312,32415);

var 
c = f_23102_32320_32414(f_23102_32338_32413(ExampleSource + InstrumentationHelperSource, @"C:\myproject\doc1.cs"))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32429,32478);

var 
peImage = f_23102_32443_32477(c, EmitOptions.Default)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32494,32531);

var 
peReader = f_23102_32509_32530(peImage)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32545,32635);

var 
reader = f_23102_32558_32634(peReader, "<DynamicAnalysisData>")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32651,32671);

f_23102_32651_32670(reader);
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,32190,32682);

Microsoft.CodeAnalysis.SyntaxTree
f_23102_32338_32413(string
text,string
filename)
{
var return_v = Parse( text, filename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32338, 32413);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23102_32320_32414(Microsoft.CodeAnalysis.SyntaxTree
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32320, 32414);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23102_32443_32477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.Emit.EmitOptions
options)
{
var return_v = compilation.EmitToArray( options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32443, 32477);
return return_v;
}


System.Reflection.PortableExecutable.PEReader
f_23102_32509_32530(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = new System.Reflection.PortableExecutable.PEReader( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32509, 32530);
return return_v;
}


Microsoft.CodeAnalysis.DynamicAnalysisDataReader
f_23102_32558_32634(System.Reflection.PortableExecutable.PEReader
peReader,string
resourceName)
{
var return_v = DynamicAnalysisDataReader.TryCreateFromPE( peReader, resourceName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32558, 32634);
return return_v;
}


int
f_23102_32651_32670(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
@object)
{
Assert.Null( (object)@object);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 32651, 32670);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,32190,32682);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,32190,32682);
}
		}

[WorkItem(42985, "https://github.com/dotnet/roslyn/issues/42985")]
        [Fact]
        public void EmptyStaticConstructor_WithEnableTestCoverage()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,32694,34151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,32870,33017);

string 
source = @"
#nullable enable
class C
{
    static C()
    {
    }

    static object obj = null!;
}" + InstrumentationHelperSource
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,33031,33151);

var 
emitOptions = f_23102_33049_33150(EmitOptions.Default, f_23102_33094_33149(InstrumentationKind.TestCoverage))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,33165,34140);

f_23102_33165_34139(f_23102_33165_33215(this, source, emitOptions: emitOptions), "C..cctor()", @"{
  // Code size       57 (0x39)
  .maxstack  5
  .locals init (bool[] V_0)
  IL_0000:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0005:  ldtoken    ""C..cctor()""
  IL_000a:  ldelem.ref
  IL_000b:  stloc.0
  IL_000c:  ldloc.0
  IL_000d:  brtrue.s   IL_0034
  IL_000f:  ldsfld     ""System.Guid <PrivateImplementationDetails>.MVID""
  IL_0014:  ldtoken    ""C..cctor()""
  IL_0019:  ldtoken    Source Document 0
  IL_001e:  ldsfld     ""bool[][] <PrivateImplementationDetails>.PayloadRoot0""
  IL_0023:  ldtoken    ""C..cctor()""
  IL_0028:  ldelema    ""bool[]""
  IL_002d:  ldc.i4.1
  IL_002e:  call       ""bool[] Microsoft.CodeAnalysis.Runtime.Instrumentation.CreatePayload(System.Guid, int, int, ref bool[], int)""
  IL_0033:  stloc.0
  IL_0034:  ldloc.0
  IL_0035:  ldc.i4.0
  IL_0036:  ldc.i4.1
  IL_0037:  stelem.i1
  IL_0038:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,32694,34151);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_33094_33149(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 33094, 33149);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_33049_33150(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 33049, 33150);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23102_33165_33215(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests
this_param,string
source,Microsoft.CodeAnalysis.Emit.EmitOptions
emitOptions)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, emitOptions:emitOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 33165, 33215);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23102_33165_34139(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 33165, 34139);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,32694,34151);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,32694,34151);
}
		}

[WorkItem(42985, "https://github.com/dotnet/roslyn/issues/42985")]
        [Fact]
        public void SynthesizedStaticConstructor_WithEnableTestCoverage()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,34163,35072);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,34345,34460);

string 
source = @"
#nullable enable
class C
{
    static object obj = null!;
}" + InstrumentationHelperSource
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,34474,34594);

var 
emitOptions = f_23102_34492_34593(EmitOptions.Default, f_23102_34537_34592(InstrumentationKind.TestCoverage))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,34608,34840);

f_23102_34608_34839(this, source, options: f_23102_34677_34750(TestOptions.DebugDll, MetadataImportOptions.All), emitOptions: emitOptions, symbolValidator: validator);

void validator(ModuleSymbol module)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,34856,35061);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,34924,34988);

var 
type = f_23102_34935_34987(f_23102_34935_34960(module), "C")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35006,35046);

f_23102_35006_35045(f_23102_35019_35044(type, ".cctor"));
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,34856,35061);

Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
f_23102_34935_34960(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
this_param)
{
var return_v = this_param.ContainingAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 34935, 34960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23102_34935_34987(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
this_param,string
fullyQualifiedMetadataName)
{
var return_v = this_param.GetTypeByMetadataName( fullyQualifiedMetadataName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 34935, 34987);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23102_35019_35044(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param,string
name)
{
var return_v = this_param.GetMembers( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 35019, 35044);
return return_v;
}


int
f_23102_35006_35045(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 35006, 35045);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,34856,35061);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,34856,35061);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,34163,35072);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
f_23102_34537_34592(Microsoft.CodeAnalysis.Emit.InstrumentationKind
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 34537, 34592);
return return_v;
}


Microsoft.CodeAnalysis.Emit.EmitOptions
f_23102_34492_34593(Microsoft.CodeAnalysis.Emit.EmitOptions
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.InstrumentationKind>
instrumentationKinds)
{
var return_v = this_param.WithInstrumentationKinds( instrumentationKinds);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 34492, 34593);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23102_34677_34750(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 34677, 34750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23102_34608_34839(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.Emit.EmitOptions
emitOptions,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, emitOptions:emitOptions, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 34608, 34839);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,34163,35072);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,34163,35072);
}
		}
private class SpanResult
{
public int StartLine {get; }

public int StartColumn {get; }

public int EndLine {get; }

public int EndColumn {get; }

public string TextStart {get; }

public SpanResult(int startLine, int startColumn, int endLine, int endColumn, string textStart)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(23102,35351,35676);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35133,35162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35176,35207);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35221,35248);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35262,35291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35305,35337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35479,35501);

StartLine = startLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35519,35545);

StartColumn = startColumn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35563,35581);

EndLine = endLine;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35599,35621);

EndColumn = endColumn;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35639,35661);

TextStart = textStart;
DynAbs.Tracing.TraceSender.TraceExitConstructor(23102,35351,35676);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,35351,35676);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,35351,35676);
}
		}

static SpanResult()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23102,35084,35687);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23102,35084,35687);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,35084,35687);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23102,35084,35687);
}

private static void VerifySpans(DynamicAnalysisDataReader reader, DynamicAnalysisMethod methodData, string[] sourceLines, params SpanResult[] expected)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23102,35699,36522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35875,35970);

ArrayBuilder<string> 
expectedSpanSpellings = f_23102_35920_35969(f_23102_35953_35968(expected))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,35984,36423);
foreach(SpanResult expectedSpanResult in f_23102_36026_36034_I(expected) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(23102,35984,36423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,36068,36206);

f_23102_36068_36205(f_23102_36080_36204(f_23102_36080_36163(sourceLines[f_23102_36092_36120(expectedSpanResult)], f_23102_36132_36162(expectedSpanResult)), f_23102_36175_36203(expectedSpanResult)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,36224,36408);

f_23102_36224_36407(                expectedSpanSpellings, f_23102_36250_36406("({0},{1})-({2},{3})", f_23102_36287_36315(expectedSpanResult), f_23102_36317_36347(expectedSpanResult), f_23102_36349_36375(expectedSpanResult), f_23102_36377_36405(expectedSpanResult)));
DynAbs.Tracing.TraceSender.TraceExitCondition(23102,35984,36423);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23102,1,440);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23102,1,440);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,36439,36511);

f_23102_36439_36510(reader, methodData, f_23102_36471_36509(expectedSpanSpellings));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23102,35699,36522);

int
f_23102_35953_35968(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 35953, 35968);
return return_v;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
f_23102_35920_35969(int
capacity)
{
var return_v = ArrayBuilder<string>.GetInstance( capacity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 35920, 35969);
return return_v;
}


int
f_23102_36092_36120(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.StartLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36092, 36120);
return return_v;
}


int
f_23102_36132_36162(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.StartColumn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36132, 36162);
return return_v;
}


string
f_23102_36080_36163(string
this_param,int
startIndex)
{
var return_v = this_param.Substring( startIndex);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36080, 36163);
return return_v;
}


string
f_23102_36175_36203(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.TextStart;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36175, 36203);
return return_v;
}


bool
f_23102_36080_36204(string
this_param,string
value)
{
var return_v = this_param.StartsWith( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36080, 36204);
return return_v;
}


int
f_23102_36068_36205(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36068, 36205);
return 0;
}


int
f_23102_36287_36315(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.StartLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36287, 36315);
return return_v;
}


int
f_23102_36317_36347(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.StartColumn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36317, 36347);
return return_v;
}


int
f_23102_36349_36375(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.EndLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36349, 36375);
return return_v;
}


int
f_23102_36377_36405(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult
this_param)
{
var return_v = this_param.EndColumn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23102, 36377, 36405);
return return_v;
}


string
f_23102_36250_36406(string
format,params object?[]
args)
{
var return_v = string.Format( format, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36250, 36406);
return return_v;
}


int
f_23102_36224_36407(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36224, 36407);
return 0;
}


Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
f_23102_36026_36034_I(Microsoft.CodeAnalysis.CSharp.DynamicAnalysis.UnitTests.DynamicAnalysisResourceTests.SpanResult[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36026, 36034);
return return_v;
}


string[]
f_23102_36471_36509(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string>
this_param)
{
var return_v = this_param.ToArrayAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36471, 36509);
return return_v;
}


int
f_23102_36439_36510(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
reader,Microsoft.CodeAnalysis.DynamicAnalysisMethod
methodData,params string[]
expected)
{
VerifySpans( reader, methodData, expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36439, 36510);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,35699,36522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,35699,36522);
}
		}

private static void VerifySpans(DynamicAnalysisDataReader reader, DynamicAnalysisMethod methodData, params string[] expected)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23102,36534,36830);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,36684,36819);

f_23102_36684_36818(expected, f_23102_36709_36741(reader, methodData.Blob).Select(s => $"({s.StartLine},{s.StartColumn})-({s.EndLine},{s.EndColumn})"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23102,36534,36830);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DynamicAnalysisSpan>
f_23102_36709_36741(Microsoft.CodeAnalysis.DynamicAnalysisDataReader
this_param,System.Reflection.Metadata.BlobHandle
handle)
{
var return_v = this_param.GetSpans( handle);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36709, 36741);
return return_v;
}


bool
f_23102_36684_36818(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 36684, 36818);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,36534,36830);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,36534,36830);
}
		}

private void VerifyDocuments(DynamicAnalysisDataReader reader, ImmutableArray<DynamicAnalysisDocument> documents, params string[] expected)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23102,36842,37632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,37006,37066);

var 
sha1 = f_23102_37017_37065("ff1816ec-aa5e-4d10-87f7-6f4963833460")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,37082,37572);

var 
actual = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from d in documents
                         let name = reader.GetDocumentName(d.Name)
                         let hash = d.Hash.IsNil ? "" : " " + BitConverter.ToString(reader.GetBytes(d.Hash))
                         let hashAlgGuid = reader.GetGuid(d.HashAlgorithm)
                         let hashAlg = (hashAlgGuid == sha1) ? " (SHA1)" : (hashAlgGuid == default(Guid)) ? "" : " " + hashAlgGuid.ToString()
                         select $"'{name}'{hash}{hashAlg}",23102,37095,37571)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,37588,37621);

f_23102_37588_37620(expected, actual);
DynAbs.Tracing.TraceSender.TraceExitMethod(23102,36842,37632);

System.Guid
f_23102_37017_37065(string
g)
{
var return_v = new System.Guid( g);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 37017, 37065);
return return_v;
}


bool
f_23102_37588_37620(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23102, 37588, 37620);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23102,36842,37632);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,36842,37632);
}
		}

public DynamicAnalysisResourceTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23102,692,37639);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23102,692,37639);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,692,37639);
}


static DynamicAnalysisResourceTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23102,692,37639);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,780,1359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23102,1385,1814);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23102,692,37639);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23102,692,37639);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23102,692,37639);
}
}
