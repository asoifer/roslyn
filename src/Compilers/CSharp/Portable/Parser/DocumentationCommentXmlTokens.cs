// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
internal static class DocumentationCommentXmlTokens
{
private static readonly SyntaxToken s_seeToken ;

private static readonly SyntaxToken s_codeToken ;

private static readonly SyntaxToken s_listToken ;

private static readonly SyntaxToken s_paramToken ;

private static readonly SyntaxToken s_valueToken ;

private static readonly SyntaxToken s_exampleToken ;

private static readonly SyntaxToken s_includeToken ;

private static readonly SyntaxToken s_remarksToken ;

private static readonly SyntaxToken s_seealsoToken ;

private static readonly SyntaxToken s_summaryToken ;

private static readonly SyntaxToken s_exceptionToken ;

private static readonly SyntaxToken s_typeparamToken ;

private static readonly SyntaxToken s_permissionToken ;

private static readonly SyntaxToken s_typeparamrefToken ;

private static readonly SyntaxToken s_crefToken ;

private static readonly SyntaxToken s_fileToken ;

private static readonly SyntaxToken s_nameToken ;

private static readonly SyntaxToken s_pathToken ;

private static readonly SyntaxToken s_typeToken ;

private static SyntaxToken Identifier(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,3128,3297);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,3203,3286);

return f_10017_3210_3285(SyntaxKind.None, null, text, text, trailing: null);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,3128,3297);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_3210_3285(Microsoft.CodeAnalysis.CSharp.SyntaxKind
contextualKind,Microsoft.CodeAnalysis.GreenNode
leading,string
text,string
valueText,Microsoft.CodeAnalysis.GreenNode
trailing)
{
var return_v = SyntaxFactory.Identifier( contextualKind, leading, text, valueText, trailing:trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 3210, 3285);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,3128,3297);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,3128,3297);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SyntaxToken IdentifierWithLeadingSpace(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,3309,3509);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,3400,3498);

return f_10017_3407_3497(SyntaxKind.None, SyntaxFactory.Space, text, text, trailing: null);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,3309,3509);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_3407_3497(Microsoft.CodeAnalysis.CSharp.SyntaxKind
contextualKind,Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
leading,string
text,string
valueText,Microsoft.CodeAnalysis.GreenNode
trailing)
{
var return_v = SyntaxFactory.Identifier( contextualKind, (Microsoft.CodeAnalysis.GreenNode)leading, text, valueText, trailing:trailing);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 3407, 3497);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,3309,3509);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,3309,3509);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsSingleSpaceTrivia(SyntaxListBuilder syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,3521,3696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,3611,3685);

return f_10017_3618_3630(syntax)== 1 &&(DynAbs.Tracing.TraceSender.Expression_True(10017, 3618, 3684)&&f_10017_3639_3684(SyntaxFactory.Space, f_10017_3674_3683(syntax, 0)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,3521,3696);

int
f_10017_3618_3630(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10017, 3618, 3630);
return return_v;
}


Microsoft.CodeAnalysis.GreenNode?
f_10017_3674_3683(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10017, 3674, 3683);
return return_v;
}


bool
f_10017_3639_3684(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxTrivia
this_param,Microsoft.CodeAnalysis.GreenNode?
other)
{
var return_v = this_param.IsEquivalentTo( other);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 3639, 3684);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,3521,3696);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,3521,3696);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static SyntaxToken LookupToken(string text, SyntaxListBuilder leading)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,4223,4594);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4325,4426) || true) && (leading == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4325,4426);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4378,4411);

return f_10017_4385_4410(text);
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4325,4426);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4442,4555) || true) && (f_10017_4446_4474(leading))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4442,4555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4508,4540);

return f_10017_4515_4539(text);
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4442,4555);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4571,4583);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,4223,4594);

Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_4385_4410(string
text)
{
var return_v = LookupXmlElementTag( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 4385, 4410);
return return_v;
}


bool
f_10017_4446_4474(Microsoft.CodeAnalysis.Syntax.InternalSyntax.SyntaxListBuilder
syntax)
{
var return_v = IsSingleSpaceTrivia( syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 4446, 4474);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_4515_4539(string
text)
{
var return_v = LookupXmlAttribute( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 4515, 4539);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,4223,4594);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,4223,4594);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SyntaxToken LookupXmlElementTag(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,4606,7476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4690,7437);

switch (f_10017_4698_4709(text))
            {

case 3:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4772,4918) || true) && (text == DocumentationCommentXmlNames.SeeElementName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4772,4918);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4877,4895);

return s_seeToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4772,4918);
}
DynAbs.Tracing.TraceSender.TraceBreak(10017,4940,4946);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 4:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,4995,5306);

switch (text)
                    {

case DocumentationCommentXmlNames.CodeElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4995,5306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5137,5156);

return s_codeToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4995,5306);

case DocumentationCommentXmlNames.ListElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4995,5306);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5264,5283);

return s_listToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4995,5306);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10017,5328,5334);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 5:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5383,5702);

switch (text)
                    {

case DocumentationCommentXmlNames.ParameterElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5383,5702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5530,5550);

return s_paramToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5383,5702);

case DocumentationCommentXmlNames.ValueElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5383,5702);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5659,5679);

return s_valueToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5383,5702);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10017,5724,5730);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 7:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5779,6501);

switch (text)
                    {

case DocumentationCommentXmlNames.ExampleElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5779,6501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,5924,5946);

return s_exampleToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5779,6501);

case DocumentationCommentXmlNames.IncludeElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5779,6501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6057,6079);

return s_includeToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5779,6501);

case DocumentationCommentXmlNames.RemarksElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5779,6501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6190,6212);

return s_remarksToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5779,6501);

case DocumentationCommentXmlNames.SeeAlsoElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5779,6501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6323,6345);

return s_seealsoToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5779,6501);

case DocumentationCommentXmlNames.SummaryElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,5779,6501);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6456,6478);

return s_summaryToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,5779,6501);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10017,6523,6529);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 9:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6578,6913);

switch (text)
                    {

case DocumentationCommentXmlNames.ExceptionElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,6578,6913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6725,6749);

return s_exceptionToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,6578,6913);

case DocumentationCommentXmlNames.TypeParameterElementName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,6578,6913);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6866,6890);

return s_typeparamToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,6578,6913);
                    }
DynAbs.Tracing.TraceSender.TraceBreak(10017,6935,6941);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 10:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,6991,7151) || true) && (text == DocumentationCommentXmlNames.PermissionElementName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,6991,7151);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7103,7128);

return s_permissionToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,6991,7151);
}
DynAbs.Tracing.TraceSender.TraceBreak(10017,7173,7179);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);

case 12:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,4690,7437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7229,7394) || true) && (text == DocumentationCommentXmlNames.TypeParameterElementName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7229,7394);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7344,7371);

return s_typeparamrefToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7229,7394);
}
DynAbs.Tracing.TraceSender.TraceBreak(10017,7416,7422);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,4690,7437);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7453,7465);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,4606,7476);

int
f_10017_4698_4709(string
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10017, 4698, 4709);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,4606,7476);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,4606,7476);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static SyntaxToken LookupXmlAttribute(string text)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10017,7488,8473);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7636,7717) || true) && (f_10017_7640_7651(text)!= 4)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7636,7717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7690,7702);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7636,7717);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7828,8434);

switch (text)
            {

case DocumentationCommentXmlNames.CrefAttributeName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7828,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,7948,7967);

return s_crefToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7828,8434);

case DocumentationCommentXmlNames.FileAttributeName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7828,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,8061,8080);

return s_fileToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7828,8434);

case DocumentationCommentXmlNames.NameAttributeName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7828,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,8174,8193);

return s_nameToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7828,8434);

case DocumentationCommentXmlNames.PathAttributeName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7828,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,8287,8306);

return s_pathToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7828,8434);

case DocumentationCommentXmlNames.TypeAttributeName:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10017,7828,8434);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,8400,8419);

return s_typeToken;
DynAbs.Tracing.TraceSender.TraceExitCondition(10017,7828,8434);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,8450,8462);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10017,7488,8473);

int
f_10017_7640_7651(string
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10017, 7640, 7651);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10017,7488,8473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,7488,8473);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static DocumentationCommentXmlTokens()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10017,498,8480);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,668,736);
s_seeToken = f_10017_681_736(DocumentationCommentXmlNames.SeeElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,783,853);
s_codeToken = f_10017_797_853(DocumentationCommentXmlNames.CodeElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,900,970);
s_listToken = f_10017_914_970(DocumentationCommentXmlNames.ListElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1017,1093);
s_paramToken = f_10017_1032_1093(DocumentationCommentXmlNames.ParameterElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1140,1212);
s_valueToken = f_10017_1155_1212(DocumentationCommentXmlNames.ValueElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1259,1335);
s_exampleToken = f_10017_1276_1335(DocumentationCommentXmlNames.ExampleElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1382,1458);
s_includeToken = f_10017_1399_1458(DocumentationCommentXmlNames.IncludeElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1505,1581);
s_remarksToken = f_10017_1522_1581(DocumentationCommentXmlNames.RemarksElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1628,1704);
s_seealsoToken = f_10017_1645_1704(DocumentationCommentXmlNames.SeeAlsoElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1751,1827);
s_summaryToken = f_10017_1768_1827(DocumentationCommentXmlNames.SummaryElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,1874,1954);
s_exceptionToken = f_10017_1893_1954(DocumentationCommentXmlNames.ExceptionElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2001,2085);
s_typeparamToken = f_10017_2020_2085(DocumentationCommentXmlNames.TypeParameterElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2132,2214);
s_permissionToken = f_10017_2152_2214(DocumentationCommentXmlNames.PermissionElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2261,2357);
s_typeparamrefToken = f_10017_2283_2357(DocumentationCommentXmlNames.TypeParameterReferenceElementName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2487,2575);
s_crefToken = f_10017_2501_2575(DocumentationCommentXmlNames.CrefAttributeName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2622,2710);
s_fileToken = f_10017_2636_2710(DocumentationCommentXmlNames.FileAttributeName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2757,2845);
s_nameToken = f_10017_2771_2845(DocumentationCommentXmlNames.NameAttributeName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,2892,2980);
s_pathToken = f_10017_2906_2980(DocumentationCommentXmlNames.PathAttributeName);DynAbs.Tracing.TraceSender.TraceSimpleStatement(10017,3027,3115);
s_typeToken = f_10017_3041_3115(DocumentationCommentXmlNames.TypeAttributeName);DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10017,498,8480);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10017,498,8480);
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_681_736(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 681, 736);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_797_853(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 797, 853);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_914_970(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 914, 970);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1032_1093(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1032, 1093);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1155_1212(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1155, 1212);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1276_1335(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1276, 1335);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1399_1458(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1399, 1458);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1522_1581(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1522, 1581);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1645_1704(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1645, 1704);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1768_1827(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1768, 1827);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_1893_1954(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 1893, 1954);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2020_2085(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2020, 2085);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2152_2214(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2152, 2214);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2283_2357(string
text)
{
var return_v = Identifier( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2283, 2357);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2501_2575(string
text)
{
var return_v = IdentifierWithLeadingSpace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2501, 2575);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2636_2710(string
text)
{
var return_v = IdentifierWithLeadingSpace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2636, 2710);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2771_2845(string
text)
{
var return_v = IdentifierWithLeadingSpace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2771, 2845);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_2906_2980(string
text)
{
var return_v = IdentifierWithLeadingSpace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 2906, 2980);
return return_v;
}


static Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
f_10017_3041_3115(string
text)
{
var return_v = IdentifierWithLeadingSpace( text);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10017, 3041, 3115);
return return_v;
}

}
}
