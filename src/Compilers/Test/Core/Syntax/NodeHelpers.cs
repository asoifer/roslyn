// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public static partial class NodeHelpers
{
public static ISyntaxNodeKindProvider KindProvider
{            get;
            set;
}

public static string GetKind(this SyntaxNodeOrToken n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,914,1032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,993,1021);

return f_25130_1000_1020(f_25130_1000_1012(), n);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,914,1032);

Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
f_25130_1000_1012()
{
var return_v = KindProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 1000, 1012);
return return_v;
}


string
f_25130_1000_1020(Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
this_param,Microsoft.CodeAnalysis.SyntaxNodeOrToken
node)
{
var return_v = this_param.Kind( (object)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1000, 1020);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,914,1032);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,914,1032);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetKind(this SyntaxNode n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1044,1155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1116,1144);

return f_25130_1123_1143(f_25130_1123_1135(), n);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1044,1155);

Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
f_25130_1123_1135()
{
var return_v = KindProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 1123, 1135);
return return_v;
}


string
f_25130_1123_1143(Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
this_param,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.Kind( (object)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1123, 1143);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1044,1155);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1044,1155);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetKind(this SyntaxToken n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1167,1279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1240,1268);

return f_25130_1247_1267(f_25130_1247_1259(), n);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1167,1279);

Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
f_25130_1247_1259()
{
var return_v = KindProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 1247, 1259);
return return_v;
}


string
f_25130_1247_1267(Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
this_param,Microsoft.CodeAnalysis.SyntaxToken
node)
{
var return_v = this_param.Kind( (object)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1247, 1267);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1167,1279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1167,1279);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static string GetKind(this SyntaxTrivia n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1291,1404);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1365,1393);

return f_25130_1372_1392(f_25130_1372_1384(), n);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1291,1404);

Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
f_25130_1372_1384()
{
var return_v = KindProvider;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 1372, 1384);
return return_v;
}


string
f_25130_1372_1392(Microsoft.CodeAnalysis.Test.Utilities.ISyntaxNodeKindProvider
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
node)
{
var return_v = this_param.Kind( (object)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1372, 1392);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1291,1404);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1291,1404);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsIdentifier(this SyntaxToken n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1416,1604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1492,1593);

return f_25130_1499_1533(n.GetKind(), "Identifier")&&(DynAbs.Tracing.TraceSender.Expression_True(25130, 1499, 1553)&&n.Parent != null )&&(DynAbs.Tracing.TraceSender.Expression_True(25130, 1499, 1592)&&f_25130_1557_1592(f_25130_1557_1575(n.Parent), "Name"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1416,1604);

bool
f_25130_1499_1533(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1499, 1533);
return return_v;
}


string
f_25130_1557_1575(Microsoft.CodeAnalysis.SyntaxNode
n)
{
var return_v = n.GetKind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1557, 1575);
return return_v;
}


bool
f_25130_1557_1592(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1557, 1592);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1416,1604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1416,1604);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsKeyword(this SyntaxToken n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1616,1888);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1689,1712);

var 
kind = n.GetKind()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1726,1877);

return f_25130_1733_1783(kind, "Keyword", StringComparison.Ordinal)||(DynAbs.Tracing.TraceSender.Expression_False(25130, 1733, 1876)||(f_25130_1788_1815(kind, "Identifier")&&(DynAbs.Tracing.TraceSender.Expression_True(25130, 1788, 1835)&&n.Parent != null )&&(DynAbs.Tracing.TraceSender.Expression_True(25130, 1788, 1875)&&!f_25130_1840_1875(f_25130_1840_1858(n.Parent), "Name"))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1616,1888);

bool
f_25130_1733_1783(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.EndsWith( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1733, 1783);
return return_v;
}


bool
f_25130_1788_1815(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1788, 1815);
return return_v;
}


string
f_25130_1840_1858(Microsoft.CodeAnalysis.SyntaxNode
n)
{
var return_v = n.GetKind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1840, 1858);
return return_v;
}


bool
f_25130_1840_1875(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1840, 1875);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1616,1888);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1616,1888);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsLiteral(this SyntaxToken n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,1900,2023);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,1973,2012);

return f_25130_1980_2011(n.GetKind(), "Literal");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,1900,2023);

bool
f_25130_1980_2011(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 1980, 2011);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,1900,2023);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,1900,2023);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsComment(this SyntaxTrivia n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,2035,2159);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2109,2148);

return f_25130_2116_2147(n.GetKind(), "Comment");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,2035,2159);

bool
f_25130_2116_2147(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 2116, 2147);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,2035,2159);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,2035,2159);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsDocumentationComment(this SyntaxTrivia n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,2171,2321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2258,2310);

return f_25130_2265_2309(n.GetKind(), "DocumentationComment");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,2171,2321);

bool
f_25130_2265_2309(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 2265, 2309);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,2171,2321);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,2171,2321);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static bool IsDisabledOrSkippedText(this SyntaxTrivia n)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,2333,2530);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2421,2444);

var 
kind = n.GetKind()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2458,2519);

return f_25130_2465_2490(kind, "Disabled")||(DynAbs.Tracing.TraceSender.Expression_False(25130, 2465, 2518)||f_25130_2494_2518(kind, "Skipped"));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,2333,2530);

bool
f_25130_2465_2490(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 2465, 2490);
return return_v;
}


bool
f_25130_2494_2518(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 2494, 2518);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,2333,2530);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,2333,2530);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxNode GetRootNode(this SyntaxNodeOrToken node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,2542,2917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2632,2657);

SyntaxNode 
retVal = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2671,2876) || true) && (node.IsNode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,2671,2876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2720,2757);

retVal = f_25130_2729_2756(node.AsNode());
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,2671,2876);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,2671,2876);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2823,2861);

retVal = node.AsToken().GetRootNode();
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,2671,2876);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,2892,2906);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,2542,2917);

Microsoft.CodeAnalysis.SyntaxNode
f_25130_2729_2756(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = node.GetRootNode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 2729, 2756);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,2542,2917);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,2542,2917);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxNode GetRootNode(this SyntaxToken node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,2929,3279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3013,3045);

SyntaxNode 
retVal = node.Parent
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3059,3238) || true) && (retVal != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,3059,3238);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3111,3223) || true) && (f_25130_3118_3131(retVal)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,3111,3223);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3181,3204);

retVal = f_25130_3190_3203(retVal);
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,3111,3223);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25130,3111,3223);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25130,3111,3223);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25130,3059,3238);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3254,3268);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,2929,3279);

Microsoft.CodeAnalysis.SyntaxNode?
f_25130_3118_3131(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3118, 3131);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25130_3190_3203(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3190, 3203);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,2929,3279);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,2929,3279);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxNode GetRootNode(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,3291,3583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3374,3428);

var 
retVal = (DynAbs.Tracing.TraceSender.Conditional_F1(25130, 3387, 3406)||((f_25130_3387_3398(node)== null &&DynAbs.Tracing.TraceSender.Conditional_F2(25130, 3409, 3413))||DynAbs.Tracing.TraceSender.Conditional_F3(25130, 3416, 3427)))?node :f_25130_3416_3427(node)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3442,3542) || true) && (f_25130_3449_3462(retVal)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,3442,3542);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3504,3527);

retVal = f_25130_3513_3526(retVal);
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,3442,3542);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25130,3442,3542);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25130,3442,3542);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3558,3572);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,3291,3583);

Microsoft.CodeAnalysis.SyntaxNode?
f_25130_3387_3398(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3387, 3398);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25130_3416_3427(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3416, 3427);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode?
f_25130_3449_3462(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3449, 3462);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_25130_3513_3526(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3513, 3526);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,3291,3583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,3291,3583);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxNode GetRootNode(this SyntaxTrivia node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,3595,3945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3680,3718);

SyntaxNode 
retVal = node.Token.Parent
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3732,3904) || true) && (retVal != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,3732,3904);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3784,3889) || true) && (retVal != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,3784,3889);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3847,3870);

retVal = f_25130_3856_3869(retVal);
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,3784,3889);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25130,3784,3889);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25130,3784,3889);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25130,3732,3904);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,3920,3934);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,3595,3945);

Microsoft.CodeAnalysis.SyntaxNode?
f_25130_3856_3869(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 3856, 3869);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,3595,3945);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,3595,3945);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NodeInfo GetNodeInfo(this SyntaxNodeOrToken nodeOrToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,3957,4354);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4052,4075);

NodeInfo 
retVal = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4089,4313) || true) && (nodeOrToken.IsNode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,4089,4313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4145,4188);

retVal = f_25130_4154_4187(nodeOrToken.AsNode());
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,4089,4313);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,4089,4313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4254,4298);

retVal = GetNodeInfo(nodeOrToken.AsToken());
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,4089,4313);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4329,4343);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,3957,4354);

Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
f_25130_4154_4187(Microsoft.CodeAnalysis.SyntaxNode?
node)
{
var return_v = node.GetNodeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4154, 4187);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,3957,4354);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,3957,4354);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NodeInfo GetNodeInfo(this SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,4366,4798);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4447,4479);

var 
typeObject = f_25130_4464_4478(node)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4493,4529);

var 
nodeClassName = f_25130_4513_4528(typeObject)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4543,4604);

var 
properties = f_25130_4560_4603(f_25130_4560_4584(typeObject))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4618,4787);

return f_25130_4625_4786(f_25130_4638_4653(typeObject), f_25130_4655_4785((
                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from p in properties
                where IsField(p)
                select GetFieldInfo(p, node),25130,4674,4774))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,4366,4798);

System.Type
f_25130_4464_4478(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4464, 4478);
return return_v;
}


string
f_25130_4513_4528(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 4513, 4528);
return return_v;
}


System.Reflection.TypeInfo
f_25130_4560_4584(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4560, 4584);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>
f_25130_4560_4603(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.DeclaredProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 4560, 4603);
return return_v;
}


string
f_25130_4638_4653(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 4638, 4653);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
f_25130_4655_4785(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4655, 4785);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
f_25130_4625_4786(string
className,Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
fieldInfos)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo( className, fieldInfos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4625, 4786);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,4366,4798);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,4366,4798);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NodeInfo GetNodeInfo(this SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,4810,5246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4893,4926);

var 
typeObject = f_25130_4910_4925(ref token)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4940,4976);

var 
nodeClassName = f_25130_4960_4975(typeObject)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,4990,5051);

var 
properties = f_25130_5007_5050(f_25130_5007_5031(typeObject))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5065,5235);

return f_25130_5072_5234(f_25130_5085_5100(typeObject), f_25130_5102_5233((
                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from p in properties
                where IsField(p)
                select GetFieldInfo(p, token),25130,5121,5222))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,4810,5246);

System.Type
f_25130_4910_4925(ref Microsoft.CodeAnalysis.SyntaxToken
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 4910, 4925);
return return_v;
}


string
f_25130_4960_4975(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 4960, 4975);
return return_v;
}


System.Reflection.TypeInfo
f_25130_5007_5031(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5007, 5031);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>
f_25130_5007_5050(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.DeclaredProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5007, 5050);
return return_v;
}


string
f_25130_5085_5100(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5085, 5100);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
f_25130_5102_5233(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5102, 5233);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
f_25130_5072_5234(string
className,Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
fieldInfos)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo( className, fieldInfos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5072, 5234);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,4810,5246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,4810,5246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static NodeInfo GetNodeInfo(this SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,5258,5698);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5343,5377);

var 
typeObject = f_25130_5360_5376(ref trivia)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5391,5427);

var 
nodeClassName = f_25130_5411_5426(typeObject)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5441,5502);

var 
properties = f_25130_5458_5501(f_25130_5458_5482(typeObject))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5516,5687);

return f_25130_5523_5686(f_25130_5536_5551(typeObject), f_25130_5553_5685((
                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from p in properties
                where IsField(p)
                select GetFieldInfo(p, trivia),25130,5572,5674))));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,5258,5698);

System.Type
f_25130_5360_5376(ref Microsoft.CodeAnalysis.SyntaxTrivia
this_param)
{
var return_v = this_param.GetType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5360, 5376);
return return_v;
}


string
f_25130_5411_5426(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5411, 5426);
return return_v;
}


System.Reflection.TypeInfo
f_25130_5458_5482(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5458, 5482);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo>
f_25130_5458_5501(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.DeclaredProperties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5458, 5501);
return return_v;
}


string
f_25130_5536_5551(System.Type
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5536, 5551);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
f_25130_5553_5685(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>
source)
{
var return_v = source.ToArray<Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5553, 5685);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
f_25130_5523_5686(string
className,Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
fieldInfos)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo( className, fieldInfos);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 5523, 5686);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,5258,5698);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,5258,5698);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsField(PropertyInfo prop)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,5758,6593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5829,5864);

var 
typeObject = f_25130_5846_5863(prop)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,5878,6582) || true) && (typeObject == typeof(int) ||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 5954)||                typeObject == typeof(uint) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6001)||                typeObject == typeof(long) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6049)||                typeObject == typeof(ulong) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6096)||                typeObject == typeof(bool) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6145)||                typeObject == typeof(string) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6193)||                typeObject == typeof(float) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6242)||                typeObject == typeof(double) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6289)||                typeObject == typeof(char) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6340)||                typeObject == typeof(DateTime) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6390)||                typeObject == typeof(decimal) )||(DynAbs.Tracing.TraceSender.Expression_False(25130, 5882, 6442)||f_25130_6411_6442(f_25130_6411_6435(                typeObject))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,5878,6582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,6476,6488);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,5878,6582);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25130,5878,6582);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,6554,6567);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(25130,5878,6582);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,5758,6593);

System.Type
f_25130_5846_5863(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 5846, 5863);
return return_v;
}


System.Reflection.TypeInfo
f_25130_6411_6435(System.Type
type)
{
var return_v = type.GetTypeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 6411, 6435);
return return_v;
}


bool
f_25130_6411_6442(System.Reflection.TypeInfo
this_param)
{
var return_v = this_param.IsEnum;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 6411, 6442);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,5758,6593);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,5758,6593);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static NodeInfo.FieldInfo GetFieldInfo(PropertyInfo prop, SyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,6722,6927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,6829,6916);

return f_25130_6836_6915(f_25130_6859_6868(prop), f_25130_6870_6887(prop), f_25130_6889_6914(prop, node, null));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,6722,6927);

string
f_25130_6859_6868(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 6859, 6868);
return return_v;
}


System.Type
f_25130_6870_6887(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 6870, 6887);
return return_v;
}


object?
f_25130_6889_6914(System.Reflection.PropertyInfo
this_param,Microsoft.CodeAnalysis.SyntaxNode
obj,object?[]?
index)
{
var return_v = this_param.GetValue( (object)obj, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 6889, 6914);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
f_25130_6836_6915(string
propertyName,System.Type
fieldType,object?
value)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo( propertyName, fieldType, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 6836, 6915);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,6722,6927);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,6722,6927);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static NodeInfo.FieldInfo GetFieldInfo(PropertyInfo prop, SyntaxToken token)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,7056,7264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,7165,7253);

return f_25130_7172_7252(f_25130_7195_7204(prop), f_25130_7206_7223(prop), f_25130_7225_7251(prop, token, null));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,7056,7264);

string
f_25130_7195_7204(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 7195, 7204);
return return_v;
}


System.Type
f_25130_7206_7223(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 7206, 7223);
return return_v;
}


object?
f_25130_7225_7251(System.Reflection.PropertyInfo
this_param,Microsoft.CodeAnalysis.SyntaxToken
obj,object?[]?
index)
{
var return_v = this_param.GetValue( (object)obj, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 7225, 7251);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
f_25130_7172_7252(string
propertyName,System.Type
fieldType,object?
value)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo( propertyName, fieldType, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 7172, 7252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,7056,7264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,7056,7264);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static NodeInfo.FieldInfo GetFieldInfo(PropertyInfo prop, SyntaxTrivia trivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25130,7393,7604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,7504,7593);

return f_25130_7511_7592(f_25130_7534_7543(prop), f_25130_7545_7562(prop), f_25130_7564_7591(prop, trivia, null));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25130,7393,7604);

string
f_25130_7534_7543(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 7534, 7543);
return return_v;
}


System.Type
f_25130_7545_7562(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25130, 7545, 7562);
return return_v;
}


object?
f_25130_7564_7591(System.Reflection.PropertyInfo
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
obj,object?[]?
index)
{
var return_v = this_param.GetValue( (object)obj, index);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 7564, 7591);
return return_v;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
f_25130_7511_7592(string
propertyName,System.Type
fieldType,object?
value)
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo( propertyName, fieldType, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25130, 7511, 7592);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25130,7393,7604);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,7393,7604);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static NodeHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25130,384,7611);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25130,794,902);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25130,384,7611);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25130,384,7611);
}

}
}
