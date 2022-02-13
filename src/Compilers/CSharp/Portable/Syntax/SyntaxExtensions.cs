// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
public static class SyntaxExtensions
{
internal static ArrowExpressionClauseSyntax? GetExpressionBodySyntax(this CSharpSyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,760,2759);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,881,927);

ArrowExpressionClauseSyntax? 
arrowExpr = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,941,2717);

switch (f_10805_949_960(node))
            {

case SyntaxKind.ArrowExpressionClause:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,1215,1261);

arrowExpr = (ArrowExpressionClauseSyntax)node;
DynAbs.Tracing.TraceSender.TraceBreak(10805,1283,1289);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);

case SyntaxKind.MethodDeclaration:
                case SyntaxKind.OperatorDeclaration:
                case SyntaxKind.ConversionOperatorDeclaration:
                case SyntaxKind.ConstructorDeclaration:
                case SyntaxKind.DestructorDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,1594,1657);

arrowExpr = f_10805_1606_1656(((BaseMethodDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10805,1679,1685);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);

case SyntaxKind.GetAccessorDeclaration:
                case SyntaxKind.SetAccessorDeclaration:
                case SyntaxKind.InitAccessorDeclaration:
                case SyntaxKind.AddAccessorDeclaration:
                case SyntaxKind.RemoveAccessorDeclaration:
                case SyntaxKind.UnknownAccessorDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,2057,2118);

arrowExpr = f_10805_2069_2117(((AccessorDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10805,2140,2146);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);

case SyntaxKind.PropertyDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,2222,2283);

arrowExpr = f_10805_2234_2282(((PropertyDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10805,2305,2311);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);

case SyntaxKind.IndexerDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,2386,2446);

arrowExpr = f_10805_2398_2445(((IndexerDeclarationSyntax)node));
DynAbs.Tracing.TraceSender.TraceBreak(10805,2468,2474);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,941,2717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,2626,2674);

f_10805_2626_2673(f_10805_2661_2672(node));
DynAbs.Tracing.TraceSender.TraceBreak(10805,2696,2702);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,941,2717);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,2731,2748);

return arrowExpr;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,760,2759);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_949_960(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 949, 960);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10805_1606_1656(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 1606, 1656);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10805_2069_2117(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 2069, 2117);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10805_2234_2282(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 2234, 2282);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10805_2398_2445(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 2398, 2445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_2661_2672(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 2661, 2672);
return return_v;
}


System.Exception
f_10805_2626_2673(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 2626, 2673);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,760,2759);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,760,2759);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxToken NormalizeWhitespace(this SyntaxToken token, string indentation, bool elasticTrivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,3244,3504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,3378,3493);

return f_10805_3385_3492(token, indentation, CodeAnalysis.SyntaxNodeExtensions.DefaultEOL, elasticTrivia);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,3244,3504);

Microsoft.CodeAnalysis.SyntaxToken
f_10805_3385_3492(Microsoft.CodeAnalysis.SyntaxToken
token,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = SyntaxNormalizer.Normalize( token, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 3385, 3492);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,3244,3504);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,3244,3504);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static SyntaxToken Identifier(this DeclarationExpressionSyntax self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,3641,3824);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,3743,3813);

return f_10805_3750_3812(((SingleVariableDesignationSyntax)f_10805_3784_3800(self)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,3641,3824);

Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
f_10805_3784_3800(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
this_param)
{
var return_v = this_param.Designation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 3784, 3800);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10805_3750_3812(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
this_param)
{
var return_v = this_param.Identifier;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 3750, 3812);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,3641,3824);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,3641,3824);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxToken NormalizeWhitespace(this SyntaxToken token,
            string indentation = CodeAnalysis.SyntaxNodeExtensions.DefaultIndentation,
            string eol = CodeAnalysis.SyntaxNodeExtensions.DefaultEOL,
            bool elasticTrivia = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,4439,4819);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,4734,4808);

return f_10805_4741_4807(token, indentation, eol, elasticTrivia);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,4439,4819);

Microsoft.CodeAnalysis.SyntaxToken
f_10805_4741_4807(Microsoft.CodeAnalysis.SyntaxToken
token,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = SyntaxNormalizer.Normalize( token, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 4741, 4807);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,4439,4819);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,4439,4819);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList NormalizeWhitespace(this SyntaxTriviaList list, string indentation, bool elasticTrivia)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,5315,5583);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,5458,5572);

return f_10805_5465_5571(list, indentation, CodeAnalysis.SyntaxNodeExtensions.DefaultEOL, elasticTrivia);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,5315,5583);

Microsoft.CodeAnalysis.SyntaxTriviaList
f_10805_5465_5571(Microsoft.CodeAnalysis.SyntaxTriviaList
trivia,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = SyntaxNormalizer.Normalize( trivia, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 5465, 5571);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,5315,5583);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,5315,5583);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList NormalizeWhitespace(this SyntaxTriviaList list,
            string indentation = CodeAnalysis.SyntaxNodeExtensions.DefaultIndentation,
            string eol = CodeAnalysis.SyntaxNodeExtensions.DefaultEOL,
            bool elasticTrivia = false)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,6209,6597);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,6513,6586);

return f_10805_6520_6585(list, indentation, eol, elasticTrivia);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,6209,6597);

Microsoft.CodeAnalysis.SyntaxTriviaList
f_10805_6520_6585(Microsoft.CodeAnalysis.SyntaxTriviaList
trivia,string
indentWhitespace,string
eolWhitespace,bool
useElasticTrivia)
{
var return_v = SyntaxNormalizer.Normalize( trivia, indentWhitespace, eolWhitespace, useElasticTrivia);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 6520, 6585);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,6209,6597);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,6209,6597);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxTriviaList ToSyntaxTriviaList(this IEnumerable<SyntaxTrivia> sequence)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,6609,6777);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,6724,6766);

return f_10805_6731_6765(sequence);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,6609,6777);

Microsoft.CodeAnalysis.SyntaxTriviaList
f_10805_6731_6765(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia>
trivias)
{
var return_v = SyntaxFactory.TriviaList( trivias);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 6731, 6765);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,6609,6777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,6609,6777);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static XmlNameAttributeElementKind GetElementKind(this XmlNameAttributeSyntax attributeSyntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,6789,8878);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,6917,6964);

f_10805_6917_6963(f_10805_6930_6952(attributeSyntax)is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,6978,7033);

CSharpSyntaxNode 
parentSyntax = f_10805_7010_7032(attributeSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7047,7091);

SyntaxKind 
parentKind = f_10805_7071_7090(parentSyntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7107,7125);

string 
parentName
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7139,7811) || true) && (parentKind == SyntaxKind.XmlEmptyElement)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7139,7811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7217,7266);

var 
parent = (XmlEmptyElementSyntax)parentSyntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7284,7329);

parentName = f_10805_7297_7308(parent).LocalName.ValueText;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7347,7388);

f_10805_7347_7387(f_10805_7360_7378(f_10805_7360_7371(parent))is null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7139,7811);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7139,7811);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7422,7811) || true) && (parentKind == SyntaxKind.XmlElementStartTag)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7422,7811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7503,7555);

var 
parent = (XmlElementStartTagSyntax)parentSyntax
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7573,7618);

parentName = f_10805_7586_7597(parent).LocalName.ValueText;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7636,7677);

f_10805_7636_7676(f_10805_7649_7667(f_10805_7649_7660(parent))is null);
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7422,7811);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7422,7811);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7743,7796);

throw f_10805_7749_7795(parentKind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7422,7811);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7139,7811);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7827,8867) || true) && (f_10805_7831_7936(parentName, DocumentationCommentXmlNames.ParameterElementName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7827,8867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,7970,8015);

return XmlNameAttributeElementKind.Parameter;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7827,8867);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,7827,8867);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8049,8867) || true) && (f_10805_8053_8167(parentName, DocumentationCommentXmlNames.ParameterReferenceElementName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8049,8867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8201,8255);

return XmlNameAttributeElementKind.ParameterReference;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8049,8867);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8049,8867);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8289,8867) || true) && (f_10805_8293_8402(parentName, DocumentationCommentXmlNames.TypeParameterElementName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8289,8867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8436,8485);

return XmlNameAttributeElementKind.TypeParameter;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8289,8867);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8289,8867);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8519,8867) || true) && (f_10805_8523_8641(parentName, DocumentationCommentXmlNames.TypeParameterReferenceElementName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8519,8867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8675,8733);

return XmlNameAttributeElementKind.TypeParameterReference;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8519,8867);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,8519,8867);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8799,8852);

throw f_10805_8805_8851(parentName);
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8519,8867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8289,8867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,8049,8867);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,7827,8867);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,6789,8878);

Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10805_6930_6952(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 6930, 6952);
return return_v;
}


int
f_10805_6917_6963(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 6917, 6963);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10805_7010_7032(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7010, 7032);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_7071_7090(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 7071, 7090);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
f_10805_7297_7308(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7297, 7308);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
f_10805_7360_7371(Microsoft.CodeAnalysis.CSharp.Syntax.XmlEmptyElementSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7360, 7371);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax?
f_10805_7360_7378(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
this_param)
{
var return_v = this_param.Prefix ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7360, 7378);
return return_v;
}


int
f_10805_7347_7387(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 7347, 7387);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
f_10805_7586_7597(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7586, 7597);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
f_10805_7649_7660(Microsoft.CodeAnalysis.CSharp.Syntax.XmlElementStartTagSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7649, 7660);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.XmlPrefixSyntax?
f_10805_7649_7667(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameSyntax
this_param)
{
var return_v = this_param.Prefix ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 7649, 7667);
return return_v;
}


int
f_10805_7636_7676(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 7636, 7676);
return 0;
}


System.Exception
f_10805_7749_7795(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 7749, 7795);
return return_v;
}


bool
f_10805_7831_7936(string
name1,string
name2)
{
var return_v = DocumentationCommentXmlNames.ElementEquals( name1, name2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 7831, 7936);
return return_v;
}


bool
f_10805_8053_8167(string
name1,string
name2)
{
var return_v = DocumentationCommentXmlNames.ElementEquals( name1, name2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 8053, 8167);
return return_v;
}


bool
f_10805_8293_8402(string
name1,string
name2)
{
var return_v = DocumentationCommentXmlNames.ElementEquals( name1, name2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 8293, 8402);
return return_v;
}


bool
f_10805_8523_8641(string
name1,string
name2)
{
var return_v = DocumentationCommentXmlNames.ElementEquals( name1, name2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 8523, 8641);
return return_v;
}


System.Exception
f_10805_8805_8851(string
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 8805, 8851);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,6789,8878);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,6789,8878);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool ReportDocumentationCommentDiagnostics(this SyntaxTree tree)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,8890,9074);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,8995,9063);

return f_10805_9002_9032(f_10805_9002_9014(tree))>= DocumentationMode.Diagnose;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,8890,9074);

Microsoft.CodeAnalysis.ParseOptions
f_10805_9002_9014(Microsoft.CodeAnalysis.SyntaxTree
this_param)
{
var return_v = this_param.Options;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 9002, 9014);
return return_v;
}


Microsoft.CodeAnalysis.DocumentationMode
f_10805_9002_9032(Microsoft.CodeAnalysis.ParseOptions
this_param)
{
var return_v = this_param.DocumentationMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 9002, 9032);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,8890,9074);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,8890,9074);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SimpleNameSyntax WithIdentifier(this SimpleNameSyntax simpleName, SyntaxToken identifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,9493,9881);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,9621,9870);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10805, 9628, 9674)||((f_10805_9628_9645(simpleName)== SyntaxKind.IdentifierName
&&DynAbs.Tracing.TraceSender.Conditional_F2(10805, 9694, 9773))||DynAbs.Tracing.TraceSender.Conditional_F3(10805, 9793, 9869)))?(SimpleNameSyntax)f_10805_9712_9773(((IdentifierNameSyntax)simpleName), identifier):(SimpleNameSyntax)f_10805_9811_9869(((GenericNameSyntax)simpleName), identifier);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,9493,9881);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_9628_9645(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 9628, 9645);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
f_10805_9712_9773(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
this_param,Microsoft.CodeAnalysis.SyntaxToken
identifier)
{
var return_v = this_param.WithIdentifier( identifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 9712, 9773);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
f_10805_9811_9869(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
this_param,Microsoft.CodeAnalysis.SyntaxToken
identifier)
{
var return_v = this_param.WithIdentifier( identifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 9811, 9869);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,9493,9881);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,9493,9881);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsTypeInContextWhichNeedsDynamicAttribute(this IdentifierNameSyntax typeNode)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,9893,10172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10016,10047);

f_10805_10016_10046(typeNode != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10061,10161);

return f_10805_10068_10109(typeNode)&&(DynAbs.Tracing.TraceSender.Expression_True(10805, 10068, 10160)&&f_10805_10113_10160(typeNode));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,9893,10172);

int
f_10805_10016_10046(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10016, 10046);
return 0;
}


bool
f_10805_10068_10109(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
node)
{
var return_v = SyntaxFacts.IsInTypeOnlyContext( (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10068, 10109);
return return_v;
}


bool
f_10805_10113_10160(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
node)
{
var return_v = IsInContextWhichNeedsDynamicAttribute( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10113, 10160);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,9893,10172);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,9893,10172);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ExpressionSyntax SkipParens(this ExpressionSyntax expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,10184,10510);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10286,10465) || true) && (f_10805_10293_10310(expression)== SyntaxKind.ParenthesizedExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,10286,10465);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10382,10450);

expression = f_10805_10395_10449(((ParenthesizedExpressionSyntax)expression));
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,10286,10465);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,10286,10465);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,10286,10465);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10481,10499);

return expression;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,10184,10510);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_10293_10310(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10293, 10310);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10805_10395_10449(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 10395, 10449);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,10184,10510);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,10184,10510);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsDeconstructionLeft(this ExpressionSyntax node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,10698,11185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10792,11174);

switch (f_10805_10800_10811(node))
            {

case SyntaxKind.TupleExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,10792,11174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10899,10911);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,10792,11174);

case SyntaxKind.DeclarationExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,10792,11174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,10989,11098);

return f_10805_10996_11050(f_10805_10996_11043(((DeclarationExpressionSyntax)node)))== SyntaxKind.ParenthesizedVariableDesignation;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,10792,11174);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,10792,11174);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,11146,11159);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,10792,11174);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,10698,11185);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_10800_10811(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10800, 10811);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
f_10805_10996_11043(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
this_param)
{
var return_v = this_param.Designation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 10996, 11043);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_10996_11050(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 10996, 11050);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,10698,11185);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,10698,11185);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsDeconstruction(this AssignmentExpressionSyntax self)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,11197,11348);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,11297,11337);

return f_10805_11304_11336(f_10805_11304_11313(self));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,11197,11348);

Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10805_11304_11313(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 11304, 11313);
return return_v;
}


bool
f_10805_11304_11336(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
node)
{
var return_v = node.IsDeconstructionLeft();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 11304, 11336);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,11197,11348);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,11197,11348);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsInContextWhichNeedsDynamicAttribute(CSharpSyntaxNode node)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,11360,12710);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,11465,11492);

f_10805_11465_11491(node != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,11508,12699);

switch (f_10805_11516_11527(node))
            {

case SyntaxKind.Parameter:
                case SyntaxKind.FieldDeclaration:
                case SyntaxKind.MethodDeclaration:
                case SyntaxKind.IndexerDeclaration:
                case SyntaxKind.OperatorDeclaration:
                case SyntaxKind.ConversionOperatorDeclaration:
                case SyntaxKind.PropertyDeclaration:
                case SyntaxKind.DelegateDeclaration:
                case SyntaxKind.EventDeclaration:
                case SyntaxKind.EventFieldDeclaration:
                case SyntaxKind.BaseList:
                case SyntaxKind.SimpleBaseType:
                case SyntaxKind.PrimaryConstructorBaseType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,11508,12699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,12251,12263);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,11508,12699);

case SyntaxKind.Block:
                case SyntaxKind.VariableDeclarator:
                case SyntaxKind.TypeParameterConstraintClause:
                case SyntaxKind.Attribute:
                case SyntaxKind.EqualsValueClause:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,11508,12699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,12540,12553);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,11508,12699);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,11508,12699);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,12603,12684);

return f_10805_12610_12621(node)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10805, 12610, 12683)&&f_10805_12633_12683(f_10805_12671_12682(node)));
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,11508,12699);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,11360,12710);

int
f_10805_11465_11491(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 11465, 11491);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_11516_11527(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 11516, 11527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10805_12610_12621(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 12610, 12621);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10805_12671_12682(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 12671, 12682);
return return_v;
}


bool
f_10805_12633_12683(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
node)
{
var return_v = IsInContextWhichNeedsDynamicAttribute( node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 12633, 12683);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,11360,12710);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,11360,12710);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static IndexerDeclarationSyntax Update(
            this IndexerDeclarationSyntax syntax,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeSyntax type,
            ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier,
            SyntaxToken thisKeyword,
            BracketedParameterListSyntax parameterList,
            AccessorListSyntax accessorList)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,12722,13526);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,13190,13515);

return f_10805_13197_13514(syntax, attributeLists, modifiers, type, explicitInterfaceSpecifier, thisKeyword, parameterList, accessorList, expressionBody: null, semicolonToken: default);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,12722,13526);

Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
f_10805_13197_13514(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
type,Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
explicitInterfaceSpecifier,Microsoft.CodeAnalysis.SyntaxToken
thisKeyword,Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax
parameterList,Microsoft.CodeAnalysis.CSharp.Syntax.AccessorListSyntax
accessorList,Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
expressionBody,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = this_param.Update( attributeLists, modifiers, type, explicitInterfaceSpecifier, thisKeyword, parameterList, accessorList, expressionBody: expressionBody, semicolonToken: semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 13197, 13514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,12722,13526);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,12722,13526);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static OperatorDeclarationSyntax Update(
            this OperatorDeclarationSyntax syntax,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeSyntax returnType,
            SyntaxToken operatorKeyword,
            SyntaxToken operatorToken,
            ParameterListSyntax parameterList,
            BlockSyntax block,
            SyntaxToken semicolonToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,13538,14319);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,14002,14308);

return f_10805_14009_14307(syntax, attributeLists, modifiers, returnType, operatorKeyword, operatorToken, parameterList, block, expressionBody: null, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,13538,14319);

Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
f_10805_14009_14307(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
returnType,Microsoft.CodeAnalysis.SyntaxToken
operatorKeyword,Microsoft.CodeAnalysis.SyntaxToken
operatorToken,Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
parameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
body,Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
expressionBody,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = this_param.Update( attributeLists, modifiers, returnType, operatorKeyword, operatorToken, parameterList, body, expressionBody: expressionBody, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 14009, 14307);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,13538,14319);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,13538,14319);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static MethodDeclarationSyntax Update(
            this MethodDeclarationSyntax syntax,
            SyntaxList<AttributeListSyntax> attributeLists,
            SyntaxTokenList modifiers,
            TypeSyntax returnType,
            ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifier,
            SyntaxToken identifier,
            TypeParameterListSyntax typeParameterList,
            ParameterListSyntax parameterList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            BlockSyntax block,
            SyntaxToken semicolonToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,14331,15353);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,14956,15342);

return f_10805_14963_15341(syntax, attributeLists, modifiers, returnType, explicitInterfaceSpecifier, identifier, typeParameterList, parameterList, constraintClauses, block, expressionBody: null, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,14331,15353);

Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
f_10805_14963_15341(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
returnType,Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
explicitInterfaceSpecifier,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
parameterList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
body,Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
expressionBody,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = this_param.Update( attributeLists, modifiers, returnType, explicitInterfaceSpecifier, identifier, typeParameterList, parameterList, constraintClauses, body, expressionBody: expressionBody, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 14963, 15341);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,14331,15353);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,14331,15353);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static CSharpSyntaxNode? GetContainingDeconstruction(this ExpressionSyntax expr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,15646,17378);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,15760,15783);

var 
kind = f_10805_15771_15782(expr)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,15797,15977) || true) && (kind != SyntaxKind.TupleExpression &&(DynAbs.Tracing.TraceSender.Expression_True(10805, 15801, 15879)&&kind != SyntaxKind.DeclarationExpression )&&(DynAbs.Tracing.TraceSender.Expression_True(10805, 15801, 15916)&&kind != SyntaxKind.IdentifierName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,15797,15977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,15950,15962);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,15797,15977);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,15993,17367) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,15993,17367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16038,16189);

f_10805_16038_16188(f_10805_16051_16062(expr)== SyntaxKind.TupleExpression ||(DynAbs.Tracing.TraceSender.Expression_False(10805, 16051, 16143)||f_10805_16096_16107(expr)== SyntaxKind.DeclarationExpression )||(DynAbs.Tracing.TraceSender.Expression_False(10805, 16051, 16187)||f_10805_16147_16158(expr)== SyntaxKind.IdentifierName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16207,16232);

var 
parent = f_10805_16220_16231(expr)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16250,16286) || true) && (parent == null)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16250,16286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16272,16284);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16250,16286);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16306,17352);

switch (f_10805_16314_16327(parent))
                {

case SyntaxKind.Argument:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16306,17352);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16420,16643) || true) && (f_10805_16424_16445_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10805_16424_16437(parent), 10805, 16424, 16445).Kind())== SyntaxKind.TupleExpression)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16420,16643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16533,16577);

expr = (TupleExpressionSyntax)f_10805_16563_16576(parent);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16607,16616);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16420,16643);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16669,16681);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16306,17352);

case SyntaxKind.SimpleAssignmentExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16306,17352);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16772,16932) || true) && ((object)f_10805_16784_16825(((AssignmentExpressionSyntax)parent))== expr)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16772,16932);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16891,16905);

return parent;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16772,16932);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,16958,16970);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16306,17352);

case SyntaxKind.ForEachVariableStatement:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16306,17352);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17059,17227) || true) && ((object)f_10805_17071_17120(((ForEachVariableStatementSyntax)parent))== expr)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,17059,17227);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17186,17200);

return parent;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,17059,17227);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17253,17265);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16306,17352);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,16306,17352);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17321,17333);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,16306,17352);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,15993,17367);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,15993,17367);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,15993,17367);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,15646,17378);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_15771_15782(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 15771, 15782);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_16051_16062(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16051, 16062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_16096_16107(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16096, 16107);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_16147_16158(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16147, 16158);
return return_v;
}


int
f_10805_16038_16188(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16038, 16188);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10805_16220_16231(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 16220, 16231);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_16314_16327(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16314, 16327);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10805_16424_16437(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 16424, 16437);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind?
f_10805_16424_16445_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 16424, 16445);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10805_16563_16576(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 16563, 16576);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10805_16784_16825(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
this_param)
{
var return_v = this_param.Left ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 16784, 16825);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10805_17071_17120(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
this_param)
{
var return_v = this_param.Variable ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 17071, 17120);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,15646,17378);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,15646,17378);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsOutDeclaration(this DeclarationExpressionSyntax p)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,17390,17641);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17488,17630);

return f_10805_17495_17511_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10805_17495_17503(p), 10805, 17495, 17511).Kind())== SyntaxKind.Argument
&&(DynAbs.Tracing.TraceSender.Expression_True(10805, 17495, 17629)&&((ArgumentSyntax)f_10805_17572_17580(p)).RefOrOutKeyword.Kind()== SyntaxKind.OutKeyword);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,17390,17641);

Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
f_10805_17495_17503(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 17495, 17503);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind?
f_10805_17495_17511_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 17495, 17511);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10805_17572_17580(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 17572, 17580);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,17390,17641);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,17390,17641);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool IsOutVarDeclaration(this DeclarationExpressionSyntax p)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,17653,17857);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,17754,17846);

return f_10805_17761_17781(f_10805_17761_17774(p))== SyntaxKind.SingleVariableDesignation &&(DynAbs.Tracing.TraceSender.Expression_True(10805, 17761, 17845)&&f_10805_17825_17845(p));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,17653,17857);

Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
f_10805_17761_17774(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
this_param)
{
var return_v = this_param.Designation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 17761, 17774);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_17761_17781(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 17761, 17781);
return return_v;
}


bool
f_10805_17825_17845(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
p)
{
var return_v = p.IsOutDeclaration();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 17825, 17845);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,17653,17857);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,17653,17857);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void VisitRankSpecifiers<TArg>(this TypeSyntax type, Action<ArrayRankSpecifierSyntax, TArg> action, in TArg argument)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10805,18232,22391);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18493,18544);

var 
stack = f_10805_18505_18543<TArg>()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18558,18575);

f_10805_18558_18574<TArg>(            stack, type);
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18591,22351) || true) && (f_10805_18598_18609<TArg>(stack)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18591,22351);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18647,18673);

var 
current = f_10805_18661_18672<TArg>(stack)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18691,18977) || true) && (current is ArrayRankSpecifierSyntax rankSpecifier)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18691,18977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18786,18818);

f_10805_18786_18817<TArg>(action, rankSpecifier, argument);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18840,18849);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18691,18977);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18691,18977);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18931,18958);

type = (TypeSyntax)current;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18691,18977);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,18997,22336);

switch (f_10805_19005_19016<TArg>(type))
                {

case SyntaxKind.ArrayType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19110,19154);

var 
arrayTypeSyntax = (ArrayTypeSyntax)type
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19189,19233);
                        for (int 
i = arrayTypeSyntax.RankSpecifiers.Count - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19180,19377) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19243,19246)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(10805,19180,19377))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,19180,19377);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19304,19350);

f_10805_19304_19349<TArg>(                            stack, f_10805_19315_19345<TArg>(arrayTypeSyntax)[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,1,198);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,1,198);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19403,19443);

f_10805_19403_19442<TArg>(                        stack, f_10805_19414_19441<TArg>(arrayTypeSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,19469,19475);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.NullableType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19552,19602);

var 
nullableTypeSyntax = (NullableTypeSyntax)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19628,19671);

f_10805_19628_19670<TArg>(                        stack, f_10805_19639_19669<TArg>(nullableTypeSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,19697,19703);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.PointerType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19779,19827);

var 
pointerTypeSyntax = (PointerTypeSyntax)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,19853,19895);

f_10805_19853_19894<TArg>(                        stack, f_10805_19864_19893<TArg>(pointerTypeSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,19921,19927);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.FunctionPointerType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20011,20075);

var 
functionPointerTypeSyntax = (FunctionPointerTypeSyntax)type
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20110,20174);
                        for (int 
i = f_10805_20114_20153<TArg>(functionPointerTypeSyntax).Parameters.Count - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20101,20471) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20184,20187)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(10805,20101,20471))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,20101,20471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20245,20328);

TypeSyntax? 
paramType = f_10805_20269_20327<TArg>(f_10805_20269_20319<TArg>(f_10805_20269_20308<TArg>(functionPointerTypeSyntax))[i])
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20358,20392);

f_10805_20358_20391<TArg>(paramType is object);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20422,20444);

f_10805_20422_20443<TArg>(                            stack, paramType);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,1,371);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,1,371);
}DynAbs.Tracing.TraceSender.TraceBreak(10805,20497,20503);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.TupleType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20577,20621);

var 
tupleTypeSyntax = (TupleTypeSyntax)type
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20656,20694);
                        for (int 
i = tupleTypeSyntax.Elements.Count - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20647,20837) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20704,20707)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(10805,20647,20837))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,20647,20837);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20765,20810);

f_10805_20765_20809<TArg>(                            stack, f_10805_20776_20808<TArg>(f_10805_20776_20800<TArg>(tupleTypeSyntax)[i]));
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,1,191);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,1,191);
}DynAbs.Tracing.TraceSender.TraceBreak(10805,20863,20869);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.RefType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,20941,20981);

var 
refTypeSyntax = (RefTypeSyntax)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21007,21038);

f_10805_21007_21037<TArg>(                        stack, f_10805_21018_21036<TArg>(refTypeSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,21064,21070);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.GenericName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21146,21194);

var 
genericNameSyntax = (GenericNameSyntax)type
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21229,21287);
                        for (int 
i = f_10805_21233_21267<TArg>(genericNameSyntax).Arguments.Count - 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21220,21445) || true) && (i >= 0)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21297,21300)
,i--,DynAbs.Tracing.TraceSender.TraceExitCondition(10805,21220,21445))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,21220,21445);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21358,21418);

f_10805_21358_21417<TArg>(                            stack, f_10805_21369_21413<TArg>(f_10805_21369_21403<TArg>(genericNameSyntax))[i]);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,1,226);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,1,226);
}DynAbs.Tracing.TraceSender.TraceBreak(10805,21471,21477);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.QualifiedName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21555,21607);

var 
qualifiedNameSyntax = (QualifiedNameSyntax)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21633,21671);

f_10805_21633_21670<TArg>(                        stack, f_10805_21644_21669<TArg>(qualifiedNameSyntax));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21697,21734);

f_10805_21697_21733<TArg>(                        stack, f_10805_21708_21732<TArg>(qualifiedNameSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,21760,21766);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.AliasQualifiedName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21849,21911);

var 
aliasQualifiedNameSyntax = (AliasQualifiedNameSyntax)type
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,21937,21979);

f_10805_21937_21978<TArg>(                        stack, f_10805_21948_21977<TArg>(aliasQualifiedNameSyntax));
DynAbs.Tracing.TraceSender.TraceBreak(10805,22005,22011);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

case SyntaxKind.IdentifierName:
                    case SyntaxKind.OmittedTypeArgument:
                    case SyntaxKind.PredefinedType:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceBreak(10805,22201,22207);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10805,18997,22336);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,22263,22317);

throw f_10805_22269_22316<TArg>(f_10805_22304_22315<TArg>(type));
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18997,22336);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10805,18591,22351);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10805,18591,22351);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10805,18591,22351);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10805,22367,22380);

f_10805_22367_22379<TArg>(
            stack);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10805,18232,22391);

Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
f_10805_18505_18543<TArg>()
{
var return_v = ArrayBuilder<SyntaxNode>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 18505, 18543);
return return_v;
}


int
f_10805_18558_18574<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 18558, 18574);
return 0;
}


int
f_10805_18598_18609<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 18598, 18609);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10805_18661_18672<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder)
{
var return_v = builder.Pop<Microsoft.CodeAnalysis.SyntaxNode>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 18661, 18672);
return return_v;
}


int
f_10805_18786_18817<TArg>(System.Action<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax, TArg>
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
arg1,TArg?
arg2)
{
this_param.Invoke( arg1, arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 18786, 18817);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_19005_19016<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 19005, 19016);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax>
f_10805_19315_19345<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
this_param)
{
var return_v = this_param.RankSpecifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 19315, 19345);
return return_v;
}


int
f_10805_19304_19349<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.ArrayRankSpecifierSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 19304, 19349);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_19414_19441<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.ArrayTypeSyntax
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 19414, 19441);
return return_v;
}


int
f_10805_19403_19442<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 19403, 19442);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_19639_19669<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.NullableTypeSyntax
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 19639, 19669);
return return_v;
}


int
f_10805_19628_19670<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 19628, 19670);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_19864_19893<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.PointerTypeSyntax
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 19864, 19893);
return return_v;
}


int
f_10805_19853_19894<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 19853, 19894);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
f_10805_20114_20153<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
this_param)
{
var return_v = this_param.ParameterList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20114, 20153);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
f_10805_20269_20308<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
this_param)
{
var return_v = this_param.ParameterList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20269, 20308);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
f_10805_20269_20319<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20269, 20319);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_20269_20327<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20269, 20327);
return return_v;
}


int
f_10805_20358_20391<TArg>(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 20358, 20391);
return 0;
}


int
f_10805_20422_20443<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 20422, 20443);
return 0;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax>
f_10805_20776_20800<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.TupleTypeSyntax
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20776, 20800);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_20776_20808<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.TupleElementSyntax
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 20776, 20808);
return return_v;
}


int
f_10805_20765_20809<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 20765, 20809);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10805_21018_21036<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21018, 21036);
return return_v;
}


int
f_10805_21007_21037<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 21007, 21037);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
f_10805_21233_21267<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
this_param)
{
var return_v = this_param.TypeArgumentList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21233, 21267);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
f_10805_21369_21403<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.GenericNameSyntax
this_param)
{
var return_v = this_param.TypeArgumentList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21369, 21403);
return return_v;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
f_10805_21369_21413<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.TypeArgumentListSyntax
this_param)
{
var return_v = this_param.Arguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21369, 21413);
return return_v;
}


int
f_10805_21358_21417<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 21358, 21417);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
f_10805_21644_21669<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
this_param)
{
var return_v = this_param.Right;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21644, 21669);
return return_v;
}


int
f_10805_21633_21670<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 21633, 21670);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
f_10805_21708_21732<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21708, 21732);
return return_v;
}


int
f_10805_21697_21733<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 21697, 21733);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
f_10805_21948_21977<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10805, 21948, 21977);
return return_v;
}


int
f_10805_21937_21978<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
builder,Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
e)
{
builder.Push<Microsoft.CodeAnalysis.SyntaxNode>( (Microsoft.CodeAnalysis.SyntaxNode)e);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 21937, 21978);
return 0;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10805_22304_22315<TArg>(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
this_param)
{
var return_v = this_param.Kind();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 22304, 22315);
return return_v;
}


System.Exception
f_10805_22269_22316<TArg>(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 22269, 22316);
return return_v;
}


int
f_10805_22367_22379<TArg>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxNode>
this_param)
{
this_param.Free();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10805, 22367, 22379);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10805,18232,22391);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,18232,22391);
}
		}

static SyntaxExtensions()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10805,490,22398);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10805,490,22398);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10805,490,22398);
}

}
}
