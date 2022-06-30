// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
internal sealed class CommonAttributeDataComparer : IEqualityComparer<AttributeData>
{
public static CommonAttributeDataComparer Instance ;

private CommonAttributeDataComparer() 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(788,877,918);
DynAbs.Tracing.TraceSender.TraceExitConstructor(788,877,918);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(788,877,918);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,877,918);
}
		}

public bool Equals(AttributeData attr1, AttributeData attr2)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(788,930,1555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1015,1043);

f_788_1015_1042(attr1 != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1057,1085);

f_788_1057_1084(attr2 != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1101,1544);

return f_788_1108_1128(attr1)== f_788_1132_1152(attr2)&&(DynAbs.Tracing.TraceSender.Expression_True(788, 1108, 1229)&&f_788_1173_1199(attr1)== f_788_1203_1229(attr2))&&(DynAbs.Tracing.TraceSender.Expression_True(788, 1108, 1284)&&f_788_1250_1265(attr1)== f_788_1269_1284(attr2))&&(DynAbs.Tracing.TraceSender.Expression_True(788, 1108, 1365)&&f_788_1305_1333(attr1)== f_788_1337_1365(attr2))&&(DynAbs.Tracing.TraceSender.Expression_True(788, 1108, 1466)&&                attr1.CommonConstructorArguments.SequenceEqual(f_788_1433_1465(attr2)))&&(DynAbs.Tracing.TraceSender.Expression_True(788, 1108, 1543)&&                attr1.NamedArguments.SequenceEqual(f_788_1522_1542(attr2)));
DynAbs.Tracing.TraceSender.TraceExitMethod(788,930,1555);

int
f_788_1015_1042(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1015, 1042);
return 0;
}


int
f_788_1057_1084(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1057, 1084);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol?
f_788_1108_1128(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeClass ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1108, 1128);
return return_v;
}


Microsoft.CodeAnalysis.INamedTypeSymbol?
f_788_1132_1152(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeClass ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1132, 1152);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_788_1173_1199(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1173, 1199);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_788_1203_1229(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1203, 1229);
return return_v;
}


bool
f_788_1250_1265(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.HasErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1250, 1265);
return return_v;
}


bool
f_788_1269_1284(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.HasErrors ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1269, 1284);
return return_v;
}


bool
f_788_1305_1333(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.IsConditionallyOmitted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1305, 1333);
return return_v;
}


bool
f_788_1337_1365(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.IsConditionallyOmitted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1337, 1365);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_788_1433_1465(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1433, 1465);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_788_1522_1542(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1522, 1542);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(788,930,1555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,930,1555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public int GetHashCode(AttributeData attr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(788,1567,2216);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1634,1661);

f_788_1634_1660(attr != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1677,1728);

int 
hash = f_788_1688_1722_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_788_1688_1707(attr), 788, 1688, 1722).GetHashCode())??(DynAbs.Tracing.TraceSender.Expression_Null<int?>(788, 1688, 1727)??0)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1742,1852);

hash = (DynAbs.Tracing.TraceSender.Conditional_F1(788, 1749, 1782)||((f_788_1749_1774(attr)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(788, 1785, 1844))||DynAbs.Tracing.TraceSender.Conditional_F3(788, 1847, 1851)))?f_788_1785_1844(f_788_1798_1837(f_788_1798_1823(attr)), hash):hash;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1866,1908);

hash = f_788_1873_1907(f_788_1886_1900(attr), hash);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1922,1977);

hash = f_788_1929_1976(f_788_1942_1969(attr), hash);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,1991,2086);

hash = f_788_1998_2085(f_788_2011_2078(f_788_2046_2077(attr)), hash);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2100,2177);

hash = f_788_2107_2176(f_788_2120_2169(f_788_2149_2168(attr)), hash);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2193,2205);

return hash;
DynAbs.Tracing.TraceSender.TraceExitMethod(788,1567,2216);

int
f_788_1634_1660(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1634, 1660);
return 0;
}


Microsoft.CodeAnalysis.INamedTypeSymbol?
f_788_1688_1707(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeClass;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1688, 1707);
return return_v;
}


int?
f_788_1688_1722_I(int?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1688, 1722);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol?
f_788_1749_1774(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1749, 1774);
return return_v;
}


Microsoft.CodeAnalysis.IMethodSymbol
f_788_1798_1823(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.AttributeConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1798, 1823);
return return_v;
}


int
f_788_1798_1837(Microsoft.CodeAnalysis.IMethodSymbol
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1798, 1837);
return return_v;
}


int
f_788_1785_1844(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1785, 1844);
return return_v;
}


bool
f_788_1886_1900(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.HasErrors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1886, 1900);
return return_v;
}


int
f_788_1873_1907(bool
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1873, 1907);
return return_v;
}


bool
f_788_1942_1969(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.IsConditionallyOmitted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 1942, 1969);
return return_v;
}


int
f_788_1929_1976(bool
newKeyPart,int
currentKey)
{
var return_v = Hash.Combine( newKeyPart, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1929, 1976);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_788_2046_2077(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.CommonConstructorArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 2046, 2077);
return return_v;
}


int
f_788_2011_2078(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
constructorArguments)
{
var return_v = GetHashCodeForConstructorArguments( constructorArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2011, 2078);
return return_v;
}


int
f_788_1998_2085(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 1998, 2085);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_788_2149_2168(Microsoft.CodeAnalysis.AttributeData
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(788, 2149, 2168);
return return_v;
}


int
f_788_2120_2169(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
namedArguments)
{
var return_v = GetHashCodeForNamedArguments( namedArguments);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2120, 2169);
return return_v;
}


int
f_788_2107_2176(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2107, 2176);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(788,1567,2216);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,1567,2216);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetHashCodeForConstructorArguments(ImmutableArray<TypedConstant> constructorArguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(788,2228,2560);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2358,2371);

int 
hash = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2387,2521);
foreach(var arg in f_788_2407_2427_I(constructorArguments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(788,2387,2521);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2461,2506);

hash = f_788_2468_2505(arg.GetHashCode(), hash);
DynAbs.Tracing.TraceSender.TraceExitCondition(788,2387,2521);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(788,1,135);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(788,1,135);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2537,2549);

return hash;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(788,2228,2560);

int
f_788_2468_2505(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2468, 2505);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
f_788_2407_2427_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2407, 2427);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(788,2228,2560);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,2228,2560);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static int GetHashCodeForNamedArguments(ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(788,2572,3063);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2712,2725);

int 
hash = 0
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2741,3024);
foreach(var arg in f_788_2761_2775_I(namedArguments) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(788,2741,3024);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2809,2938) || true) && (arg.Key != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(788,2809,2938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2870,2919);

hash = f_788_2877_2918(f_788_2890_2911(arg.Key), hash);
DynAbs.Tracing.TraceSender.TraceExitCondition(788,2809,2938);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,2958,3009);

hash = f_788_2965_3008(arg.Value.GetHashCode(), hash);
DynAbs.Tracing.TraceSender.TraceExitCondition(788,2741,3024);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(788,1,284);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(788,1,284);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,3040,3052);

return hash;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(788,2572,3063);

int
f_788_2890_2911(string
this_param)
{
var return_v = this_param.GetHashCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2890, 2911);
return return_v;
}


int
f_788_2877_2918(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2877, 2918);
return return_v;
}


int
f_788_2965_3008(int
newKey,int
currentKey)
{
var return_v = Hash.Combine( newKey, currentKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2965, 3008);
return return_v;
}


System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
f_788_2761_2775_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 2761, 2775);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(788,2572,3063);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,2572,3063);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static CommonAttributeDataComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(788,679,3070);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(788,822,866);
Instance = f_788_833_866();DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(788,679,3070);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(788,679,3070);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(788,679,3070);

static Microsoft.CodeAnalysis.CommonAttributeDataComparer
f_788_833_866()
{
var return_v = new Microsoft.CodeAnalysis.CommonAttributeDataComparer();
DynAbs.Tracing.TraceSender.TraceEndInvocation(788, 833, 866);
return return_v;
}

}
}
