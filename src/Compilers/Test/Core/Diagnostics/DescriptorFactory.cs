// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
public static class DescriptorFactory
{
public static DiagnosticDescriptor CreateSimpleDescriptor(string id, params string[] additionalCustomTags)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25071,1535,1995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25071,1666,1762);

var 
customTags = f_25071_1683_1761(f_25071_1683_1751(additionalCustomTags, WellKnownDiagnosticTags.NotConfigurable))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25071,1776,1984);

return f_25071_1783_1983(id, title: "", messageFormat: id, category: "", defaultSeverity: DiagnosticSeverity.Hidden, isEnabledByDefault: true, customTags: customTags);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25071,1535,1995);

System.Collections.Generic.IEnumerable<string>
f_25071_1683_1751(string[]
source,string
value)
{
var return_v = source.Concat<string>( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25071, 1683, 1751);
return return_v;
}


string[]
f_25071_1683_1761(System.Collections.Generic.IEnumerable<string>
source)
{
var return_v = source.AsArray<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25071, 1683, 1761);
return return_v;
}


Microsoft.CodeAnalysis.DiagnosticDescriptor
f_25071_1783_1983(string
id,string
title,string
messageFormat,string
category,Microsoft.CodeAnalysis.DiagnosticSeverity
defaultSeverity,bool
isEnabledByDefault,params string[]
customTags)
{
var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor( id, title: title, messageFormat: messageFormat, category: category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25071, 1783, 1983);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25071,1535,1995);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25071,1535,1995);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DescriptorFactory()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25071,469,2002);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25071,469,2002);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25071,469,2002);
}

}
}
