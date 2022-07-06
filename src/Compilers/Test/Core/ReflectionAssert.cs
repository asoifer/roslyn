// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using System.Reflection;

namespace Roslyn.Test.Utilities
{
public static class ReflectionAssert
{
public static void AssertPublicAndInternalFieldsAndProperties(Type targetType, params string[] expectedFieldsAndProperties)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25040,385,1202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25040,533,665);

var 
fields = f_25040_546_664(targetType, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25040,679,819);

var 
properties = f_25040_696_818(targetType, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25040,833,1089);

var 
fieldsAndProps = f_25040_854_1088(f_25040_854_1037(f_25040_854_905(f_25040_854_885(fields, f => !f.IsPrivate), f => f.Name), f_25040_948_1036(f_25040_948_1016(                                 properties, p => p.GetMethod != null && !p.GetMethod.IsPrivate), p => p.Name)), s => s)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25040,1105,1191);

f_25040_1105_1190(expectedFieldsAndProperties, fieldsAndProps, itemSeparator: "\r\n");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25040,385,1202);

System.Reflection.FieldInfo[]
f_25040_546_664(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetFields( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 546, 664);
return return_v;
}


System.Reflection.PropertyInfo[]
f_25040_696_818(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetProperties( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 696, 818);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>
f_25040_854_885(System.Reflection.FieldInfo[]
source,System.Func<System.Reflection.FieldInfo, bool>
predicate)
{
var return_v = source.Where<System.Reflection.FieldInfo>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 854, 885);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25040_854_905(System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo>
source,System.Func<System.Reflection.FieldInfo, string>
selector)
{
var return_v = source.Select<System.Reflection.FieldInfo,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 854, 905);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>
f_25040_948_1016(System.Reflection.PropertyInfo[]
source,System.Func<System.Reflection.PropertyInfo, bool>
predicate)
{
var return_v = source.Where<System.Reflection.PropertyInfo>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 948, 1016);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25040_948_1036(System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>
source,System.Func<System.Reflection.PropertyInfo, string>
selector)
{
var return_v = source.Select<System.Reflection.PropertyInfo,string>( selector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 948, 1036);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25040_854_1037(System.Collections.Generic.IEnumerable<string>
first,System.Collections.Generic.IEnumerable<string>
second)
{
var return_v = first.Concat<string>( second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 854, 1037);
return return_v;
}


System.Linq.IOrderedEnumerable<string>
f_25040_854_1088(System.Collections.Generic.IEnumerable<string>
source,System.Func<string, string>
keySelector)
{
var return_v = source.OrderBy<string,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 854, 1088);
return return_v;
}


int
f_25040_1105_1190(string[]
expected,System.Linq.IOrderedEnumerable<string>
actual,string
itemSeparator)
{
AssertEx.SetEqual( (System.Collections.Generic.IEnumerable<string>)expected, (System.Collections.Generic.IEnumerable<string>)actual, itemSeparator: itemSeparator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25040, 1105, 1190);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25040,385,1202);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25040,385,1202);
}
		}

static ReflectionAssert()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25040,332,1209);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25040,332,1209);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25040,332,1209);
}

}
}
