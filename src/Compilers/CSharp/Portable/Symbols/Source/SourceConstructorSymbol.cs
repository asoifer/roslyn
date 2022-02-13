// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
internal sealed class SourceConstructorSymbol : SourceConstructorSymbolBase
{
private readonly bool _isExpressionBodied;

private readonly bool _hasThisInitializer;

public static SourceConstructorSymbol CreateConstructorSymbol(
            SourceMemberContainerTypeSymbol containingType,
            ConstructorDeclarationSyntax syntax,
            bool isNullableAnalysisEnabled,
            DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10241,582,1154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,865,985);

var 
methodKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10241, 882, 928)||((syntax.Modifiers.Any(SyntaxKind.StaticKeyword)&&DynAbs.Tracing.TraceSender.Conditional_F2(10241, 931, 959))||DynAbs.Tracing.TraceSender.Conditional_F3(10241, 962, 984)))?MethodKind.StaticConstructor :MethodKind.Constructor
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,999,1143);

return f_10241_1006_1142(containingType, syntax.Identifier.GetLocation(), syntax, methodKind, isNullableAnalysisEnabled, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10241,582,1154);

Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
f_10241_1006_1142(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
containingType,Microsoft.CodeAnalysis.Location
location,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntax,Microsoft.CodeAnalysis.MethodKind
methodKind,bool
isNullableAnalysisEnabled,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol( containingType, location, syntax, methodKind, isNullableAnalysisEnabled, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 1006, 1142);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,582,1154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,582,1154);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private SourceConstructorSymbol(
             SourceMemberContainerTypeSymbol containingType,
             Location location,
             ConstructorDeclarationSyntax syntax,
             MethodKind methodKind,
            bool isNullableAnalysisEnabled,
             DiagnosticBag diagnostics) :base(f_10241_1489_1503_C(containingType) ,location,syntax,f_10241_1523_1561(syntax))
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(10241,1166,3638);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,498,517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,550,569);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1587,1627);

bool 
hasBlockBody = f_10241_1607_1618(syntax)!= null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1641,1710);

_isExpressionBodied = !hasBlockBody &&(DynAbs.Tracing.TraceSender.Expression_True(10241, 1663, 1709)&&f_10241_1680_1701(syntax)!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1724,1775);

bool 
hasBody = hasBlockBody ||(DynAbs.Tracing.TraceSender.Expression_False(10241, 1739, 1774)||_isExpressionBodied)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1791,1881);

_hasThisInitializer = f_10241_1813_1839_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10241_1813_1831(syntax), 10241, 1813, 1839)?.Kind())== SyntaxKind.ThisConstructorInitializer;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1897,1917);

bool 
modifierErrors
=default(bool);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,1931,2059);

var 
declarationModifiers = f_10241_1958_2058(this, f_10241_1977_1993(syntax), methodKind, hasBody, location, diagnostics, out modifierErrors)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2073,2221);

f_10241_2073_2220(            this, methodKind, declarationModifiers, returnsVoid: true, isExtensionMethod: false, isNullableAnalysisEnabled: isNullableAnalysisEnabled);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2237,2478) || true) && (syntax.Identifier.ValueText != f_10241_2272_2291(containingType))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,2237,2478);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2406,2463);

f_10241_2406_2462(                // This is probably a method declaration with the type missing.
                diagnostics, ErrorCode.ERR_MemberNeedsType, location);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,2237,2478);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2494,2918) || true) && (f_10241_2498_2506())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,2494,2918);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2540,2750) || true) && (methodKind == MethodKind.Constructor &&(DynAbs.Tracing.TraceSender.Expression_True(10241, 2544, 2610)&&f_10241_2584_2602(syntax)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,2540,2750);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2652,2731);

f_10241_2652_2730(                    diagnostics, ErrorCode.ERR_ExternHasConstructorInitializer, location, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,2540,2750);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2770,2903) || true) && (hasBody)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,2770,2903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2823,2884);

f_10241_2823_2883(                    diagnostics, ErrorCode.ERR_ExternHasBody, location, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,2770,2903);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,2494,2918);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,2934,3111) || true) && (methodKind == MethodKind.StaticConstructor)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,2934,3111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3014,3096);

f_10241_3014_3095(this, syntax, location, hasBody, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,2934,3111);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3127,3246);

var 
info = f_10241_3138_3245(this.DeclarationModifiers, this, isExplicitInterfaceImplementation: false)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3260,3357) || true) && (info != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,3260,3357);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3310,3342);

f_10241_3310_3341(                diagnostics, info, location);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,3260,3357);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3373,3505) || true) && (!modifierErrors)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,3373,3505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3426,3490);

f_10241_3426_3489(                this, methodKind, hasBody, location, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,3373,3505);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3521,3627);

f_10241_3521_3626(f_10241_3570_3581(syntax), f_10241_3583_3604(syntax), syntax, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitConstructor(10241,1166,3638);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,1166,3638);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,1166,3638);
}
		}

internal ConstructorDeclarationSyntax GetSyntax()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,3650,3858);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3724,3765);

f_10241_3724_3764(syntaxReferenceOpt != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3779,3847);

return (ConstructorDeclarationSyntax)f_10241_3816_3846(syntaxReferenceOpt);
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,3650,3858);

int
f_10241_3724_3764(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3724, 3764);
return 0;
}


Microsoft.CodeAnalysis.SyntaxNode
f_10241_3816_3846(Microsoft.CodeAnalysis.SyntaxReference
this_param)
{
var return_v = this_param.GetSyntax();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3816, 3846);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,3650,3858);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,3650,3858);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override ParameterListSyntax GetParameterList()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,3870,3996);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,3952,3985);

return f_10241_3959_3984(f_10241_3959_3970(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,3870,3996);

Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_10241_3959_3970(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.GetSyntax();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3959, 3970);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
f_10241_3959_3984(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ParameterList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 3959, 3984);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,3870,3996);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,3870,3996);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override CSharpSyntaxNode GetInitializer()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,4008,4127);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,4085,4116);

return f_10241_4092_4115(f_10241_4092_4103(this));
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,4008,4127);

Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_10241_4092_4103(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.GetSyntax();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 4092, 4103);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
f_10241_4092_4115(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 4092, 4115);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,4008,4127);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,4008,4127);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private DeclarationModifiers MakeModifiers(SyntaxTokenList modifiers, MethodKind methodKind, bool hasBody, Location location, DiagnosticBag diagnostics, out bool modifierErrors)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,4139,5998);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,4341,4465);

var 
defaultAccess = (DynAbs.Tracing.TraceSender.Conditional_F1(10241, 4361, 4405)||(((methodKind == MethodKind.StaticConstructor) &&DynAbs.Tracing.TraceSender.Conditional_F2(10241, 4408, 4433))||DynAbs.Tracing.TraceSender.Conditional_F3(10241, 4436, 4464)))?DeclarationModifiers.None :DeclarationModifiers.Private
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,4540,4783);

const DeclarationModifiers 
allowedModifiers =
                DeclarationModifiers.AccessibilityMask |
                DeclarationModifiers.Static |
                DeclarationModifiers.Extern |
                DeclarationModifiers.Unsafe
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,4799,4946);

var 
mods = f_10241_4810_4945(modifiers, defaultAccess, allowedModifiers, location, diagnostics, out modifierErrors)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,4962,5006);

f_10241_4962_5005(
            this, mods, diagnostics);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5022,5959) || true) && (methodKind == MethodKind.StaticConstructor)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,5022,5959);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5102,5423) || true) && ((mods & DeclarationModifiers.AccessibilityMask) != 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,5102,5423);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5200,5284);

f_10241_5200_5283(                    diagnostics, ErrorCode.ERR_StaticConstructorWithAccessModifiers, location, this);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5306,5360);

mods = mods & ~DeclarationModifiers.AccessibilityMask;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5382,5404);

modifierErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,5102,5423);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5443,5480);

mods |= DeclarationModifiers.Private;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5559,5944) || true) && (f_10241_5563_5594(f_10241_5563_5582(this)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,5559,5944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5636,5925);

f_10241_5636_5924(hasBody, mods, DeclarationModifiers.Extern, location, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,5559,5944);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,5022,5959);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,5975,5987);

return mods;
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,4139,5998);

Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
f_10241_4810_4945(Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
defaultAccess,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
allowedModifiers,Microsoft.CodeAnalysis.Location
errorLocation,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,out bool
modifierErrors)
{
var return_v = ModifierUtils.MakeAndCheckNontypeMemberModifiers( modifiers, defaultAccess, allowedModifiers, errorLocation, diagnostics, out modifierErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 4810, 4945);
return return_v;
}


int
f_10241_4962_5005(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
symbol,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
modifiers,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
symbol.CheckUnsafeModifier( modifiers, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 4962, 5005);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_5200_5283(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 5200, 5283);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10241_5563_5582(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 5563, 5582);
return return_v;
}


bool
f_10241_5563_5594(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsInterface;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 5563, 5594);
return return_v;
}


int
f_10241_5636_5924(bool
hasBody,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
modifiers,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
defaultInterfaceImplementationModifiers,Microsoft.CodeAnalysis.Location
errorLocation,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
ModifierUtils.ReportDefaultInterfaceImplementationModifiers( hasBody, modifiers, defaultInterfaceImplementationModifiers, errorLocation, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 5636, 5924);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,4139,5998);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,4139,5998);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckModifiers(MethodKind methodKind, bool hasBody, Location location, DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,6010,6755);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6145,6744) || true) && (!hasBody &&(DynAbs.Tracing.TraceSender.Expression_True(10241, 6149, 6170)&&f_10241_6161_6170_M(!IsExtern)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,6145,6744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6204,6271);

f_10241_6204_6270(                diagnostics, ErrorCode.ERR_ConcreteMissingBody, location, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,6145,6744);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,6145,6744);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6305,6744) || true) && (f_10241_6309_6332(f_10241_6309_6323())&&(DynAbs.Tracing.TraceSender.Expression_True(10241, 6309, 6377)&&f_10241_6336_6377(f_10241_6336_6362(this)))&&(DynAbs.Tracing.TraceSender.Expression_True(10241, 6309, 6397)&&f_10241_6381_6397_M(!this.IsOverride)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,6305,6744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6431,6528);

f_10241_6431_6527(                diagnostics, f_10241_6447_6510(f_10241_6495_6509()), location, this);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,6305,6744);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,6305,6744);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6562,6744) || true) && (f_10241_6566_6589(f_10241_6566_6580())&&(DynAbs.Tracing.TraceSender.Expression_True(10241, 6566, 6629)&&methodKind == MethodKind.Constructor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,6562,6744);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6663,6729);

f_10241_6663_6728(                diagnostics, ErrorCode.ERR_ConstructorInStaticClass, location);
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,6562,6744);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,6305,6744);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,6145,6744);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,6010,6755);

bool
f_10241_6161_6170_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6161, 6170);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_6204_6270(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6204, 6270);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10241_6309_6323()
{
var return_v = ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6309, 6323);
return return_v;
}


bool
f_10241_6309_6332(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsSealed ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6309, 6332);
return return_v;
}


Microsoft.CodeAnalysis.Accessibility
f_10241_6336_6362(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.DeclaredAccessibility;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6336, 6362);
return return_v;
}


bool
f_10241_6336_6377(Microsoft.CodeAnalysis.Accessibility
accessibility)
{
var return_v = accessibility.HasProtected();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6336, 6377);
return return_v;
}


bool
f_10241_6381_6397_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6381, 6397);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10241_6495_6509()
{
var return_v = ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6495, 6509);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ErrorCode
f_10241_6447_6510(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
containingType)
{
var return_v = AccessCheck.GetProtectedMemberInSealedTypeError( containingType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6447, 6510);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_6431_6527(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6431, 6527);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10241_6566_6580()
{
var return_v = ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6566, 6580);
return return_v;
}


bool
f_10241_6566_6589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6566, 6589);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_6663_6728(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6663, 6728);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,6010,6755);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,6010,6755);
}
		}

internal override OneOrMany<SyntaxList<AttributeListSyntax>> GetAttributeDeclarations()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,6767,6978);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,6879,6967);

return f_10241_6886_6966(f_10241_6903_6965(((ConstructorDeclarationSyntax)f_10241_6934_6949(this))));
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,6767,6978);

Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10241_6934_6949(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.SyntaxNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6934, 6949);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
f_10241_6903_6965(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.AttributeLists;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 6903, 6965);
return return_v;
}


Roslyn.Utilities.OneOrMany<Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>>
f_10241_6886_6966(Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
one)
{
var return_v = OneOrMany.Create( one);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 6886, 6966);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,6767,6978);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,6767,6978);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal override bool IsExpressionBodied
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,7056,7134);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7092,7119);

return _isExpressionBodied;
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,7056,7134);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,6990,7145);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,6990,7145);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

internal override bool IsNullableAnalysisEnabled()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,7157,7448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7232,7437);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10241, 7239, 7258)||((_hasThisInitializer &&DynAbs.Tracing.TraceSender.Conditional_F2(10241, 7278, 7309))||DynAbs.Tracing.TraceSender.Conditional_F3(10241, 7329, 7436)))?                flags.IsNullableAnalysisEnabled :f_10241_7329_7436(                ((SourceMemberContainerTypeSymbol)f_10241_7363_7377()), f_10241_7427_7435());
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,7157,7448);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10241_7363_7377()
{
var return_v = ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 7363, 7377);
return return_v;
}


bool
f_10241_7427_7435()
{
var return_v = IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 7427, 7435);
return return_v;
}


bool
f_10241_7329_7436(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
this_param,bool
useStatic)
{
var return_v = this_param.IsNullableEnabledForConstructorsAndInitializers( useStatic);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 7329, 7436);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,7157,7448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,7157,7448);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

protected override bool AllowRefOrOut
{
get
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,7522,7585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7558,7570);

return true;
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,7522,7585);
            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,7460,7596);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,7460,7596);
}
			throw new System.Exception("Slicer error: unreachable code");
		}}

protected override bool IsWithinExpressionOrBlockBody(int position, out int offset)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(10241,7608,8367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7716,7770);

ConstructorDeclarationSyntax 
ctorSyntax = f_10241_7758_7769(this)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7807,8301) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10241, 7811, 7834)||((f_10241_7811_7826(ctorSyntax)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(10241, 7837, 7884))||DynAbs.Tracing.TraceSender.Conditional_F3(10241, 7887, 7892)))?f_10241_7837_7852(ctorSyntax).Span.Contains(position)== true :false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,7807,8301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7926,7973);

offset = position - f_10241_7946_7961(ctorSyntax).Span.Start;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,7991,8003);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,7807,8301);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,7807,8301);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,8060,8301) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10241, 8064, 8097)||((f_10241_8064_8089(ctorSyntax)!= null &&DynAbs.Tracing.TraceSender.Conditional_F2(10241, 8100, 8157))||DynAbs.Tracing.TraceSender.Conditional_F3(10241, 8160, 8165)))?f_10241_8100_8125(ctorSyntax).Span.Contains(position)== true :false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10241,8060,8301);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,8199,8256);

offset = position - f_10241_8219_8244(ctorSyntax).Span.Start;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,8274,8286);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,8060,8301);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10241,7807,8301);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,8317,8329);

offset = -1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10241,8343,8356);

return false;
DynAbs.Tracing.TraceSender.TraceExitMethod(10241,7608,8367);

Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
f_10241_7758_7769(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param)
{
var return_v = this_param.GetSyntax();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 7758, 7769);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
f_10241_7811_7826(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Body ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 7811, 7826);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
f_10241_7837_7852(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 7837, 7852);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
f_10241_7946_7961(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 7946, 7961);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10241_8064_8089(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 8064, 8089);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
f_10241_8100_8125(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 8100, 8125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10241_8219_8244(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 8219, 8244);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10241,7608,8367);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,7608,8367);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static SourceConstructorSymbol()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10241,384,8374);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10241,384,8374);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10241,384,8374);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10241,384,8374);

static bool
f_10241_1523_1561(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
node)
{
var return_v = SyntaxFacts.HasYieldOperations( (Microsoft.CodeAnalysis.SyntaxNode)node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 1523, 1561);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
f_10241_1607_1618(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Body ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 1607, 1618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10241_1680_1701(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 1680, 1701);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
f_10241_1813_1831(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 1813, 1831);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.SyntaxKind?
f_10241_1813_1839_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 1813, 1839);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTokenList
f_10241_1977_1993(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Modifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 1977, 1993);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
f_10241_1958_2058(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param,Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,Microsoft.CodeAnalysis.MethodKind
methodKind,bool
hasBody,Microsoft.CodeAnalysis.Location
location,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,out bool
modifierErrors)
{
var return_v = this_param.MakeModifiers( modifiers, methodKind, hasBody, location, diagnostics, out modifierErrors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 1958, 2058);
return return_v;
}


int
f_10241_2073_2220(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param,Microsoft.CodeAnalysis.MethodKind
methodKind,Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
declarationModifiers,bool
returnsVoid,bool
isExtensionMethod,bool
isNullableAnalysisEnabled)
{
this_param.MakeFlags( methodKind, declarationModifiers, returnsVoid:returnsVoid, isExtensionMethod:isExtensionMethod, isNullableAnalysisEnabled:isNullableAnalysisEnabled);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 2073, 2220);
return 0;
}


string
f_10241_2272_2291(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 2272, 2291);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_2406_2462(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 2406, 2462);
return return_v;
}


bool
f_10241_2498_2506()
{
var return_v = IsExtern;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 2498, 2506);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
f_10241_2584_2602(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Initializer ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 2584, 2602);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_2652_2730(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 2652, 2730);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_2823_2883(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 2823, 2883);
return return_v;
}


int
f_10241_3014_3095(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
declarationSyntax,Microsoft.CodeAnalysis.Location
location,bool
hasBody,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
this_param.CheckFeatureAvailabilityAndRuntimeSupport( (Microsoft.CodeAnalysis.SyntaxNode)declarationSyntax, location, hasBody, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3014, 3095);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10241_3138_3245(Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
modifiers,Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
symbol,bool
isExplicitInterfaceImplementation)
{
var return_v = ModifierUtils.CheckAccessibility( modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol, isExplicitInterfaceImplementation:isExplicitInterfaceImplementation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3138, 3245);
return return_v;
}


int
f_10241_3310_3341(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
info,Microsoft.CodeAnalysis.Location
location)
{
diagnostics.Add( (Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3310, 3341);
return 0;
}


int
f_10241_3426_3489(Microsoft.CodeAnalysis.CSharp.Symbols.SourceConstructorSymbol
this_param,Microsoft.CodeAnalysis.MethodKind
methodKind,bool
hasBody,Microsoft.CodeAnalysis.Location
location,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
this_param.CheckModifiers( methodKind, hasBody, location, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3426, 3489);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
f_10241_3570_3581(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 3570, 3581);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
f_10241_3583_3604(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
this_param)
{
var return_v = this_param.ExpressionBody;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10241, 3583, 3604);
return return_v;
}


int
f_10241_3521_3626(Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
block,Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
expression,Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
syntax,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
CheckForBlockAndExpressionBody( (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)block, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)expression, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10241, 3521, 3626);
return 0;
}


static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
f_10241_1489_1503_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceBaseCall(10241, 1166, 3638);
return return_v;
}

}
}
