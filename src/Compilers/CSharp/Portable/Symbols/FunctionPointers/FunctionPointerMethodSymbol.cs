// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class FunctionPointerMethodSymbol : MethodSymbol
    {
        private readonly ImmutableArray<FunctionPointerParameterSymbol> _parameters;

        private ImmutableHashSet<CustomModifier>? _lazyCallingConventionModifiers;

        public static FunctionPointerMethodSymbol CreateFromSource(FunctionPointerTypeSyntax syntax, Binder typeBinder, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved, bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 816, 13991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1053, 1143);

                ArrayBuilder<CustomModifier>
                customModifiers = f_10631_1100_1142()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1157, 1296);

                CallingConvention
                callingConvention = f_10631_1195_1295(f_10631_1216_1238(typeBinder), f_10631_1240_1264(syntax), customModifiers, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1312, 1343);

                RefKind
                refKind = RefKind.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1357, 1388);

                TypeWithAnnotations
                returnType
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1404, 4427) || true) && (f_10631_1408_1428(syntax).Parameters.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 1404, 4427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1484, 1554);

                    returnType = TypeWithAnnotations.Create(f_10631_1524_1552(typeBinder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 1404, 4427);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 1404, 4427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1757, 1886);

                    FunctionPointerParameterSyntax?
                    returnTypeParameter = f_10631_1811_1842(f_10631_1811_1831(syntax))[f_10631_1843_1863(syntax).Parameters.Count - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1904, 1962);

                    SyntaxTokenList
                    modifiers = f_10631_1932_1961(returnTypeParameter)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1989, 1994);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 1980, 3604) || true) && (i < modifiers.Count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2017, 2020)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 1980, 3604))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 1980, 3604);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2062, 2098);

                            SyntaxToken
                            modifier = modifiers[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2120, 3585);

                            switch (modifier.Kind())
                            {

                                case SyntaxKind.RefKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2220, 2248) || true) && (refKind == RefKind.None) && (DynAbs.Tracing.TraceSender.Expression_True(10631, 2220, 2248) || true)
                            :
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 2120, 3585);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2279, 2821) || true) && (modifiers.Count > i + 1 && (DynAbs.Tracing.TraceSender.Expression_True(10631, 2283, 2363) && modifiers[i + 1].Kind() == SyntaxKind.ReadOnlyKeyword))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 2279, 2821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2429, 2433);

                                        i++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2467, 2497);

                                        refKind = RefKind.RefReadOnly;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2531, 2638);

                                        f_10631_2531_2637(customModifiers, f_10631_2556_2636(typeBinder, diagnostics, returnTypeParameter));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 2279, 2821);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 2279, 2821);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2768, 2790);

                                        refKind = RefKind.Ref;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 2279, 2821);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10631, 2853, 2859);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 2120, 3585);

                                case SyntaxKind.RefKeyword:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 2120, 3585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 2944, 2982);

                                    f_10631_2944_2981(refKind != RefKind.None);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3092, 3179);

                                    f_10631_3092_3178(                            // A return type can only have one '{0}' modifier.
                                                                diagnostics, ErrorCode.ERR_DupReturnTypeMod, modifier.GetLocation(), modifier.Text);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10631, 3209, 3215);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 2120, 3585);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 2120, 3585);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3419, 3526);

                                    f_10631_3419_3525(                            // '{0}' is not a valid function pointer return type modifier. Valid modifiers are 'ref' and 'ref readonly'.
                                                                diagnostics, ErrorCode.ERR_InvalidFuncPointerReturnTypeModifier, modifier.GetLocation(), modifier.Text);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10631, 3556, 3562);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 2120, 3585);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 1625);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 1625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3624, 3744);

                    returnType = f_10631_3637_3743(typeBinder, f_10631_3657_3681(returnTypeParameter), diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3764, 4412) || true) && (returnType.IsVoidType() && (DynAbs.Tracing.TraceSender.Expression_True(10631, 3768, 3818) && refKind != RefKind.None))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 3764, 4412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3860, 3932);

                        f_10631_3860_3931(diagnostics, ErrorCode.ERR_NoVoidHere, f_10631_3902_3930(returnTypeParameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 3764, 4412);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 3764, 4412);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 3974, 4412) || true) && (returnType.IsStatic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 3974, 4412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4039, 4153);

                            f_10631_4039_4152(diagnostics, f_10631_4055_4109(useWarning: false), f_10631_4111_4139(returnTypeParameter), returnType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 3974, 4412);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 3974, 4412);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4195, 4412) || true) && (returnType.IsRestrictedType(ignoreSpanLikeTypes: true))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 4195, 4412);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4295, 4393);

                                f_10631_4295_4392(diagnostics, ErrorCode.ERR_MethodReturnCantBeRefAny, f_10631_4351_4379(returnTypeParameter), returnType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 4195, 4412);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 3974, 4412);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 3764, 4412);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 1404, 4427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4443, 4505);

                var
                refCustomModifiers = ImmutableArray<CustomModifier>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4519, 4795) || true) && (refKind != RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 4519, 4795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4580, 4638);

                    refCustomModifiers = f_10631_4601_4637(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 4519, 4795);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 4519, 4795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4704, 4780);

                    returnType = returnType.WithModifiers(f_10631_4742_4778(customModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 4519, 4795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 4811, 5108);

                return f_10631_4818_5107(callingConvention, refKind, returnType, refCustomModifiers, syntax, typeBinder, diagnostics, suppressUseSiteDiagnostics);

                static CallingConvention getCallingConvention(CSharpCompilation compilation, FunctionPointerCallingConventionSyntax? callingConventionSyntax, ArrayBuilder<CustomModifier> customModifiers, DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 5124, 13980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 5398, 5520);

                        var
                        temp = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 5409, 5440) || ((callingConventionSyntax != null && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 5443, 5499)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 5502, 5519))) ? callingConventionSyntax.ManagedOrUnmanagedKeyword.Kind() : (SyntaxKind?)null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 5538, 10964);

                        switch (temp)
                        {

                            case null:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 5538, 10964);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 5628, 5661);

                                return CallingConvention.Default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 5538, 10964);

                            case SyntaxKind.ManagedKeyword:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 5538, 10964);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 5826, 6172) || true) && (f_10631_5830_5884(callingConventionSyntax) is object && (DynAbs.Tracing.TraceSender.Expression_True(10631, 5830, 5942) && f_10631_5898_5942_M(!callingConventionSyntax.ContainsDiagnostics)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 5826, 6172);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 6000, 6145);

                                    f_10631_6000_6144(diagnostics, ErrorCode.ERR_CannotSpecifyManagedWithUnmanagedSpecifiers, f_10631_6075_6143(f_10631_6075_6129(callingConventionSyntax)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 5826, 6172);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 6198, 6231);

                                return CallingConvention.Default;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 5538, 10964);

                            case SyntaxKind.UnmanagedKeyword:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 5538, 10964);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8012, 10822);

                                switch (f_10631_8020_8074(callingConventionSyntax))
                                {

                                    case null:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 8012, 10822);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8176, 8289);

                                        f_10631_8176_8288(compilation, callingConventionSyntax.ManagedOrUnmanagedKeyword.GetLocation(), diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8323, 8358);

                                        return CallingConvention.Unmanaged;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 8012, 10822);

                                    case { CallingConventions: { Count: 1 } specifiers }:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 8012, 10822);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8477, 9204);

                                        return f_10631_8484_8502(specifiers[0]) switch
                                        {
                                            // Special identifiers cases
                                            { ValueText: "Cdecl" } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8648, 8697) && DynAbs.Tracing.TraceSender.Expression_True(10631, 8648, 8697))
        => CallingConvention.CDecl,
                                            { ValueText: "Stdcall" } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8736, 8790) && DynAbs.Tracing.TraceSender.Expression_True(10631, 8736, 8790))
        => CallingConvention.Standard,
                                            { ValueText: "Thiscall" } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8829, 8884) && DynAbs.Tracing.TraceSender.Expression_True(10631, 8829, 8884))
        => CallingConvention.ThisCall,
                                            { ValueText: "Fastcall" } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 8923, 8978) && DynAbs.Tracing.TraceSender.Expression_True(10631, 8923, 8978))
        => CallingConvention.FastCall,

                                            // Unknown identifier case
                                            _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 9083, 9168) && DynAbs.Tracing.TraceSender.Expression_True(10631, 9083, 9168))
        => f_10631_9088_9168(specifiers[0], compilation, customModifiers, diagnostics)
                                        };
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 8012, 10822);

                                    case { CallingConventions: { Count: 0 } } unmanagedList:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 8012, 10822);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 9563, 9831) || true) && (f_10631_9567_9601_M(!unmanagedList.ContainsDiagnostics))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 9563, 9831);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 9675, 9796);

                                            f_10631_9675_9795(diagnostics, ErrorCode.ERR_InvalidFunctionPointerCallingConvention, unmanagedList.OpenBracketToken.GetLocation(), "");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 9563, 9831);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 9865, 9898);

                                        return CallingConvention.Default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 8012, 10822);

                                    case { CallingConventions: var specifiers }:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 8012, 10822);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10074, 10187);

                                        f_10631_10074_10186(compilation, callingConventionSyntax.ManagedOrUnmanagedKeyword.GetLocation(), diagnostics);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10221, 10724);
                                            foreach (FunctionPointerUnmanagedCallingConventionSyntax? specifier in f_10631_10292_10302_I(specifiers))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 10221, 10724);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10376, 10478);

                                                CustomModifier?
                                                modifier = f_10631_10403_10477(specifier, compilation, diagnostics)
                                                ;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10516, 10689) || true) && (modifier is object)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 10516, 10689);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10620, 10650);

                                                    f_10631_10620_10649(customModifiers, modifier);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 10516, 10689);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 10221, 10724);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 504);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 504);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10760, 10795);

                                        return CallingConvention.Unmanaged;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 8012, 10822);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 5538, 10964);

                            case var unexpected:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 5538, 10964);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 10892, 10945);

                                throw f_10631_10898_10944(unexpected);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 5538, 10964);
                        }

                        static CallingConvention handleSingleConvention(FunctionPointerUnmanagedCallingConventionSyntax specifier, CSharpCompilation compilation, ArrayBuilder<CustomModifier> customModifiers, DiagnosticBag diagnostics)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 10984, 11655);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11235, 11308);

                                f_10631_11235_11307(compilation, f_10631_11270_11293(specifier), diagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11330, 11432);

                                CustomModifier?
                                modifier = f_10631_11357_11431(specifier, compilation, diagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11454, 11579) || true) && (modifier is object)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 11454, 11579);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11526, 11556);

                                    f_10631_11526_11555(customModifiers, modifier);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 11454, 11579);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11601, 11636);

                                return CallingConvention.Unmanaged;
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 10984, 11655);

                                Microsoft.CodeAnalysis.Location
                                f_10631_11270_11293(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                                this_param)
                                {
                                    var return_v = this_param.GetLocation();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 11270, 11293);
                                    return return_v;
                                }


                                int
                                f_10631_11235_11307(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                compilation, Microsoft.CodeAnalysis.Location
                                errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics)
                                {
                                    checkUnmanagedSupport(compilation, errorLocation, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 11235, 11307);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CustomModifier?
                                f_10631_11357_11431(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                                specifier, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics)
                                {
                                    var return_v = handleIndividualUnrecognizedSpecifier(specifier, compilation, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 11357, 11431);
                                    return return_v;
                                }


                                int
                                f_10631_11526_11555(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                                this_param, Microsoft.CodeAnalysis.CustomModifier
                                item)
                                {
                                    this_param.Add(item);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 11526, 11555);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 10984, 11655);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 10984, 11655);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }

                        static CustomModifier? handleIndividualUnrecognizedSpecifier(FunctionPointerUnmanagedCallingConventionSyntax specifier, CSharpCompilation compilation, DiagnosticBag diagnostics)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 11675, 13529);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11893, 11941);

                                string
                                specifierText = specifier.Name.ValueText
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 11963, 12087) || true) && (f_10631_11967_12002(specifierText))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 11963, 12087);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12052, 12064);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 11963, 12087);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12111, 12156);

                                string
                                typeName = "CallConv" + specifierText
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12178, 12340);

                                var
                                metadataName = MetadataTypeName.FromNamespaceAndTypeName("System.Runtime.CompilerServices", typeName, useCLSCompliantNameArityEncoding: true, forcedArity: 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12362, 12392);

                                NamedTypeSymbol
                                specifierType
                                = default(NamedTypeSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12414, 12540);

                                specifierType = f_10631_12430_12539(f_10631_12430_12461(f_10631_12430_12450(compilation)), ref metadataName, digThroughForwardedTypes: false);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12564, 13209) || true) && (specifierType is MissingMetadataTypeSymbol)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 12564, 13209);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12770, 12935);

                                    specifierType = f_10631_12786_12934(f_10631_12825_12855(specifierType), ref metadataName, f_10631_12875_12933(ErrorCode.ERR_TypeNotFound, typeName));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 12564, 13209);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 12564, 13209);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 12985, 13209) || true) && (f_10631_12989_13024(specifierType) != Accessibility.Public)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 12985, 13209);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13098, 13186);

                                        f_10631_13098_13185(diagnostics, ErrorCode.ERR_TypeMustBePublic, f_10631_13146_13169(specifier), specifierType);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 12985, 13209);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 12564, 13209);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13233, 13428) || true) && (f_10631_13237_13273(specifierType) is DiagnosticInfo diagnostic)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 13233, 13428);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13352, 13405);

                                    f_10631_13352_13404(diagnostics, diagnostic, f_10631_13380_13403(specifier));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 13233, 13428);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13452, 13510);

                                return f_10631_13459_13509(specifierType);
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 11675, 13529);

                                bool
                                f_10631_11967_12002(string
                                value)
                                {
                                    var return_v = string.IsNullOrEmpty(value);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 11967, 12002);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                f_10631_12430_12450(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                this_param)
                                {
                                    var return_v = this_param.Assembly;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 12430, 12450);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                f_10631_12430_12461(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                this_param)
                                {
                                    var return_v = this_param.CorLibrary;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 12430, 12461);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                f_10631_12430_12539(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                                emittedName, bool
                                digThroughForwardedTypes)
                                {
                                    var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 12430, 12539);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                                f_10631_12825_12855(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                this_param)
                                {
                                    var return_v = this_param.ContainingModule;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 12825, 12855);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10631_12875_12933(Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, params object[]
                                args)
                                {
                                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 12875, 12933);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel
                                f_10631_12786_12934(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                                module, ref Microsoft.CodeAnalysis.MetadataTypeName
                                fullName, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                errorInfo)
                                {
                                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol.TopLevel(module, ref fullName, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 12786, 12934);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Accessibility
                                f_10631_12989_13024(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                this_param)
                                {
                                    var return_v = this_param.DeclaredAccessibility;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 12989, 13024);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Location
                                f_10631_13146_13169(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                                this_param)
                                {
                                    var return_v = this_param.GetLocation();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13146, 13169);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10631_13098_13185(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location, params object[]
                                args)
                                {
                                    var return_v = diagnostics.Add(code, location, args);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13098, 13185);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.DiagnosticInfo
                                f_10631_13237_13273(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                this_param)
                                {
                                    var return_v = this_param.GetUseSiteDiagnostic();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13237, 13273);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Location
                                f_10631_13380_13403(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                                this_param)
                                {
                                    var return_v = this_param.GetLocation();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13380, 13403);
                                    return return_v;
                                }


                                int
                                f_10631_13352_13404(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                                info, Microsoft.CodeAnalysis.Location
                                location)
                                {
                                    diagnostics.Add(info, location);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13352, 13404);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CustomModifier
                                f_10631_13459_13509(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                                modifier)
                                {
                                    var return_v = CSharpCustomModifier.CreateOptional(modifier);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13459, 13509);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 11675, 13529);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 11675, 13529);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }

                        static void checkUnmanagedSupport(CSharpCompilation compilation, Location errorLocation, DiagnosticBag diagnostics)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 13549, 13965);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13705, 13946) || true) && (f_10631_13709_13781_M(!f_10631_13710_13730(compilation).RuntimeSupportsUnmanagedSignatureCallingConvention))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 13705, 13946);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 13831, 13923);

                                    f_10631_13831_13922(diagnostics, ErrorCode.ERR_RuntimeDoesNotSupportUnmanagedDefaultCallConv, errorLocation);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 13705, 13946);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 13549, 13965);

                                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                                f_10631_13710_13730(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                                this_param)
                                {
                                    var return_v = this_param.Assembly;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 13710, 13730);
                                    return return_v;
                                }


                                bool
                                f_10631_13709_13781_M(bool
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 13709, 13781);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                                f_10631_13831_13922(Microsoft.CodeAnalysis.DiagnosticBag
                                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                                code, Microsoft.CodeAnalysis.Location
                                location)
                                {
                                    var return_v = diagnostics.Add(code, location);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 13831, 13922);
                                    return return_v;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 13549, 13965);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 13549, 13965);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 5124, 13980);

                        Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionListSyntax?
                        f_10631_5830_5884(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerCallingConventionSyntax?
                        this_param)
                        {
                            var return_v = this_param.UnmanagedCallingConventionList;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 5830, 5884);
                            return return_v;
                        }


                        bool
                        f_10631_5898_5942_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 5898, 5942);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionListSyntax
                        f_10631_6075_6129(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerCallingConventionSyntax
                        this_param)
                        {
                            var return_v = this_param.UnmanagedCallingConventionList;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 6075, 6129);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10631_6075_6143(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionListSyntax
                        this_param)
                        {
                            var return_v = this_param.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 6075, 6143);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10631_6000_6144(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = diagnostics.Add(code, location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 6000, 6144);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionListSyntax?
                        f_10631_8020_8074(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerCallingConventionSyntax?
                        this_param)
                        {
                            var return_v = this_param.UnmanagedCallingConventionList;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 8020, 8074);
                            return return_v;
                        }


                        int
                        f_10631_8176_8288(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.Location
                        errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            checkUnmanagedSupport(compilation, errorLocation, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 8176, 8288);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SyntaxToken
                        f_10631_8484_8502(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 8484, 8502);
                            return return_v;
                        }


                        Microsoft.Cci.CallingConvention
                        f_10631_9088_9168(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                        specifier, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                        customModifiers, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = handleSingleConvention(specifier, compilation, customModifiers, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 9088, 9168);
                            return return_v;
                        }


                        bool
                        f_10631_9567_9601_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 9567, 9601);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10631_9675_9795(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 9675, 9795);
                            return return_v;
                        }


                        int
                        f_10631_10074_10186(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.Location
                        errorLocation, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            checkUnmanagedSupport(compilation, errorLocation, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 10074, 10186);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CustomModifier?
                        f_10631_10403_10477(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax
                        specifier, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = handleIndividualUnrecognizedSpecifier(specifier, compilation, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 10403, 10477);
                            return return_v;
                        }


                        int
                        f_10631_10620_10649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                        this_param, Microsoft.CodeAnalysis.CustomModifier
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 10620, 10649);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax>
                        f_10631_10292_10302_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerUnmanagedCallingConventionSyntax>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 10292, 10302);
                            return return_v;
                        }


                        System.Exception
                        f_10631_10898_10944(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                        o)
                        {
                            var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 10898, 10944);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 5124, 13980);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 5124, 13980);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 816, 13991);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_1100_1142()
                {
                    var return_v = ArrayBuilder<CustomModifier>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 1100, 1142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10631_1216_1238(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1216, 1238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerCallingConventionSyntax?
                f_10631_1240_1264(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1240, 1264);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10631_1195_1295(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerCallingConventionSyntax?
                callingConventionSyntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = getCallingConvention(compilation, callingConventionSyntax, customModifiers, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 1195, 1295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
                f_10631_1408_1428(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1408, 1428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10631_1524_1552(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 1524, 1552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
                f_10631_1811_1831(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1811, 1831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
                f_10631_1811_1842(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1811, 1842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
                f_10631_1843_1863(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1843, 1863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10631_1932_1961(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 1932, 1961);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_2556_2636(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                syntax)
                {
                    var return_v = ParameterHelpers.CreateInModifiers(binder, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 2556, 2636);
                    return return_v;
                }


                int
                f_10631_2531_2637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 2531, 2637);
                    return 0;
                }


                int
                f_10631_2944_2981(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 2944, 2981);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_3092_3178(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 3092, 3178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_3419_3525(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 3419, 3525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10631_3657_3681(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 3657, 3681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_3637_3743(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 3637, 3743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10631_3902_3930(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 3902, 3930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_3860_3931(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 3860, 3931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10631_4055_4109(bool
                useWarning)
                {
                    var return_v = ErrorFacts.GetStaticClassReturnCode(useWarning: useWarning);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4055, 4109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10631_4111_4139(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 4111, 4139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_4039_4152(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4039, 4152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10631_4351_4379(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 4351, 4379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_4295_4392(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4295, 4392);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_4601_4637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4601, 4637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_4742_4778(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4742, 4778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_4818_5107(Microsoft.Cci.CallingConvention
                callingConvention, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Binder
                typeBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol(callingConvention, refKind, returnType, refCustomModifiers, syntax, typeBinder, diagnostics, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 4818, 5107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 816, 13991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 816, 13991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FunctionPointerMethodSymbol CreateFromPartsForTest(
                    CallingConvention callingConvention,
                    TypeWithAnnotations returnType,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    RefKind returnRefKind,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<ImmutableArray<CustomModifier>> parameterRefCustomModifiers,
                    ImmutableArray<RefKind> parameterRefKinds,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 14249, 15120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 14790, 15109);

                return f_10631_14797_15108(callingConvention, returnRefKind, returnType, refCustomModifiers, parameterTypes, parameterRefCustomModifiers, parameterRefKinds, compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 14249, 15120);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_14797_15108(Microsoft.Cci.CallingConvention
                callingConvention, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnTypeWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                parameterRefCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol(callingConvention, refKind, returnTypeWithAnnotations, refCustomModifiers, parameterTypes, parameterRefCustomModifiers, parameterRefKinds, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 14797, 15108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 14249, 15120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 14249, 15120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FunctionPointerMethodSymbol CreateFromParts(
                    CallingConvention callingConvention,
                    ImmutableArray<CustomModifier> callingConventionModifiers,
                    TypeWithAnnotations returnTypeWithAnnotations,
                    RefKind returnRefKind,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 15321, 17139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 15789, 15855);

                var
                modifiersBuilder = f_10631_15812_15854()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 15871, 16103) || true) && (f_10631_15875_15919_M(!callingConventionModifiers.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 15871, 16103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 15953, 16016);

                    f_10631_15953_16015(callingConvention == CallingConvention.Unmanaged);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16034, 16088);

                    f_10631_16034_16087(modifiersBuilder, callingConventionModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 15871, 16103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16119, 16169);

                ImmutableArray<CustomModifier>
                refCustomModifiers
                = default(ImmutableArray<CustomModifier>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16183, 16769) || true) && (returnRefKind == RefKind.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 16183, 16769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16250, 16308);

                    refCustomModifiers = ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16326, 16433);

                    returnTypeWithAnnotations = returnTypeWithAnnotations.WithModifiers(f_10631_16394_16431(modifiersBuilder));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 16183, 16769);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 16183, 16769);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16499, 16677) || true) && (f_10631_16503_16558(returnRefKind, compilation) is CustomModifier modifier)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 16499, 16677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16627, 16658);

                        f_10631_16627_16657(modifiersBuilder, modifier);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 16499, 16677);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16695, 16754);

                    refCustomModifiers = f_10631_16716_16753(modifiersBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 16183, 16769);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 16785, 17128);

                return f_10631_16792_17127(callingConvention, returnRefKind, returnTypeWithAnnotations, refCustomModifiers, parameterTypes, parameterRefCustomModifiers: default, parameterRefKinds, compilation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 15321, 17139);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_15812_15854()
                {
                    var return_v = ArrayBuilder<CustomModifier>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 15812, 15854);
                    return return_v;
                }


                bool
                f_10631_15875_15919_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 15875, 15919);
                    return return_v;
                }


                int
                f_10631_15953_16015(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 15953, 16015);
                    return 0;
                }


                int
                f_10631_16034_16087(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16034, 16087);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_16394_16431(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16394, 16431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier?
                f_10631_16503_16558(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetCustomModifierForRefKind(refKind, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16503, 16558);
                    return return_v;
                }


                int
                f_10631_16627_16657(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param, Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16627, 16657);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_16716_16753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16716, 16753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_16792_17127(Microsoft.Cci.CallingConvention
                callingConvention, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnTypeWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                parameterRefCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol(callingConvention, refKind, returnTypeWithAnnotations, refCustomModifiers, parameterTypes, parameterRefCustomModifiers: parameterRefCustomModifiers, parameterRefKinds, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 16792, 17127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 15321, 17139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 15321, 17139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CustomModifier? GetCustomModifierForRefKind(RefKind refKind, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 17151, 17881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17282, 17614);

                var
                attributeType = refKind switch
                {
                    RefKind.In when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17349, 17449) && DynAbs.Tracing.TraceSender.Expression_True(10631, 17349, 17449))
=> f_10631_17363_17449(compilation, WellKnownType.System_Runtime_InteropServices_InAttribute),
                    RefKind.Out when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17468, 17570) && DynAbs.Tracing.TraceSender.Expression_True(10631, 17468, 17570))
=> f_10631_17483_17570(compilation, WellKnownType.System_Runtime_InteropServices_OutAttribute),
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17589, 17598) && DynAbs.Tracing.TraceSender.Expression_True(10631, 17589, 17598))
=> null
                }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17630, 17796) || true) && (attributeType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 17630, 17796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17689, 17751);

                    f_10631_17689_17750(refKind != RefKind.Out && (DynAbs.Tracing.TraceSender.Expression_True(10631, 17702, 17749) && refKind != RefKind.In));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17769, 17781);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 17630, 17796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 17812, 17870);

                return f_10631_17819_17869(attributeType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 17151, 17881);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10631_17363_17449(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 17363, 17449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10631_17483_17570(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 17483, 17570);
                    return return_v;
                }


                int
                f_10631_17689_17750(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 17689, 17750);
                    return 0;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10631_17819_17869(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CSharpCustomModifier.CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 17819, 17869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 17151, 17881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 17151, 17881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static FunctionPointerMethodSymbol CreateFromMetadata(CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> retAndParamTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 18060, 18131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 18063, 18131);
                return f_10631_18063_18131(callingConvention, retAndParamTypes); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 18060, 18131);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 18060, 18131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 18060, 18131);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10631_18063_18131(Microsoft.Cci.CallingConvention
            callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
            retAndParamTypes)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol(callingConvention, retAndParamTypes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 18063, 18131);
                return return_v;
            }

        }

        public FunctionPointerMethodSymbol SubstituteParameterSymbols(
                    TypeWithAnnotations substitutedReturnType,
                    ImmutableArray<TypeWithAnnotations> substitutedParameterTypes,
                    ImmutableArray<CustomModifier> refCustomModifiers = default,
                    ImmutableArray<ImmutableArray<CustomModifier>> paramRefCustomModifiers = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 18521, 18882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 18524, 18882);
                return f_10631_18524_18882(f_10631_18574_18596(this), f_10631_18615_18627(this), substitutedReturnType, (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 18686, 18714) || ((refCustomModifiers.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 18717, 18740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 18743, 18761))) ? f_10631_18717_18740(this) : refCustomModifiers, f_10631_18780_18795(this), substitutedParameterTypes, paramRefCustomModifiers); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 18521, 18882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 18521, 18882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 18521, 18882);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.CallingConvention
            f_10631_18574_18596(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param)
            {
                var return_v = this_param.CallingConvention;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 18574, 18596);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10631_18615_18627(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param)
            {
                var return_v = this_param.RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 18615, 18627);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10631_18717_18740(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param)
            {
                var return_v = this_param.RefCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 18717, 18740);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10631_18780_18795(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param)
            {
                var return_v = this_param.Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 18780, 18795);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10631_18524_18882(Microsoft.Cci.CallingConvention
            callingConvention, Microsoft.CodeAnalysis.RefKind
            refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            originalParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
            substitutedRefCustomModifiers)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol(callingConvention, refKind, returnType, refCustomModifiers, originalParameters, substitutedParameterTypes, substitutedRefCustomModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 18524, 18882);
                return return_v;
            }

        }

        internal FunctionPointerMethodSymbol MergeEquivalentTypes(FunctionPointerMethodSymbol signature, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 18895, 21306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19039, 19082);

                f_10631_19039_19081(f_10631_19052_19059() == f_10631_19063_19080(signature));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19096, 19172);

                var
                returnVariance = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 19117, 19140) || ((f_10631_19117_19124() == RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 19143, 19151)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 19154, 19171))) ? variance : VarianceKind.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19186, 19309);

                var
                mergedReturnType = f_10631_19209_19234().MergeEquivalentTypes(f_10631_19256_19291(signature), returnVariance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19325, 19394);

                var
                mergedParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19408, 19437);

                bool
                hasParamChanges = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19451, 21002) || true) && (_parameters.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 19451, 21002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19511, 19607);

                    var
                    paramMergedTypesBuilder = f_10631_19541_19606(_parameters.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19634, 19639);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19625, 20631) || true) && (i < _parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19665, 19668)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 19625, 20631))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 19625, 20631);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19710, 19741);

                            var
                            thisParam = _parameters[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19763, 19805);

                            var
                            otherParam = signature._parameters[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19827, 19881);

                            f_10631_19827_19880(f_10631_19840_19857(thisParam) == f_10631_19861_19879(otherParam));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 19903, 20211);

                            var
                            paramVariance = (variance, f_10631_19934_19951(thisParam)) switch
                            {
                                (VarianceKind.In, RefKind.None) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20008, 20059) && DynAbs.Tracing.TraceSender.Expression_True(10631, 20008, 20059))
=> VarianceKind.Out,
                                (VarianceKind.Out, RefKind.None) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20086, 20137) && DynAbs.Tracing.TraceSender.Expression_True(10631, 20086, 20137))
=> VarianceKind.In,
                                _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20164, 20186) && DynAbs.Tracing.TraceSender.Expression_True(10631, 20164, 20186))
=> VarianceKind.None,
                            }
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20235, 20359);

                            var
                            mergedParameterType = thisParam.TypeWithAnnotations.MergeEquivalentTypes(f_10631_20312_20342(otherParam), paramVariance)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20381, 20430);

                            f_10631_20381_20429(paramMergedTypesBuilder, mergedParameterType);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20452, 20612) || true) && (!mergedParameterType.IsSameAs(f_10631_20486_20515(thisParam)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 20452, 20612);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20566, 20589);

                                hasParamChanges = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 20452, 20612);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 1007);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 1007);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20651, 20987) || true) && (hasParamChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 20651, 20987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20712, 20780);

                        mergedParameterTypes = f_10631_20735_20779(paramMergedTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 20651, 20987);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 20651, 20987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20862, 20893);

                        f_10631_20862_20892(paramMergedTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 20915, 20968);

                        mergedParameterTypes = f_10631_20938_20967();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 20651, 20987);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 19451, 21002);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21018, 21295) || true) && (hasParamChanges || (DynAbs.Tracing.TraceSender.Expression_False(10631, 21022, 21094) || !mergedReturnType.IsSameAs(f_10631_21068_21093())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 21018, 21295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21128, 21202);

                    return f_10631_21135_21201(this, mergedReturnType, mergedParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 21018, 21295);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 21018, 21295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21268, 21280);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 21018, 21295);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 18895, 21306);

                Microsoft.CodeAnalysis.RefKind
                f_10631_19052_19059()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19052, 19059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_19063_19080(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19063, 19080);
                    return return_v;
                }


                int
                f_10631_19039_19081(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 19039, 19081);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_19117_19124()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19117, 19124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_19209_19234()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19209, 19234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_19256_19291(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19256, 19291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_19541_19606(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 19541, 19606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_19840_19857(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19840, 19857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_19861_19879(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19861, 19879);
                    return return_v;
                }


                int
                f_10631_19827_19880(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 19827, 19880);
                    return 0;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_19934_19951(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 19934, 19951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_20312_20342(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 20312, 20342);
                    return return_v;
                }


                int
                f_10631_20381_20429(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 20381, 20429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_20486_20515(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 20486, 20515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_20735_20779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 20735, 20779);
                    return return_v;
                }


                int
                f_10631_20862_20892(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 20862, 20892);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_20938_20967()
                {
                    var return_v = ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 20938, 20967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_21068_21093()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 21068, 21093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_21135_21201(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes)
                {
                    var return_v = this_param.SubstituteParameterSymbols(substitutedReturnType, substitutedParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21135, 21201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 18895, 21306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 18895, 21306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public FunctionPointerMethodSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 21318, 22913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21467, 21528);

                var
                transformedReturn = f_10631_21491_21527(transform, f_10631_21501_21526())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21544, 21618);

                var
                transformedParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21632, 21661);

                bool
                hasParamChanges = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21675, 22602) || true) && (_parameters.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 21675, 22602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21735, 21825);

                    var
                    paramTypesBuilder = f_10631_21759_21824(_parameters.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21843, 22231);
                        foreach (var param in f_10631_21865_21876_I(_parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 21843, 22231);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21918, 21977);

                            var
                            transformedType = f_10631_21940_21976(transform, f_10631_21950_21975(param))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 21999, 22038);

                            f_10631_21999_22037(paramTypesBuilder, transformedType);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22060, 22212) || true) && (!transformedType.IsSameAs(f_10631_22090_22115(param)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 22060, 22212);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22166, 22189);

                                hasParamChanges = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 22060, 22212);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 21843, 22231);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 389);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 389);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22251, 22585) || true) && (hasParamChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 22251, 22585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22312, 22379);

                        transformedParameterTypes = f_10631_22340_22378(paramTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 22251, 22585);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 22251, 22585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22461, 22486);

                        f_10631_22461_22485(paramTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22508, 22566);

                        transformedParameterTypes = f_10631_22536_22565();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 22251, 22585);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 21675, 22602);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22618, 22902) || true) && (hasParamChanges || (DynAbs.Tracing.TraceSender.Expression_False(10631, 22622, 22695) || !transformedReturn.IsSameAs(f_10631_22669_22694())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 22618, 22902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22729, 22809);

                    return f_10631_22736_22808(this, transformedReturn, transformedParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 22618, 22902);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 22618, 22902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 22875, 22887);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 22618, 22902);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 21318, 22913);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_21501_21526()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 21501, 21526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_21491_21527(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21491, 21527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_21759_21824(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21759, 21824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_21950_21975(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 21950, 21975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_21940_21976(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21940, 21976);
                    return return_v;
                }


                int
                f_10631_21999_22037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21999, 22037);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_22090_22115(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 22090, 22115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                f_10631_21865_21876_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 21865, 21876);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_22340_22378(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 22340, 22378);
                    return return_v;
                }


                int
                f_10631_22461_22485(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 22461, 22485);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_22536_22565()
                {
                    var return_v = ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 22536, 22565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_22669_22694()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 22669, 22694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_22736_22808(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes)
                {
                    var return_v = this_param.SubstituteParameterSymbols(substitutedReturnType, substitutedParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 22736, 22808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 21318, 22913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 21318, 22913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FunctionPointerMethodSymbol(
                    CallingConvention callingConvention,
                    RefKind refKind,
                    TypeWithAnnotations returnType,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    ImmutableArray<ParameterSymbol> originalParameters,
                    ImmutableArray<TypeWithAnnotations> substitutedParameterTypes,
                    ImmutableArray<ImmutableArray<CustomModifier>> substitutedRefCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10631, 22925, 24930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 772, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38117, 38179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38274, 38314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23407, 23483);

                f_10631_23407_23482(originalParameters.Length == substitutedParameterTypes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23497, 23620);

                f_10631_23497_23619(substitutedRefCustomModifiers.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10631, 23510, 23618) || originalParameters.Length == substitutedRefCustomModifiers.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23634, 23674);

                RefCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23688, 23726);

                CallingConvention = callingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23740, 23758);

                RefKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23772, 23811);

                ReturnTypeWithAnnotations = returnType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23827, 24919) || true) && (originalParameters.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 23827, 24919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 23894, 23998);

                    var
                    paramsBuilder = f_10631_23914_23997(originalParameters.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24025, 24030);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24016, 24702) || true) && (i < originalParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24063, 24066)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 24016, 24702))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 24016, 24702);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24108, 24150);

                            var
                            originalParam = originalParameters[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24172, 24223);

                            var
                            substitutedType = substitutedParameterTypes[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24245, 24377);

                            var
                            customModifiers = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 24267, 24306) || ((substitutedRefCustomModifiers.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 24309, 24341)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 24344, 24376))) ? f_10631_24309_24341(originalParam) : substitutedRefCustomModifiers[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24399, 24683);

                            f_10631_24399_24682(paramsBuilder, f_10631_24417_24681(substitutedType, f_10631_24520_24541(originalParam), f_10631_24568_24589(originalParam), containingSymbol: this, customModifiers));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 687);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24722, 24771);

                    _parameters = f_10631_24736_24770(paramsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 23827, 24919);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 23827, 24919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 24837, 24904);

                    _parameters = ImmutableArray<FunctionPointerParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 23827, 24919);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10631, 22925, 24930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 22925, 24930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 22925, 24930);
            }
        }

        private FunctionPointerMethodSymbol(
                    CallingConvention callingConvention,
                    RefKind refKind,
                    TypeWithAnnotations returnTypeWithAnnotations,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<ImmutableArray<CustomModifier>> parameterRefCustomModifiers,
                    ImmutableArray<RefKind> parameterRefKinds,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10631, 25131, 27147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 772, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38117, 38179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38274, 38314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 25650, 25687);

                f_10631_25650_25686(refKind != RefKind.Out);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 25701, 25778);

                f_10631_25701_25777(refCustomModifiers.IsDefaultOrEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10631, 25714, 25776) || refKind != RefKind.None));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 25792, 25907);

                f_10631_25792_25906(parameterRefCustomModifiers.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10631, 25805, 25905) || parameterRefCustomModifiers.Length == parameterTypes.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 25921, 26049);

                RefCustomModifiers = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 25942, 25970) || ((refCustomModifiers.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 25973, 26027)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 26030, 26048))) ? f_10631_25973_26027(refKind, compilation) : refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 26063, 26081);

                RefKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 26095, 26133);

                CallingConvention = callingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 26147, 26201);

                ReturnTypeWithAnnotations = returnTypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 26215, 26842);

                _parameters = parameterTypes.ZipAsArray(parameterRefKinds, (Method: this, Comp: compilation, ParamRefCustomModifiers: parameterRefCustomModifiers), (type, refKind, i, arg) =>
                  {
                      var refCustomModifiers = arg.ParamRefCustomModifiers.IsDefault ? getCustomModifierArrayForRefKind(refKind, arg.Comp) : arg.ParamRefCustomModifiers[i];
                      Debug.Assert(refCustomModifiers.IsEmpty || refKind != RefKind.None);
                      return new FunctionPointerParameterSymbol(type, refKind, i, arg.Method, refCustomModifiers: refCustomModifiers);
                  });

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_25973_26027(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = getCustomModifierArrayForRefKind(refKind, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 25973, 26027);
                    return return_v;
                }

                static ImmutableArray<CustomModifier> getCustomModifierArrayForRefKind(RefKind refKind, CSharpCompilation compilation)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 26994, 27135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 26997, 27135);
                        // LAFHIS
                        DynAbs.Tracing.TraceSender.Conditional_F1(10631, 26997, 27062);
                        var temp = f_10631_26997_27046(refKind, compilation);
                        return ((temp is { } && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 27065, 27096)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 27099, 27135)) ? f_10631_27065_27096(temp) : ImmutableArray<CustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 26994, 27135);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 26994, 27135);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 26994, 27135);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10631, 25131, 27147);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 25131, 27147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 25131, 27147);
            }
        }

        private FunctionPointerMethodSymbol(
                    CallingConvention callingConvention,
                    RefKind refKind,
                    TypeWithAnnotations returnType,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    FunctionPointerTypeSyntax syntax,
                    Binder typeBinder,
                    DiagnosticBag diagnostics,
                    bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10631, 27159, 28170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 772, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38117, 38179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38274, 38314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 27574, 27614);

                RefCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 27628, 27666);

                CallingConvention = callingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 27680, 27698);

                RefKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 27712, 27751);

                ReturnTypeWithAnnotations = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 27767, 28159);

                _parameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 27781, 27822) || ((f_10631_27781_27801(syntax).Parameters.Count > 1
                && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 27842, 28086)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 28106, 28158))) ? f_10631_27842_28086(typeBinder, this, f_10631_27971_28002(f_10631_27971_27991(syntax)), diagnostics, suppressUseSiteDiagnostics) : ImmutableArray<FunctionPointerParameterSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10631, 27159, 28170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 27159, 28170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 27159, 28170);
            }
        }

        private FunctionPointerMethodSymbol(CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> retAndParamTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10631, 28182, 30957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 772, 803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38117, 38179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38274, 38314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28335, 28377);

                f_10631_28335_28376(retAndParamTypes.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28393, 28445);

                ParamInfo<TypeSymbol>
                retInfo = retAndParamTypes[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28459, 28589);

                var
                returnType = TypeWithAnnotations.Create(retInfo.Type, customModifiers: f_10631_28534_28587(retInfo.CustomModifiers))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28605, 28683);

                RefCustomModifiers = f_10631_28626_28682(retInfo.RefCustomModifiers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28697, 28735);

                CallingConvention = callingConvention;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28749, 28788);

                ReturnTypeWithAnnotations = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28802, 28886);

                RefKind = f_10631_28812_28885(retInfo, f_10631_28832_28850(), RefKind.RefReadOnly, RefKind.Ref);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28900, 28937);

                f_10631_28900_28936(f_10631_28913_28920() != RefKind.Out);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 28951, 29030);

                _parameters = f_10631_28965_29029(retAndParamTypes.AsSpan()[1..], this);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        f_10631_28965_29029(System.ReadOnlySpan<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
        parameterTypes, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        parent)
                {
                    var return_v = makeParametersFromMetadata(parameterTypes, parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28965, 29029);
                    return return_v;
                }

                static ImmutableArray<FunctionPointerParameterSymbol> makeParametersFromMetadata(ReadOnlySpan<ParamInfo<TypeSymbol>> parameterTypes, FunctionPointerMethodSymbol parent)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 29046, 30356);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29247, 30341) || true) && (parameterTypes.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 29247, 30341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29318, 29418);

                            var
                            paramsBuilder = f_10631_29338_29417(parameterTypes.Length)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29451, 29456);

                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29442, 30114) || true) && (i < parameterTypes.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29485, 29488)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 29442, 30114))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 29442, 30114);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29538, 29586);

                                    ParamInfo<TypeSymbol>
                                    param = parameterTypes[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29612, 29692);

                                    var
                                    paramRefCustomMods = f_10631_29637_29691(param.RefCustomModifiers)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29718, 29843);

                                    var
                                    paramType = TypeWithAnnotations.Create(param.Type, customModifiers: f_10631_29790_29841(param.CustomModifiers))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29869, 29955);

                                    RefKind
                                    paramRefKind = f_10631_29892_29954(param, paramRefCustomMods, RefKind.In, RefKind.Out)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 29981, 30091);

                                    f_10631_29981_30090(paramsBuilder, f_10631_29999_30089(paramType, paramRefKind, i, parent, paramRefCustomMods));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 673);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 673);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30138, 30180);

                            return f_10631_30145_30179(paramsBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 29247, 30341);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 29247, 30341);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30262, 30322);

                            return ImmutableArray<FunctionPointerParameterSymbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 29247, 30341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 29046, 30356);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 29046, 30356);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 29046, 30356);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_28812_28885(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                paramRefCustomMods, Microsoft.CodeAnalysis.RefKind
                hasInRefKind, Microsoft.CodeAnalysis.RefKind
                hasOutRefKind)
                {
                    var return_v = getRefKind(param, paramRefCustomMods, hasInRefKind, hasOutRefKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28812, 28885);
                    return return_v;
                }

                static RefKind getRefKind(ParamInfo<TypeSymbol> param, ImmutableArray<CustomModifier> paramRefCustomMods, RefKind hasInRefKind, RefKind hasOutRefKind)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10631, 30372, 30946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30555, 30931);

                        return param.IsByRef switch
                        {
                            false when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30623, 30644) && DynAbs.Tracing.TraceSender.Expression_True(10631, 30623, 30644))
        => RefKind.None,
                            true when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30672, 30739) || true) && (CustomModifierUtils.HasInAttributeModifier(paramRefCustomMods)) && (DynAbs.Tracing.TraceSender.Expression_True(10631, 30672, 30739) || true)
        => hasInRefKind,
                            true when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30783, 30851) || true) && (CustomModifierUtils.HasOutAttributeModifier(paramRefCustomMods)) && (DynAbs.Tracing.TraceSender.Expression_True(10631, 30783, 30851) || true)
        => hasOutRefKind,
                            true when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 30891, 30910) && DynAbs.Tracing.TraceSender.Expression_True(10631, 30891, 30910))
        => RefKind.Ref,
                        };
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10631, 30372, 30946);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 30372, 30946);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 30372, 30946);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10631, 28182, 30957);

                static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                f_10631_29338_29417(int
                capacity)
                {
                    var return_v = ArrayBuilder<FunctionPointerParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29338, 29417);
                    return return_v;
                }


                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_29637_29691(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CSharpCustomModifier.Convert(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29637, 29691);
                    return return_v;
                }


                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_29790_29841(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CSharpCustomModifier.Convert(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29790, 29841);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.RefKind
                f_10631_29892_29954(Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                paramRefCustomMods, Microsoft.CodeAnalysis.RefKind
                hasInRefKind, Microsoft.CodeAnalysis.RefKind
                hasOutRefKind)
                {
                    var return_v = getRefKind(param, paramRefCustomMods, hasInRefKind, hasOutRefKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29892, 29954);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                f_10631_29999_30089(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, Microsoft.CodeAnalysis.RefKind
                refKind, int
                ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                refCustomModifiers)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol(typeWithAnnotations, refKind, ordinal, containingSymbol, refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29999, 30089);
                    return return_v;
                }


                static int
                f_10631_29981_30090(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 29981, 30090);
                    return 0;
                }


                static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                f_10631_30145_30179(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 30145, 30179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 28182, 30957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 28182, 30957);
            }
        }

        internal void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 30969, 31286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31060, 31120);

                f_10631_31060_31085().AddNullableTransforms(transforms);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31134, 31275);
                    foreach (var param in f_10631_31156_31166_I(f_10631_31156_31166()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 31134, 31275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31200, 31260);

                        param.TypeWithAnnotations.AddNullableTransforms(transforms);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 31134, 31275);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 142);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 30969, 31286);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_31060_31085()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31060, 31085);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31156_31166()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31156, 31166);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31156_31166_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 31156, 31166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 30969, 31286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 30969, 31286);
            }
        }

        internal FunctionPointerMethodSymbol ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 31298, 32814);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations newReturnType = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations newParamType = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31461, 31601);

                bool
                madeChanges = f_10631_31480_31505().ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out newReturnType
                )
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31615, 31677);

                var
                newParamTypes = ImmutableArray<TypeWithAnnotations>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31691, 32581) || true) && (f_10631_31695_31714_M(!f_10631_31696_31706().IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 31691, 32581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31748, 31837);

                    var
                    paramTypesBuilder = f_10631_31772_31836(f_10631_31818_31828().Length)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31855, 31885);

                    bool
                    madeParamChanges = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31903, 32194);
                        foreach (var param in f_10631_31925_31935_I(f_10631_31925_31935()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 31903, 32194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 31977, 32117);

                            madeParamChanges |= param.TypeWithAnnotations.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out newParamType
                            );
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32139, 32175);

                            f_10631_32139_32174(paramTypesBuilder, newParamType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 31903, 32194);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 292);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32214, 32566) || true) && (madeParamChanges)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 32214, 32566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32276, 32331);

                        newParamTypes = f_10631_32292_32330(paramTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32353, 32372);

                        madeChanges = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 32214, 32566);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 32214, 32566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32454, 32479);

                        f_10631_32454_32478(paramTypesBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32501, 32547);

                        newParamTypes = f_10631_32517_32546();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 32214, 32566);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 31691, 32581);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32597, 32803) || true) && (madeChanges)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 32597, 32803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32646, 32710);

                    return f_10631_32653_32709(this, newReturnType, newParamTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 32597, 32803);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 32597, 32803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32776, 32788);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 32597, 32803);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 31298, 32814);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_31480_31505()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31480, 31505);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31696_31706()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31696, 31706);
                    return return_v;
                }


                bool
                f_10631_31695_31714_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31695, 31714);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31818_31828()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31818, 31828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_31772_31836(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 31772, 31836);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31925_31935()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 31925, 31935);
                    return return_v;
                }


                int
                f_10631_32139_32174(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 32139, 32174);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_31925_31935_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 31925, 31935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_32292_32330(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 32292, 32330);
                    return return_v;
                }


                int
                f_10631_32454_32478(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 32454, 32478);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10631_32517_32546()
                {
                    var return_v = ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 32517, 32546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10631_32653_32709(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                substitutedParameterTypes)
                {
                    var return_v = this_param.SubstituteParameterSymbols(substitutedReturnType, substitutedParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 32653, 32709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 31298, 32814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 31298, 32814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> UnmanagedCallingConventionTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 32932, 33934);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 32968, 33145) || true) && (!f_10631_32973_33039(f_10631_32973_32990(), CallingConvention.Unmanaged))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 32968, 33145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33081, 33126);

                        return ImmutableArray<NamedTypeSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 32968, 33145);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33165, 33278);

                    var
                    modifiersToSearch = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 33189, 33212) || ((f_10631_33189_33196() != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 33215, 33233)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 33236, 33277))) ? f_10631_33215_33233() : f_10631_33236_33261().CustomModifiers
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33296, 33431) || true) && (modifiersToSearch.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 33296, 33431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33367, 33412);

                        return ImmutableArray<NamedTypeSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 33296, 33431);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33451, 33533);

                    var
                    builder = f_10631_33465_33532(modifiersToSearch.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33551, 33863);
                        foreach (CSharpCustomModifier modifier in f_10631_33593_33610_I(modifiersToSearch))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 33551, 33863);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33652, 33844) || true) && (f_10631_33656_33734(f_10631_33710_33733(modifier)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 33652, 33844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33784, 33821);

                                f_10631_33784_33820(builder, f_10631_33796_33819(modifier));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 33652, 33844);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 33551, 33863);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 313);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 33883, 33919);

                    return f_10631_33890_33918(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 32932, 33934);

                    Microsoft.Cci.CallingConvention
                    f_10631_32973_32990()
                    {
                        var return_v = CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 32973, 32990);
                        return return_v;
                    }


                    bool
                    f_10631_32973_33039(Microsoft.Cci.CallingConvention
                    original, Microsoft.Cci.CallingConvention
                    compare)
                    {
                        var return_v = original.IsCallingConvention(compare);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 32973, 33039);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10631_33189_33196()
                    {
                        var return_v = RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 33189, 33196);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10631_33215_33233()
                    {
                        var return_v = RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 33215, 33233);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10631_33236_33261()
                    {
                        var return_v = ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 33236, 33261);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10631_33465_33532(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 33465, 33532);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10631_33710_33733(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.ModifierSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 33710, 33733);
                        return return_v;
                    }


                    bool
                    f_10631_33656_33734(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifierType)
                    {
                        var return_v = FunctionPointerTypeSymbol.IsCallingConventionModifier(modifierType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 33656, 33734);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10631_33796_33819(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.ModifierSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 33796, 33819);
                        return return_v;
                    }


                    int
                    f_10631_33784_33820(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 33784, 33820);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10631_33593_33610_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 33593, 33610);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10631_33890_33918(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 33890, 33918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 32826, 33945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 32826, 33945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableHashSet<CustomModifier> GetCallingConventionModifiers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 33957, 35439);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34053, 35373) || true) && (_lazyCallingConventionModifiers is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34053, 35373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34130, 34243);

                    var
                    modifiersToSearch = (DynAbs.Tracing.TraceSender.Conditional_F1(10631, 34154, 34177) || ((f_10631_34154_34161() != RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10631, 34180, 34198)) || DynAbs.Tracing.TraceSender.Conditional_F3(10631, 34201, 34242))) ? f_10631_34180_34198() : f_10631_34201_34226().CustomModifiers
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34261, 35358) || true) && (modifiersToSearch.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10631, 34265, 34342) || f_10631_34294_34311() != CallingConvention.Unmanaged))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34261, 35358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34384, 34457);

                        _lazyCallingConventionModifiers = ImmutableHashSet<CustomModifier>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34261, 35358);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34261, 35358);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34539, 34597);

                        var
                        builder = f_10631_34553_34596()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34619, 34947);
                            foreach (var modifier in f_10631_34644_34661_I(modifiersToSearch))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34619, 34947);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34711, 34924) || true) && (f_10631_34715_34817(f_10631_34769_34816(((CSharpCustomModifier)modifier))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34711, 34924);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34875, 34897);

                                    f_10631_34875_34896(builder, modifier);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34711, 34924);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34619, 34947);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 329);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 329);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 34971, 35300) || true) && (f_10631_34975_34988(builder) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34971, 35300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35043, 35116);

                            _lazyCallingConventionModifiers = ImmutableHashSet<CustomModifier>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34971, 35300);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 34971, 35300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35214, 35277);

                            _lazyCallingConventionModifiers = f_10631_35248_35276(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34971, 35300);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35324, 35339);

                        f_10631_35324_35338(
                                            builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34261, 35358);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 34053, 35373);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35389, 35428);

                return _lazyCallingConventionModifiers;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 33957, 35439);

                Microsoft.CodeAnalysis.RefKind
                f_10631_34154_34161()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34154, 34161);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_34180_34198()
                {
                    var return_v = RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34180, 34198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_34201_34226()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34201, 34226);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10631_34294_34311()
                {
                    var return_v = CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34294, 34311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_34553_34596()
                {
                    var return_v = PooledHashSet<CustomModifier>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 34553, 34596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10631_34769_34816(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                this_param)
                {
                    var return_v = this_param.ModifierSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34769, 34816);
                    return return_v;
                }


                bool
                f_10631_34715_34817(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifierType)
                {
                    var return_v = FunctionPointerTypeSymbol.IsCallingConventionModifier(modifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 34715, 34817);
                    return return_v;
                }


                bool
                f_10631_34875_34896(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param, Microsoft.CodeAnalysis.CustomModifier
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 34875, 34896);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_34644_34661_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 34644, 34661);
                    return return_v;
                }


                int
                f_10631_34975_34988(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 34975, 34988);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_35248_35276(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CustomModifier>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 35248, 35276);
                    return return_v;
                }


                int
                f_10631_35324_35338(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 35324, 35338);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 33957, 35439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 33957, 35439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 35451, 35720);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35546, 35658) || true) && (!(other is FunctionPointerMethodSymbol method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 35546, 35658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35630, 35643);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 35546, 35658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35674, 35709);

                return f_10631_35681_35708(this, method, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 35451, 35720);

                bool
                f_10631_35681_35708(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 35681, 35708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 35451, 35720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 35451, 35720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Equals(FunctionPointerMethodSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 35732, 36133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 35841, 36122);

                return f_10631_35848_35876(this, other) || (DynAbs.Tracing.TraceSender.Expression_False(10631, 35848, 36121) || (f_10631_35898_35936(this, other, compareKind) && (DynAbs.Tracing.TraceSender.Expression_True(10631, 35898, 36120) && _parameters.SequenceEqual(other._parameters, compareKind, (param1, param2, compareKind) => param1.MethodEqualityChecks(param2, compareKind)))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 35732, 36133);

                bool
                f_10631_35848_35876(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 35848, 35876);
                    return return_v;
                }


                bool
                f_10631_35898_35936(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.EqualsNoParameters(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 35898, 35936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 35732, 36133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 35732, 36133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EqualsNoParameters(FunctionPointerMethodSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 36145, 37576);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 36265, 36573) || true) && (f_10631_36269_36286() != f_10631_36290_36313(other) || (DynAbs.Tracing.TraceSender.Expression_False(10631, 36269, 36411) || !f_10631_36335_36411(compareKind, f_10631_36388_36395(), f_10631_36397_36410(other))) || (DynAbs.Tracing.TraceSender.Expression_False(10631, 36269, 36511) || !f_10631_36433_36458().Equals(f_10631_36466_36497(other), compareKind)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 36265, 36573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 36545, 36558);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 36265, 36573);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37005, 37537) || true) && ((compareKind & TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 37005, 37537);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37128, 37378) || true) && (f_10631_37132_37198(f_10631_37132_37149(), CallingConvention.Unmanaged) && (DynAbs.Tracing.TraceSender.Expression_True(10631, 37132, 37304) && !f_10631_37224_37304(f_10631_37224_37255(this), f_10631_37266_37303(other))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 37128, 37378);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37346, 37359);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 37128, 37378);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 37005, 37537);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 37005, 37537);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37412, 37537) || true) && (!f_10631_37417_37435().SequenceEqual(f_10631_37450_37474(other)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 37412, 37537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37509, 37522);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 37412, 37537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 37005, 37537);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37553, 37565);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 36145, 37576);

                Microsoft.Cci.CallingConvention
                f_10631_36269_36286()
                {
                    var return_v = CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36269, 36286);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10631_36290_36313(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36290, 36313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_36388_36395()
                {
                    var return_v = RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36388, 36395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10631_36397_36410(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36397, 36410);
                    return return_v;
                }


                bool
                f_10631_36335_36411(Microsoft.CodeAnalysis.TypeCompareKind
                compareKind, Microsoft.CodeAnalysis.RefKind
                refKind1, Microsoft.CodeAnalysis.RefKind
                refKind2)
                {
                    var return_v = FunctionPointerTypeSymbol.RefKindEquals(compareKind, refKind1, refKind2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 36335, 36411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_36433_36458()
                {
                    var return_v = ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36433, 36458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10631_36466_36497(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 36466, 36497);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10631_37132_37149()
                {
                    var return_v = CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 37132, 37149);
                    return return_v;
                }


                bool
                f_10631_37132_37198(Microsoft.Cci.CallingConvention
                original, Microsoft.Cci.CallingConvention
                compare)
                {
                    var return_v = original.IsCallingConvention(compare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37132, 37198);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_37224_37255(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37224, 37255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_37266_37303(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37266, 37303);
                    return return_v;
                }


                bool
                f_10631_37224_37304(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CustomModifier>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37224, 37304);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_37417_37435()
                {
                    var return_v = RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 37417, 37435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_37450_37474(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 37450, 37474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 36145, 37576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 36145, 37576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 37588, 37894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37646, 37690);

                var
                currentHash = f_10631_37664_37689(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37704, 37850);
                    foreach (var param in f_10631_37726_37737_I(_parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 37704, 37850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37771, 37835);

                        currentHash = f_10631_37785_37834(f_10631_37798_37820(param), currentHash);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 37704, 37850);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10631, 1, 147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10631, 1, 147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37864, 37883);

                return currentHash;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 37588, 37894);

                int
                f_10631_37664_37689(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCodeNoParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37664, 37689);
                    return return_v;
                }


                int
                f_10631_37798_37820(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
                this_param)
                {
                    var return_v = this_param.MethodHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37798, 37820);
                    return return_v;
                }


                int
                f_10631_37785_37834(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37785, 37834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                f_10631_37726_37737_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37726, 37737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 37588, 37894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 37588, 37894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int GetHashCodeNoParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 37958, 38104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 37961, 38104);
                return f_10631_37961_38104(f_10631_37974_37984(), f_10631_37986_38103(f_10631_37999_38030(f_10631_37999_38016()), f_10631_38032_38102(f_10631_38032_38088(f_10631_38080_38087())))); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 37958, 38104);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 37958, 38104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 37958, 38104);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10631_37974_37984()
            {
                var return_v = ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 37974, 37984);
                return return_v;
            }


            Microsoft.Cci.CallingConvention
            f_10631_37999_38016()
            {
                var return_v = CallingConvention;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 37999, 38016);
                return return_v;
            }


            int
            f_10631_37999_38030(Microsoft.Cci.CallingConvention
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37999, 38030);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10631_38080_38087()
            {
                var return_v = RefKind;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 38080, 38087);
                return return_v;
            }


            Microsoft.CodeAnalysis.RefKind
            f_10631_38032_38088(Microsoft.CodeAnalysis.RefKind
            refKind)
            {
                var return_v = FunctionPointerTypeSymbol.GetRefKindForHashCode(refKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 38032, 38088);
                return return_v;
            }


            int
            f_10631_38032_38102(Microsoft.CodeAnalysis.RefKind
            this_param)
            {
                var return_v = this_param.GetHashCode();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 38032, 38102);
                return return_v;
            }


            int
            f_10631_37986_38103(int
            newKey, int
            currentKey)
            {
                var return_v = Hash.Combine(newKey, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37986, 38103);
                return return_v;
            }


            int
            f_10631_37961_38104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            newKeyPart, int
            currentKey)
            {
                var return_v = Hash.Combine(newKeyPart, currentKey);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 37961, 38104);
                return return_v;
            }

        }

        internal override CallingConvention CallingConvention { get; }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 38222, 38263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38225, 38263);
                    return f_10631_38225_38250().IsVoidType(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 38222, 38263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 38222, 38263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 38222, 38263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind { get; }

        public override TypeWithAnnotations ReturnTypeWithAnnotations { get; }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 38463, 38546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38479, 38546);
                    return _parameters.Cast<FunctionPointerParameterSymbol, ParameterSymbol>(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 38463, 38546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 38463, 38546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 38463, 38546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 38679, 38717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38682, 38717);
                    return MethodKind.FunctionPointerSignature; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 38679, 38717);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 38679, 38717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 38679, 38717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 38730, 39175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38811, 38839);

                DiagnosticInfo?
                info = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38853, 38890);

                f_10631_38853_38889(this, ref info);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 38906, 39136) || true) && (f_10631_38910_38981(f_10631_38910_38927(), CallingConvention.ExtraArguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10631, 38906, 39136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39015, 39121);

                    f_10631_39015_39120(this, ref info, f_10631_39049_39119(ErrorCode.ERR_UnsupportedCallingConvention, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10631, 38906, 39136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39152, 39164);

                return info;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 38730, 39175);

                bool
                f_10631_38853_38889(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 38853, 38889);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10631_38910_38927()
                {
                    var return_v = CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 38910, 38927);
                    return return_v;
                }


                bool
                f_10631_38910_38981(Microsoft.Cci.CallingConvention
                original, Microsoft.Cci.CallingConvention
                compare)
                {
                    var return_v = original.IsCallingConvention(compare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 38910, 38981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10631_39049_39119(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39049, 39119);
                    return return_v;
                }


                bool
                f_10631_39015_39120(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, (Microsoft.CodeAnalysis.DiagnosticInfo)info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39015, 39120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 38730, 39175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 38730, 39175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo? result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 39187, 39681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39346, 39670);

                return f_10631_39353_39441(f_10631_39353_39363(), ref result, owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10631, 39353, 39559) || f_10631_39462_39559(ref result, f_10631_39515_39533(), owner, ref checkedTypes)) || (DynAbs.Tracing.TraceSender.Expression_False(10631, 39353, 39669) || f_10631_39580_39669(ref result, f_10631_39633_39643(), owner, ref checkedTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 39187, 39681);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10631_39353_39363()
                {
                    var return_v = ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 39353, 39363);
                    return return_v;
                }


                bool
                f_10631_39353_39441(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39353, 39441);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10631_39515_39533()
                {
                    var return_v = RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 39515, 39533);
                    return return_v;
                }


                bool
                f_10631_39462_39559(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39462, 39559);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10631_39633_39643()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 39633, 39643);
                    return return_v;
                }


                bool
                f_10631_39580_39669(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, parameters, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39580, 39669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 39187, 39681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 39187, 39681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 39747, 39980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39783, 39870);

                    var
                    isVararg = f_10631_39798_39869(f_10631_39798_39815(), CallingConvention.ExtraArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39888, 39931);

                    f_10631_39888_39930(!isVararg || (DynAbs.Tracing.TraceSender.Expression_False(10631, 39901, 39929) || f_10631_39914_39929()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 39949, 39965);

                    return isVararg;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 39747, 39980);

                    Microsoft.Cci.CallingConvention
                    f_10631_39798_39815()
                    {
                        var return_v = CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 39798, 39815);
                        return return_v;
                    }


                    bool
                    f_10631_39798_39869(Microsoft.Cci.CallingConvention
                    original, Microsoft.Cci.CallingConvention
                    compare)
                    {
                        var return_v = original.IsCallingConvention(compare);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39798, 39869);
                        return return_v;
                    }


                    bool
                    f_10631_39914_39929()
                    {
                        var return_v = HasUseSiteError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 39914, 39929);
                        return return_v;
                    }


                    int
                    f_10631_39888_39930(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 39888, 39930);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 39693, 39991);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 39693, 39991);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40044, 40051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40047, 40051);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40044, 40051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40044, 40051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40044, 40051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40146, 40150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40149, 40150);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40146, 40150);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40146, 40150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40146, 40150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40228, 40272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40231, 40272);
                    return ImmutableArray<TypeParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40228, 40272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40228, 40272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40228, 40272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40322, 40330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40325, 40330);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40322, 40330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40322, 40330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40322, 40330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40385, 40393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40388, 40393);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40385, 40393);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40385, 40393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40385, 40393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40433, 40441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40436, 40441);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40433, 40441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40433, 40441);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40433, 40441);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40530, 40567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40533, 40567);
                    return ImmutableArray<MethodSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40530, 40567);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40530, 40567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40530, 40567);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40619, 40626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40622, 40626);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40619, 40626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40619, 40626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40619, 40626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40688, 40721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40691, 40721);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40688, 40721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40688, 40721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40688, 40721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40806, 40846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40809, 40846);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40806, 40846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40806, 40846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40806, 40846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40909, 40939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40912, 40939);
                    return Accessibility.NotApplicable; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40909, 40939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40909, 40939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40909, 40939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 40980, 40988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 40983, 40988);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 40980, 40988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 40980, 40988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 40980, 40988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41030, 41038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41033, 41038);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41030, 41038);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41030, 41038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41030, 41038);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41081, 41089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41084, 41089);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41081, 41089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41081, 41089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41081, 41089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41132, 41140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41135, 41140);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41132, 41140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41132, 41140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41132, 41140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41181, 41189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41184, 41189);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41181, 41189);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41181, 41189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41181, 41189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41230, 41238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41233, 41238);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41230, 41238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41230, 41238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41230, 41238);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41291, 41298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41294, 41298);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41291, 41298);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41291, 41298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41291, 41298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41390, 41434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41393, 41434);
                    return ImmutableArray<TypeWithAnnotations>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41390, 41434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41390, 41434);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41390, 41434);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41483, 41491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41486, 41491);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41483, 41491);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41483, 41491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41483, 41491);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41566, 41576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41569, 41576);
                    return default; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41566, 41576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41566, 41576);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41566, 41576);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41633, 41641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41636, 41641);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41633, 41641);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41633, 41641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41633, 41641);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData? ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41738, 41745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41741, 41745);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41738, 41745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41738, 41745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41738, 41745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41802, 41810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41805, 41810);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41802, 41810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41802, 41810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41802, 41810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41863, 41871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41866, 41871);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41863, 41871);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41863, 41871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41863, 41871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 41916, 41924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 41919, 41924);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 41916, 41924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 41916, 41924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 41916, 41924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42007, 42038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42010, 42038);
                return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42007, 42038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42007, 42038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42007, 42038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42123, 42154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42126, 42154);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42123, 42154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42123, 42154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42123, 42154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42238, 42271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42241, 42271);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42238, 42271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42238, 42271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42238, 42271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42346, 42377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42349, 42377);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42346, 42377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42346, 42377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42346, 42377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42480, 42488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42483, 42488);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42480, 42488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42480, 42488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42480, 42488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42591, 42599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42594, 42599);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42591, 42599);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42591, 42599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42591, 42599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42727, 42734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42730, 42734);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42727, 42734);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42727, 42734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42727, 42734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42788, 42827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42791, 42827);
                    throw f_10631_42797_42827(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42788, 42827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42788, 42827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42788, 42827);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42901, 42940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42904, 42940);
                    throw f_10631_42910_42940(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42901, 42940);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42901, 42940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42901, 42940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 42990, 43029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 42993, 43029);
                    throw f_10631_42999_43029(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 42990, 43029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 42990, 43029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 42990, 43029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 43089, 43128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 43092, 43128);
                throw f_10631_43098_43128(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 43089, 43128);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 43089, 43128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 43089, 43128);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10631_43098_43128()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 43098, 43128);
                return return_v;
            }

        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 43229, 43268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 43232, 43268);
                throw f_10631_43238_43268(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 43229, 43268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 43229, 43268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 43229, 43268);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10631_43238_43268()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 43238, 43268);
                return return_v;
            }

        }

        internal override IEnumerable<SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 43353, 43392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 43356, 43392);
                throw f_10631_43362_43392(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 43353, 43392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 43353, 43392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 43353, 43392);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10631_43362_43392()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 43362, 43392);
                return return_v;
            }

        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10631, 43461, 43500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10631, 43464, 43500);
                throw f_10631_43470_43500(); DynAbs.Tracing.TraceSender.TraceExitMethod(10631, 43461, 43500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10631, 43461, 43500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 43461, 43500);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10631_43470_43500()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 43470, 43500);
                return return_v;
            }

        }

        static FunctionPointerMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10631, 563, 43508);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10631, 563, 43508);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10631, 563, 43508);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10631, 563, 43508);

        int
        f_10631_23407_23482(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 23407, 23482);
            return 0;
        }


        int
        f_10631_23497_23619(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 23497, 23619);
            return 0;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        f_10631_23914_23997(int
        capacity)
        {
            var return_v = ArrayBuilder<FunctionPointerParameterSymbol>.GetInstance(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 23914, 23997);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10631_24309_24341(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 24309, 24341);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10631_24520_24541(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 24520, 24541);
            return return_v;
        }


        int
        f_10631_24568_24589(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Ordinal;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 24568, 24589);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
        f_10631_24417_24681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        typeWithAnnotations, Microsoft.CodeAnalysis.RefKind
        refKind, int
        ordinal, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        refCustomModifiers)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol(typeWithAnnotations, refKind, ordinal, containingSymbol: containingSymbol, refCustomModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 24417, 24681);
            return return_v;
        }


        int
        f_10631_24399_24682(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 24399, 24682);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        f_10631_24736_24770(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        this_param)
        {
            var return_v = this_param.ToImmutableAndFree();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 24736, 24770);
            return return_v;
        }


        int
        f_10631_25650_25686(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 25650, 25686);
            return 0;
        }


        int
        f_10631_25701_25777(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 25701, 25777);
            return 0;
        }


        int
        f_10631_25792_25906(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 25792, 25906);
            return 0;
        }


        static Microsoft.CodeAnalysis.CustomModifier?
        f_10631_26997_27046(Microsoft.CodeAnalysis.RefKind
        refKind, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = GetCustomModifierForRefKind(refKind, compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 26997, 27046);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10631_27065_27096(Microsoft.CodeAnalysis.CustomModifier
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 27065, 27096);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
        f_10631_27781_27801(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 27781, 27801);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
        f_10631_27971_27991(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
        this_param)
        {
            var return_v = this_param.ParameterList;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 27971, 27991);
            return return_v;
        }


        Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
        f_10631_27971_28002(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterListSyntax
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 27971, 28002);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerParameterSymbol>
        f_10631_27842_28086(Microsoft.CodeAnalysis.CSharp.Binder
        binder, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
        owner, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerParameterSyntax>
        parametersList, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, bool
        suppressUseSiteDiagnostics)
        {
            var return_v = ParameterHelpers.MakeFunctionPointerParameters(binder, owner, parametersList, diagnostics, suppressUseSiteDiagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 27842, 28086);
            return return_v;
        }


        int
        f_10631_28335_28376(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28335, 28376);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10631_28534_28587(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
        customModifiers)
        {
            var return_v = CSharpCustomModifier.Convert(customModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28534, 28587);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10631_28626_28682(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
        customModifiers)
        {
            var return_v = CSharpCustomModifier.Convert(customModifiers);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28626, 28682);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
        f_10631_28832_28850()
        {
            var return_v = RefCustomModifiers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 28832, 28850);
            return return_v;
        }

        Microsoft.CodeAnalysis.RefKind
        f_10631_28913_28920()
        {
            var return_v = RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 28913, 28920);
            return return_v;
        }


        int
        f_10631_28900_28936(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10631, 28900, 28936);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10631_38225_38250()
        {
            var return_v = ReturnTypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 38225, 38250);
            return return_v;
        }


        System.Exception
        f_10631_42797_42827()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 42797, 42827);
            return return_v;
        }


        System.Exception
        f_10631_42910_42940()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 42910, 42940);
            return return_v;
        }


        System.Exception
        f_10631_42999_43029()
        {
            var return_v = ExceptionUtilities.Unreachable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10631, 42999, 43029);
            return return_v;
        }

    }
}
