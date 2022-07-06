// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslyn.Test.Utilities
{
internal sealed class VirtualizedRelativePathResolver : RelativePathResolver
{
private readonly HashSet<string> _existingFullPaths;

public VirtualizedRelativePathResolver(IEnumerable<string> existingFullPaths, string baseDirectory = null, ImmutableArray<string> searchPaths = default(ImmutableArray<string>))
:base(f_25123_761_786_C(searchPaths.NullToEmpty()) ,baseDirectory)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(25123,564,922);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25123,533,551);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25123,827,911);

_existingFullPaths = f_25123_848_910(existingFullPaths, f_25123_887_909());
DynAbs.Tracing.TraceSender.TraceExitConstructor(25123,564,922);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25123,564,922);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25123,564,922);
}
		}

protected override bool FileExists(string fullPath)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(25123,934,1138);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25123,1064,1127);

return f_25123_1071_1126(_existingFullPaths, f_25123_1099_1125(fullPath));
DynAbs.Tracing.TraceSender.TraceExitMethod(25123,934,1138);

string
f_25123_1099_1125(string
path)
{
var return_v = Path.GetFullPath( path);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25123, 1099, 1125);
return return_v;
}


bool
f_25123_1071_1126(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25123, 1071, 1126);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25123,934,1138);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25123,934,1138);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static VirtualizedRelativePathResolver()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25123,407,1145);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25123,407,1145);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25123,407,1145);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25123,407,1145);

static System.StringComparer
f_25123_887_909()
{
var return_v = StringComparer.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25123, 887, 909);
return return_v;
}


static System.Collections.Generic.HashSet<string>
f_25123_848_910(System.Collections.Generic.IEnumerable<string>
collection,System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( collection, (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25123, 848, 910);
return return_v;
}


static System.Collections.Immutable.ImmutableArray<string>
f_25123_761_786_C(System.Collections.Immutable.ImmutableArray<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(25123, 564, 922);
return return_v;
}

}
}
