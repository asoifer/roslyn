// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class InAttributeModifierTests : CSharpTestBase
{
[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,596,1644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,725,873);

var 
reference = f_23117_741_872(@"
public class TestRef
{
    public void M(in int p)
    {
        System.Console.WriteLine(p);
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,889,1055);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1071,1185);

var 
verifier = f_23117_1086_1184(this, code, references: new[] { f_23117_1129_1160(reference)}, expectedOutput: "5")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1199,1237);

f_23117_1199_1236(f_23117_1215_1235(verifier));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1253,1364);

verifier = f_23117_1264_1363(this, code, references: new[] { f_23117_1307_1339(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1378,1416);

f_23117_1378_1415(f_23117_1394_1414(verifier));

void verifyParameter(Compilation comp)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,1432,1633);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1503,1554);

var 
m = (IMethodSymbol)f_23117_1526_1553(comp, "TestRef.M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1572,1618);

f_23117_1572_1617(f_23117_1585_1616(f_23117_1585_1597(m)[0]));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,1432,1633);

Microsoft.CodeAnalysis.ISymbol
f_23117_1526_1553(Microsoft.CodeAnalysis.Compilation
compilation,string
qualifiedName)
{
var return_v = compilation.GetMember( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1526, 1553);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
f_23117_1585_1597(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 1585, 1597);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
f_23117_1585_1616(Microsoft.CodeAnalysis.IParameterSymbol
this_param)
{
var return_v = this_param.GetAttributes();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1585, 1616);
return return_v;
}


int
f_23117_1572_1617(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1572, 1617);
return 0;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,1432,1633);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,1432,1633);
}
		}
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,596,1644);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_741_872(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 741, 872);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_1129_1160(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1129, 1160);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_1086_1184(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1086, 1184);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23117_1215_1235(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 1215, 1235);
return return_v;
}


int
f_23117_1199_1236(Microsoft.CodeAnalysis.Compilation
comp)
{
verifyParameter( comp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1199, 1236);
return 0;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_1307_1339(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1307, 1339);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_1264_1363(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1264, 1363);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23117_1394_1414(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 1394, 1414);
return return_v;
}


int
f_23117_1378_1415(Microsoft.CodeAnalysis.Compilation
comp)
{
verifyParameter( comp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1378, 1415);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,596,1644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,596,1644);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,1656,2374);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1786,1955);

var 
reference = f_23117_1802_1954(@"
public class TestRef
{
    private int value = 5;
    public ref readonly int M()
    {
        return ref value;
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,1971,2134);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2150,2249);

f_23117_2150_2248(this, code, references: new[] { f_23117_2193_2224(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2263,2363);

f_23117_2263_2362(this, code, references: new[] { f_23117_2306_2338(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,1656,2374);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_1802_1954(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 1802, 1954);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_2193_2224(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2193, 2224);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_2150_2248(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2150, 2248);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_2306_2338(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2306, 2338);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_2263_2362(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2263, 2362);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,1656,2374);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,1656,2374);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,2386,3064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2507,2647);

var 
reference = f_23117_2523_2646(@"
public class TestRef
{
    private int value = 5;
    public ref readonly int P => ref value;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2663,2824);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2840,2939);

f_23117_2840_2938(this, code, references: new[] { f_23117_2883_2914(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,2953,3053);

f_23117_2953_3052(this, code, references: new[] { f_23117_2996_3028(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,2386,3064);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_2523_2646(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2523, 2646);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_2883_2914(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2883, 2914);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_2840_2938(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2840, 2938);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_2996_3028(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2996, 3028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_2953_3052(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 2953, 3052);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,2386,3064);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,2386,3064);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,3076,3788);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,3206,3364);

var 
reference = f_23117_3222_3363(@"
public class TestRef
{
    public int this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,3380,3548);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,3564,3663);

f_23117_3564_3662(this, code, references: new[] { f_23117_3607_3638(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,3677,3777);

f_23117_3677_3776(this, code, references: new[] { f_23117_3720_3752(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,3076,3788);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_3222_3363(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3222, 3363);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_3607_3638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3607, 3638);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_3564_3662(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3564, 3662);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_3720_3752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3720, 3752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_3677_3776(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3677, 3776);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,3076,3788);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,3076,3788);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,3800,4499);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,3931,4081);

var 
reference = f_23117_3947_4080(@"
public class TestRef
{
    private int value = 5;
    public ref readonly int this[int p] => ref value;
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4097,4259);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4275,4374);

f_23117_4275_4373(this, code, references: new[] { f_23117_4318_4349(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4388,4488);

f_23117_4388_4487(this, code, references: new[] { f_23117_4431_4463(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,3800,4499);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_3947_4080(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 3947, 4080);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_4318_4349(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4318, 4349);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_4275_4373(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4275, 4373);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_4431_4463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4431, 4463);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_4388_4487(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4388, 4487);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,3800,4499);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,3800,4499);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,4511,5223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4642,4718);

var 
reference = f_23117_4658_4717(@"
public delegate void D(in int p);
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4734,4983);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Process((in int p) => System.Console.WriteLine(p));
    }

    private static void Process(D func)
    {
        int value = 5;
        func(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,4999,5098);

f_23117_4999_5097(this, code, references: new[] { f_23117_5042_5073(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,5112,5212);

f_23117_5112_5211(this, code, references: new[] { f_23117_5155_5187(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,4511,5223);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_4658_4717(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4658, 4717);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_5042_5073(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5042, 5073);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_4999_5097(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 4999, 5097);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_5155_5187(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5155, 5187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_5112_5211(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5112, 5211);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,4511,5223);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,4511,5223);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,5235,5960);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,5367,5447);

var 
reference = f_23117_5383_5446(@"
public delegate ref readonly int D();
")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,5463,5720);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Process(() => ref value);
    }

    private static void Process(D func)
    {
        System.Console.WriteLine(func());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,5736,5835);

f_23117_5736_5834(this, code, references: new[] { f_23117_5779_5810(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,5849,5949);

f_23117_5849_5948(this, code, references: new[] { f_23117_5892_5924(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,5235,5960);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_5383_5446(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5383, 5446);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_5779_5810(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5779, 5810);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_5736_5834(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5736, 5834);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_5892_5924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5892, 5924);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_5849_5948(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 5849, 5948);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,5235,5960);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,5235,5960);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,5972,7391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,6104,7024);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual 
          instance void  M(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) x) cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,7040,7105);

var 
reference = f_23117_7056_7104(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,7121,7287);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,7303,7380);

f_23117_7303_7379(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,5972,7391);

Microsoft.CodeAnalysis.MetadataReference
f_23117_7056_7104(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 7056, 7104);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_7303_7379(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 7303, 7379);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,5972,7391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,5972,7391);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,7403,8952);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,7536,8588);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot virtual 
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) 
          M() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,8604,8669);

var 
reference = f_23117_8620_8668(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,8685,8848);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,8864,8941);

f_23117_8864_8940(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,7403,8952);

Microsoft.CodeAnalysis.MetadataReference
f_23117_8620_8668(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 8620, 8668);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_8864_8940(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 8864, 8940);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,7403,8952);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,7403,8952);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,8964,10723);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,9088,10361);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          get_P() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldflda     int32 TestRef::'value'
    IL_0006:  ret
  }

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          P()
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) TestRef::get_P()
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,10377,10442);

var 
reference = f_23117_10393_10441(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,10458,10619);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,10635,10712);

f_23117_10635_10711(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,8964,10723);

Microsoft.CodeAnalysis.MetadataReference
f_23117_10393_10441(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 10393, 10441);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_10635_10711(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 10635, 10711);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,8964,10723);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,8964,10723);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,10735,12501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,10868,12132);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, int32 'value') cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }

  .property instance int32 Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute))
  {
    .set instance void TestRef::set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute), int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,12148,12213);

var 
reference = f_23117_12164_12212(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,12229,12397);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,12413,12490);

f_23117_12413_12489(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,10735,12501);

Microsoft.CodeAnalysis.MetadataReference
f_23117_12164_12212(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 12164, 12212);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_12413_12489(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 12413, 12489);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,10735,12501);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,10735,12501);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,12513,14541);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,12647,14178);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          get_Item(int32 p) cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) Item(int32)
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) TestRef::get_Item(int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,14194,14259);

var 
reference = f_23117_14210_14258(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,14275,14437);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,14453,14530);

f_23117_14453_14529(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,12513,14541);

Microsoft.CodeAnalysis.MetadataReference
f_23117_14210_14258(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 14210, 14258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_14453_14529(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 14453, 14529);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,12513,14541);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,12513,14541);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,14553,16460);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,14687,16010);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance void Invoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance void  EndInvoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,16026,16091);

var 
reference = f_23117_16042_16090(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,16107,16356);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Process((in int p) => System.Console.WriteLine(p));
    }

    private static void Process(D func)
    {
        int value = 5;
        func(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,16372,16449);

f_23117_16372_16448(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,14553,16460);

Microsoft.CodeAnalysis.MetadataReference
f_23117_16042_16090(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 16042, 16090);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_16372_16448(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 16372, 16448);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,14553,16460);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,14553,16460);
}
		}

[Fact]
        public void InAttributeModReqIsConsumedInRefCustomModifiersPosition_IL_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,16472,18180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,16607,17722);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) Invoke() runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) EndInvoke(class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,17738,17803);

var 
reference = f_23117_17754_17802(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,17819,18076);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Process(() => ref value);
    }

    private static void Process(D func)
    {
        System.Console.WriteLine(func());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,18092,18169);

f_23117_18092_18168(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,16472,18180);

Microsoft.CodeAnalysis.MetadataReference
f_23117_17754_17802(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 17754, 17802);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_18092_18168(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 18092, 18168);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,16472,18180);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,16472,18180);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,18192,19859);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,18320,19240);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual 
          instance void  M(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute)& x) cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,19256,19321);

var 
reference = f_23117_19272_19320(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,19337,19503);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,19519,19848);

f_23117_19519_19847(f_23117_19519_19575(code, references: new[] { reference }), f_23117_19749_19846(f_23117_19749_19826(f_23117_19749_19791(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M(in int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,18192,19859);

Microsoft.CodeAnalysis.MetadataReference
f_23117_19272_19320(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19272, 19320);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_19519_19575(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19519, 19575);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_19749_19791(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19749, 19791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_19749_19826(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19749, 19826);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_19749_19846(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19749, 19846);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_19519_19847(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 19519, 19847);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,18192,19859);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,18192,19859);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,19871,21677);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,20000,21052);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot virtual 
          instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &
          M() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,21068,21133);

var 
reference = f_23117_21084_21132(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,21149,21312);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,21328,21666);

f_23117_21328_21665(f_23117_21328_21384(code, references: new[] { reference }), f_23117_21573_21664(f_23117_21573_21644(f_23117_21573_21615(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,19871,21677);

Microsoft.CodeAnalysis.MetadataReference
f_23117_21084_21132(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21084, 21132);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_21328_21384(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21328, 21384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_21573_21615(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21573, 21615);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_21573_21644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21573, 21644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_21573_21664(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21573, 21664);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_21328_21665(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 21328, 21665);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,19871,21677);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,19871,21677);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,21689,24359);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,21809,23085);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &
          get_P() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldflda     int32 TestRef::'value'
    IL_0006:  ret
  }

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &
          P()
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & TestRef::get_P()
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,23101,23166);

var 
reference = f_23117_23117_23165(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,23182,23343);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,23359,23799);

f_23117_23359_23798(f_23117_23359_23415(code, references: new[] { reference }), f_23117_23684_23797(f_23117_23684_23777(f_23117_23684_23731(ErrorCode.ERR_BindToBogusProp1, "P"), "TestRef.P", "TestRef.get_P()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,23815,23978);

code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.get_P());
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,23994,24348);

f_23117_23994_24347(f_23117_23994_24050(code, references: new[] { reference }), f_23117_24247_24346(f_23117_24247_24326(f_23117_24247_24293(ErrorCode.ERR_BindToBogus, "get_P"), "TestRef.get_P()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,21689,24359);

Microsoft.CodeAnalysis.MetadataReference
f_23117_23117_23165(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23117, 23165);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_23359_23415(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23359, 23415);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_23684_23731(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23684, 23731);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_23684_23777(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23684, 23777);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_23684_23797(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23684, 23797);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_23359_23798(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23359, 23798);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_23994_24050(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23994, 24050);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_24247_24293(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 24247, 24293);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_24247_24326(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 24247, 24326);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_24247_24346(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 24247, 24346);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_23994_24347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 23994, 24347);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,21689,24359);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,21689,24359);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,24371,27113);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,24500,25767);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & p, int32 'value') cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }

  .property instance int32 Item(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &)
  {
    .set instance void TestRef::set_Item(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &, int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,25783,25848);

var 
reference = f_23117_25799_25847(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,25864,26032);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,26048,26528);

f_23117_26048_26527(f_23117_26048_26104(code, references: new[] { reference }), f_23117_26380_26526(f_23117_26380_26507(f_23117_26380_26436(ErrorCode.ERR_BindToBogusProp1, "obj[value]"), "TestRef.this[in int]", "TestRef.set_Item(in int, int)"), 8, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,26544,26716);

code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.set_Item(value, 0);
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,26732,27102);

f_23117_26732_27101(f_23117_26732_26788(code, references: new[] { reference }), f_23117_26984_27100(f_23117_26984_27080(f_23117_26984_27033(ErrorCode.ERR_BindToBogus, "set_Item"), "TestRef.set_Item(in int, int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,24371,27113);

Microsoft.CodeAnalysis.MetadataReference
f_23117_25799_25847(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 25799, 25847);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_26048_26104(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26048, 26104);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26380_26436(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26380, 26436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26380_26507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26380, 26507);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26380_26526(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26380, 26526);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_26048_26527(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26048, 26527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_26732_26788(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26732, 26788);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26984_27033(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26984, 27033);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26984_27080(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26984, 27080);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_26984_27100(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26984, 27100);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_26732_27101(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 26732, 27101);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,24371,27113);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,24371,27113);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,27125,30121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,27255,28789);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) &
          get_Item(int32 p) cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & Item(int32)
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & TestRef::get_Item(int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,28805,28870);

var 
reference = f_23117_28821_28869(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,28886,29048);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,29064,29538);

f_23117_29064_29537(f_23117_29064_29120(code, references: new[] { reference }), f_23117_29404_29536(f_23117_29404_29516(f_23117_29404_29456(ErrorCode.ERR_BindToBogusProp1, "obj[0]"), "TestRef.this[int]", "TestRef.get_Item(int)"), 7, 34));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,29554,29721);

code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.get_Item(0));
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,29737,30110);

f_23117_29737_30109(f_23117_29737_29793(code, references: new[] { reference }), f_23117_30000_30108(f_23117_30000_30088(f_23117_30000_30049(ErrorCode.ERR_BindToBogus, "get_Item"), "TestRef.get_Item(int)"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,27125,30121);

Microsoft.CodeAnalysis.MetadataReference
f_23117_28821_28869(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 28821, 28869);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_29064_29120(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29064, 29120);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_29404_29456(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29404, 29456);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_29404_29516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29404, 29516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_29404_29536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29404, 29536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_29064_29537(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29064, 29537);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_29737_29793(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29737, 29793);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_30000_30049(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 30000, 30049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_30000_30088(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 30000, 30088);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_30000_30108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 30000, 30108);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_29737_30109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 29737, 30109);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,27125,30121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,27125,30121);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,30133,32627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,30263,31589);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance void Invoke(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & p) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & p, class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance void  EndInvoke(int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & p, class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,31605,31670);

var 
reference = f_23117_31621_31669(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,31686,31935);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Process((in int p) => System.Console.WriteLine(p));
    }

    private static void Process(D func)
    {
        int value = 5;
        func(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,31951,32616);

f_23117_31951_32615(f_23117_31951_32007(code, references: new[] { reference }), f_23117_32218_32354(f_23117_32218_32334(f_23117_32218_32300(ErrorCode.ERR_BindToBogus, "(in int p) => System.Console.WriteLine(p)"), "D.Invoke(in int)"), 6, 17), f_23117_32508_32614(f_23117_32508_32594(f_23117_32508_32560(ErrorCode.ERR_BindToBogus, "func(value)"), "D.Invoke(in int)"), 12, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,30133,32627);

Microsoft.CodeAnalysis.MetadataReference
f_23117_31621_31669(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 31621, 31669);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_31951_32007(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 31951, 32007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32218_32300(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32218, 32300);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32218_32334(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32218, 32334);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32218_32354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32218, 32354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32508_32560(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32508, 32560);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32508_32594(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32508, 32594);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_32508_32614(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 32508, 32614);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_31951_32615(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 31951, 32615);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,30133,32627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,30133,32627);
}
		}

[Fact]
        public void InAttributeModReqIsNotAllowedInCustomModifiersPosition_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,32639,34875);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,32770,33887);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & Invoke() runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance int32 modreq([mscorlib]System.Runtime.InteropServices.InAttribute) & EndInvoke(class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,33903,33968);

var 
reference = f_23117_33919_33967(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,33984,34241);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Process(() => ref value);
    }

    private static void Process(D func)
    {
        System.Console.WriteLine(func());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,34257,34864);

f_23117_34257_34863(f_23117_34257_34313(code, references: new[] { reference }), f_23117_34492_34596(f_23117_34492_34576(f_23117_34492_34548(ErrorCode.ERR_BindToBogus, "() => ref value"), "D.Invoke()"), 8, 17), f_23117_34766_34862(f_23117_34766_34841(f_23117_34766_34813(ErrorCode.ERR_BindToBogus, "func()"), "D.Invoke()"), 13, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,32639,34875);

Microsoft.CodeAnalysis.MetadataReference
f_23117_33919_33967(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 33919, 33967);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_34257_34313(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34257, 34313);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34492_34548(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34492, 34548);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34492_34576(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34492, 34576);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34492_34596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34492, 34596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34766_34813(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34766, 34813);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34766_34841(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34766, 34841);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_34766_34862(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34766, 34862);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_34257_34863(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 34257, 34863);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,32639,34875);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,32639,34875);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForInSignatures_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,34887,36569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,35021,35950);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual 
          instance void  M(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) x) cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,35966,36031);

var 
reference = f_23117_35982_36030(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,36047,36213);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,36229,36558);

f_23117_36229_36557(f_23117_36229_36285(code, references: new[] { reference }), f_23117_36459_36556(f_23117_36459_36536(f_23117_36459_36501(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M(in int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,34887,36569);

Microsoft.CodeAnalysis.MetadataReference
f_23117_35982_36030(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 35982, 36030);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_36229_36285(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 36229, 36285);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_36459_36501(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 36459, 36501);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_36459_36536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 36459, 36536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_36459_36556(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 36459, 36556);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_36229_36557(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 36229, 36557);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,34887,36569);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,34887,36569);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForRefReadOnlySignatures_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,36581,38410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,36725,37785);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot virtual 
          instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute)
          M() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 ) 
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,37801,37866);

var 
reference = f_23117_37817_37865(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,37882,38045);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,38061,38399);

f_23117_38061_38398(f_23117_38061_38117(code, references: new[] { reference }), f_23117_38306_38397(f_23117_38306_38377(f_23117_38306_38348(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,36581,38410);

Microsoft.CodeAnalysis.MetadataReference
f_23117_37817_37865(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 37817, 37865);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_38061_38117(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 38061, 38117);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_38306_38348(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 38306, 38348);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_38306_38377(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 38306, 38377);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_38306_38397(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 38306, 38397);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_38061_38398(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 38061, 38398);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,36581,38410);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,36581,38410);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForRefReadOnlySignatures_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,38422,41131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,38557,39857);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute)
          get_P() cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldflda     int32 TestRef::'value'
    IL_0006:  ret
  }

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute)
          P()
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) TestRef::get_P()
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,39873,39938);

var 
reference = f_23117_39889_39937(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,39954,40115);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,40131,40571);

f_23117_40131_40570(f_23117_40131_40187(code, references: new[] { reference }), f_23117_40456_40569(f_23117_40456_40549(f_23117_40456_40503(ErrorCode.ERR_BindToBogusProp1, "P"), "TestRef.P", "TestRef.get_P()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,40587,40750);

code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.get_P());
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,40766,41120);

f_23117_40766_41119(f_23117_40766_40822(code, references: new[] { reference }), f_23117_41019_41118(f_23117_41019_41098(f_23117_41019_41065(ErrorCode.ERR_BindToBogus, "get_P"), "TestRef.get_P()"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,38422,41131);

Microsoft.CodeAnalysis.MetadataReference
f_23117_39889_39937(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 39889, 39937);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_40131_40187(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40131, 40187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_40456_40503(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40456, 40503);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_40456_40549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40456, 40549);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_40456_40569(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40456, 40569);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_40131_40570(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40131, 40570);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_40766_40822(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40766, 40822);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_41019_41065(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 41019, 41065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_41019_41098(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 41019, 41098);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_41019_41118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 41019, 41118);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_40766_41119(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 40766, 41119);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,38422,41131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,38422,41131);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForInSignatures_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,41143,43915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,41278,42569);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) p, int32 'value') cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }

  .property instance int32 Item(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute))
  {
    .set instance void TestRef::set_Item(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute), int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,42585,42650);

var 
reference = f_23117_42601_42649(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,42666,42834);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,42850,43330);

f_23117_42850_43329(f_23117_42850_42906(code, references: new[] { reference }), f_23117_43182_43328(f_23117_43182_43309(f_23117_43182_43238(ErrorCode.ERR_BindToBogusProp1, "obj[value]"), "TestRef.this[in int]", "TestRef.set_Item(in int, int)"), 8, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,43346,43518);

code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.set_Item(value, 0);
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,43534,43904);

f_23117_43534_43903(f_23117_43534_43590(code, references: new[] { reference }), f_23117_43786_43902(f_23117_43786_43882(f_23117_43786_43835(ErrorCode.ERR_BindToBogus, "set_Item"), "TestRef.set_Item(in int, int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,41143,43915);

Microsoft.CodeAnalysis.MetadataReference
f_23117_42601_42649(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 42601, 42649);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_42850_42906(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 42850, 42906);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43182_43238(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43182, 43238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43182_43309(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43182, 43309);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43182_43328(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43182, 43328);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_42850_43329(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 42850, 43329);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_43534_43590(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43534, 43590);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43786_43835(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43786, 43835);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43786_43882(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43786, 43882);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_43786_43902(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43786, 43902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_43534_43903(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 43534, 43903);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,41143,43915);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,41143,43915);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForRefReadOnlySignatures_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,43927,46980);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,44072,45630);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute)
          get_Item(int32 p) cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a
    IL_000a:  ldloc.0
    IL_000b:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  }

  .property instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) Item(int32)
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) TestRef::get_Item(int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,45646,45711);

var 
reference = f_23117_45662_45710(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,45727,45889);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,45905,46379);

f_23117_45905_46378(f_23117_45905_45961(code, references: new[] { reference }), f_23117_46245_46377(f_23117_46245_46357(f_23117_46245_46297(ErrorCode.ERR_BindToBogusProp1, "obj[0]"), "TestRef.this[int]", "TestRef.get_Item(int)"), 7, 34));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,46395,46562);

code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.get_Item(0));
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,46578,46969);

f_23117_46578_46968(f_23117_46578_46634(code, references: new[] { reference }), f_23117_46841_46949(f_23117_46841_46929(f_23117_46841_46890(ErrorCode.ERR_BindToBogus, "get_Item"), "TestRef.get_Item(int)"), 7, 38));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,43927,46980);

Microsoft.CodeAnalysis.MetadataReference
f_23117_45662_45710(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 45662, 45710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_45905_45961(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 45905, 45961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46245_46297(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46245, 46297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46245_46357(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46245, 46357);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46245_46377(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46245, 46377);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_45905_46378(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 45905, 46378);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_46578_46634(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46578, 46634);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46841_46890(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46841, 46890);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46841_46929(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46841, 46929);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_46841_46949(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46841, 46949);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_46578_46968(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 46578, 46968);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,43927,46980);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,43927,46980);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForInSignatures_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,46992,49516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,47128,48478);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance void Invoke(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) p) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) p, class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance void  EndInvoke(int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) p, class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,48494,48559);

var 
reference = f_23117_48510_48558(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,48575,48824);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Process((in int p) => System.Console.WriteLine(p));
    }

    private static void Process(D func)
    {
        int value = 5;
        func(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,48840,49505);

f_23117_48840_49504(f_23117_48840_48896(code, references: new[] { reference }), f_23117_49107_49243(f_23117_49107_49223(f_23117_49107_49189(ErrorCode.ERR_BindToBogus, "(in int p) => System.Console.WriteLine(p)"), "D.Invoke(in int)"), 6, 17), f_23117_49397_49503(f_23117_49397_49483(f_23117_49397_49449(ErrorCode.ERR_BindToBogus, "func(value)"), "D.Invoke(in int)"), 12, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,46992,49516);

Microsoft.CodeAnalysis.MetadataReference
f_23117_48510_48558(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 48510, 48558);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_48840_48896(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 48840, 48896);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49107_49189(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49107, 49189);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49107_49223(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49107, 49223);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49107_49243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49107, 49243);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49397_49449(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49397, 49449);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49397_49483(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49397, 49483);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_49397_49503(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 49397, 49503);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_48840_49504(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 48840, 49504);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,46992,49516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,46992,49516);
}
		}

[Fact]
        public void OtherModReqsAreNotAllowedOnRefCustomModifiersForRefReadOnlySignatures_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,49528,51795);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,49674,50807);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) Invoke() runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance int32& modreq([mscorlib]System.Runtime.CompilerServices.IsReadOnlyAttribute) EndInvoke(class [mscorlib]System.IAsyncResult result) runtime managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,50823,50888);

var 
reference = f_23117_50839_50887(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,50904,51161);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Process(() => ref value);
    }

    private static void Process(D func)
    {
        System.Console.WriteLine(func());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,51177,51784);

f_23117_51177_51783(f_23117_51177_51233(code, references: new[] { reference }), f_23117_51412_51516(f_23117_51412_51496(f_23117_51412_51468(ErrorCode.ERR_BindToBogus, "() => ref value"), "D.Invoke()"), 8, 17), f_23117_51686_51782(f_23117_51686_51761(f_23117_51686_51733(ErrorCode.ERR_BindToBogus, "func()"), "D.Invoke()"), 13, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,49528,51795);

Microsoft.CodeAnalysis.MetadataReference
f_23117_50839_50887(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 50839, 50887);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_51177_51233(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51177, 51233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51412_51468(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51412, 51468);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51412_51496(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51412, 51496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51412_51516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51412, 51516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51686_51733(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51686, 51733);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51686_51761(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51686, 51761);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_51686_51782(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51686, 51782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_51177_51783(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 51177, 51783);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,49528,51795);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,49528,51795);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,51807,52526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,51941,52096);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
}
class Test
{
    public virtual void M(in object x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,52112,52515);

f_23117_52112_52514(f_23117_52112_52140(code), f_23117_52370_52513(f_23117_52370_52493(f_23117_52370_52433(ErrorCode.ERR_PredefinedTypeNotFound, "in object x"), "System.Runtime.InteropServices.InAttribute"), 9, 27));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,51807,52526);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_52112_52140(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52112, 52140);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_52370_52433(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52370, 52433);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_52370_52493(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52370, 52493);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_52370_52513(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52370, 52513);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_52112_52514(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52112, 52514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,51807,52526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,51807,52526);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,52538,53330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,52673,52876);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
}
class Test
{
    private object value = null;
    public virtual ref readonly object M() => ref value;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,52892,53319);

f_23117_52892_53318(f_23117_52892_52920(code), f_23117_53165_53317(f_23117_53165_53296(f_23117_53165_53236(ErrorCode.ERR_PredefinedTypeNotFound, "ref readonly object"), "System.Runtime.InteropServices.InAttribute"), 10, 20));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,52538,53330);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_52892_52920(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52892, 52920);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53165_53236(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53165, 53236);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53165_53296(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53165, 53296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53165_53317(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53165, 53317);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_52892_53318(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 52892, 53318);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,52538,53330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,52538,53330);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,53342,54121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,53468,53669);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
}
class Test
{
    private object value = null;
    public virtual ref readonly object M => ref value;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,53685,54110);

f_23117_53685_54109(f_23117_53685_53713(code), f_23117_53956_54108(f_23117_53956_54087(f_23117_53956_54027(ErrorCode.ERR_PredefinedTypeNotFound, "ref readonly object"), "System.Runtime.InteropServices.InAttribute"), 10, 20));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,53342,54121);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_53685_53713(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53685, 53713);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53956_54027(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53956, 54027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53956_54087(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53956, 54087);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_53956_54108(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53956, 54108);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_53685_54109(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 53685, 54109);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,53342,54121);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,53342,54121);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,54133,54873);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,54268,54433);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
}
class Test
{
    public virtual object this[in object p] => null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,54449,54862);

f_23117_54449_54861(f_23117_54449_54477(code), f_23117_54717_54860(f_23117_54717_54840(f_23117_54717_54780(ErrorCode.ERR_PredefinedTypeNotFound, "in object p"), "System.Runtime.InteropServices.InAttribute"), 9, 32));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,54133,54873);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_54449_54477(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 54449, 54477);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_54717_54780(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 54717, 54780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_54717_54840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 54717, 54840);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_54717_54860(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 54717, 54860);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_54449_54861(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 54449, 54861);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,54133,54873);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,54133,54873);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,54885,55700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,55021,55235);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
}
class Test
{
    private object value = null;
    public virtual ref readonly object this[object p] => ref value;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,55251,55689);

f_23117_55251_55688(f_23117_55251_55279(code), f_23117_55535_55687(f_23117_55535_55666(f_23117_55535_55606(ErrorCode.ERR_PredefinedTypeNotFound, "ref readonly object"), "System.Runtime.InteropServices.InAttribute"), 10, 20));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,54885,55700);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_55251_55279(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 55251, 55279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_55535_55606(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 55535, 55606);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_55535_55666(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 55535, 55666);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_55535_55687(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 55535, 55687);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_55251_55688(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 55251, 55688);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,54885,55700);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,54885,55700);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,55712,56531);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,55848,56111);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class IntPtr {}
    public class Int32 {}
    public class Delegate {}
    public class MulticastDelegate : Delegate {}
}
public delegate void D(in int p);"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,56127,56520);

f_23117_56127_56519(f_23117_56127_56155(code), f_23117_56377_56518(f_23117_56377_56497(f_23117_56377_56437(ErrorCode.ERR_PredefinedTypeNotFound, "in int p"), "System.Runtime.InteropServices.InAttribute"), 11, 24));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,55712,56531);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_56127_56155(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56127, 56155);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_56377_56437(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56377, 56437);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_56377_56497(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56377, 56497);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_56377_56518(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56377, 56518);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_56127_56519(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56127, 56519);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,55712,56531);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,55712,56531);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfMscorlibInAttributeIsNotAvailable_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,56543,57379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,56680,56947);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class IntPtr {}
    public class Int32 {}
    public class Delegate {}
    public class MulticastDelegate : Delegate {}
}
public delegate ref readonly int D();"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,56963,57368);

f_23117_56963_57367(f_23117_56963_56991(code), f_23117_57217_57366(f_23117_57217_57345(f_23117_57217_57285(ErrorCode.ERR_PredefinedTypeNotFound, "ref readonly int"), "System.Runtime.InteropServices.InAttribute"), 11, 17));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,56543,57379);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_56963_56991(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56963, 56991);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_57217_57285(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 57217, 57285);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_57217_57345(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 57217, 57345);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_57217_57366(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 57217, 57366);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_56963_57367(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 56963, 57367);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,56543,57379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,56543,57379);
}
		}

[Fact]
        public void InAttributeIsWrittenOnInMembers_Methods_Parameters_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,57391,58111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,57504,57583);

var 
code = @"
class Test
{
    public virtual void Method(in int x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,57599,57970);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,57986,58100);

f_23117_57986_58099(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,57391,58111);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_57986_58099(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 57986, 58099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,57391,58111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,57391,58111);
}
		}

[Fact]
        public void InAttributeIsWrittenOnInMembers_Methods_Parameters_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,58123,58851);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,58237,58323);

var 
code = @"
abstract class Test
{
    public abstract void Method(in int x);
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,58339,58710);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,58726,58840);

f_23117_58726_58839(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,58123,58851);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_58726_58839(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 58726, 58839);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,58123,58851);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,58123,58851);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Methods_ReturnTypes_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,58863,59604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,58986,59099);

var 
code = @"
class Test
{
    private int x = 0;
    public virtual ref readonly int Method() => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,59115,59463);

Action<ModuleSymbol> 
validator = module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,59479,59593);

f_23117_59479_59592(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,58863,59604);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_59479_59592(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 59479, 59592);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,58863,59604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,58863,59604);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Methods_ReturnTypes_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,59616,60335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,59740,59830);

var 
code = @"
abstract class Test
{
    public abstract ref readonly int Method();
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,59846,60194);

Action<ModuleSymbol> 
validator = module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,60210,60324);

f_23117_60210_60323(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,59616,60335);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_60210_60323(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 60210, 60323);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,59616,60335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,59616,60335);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Methods_ReturnTypes_NoModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,60347,61084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,60474,60579);

var 
code = @"
class Test
{
    private int x = 0;
    public ref readonly int Method() => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,60595,60943);

Action<ModuleSymbol> 
validator = module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,60959,61073);

f_23117_60959_61072(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,60347,61084);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_60959_61072(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 60959, 61072);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,60347,61084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,60347,61084);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Methods_ReturnTypes_Static()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,61096,61842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,61218,61337);

var 
code = @"
class Test
{
    private static int x = 0;
    public static ref readonly int Method() => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,61353,61701);

Action<ModuleSymbol> 
validator = module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,61717,61831);

f_23117_61717_61830(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,61096,61842);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_61717_61830(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 61717, 61830);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,61096,61842);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,61096,61842);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Properties_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,61854,62590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,61968,62081);

var 
code = @"
class Test
{
    private int x = 0;
    public virtual ref readonly int Property => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,62097,62449);

Action<ModuleSymbol> 
validator = module =>
            {
                var property = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("Property");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,62465,62579);

f_23117_62465_62578(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,61854,62590);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_62465_62578(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 62465, 62578);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,61854,62590);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,61854,62590);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Properties_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,62602,63324);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,62717,62815);

var 
code = @"
abstract class Test
{
    public abstract ref readonly int Property { get; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,62831,63183);

Action<ModuleSymbol> 
validator = module =>
            {
                var property = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("Property");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,63199,63313);

f_23117_63199_63312(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,62602,63324);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_63199_63312(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 63199, 63312);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,62602,63324);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,62602,63324);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Properties_NoModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,63336,64068);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,63454,63559);

var 
code = @"
class Test
{
    private int x = 0;
    public ref readonly int Property => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,63575,63927);

Action<ModuleSymbol> 
validator = module =>
            {
                var property = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("Property");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,63943,64057);

f_23117_63943_64056(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,63336,64068);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_63943_64056(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 63943, 64056);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,63336,64068);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,63336,64068);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Properties_Static()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,64080,64821);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,64193,64312);

var 
code = @"
class Test
{
    private static int x = 0;
    public static ref readonly int Property => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,64328,64680);

Action<ModuleSymbol> 
validator = module =>
            {
                var property = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("Property");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,64696,64810);

f_23117_64696_64809(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,64080,64821);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_64696_64809(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 64696, 64809);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,64080,64821);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,64080,64821);
}
		}

[Fact]
        public void InAttributeIsWrittenOnInMembers_Indexers_Parameters_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,64833,65555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,64947,65025);

var 
code = @"
class Test
{
    public virtual int this[in int x] => x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,65041,65414);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,65430,65544);

f_23117_65430_65543(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,64833,65555);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_65430_65543(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 65430, 65543);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,64833,65555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,64833,65555);
}
		}

[Fact]
        public void InAttributeIsWrittenOnInMembers_Indexers_Parameters_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,65567,66303);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,65682,65773);

var 
code = @"
abstract class Test
{
    public abstract int this[in int x] { get; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,65789,66162);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,66178,66292);

f_23117_66178_66291(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,65567,66303);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_66178_66291(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 66178, 66291);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,65567,66303);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,65567,66303);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Indexers_ReturnTypes_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,66315,67055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,66439,66551);

var 
code = @"
class Test
{
    private int x;
    public virtual ref readonly int this[int p] => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,66567,66914);

Action<ModuleSymbol> 
validator = module =>
            {
                var indexer = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,66930,67044);

f_23117_66930_67043(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,66315,67055);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_66930_67043(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 66930, 67043);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,66315,67055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,66315,67055);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Indexers_ReturnTypes_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,67067,67883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,67192,67293);

var 
code = @"
abstract class Test
{
    public abstract ref readonly int this[int p] { get; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,67309,67742);

Action<ModuleSymbol> 
validator = module =>
            {
                var indexer = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,67758,67872);

f_23117_67758_67871(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,67067,67883);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_67758_67871(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 67758, 67871);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,67067,67883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,67067,67883);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Indexers_ReturnTypes_NoModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,67895,68631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,68023,68127);

var 
code = @"
class Test
{
    private int x;
    public ref readonly int this[int p] => ref x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,68143,68490);

Action<ModuleSymbol> 
validator = module =>
            {
                var indexer = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,68506,68620);

f_23117_68506_68619(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,67895,68631);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_68506_68619(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 68506, 68619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,67895,68631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,67895,68631);
}
		}

[Fact]
        public void InAttributeIsWrittenOnInMembers_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,68643,69935);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,68750,68797);

var 
code = "public delegate void D(in int p);"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,68813,69794);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("D");

                var invokeParameter = type.DelegateInvokeMethod.Parameters.Single();
                Assert.Empty(invokeParameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(invokeParameter.RefCustomModifiers);

                var beginInvokeParameter = type.GetMethod("BeginInvoke").Parameters.First();
                Assert.Empty(beginInvokeParameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(beginInvokeParameter.RefCustomModifiers);

                var endInvokeParameter = type.GetMethod("EndInvoke").Parameters.First();
                Assert.Empty(endInvokeParameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(endInvokeParameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,69810,69924);

f_23117_69810_69923(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,68643,69935);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_69810_69923(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 69810, 69923);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,68643,69935);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,68643,69935);
}
		}

[Fact]
        public void InAttributeIsWrittenOnRefReadOnlyMembers_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,69947,70924);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,70064,70115);

var 
code = "public delegate ref readonly int D();"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,70131,70783);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("D");

                var invokeMethod = type.DelegateInvokeMethod;
                Assert.Empty(invokeMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(invokeMethod.RefCustomModifiers);

                var endInvokeMethod = type.GetMethod("EndInvoke");
                Assert.Empty(endInvokeMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(endInvokeMethod.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,70799,70913);

f_23117_70799_70912(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,69947,70924);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_70799_70912(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 70799, 70912);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,69947,70924);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,69947,70924);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnInMembers_Methods_Parameters_NoModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,70936,71628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,71056,71127);

var 
code = @"
class Test
{
    public void Method(in int x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,71143,71487);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,71503,71617);

f_23117_71503_71616(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,70936,71628);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_71503_71616(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 71503, 71616);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,70936,71628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,70936,71628);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnInMembers_Methods_Parameters_Static()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,71640,72334);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,71755,71833);

var 
code = @"
class Test
{
    public static void Method(in int x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,71849,72193);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("Method").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,72209,72323);

f_23117_72209_72322(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,71640,72334);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_72209_72322(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 72209, 72322);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,71640,72334);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,71640,72334);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnInMembers_Indexers_Parameters_NoModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,72346,73040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,72467,72537);

var 
code = @"
class Test
{
    public int this[in int x] => x;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,72553,72899);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,72915,73029);

f_23117_72915_73028(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,72346,73040);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_72915_73028(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 72915, 73028);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,72346,73040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,72346,73040);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnRefReadOnlyMembers_Operators_Unary()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,73052,73771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,73166,73263);

var 
code = @"
public class Test
{
    public static bool operator!(in Test obj) => false;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,73279,73630);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("op_LogicalNot").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,73646,73760);

f_23117_73646_73759(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,73052,73771);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_73646_73759(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 73646, 73759);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,73052,73771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,73052,73771);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnRefReadOnlyMembers_Operators_Binary()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,73783,74718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,73898,74010);

var 
code = @"
public class Test
{
    public static bool operator+(in Test obj1, in Test obj2) => false;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,74026,74577);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameters = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod("op_Addition").Parameters;
                Assert.Equal(2, parameters.Length);

                Assert.Empty(parameters[0].TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameters[0].RefCustomModifiers);

                Assert.Empty(parameters[1].TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameters[1].RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,74593,74707);

f_23117_74593_74706(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,73783,74718);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_74593_74706(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 74593, 74706);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,73783,74718);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,73783,74718);
}
		}

[Fact]
        public void InAttributeIsNotWrittenOnRefReadOnlyMembers_Constructors()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,74730,75412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,74841,74912);

var 
code = @"
public class Test
{
    public Test(in int x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,74928,75271);

Action<ModuleSymbol> 
validator = module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("Test").GetMethod(".ctor").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,75287,75401);

f_23117_75287_75400(this, code, verify: Verification.Passes, sourceSymbolValidator: validator, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,74730,75412);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_75287_75400(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
sourceSymbolValidator,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, sourceSymbolValidator:sourceSymbolValidator, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 75287, 75400);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,74730,75412);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,74730,75412);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,75424,77038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,75563,76480);

var 
ilSource = @"
.class public auto ansi beforefieldinit TestRef extends [mscorlib]System.Object
{
    .method public hidebysig newslot virtual instance void M (int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) x) cil managed 
    {
        .maxstack 8
        IL_0000: nop                  // Do nothing (No operation)
        IL_0001: ret                  // Return from method, possibly with a value
    }

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: call instance void [mscorlib]System.Object::.ctor() // Call method indicated on the stack with arguments
        IL_0006: nop                  // Do nothing (No operation)
        IL_0007: ret                  // Return from method, possibly with a value
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,76496,76666);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(ref value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,76682,77027);

f_23117_76682_77026(f_23117_76682_76748(code, references: new[] { f_23117_76726_76745(ilSource)}), f_23117_76927_77025(f_23117_76927_77005(f_23117_76927_76969(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M(ref int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,75424,77038);

Microsoft.CodeAnalysis.MetadataReference
f_23117_76726_76745(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76726, 76745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_76682_76748(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76682, 76748);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_76927_76969(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76927, 76969);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_76927_77005(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76927, 77005);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_76927_77025(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76927, 77025);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_76682_77026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 76682, 77026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,75424,77038);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,75424,77038);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,77050,79362);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,77190,78836);

var 
ilSource = @"
.class public auto ansi beforefieldinit TestRef extends [mscorlib]System.Object
{
    .field private int32 'value'

    .method public hidebysig newslot virtual instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) M () cil managed 
    {
        .maxstack 1
        .locals init ([0] int32&)

        IL_0000: nop                  // Do nothing (No operation)
        IL_0001: ldarg.0              // Load argument 0 onto the stack
        IL_0002: ldflda int32 TestRef::'value' // Push the address of field of object obj on the stack
        IL_0007: stloc.0              // Pop a value from stack into local variable 0
        IL_0008: br.s IL_000a         // Branch to target, short form
        IL_000a: ldloc.0              // Load local variable 0 onto stack
        IL_000b: ret                  // Return from method, possibly with a value
    }

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: ldc.i4.0             // Push 0 onto the stack as int32
        IL_0002: stfld int32 TestRef::'value' // Replace the value of field of the object obj with value
        IL_0007: ldarg.0              // Load argument 0 onto the stack
        IL_0008: call instance void [mscorlib]System.Object::.ctor() // Call method indicated on the stack with arguments
        IL_000d: nop                  // Do nothing (No operation)
        IL_000e: ret                  // Return from method, possibly with a value
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,78852,79001);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        var value = obj.M();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,79017,79351);

f_23117_79017_79350(f_23117_79017_79083(code, references: new[] { f_23117_79061_79080(ilSource)}), f_23117_79258_79349(f_23117_79258_79329(f_23117_79258_79300(ErrorCode.ERR_BindToBogus, "M"), "TestRef.M()"), 7, 25));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,77050,79362);

Microsoft.CodeAnalysis.MetadataReference
f_23117_79061_79080(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79061, 79080);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_79017_79083(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79017, 79083);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_79258_79300(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79258, 79300);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_79258_79329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79258, 79329);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_79258_79349(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79258, 79349);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_79017_79350(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 79017, 79350);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,77050,79362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,77050,79362);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Properties()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,79374,81445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,79505,80927);

var 
ilSource = @"
.class public auto ansi beforefieldinit TestRef extends [mscorlib]System.Object
{
    .field private int32 'value'

    .method public hidebysig specialname newslot virtual instance int32& get_P () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: ldflda int32 TestRef::'value' // Push the address of field of object obj on the stack
        IL_0006: ret                  // Return from method, possibly with a value
    }

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: ldc.i4.0             // Push 0 onto the stack as int32
        IL_0002: stfld int32 TestRef::'value' // Replace the value of field of the object obj with value
        IL_0007: ldarg.0              // Load argument 0 onto the stack
        IL_0008: call instance void [mscorlib]System.Object::.ctor() // Call method indicated on the stack with arguments
        IL_000d: nop                  // Do nothing (No operation)
        IL_000e: ret                  // Return from method, possibly with a value
    }

    .property instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) P()
    {
        .get instance int32& TestRef::get_P()
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,80943,81090);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        var value = obj.P;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,81106,81434);

f_23117_81106_81433(f_23117_81106_81172(code, references: new[] { f_23117_81150_81169(ilSource)}), f_23117_81343_81432(f_23117_81343_81412(f_23117_81343_81385(ErrorCode.ERR_BindToBogus, "P"), "TestRef.P"), 7, 25));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,79374,81445);

Microsoft.CodeAnalysis.MetadataReference
f_23117_81150_81169(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81150, 81169);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_81106_81172(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81106, 81172);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_81343_81385(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81343, 81385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_81343_81412(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81343, 81412);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_81343_81432(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81343, 81432);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_81106_81433(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 81106, 81433);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,79374,81445);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,79374,81445);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,81457,84006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,81597,82715);

var 
ilSource = @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )
  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, int32 'value') cil managed
  {
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  }

  .method public hidebysig specialname rtspecialname instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }

  .property instance int32 Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute))
  {
    .set instance void TestRef::set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute), int32)
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,82731,82899);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,82915,83409);

f_23117_82915_83408(f_23117_82915_82981(code, references: new[] { f_23117_82959_82978(ilSource)}), f_23117_83259_83407(f_23117_83259_83388(f_23117_83259_83315(ErrorCode.ERR_BindToBogusProp1, "obj[value]"), "TestRef.this[ref int]", "TestRef.set_Item(ref int, int)"), 8, 9));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,83425,83597);

code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.set_Item(value, 0);
    }
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,83613,83995);

f_23117_83613_83994(f_23117_83613_83679(code, references: new[] { f_23117_83657_83676(ilSource)}), f_23117_83876_83993(f_23117_83876_83973(f_23117_83876_83925(ErrorCode.ERR_BindToBogus, "set_Item"), "TestRef.set_Item(ref int, int)"), 8, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,81457,84006);

Microsoft.CodeAnalysis.MetadataReference
f_23117_82959_82978(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 82959, 82978);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_82915_82981(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 82915, 82981);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83259_83315(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83259, 83315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83259_83388(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83259, 83388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83259_83407(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83259, 83407);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_82915_83408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 82915, 83408);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_83657_83676(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83657, 83676);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_83613_83679(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83613, 83679);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83876_83925(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83876, 83925);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83876_83973(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83876, 83973);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_83876_83993(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83876, 83993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_83613_83994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 83613, 83994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,81457,84006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,81457,84006);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,84018,86280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,84159,85739);

var 
ilSource = @"
.class public auto ansi beforefieldinit TestRef extends [mscorlib]System.Object
{
    .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = (01 00 04 49 74 65 6d 00 00)
    
    .field private int32 'value'

    .method public hidebysig specialname newslot virtual instance int32& get_Item (int32 p) cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: ldflda int32 TestRef::'value' // Push the address of field of object obj on the stack
        IL_0006: ret                  // Return from method, possibly with a value
    }

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0              // Load argument 0 onto the stack
        IL_0001: ldc.i4.0             // Push 0 onto the stack as int32
        IL_0002: stfld int32 TestRef::'value' // Replace the value of field of the object obj with value
        IL_0007: ldarg.0              // Load argument 0 onto the stack
        IL_0008: call instance void [mscorlib]System.Object::.ctor() // Call method indicated on the stack with arguments
        IL_000d: nop                  // Do nothing (No operation)
        IL_000e: ret                  // Return from method, possibly with a value
    }

    .property instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) Item(int32 p)
    {
        .get instance int32& TestRef::get_Item(int32)
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,85755,85903);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        var value = obj[5];
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,85919,86269);

f_23117_85919_86268(f_23117_85919_85985(code, references: new[] { f_23117_85963_85982(ilSource)}), f_23117_86165_86267(f_23117_86165_86247(f_23117_86165_86212(ErrorCode.ERR_BindToBogus, "obj[5]"), "TestRef.this[int]"), 7, 21));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,84018,86280);

Microsoft.CodeAnalysis.MetadataReference
f_23117_85963_85982(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 85963, 85982);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_85919_85985(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 85919, 85985);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_86165_86212(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 86165, 86212);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_86165_86247(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 86165, 86247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_86165_86267(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 86165, 86267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_85919_86268(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 85919, 86268);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,84018,86280);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,84018,86280);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Delegates_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,86292,88337);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,86433,87366);

var 
ilSource = @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance void Invoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p) runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance void  EndInvoke(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p, class [mscorlib]System.IAsyncResult result) runtime managed
  {
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,87382,87631);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Process((in int p) => System.Console.WriteLine(p));
    }

    private static void Process(D func)
    {
        int value = 5;
        func(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,87647,88326);

f_23117_87647_88325(f_23117_87647_87713(code, references: new[] { f_23117_87691_87710(ilSource)}), f_23117_87925_88062(f_23117_87925_88042(f_23117_87925_88007(ErrorCode.ERR_BindToBogus, "(in int p) => System.Console.WriteLine(p)"), "D.Invoke(ref int)"), 6, 17), f_23117_88217_88324(f_23117_88217_88304(f_23117_88217_88269(ErrorCode.ERR_BindToBogus, "func(value)"), "D.Invoke(ref int)"), 12, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,86292,88337);

Microsoft.CodeAnalysis.MetadataReference
f_23117_87691_87710(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87691, 87710);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_87647_87713(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87647, 87713);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_87925_88007(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87925, 88007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_87925_88042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87925, 88042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_87925_88062(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87925, 88062);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_88217_88269(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 88217, 88269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_88217_88304(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 88217, 88304);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_88217_88324(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 88217, 88324);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_87647_88325(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 87647, 88325);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,86292,88337);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,86292,88337);
}
		}

[Fact]
        public void InAttributeModReqIsRejectedOnSignaturesWithoutIsReadOnlyAttribute_Delegates_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,88349,90255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,88491,89338);

var 
ilSource = @"
.class public auto ansi sealed D
       extends [mscorlib]System.MulticastDelegate
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor(object 'object', native int 'method') runtime managed
  {
  }

  .method public hidebysig newslot virtual instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) Invoke() runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance class [mscorlib]System.IAsyncResult
          BeginInvoke(class [mscorlib]System.AsyncCallback callback, object 'object') runtime managed
  {
  }

  .method public hidebysig newslot virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) EndInvoke(class [mscorlib]System.IAsyncResult result) runtime managed
  {
  }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,89354,89611);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Process(() => ref value);
    }

    private static void Process(D func)
    {
        System.Console.WriteLine(func());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,89627,90244);

f_23117_89627_90243(f_23117_89627_89693(code, references: new[] { f_23117_89671_89690(ilSource)}), f_23117_89872_89976(f_23117_89872_89956(f_23117_89872_89928(ErrorCode.ERR_BindToBogus, "() => ref value"), "D.Invoke()"), 8, 17), f_23117_90146_90242(f_23117_90146_90221(f_23117_90146_90193(ErrorCode.ERR_BindToBogus, "func()"), "D.Invoke()"), 13, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,88349,90255);

Microsoft.CodeAnalysis.MetadataReference
f_23117_89671_89690(string
ilSource)
{
var return_v = CompileIL( ilSource);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89671, 89690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_89627_89693(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89627, 89693);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_89872_89928(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89872, 89928);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_89872_89956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89872, 89956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_89872_89976(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89872, 89976);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_90146_90193(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 90146, 90193);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_90146_90221(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 90146, 90221);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_90146_90242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 90146, 90242);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_89627_90243(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 89627, 90243);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,88349,90255);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,88349,90255);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_Parameters_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,90267,91940);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,90399,90513);

var 
reference = f_23117_90415_90512(@"
public abstract class Parent
{
    public abstract void M(in int p);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,90529,90944);

f_23117_90529_90943(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,90960,91227);

var 
code = @"
public class Child : Parent
{
    public override void M(in int p)
    {
        System.Console.WriteLine(p);
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj.M(5);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,91243,91644);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,91660,91787);

f_23117_91660_91786(this, code, references: new[] { f_23117_91703_91734(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,91801,91929);

f_23117_91801_91928(this, code, references: new[] { f_23117_91844_91876(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,90267,91940);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_90415_90512(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 90415, 90512);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_90529_90943(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 90529, 90943);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_91703_91734(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 91703, 91734);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_91660_91786(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 91660, 91786);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_91844_91876(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 91844, 91876);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_91801_91928(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 91801, 91928);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,90267,91940);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,90267,91940);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_Parameters_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,91952,93614);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,92083,92189);

var 
reference = f_23117_92099_92188(@"
public class Parent
{
    public virtual void M(in int p) {}
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,92205,92620);

f_23117_92205_92619(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,92636,92903);

var 
code = @"
public class Child : Parent
{
    public override void M(in int p)
    {
        System.Console.WriteLine(p);
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj.M(5);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,92917,93318);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,93334,93461);

f_23117_93334_93460(this, code, references: new[] { f_23117_93377_93408(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,93475,93603);

f_23117_93475_93602(this, code, references: new[] { f_23117_93518_93550(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,91952,93614);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_92099_92188(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 92099, 92188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_92205_92619(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 92205, 92619);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_93377_93408(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93377, 93408);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_93334_93460(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93334, 93460);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_93518_93550(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93518, 93550);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_93475_93602(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93475, 93602);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,91952,93614);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,91952,93614);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_Parameters_ImplicitInterfaces_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,93626,95832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,93773,93866);

var 
reference = f_23117_93789_93865(@"
public interface Parent
{
    void M(in int p);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,93882,94297);

f_23117_93882_94296(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,94313,94571);

var 
code = @"
public class Child : Parent
{
    public void M(in int p)
    {
        System.Console.WriteLine(p);
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj.M(5);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,94587,95536);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitParameter = type.GetMethod("M").Parameters.Single();
                Assert.Empty(implicitParameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(implicitParameter.RefCustomModifiers);

                var explicitImplementation = type.GetMethod("Parent.M");
                Assert.Equal("void Parent.M(in modreq(System.Runtime.InteropServices.InAttribute) System.Int32 p)", explicitImplementation.ExplicitInterfaceImplementations.Single().ToTestDisplayString());

                var explicitParameter = explicitImplementation.Parameters.Single();
                Assert.Empty(explicitParameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(explicitParameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,95552,95679);

f_23117_95552_95678(this, code, references: new[] { f_23117_95595_95626(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,95693,95821);

f_23117_95693_95820(this, code, references: new[] { f_23117_95736_95768(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,93626,95832);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_93789_93865(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93789, 93865);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_93882_94296(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 93882, 94296);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_95595_95626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 95595, 95626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_95552_95678(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 95552, 95678);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_95736_95768(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 95736, 95768);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_95693_95820(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 95693, 95820);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,93626,95832);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,93626,95832);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_Parameters_ImplicitInterfaces_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,95844,97507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,95988,96081);

var 
reference = f_23117_96004_96080(@"
public interface Parent
{
    void M(in int p);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,96097,96512);

f_23117_96097_96511(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,96528,96794);

var 
code = @"
public class Child : Parent
{
    public virtual void M(in int p)
    {
        System.Console.WriteLine(p);
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj.M(5);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,96810,97211);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,97227,97354);

f_23117_97227_97353(this, code, references: new[] { f_23117_97270_97301(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,97368,97496);

f_23117_97368_97495(this, code, references: new[] { f_23117_97411_97443(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,95844,97507);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_96004_96080(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 96004, 96080);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_96097_96511(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 96097, 96511);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_97270_97301(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97270, 97301);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_97227_97353(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97227, 97353);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_97411_97443(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97411, 97443);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_97368_97495(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97368, 97495);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,95844,97507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,95844,97507);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_Parameters_ExplicitInterfaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,97519,99171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,97655,97748);

var 
reference = f_23117_97671_97747(@"
public interface Parent
{
    void M(in int p);
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,97764,98179);

f_23117_97764_98178(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetMethod("M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,98195,98453);

var 
code = @"
public class Child : Parent
{
    void Parent.M(in int p)
    {
        System.Console.WriteLine(p);
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj.M(5);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,98467,98875);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetMethod("Parent.M").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,98891,99018);

f_23117_98891_99017(this, code, references: new[] { f_23117_98934_98965(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,99032,99160);

f_23117_99032_99159(this, code, references: new[] { f_23117_99075_99107(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,97519,99171);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_97671_97747(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97671, 97747);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_97764_98178(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 97764, 98178);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_98934_98965(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 98934, 98965);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_98891_99017(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 98891, 99017);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_99075_99107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 99075, 99107);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_99032_99159(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 99032, 99159);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,97519,99171);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,97519,99171);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_ReturnTypes_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,99183,100832);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,99316,99434);

var 
reference = f_23117_99332_99433(@"
public abstract class Parent
{
    public abstract ref readonly int M();
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,99450,99842);

f_23117_99450_99841(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var method = type.GetMethod("M");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,99858,100144);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,100158,100536);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var method = type.GetMethod("M");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,100552,100679);

f_23117_100552_100678(this, code, references: new[] { f_23117_100595_100626(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,100693,100821);

f_23117_100693_100820(this, code, references: new[] { f_23117_100736_100768(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,99183,100832);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_99332_99433(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 99332, 99433);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_99450_99841(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 99450, 99841);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_100595_100626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 100595, 100626);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_100552_100678(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 100552, 100678);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_100736_100768(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 100736, 100768);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_100693_100820(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 100693, 100820);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,99183,100832);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,99183,100832);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_ReturnTypes_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,100844,102497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,100976,101099);

var 
reference = f_23117_100992_101098(@"
public class Parent
{
    public virtual ref readonly int M() { throw null; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,101115,101507);

f_23117_101115_101506(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var method = type.GetMethod("M");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,101523,101809);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,101823,102201);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var method = type.GetMethod("M");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,102217,102344);

f_23117_102217_102343(this, code, references: new[] { f_23117_102260_102291(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,102358,102486);

f_23117_102358_102485(this, code, references: new[] { f_23117_102401_102433(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,100844,102497);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_100992_101098(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 100992, 101098);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_101115_101506(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 101115, 101506);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_102260_102291(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102260, 102291);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_102217_102343(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102217, 102343);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_102401_102433(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102401, 102433);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_102358_102485(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102358, 102485);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,100844,102497);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,100844,102497);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_ReturnTypes_ImplicitInterfaces_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,102509,104167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,102657,102754);

var 
reference = f_23117_102673_102753(@"
public interface Parent
{
    ref readonly int M();
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,102770,103162);

f_23117_102770_103161(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var method = type.GetMethod("M");

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,103178,103455);

var 
code = @"
public class Child : Parent
{
    public ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,103469,103871);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitMethod = type.GetMethod("M");
                Assert.Empty(implicitMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitMethod.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,103887,104014);

f_23117_103887_104013(this, code, references: new[] { f_23117_103930_103961(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,104028,104156);

f_23117_104028_104155(this, code, references: new[] { f_23117_104071_104103(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,102509,104167);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_102673_102753(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102673, 102753);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_102770_103161(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 102770, 103161);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_103930_103961(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 103930, 103961);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_103887_104013(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 103887, 104013);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_104071_104103(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 104071, 104103);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_104028_104155(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 104028, 104155);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,102509,104167);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,102509,104167);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_ReturnTypes_ImplicitInterfaces_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,104179,105866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,104324,104421);

var 
reference = f_23117_104340_104420(@"
public interface Parent
{
    ref readonly int M();
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,104437,104853);

f_23117_104437_104852(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var implicitMethod = type.GetMethod("M");

                Assert.Empty(implicitMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitMethod.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,104869,105154);

var 
code = @"
public class Child : Parent
{
    public virtual ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,105168,105570);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var implicitMethod = type.GetMethod("M");

                Assert.Empty(implicitMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitMethod.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,105586,105713);

f_23117_105586_105712(this, code, references: new[] { f_23117_105629_105660(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,105727,105855);

f_23117_105727_105854(this, code, references: new[] { f_23117_105770_105802(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,104179,105866);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_104340_104420(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 104340, 104420);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_104437_104852(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 104437, 104852);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_105629_105660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 105629, 105660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_105586_105712(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 105586, 105712);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_105770_105802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 105770, 105802);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_105727_105854(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 105727, 105854);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,104179,105866);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,104179,105866);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Methods_ReturnTypes_ExplicitInterfaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,105878,107556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,106015,106112);

var 
reference = f_23117_106031_106111(@"
public interface Parent
{
    ref readonly int M();
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,106128,106544);

f_23117_106128_106543(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var implicitMethod = type.GetMethod("M");

                Assert.Empty(implicitMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitMethod.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,106560,106837);

var 
code = @"
public class Child : Parent
{
    ref readonly int Parent.M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,106851,107260);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var implicitMethod = type.GetMethod("Parent.M");

                Assert.Empty(implicitMethod.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitMethod.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,107276,107403);

f_23117_107276_107402(this, code, references: new[] { f_23117_107319_107350(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,107417,107545);

f_23117_107417_107544(this, code, references: new[] { f_23117_107460_107492(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,105878,107556);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_106031_106111(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 106031, 106111);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_106128_106543(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 106128, 106543);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_107319_107350(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107319, 107350);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_107276_107402(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107276, 107402);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_107460_107492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107460, 107492);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_107417_107544(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107417, 107544);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,105878,107556);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,105878,107556);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Properties_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,107568,109214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,107692,107816);

var 
reference = f_23117_107708_107815(@"
public abstract class Parent
{
    public abstract ref readonly int P { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,107832,108226);

f_23117_107832_108225(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,108242,108524);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int P => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,108538,108918);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,108934,109061);

f_23117_108934_109060(this, code, references: new[] { f_23117_108977_109008(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,109075,109203);

f_23117_109075_109202(this, code, references: new[] { f_23117_109118_109150(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,107568,109214);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_107708_107815(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107708, 107815);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_107832_108225(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 107832, 108225);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_108977_109008(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 108977, 109008);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_108934_109060(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 108934, 109060);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_109118_109150(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 109118, 109150);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_109075_109202(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 109075, 109202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,107568,109214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,107568,109214);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Properties_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,109226,110878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,109349,109478);

var 
reference = f_23117_109365_109477(@"
public class Parent
{
    public virtual ref readonly int P { get { throw null; } }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,109494,109888);

f_23117_109494_109887(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,109904,110186);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int P => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,110202,110582);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,110598,110725);

f_23117_110598_110724(this, code, references: new[] { f_23117_110641_110672(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,110739,110867);

f_23117_110739_110866(this, code, references: new[] { f_23117_110782_110814(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,109226,110878);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_109365_109477(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 109365, 109477);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_109494_109887(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 109494, 109887);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_110641_110672(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 110641, 110672);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_110598_110724(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 110598, 110724);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_110782_110814(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 110782, 110814);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_110739_110866(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 110739, 110866);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,109226,110878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,109226,110878);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Properties_ImplicitInterface_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,110890,112546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,111028,111131);

var 
reference = f_23117_111044_111130(@"
public interface Parent
{
    ref readonly int P { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,111147,111541);

f_23117_111147_111540(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,111557,111830);

var 
code = @"
public class Child : Parent
{
    public ref readonly int P => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,111846,112250);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitproperty = type.GetProperty("P");
                Assert.Empty(implicitproperty.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(implicitproperty.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,112266,112393);

f_23117_112266_112392(this, code, references: new[] { f_23117_112309_112340(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,112407,112535);

f_23117_112407_112534(this, code, references: new[] { f_23117_112450_112482(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,110890,112546);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_111044_111130(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 111044, 111130);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_111147_111540(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 111147, 111540);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_112309_112340(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112309, 112340);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_112266_112392(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112266, 112392);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_112450_112482(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112450, 112482);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_112407_112534(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112407, 112534);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,110890,112546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,110890,112546);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Properties_ImplicitInterface_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,112558,114195);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,112693,112796);

var 
reference = f_23117_112709_112795(@"
public interface Parent
{
    ref readonly int P { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,112812,113206);

f_23117_112812_113205(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,113222,113503);

var 
code = @"
public class Child : Parent
{
    public virtual ref readonly int P => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,113519,113899);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,113915,114042);

f_23117_113915_114041(this, code, references: new[] { f_23117_113958_113989(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,114056,114184);

f_23117_114056_114183(this, code, references: new[] { f_23117_114099_114131(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,112558,114195);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_112709_112795(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112709, 112795);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_112812_113205(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 112812, 113205);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_113958_113989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 113958, 113989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_113915_114041(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 113915, 114041);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_114099_114131(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 114099, 114131);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_114056_114183(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 114056, 114183);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,112558,114195);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,112558,114195);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Properties_ExplicitInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,114207,115835);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,114334,114437);

var 
reference = f_23117_114350_114436(@"
public interface Parent
{
    ref readonly int P { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,114453,114847);

f_23117_114453_114846(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var property = type.GetProperty("P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,114863,115136);

var 
code = @"
public class Child : Parent
{
    ref readonly int Parent.P => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.P);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,115152,115539);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var property = type.GetProperty("Parent.P");

                Assert.Empty(property.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(property.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,115555,115682);

f_23117_115555_115681(this, code, references: new[] { f_23117_115598_115629(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,115696,115824);

f_23117_115696_115823(this, code, references: new[] { f_23117_115739_115771(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,114207,115835);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_114350_114436(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 114350, 114436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_114453_114846(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 114453, 114846);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_115598_115629(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 115598, 115629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_115555_115681(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 115555, 115681);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_115739_115771(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 115739, 115771);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_115696_115823(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 115696, 115823);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,114207,115835);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,114207,115835);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_Parameters_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,115847,117557);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,115980,116104);

var 
reference = f_23117_115996_116103(@"
public abstract class Parent
{
    public abstract int this[in int p] { set; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,116120,116542);

f_23117_116120_116541(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,116558,116837);

var 
code = @"
public class Child : Parent
{
    public override int this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj[5] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,116853,117261);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,117277,117404);

f_23117_117277_117403(this, code, references: new[] { f_23117_117320_117351(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,117418,117546);

f_23117_117418_117545(this, code, references: new[] { f_23117_117461_117493(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,115847,117557);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_115996_116103(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 115996, 116103);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_116120_116541(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 116120, 116541);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_117320_117351(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117320, 117351);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_117277_117403(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117277, 117403);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_117461_117493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117461, 117493);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_117418_117545(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117418, 117545);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,115847,117557);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,115847,117557);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_Parameters_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,117569,119271);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,117701,117818);

var 
reference = f_23117_117717_117817(@"
public class Parent
{
    public virtual int this[in int p] { set { } }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,117834,118256);

f_23117_117834_118255(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,118272,118551);

var 
code = @"
public class Child : Parent
{
    public override int this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj[5] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,118567,118975);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,118991,119118);

f_23117_118991_119117(this, code, references: new[] { f_23117_119034_119065(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,119132,119260);

f_23117_119132_119259(this, code, references: new[] { f_23117_119175_119207(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,117569,119271);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_117717_117817(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117717, 117817);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_117834_118255(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 117834, 118255);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_119034_119065(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 119034, 119065);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_118991_119117(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 118991, 119117);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_119175_119207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 119175, 119207);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_119132_119259(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 119132, 119259);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,117569,119271);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,117569,119271);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_Parameters_ImplicitInterface_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,119283,121538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,119430,119533);

var 
reference = f_23117_119446_119532(@"
public interface Parent
{
    int this[in int p] { set; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,119549,119971);

f_23117_119549_119970(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,119987,120257);

var 
code = @"
public class Child : Parent
{
    public int this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj[5] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,120273,121242);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitParameter = type.GetProperty("this[]").Parameters.Single();
                Assert.Empty(implicitParameter.TypeWithAnnotations.CustomModifiers);
                Assert.Empty(implicitParameter.RefCustomModifiers);

                var explicitImplementation = type.GetMethod("Parent.set_Item");
                Assert.Equal("void Parent.this[in modreq(System.Runtime.InteropServices.InAttribute) System.Int32 p].set", explicitImplementation.ExplicitInterfaceImplementations.Single().ToTestDisplayString());

                var explicitParameter = explicitImplementation.Parameters.First();
                Assert.Empty(explicitParameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(explicitParameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,121258,121385);

f_23117_121258_121384(this, code, references: new[] { f_23117_121301_121332(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,121399,121527);

f_23117_121399_121526(this, code, references: new[] { f_23117_121442_121474(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,119283,121538);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_119446_119532(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 119446, 119532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_119549_119970(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 119549, 119970);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_121301_121332(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121301, 121332);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_121258_121384(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121258, 121384);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_121442_121474(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121442, 121474);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_121399_121526(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121399, 121526);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,119283,121538);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,119283,121538);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_Parameters_ImplicitInterface_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,121550,123249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,121694,121797);

var 
reference = f_23117_121710_121796(@"
public interface Parent
{
    int this[in int p] { set; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,121813,122235);

f_23117_121813_122234(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,122251,122529);

var 
code = @"
public class Child : Parent
{
    public virtual int this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj[5] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,122545,122953);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,122969,123096);

f_23117_122969_123095(this, code, references: new[] { f_23117_123012_123043(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,123110,123238);

f_23117_123110_123237(this, code, references: new[] { f_23117_123153_123185(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,121550,123249);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_121710_121796(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121710, 121796);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_121813_122234(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 121813, 122234);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_123012_123043(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 123012, 123043);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_122969_123095(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 122969, 123095);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_123153_123185(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 123153, 123185);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_123110_123237(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 123110, 123237);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,121550,123249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,121550,123249);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_Parameters_ExplicitInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,123261,124949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,123397,123500);

var 
reference = f_23117_123413_123499(@"
public interface Parent
{
    int this[in int p] { set; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,123516,123938);

f_23117_123516_123937(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var parameter = type.GetProperty("this[]").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,123954,124224);

var 
code = @"
public class Child : Parent
{
    int Parent.this[in int p]
    {
        set { System.Console.WriteLine(p); }
    }
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        obj[5] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,124240,124653);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var parameter = type.GetProperty("Parent.Item").Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,124669,124796);

f_23117_124669_124795(this, code, references: new[] { f_23117_124712_124743(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,124810,124938);

f_23117_124810_124937(this, code, references: new[] { f_23117_124853_124885(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,123261,124949);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_123413_123499(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 123413, 123499);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_123516_123937(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 123516, 123937);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_124712_124743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 124712, 124743);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_124669_124795(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 124669, 124795);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_124853_124885(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 124853, 124885);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_124810_124937(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 124810, 124937);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,123261,124949);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,123261,124949);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_ReturnTypes_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,124961,126644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,125095,125229);

var 
reference = f_23117_125111_125228(@"
public abstract class Parent
{
    public abstract ref readonly int this[int p] { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,125245,125641);

f_23117_125245_125640(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,125657,125950);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int this[int p] => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,125966,126348);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,126364,126491);

f_23117_126364_126490(this, code, references: new[] { f_23117_126407_126438(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,126505,126633);

f_23117_126505_126632(this, code, references: new[] { f_23117_126548_126580(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,124961,126644);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_125111_125228(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 125111, 125228);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_125245_125640(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 125245, 125640);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_126407_126438(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126407, 126438);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_126364_126490(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126364, 126490);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_126548_126580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126548, 126580);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_126505_126632(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126505, 126632);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,124961,126644);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,124961,126644);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_ReturnTypes_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,126656,128343);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,126789,126928);

var 
reference = f_23117_126805_126927(@"
public class Parent
{
    public virtual ref readonly int this[int p] { get { throw null; } }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,126944,127340);

f_23117_126944_127339(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,127356,127649);

var 
code = @"
public class Child : Parent
{
    public override ref readonly int this[int p] => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,127665,128047);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,128063,128190);

f_23117_128063_128189(this, code, references: new[] { f_23117_128106_128137(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,128204,128332);

f_23117_128204_128331(this, code, references: new[] { f_23117_128247_128279(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,126656,128343);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_126805_126927(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126805, 126927);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_126944_127339(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 126944, 127339);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_128106_128137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128106, 128137);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_128063_128189(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128063, 128189);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_128247_128279(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128247, 128279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_128204_128331(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128204, 128331);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,126656,128343);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,126656,128343);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_ReturnTypes_ImplicitInterface_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,128355,130022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,128503,128616);

var 
reference = f_23117_128519_128615(@"
public interface Parent
{
    ref readonly int this[int p] { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,128632,129028);

f_23117_128632_129027(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,129044,129328);

var 
code = @"
public class Child : Parent
{
    public ref readonly int this[int p] => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,129344,129726);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,129742,129869);

f_23117_129742_129868(this, code, references: new[] { f_23117_129785_129816(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,129883,130011);

f_23117_129883_130010(this, code, references: new[] { f_23117_129926_129958(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,128355,130022);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_128519_128615(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128519, 128615);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_128632_129027(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 128632, 129027);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_129785_129816(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 129785, 129816);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_129742_129868(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 129742, 129868);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_129926_129958(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 129926, 129958);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_129883_130010(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 129883, 130010);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,128355,130022);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,128355,130022);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_ReturnTypes_ImplicitInterface_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,130034,131706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,130179,130292);

var 
reference = f_23117_130195_130291(@"
public interface Parent
{
    ref readonly int this[int p] { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,130308,130704);

f_23117_130308_130703(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,130720,131012);

var 
code = @"
public class Child : Parent
{
    public virtual ref readonly int this[int p] => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,131028,131410);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,131426,131553);

f_23117_131426_131552(this, code, references: new[] { f_23117_131469_131500(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,131567,131695);

f_23117_131567_131694(this, code, references: new[] { f_23117_131610_131642(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,130034,131706);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_130195_130291(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 130195, 130291);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_130308_130703(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 130308, 130703);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_131469_131500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131469, 131500);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_131426_131552(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131426, 131552);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_131610_131642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131610, 131642);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_131567_131694(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131567, 131694);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,130034,131706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,130034,131706);
}
		}

[Fact]
        public void WhenImplementingParentWithModifiersCopyThem_Indexers_ReturnTypes_ExplicitInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,131718,133379);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,131855,131968);

var 
reference = f_23117_131871_131967(@"
public interface Parent
{
    ref readonly int this[int p] { get; }
}")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,131984,132380);

f_23117_131984_132379(this, reference, symbolValidator: module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Parent");
                var indexer = type.GetProperty("this[]");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,132396,132680);

var 
code = @"
public class Child : Parent
{
    ref readonly int Parent.this[int p] => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,132696,133083);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");
                var indexer = type.GetProperty("Parent.Item");

                Assert.Empty(indexer.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(indexer.RefCustomModifiers);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,133099,133226);

f_23117_133099_133225(this, code, references: new[] { f_23117_133142_133173(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,133240,133368);

f_23117_133240_133367(this, code, references: new[] { f_23117_133283_133315(reference)}, expectedOutput: "5", symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,131718,133379);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_131871_131967(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131871, 131967);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_131984_132379(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 131984, 132379);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_133142_133173(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133142, 133173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_133099_133225(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133099, 133225);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_133283_133315(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133283, 133315);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_133240_133367(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133240, 133367);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,131718,133379);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,131718,133379);
}
		}

[Fact]
        public void CreatingLambdasOfDelegatesWithModifiersCanBeExecuted_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,133391,134491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,133509,133580);

var 
reference = f_23117_133525_133579("public delegate void D(in int p);")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,133596,133978);

f_23117_133596_133977(this, reference, symbolValidator: module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod.Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,133994,134251);

var 
code = @"
public class Test
{
    public static void Main()
    {
        Run((in int p) => System.Console.WriteLine(p));
    }

    public static void Run(D lambda)
    {
        lambda(value);
    }

    private static int value = 5;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,134267,134366);

f_23117_134267_134365(this, code, references: new[] { f_23117_134310_134341(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,134380,134480);

f_23117_134380_134479(this, code, references: new[] { f_23117_134423_134455(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,133391,134491);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_133525_133579(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133525, 133579);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_133596_133977(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 133596, 133977);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_134310_134341(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134310, 134341);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_134267_134365(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134267, 134365);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_134423_134455(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134423, 134455);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_134380_134479(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134380, 134479);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,133391,134491);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,133391,134491);
}
		}

[Fact]
        public void CreatingLambdasOfDelegatesWithModifiersCanBeExecuted_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,134503,135580);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,134622,134697);

var 
reference = f_23117_134638_134696("public delegate ref readonly int D();")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,134713,135072);

f_23117_134713_135071(this, reference, symbolValidator: module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod;

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,135088,135340);

var 
code = @"
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Run(() => ref value);
    }

    public static void Run(D lambda)
    {
        System.Console.WriteLine(lambda());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,135356,135455);

f_23117_135356_135454(this, code, references: new[] { f_23117_135399_135430(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,135469,135569);

f_23117_135469_135568(this, code, references: new[] { f_23117_135512_135544(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,134503,135580);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_134638_134696(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134638, 134696);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_134713_135071(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 134713, 135071);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_135399_135430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135399, 135430);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_135356_135454(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135356, 135454);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_135512_135544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135512, 135544);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_135469_135568(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135469, 135568);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,134503,135580);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,134503,135580);
}
		}

[Fact]
        public void CreatingLambdasOfDelegatesWithModifiersCanBeExecuted_Parameters_DuplicateModifierTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,135592,136882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,135733,135890);

var 
reference = f_23117_135749_135889(@"

namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public delegate void D(in int p);")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,135906,136288);

f_23117_135906_136287(this, reference, symbolValidator: module =>
            {
                var parameter = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod.Parameters.Single();

                Assert.Empty(parameter.TypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(parameter.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,136304,136642);

var 
code = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Test
{
    public static void Main()
    {
        Run((in int p) => System.Console.WriteLine(p));
    }

    public static void Run(D lambda)
    {
        lambda(value);
    }

    private static int value = 5;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,136658,136757);

f_23117_136658_136756(this, code, references: new[] { f_23117_136701_136732(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,136771,136871);

f_23117_136771_136870(this, code, references: new[] { f_23117_136814_136846(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,135592,136882);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_135749_135889(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135749, 135889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_135906_136287(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 135906, 136287);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_136701_136732(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 136701, 136732);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_136658_136756(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 136658, 136756);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_136814_136846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 136814, 136846);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_136771_136870(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 136771, 136870);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,135592,136882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,135592,136882);
}
		}

[Fact]
        public void CreatingLambdasOfDelegatesWithModifiersCanBeExecuted_ReturnTypes_DuplicateModifierTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,136894,138159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,137036,137195);

var 
reference = f_23117_137052_137194(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public delegate ref readonly int D();")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,137211,137570);

f_23117_137211_137569(this, reference, symbolValidator: module =>
            {
                var method = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod;

                Assert.Empty(method.ReturnTypeWithAnnotations.CustomModifiers);
                AssertSingleInAttributeRequiredModifier(method.RefCustomModifiers);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,137586,137919);

var 
code = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Test
{
    private static int value = 5;

    public static void Main()
    {
        Run(() => ref value);
    }

    public static void Run(D lambda)
    {
        System.Console.WriteLine(lambda());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,137935,138034);

f_23117_137935_138033(this, code, references: new[] { f_23117_137978_138009(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,138048,138148);

f_23117_138048_138147(this, code, references: new[] { f_23117_138091_138123(reference)}, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,136894,138159);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_137052_137194(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 137052, 137194);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_137211_137569(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 137211, 137569);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_137978_138009(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 137978, 138009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_137935_138033(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CompilationReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 137935, 138033);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_138091_138123(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138091, 138123);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_138048_138147(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138048, 138147);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,136894,138159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,136894,138159);
}
		}

[Fact]
        public void OverridingMethodSymbolDoesNotCopyModifiersIfItWasRefKindNone_Interface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,138171,139540);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,138296,138427);

var 
code = @"
public interface ITest
{
    ref readonly int M();
}
public class Test : ITest
{
    public int M() => 0;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,138443,138904);

var 
comp = f_23117_138454_138903(f_23117_138454_138477(code), f_23117_138753_138902(f_23117_138753_138882(f_23117_138753_138835(ErrorCode.ERR_CloseUnimplementedInterfaceMemberWrongRefReturn, "ITest"), "Test", "ITest.M()", "Test.M()"), 6, 21))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,138920,138993);

var 
interfaceMethod = f_23117_138942_138992(f_23117_138942_138977(comp, "ITest"), "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139007,139066);

f_23117_139007_139065(RefKind.RefReadOnly, f_23117_139041_139064(interfaceMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139080,139152);

f_23117_139080_139151(interfaceMethod.ReturnTypeWithAnnotations.CustomModifiers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139166,139242);

f_23117_139166_139241(this, f_23117_139206_139240(interfaceMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139258,139326);

var 
classMethod = f_23117_139276_139325(f_23117_139276_139310(comp, "Test"), "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139340,139388);

f_23117_139340_139387(RefKind.None, f_23117_139367_139386(classMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139402,139470);

f_23117_139402_139469(classMethod.ReturnTypeWithAnnotations.CustomModifiers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139484,139529);

f_23117_139484_139528(f_23117_139497_139527(classMethod));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,138171,139540);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_138454_138477(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138454, 138477);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_138753_138835(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138753, 138835);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_138753_138882(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138753, 138882);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_138753_138902(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138753, 138902);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_138454_138903(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138454, 138903);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_23117_138942_138977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,string
fullyQualifiedMetadataName)
{
var return_v = this_param.GetTypeByMetadataName( fullyQualifiedMetadataName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138942, 138977);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23117_138942_138992(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
symbol,string
name)
{
var return_v = symbol.GetMethod( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 138942, 138992);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23117_139041_139064(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 139041, 139064);
return return_v;
}


int
f_23117_139007_139065(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139007, 139065);
return 0;
}


int
f_23117_139080_139151(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139080, 139151);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_23117_139206_139240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefCustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 139206, 139240);
return return_v;
}


int
f_23117_139166_139241(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
modifiers)
{
this_param.AssertSingleInAttributeRequiredModifier( modifiers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139166, 139241);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_23117_139276_139310(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,string
fullyQualifiedMetadataName)
{
var return_v = this_param.GetTypeByMetadataName( fullyQualifiedMetadataName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139276, 139310);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23117_139276_139325(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
symbol,string
name)
{
var return_v = symbol.GetMethod( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139276, 139325);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23117_139367_139386(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 139367, 139386);
return return_v;
}


int
f_23117_139340_139387(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139340, 139387);
return 0;
}


int
f_23117_139402_139469(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139402, 139469);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_23117_139497_139527(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefCustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 139497, 139527);
return return_v;
}


int
f_23117_139484_139528(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139484, 139528);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,138171,139540);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,138171,139540);
}
		}

[Fact]
        public void OverridingMethodSymbolDoesNotCopyModifiersIfItWasRefKindNone_Class()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,139552,140862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139673,139844);

var 
code = @"
public abstract class ParentTest
{
    public abstract ref readonly int M();
}
public class Test : ParentTest
{
    public override int M() => 0;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,139860,140233);

var 
comp = f_23117_139871_140232(f_23117_139871_139894(code), f_23117_140107_140231(f_23117_140107_140211(f_23117_140107_140167(ErrorCode.ERR_CantChangeRefReturnOnOverride, "M"), "Test.M()", "ParentTest.M()"), 8, 25))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140249,140324);

var 
parentMethod = f_23117_140268_140323(f_23117_140268_140308(comp, "ParentTest"), "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140338,140394);

f_23117_140338_140393(RefKind.RefReadOnly, f_23117_140372_140392(parentMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140408,140477);

f_23117_140408_140476(parentMethod.ReturnTypeWithAnnotations.CustomModifiers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140491,140564);

f_23117_140491_140563(this, f_23117_140531_140562(parentMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140580,140648);

var 
classMethod = f_23117_140598_140647(f_23117_140598_140632(comp, "Test"), "M")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140662,140710);

f_23117_140662_140709(RefKind.None, f_23117_140689_140708(classMethod));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140724,140792);

f_23117_140724_140791(classMethod.ReturnTypeWithAnnotations.CustomModifiers);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,140806,140851);

f_23117_140806_140850(f_23117_140819_140849(classMethod));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,139552,140862);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_139871_139894(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139871, 139894);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_140107_140167(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140107, 140167);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_140107_140211(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140107, 140211);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_140107_140231(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140107, 140231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_139871_140232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 139871, 140232);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_23117_140268_140308(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,string
fullyQualifiedMetadataName)
{
var return_v = this_param.GetTypeByMetadataName( fullyQualifiedMetadataName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140268, 140308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23117_140268_140323(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
symbol,string
name)
{
var return_v = symbol.GetMethod( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140268, 140323);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23117_140372_140392(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 140372, 140392);
return return_v;
}


int
f_23117_140338_140393(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140338, 140393);
return 0;
}


int
f_23117_140408_140476(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140408, 140476);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_23117_140531_140562(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefCustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 140531, 140562);
return return_v;
}


int
f_23117_140491_140563(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
modifiers)
{
this_param.AssertSingleInAttributeRequiredModifier( modifiers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140491, 140563);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_23117_140598_140632(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,string
fullyQualifiedMetadataName)
{
var return_v = this_param.GetTypeByMetadataName( fullyQualifiedMetadataName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140598, 140632);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23117_140598_140647(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
symbol,string
name)
{
var return_v = symbol.GetMethod( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140598, 140647);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_23117_140689_140708(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 140689, 140708);
return return_v;
}


int
f_23117_140662_140709(Microsoft.CodeAnalysis.RefKind
expected,Microsoft.CodeAnalysis.RefKind
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140662, 140709);
return 0;
}


int
f_23117_140724_140791(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140724, 140791);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_23117_140819_140849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.RefCustomModifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 140819, 140849);
return return_v;
}


int
f_23117_140806_140850(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
collection)
{
Assert.Empty( (System.Collections.IEnumerable)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 140806, 140850);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,139552,140862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,139552,140862);
}
		}

[Fact]
        public void OverloadResolutionShouldBeAbleToPickOverloadsWithNoModreqsOverOnesWithModreq_Methods_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,140874,142738);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,141024,142371);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig newslot virtual
          instance void  M(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p) cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  } // end of method TestRef::M

  .method public hidebysig newslot virtual
          instance void  M(int64 p) cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  call       void [mscorlib]System.Console::WriteLine(int64)
    IL_0007:  nop
    IL_0008:  ret
  } // end of method TestRef::M

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method TestRef::.ctor
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,142387,142452);

var 
reference = f_23117_142403_142451(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,142468,142634);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj.M(value);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,142650,142727);

f_23117_142650_142726(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,140874,142738);

Microsoft.CodeAnalysis.MetadataReference
f_23117_142403_142451(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 142403, 142451);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_142650_142726(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 142650, 142726);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,140874,142738);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,140874,142738);
}
		}

[Fact]
        public void OverloadResolutionShouldBeAbleToPickOverloadsWithNoModreqsOverOnesWithModreq_Methods_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,142750,144604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,142901,144239);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
   .field private int32 'value'
  .method public hidebysig newslot virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          M(int32 p) cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldflda     int32 TestRef::'value'
    IL_0006:  ret
  } // end of method TestRef::M

  .method public hidebysig newslot virtual
          instance int32  M(int64 p) cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 TestRef::'value'
    IL_0006:  ret
  } // end of method TestRef::M

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  } // end of method TestRef::.ctor
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,144255,144320);

var 
reference = f_23117_144271_144319(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,144336,144500);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj.M(0));
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,144516,144593);

f_23117_144516_144592(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,142750,144604);

Microsoft.CodeAnalysis.MetadataReference
f_23117_144271_144319(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 144271, 144319);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_144516_144592(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 144516, 144592);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,142750,144604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,142750,144604);
}
		}

[Fact]
        public void OverloadResolutionShouldBeAbleToPickOverloadsWithNoModreqsOverOnesWithModreq_Indexers_Parameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,144616,147281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,144767,146912);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )                      // ...Item..
  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) p,
                                  int32 'value') cil managed
  {
    .param [1]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldind.i4
    IL_0003:  call       void [mscorlib]System.Console::WriteLine(int32)
    IL_0008:  nop
    IL_0009:  ret
  } // end of method TestRef::set_Item

  .method public hidebysig newslot specialname virtual
          instance void  set_Item(int64 p,
                                  int32 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  call       void [mscorlib]System.Console::WriteLine(int64)
    IL_0007:  nop
    IL_0008:  ret
  } // end of method TestRef::set_Item

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method TestRef::.ctor

  .property instance int32 Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute))
  {
    .set instance void TestRef::set_Item(int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute),
                                         int32)
  } // end of property TestRef::Item
  .property instance int32 Item(int64)
  {
    .set instance void TestRef::set_Item(int64,
                                         int32)
  } // end of property TestRef::Item
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,146928,146993);

var 
reference = f_23117_146944_146992(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,147009,147177);

var 
code = @"
public class Test
{
    public static void Main()
    {
        int value = 5;
        var obj = new TestRef();
        obj[value] = 0;
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,147193,147270);

f_23117_147193_147269(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,144616,147281);

Microsoft.CodeAnalysis.MetadataReference
f_23117_146944_146992(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 146944, 146992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_147193_147269(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 147193, 147269);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,144616,147281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,144616,147281);
}
		}

[Fact]
        public void OverloadResolutionShouldBeAbleToPickOverloadsWithNoModreqsOverOnesWithModreq_Indexers_ReturnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,147293,150129);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,147445,149766);

var 
ilSource = IsReadOnlyAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = ( 01 00 04 49 74 65 6D 00 00 )                      // ...Item..
  .field private int32 'value'
  .method public hidebysig newslot specialname virtual
          instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          get_Item(int32 p) cil managed
  {
    .param [0]
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32& V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldflda     int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method TestRef::get_Item

  .method public hidebysig newslot specialname virtual
          instance int32  get_Item(int64 p) cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init (int32 V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      int32 TestRef::'value'
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method TestRef::get_Item

  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.5
    IL_0002:  stfld      int32 TestRef::'value'
    IL_0007:  ldarg.0
    IL_0008:  call       instance void [mscorlib]System.Object::.ctor()
    IL_000d:  nop
    IL_000e:  ret
  } // end of method TestRef::.ctor

  .property instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)
          Item(int32)
  {
    .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = ( 01 00 00 00 )
    .get instance int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute) TestRef::get_Item(int32)
  } // end of property TestRef::Item
  .property instance int32 Item(int64)
  {
    .get instance int32 TestRef::get_Item(int64)
  } // end of property TestRef::Item
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,149782,149847);

var 
reference = f_23117_149798_149846(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,149863,150025);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();
        System.Console.WriteLine(obj[0]);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,150041,150118);

f_23117_150041_150117(this, code, references: new[] { reference }, expectedOutput: "5");
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,147293,150129);

Microsoft.CodeAnalysis.MetadataReference
f_23117_149798_149846(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 149798, 149846);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_150041_150117(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 150041, 150117);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,147293,150129);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,147293,150129);
}
		}

[Fact]
        public void UsingInAttributeFromReferenceWhileHavingDuplicateInCompilation_Class_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,150141,151914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,150272,150499);

var 
testRef = f_23117_150286_150498(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Parent
{
    public virtual ref readonly int M() { throw null; }
}", assemblyName: "testRef")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,150515,150830);

f_23117_150515_150829(this, testRef, symbolValidator: module =>
            {
                var parentModifier = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", parentModifier.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,150846,151217);

var 
userCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Child : Parent
{
    public override ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,151231,151532);

Action<ModuleSymbol> 
validator = module =>
            {
                var childModifier = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", childModifier.ContainingAssembly.Name);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,151548,151718);

f_23117_151548_151717(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_151624_151653(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,151732,151903);

f_23117_151732_151902(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_151808_151838(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,150141,151914);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_150286_150498(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 150286, 150498);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_150515_150829(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 150515, 150829);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_151624_151653(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 151624, 151653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_151548_151717(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 151548, 151717);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_151808_151838(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 151808, 151838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_151732_151902(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 151732, 151902);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,150141,151914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,150141,151914);
}
		}

[Fact]
        public void UsingInAttributeFromReferenceWhileHavingDuplicateInCompilation_Class_Abstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,151926,153695);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,152058,152280);

var 
testRef = f_23117_152072_152279(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public abstract class Parent
{
    public abstract ref readonly int M();
}", assemblyName: "testRef")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,152296,152611);

f_23117_152296_152610(this, testRef, symbolValidator: module =>
            {
                var parentModifier = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", parentModifier.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,152627,152998);

var 
userCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Child : Parent
{
    public override ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,153012,153313);

Action<ModuleSymbol> 
validator = module =>
            {
                var childModifier = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", childModifier.ContainingAssembly.Name);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,153329,153499);

f_23117_153329_153498(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_153405_153434(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,153513,153684);

f_23117_153513_153683(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_153589_153619(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,151926,153695);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_152072_152279(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 152072, 152279);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_152296_152610(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 152296, 152610);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_153405_153434(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 153405, 153434);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_153329_153498(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 153329, 153498);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_153589_153619(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 153589, 153619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_153513_153683(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 153513, 153683);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,151926,153695);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,151926,153695);
}
		}

[Fact]
        public void UsingInAttributeFromReferenceWhileHavingDuplicateInCompilation_ExplicitInterface()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,153707,155498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,153842,154043);

var 
testRef = f_23117_153856_154042(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public interface Parent
{
    ref readonly int M();
}", assemblyName: "testRef")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,154059,154374);

f_23117_154059_154373(this, testRef, symbolValidator: module =>
            {
                var parentModifier = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", parentModifier.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,154390,154752);

var 
userCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Child : Parent
{
    ref readonly int Parent.M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,154766,155116);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var explicitModifier = type.GetMethod("Parent.M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", explicitModifier.ContainingAssembly.Name);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,155132,155302);

f_23117_155132_155301(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_155208_155237(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,155316,155487);

f_23117_155316_155486(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_155392_155422(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,153707,155498);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_153856_154042(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 153856, 154042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_154059_154373(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 154059, 154373);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_155208_155237(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155208, 155237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_155132_155301(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155132, 155301);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_155392_155422(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155392, 155422);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_155316_155486(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155316, 155486);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,153707,155498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,153707,155498);
}
		}

[Fact]
        public void UsingInAttributeFromReferenceWhileHavingDuplicateInCompilation_ImplicitInterface_Virtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,155510,157522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,155653,155854);

var 
testRef = f_23117_155667_155853(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public interface Parent
{
    ref readonly int M();
}", assemblyName: "testRef")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,155870,156185);

f_23117_155870_156184(this, testRef, symbolValidator: module =>
            {
                var parentModifier = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", parentModifier.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,156201,156571);

var 
userCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Child : Parent
{
    public virtual ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,156585,157140);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitModifier = type.GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal(module.ContainingAssembly.Name, implicitModifier.ContainingAssembly.Name);

                var explicitModifier = type.GetMethod("Parent.M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", explicitModifier.ContainingAssembly.Name);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,157156,157326);

f_23117_157156_157325(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_157232_157261(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,157340,157511);

f_23117_157340_157510(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_157416_157446(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,155510,157522);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_155667_155853(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155667, 155853);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_155870_156184(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 155870, 156184);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_157232_157261(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157232, 157261);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_157156_157325(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157156, 157325);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_157416_157446(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157416, 157446);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_157340_157510(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157340, 157510);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,155510,157522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,155510,157522);
}
		}

[Fact]
        public void UsingInAttributeFromReferenceWhileHavingDuplicateInCompilation_ImplicitInterface_NonVirtual()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,157534,159543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,157680,157881);

var 
testRef = f_23117_157694_157880(@"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public interface Parent
{
    ref readonly int M();
}", assemblyName: "testRef")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,157897,158212);

f_23117_157897_158211(this, testRef, symbolValidator: module =>
            {
                var parentModifier = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", parentModifier.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,158228,158590);

var 
userCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}
public class Child : Parent
{
    public ref readonly int M() => ref value;
    private int value = 5;
}
public class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M());
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,158606,159161);

Action<ModuleSymbol> 
validator = module =>
            {
                var type = module.ContainingAssembly.GetTypeByMetadataName("Child");

                var implicitModifier = type.GetMethod("M").RefCustomModifiers.Single().Modifier;
                Assert.Equal(module.ContainingAssembly.Name, implicitModifier.ContainingAssembly.Name);

                var explicitModifier = type.GetMethod("Parent.M").RefCustomModifiers.Single().Modifier;
                Assert.Equal("testRef", explicitModifier.ContainingAssembly.Name);
            }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159177,159347);

f_23117_159177_159346(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_159253_159282(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159361,159532);

f_23117_159361_159531(this, source: userCode, expectedOutput: "5", references: new[] { f_23117_159437_159467(testRef)}, options: TestOptions.ReleaseExe, symbolValidator: validator);
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,157534,159543);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_157694_157880(string
source,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157694, 157880);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_157897_158211(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 157897, 158211);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_23117_159253_159282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.ToMetadataReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159253, 159282);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_159177_159346(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CompilationReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159177, 159346);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_159437_159467(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159437, 159467);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_159361_159531(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( source:(Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159361, 159531);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,157534,159543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,157534,159543);
}
		}

[Fact]
        public void DuplicateInAttributeTypeInReferences()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,159555,160469);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159646,159745);

var 
refCode = @"
namespace System.Runtime.InteropServices
{
    public class InAttribute {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159761,159822);

var 
ref1 = f_23117_159772_159821(f_23117_159772_159798(refCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159836,159897);

var 
ref2 = f_23117_159847_159896(f_23117_159847_159873(refCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,159913,160001);

var 
user = @"
public class Test
{
    public ref readonly int M() => throw null;
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,160017,160458);

f_23117_160017_160457(f_23117_160017_160074(user, references: new[] { ref1, ref2 }), f_23117_160308_160456(f_23117_160308_160436(f_23117_160308_160376(ErrorCode.ERR_PredefinedTypeNotFound, "ref readonly int"), "System.Runtime.InteropServices.InAttribute"), 4, 12));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,159555,160469);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_159772_159798(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159772, 159798);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_159772_159821(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159772, 159821);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_159847_159873(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159847, 159873);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23117_159847_159896(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 159847, 159896);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_160017_160074(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160017, 160074);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_160308_160376(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160308, 160376);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_160308_160436(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160308, 160436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_160308_160456(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160308, 160456);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23117_160017_160457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160017, 160457);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,159555,160469);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,159555,160469);
}
		}

[Fact]
        public void ParentClassOfProxiedInterfaceFunctionHasNoModreq_ImplementedInChild()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,160481,162516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,160603,160778);

var 
code = @"
class Parent
{
    public void M(in int x) { }
}
interface IM
{
    void M(in int x);
}
class Child: Parent, IM
{
    public void M(in int x) { }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,160794,162505);

f_23117_160794_162504(f_23117_160794_162148(this, code, verify: Verification.Passes, symbolValidator: module =>
            {
                // Nothing on Parent
                var parentMethod = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M");
                Assert.False(parentMethod.IsMetadataVirtual());
                Assert.Empty(parentMethod.Parameters.Single().RefCustomModifiers);

                // Nothing on Child
                var childMethod = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M");
                Assert.False(childMethod.IsMetadataVirtual());
                Assert.Empty(childMethod.Parameters.Single().RefCustomModifiers);

                // Modreq on Interface
                var interfaceMethod = module.ContainingAssembly.GetTypeByMetadataName("IM").GetMethod("M");
                Assert.True(interfaceMethod.IsMetadataVirtual());
                AssertSingleInAttributeRequiredModifier(interfaceMethod.Parameters.Single().RefCustomModifiers);

                // Modreq on proxy
                var proxyMethod = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("IM.M");
                Assert.True(proxyMethod.IsMetadataVirtual());
                AssertSingleInAttributeRequiredModifier(proxyMethod.Parameters.Single().RefCustomModifiers);
            }), f_23117_162387_162503(f_23117_162387_162482(f_23117_162387_162429(ErrorCode.WRN_NewRequired, "M"), "Child.M(in int)", "Parent.M(in int)"), 12, 17));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,160481,162516);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_160794_162148(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160794, 162148);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_162387_162429(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 162387, 162429);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_162387_162482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 162387, 162482);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23117_162387_162503(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 162387, 162503);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_160794_162504(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 160794, 162504);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,160481,162516);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,160481,162516);
}
		}

[Fact]
        public void ParentClassOfProxiedInterfaceFunctionHasNoModreq_NotImplementedInChild()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,162528,164059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,162653,162795);

var 
code = @"
class Parent
{
    public void M(in int x) { }
}
interface IM
{
    void M(in int x);
}
class Child: Parent, IM
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,162811,164048);

f_23117_162811_164047(f_23117_162811_164027(this, code, verify: Verification.Passes, symbolValidator: module =>
            {
                // Nothing on Parent
                var parentMethod = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M");
                Assert.False(parentMethod.IsMetadataVirtual());
                Assert.Empty(parentMethod.Parameters.Single().RefCustomModifiers);

                // No method on Child
                Assert.DoesNotContain("M", module.ContainingAssembly.GetTypeByMetadataName("Child").MemberNames);

                // Modreq on Interface
                var interfaceMethod = module.ContainingAssembly.GetTypeByMetadataName("IM").GetMethod("M");
                Assert.True(interfaceMethod.IsMetadataVirtual());
                AssertSingleInAttributeRequiredModifier(interfaceMethod.Parameters.Single().RefCustomModifiers);

                // Modreq on proxy
                var proxyMethod = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("IM.M");
                Assert.True(proxyMethod.IsMetadataVirtual());
                AssertSingleInAttributeRequiredModifier(proxyMethod.Parameters.Single().RefCustomModifiers);
            }));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,162528,164059);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_162811_164027(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.InAttributeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify:verify, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 162811, 164027);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23117_162811_164047(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = this_param.VerifyDiagnostics( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 162811, 164047);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,162528,164059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,162528,164059);
}
		}

private void AssertSingleInAttributeRequiredModifier(ImmutableArray<CustomModifier> modifiers)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23117,164071,164477);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,164190,164224);

var 
modifier = modifiers.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,164238,164342);

var 
typeName = f_23117_164253_164341(WellKnownType.System_Runtime_InteropServices_InAttribute)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,164358,164392);

f_23117_164358_164391(f_23117_164371_164390(modifier));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,164406,164466);

f_23117_164406_164465(typeName, f_23117_164429_164464(f_23117_164429_164446(modifier)));
DynAbs.Tracing.TraceSender.TraceExitMethod(23117,164071,164477);

string
f_23117_164253_164341(Microsoft.CodeAnalysis.WellKnownType
id)
{
var return_v = id.GetMetadataName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 164253, 164341);
return return_v;
}


bool
f_23117_164371_164390(Microsoft.CodeAnalysis.CustomModifier
this_param)
{
var return_v = this_param.IsOptional;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 164371, 164390);
return return_v;
}


int
f_23117_164358_164391(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 164358, 164391);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol
f_23117_164429_164446(Microsoft.CodeAnalysis.CustomModifier
this_param)
{
var return_v = this_param.Modifier;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23117, 164429, 164446);
return return_v;
}


string
f_23117_164429_164464(Microsoft.CodeAnalysis.INamedTypeSymbol
this_param)
{
var return_v = this_param.ToDisplayString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 164429, 164464);
return return_v;
}


int
f_23117_164406_164465(string
expected,string
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23117, 164406, 164465);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23117,164071,164477);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,164071,164477);
}
		}

private const string 
IsReadOnlyAttributeIL = @"
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}
.assembly Test
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78 63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Test.dll
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003
.corflags 0x00000001

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }
}

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.IsReadOnlyAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  }
}
"
;

public InAttributeModifierTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23117,525,166451);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23117,525,166451);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,525,166451);
}


static InAttributeModifierTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23117,525,166451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23117,164510,166443);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23117,525,166451);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23117,525,166451);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23117,525,166451);
}
}
