// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Roslyn.Test.Utilities.TestGenerators
{
internal class SingleFileTestGenerator : ISourceGenerator
{
private readonly string _content;

private readonly string _hintName;

public SingleFileTestGenerator(string content, string hintName = "generatedFile")
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,573,744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,508,516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,551,560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,679,698);

_content = content;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,712,733);

_hintName = hintName;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,573,744);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,573,744);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,573,744);
}
		}

public void Execute(GeneratorExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,756,922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,835,911);

context.AddSource(this._hintName,f_25128_869_909(_content, f_25128_895_908()));
DynAbs.Tracing.TraceSender.TraceExitMethod(25128,756,922);

System.Text.Encoding
f_25128_895_908()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 895, 908);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_25128_869_909(string
text,System.Text.Encoding
encoding)
{
var return_v = SourceText.From( text, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 869, 909);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,756,922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,756,922);
}
		}

public void Initialize(GeneratorInitializationContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,934,1018);
DynAbs.Tracing.TraceSender.TraceExitMethod(25128,934,1018);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,934,1018);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,934,1018);
}
		}

static SingleFileTestGenerator()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,410,1025);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,410,1025);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,410,1025);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,410,1025);
}
internal class SingleFileTestGenerator2 : SingleFileTestGenerator
{
public SingleFileTestGenerator2(string content, string hintName = "generatedFile") :base(f_25128_1205_1212_C(content) ,hintName)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,1115,1245);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,1115,1245);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,1115,1245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,1115,1245);
}
		}

static SingleFileTestGenerator2()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,1033,1252);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,1033,1252);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,1033,1252);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,1033,1252);

static string
f_25128_1205_1212_C(string
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25128, 1115, 1245);
return return_v;
}

}
internal class CallbackGenerator : ISourceGenerator
{
private readonly Action<GeneratorInitializationContext> _onInit;

private readonly Action<GeneratorExecutionContext> _onExecute;

private readonly string? _source;

public CallbackGenerator(Action<GeneratorInitializationContext> onInit, Action<GeneratorExecutionContext> onExecute, string? source = "")
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,1519,1777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1384,1391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1453,1463);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1499,1506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1681,1698);

_onInit = onInit;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1712,1735);

_onExecute = onExecute;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1749,1766);

_source = source;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,1519,1777);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,1519,1777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,1519,1777);
}
		}

public void Execute(GeneratorExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,1789,2070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1868,1888);

f_25128_1868_1887(this, context);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1902,2059) || true) && (!f_25128_1907_1941(_source))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25128,1902,2059);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,1975,2044);

context.AddSource("source",f_25128_2003_2042(_source, f_25128_2028_2041()));
DynAbs.Tracing.TraceSender.TraceExitCondition(25128,1902,2059);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25128,1789,2070);

int
f_25128_1868_1887(Roslyn.Test.Utilities.TestGenerators.CallbackGenerator
this_param,Microsoft.CodeAnalysis.GeneratorExecutionContext
obj)
{
this_param._onExecute( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 1868, 1887);
return 0;
}


bool
f_25128_1907_1941(string?
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 1907, 1941);
return return_v;
}


System.Text.Encoding
f_25128_2028_2041()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 2028, 2041);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_25128_2003_2042(string
text,System.Text.Encoding
encoding)
{
var return_v = SourceText.From( text, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 2003, 2042);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,1789,2070);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,1789,2070);
}
		}

public void Initialize(GeneratorInitializationContext context) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,2143,2162);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,2146,2162);
f_25128_2146_2162(this, context);DynAbs.Tracing.TraceSender.TraceExitMethod(25128,2143,2162);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,2143,2162);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2143,2162);
}

int
f_25128_2146_2162(Roslyn.Test.Utilities.TestGenerators.CallbackGenerator
this_param,Microsoft.CodeAnalysis.GeneratorInitializationContext
obj)
{
this_param._onInit( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 2146, 2162);
return 0;
}

		}

static CallbackGenerator()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,1260,2170);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,1260,2170);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,1260,2170);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,1260,2170);
}
internal class CallbackGenerator2 : CallbackGenerator
{
public CallbackGenerator2(Action<GeneratorInitializationContext> onInit, Action<GeneratorExecutionContext> onExecute, string? source = "") :base(f_25128_2394_2400_C(onInit) ,onExecute,source)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,2248,2442);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,2248,2442);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,2248,2442);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2248,2442);
}
		}

static CallbackGenerator2()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,2178,2449);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,2178,2449);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2178,2449);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,2178,2449);

static System.Action<Microsoft.CodeAnalysis.GeneratorInitializationContext>
f_25128_2394_2400_C(System.Action<Microsoft.CodeAnalysis.GeneratorInitializationContext>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25128, 2248, 2442);
return return_v;
}

}
internal class AdditionalFileAddedGenerator : ISourceGenerator
{
public bool CanApplyChanges {get; set; }

public void Execute(GeneratorExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,2597,2867);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,2676,2856);
foreach(var file in f_25128_2697_2720_I(context.AdditionalFiles) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25128,2676,2856);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,2754,2841);

context.AddSource(f_25128_2772_2803(this, f_25128_2793_2802(file)),f_25128_2805_2839("", f_25128_2825_2838()));
DynAbs.Tracing.TraceSender.TraceExitCondition(25128,2676,2856);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25128,1,181);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25128,1,181);
}DynAbs.Tracing.TraceSender.TraceExitMethod(25128,2597,2867);

string
f_25128_2793_2802(Microsoft.CodeAnalysis.AdditionalText
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 2793, 2802);
return return_v;
}


string
f_25128_2772_2803(Roslyn.Test.Utilities.TestGenerators.AdditionalFileAddedGenerator
this_param,string
path)
{
var return_v = this_param.GetGeneratedFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 2772, 2803);
return return_v;
}


System.Text.Encoding
f_25128_2825_2838()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 2825, 2838);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_25128_2805_2839(string
text,System.Text.Encoding
encoding)
{
var return_v = SourceText.From( text, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 2805, 2839);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
f_25128_2697_2720_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 2697, 2720);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,2597,2867);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2597,2867);
}
		}

public void Initialize(GeneratorInitializationContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,2879,3033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,2966,3022);

context.RegisterForAdditionalFileChanges(UpdateContext);
DynAbs.Tracing.TraceSender.TraceExitMethod(25128,2879,3033);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,2879,3033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2879,3033);
}
		}

bool UpdateContext(GeneratorEditContext context, AdditionalFileEdit edit)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,3045,3426);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3143,3388) || true) && (edit is AdditionalFileAddedEdit add &&(DynAbs.Tracing.TraceSender.Expression_True(25128, 3147, 3201)&&f_25128_3186_3201()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25128,3143,3388);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3235,3343);

f_25128_3235_3342(                context.AdditionalSources, f_25128_3265_3305(this, f_25128_3286_3304(f_25128_3286_3299(add))), f_25128_3307_3341("", f_25128_3327_3340()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3361,3373);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(25128,3143,3388);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3402,3415);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(25128,3045,3426);

bool
f_25128_3186_3201()
{
var return_v = CanApplyChanges;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 3186, 3201);
return return_v;
}


Microsoft.CodeAnalysis.AdditionalText
f_25128_3286_3299(Microsoft.CodeAnalysis.AdditionalFileAddedEdit
this_param)
{
var return_v = this_param.AddedText;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 3286, 3299);
return return_v;
}


string
f_25128_3286_3304(Microsoft.CodeAnalysis.AdditionalText
this_param)
{
var return_v = this_param.Path;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 3286, 3304);
return return_v;
}


string
f_25128_3265_3305(Roslyn.Test.Utilities.TestGenerators.AdditionalFileAddedGenerator
this_param,string
path)
{
var return_v = this_param.GetGeneratedFileName( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3265, 3305);
return return_v;
}


System.Text.Encoding
f_25128_3327_3340()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 3327, 3340);
return return_v;
}


Microsoft.CodeAnalysis.Text.SourceText
f_25128_3307_3341(string
text,System.Text.Encoding
encoding)
{
var return_v = SourceText.From( text, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3307, 3341);
return return_v;
}


int
f_25128_3235_3342(Microsoft.CodeAnalysis.AdditionalSourcesCollection
this_param,string
hintName,Microsoft.CodeAnalysis.Text.SourceText
source)
{
this_param.Add( hintName, source);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3235, 3342);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,3045,3426);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,3045,3426);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetGeneratedFileName(string path) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,3487,3586);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3490,3586);
return $"{f_25128_3493_3574(f_25128_3526_3573(path, '\\', Path.DirectorySeparatorChar))}.generated";DynAbs.Tracing.TraceSender.TraceExitMethod(25128,3487,3586);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,3487,3586);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,3487,3586);
}
			throw new System.Exception("Slicer error: unreachable code");

string
f_25128_3526_3573(string
this_param,char
oldChar,char
newChar)
{
var return_v = this_param.Replace( oldChar, newChar);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3526, 3573);
return return_v;
}


string?
f_25128_3493_3574(string
path)
{
var return_v = Path.GetFileNameWithoutExtension( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3493, 3574);
return return_v;
}

		}

public AdditionalFileAddedGenerator()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,2457,3594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,2536,2585);
this.CanApplyChanges = true;DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,2457,3594);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2457,3594);
}


static AdditionalFileAddedGenerator()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,2457,3594);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,2457,3594);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,2457,3594);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,2457,3594);
}
internal class InMemoryAdditionalText : AdditionalText
{
private readonly SourceText _content;

public InMemoryAdditionalText(string path, string content)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25128,3722,3893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3701,3709);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3905,3941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3805,3817);

Path = path;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,3831,3882);

_content = f_25128_3842_3881(content, f_25128_3867_3880());
DynAbs.Tracing.TraceSender.TraceExitConstructor(25128,3722,3893);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,3722,3893);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,3722,3893);
}
		}

public override string Path {get; }

public override SourceText GetText(CancellationToken cancellationToken = default) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25128,4035,4046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25128,4038,4046);
return _content;DynAbs.Tracing.TraceSender.TraceExitMethod(25128,4035,4046);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25128,4035,4046);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,4035,4046);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static InMemoryAdditionalText()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25128,3602,4056);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25128,3602,4056);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25128,3602,4056);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25128,3602,4056);

static System.Text.Encoding
f_25128_3867_3880()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25128, 3867, 3880);
return return_v;
}


static Microsoft.CodeAnalysis.Text.SourceText
f_25128_3842_3881(string
text,System.Text.Encoding
encoding)
{
var return_v = SourceText.From( text, encoding);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25128, 3842, 3881);
return return_v;
}

}
}
