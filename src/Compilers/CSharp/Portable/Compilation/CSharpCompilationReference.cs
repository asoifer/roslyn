// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
[DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal sealed class CSharpCompilationReference : CompilationReference
{
public new CSharpCompilation Compilation {get; }

internal override Compilation CompilationCore
{
get 		{
			try
{ DynAbs.Tracing.TraceSender.TraceEnterMethod(10915,810,842);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,816,840);

return f_10915_823_839(this);
DynAbs.Tracing.TraceSender.TraceExitMethod(10915,810,842);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10915_823_839(Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10915, 823, 839);
return return_v;
}

}
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10915,740,853);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,740,853);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public CSharpCompilationReference(
            CSharpCompilation compilation,
            ImmutableArray<string> aliases = default(ImmutableArray<string>),
            bool embedInteropTypes = false)
:base(f_10915_1460_1514_C(f_10915_1460_1514(compilation, aliases, embedInteropTypes)) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10915,1237,1582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,679,728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,1540,1571);

this.Compilation = compilation;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10915,1237,1582);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10915,1237,1582);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,1237,1582);
}
		}

private CSharpCompilationReference(CSharpCompilation compilation, MetadataReferenceProperties properties)
:base(f_10915_1720_1730_C(properties) )
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10915,1594,1798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,679,728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,1756,1787);

this.Compilation = compilation;
DynAbs.Tracing.TraceSender.TraceExitConstructor(10915,1594,1798);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10915,1594,1798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,1594,1798);
}
		}

internal override CompilationReference WithPropertiesImpl(MetadataReferenceProperties properties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10915,1810,2006);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,1932,1995);

return f_10915_1939_1994(f_10915_1970_1981(), properties);
DynAbs.Tracing.TraceSender.TraceExitMethod(10915,1810,2006);

Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10915_1970_1981()
{
var return_v = Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10915, 1970, 1981);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
f_10915_1939_1994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.MetadataReferenceProperties
properties)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference( compilation, properties);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10915, 1939, 1994);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10915,1810,2006);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,1810,2006);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private string GetDebuggerDisplay()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10915,2018,2157);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10915,2078,2146);

return f_10915_2085_2113()+ f_10915_2116_2145(f_10915_2116_2132(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(10915,2018,2157);

string
f_10915_2085_2113()
{
var return_v = CSharpResources.CompilationC ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10915, 2085, 2113);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10915_2116_2132(Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
this_param)
{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10915, 2116, 2132);
return return_v;
}


string?
f_10915_2116_2145(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param)
{
var return_v = this_param.AssemblyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10915, 2116, 2145);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10915,2018,2157);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,2018,2157);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CSharpCompilationReference()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10915,442,2164);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10915,442,2164);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10915,442,2164);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10915,442,2164);

static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_10915_1460_1514(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,System.Collections.Immutable.ImmutableArray<string>
aliases,bool
embedInteropTypes)
{
var return_v = GetProperties( (Microsoft.CodeAnalysis.Compilation)compilation, aliases, embedInteropTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10915, 1460, 1514);
return return_v;
}


static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_10915_1460_1514_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10915, 1237, 1582);
return return_v;
}


static Microsoft.CodeAnalysis.MetadataReferenceProperties
f_10915_1720_1730_C(Microsoft.CodeAnalysis.MetadataReferenceProperties
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10915, 1594, 1798);
return return_v;
}

}
}
