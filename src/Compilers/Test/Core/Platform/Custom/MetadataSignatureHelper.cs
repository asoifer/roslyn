// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
public class MetadataSignatureHelper
{
private const BindingFlags 
BINDING_FLAGS =
                BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly
;

private static void AppendComma(StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,749,850);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,823,839);

f_25144_823_838(            sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,749,850);

System.Text.StringBuilder
f_25144_823_838(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 823, 838);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,749,850);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,749,850);
}
		}

private static void RemoveTrailingComma(StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,862,1077);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,944,1066) || true) && (f_25144_948_1002(f_25144_948_961(sb), ", ", StringComparison.Ordinal))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,944,1066);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1036,1051);

sb.Length -= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => 2,25144,1036,1045);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,944,1066);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,862,1077);

string
f_25144_948_961(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 948, 961);
return return_v;
}


bool
f_25144_948_1002(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 948, 1002);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,862,1077);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,862,1077);
}
		}

private static void AppendType(Type type, StringBuilder sb, bool showGenericConstraints = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,1089,2404);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1210,2363) || true) && (showGenericConstraints &&(DynAbs.Tracing.TraceSender.Expression_True(25144, 1214, 1263)&&f_25144_1240_1263(type)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,1210,2363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1297,1331);

var 
typeInfo = f_25144_1312_1330(type)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1349,1491) || true) && (f_25144_1353_1448(f_25144_1353_1388(typeInfo), GenericParameterAttributes.ReferenceTypeConstraint))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,1349,1491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1471,1491);

f_25144_1471_1490(                    sb, "class ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,1349,1491);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1509,1662) || true) && (f_25144_1513_1615(f_25144_1513_1548(typeInfo), GenericParameterAttributes.NotNullableValueTypeConstraint))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,1509,1662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1638,1662);

f_25144_1638_1661(                    sb, "valuetype ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,1509,1662);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1680,1827) || true) && (f_25144_1684_1784(f_25144_1684_1719(typeInfo), GenericParameterAttributes.DefaultConstructorConstraint))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,1680,1827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1807,1827);

f_25144_1807_1826(                    sb, ".ctor ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,1680,1827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1847,1914);

var 
genericConstraints = f_25144_1872_1913(typeInfo)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,1932,2348) || true) && (f_25144_1936_1961(genericConstraints)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,1932,2348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2007,2022);

f_25144_2007_2021(                    sb, "(");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2044,2245);
foreach(var genericConstraint in f_25144_2078_2096_I(genericConstraints) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,2044,2245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2146,2180);

f_25144_2146_2179(genericConstraint, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2206,2222);

f_25144_2206_2221(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,2044,2245);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,202);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,202);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2267,2291);

f_25144_2267_2290(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2313,2329);

f_25144_2313_2328(                    sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,1932,2348);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,1210,2363);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2377,2393);

f_25144_2377_2392(            sb, type);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,1089,2404);

bool
f_25144_1240_1263(System.Type
this_param)
{
var return_v = this_param.IsGenericParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 1240, 1263);
return return_v;
}


System.Reflection.TypeInfo
f_25144_1312_1330(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1312, 1330);
return return_v;
}


System.Reflection.GenericParameterAttributes
f_25144_1353_1388(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.GenericParameterAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 1353, 1388);
return return_v;
}


bool
f_25144_1353_1448(System.Reflection.GenericParameterAttributes
this_param,System.Reflection.GenericParameterAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1353, 1448);
return return_v;
}


System.Text.StringBuilder
f_25144_1471_1490(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1471, 1490);
return return_v;
}


System.Reflection.GenericParameterAttributes
f_25144_1513_1548(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.GenericParameterAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 1513, 1548);
return return_v;
}


bool
f_25144_1513_1615(System.Reflection.GenericParameterAttributes
this_param,System.Reflection.GenericParameterAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1513, 1615);
return return_v;
}


System.Text.StringBuilder
f_25144_1638_1661(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1638, 1661);
return return_v;
}


System.Reflection.GenericParameterAttributes
f_25144_1684_1719(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.GenericParameterAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 1684, 1719);
return return_v;
}


bool
f_25144_1684_1784(System.Reflection.GenericParameterAttributes
this_param,System.Reflection.GenericParameterAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1684, 1784);
return return_v;
}


System.Text.StringBuilder
f_25144_1807_1826(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1807, 1826);
return return_v;
}


System.Type[]
f_25144_1872_1913(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.GetGenericParameterConstraints();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 1872, 1913);
return return_v;
}


int
f_25144_1936_1961(System.Type[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 1936, 1961);
return return_v;
}


System.Text.StringBuilder
f_25144_2007_2021(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2007, 2021);
return return_v;
}


int
f_25144_2146_2179(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2146, 2179);
return 0;
}


int
f_25144_2206_2221(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2206, 2221);
return 0;
}


System.Type[]
f_25144_2078_2096_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2078, 2096);
return return_v;
}


int
f_25144_2267_2290(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2267, 2290);
return 0;
}


System.Text.StringBuilder
f_25144_2313_2328(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2313, 2328);
return return_v;
}


System.Text.StringBuilder
f_25144_2377_2392(System.Text.StringBuilder
this_param,System.Type
value)
{
var return_v = this_param.Append( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2377, 2392);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,1089,2404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,1089,2404);
}
		}

private static void AppendValue(object value, StringBuilder sb, bool includeAssignmentOperator = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,2416,3050);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2543,3039) || true) && (value != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,2543,3039);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2594,2701) || true) && (includeAssignmentOperator)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,2594,2701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2665,2682);

f_25144_2665_2681(                    sb, " = ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,2594,2701);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2721,3024) || true) && (f_25144_2725_2740(value)== typeof(string))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,2721,3024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2800,2845);

f_25144_2800_2844(                    sb, "\"{0}\"", f_25144_2827_2843(value));
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,2721,3024);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,2721,3024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,2927,3005);

f_25144_2927_3004(                    sb, f_25144_2937_3003(value));
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,2721,3024);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,2543,3039);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,2416,3050);

System.Text.StringBuilder
f_25144_2665_2681(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2665, 2681);
return return_v;
}


System.Type
f_25144_2725_2740(object
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2725, 2740);
return return_v;
}


string?
f_25144_2827_2843(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2827, 2843);
return return_v;
}


System.Text.StringBuilder
f_25144_2800_2844(System.Text.StringBuilder
this_param,string
format,string?
arg0)
{
var return_v = this_param.AppendFormat( format, (object?)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2800, 2844);
return return_v;
}


string
f_25144_2937_3003(object
value)
{
var return_v = Roslyn.Test.Utilities.TestHelpers.GetCultureInvariantString( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2937, 3003);
return return_v;
}


System.Text.StringBuilder
f_25144_2927_3004(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 2927, 3004);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,2416,3050);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,2416,3050);
}
		}

private static void AppendCustomAttributeData(CustomAttributeData attribute, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,3062,3834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3181,3196);

f_25144_3181_3195(            sb, "[");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3210,3262);

f_25144_3210_3261(f_25144_3221_3256(f_25144_3221_3242(attribute)), sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3276,3291);

f_25144_3276_3290(            sb, "(");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3305,3502);
foreach(var positionalArgument in f_25144_3340_3370_I(f_25144_3340_3370(attribute)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,3305,3502);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3404,3453);

f_25144_3404_3452(positionalArgument.Value, sb, false);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3471,3487);

f_25144_3471_3486(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,3305,3502);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,198);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,198);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3516,3755);
foreach(var namedArgument in f_25144_3546_3570_I(f_25144_3546_3570(attribute)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,3516,3755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3604,3640);

f_25144_3604_3639(                sb, namedArgument.MemberName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3658,3706);

f_25144_3658_3705(namedArgument.TypedValue.Value, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3724,3740);

f_25144_3724_3739(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,3516,3755);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,240);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3769,3793);

f_25144_3769_3792(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3807,3823);

f_25144_3807_3822(            sb, ")]");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,3062,3834);

System.Text.StringBuilder
f_25144_3181_3195(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3181, 3195);
return return_v;
}


System.Reflection.ConstructorInfo
f_25144_3221_3242(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 3221, 3242);
return return_v;
}


System.Type?
f_25144_3221_3256(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.DeclaringType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 3221, 3256);
return return_v;
}


int
f_25144_3210_3261(System.Type?
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3210, 3261);
return 0;
}


System.Text.StringBuilder
f_25144_3276_3290(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3276, 3290);
return return_v;
}


System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument>
f_25144_3340_3370(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.ConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 3340, 3370);
return return_v;
}


int
f_25144_3404_3452(object?
value,System.Text.StringBuilder
sb,bool
includeAssignmentOperator)
{
AppendValue( value, sb, includeAssignmentOperator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3404, 3452);
return 0;
}


int
f_25144_3471_3486(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3471, 3486);
return 0;
}


System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument>
f_25144_3340_3370_I(System.Collections.Generic.IList<System.Reflection.CustomAttributeTypedArgument>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3340, 3370);
return return_v;
}


System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument>
f_25144_3546_3570(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 3546, 3570);
return return_v;
}


System.Text.StringBuilder
f_25144_3604_3639(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3604, 3639);
return return_v;
}


int
f_25144_3658_3705(object?
value,System.Text.StringBuilder
sb)
{
AppendValue( value, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3658, 3705);
return 0;
}


int
f_25144_3724_3739(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3724, 3739);
return 0;
}


System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument>
f_25144_3546_3570_I(System.Collections.Generic.IList<System.Reflection.CustomAttributeNamedArgument>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3546, 3570);
return return_v;
}


int
f_25144_3769_3792(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3769, 3792);
return 0;
}


System.Text.StringBuilder
f_25144_3807_3822(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3807, 3822);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,3062,3834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,3062,3834);
}
		}

private static void AppendParameterInfo(ParameterInfo parameter, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,3846,5746);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,3953,4605);
foreach(var attribute in f_25144_3979_4005_I(f_25144_3979_4005(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,3953,4605);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4174,4590) || true) && (f_25144_4178_4201(attribute)!= typeof(OptionalAttribute) &&(DynAbs.Tracing.TraceSender.Expression_True(25144, 4178, 4301)&&f_25144_4255_4278(attribute)!= typeof(InAttribute) )&&(DynAbs.Tracing.TraceSender.Expression_True(25144, 4178, 4373)&&f_25144_4326_4349(attribute)!= typeof(OutAttribute) )&&(DynAbs.Tracing.TraceSender.Expression_True(25144, 4178, 4451)&&f_25144_4398_4421(attribute)!= typeof(MarshalAsAttribute)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,4174,4590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4493,4534);

f_25144_4493_4533(attribute, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4556,4571);

f_25144_4556_4570(                    sb, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,4174,4590);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,3953,4605);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,653);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,653);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4621,4827);
foreach(var modreq in f_25144_4644_4682_I(f_25144_4644_4682(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,4621,4827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4716,4737);

f_25144_4716_4736(                sb, "modreq(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4755,4778);

f_25144_4755_4777(modreq, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4796,4812);

f_25144_4796_4811(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,4621,4827);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,207);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,207);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4841,5047);
foreach(var modopt in f_25144_4864_4902_I(f_25144_4864_4902(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,4841,5047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4936,4957);

f_25144_4936_4956(                sb, "modopt(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,4975,4998);

f_25144_4975_4997(modopt, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5016,5032);

f_25144_5016_5031(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,4841,5047);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,207);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,207);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5063,5086);

int 
length = f_25144_5076_5085(sb)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5100,5164);

f_25144_5100_5163(sb, f_25144_5130_5150(parameter), all: false);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5178,5264) || true) && (f_25144_5182_5191(sb)> length)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,5178,5264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5234,5249);

f_25144_5234_5248(                sb, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,5178,5264);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5280,5320);

f_25144_5280_5319(f_25144_5291_5314(parameter), sb);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5334,5735) || true) && (!f_25144_5339_5380(f_25144_5365_5379(parameter)))
) // If this is not the 'return' parameter

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,5334,5735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5455,5470);

f_25144_5455_5469(                sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5488,5514);

f_25144_5488_5513(                sb, f_25144_5498_5512(parameter));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5534,5579);

var 
defaultValue = f_25144_5553_5578(parameter)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5597,5720) || true) && (defaultValue != DBNull.Value)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,5597,5720);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5671,5701);

f_25144_5671_5700(defaultValue, sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,5597,5720);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,5334,5735);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,3846,5746);

System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_3979_4005(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 3979, 4005);
return return_v;
}


System.Type
f_25144_4178_4201(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.AttributeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 4178, 4201);
return return_v;
}


System.Type
f_25144_4255_4278(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.AttributeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 4255, 4278);
return return_v;
}


System.Type
f_25144_4326_4349(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.AttributeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 4326, 4349);
return return_v;
}


System.Type
f_25144_4398_4421(System.Reflection.CustomAttributeData
this_param)
{
var return_v = this_param.AttributeType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 4398, 4421);
return return_v;
}


int
f_25144_4493_4533(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4493, 4533);
return 0;
}


System.Text.StringBuilder
f_25144_4556_4570(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4556, 4570);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_3979_4005_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 3979, 4005);
return return_v;
}


System.Type[]
f_25144_4644_4682(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.GetRequiredCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4644, 4682);
return return_v;
}


System.Text.StringBuilder
f_25144_4716_4736(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4716, 4736);
return return_v;
}


int
f_25144_4755_4777(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4755, 4777);
return 0;
}


System.Text.StringBuilder
f_25144_4796_4811(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4796, 4811);
return return_v;
}


System.Type[]
f_25144_4644_4682_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4644, 4682);
return return_v;
}


System.Type[]
f_25144_4864_4902(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.GetOptionalCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4864, 4902);
return return_v;
}


System.Text.StringBuilder
f_25144_4936_4956(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4936, 4956);
return return_v;
}


int
f_25144_4975_4997(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4975, 4997);
return 0;
}


System.Text.StringBuilder
f_25144_5016_5031(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5016, 5031);
return return_v;
}


System.Type[]
f_25144_4864_4902_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 4864, 4902);
return return_v;
}


int
f_25144_5076_5085(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5076, 5085);
return return_v;
}


System.Reflection.ParameterAttributes
f_25144_5130_5150(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5130, 5150);
return return_v;
}


bool
f_25144_5100_5163(System.Text.StringBuilder
sb,System.Reflection.ParameterAttributes
attributes,bool
all)
{
var return_v = AppendParameterAttributes( sb, attributes, all: all);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5100, 5163);
return return_v;
}


int
f_25144_5182_5191(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5182, 5191);
return return_v;
}


System.Text.StringBuilder
f_25144_5234_5248(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5234, 5248);
return return_v;
}


System.Type
f_25144_5291_5314(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5291, 5314);
return return_v;
}


int
f_25144_5280_5319(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5280, 5319);
return 0;
}


string?
f_25144_5365_5379(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5365, 5379);
return return_v;
}


bool
f_25144_5339_5380(string?
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5339, 5380);
return return_v;
}


System.Text.StringBuilder
f_25144_5455_5469(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5455, 5469);
return return_v;
}


string
f_25144_5498_5512(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5498, 5512);
return return_v;
}


System.Text.StringBuilder
f_25144_5488_5513(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5488, 5513);
return return_v;
}


object?
f_25144_5553_5578(System.Reflection.ParameterInfo
this_param)
{
var return_v = this_param.RawDefaultValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 5553, 5578);
return return_v;
}


int
f_25144_5671_5700(object?
value,System.Text.StringBuilder
sb)
{
AppendValue( value, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5671, 5700);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,3846,5746);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,3846,5746);
}
		}

public static bool AppendParameterAttributes(StringBuilder sb, ParameterAttributes attributes, bool all = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,5758,6610);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5894,5933);

List<string> 
list = f_25144_5914_5932()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,5949,6038) || true) && ((attributes & ParameterAttributes.Optional) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,5949,6038);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6020,6038);

f_25144_6020_6037(                list, "[opt]");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,5949,6038);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6052,6134) || true) && ((attributes & ParameterAttributes.In) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6052,6134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6117,6134);

f_25144_6117_6133(                list, "[in]");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6052,6134);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6148,6232) || true) && ((attributes & ParameterAttributes.Out) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6148,6232);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6214,6232);

f_25144_6214_6231(                list, "[out]");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6148,6232);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6248,6521) || true) && (all)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6248,6521);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6289,6391) || true) && ((attributes & ParameterAttributes.HasFieldMarshal) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6289,6391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6371,6391);

f_25144_6371_6390(                    list, "marshal");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6289,6391);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6409,6506) || true) && ((attributes & ParameterAttributes.HasDefault) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6409,6506);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6486,6506);

f_25144_6486_6505(                    list, "default");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6409,6506);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6248,6521);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6537,6563);

f_25144_6537_6562(
            sb, f_25144_6547_6561(list, " "));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6577,6599);

return f_25144_6584_6594(list)> 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,5758,6610);

System.Collections.Generic.List<string>
f_25144_5914_5932()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 5914, 5932);
return return_v;
}


int
f_25144_6020_6037(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6020, 6037);
return 0;
}


int
f_25144_6117_6133(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6117, 6133);
return 0;
}


int
f_25144_6214_6231(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6214, 6231);
return 0;
}


int
f_25144_6371_6390(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6371, 6390);
return 0;
}


int
f_25144_6486_6505(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6486, 6505);
return 0;
}


string
f_25144_6547_6561(System.Collections.Generic.List<string>
source,string
separator)
{
var return_v = source.Join( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6547, 6561);
return return_v;
}


System.Text.StringBuilder
f_25144_6537_6562(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6537, 6562);
return return_v;
}


int
f_25144_6584_6594(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 6584, 6594);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,5758,6610);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,5758,6610);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool AppendPropertyAttributes(StringBuilder sb, PropertyAttributes attributes, bool all = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,6622,7280);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6756,6795);

List<string> 
list = f_25144_6776_6794()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6811,6908) || true) && ((attributes & PropertyAttributes.SpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6811,6908);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6884,6908);

f_25144_6884_6907(                list, "specialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6811,6908);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6922,7023) || true) && ((attributes & PropertyAttributes.RTSpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,6922,7023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,6997,7023);

f_25144_6997_7022(                list, "rtspecialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,6922,7023);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7039,7191) || true) && (all)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7039,7191);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7080,7176) || true) && ((attributes & PropertyAttributes.HasDefault) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7080,7176);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7156,7176);

f_25144_7156_7175(                    list, "default");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7080,7176);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7039,7191);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7207,7233);

f_25144_7207_7232(
            sb, f_25144_7217_7231(list, " "));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7247,7269);

return f_25144_7254_7264(list)> 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,6622,7280);

System.Collections.Generic.List<string>
f_25144_6776_6794()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6776, 6794);
return return_v;
}


int
f_25144_6884_6907(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6884, 6907);
return 0;
}


int
f_25144_6997_7022(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 6997, 7022);
return 0;
}


int
f_25144_7156_7175(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7156, 7175);
return 0;
}


string
f_25144_7217_7231(System.Collections.Generic.List<string>
source,string
separator)
{
var return_v = source.Join( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7217, 7231);
return return_v;
}


System.Text.StringBuilder
f_25144_7207_7232(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7207, 7232);
return return_v;
}


int
f_25144_7254_7264(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 7254, 7264);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,6622,7280);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,6622,7280);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool AppendEventAttributes(StringBuilder sb, EventAttributes attributes, bool all = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,7292,7770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7420,7459);

List<string> 
list = f_25144_7440_7458()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7475,7569) || true) && ((attributes & EventAttributes.SpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7475,7569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7545,7569);

f_25144_7545_7568(                list, "specialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7475,7569);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7583,7681) || true) && ((attributes & EventAttributes.RTSpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7583,7681);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7655,7681);

f_25144_7655_7680(                list, "rtspecialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7583,7681);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7697,7723);

f_25144_7697_7722(
            sb, f_25144_7707_7721(list, " "));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7737,7759);

return f_25144_7744_7754(list)> 0;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,7292,7770);

System.Collections.Generic.List<string>
f_25144_7440_7458()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7440, 7458);
return return_v;
}


int
f_25144_7545_7568(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7545, 7568);
return 0;
}


int
f_25144_7655_7680(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7655, 7680);
return 0;
}


string
f_25144_7707_7721(System.Collections.Generic.List<string>
source,string
separator)
{
var return_v = source.Join( separator);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7707, 7721);
return return_v;
}


System.Text.StringBuilder
f_25144_7697_7722(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 7697, 7722);
return return_v;
}


int
f_25144_7744_7754(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 7744, 7754);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,7292,7770);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,7292,7770);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static StringBuilder AppendFieldAttributes(StringBuilder sb, FieldAttributes attributes, bool all = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,7782,9918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7919,7937);

string 
visibility
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,7951,8690);

switch (attributes & FieldAttributes.FieldAccessMask)
            {

case FieldAttributes.PrivateScope: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8072,8100);

visibility = "privatescope";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8101,8107);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.Private: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8155,8178);

visibility = "private";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8179,8185);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.FamANDAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8237,8264);

visibility = "famandassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8265,8271);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.Assembly: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8320,8344);

visibility = "assembly";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8345,8351);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.Family: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8398,8420);

visibility = "family";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8421,8427);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.FamORAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8478,8504);

visibility = "famorassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8505,8511);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

case FieldAttributes.Public: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8558,8580);

visibility = "public";
DynAbs.Tracing.TraceSender.TraceBreak(25144,8581,8587);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,7951,8690);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8637,8675);

throw f_25144_8643_8674();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,7951,8690);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8706,8728);

f_25144_8706_8727(
            sb, visibility);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8742,8822);

f_25144_8742_8821(            sb, (DynAbs.Tracing.TraceSender.Conditional_F1(25144, 8752, 8794)||(((attributes & FieldAttributes.Static) != 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(25144, 8797, 8806))||DynAbs.Tracing.TraceSender.Conditional_F3(25144, 8809, 8820)))?" static" :" instance");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8838,8928) || true) && ((attributes & FieldAttributes.InitOnly) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,8838,8928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8905,8928);

f_25144_8905_8927(                sb, " initonly");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,8838,8928);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,8942,9030) || true) && ((attributes & FieldAttributes.Literal) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,8942,9030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9008,9030);

f_25144_9008_9029(                sb, " literal");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,8942,9030);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9044,9144) || true) && ((attributes & FieldAttributes.NotSerialized) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9044,9144);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9116,9144);

f_25144_9116_9143(                sb, " notserialized");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9044,9144);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9158,9254) || true) && ((attributes & FieldAttributes.SpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9158,9254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9228,9254);

f_25144_9228_9253(                sb, " specialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9158,9254);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9268,9368) || true) && ((attributes & FieldAttributes.RTSpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9268,9368);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9340,9368);

f_25144_9340_9367(                sb, " rtspecialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9268,9368);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9384,9881) || true) && (all)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9384,9881);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9425,9525) || true) && ((attributes & FieldAttributes.PinvokeImpl) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9425,9525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9499,9525);

f_25144_9499_9524(                    sb, " pinvokeimpl");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9425,9525);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9543,9643) || true) && ((attributes & FieldAttributes.HasFieldMarshal) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9543,9643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9621,9643);

f_25144_9621_9642(                    sb, " marshal");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9543,9643);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9661,9756) || true) && ((attributes & FieldAttributes.HasDefault) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9661,9756);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9734,9756);

f_25144_9734_9755(                    sb, " default");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9661,9756);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9774,9866) || true) && ((attributes & FieldAttributes.HasFieldRVA) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,9774,9866);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9848,9866);

f_25144_9848_9865(                    sb, " rva");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9774,9866);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,9384,9881);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,9897,9907);

return sb;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,7782,9918);

System.InvalidOperationException
f_25144_8643_8674()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 8643, 8674);
return return_v;
}


System.Text.StringBuilder
f_25144_8706_8727(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 8706, 8727);
return return_v;
}


System.Text.StringBuilder
f_25144_8742_8821(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 8742, 8821);
return return_v;
}


System.Text.StringBuilder
f_25144_8905_8927(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 8905, 8927);
return return_v;
}


System.Text.StringBuilder
f_25144_9008_9029(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9008, 9029);
return return_v;
}


System.Text.StringBuilder
f_25144_9116_9143(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9116, 9143);
return return_v;
}


System.Text.StringBuilder
f_25144_9228_9253(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9228, 9253);
return return_v;
}


System.Text.StringBuilder
f_25144_9340_9367(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9340, 9367);
return return_v;
}


System.Text.StringBuilder
f_25144_9499_9524(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9499, 9524);
return return_v;
}


System.Text.StringBuilder
f_25144_9621_9642(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9621, 9642);
return return_v;
}


System.Text.StringBuilder
f_25144_9734_9755(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9734, 9755);
return return_v;
}


System.Text.StringBuilder
f_25144_9848_9865(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 9848, 9865);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,7782,9918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,7782,9918);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static StringBuilder AppendMethodAttributes(StringBuilder sb, MethodAttributes attributes, bool all = true)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,9930,12285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10069,10087);

string 
visibility
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10101,10849);

switch (attributes & MethodAttributes.MemberAccessMask)
            {

case MethodAttributes.PrivateScope: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10225,10253);

visibility = "privatescope";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10254,10260);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.Private: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10309,10332);

visibility = "private";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10333,10339);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.FamANDAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10392,10419);

visibility = "famandassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10420,10426);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.Assembly: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10476,10500);

visibility = "assembly";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10501,10507);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.Family: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10555,10577);

visibility = "family";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10578,10584);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.FamORAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10636,10662);

visibility = "famorassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10663,10669);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

case MethodAttributes.Public: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10717,10739);

visibility = "public";
DynAbs.Tracing.TraceSender.TraceBreak(25144,10740,10746);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10101,10849);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10796,10834);

throw f_25144_10802_10833();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10101,10849);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10865,10887);

f_25144_10865_10886(
            sb, visibility);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10903,10996) || true) && ((attributes & MethodAttributes.HideBySig) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,10903,10996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,10972,10996);

f_25144_10972_10995(                sb, " hidebysig");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,10903,10996);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11010,11099) || true) && ((attributes & MethodAttributes.NewSlot) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11010,11099);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11077,11099);

f_25144_11077_11098(                sb, " newslot");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11010,11099);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11113,11215) || true) && ((attributes & MethodAttributes.CheckAccessOnOverride) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11113,11215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11194,11215);

f_25144_11194_11214(                sb, " strict");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11113,11215);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11229,11326) || true) && ((attributes & MethodAttributes.SpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11229,11326);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11300,11326);

f_25144_11300_11325(                sb, " specialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11229,11326);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11340,11441) || true) && ((attributes & MethodAttributes.RTSpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11340,11441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11413,11441);

f_25144_11413_11440(                sb, " rtspecialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11340,11441);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11455,11555) || true) && ((attributes & MethodAttributes.RequireSecObject) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11455,11555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11531,11555);

f_25144_11531_11554(                sb, " reqsecobj");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11455,11555);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11569,11671) || true) && ((attributes & MethodAttributes.UnmanagedExport) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11569,11671);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11644,11671);

f_25144_11644_11670(                sb, " unmanagedexp");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11569,11671);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11685,11776) || true) && ((attributes & MethodAttributes.Abstract) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11685,11776);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11753,11776);

f_25144_11753_11775(                sb, " abstract");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11685,11776);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11790,11879) || true) && ((attributes & MethodAttributes.Virtual) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11790,11879);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11857,11879);

f_25144_11857_11878(                sb, " virtual");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11790,11879);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11893,11978) || true) && ((attributes & MethodAttributes.Final) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,11893,11978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11958,11978);

f_25144_11958_11977(                sb, " final");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,11893,11978);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,11994,12075);

f_25144_11994_12074(
            sb, (DynAbs.Tracing.TraceSender.Conditional_F1(25144, 12004, 12047)||(((attributes & MethodAttributes.Static) != 0 &&DynAbs.Tracing.TraceSender.Conditional_F2(25144, 12050, 12059))||DynAbs.Tracing.TraceSender.Conditional_F3(25144, 12062, 12073)))?" static" :" instance");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12091,12248) || true) && (all)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12091,12248);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12132,12233) || true) && ((attributes & MethodAttributes.PinvokeImpl) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12132,12233);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12207,12233);

f_25144_12207_12232(                    sb, " pinvokeimpl");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12132,12233);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12091,12248);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12264,12274);

return sb;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,9930,12285);

System.InvalidOperationException
f_25144_10802_10833()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 10802, 10833);
return return_v;
}


System.Text.StringBuilder
f_25144_10865_10886(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 10865, 10886);
return return_v;
}


System.Text.StringBuilder
f_25144_10972_10995(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 10972, 10995);
return return_v;
}


System.Text.StringBuilder
f_25144_11077_11098(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11077, 11098);
return return_v;
}


System.Text.StringBuilder
f_25144_11194_11214(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11194, 11214);
return return_v;
}


System.Text.StringBuilder
f_25144_11300_11325(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11300, 11325);
return return_v;
}


System.Text.StringBuilder
f_25144_11413_11440(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11413, 11440);
return return_v;
}


System.Text.StringBuilder
f_25144_11531_11554(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11531, 11554);
return return_v;
}


System.Text.StringBuilder
f_25144_11644_11670(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11644, 11670);
return return_v;
}


System.Text.StringBuilder
f_25144_11753_11775(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11753, 11775);
return return_v;
}


System.Text.StringBuilder
f_25144_11857_11878(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11857, 11878);
return return_v;
}


System.Text.StringBuilder
f_25144_11958_11977(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11958, 11977);
return return_v;
}


System.Text.StringBuilder
f_25144_11994_12074(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 11994, 12074);
return return_v;
}


System.Text.StringBuilder
f_25144_12207_12232(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 12207, 12232);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,9930,12285);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,9930,12285);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static StringBuilder AppendMethodImplAttributes(StringBuilder sb, MethodImplAttributes attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,12297,13999);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12427,12443);

string 
codeType
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12457,12939);

switch (attributes & MethodImplAttributes.CodeTypeMask)
            {

case MethodImplAttributes.IL: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12457,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12575,12592);

codeType = "cil";
DynAbs.Tracing.TraceSender.TraceBreak(25144,12593,12599);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12457,12939);

case MethodImplAttributes.OPTIL: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12457,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12650,12669);

codeType = "optil";
DynAbs.Tracing.TraceSender.TraceBreak(25144,12670,12676);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12457,12939);

case MethodImplAttributes.Runtime: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12457,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12729,12750);

codeType = "runtime";
DynAbs.Tracing.TraceSender.TraceBreak(25144,12751,12757);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12457,12939);

case MethodImplAttributes.Native: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12457,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12809,12829);

codeType = "native";
DynAbs.Tracing.TraceSender.TraceBreak(25144,12830,12836);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12457,12939);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,12457,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12886,12924);

throw f_25144_12892_12923();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,12457,12939);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12955,12975);

f_25144_12955_12974(
            sb, codeType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,12989,13004);

f_25144_12989_13003(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13018,13135);

f_25144_13018_13134(            sb, (DynAbs.Tracing.TraceSender.Conditional_F1(25144, 13028, 13107)||(((attributes & MethodImplAttributes.Unmanaged) == MethodImplAttributes.Unmanaged &&DynAbs.Tracing.TraceSender.Conditional_F2(25144, 13110, 13121))||DynAbs.Tracing.TraceSender.Conditional_F3(25144, 13124, 13133)))?"unmanaged" :"managed");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13151,13252) || true) && ((attributes & MethodImplAttributes.PreserveSig) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13151,13252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13226,13252);

f_25144_13226_13251(                sb, " preservesig");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13151,13252);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13266,13365) || true) && ((attributes & MethodImplAttributes.ForwardRef) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13266,13365);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13340,13365);

f_25144_13340_13364(                sb, " forwardref");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13266,13365);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13379,13482) || true) && ((attributes & MethodImplAttributes.InternalCall) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13379,13482);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13455,13482);

f_25144_13455_13481(                sb, " internalcall");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13379,13482);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13496,13599) || true) && ((attributes & MethodImplAttributes.Synchronized) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13496,13599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13572,13599);

f_25144_13572_13598(                sb, " synchronized");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13496,13599);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13613,13712) || true) && ((attributes & MethodImplAttributes.NoInlining) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13613,13712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13687,13712);

f_25144_13687_13711(                sb, " noinlining");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13613,13712);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13726,13841) || true) && ((attributes & MethodImplAttributes.AggressiveInlining) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13726,13841);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13808,13841);

f_25144_13808_13840(                sb, " aggressiveinlining");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13726,13841);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13855,13962) || true) && ((attributes & MethodImplAttributes.NoOptimization) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,13855,13962);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13933,13962);

f_25144_13933_13961(                sb, " nooptimization");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,13855,13962);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,13978,13988);

return sb;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,12297,13999);

System.InvalidOperationException
f_25144_12892_12923()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 12892, 12923);
return return_v;
}


System.Text.StringBuilder
f_25144_12955_12974(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 12955, 12974);
return return_v;
}


System.Text.StringBuilder
f_25144_12989_13003(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 12989, 13003);
return return_v;
}


System.Text.StringBuilder
f_25144_13018_13134(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13018, 13134);
return return_v;
}


System.Text.StringBuilder
f_25144_13226_13251(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13226, 13251);
return return_v;
}


System.Text.StringBuilder
f_25144_13340_13364(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13340, 13364);
return return_v;
}


System.Text.StringBuilder
f_25144_13455_13481(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13455, 13481);
return return_v;
}


System.Text.StringBuilder
f_25144_13572_13598(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13572, 13598);
return return_v;
}


System.Text.StringBuilder
f_25144_13687_13711(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13687, 13711);
return return_v;
}


System.Text.StringBuilder
f_25144_13808_13840(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13808, 13840);
return return_v;
}


System.Text.StringBuilder
f_25144_13933_13961(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 13933, 13961);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,12297,13999);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,12297,13999);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static StringBuilder AppendTypeAttributes(StringBuilder sb, TypeAttributes attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,14011,17131);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14129,14147);

string 
visibility
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14161,15036);

switch (attributes & TypeAttributes.VisibilityMask)
            {

case TypeAttributes.NotPublic: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14276,14299);

visibility = "private";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14300,14306);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.Public: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14352,14374);

visibility = "public";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14375,14381);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedPrivate: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14434,14464);

visibility = "nested private";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14465,14471);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedFamANDAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14528,14562);

visibility = "nested famandassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14563,14569);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedAssembly: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14623,14654);

visibility = "nested assembly";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14655,14661);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedFamily: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14713,14742);

visibility = "nested family";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14743,14749);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedFamORAssem: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14805,14838);

visibility = "nested famorassem";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14839,14845);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

case TypeAttributes.NestedPublic: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14897,14926);

visibility = "nested public";
DynAbs.Tracing.TraceSender.TraceBreak(25144,14927,14933);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,14161,15036);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,14983,15021);

throw f_25144_14989_15020();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,14161,15036);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15052,15066);

string 
layout
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15080,15484);

switch (attributes & TypeAttributes.LayoutMask)
            {

case TypeAttributes.AutoLayout: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15080,15484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15192,15208);

layout = "auto";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15209,15215);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15080,15484);

case TypeAttributes.SequentialLayout: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15080,15484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15271,15293);

layout = "sequential";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15294,15300);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15080,15484);

case TypeAttributes.ExplicitLayout: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15080,15484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15354,15374);

layout = "explicit";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15375,15381);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15080,15484);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15080,15484);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15431,15469);

throw f_25144_15437_15468();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15080,15484);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15500,15520);

string 
stringFormat
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15534,15949);

switch (attributes & TypeAttributes.StringFormatMask)
            {

case TypeAttributes.AnsiClass: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15534,15949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15651,15673);

stringFormat = "ansi";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15674,15680);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15534,15949);

case TypeAttributes.UnicodeClass: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15534,15949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15732,15757);

stringFormat = "unicode";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15758,15764);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15534,15949);

case TypeAttributes.AutoClass: DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15534,15949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15813,15839);

stringFormat = "autochar";
DynAbs.Tracing.TraceSender.TraceBreak(25144,15840,15846);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15534,15949);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15534,15949);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15896,15934);

throw f_25144_15902_15933();
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15534,15949);
            }

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,15965,16056) || true) && ((attributes & TypeAttributes.Interface) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,15965,16056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16032,16056);

f_25144_16032_16055(                sb, "interface ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,15965,16056);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16072,16094);

f_25144_16072_16093(
            sb, visibility);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16110,16199) || true) && ((attributes & TypeAttributes.Abstract) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16110,16199);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16176,16199);

f_25144_16176_16198(                sb, " abstract");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16110,16199);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16215,16230);

f_25144_16215_16229(
            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16244,16262);

f_25144_16244_16261(            sb, layout);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16276,16291);

f_25144_16276_16290(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16305,16329);

f_25144_16305_16328(            sb, stringFormat);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16345,16430) || true) && ((attributes & TypeAttributes.Import) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16345,16430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16409,16430);

f_25144_16409_16429(                sb, " import");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16345,16430);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16444,16545) || true) && ((attributes & TypeAttributes.WindowsRuntime) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16444,16545);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16516,16545);

f_25144_16516_16544(                sb, " windowsruntime");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16444,16545);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16559,16644) || true) && ((attributes & TypeAttributes.Sealed) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16559,16644);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16623,16644);

f_25144_16623_16643(                sb, " sealed");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16559,16644);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16658,16755) || true) && ((attributes & TypeAttributes.Serializable) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16658,16755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16728,16755);

f_25144_16728_16754(                sb, " serializable");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16658,16755);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16769,16872) || true) && ((attributes & TypeAttributes.BeforeFieldInit) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16769,16872);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16842,16872);

f_25144_16842_16871(                sb, " beforefieldinit");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16769,16872);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16886,16981) || true) && ((attributes & TypeAttributes.SpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16886,16981);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16955,16981);

f_25144_16955_16980(                sb, " specialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16886,16981);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,16995,17094) || true) && ((attributes & TypeAttributes.RTSpecialName) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,16995,17094);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17066,17094);

f_25144_17066_17093(                sb, " rtspecialname");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,16995,17094);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17110,17120);

return sb;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,14011,17131);

System.InvalidOperationException
f_25144_14989_15020()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 14989, 15020);
return return_v;
}


System.InvalidOperationException
f_25144_15437_15468()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 15437, 15468);
return return_v;
}


System.InvalidOperationException
f_25144_15902_15933()
{
var return_v = new System.InvalidOperationException();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 15902, 15933);
return return_v;
}


System.Text.StringBuilder
f_25144_16032_16055(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16032, 16055);
return return_v;
}


System.Text.StringBuilder
f_25144_16072_16093(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16072, 16093);
return return_v;
}


System.Text.StringBuilder
f_25144_16176_16198(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16176, 16198);
return return_v;
}


System.Text.StringBuilder
f_25144_16215_16229(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16215, 16229);
return return_v;
}


System.Text.StringBuilder
f_25144_16244_16261(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16244, 16261);
return return_v;
}


System.Text.StringBuilder
f_25144_16276_16290(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16276, 16290);
return return_v;
}


System.Text.StringBuilder
f_25144_16305_16328(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16305, 16328);
return return_v;
}


System.Text.StringBuilder
f_25144_16409_16429(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16409, 16429);
return return_v;
}


System.Text.StringBuilder
f_25144_16516_16544(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16516, 16544);
return return_v;
}


System.Text.StringBuilder
f_25144_16623_16643(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16623, 16643);
return return_v;
}


System.Text.StringBuilder
f_25144_16728_16754(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16728, 16754);
return return_v;
}


System.Text.StringBuilder
f_25144_16842_16871(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16842, 16871);
return return_v;
}


System.Text.StringBuilder
f_25144_16955_16980(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 16955, 16980);
return return_v;
}


System.Text.StringBuilder
f_25144_17066_17093(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17066, 17093);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,14011,17131);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,14011,17131);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static void AppendMethodInfo(MethodInfo method, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,17143,18464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17241,17262);

f_25144_17241_17261(            sb, ".method");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17278,17450);
foreach(var attribute in f_25144_17304_17327_I(f_25144_17304_17327(method)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,17278,17450);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17361,17376);

f_25144_17361_17375(                sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17394,17435);

f_25144_17394_17434(attribute, sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,17278,17450);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,173);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,173);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17466,17481);

f_25144_17466_17480(
            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17495,17541);

f_25144_17495_17540(sb, f_25144_17522_17539(method));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17555,17570);

f_25144_17555_17569(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17584,17632);

f_25144_17584_17631(f_25144_17604_17626(method), sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17646,17661);

f_25144_17646_17660(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17675,17698);

f_25144_17675_17697(            sb, f_25144_17685_17696(method));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17714,18090) || true) && (f_25144_17718_17740(method))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,17714,18090);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17774,17789);

f_25144_17774_17788(                sb, "<");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17807,18000);
foreach(var typeParameter in f_25144_17837_17865_I(f_25144_17837_17865(method)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,17807,18000);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17907,17943);

f_25144_17907_17942(typeParameter, sb, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,17965,17981);

f_25144_17965_17980(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,17807,18000);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,194);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,194);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18018,18042);

f_25144_18018_18041(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18060,18075);

f_25144_18060_18074(                sb, ">");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,17714,18090);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18106,18121);

f_25144_18106_18120(
            sb, "(");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18135,18301);
foreach(var parameter in f_25144_18161_18183_I(f_25144_18161_18183(method)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,18135,18301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18217,18252);

f_25144_18217_18251(parameter, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18270,18286);

f_25144_18270_18285(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,18135,18301);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,167);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,167);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18315,18339);

f_25144_18315_18338(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18353,18369);

f_25144_18353_18368(            sb, ") ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18383,18453);

f_25144_18383_18452(sb, f_25144_18414_18451(method));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,17143,18464);

System.Text.StringBuilder
f_25144_17241_17261(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17241, 17261);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_17304_17327(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 17304, 17327);
return return_v;
}


System.Text.StringBuilder
f_25144_17361_17375(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17361, 17375);
return return_v;
}


int
f_25144_17394_17434(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17394, 17434);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_17304_17327_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17304, 17327);
return return_v;
}


System.Text.StringBuilder
f_25144_17466_17480(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17466, 17480);
return return_v;
}


System.Reflection.MethodAttributes
f_25144_17522_17539(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 17522, 17539);
return return_v;
}


System.Text.StringBuilder
f_25144_17495_17540(System.Text.StringBuilder
sb,System.Reflection.MethodAttributes
attributes)
{
var return_v = AppendMethodAttributes( sb, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17495, 17540);
return return_v;
}


System.Text.StringBuilder
f_25144_17555_17569(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17555, 17569);
return return_v;
}


System.Reflection.ParameterInfo
f_25144_17604_17626(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.ReturnParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 17604, 17626);
return return_v;
}


int
f_25144_17584_17631(System.Reflection.ParameterInfo
parameter,System.Text.StringBuilder
sb)
{
AppendParameterInfo( parameter, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17584, 17631);
return 0;
}


System.Text.StringBuilder
f_25144_17646_17660(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17646, 17660);
return return_v;
}


string
f_25144_17685_17696(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 17685, 17696);
return return_v;
}


System.Text.StringBuilder
f_25144_17675_17697(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17675, 17697);
return return_v;
}


bool
f_25144_17718_17740(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.IsGenericMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 17718, 17740);
return return_v;
}


System.Text.StringBuilder
f_25144_17774_17788(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17774, 17788);
return return_v;
}


System.Type[]
f_25144_17837_17865(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.GetGenericArguments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17837, 17865);
return return_v;
}


int
f_25144_17907_17942(System.Type
type,System.Text.StringBuilder
sb,bool
showGenericConstraints)
{
AppendType( type, sb, showGenericConstraints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17907, 17942);
return 0;
}


int
f_25144_17965_17980(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17965, 17980);
return 0;
}


System.Type[]
f_25144_17837_17865_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 17837, 17865);
return return_v;
}


int
f_25144_18018_18041(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18018, 18041);
return 0;
}


System.Text.StringBuilder
f_25144_18060_18074(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18060, 18074);
return return_v;
}


System.Text.StringBuilder
f_25144_18106_18120(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18106, 18120);
return return_v;
}


System.Reflection.ParameterInfo[]
f_25144_18161_18183(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.GetParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18161, 18183);
return return_v;
}


int
f_25144_18217_18251(System.Reflection.ParameterInfo
parameter,System.Text.StringBuilder
sb)
{
AppendParameterInfo( parameter, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18217, 18251);
return 0;
}


int
f_25144_18270_18285(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18270, 18285);
return 0;
}


System.Reflection.ParameterInfo[]
f_25144_18161_18183_I(System.Reflection.ParameterInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18161, 18183);
return return_v;
}


int
f_25144_18315_18338(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18315, 18338);
return 0;
}


System.Text.StringBuilder
f_25144_18353_18368(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18353, 18368);
return return_v;
}


System.Reflection.MethodImplAttributes
f_25144_18414_18451(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.GetMethodImplementationFlags();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18414, 18451);
return return_v;
}


System.Text.StringBuilder
f_25144_18383_18452(System.Text.StringBuilder
sb,System.Reflection.MethodImplAttributes
attributes)
{
var return_v = AppendMethodImplAttributes( sb, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18383, 18452);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,17143,18464);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,17143,18464);
}
		}

private static void AppendConstructorInfo(ConstructorInfo constructor, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,18476,21089);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18589,18610);

f_25144_18589_18609(            sb, ".method");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18626,18803);
foreach(var attribute in f_25144_18652_18680_I(f_25144_18652_18680(constructor)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,18626,18803);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18714,18729);

f_25144_18714_18728(                sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18747,18788);

f_25144_18747_18787(attribute, sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,18626,18803);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,178);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,178);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18819,18834);

f_25144_18819_18833(
            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18848,18899);

f_25144_18848_18898(sb, f_25144_18875_18897(constructor));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18913,18928);

f_25144_18913_18927(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18942,18961);

f_25144_18942_18960(            sb, "void ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,18975,19003);

f_25144_18975_19002(            sb, f_25144_18985_19001(constructor));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19019,19405) || true) && (f_25144_19023_19050(constructor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19019,19405);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19084,19099);

f_25144_19084_19098(                sb, "<");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19117,19315);
foreach(var typeParameter in f_25144_19147_19180_I(f_25144_19147_19180(constructor)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19117,19315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19222,19258);

f_25144_19222_19257(typeParameter, sb, true);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19280,19296);

f_25144_19280_19295(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19117,19315);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,199);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,199);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19333,19357);

f_25144_19333_19356(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19375,19390);

f_25144_19375_19389(                sb, ">");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19019,19405);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19421,19436);

f_25144_19421_19435(
            sb, "(");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19450,19621);
foreach(var parameter in f_25144_19476_19503_I(f_25144_19476_19503(constructor)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19450,19621);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19537,19572);

f_25144_19537_19571(parameter, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19590,19606);

f_25144_19590_19605(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19450,19621);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,172);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,172);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19635,19659);

f_25144_19635_19658(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19673,19688);

f_25144_19673_19687(            sb, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19704,19763);

var 
implFlags = f_25144_19720_19762(constructor)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19777,19860) || true) && (f_25144_19781_19823(implFlags, MethodImplAttributes.IL))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19777,19860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19842,19860);

f_25144_19842_19859(                sb, " cil");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19777,19860);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19874,19972) || true) && (f_25144_19878_19928(implFlags, MethodImplAttributes.ForwardRef))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19874,19972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19947,19972);

f_25144_19947_19971(                sb, " forwardref");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19874,19972);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,19986,20088) || true) && (f_25144_19990_20042(implFlags, MethodImplAttributes.InternalCall))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,19986,20088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20061,20088);

f_25144_20061_20087(                sb, " internalcall");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,19986,20088);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20102,20194) || true) && (f_25144_20106_20153(implFlags, MethodImplAttributes.Managed))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20102,20194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20172,20194);

f_25144_20172_20193(                sb, " managed");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20102,20194);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20208,20298) || true) && (f_25144_20212_20258(implFlags, MethodImplAttributes.Native))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20208,20298);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20277,20298);

f_25144_20277_20297(                sb, " native");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20208,20298);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20312,20410) || true) && (f_25144_20316_20366(implFlags, MethodImplAttributes.NoInlining))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20312,20410);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20385,20410);

f_25144_20385_20409(                sb, " noinlining");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20312,20410);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20424,20530) || true) && (f_25144_20428_20482(implFlags, MethodImplAttributes.NoOptimization))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20424,20530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20501,20530);

f_25144_20501_20529(                sb, " nooptimization");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20424,20530);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20544,20632) || true) && (f_25144_20548_20593(implFlags, MethodImplAttributes.OPTIL))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20544,20632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20612,20632);

f_25144_20612_20631(                sb, " optil");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20544,20632);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20646,20746) || true) && (f_25144_20650_20701(implFlags, MethodImplAttributes.PreserveSig))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20646,20746);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20720,20746);

f_25144_20720_20745(                sb, " preservesig");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20646,20746);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20760,20852) || true) && (f_25144_20764_20811(implFlags, MethodImplAttributes.Runtime))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20760,20852);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20830,20852);

f_25144_20830_20851(                sb, " runtime");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20760,20852);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20866,20968) || true) && (f_25144_20870_20922(implFlags, MethodImplAttributes.Synchronized))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20866,20968);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20941,20968);

f_25144_20941_20967(                sb, " synchronized");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20866,20968);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,20982,21078) || true) && (f_25144_20986_21035(implFlags, MethodImplAttributes.Unmanaged))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,20982,21078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21054,21078);

f_25144_21054_21077(                sb, " unmanaged");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,20982,21078);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,18476,21089);

System.Text.StringBuilder
f_25144_18589_18609(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18589, 18609);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_18652_18680(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 18652, 18680);
return return_v;
}


System.Text.StringBuilder
f_25144_18714_18728(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18714, 18728);
return return_v;
}


int
f_25144_18747_18787(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18747, 18787);
return 0;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_18652_18680_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18652, 18680);
return return_v;
}


System.Text.StringBuilder
f_25144_18819_18833(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18819, 18833);
return return_v;
}


System.Reflection.MethodAttributes
f_25144_18875_18897(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 18875, 18897);
return return_v;
}


System.Text.StringBuilder
f_25144_18848_18898(System.Text.StringBuilder
sb,System.Reflection.MethodAttributes
attributes)
{
var return_v = AppendMethodAttributes( sb, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18848, 18898);
return return_v;
}


System.Text.StringBuilder
f_25144_18913_18927(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18913, 18927);
return return_v;
}


System.Text.StringBuilder
f_25144_18942_18960(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18942, 18960);
return return_v;
}


string
f_25144_18985_19001(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 18985, 19001);
return return_v;
}


System.Text.StringBuilder
f_25144_18975_19002(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 18975, 19002);
return return_v;
}


bool
f_25144_19023_19050(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.IsGenericMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 19023, 19050);
return return_v;
}


System.Text.StringBuilder
f_25144_19084_19098(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19084, 19098);
return return_v;
}


System.Type[]
f_25144_19147_19180(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.GetGenericArguments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19147, 19180);
return return_v;
}


int
f_25144_19222_19257(System.Type
type,System.Text.StringBuilder
sb,bool
showGenericConstraints)
{
AppendType( type, sb, showGenericConstraints);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19222, 19257);
return 0;
}


int
f_25144_19280_19295(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19280, 19295);
return 0;
}


System.Type[]
f_25144_19147_19180_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19147, 19180);
return return_v;
}


int
f_25144_19333_19356(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19333, 19356);
return 0;
}


System.Text.StringBuilder
f_25144_19375_19389(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19375, 19389);
return return_v;
}


System.Text.StringBuilder
f_25144_19421_19435(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19421, 19435);
return return_v;
}


System.Reflection.ParameterInfo[]
f_25144_19476_19503(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.GetParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19476, 19503);
return return_v;
}


int
f_25144_19537_19571(System.Reflection.ParameterInfo
parameter,System.Text.StringBuilder
sb)
{
AppendParameterInfo( parameter, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19537, 19571);
return 0;
}


int
f_25144_19590_19605(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19590, 19605);
return 0;
}


System.Reflection.ParameterInfo[]
f_25144_19476_19503_I(System.Reflection.ParameterInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19476, 19503);
return return_v;
}


int
f_25144_19635_19658(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19635, 19658);
return 0;
}


System.Text.StringBuilder
f_25144_19673_19687(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19673, 19687);
return return_v;
}


System.Reflection.MethodImplAttributes
f_25144_19720_19762(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.GetMethodImplementationFlags();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19720, 19762);
return return_v;
}


bool
f_25144_19781_19823(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19781, 19823);
return return_v;
}


System.Text.StringBuilder
f_25144_19842_19859(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19842, 19859);
return return_v;
}


bool
f_25144_19878_19928(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19878, 19928);
return return_v;
}


System.Text.StringBuilder
f_25144_19947_19971(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19947, 19971);
return return_v;
}


bool
f_25144_19990_20042(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 19990, 20042);
return return_v;
}


System.Text.StringBuilder
f_25144_20061_20087(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20061, 20087);
return return_v;
}


bool
f_25144_20106_20153(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20106, 20153);
return return_v;
}


System.Text.StringBuilder
f_25144_20172_20193(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20172, 20193);
return return_v;
}


bool
f_25144_20212_20258(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20212, 20258);
return return_v;
}


System.Text.StringBuilder
f_25144_20277_20297(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20277, 20297);
return return_v;
}


bool
f_25144_20316_20366(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20316, 20366);
return return_v;
}


System.Text.StringBuilder
f_25144_20385_20409(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20385, 20409);
return return_v;
}


bool
f_25144_20428_20482(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20428, 20482);
return return_v;
}


System.Text.StringBuilder
f_25144_20501_20529(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20501, 20529);
return return_v;
}


bool
f_25144_20548_20593(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20548, 20593);
return return_v;
}


System.Text.StringBuilder
f_25144_20612_20631(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20612, 20631);
return return_v;
}


bool
f_25144_20650_20701(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20650, 20701);
return return_v;
}


System.Text.StringBuilder
f_25144_20720_20745(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20720, 20745);
return return_v;
}


bool
f_25144_20764_20811(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20764, 20811);
return return_v;
}


System.Text.StringBuilder
f_25144_20830_20851(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20830, 20851);
return return_v;
}


bool
f_25144_20870_20922(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20870, 20922);
return return_v;
}


System.Text.StringBuilder
f_25144_20941_20967(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20941, 20967);
return return_v;
}


bool
f_25144_20986_21035(System.Reflection.MethodImplAttributes
this_param,System.Reflection.MethodImplAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 20986, 21035);
return return_v;
}


System.Text.StringBuilder
f_25144_21054_21077(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21054, 21077);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,18476,21089);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,18476,21089);
}
		}

private static void AppendPropertyInfo(PropertyInfo property, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,21101,23272);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21205,21229);

f_25144_21205_21228(            sb, ".property ");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21245,21419);
foreach(var attribute in f_25144_21271_21296_I(f_25144_21271_21296(property)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,21245,21419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21330,21371);

f_25144_21330_21370(attribute, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21389,21404);

f_25144_21389_21403(                sb, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,21245,21419);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,175);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,175);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21433,21638);
foreach(var modreq in f_25144_21456_21493_I(f_25144_21456_21493(property)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,21433,21638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21527,21548);

f_25144_21527_21547(                sb, "modreq(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21566,21589);

f_25144_21566_21588(modreq, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21607,21623);

f_25144_21607_21622(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,21433,21638);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,206);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,206);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21652,21857);
foreach(var modopt in f_25144_21675_21712_I(f_25144_21675_21712(property)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,21652,21857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21746,21767);

f_25144_21746_21766(                sb, "modopt(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21785,21808);

f_25144_21785_21807(modopt, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21826,21842);

f_25144_21826_21841(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,21652,21857);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,206);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,206);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21873,22211) || true) && (f_25144_21877_21893(property)&&(DynAbs.Tracing.TraceSender.Expression_True(25144, 21877, 21914)&&f_25144_21897_21914(property)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,21873,22211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,21948,21972);

f_25144_21948_21971(                sb, "readwrite ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,21873,22211);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,21873,22211);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22006,22211) || true) && (f_25144_22010_22026(property))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22006,22211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22060,22083);

f_25144_22060_22082(                sb, "readonly ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22006,22211);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22006,22211);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22117,22211) || true) && (f_25144_22121_22138(property))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22117,22211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22172,22196);

f_25144_22172_22195(                sb, "writeonly ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22117,22211);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22006,22211);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,21873,22211);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22227,22335) || true) && (f_25144_22231_22290(f_25144_22231_22250(property), PropertyAttributes.SpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22227,22335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22309,22335);

f_25144_22309_22334(                sb, "specialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22227,22335);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22349,22461) || true) && (f_25144_22353_22414(f_25144_22353_22372(property), PropertyAttributes.RTSpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22349,22461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22433,22461);

f_25144_22433_22460(                sb, "rtspecialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22349,22461);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22477,22525);

var 
propertyAccessors = f_25144_22501_22524(property)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22539,22687) || true) && (f_25144_22543_22567(propertyAccessors)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22539,22687);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22605,22672);

f_25144_22605_22671(                sb, (DynAbs.Tracing.TraceSender.Conditional_F1(25144, 22615, 22644)||((f_25144_22615_22644(propertyAccessors[0])&&DynAbs.Tracing.TraceSender.Conditional_F2(25144, 22647, 22656))||DynAbs.Tracing.TraceSender.Conditional_F3(25144, 22659, 22670)))?"static " :"instance ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22539,22687);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22701,22739);

f_25144_22701_22738(f_25144_22712_22733(property), sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22753,22768);

f_25144_22753_22767(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22782,22807);

f_25144_22782_22806(            sb, f_25144_22792_22805(property));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22823,22875);

var 
indexParameters = f_25144_22845_22874(property)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22889,23261) || true) && (f_25144_22893_22915(indexParameters)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22889,23261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22953,22968);

f_25144_22953_22967(                sb, "(");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,22986,23171);
foreach(var indexParameter in f_25144_23017_23032_I(indexParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,22986,23171);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23074,23114);

f_25144_23074_23113(indexParameter, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23136,23152);

f_25144_23136_23151(sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22986,23171);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,186);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,186);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23189,23213);

f_25144_23189_23212(sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23231,23246);

f_25144_23231_23245(                sb, ")");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,22889,23261);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,21101,23272);

System.Text.StringBuilder
f_25144_21205_21228(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21205, 21228);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_21271_21296(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 21271, 21296);
return return_v;
}


int
f_25144_21330_21370(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21330, 21370);
return 0;
}


System.Text.StringBuilder
f_25144_21389_21403(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21389, 21403);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_21271_21296_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21271, 21296);
return return_v;
}


System.Type[]
f_25144_21456_21493(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetRequiredCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21456, 21493);
return return_v;
}


System.Text.StringBuilder
f_25144_21527_21547(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21527, 21547);
return return_v;
}


int
f_25144_21566_21588(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21566, 21588);
return 0;
}


System.Text.StringBuilder
f_25144_21607_21622(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21607, 21622);
return return_v;
}


System.Type[]
f_25144_21456_21493_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21456, 21493);
return return_v;
}


System.Type[]
f_25144_21675_21712(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetOptionalCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21675, 21712);
return return_v;
}


System.Text.StringBuilder
f_25144_21746_21766(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21746, 21766);
return return_v;
}


int
f_25144_21785_21807(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21785, 21807);
return 0;
}


System.Text.StringBuilder
f_25144_21826_21841(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21826, 21841);
return return_v;
}


System.Type[]
f_25144_21675_21712_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21675, 21712);
return return_v;
}


bool
f_25144_21877_21893(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.CanRead ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 21877, 21893);
return return_v;
}


bool
f_25144_21897_21914(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.CanWrite;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 21897, 21914);
return return_v;
}


System.Text.StringBuilder
f_25144_21948_21971(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 21948, 21971);
return return_v;
}


bool
f_25144_22010_22026(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.CanRead;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22010, 22026);
return return_v;
}


System.Text.StringBuilder
f_25144_22060_22082(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22060, 22082);
return return_v;
}


bool
f_25144_22121_22138(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.CanWrite;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22121, 22138);
return return_v;
}


System.Text.StringBuilder
f_25144_22172_22195(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22172, 22195);
return return_v;
}


System.Reflection.PropertyAttributes
f_25144_22231_22250(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22231, 22250);
return return_v;
}


bool
f_25144_22231_22290(System.Reflection.PropertyAttributes
this_param,System.Reflection.PropertyAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22231, 22290);
return return_v;
}


System.Text.StringBuilder
f_25144_22309_22334(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22309, 22334);
return return_v;
}


System.Reflection.PropertyAttributes
f_25144_22353_22372(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22353, 22372);
return return_v;
}


bool
f_25144_22353_22414(System.Reflection.PropertyAttributes
this_param,System.Reflection.PropertyAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22353, 22414);
return return_v;
}


System.Text.StringBuilder
f_25144_22433_22460(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22433, 22460);
return return_v;
}


System.Reflection.MethodInfo[]
f_25144_22501_22524(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetAccessors();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22501, 22524);
return return_v;
}


int
f_25144_22543_22567(System.Reflection.MethodInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22543, 22567);
return return_v;
}


bool
f_25144_22615_22644(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22615, 22644);
return return_v;
}


System.Text.StringBuilder
f_25144_22605_22671(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22605, 22671);
return return_v;
}


System.Type
f_25144_22712_22733(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22712, 22733);
return return_v;
}


int
f_25144_22701_22738(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22701, 22738);
return 0;
}


System.Text.StringBuilder
f_25144_22753_22767(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22753, 22767);
return return_v;
}


string
f_25144_22792_22805(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22792, 22805);
return return_v;
}


System.Text.StringBuilder
f_25144_22782_22806(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22782, 22806);
return return_v;
}


System.Reflection.ParameterInfo[]
f_25144_22845_22874(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetIndexParameters();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22845, 22874);
return return_v;
}


int
f_25144_22893_22915(System.Reflection.ParameterInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 22893, 22915);
return return_v;
}


System.Text.StringBuilder
f_25144_22953_22967(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 22953, 22967);
return return_v;
}


int
f_25144_23074_23113(System.Reflection.ParameterInfo
parameter,System.Text.StringBuilder
sb)
{
AppendParameterInfo( parameter, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23074, 23113);
return 0;
}


int
f_25144_23136_23151(System.Text.StringBuilder
sb)
{
AppendComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23136, 23151);
return 0;
}


System.Reflection.ParameterInfo[]
f_25144_23017_23032_I(System.Reflection.ParameterInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23017, 23032);
return return_v;
}


int
f_25144_23189_23212(System.Text.StringBuilder
sb)
{
RemoveTrailingComma( sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23189, 23212);
return 0;
}


System.Text.StringBuilder
f_25144_23231_23245(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23231, 23245);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,21101,23272);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,21101,23272);
}
		}

private static void AppendFieldInfo(FieldInfo field, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,23284,25366);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23379,23400);

f_25144_23379_23399(            sb, ".field ");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23416,23587);
foreach(var attribute in f_25144_23442_23464_I(f_25144_23442_23464(field)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,23416,23587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23498,23539);

f_25144_23498_23538(attribute, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23557,23572);

f_25144_23557_23571(                sb, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,23416,23587);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,172);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,172);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23603,23805);
foreach(var modreq in f_25144_23626_23660_I(f_25144_23626_23660(field)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,23603,23805);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23694,23715);

f_25144_23694_23714(                sb, "modreq(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23733,23756);

f_25144_23733_23755(modreq, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23774,23790);

f_25144_23774_23789(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,23603,23805);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,203);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,203);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23819,24021);
foreach(var modopt in f_25144_23842_23876_I(f_25144_23842_23876(field)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,23819,24021);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23910,23931);

f_25144_23910_23930(                sb, "modopt(");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23949,23972);

f_25144_23949_23971(modopt, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,23990,24006);

f_25144_23990_24005(                sb, ") ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,23819,24021);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,203);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,203);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24037,24097) || true) && (f_25144_24041_24056(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24037,24097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24075,24097);

f_25144_24075_24096(                sb, "private ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24037,24097);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24111,24169) || true) && (f_25144_24115_24129(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24111,24169);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24148,24169);

f_25144_24148_24168(                sb, "public ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24111,24169);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24183,24241) || true) && (f_25144_24187_24201(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24183,24241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24220,24241);

f_25144_24220_24240(                sb, "family ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24183,24241);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24255,24317) || true) && (f_25144_24259_24275(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24255,24317);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24294,24317);

f_25144_24294_24316(                sb, "assembly ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24255,24317);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24331,24403) || true) && (f_25144_24335_24359(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24331,24403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24378,24403);

f_25144_24378_24402(                sb, "famorassem ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24331,24403);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24417,24491) || true) && (f_25144_24421_24446(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24417,24491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24465,24491);

f_25144_24465_24490(                sb, "famandassem ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24417,24491);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24507,24569) || true) && (f_25144_24511_24527(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24507,24569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24546,24569);

f_25144_24546_24568(                sb, "initonly ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24507,24569);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24583,24643) || true) && (f_25144_24587_24602(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24583,24643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24621,24643);

f_25144_24621_24642(                sb, "literal ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24583,24643);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24657,24729) || true) && (f_25144_24661_24682(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24657,24729);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24701,24729);

f_25144_24701_24728(                sb, "notserialized ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24657,24729);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24743,24845) || true) && (f_25144_24747_24800(f_25144_24747_24763(field), FieldAttributes.SpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24743,24845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24819,24845);

f_25144_24819_24844(                sb, "specialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24743,24845);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24859,24965) || true) && (f_25144_24863_24918(f_25144_24863_24879(field), FieldAttributes.RTSpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24859,24965);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24937,24965);

f_25144_24937_24964(                sb, "rtspecialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24859,24965);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,24979,25047) || true) && (f_25144_24983_25002(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,24979,25047);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25021,25047);

f_25144_25021_25046(                sb, "pinvokeimpl ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,24979,25047);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25063,25115);

f_25144_25063_25114(
            sb, (DynAbs.Tracing.TraceSender.Conditional_F1(25144, 25073, 25087)||((f_25144_25073_25087(field)&&DynAbs.Tracing.TraceSender.Conditional_F2(25144, 25090, 25099))||DynAbs.Tracing.TraceSender.Conditional_F3(25144, 25102, 25113)))?"static " :"instance ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25129,25161);

f_25144_25129_25160(f_25144_25140_25155(field), sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25175,25190);

f_25144_25175_25189(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25204,25226);

f_25144_25204_25225(            sb, f_25144_25214_25224(field));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25242,25355) || true) && (f_25144_25246_25261(field))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,25242,25355);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25295,25340);

f_25144_25295_25339(f_25144_25307_25334(field), sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,25242,25355);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,23284,25366);

System.Text.StringBuilder
f_25144_23379_23399(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23379, 23399);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_23442_23464(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 23442, 23464);
return return_v;
}


int
f_25144_23498_23538(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23498, 23538);
return 0;
}


System.Text.StringBuilder
f_25144_23557_23571(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23557, 23571);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_23442_23464_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23442, 23464);
return return_v;
}


System.Type[]
f_25144_23626_23660(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.GetRequiredCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23626, 23660);
return return_v;
}


System.Text.StringBuilder
f_25144_23694_23714(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23694, 23714);
return return_v;
}


int
f_25144_23733_23755(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23733, 23755);
return 0;
}


System.Text.StringBuilder
f_25144_23774_23789(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23774, 23789);
return return_v;
}


System.Type[]
f_25144_23626_23660_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23626, 23660);
return return_v;
}


System.Type[]
f_25144_23842_23876(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.GetOptionalCustomModifiers();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23842, 23876);
return return_v;
}


System.Text.StringBuilder
f_25144_23910_23930(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23910, 23930);
return return_v;
}


int
f_25144_23949_23971(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23949, 23971);
return 0;
}


System.Text.StringBuilder
f_25144_23990_24005(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23990, 24005);
return return_v;
}


System.Type[]
f_25144_23842_23876_I(System.Type[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 23842, 23876);
return return_v;
}


bool
f_25144_24041_24056(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsPrivate;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24041, 24056);
return return_v;
}


System.Text.StringBuilder
f_25144_24075_24096(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24075, 24096);
return return_v;
}


bool
f_25144_24115_24129(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsPublic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24115, 24129);
return return_v;
}


System.Text.StringBuilder
f_25144_24148_24168(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24148, 24168);
return return_v;
}


bool
f_25144_24187_24201(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsFamily;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24187, 24201);
return return_v;
}


System.Text.StringBuilder
f_25144_24220_24240(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24220, 24240);
return return_v;
}


bool
f_25144_24259_24275(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24259, 24275);
return return_v;
}


System.Text.StringBuilder
f_25144_24294_24316(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24294, 24316);
return return_v;
}


bool
f_25144_24335_24359(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsFamilyOrAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24335, 24359);
return return_v;
}


System.Text.StringBuilder
f_25144_24378_24402(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24378, 24402);
return return_v;
}


bool
f_25144_24421_24446(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsFamilyAndAssembly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24421, 24446);
return return_v;
}


System.Text.StringBuilder
f_25144_24465_24490(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24465, 24490);
return return_v;
}


bool
f_25144_24511_24527(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsInitOnly;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24511, 24527);
return return_v;
}


System.Text.StringBuilder
f_25144_24546_24568(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24546, 24568);
return return_v;
}


bool
f_25144_24587_24602(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsLiteral;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24587, 24602);
return return_v;
}


System.Text.StringBuilder
f_25144_24621_24642(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24621, 24642);
return return_v;
}


bool
f_25144_24661_24682(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsNotSerialized;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24661, 24682);
return return_v;
}


System.Text.StringBuilder
f_25144_24701_24728(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24701, 24728);
return return_v;
}


System.Reflection.FieldAttributes
f_25144_24747_24763(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24747, 24763);
return return_v;
}


bool
f_25144_24747_24800(System.Reflection.FieldAttributes
this_param,System.Reflection.FieldAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24747, 24800);
return return_v;
}


System.Text.StringBuilder
f_25144_24819_24844(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24819, 24844);
return return_v;
}


System.Reflection.FieldAttributes
f_25144_24863_24879(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24863, 24879);
return return_v;
}


bool
f_25144_24863_24918(System.Reflection.FieldAttributes
this_param,System.Reflection.FieldAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24863, 24918);
return return_v;
}


System.Text.StringBuilder
f_25144_24937_24964(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 24937, 24964);
return return_v;
}


bool
f_25144_24983_25002(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsPinvokeImpl;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 24983, 25002);
return return_v;
}


System.Text.StringBuilder
f_25144_25021_25046(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25021, 25046);
return return_v;
}


bool
f_25144_25073_25087(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25073, 25087);
return return_v;
}


System.Text.StringBuilder
f_25144_25063_25114(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25063, 25114);
return return_v;
}


System.Type
f_25144_25140_25155(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.FieldType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25140, 25155);
return return_v;
}


int
f_25144_25129_25160(System.Type
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25129, 25160);
return 0;
}


System.Text.StringBuilder
f_25144_25175_25189(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25175, 25189);
return return_v;
}


string
f_25144_25214_25224(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25214, 25224);
return return_v;
}


System.Text.StringBuilder
f_25144_25204_25225(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25204, 25225);
return return_v;
}


bool
f_25144_25246_25261(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsLiteral;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25246, 25261);
return return_v;
}


object?
f_25144_25307_25334(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.GetRawConstantValue();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25307, 25334);
return return_v;
}


int
f_25144_25295_25339(object?
value,System.Text.StringBuilder
sb)
{
AppendValue( value, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25295, 25339);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,23284,25366);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,23284,25366);
}
		}

private static void AppendEventInfo(EventInfo @event, StringBuilder sb)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,25378,26056);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25474,25495);

f_25144_25474_25494(            sb, ".event ");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25511,25683);
foreach(var attribute in f_25144_25537_25560_I(f_25144_25537_25560(@event)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,25511,25683);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25594,25635);

f_25144_25594_25634(attribute, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25653,25668);

f_25144_25653_25667(                sb, " ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,25511,25683);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,173);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,173);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25699,25802) || true) && (f_25144_25703_25757(f_25144_25703_25720(@event), EventAttributes.SpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,25699,25802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25776,25802);

f_25144_25776_25801(                sb, "specialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,25699,25802);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25816,25923) || true) && (f_25144_25820_25876(f_25144_25820_25837(@event), EventAttributes.RTSpecialName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,25816,25923);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25895,25923);

f_25144_25895_25922(                sb, "rtspecialname ");
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,25816,25923);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25939,25979);

f_25144_25939_25978(f_25144_25950_25973(@event), sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,25993,26008);

f_25144_25993_26007(            sb, " ");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26022,26045);

f_25144_26022_26044(            sb, f_25144_26032_26043(@event));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,25378,26056);

System.Text.StringBuilder
f_25144_25474_25494(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25474, 25494);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_25537_25560(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.CustomAttributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25537, 25560);
return return_v;
}


int
f_25144_25594_25634(System.Reflection.CustomAttributeData
attribute,System.Text.StringBuilder
sb)
{
AppendCustomAttributeData( attribute, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25594, 25634);
return 0;
}


System.Text.StringBuilder
f_25144_25653_25667(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25653, 25667);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
f_25144_25537_25560_I(System.Collections.Generic.IEnumerable<System.Reflection.CustomAttributeData>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25537, 25560);
return return_v;
}


System.Reflection.EventAttributes
f_25144_25703_25720(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25703, 25720);
return return_v;
}


bool
f_25144_25703_25757(System.Reflection.EventAttributes
this_param,System.Reflection.EventAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25703, 25757);
return return_v;
}


System.Text.StringBuilder
f_25144_25776_25801(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25776, 25801);
return return_v;
}


System.Reflection.EventAttributes
f_25144_25820_25837(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25820, 25837);
return return_v;
}


bool
f_25144_25820_25876(System.Reflection.EventAttributes
this_param,System.Reflection.EventAttributes
flag)
{
var return_v = this_param.HasFlag( (System.Enum)flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25820, 25876);
return return_v;
}


System.Text.StringBuilder
f_25144_25895_25922(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25895, 25922);
return return_v;
}


System.Type?
f_25144_25950_25973(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.EventHandlerType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 25950, 25973);
return return_v;
}


int
f_25144_25939_25978(System.Type?
type,System.Text.StringBuilder
sb)
{
AppendType( type, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25939, 25978);
return 0;
}


System.Text.StringBuilder
f_25144_25993_26007(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 25993, 26007);
return return_v;
}


string
f_25144_26032_26043(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 26032, 26043);
return return_v;
}


System.Text.StringBuilder
f_25144_26022_26044(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26022, 26044);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,25378,26056);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,25378,26056);
}
		}

public static IEnumerable<string> GetMemberSignatures(System.Reflection.Assembly assembly, string fullyQualifiedTypeName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,26088,27901);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26234,26270);

var 
candidates = f_25144_26251_26269()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26284,26313);

var 
sb = f_25144_26293_26312()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26327,26379);

var 
type = f_25144_26338_26378(assembly, fullyQualifiedTypeName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26393,27858) || true) && (type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,26393,27858);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26443,26724);
foreach(var constructor in f_25144_26471_26539_I(f_25144_26471_26539(f_25144_26471_26506(type, BINDING_FLAGS), (member) => member.Name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,26443,26724);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26581,26620);

f_25144_26581_26619(constructor, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26642,26672);

f_25144_26642_26671(                    candidates, f_25144_26657_26670(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26694,26705);

f_25144_26694_26704(                    sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,26443,26724);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,282);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,282);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26742,27003);
foreach(var method in f_25144_26765_26828_I(f_25144_26765_26828(f_25144_26765_26795(type, BINDING_FLAGS), (member) => member.Name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,26742,27003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26870,26899);

f_25144_26870_26898(method, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26921,26951);

f_25144_26921_26950(                    candidates, f_25144_26936_26949(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,26973,26984);

f_25144_26973_26983(                    sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,26742,27003);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,262);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,262);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27021,27291);
foreach(var property in f_25144_27046_27112_I(f_25144_27046_27112(f_25144_27046_27079(type, BINDING_FLAGS), (member) => member.Name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,27021,27291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27154,27187);

f_25144_27154_27186(property, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27209,27239);

f_25144_27209_27238(                    candidates, f_25144_27224_27237(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27261,27272);

f_25144_27261_27271(                    sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,27021,27291);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,271);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,271);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27309,27568);
foreach(var @event in f_25144_27332_27394_I(f_25144_27332_27394(f_25144_27332_27361(type, BINDING_FLAGS), (member) => member.Name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,27309,27568);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27436,27464);

f_25144_27436_27463(@event, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27486,27516);

f_25144_27486_27515(                    candidates, f_25144_27501_27514(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27538,27549);

f_25144_27538_27548(                    sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,27309,27568);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,260);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,260);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27586,27843);
foreach(var field in f_25144_27608_27670_I(f_25144_27608_27670(f_25144_27608_27637(type, BINDING_FLAGS), (member) => member.Name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,27586,27843);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27712,27739);

f_25144_27712_27738(field, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27761,27791);

f_25144_27761_27790(                    candidates, f_25144_27776_27789(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27813,27824);

f_25144_27813_27823(                    sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,27586,27843);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,258);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,258);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25144,26393,27858);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,27872,27890);

return candidates;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,26088,27901);

System.Collections.Generic.List<string>
f_25144_26251_26269()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26251, 26269);
return return_v;
}


System.Text.StringBuilder
f_25144_26293_26312()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26293, 26312);
return return_v;
}


System.Type?
f_25144_26338_26378(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetType( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26338, 26378);
return return_v;
}


System.Reflection.ConstructorInfo[]
f_25144_26471_26506(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetConstructors( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26471, 26506);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.ConstructorInfo>
f_25144_26471_26539(System.Reflection.ConstructorInfo[]
source,System.Func<System.Reflection.ConstructorInfo, string>
keySelector)
{
var return_v = source.OrderBy<System.Reflection.ConstructorInfo,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26471, 26539);
return return_v;
}


int
f_25144_26581_26619(System.Reflection.ConstructorInfo
constructor,System.Text.StringBuilder
sb)
{
AppendConstructorInfo( constructor, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26581, 26619);
return 0;
}


string
f_25144_26657_26670(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26657, 26670);
return return_v;
}


int
f_25144_26642_26671(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26642, 26671);
return 0;
}


System.Text.StringBuilder
f_25144_26694_26704(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26694, 26704);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.ConstructorInfo>
f_25144_26471_26539_I(System.Linq.IOrderedEnumerable<System.Reflection.ConstructorInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26471, 26539);
return return_v;
}


System.Reflection.MethodInfo[]
f_25144_26765_26795(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMethods( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26765, 26795);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.MethodInfo>
f_25144_26765_26828(System.Reflection.MethodInfo[]
source,System.Func<System.Reflection.MethodInfo, string>
keySelector)
{
var return_v = source.OrderBy<System.Reflection.MethodInfo,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26765, 26828);
return return_v;
}


int
f_25144_26870_26898(System.Reflection.MethodInfo
method,System.Text.StringBuilder
sb)
{
AppendMethodInfo( method, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26870, 26898);
return 0;
}


string
f_25144_26936_26949(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26936, 26949);
return return_v;
}


int
f_25144_26921_26950(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26921, 26950);
return 0;
}


System.Text.StringBuilder
f_25144_26973_26983(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26973, 26983);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.MethodInfo>
f_25144_26765_26828_I(System.Linq.IOrderedEnumerable<System.Reflection.MethodInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 26765, 26828);
return return_v;
}


System.Reflection.PropertyInfo[]
f_25144_27046_27079(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetProperties( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27046, 27079);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.PropertyInfo>
f_25144_27046_27112(System.Reflection.PropertyInfo[]
source,System.Func<System.Reflection.PropertyInfo, string>
keySelector)
{
var return_v = source.OrderBy<System.Reflection.PropertyInfo,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27046, 27112);
return return_v;
}


int
f_25144_27154_27186(System.Reflection.PropertyInfo
property,System.Text.StringBuilder
sb)
{
AppendPropertyInfo( property, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27154, 27186);
return 0;
}


string
f_25144_27224_27237(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27224, 27237);
return return_v;
}


int
f_25144_27209_27238(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27209, 27238);
return 0;
}


System.Text.StringBuilder
f_25144_27261_27271(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27261, 27271);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.PropertyInfo>
f_25144_27046_27112_I(System.Linq.IOrderedEnumerable<System.Reflection.PropertyInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27046, 27112);
return return_v;
}


System.Reflection.EventInfo[]
f_25144_27332_27361(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetEvents( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27332, 27361);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.EventInfo>
f_25144_27332_27394(System.Reflection.EventInfo[]
source,System.Func<System.Reflection.EventInfo, string>
keySelector)
{
var return_v = source.OrderBy<System.Reflection.EventInfo,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27332, 27394);
return return_v;
}


int
f_25144_27436_27463(System.Reflection.EventInfo
@event,System.Text.StringBuilder
sb)
{
AppendEventInfo( @event, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27436, 27463);
return 0;
}


string
f_25144_27501_27514(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27501, 27514);
return return_v;
}


int
f_25144_27486_27515(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27486, 27515);
return 0;
}


System.Text.StringBuilder
f_25144_27538_27548(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27538, 27548);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.EventInfo>
f_25144_27332_27394_I(System.Linq.IOrderedEnumerable<System.Reflection.EventInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27332, 27394);
return return_v;
}


System.Reflection.FieldInfo[]
f_25144_27608_27637(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetFields( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27608, 27637);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.FieldInfo>
f_25144_27608_27670(System.Reflection.FieldInfo[]
source,System.Func<System.Reflection.FieldInfo, string>
keySelector)
{
var return_v = source.OrderBy<System.Reflection.FieldInfo,string>( keySelector);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27608, 27670);
return return_v;
}


int
f_25144_27712_27738(System.Reflection.FieldInfo
field,System.Text.StringBuilder
sb)
{
AppendFieldInfo( field, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27712, 27738);
return 0;
}


string
f_25144_27776_27789(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27776, 27789);
return return_v;
}


int
f_25144_27761_27790(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27761, 27790);
return 0;
}


System.Text.StringBuilder
f_25144_27813_27823(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27813, 27823);
return return_v;
}


System.Linq.IOrderedEnumerable<System.Reflection.FieldInfo>
f_25144_27608_27670_I(System.Linq.IOrderedEnumerable<System.Reflection.FieldInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 27608, 27670);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,26088,27901);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,26088,27901);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static IEnumerable<string> GetMemberSignatures(System.Reflection.Assembly assembly, string fullyQualifiedTypeName, string memberName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25144,27913,30646);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28078,28112);

IEnumerable<string> 
retVal = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28126,30607) || true) && (f_25144_28130_28167(memberName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28126,30607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28201,28264);

retVal = f_25144_28210_28263(assembly, fullyQualifiedTypeName);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28126,30607);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28126,30607);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28330,28359);

var 
sb = f_25144_28339_28358()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28377,28429);

var 
type = f_25144_28388_28428(assembly, fullyQualifiedTypeName)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28447,28488);

var 
candidates = f_25144_28464_28487()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28508,30552) || true) && (type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28508,30552);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28566,28961);
foreach(var constructor in f_25144_28594_28629_I(f_25144_28594_28629(type, BINDING_FLAGS)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28566,28961);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28679,28938) || true) && (f_25144_28683_28699(constructor)== memberName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28679,28938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28771,28810);

f_25144_28771_28809(constructor, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28840,28870);

f_25144_28840_28869(                            candidates, f_25144_28855_28868(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28900,28911);

f_25144_28900_28910(                            sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28679,28938);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28566,28961);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,396);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,396);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,28983,29353);
foreach(var method in f_25144_29006_29036_I(f_25144_29006_29036(type, BINDING_FLAGS)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,28983,29353);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29086,29330) || true) && (f_25144_29090_29101(method)== memberName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,29086,29330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29173,29202);

f_25144_29173_29201(method, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29232,29262);

f_25144_29232_29261(                            candidates, f_25144_29247_29260(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29292,29303);

f_25144_29292_29302(                            sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,29086,29330);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28983,29353);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,371);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,371);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29375,29756);
foreach(var property in f_25144_29400_29433_I(f_25144_29400_29433(type, BINDING_FLAGS)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,29375,29756);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29483,29733) || true) && (f_25144_29487_29500(property)== memberName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,29483,29733);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29572,29605);

f_25144_29572_29604(property, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29635,29665);

f_25144_29635_29664(                            candidates, f_25144_29650_29663(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29695,29706);

f_25144_29695_29705(                            sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,29483,29733);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,29375,29756);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,382);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,382);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29778,30146);
foreach(var @event in f_25144_29801_29830_I(f_25144_29801_29830(type, BINDING_FLAGS)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,29778,30146);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29880,30123) || true) && (f_25144_29884_29895(@event)== memberName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,29880,30123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,29967,29995);

f_25144_29967_29994(@event, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30025,30055);

f_25144_30025_30054(                            candidates, f_25144_30040_30053(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30085,30096);

f_25144_30085_30095(                            sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,29880,30123);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,29778,30146);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,369);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,369);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30168,30533);
foreach(var field in f_25144_30190_30219_I(f_25144_30190_30219(type, BINDING_FLAGS)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,30168,30533);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30269,30510) || true) && (f_25144_30273_30283(field)== memberName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25144,30269,30510);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30355,30382);

f_25144_30355_30381(field, sb);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30412,30442);

f_25144_30412_30441(                            candidates, f_25144_30427_30440(sb));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30472,30483);

f_25144_30472_30482(                            sb);
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,30269,30510);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,30168,30533);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25144,1,366);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25144,1,366);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28508,30552);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30572,30592);

retVal = candidates;
DynAbs.Tracing.TraceSender.TraceExitCondition(25144,28126,30607);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,30621,30635);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25144,27913,30646);

bool
f_25144_28130_28167(string
value)
{
var return_v = string.IsNullOrWhiteSpace( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28130, 28167);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_25144_28210_28263(System.Reflection.Assembly
assembly,string
fullyQualifiedTypeName)
{
var return_v = GetMemberSignatures( assembly, fullyQualifiedTypeName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28210, 28263);
return return_v;
}


System.Text.StringBuilder
f_25144_28339_28358()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28339, 28358);
return return_v;
}


System.Type?
f_25144_28388_28428(System.Reflection.Assembly
this_param,string
name)
{
var return_v = this_param.GetType( name);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28388, 28428);
return return_v;
}


System.Collections.Generic.SortedSet<string>
f_25144_28464_28487()
{
var return_v = new System.Collections.Generic.SortedSet<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28464, 28487);
return return_v;
}


System.Reflection.ConstructorInfo[]
f_25144_28594_28629(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetConstructors( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28594, 28629);
return return_v;
}


string
f_25144_28683_28699(System.Reflection.ConstructorInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 28683, 28699);
return return_v;
}


int
f_25144_28771_28809(System.Reflection.ConstructorInfo
constructor,System.Text.StringBuilder
sb)
{
AppendConstructorInfo( constructor, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28771, 28809);
return 0;
}


string
f_25144_28855_28868(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28855, 28868);
return return_v;
}


bool
f_25144_28840_28869(System.Collections.Generic.SortedSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28840, 28869);
return return_v;
}


System.Text.StringBuilder
f_25144_28900_28910(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28900, 28910);
return return_v;
}


System.Reflection.ConstructorInfo[]
f_25144_28594_28629_I(System.Reflection.ConstructorInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 28594, 28629);
return return_v;
}


System.Reflection.MethodInfo[]
f_25144_29006_29036(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMethods( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29006, 29036);
return return_v;
}


string
f_25144_29090_29101(System.Reflection.MethodInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 29090, 29101);
return return_v;
}


int
f_25144_29173_29201(System.Reflection.MethodInfo
method,System.Text.StringBuilder
sb)
{
AppendMethodInfo( method, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29173, 29201);
return 0;
}


string
f_25144_29247_29260(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29247, 29260);
return return_v;
}


bool
f_25144_29232_29261(System.Collections.Generic.SortedSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29232, 29261);
return return_v;
}


System.Text.StringBuilder
f_25144_29292_29302(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29292, 29302);
return return_v;
}


System.Reflection.MethodInfo[]
f_25144_29006_29036_I(System.Reflection.MethodInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29006, 29036);
return return_v;
}


System.Reflection.PropertyInfo[]
f_25144_29400_29433(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetProperties( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29400, 29433);
return return_v;
}


string
f_25144_29487_29500(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 29487, 29500);
return return_v;
}


int
f_25144_29572_29604(System.Reflection.PropertyInfo
property,System.Text.StringBuilder
sb)
{
AppendPropertyInfo( property, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29572, 29604);
return 0;
}


string
f_25144_29650_29663(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29650, 29663);
return return_v;
}


bool
f_25144_29635_29664(System.Collections.Generic.SortedSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29635, 29664);
return return_v;
}


System.Text.StringBuilder
f_25144_29695_29705(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29695, 29705);
return return_v;
}


System.Reflection.PropertyInfo[]
f_25144_29400_29433_I(System.Reflection.PropertyInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29400, 29433);
return return_v;
}


System.Reflection.EventInfo[]
f_25144_29801_29830(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetEvents( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29801, 29830);
return return_v;
}


string
f_25144_29884_29895(System.Reflection.EventInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 29884, 29895);
return return_v;
}


int
f_25144_29967_29994(System.Reflection.EventInfo
@event,System.Text.StringBuilder
sb)
{
AppendEventInfo( @event, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29967, 29994);
return 0;
}


string
f_25144_30040_30053(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30040, 30053);
return return_v;
}


bool
f_25144_30025_30054(System.Collections.Generic.SortedSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30025, 30054);
return return_v;
}


System.Text.StringBuilder
f_25144_30085_30095(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30085, 30095);
return return_v;
}


System.Reflection.EventInfo[]
f_25144_29801_29830_I(System.Reflection.EventInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 29801, 29830);
return return_v;
}


System.Reflection.FieldInfo[]
f_25144_30190_30219(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetFields( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30190, 30219);
return return_v;
}


string
f_25144_30273_30283(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Name ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25144, 30273, 30283);
return return_v;
}


int
f_25144_30355_30381(System.Reflection.FieldInfo
field,System.Text.StringBuilder
sb)
{
AppendFieldInfo( field, sb);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30355, 30381);
return 0;
}


string
f_25144_30427_30440(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30427, 30440);
return return_v;
}


bool
f_25144_30412_30441(System.Collections.Generic.SortedSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30412, 30441);
return return_v;
}


System.Text.StringBuilder
f_25144_30472_30482(System.Text.StringBuilder
this_param)
{
var return_v = this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30472, 30482);
return return_v;
}


System.Reflection.FieldInfo[]
f_25144_30190_30219_I(System.Reflection.FieldInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25144, 30190, 30219);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25144,27913,30646);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,27913,30646);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public MetadataSignatureHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25144,480,30653);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25144,480,30653);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,480,30653);
}


static MetadataSignatureHelper()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25144,480,30653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25144,585,736);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25144,480,30653);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25144,480,30653);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25144,480,30653);
}
}
