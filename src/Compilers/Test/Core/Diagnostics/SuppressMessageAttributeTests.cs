// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.UnitTests.Diagnostics
{
public abstract partial class SuppressMessageAttributeTests
{
[Fact]
        public async Task LocalSuppressionOnType()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,714,1088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,797,1077);

await f_25079_803_1076(this, @"
[System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Declaration"")]
public class C
{
}
public class C1
{
}
", new[] { f_25079_976_1023("C")}, f_25079_1044_1075(this, "Declaration", "C1"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,714,1088);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_976_1023(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 976, 1023);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_1044_1075(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1044, 1075);
return return_v;
}


System.Threading.Tasks.Task
f_25079_803_1076(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 803, 1076);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,714,1088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,714,1088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task MultipleLocalSuppressionsOnSingleSymbol()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,1100,1537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,1200,1526);

await f_25079_1206_1525(this, @"
using System.Diagnostics.CodeAnalysis;

[SuppressMessage(""Test"", ""Declaration"")]
[SuppressMessage(""Test"", ""TypeDeclaration"")]
public class C
{
}
", new DiagnosticAnalyzer[] { f_25079_1435_1482("C"), f_25079_1484_1522()});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,1100,1537);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_1435_1482(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1435, 1482);
return return_v;
}


Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer
f_25079_1484_1522()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1484, 1522);
return return_v;
}


System.Threading.Tasks.Task
f_25079_1206_1525(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1206, 1525);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,1100,1537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,1100,1537);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task DuplicateLocalSuppressions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,1549,1929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,1636,1918);

await f_25079_1642_1917(this, @"
using System.Diagnostics.CodeAnalysis;

[SuppressMessage(""Test"", ""Declaration"")]
[SuppressMessage(""Test"", ""Declaration"")]
public class C
{
}
", new DiagnosticAnalyzer[] { f_25079_1867_1914("C")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,1549,1929);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_1867_1914(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1867, 1914);
return return_v;
}


System.Threading.Tasks.Task
f_25079_1642_1917(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 1642, 1917);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,1549,1929);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,1549,1929);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task LocalSuppressionOnMember()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,1941,2355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,2026,2344);

await f_25079_2032_2343(this, @"
public class C
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Declaration"")]
    public void Goo() {}
    public void Goo1() {}
}
", new[] { f_25079_2239_2288("Goo")}, f_25079_2309_2342(this, "Declaration", "Goo1"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,1941,2355);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_2239_2288(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 2239, 2288);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_2309_2342(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 2309, 2342);
return return_v;
}


System.Threading.Tasks.Task
f_25079_2032_2343(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 2032, 2343);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,1941,2355);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,1941,2355);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnNamespaces()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,2427,3172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,2517,3161);

await f_25079_2523_3160(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Namespace"", Target=""N"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Namespace"", Target=""N.N1"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Namespace"", Target=""N4"")]

namespace N
{
    namespace N1
    {
        namespace N2.N3
        {
        }
    }
}

namespace N4
{
}
", new[] { f_25079_3010_3057("N")}, f_25079_3078_3109(this, "Declaration", "N2"), f_25079_3128_3159(this, "Declaration", "N3"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,2427,3172);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_3010_3057(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3010, 3057);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_3078_3109(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3078, 3109);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_3128_3159(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3128, 3159);
return return_v;
}


System.Threading.Tasks.Task
f_25079_2523_3160(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 2523, 3160);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,2427,3172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,2427,3172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact, WorkItem(486, "https://github.com/dotnet/roslyn/issues/486")]
        public async Task GlobalSuppressionOnNamespaces_NamespaceAndDescendants()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,3184,3965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,3360,3954);

await f_25079_3366_3953(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""NamespaceAndDescendants"", Target=""N.N1"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""namespaceanddescendants"", Target=""N4"")]

namespace N
{
    namespace N1
    {
        namespace N2.N3
        {
        }
    }
}

namespace N4
{
    namespace N5
    {
    }
}

namespace N.N1.N6.N7
{
}
", new[] { f_25079_3854_3901("N")}, f_25079_3922_3952(this, "Declaration", "N"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,3184,3965);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_3854_3901(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3854, 3901);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_3922_3952(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3922, 3952);
return return_v;
}


System.Threading.Tasks.Task
f_25079_3366_3953(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 3366, 3953);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,3184,3965);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,3184,3965);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact, WorkItem(486, "https://github.com/dotnet/roslyn/issues/486")]
        public async Task GlobalSuppressionOnTypesAndNamespaces_NamespaceAndDescendants()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,3977,5424);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,4161,5016);

var 
source = @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""NamespaceAndDescendants"", Target=""N.N1.N2"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""NamespaceAndDescendants"", Target=""N4"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""C2"")]

namespace N
{
    namespace N1
    {
        class C1
        {
        }

        namespace N2.N3
        {
            class C2
            {
            }

            class C3
            {
                class C4
                {
                }
            }
        }
    }
}

namespace N4
{
    namespace N5
    {
        class C5
        {
        }
    }

    class C6
    {
    }
}

namespace N.N1.N2.N7
{
    class C7
    {
    }
}
"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,5032,5239);

await f_25079_5038_5238(this, source, new[] { f_25079_5089_5136("N")}, f_25079_5157_5187(this, "Declaration", "N"), f_25079_5206_5237(this, "Declaration", "N1"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,5255,5413);

await f_25079_5261_5412(this, source, new[] { f_25079_5312_5359("C")}, f_25079_5380_5411(this, "Declaration", "C1"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,3977,5424);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_5089_5136(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5089, 5136);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_5157_5187(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5157, 5187);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_5206_5237(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5206, 5237);
return return_v;
}


System.Threading.Tasks.Task
f_25079_5038_5238(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5038, 5238);
return return_v;
}


Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_5312_5359(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5312, 5359);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_5380_5411(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5380, 5411);
return return_v;
}


System.Threading.Tasks.Task
f_25079_5261_5412(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5261, 5412);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,3977,5424);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,3977,5424);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,5436,6152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,5521,6141);

await f_25079_5527_6140(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""E"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""Ef"")]
[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""Egg"")]
[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""Ele`2"")]

public class E
{
}
public interface Ef
{
}
public struct Egg
{
}
public delegate void Ele<T1,T2>(T1 x, T2 y);
", new[] { f_25079_6090_6137("E")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,5436,6152);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_6090_6137(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 6090, 6137);
return return_v;
}


System.Threading.Tasks.Task
f_25079_5527_6140(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 5527, 6140);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,5436,6152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,5436,6152);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnNestedTypes()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,6164,7054);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,6255,7043);

await f_25079_6261_7042(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""type"", Target=""C.A1"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""type"", Target=""C+A2"")]
[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""member"", Target=""C+A3"")]
[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""member"", Target=""C.A4"")]

public class C
{
    public class A1 { }
    public class A2 { }
    public class A3 { }
    public delegate void A4();
}
", new[] { f_25079_6842_6889("A")}, f_25079_6910_6941(this, "Declaration", "A1"), f_25079_6960_6991(this, "Declaration", "A3"), f_25079_7010_7041(this, "Declaration", "A4"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,6164,7054);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_6842_6889(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 6842, 6889);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_6910_6941(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 6910, 6941);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_6960_6991(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 6960, 6991);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_7010_7041(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 7010, 7041);
return return_v;
}


System.Threading.Tasks.Task
f_25079_6261_7042(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 6261, 7042);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,6164,7054);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,6164,7054);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnBasicModule()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,7066,7444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,7157,7433);

await f_25079_7163_7432(this, @"
<assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Declaration"", Scope=""type"", Target=""M"")>

Module M
    Class C
    End Class
End Module
", new[] { f_25079_7382_7429("M")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,7066,7444);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_7382_7429(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 7382, 7429);
return return_v;
}


System.Threading.Tasks.Task
f_25079_7163_7432(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 7163, 7432);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,7066,7444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,7066,7444);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnMembers()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,7456,8046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,7543,8035);

await f_25079_7549_8034(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Member"", Target=""C.#M1"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Member"", Target=""C.#M3`1()"")]

public class C
{
    int M1;
    public void M2() {}
    public static void M3<T>() {}
}
", new[] { f_25079_7924_7971("M")}, new[] { f_25079_8000_8031(this, "Declaration", "M2")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,7456,8046);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_7924_7971(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 7924, 7971);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_8000_8031(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 8000, 8031);
return return_v;
}


System.Threading.Tasks.Task
f_25079_7549_8034(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 7549, 8034);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,7456,8046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,7456,8046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GlobalSuppressionOnValueTupleMemberWithDocId()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,8058,8617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,8163,8606);

await f_25079_8169_8605(this, @"
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Member"", Target=""~M:C.M~System.Threading.Tasks.Task{System.ValueTuple{System.Boolean,ErrorCode}}"")]

enum ErrorCode {}

class C
{
    Task<(bool status, ErrorCode errorCode)> M() => null;
}
", new[] { f_25079_8555_8602("M")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,8058,8617);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_8555_8602(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 8555, 8602);
return return_v;
}


System.Threading.Tasks.Task
f_25079_8169_8605(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 8169, 8605);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,8058,8617);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,8058,8617);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task MultipleGlobalSuppressionsOnSingleSymbol()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,8629,9149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,8730,9138);

await f_25079_8736_9137(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""E"")]
[assembly: SuppressMessage(""Test"", ""TypeDeclaration"", Scope=""Type"", Target=""E"")]

public class E
{
}
", new DiagnosticAnalyzer[] { f_25079_9047_9094("E"), f_25079_9096_9134()});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,8629,9149);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_9047_9094(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9047, 9094);
return return_v;
}


Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer
f_25079_9096_9134()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9096, 9134);
return return_v;
}


System.Threading.Tasks.Task
f_25079_8736_9137(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 8736, 9137);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,8629,9149);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,8629,9149);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task DuplicateGlobalSuppressions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,9161,9605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,9249,9594);

await f_25079_9255_9593(this, @"
using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""E"")]
[assembly: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""E"")]

public class E
{
}
", new[] { f_25079_9543_9590("E")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,9161,9605);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_9543_9590(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9543, 9590);
return return_v;
}


System.Threading.Tasks.Task
f_25079_9255_9593(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9255, 9593);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,9161,9605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,9161,9605);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task WarningOnCommentAnalyzerCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,9675,10003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,9766,9992);

await f_25079_9772_9991(this, "// Comment\r\n /* Comment */", new[] { f_25079_9847_9877()}, f_25079_9898_9933(this, "Comment", "// Comment"), f_25079_9952_9990(this, "Comment", "/* Comment */"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,9675,10003);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_9847_9877()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9847, 9877);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_9898_9933(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9898, 9933);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_9952_9990(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9952, 9990);
return return_v;
}


System.Threading.Tasks.Task
f_25079_9772_9991(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 9772, 9991);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,9675,10003);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,9675,10003);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task WarningOnCommentAnalyzerBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,10015,10264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,10105,10253);

await f_25079_10111_10252(this, "' Comment", new[] { f_25079_10166_10196()}, f_25079_10217_10251(this, "Comment", "' Comment"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,10015,10264);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_10166_10196()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10166, 10196);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_10217_10251(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10217, 10251);
return return_v;
}


System.Threading.Tasks.Task
f_25079_10111_10252(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10111, 10252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,10015,10264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,10015,10264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GloballySuppressSyntaxDiagnosticsCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,10276,10756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,10376,10745);

await f_25079_10382_10744(this, @"
// before module attributes
[module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Comment"")]
// before class
public class C
{
    // before method
    public void Goo() // after method declaration
    {
        // inside method
    }
}
// after class
", new[] { f_25079_10711_10741()});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,10276,10756);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_10711_10741()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10711, 10741);
return return_v;
}


System.Threading.Tasks.Task
f_25079_10382_10744(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10382, 10744);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,10276,10756);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,10276,10756);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GloballySuppressSyntaxDiagnosticsBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,10768,11232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,10867,11221);

await f_25079_10873_11220(this, @"
' before module attributes
<Module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Comment"")>
' before class
Public Class C
    ' before sub
    Public Sub Goo() ' after sub statement
        ' inside sub
    End Sub
End Class
' after class
", new[] { f_25079_11187_11217()});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,10768,11232);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_11187_11217()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11187, 11217);
return return_v;
}


System.Threading.Tasks.Task
f_25079_10873_11220(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 10873, 11220);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,10768,11232);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,10768,11232);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GloballySuppressSyntaxDiagnosticsOnTargetCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,11244,11969);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,11352,11958);

await f_25079_11358_11957(this, @"
// before module attributes
[module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Comment"", Scope=""Member"" Target=""C.Goo():System.Void"")]
// before class
public class C
{
    // before method
    public void Goo() // after method declaration
    {
        // inside method
    }
}
// after class
", new[] { f_25079_11736_11766()}, f_25079_11787_11839(this, "Comment", "// before module attributes"), f_25079_11858_11898(this, "Comment", "// before class"), f_25079_11917_11956(this, "Comment", "// after class"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,11244,11969);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_11736_11766()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11736, 11766);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_11787_11839(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11787, 11839);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_11858_11898(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11858, 11898);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_11917_11956(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11917, 11956);
return return_v;
}


System.Threading.Tasks.Task
f_25079_11358_11957(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 11358, 11957);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,11244,11969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,11244,11969);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task GloballySuppressSyntaxDiagnosticsOnTargetBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,11981,12690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,12088,12679);

await f_25079_12094_12678(this, @"
' before module attributes
<Module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Comment"", Scope:=""Member"", Target:=""C.Goo():System.Void"")>
' before class
Public Class C
    ' before sub
    Public Sub Goo() ' after sub statement
        ' inside sub
    End Sub
End Class
' after class
", new[] { f_25079_12460_12490()}, f_25079_12511_12562(this, "Comment", "' before module attributes"), f_25079_12581_12620(this, "Comment", "' before class"), f_25079_12639_12677(this, "Comment", "' after class"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,11981,12690);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_12460_12490()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12460, 12490);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_12511_12562(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12511, 12562);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_12581_12620(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12581, 12620);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_12639_12677(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12639, 12677);
return return_v;
}


System.Threading.Tasks.Task
f_25079_12094_12678(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12094, 12678);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,11981,12690);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,11981,12690);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnNamespaceDeclarationCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,12702,13446);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,12816,13435);

await f_25079_12822_13434(this, @"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"", Scope=""namespace"", Target=""A.B"")]
namespace A
[|{
    namespace B
    {
        class C {}
    }
}|]
", f_25079_13073_13116(f_25079_13073_13097(this, "Token", "{"), 4, 1), f_25079_13135_13182(f_25079_13135_13163(this, "Token", "class"), 7, 9), f_25079_13201_13245(f_25079_13201_13225(this, "Token", "C"), 7, 15), f_25079_13264_13308(f_25079_13264_13288(this, "Token", "{"), 7, 17), f_25079_13327_13371(f_25079_13327_13351(this, "Token", "}"), 7, 18), f_25079_13390_13433(f_25079_13390_13414(this, "Token", "}"), 9, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,12702,13446);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13073_13097(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13073, 13097);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13073_13116(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13073, 13116);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13135_13163(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13135, 13163);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13135_13182(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13135, 13182);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13201_13225(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13201, 13225);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13201_13245(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13201, 13245);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13264_13288(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13264, 13288);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13264_13308(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13264, 13308);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13327_13351(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13327, 13351);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13327_13371(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13327, 13371);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13390_13414(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13390, 13414);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13390_13433(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13390, 13433);
return return_v;
}


System.Threading.Tasks.Task
f_25079_12822_13434(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 12822, 13434);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,12702,13446);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,12702,13446);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact, WorkItem(486, "https://github.com/dotnet/roslyn/issues/486")]
        public async Task SuppressSyntaxDiagnosticsOnNamespaceAndChildDeclarationCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,13458,14031);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,13642,14020);

await f_25079_13648_14019(this, @"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"", Scope=""NamespaceAndDescendants"", Target=""A.B"")]
namespace A
[|{
    namespace B
    {
        class C {}
    }
}|]
", f_25079_13913_13956(f_25079_13913_13937(this, "Token", "{"), 4, 1), f_25079_13975_14018(f_25079_13975_13999(this, "Token", "}"), 9, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,13458,14031);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13913_13937(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13913, 13937);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13913_13956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13913, 13956);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13975_13999(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13975, 13999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_13975_14018(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13975, 14018);
return return_v;
}


System.Threading.Tasks.Task
f_25079_13648_14019(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 13648, 14019);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,13458,14031);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,13458,14031);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnNamespaceDeclarationBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,14043,14826);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,14156,14815);

await f_25079_14162_14814(this, @"
<assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"", Scope:=""Namespace"", Target:=""A.B"")>
Namespace [|A
    Namespace B 
        Class C
        End Class
    End Namespace
End|] Namespace
", f_25079_14445_14489(f_25079_14445_14469(this, "Token", "A"), 3, 11), f_25079_14508_14555(f_25079_14508_14536(this, "Token", "Class"), 5, 9), f_25079_14574_14618(f_25079_14574_14598(this, "Token", "C"), 5, 15), f_25079_14637_14682(f_25079_14637_14663(this, "Token", "End"), 6, 9), f_25079_14701_14749(f_25079_14701_14729(this, "Token", "Class"), 6, 13), f_25079_14768_14813(f_25079_14768_14794(this, "Token", "End"), 8, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,14043,14826);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14445_14469(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14445, 14469);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14445_14489(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14445, 14489);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14508_14536(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14508, 14536);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14508_14555(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14508, 14555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14574_14598(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14574, 14598);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14574_14618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14574, 14618);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14637_14663(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14637, 14663);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14637_14682(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14637, 14682);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14701_14729(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14701, 14729);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14701_14749(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14701, 14749);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14768_14794(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14768, 14794);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_14768_14813(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14768, 14813);
return return_v;
}


System.Threading.Tasks.Task
f_25079_14162_14814(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 14162, 14814);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,14043,14826);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,14043,14826);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact, WorkItem(486, "https://github.com/dotnet/roslyn/issues/486")]
        public async Task SuppressSyntaxDiagnosticsOnNamespaceAndDescendantsDeclarationBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,14838,15451);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,15027,15440);

await f_25079_15033_15439(this, @"
<assembly: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"", Scope:=""NamespaceAndDescendants"", Target:=""A.B"")>
Namespace [|A
    Namespace B 
        Class C
        End Class
    End Namespace
End|] Namespace
", f_25079_15330_15374(f_25079_15330_15354(this, "Token", "A"), 3, 11), f_25079_15393_15438(f_25079_15393_15419(this, "Token", "End"), 8, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,14838,15451);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_15330_15354(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15330, 15354);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_15330_15374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15330, 15374);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_15393_15419(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15393, 15419);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_15393_15438(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15393, 15438);
return return_v;
}


System.Threading.Tasks.Task
f_25079_15033_15439(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15033, 15439);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,14838,15451);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,14838,15451);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Theory, WorkItem(486, "https://github.com/dotnet/roslyn/issues/486")]
        [InlineData("Namespace")]
        [InlineData("NamespaceAndDescendants")]
        public async Task DontSuppressSyntaxDiagnosticsInRootNamespaceBasic(string scope)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,15463,16126);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,15733,16115);

await f_25079_15739_16114(this, $@"
<module: System.Diagnostics.SuppressMessage(""Test"", ""Comment"", Scope:=""{scope}"", Target:=""RootNamespace"")>
' In root namespace
", rootNamespace: "RootNamespace", analyzers: new[] { f_25079_15986_16016()}, diagnostics: f_25079_16050_16113(f_25079_16050_16094(this, "Comment", "' In root namespace"), 3, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,15463,16126);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_15986_16016()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15986, 16016);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16050_16094(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16050, 16094);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16050_16113(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16050, 16113);
return return_v;
}


System.Threading.Tasks.Task
f_25079_15739_16114(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,string
rootNamespace,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, rootNamespace: rootNamespace, analyzers: (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 15739, 16114);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,15463,16126);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,15463,16126);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnTypesCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,16138,16813);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,16237,16802);

await f_25079_16243_16801(this, @"
using System.Diagnostics.CodeAnalysis;

namespace N
[|{
    [SuppressMessage(""Test"", ""Token"")]
    class C<T> {}

    [SuppressMessage(""Test"", ""Token"")]
    struct S<T> {}

    [SuppressMessage(""Test"", ""Token"")]
    interface I<T>{}

    [SuppressMessage(""Test"", ""Token"")]
    enum E {}

    [SuppressMessage(""Test"", ""Token"")]
    delegate void D();
}|]
", f_25079_16694_16737(f_25079_16694_16718(this, "Token", "{"), 5, 1), f_25079_16756_16800(f_25079_16756_16780(this, "Token", "}"), 20, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,16138,16813);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16694_16718(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16694, 16718);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16694_16737(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16694, 16737);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16756_16780(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16756, 16780);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_16756_16800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16756, 16800);
return return_v;
}


System.Threading.Tasks.Task
f_25079_16243_16801(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16243, 16801);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,16138,16813);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,16138,16813);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnTypesBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,16825,17649);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,16923,17638);

await f_25079_16929_17637(this, @"
Imports System.Diagnostics.CodeAnalysis

Namespace [|N
    <SuppressMessage(""Test"", ""Token"")>
    Module M
    End Module

    <SuppressMessage(""Test"", ""Token"")>
    Class C
    End Class

    <SuppressMessage(""Test"", ""Token"")>
    Structure S
    End Structure

    <SuppressMessage(""Test"", ""Token"")>
    Interface I
    End Interface

    <SuppressMessage(""Test"", ""Token"")>
    Enum E
        None
    End Enum

    <SuppressMessage(""Test"", ""Token"")>
    Delegate Sub D()
End|] Namespace
", f_25079_17527_17571(f_25079_17527_17551(this, "Token", "N"), 4, 11), f_25079_17590_17636(f_25079_17590_17616(this, "Token", "End"), 28, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,16825,17649);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_17527_17551(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 17527, 17551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_17527_17571(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 17527, 17571);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_17590_17616(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 17590, 17616);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_17590_17636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 17590, 17636);
return return_v;
}


System.Threading.Tasks.Task
f_25079_16929_17637(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 16929, 17637);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,16825,17649);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,16825,17649);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnFieldsCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,17661,18110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,17761,18099);

await f_25079_17767_18098(this, @"
using System.Diagnostics.CodeAnalysis;

class C
[|{
    [SuppressMessage(""Test"", ""Token"")]
    int field1 = 1, field2 = 2;

    [SuppressMessage(""Test"", ""Token"")]
    int field3 = 3;
}|]
", f_25079_18030_18054(this, "Token", "{"), f_25079_18073_18097(this, "Token", "}"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,17661,18110);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18030_18054(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18030, 18054);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18073_18097(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18073, 18097);
return return_v;
}


System.Threading.Tasks.Task
f_25079_17767_18098(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 17767, 18098);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,17661,18110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,17661,18110);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        [WorkItem(6379, "https://github.com/dotnet/roslyn/issues/6379")]
        public async Task SuppressSyntaxDiagnosticsOnEnumFieldsCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,18122,19045);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,18300,19034);

await f_25079_18306_19033(this, @"
// before module attributes
[module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Comment"", Scope=""Member"" Target=""E.Field1"")]
// before enum
public enum E
{
    // before Field1 declaration
    Field1, // after Field1 declaration
    Field2 // after Field2 declaration
}
// after enum
", new[] { f_25079_18672_18702()}, f_25079_18723_18775(this, "Comment", "// before module attributes"), f_25079_18794_18833(this, "Comment", "// before enum"), f_25079_18852_18904(this, "Comment", "// after Field1 declaration"), f_25079_18923_18975(this, "Comment", "// after Field2 declaration"), f_25079_18994_19032(this, "Comment", "// after enum"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,18122,19045);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer
f_25079_18672_18702()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18672, 18702);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18723_18775(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18723, 18775);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18794_18833(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18794, 18833);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18852_18904(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18852, 18904);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18923_18975(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18923, 18975);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_18994_19032(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18994, 19032);
return return_v;
}


System.Threading.Tasks.Task
f_25079_18306_19033(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCommentAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 18306, 19033);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,18122,19045);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,18122,19045);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnFieldsBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,19057,19562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,19156,19551);

await f_25079_19162_19550(this, @"
Imports System.Diagnostics.CodeAnalysis

Class [|C
    <SuppressMessage(""Test"", ""Token"")>
    Public field1 As Integer = 1,
           field2 As Double = 2.0

    <SuppressMessage(""Test"", ""Token"")>
    Public field3 As Integer = 3
End|] Class
", f_25079_19480_19504(this, "Token", "C"), f_25079_19523_19549(this, "Token", "End"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,19057,19562);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_19480_19504(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 19480, 19504);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_19523_19549(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 19523, 19549);
return return_v;
}


System.Threading.Tasks.Task
f_25079_19162_19550(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 19162, 19550);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,19057,19562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,19057,19562);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventsCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,19574,20077);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,19674,20066);

await f_25079_19680_20065(this, @"
class C
[|{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    public event System.Action<int> E1;

    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    public event System.Action<int> E2, E3;
}|]
", f_25079_19997_20021(this, "Token", "{"), f_25079_20040_20064(this, "Token", "}"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,19574,20077);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_19997_20021(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 19997, 20021);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_20040_20064(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20040, 20064);
return return_v;
}


System.Threading.Tasks.Task
f_25079_19680_20065(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 19680, 20065);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,19574,20077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,19574,20077);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventsBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,20089,20583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,20188,20572);

await f_25079_20194_20571(this, @"
Imports System.Diagnostics.CodeAnalysis

Class [|C
    <SuppressMessage(""Test"", ""Token"")>
    Public Event E1 As System.Action(Of Integer)

    <SuppressMessage(""Test"", ""Token"")>
    Public Event E2(ByVal arg As Integer)
End|] Class
", f_25079_20501_20525(this, "Token", "C"), f_25079_20544_20570(this, "Token", "End"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,20089,20583);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_20501_20525(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20501, 20525);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_20544_20570(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20544, 20570);
return return_v;
}


System.Threading.Tasks.Task
f_25079_20194_20571(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20194, 20571);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,20089,20583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,20089,20583);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventAddAccessorCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,20595,21079);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,20705,21068);

await f_25079_20711_21067(this, @"
class C
{
    public event System.Action<int> E
    [|{
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        add {}
        remove|] {}
    }
}
", f_25079_20956_20999(f_25079_20956_20980(this, "Token", "{"), 5, 5), f_25079_21018_21066(f_25079_21018_21047(this, "Token", "remove"), 8, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,20595,21079);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_20956_20980(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20956, 20980);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_20956_20999(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20956, 20999);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_21018_21047(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21018, 21047);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_21018_21066(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21018, 21066);
return return_v;
}


System.Threading.Tasks.Task
f_25079_20711_21067(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 20711, 21067);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,20595,21079);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,20595,21079);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventAddAccessorBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,21091,21742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,21200,21731);

await f_25079_21206_21730(this, @"
Class C
    Public Custom Event E As System.Action(Of Integer[|)
        <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
        AddHandler(value As Action(Of Integer))
        End AddHandler
        RemoveHandler|](value As Action(Of Integer))
        End RemoveHandler
        RaiseEvent(obj As Integer)
        End RaiseEvent
    End Event
End Class
", f_25079_21650_21674(this, "Token", ")"), f_25079_21693_21729(this, "Token", "RemoveHandler"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,21091,21742);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_21650_21674(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21650, 21674);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_21693_21729(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21693, 21729);
return return_v;
}


System.Threading.Tasks.Task
f_25079_21206_21730(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21206, 21730);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,21091,21742);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,21091,21742);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventRemoveAccessorCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,21754,22237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,21867,22226);

await f_25079_21873_22225(this, @"
class C
{
    public event System.Action<int> E
    {
        add {[|}
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        remove {}
    }|]
}
", f_25079_22118_22162(f_25079_22118_22142(this, "Token", "}"), 6, 14), f_25079_22181_22224(f_25079_22181_22205(this, "Token", "}"), 9, 5));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,21754,22237);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22118_22142(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22118, 22142);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22118_22162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22118, 22162);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22181_22205(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22181, 22205);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22181_22224(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22181, 22224);
return return_v;
}


System.Threading.Tasks.Task
f_25079_21873_22225(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 21873, 22225);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,21754,22237);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,21754,22237);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnEventRemoveAccessorBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,22249,22909);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,22361,22898);

await f_25079_22367_22897(this, @"
Class C
    Public Custom Event E As System.Action(Of Integer)
        AddHandler(value As Action(Of Integer))
        End [|AddHandler
        <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
        RemoveHandler(value As Action(Of Integer))
        End RemoveHandler
        RaiseEvent|](obj As Integer)
        End RaiseEvent
    End Event
End Class
", f_25079_22811_22844(this, "Token", "AddHandler"), f_25079_22863_22896(this, "Token", "RaiseEvent"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,22249,22909);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22811_22844(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22811, 22844);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_22863_22896(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22863, 22896);
return return_v;
}


System.Threading.Tasks.Task
f_25079_22367_22897(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 22367, 22897);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,22249,22909);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,22249,22909);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[WorkItem(1103442, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1103442")]
        [Fact]
        public async Task SuppressSyntaxDiagnosticsOnRaiseEventAccessorBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,22921,23670);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,23126,23659);

await f_25079_23132_23658(this, @"
Class C
    Public Custom Event E As System.Action(Of Integer)
        AddHandler(value As Action(Of Integer))
        End AddHandler
        RemoveHandler(value As Action(Of Integer))
        End [|RemoveHandler
        <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
        RaiseEvent(obj As Integer)
        End RaiseEvent
    End|] Event
End Class
", f_25079_23576_23612(this, "Token", "RemoveHandler"), f_25079_23631_23657(this, "Token", "End"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,22921,23670);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_23576_23612(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 23576, 23612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_23631_23657(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 23631, 23657);
return return_v;
}


System.Threading.Tasks.Task
f_25079_23132_23658(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 23132, 23658);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,22921,23670);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,22921,23670);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertyCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,23682,24243);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,23784,24232);

await f_25079_23790_24231(this, @"
using System.Diagnostics.CodeAnalysis;

class C
[|{
    [SuppressMessage(""Test"", ""Token"")]
    int Property1 { get; set; }

    [SuppressMessage(""Test"", ""Token"")]
    int Property2
    {
        get { return 2; }
        set { Property1 = 2; }
    }
}|]
", f_25079_24124_24167(f_25079_24124_24148(this, "Token", "{"), 5, 1), f_25079_24186_24230(f_25079_24186_24210(this, "Token", "}"), 15, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,23682,24243);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24124_24148(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24124, 24148);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24124_24167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24124, 24167);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24186_24210(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24186, 24210);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24186_24230(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24186, 24230);
return return_v;
}


System.Threading.Tasks.Task
f_25079_23790_24231(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 23790, 24231);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,23682,24243);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,23682,24243);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertyBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,24255,24916);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,24356,24905);

await f_25079_24362_24904(this, @"
Imports System.Diagnostics.CodeAnalysis

Class [|C
    <SuppressMessage(""Test"", ""Token"")>
    Property Property1 As Integer

    <SuppressMessage(""Test"", ""Token"")>
    Property Property2 As Integer
        Get
            Return 2
        End Get
        Set(value As Integer)
            Property1 = value
        End Set
    End Property
End|] Class
", f_25079_24795_24838(f_25079_24795_24819(this, "Token", "C"), 4, 7), f_25079_24857_24903(f_25079_24857_24883(this, "Token", "End"), 17, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,24255,24916);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24795_24819(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24795, 24819);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24795_24838(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24795, 24838);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24857_24883(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24857, 24883);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_24857_24903(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24857, 24903);
return return_v;
}


System.Threading.Tasks.Task
f_25079_24362_24904(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 24362, 24904);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,24255,24916);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,24255,24916);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertyGetterCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,24928,25414);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,25036,25403);

await f_25079_25042_25402(this, @"
class C
{
    int x;
    int Property
    [|{
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        get { return 2; }
        set|] { x = 2; }
    }
}
", f_25079_25294_25337(f_25079_25294_25318(this, "Token", "{"), 6, 5), f_25079_25356_25401(f_25079_25356_25382(this, "Token", "set"), 9, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,24928,25414);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25294_25318(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25294, 25318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25294_25337(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25294, 25337);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25356_25382(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25356, 25382);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25356_25401(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25356, 25401);
return return_v;
}


System.Threading.Tasks.Task
f_25079_25042_25402(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25042, 25402);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,24928,25414);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,24928,25414);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertyGetterBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,25426,26030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,25533,26019);

await f_25079_25539_26018(this, @"
Class C
    Private x As Integer
    Property [Property] As [|Integer
        <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
        Get
            Return 2
        End Get
        Set|](value As Integer)
            x = value
        End Set
    End Property
End Class
", f_25079_25903_25953(f_25079_25903_25933(this, "Token", "Integer"), 4, 28), f_25079_25972_26017(f_25079_25972_25998(this, "Token", "Set"), 9, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,25426,26030);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25903_25933(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25903, 25933);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25903_25953(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25903, 25953);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25972_25998(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25972, 25998);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_25972_26017(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25972, 26017);
return return_v;
}


System.Threading.Tasks.Task
f_25079_25539_26018(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 25539, 26018);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,25426,26030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,25426,26030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertySetterCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,26042,26528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,26150,26517);

await f_25079_26156_26516(this, @"
class C
{
    int x;
    int Property
    [|{
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        get { return 2; }
        set|] { x = 2; }
    }
}
", f_25079_26408_26451(f_25079_26408_26432(this, "Token", "{"), 6, 5), f_25079_26470_26515(f_25079_26470_26496(this, "Token", "set"), 9, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,26042,26528);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_26408_26432(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26408, 26432);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_26408_26451(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26408, 26451);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_26470_26496(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26470, 26496);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_26470_26515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26470, 26515);
return return_v;
}


System.Threading.Tasks.Task
f_25079_26156_26516(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26156, 26516);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,26042,26528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,26042,26528);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnPropertySetterBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,26540,27141);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,26647,27130);

await f_25079_26653_27129(this, @"
Class C
    Private x As Integer
    Property [Property] As Integer
        Get
            Return 2
        End [|Get
        <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
        Set(value As Integer)
            x = value
        End Set
    End|] Property
End Class
", f_25079_27017_27063(f_25079_27017_27043(this, "Token", "Get"), 7, 13), f_25079_27082_27128(f_25079_27082_27108(this, "Token", "End"), 12, 5));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,26540,27141);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27017_27043(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27017, 27043);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27017_27063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27017, 27063);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27082_27108(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27082, 27108);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27082_27128(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27082, 27128);
return return_v;
}


System.Threading.Tasks.Task
f_25079_26653_27129(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 26653, 27129);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,26540,27141);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,26540,27141);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnIndexerCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,27153,27631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,27254,27620);

await f_25079_27260_27619(this, @"
class C
{
    int x[|;
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    int this[int i]
    {
        get { return 2; }
        set { x = 2; }
    }
}|]
", f_25079_27511_27555(f_25079_27511_27535(this, "Token", ";"), 4, 10), f_25079_27574_27618(f_25079_27574_27598(this, "Token", "}"), 11, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,27153,27631);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27511_27535(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27511, 27535);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27511_27555(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27511, 27555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27574_27598(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27574, 27598);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_27574_27618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27574, 27618);
return return_v;
}


System.Threading.Tasks.Task
f_25079_27260_27619(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27260, 27619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,27153,27631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,27153,27631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnIndexerGetterCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,27643,28131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,27750,28120);

await f_25079_27756_28119(this, @"
class C
{
    int x;
    int this[int i]
    [|{
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        get { return 2; }
        set|] { x = 2; }
    }
}
", f_25079_28011_28054(f_25079_28011_28035(this, "Token", "{"), 6, 5), f_25079_28073_28118(f_25079_28073_28099(this, "Token", "set"), 9, 9));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,27643,28131);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28011_28035(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28011, 28035);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28011_28054(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28011, 28054);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28073_28099(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28073, 28099);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28073_28118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28073, 28118);
return return_v;
}


System.Threading.Tasks.Task
f_25079_27756_28119(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 27756, 28119);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,27643,28131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,27643,28131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnIndexerSetterCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,28143,28631);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,28250,28620);

await f_25079_28256_28619(this, @"
class C
{
    int x;
    int this[int i]
    {
        get { return 2; [|}
        [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
        set { x = 2; }
    }|]
}
", f_25079_28511_28555(f_25079_28511_28535(this, "Token", "}"), 7, 25), f_25079_28574_28618(f_25079_28574_28598(this, "Token", "}"), 10, 5));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,28143,28631);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28511_28535(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28511, 28535);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28511_28555(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28511, 28555);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28574_28598(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28574, 28598);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_28574_28618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28574, 28618);
return return_v;
}


System.Threading.Tasks.Task
f_25079_28256_28619(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28256, 28619);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,28143,28631);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,28143,28631);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnMethodCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,28643,29146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,28743,29135);

await f_25079_28749_29134(this, @"
using System.Diagnostics.CodeAnalysis;

abstract class C
[|{
    [SuppressMessage(""Test"", ""Token"")]
    public void M1<T>() {}

    [SuppressMessage(""Test"", ""Token"")]
    public abstract void M2();
}|]
", f_25079_29027_29070(f_25079_29027_29051(this, "Token", "{"), 5, 1), f_25079_29089_29133(f_25079_29089_29113(this, "Token", "}"), 11, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,28643,29146);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29027_29051(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29027, 29051);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29027_29070(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29027, 29070);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29089_29113(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29089, 29113);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29089_29133(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29089, 29133);
return return_v;
}


System.Threading.Tasks.Task
f_25079_28749_29134(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 28749, 29134);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,28643,29146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,28643,29146);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnMethodBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,29158,29739);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,29257,29728);

await f_25079_29263_29727(this, @"
Imports System.Diagnostics.CodeAnalysis

Public MustInherit Class [|C
    <SuppressMessage(""Test"", ""Token"")> 
    Public Function M2(Of T)() As Integer
        Return 0
    End Function 
    
    <SuppressMessage(""Test"", ""Token"")> 
    Public MustOverride Sub M3() 
End|] Class
", f_25079_29617_29661(f_25079_29617_29641(this, "Token", "C"), 4, 26), f_25079_29680_29726(f_25079_29680_29706(this, "Token", "End"), 12, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,29158,29739);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29617_29641(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29617, 29641);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29617_29661(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29617, 29661);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29680_29706(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29680, 29706);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_29680_29726(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29680, 29726);
return return_v;
}


System.Threading.Tasks.Task
f_25079_29263_29727(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29263, 29727);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,29158,29739);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,29158,29739);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnOperatorCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,29751,30210);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,29853,30199);

await f_25079_29859_30198(this, @"
class C
[|{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    public static C operator +(C a, C b) 
    {
        return null;
    } 
}|]
", f_25079_30092_30135(f_25079_30092_30116(this, "Token", "{"), 3, 1), f_25079_30154_30197(f_25079_30154_30178(this, "Token", "}"), 9, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,29751,30210);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30092_30116(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30092, 30116);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30092_30135(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30092, 30135);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30154_30178(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30154, 30178);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30154_30197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30154, 30197);
return return_v;
}


System.Threading.Tasks.Task
f_25079_29859_30198(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 29859, 30198);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,29751,30210);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,29751,30210);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnOperatorBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,30222,30715);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,30323,30704);

await f_25079_30329_30703(this, @"
Class [|C
    <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")> 
    Public Shared Operator +(ByVal a As C, ByVal b As C) As C 
        Return Nothing
    End Operator 
End|] Class 
", f_25079_30595_30638(f_25079_30595_30619(this, "Token", "C"), 2, 7), f_25079_30657_30702(f_25079_30657_30683(this, "Token", "End"), 7, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,30222,30715);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30595_30619(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30595, 30619);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30595_30638(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30595, 30638);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30657_30683(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30657, 30683);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_30657_30702(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30657, 30702);
return return_v;
}


System.Threading.Tasks.Task
f_25079_30329_30703(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30329, 30703);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,30222,30715);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,30222,30715);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnConstructorCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,30727,31194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,30832,31183);

await f_25079_30838_31182(this, @"
class Base
{
    public Base(int x) {}
}

class C : Base
[|{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    public C() : base(0) {} 
}|]
", f_25079_31075_31118(f_25079_31075_31099(this, "Token", "{"), 8, 1), f_25079_31137_31181(f_25079_31137_31161(this, "Token", "}"), 11, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,30727,31194);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31075_31099(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31075, 31099);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31075_31118(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31075, 31118);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31137_31161(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31137, 31161);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31137_31181(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31137, 31181);
return return_v;
}


System.Threading.Tasks.Task
f_25079_30838_31182(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 30838, 31182);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,30727,31194);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,30727,31194);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnConstructorBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,31206,31628);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,31310,31617);

await f_25079_31316_31616(this, @"
Class [|C
    <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
    Public Sub New()
    End Sub
End|] Class
", f_25079_31508_31551(f_25079_31508_31532(this, "Token", "C"), 2, 7), f_25079_31570_31615(f_25079_31570_31596(this, "Token", "End"), 6, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,31206,31628);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31508_31532(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31508, 31532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31508_31551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31508, 31551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31570_31596(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31570, 31596);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31570_31615(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31570, 31615);
return return_v;
}


System.Threading.Tasks.Task
f_25079_31316_31616(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31316, 31616);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,31206,31628);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,31206,31628);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnDestructorCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,31640,32034);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,31744,32023);

await f_25079_31750_32022(this, @"
class C
[|{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    ~C() {}
}|]
", f_25079_31916_31959(f_25079_31916_31940(this, "Token", "{"), 3, 1), f_25079_31978_32021(f_25079_31978_32002(this, "Token", "}"), 6, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,31640,32034);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31916_31940(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31916, 31940);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31916_31959(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31916, 31959);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31978_32002(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31978, 32002);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_31978_32021(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31978, 32021);
return return_v;
}


System.Threading.Tasks.Task
f_25079_31750_32022(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 31750, 32022);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,31640,32034);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,31640,32034);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnNestedTypeCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,32046,32494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,32150,32483);

await f_25079_32156_32482(this, @"
class C
[|{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")]
    class D
    {
        class E
        {
        }
    }
}|]
", f_25079_32375_32418(f_25079_32375_32399(this, "Token", "{"), 3, 1), f_25079_32437_32481(f_25079_32437_32461(this, "Token", "}"), 11, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,32046,32494);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32375_32399(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32375, 32399);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32375_32418(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32375, 32418);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32437_32461(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32437, 32461);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32437_32481(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32437, 32481);
return return_v;
}


System.Threading.Tasks.Task
f_25079_32156_32482(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsCSharpAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32156, 32482);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,32046,32494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,32046,32494);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressSyntaxDiagnosticsOnNestedTypeBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,32506,32956);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,32609,32945);

await f_25079_32615_32944(this, @"
Class [|C
    <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Token"")>
    Class D
        Class E
        End Class
    End Class
End|] Class
", f_25079_32836_32879(f_25079_32836_32860(this, "Token", "C"), 2, 7), f_25079_32898_32943(f_25079_32898_32924(this, "Token", "End"), 8, 1));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,32506,32956);

Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32836_32860(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32836, 32860);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32836_32879(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32836, 32879);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32898_32924(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32898, 32924);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_32898_32943(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32898, 32943);
return return_v;
}


System.Threading.Tasks.Task
f_25079_32615_32944(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsBasicAsync( markup, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 32615, 32944);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,32506,32956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,32506,32956);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressMessageCompilationEnded()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,33023,33330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,33115,33319);

await f_25079_33121_33318(this, @"[module: System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""CompilationEnded"")]", new[] { f_25079_33276_33315()});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,33023,33330);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCompilationEndedAnalyzer
f_25079_33276_33315()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCompilationEndedAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33276, 33315);
return return_v;
}


System.Threading.Tasks.Task
f_25079_33121_33318(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCompilationEndedAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33121, 33318);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,33023,33330);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,33023,33330);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressMessageOnPropertyAccessor()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,33342,33704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,33436,33693);

await f_25079_33442_33692(this, @"
public class C
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Declaration"")]
    public string P { get; private set; }
}
", new[] { f_25079_33639_33689("get_")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,33342,33704);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_33639_33689(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33639, 33689);
return return_v;
}


System.Threading.Tasks.Task
f_25079_33442_33692(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33442, 33692);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,33342,33704);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,33342,33704);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressMessageOnDelegateInvoke()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,33716,34059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,33808,34048);

await f_25079_33814_34047(this, @"
public class C
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""Declaration"")]
    delegate void D();
}
", new[] { f_25079_33992_34044("Invoke")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,33716,34059);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_33992_34044(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33992, 34044);
return return_v;
}


System.Threading.Tasks.Task
f_25079_33814_34047(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 33814, 34047);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,33716,34059);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,33716,34059);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressMessageOnCodeBodyCSharp()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,34071,34450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,34163,34439);

await f_25079_34169_34438(this, @"
public class C
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""CodeBody"")]
    void Goo()
    {
        Goo();
    }
}
", new[] { f_25079_34384_34435(LanguageNames.CSharp)});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,34071,34450);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer
f_25079_34384_34435(string
language)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer( language);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 34384, 34435);
return return_v;
}


System.Threading.Tasks.Task
f_25079_34169_34438(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 34169, 34438);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,34071,34450);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,34071,34450);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task SuppressMessageOnCodeBodyBasic()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,34462,34846);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,34553,34835);

await f_25079_34559_34834(this, @"
Public Class C
    <System.Diagnostics.CodeAnalysis.SuppressMessage(""Test"", ""CodeBody"")>
    Sub Goo()
        Goo()
    End Sub
End Class
", new[] { f_25079_34775_34831(LanguageNames.VisualBasic)});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,34462,34846);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer
f_25079_34775_34831(string
language)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer( language);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 34775, 34831);
return return_v;
}


System.Threading.Tasks.Task
f_25079_34559_34834(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnCodeBodyAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 34559, 34834);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,34462,34846);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,34462,34846);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task UnnecessaryScopeAndTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,34918,35435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,35004,35424);

await f_25079_35010_35423(this, @"
using System.Diagnostics.CodeAnalysis;

[SuppressMessage(""Test"", ""Declaration"", Scope=""Type"")]
public class C1
{
}

[SuppressMessage(""Test"", ""Declaration"", Target=""C"")]
public class C2
{
}

[SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""C"")]
public class C3
{
}
", new[] { f_25079_35373_35420("C")});
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,34918,35435);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_35373_35420(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 35373, 35420);
return return_v;
}


System.Threading.Tasks.Task
f_25079_35010_35423(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 35010, 35423);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,34918,35435);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,34918,35435);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task InvalidScopeOrTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,35447,36015);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,35528,36004);

await f_25079_35534_36003(this, @"
using System.Diagnostics.CodeAnalysis;

[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Class"", Target=""C"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"", Target=""E"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Class"", Target=""E"")]

public class C
{
}
", new[] { f_25079_35904_35951("C")}, f_25079_35972_36002(this, "Declaration", "C"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,35447,36015);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_35904_35951(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 35904, 35951);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_35972_36002(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 35972, 36002);
return return_v;
}


System.Threading.Tasks.Task
f_25079_35534_36003(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 35534, 36003);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,35447,36015);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,35447,36015);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task MissingScopeOrTarget()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,36027,36479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,36108,36468);

await f_25079_36114_36467(this, @"
using System.Diagnostics.CodeAnalysis;

[module: SuppressMessage(""Test"", ""Declaration"", Target=""C"")]
[module: SuppressMessage(""Test"", ""Declaration"", Scope=""Type"")]

public class C
{
}
", new[] { f_25079_36368_36415("C")}, f_25079_36436_36466(this, "Declaration", "C"));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,36027,36479);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer
f_25079_36368_36415(string
errorSymbolPrefix)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer( errorSymbolPrefix);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 36368, 36415);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_36436_36466(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 36436, 36466);
return return_v;
}


System.Threading.Tasks.Task
f_25079_36114_36467(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnNamePrefixDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyCSharpAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 36114, 36467);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,36027,36479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,36027,36479);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

[Fact]
        public async Task InvalidAttributeConstructorParameters()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,36491,37146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,36589,37135);

await f_25079_36595_37134(this, @"
Imports System.Diagnostics.CodeAnalysis

<module: SuppressMessage(UndeclaredIdentifier, ""Comment"")>
<module: SuppressMessage(""Test"", UndeclaredIdentifier)>
<module: SuppressMessage(""Test"", ""Comment"", Scope:=UndeclaredIdentifier, Target:=""C"")>
<module: SuppressMessage(""Test"", ""Comment"", Scope:=""Type"", Target:=UndeclaredIdentifier)>

Class C
End Class
", new[] { f_25079_37021_37059()}, f_25079_37080_37133(f_25079_37080_37114(this, "TypeDeclaration", "C"), 9, 7));
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,36491,37146);

Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer
f_25079_37021_37059()
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37021, 37059);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_37080_37114(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
id,string
squiggledText)
{
var return_v = this_param.Diagnostic( id, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37080, 37114);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_37080_37133(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37080, 37133);
return return_v;
}


System.Threading.Tasks.Task
f_25079_36595_37134(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTypeDeclarationAnalyzer[]
analyzers,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyBasicAsync( source, (Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[])analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 36595, 37134);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,36491,37146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,36491,37146);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected async Task VerifyCSharpAsync(string source, DiagnosticAnalyzer[] analyzers, params DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,37180,37417);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,37334,37406);

await f_25079_37340_37405(this, source, LanguageNames.CSharp, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,37180,37417);

System.Threading.Tasks.Task
f_25079_37340_37405(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,string
language,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyAsync( source, language, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37340, 37405);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,37180,37417);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,37180,37417);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected Task VerifyTokenDiagnosticsCSharpAsync(string markup, params DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,37429,37650);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,37561,37639);

return f_25079_37568_37638(this, markup, LanguageNames.CSharp, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,37429,37650);

System.Threading.Tasks.Task
f_25079_37568_37638(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,string
language,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsAsync( markup, language, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37568, 37638);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,37429,37650);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,37429,37650);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected async Task VerifyBasicAsync(string source, string rootNamespace, DiagnosticAnalyzer[] analyzers, params DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,37662,38086);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,37837,37954);

f_25079_37837_37953(f_25079_37850_37890(rootNamespace), f_25079_37892_37952("Invalid root namespace '{0}'", rootNamespace));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,37968,38075);

await f_25079_37974_38074(this, source, LanguageNames.VisualBasic, analyzers, diagnostics, rootNamespace: rootNamespace);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,37662,38086);

bool
f_25079_37850_37890(string
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37850, 37890);
return return_v;
}


string
f_25079_37892_37952(string
format,string
arg0)
{
var return_v = string.Format( format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37892, 37952);
return return_v;
}


int
f_25079_37837_37953(bool
condition,string
userMessage)
{
Assert.False( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37837, 37953);
return 0;
}


System.Threading.Tasks.Task
f_25079_37974_38074(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,string
language,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics,string
rootNamespace)
{
var return_v = this_param.VerifyAsync( source, language, analyzers, diagnostics, rootNamespace: rootNamespace);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 37974, 38074);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,37662,38086);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,37662,38086);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected async Task VerifyBasicAsync(string source, DiagnosticAnalyzer[] analyzers, params DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,38098,38339);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,38251,38328);

await f_25079_38257_38327(this, source, LanguageNames.VisualBasic, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,38098,38339);

System.Threading.Tasks.Task
f_25079_38257_38327(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,string
language,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyAsync( source, language, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 38257, 38327);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,38098,38339);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,38098,38339);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected Task VerifyTokenDiagnosticsBasicAsync(string markup, params DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,38351,38576);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,38482,38565);

return f_25079_38489_38564(this, markup, LanguageNames.VisualBasic, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,38351,38576);

System.Threading.Tasks.Task
f_25079_38489_38564(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
markup,string
language,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyTokenDiagnosticsAsync( markup, language, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 38489, 38564);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,38351,38576);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,38351,38576);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract Task VerifyAsync(string source, string language, DiagnosticAnalyzer[] analyzers, DiagnosticDescription[] diagnostics, string rootNamespace = null);

private Task VerifyTokenDiagnosticsAsync(string markup, string language, DiagnosticDescription[] diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,38905,39382);
string source = default(string);
System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan> spans = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,39039,39123);

f_25079_39039_39122(markup, out source, out spans);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,39137,39241);

f_25079_39137_39240(spans.Length > 0, "Must specify a span within which to generate diagnostics on each token");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,39257,39371);

return f_25079_39264_39370(this, source, language, new DiagnosticAnalyzer[] { f_25079_39321_39354(spans)}, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,38905,39382);

int
f_25079_39039_39122(string
input,out string
output,out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
spans)
{
MarkupTestFile.GetSpans( input, out output, out spans);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 39039, 39122);
return 0;
}


int
f_25079_39137_39240(bool
condition,string
userMessage)
{
Assert.True( condition, userMessage);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 39137, 39240);
return 0;
}


Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTokenAnalyzer
f_25079_39321_39354(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextSpan>
spans)
{
var return_v = new Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests.WarningOnTokenAnalyzer( (System.Collections.Generic.IList<Microsoft.CodeAnalysis.Text.TextSpan>)spans);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 39321, 39354);
return return_v;
}


System.Threading.Tasks.Task
f_25079_39264_39370(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param,string
source,string
language,Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer[]
analyzers,Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
diagnostics)
{
var return_v = this_param.VerifyAsync( source, language, analyzers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 39264, 39370);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,38905,39382);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,38905,39382);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected abstract bool ConsiderArgumentsForComparingDiagnostics {get; }

protected DiagnosticDescription Diagnostic(string id, string squiggledText)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25079,39479,39847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,39579,39733);

var 
arguments = (DynAbs.Tracing.TraceSender.Conditional_F1(25079, 39595, 39665)||((f_25079_39595_39640(this)&&(DynAbs.Tracing.TraceSender.Expression_True(25079, 39595, 39665)&&squiggledText != null
)&&DynAbs.Tracing.TraceSender.Conditional_F2(25079, 39685, 39708))||DynAbs.Tracing.TraceSender.Conditional_F3(25079, 39728, 39732)))?new[] { squiggledText }
:null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25079,39747,39836);

return f_25079_39754_39835(id, false, squiggledText, arguments, null, null, false);
DynAbs.Tracing.TraceSender.TraceExitMethod(25079,39479,39847);

bool
f_25079_39595_39640(Microsoft.CodeAnalysis.UnitTests.Diagnostics.SuppressMessageAttributeTests
this_param)
{
var return_v = this_param.ConsiderArgumentsForComparingDiagnostics ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25079, 39595, 39640);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_25079_39754_39835(string
code,bool
isWarningAsError,string?
squiggledText,string[]?
arguments,Microsoft.CodeAnalysis.Text.LinePosition?
startLocation,System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
syntaxNodePredicate,bool
argumentOrderDoesNotMatter)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription( (object)code, isWarningAsError, squiggledText, (object[]?)arguments, startLocation, syntaxNodePredicate, argumentOrderDoesNotMatter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25079, 39754, 39835);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25079,39479,39847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,39479,39847);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public SuppressMessageAttributeTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25079,601,39854);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25079,601,39854);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,601,39854);
}


static SuppressMessageAttributeTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25079,601,39854);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080,699,730);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25080,764,801);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25079,601,39854);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25079,601,39854);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25079,601,39854);
}
}
