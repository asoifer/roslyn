// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Emit
{
public class UnmanagedTypeModifierTests : CSharpTestBase
{
[Fact]
        public void LoadingADifferentModifierTypeForUnmanagedConstraint()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,530,3306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,636,1985);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M1<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M1

  .method public hidebysig instance void
          M2<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.InAttribute)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,2001,2066);

var 
reference = f_23121_2017_2065(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,2082,2281);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();

        obj.M1<int>();      // valid
        obj.M2<int>();      // invalid
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,2297,3295);

f_23121_2297_3294(f_23121_2297_2353(code, references: new[] { reference }), f_23121_2641_2784(f_23121_2641_2764(f_23121_2641_2714(ErrorCode.ERR_GenericConstraintNotSatisfiedValType, "M2<int>"), "TestRef.M2<T>()", "?", "T", "int"), 9, 13), f_23121_2941_3028(f_23121_2941_3008(f_23121_2941_2989(ErrorCode.ERR_BindToBogus, "M2<int>"), "T"), 9, 13), f_23121_3191_3275(f_23121_3191_3255(f_23121_3191_3237(ErrorCode.ERR_BogusType, "M2<int>"), ""), 9, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,530,3306);

Microsoft.CodeAnalysis.MetadataReference
f_23121_2017_2065(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2017, 2065);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_2297_2353(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2297, 2353);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2641_2714(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2641, 2714);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2641_2764(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2641, 2764);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2641_2784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2641, 2784);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2941_2989(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2941, 2989);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2941_3008(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2941, 3008);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_2941_3028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2941, 3028);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_3191_3237(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 3191, 3237);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_3191_3255(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 3191, 3255);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_3191_3275(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 3191, 3275);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_2297_3294(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 2297, 3294);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,530,3306);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,530,3306);
}
		}

[Fact]
        public void LoadingUnmanagedTypeModifier_OptionalIsError()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,3318,6089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,3417,4768);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M1<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M1

  .method public hidebysig instance void
          M2<valuetype .ctor (class [mscorlib]System.ValueType modopt([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,4784,4849);

var 
reference = f_23121_4800_4848(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,4865,5064);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();

        obj.M1<int>();      // valid
        obj.M2<int>();      // invalid
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,5080,6078);

f_23121_5080_6077(f_23121_5080_5136(code, references: new[] { reference }), f_23121_5424_5567(f_23121_5424_5547(f_23121_5424_5497(ErrorCode.ERR_GenericConstraintNotSatisfiedValType, "M2<int>"), "TestRef.M2<T>()", "?", "T", "int"), 9, 13), f_23121_5724_5811(f_23121_5724_5791(f_23121_5724_5772(ErrorCode.ERR_BindToBogus, "M2<int>"), "T"), 9, 13), f_23121_5974_6058(f_23121_5974_6038(f_23121_5974_6020(ErrorCode.ERR_BogusType, "M2<int>"), ""), 9, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,3318,6089);

Microsoft.CodeAnalysis.MetadataReference
f_23121_4800_4848(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 4800, 4848);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_5080_5136(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5080, 5136);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5424_5497(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5424, 5497);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5424_5547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5424, 5547);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5424_5567(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5424, 5567);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5724_5772(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5724, 5772);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5724_5791(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5724, 5791);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5724_5811(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5724, 5811);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5974_6020(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5974, 6020);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5974_6038(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5974, 6038);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_5974_6058(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5974, 6058);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_5080_6077(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 5080, 6077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,3318,6089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,3318,6089);
}
		}

[Fact]
        public void LoadingUnmanagedTypeModifier_MoreThanOneModifier()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,6101,8910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,6204,7589);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M1<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M1

  .method public hidebysig instance void
          M2<valuetype .ctor (class [mscorlib]System.ValueType modopt([mscorlib]System.DateTime) modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,7605,7670);

var 
reference = f_23121_7621_7669(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,7686,7885);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();

        obj.M1<int>();      // valid
        obj.M2<int>();      // invalid
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,7901,8899);

f_23121_7901_8898(f_23121_7901_7957(code, references: new[] { reference }), f_23121_8245_8388(f_23121_8245_8368(f_23121_8245_8318(ErrorCode.ERR_GenericConstraintNotSatisfiedValType, "M2<int>"), "TestRef.M2<T>()", "?", "T", "int"), 9, 13), f_23121_8545_8632(f_23121_8545_8612(f_23121_8545_8593(ErrorCode.ERR_BindToBogus, "M2<int>"), "T"), 9, 13), f_23121_8795_8879(f_23121_8795_8859(f_23121_8795_8841(ErrorCode.ERR_BogusType, "M2<int>"), ""), 9, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,6101,8910);

Microsoft.CodeAnalysis.MetadataReference
f_23121_7621_7669(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 7621, 7669);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_7901_7957(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 7901, 7957);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8245_8318(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8245, 8318);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8245_8368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8245, 8368);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8245_8388(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8245, 8388);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8545_8593(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8545, 8593);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8545_8612(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8545, 8612);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8545_8632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8545, 8632);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8795_8841(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8795, 8841);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8795_8859(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8795, 8859);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_8795_8879(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 8795, 8879);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_7901_8898(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 7901, 8898);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,6101,8910);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,6101,8910);
}
		}

[Fact]
        public void LoadingUnmanagedTypeModifier_ModreqWithoutAttribute()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,8922,10914);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,9028,10253);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M1<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M1

  .method public hidebysig instance void
          M2<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,10269,10334);

var 
reference = f_23121_10285_10333(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,10350,10549);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();

        obj.M1<int>();      // valid
        obj.M2<int>();      // invalid
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,10565,10903);

f_23121_10565_10902(f_23121_10565_10621(code, references: new[] { reference }), f_23121_10796_10883(f_23121_10796_10863(f_23121_10796_10844(ErrorCode.ERR_BindToBogus, "M2<int>"), "T"), 9, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,8922,10914);

Microsoft.CodeAnalysis.MetadataReference
f_23121_10285_10333(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10285, 10333);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_10565_10621(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10565, 10621);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_10796_10844(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10796, 10844);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_10796_10863(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10796, 10863);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_10796_10883(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10796, 10883);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_10565_10902(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 10565, 10902);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,8922,10914);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,8922,10914);
}
		}

[Fact]
        public void LoadingUnmanagedTypeModifier_AttributeWithoutModreq()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,10926,12981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,11032,12320);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M1<valuetype .ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M1

  .method public hidebysig instance void
          M2<valuetype .ctor (class [mscorlib]System.ValueType) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
  } // end of method TestRef::M2

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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,12336,12401);

var 
reference = f_23121_12352_12400(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,12417,12616);

var 
code = @"
public class Test
{
    public static void Main()
    {
        var obj = new TestRef();

        obj.M1<int>();      // valid
        obj.M2<int>();      // invalid
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,12632,12970);

f_23121_12632_12969(f_23121_12632_12688(code, references: new[] { reference }), f_23121_12863_12950(f_23121_12863_12930(f_23121_12863_12911(ErrorCode.ERR_BindToBogus, "M2<int>"), "T"), 9, 13));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,10926,12981);

Microsoft.CodeAnalysis.MetadataReference
f_23121_12352_12400(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12352, 12400);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_12632_12688(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12632, 12688);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_12863_12911(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12863, 12911);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_12863_12930(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12863, 12930);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_12863_12950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12863, 12950);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_12632_12969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 12632, 12969);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,10926,12981);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,10926,12981);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfModreqTypeIsNotAvailable_Class()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,12993,13693);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,13105,13270);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class ValueType {}
}
class Test<T> where T : unmanaged
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,13286,13682);

f_23121_13286_13681(f_23121_13286_13314(code), f_23121_13537_13680(f_23121_13537_13660(f_23121_13537_13598(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.Runtime.InteropServices.UnmanagedType"), 8, 25));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,12993,13693);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_13286_13314(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 13286, 13314);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_13537_13598(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 13537, 13598);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_13537_13660(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 13537, 13660);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_13537_13680(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 13537, 13680);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_13286_13681(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 13286, 13681);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,12993,13693);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,12993,13693);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfModreqTypeIsNotAvailable_Method()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,13705,14444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,13818,14007);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class ValueType {}
}
class Test
{
    public void M<T>() where T : unmanaged {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,14023,14433);

f_23121_14023_14432(f_23121_14023_14051(code), f_23121_14287_14431(f_23121_14287_14410(f_23121_14287_14348(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.Runtime.InteropServices.UnmanagedType"), 10, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,13705,14444);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_14023_14051(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14023, 14051);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_14287_14348(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14287, 14348);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_14287_14410(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14287, 14410);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_14287_14431(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14287, 14431);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_14023_14432(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14023, 14432);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,13705,14444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,13705,14444);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfModreqTypeIsNotAvailable_Delegate()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,14456,15252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,14571,14812);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class ValueType {}
    public class IntPtr {}
    public class MulticastDelegate {}
}
public delegate void D<T>() where T : unmanaged;"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,14828,15241);

f_23121_14828_15240(f_23121_14828_14856(code), f_23121_15095_15239(f_23121_15095_15218(f_23121_15095_15156(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.Runtime.InteropServices.UnmanagedType"), 10, 39));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,14456,15252);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_14828_14856(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14828, 14856);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_15095_15156(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 15095, 15156);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_15095_15218(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 15095, 15218);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_15095_15239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 15095, 15239);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_14828_15240(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 14828, 15240);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,14456,15252);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,14456,15252);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfModreqTypeIsNotAvailable_LocalFunction()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,15264,16174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,15384,15743);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class ValueType {}
    public class IntPtr {}
    public class MulticastDelegate {}
}
public class Test
{
    public struct S {}

    public void M()
    {
        void N<T>() where T : unmanaged
        {
        }

        N<S>();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,15759,16163);

f_23121_15759_16162(f_23121_15759_15787(code), f_23121_16017_16161(f_23121_16017_16140(f_23121_16017_16078(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.Runtime.InteropServices.UnmanagedType"), 16, 31));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,15264,16174);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_15759_15787(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 15759, 15787);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16017_16078(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16017, 16078);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16017_16140(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16017, 16140);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16017_16161(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16017, 16161);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_15759_16162(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 15759, 16162);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,15264,16174);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,15264,16174);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfValueTypeIsNotAvailable_Class()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,16186,16939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,16297,16570);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}

    namespace Runtime
    {
        namespace InteropServices
        {
            public class UnmanagedType {}
        }
    }
}
class Test<T> where T : unmanaged
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,16586,16928);

f_23121_16586_16927(f_23121_16586_16614(code), f_23121_16810_16926(f_23121_16810_16905(f_23121_16810_16871(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.ValueType"), 15, 25));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,16186,16939);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_16586_16614(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16586, 16614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16810_16871(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16810, 16871);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16810_16905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16810, 16905);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_16810_16926(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16810, 16926);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_16586_16927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 16586, 16927);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,16186,16939);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,16186,16939);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfValueTypeIsNotAvailable_Method()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,16951,17741);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,17063,17360);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}

    namespace Runtime
    {
        namespace InteropServices
        {
            public class UnmanagedType {}
        }
    }
}
class Test
{
    public void M<T>() where T : unmanaged {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,17376,17730);

f_23121_17376_17729(f_23121_17376_17404(code), f_23121_17612_17728(f_23121_17612_17707(f_23121_17612_17673(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.ValueType"), 17, 34));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,16951,17741);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_17376_17404(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 17376, 17404);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_17612_17673(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 17612, 17673);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_17612_17707(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 17612, 17707);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_17612_17728(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 17612, 17728);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_17376_17729(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 17376, 17729);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,16951,17741);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,16951,17741);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfValueTypeIsNotAvailable_Delegate()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,17753,18600);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,17867,18216);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public class IntPtr {}
    public class MulticastDelegate {}

    namespace Runtime
    {
        namespace InteropServices
        {
            public class UnmanagedType {}
        }
    }
}
public delegate void M<T>() where T : unmanaged;"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,18232,18589);

f_23121_18232_18588(f_23121_18232_18260(code), f_23121_18471_18587(f_23121_18471_18566(f_23121_18471_18532(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.ValueType"), 17, 39));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,17753,18600);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_18232_18260(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 18232, 18260);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_18471_18532(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 18471, 18532);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_18471_18566(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 18471, 18566);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_18471_18587(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 18471, 18587);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_18232_18588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 18232, 18588);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,17753,18600);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,17753,18600);
}
		}

[Fact]
        public void ProperErrorsArePropagatedIfValueTypeIsNotAvailable_LocalFunctions()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,18612,19785);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,18732,19129);

var 
code = @"
namespace System
{
    public class Object {}
    public class Void {}
    public struct Int32 {}

    namespace Runtime
    {
        namespace InteropServices
        {
            public class UnmanagedType {}
        }
    }
}
class Test
{
    public void M()
    {
        void N<T>() where T : unmanaged
        {
        }

        N<int>();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,19145,19774);

f_23121_19145_19773(f_23121_19145_19173(code), f_23121_19361_19472(f_23121_19361_19452(f_23121_19361_19418(ErrorCode.ERR_PredefinedTypeNotFound, "Int32"), "System.ValueType"), 6, 19), f_23121_19656_19772(f_23121_19656_19751(f_23121_19656_19717(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.ValueType"), 20, 31));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,18612,19785);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_19145_19173(string
source)
{
var return_v = CreateEmptyCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19145, 19173);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19361_19418(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19361, 19418);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19361_19452(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19361, 19452);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19361_19472(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19361, 19472);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19656_19717(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19656, 19717);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19656_19751(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19656, 19751);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_19656_19772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19656, 19772);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_19145_19773(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19145, 19773);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,18612,19785);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,18612,19785);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Virtual_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,19797,21425);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,19910,21091);

var 
reference = f_23121_19926_21090(this, @"
public class Parent
{
    public virtual string M<T>() where T : unmanaged => ""Parent"";
}
public class Child : Parent
{
    public override string M<T>() => ""Child"";
}", symbolValidator: module =>
            {
                var parentTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(parentTypeParameter.HasValueTypeConstraint);
                Assert.True(parentTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, parentTypeParameter, module.ContainingAssembly.Name);

                var childTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(childTypeParameter.HasValueTypeConstraint);
                Assert.True(childTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, childTypeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,21107,21414);

f_23121_21107_21413(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Parent().M<int>());
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_21330_21374(f_23121_21330_21351(reference))}, expectedOutput: @"
Parent
Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,19797,21425);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_19926_21090(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 19926, 21090);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_21330_21351(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 21330, 21351);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_21330_21374(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 21330, 21374);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_21107_21413(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 21107, 21413);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,19797,21425);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,19797,21425);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Virtual_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,21437,23228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,21548,22167);

var 
parent = f_23121_21561_22166(this, @"
public class Parent
{
    public virtual string M<T>() where T : unmanaged => ""Parent"";
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,22185,22855);

var 
child = f_23121_22197_22854(this, @"
public class Child : Parent
{
    public override string M<T>() => ""Child"";
}", references: new[] { f_23121_22323_22364(f_23121_22323_22341(parent))}, symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,22871,23217);

f_23121_22871_23216(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Parent().M<int>());
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_23094_23135(f_23121_23094_23112(parent)), f_23121_23137_23177(f_23121_23137_23154(child))}, expectedOutput: @"
Parent
Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,21437,23228);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_21561_22166(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 21561, 22166);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_22323_22341(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 22323, 22341);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_22323_22364(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 22323, 22364);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_22197_22854(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 22197, 22854);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_23094_23112(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 23094, 23112);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_23094_23135(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 23094, 23135);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_23137_23154(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 23137, 23154);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_23137_23177(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 23137, 23177);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_22871_23216(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 22871, 23216);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,21437,23228);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,21437,23228);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Abstract_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,23240,24796);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,23354,24531);

var 
reference = f_23121_23370_24530(this, @"
public abstract class Parent
{
    public abstract string M<T>() where T : unmanaged;
}
public class Child : Parent
{
    public override string M<T>() => ""Child"";
}", symbolValidator: module =>
            {
                var parentTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(parentTypeParameter.HasValueTypeConstraint);
                Assert.True(parentTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, parentTypeParameter, module.ContainingAssembly.Name);

                var childTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(childTypeParameter.HasValueTypeConstraint);
                Assert.True(childTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, childTypeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,24547,24785);

f_23121_24547_24784(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_24712_24756(f_23121_24712_24733(reference))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,23240,24796);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_23370_24530(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 23370, 24530);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_24712_24733(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 24712, 24733);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_24712_24756(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 24712, 24756);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_24547_24784(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 24547, 24784);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,23240,24796);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,23240,24796);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Abstract_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,24808,26527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,24920,25535);

var 
parent = f_23121_24933_25534(this, @"
public abstract class Parent
{
    public abstract string M<T>() where T : unmanaged;
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,25553,26223);

var 
child = f_23121_25565_26222(this, @"
public class Child : Parent
{
    public override string M<T>() => ""Child"";
}", references: new[] { f_23121_25691_25732(f_23121_25691_25709(parent))}, symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,26239,26516);

f_23121_26239_26515(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_26404_26445(f_23121_26404_26422(parent)), f_23121_26447_26487(f_23121_26447_26464(child))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,24808,26527);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_24933_25534(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 24933, 25534);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_25691_25709(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 25691, 25709);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_25691_25732(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 25691, 25732);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_25565_26222(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 25565, 26222);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_26404_26422(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 26404, 26422);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_26404_26445(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 26404, 26445);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_26447_26464(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 26447, 26464);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_26447_26487(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 26447, 26487);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_26239_26515(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 26239, 26515);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,24808,26527);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,24808,26527);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Implicit_Nonvirtual_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,26539,28106);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,26674,27841);

var 
reference = f_23121_26690_27840(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}
public class Child : Parent
{
    public string M<T>() where T : unmanaged => ""Child"";
}", symbolValidator: module =>
            {
                var parentTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(parentTypeParameter.HasValueTypeConstraint);
                Assert.True(parentTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, parentTypeParameter, module.ContainingAssembly.Name);

                var childTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(childTypeParameter.HasValueTypeConstraint);
                Assert.True(childTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, childTypeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,27857,28095);

f_23121_27857_28094(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_28022_28066(f_23121_28022_28043(reference))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,26539,28106);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_26690_27840(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 26690, 27840);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_28022_28043(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 28022, 28043);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_28022_28066(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 28022, 28066);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_27857_28094(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 27857, 28094);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,26539,28106);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,26539,28106);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Implicit_Nonvirtual_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,28118,29848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,28251,28845);

var 
parent = f_23121_28264_28844(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,28863,29544);

var 
child = f_23121_28875_29543(this, @"
public class Child : Parent
{
    public string M<T>() where T : unmanaged => ""Child"";
}", references: new[] { f_23121_29012_29053(f_23121_29012_29030(parent))}, symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,29560,29837);

f_23121_29560_29836(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_29725_29766(f_23121_29725_29743(parent)), f_23121_29768_29808(f_23121_29768_29785(child))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,28118,29848);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_28264_28844(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 28264, 28844);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_29012_29030(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 29012, 29030);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_29012_29053(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 29012, 29053);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_28875_29543(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 28875, 29543);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_29725_29743(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 29725, 29743);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_29725_29766(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 29725, 29766);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_29768_29785(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 29768, 29785);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_29768_29808(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 29768, 29808);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_29560_29836(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 29560, 29836);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,28118,29848);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,28118,29848);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Implicit_Virtual_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,29860,31432);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,29992,31167);

var 
reference = f_23121_30008_31166(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}
public class Child : Parent
{
    public virtual string M<T>() where T : unmanaged => ""Child"";
}", symbolValidator: module =>
            {
                var parentTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(parentTypeParameter.HasValueTypeConstraint);
                Assert.True(parentTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, parentTypeParameter, module.ContainingAssembly.Name);

                var childTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(childTypeParameter.HasValueTypeConstraint);
                Assert.True(childTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, childTypeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,31183,31421);

f_23121_31183_31420(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_31348_31392(f_23121_31348_31369(reference))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,29860,31432);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_30008_31166(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 30008, 31166);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_31348_31369(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 31348, 31369);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_31348_31392(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 31348, 31392);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_31183_31420(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 31183, 31420);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,29860,31432);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,29860,31432);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Implicit_Virtual_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,31444,33179);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,31574,32168);

var 
parent = f_23121_31587_32167(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,32186,32875);

var 
child = f_23121_32198_32874(this, @"
public class Child : Parent
{
    public virtual string M<T>() where T : unmanaged => ""Child"";
}", references: new[] { f_23121_32343_32384(f_23121_32343_32361(parent))}, symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,32891,33168);

f_23121_32891_33167(this, @"
class Program
{
    public static void Main()
    {
        System.Console.WriteLine(new Child().M<int>());
    }
}", references: new[] { f_23121_33056_33097(f_23121_33056_33074(parent)), f_23121_33099_33139(f_23121_33099_33116(child))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,31444,33179);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_31587_32167(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 31587, 32167);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_32343_32361(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 32343, 32361);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_32343_32384(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 32343, 32384);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_32198_32874(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 32198, 32874);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_33056_33074(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 33056, 33074);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_33056_33097(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 33056, 33097);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_33099_33116(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 33099, 33116);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_33099_33139(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 33099, 33139);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_32891_33167(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 32891, 33167);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,31444,33179);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,31444,33179);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Explicit_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,33191,34761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,33315,34469);

var 
reference = f_23121_33331_34468(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}
public class Child : Parent
{
    string Parent.M<T>() => ""Child"";
}", symbolValidator: module =>
            {
                var parentTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(parentTypeParameter.HasValueTypeConstraint);
                Assert.True(parentTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, parentTypeParameter, module.ContainingAssembly.Name);

                var childTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("Parent.M").TypeParameters.Single();
                Assert.True(childTypeParameter.HasValueTypeConstraint);
                Assert.True(childTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, childTypeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,34485,34750);

f_23121_34485_34749(this, @"
class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M<int>());
    }
}", references: new[] { f_23121_34677_34721(f_23121_34677_34698(reference))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,33191,34761);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_33331_34468(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 33331, 34468);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_34677_34698(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 34677, 34698);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_34677_34721(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 34677, 34721);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_34485_34749(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 34485, 34749);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,33191,34761);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,33191,34761);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToOverrides_Interface_Explicit_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,34773,36506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,34895,35489);

var 
parent = f_23121_34908_35488(this, @"
public interface Parent
{
    string M<T>() where T : unmanaged;
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Parent").GetMethod("M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,35507,36175);

var 
child = f_23121_35519_36174(this, @"
public class Child : Parent
{
    string Parent.M<T>() => ""Child"";
}", references: new[] { f_23121_35636_35677(f_23121_35636_35654(parent))}, symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("Parent.M").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,36191,36495);

f_23121_36191_36494(this, @"
class Program
{
    public static void Main()
    {
        Parent obj = new Child();
        System.Console.WriteLine(obj.M<int>());
    }
}", references: new[] { f_23121_36383_36424(f_23121_36383_36401(parent)), f_23121_36426_36466(f_23121_36426_36443(child))}, expectedOutput: "Child");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,34773,36506);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_34908_35488(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 34908, 35488);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_35636_35654(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 35636, 35654);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_35636_35677(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 35636, 35677);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_35519_36174(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 35519, 36174);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_36383_36401(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 36383, 36401);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_36383_36424(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 36383, 36424);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_36426_36443(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 36426, 36443);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_36426_36466(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 36426, 36466);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_36191_36494(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.MetadataReference[]
references,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 36191, 36494);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,34773,36506);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,34773,36506);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToLambda_Compilation()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,36518,38192);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,36620,38181);

f_23121_36620_38180(this, @"
public delegate T D<T>() where T : unmanaged;
public class TestRef
{
    public static void Print<T>(D<T> lambda) where T : unmanaged
    {
        System.Console.WriteLine(lambda());
    }
}
public class Program
{
    static void Test<T>(T arg)  where T : unmanaged
    {
        TestRef.Print(() => arg);
    }
    
    public static void Main()
    {
        Test(5);
    }
}", expectedOutput: "5", options: f_23121_37105_37180(TestOptions.ReleaseExe, MetadataImportOptions.All), symbolValidator: module =>
            {
                var delegateTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("D`1").TypeParameters.Single();
                Assert.True(delegateTypeParameter.HasValueTypeConstraint);
                Assert.True(delegateTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, delegateTypeParameter, module.ContainingAssembly.Name);

                var lambdaTypeParameter = module.ContainingAssembly.GetTypeByMetadataName("Program").GetTypeMember("<>c__DisplayClass0_0").TypeParameters.Single();
                Assert.True(lambdaTypeParameter.HasValueTypeConstraint);
                Assert.True(lambdaTypeParameter.HasUnmanagedTypeConstraint);

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, lambdaTypeParameter, module.ContainingAssembly.Name);
            });
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,36518,38192);

Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23121_37105_37180(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 37105, 37180);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_36620_38180(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 36620, 38180);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,36518,38192);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,36518,38192);
}
		}

[Fact]
        public void UnmanagedTypeModreqIsCopiedToLambda_Reference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,38204,40322);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,38304,39151);

var 
reference = f_23121_38320_39150(this, @"
public delegate T D<T>() where T : unmanaged;
public class TestRef
{
    public static void Print<T>(D<T> lambda) where T : unmanaged
    {
        System.Console.WriteLine(lambda());
    }
}", symbolValidator: module =>
            {
                var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("D`1").TypeParameters.Single();
                Assert.True(typeParameter.HasValueTypeConstraint);
                Assert.True(typeParameter.HasUnmanagedTypeConstraint);
                Assert.False(typeParameter.HasConstructorConstraint);   // .ctor  is an artifact of emit, we will ignore it on importing.

                AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
            })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,39169,40311);

f_23121_39169_40310(this, @"
public class Program
{
    static void Test<T>(T arg)  where T : unmanaged
    {
        TestRef.Print(() => arg);
    }
    
    public static void Main()
    {
        Test(5);
    }
}", expectedOutput: "5", references: new[] { f_23121_39465_39509(f_23121_39465_39486(reference))}, options: f_23121_39539_39614(TestOptions.ReleaseExe, MetadataImportOptions.All), symbolValidator: module =>
                {
                    var typeParameter = module.ContainingAssembly.GetTypeByMetadataName("Program").GetTypeMember("<>c__DisplayClass0_0").TypeParameters.Single();
                    Assert.True(typeParameter.HasValueTypeConstraint);
                    Assert.True(typeParameter.HasUnmanagedTypeConstraint);
                    Assert.False(typeParameter.HasConstructorConstraint);  // .ctor  is an artifact of emit, we will ignore it on importing.

                    AttributeTests_IsUnmanaged.AssertReferencedIsUnmanagedAttribute(Accessibility.Internal, typeParameter, module.ContainingAssembly.Name);
                });
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,38204,40322);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_38320_39150(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 38320, 39150);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_23121_39465_39486(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 39465, 39486);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_39465_39509(Microsoft.CodeAnalysis.Compilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 39465, 39509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
f_23121_39539_39614(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
this_param,Microsoft.CodeAnalysis.MetadataImportOptions
value)
{
var return_v = this_param.WithMetadataImportOptions( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 39539, 39614);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_39169_40310(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,string
expectedOutput,Microsoft.CodeAnalysis.MetadataReference[]
references,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
symbolValidator)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput:expectedOutput, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options:options, symbolValidator:symbolValidator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 39169, 40310);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,38204,40322);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,38204,40322);
}
		}

[Fact]
        public void DuplicateUnmanagedTypeInReferences()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,40334,41214);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,40423,40524);

var 
refCode = @"
namespace System.Runtime.InteropServices
{
    public class UnmanagedType {}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,40540,40601);

var 
ref1 = f_23121_40551_40600(f_23121_40551_40577(refCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,40615,40676);

var 
ref2 = f_23121_40626_40675(f_23121_40626_40652(refCode))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,40692,40755);

var 
user = @"
public class Test<T> where T : unmanaged
{
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,40771,41203);

f_23121_40771_41202(f_23121_40771_40828(user, references: new[] { ref1, ref2 }), f_23121_41058_41201(f_23121_41058_41181(f_23121_41058_41119(ErrorCode.ERR_PredefinedTypeNotFound, "unmanaged"), "System.Runtime.InteropServices.UnmanagedType"), 2, 32));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,40334,41214);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_40551_40577(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40551, 40577);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_40551_40600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40551, 40600);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_40626_40652(string
source)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40626, 40652);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReference
f_23121_40626_40675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
comp)
{
var return_v = comp.EmitToImageReference();
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40626, 40675);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_40771_40828(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40771, 40828);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_41058_41119(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 41058, 41119);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_41058_41181(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 41058, 41181);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_41058_41201(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 41058, 41201);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_40771_41202(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 40771, 41202);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,40334,41214);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,40334,41214);
}
		}

[Fact]
        public void UnmanagedConstraintWithClassConstraint_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,41226,43654);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,41322,42219);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M<class (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,42235,42300);

var 
reference = f_23121_42251_42299(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,42316,42470);

var 
code = @"
public class Test
{
    public static void Main()
    {
        new TestRef().M<int>();
        new TestRef().M<string>();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,42486,43643);

f_23121_42486_43642(f_23121_42486_42542(code, references: new[] { reference }), f_23121_42796_42921(f_23121_42796_42901(f_23121_42796_42857(ErrorCode.ERR_RefConstraintNotSatisfied, "M<int>"), "TestRef.M<T>()", "T", "int"), 6, 23), f_23121_43219_43381(f_23121_43219_43361(f_23121_43219_43294(ErrorCode.ERR_GenericConstraintNotSatisfiedRefType, "M<string>"), "TestRef.M<T>()", "System.ValueType", "T", "string"), 7, 23), f_23121_43534_43623(f_23121_43534_43603(f_23121_43534_43584(ErrorCode.ERR_BindToBogus, "M<string>"), "T"), 7, 23));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,41226,43654);

Microsoft.CodeAnalysis.MetadataReference
f_23121_42251_42299(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42251, 42299);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_42486_42542(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42486, 42542);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_42796_42857(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42796, 42857);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_42796_42901(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42796, 42901);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_42796_42921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42796, 42921);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43219_43294(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43219, 43294);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43219_43361(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43219, 43361);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43219_43381(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43219, 43381);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43534_43584(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43534, 43584);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43534_43603(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43534, 43603);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_43534_43623(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 43534, 43623);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_42486_43642(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 42486, 43642);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,41226,43654);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,41226,43654);
}
		}

[Fact]
        public void UnmanagedConstraintWithConstructorConstraint_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,43666,46364);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,43768,44665);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M<.ctor (class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,44681,44746);

var 
reference = f_23121_44697_44745(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,44762,44916);

var 
code = @"
public class Test
{
    public static void Main()
    {
        new TestRef().M<int>();
        new TestRef().M<string>();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,44932,46353);

f_23121_44932_46352(f_23121_44932_44988(code, references: new[] { reference }), f_23121_45156_45242(f_23121_45156_45222(f_23121_45156_45203(ErrorCode.ERR_BindToBogus, "M<int>"), "T"), 6, 23), f_23121_45540_45702(f_23121_45540_45682(f_23121_45540_45615(ErrorCode.ERR_GenericConstraintNotSatisfiedRefType, "M<string>"), "TestRef.M<T>()", "System.ValueType", "T", "string"), 7, 23), f_23121_45978_46109(f_23121_45978_46089(f_23121_45978_46042(ErrorCode.ERR_NewConstraintNotSatisfied, "M<string>"), "TestRef.M<T>()", "T", "string"), 7, 23), f_23121_46262_46351(f_23121_46262_46331(f_23121_46262_46312(ErrorCode.ERR_BindToBogus, "M<string>"), "T"), 7, 23));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,43666,46364);

Microsoft.CodeAnalysis.MetadataReference
f_23121_44697_44745(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 44697, 44745);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_44932_44988(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 44932, 44988);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45156_45203(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45156, 45203);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45156_45222(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45156, 45222);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45156_45242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45156, 45242);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45540_45615(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45540, 45615);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45540_45682(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45540, 45682);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45540_45702(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45540, 45702);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45978_46042(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45978, 46042);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45978_46089(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45978, 46089);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_45978_46109(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 45978, 46109);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_46262_46312(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 46262, 46312);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_46262_46331(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 46262, 46331);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_46262_46351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 46262, 46351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_44932_46352(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 44932, 46352);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,43666,46364);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,43666,46364);
}
		}

[Fact]
        public void UnmanagedConstraintWithoutValueTypeConstraint_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,46376,48662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,46479,47370);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M<(class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,47386,47451);

var 
reference = f_23121_47402_47450(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,47467,47621);

var 
code = @"
public class Test
{
    public static void Main()
    {
        new TestRef().M<int>();
        new TestRef().M<string>();
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,47637,48651);

f_23121_47637_48650(f_23121_47637_47693(code, references: new[] { reference }), f_23121_47861_47947(f_23121_47861_47927(f_23121_47861_47908(ErrorCode.ERR_BindToBogus, "M<int>"), "T"), 6, 23), f_23121_48245_48407(f_23121_48245_48387(f_23121_48245_48320(ErrorCode.ERR_GenericConstraintNotSatisfiedRefType, "M<string>"), "TestRef.M<T>()", "System.ValueType", "T", "string"), 7, 23), f_23121_48560_48649(f_23121_48560_48629(f_23121_48560_48610(ErrorCode.ERR_BindToBogus, "M<string>"), "T"), 7, 23));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,46376,48662);

Microsoft.CodeAnalysis.MetadataReference
f_23121_47402_47450(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47402, 47450);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_47637_47693(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47637, 47693);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_47861_47908(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47861, 47908);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_47861_47927(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47861, 47927);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_47861_47947(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47861, 47947);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48245_48320(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48245, 48320);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48245_48387(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48245, 48387);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48245_48407(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48245, 48407);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48560_48610(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48560, 48610);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48560_48629(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48560, 48629);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_48560_48649(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 48560, 48649);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_47637_48650(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 47637, 48650);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,46376,48662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,46376,48662);
}
		}

[Fact]
        public void UnmanagedConstraintWithTypeConstraint_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,48674,50593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,48769,49712);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M<valuetype .ctor (class [mscorlib]System.IComparable, class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,49728,49793);

var 
reference = f_23121_49744_49792(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,49809,50023);

var 
code = @"
public class Test
{
    public static void Main()
    {
        // OK
        new TestRef().M<int>();

        // Not IComparable
        new TestRef().M<S1>();
    }

    struct S1{}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,50039,50582);

f_23121_50039_50581(f_23121_50039_50095(code, references: new[] { reference }), f_23121_50400_50562(f_23121_50400_50541(f_23121_50400_50471(ErrorCode.ERR_GenericConstraintNotSatisfiedValType, "M<S1>"), "TestRef.M<T>()", "System.IComparable", "T", "Test.S1"), 10, 23));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,48674,50593);

Microsoft.CodeAnalysis.MetadataReference
f_23121_49744_49792(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 49744, 49792);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_50039_50095(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 50039, 50095);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_50400_50471(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 50400, 50471);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_50400_50541(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 50400, 50541);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_50400_50562(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 50400, 50562);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_50039_50581(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 50039, 50581);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,48674,50593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,48674,50593);
}
		}

[Fact]
        public void UnmanagedConstraintWithNoCtorConstraint_IL()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,50605,52932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,50702,51639);

var 
ilSource = IsUnmanagedAttributeIL + @"
.class public auto ansi beforefieldinit TestRef
       extends [mscorlib]System.Object
{
  .method public hidebysig instance void
          M<valuetype (class [mscorlib]System.IComparable, class [mscorlib]System.ValueType modreq([mscorlib]System.Runtime.InteropServices.UnmanagedType)) T>() cil managed
  {
    .param type T
    .custom instance void System.Runtime.CompilerServices.IsUnmanagedAttribute::.ctor() = ( 01 00 00 00 )
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ret
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
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,51655,51720);

var 
reference = f_23121_51671_51719(ilSource, prependDefaultHeader: false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,51736,51950);

var 
code = @"
public class Test
{
    public static void Main()
    {
        // OK
        new TestRef().M<int>();

        // Not IComparable
        new TestRef().M<S1>();
    }

    struct S1{}
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,51966,52031);

var 
c = f_23121_51974_52030(code, references: new[] { reference })
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52047,52535);

f_23121_52047_52534(
            c, f_23121_52353_52515(f_23121_52353_52494(f_23121_52353_52424(ErrorCode.ERR_GenericConstraintNotSatisfiedValType, "M<S1>"), "TestRef.M<T>()", "System.IComparable", "T", "Test.S1"), 10, 23));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52551,52653);

var 
typeParameter = f_23121_52571_52628(f_23121_52571_52613(f_23121_52571_52588(c), "TestRef"), "M").TypeParameters.Single()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52667,52721);

f_23121_52667_52720(f_23121_52679_52719(typeParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52735,52785);

f_23121_52735_52784(f_23121_52747_52783(typeParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52799,52854);

f_23121_52799_52853(f_23121_52812_52852(typeParameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,52868,52921);

f_23121_52868_52920(f_23121_52881_52919(typeParameter));
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,50605,52932);

Microsoft.CodeAnalysis.MetadataReference
f_23121_51671_51719(string
ilSource,bool
prependDefaultHeader)
{
var return_v = CompileIL( ilSource, prependDefaultHeader:prependDefaultHeader);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 51671, 51719);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_51974_52030(string
source,Microsoft.CodeAnalysis.MetadataReference[]
references)
{
var return_v = CreateCompilation( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references:(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 51974, 52030);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_52353_52424(Microsoft.CodeAnalysis.CSharp.ErrorCode
code,string
squiggledText)
{
var return_v = Diagnostic( (object)code, squiggledText);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52353, 52424);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_52353_52494(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,params object[]
arguments)
{
var return_v = this_param.WithArguments( arguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52353, 52494);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
f_23121_52353_52515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
this_param,int
line,int
column)
{
var return_v = this_param.WithLocation( line, column);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52353, 52515);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_23121_52047_52534(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
c,params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
expected)
{
var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>( expected);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52047, 52534);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
f_23121_52571_52588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.GlobalNamespace;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 52571, 52588);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_23121_52571_52613(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
symbol,string
name)
{
var return_v = symbol.GetTypeMember( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52571, 52613);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_23121_52571_52628(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
symbol,string
name)
{
var return_v = symbol.GetMethod( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52571, 52628);
return return_v;
}


bool
f_23121_52679_52719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param)
{
var return_v = this_param.HasUnmanagedTypeConstraint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 52679, 52719);
return return_v;
}


int
f_23121_52667_52720(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52667, 52720);
return 0;
}


bool
f_23121_52747_52783(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param)
{
var return_v = this_param.HasValueTypeConstraint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 52747, 52783);
return return_v;
}


int
f_23121_52735_52784(bool
condition)
{
Assert.True( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52735, 52784);
return 0;
}


bool
f_23121_52812_52852(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param)
{
var return_v = this_param.HasReferenceTypeConstraint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 52812, 52852);
return return_v;
}


int
f_23121_52799_52853(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52799, 52853);
return 0;
}


bool
f_23121_52881_52919(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
this_param)
{
var return_v = this_param.HasConstructorConstraint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23121, 52881, 52919);
return return_v;
}


int
f_23121_52868_52920(bool
condition)
{
Assert.False( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 52868, 52920);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,50605,52932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,50605,52932);
}
		}

[Fact]
        [WorkItem(25654, "https://github.com/dotnet/roslyn/issues/25654")]
        public void UnmanagedConstraint_PointersTypeInference()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(23121,52944,54046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,53116,53393);

var 
code = @"
unsafe class Program
{
    static void M<T>(T* a) where T : unmanaged
    {
        System.Console.WriteLine(typeof(T).FullName);
    }
    static void Main()
    {
        int x = 5;
        M(&x);

        double y = 5.5;
        M(&y);
    }
}"
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,53409,54035);

f_23121_53409_54034(f_23121_53409_53550(this, code, options: TestOptions.UnsafeReleaseExe, verify: Verification.Fails, expectedOutput: @"
System.Int32
System.Double
"), "Program.Main", @"
{
  // Code size       29 (0x1d)
  .maxstack  1
  .locals init (int V_0, //x
                double V_1) //y
  IL_0000:  ldc.i4.5
  IL_0001:  stloc.0
  IL_0002:  ldloca.s   V_0
  IL_0004:  conv.u
  IL_0005:  call       ""void Program.M<int>(int*)""
  IL_000a:  ldc.r8     5.5
  IL_0013:  stloc.1
  IL_0014:  ldloca.s   V_1
  IL_0016:  conv.u
  IL_0017:  call       ""void Program.M<double>(double*)""
  IL_001c:  ret
}");
DynAbs.Tracing.TraceSender.TraceExitMethod(23121,52944,54046);

Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_53409_53550(Microsoft.CodeAnalysis.CSharp.UnitTests.Emit.UnmanagedTypeModifierTests
this_param,string
source,Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
options,Microsoft.CodeAnalysis.Test.Utilities.Verification
verify,string
expectedOutput)
{
var return_v = this_param.CompileAndVerify( (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options:options, verify:verify, expectedOutput:expectedOutput);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 53409, 53550);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
f_23121_53409_54034(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
this_param,string
qualifiedMethodName,string
expectedIL)
{
var return_v = this_param.VerifyIL( qualifiedMethodName, expectedIL);
DynAbs.Tracing.TraceSender.TraceEndInvocation(23121, 53409, 54034);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23121,52944,54046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,52944,54046);
}
		}

private const string 
IsUnmanagedAttributeIL = @"
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

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.IsUnmanagedAttribute
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

public UnmanagedTypeModifierTests()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(23121,457,56022);
DynAbs.Tracing.TraceSender.TraceExitConstructor(23121,457,56022);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,457,56022);
}


static UnmanagedTypeModifierTests()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23121,457,56022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(23121,54079,56014);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23121,457,56022);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23121,457,56022);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23121,457,56022);
}
}
