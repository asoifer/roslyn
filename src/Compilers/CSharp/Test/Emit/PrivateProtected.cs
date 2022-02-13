// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using static Roslyn.Test.Utilities.SigningTestHelpers;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
[CompilerTrait(CompilerFeature.PrivateProtected)]
    public class PrivateProtected : CSharpTestBase
{
private static readonly string s_keyPairFile ;

private static readonly string s_publicKeyFile ;

private static readonly ImmutableArray<byte> s_publicKey ;

[ConditionalFact(typeof(DesktopOnly))]
        public void RejectIncompatibleModifiers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,969,2664);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,1083,1377);

string 
source =
@"public class Base
{
    private internal int Field1;
    internal private int Field2;
    private internal protected int Field3;
    internal protected private int Field4;
    private public protected int Field5;
    private readonly protected int Field6; // ok
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,1391,2653);

f_23142_1391_2652(f_23142_1391_1454(source, parseOptions: TestOptions.Regular7_2), f_23142_1638_1713(f_23142_1638_1693(ErrorCode.ERR_BadMemberProtection, "Field1"), 3, 26), f_23142_1861_1936(f_23142_1861_1916(ErrorCode.ERR_BadMemberProtection, "Field2"), 4, 26), f_23142_2094_2169(f_23142_2094_2149(ErrorCode.ERR_BadMemberProtection, "Field3"), 5, 36), f_23142_2327_2402(f_23142_2327_2382(ErrorCode.ERR_BadMemberProtection, "Field4"), 6, 36), f_23142_2558_2633(f_23142_2558_2613(ErrorCode.ERR_BadMemberProtection, "Field5"), 7, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,969,2664);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_1391_1454(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1391, 1454);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_1638_1693(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1638, 1693);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_1638_1713(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1638, 1713);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_1861_1916(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1861, 1916);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_1861_1936(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1861, 1936);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2094_2149(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2094, 2149);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2094_2169(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2094, 2169);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2327_2382(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2327, 2382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2327_2402(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2327, 2402);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2558_2613(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2558, 2613);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_2558_2633(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 2558, 2633);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_1391_2652(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 1391, 2652);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,969,2664);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,969,2664);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void AccessibleWhereRequired_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,2676,3175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,2789,3012);

string 
source =
@"public class Base
{
    private protected int Field1;
    protected private int Field2;
}

public class Derived : Base
{
    void M()
    {
        Field1 = 1;
        Field2 = 2;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,3026,3164);

var 
compilation = f_23142_3044_3163(f_23142_3044_3107(source, parseOptions: TestOptions.Regular7_2))
;
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,2676,3175);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_3044_3107(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 3044, 3107);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_3044_3163(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 3044, 3163);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,2676,3175);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,2676,3175);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void AccessibleWhereRequired_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,3187,14750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,3300,3959);

string 
source1 =
@"[assembly: System.Runtime.CompilerServices.InternalsVisibleTo(""WantsIVTAccess"")]
public class Base
{
    private protected const int Constant = 3;
    private protected int Field1;
    protected private int Field2;
    private protected void Method() { }
    private protected event System.Action Event1;
    private protected int Property1 { set {} }
    public int Property2 { private protected set {} get { return 4; } }
    private protected int this[int x] { set { } get { return 6; } }
    public int this[string x] { private protected set { } get { return 5; } }
    private protected Base() { Event1?.Invoke(); }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,3973,4156);

var 
baseCompilation = f_23142_3995_4155(source1, parseOptions: TestOptions.Regular7_2, options: TestOptions.SigningReleaseDll, assemblyName: "Paul")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,4170,4246);

var 
bb = (NamedTypeSymbol)f_23142_4196_4245(f_23142_4196_4227(baseCompilation), "Base")
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,4260,4760);
foreach(var member in f_23142_4283_4298_I(f_23142_4283_4298(bb)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(23142,4260,4760);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,4332,4745);

switch (f_23142_4340_4351(member))
                {

case "Property2":
                    case "get_Property2":
                    case "this[]":
                    case "get_Item":
DynAbs.Tracing.TraceSender.TraceEnterCondition(23142,4332,4745);
DynAbs.Tracing.TraceSender.TraceBreak(23142,4553,4559);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(23142,4332,4745);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(23142,4332,4745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,4615,4694);

f_23142_4615_4693(Accessibility.ProtectedAndInternal, f_23142_4664_4692(member));
DynAbs.Tracing.TraceSender.TraceBreak(23142,4720,4726);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(23142,4332,4745);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(23142,4260,4760);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(23142,1,501);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(23142,1,501);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,4776,5153);

string 
source2 =
@"public class Derived : Base
{
    void M()
    {
        Field1 = Constant;
        Field2 = Constant;
        Method();
        Event1 += null;
        Property1 = Constant;
        Property2 = Constant;
        this[1] = 2;
        this[string.Empty] = 4;
    }
    Derived(int x) : base() {}
    Derived(long x) {} // implicit base()
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,5167,9599);

f_23142_5167_9598(f_23142_5167_5436(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_5269_5316(baseCompilation)}, assemblyName: "WantsIVTAccessButCantHave", options: TestOptions.SigningReleaseDll), f_23142_5633_5726(f_23142_5633_5707(f_23142_5633_5678(ErrorCode.ERR_BadAccess, "Field1"), "Base.Field1"), 5, 9), f_23142_5894_5992(f_23142_5894_5972(f_23142_5894_5941(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 5, 18), f_23142_6157_6250(f_23142_6157_6231(f_23142_6157_6202(ErrorCode.ERR_BadAccess, "Field2"), "Base.Field2"), 6, 9), f_23142_6418_6516(f_23142_6418_6496(f_23142_6418_6465(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 6, 18), f_23142_6674_6769(f_23142_6674_6750(f_23142_6674_6719(ErrorCode.ERR_BadAccess, "Method"), "Base.Method()"), 7, 9), f_23142_6931_7024(f_23142_6931_7005(f_23142_6931_6976(ErrorCode.ERR_BadAccess, "Event1"), "Base.Event1"), 8, 9), f_23142_7190_7295(f_23142_7190_7276(f_23142_7190_7243(ErrorCode.ERR_BadAccess, "Event1 += null"), "Base.Event1.add"), 8, 9), f_23142_7466_7565(f_23142_7466_7546(f_23142_7466_7514(ErrorCode.ERR_BadAccess, "Property1"), "Base.Property1"), 9, 9), f_23142_7736_7834(f_23142_7736_7814(f_23142_7736_7783(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 9, 21), f_23142_8058_8167(f_23142_8058_8147(f_23142_8058_8115(ErrorCode.ERR_InaccessibleSetter, "Property2"), "Base.Property2"), 10, 9), f_23142_8339_8438(f_23142_8339_8417(f_23142_8339_8386(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 10, 21), f_23142_8591_8689(f_23142_8591_8668(f_23142_8591_8632(ErrorCode.ERR_BadArgType, "1"), "1", "int", "string"), 11, 14), f_23142_8918_9039(f_23142_8918_9019(f_23142_8918_8984(ErrorCode.ERR_InaccessibleSetter, "this[string.Empty]"), "Base.this[string]"), 12, 9), f_23142_9210_9303(f_23142_9210_9282(f_23142_9210_9253(ErrorCode.ERR_BadAccess, "base"), "Base.Base()"), 14, 22), f_23142_9484_9579(f_23142_9484_9559(f_23142_9484_9530(ErrorCode.ERR_BadAccess, "Derived"), "Base.Base()"), 15, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,9613,14062);

f_23142_9613_14061(f_23142_9613_9899(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_9715_9779(f_23142_9749_9778(baseCompilation))}, assemblyName: "WantsIVTAccessButCantHave", options: TestOptions.SigningReleaseDll), f_23142_10096_10189(f_23142_10096_10170(f_23142_10096_10141(ErrorCode.ERR_BadAccess, "Field1"), "Base.Field1"), 5, 9), f_23142_10357_10455(f_23142_10357_10435(f_23142_10357_10404(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 5, 18), f_23142_10620_10713(f_23142_10620_10694(f_23142_10620_10665(ErrorCode.ERR_BadAccess, "Field2"), "Base.Field2"), 6, 9), f_23142_10881_10979(f_23142_10881_10959(f_23142_10881_10928(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 6, 18), f_23142_11137_11232(f_23142_11137_11213(f_23142_11137_11182(ErrorCode.ERR_BadAccess, "Method"), "Base.Method()"), 7, 9), f_23142_11394_11487(f_23142_11394_11468(f_23142_11394_11439(ErrorCode.ERR_BadAccess, "Event1"), "Base.Event1"), 8, 9), f_23142_11653_11758(f_23142_11653_11739(f_23142_11653_11706(ErrorCode.ERR_BadAccess, "Event1 += null"), "Base.Event1.add"), 8, 9), f_23142_11929_12028(f_23142_11929_12009(f_23142_11929_11977(ErrorCode.ERR_BadAccess, "Property1"), "Base.Property1"), 9, 9), f_23142_12199_12297(f_23142_12199_12277(f_23142_12199_12246(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 9, 21), f_23142_12521_12630(f_23142_12521_12610(f_23142_12521_12578(ErrorCode.ERR_InaccessibleSetter, "Property2"), "Base.Property2"), 10, 9), f_23142_12802_12901(f_23142_12802_12880(f_23142_12802_12849(ErrorCode.ERR_BadAccess, "Constant"), "Base.Constant"), 10, 21), f_23142_13054_13152(f_23142_13054_13131(f_23142_13054_13095(ErrorCode.ERR_BadArgType, "1"), "1", "int", "string"), 11, 14), f_23142_13381_13502(f_23142_13381_13482(f_23142_13381_13447(ErrorCode.ERR_InaccessibleSetter, "this[string.Empty]"), "Base.this[string]"), 12, 9), f_23142_13673_13766(f_23142_13673_13745(f_23142_13673_13716(ErrorCode.ERR_BadAccess, "base"), "Base.Base()"), 14, 22), f_23142_13947_14042(f_23142_13947_14022(f_23142_13947_13993(ErrorCode.ERR_BadAccess, "Derived"), "Base.Base()"), 15, 5));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,14078,14393);

f_23142_14078_14392(f_23142_14078_14336(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_14180_14227(baseCompilation)}, assemblyName: "WantsIVTAccess", options: TestOptions.SigningReleaseDll));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,14407,14739);

f_23142_14407_14738(f_23142_14407_14682(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_14509_14573(f_23142_14543_14572(baseCompilation))}, assemblyName: "WantsIVTAccess", options: TestOptions.SigningReleaseDll));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,3187,14750);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_3995_4155(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,string
assemblyName)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, options:options, assemblyName:assemblyName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 3995, 4155);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
f_23142_4196_4227(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.GlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23142, 4196, 4227);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_23142_4196_4245(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
container,string
qualifiedName)
{
var return_v = container.GetMember( qualifiedName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 4196, 4245);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23142_4283_4298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.GetMembers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 4283, 4298);
return return_v;
}


string
f_23142_4340_4351(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23142, 4340, 4351);
return return_v;
}


Microsoft.CodeAnalysis.Accessibility
f_23142_4664_4692(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.DeclaredAccessibility;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23142, 4664, 4692);
return return_v;
}


int
f_23142_4615_4693(Microsoft.CodeAnalysis.Accessibility
expected,Microsoft.CodeAnalysis.Accessibility
actual)
{
Assert.Equal( expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 4615, 4693);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
f_23142_4283_4298_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 4283, 4298);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23142_5269_5316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5269, 5316);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_5167_5436(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5167, 5436);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5633_5678(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5633, 5678);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5633_5707(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5633, 5707);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5633_5726(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5633, 5726);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5894_5941(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5894, 5941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5894_5972(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5894, 5972);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_5894_5992(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5894, 5992);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6157_6202(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6157, 6202);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6157_6231(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6157, 6231);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6157_6250(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6157, 6250);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6418_6465(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6418, 6465);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6418_6496(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6418, 6496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6418_6516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6418, 6516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6674_6719(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6674, 6719);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6674_6750(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6674, 6750);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6674_6769(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6674, 6769);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6931_6976(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6931, 6976);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6931_7005(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6931, 7005);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_6931_7024(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 6931, 7024);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7190_7243(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7190, 7243);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7190_7276(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7190, 7276);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7190_7295(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7190, 7295);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7466_7514(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7466, 7514);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7466_7546(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7466, 7546);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7466_7565(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7466, 7565);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7736_7783(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7736, 7783);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7736_7814(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7736, 7814);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_7736_7834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 7736, 7834);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8058_8115(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8058, 8115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8058_8147(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8058, 8147);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8058_8167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8058, 8167);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8339_8386(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8339, 8386);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8339_8417(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8339, 8417);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8339_8438(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8339, 8438);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8591_8632(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8591, 8632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8591_8668(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8591, 8668);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8591_8689(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8591, 8689);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8918_8984(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8918, 8984);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8918_9019(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8918, 9019);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_8918_9039(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 8918, 9039);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9210_9253(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9210, 9253);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9210_9282(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9210, 9282);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9210_9303(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9210, 9303);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9484_9530(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9484, 9530);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9484_9559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9484, 9559);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_9484_9579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9484, 9579);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_5167_9598(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 5167, 9598);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23142_9749_9778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9749, 9778);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23142_9715_9779(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = MetadataReference.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9715, 9779);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_9613_9899(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9613, 9899);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10096_10141(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10096, 10141);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10096_10170(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10096, 10170);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10096_10189(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10096, 10189);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10357_10404(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10357, 10404);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10357_10435(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10357, 10435);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10357_10455(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10357, 10455);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10620_10665(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10620, 10665);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10620_10694(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10620, 10694);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10620_10713(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10620, 10713);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10881_10928(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10881, 10928);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10881_10959(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10881, 10959);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_10881_10979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 10881, 10979);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11137_11182(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11137, 11182);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11137_11213(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11137, 11213);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11137_11232(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11137, 11232);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11394_11439(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11394, 11439);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11394_11468(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11394, 11468);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11394_11487(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11394, 11487);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11653_11706(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11653, 11706);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11653_11739(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11653, 11739);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11653_11758(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11653, 11758);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11929_11977(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11929, 11977);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11929_12009(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11929, 12009);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_11929_12028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 11929, 12028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12199_12246(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12199, 12246);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12199_12277(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12199, 12277);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12199_12297(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12199, 12297);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12521_12578(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12521, 12578);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12521_12610(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12521, 12610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12521_12630(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12521, 12630);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12802_12849(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12802, 12849);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12802_12880(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12802, 12880);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_12802_12901(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 12802, 12901);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13054_13095(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13054, 13095);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13054_13131(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13054, 13131);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13054_13152(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13054, 13152);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13381_13447(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13381, 13447);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13381_13482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13381, 13482);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13381_13502(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13381, 13502);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13673_13716(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13673, 13716);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13673_13745(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13673, 13745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13673_13766(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13673, 13766);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13947_13993(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13947, 13993);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13947_14022(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13947, 14022);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_13947_14042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 13947, 14042);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_9613_14061(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 9613, 14061);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23142_14180_14227(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14180, 14227);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_14078_14336(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14078, 14336);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_14078_14392(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14078, 14392);
return return_v;
}


System.Collections.Immutable.ImmutableArray<byte>
f_23142_14543_14572(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = compilation.EmitToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14543, 14572);
return return_v;
}


Microsoft.CodeAnalysis.PortableExecutableReference
f_23142_14509_14573(System.Collections.Immutable.ImmutableArray<byte>
peImage)
{
var return_v = MetadataReference.CreateFromImage( peImage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14509, 14573);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_14407_14682(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.PortableExecutableReference[]
references,string
assemblyName,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName:assemblyName, options:options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14407, 14682);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_14407_14738(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 14407, 14738);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,3187,14750);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,3187,14750);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void NotAccessibleWhereRequired()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,14762,15787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,14875,15129);

string 
source =
@"public class Base
{
    private protected int Field1;
    protected private int Field2;
}

public class Derived // : Base
{
    void M()
    {
        Base b = null;
        b.Field1 = 1;
        b.Field2 = 2;
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,15143,15776);

f_23142_15143_15775(f_23142_15143_15206(source, parseOptions: TestOptions.Regular7_2), f_23142_15404_15499(f_23142_15404_15478(f_23142_15404_15449(ErrorCode.ERR_BadAccess, "Field1"), "Base.Field1"), 12, 11), f_23142_15661_15756(f_23142_15661_15735(f_23142_15661_15706(ErrorCode.ERR_BadAccess, "Field2"), "Base.Field2"), 13, 11));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,14762,15787);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_15143_15206(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15143, 15206);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15404_15449(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15404, 15449);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15404_15478(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15404, 15478);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15404_15499(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15404, 15499);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15661_15706(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15661, 15706);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15661_15735(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15661, 15735);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_15661_15756(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15661, 15756);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_15143_15775(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 15143, 15775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,14762,15787);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,14762,15787);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void NotInStructOrNamespace()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,15799,16736);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,15908,16003);

string 
source =
@"protected private struct Struct
{
    private protected int Field1;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,16017,16725);

f_23142_16017_16724(f_23142_16017_16080(source, parseOptions: TestOptions.Regular7_2), f_23142_16355_16429(f_23142_16355_16409(ErrorCode.ERR_NoNamespacePrivate, "Struct"), 1, 26), f_23142_16601_16705(f_23142_16601_16685(f_23142_16601_16654(ErrorCode.ERR_ProtectedInStruct, "Field1"), "Struct.Field1"), 3, 27));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,15799,16736);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_16017_16080(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16017, 16080);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_16355_16409(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16355, 16409);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_16355_16429(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16355, 16429);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_16601_16654(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16601, 16654);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_16601_16685(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16601, 16685);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_16601_16705(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16601, 16705);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_16017_16724(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 16017, 16724);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,15799,16736);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,15799,16736);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void NotInStaticClass()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,16748,17721);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,16851,17008);

string 
source =
@"static class C
{
    static private protected int Field1 = 2;
}
sealed class D
{
    static private protected int Field2 = 2;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,17022,17710);

f_23142_17022_17709(f_23142_17022_17085(source, parseOptions: TestOptions.Regular7_2), f_23142_17306_17405(f_23142_17306_17385(f_23142_17306_17359(ErrorCode.WRN_ProtectedInSealed, "Field2"), "D.Field2"), 7, 34), f_23142_17591_17690(f_23142_17591_17670(f_23142_17591_17644(ErrorCode.ERR_ProtectedInStatic, "Field1"), "C.Field1"), 3, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,16748,17721);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_17022_17085(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17022, 17085);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17306_17359(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17306, 17359);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17306_17385(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17306, 17385);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17306_17405(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17306, 17405);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17591_17644(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17591, 17644);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17591_17670(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17591, 17670);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_17591_17690(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17591, 17690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_17022_17709(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 17022, 17709);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,16748,17721);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,16748,17721);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void NestedTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,17733,19277);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,17831,18254);

string 
source =
@"class Outer
{
    private protected class Inner
    {
    }
}
class Derived : Outer
{
    public void M()
    {
        Outer.Inner x = null;
    }
}
class NotDerived
{
    public void M()
    {
        Outer.Inner x = null; // error: Outer.Inner not accessible
    }
}
struct Struct
{
    private protected class Inner // error: protected not allowed in struct
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,18268,19266);

f_23142_18268_19265(f_23142_18268_18331(source, parseOptions: TestOptions.Regular7_2), f_23142_18581_18684(f_23142_18581_18663(f_23142_18581_18633(ErrorCode.ERR_ProtectedInStruct, "Inner"), "Struct.Inner"), 23, 29), f_23142_18855_18945(f_23142_18855_18924(f_23142_18855_18905(ErrorCode.WRN_UnreferencedVarAssg, "x"), "x"), 11, 21), f_23142_19152_19246(f_23142_19152_19225(f_23142_19152_19196(ErrorCode.ERR_BadAccess, "Inner"), "Outer.Inner"), 18, 15));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,17733,19277);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_18268_18331(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18268, 18331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18581_18633(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18581, 18633);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18581_18663(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18581, 18663);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18581_18684(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18581, 18684);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18855_18905(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18855, 18905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18855_18924(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18855, 18924);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_18855_18945(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18855, 18945);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_19152_19196(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 19152, 19196);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_19152_19225(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 19152, 19225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_19152_19246(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 19152, 19246);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_18268_19265(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 18268, 19265);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,17733,19277);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,17733,19277);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void PermittedAccessorProtection()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,19289,19874);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,19403,19729);

string 
source =
@"class Class
{
    public int Prop1 { get; private protected set; }
    protected internal int Prop2 { get; private protected set; }
    protected int Prop3 { get; private protected set; }
    internal int Prop4 { get; private protected set; }
    private protected int Prop5 { get; private set; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,19743,19863);

f_23142_19743_19862(f_23142_19743_19806(source, parseOptions: TestOptions.Regular7_2));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,19289,19874);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_19743_19806(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 19743, 19806);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_19743_19862(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 19743, 19862);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,19289,19874);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,19289,19874);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void ForbiddenAccessorProtection_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,19886,21093);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,20003,20161);

string 
source =
@"class Class
{
    private protected int Prop1 { get; private protected set; }
    private int Prop2 { get; private protected set; }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,20175,21082);

f_23142_20175_21081(f_23142_20175_20238(source, parseOptions: TestOptions.Regular7_2), f_23142_20548_20673(f_23142_20548_20653(f_23142_20548_20605(ErrorCode.ERR_InvalidPropertyAccessMod, "set"), "Class.Prop1.set", "Class.Prop1"), 3, 58), f_23142_20937_21062(f_23142_20937_21042(f_23142_20937_20994(ErrorCode.ERR_InvalidPropertyAccessMod, "set"), "Class.Prop2.set", "Class.Prop2"), 4, 48));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,19886,21093);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_20175_20238(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20175, 20238);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20548_20605(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20548, 20605);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20548_20653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20548, 20653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20548_20673(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20548, 20673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20937_20994(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20937, 20994);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20937_21042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20937, 21042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_20937_21062(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20937, 21062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_20175_21081(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 20175, 21081);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,19886,21093);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,19886,21093);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void ForbiddenAccessorProtection_02()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,21105,22162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,21222,21301);

string 
source =
@"interface ISomething
{
    private protected int M();
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,21315,22151);

f_23142_21315_22150(f_23142_21315_21378(source, parseOptions: TestOptions.Regular7_2), f_23142_21643_21781(f_23142_21643_21761(f_23142_21643_21712(ErrorCode.ERR_DefaultInterfaceImplementationModifier, "M"), "private protected", "7.2", "8.0"), 3, 27), f_23142_22026_22131(f_23142_22026_22111(ErrorCode.ERR_RuntimeDoesNotSupportProtectedAccessForInterfaceMember, "M"), 3, 27));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,21105,22162);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_21315_21378(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 21315, 21378);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_21643_21712(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 21643, 21712);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_21643_21761(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 21643, 21761);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_21643_21781(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 21643, 21781);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_22026_22111(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 22026, 22111);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_22026_22131(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 22026, 22131);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_21315_22150(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 21315, 22150);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,21105,22162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,21105,22162);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void AtLeastAsRestrictivePositive_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,22174,22961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,22292,22816);

string 
source =
@"
public class C
{
    internal class Internal {}
    protected class Protected {}
    private protected class PrivateProtected {}
    private protected void M(Internal x) {} // ok
    private protected void M(Protected x) {} // ok
    private protected void M(PrivateProtected x) {} // ok
    private protected class Nested
    {
        public void M(Internal x) {} // ok
        public void M(Protected x) {} // ok
        private protected void M(PrivateProtected x) {} // ok
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,22830,22950);

f_23142_22830_22949(f_23142_22830_22893(source, parseOptions: TestOptions.Regular7_2));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,22174,22961);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_22830_22893(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 22830, 22893);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_22830_22949(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 22830, 22949);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,22174,22961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,22174,22961);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void AtLeastAsRestrictiveNegative_01()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,22973,24397);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,23091,23342);

string 
source =
@"
public class Container
{
    private protected class PrivateProtected {}
    internal void M1(PrivateProtected x) {} // error: conflicting access
    protected void M2(PrivateProtected x) {} // error: conflicting access
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,23356,24386);

f_23142_23356_24385(f_23142_23356_23419(source, parseOptions: TestOptions.Regular7_2), f_23142_23756_23911(f_23142_23756_23891(f_23142_23756_23803(ErrorCode.ERR_BadVisParamType, "M2"), "Container.M2(Container.PrivateProtected)", "Container.PrivateProtected"), 6, 20), f_23142_24211_24366(f_23142_24211_24346(f_23142_24211_24258(ErrorCode.ERR_BadVisParamType, "M1"), "Container.M1(Container.PrivateProtected)", "Container.PrivateProtected"), 5, 19));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,22973,24397);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_23356_23419(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 23356, 23419);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_23756_23803(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 23756, 23803);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_23756_23891(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 23756, 23891);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_23756_23911(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 23756, 23911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_24211_24258(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 24211, 24258);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_24211_24346(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 24211, 24346);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_24211_24366(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 24211, 24366);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_23356_24385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 23356, 24385);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,22973,24397);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,22973,24397);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void DuplicateAccessInBinder()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,24409,27796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,24519,25170);

string 
source =
@"
public class Container
{
    private public int Field;                           // 1
    private public int Property { get; set; }           // 2
    private public int M() => 1;                        // 3
    private public class C {}                           // 4
    private public struct S {}                          // 5
    private public enum E {}                            // 6
    private public event System.Action V;               // 7
    private public interface I {}                       // 8
    private public int this[int index] => 1;            // 9
    void Q() { V.Invoke(); V = null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,25184,27785);

f_23142_25184_27784(f_23142_25184_25247(source, parseOptions: TestOptions.Regular7_2), f_23142_25459_25529(f_23142_25459_25509(ErrorCode.ERR_BadMemberProtection, "C"), 7, 26), f_23142_25705_25775(f_23142_25705_25755(ErrorCode.ERR_BadMemberProtection, "S"), 8, 27), f_23142_25951_26021(f_23142_25951_26001(ErrorCode.ERR_BadMemberProtection, "E"), 9, 25), f_23142_26198_26269(f_23142_26198_26248(ErrorCode.ERR_BadMemberProtection, "I"), 11, 30), f_23142_26445_26519(f_23142_26445_26499(ErrorCode.ERR_BadMemberProtection, "Field"), 4, 24), f_23142_26695_26772(f_23142_26695_26752(ErrorCode.ERR_BadMemberProtection, "Property"), 5, 24), f_23142_26948_27018(f_23142_26948_26998(ErrorCode.ERR_BadMemberProtection, "M"), 6, 24), f_23142_27195_27266(f_23142_27195_27245(ErrorCode.ERR_BadMemberProtection, "V"), 10, 40), f_23142_27443_27517(f_23142_27443_27496(ErrorCode.ERR_BadMemberProtection, "this"), 12, 24), f_23142_27694_27765(f_23142_27694_27744(ErrorCode.ERR_BadMemberProtection, "1"), 12, 43));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,24409,27796);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_25184_25247(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25184, 25247);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25459_25509(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25459, 25509);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25459_25529(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25459, 25529);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25705_25755(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25705, 25755);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25705_25775(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25705, 25775);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25951_26001(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25951, 26001);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_25951_26021(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25951, 26021);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26198_26248(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26198, 26248);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26198_26269(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26198, 26269);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26445_26499(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26445, 26499);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26445_26519(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26445, 26519);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26695_26752(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26695, 26752);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26695_26772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26695, 26772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26948_26998(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26948, 26998);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_26948_27018(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 26948, 27018);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27195_27245(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27195, 27245);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27195_27266(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27195, 27266);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27443_27496(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27443, 27496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27443_27517(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27443, 27517);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27694_27744(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27694, 27744);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_27694_27765(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 27694, 27765);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_25184_27784(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 25184, 27784);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,24409,27796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,24409,27796);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void NotInVersion71()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,27808,32206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,27909,28587);

string 
source =
@"
public class Container
{
    private protected int Field;                           // 1
    private protected int Property { get; set; }           // 2
    private protected int M() => 1;                        // 3
    private protected class C {}                           // 4
    private protected struct S {}                          // 5
    private protected enum E {}                            // 6
    private protected event System.Action V;               // 7
    private protected interface I {}                       // 8
    private protected int this[int index] => 1;            // 9
    void Q() { V.Invoke(); V = null; }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,28601,32061);

f_23142_28601_32060(f_23142_28601_28664(source, parseOptions: TestOptions.Regular7_1), f_23142_28945_29069(f_23142_28945_29049(f_23142_28945_29007(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "C"), "private protected", "7.2"), 7, 29), f_23142_29314_29438(f_23142_29314_29418(f_23142_29314_29376(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "S"), "private protected", "7.2"), 8, 30), f_23142_29683_29807(f_23142_29683_29787(f_23142_29683_29745(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "E"), "private protected", "7.2"), 9, 28), f_23142_30053_30178(f_23142_30053_30157(f_23142_30053_30115(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "I"), "private protected", "7.2"), 11, 33), f_23142_30423_30551(f_23142_30423_30531(f_23142_30423_30489(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "Field"), "private protected", "7.2"), 4, 27), f_23142_30796_30927(f_23142_30796_30907(f_23142_30796_30865(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "Property"), "private protected", "7.2"), 5, 27), f_23142_31172_31296(f_23142_31172_31276(f_23142_31172_31234(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "M"), "private protected", "7.2"), 6, 27), f_23142_31542_31667(f_23142_31542_31646(f_23142_31542_31604(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "V"), "private protected", "7.2"), 10, 43), f_23142_31913_32041(f_23142_31913_32020(f_23142_31913_31978(ErrorCode.ERR_FeatureNotAvailableInVersion7_1, "this"), "private protected", "7.2"), 12, 27));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,32075,32195);

f_23142_32075_32194(f_23142_32075_32138(source, parseOptions: TestOptions.Regular7_2));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,27808,32206);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_28601_28664(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 28601, 28664);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_28945_29007(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 28945, 29007);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_28945_29049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 28945, 29049);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_28945_29069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 28945, 29069);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29314_29376(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29314, 29376);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29314_29418(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29314, 29418);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29314_29438(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29314, 29438);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29683_29745(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29683, 29745);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29683_29787(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29683, 29787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_29683_29807(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 29683, 29807);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30053_30115(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30053, 30115);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30053_30157(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30053, 30157);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30053_30178(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30053, 30178);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30423_30489(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30423, 30489);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30423_30531(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30423, 30531);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30423_30551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30423, 30551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30796_30865(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30796, 30865);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30796_30907(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30796, 30907);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_30796_30927(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 30796, 30927);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31172_31234(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31172, 31234);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31172_31276(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31172, 31276);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31172_31296(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31172, 31296);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31542_31604(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31542, 31604);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31542_31646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31542, 31646);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31542_31667(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31542, 31667);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31913_31978(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31913, 31978);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31913_32020(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31913, 32020);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_31913_32041(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 31913, 32041);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_28601_32060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 28601, 32060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_32075_32138(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 32075, 32138);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_32075_32194(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 32075, 32194);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,27808,32206);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,27808,32206);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void VerifyPrivateProtectedIL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,32218,32862);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,32329,32432);

var 
text = @"
class Program
{
    private protected void M() {}
    private protected int F;
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,32446,32851);

var 
verifier = f_23142_32461_32850(this, text, parseOptions: TestOptions.Regular7_2, expectedSignatures: new[]
                {
f_23142_32640_32735("Program", "M", ".method famandassem hidebysig instance System.Void M() cil managed"),
f_23142_32758_32829("Program", "F", ".field famandassem instance System.Int32 F"),
                })
;
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,32218,32862);

Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription
f_23142_32640_32735(string
fullyQualifiedTypeName,string
memberName,string
expectedSignature)
{
var return_v = Signature( fullyQualifiedTypeName, memberName, expectedSignature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 32640, 32735);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription
f_23142_32758_32829(string
fullyQualifiedTypeName,string
memberName,string
expectedSignature)
{
var return_v = Signature( fullyQualifiedTypeName, memberName, expectedSignature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 32758, 32829);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23142_32461_32850(Microsoft.CodeAnalysis.CSharp.UnitTests.PrivateProtected
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.Test.Utilities.SignatureDescription[]
expectedSignatures)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, expectedSignatures:expectedSignatures);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 32461, 32850);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,32218,32862);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,32218,32862);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void VerifyPartialPartsMatch()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,32874,33838);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,32984,33111);

var 
source =
@"class Outer
{
    private protected partial class Inner {}
    private           partial class Inner {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,33125,33556);

f_23142_33125_33555(f_23142_33125_33188(source, parseOptions: TestOptions.Regular7_2), f_23142_33429_33536(f_23142_33429_33516(f_23142_33429_33487(ErrorCode.ERR_PartialModifierConflict, "Inner"), "Outer.Inner"), 3, 37));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,33570,33693);

source =
@"class Outer
{
    private protected partial class Inner {}
    private protected partial class Inner {}
}";
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,33707,33827);

f_23142_33707_33826(f_23142_33707_33770(source, parseOptions: TestOptions.Regular7_2));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,32874,33838);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_33125_33188(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33125, 33188);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_33429_33487(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33429, 33487);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_33429_33516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33429, 33516);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_33429_33536(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33429, 33536);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_33125_33555(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33125, 33555);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_33707_33770(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33707, 33770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_33707_33826(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 33707, 33826);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,32874,33838);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,32874,33838);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void VerifyProtectedSemantics()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,33850,35250);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,33961,34383);

var 
source =
@"class Base
{
    private protected void M()
    {
        System.Console.WriteLine(this.GetType().Name);
    }
}

class Derived : Base
{
    public void Main()
    {
        Derived derived = new Derived();
        derived.M();
        Base bb = new Base();
        bb.M(); // error 1
        Other other = new Other();
        other.M(); // error 2
    }
}

class Other : Base
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,34397,35239);

f_23142_34397_35238(f_23142_34397_34460(source, parseOptions: TestOptions.Regular7_2), f_23142_34740_34855(f_23142_34740_34834(f_23142_34740_34789(ErrorCode.ERR_BadProtectedAccess, "M"), "Base.M()", "Base", "Derived"), 16, 12), f_23142_35103_35219(f_23142_35103_35198(f_23142_35103_35152(ErrorCode.ERR_BadProtectedAccess, "M"), "Base.M()", "Other", "Derived"), 18, 15));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,33850,35250);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_34397_34460(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 34397, 34460);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_34740_34789(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 34740, 34789);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_34740_34834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 34740, 34834);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_34740_34855(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 34740, 34855);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_35103_35152(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35103, 35152);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_35103_35198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35103, 35198);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_35103_35219(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35103, 35219);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_34397_35238(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 34397, 35238);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,33850,35250);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,33850,35250);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void HidingAbstract()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,35262,35662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,35363,35517);

var 
source =
@"abstract class A
{
    internal abstract void F();
}
abstract class B : A
{
    private protected new void F() { } // No CS0533
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,35531,35651);

f_23142_35531_35650(f_23142_35531_35594(source, parseOptions: TestOptions.Regular7_2));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,35262,35662);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_35531_35594(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35531, 35594);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_35531_35650(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35531, 35650);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,35262,35662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,35262,35662);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void HidingInaccessible()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,35674,36609);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,35779,35859);

string 
source1 =
@"public class A
{
    private protected void F() { }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,35873,35957);

var 
compilation1 = f_23142_35892_35956(source1, parseOptions: TestOptions.Regular7_2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,35971,36004);

f_23142_35971_36003(            compilation1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36020,36093);

string 
source2 =
@"class B : A
{
    new void F() { } // CS0109
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36107,36598);

f_23142_36107_36597(f_23142_36107_36256(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_36209_36253(compilation1)}), f_23142_36490_36578(f_23142_36490_36558(f_23142_36490_36535(ErrorCode.WRN_NewNotRequired, "F"), "B.F()"), 3, 14));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,35674,36609);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_35892_35956(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35892, 35956);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_35971_36003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 35971, 36003);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23142_36209_36253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36209, 36253);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_36107_36256(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36107, 36256);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_36490_36535(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36490, 36535);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_36490_36558(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36490, 36558);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_36490_36578(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36490, 36578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_36107_36597(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36107, 36597);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,35674,36609);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,35674,36609);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void UnimplementedInaccessible()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,36621,37530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36733,36828);

string 
source1 =
@"public abstract class A
{
    private protected abstract void F();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36842,36926);

var 
compilation1 = f_23142_36861_36925(source1, parseOptions: TestOptions.Regular7_2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36940,36973);

f_23142_36940_36972(            compilation1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,36989,37040);

string 
source2 =
@"class B : A // CS0534
{
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,37054,37519);

f_23142_37054_37518(f_23142_37054_37203(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_37156_37200(compilation1)}), f_23142_37394_37499(f_23142_37394_37480(f_23142_37394_37452(ErrorCode.ERR_UnimplementedAbstractMethod, "B"), "B", "A.F()"), 1, 7));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,36621,37530);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_36861_36925(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36861, 36925);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_36940_36972(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 36940, 36972);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23142_37156_37200(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37156, 37200);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_37054_37203(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37054, 37203);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_37394_37452(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37394, 37452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_37394_37480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37394, 37480);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_37394_37499(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37394, 37499);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_37054_37518(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37054, 37518);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,36621,37530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,36621,37530);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void ImplementInaccessible()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,37542,38754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,37650,37745);

string 
source1 =
@"public abstract class A
{
    private protected abstract void F();
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,37759,37843);

var 
compilation1 = f_23142_37778_37842(source1, parseOptions: TestOptions.Regular7_2)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,37857,37890);

f_23142_37857_37889(            compilation1);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,37906,38001);

string 
source2 =
@"class B : A // CS0534
{
    override private protected void F() {}
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,38015,38743);

f_23142_38015_38742(f_23142_38015_38164(source2, parseOptions: TestOptions.Regular7_2, references: new[] { f_23142_38117_38161(compilation1)}), f_23142_38366_38459(f_23142_38366_38439(f_23142_38366_38416(ErrorCode.ERR_OverrideNotExpected, "F"), "B.F()"), 3, 37), f_23142_38618_38723(f_23142_38618_38704(f_23142_38618_38676(ErrorCode.ERR_UnimplementedAbstractMethod, "B"), "B", "A.F()"), 1, 7));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,37542,38754);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_37778_37842(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37778, 37842);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_37857_37889(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 37857, 37889);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_23142_38117_38161(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38117, 38161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_38015_38164(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions,Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38015, 38164);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38366_38416(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38366, 38416);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38366_38439(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38366, 38439);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38366_38459(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38366, 38459);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38618_38676(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38618, 38676);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38618_38704(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38618, 38704);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_38618_38723(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38618, 38723);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_38015_38742(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 38015, 38742);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,37542,38754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,37542,38754);
}
		}

[ConditionalFact(typeof(DesktopOnly))]
        public void VerifyPPExtension()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23142,38766,40215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,38870,39161);

string 
source = @"
static class Extensions
{
    static private protected void SomeExtension(this string s) { } // error: no pp in static class
}

class Client
{
    public static void M(string s)
    {
        s.SomeExtension(); // error: no accessible SomeExtension
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,39175,40204);

f_23142_39175_40203(f_23142_39175_39252(source, parseOptions: TestOptions.Regular7_2), f_23142_39548_39678(f_23142_39548_39658(f_23142_39548_39608(ErrorCode.ERR_ProtectedInStatic, "SomeExtension"), "Extensions.SomeExtension(string)"), 4, 35), f_23142_40056_40184(f_23142_40056_40163(f_23142_40056_40122(ErrorCode.ERR_NoSuchMemberOrExtension, "SomeExtension"), "string", "SomeExtension"), 11, 11));
DynAbs.Tracing.TraceSender.TraceExitMethod(23142,38766,40215);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_39175_39252(string
source,Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
parseOptions)
{
var return_v = CreateCompilationWithMscorlib45( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions:parseOptions);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 39175, 39252);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_39548_39608(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 39548, 39608);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_39548_39658(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 39548, 39658);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_39548_39678(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 39548, 39678);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_40056_40122(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 40056, 40122);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_40056_40163(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 40056, 40163);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23142_40056_40184(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 40056, 40184);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23142_39175_40203(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23142, 39175, 40203);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23142,38766,40215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,38766,40215);
}
		}

public PrivateProtected()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23142,571,40222);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23142,571,40222);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,571,40222);
}


static PrivateProtected()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23142,571,40222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,720,766);
s_keyPairFile = SigningTestHelpers.KeyPairFile;DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,808,858);
s_publicKeyFile = SigningTestHelpers.PublicKeyFile;DynAbs.Tracing.TraceSender.TraceSimpleStatement(23142,914,956);
s_publicKey = SigningTestHelpers.PublicKey;DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23142,571,40222);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23142,571,40222);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23142,571,40222);
}
}
