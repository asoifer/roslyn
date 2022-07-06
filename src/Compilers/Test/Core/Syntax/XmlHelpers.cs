// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.Test.Utilities
{
public class XmlOptions
{
public bool Trivia
{            get;
            set;
}

public bool Spans
{            get;
            set;
}

public bool ReflectionInfo
{            get;
            set;
}

public bool Text
{            get;
            set;
}

public bool Errors
{            get;
            set;
}

public XmlOptions()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(25135,402,882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,442,518);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,530,605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,617,701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,713,787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,799,875);
DynAbs.Tracing.TraceSender.TraceExitConstructor(25135,402,882);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,402,882);
}


static XmlOptions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25135,402,882);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25135,402,882);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,402,882);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25135,402,882);
}
public static class XmlHelpers
{
private static void AddNodeInfo(NodeInfo info, XElement xml)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,937,1494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1022,1070);

f_25135_1022_1069(            xml, f_25135_1030_1068("Type", f_25135_1053_1067(info)));
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1084,1483);
foreach(var f in f_25135_1102_1117_I(f_25135_1102_1117(info)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,1084,1483);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1151,1468) || true) && (!(f_25135_1157_1188(f_25135_1157_1171(f), "Span")||(DynAbs.Tracing.TraceSender.Expression_False(25135, 1157, 1223)||f_25135_1192_1223(f_25135_1192_1206(f), "Kind"))||(DynAbs.Tracing.TraceSender.Expression_False(25135, 1157, 1258)||f_25135_1227_1258(f_25135_1227_1241(f), "Text"))||(DynAbs.Tracing.TraceSender.Expression_False(25135, 1157, 1298)||f_25135_1262_1298(f_25135_1262_1276(f), "IsMissing"))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,1151,1468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1341,1449);

f_25135_1341_1448(                    xml, @"<<%= f.PropertyName %> FieldType=<%= f.FieldType.Name %>><%= New XCData(f.Value.ToString) %></>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,1151,1468);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,1084,1483);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25135,1,400);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25135,1,400);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,937,1494);

string
f_25135_1053_1067(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
this_param)
{
var return_v = this_param.ClassName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1053, 1067);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_1030_1068(string
name,string
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1030, 1068);
return return_v;
}


int
f_25135_1022_1069(System.Xml.Linq.XElement
this_param,System.Xml.Linq.XAttribute
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1022, 1069);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
f_25135_1102_1117(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
this_param)
{
var return_v = this_param.FieldInfos;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1102, 1117);
return return_v;
}


string
f_25135_1157_1171(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
this_param)
{
var return_v = this_param.PropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1157, 1171);
return return_v;
}


bool
f_25135_1157_1188(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1157, 1188);
return return_v;
}


string
f_25135_1192_1206(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
this_param)
{
var return_v = this_param.PropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1192, 1206);
return return_v;
}


bool
f_25135_1192_1223(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1192, 1223);
return return_v;
}


string
f_25135_1227_1241(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
this_param)
{
var return_v = this_param.PropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1227, 1241);
return return_v;
}


bool
f_25135_1227_1258(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1227, 1258);
return return_v;
}


string
f_25135_1262_1276(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo
this_param)
{
var return_v = this_param.PropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 1262, 1276);
return return_v;
}


bool
f_25135_1262_1298(string
this_param,string
value)
{
var return_v = this_param.Contains( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1262, 1298);
return return_v;
}


int
f_25135_1341_1448(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1341, 1448);
return 0;
}


Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
f_25135_1102_1117_I(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo.FieldInfo[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1102, 1117);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,937,1494);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,937,1494);
}
		}

public static void AddInfo(SyntaxNode node, XElement xml, XmlOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,1506,1656);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1608,1645);

f_25135_1608_1644(f_25135_1620_1638(node), xml);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,1506,1656);

Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
f_25135_1620_1638(Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = node.GetNodeInfo();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1620, 1638);
return return_v;
}


int
f_25135_1608_1644(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
info,System.Xml.Linq.XElement
xml)
{
AddNodeInfo( info, xml);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1608, 1644);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,1506,1656);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,1506,1656);
}
		}

public static void AddInfo(SyntaxNodeOrToken node, XElement xml, XmlOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,1668,1825);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1777,1814);

f_25135_1777_1813(node.GetNodeInfo(), xml);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,1668,1825);

int
f_25135_1777_1813(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
info,System.Xml.Linq.XElement
xml)
{
AddNodeInfo( info, xml);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1777, 1813);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,1668,1825);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,1668,1825);
}
		}

public static void AddInfo(SyntaxToken node, XElement xml, XmlOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,1837,1988);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,1940,1977);

f_25135_1940_1976(node.GetNodeInfo(), xml);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,1837,1988);

int
f_25135_1940_1976(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
info,System.Xml.Linq.XElement
xml)
{
AddNodeInfo( info, xml);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 1940, 1976);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,1837,1988);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,1837,1988);
}
		}

public static void AddInfo(SyntaxTrivia node, XElement xml, XmlOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,2000,2152);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,2104,2141);

f_25135_2104_2140(node.GetNodeInfo(), xml);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,2000,2152);

int
f_25135_2104_2140(Microsoft.CodeAnalysis.Test.Utilities.NodeInfo
info,System.Xml.Linq.XElement
xml)
{
AddNodeInfo( info, xml);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 2104, 2140);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,2000,2152);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,2000,2152);
}
		}

public static void AddErrors(XElement xml, IEnumerable<Diagnostic> errors, XmlOptions options)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,2164,3258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,2283,3247);

f_25135_2283_3246(            xml, @"<Errors>
                    <%= From e In errors
                        Let l = e.Location
                        Select If(l.InSource,
                        <Error Code=<%= e.Info.MessageIdentifier.ToString %> Severity=<%= e.Severity.ToString %>>
                            <%= If(options.Text, <Message><%= e.GetMessage(Globalization.CultureInfo.CurrentCulture) %></Message>, Nothing) %>
                            <%= If(options.Spans, <Span Start=<%= l.SourceSpan.Start %> End=<%= l.SourceSpan.End %> Length=<%= l.SourceSpan.Length %>/>, Nothing) %>
                        </Error>,
                        <Error Code=<%= e.Info.MessageIdentifier.ToString %> Severity=<%= e.Severity.ToString %>>
                            <%= If(options.Text, <Message><%= e.GetMessage(Globalization.CultureInfo.CurrentCulture) %></Message>, Nothing) %>
                        </Error>
                        ) %>
                </Errors>");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,2164,3258);

int
f_25135_2283_3246(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 2283, 3246);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,2164,3258);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,2164,3258);
}
		}

public static XElement ToXml(this SyntaxNodeOrToken node, SyntaxTree syntaxTree, XmlOptions options = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,3270,3701);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3402,3422);

XElement 
xml = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3436,3663) || true) && (node.IsNode)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,3436,3663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3485,3533);

xml = f_25135_3491_3532(node.AsNode(), syntaxTree, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,3436,3663);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,3436,3663);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3599,3648);

xml = ToXml(node.AsToken(),syntaxTree,options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,3436,3663);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3679,3690);

return xml;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,3270,3701);

System.Xml.Linq.XElement
f_25135_3491_3532(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions?
options)
{
var return_v = node.ToXml( syntaxTree, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 3491, 3532);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,3270,3701);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,3270,3701);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static XElement ToXml(this SyntaxNode node, SyntaxTree syntaxTree, XmlOptions options = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,3713,5247);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3838,3933) || true) && (options == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,3838,3933);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3891,3918);

options = f_25135_3901_3917();
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,3838,3933);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3949,3969);

XElement 
xml = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,3983,5209) || true) && (node != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,3983,5209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4033,4281);

xml = f_25135_4039_4280("Node", f_25135_4077_4109("IsToken", false), f_25135_4128_4160("IsTrivia", true), f_25135_4179_4217("Kind", f_25135_4202_4216(node)), f_25135_4236_4279("IsMissing", f_25135_4264_4278(node)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4301,4626) || true) && (f_25135_4305_4318(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,4301,4626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4360,4464);

f_25135_4360_4463(                    xml, @"<Span Start=<%= node.SpanStart %> End=<%= node.Span.End %> Length=<%= node.Span.Length %>/>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4486,4607);

f_25135_4486_4606(                    xml, @"<FullSpan Start=<%= node.FullSpan.Start %> End=<%= node.FullSpan.End %> Length=<%= node.FullSpan.Length %>/>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,4301,4626);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4646,4761) || true) && (f_25135_4650_4672(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,4646,4761);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4714,4742);

f_25135_4714_4741(node, xml, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,4646,4761);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4781,5031) || true) && (f_25135_4785_4799(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,4781,5031);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4841,5012) || true) && (f_25135_4845_4882(f_25135_4845_4876(syntaxTree, node)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,4841,5012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,4932,4989);

f_25135_4932_4988(xml, f_25135_4947_4978(syntaxTree, node), options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,4841,5012);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,4781,5031);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5051,5194);
foreach(var c in f_25135_5069_5095_I(f_25135_5069_5095(node)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,5051,5194);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5137,5175);

f_25135_5137_5174(                    xml, c.ToXml(syntaxTree,options));
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,5051,5194);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(25135,1,144);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(25135,1,144);
}DynAbs.Tracing.TraceSender.TraceExitCondition(25135,3983,5209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5225,5236);

return xml;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,3713,5247);

Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
f_25135_3901_3917()
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.XmlOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 3901, 3917);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_4077_4109(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4077, 4109);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_4128_4160(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4128, 4160);
return return_v;
}


string
f_25135_4202_4216(Microsoft.CodeAnalysis.SyntaxNode
n)
{
var return_v = n.GetKind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4202, 4216);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_4179_4217(string
name,string
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4179, 4217);
return return_v;
}


bool
f_25135_4264_4278(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.IsMissing;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 4264, 4278);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_4236_4279(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4236, 4279);
return return_v;
}


System.Xml.Linq.XElement
f_25135_4039_4280(string
name,params object[]
content)
{
var return_v = new System.Xml.Linq.XElement( (System.Xml.Linq.XName)name, content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4039, 4280);
return return_v;
}


bool
f_25135_4305_4318(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Spans;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 4305, 4318);
return return_v;
}


int
f_25135_4360_4463(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4360, 4463);
return 0;
}


int
f_25135_4486_4606(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4486, 4606);
return 0;
}


bool
f_25135_4650_4672(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.ReflectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 4650, 4672);
return return_v;
}


int
f_25135_4714_4741(Microsoft.CodeAnalysis.SyntaxNode
node,System.Xml.Linq.XElement
xml,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddInfo( node, xml, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4714, 4741);
return 0;
}


bool
f_25135_4785_4799(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 4785, 4799);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_4845_4876(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.GetDiagnostics( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4845, 4876);
return return_v;
}


bool
f_25135_4845_4882(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
source)
{
var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4845, 4882);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_4947_4978(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.GetDiagnostics( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4947, 4978);
return return_v;
}


int
f_25135_4932_4988(System.Xml.Linq.XElement
xml,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
errors,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddErrors( xml, errors, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 4932, 4988);
return 0;
}


Microsoft.CodeAnalysis.ChildSyntaxList
f_25135_5069_5095(Microsoft.CodeAnalysis.SyntaxNode
this_param)
{
var return_v = this_param.ChildNodesAndTokens();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5069, 5095);
return return_v;
}


int
f_25135_5137_5174(System.Xml.Linq.XElement
this_param,System.Xml.Linq.XElement
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5137, 5174);
return 0;
}


Microsoft.CodeAnalysis.ChildSyntaxList
f_25135_5069_5095_I(Microsoft.CodeAnalysis.ChildSyntaxList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5069, 5095);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,3713,5247);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,3713,5247);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static XElement ToXml(this SyntaxToken token, SyntaxTree syntaxTree, XmlOptions options = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,5259,7176);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5386,5481) || true) && (options == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,5386,5481);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5439,5466);

options = f_25135_5449_5465();
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,5386,5481);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5497,5759);

XElement 
retVal = f_25135_5515_5758("Node", f_25135_5553_5585("IsToken", false), f_25135_5604_5636("IsTrivia", true), f_25135_5655_5694("Kind", token.GetKind()), f_25135_5713_5757("IsMissing", token.IsMissing))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5775,6096) || true) && (f_25135_5779_5792(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,5775,6096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5826,5936);

f_25135_5826_5935(                retVal, @"<Span Start=<%= token.SpanStart %> End=<%= token.Span.End %> Length=<%= token.Span.Length %>/>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,5954,6081);

f_25135_5954_6080(                retVal, @"<FullSpan Start=<%= token.FullSpan.Start %> End=<%= token.FullSpan.End %> Length=<%= token.FullSpan.Length %>/>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,5775,6096);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6112,6240) || true) && (f_25135_6116_6128(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6112,6240);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6162,6225);

f_25135_6162_6224(                retVal, @"<Text><%= New XCData(token.GetText()) %></Text>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6112,6240);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6256,6363) || true) && (f_25135_6260_6282(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6256,6363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6316,6348);

f_25135_6316_6347(token, retVal, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6256,6363);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6379,6610) || true) && (f_25135_6383_6397(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6379,6610);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6431,6595) || true) && (f_25135_6435_6473(f_25135_6435_6467(syntaxTree, token)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6431,6595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6515,6576);

f_25135_6515_6575(retVal, f_25135_6533_6565(syntaxTree, token), options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6431,6595);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6379,6610);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6626,7135) || true) && (f_25135_6630_6644(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6626,7135);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6678,6887) || true) && (token.LeadingTrivia.Any())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6678,6887);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6749,6868);

f_25135_6749_6867(                    retVal, @"<LeadingTrivia><%= From t In token.LeadingTrivia Select t.ToXml(syntaxTree, options) %></LeadingTrivia>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6678,6887);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6907,7120) || true) && (token.TrailingTrivia.Any())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,6907,7120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,6979,7101);

f_25135_6979_7100(                    retVal, @"<TrailingTrivia><%= From t In token.TrailingTrivia Select t.ToXml(syntaxTree, options) %></TrailingTrivia>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6907,7120);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,6626,7135);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7151,7165);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,5259,7176);

Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
f_25135_5449_5465()
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.XmlOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5449, 5465);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_5553_5585(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5553, 5585);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_5604_5636(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5604, 5636);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_5655_5694(string
name,string
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5655, 5694);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_5713_5757(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5713, 5757);
return return_v;
}


System.Xml.Linq.XElement
f_25135_5515_5758(string
name,params object[]
content)
{
var return_v = new System.Xml.Linq.XElement( (System.Xml.Linq.XName)name, content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5515, 5758);
return return_v;
}


bool
f_25135_5779_5792(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Spans;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 5779, 5792);
return return_v;
}


int
f_25135_5826_5935(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5826, 5935);
return 0;
}


int
f_25135_5954_6080(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 5954, 6080);
return 0;
}


bool
f_25135_6116_6128(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 6116, 6128);
return return_v;
}


int
f_25135_6162_6224(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6162, 6224);
return 0;
}


bool
f_25135_6260_6282(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.ReflectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 6260, 6282);
return return_v;
}


int
f_25135_6316_6347(Microsoft.CodeAnalysis.SyntaxToken
node,System.Xml.Linq.XElement
xml,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddInfo( node, xml, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6316, 6347);
return 0;
}


bool
f_25135_6383_6397(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 6383, 6397);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_6435_6467(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = this_param.GetDiagnostics( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6435, 6467);
return return_v;
}


bool
f_25135_6435_6473(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
source)
{
var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6435, 6473);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_6533_6565(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxToken
token)
{
var return_v = this_param.GetDiagnostics( token);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6533, 6565);
return return_v;
}


int
f_25135_6515_6575(System.Xml.Linq.XElement
xml,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
errors,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddErrors( xml, errors, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6515, 6575);
return 0;
}


bool
f_25135_6630_6644(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Trivia;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 6630, 6644);
return return_v;
}


int
f_25135_6749_6867(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6749, 6867);
return 0;
}


int
f_25135_6979_7100(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 6979, 7100);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,5259,7176);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,5259,7176);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static XElement ToXml(this SyntaxTrivia trivia, SyntaxTree syntaxTree, XmlOptions options = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(25135,7188,8730);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7317,7412) || true) && (options == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,7317,7412);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7370,7397);

options = f_25135_7380_7396();
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,7317,7412);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7428,7681);

XElement 
retVal = f_25135_7446_7680("Node", f_25135_7484_7516("IsToken", false), f_25135_7535_7567("IsTrivia", true), f_25135_7586_7626("Kind", trivia.GetKind()), f_25135_7645_7679("IsMissing", false))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7695,8022) || true) && (f_25135_7699_7712(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,7695,8022);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7746,7859);

f_25135_7746_7858(                retVal, @"<Span Start=<%= trivia.SpanStart %> End=<%= trivia.Span.End %> Length=<%= trivia.Span.Length %>/>");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,7877,8007);

f_25135_7877_8006(                retVal, @"<FullSpan Start=<%= trivia.FullSpan.Start %> End=<%= trivia.FullSpan.End %> Length=<%= trivia.FullSpan.Length %>/>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,7695,8022);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8038,8167) || true) && (f_25135_8042_8054(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,8038,8167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8088,8152);

f_25135_8088_8151(                retVal, @"<Text><%= New XCData(trivia.GetText()) %></Text>");
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,8038,8167);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8183,8291) || true) && (f_25135_8187_8209(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,8183,8291);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8243,8276);

f_25135_8243_8275(trivia, retVal, options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,8183,8291);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8307,8540) || true) && (f_25135_8311_8325(options))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,8307,8540);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8359,8525) || true) && (f_25135_8363_8402(f_25135_8363_8396(syntaxTree, trivia)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,8359,8525);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8444,8506);

f_25135_8444_8505(retVal, f_25135_8462_8495(syntaxTree, trivia), options);
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,8359,8525);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,8307,8540);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8556,8689) || true) && (trivia.HasStructure)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(25135,8556,8689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8613,8674);

f_25135_8613_8673(                retVal, f_25135_8624_8672(trivia.GetStructure(), syntaxTree, options));
DynAbs.Tracing.TraceSender.TraceExitCondition(25135,8556,8689);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(25135,8705,8719);

return retVal;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(25135,7188,8730);

Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
f_25135_7380_7396()
{
var return_v = new Microsoft.CodeAnalysis.Test.Utilities.XmlOptions();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7380, 7396);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_7484_7516(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7484, 7516);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_7535_7567(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7535, 7567);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_7586_7626(string
name,string
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7586, 7626);
return return_v;
}


System.Xml.Linq.XAttribute
f_25135_7645_7679(string
name,bool
value)
{
var return_v = new System.Xml.Linq.XAttribute( (System.Xml.Linq.XName)name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7645, 7679);
return return_v;
}


System.Xml.Linq.XElement
f_25135_7446_7680(string
name,params object[]
content)
{
var return_v = new System.Xml.Linq.XElement( (System.Xml.Linq.XName)name, content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7446, 7680);
return return_v;
}


bool
f_25135_7699_7712(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Spans;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 7699, 7712);
return return_v;
}


int
f_25135_7746_7858(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7746, 7858);
return 0;
}


int
f_25135_7877_8006(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 7877, 8006);
return 0;
}


bool
f_25135_8042_8054(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 8042, 8054);
return return_v;
}


int
f_25135_8088_8151(System.Xml.Linq.XElement
this_param,string
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8088, 8151);
return 0;
}


bool
f_25135_8187_8209(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.ReflectionInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 8187, 8209);
return return_v;
}


int
f_25135_8243_8275(Microsoft.CodeAnalysis.SyntaxTrivia
node,System.Xml.Linq.XElement
xml,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddInfo( node, xml, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8243, 8275);
return 0;
}


bool
f_25135_8311_8325(Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
this_param)
{
var return_v = this_param.Errors;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25135, 8311, 8325);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_8363_8396(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = this_param.GetDiagnostics( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8363, 8396);
return return_v;
}


bool
f_25135_8363_8402(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
source)
{
var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostic>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8363, 8402);
return return_v;
}


System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
f_25135_8462_8495(Microsoft.CodeAnalysis.SyntaxTree
this_param,Microsoft.CodeAnalysis.SyntaxTrivia
trivia)
{
var return_v = this_param.GetDiagnostics( trivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8462, 8495);
return return_v;
}


int
f_25135_8444_8505(System.Xml.Linq.XElement
xml,System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>
errors,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
AddErrors( xml, errors, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8444, 8505);
return 0;
}


System.Xml.Linq.XElement
f_25135_8624_8672(Microsoft.CodeAnalysis.SyntaxNode?
node,Microsoft.CodeAnalysis.SyntaxTree
syntaxTree,Microsoft.CodeAnalysis.Test.Utilities.XmlOptions
options)
{
var return_v = node.ToXml( syntaxTree, options);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8624, 8672);
return return_v;
}


int
f_25135_8613_8673(System.Xml.Linq.XElement
this_param,System.Xml.Linq.XElement
content)
{
this_param.Add( (object)content);
DynAbs.Tracing.TraceSender.TraceEndInvocation(25135, 8613, 8673);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25135,7188,8730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,7188,8730);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static XmlHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25135,890,8737);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25135,890,8737);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25135,890,8737);
}

}
}
