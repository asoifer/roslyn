// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
public abstract class CompilationReference : MetadataReference, IEquatable<CompilationReference>
{
public Compilation Compilation {
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(427,627,658);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,633,656);

return f_427_640_655();
DynAbs.Tracing.TraceSender.TraceExitMethod(427,627,658);

Microsoft.CodeAnalysis.Compilation
f_427_640_655()
{
var return_v = CompilationCore;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 640, 655);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,594,660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,594,660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal abstract Compilation CompilationCore {get; }

internal CompilationReference(MetadataReferenceProperties properties)
:base(f_427_826_836_C(properties) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(427,736,931);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,862,920);

f_427_862_919(properties.Kind != MetadataImageKind.Module);
DynAbs.Tracing.TraceSender.TraceExitConstructor(427,736,931);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,736,931);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,736,931);
}
		}

internal static MetadataReferenceProperties GetProperties(Compilation compilation, ImmutableArray<string> aliases, bool embedInteropTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(427,943,1743);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1106,1231) || true) && (compilation == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,1106,1231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1163,1216);

throw f_427_1169_1215(nameof(compilation));
DynAbs.Tracing.TraceSender.TraceExitCondition(427,1106,1231);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1247,1413) || true) && (f_427_1251_1275(compilation))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,1247,1413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1309,1398);

throw f_427_1315_1397(f_427_1341_1396());
DynAbs.Tracing.TraceSender.TraceExitCondition(427,1247,1413);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1429,1621) || true) && (f_427_1433_1463(f_427_1433_1452(compilation))== OutputKind.NetModule)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,1429,1621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1521,1606);

throw f_427_1527_1605(f_427_1553_1604());
DynAbs.Tracing.TraceSender.TraceExitCondition(427,1429,1621);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,1637,1732);

return f_427_1644_1731(MetadataImageKind.Assembly, aliases, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(427,943,1743);

System.ArgumentNullException
f_427_1169_1215(string
paramName)
{
var return_v = new System.ArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 1169, 1215);
return return_v;
}


bool
f_427_1251_1275(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.IsSubmission;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 1251, 1275);
return return_v;
}


string
f_427_1341_1396()
{
var return_v = CodeAnalysisResources.CannotCreateReferenceToSubmission;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 1341, 1396);
return return_v;
}


System.NotSupportedException
f_427_1315_1397(string
message)
{
var return_v = new System.NotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 1315, 1397);
return return_v;
}


Microsoft.CodeAnalysis.CompilationOptions
f_427_1433_1452(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 1433, 1452);
return return_v;
}


Microsoft.CodeAnalysis.OutputKind
f_427_1433_1463(Microsoft.CodeAnalysis.CompilationOptions
this_param)
{
var return_v = this_param.OutputKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 1433, 1463);
return return_v;
}


string
f_427_1553_1604()
{
var return_v = CodeAnalysisResources.CannotCreateReferenceToModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 1553, 1604);
return return_v;
}


System.NotSupportedException
f_427_1527_1605(string
message)
{
var return_v = new System.NotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 1527, 1605);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_1644_1731(Microsoft.CodeAnalysis.MetadataImageKind
kind,System.Collections.Immutable.ImmutableArray<string>
aliases,bool
embedInteropTypes)
{
var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties( kind, aliases, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 1644, 1731);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,943,1743);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,943,1743);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public new CompilationReference WithAliases(IEnumerable<string> aliases)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,2056,2225);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,2153,2214);

return f_427_2160_2213(this, f_427_2177_2212(aliases));
DynAbs.Tracing.TraceSender.TraceExitMethod(427,2056,2225);

System.Collections.Immutable.ImmutableArray<string>
f_427_2177_2212(System.Collections.Generic.IEnumerable<string>
items)
{
var return_v = ImmutableArray.CreateRange( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 2177, 2212);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_427_2160_2213(Microsoft.CodeAnalysis.CompilationReference
this_param,System.Collections.Immutable.ImmutableArray<string>
aliases)
{
var return_v = this_param.WithAliases( aliases);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 2160, 2213);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,2056,2225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,2056,2225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public new CompilationReference WithAliases(ImmutableArray<string> aliases)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,2538,2704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,2638,2693);

return f_427_2645_2692(this, f_427_2660_2670().WithAliases(aliases));
DynAbs.Tracing.TraceSender.TraceExitMethod(427,2538,2704);

Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_2660_2670()
{
var return_v = Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 2660, 2670);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_427_2645_2692(Microsoft.CodeAnalysis.CompilationReference
this_param,Microsoft.CodeAnalysis.MetadataReferenceProperties
properties)
{
var return_v = this_param.WithProperties( properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 2645, 2692);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,2538,2704);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,2538,2704);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public new CompilationReference WithEmbedInteropTypes(bool value)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,3081,3245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,3171,3234);

return f_427_3178_3233(this, f_427_3193_3203().WithEmbedInteropTypes(value));
DynAbs.Tracing.TraceSender.TraceExitMethod(427,3081,3245);

Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_3193_3203()
{
var return_v = Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 3193, 3203);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_427_3178_3233(Microsoft.CodeAnalysis.CompilationReference
this_param,Microsoft.CodeAnalysis.MetadataReferenceProperties
properties)
{
var return_v = this_param.WithProperties( properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 3178, 3233);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,3081,3245);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,3081,3245);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public new CompilationReference WithProperties(MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,3622,4085);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,3733,3827) || true) && (properties == f_427_3751_3766(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,3733,3827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,3800,3812);

return this;
DynAbs.Tracing.TraceSender.TraceExitCondition(427,3733,3827);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,3843,4020) || true) && (properties.Kind == MetadataImageKind.Module)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,3843,4020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,3924,4005);

throw f_427_3930_4004(f_427_3952_4003());
DynAbs.Tracing.TraceSender.TraceExitCondition(427,3843,4020);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4036,4074);

return f_427_4043_4073(this, properties);
DynAbs.Tracing.TraceSender.TraceExitMethod(427,3622,4085);

Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_3751_3766(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 3751, 3766);
return return_v;
}


string
f_427_3952_4003()
{
var return_v = CodeAnalysisResources.CannotCreateReferenceToModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 3952, 4003);
return return_v;
}


System.ArgumentException
f_427_3930_4004(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 3930, 4004);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_427_4043_4073(Microsoft.CodeAnalysis.CompilationReference
this_param,Microsoft.CodeAnalysis.MetadataReferenceProperties
properties)
{
var return_v = this_param.WithPropertiesImpl( properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 4043, 4073);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,3622,4085);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,3622,4085);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal sealed override MetadataReference WithPropertiesImplReturningMetadataReference(MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,4097,4495);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4249,4430) || true) && (properties.Kind == MetadataImageKind.Module)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,4249,4430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4330,4415);

throw f_427_4336_4414(f_427_4362_4413());
DynAbs.Tracing.TraceSender.TraceExitCondition(427,4249,4430);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4446,4484);

return f_427_4453_4483(this, properties);
DynAbs.Tracing.TraceSender.TraceExitMethod(427,4097,4495);

string
f_427_4362_4413()
{
var return_v = CodeAnalysisResources.CannotCreateReferenceToModule;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 4362, 4413);
return return_v;
}


System.NotSupportedException
f_427_4336_4414(string
message)
{
var return_v = new System.NotSupportedException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 4336, 4414);
return return_v;
}


Microsoft.CodeAnalysis.CompilationReference
f_427_4453_4483(Microsoft.CodeAnalysis.CompilationReference
this_param,Microsoft.CodeAnalysis.MetadataReferenceProperties
properties)
{
var return_v = this_param.WithPropertiesImpl( properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 4453, 4483);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,4097,4495);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,4097,4495);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal abstract CompilationReference WithPropertiesImpl(MetadataReferenceProperties properties);

public override string? Display
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,4673,4756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4709,4741);

return f_427_4716_4740(f_427_4716_4727());
DynAbs.Tracing.TraceSender.TraceExitMethod(427,4673,4756);

Microsoft.CodeAnalysis.Compilation
f_427_4716_4727()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 4716, 4727);
return return_v;
}


string?
f_427_4716_4740(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 4716, 4740);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,4617,4767);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,4617,4767);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public bool Equals(CompilationReference? other)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,4779,5242);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4851,4930) || true) && (other == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,4851,4930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4902,4915);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(427,4851,4930);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,4946,5046) || true) && (f_427_4950_4985(this, other))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(427,4946,5046);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,5019,5031);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(427,4946,5046);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,5121,5231);

return f_427_5128_5178(f_427_5142_5158(this), f_427_5160_5177(other))&&(DynAbs.Tracing.TraceSender.Expression_True(427, 5128, 5230)&&f_427_5182_5230(f_427_5196_5211(this), f_427_5213_5229(other)));
DynAbs.Tracing.TraceSender.TraceExitMethod(427,4779,5242);

bool
f_427_4950_4985(Microsoft.CodeAnalysis.CompilationReference
objA,Microsoft.CodeAnalysis.CompilationReference
objB)
{
var return_v = object.ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 4950, 4985);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_427_5142_5158(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 5142, 5158);
return return_v;
}


Microsoft.CodeAnalysis.Compilation
f_427_5160_5177(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 5160, 5177);
return return_v;
}


bool
f_427_5128_5178(Microsoft.CodeAnalysis.Compilation
objA,Microsoft.CodeAnalysis.Compilation
objB)
{
var return_v = object.Equals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 5128, 5178);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_5196_5211(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 5196, 5211);
return return_v;
}


Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_5213_5229(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 5213, 5229);
return return_v;
}


bool
f_427_5182_5230(Microsoft.CodeAnalysis.MetadataReferenceProperties
objA,Microsoft.CodeAnalysis.MetadataReferenceProperties
objB)
{
var return_v = object.Equals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 5182, 5230);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,4779,5242);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,4779,5242);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object? obj)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,5254,5373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,5319,5362);

return f_427_5326_5361(this, obj as CompilationReference);
DynAbs.Tracing.TraceSender.TraceExitMethod(427,5254,5373);

bool
f_427_5326_5361(Microsoft.CodeAnalysis.CompilationReference
this_param,object?
other)
{
var return_v = this_param.Equals( (Microsoft.CodeAnalysis.CompilationReference?)other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 5326, 5361);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,5254,5373);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,5254,5373);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(427,5385,5537);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(427,5443,5526);

return f_427_5450_5525(f_427_5463_5493(f_427_5463_5479(this)), this.Properties.GetHashCode());
DynAbs.Tracing.TraceSender.TraceExitMethod(427,5385,5537);

Microsoft.CodeAnalysis.Compilation
f_427_5463_5479(Microsoft.CodeAnalysis.CompilationReference
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(427, 5463, 5479);
return return_v;
}


int
f_427_5463_5493(Microsoft.CodeAnalysis.Compilation
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 5463, 5493);
return return_v;
}


int
f_427_5450_5525(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 5450, 5525);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(427,5385,5537);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,5385,5537);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CompilationReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(427,481,5544);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(427,481,5544);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(427,481,5544);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(427,481,5544);

static int
f_427_862_919(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(427, 862, 919);
return 0;
}


static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_427_826_836_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(427, 736, 931);
return return_v;
}

}
}
