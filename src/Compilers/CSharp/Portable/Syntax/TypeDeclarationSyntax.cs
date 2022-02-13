// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
public abstract partial class TypeDeclarationSyntax
{
public int Arity
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10815,459,594);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,495,579);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10815, 502, 532)||((f_10815_502_524(this)== null &&DynAbs.Tracing.TraceSender.Conditional_F2(10815, 535, 536))||DynAbs.Tracing.TraceSender.Conditional_F3(10815, 539, 578)))?0 :f_10815_539_561(this).Parameters.Count;
DynAbs.Tracing.TraceSender.TraceExitMethod(10815,459,594);

Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
f_10815_502_524(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param)
{
var return_v = this_param.TypeParameterList ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10815, 502, 524);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
f_10815_539_561(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param)
{
var return_v = this_param.TypeParameterList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10815, 539, 561);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,418,605);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,418,605);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

public new TypeDeclarationSyntax AddAttributeLists(params AttributeListSyntax[] items)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10815,717,771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,720,771);
return (TypeDeclarationSyntax)f_10815_743_771(this, items);DynAbs.Tracing.TraceSender.TraceExitMethod(10815,717,771);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,717,771);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,717,771);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
f_10815_743_771(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param,params Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax[]
items)
{
var return_v = this_param.AddAttributeListsCore( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 743, 771);
return return_v;
}

		}

public new TypeDeclarationSyntax AddModifiers(params SyntaxToken[] items)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10815,871,920);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,874,920);
return (TypeDeclarationSyntax)f_10815_897_920(this, items);DynAbs.Tracing.TraceSender.TraceExitMethod(10815,871,920);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,871,920);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,871,920);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
f_10815_897_920(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param,params Microsoft.CodeAnalysis.SyntaxToken[]
items)
{
var return_v = this_param.AddModifiersCore( items);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 897, 920);
return return_v;
}

		}

public new TypeDeclarationSyntax WithAttributeLists(SyntaxList<AttributeListSyntax> attributeLists)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10815,1046,1110);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1049,1110);
return (TypeDeclarationSyntax)f_10815_1072_1110(this, attributeLists);DynAbs.Tracing.TraceSender.TraceExitMethod(10815,1046,1110);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,1046,1110);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,1046,1110);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
f_10815_1072_1110(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists)
{
var return_v = this_param.WithAttributeListsCore( attributeLists);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 1072, 1110);
return return_v;
}

		}

public new TypeDeclarationSyntax WithModifiers(SyntaxTokenList modifiers)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10815,1210,1264);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1213,1264);
return (TypeDeclarationSyntax)f_10815_1236_1264(this, modifiers);DynAbs.Tracing.TraceSender.TraceExitMethod(10815,1210,1264);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,1210,1264);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,1210,1264);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
f_10815_1236_1264(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
this_param,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers)
{
var return_v = this_param.WithModifiersCore( modifiers);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 1236, 1264);
return return_v;
}

		}

static TypeDeclarationSyntax()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10815,350,1272);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10815,350,1272);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,350,1272);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10815,350,1272);
}
}

namespace Microsoft.CodeAnalysis.CSharp
{
public static partial class SyntaxFactory
{
internal static SyntaxKind GetTypeDeclarationKeywordKind(DeclarationKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10815,1385,1941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1488,1930);

switch (kind)
            {

case DeclarationKind.Class:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,1488,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1583,1614);

return SyntaxKind.ClassKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,1488,1930);

case DeclarationKind.Struct:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,1488,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1682,1714);

return SyntaxKind.StructKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,1488,1930);

case DeclarationKind.Interface:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,1488,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1785,1820);

return SyntaxKind.InterfaceKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,1488,1930);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,1488,1930);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,1868,1915);

throw f_10815_1874_1914(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,1488,1930);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10815,1385,1941);

System.Exception
f_10815_1874_1914(Microsoft.CodeAnalysis.CSharp.DeclarationKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 1874, 1914);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,1385,1941);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,1385,1941);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SyntaxKind GetTypeDeclarationKeywordKind(SyntaxKind kind)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10815,1953,2627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2050,2616);

switch (kind)
            {

case SyntaxKind.ClassDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,2050,2616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2151,2182);

return SyntaxKind.ClassKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,2050,2616);

case SyntaxKind.StructDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,2050,2616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2256,2288);

return SyntaxKind.StructKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,2050,2616);

case SyntaxKind.InterfaceDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,2050,2616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2365,2400);

return SyntaxKind.InterfaceKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,2050,2616);

case SyntaxKind.RecordDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,2050,2616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2474,2506);

return SyntaxKind.RecordKeyword;
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,2050,2616);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,2050,2616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2554,2601);

throw f_10815_2560_2600(kind);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,2050,2616);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10815,1953,2627);

System.Exception
f_10815_2560_2600(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 2560, 2600);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,1953,2627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,1953,2627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static TypeDeclarationSyntax TypeDeclaration(SyntaxKind kind, SyntaxToken identifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10815,2639,3403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,2756,3392);

return f_10815_2763_3391(kind, default(SyntaxList<AttributeListSyntax>), default(SyntaxTokenList), f_10815_2922_2978(f_10815_2942_2977(kind)), identifier, typeParameterList: null, baseList: null, default(SyntaxList<TypeParameterConstraintClauseSyntax>), f_10815_3176_3222(SyntaxKind.OpenBraceToken), default(SyntaxList<MemberDeclarationSyntax>), f_10815_3304_3351(SyntaxKind.CloseBraceToken), default(SyntaxToken));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10815,2639,3403);

Microsoft.CodeAnalysis.CSharp.SyntaxKind
f_10815_2942_2977(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = GetTypeDeclarationKeywordKind( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 2942, 2977);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10815_2922_2978(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.Token( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 2922, 2978);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10815_3176_3222(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.Token( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 3176, 3222);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10815_3304_3351(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFactory.Token( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 3304, 3351);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
f_10815_2763_3391(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributes,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.SyntaxToken
keyword,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
baseList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
members,Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = TypeDeclaration( kind, attributes, modifiers, keyword, identifier, typeParameterList: typeParameterList, baseList: baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 2763, 3391);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,2639,3403);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,2639,3403);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static TypeDeclarationSyntax TypeDeclaration(SyntaxKind kind, string identifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10815,3415,3619);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,3527,3608);

return f_10815_3534_3607(kind, f_10815_3570_3606(identifier));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10815,3415,3619);

Microsoft.CodeAnalysis.SyntaxToken
f_10815_3570_3606(string
text)
{
var return_v = SyntaxFactory.Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 3570, 3606);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
f_10815_3534_3607(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind,Microsoft.CodeAnalysis.SyntaxToken
identifier)
{
var return_v = SyntaxFactory.TypeDeclaration( kind, identifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 3534, 3607);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,3415,3619);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,3415,3619);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static TypeDeclarationSyntax TypeDeclaration(
            SyntaxKind kind,
            SyntaxList<AttributeListSyntax> attributes,
            SyntaxTokenList modifiers,
            SyntaxToken keyword,
            SyntaxToken identifier,
            TypeParameterListSyntax? typeParameterList,
            BaseListSyntax? baseList,
            SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
            SyntaxToken openBraceToken,
            SyntaxList<MemberDeclarationSyntax> members,
            SyntaxToken closeBraceToken,
            SyntaxToken semicolonToken)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10815,3631,5479);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,4264,5468);

switch (kind)
            {

case SyntaxKind.ClassDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,4264,5468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,4365,4553);

return f_10815_4372_4552(attributes, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,4264,5468);

case SyntaxKind.StructDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,4264,5468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,4627,4816);

return f_10815_4634_4815(attributes, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,4264,5468);

case SyntaxKind.InterfaceDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,4264,5468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,4893,5085);

return f_10815_4900_5084(attributes, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,4264,5468);

case SyntaxKind.RecordDeclaration:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,4264,5468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,5159,5369);

return f_10815_5166_5368(attributes, modifiers, keyword, identifier, typeParameterList, parameterList: null, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,4264,5468);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10815,4264,5468);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10815,5417,5453);

throw f_10815_5423_5452("kind");
DynAbs.Tracing.TraceSender.TraceExitCondition(10815,4264,5468);
            }
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10815,3631,5479);

Microsoft.CodeAnalysis.CSharp.Syntax.ClassDeclarationSyntax
f_10815_4372_4552(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.SyntaxToken
keyword,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
baseList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
members,Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = SyntaxFactory.ClassDeclaration( attributeLists, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 4372, 4552);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.StructDeclarationSyntax
f_10815_4634_4815(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.SyntaxToken
keyword,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
baseList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
members,Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = SyntaxFactory.StructDeclaration( attributeLists, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 4634, 4815);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InterfaceDeclarationSyntax
f_10815_4900_5084(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.SyntaxToken
keyword,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
baseList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
members,Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = SyntaxFactory.InterfaceDeclaration( attributeLists, modifiers, keyword, identifier, typeParameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 4900, 5084);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
f_10815_5166_5368(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
attributeLists,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.SyntaxToken
keyword,Microsoft.CodeAnalysis.SyntaxToken
identifier,Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax?
typeParameterList,Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
parameterList,Microsoft.CodeAnalysis.CSharp.Syntax.BaseListSyntax?
baseList,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
constraintClauses,Microsoft.CodeAnalysis.SyntaxToken
openBraceToken,Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax>
members,Microsoft.CodeAnalysis.SyntaxToken
closeBraceToken,Microsoft.CodeAnalysis.SyntaxToken
semicolonToken)
{
var return_v = SyntaxFactory.RecordDeclaration( attributeLists, modifiers, keyword, identifier, typeParameterList, parameterList: parameterList, baseList, constraintClauses, openBraceToken, members, closeBraceToken, semicolonToken);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 5166, 5368);
return return_v;
}


System.ArgumentException
f_10815_5423_5452(string
message)
{
var return_v = new System.ArgumentException( message);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10815, 5423, 5452);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10815,3631,5479);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10815,3631,5479);
}
			throw new System.Exception("Slicer error: unreachable code");
		}
}
}
