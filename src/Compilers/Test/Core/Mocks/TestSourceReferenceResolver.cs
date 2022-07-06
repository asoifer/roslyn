// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
public sealed class TestSourceReferenceResolver : SourceReferenceResolver
{
public static readonly SourceReferenceResolver Default ;

public static SourceReferenceResolver Create(params KeyValuePair<string, string>[] sources)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25121,641,863);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,757,852);

return f_25121_764_851(f_25121_796_850(sources, p => p.Key, p => (object)p.Value));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25121,641,863);

System.Collections.Generic.Dictionary<string, object>
f_25121_796_850(System.Collections.Generic.KeyValuePair<string, string>[]
source,System.Func<System.Collections.Generic.KeyValuePair<string, string>, string>
keySelector,System.Func<System.Collections.Generic.KeyValuePair<string, string>, object>
elementSelector)
{
var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<string, string>,string,object>( keySelector, elementSelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 796, 850);
return return_v;
}


Roslyn.Test.Utilities.TestSourceReferenceResolver
f_25121_764_851(System.Collections.Generic.Dictionary<string, object>
sources)
{
var return_v = new Roslyn.Test.Utilities.TestSourceReferenceResolver( sources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 764, 851);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,641,863);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,641,863);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SourceReferenceResolver Create(params KeyValuePair<string, object>[] sources)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25121,875,1089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,991,1078);

return f_25121_998_1077(f_25121_1030_1076(sources, p => p.Key, p => p.Value));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25121,875,1089);

System.Collections.Generic.Dictionary<string, object>
f_25121_1030_1076(System.Collections.Generic.KeyValuePair<string, object>[]
source,System.Func<System.Collections.Generic.KeyValuePair<string, object>, string>
keySelector,System.Func<System.Collections.Generic.KeyValuePair<string, object>, object>
elementSelector)
{
var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<string, object>,string,object>( keySelector, elementSelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 1030, 1076);
return return_v;
}


Roslyn.Test.Utilities.TestSourceReferenceResolver
f_25121_998_1077(System.Collections.Generic.Dictionary<string, object>
sources)
{
var return_v = new Roslyn.Test.Utilities.TestSourceReferenceResolver( sources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 998, 1077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,875,1089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,875,1089);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SourceReferenceResolver Create(Dictionary<string, string> sources = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25121,1101,1319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1213,1308);

return f_25121_1220_1307(f_25121_1252_1306(sources, p => p.Key, p => (object)p.Value));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25121,1101,1319);

System.Collections.Generic.Dictionary<string, object>
f_25121_1252_1306(System.Collections.Generic.Dictionary<string, string>?
source,System.Func<System.Collections.Generic.KeyValuePair<string, string>, string>
keySelector,System.Func<System.Collections.Generic.KeyValuePair<string, string>, object>
elementSelector)
{
var return_v = source.ToDictionary<System.Collections.Generic.KeyValuePair<string, string>,string,object>( keySelector, elementSelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 1252, 1306);
return return_v;
}


Roslyn.Test.Utilities.TestSourceReferenceResolver
f_25121_1220_1307(System.Collections.Generic.Dictionary<string, object>
sources)
{
var return_v = new Roslyn.Test.Utilities.TestSourceReferenceResolver( sources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 1220, 1307);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,1101,1319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,1101,1319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private readonly Dictionary<string, object> _sources;

private TestSourceReferenceResolver(Dictionary<string, object> sources)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25121,1396,1522);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1375,1383);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1492,1511);

_sources = sources;
DynAbs.Tracing.TraceSender.TraceExitConstructor(25121,1396,1522);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,1396,1522);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,1396,1522);
}
		}

public override string NormalizePath(string path, string baseFilePath) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25121,1605,1612);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1608,1612);
return path;DynAbs.Tracing.TraceSender.TraceExitMethod(25121,1605,1612);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,1605,1612);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,1605,1612);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override string ResolveReference(string path, string baseFilePath) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25121,1699,1764);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1715,1764);
return (DynAbs.Tracing.TraceSender.Conditional_F1(25121, 1715, 1750)||((f_25121_1715_1742_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_sources, 25121, 1715, 1742)?.ContainsKey(path))== true &&DynAbs.Tracing.TraceSender.Conditional_F2(25121, 1753, 1757))||DynAbs.Tracing.TraceSender.Conditional_F3(25121, 1760, 1764)))?path :null;DynAbs.Tracing.TraceSender.TraceExitMethod(25121,1699,1764);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,1699,1764);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,1699,1764);
}
			throw new System.Exception("Slicer error: unreachable code");

bool?
f_25121_1715_1742_I(bool?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 1715, 1742);
return return_v;
}

		}

public override Stream OpenRead(string resolvedPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25121,1777,2196);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1854,2185) || true) && (_sources != null &&(DynAbs.Tracing.TraceSender.Expression_True(25121, 1858, 1898)&&resolvedPath != null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25121,1854,2185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1932,1966);

var 
data = f_25121_1943_1965(_sources, resolvedPath)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,1984,2080);

return f_25121_1991_2079((DynAbs.Tracing.TraceSender.Conditional_F1(25121, 2008, 2024)||(((data is string) &&DynAbs.Tracing.TraceSender.Conditional_F2(25121, 2027, 2063))||DynAbs.Tracing.TraceSender.Conditional_F3(25121, 2066, 2078)))?f_25121_2027_2063(f_25121_2027_2040(), data):(byte[])data);
DynAbs.Tracing.TraceSender.TraceExitCondition(25121,1854,2185);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25121,1854,2185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,2146,2170);

throw f_25121_2152_2169();
DynAbs.Tracing.TraceSender.TraceExitCondition(25121,1854,2185);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(25121,1777,2196);

object
f_25121_1943_1965(System.Collections.Generic.Dictionary<string, object>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25121, 1943, 1965);
return return_v;
}


System.Text.Encoding
f_25121_2027_2040()
{
var return_v = Encoding.UTF8;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25121, 2027, 2040);
return return_v;
}


byte[]
f_25121_2027_2063(System.Text.Encoding
this_param,object
s)
{
var return_v = this_param.GetBytes( (string)s);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 2027, 2063);
return return_v;
}


System.IO.MemoryStream
f_25121_1991_2079(byte[]
buffer)
{
var return_v = new System.IO.MemoryStream( buffer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 1991, 2079);
return return_v;
}


System.IO.IOException
f_25121_2152_2169()
{
var return_v = new System.IO.IOException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 2152, 2169);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,1777,2196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,1777,2196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override bool Equals(object other) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25121,2250,2281);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,2253,2281);
return f_25121_2253_2281(this, other);DynAbs.Tracing.TraceSender.TraceExitMethod(25121,2250,2281);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,2250,2281);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,2250,2281);
}
			throw new System.Exception("Slicer error: unreachable code");

bool
f_25121_2253_2281(Roslyn.Test.Utilities.TestSourceReferenceResolver
objA,object
objB)
{
var return_v = ReferenceEquals( (object)objA, objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 2253, 2281);
return return_v;
}

		}

public override int GetHashCode() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(25121,2328,2363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,2331,2363);
return f_25121_2331_2363(this);DynAbs.Tracing.TraceSender.TraceExitMethod(25121,2328,2363);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25121,2328,2363);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,2328,2363);
}
			throw new System.Exception("Slicer error: unreachable code");

int
f_25121_2331_2363(Roslyn.Test.Utilities.TestSourceReferenceResolver
o)
{
var return_v = RuntimeHelpers.GetHashCode( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 2331, 2363);
return return_v;
}

		}

static TestSourceReferenceResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25121,435,2371);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25121,572,628);
Default = f_25121_582_628(sources: null);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25121,435,2371);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25121,435,2371);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25121,435,2371);

static Roslyn.Test.Utilities.TestSourceReferenceResolver
f_25121_582_628(System.Collections.Generic.Dictionary<string, object>
sources)
{
var return_v = new Roslyn.Test.Utilities.TestSourceReferenceResolver( sources: sources);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25121, 582, 628);
return return_v;
}

}
}
