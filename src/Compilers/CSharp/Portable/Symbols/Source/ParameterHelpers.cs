// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
internal static class ParameterHelpers
{
public static ImmutableArray<ParameterSymbol> MakeParameters(
            Binder binder,
            Symbol owner,
            BaseParameterListSyntax syntax,
            out SyntaxToken arglistToken,
            DiagnosticBag diagnostics,
            bool allowRefOrOut,
            bool allowThis,
            bool addRefReadOnlyModifier)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,571,2413);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,944,2402);

return f_10235_951_2401(binder, owner, f_10235_1075_1092(syntax), out arglistToken, diagnostics, allowRefOrOut, allowThis, addRefReadOnlyModifier, suppressUseSiteDiagnostics: false, lastIndex: syntax.Parameters.Count - 1, parameterCreationFunc: (Binder context, Symbol owner, TypeWithAnnotations parameterType,
                                        ParameterSyntax syntax, RefKind refKind, int ordinal,
                                        SyntaxToken paramsKeyword, SyntaxToken thisKeyword, bool addRefReadOnlyModifier,
                                        DiagnosticBag declarationDiagnostics) =>
                {
                    return SourceParameterSymbol.Create(
                        context,
                        owner,
                        parameterType,
                        syntax,
                        refKind,
                        syntax.Identifier,
                        ordinal,
                        isParams: paramsKeyword.Kind() != SyntaxKind.None,
                        isExtensionMethodThis: ordinal == 0 && thisKeyword.Kind() != SyntaxKind.None,
                        addRefReadOnlyModifier,
                        declarationDiagnostics);
                });
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,571,2413);

Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
f_10235_1075_1092(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterListSyntax
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 1075, 1092);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10235_951_2401(Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.Symbol
owner,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
parametersList,out Microsoft.CodeAnalysis.SyntaxToken
arglistToken,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
allowRefOrOut,bool
allowThis,bool
addRefReadOnlyModifier,bool
suppressUseSiteDiagnostics,int
lastIndex,System.Func<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax, Microsoft.CodeAnalysis.RefKind, int, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, bool, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameterCreationFunc)
{
var return_v = MakeParameters<ParameterSyntax, ParameterSymbol, Symbol>( binder, owner, parametersList, out arglistToken, diagnostics, allowRefOrOut, allowThis, addRefReadOnlyModifier, suppressUseSiteDiagnostics:suppressUseSiteDiagnostics, lastIndex:lastIndex, parameterCreationFunc:parameterCreationFunc);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 951, 2401);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,571,2413);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,571,2413);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public static ImmutableArray<FunctionPointerParameterSymbol> MakeFunctionPointerParameters(
            Binder binder,
            FunctionPointerMethodSymbol owner,
            SeparatedSyntaxList<FunctionPointerParameterSyntax> parametersList,
            DiagnosticBag diagnostics,
            bool suppressUseSiteDiagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,2425,5033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,2784,5022);

return f_10235_2791_5021(binder, owner, parametersList, out _, diagnostics, allowRefOrOut: true, allowThis: false, addRefReadOnlyModifier: true, suppressUseSiteDiagnostics, parametersList.Count - 2, parameterCreationFunc: (Binder binder, FunctionPointerMethodSymbol owner, TypeWithAnnotations parameterType,
                                        FunctionPointerParameterSyntax syntax, RefKind refKind, int ordinal,
                                        SyntaxToken paramsKeyword, SyntaxToken thisKeyword, bool addRefReadOnlyModifier,
                                        DiagnosticBag diagnostics) =>
                {
                    // Non-function pointer locations have other locations to encode in/ref readonly/outness. For function pointers,
                    // these modreqs are the only locations where this can be encoded. If that changes, we should update this.
                    Debug.Assert(addRefReadOnlyModifier, "If addReadonlyRef isn't true, we must have found a different location to encode the readonlyness of a function pointer");
                    ImmutableArray<CustomModifier> customModifiers = refKind switch
                    {
                        RefKind.In => CreateInModifiers(binder, diagnostics, syntax),
                        RefKind.Out => CreateOutModifiers(binder, diagnostics, syntax),
                        _ => ImmutableArray<CustomModifier>.Empty
                    };

                    if (parameterType.IsVoidType())
                    {
                        diagnostics.Add(ErrorCode.ERR_NoVoidParameter, syntax.Type.Location);
                    }

                    return new FunctionPointerParameterSymbol(
                        parameterType,
                        refKind,
                        ordinal,
                        owner,
                        customModifiers);
                }, parsingFunctionPointer: true);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,2425,5033);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
f_10235_2791_5021(Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
owner,Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
parametersList,out Microsoft.CodeAnalysis.SyntaxToken
arglistToken,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
allowRefOrOut,bool
allowThis,bool
addRefReadOnlyModifier,bool
suppressUseSiteDiagnostics,int
lastIndex,System.Func<Microsoft.CodeAnalysis.CSharp.Binder, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax, Microsoft.CodeAnalysis.RefKind, int, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, bool, Microsoft.CodeAnalysis.DiagnosticBag, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
parameterCreationFunc,bool
parsingFunctionPointer)
{
var return_v = MakeParameters<FunctionPointerParameterSyntax, FunctionPointerParameterSymbol, FunctionPointerMethodSymbol>( binder, owner, parametersList, out arglistToken, diagnostics, allowRefOrOut:allowRefOrOut, allowThis:allowThis, addRefReadOnlyModifier:addRefReadOnlyModifier, suppressUseSiteDiagnostics, lastIndex, parameterCreationFunc:parameterCreationFunc, parsingFunctionPointer:parsingFunctionPointer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 2791, 5021);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,2425,5033);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,2425,5033);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<TParameterSymbol> MakeParameters<TParameterSyntax, TParameterSymbol, TOwningSymbol>(
            Binder binder,
            TOwningSymbol owner,
            SeparatedSyntaxList<TParameterSyntax> parametersList,
            out SyntaxToken arglistToken,
            DiagnosticBag diagnostics,
            bool allowRefOrOut,
            bool allowThis,
            bool addRefReadOnlyModifier,
            bool suppressUseSiteDiagnostics,
            int lastIndex,
            Func<Binder, TOwningSymbol, TypeWithAnnotations, TParameterSyntax, RefKind, int, SyntaxToken, SyntaxToken, bool, DiagnosticBag, TParameterSymbol> parameterCreationFunc,
            bool parsingFunctionPointer = false)
            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,5045,10737);
Microsoft.CodeAnalysis.SyntaxToken refnessKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
Microsoft.CodeAnalysis.SyntaxToken paramsKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
Microsoft.CodeAnalysis.SyntaxToken thisKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,5960,6038);

f_10235_5960_6037<TParameterSyntax, TParameterSymbol, TOwningSymbol>(!parsingFunctionPointer ||(DynAbs.Tracing.TraceSender.Expression_False(10235, 5973, 6036)||owner is FunctionPointerMethodSymbol));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6052,6088);

arglistToken = default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6104,6127);

int 
parameterIndex = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6141,6163);

int 
firstDefault = -1
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6179,6238);

var 
builder = f_10235_6193_6237<TParameterSymbol, TParameterSyntax, TOwningSymbol>()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6252,6300);

var 
mustBeLastParameter = (ParameterSyntax)null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6316,9412);
foreach(var parameterSyntax in f_10235_6348_6362_I<TParameterSyntax>(parametersList) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,6316,9412);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6396,6434) || true) && (parameterIndex > lastIndex)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,6396,6434);
DynAbs.Tracing.TraceSender.TraceBreak(10235,6428,6434);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,6396,6434);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6454,6532);

f_10235_6454_6531<TParameterSyntax, TParameterSymbol, TOwningSymbol>(parameterSyntax, diagnostics, parsingFunctionPointer);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6552,6698);

var 
refKind = f_10235_6566_6697<TParameterSyntax, TParameterSymbol, TOwningSymbol>(f_10235_6579_6604<TParameterSyntax, TParameterSymbol, TOwningSymbol>(parameterSyntax), out refnessKeyword, out paramsKeyword, out thisKeyword)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6716,6907) || true) && (thisKeyword.Kind()!= SyntaxKind.None &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 6720, 6771)&&!allowThis))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,6716,6907);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6813,6888);

f_10235_6813_6887<TParameterSyntax,TParameterSymbol,TOwningSymbol>(                    diagnostics, ErrorCode.ERR_ThisInBadContext, thisKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,6716,6907);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,6927,8382) || true) && (parameterSyntax is ParameterSyntax concreteParam)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,6927,8382);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,7021,7335) || true) && (mustBeLastParameter == null &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 7025, 7226)&&                        (concreteParam.Modifiers.Any(SyntaxKind.ParamsKeyword)||(DynAbs.Tracing.TraceSender.Expression_False(10235, 7082, 7225)||                         concreteParam.Identifier.Kind()== SyntaxKind.ArgListKeyword))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,7021,7335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,7276,7312);

mustBeLastParameter = concreteParam;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,7021,7335);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,7359,8181) || true) && (f_10235_7363_7386<TParameterSyntax, TParameterSymbol, TOwningSymbol>(concreteParam))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,7359,8181);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,7436,7476);

arglistToken = f_10235_7451_7475<TParameterSyntax, TParameterSymbol, TOwningSymbol>(concreteParam);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,7697,8121) || true) && (paramsKeyword.Kind()!= SyntaxKind.None
||(DynAbs.Tracing.TraceSender.Expression_False(10235, 7701, 7813)||refnessKeyword.Kind()!= SyntaxKind.None
)||(DynAbs.Tracing.TraceSender.Expression_False(10235, 7701, 7883)||thisKeyword.Kind()!= SyntaxKind.None))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,7697,8121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8020,8094);

f_10235_8020_8093<TParameterSyntax,TParameterSymbol,TOwningSymbol>(                            // CS1669: __arglist is not valid in this context
                            diagnostics, ErrorCode.ERR_IllegalVarArgs, arglistToken.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,7697,8121);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8149,8158);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,7359,8181);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8205,8363) || true) && (f_10235_8209_8230<TParameterSyntax, TParameterSymbol, TOwningSymbol>(concreteParam)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 8209, 8260)&&firstDefault == -1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,8205,8363);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8310,8340);

firstDefault = parameterIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,8205,8363);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,6927,8382);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8402,8445);

f_10235_8402_8444<TParameterSyntax, TParameterSymbol, TOwningSymbol>(f_10235_8415_8435<TParameterSyntax, TParameterSymbol, TOwningSymbol>(parameterSyntax)!= null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8463,8590);

var 
parameterType = f_10235_8483_8589<TParameterSyntax,TParameterSymbol,TOwningSymbol>(binder, f_10235_8499_8519<TParameterSyntax, TParameterSymbol, TOwningSymbol>(parameterSyntax), diagnostics, suppressUseSiteDiagnostics: suppressUseSiteDiagnostics)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8610,8979) || true) && (!allowRefOrOut &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 8614, 8682)&&(refKind == RefKind.Ref ||(DynAbs.Tracing.TraceSender.Expression_False(10235, 8633, 8681)||refKind == RefKind.Out))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,8610,8979);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8724,8779);

f_10235_8724_8778<TParameterSyntax, TParameterSymbol, TOwningSymbol>(refnessKeyword.Kind()!= SyntaxKind.None);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8883,8960);

f_10235_8883_8959<TParameterSyntax,TParameterSymbol,TOwningSymbol>(
                    // error CS0631: ref and out are not valid in this context
                    diagnostics, ErrorCode.ERR_IllegalRefParam, refnessKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,8610,8979);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,8999,9187);

TParameterSymbol 
parameter = f_10235_9028_9186<TParameterSymbol,TOwningSymbol,TParameterSyntax>(parameterCreationFunc, binder, owner, parameterType, parameterSyntax, refKind, parameterIndex, paramsKeyword, thisKeyword, addRefReadOnlyModifier, diagnostics)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9207,9319);

f_10235_9207_9318<TOwningSymbol, TParameterSyntax, TParameterSymbol>(owner, parameterSyntax, parameter, thisKeyword, paramsKeyword, firstDefault, diagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9339,9362);

f_10235_9339_9361<TParameterSymbol,TParameterSyntax,TOwningSymbol>(
                builder, parameter);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9380,9397);

++parameterIndex;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,6316,9412);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,3097);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,3097);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9428,9827) || true) && (mustBeLastParameter != null &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 9432, 9511)&&mustBeLastParameter != parametersList[lastIndex]))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,9428,9827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9545,9812);

f_10235_9545_9811<TParameterSyntax,TParameterSymbol,TOwningSymbol>(                diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10235, 9583, 9649)||((                    mustBeLastParameter.Identifier.Kind()== SyntaxKind.ArgListKeyword
&&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 9677, 9702))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 9730, 9754)))?ErrorCode.ERR_VarargsLast
:ErrorCode.ERR_ParamsLast, f_10235_9777_9810<TParameterSyntax,TParameterSymbol,TOwningSymbol>(                    mustBeLastParameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,9428,9827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9843,9918);

ImmutableArray<TParameterSymbol> 
parameters = f_10235_9889_9917<TParameterSymbol,TParameterSyntax,TOwningSymbol>(builder)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9934,10692) || true) && (!parsingFunctionPointer)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,9934,10692);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,9995,10035);

var 
methodOwner = owner as MethodSymbol
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,10053,10220);

var 
typeParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10235, 10074, 10101)||(((object)methodOwner != null &&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 10125, 10151))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 10175, 10219)))?f_10235_10125_10151<TParameterSyntax, TParameterSymbol, TOwningSymbol>(methodOwner):                    default(ImmutableArray<TypeParameterSymbol>)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,10240,10305);

f_10235_10240_10304<TParameterSyntax, TParameterSymbol, TOwningSymbol>(f_10235_10253_10276_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(methodOwner, 10235, 10253, 10276)?.MethodKind)!= MethodKind.LambdaMethod);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,10323,10515);

bool 
allowShadowingNames = f_10235_10350_10438<TParameterSyntax,TParameterSymbol,TOwningSymbol>(f_10235_10350_10368<TParameterSyntax, TParameterSymbol, TOwningSymbol>(binder), MessageID.IDS_FeatureNameShadowingInNestedFunctions)&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 10350, 10514)&&f_10235_10463_10486_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(methodOwner, 10235, 10463, 10486)?.MethodKind)== MethodKind.LocalFunction)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,10535,10677);

f_10235_10535_10676<TParameterSyntax,TParameterSymbol,TOwningSymbol>(
                binder, typeParameters, parameters.Cast<TParameterSymbol, ParameterSymbol>(), allowShadowingNames, diagnostics);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,9934,10692);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,10708,10726);

return parameters;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,5045,10737);

int
f_10235_5960_6037<TParameterSyntax, TParameterSymbol, TOwningSymbol>(bool
condition)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 5960, 6037);
return 0;
}


Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TParameterSymbol>
f_10235_6193_6237<TParameterSymbol, TParameterSyntax, TOwningSymbol>()            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = ArrayBuilder<TParameterSymbol>.GetInstance();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 6193, 6237);
return return_v;
}


int
f_10235_6454_6531<TParameterSyntax, TParameterSymbol, TOwningSymbol>(TParameterSyntax
parameter,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
parsingFunctionPointerParams)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
CheckParameterModifiers( (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax)parameter, diagnostics, parsingFunctionPointerParams);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 6454, 6531);
return 0;
}


Microsoft.CodeAnalysis.SyntaxTokenList
f_10235_6579_6604<TParameterSyntax, TParameterSymbol, TOwningSymbol>(TParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Modifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 6579, 6604);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10235_6566_6697<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,out Microsoft.CodeAnalysis.SyntaxToken
refnessKeyword,out Microsoft.CodeAnalysis.SyntaxToken
paramsKeyword,out Microsoft.CodeAnalysis.SyntaxToken
thisKeyword)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = GetModifiers( modifiers, out refnessKeyword, out paramsKeyword, out thisKeyword);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 6566, 6697);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_6813_6887<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 6813, 6887);
return return_v;
}


bool
f_10235_7363_7386<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.IsArgList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 7363, 7386);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxToken
f_10235_7451_7475<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Identifier;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 7451, 7475);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_8020_8093<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 8020, 8093);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10235_8209_8230<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Default ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 8209, 8230);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
f_10235_8415_8435<TParameterSyntax, TParameterSymbol, TOwningSymbol>(TParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 8415, 8435);
return return_v;
}


int
f_10235_8402_8444<TParameterSyntax, TParameterSymbol, TOwningSymbol>(bool
condition)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 8402, 8444);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
f_10235_8499_8519<TParameterSyntax, TParameterSymbol, TOwningSymbol>(TParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 8499, 8519);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
f_10235_8483_8589<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
syntax,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,bool
suppressUseSiteDiagnostics)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.BindType( (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, suppressUseSiteDiagnostics:suppressUseSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 8483, 8589);
return return_v;
}


int
f_10235_8724_8778<TParameterSyntax, TParameterSymbol, TOwningSymbol>(bool
condition)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 8724, 8778);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_8883_8959<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 8883, 8959);
return return_v;
}


TParameterSymbol
f_10235_9028_9186<TParameterSymbol, TOwningSymbol, TParameterSyntax>(System.Func<Microsoft.CodeAnalysis.CSharp.Binder, TOwningSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, TParameterSyntax, Microsoft.CodeAnalysis.RefKind, int, Microsoft.CodeAnalysis.SyntaxToken, Microsoft.CodeAnalysis.SyntaxToken, bool, Microsoft.CodeAnalysis.DiagnosticBag, TParameterSymbol>
this_param,Microsoft.CodeAnalysis.CSharp.Binder
arg1,TOwningSymbol
arg2,Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
arg3,TParameterSyntax
arg4,Microsoft.CodeAnalysis.RefKind
arg5,int
arg6,Microsoft.CodeAnalysis.SyntaxToken
arg7,Microsoft.CodeAnalysis.SyntaxToken
arg8,bool
arg9,Microsoft.CodeAnalysis.DiagnosticBag
arg10)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Invoke( arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9028, 9186);
return return_v;
}


int
f_10235_9207_9318<TOwningSymbol, TParameterSyntax, TParameterSymbol>(TOwningSymbol
owner,TParameterSyntax
parameterSyntax,TParameterSymbol
parameter,Microsoft.CodeAnalysis.SyntaxToken
thisKeyword,Microsoft.CodeAnalysis.SyntaxToken
paramsKeyword,int
firstDefault,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
ReportParameterErrors( (Microsoft.CodeAnalysis.CSharp.Symbol)owner, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax)parameterSyntax, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)parameter, thisKeyword, paramsKeyword, firstDefault, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9207, 9318);
return 0;
}


int
f_10235_9339_9361<TParameterSymbol, TParameterSyntax, TOwningSymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TParameterSymbol>
this_param,TParameterSymbol
item)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9339, 9361);
return 0;
}


Microsoft.CodeAnalysis.SeparatedSyntaxList<TParameterSyntax>
f_10235_6348_6362_I<TParameterSyntax>(Microsoft.CodeAnalysis.SeparatedSyntaxList<TParameterSyntax>
i)            where TParameterSyntax : BaseParameterSyntax

{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 6348, 6362);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_9777_9810<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.GetLocation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9777, 9810);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_9545_9811<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9545, 9811);
return return_v;
}


System.Collections.Immutable.ImmutableArray<TParameterSymbol>
f_10235_9889_9917<TParameterSymbol, TParameterSyntax, TOwningSymbol>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TParameterSymbol>
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.ToImmutableAndFree();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 9889, 9917);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
f_10235_10125_10151<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.TypeParameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 10125, 10151);
return return_v;
}


Microsoft.CodeAnalysis.MethodKind?
f_10235_10253_10276_M(Microsoft.CodeAnalysis.MethodKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 10253, 10276);
return return_v;
}


int
f_10235_10240_10304<TParameterSyntax, TParameterSymbol, TOwningSymbol>(bool
condition)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 10240, 10304);
return 0;
}


Microsoft.CodeAnalysis.CSharp.CSharpCompilation
f_10235_10350_10368<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Binder
this_param)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = this_param.Compilation;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 10350, 10368);
return return_v;
}


bool
f_10235_10350_10438<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
compilation,Microsoft.CodeAnalysis.CSharp.MessageID
feature)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
var return_v = compilation.IsFeatureEnabled( feature);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 10350, 10438);
return return_v;
}


Microsoft.CodeAnalysis.MethodKind?
f_10235_10463_10486_M(Microsoft.CodeAnalysis.MethodKind?
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 10463, 10486);
return return_v;
}


int
f_10235_10535_10676<TParameterSyntax, TParameterSymbol, TOwningSymbol>(Microsoft.CodeAnalysis.CSharp.Binder
this_param,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
typeParameters,System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
parameters,bool
allowShadowingNames,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)            where TParameterSyntax : BaseParameterSyntax
            where TParameterSymbol : ParameterSymbol
            where TOwningSymbol : Symbol

{
this_param.ValidateParameterNameConflicts( typeParameters, parameters, allowShadowingNames, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 10535, 10676);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,5045,10737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,5045,10737);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void EnsureIsReadOnlyAttributeExists(CSharpCompilation compilation, ImmutableArray<ParameterSymbol> parameters, DiagnosticBag diagnostics, bool modifyCompilation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,10749,11562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11166,11245) || true) && (compilation == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,11166,11245);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11223,11230);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,11166,11245);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11261,11551);
foreach(var parameter in f_10235_11287_11297_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,11261,11551);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11331,11536) || true) && (f_10235_11335_11352(parameter)== RefKind.In)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,11331,11536);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11408,11517);

f_10235_11408_11516(                    compilation, diagnostics, f_10235_11465_11496(parameter), modifyCompilation);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,11331,11536);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,11261,11551);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,291);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,291);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,10749,11562);

Microsoft.CodeAnalysis.RefKind
f_10235_11335_11352(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 11335, 11352);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_11465_11496(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
parameter)
{
var return_v = GetParameterLocation( parameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 11465, 11496);
return return_v;
}


int
f_10235_11408_11516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Location
location,bool
modifyCompilation)
{
this_param.EnsureIsReadOnlyAttributeExists( diagnostics, location, modifyCompilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 11408, 11516);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10235_11287_11297_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 11287, 11297);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,10749,11562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,10749,11562);
}
		}

internal static void EnsureNativeIntegerAttributeExists(CSharpCompilation compilation, ImmutableArray<ParameterSymbol> parameters, DiagnosticBag diagnostics, bool modifyCompilation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,11574,12415);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,11994,12073) || true) && (compilation == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,11994,12073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12051,12058);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,11994,12073);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12089,12404);
foreach(var parameter in f_10235_12115_12125_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,12089,12404);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12159,12389) || true) && (parameter.TypeWithAnnotations.ContainsNativeInteger())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,12159,12389);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12258,12370);

f_10235_12258_12369(                    compilation, diagnostics, f_10235_12318_12349(parameter), modifyCompilation);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,12159,12389);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,12089,12404);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,316);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,316);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,11574,12415);

Microsoft.CodeAnalysis.Location
f_10235_12318_12349(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
parameter)
{
var return_v = GetParameterLocation( parameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 12318, 12349);
return return_v;
}


int
f_10235_12258_12369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Location
location,bool
modifyCompilation)
{
this_param.EnsureNativeIntegerAttributeExists( diagnostics, location, modifyCompilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 12258, 12369);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10235_12115_12125_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 12115, 12125);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,11574,12415);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,11574,12415);
}
		}

internal static void EnsureNullableAttributeExists(CSharpCompilation compilation, Symbol container, ImmutableArray<ParameterSymbol> parameters, DiagnosticBag diagnostics, bool modifyCompilation)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,12427,13430);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12860,12939) || true) && (compilation == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,12860,12939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12917,12924);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,12860,12939);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,12955,13419) || true) && (parameters.Length > 0 &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 12959, 13035)&&f_10235_12984_13035(compilation, container)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,12955,13419);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13069,13404);
foreach(var parameter in f_10235_13095_13105_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13069,13404);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13147,13385) || true) && (parameter.TypeWithAnnotations.NeedsNullableAttribute())
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13147,13385);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13255,13362);

f_10235_13255_13361(                        compilation, diagnostics, f_10235_13310_13341(parameter), modifyCompilation);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13147,13385);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13069,13404);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,336);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,336);
}DynAbs.Tracing.TraceSender.TraceExitCondition(10235,12955,13419);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,12427,13430);

bool
f_10235_12984_13035(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.CSharp.Symbol
symbol)
{
var return_v = this_param.ShouldEmitNullableAttributes( symbol);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 12984, 13035);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_13310_13341(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
parameter)
{
var return_v = GetParameterLocation( parameter);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 13310, 13341);
return return_v;
}


int
f_10235_13255_13361(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
this_param,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.Location
location,bool
modifyCompilation)
{
this_param.EnsureNullableAttributeExists( diagnostics, location, modifyCompilation);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 13255, 13361);
return 0;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
f_10235_13095_13105_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 13095, 13105);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,12427,13430);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,12427,13430);
}
		}

private static Location GetParameterLocation(ParameterSymbol parameter) 		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterMethod(10235,13514,13558);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13517,13558);
return f_10235_13517_13558(f_10235_13517_13549(parameter));DynAbs.Tracing.TraceSender.TraceExitMethod(10235,13514,13558);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,13514,13558);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,13514,13558);
}
			throw new System.Exception("Slicer error: unreachable code");

Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
f_10235_13517_13549(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
symbol)
{
var return_v = symbol.GetNonNullSyntaxNode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 13517, 13549);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_13517_13558(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 13517, 13558);
return return_v;
}

		}

private static void CheckParameterModifiers(BaseParameterSyntax parameter, DiagnosticBag diagnostics, bool parsingFunctionPointerParams)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,13571,21191);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13732,13753);

var 
seenThis = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13767,13787);

var 
seenRef = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13801,13821);

var 
seenOut = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13835,13858);

var 
seenParams = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13872,13891);

var 
seenIn = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13907,21180);
foreach(var modifier in f_10235_13932_13951_I(f_10235_13932_13951(parameter)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13907,21180);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,13985,21165);

switch (modifier.Kind())
                {

case SyntaxKind.ThisKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14104,14937) || true) && (seenThis)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14104,14937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14174,14286);

f_10235_14174_14285(                            diagnostics, ErrorCode.ERR_DupParamMod, modifier.GetLocation(), f_10235_14241_14284(SyntaxKind.ThisKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14104,14937);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14104,14937);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14344,14937) || true) && (seenOut)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14344,14937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14413,14579);

f_10235_14413_14578(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_14490_14533(SyntaxKind.ThisKeyword), f_10235_14535_14577(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14344,14937);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14344,14937);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14637,14937) || true) && (seenParams)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14637,14937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14709,14780);

f_10235_14709_14779(                            diagnostics, ErrorCode.ERR_BadParamModThis, modifier.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14637,14937);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,14637,14937);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,14894,14910);

seenThis = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14637,14937);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14344,14937);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,14104,14937);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,14963,14969);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

case SyntaxKind.RefKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15046,16218) || true) && (seenRef)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15046,16218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15115,15226);

f_10235_15115_15225(                            diagnostics, ErrorCode.ERR_DupParamMod, modifier.GetLocation(), f_10235_15182_15224(SyntaxKind.RefKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15046,16218);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15046,16218);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15284,16218) || true) && (seenParams)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15284,16218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15356,15480);

f_10235_15356_15479(                            diagnostics, ErrorCode.ERR_ParamsCantBeWithModifier, modifier.GetLocation(), f_10235_15436_15478(SyntaxKind.RefKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15284,16218);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15284,16218);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15538,16218) || true) && (seenOut)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15538,16218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15607,15772);

f_10235_15607_15771(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_15684_15726(SyntaxKind.RefKeyword), f_10235_15728_15770(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15538,16218);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15538,16218);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15830,16218) || true) && (seenIn)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15830,16218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,15898,16062);

f_10235_15898_16061(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_15975_16017(SyntaxKind.RefKeyword), f_10235_16019_16060(SyntaxKind.InKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15830,16218);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,15830,16218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16176,16191);

seenRef = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15830,16218);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15538,16218);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15284,16218);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,15046,16218);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,16244,16250);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

case SyntaxKind.OutKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16327,17793) || true) && (seenOut)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16327,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16396,16507);

f_10235_16396_16506(                            diagnostics, ErrorCode.ERR_DupParamMod, modifier.GetLocation(), f_10235_16463_16505(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16327,17793);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16327,17793);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16565,17793) || true) && (seenThis)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16565,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16635,16801);

f_10235_16635_16800(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_16712_16754(SyntaxKind.OutKeyword), f_10235_16756_16799(SyntaxKind.ThisKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16565,17793);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16565,17793);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16859,17793) || true) && (seenParams)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16859,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,16931,17055);

f_10235_16931_17054(                            diagnostics, ErrorCode.ERR_ParamsCantBeWithModifier, modifier.GetLocation(), f_10235_17011_17053(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16859,17793);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,16859,17793);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17113,17793) || true) && (seenRef)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17113,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17182,17347);

f_10235_17182_17346(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_17259_17301(SyntaxKind.OutKeyword), f_10235_17303_17345(SyntaxKind.RefKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17113,17793);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17113,17793);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17405,17793) || true) && (seenIn)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17405,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17473,17637);

f_10235_17473_17636(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_17550_17592(SyntaxKind.OutKeyword), f_10235_17594_17635(SyntaxKind.InKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17405,17793);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17405,17793);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17751,17766);

seenOut = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17405,17793);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17113,17793);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16859,17793);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16565,17793);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,16327,17793);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,17819,17825);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

case SyntaxKind.ParamsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17879,17913) || true) && (!parsingFunctionPointerParams) && (DynAbs.Tracing.TraceSender.Expression_True(10235,17879,17913) || true)
:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,17940,19367) || true) && (seenParams)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17940,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18012,18126);

f_10235_18012_18125(                            diagnostics, ErrorCode.ERR_DupParamMod, modifier.GetLocation(), f_10235_18079_18124(SyntaxKind.ParamsKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17940,19367);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,17940,19367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18184,19367) || true) && (seenThis)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18184,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18254,18325);

f_10235_18254_18324(                            diagnostics, ErrorCode.ERR_BadParamModThis, modifier.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18184,19367);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18184,19367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18383,19367) || true) && (seenRef)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18383,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18452,18620);

f_10235_18452_18619(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_18529_18574(SyntaxKind.ParamsKeyword), f_10235_18576_18618(SyntaxKind.RefKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18383,19367);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18383,19367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18678,19367) || true) && (seenIn)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18678,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18746,18913);

f_10235_18746_18912(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_18823_18868(SyntaxKind.ParamsKeyword), f_10235_18870_18911(SyntaxKind.InKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18678,19367);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18678,19367);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,18971,19367) || true) && (seenOut)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18971,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19040,19208);

f_10235_19040_19207(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_19117_19162(SyntaxKind.ParamsKeyword), f_10235_19164_19206(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18971,19367);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,18971,19367);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19322,19340);

seenParams = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18971,19367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18678,19367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18383,19367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,18184,19367);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,17940,19367);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,19393,19399);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

case SyntaxKind.InKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19475,20643) || true) && (seenIn)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,19475,20643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19543,19653);

f_10235_19543_19652(                            diagnostics, ErrorCode.ERR_DupParamMod, modifier.GetLocation(), f_10235_19610_19651(SyntaxKind.InKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,19475,20643);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,19475,20643);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19711,20643) || true) && (seenOut)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,19711,20643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,19780,19944);

f_10235_19780_19943(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_19857_19898(SyntaxKind.InKeyword), f_10235_19900_19942(SyntaxKind.OutKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,19711,20643);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,19711,20643);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20002,20643) || true) && (seenRef)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,20002,20643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20071,20235);

f_10235_20071_20234(                            diagnostics, ErrorCode.ERR_BadParameterModifiers, modifier.GetLocation(), f_10235_20148_20189(SyntaxKind.InKeyword), f_10235_20191_20233(SyntaxKind.RefKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,20002,20643);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,20002,20643);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20293,20643) || true) && (seenParams)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,20293,20643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20365,20488);

f_10235_20365_20487(                            diagnostics, ErrorCode.ERR_ParamsCantBeWithModifier, modifier.GetLocation(), f_10235_20445_20486(SyntaxKind.InKeyword));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,20293,20643);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,20293,20643);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20602,20616);

seenIn = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,20293,20643);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,20002,20643);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,19711,20643);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,19475,20643);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,20669,20675);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

case SyntaxKind.ParamsKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20729,20762) || true) && (parsingFunctionPointerParams) && (DynAbs.Tracing.TraceSender.Expression_True(10235,20729,20762) || true)
:
                    case SyntaxKind.ReadOnlyKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20817,20850) || true) && (parsingFunctionPointerParams) && (DynAbs.Tracing.TraceSender.Expression_True(10235,20817,20850) || true)
:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,20877,20998);

f_10235_20877_20997(                        diagnostics, ErrorCode.ERR_BadFuncPointerParamModifier, modifier.GetLocation(), f_10235_20960_20996(modifier.Kind()));
DynAbs.Tracing.TraceSender.TraceBreak(10235,21024,21030);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,13985,21165);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,21088,21146);

throw f_10235_21094_21145(modifier.Kind());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13985,21165);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,13907,21180);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,7274);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,7274);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,13571,21191);

Microsoft.CodeAnalysis.SyntaxTokenList
f_10235_13932_13951(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax
this_param)
{
var return_v = this_param.Modifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 13932, 13951);
return return_v;
}


string
f_10235_14241_14284(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14241, 14284);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_14174_14285(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14174, 14285);
return return_v;
}


string
f_10235_14490_14533(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14490, 14533);
return return_v;
}


string
f_10235_14535_14577(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14535, 14577);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_14413_14578(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14413, 14578);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_14709_14779(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 14709, 14779);
return return_v;
}


string
f_10235_15182_15224(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15182, 15224);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_15115_15225(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15115, 15225);
return return_v;
}


string
f_10235_15436_15478(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15436, 15478);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_15356_15479(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15356, 15479);
return return_v;
}


string
f_10235_15684_15726(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15684, 15726);
return return_v;
}


string
f_10235_15728_15770(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15728, 15770);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_15607_15771(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15607, 15771);
return return_v;
}


string
f_10235_15975_16017(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15975, 16017);
return return_v;
}


string
f_10235_16019_16060(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16019, 16060);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_15898_16061(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 15898, 16061);
return return_v;
}


string
f_10235_16463_16505(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16463, 16505);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_16396_16506(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16396, 16506);
return return_v;
}


string
f_10235_16712_16754(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16712, 16754);
return return_v;
}


string
f_10235_16756_16799(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16756, 16799);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_16635_16800(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16635, 16800);
return return_v;
}


string
f_10235_17011_17053(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17011, 17053);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_16931_17054(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 16931, 17054);
return return_v;
}


string
f_10235_17259_17301(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17259, 17301);
return return_v;
}


string
f_10235_17303_17345(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17303, 17345);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_17182_17346(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17182, 17346);
return return_v;
}


string
f_10235_17550_17592(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17550, 17592);
return return_v;
}


string
f_10235_17594_17635(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17594, 17635);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_17473_17636(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 17473, 17636);
return return_v;
}


string
f_10235_18079_18124(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18079, 18124);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_18012_18125(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18012, 18125);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_18254_18324(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18254, 18324);
return return_v;
}


string
f_10235_18529_18574(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18529, 18574);
return return_v;
}


string
f_10235_18576_18618(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18576, 18618);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_18452_18619(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18452, 18619);
return return_v;
}


string
f_10235_18823_18868(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18823, 18868);
return return_v;
}


string
f_10235_18870_18911(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18870, 18911);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_18746_18912(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 18746, 18912);
return return_v;
}


string
f_10235_19117_19162(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19117, 19162);
return return_v;
}


string
f_10235_19164_19206(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19164, 19206);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_19040_19207(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19040, 19207);
return return_v;
}


string
f_10235_19610_19651(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19610, 19651);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_19543_19652(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19543, 19652);
return return_v;
}


string
f_10235_19857_19898(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19857, 19898);
return return_v;
}


string
f_10235_19900_19942(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19900, 19942);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_19780_19943(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 19780, 19943);
return return_v;
}


string
f_10235_20148_20189(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20148, 20189);
return return_v;
}


string
f_10235_20191_20233(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20191, 20233);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_20071_20234(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20071, 20234);
return return_v;
}


string
f_10235_20445_20486(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20445, 20486);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_20365_20487(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20365, 20487);
return return_v;
}


string
f_10235_20960_20996(Microsoft.CodeAnalysis.CSharp.SyntaxKind
kind)
{
var return_v = SyntaxFacts.GetText( kind);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20960, 20996);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_20877_20997(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 20877, 20997);
return return_v;
}


System.Exception
f_10235_21094_21145(Microsoft.CodeAnalysis.CSharp.SyntaxKind
o)
{
var return_v = ExceptionUtilities.UnexpectedValue( (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 21094, 21145);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTokenList
f_10235_13932_13951_I(Microsoft.CodeAnalysis.SyntaxTokenList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 13932, 13951);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,13571,21191);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,13571,21191);
}
		}

private static void ReportParameterErrors(
            Symbol owner,
            BaseParameterSyntax parameterSyntax,
            ParameterSymbol parameter,
            SyntaxToken thisKeyword,
            SyntaxToken paramsKeyword,
            int firstDefault,
            DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,21203,24332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,21536,21575);

int 
parameterIndex = f_10235_21557_21574(parameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,21589,21658);

bool 
isDefault = parameterSyntax is ParameterSyntax { Default: { } }
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,21674,24321) || true) && (thisKeyword.Kind()== SyntaxKind.ThisKeyword &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 21678, 21745)&&parameterIndex != 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,21674,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22048,22131);

f_10235_22048_22130(                // Report CS1100 on "this". Note that is a change from Dev10
                // which reports the error on the type following "this".

                // error CS1100: Method '{0}' has a parameter modifier 'this' which is not on the first parameter
                diagnostics, ErrorCode.ERR_BadThisParam, thisKeyword.GetLocation(), f_10235_22119_22129(owner));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,21674,24321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,21674,24321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22165,24321) || true) && (f_10235_22169_22187(parameter)&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 22169, 22209)&&f_10235_22191_22209(owner)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22165,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22313,22387);

f_10235_22313_22386(                // error CS1670: params is not valid in this context
                diagnostics, ErrorCode.ERR_IllegalParams, paramsKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22165,24321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22165,24321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22421,24321) || true) && (f_10235_22425_22443(parameter)&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 22425, 22489)&&!parameter.TypeWithAnnotations.IsSZArray()))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22421,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22613,22691);

f_10235_22613_22690(                // error CS0225: The params parameter must be a single dimensional array
                diagnostics, ErrorCode.ERR_ParamsMustBeArray, paramsKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22421,24321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22421,24321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22725,24321) || true) && (parameter.TypeWithAnnotations.IsStatic)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22725,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,22801,22905);

f_10235_22801_22904(f_10235_22814_22840(parameter)is FunctionPointerMethodSymbol or { ContainingType: not null });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,23033,23424);

f_10235_23033_23423(                // error CS0721: '{0}': static types cannot be used as parameters
                // LAFHIS
                diagnostics, f_10235_23071_23286((DynAbs.Tracing.TraceSender.Conditional_F1(10235, 23136, 23190)||((f_10235_23136_23190(f_10235_23136_23177(f_10235_23136_23162(parameter)), null)&&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 23218, 23277))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 23280, 23285)))?f_10235_23218_23277(f_10235_23218_23259(f_10235_23218_23244(parameter))):false), (DynAbs.Tracing.TraceSender.Conditional_F1(10235, 23309, 23332)||((                    owner.Locations.IsEmpty &&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 23335, 23364))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 23367, 23385)))?f_10235_23335_23364(parameterSyntax):f_10235_23367_23382(owner)[0], f_10235_23408_23422(parameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22725,24321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,22725,24321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,23458,24321) || true) && (firstDefault != -1 &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 23462, 23513)&&parameterIndex > firstDefault )&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 23462, 23527)&&!isDefault )&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 23462, 23550)&&f_10235_23531_23550_M(!parameter.IsParams)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,23458,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,23680,23813);

Location 
loc = ((ParameterSyntax)(BaseParameterSyntax)parameterSyntax).Identifier.GetNextToken(includeZeroWidth: true).GetLocation()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,23850,23918);

f_10235_23850_23917(                diagnostics, ErrorCode.ERR_DefaultValueBeforeRequiredValue, loc);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,23458,24321);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,23458,24321);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,23952,24321) || true) && (f_10235_23956_23973(parameter)!= RefKind.None &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 23956, 24083)&&                parameter.TypeWithAnnotations.IsRestrictedType(ignoreSpanLikeTypes: true)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,23952,24321);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,24211,24306);

f_10235_24211_24305(                // CS1601: Cannot make reference to variable of type 'System.TypedReference'
                diagnostics, ErrorCode.ERR_MethodArgCantBeRefAny, f_10235_24264_24288(parameterSyntax), f_10235_24290_24304(parameter));
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,23952,24321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,23458,24321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22725,24321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22421,24321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,22165,24321);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,21674,24321);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,21203,24332);

int
f_10235_21557_21574(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 21557, 21574);
return return_v;
}


string
f_10235_22119_22129(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 22119, 22129);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_22048_22130(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 22048, 22130);
return return_v;
}


bool
f_10235_22169_22187(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.IsParams ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 22169, 22187);
return return_v;
}


bool
f_10235_22191_22209(Microsoft.CodeAnalysis.CSharp.Symbol
symbol)
{
var return_v = symbol.IsOperator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 22191, 22209);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_22313_22386(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 22313, 22386);
return return_v;
}


bool
f_10235_22425_22443(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.IsParams ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 22425, 22443);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_22613_22690(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 22613, 22690);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10235_22814_22840(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.ContainingSymbol ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 22814, 22840);
return return_v;
}


int
f_10235_22801_22904(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 22801, 22904);
return 0;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10235_23136_23162(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23136, 23162);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10235_23136_23177(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23136, 23177);
return return_v;
}


bool
f_10235_23136_23190(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
this_param,object
obj)
{
var return_v = this_param.Equals( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23136, 23190);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbol
f_10235_23218_23244(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23218, 23244);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
f_10235_23218_23259(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23218, 23259);
return return_v;
}


bool
f_10235_23218_23277(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
type)
{
var return_v = type.IsInterfaceType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23218, 23277);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.ErrorCode
f_10235_23071_23286(bool
useWarning)
{
var return_v = ErrorFacts.GetStaticClassParameterCode( useWarning);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23071, 23286);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_23335_23364(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax
this_param)
{
var return_v = this_param.GetLocation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23335, 23364);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
f_10235_23367_23382(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Locations;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23367, 23382);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_23408_23422(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23408, 23422);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_23033_23423(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23033, 23423);
return return_v;
}


bool
f_10235_23531_23550_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23531, 23550);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_23850_23917(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 23850, 23917);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10235_23956_23973(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.RefKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 23956, 23973);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_24264_24288(Microsoft.CodeAnalysis.CSharp.Syntax.BaseParameterSyntax
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 24264, 24288);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_24290_24304(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 24290, 24304);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_24211_24305(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 24211, 24305);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,21203,24332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,21203,24332);
}
		}

internal static bool ReportDefaultParameterErrors(
            Binder binder,
            Symbol owner,
            ParameterSyntax parameterSyntax,
            SourceParameterSymbol parameter,
            BoundExpression defaultExpression,
            BoundExpression convertedExpression,
            DiagnosticBag diagnostics)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,24344,32634);
Microsoft.CodeAnalysis.SyntaxToken refnessKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
Microsoft.CodeAnalysis.SyntaxToken paramsKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
Microsoft.CodeAnalysis.SyntaxToken thisKeyword = default(Microsoft.CodeAnalysis.SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,24704,24727);

bool 
hasErrors = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,25667,25709);

TypeSymbol 
parameterType = f_10235_25694_25708(parameter)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,25723,25773);

HashSet<DiagnosticInfo> 
useSiteDiagnostics = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,25787,25929);

Conversion 
conversion = f_10235_25811_25928(f_10235_25811_25829(binder), defaultExpression, parameterType, ref useSiteDiagnostics)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,25943,26005);

f_10235_25943_26004(            diagnostics, defaultExpression.Syntax, useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26021,26167);

var 
refKind = f_10235_26035_26166(f_10235_26048_26073(parameterSyntax), out refnessKeyword, out paramsKeyword, out thisKeyword)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26434,31033) || true) && (refKind == RefKind.Ref ||(DynAbs.Tracing.TraceSender.Expression_False(10235, 26438, 26486)||refKind == RefKind.Out))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,26434,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26605,26685);

f_10235_26605_26684(                // error CS1741: A ref or out parameter cannot have a default value
                diagnostics, ErrorCode.ERR_RefOutDefaultValue, refnessKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26703,26720);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,26434,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,26434,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26754,31033) || true) && (paramsKeyword.Kind()== SyntaxKind.ParamsKeyword)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,26754,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,26927,27018);

f_10235_26927_27017(                // error CS1751: Cannot specify a default value for a parameter array
                diagnostics, ErrorCode.ERR_DefaultValueForParamsParameter, paramsKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27036,27053);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,26754,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,26754,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27087,31033) || true) && (thisKeyword.Kind()== SyntaxKind.ThisKeyword)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,27087,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27339,27651) || true) && (f_10235_27343_27360(parameter)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,27339,27651);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27501,27593);

f_10235_27501_27592(                    // error CS1743: Cannot specify a default value for the 'this' parameter
                    diagnostics, ErrorCode.ERR_DefaultValueForExtensionParameter, thisKeyword.GetLocation());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27615,27632);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,27339,27651);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,27087,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,27087,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27685,31033) || true) && (f_10235_27689_27720_M(!defaultExpression.HasAnyErrors)&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 27689, 27832)&&!f_10235_27725_27832((DynAbs.Tracing.TraceSender.Conditional_F1(10235, 27745, 27789)||((f_10235_27745_27789(defaultExpression)&&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 27792, 27811))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 27814, 27831)))?convertedExpression :defaultExpression)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,27685,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,27966,28102);

f_10235_27966_28101(                // error CS1736: Default parameter value for '{0}' must be a compile-time constant
                diagnostics, ErrorCode.ERR_DefaultValueMustBeConstant, f_10235_28024_28062(f_10235_28024_28053(f_10235_28024_28047(parameterSyntax))), parameterSyntax.Identifier.ValueText);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,28120,28137);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,27685,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,27685,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,28171,31033) || true) && (f_10235_28175_28193_M(!conversion.Exists)||(DynAbs.Tracing.TraceSender.Expression_False(10235, 28175, 28238)||                conversion.IsUserDefined )||(DynAbs.Tracing.TraceSender.Expression_False(10235, 28175, 28376)||                conversion.IsIdentity &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 28259, 28338)&&f_10235_28284_28309(parameterType)== SpecialType.System_Object )&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 28259, 28376)&&f_10235_28342_28376(f_10235_28342_28364(defaultExpression)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,28171,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,28858,29022);

f_10235_28858_29021(                // If we had no implicit conversion, or a user-defined conversion, report an error.
                //
                // Even though "object x = (dynamic)null" is a legal identity conversion, we do not allow it. 
                // CONSIDER: We could. Doesn't hurt anything.

                // error CS1750: A value of type '{0}' cannot be used as a default parameter because there are no standard conversions to type '{1}'
                diagnostics, ErrorCode.ERR_NoConversionForDefaultParam, parameterSyntax.Identifier.GetLocation(), f_10235_28980_29005(defaultExpression), parameterType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,29042,29059);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,28171,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,28171,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,29093,31033) || true) && (conversion.IsReference &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 29097, 29244)&&                (f_10235_29141_29166(parameterType)== SpecialType.System_Object ||(DynAbs.Tracing.TraceSender.Expression_False(10235, 29141, 29243)||f_10235_29199_29217(parameterType)== SymbolKind.DynamicType)) )&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 29097, 29303)&&                (object)f_10235_29273_29295(defaultExpression)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 29097, 29387)&&f_10235_29324_29358(f_10235_29324_29346(defaultExpression))== SpecialType.System_String )||(DynAbs.Tracing.TraceSender.Expression_False(10235, 29097, 29427)||                conversion.IsBoxing))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,29093,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,29714,29888);

f_10235_29714_29887(                // We don't allow object x = "hello", object x = 123, dynamic x = "hello", etc.
                // error CS1763: '{0}' is of type '{1}'. A default parameter value of a reference type other than string can only be initialized with null
                diagnostics, ErrorCode.ERR_NotNullRefDefaultParameter, parameterSyntax.Identifier.GetLocation(), parameterSyntax.Identifier.ValueText, parameterType);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,29908,29925);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,29093,31033);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,29093,31033);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,29959,31033) || true) && (conversion.IsNullable &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 29963, 30028)&&!f_10235_29989_30028(f_10235_29989_30011(defaultExpression)))&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 29963, 30169)&&                !(f_10235_30051_30105(f_10235_30051_30092(parameterType))||(DynAbs.Tracing.TraceSender.Expression_False(10235, 30051, 30168)||f_10235_30109_30168(f_10235_30109_30150(parameterType))))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,29959,31033);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,30794,30981);

f_10235_30794_30980(                // We can do:
                // M(int? x = default(int)) 
                // M(int? x = default(int?)) 
                // M(MyEnum? e = default(enum))
                // M(MyEnum? e = default(enum?))
                // M(MyStruct? s = default(MyStruct?))
                //
                // but we cannot do:
                //
                // M(MyStruct? s = default(MyStruct))

                // error CS1770: 
                // A value of type '{0}' cannot be used as default parameter for nullable parameter '{1}' because '{0}' is not a simple type
                diagnostics, ErrorCode.ERR_NoConversionForNubDefaultParam, parameterSyntax.Identifier.GetLocation(), f_10235_30919_30941(defaultExpression), parameterSyntax.Identifier.ValueText);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,31001,31018);

hasErrors = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,29959,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,29093,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,28171,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,27685,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,27087,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,26754,31033);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,26434,31033);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,31049,31135);

f_10235_31049_31134(convertedExpression, diagnostics);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,32000,32590) || true) && (f_10235_32004_32045(owner)||(DynAbs.Tracing.TraceSender.Expression_False(10235, 32004, 32097)||f_10235_32066_32097(                owner))||(DynAbs.Tracing.TraceSender.Expression_False(10235, 32004, 32136)||f_10235_32118_32136(                owner)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,32000,32590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,32388,32575);

f_10235_32388_32574(                // CS1066: The default value specified for parameter '{0}' will have no effect because it applies to a 
                //         member that is used in contexts that do not allow optional arguments
                diagnostics, ErrorCode.WRN_DefaultValueForUnconsumedLocation, parameterSyntax.Identifier.GetLocation(), parameterSyntax.Identifier.ValueText);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,32000,32590);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,32606,32623);

return hasErrors;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,24344,32634);

Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_25694_25708(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 25694, 25708);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversions
f_10235_25811_25829(Microsoft.CodeAnalysis.CSharp.Binder
this_param)
{
var return_v = this_param.Conversions;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 25811, 25829);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Conversion
f_10235_25811_25928(Microsoft.CodeAnalysis.CSharp.Conversions
this_param,Microsoft.CodeAnalysis.CSharp.BoundExpression
sourceExpression,Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
destination,ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
useSiteDiagnostics)
{
var return_v = this_param.ClassifyImplicitConversionFromExpression( sourceExpression, destination, ref useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 25811, 25928);
return return_v;
}


bool
f_10235_25943_26004(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
node,System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
useSiteDiagnostics)
{
var return_v = diagnostics.Add( node, useSiteDiagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 25943, 26004);
return return_v;
}


Microsoft.CodeAnalysis.SyntaxTokenList
f_10235_26048_26073(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)
{
var return_v = this_param.Modifiers;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 26048, 26073);
return return_v;
}


Microsoft.CodeAnalysis.RefKind
f_10235_26035_26166(Microsoft.CodeAnalysis.SyntaxTokenList
modifiers,out Microsoft.CodeAnalysis.SyntaxToken
refnessKeyword,out Microsoft.CodeAnalysis.SyntaxToken
paramsKeyword,out Microsoft.CodeAnalysis.SyntaxToken
thisKeyword)
{
var return_v = GetModifiers( modifiers, out refnessKeyword, out paramsKeyword, out thisKeyword);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 26035, 26166);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_26605_26684(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 26605, 26684);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_26927_27017(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 26927, 27017);
return return_v;
}


int
f_10235_27343_27360(Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
this_param)
{
var return_v = this_param.Ordinal ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 27343, 27360);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_27501_27592(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location)
{
var return_v = diagnostics.Add( code, location);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 27501, 27592);
return return_v;
}


bool
f_10235_27689_27720_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 27689, 27720);
return return_v;
}


bool
f_10235_27745_27789(Microsoft.CodeAnalysis.CSharp.BoundExpression
node)
{
var return_v = node.IsImplicitObjectCreation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 27745, 27789);
return return_v;
}


bool
f_10235_27725_27832(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = IsValidDefaultValue( expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 27725, 27832);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
f_10235_28024_28047(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
this_param)
{
var return_v = this_param.Default;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28024, 28047);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
f_10235_28024_28053(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28024, 28053);
return return_v;
}


Microsoft.CodeAnalysis.Location
f_10235_28024_28062(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
this_param)
{
var return_v = this_param.Location;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28024, 28062);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_27966_28101(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 27966, 28101);
return return_v;
}


bool
f_10235_28175_28193_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28175, 28193);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10235_28284_28309(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28284, 28309);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10235_28342_28364(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28342, 28364);
return return_v;
}


bool
f_10235_28342_28376(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = type.IsDynamic();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 28342, 28376);
return return_v;
}


object
f_10235_28980_29005(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Display;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 28980, 29005);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_28858_29021(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 28858, 29021);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10235_29141_29166(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29141, 29166);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10235_29199_29217(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29199, 29217);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10235_29273_29295(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29273, 29295);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_29324_29346(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29324, 29346);
return return_v;
}


Microsoft.CodeAnalysis.SpecialType
f_10235_29324_29358(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
this_param)
{
var return_v = this_param.SpecialType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29324, 29358);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_29714_29887(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 29714, 29887);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
f_10235_29989_30011(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 29989, 30011);
return return_v;
}


bool
f_10235_29989_30028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
type)
{
var return_v = type.IsNullableType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 29989, 30028);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_30051_30092(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 30051, 30092);
return return_v;
}


bool
f_10235_30051_30105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsEnumType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 30051, 30105);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_30109_30150(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.GetNullableUnderlyingType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 30109, 30150);
return return_v;
}


bool
f_10235_30109_30168(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
type)
{
var return_v = type.IsIntrinsicType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 30109, 30168);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
f_10235_30919_30941(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 30919, 30941);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_30794_30980(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 30794, 30980);
return return_v;
}


int
f_10235_31049_31134(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics)
{
ConstantValueUtils.CheckLangVersionForConstantValue( expression, diagnostics);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 31049, 31134);
return 0;
}


bool
f_10235_32004_32045(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.IsExplicitInterfaceImplementation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 32004, 32045);
return return_v;
}


bool
f_10235_32066_32097(Microsoft.CodeAnalysis.CSharp.Symbol
member)
{
var return_v = member.IsPartialImplementation();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 32066, 32097);
return return_v;
}


bool
f_10235_32118_32136(Microsoft.CodeAnalysis.CSharp.Symbol
symbol)
{
var return_v = symbol.IsOperator();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 32118, 32136);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
f_10235_32388_32574(Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.CSharp.ErrorCode
code,Microsoft.CodeAnalysis.Location
location,params object[]
args)
{
var return_v = diagnostics.Add( code, location, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 32388, 32574);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,24344,32634);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,24344,32634);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsValidDefaultValue(BoundExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,32646,34075);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33459,33556) || true) && (f_10235_33463_33487(expression)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,33459,33556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33529,33541);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,33459,33556);
}
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33570,34064) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,33570,34064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33615,34049);

switch (f_10235_33623_33638(expression))
                {

case BoundKind.DefaultLiteral:
                    case BoundKind.DefaultExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,33615,34049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33791,33803);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,33615,34049);

case BoundKind.ObjectCreationExpression:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,33615,34049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,33891,33961);

return f_10235_33898_33960(expression);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,33615,34049);

default:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,33615,34049);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34017,34030);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,33615,34049);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,33570,34064);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,33570,34064);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,33570,34064);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,32646,34075);

Microsoft.CodeAnalysis.ConstantValue?
f_10235_33463_33487(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.ConstantValue ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 33463, 33487);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundKind
f_10235_33623_33638(Microsoft.CodeAnalysis.CSharp.BoundExpression
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 33623, 33638);
return return_v;
}


bool
f_10235_33898_33960(Microsoft.CodeAnalysis.CSharp.BoundExpression
expression)
{
var return_v = IsValidDefaultValue( (Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression)expression);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 33898, 33960);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,32646,34075);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,32646,34075);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool IsValidDefaultValue(BoundObjectCreationExpression expression)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,34087,34313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34193,34302);

return f_10235_34200_34254(f_10235_34200_34222(expression))&&(DynAbs.Tracing.TraceSender.Expression_True(10235, 34200, 34301)&&f_10235_34258_34293(expression)== null);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,34087,34313);

Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
f_10235_34200_34222(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.Constructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34200, 34222);
return return_v;
}


bool
f_10235_34200_34254(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
method)
{
var return_v = method.IsDefaultValueTypeConstructor();
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 34200, 34254);
return return_v;
}


Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
f_10235_34258_34293(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
this_param)
{
var return_v = this_param.InitializerExpressionOpt ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34258, 34293);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,34087,34313);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,34087,34313);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static MethodSymbol FindContainingGenericMethod(Symbol symbol)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,34325,34932);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34433,34449);
            for (Symbol 
current = symbol
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34421,34895) || true) && ((object)current != null)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34476,34510)
,current = f_10235_34486_34510(current),DynAbs.Tracing.TraceSender.TraceExitCondition(10235,34421,34895))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,34421,34895);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34544,34880) || true) && (f_10235_34548_34560(current)== SymbolKind.Method)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,34544,34880);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34623,34667);

MethodSymbol 
method = (MethodSymbol)current
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34689,34861) || true) && (f_10235_34693_34710(method)!= MethodKind.AnonymousFunction)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,34689,34861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34792,34838);

return (DynAbs.Tracing.TraceSender.Conditional_F1(10235, 34799, 34821)||((f_10235_34799_34821(method)&&DynAbs.Tracing.TraceSender.Conditional_F2(10235, 34824, 34830))||DynAbs.Tracing.TraceSender.Conditional_F3(10235, 34833, 34837)))?method :null;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,34689,34861);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,34544,34880);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,475);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,475);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,34909,34921);

return null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,34325,34932);

Microsoft.CodeAnalysis.CSharp.Symbol
f_10235_34486_34510(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.ContainingSymbol;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34486, 34510);
return return_v;
}


Microsoft.CodeAnalysis.SymbolKind
f_10235_34548_34560(Microsoft.CodeAnalysis.CSharp.Symbol
this_param)
{
var return_v = this_param.Kind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34548, 34560);
return return_v;
}


Microsoft.CodeAnalysis.MethodKind
f_10235_34693_34710(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.MethodKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34693, 34710);
return return_v;
}


bool
f_10235_34799_34821(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
this_param)
{
var return_v = this_param.IsGenericMethod ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10235, 34799, 34821);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,34325,34932);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,34325,34932);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static RefKind GetModifiers(SyntaxTokenList modifiers, out SyntaxToken refnessKeyword, out SyntaxToken paramsKeyword, out SyntaxToken thisKeyword)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,34944,36662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35123,35150);

var 
refKind = RefKind.None
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35166,35204);

refnessKeyword = default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35218,35255);

paramsKeyword = default(SyntaxToken);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35269,35304);

thisKeyword = default(SyntaxToken);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35320,36620);
foreach(var modifier in f_10235_35345_35354_I(modifiers) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35320,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35388,36605);

switch (modifier.Kind())
                {

case SyntaxKind.OutKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35388,36605);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35506,35696) || true) && (refKind == RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35506,35696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35591,35617);

refnessKeyword = modifier;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35647,35669);

refKind = RefKind.Out;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35506,35696);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,35722,35728);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35388,36605);

case SyntaxKind.RefKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35388,36605);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35803,35993) || true) && (refKind == RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35803,35993);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35888,35914);

refnessKeyword = modifier;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,35944,35966);

refKind = RefKind.Ref;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35803,35993);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,36019,36025);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35388,36605);

case SyntaxKind.InKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35388,36605);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36099,36288) || true) && (refKind == RefKind.None)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,36099,36288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36184,36210);

refnessKeyword = modifier;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36240,36261);

refKind = RefKind.In;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,36099,36288);
}
DynAbs.Tracing.TraceSender.TraceBreak(10235,36314,36320);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35388,36605);

case SyntaxKind.ParamsKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35388,36605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36398,36423);

paramsKeyword = modifier;
DynAbs.Tracing.TraceSender.TraceBreak(10235,36449,36455);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35388,36605);

case SyntaxKind.ThisKeyword:
DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,35388,36605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36531,36554);

thisKeyword = modifier;
DynAbs.Tracing.TraceSender.TraceBreak(10235,36580,36586);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35388,36605);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,35320,36620);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(10235,1,1301);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(10235,1,1301);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36636,36651);

return refKind;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,34944,36662);

Microsoft.CodeAnalysis.SyntaxTokenList
f_10235_35345_35354_I(Microsoft.CodeAnalysis.SyntaxTokenList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 35345, 35354);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,34944,36662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,34944,36662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<CustomModifier> ConditionallyCreateInModifiers(RefKind refKind, bool addRefReadOnlyModifier, Binder binder, DiagnosticBag diagnostics, SyntaxNode syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,36674,37158);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36883,37147) || true) && (addRefReadOnlyModifier &&(DynAbs.Tracing.TraceSender.Expression_True(10235, 36887, 36934)&&refKind == RefKind.In))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,36883,37147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,36968,37022);

return f_10235_36975_37021(binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,36883,37147);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(10235,36883,37147);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,37088,37132);

return ImmutableArray<CustomModifier>.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(10235,36883,37147);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,36674,37158);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_10235_36975_37021(Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = CreateInModifiers( binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 36975, 37021);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,36674,37158);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,36674,37158);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<CustomModifier> CreateInModifiers(Binder binder, DiagnosticBag diagnostics, SyntaxNode syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,37170,37441);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,37320,37430);

return f_10235_37327_37429(WellKnownType.System_Runtime_InteropServices_InAttribute, binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,37170,37441);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_10235_37327_37429(Microsoft.CodeAnalysis.WellKnownType
modifier,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = CreateModifiers( modifier, binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 37327, 37429);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,37170,37441);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,37170,37441);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static ImmutableArray<CustomModifier> CreateOutModifiers(Binder binder, DiagnosticBag diagnostics, SyntaxNode syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,37453,37726);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,37604,37715);

return f_10235_37611_37714(WellKnownType.System_Runtime_InteropServices_OutAttribute, binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,37453,37726);

System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_10235_37611_37714(Microsoft.CodeAnalysis.WellKnownType
modifier,Microsoft.CodeAnalysis.CSharp.Binder
binder,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
syntax)
{
var return_v = CreateModifiers( modifier, binder, diagnostics, syntax);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 37611, 37714);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,37453,37726);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,37453,37726);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static ImmutableArray<CustomModifier> CreateModifiers(WellKnownType modifier, Binder binder, DiagnosticBag diagnostics, SyntaxNode syntax)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10235,37738,38088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,37909,37983);

var 
modifierType = f_10235_37928_37982(binder, modifier, diagnostics, syntax)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(10235,37997,38077);

return f_10235_38004_38076(f_10235_38026_38075(modifierType));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10235,37738,38088);

Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
f_10235_37928_37982(Microsoft.CodeAnalysis.CSharp.Binder
this_param,Microsoft.CodeAnalysis.WellKnownType
type,Microsoft.CodeAnalysis.DiagnosticBag
diagnostics,Microsoft.CodeAnalysis.SyntaxNode
node)
{
var return_v = this_param.GetWellKnownType( type, diagnostics, node);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 37928, 37982);
return return_v;
}


Microsoft.CodeAnalysis.CustomModifier
f_10235_38026_38075(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
modifier)
{
var return_v = CSharpCustomModifier.CreateRequired( modifier);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 38026, 38075);
return return_v;
}


System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
f_10235_38004_38076(Microsoft.CodeAnalysis.CustomModifier
item)
{
var return_v = ImmutableArray.Create( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(10235, 38004, 38076);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10235,37738,38088);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,37738,38088);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static ParameterHelpers()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10235,516,38095);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10235,516,38095);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10235,516,38095);
}

}
}
