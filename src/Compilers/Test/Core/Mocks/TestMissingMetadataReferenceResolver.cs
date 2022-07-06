// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
internal class TestMissingMetadataReferenceResolver : MetadataReferenceResolver
{
internal struct ReferenceAndIdentity
        {

public readonly MetadataReference Reference;

public readonly AssemblyIdentity Identity;

public ReferenceAndIdentity(MetadataReference reference, AssemblyIdentity identity)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25119,692,883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,808,830);

Reference = reference;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,848,868);

Identity = identity;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25119,692,883);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,692,883);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,692,883);
}
		}

public override string ToString()
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,899,1041);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,965,1026);

return $"{f_25119_975_992(Reference)} -> {f_25119_998_1023(Identity)}";
DynAbs.Tracing.TraceSender.TraceExitMethod(25119,899,1041);

string?
f_25119_975_992(Microsoft.CodeAnalysis.MetadataReference
this_param)
{
var return_v = this_param.Display;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25119, 975, 992);
return return_v;
}


string
f_25119_998_1023(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.GetDisplayName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 998, 1023);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,899,1041);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,899,1041);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
static ReferenceAndIdentity(){DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25119,515,1052);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25119,515,1052);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,515,1052);
}
        }

private readonly Dictionary<string, MetadataReference> _map;

public readonly List<ReferenceAndIdentity> ResolutionAttempts ;

public TestMissingMetadataReferenceResolver(Dictionary<string, MetadataReference> map)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25119,1243,1376);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1119,1123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1177,1230);
this.ResolutionAttempts = f_25119_1198_1230();DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1354,1365);

_map = map;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25119,1243,1376);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,1243,1376);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,1243,1376);
}
		}

public override PortableExecutableReference ResolveMissingAssembly(MetadataReference definition, AssemblyIdentity referenceIdentity)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,1388,1922);
Microsoft.CodeAnalysis.MetadataReference reference = default(Microsoft.CodeAnalysis.MetadataReference);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1545,1625);

f_25119_1545_1624(            ResolutionAttempts, f_25119_1568_1623(definition, referenceIdentity));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1641,1790);

string 
nameAndVersion = f_25119_1665_1687(referenceIdentity)+ ((DynAbs.Tracing.TraceSender.Conditional_F1(25119, 1691, 1748)||((f_25119_1691_1716(referenceIdentity)!= AssemblyIdentity.NullVersion &&DynAbs.Tracing.TraceSender.Conditional_F2(25119, 1751, 1783))||DynAbs.Tracing.TraceSender.Conditional_F3(25119, 1786, 1788)))?$", {f_25119_1756_1781(referenceIdentity)}" :"")
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1804,1911);

return (DynAbs.Tracing.TraceSender.Conditional_F1(25119, 1811, 1862)||((f_25119_1811_1862(_map, nameAndVersion, out reference)&&DynAbs.Tracing.TraceSender.Conditional_F2(25119, 1865, 1903))||DynAbs.Tracing.TraceSender.Conditional_F3(25119, 1906, 1910)))?(PortableExecutableReference)reference :null;
DynAbs.Tracing.TraceSender.TraceExitMethod(25119,1388,1922);

Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity
f_25119_1568_1623(Microsoft.CodeAnalysis.MetadataReference
reference,Microsoft.CodeAnalysis.AssemblyIdentity
identity)
{
var return_v = new Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity( reference, identity);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 1568, 1623);
return return_v;
}


int
f_25119_1545_1624(System.Collections.Generic.List<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity>
this_param,Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 1545, 1624);
return 0;
}


string
f_25119_1665_1687(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25119, 1665, 1687);
return return_v;
}


System.Version
f_25119_1691_1716(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.Version ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25119, 1691, 1716);
return return_v;
}


System.Version
f_25119_1756_1781(Microsoft.CodeAnalysis.AssemblyIdentity
this_param)
{
var return_v = this_param.Version;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25119, 1756, 1781);
return return_v;
}


bool
f_25119_1811_1862(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.MetadataReference>
this_param,string
key,out Microsoft.CodeAnalysis.MetadataReference
value)
{
var return_v = this_param.TryGetValue( key, out value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 1811, 1862);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,1388,1922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,1388,1922);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool ResolveMissingAssemblies {get		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,1980,1987);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,1983,1987);
return true;DynAbs.Tracing.TraceSender.TraceExitMethod(25119,1980,1987);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,1980,1987);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,1980,1987);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public override bool Equals(object other) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,2040,2047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,2043,2047);
return true;DynAbs.Tracing.TraceSender.TraceExitMethod(25119,2040,2047);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,2040,2047);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,2040,2047);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override int GetHashCode() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,2092,2096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,2095,2096);
return 1;DynAbs.Tracing.TraceSender.TraceExitMethod(25119,2092,2096);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,2092,2096);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,2092,2096);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string baseFilePath, MetadataReferenceProperties properties) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,2263,2318);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,2266,2318);
return default(ImmutableArray<PortableExecutableReference>);DynAbs.Tracing.TraceSender.TraceExitMethod(25119,2263,2318);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,2263,2318);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,2263,2318);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void VerifyResolutionAttempts(params string[] expected)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25119,2331,2500);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25119,2418,2489);

f_25119_2418_2488(expected, f_25119_2443_2487(ResolutionAttempts, a => a.ToString()));
DynAbs.Tracing.TraceSender.TraceExitMethod(25119,2331,2500);

System.Collections.Generic.IEnumerable<string>
f_25119_2443_2487(System.Collections.Generic.List<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity>
source,System.Func<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity, string>
selector)
{
var return_v = source.Select<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 2443, 2487);
return return_v;
}


bool
f_25119_2418_2488(string[]
expected,System.Collections.Generic.IEnumerable<string>
actual)
{
var return_v = AssertEx.Equal( (System.Collections.Generic.IEnumerable<string>)expected, actual);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 2418, 2488);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25119,2331,2500);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,2331,2500);
}
		}

static TestMissingMetadataReferenceResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25119,419,2507);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25119,419,2507);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25119,419,2507);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25119,419,2507);

System.Collections.Generic.List<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity>
f_25119_1198_1230()
{
var return_v = new System.Collections.Generic.List<Roslyn.Test.Utilities.TestMissingMetadataReferenceResolver.ReferenceAndIdentity>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25119, 1198, 1230);
return return_v;
}

}
}
