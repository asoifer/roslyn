// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal readonly struct TypeParameterDiagnosticInfo
    {

        public readonly TypeParameterSymbol TypeParameter;

        public readonly DiagnosticInfo DiagnosticInfo;

        public TypeParameterDiagnosticInfo(TypeParameterSymbol typeParameter, DiagnosticInfo diagnosticInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10094, 1092, 1314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 1217, 1252);

                this.TypeParameter = typeParameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 1266, 1303);

                this.DiagnosticInfo = diagnosticInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10094, 1092, 1314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 1092, 1314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 1092, 1314);
            }
        }
        static TypeParameterDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10094, 905, 1321);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10094, 905, 1321);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 905, 1321);
        }
    }
    internal static class ConstraintsHelper
    {
        public static TypeParameterBounds ResolveBounds(
                    this TypeParameterSymbol typeParameter,
                    AssemblySymbol corLibrary,
                    ConsList<TypeParameterSymbol> inProgress,
                    ImmutableArray<TypeWithAnnotations> constraintTypes,
                    bool inherited,
                    CSharpCompilation currentCompilation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 3862, 5047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4269, 4350);

                var
                diagnosticsBuilder = f_10094_4294_4349()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4364, 4439);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4453, 4617);

                var
                bounds = f_10094_4466_4616(typeParameter, corLibrary, inProgress, constraintTypes, inherited, currentCompilation, diagnosticsBuilder, ref useSiteDiagnosticsBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4633, 4774) || true) && (useSiteDiagnosticsBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 4633, 4774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4704, 4759);

                    f_10094_4704_4758(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 4633, 4774);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4790, 4966);
                    foreach (var pair in f_10094_4811_4829_I(diagnosticsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 4790, 4966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4863, 4951);

                        f_10094_4863_4950(diagnostics, f_10094_4879_4949(pair.DiagnosticInfo, f_10094_4917_4945(pair.TypeParameter)[0]));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 4790, 4966);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 4982, 5008);

                f_10094_4982_5007(
                            diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 5022, 5036);

                return bounds;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 3862, 5047);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_4294_4349()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4294, 4349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10094_4466_4616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                inherited, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = typeParameter.ResolveBounds(corLibrary, inProgress, constraintTypes, inherited, currentCompilation, diagnosticsBuilder, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4466, 4616);
                    return return_v;
                }


                int
                f_10094_4704_4758(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4704, 4758);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10094_4917_4945(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 4917, 4945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10094_4879_4949(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4879, 4949);
                    return return_v;
                }


                int
                f_10094_4863_4950(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4863, 4950);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_4811_4829_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4811, 4829);
                    return return_v;
                }


                int
                f_10094_4982_5007(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 4982, 5007);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 3862, 5047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 3862, 5047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static TypeParameterBounds ResolveBounds(
                    this TypeParameterSymbol typeParameter,
                    AssemblySymbol corLibrary,
                    ConsList<TypeParameterSymbol> inProgress,
                    ImmutableArray<TypeWithAnnotations> constraintTypes,
                    bool inherited,
                    CSharpCompilation currentCompilation,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 5109, 17458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 5637, 5733);

                f_10094_5637_5732(currentCompilation == null || (DynAbs.Tracing.TraceSender.Expression_False(10094, 5650, 5731) || f_10094_5680_5731(typeParameter, currentCompilation)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 5749, 5792);

                ImmutableArray<NamedTypeSymbol>
                interfaces
                = default(ImmutableArray<NamedTypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 5808, 5968);

                NamedTypeSymbol
                effectiveBaseClass = f_10094_5845_5967(corLibrary, (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 5871, 5907) || ((f_10094_5871_5907(typeParameter) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 5910, 5938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 5941, 5966))) ? SpecialType.System_ValueType : SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 5982, 6030);

                TypeSymbol
                deducedBaseType = effectiveBaseClass
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6046, 16478) || true) && (constraintTypes.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6046, 16478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6111, 6162);

                    interfaces = ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6046, 16478);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6046, 16478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6228, 6305);

                    var
                    constraintTypesBuilder = f_10094_6257_6304()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6323, 6391);

                    var
                    interfacesBuilder = f_10094_6347_6390()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6409, 6459);

                    var
                    conversions = f_10094_6427_6458(corLibrary)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6477, 6527);

                    HashSet<DiagnosticInfo>
                    useSiteDiagnostics = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6713, 16096);
                        foreach (var constraintType in f_10094_6744_6759_I(constraintTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6713, 16096);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6801, 6854);

                            f_10094_6801_6853(!f_10094_6815_6852(constraintType.Type));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6878, 6918);

                            NamedTypeSymbol
                            constraintEffectiveBase
                            = default(NamedTypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6940, 6973);

                            TypeSymbol
                            constraintDeducedBase
                            = default(TypeSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 6997, 14636);

                            switch (constraintType.TypeKind)
                            {

                                case TypeKind.TypeParameter:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 7171, 7242);

                                        var
                                        constraintTypeParameter = (TypeParameterSymbol)constraintType.Type
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 7276, 7328);

                                        ConsList<TypeParameterSymbol>
                                        constraintsInProgress
                                        = default(ConsList<TypeParameterSymbol>);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 7364, 8576) || true) && (f_10094_7368_7408(constraintTypeParameter) == f_10094_7412_7442(typeParameter))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 7364, 8576);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 7630, 8139) || true) && (f_10094_7634_7687(inProgress, constraintTypeParameter))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 7630, 8139);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 7872, 8049);

                                                f_10094_7872_8048(                                        // "Circular constraint dependency involving '{0}' and '{1}'"
                                                                                        diagnosticsBuilder, f_10094_7895_8047(constraintTypeParameter, f_10094_7952_8046(ErrorCode.ERR_CircularConstraint, constraintTypeParameter, typeParameter)));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8091, 8100);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 7630, 8139);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8179, 8214);

                                            constraintsInProgress = inProgress;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 7364, 8576);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 7364, 8576);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8481, 8541);

                                            constraintsInProgress = ConsList<TypeParameterSymbol>.Empty;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 7364, 8576);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8710, 8805);

                                        constraintEffectiveBase = f_10094_8736_8804(constraintTypeParameter, constraintsInProgress);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8839, 8929);

                                        constraintDeducedBase = f_10094_8863_8928(constraintTypeParameter, constraintsInProgress);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 8963, 9058);

                                        f_10094_8963_9057(interfacesBuilder, f_10094_8996_9056(constraintTypeParameter, constraintsInProgress));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9094, 10380) || true) && (!inherited && (DynAbs.Tracing.TraceSender.Expression_True(10094, 9098, 9138) && currentCompilation != null) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 9098, 9203) && f_10094_9142_9203(constraintTypeParameter, currentCompilation)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 9094, 10380);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9277, 9297);

                                            ErrorCode
                                            errorCode
                                            = default(ErrorCode);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9335, 9978) || true) && (f_10094_9339_9389(constraintTypeParameter))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 9335, 9978);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9471, 9517);

                                                errorCode = ErrorCode.ERR_ConWithUnmanagedCon;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 9335, 9978);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 9335, 9978);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9599, 9978) || true) && (f_10094_9603_9649(constraintTypeParameter))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 9599, 9978);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 9731, 9771);

                                                    errorCode = ErrorCode.ERR_ConWithValCon;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 9599, 9978);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 9599, 9978);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 9933, 9939);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 9599, 9978);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 9335, 9978);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10154, 10298);

                                            f_10094_10154_10297(
                                                                                // "Type parameter '{1}' has the '?' constraint so '{1}' cannot be used as a constraint for '{0}'"
                                                                                diagnosticsBuilder, f_10094_10177_10296(typeParameter, f_10094_10224_10295(errorCode, typeParameter, constraintTypeParameter)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10336, 10345);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 9094, 10380);
                                        }
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 10441, 10447);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Interface:
                                case TypeKind.Class:
                                case TypeKind.Delegate:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10626, 10728);

                                    f_10094_10626_10727(inherited || (DynAbs.Tracing.TraceSender.Expression_False(10094, 10639, 10678) || currentCompilation == null) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 10639, 10726) || constraintType.TypeKind != TypeKind.Delegate));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10760, 11399) || true) && (f_10094_10764_10801(constraintType.Type))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 10760, 11399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10867, 10937);

                                        f_10094_10867_10936(interfacesBuilder, constraintType.Type);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 10971, 11014);

                                        f_10094_10971_11013(constraintTypesBuilder, constraintType);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11048, 11057);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 10760, 11399);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 10760, 11399);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11187, 11250);

                                        constraintEffectiveBase = (NamedTypeSymbol)constraintType.Type;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11284, 11328);

                                        constraintDeducedBase = constraintType.Type;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10094, 11362, 11368);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 10760, 11399);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Struct:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11478, 12825) || true) && (constraintType.IsNullableType())
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 11478, 12825);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11579, 11648);

                                        var
                                        underlyingType = f_10094_11600_11647(constraintType.Type)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11682, 12794) || true) && (f_10094_11686_11709(underlyingType) == TypeKind.TypeParameter)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 11682, 12794);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11809, 11875);

                                            var
                                            underlyingTypeParameter = (TypeParameterSymbol)underlyingType
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 11913, 12759) || true) && (f_10094_11917_11957(underlyingTypeParameter) == f_10094_11961_11991(typeParameter))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 11913, 12759);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 12191, 12720) || true) && (f_10094_12195_12248(inProgress, underlyingTypeParameter))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 12191, 12720);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 12445, 12622);

                                                    f_10094_12445_12621(                                            // "Circular constraint dependency involving '{0}' and '{1}'"
                                                                                                diagnosticsBuilder, f_10094_12468_12620(underlyingTypeParameter, f_10094_12525_12619(ErrorCode.ERR_CircularConstraint, underlyingTypeParameter, typeParameter)));
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 12668, 12677);

                                                    continue;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 12191, 12720);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 11913, 12759);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 11682, 12794);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 11478, 12825);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 12855, 12909);

                                    f_10094_12855_12908(inherited || (DynAbs.Tracing.TraceSender.Expression_False(10094, 12868, 12907) || currentCompilation == null));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 12939, 13021);

                                    constraintEffectiveBase = f_10094_12965_13020(corLibrary, SpecialType.System_ValueType);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13051, 13095);

                                    constraintDeducedBase = constraintType.Type;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 13125, 13131);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Enum:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13208, 13262);

                                    f_10094_13208_13261(inherited || (DynAbs.Tracing.TraceSender.Expression_False(10094, 13221, 13260) || currentCompilation == null));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13292, 13369);

                                    constraintEffectiveBase = f_10094_13318_13368(corLibrary, SpecialType.System_Enum);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13399, 13443);

                                    constraintDeducedBase = constraintType.Type;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 13473, 13479);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Array:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13557, 13611);

                                    f_10094_13557_13610(inherited || (DynAbs.Tracing.TraceSender.Expression_False(10094, 13570, 13609) || currentCompilation == null));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13641, 13719);

                                    constraintEffectiveBase = f_10094_13667_13718(corLibrary, SpecialType.System_Array);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13749, 13793);

                                    constraintDeducedBase = constraintType.Type;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 13823, 13829);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Error:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 13907, 13970);

                                    constraintEffectiveBase = (NamedTypeSymbol)constraintType.Type;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 14000, 14044);

                                    constraintDeducedBase = constraintType.Type;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10094, 14074, 14080);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Pointer:
                                case TypeKind.FunctionPointer:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 14421, 14430);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);

                                case TypeKind.Submission:
                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 6997, 14636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 14547, 14613);

                                    throw f_10094_14553_14612(constraintType.TypeKind);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6997, 14636);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 14660, 14755);

                            f_10094_14660_14754(conversions, constraintEffectiveBase, constraintDeducedBase);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 14779, 14822);

                            f_10094_14779_14821(
                                                constraintTypesBuilder, constraintType);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15011, 16077) || true) && (!f_10094_15016_15045(deducedBaseType) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 15015, 15085) && !f_10094_15050_15085(constraintDeducedBase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 15011, 16077);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15135, 16054) || true) && (!f_10094_15140_15232(conversions, deducedBaseType, constraintDeducedBase, ref useSiteDiagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 15135, 16054);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15290, 16027) || true) && (!f_10094_15295_15387(conversions, constraintDeducedBase, deducedBaseType, ref useSiteDiagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 15290, 16027);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15561, 15747);

                                        f_10094_15561_15746(                                // "Type parameter '{0}' inherits conflicting constraints '{1}' and '{2}'"
                                                                        diagnosticsBuilder, f_10094_15584_15745(typeParameter, f_10094_15631_15744(ErrorCode.ERR_BaseConstraintConflict, typeParameter, constraintDeducedBase, deducedBaseType)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 15290, 16027);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 15290, 16027);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15877, 15917);

                                        deducedBaseType = constraintDeducedBase;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 15951, 15996);

                                        effectiveBaseClass = constraintEffectiveBase;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 15290, 16027);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 15135, 16054);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 15011, 16077);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6713, 16096);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 9384);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 9384);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16116, 16207);

                    f_10094_16116_16206(useSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16227, 16311);

                    f_10094_16227_16310(conversions, effectiveBaseClass, deducedBaseType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16331, 16393);

                    constraintTypes = f_10094_16349_16392(constraintTypesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16411, 16463);

                    interfaces = f_10094_16424_16462(interfacesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 6046, 16478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16494, 16632);

                f_10094_16494_16631((f_10094_16508_16538(effectiveBaseClass) == SpecialType.System_Object) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 16507, 16630) || (f_10094_16573_16600(deducedBaseType) != SpecialType.System_Object)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16789, 17092) || true) && ((constraintTypes.Length == 0) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 16793, 16884) && (f_10094_16827_16854(deducedBaseType) == SpecialType.System_Object)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 16789, 17092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 16918, 16992);

                    f_10094_16918_16991(f_10094_16931_16961(effectiveBaseClass) == SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17010, 17047);

                    f_10094_17010_17046(interfaces.Length == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17065, 17077);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 16789, 17092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17108, 17211);

                var
                bounds = f_10094_17121_17210(constraintTypes, interfaces, effectiveBaseClass, deducedBaseType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17287, 17417) || true) && (inherited)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 17287, 17417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17334, 17402);

                    f_10094_17334_17401(typeParameter, bounds, diagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 17287, 17417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17433, 17447);

                return bounds;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 5109, 17458);

                bool
                f_10094_5680_5731(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 5680, 5731);
                    return return_v;
                }


                int
                f_10094_5637_5732(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 5637, 5732);
                    return 0;
                }


                bool
                f_10094_5871_5907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 5871, 5907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_5845_5967(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 5845, 5967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_6257_6304()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6257, 6304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_6347_6390()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6347, 6390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeConversions
                f_10094_6427_6458(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6427, 6458);
                    return return_v;
                }


                bool
                f_10094_6815_6852(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6815, 6852);
                    return return_v;
                }


                int
                f_10094_6801_6853(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6801, 6853);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_7368_7408(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 7368, 7408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_7412_7442(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 7412, 7442);
                    return return_v;
                }


                bool
                f_10094_7634_7687(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 7634, 7687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_7952_8046(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 7952, 8046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_7895_8047(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 7895, 8047);
                    return return_v;
                }


                int
                f_10094_7872_8048(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 7872, 8048);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_8736_8804(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetEffectiveBaseClass(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 8736, 8804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10094_8863_8928(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetDeducedBaseType(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 8863, 8928);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_8996_9056(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetInterfaces(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 8996, 9056);
                    return return_v;
                }


                int
                f_10094_8963_9057(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces)
                {
                    AddInterfaces(builder, interfaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 8963, 9057);
                    return 0;
                }


                bool
                f_10094_9142_9203(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 9142, 9203);
                    return return_v;
                }


                bool
                f_10094_9339_9389(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 9339, 9389);
                    return return_v;
                }


                bool
                f_10094_9603_9649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 9603, 9649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_10224_10295(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10224, 10295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_10177_10296(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10177, 10296);
                    return return_v;
                }


                int
                f_10094_10154_10297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10154, 10297);
                    return 0;
                }


                int
                f_10094_10626_10727(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10626, 10727);
                    return 0;
                }


                bool
                f_10094_10764_10801(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10764, 10801);
                    return return_v;
                }


                int
                f_10094_10867_10936(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                @interface)
                {
                    AddInterface(builder, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)@interface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10867, 10936);
                    return 0;
                }


                int
                f_10094_10971_11013(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 10971, 11013);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10094_11600_11647(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 11600, 11647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10094_11686_11709(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 11686, 11709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_11917_11957(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 11917, 11957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_11961_11991(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 11961, 11991);
                    return return_v;
                }


                bool
                f_10094_12195_12248(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12195, 12248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_12525_12619(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12525, 12619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_12468_12620(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12468, 12620);
                    return return_v;
                }


                int
                f_10094_12445_12621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12445, 12621);
                    return 0;
                }


                int
                f_10094_12855_12908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12855, 12908);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_12965_13020(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 12965, 13020);
                    return return_v;
                }


                int
                f_10094_13208_13261(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 13208, 13261);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_13318_13368(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 13318, 13368);
                    return return_v;
                }


                int
                f_10094_13557_13610(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 13557, 13610);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_13667_13718(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 13667, 13718);
                    return return_v;
                }


                System.Exception
                f_10094_14553_14612(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 14553, 14612);
                    return return_v;
                }


                int
                f_10094_14660_14754(Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                effectiveBase, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                deducedBase)
                {
                    CheckEffectiveAndDeducedBaseTypes((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)effectiveBase, deducedBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 14660, 14754);
                    return 0;
                }


                int
                f_10094_14779_14821(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 14779, 14821);
                    return 0;
                }


                bool
                f_10094_15016_15045(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15016, 15045);
                    return return_v;
                }


                bool
                f_10094_15050_15085(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15050, 15085);
                    return return_v;
                }


                bool
                f_10094_15140_15232(Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = IsEncompassedBy((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15140, 15232);
                    return return_v;
                }


                bool
                f_10094_15295_15387(Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = IsEncompassedBy((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, a, b, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15295, 15387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_15631_15744(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15631, 15744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_15584_15745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15584, 15745);
                    return return_v;
                }


                int
                f_10094_15561_15746(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 15561, 15746);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_6744_6759_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 6744, 6759);
                    return return_v;
                }


                bool
                f_10094_16116_16206(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder)
                {
                    var return_v = AppendUseSiteDiagnostics(useSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16116, 16206);
                    return return_v;
                }


                int
                f_10094_16227_16310(Microsoft.CodeAnalysis.CSharp.TypeConversions
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                effectiveBase, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                deducedBase)
                {
                    CheckEffectiveAndDeducedBaseTypes((Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)effectiveBase, deducedBase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16227, 16310);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_16349_16392(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16349, 16392);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_16424_16462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16424, 16462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10094_16508_16538(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 16508, 16538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10094_16573_16600(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 16573, 16600);
                    return return_v;
                }


                int
                f_10094_16494_16631(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16494, 16631);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10094_16827_16854(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 16827, 16854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10094_16931_16961(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 16931, 16961);
                    return return_v;
                }


                int
                f_10094_16918_16991(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 16918, 16991);
                    return 0;
                }


                int
                f_10094_17010_17046(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 17010, 17046);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10094_17121_17210(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                effectiveBaseClass, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                deducedBaseType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds(constraintTypes, interfaces, effectiveBaseClass, deducedBaseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 17121, 17210);
                    return return_v;
                }


                int
                f_10094_17334_17401(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                bounds, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder)
                {
                    CheckOverrideConstraints(typeParameter, bounds, diagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 17334, 17401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 5109, 17458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 5109, 17458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ImmutableArray<TypeWithAnnotations>> MakeTypeParameterConstraintTypes(
                    this MethodSymbol containingSymbol,
                    Binder binder,
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    TypeParameterListSyntax typeParameterList,
                    SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 17470, 19063);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 17914, 18090) || true) && (typeParameters.Length == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10094, 17918, 17976) || constraintClauses.Count == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 17914, 18090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18010, 18075);

                    return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 17914, 18090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18259, 18334);

                f_10094_18259_18333(!f_10094_18273_18332(binder.Flags, BinderFlags.GenericConstraintsClause));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18348, 18461);

                binder = f_10094_18357_18460(binder, BinderFlags.GenericConstraintsClause | BinderFlags.SuppressConstraintChecks);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18477, 18531);

                ImmutableArray<TypeParameterConstraintClause>
                clauses
                = default(ImmutableArray<TypeParameterConstraintClause>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18545, 18786);

                clauses = f_10094_18555_18785(binder, containingSymbol, typeParameters, typeParameterList, constraintClauses, diagnostics, performOnlyCycleSafeValidation: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18802, 18973) || true) && (clauses.All(clause => clause.ConstraintTypes.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 18802, 18973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18893, 18958);

                    return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 18802, 18973);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 18989, 19052);

                return clauses.SelectAsArray(clause => clause.ConstraintTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 17470, 19063);

                bool
                f_10094_18273_18332(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 18273, 18332);
                    return return_v;
                }


                int
                f_10094_18259_18333(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 18259, 18333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10094_18357_18460(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 18357, 18460);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_18555_18785(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                clauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                performOnlyCycleSafeValidation)
                {
                    var return_v = this_param.BindTypeParameterConstraintClauses((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, typeParameters, typeParameterList, clauses, diagnostics, performOnlyCycleSafeValidation: performOnlyCycleSafeValidation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 18555, 18785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 17470, 19063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 17470, 19063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeParameterConstraintKind> MakeTypeParameterConstraintKinds(
                    this MethodSymbol containingSymbol,
                    Binder binder,
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    TypeParameterListSyntax typeParameterList,
                    SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 19075, 21359);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 19471, 19607) || true) && (typeParameters.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 19471, 19607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 19535, 19592);

                    return ImmutableArray<TypeParameterConstraintKind>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 19471, 19607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 19623, 19677);

                ImmutableArray<TypeParameterConstraintClause>
                clauses
                = default(ImmutableArray<TypeParameterConstraintClause>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 19693, 21070) || true) && (constraintClauses.Count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 19693, 21070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 19759, 19836);

                    clauses = f_10094_19769_19835(binder, typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 19693, 21070);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 19693, 21070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20207, 20282);

                    f_10094_20207_20281(!f_10094_20221_20280(binder.Flags, BinderFlags.GenericConstraintsClause));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20300, 20455);

                    binder = f_10094_20309_20454(binder, BinderFlags.GenericConstraintsClause | BinderFlags.SuppressConstraintChecks | BinderFlags.SuppressTypeArgumentBinding);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20475, 20519);

                    var
                    discarded = f_10094_20491_20518()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20661, 20903);

                    clauses = f_10094_20671_20902(binder, containingSymbol, typeParameters, typeParameterList, constraintClauses, discarded, performOnlyCycleSafeValidation: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20921, 20938);

                    f_10094_20921_20937(discarded);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 20958, 21055);

                    clauses = f_10094_20968_21054(containingSymbol, typeParameters, clauses);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 19693, 21070);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21086, 21273) || true) && (clauses.All(clause => clause.Constraints == TypeParameterConstraintKind.None))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 21086, 21273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21201, 21258);

                    return ImmutableArray<TypeParameterConstraintKind>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 21086, 21273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21289, 21348);

                return clauses.SelectAsArray(clause => clause.Constraints);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 19075, 21359);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_19769_19835(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList)
                {
                    var return_v = this_param.GetDefaultTypeParameterConstraintClauses(typeParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 19769, 19835);
                    return return_v;
                }


                bool
                f_10094_20221_20280(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20221, 20280);
                    return return_v;
                }


                int
                f_10094_20207_20281(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20207, 20281);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10094_20309_20454(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20309, 20454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10094_20491_20518()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20491, 20518);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_20671_20902(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                typeParameterList, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterConstraintClauseSyntax>
                clauses, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                performOnlyCycleSafeValidation)
                {
                    var return_v = this_param.BindTypeParameterConstraintClauses((Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, typeParameters, typeParameterList, clauses, diagnostics, performOnlyCycleSafeValidation: performOnlyCycleSafeValidation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20671, 20902);
                    return return_v;
                }


                int
                f_10094_20921_20937(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20921, 20937);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_20968_21054(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses)
                {
                    var return_v = AdjustConstraintKindsBasedOnConstraintTypes((Microsoft.CodeAnalysis.CSharp.Symbol)container, typeParameters, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 20968, 21054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 19075, 21359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 19075, 21359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeParameterConstraintClause> AdjustConstraintKindsBasedOnConstraintTypes(Symbol container, ImmutableArray<TypeParameterSymbol> typeParameters, ImmutableArray<TypeParameterConstraintClause> constraintClauses)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 21371, 23802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21636, 21670);

                int
                arity = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21686, 21734);

                f_10094_21686_21733(constraintClauses.Length == arity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21750, 21906);

                SmallDictionary<TypeParameterSymbol, bool>
                isValueTypeMap = f_10094_21810_21905(container, typeParameters, constraintClauses)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 21920, 22122);

                SmallDictionary<TypeParameterSymbol, bool>
                isReferenceTypeFromConstraintTypesMap = f_10094_22003_22121(container, typeParameters, constraintClauses)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22136, 22195);

                ArrayBuilder<TypeParameterConstraintClause>
                builder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22220, 22225);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22211, 23617) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22238, 22241)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 22211, 23617))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 22211, 23617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22275, 22313);

                        var
                        constraint = constraintClauses[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22331, 22369);

                        var
                        typeParameter = typeParameters[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22387, 22455);

                        TypeParameterConstraintKind
                        constraintKind = constraint.Constraints
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22475, 22635);

                        f_10094_22475_22634((constraintKind & (TypeParameterConstraintKind.ValueTypeFromConstraintTypes | TypeParameterConstraintKind.ReferenceTypeFromConstraintTypes)) == 0);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22655, 22897) || true) && ((constraintKind & TypeParameterConstraintKind.AllValueTypeKinds) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10094, 22659, 22761) && f_10094_22732_22761(isValueTypeMap, typeParameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 22655, 22897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22803, 22878);

                            constraintKind |= TypeParameterConstraintKind.ValueTypeFromConstraintTypes;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 22655, 22897);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 22917, 23113) || true) && (f_10094_22921_22973(isReferenceTypeFromConstraintTypesMap, typeParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 22917, 23113);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23015, 23094);

                            constraintKind |= TypeParameterConstraintKind.ReferenceTypeFromConstraintTypes;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 22917, 23113);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23133, 23602) || true) && (constraint.Constraints != constraintKind)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 23133, 23602);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23219, 23465) || true) && (builder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 23219, 23465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23288, 23380);

                                builder = f_10094_23298_23379(constraintClauses.Length);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23406, 23442);

                                f_10094_23406_23441(builder, constraintClauses);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 23219, 23465);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23489, 23583);

                            builder[i] = f_10094_23502_23582(constraintKind, constraint.ConstraintTypes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 23133, 23602);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 1407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 1407);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23633, 23750) || true) && (builder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 23633, 23750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23686, 23735);

                    constraintClauses = f_10094_23706_23734(builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 23633, 23750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 23766, 23791);

                return constraintClauses;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 21371, 23802);

                int
                f_10094_21686_21733(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 21686, 21733);
                    return 0;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                f_10094_21810_21905(Microsoft.CodeAnalysis.CSharp.Symbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses)
                {
                    var return_v = TypeParameterConstraintClause.BuildIsValueTypeMap(container, typeParameters, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 21810, 21905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                f_10094_22003_22121(Microsoft.CodeAnalysis.CSharp.Symbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                constraintClauses)
                {
                    var return_v = TypeParameterConstraintClause.BuildIsReferenceTypeFromConstraintTypesMap(container, typeParameters, constraintClauses);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 22003, 22121);
                    return return_v;
                }


                int
                f_10094_22475_22634(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 22475, 22634);
                    return 0;
                }


                bool
                f_10094_22732_22761(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 22732, 22761);
                    return return_v;
                }


                bool
                f_10094_22921_22973(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 22921, 22973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_23298_23379(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeParameterConstraintClause>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 23298, 23379);
                    return return_v;
                }


                int
                f_10094_23406_23441(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 23406, 23441);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause
                f_10094_23502_23582(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                constraints, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterConstraintClause.Create(constraints, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 23502, 23582);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                f_10094_23706_23734(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintClause>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 23706, 23734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 21371, 23802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 21371, 23802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckOverrideConstraints(
                    TypeParameterSymbol typeParameter,
                    TypeParameterBounds bounds,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 23873, 24941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24107, 24148);

                var
                deducedBase = bounds.DeducedBaseType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24162, 24207);

                var
                constraintTypes = bounds.ConstraintTypes
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24223, 24930) || true) && (f_10094_24227_24270(typeParameter, constraintTypes) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 24227, 24321) && f_10094_24274_24321(typeParameter, constraintTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 24223, 24930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24355, 24438);

                    f_10094_24355_24437(f_10094_24368_24392_M(!deducedBase.IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 24368, 24436) || f_10094_24396_24436(typeParameter)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24456, 24584);

                    f_10094_24456_24583(diagnosticsBuilder, f_10094_24479_24582(typeParameter, deducedBase, classConflict: f_10094_24558_24581(deducedBase)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 24223, 24930);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 24223, 24930);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24618, 24930) || true) && (f_10094_24622_24650(deducedBase) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 24622, 24736) && (f_10094_24655_24691(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 24655, 24735) || f_10094_24695_24735(typeParameter)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 24618, 24930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 24770, 24915);

                        f_10094_24770_24914(diagnosticsBuilder, f_10094_24793_24913(typeParameter, deducedBase, classConflict: f_10094_24872_24912(typeParameter)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 24618, 24930);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 24223, 24930);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 23873, 24941);

                bool
                f_10094_24227_24270(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = IsValueType(typeParameter, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24227, 24270);
                    return return_v;
                }


                bool
                f_10094_24274_24321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = IsReferenceType(typeParameter, constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24274, 24321);
                    return return_v;
                }


                bool
                f_10094_24368_24392_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24368, 24392);
                    return return_v;
                }


                bool
                f_10094_24396_24436(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24396, 24436);
                    return return_v;
                }


                int
                f_10094_24355_24437(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24355, 24437);
                    return 0;
                }


                bool
                f_10094_24558_24581(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24558, 24581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_24479_24582(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                deducedBase, bool
                classConflict)
                {
                    var return_v = GenerateConflictingConstraintsError(typeParameter, deducedBase, classConflict: classConflict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24479, 24582);
                    return return_v;
                }


                int
                f_10094_24456_24583(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24456, 24583);
                    return 0;
                }


                bool
                f_10094_24622_24650(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24622, 24650);
                    return return_v;
                }


                bool
                f_10094_24655_24691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24655, 24691);
                    return return_v;
                }


                bool
                f_10094_24695_24735(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24695, 24735);
                    return return_v;
                }


                bool
                f_10094_24872_24912(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 24872, 24912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_24793_24913(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                deducedBase, bool
                classConflict)
                {
                    var return_v = GenerateConflictingConstraintsError(typeParameter, deducedBase, classConflict: classConflict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24793, 24913);
                    return return_v;
                }


                int
                f_10094_24770_24914(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 24770, 24914);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 23873, 24941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 23873, 24941);
            }
        }

        public static void CheckAllConstraints(
                    this TypeSymbol type,
                    CSharpCompilation compilation,
                    ConversionsBase conversions,
                    Location location,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 25274, 25776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 25531, 25631);

                bool
                includeNullability = f_10094_25557_25630(compilation, MessageID.IDS_FeatureNullableReferenceTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 25645, 25765);

                type.CheckAllConstraints(f_10094_25670_25763(compilation, conversions, includeNullability, location, diagnostics));

                DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 25645, 25764);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 25274, 25776);

                bool
                f_10094_25557_25630(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 25557, 25630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                f_10094_25670_25763(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, bool
                includeNullability, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs(currentCompilation, conversions, includeNullability, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 25670, 25763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 25274, 25776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 25274, 25776);
            }
        }

        public static bool CheckAllConstraints(
                    this TypeSymbol type,
                    CSharpCompilation compilation,
                    ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 25788, 26438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 25973, 26019);

                var
                diagnostics = f_10094_25991_26018()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 26179, 26318);

                type.CheckAllConstraints(f_10094_26204_26316(compilation, conversions, includeNullability: false, NoLocation.Singleton, diagnostics));

                DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 26179, 26317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 26332, 26370);

                bool
                ok = !f_10094_26343_26369(diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 26384, 26403);

                f_10094_26384_26402(diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 26417, 26427);

                return ok;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 25788, 26438);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10094_25991_26018()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 25991, 26018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                f_10094_26204_26316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, bool
                includeNullability, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs(currentCompilation, conversions, includeNullability: includeNullability, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 26204, 26316);
                    return return_v;
                }


                bool
                f_10094_26343_26369(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 26343, 26369);
                    return return_v;
                }


                int
                f_10094_26384_26402(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 26384, 26402);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 25788, 26438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 25788, 26438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void CheckAllConstraints(this TypeSymbol type, CheckConstraintsArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 26450, 26628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 26562, 26617);

                f_10094_26562_26616(type, s_checkConstraintsSingleTypeFunc, args);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 26450, 26628);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10094_26562_26616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs, bool, bool>
                predicate, Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs
                arg)
                {
                    var return_v = type.VisitType<Microsoft.CodeAnalysis.CSharp.Symbols.ConstraintsHelper.CheckConstraintsArgs>(predicate, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 26562, 26616);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 26450, 26628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 26450, 26628);
            }
        }

        internal readonly struct CheckConstraintsArgs
        {

            public readonly CSharpCompilation CurrentCompilation;

            public readonly ConversionsBase Conversions;

            public readonly bool IncludeNullability;

            public readonly Location Location;

            public readonly DiagnosticBag Diagnostics;

            public CheckConstraintsArgs(CSharpCompilation currentCompilation, ConversionsBase conversions, Location location, DiagnosticBag diagnostics) : this(f_10094_27160_27178_C(currentCompilation), conversions, f_10094_27193_27273(currentCompilation, MessageID.IDS_FeatureNullableReferenceTypes), location, diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10094, 26995, 27327);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10094, 26995, 27327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 26995, 27327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 26995, 27327);
                }
            }

            public CheckConstraintsArgs(CSharpCompilation currentCompilation, ConversionsBase conversions, bool includeNullability, Location location, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10094, 27343, 27805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27541, 27586);

                    this.CurrentCompilation = currentCompilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27604, 27635);

                    this.Conversions = conversions;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27653, 27698);

                    this.IncludeNullability = includeNullability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27716, 27741);

                    this.Location = location;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27759, 27790);

                    this.Diagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10094, 27343, 27805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 27343, 27805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 27343, 27805);
                }
            }
            static CheckConstraintsArgs()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10094, 26640, 27816);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10094, 26640, 27816);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 26640, 27816);
            }

            static bool
            f_10094_27193_27273(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation, Microsoft.CodeAnalysis.CSharp.MessageID
            feature)
            {
                var return_v = compilation.IsFeatureEnabled(feature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 27193, 27273);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10094_27160_27178_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10094, 26995, 27327);
                return return_v;
            }

        }

        private static readonly Func<TypeSymbol, CheckConstraintsArgs, bool, bool> s_checkConstraintsSingleTypeFunc;

        private static bool CheckConstraintsSingleType(TypeSymbol type, in CheckConstraintsArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 28011, 28556);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28129, 28492) || true) && (f_10094_28133_28142(type) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 28129, 28492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28200, 28247);

                    ((NamedTypeSymbol)type).CheckConstraints(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 28200, 28246);

                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 28129, 28492);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 28129, 28492);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28281, 28492) || true) && (f_10094_28285_28294(type) == SymbolKind.PointerType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 28281, 28492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28354, 28477);

                        f_10094_28354_28476(args.CurrentCompilation, f_10094_28403_28442(((PointerTypeSymbol)type)), args.Location, args.Diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 28281, 28492);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 28129, 28492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28506, 28519);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 28011, 28556);

                Microsoft.CodeAnalysis.SymbolKind
                f_10094_28133_28142(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 28133, 28142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10094_28285_28294(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 28285, 28294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10094_28403_28442(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 28403, 28442);
                    return return_v;
                }


                bool
                f_10094_28354_28476(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.CheckManagedAddr(compilation, type, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 28354, 28476);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 28011, 28556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 28011, 28556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void CheckConstraints(
                    this NamedTypeSymbol tuple,
                    ConversionsBase conversions,
                    SyntaxNode typeSyntax,
                    ImmutableArray<Location> elementLocations,
                    CSharpCompilation currentCompilation,
                    DiagnosticBag diagnosticsOpt,
                    DiagnosticBag nullabilityDiagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 28568, 31666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28952, 28984);

                f_10094_28952_28983(f_10094_28965_28982(tuple));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 28998, 29082) || true) && (!f_10094_29003_29026(tuple))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 28998, 29082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29060, 29067);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 28998, 29082);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29098, 29178) || true) && (f_10094_29102_29122(typeSyntax))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 29098, 29178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29156, 29163);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 29098, 29178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29194, 29275);

                var
                diagnosticsBuilder = f_10094_29219_29274()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29289, 29381);

                var
                nullabilityDiagnosticsBuilder = f_10094_29325_29380()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29395, 29470);

                var
                underlyingTupleTypeChain = f_10094_29426_29469()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29484, 29556);

                f_10094_29484_29555(tuple, underlyingTupleTypeChain);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29572, 29587);

                int
                offset = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29601, 31516);
                    foreach (var underlyingTuple in f_10094_29633_29657_I(underlyingTupleTypeChain))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 29601, 31516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29691, 29766);

                        ArrayBuilder<TypeParameterDiagnosticInfo>
                        useSiteDiagnosticsBuilder = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 29784, 30143);

                        f_10094_29784_30142(underlyingTuple, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 30015, 30050) || (((nullabilityDiagnosticsOpt is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 30053, 30057)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 30060, 30089))) ? null : nullabilityDiagnosticsBuilder, ref useSiteDiagnosticsBuilder);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30163, 30316) || true) && (useSiteDiagnosticsBuilder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 30163, 30316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30242, 30297);

                            f_10094_30242_30296(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 30163, 30316);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30336, 30400);

                        f_10094_30336_30399(diagnosticsBuilder, diagnosticsOpt);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30418, 30504);

                        f_10094_30418_30503(nullabilityDiagnosticsBuilder, nullabilityDiagnosticsOpt);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30524, 30570);

                        offset += NamedTypeSymbol.ValueTupleRestIndex;

                        int
                f_10094_30336_30399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                builder, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                        {
                            populateDiagnosticsAndClear(builder, bag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 30336, 30399);
                            return 0;
                        }


                        int
                        f_10094_30418_30503(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                        builder, Microsoft.CodeAnalysis.DiagnosticBag?
                        bag)
                        {
                            populateDiagnosticsAndClear(builder, bag);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 30418, 30503);
                            return 0;
                        }

                        void populateDiagnosticsAndClear(ArrayBuilder<TypeParameterDiagnosticInfo> builder, DiagnosticBag bag)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10094, 30590, 31501);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30733, 30870) || true) && (bag is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 30733, 30870);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30798, 30814);

                                    f_10094_30798_30813(builder);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30840, 30847);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 30733, 30870);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30894, 31442);
                                    foreach (var pair in f_10094_30915_30922_I(builder))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 30894, 31442);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 30972, 31013);

                                        var
                                        ordinal = f_10094_30986_31012(pair.TypeParameter)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31215, 31336);

                                        var
                                        location = (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 31230, 31276) || ((ordinal == NamedTypeSymbol.ValueTupleRestIndex && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 31279, 31298)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 31301, 31335))) ? f_10094_31279_31298(typeSyntax) : elementLocations[ordinal + offset]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31362, 31419);

                                        f_10094_31362_31418(bag, f_10094_31370_31417(pair.DiagnosticInfo, location));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 30894, 31442);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 549);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 549);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31466, 31482);

                                f_10094_31466_31481(
                                                    builder);
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10094, 30590, 31501);

                                int
                                f_10094_30798_30813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                                this_param)
                                {
                                    this_param.Clear();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 30798, 30813);
                                    return 0;
                                }


                                int
                                f_10094_30986_31012(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                                this_param)
                                {
                                    var return_v = this_param.Ordinal;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 30986, 31012);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.Location
                                f_10094_31279_31298(Microsoft.CodeAnalysis.SyntaxNode
                                this_param)
                                {
                                    var return_v = this_param.Location;
                                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 31279, 31298);
                                    return return_v;
                                }


                                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                                f_10094_31370_31417(Microsoft.CodeAnalysis.DiagnosticInfo
                                info, Microsoft.CodeAnalysis.Location
                                location)
                                {
                                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31370, 31417);
                                    return return_v;
                                }


                                int
                                f_10094_31362_31418(Microsoft.CodeAnalysis.DiagnosticBag
                                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                                diag)
                                {
                                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31362, 31418);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                                f_10094_30915_30922_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                                i)
                                {
                                    var return_v = i;
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 30915, 30922);
                                    return return_v;
                                }


                                int
                                f_10094_31466_31481(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                                this_param)
                                {
                                    this_param.Clear();
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31466, 31481);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 30590, 31501);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 30590, 31501);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 29601, 31516);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 1916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 1916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31532, 31564);

                f_10094_31532_31563(
                            underlyingTupleTypeChain);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31578, 31604);

                f_10094_31578_31603(diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 31618, 31655);

                f_10094_31618_31654(nullabilityDiagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 28568, 31666);

                bool
                f_10094_28965_28982(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 28965, 28982);
                    return return_v;
                }


                int
                f_10094_28952_28983(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 28952, 28983);
                    return 0;
                }


                bool
                f_10094_29003_29026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = RequiresChecking(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29003, 29026);
                    return return_v;
                }


                bool
                f_10094_29102_29122(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 29102, 29122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_29219_29274()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29219, 29274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_29325_29380()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29325, 29380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_29426_29469()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29426, 29469);
                    return return_v;
                }


                int
                f_10094_29484_29555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingTupleType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                underlyingTupleTypeChain)
                {
                    NamedTypeSymbol.GetUnderlyingTypeChain(underlyingTupleType, underlyingTupleTypeChain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29484, 29555);
                    return 0;
                }


                bool
                f_10094_29784_30142(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = CheckTypeConstraints(type, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29784, 30142);
                    return return_v;
                }


                int
                f_10094_30242_30296(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 30242, 30296);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_29633_29657_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 29633, 29657);
                    return return_v;
                }


                int
                f_10094_31532_31563(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31532, 31563);
                    return 0;
                }


                int
                f_10094_31578_31603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31578, 31603);
                    return 0;
                }


                int
                f_10094_31618_31654(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 31618, 31654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 28568, 31666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 28568, 31666);
            }
        }

        public static bool CheckConstraintsForNamedType(
                    this NamedTypeSymbol type,
                    ConversionsBase conversions,
                    bool includeNullability,
                    SyntaxNode typeSyntax,
                    SeparatedSyntaxList<TypeSyntax> typeArgumentsSyntax, // may be omitted in synthesized invocations
                    CSharpCompilation currentCompilation,
                    ConsList<TypeSymbol> basesBeingResolved,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 31678, 33617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32163, 32263);

                f_10094_32163_32262(typeArgumentsSyntax.Count == 0 /*omitted*/ || (DynAbs.Tracing.TraceSender.Expression_False(10094, 32176, 32261) || typeArgumentsSyntax.Count == f_10094_32251_32261(type)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32279, 32367) || true) && (!f_10094_32284_32306(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 32279, 32367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32340, 32352);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 32279, 32367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32383, 32464);

                var
                diagnosticsBuilder = f_10094_32408_32463()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32478, 32553);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32567, 32798);

                var
                result = f_10094_32580_32601_M(!typeSyntax.HasErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 32580, 32797) && f_10094_32605_32797(type, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 32719, 32737) || ((includeNullability && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 32740, 32758)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 32761, 32765))) ? diagnosticsBuilder : null, ref useSiteDiagnosticsBuilder))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32814, 32955) || true) && (useSiteDiagnosticsBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 32814, 32955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32885, 32940);

                    f_10094_32885_32939(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 32814, 32955);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 32971, 33316);
                    foreach (var pair in f_10094_32992_33010_I(diagnosticsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 32971, 33316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33044, 33085);

                        int
                        ordinal = f_10094_33058_33084(pair.TypeParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33103, 33218);

                        var
                        location = f_10094_33118_33217((DynAbs.Tracing.TraceSender.Conditional_F1(10094, 33137, 33172) || ((ordinal < typeArgumentsSyntax.Count && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 33175, 33203)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 33206, 33216))) ? typeArgumentsSyntax[ordinal] : typeSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33236, 33301);

                        f_10094_33236_33300(diagnostics, f_10094_33252_33299(pair.DiagnosticInfo, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 32971, 33316);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33332, 33358);

                f_10094_33332_33357(
                            diagnosticsBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33374, 33576) || true) && (f_10094_33378_33426(type, basesBeingResolved))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 33374, 33576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33460, 33475);

                    result = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33493, 33561);

                    f_10094_33493_33560(diagnostics, ErrorCode.ERR_BogusType, f_10094_33534_33553(typeSyntax), type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 33374, 33576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33592, 33606);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 31678, 33617);

                int
                f_10094_32251_32261(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 32251, 32261);
                    return return_v;
                }


                int
                f_10094_32163_32262(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32163, 32262);
                    return 0;
                }


                bool
                f_10094_32284_32306(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = RequiresChecking(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32284, 32306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_32408_32463()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32408, 32463);
                    return return_v;
                }


                bool
                f_10094_32580_32601_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 32580, 32601);
                    return return_v;
                }


                bool
                f_10094_32605_32797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = CheckTypeConstraints(type, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32605, 32797);
                    return return_v;
                }


                int
                f_10094_32885_32939(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32885, 32939);
                    return 0;
                }


                int
                f_10094_33058_33084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 33058, 33084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10094_33118_33217(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33118, 33217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10094_33252_33299(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33252, 33299);
                    return return_v;
                }


                int
                f_10094_33236_33300(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33236, 33300);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_32992_33010_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 32992, 33010);
                    return return_v;
                }


                int
                f_10094_33332_33357(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33332, 33357);
                    return 0;
                }


                bool
                f_10094_33378_33426(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = HasDuplicateInterfaces(type, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33378, 33426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10094_33534_33553(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 33534, 33553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_33493_33560(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33493, 33560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 31678, 33617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 31678, 33617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckConstraints(this NamedTypeSymbol type, in CheckConstraintsArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 33629, 35287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33746, 33794);

                f_10094_33746_33793(args.CurrentCompilation is object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33810, 33898) || true) && (!f_10094_33815_33837(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 33810, 33898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33871, 33883);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 33810, 33898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 33914, 33995);

                var
                diagnosticsBuilder = f_10094_33939_33994()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34009, 34084);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34098, 34319);

                var
                result = f_10094_34111_34318(type, args.Conversions, args.CurrentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 34235, 34258) || ((args.IncludeNullability && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 34261, 34279)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 34282, 34286))) ? diagnosticsBuilder : null, ref useSiteDiagnosticsBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34335, 34476) || true) && (useSiteDiagnosticsBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 34335, 34476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34406, 34461);

                    f_10094_34406_34460(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 34335, 34476);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34492, 34655);
                    foreach (var pair in f_10094_34513_34531_I(diagnosticsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 34492, 34655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34565, 34640);

                        f_10094_34565_34639(args.Diagnostics, f_10094_34586_34638(pair.DiagnosticInfo, args.Location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 34492, 34655);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34671, 34697);

                f_10094_34671_34696(
                            diagnosticsBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 34970, 35246) || true) && (!(args.CurrentCompilation != null && (DynAbs.Tracing.TraceSender.Expression_True(10094, 34976, 35058) && f_10094_35011_35058(type, args.CurrentCompilation))) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 34974, 35097) && f_10094_35063_35097(type, null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 34970, 35246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 35131, 35146);

                    result = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 35164, 35231);

                    f_10094_35164_35230(args.Diagnostics, ErrorCode.ERR_BogusType, args.Location, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 34970, 35246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 35262, 35276);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 33629, 35287);

                int
                f_10094_33746_33793(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33746, 33793);
                    return 0;
                }


                bool
                f_10094_33815_33837(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = RequiresChecking(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33815, 33837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_33939_33994()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 33939, 33994);
                    return return_v;
                }


                bool
                f_10094_34111_34318(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = CheckTypeConstraints(type, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34111, 34318);
                    return return_v;
                }


                int
                f_10094_34406_34460(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34406, 34460);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10094_34586_34638(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34586, 34638);
                    return return_v;
                }


                int
                f_10094_34565_34639(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34565, 34639);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_34513_34531_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34513, 34531);
                    return return_v;
                }


                int
                f_10094_34671_34696(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 34671, 34696);
                    return 0;
                }


                bool
                f_10094_35011_35058(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 35011, 35058);
                    return return_v;
                }


                bool
                f_10094_35063_35097(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = HasDuplicateInterfaces(type, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 35063, 35097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_35164_35230(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 35164, 35230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 33629, 35287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 33629, 35287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasDuplicateInterfaces(NamedTypeSymbol type, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 35587, 37313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 35905, 35992);

                var
                array = f_10094_35917_35991(f_10094_35917_35940(type), basesBeingResolved)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36008, 36999);

                switch (array.Length)
                {

                    case 0:
                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36008, 36999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36163, 36176);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36008, 36999);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36008, 36999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36225, 36374) || true) && ((object)f_10094_36237_36264(array[0]) == f_10094_36268_36295(array[1]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36225, 36374);
                            DynAbs.Tracing.TraceSender.TraceBreak(10094, 36345, 36351);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36225, 36374);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36448, 36461);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36008, 36999);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36008, 36999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36511, 36557);

                        var
                        set = f_10094_36521_36556()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36579, 36861);
                            foreach (var i in f_10094_36597_36602_I(array))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36579, 36861);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36652, 36838) || true) && (!f_10094_36657_36686(set, f_10094_36665_36685(i)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 36652, 36838);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36744, 36755);

                                    f_10094_36744_36754(set);

                                    goto hasRelatedInterfaces;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36652, 36838);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36579, 36861);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 283);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 283);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36938, 36949);

                        f_10094_36938_36948(
                                            // all interfaces are unrelated
                                            set);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 36971, 36984);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 36008, 36999);
                }

// very rare case. 
// some implemented interfaces are related
// will have to instantiate interfaces and check
hasRelatedInterfaces:
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37153, 37302);

                return f_10094_37160_37215(type, basesBeingResolved).HasDuplicates(Symbols.SymbolEqualityComparer.IgnoringDynamicTupleNamesAndNullability);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 35587, 37313);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_35917_35940(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 35917, 35940);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_35917_35991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 35917, 35991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_36237_36264(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 36237, 36264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_36268_36295(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 36268, 36295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<object>
                f_10094_36521_36556()
                {
                    var return_v = PooledHashSet<object>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 36521, 36556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_36665_36685(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 36665, 36685);
                    return return_v;
                }


                bool
                f_10094_36657_36686(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 36657, 36686);
                    return return_v;
                }


                int
                f_10094_36744_36754(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<object>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 36744, 36754);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_36597_36602_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 36597, 36602);
                    return return_v;
                }


                int
                f_10094_36938_36948(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<object>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 36938, 36948);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_37160_37215(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 37160, 37215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 35587, 37313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 35587, 37313);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckConstraints(
                    this MethodSymbol method,
                    ConversionsBase conversions,
                    SyntaxNode syntaxNode,
                    CSharpCompilation currentCompilation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 37325, 38523);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37594, 37684) || true) && (!f_10094_37599_37623(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 37594, 37684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37657, 37669);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 37594, 37684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37700, 37781);

                var
                diagnosticsBuilder = f_10094_37725_37780()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37795, 37870);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 37884, 38052);

                var
                result = f_10094_37897_38051(method, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: null, ref useSiteDiagnosticsBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38068, 38209) || true) && (useSiteDiagnosticsBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 38068, 38209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38139, 38194);

                    f_10094_38139_38193(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 38068, 38209);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38225, 38442);
                    foreach (var pair in f_10094_38246_38264_I(diagnosticsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 38225, 38442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38298, 38344);

                        var
                        location = f_10094_38313_38343(syntaxNode)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38362, 38427);

                        f_10094_38362_38426(diagnostics, f_10094_38378_38425(pair.DiagnosticInfo, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 38225, 38442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38458, 38484);

                f_10094_38458_38483(
                            diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38498, 38512);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 37325, 38523);

                bool
                f_10094_37599_37623(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = RequiresChecking(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 37599, 37623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_37725_37780()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 37725, 37780);
                    return return_v;
                }


                bool
                f_10094_37897_38051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = CheckMethodConstraints(method, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 37897, 38051);
                    return return_v;
                }


                int
                f_10094_38139_38193(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38139, 38193);
                    return 0;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10094_38313_38343(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38313, 38343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10094_38378_38425(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38378, 38425);
                    return return_v;
                }


                int
                f_10094_38362_38426(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38362, 38426);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_38246_38264_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38246, 38264);
                    return return_v;
                }


                int
                f_10094_38458_38483(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38458, 38483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 37325, 38523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 37325, 38523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckConstraints(
                    this MethodSymbol method,
                    ConversionsBase conversions,
                    Location location,
                    CSharpCompilation currentCompilation,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 38535, 39665);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38800, 38890) || true) && (!f_10094_38805_38829(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 38800, 38890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38863, 38875);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 38800, 38890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 38906, 38987);

                var
                diagnosticsBuilder = f_10094_38931_38986()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39001, 39076);

                ArrayBuilder<TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39090, 39258);

                var
                result = f_10094_39103_39257(method, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: null, ref useSiteDiagnosticsBuilder)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39274, 39415) || true) && (useSiteDiagnosticsBuilder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 39274, 39415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39345, 39400);

                    f_10094_39345_39399(diagnosticsBuilder, useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 39274, 39415);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39431, 39584);
                    foreach (var pair in f_10094_39452_39470_I(diagnosticsBuilder))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 39431, 39584);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39504, 39569);

                        f_10094_39504_39568(diagnostics, f_10094_39520_39567(pair.DiagnosticInfo, location));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 39431, 39584);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39600, 39626);

                f_10094_39600_39625(
                            diagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 39640, 39654);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 38535, 39665);

                bool
                f_10094_38805_38829(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = RequiresChecking(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38805, 38829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_38931_38986()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 38931, 38986);
                    return return_v;
                }


                bool
                f_10094_39103_39257(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = CheckMethodConstraints(method, conversions, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt: nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39103, 39257);
                    return return_v;
                }


                int
                f_10094_39345_39399(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39345, 39399);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10094_39520_39567(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39520, 39567);
                    return return_v;
                }


                int
                f_10094_39504_39568(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39504, 39568);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_39452_39470_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39452, 39470);
                    return return_v;
                }


                int
                f_10094_39600_39625(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 39600, 39625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 38535, 39665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 38535, 39665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckTypeConstraints(
                    NamedTypeSymbol type,
                    ConversionsBase conversions,
                    CSharpCompilation currentCompilation,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                    ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 39677, 40552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 40121, 40541);

                return f_10094_40128_40540(type, conversions, f_10094_40216_40237(type), f_10094_40256_40294(f_10094_40256_40279(type)), f_10094_40313_40366(type), currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 39677, 40552);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10094_40216_40237(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 40216, 40237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_40256_40279(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 40256, 40279);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10094_40256_40294(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 40256, 40294);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_40313_40366(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 40313, 40366);
                    return return_v;
                }


                bool
                f_10094_40128_40540(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                substitution, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder)
                {
                    var return_v = containingSymbol.CheckConstraints(conversions, substitution, typeParameters, typeArguments, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 40128, 40540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 39677, 40552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 39677, 40552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckMethodConstraints(
                    MethodSymbol method,
                    ConversionsBase conversions,
                    CSharpCompilation currentCompilation,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                    ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder,
                    BitVector skipParameters = default(BitVector))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 40564, 41536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 41068, 41525);

                return f_10094_41075_41524(method, conversions, f_10094_41165_41188(method), f_10094_41207_41263(((MethodSymbol)f_10094_41222_41247(method))), f_10094_41282_41317(method), currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder, skipParameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 40564, 41536);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10094_41165_41188(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 41165, 41188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10094_41222_41247(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 41222, 41247);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10094_41207_41263(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 41207, 41263);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_41282_41317(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 41282, 41317);
                    return return_v;
                }


                bool
                f_10094_41075_41524(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                substitution, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder, Microsoft.CodeAnalysis.BitVector
                skipParameters)
                {
                    var return_v = containingSymbol.CheckConstraints(conversions, substitution, typeParameters, typeArguments, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder, skipParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 41075, 41524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 40564, 41536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 40564, 41536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CheckConstraints(
                    this Symbol containingSymbol,
                    ConversionsBase conversions,
                    TypeMap substitution,
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    ImmutableArray<TypeWithAnnotations> typeArguments,
                    CSharpCompilation currentCompilation,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                    ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder,
                    BitVector skipParameters = default(BitVector),
                    HashSet<TypeParameterSymbol> ignoreTypeConstraintsDependentOnTypeParametersOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 42827, 44627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43598, 43658);

                f_10094_43598_43657(typeParameters.Length == typeArguments.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43672, 43712);

                f_10094_43672_43711(typeParameters.Length > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43726, 43818);

                f_10094_43726_43817(!conversions.IncludeNullability || (DynAbs.Tracing.TraceSender.Expression_False(10094, 43739, 43816) || (nullabilityDiagnosticsBuilderOpt != null)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43834, 43864);

                int
                n = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43878, 43900);

                bool
                succeeded = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43925, 43930);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43916, 44583) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43939, 43942)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 43916, 44583))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 43916, 44583);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 43976, 44067) || true) && (skipParameters[i])
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 43976, 44067);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44039, 44048);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 43976, 44067);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44087, 44123);

                        var
                        typeArgument = typeArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44141, 44179);

                        var
                        typeParameter = typeParameters[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44199, 44568) || true) && (!f_10094_44204_44489(containingSymbol, conversions, substitution, typeParameter, typeArgument, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder, ignoreTypeConstraintsDependentOnTypeParametersOpt))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 44199, 44568);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44531, 44549);

                            succeeded = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 44199, 44568);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 44599, 44616);

                return succeeded;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 42827, 44627);

                int
                f_10094_43598_43657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 43598, 43657);
                    return 0;
                }


                int
                f_10094_43672_43711(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 43672, 43711);
                    return 0;
                }


                int
                f_10094_43726_43817(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 43726, 43817);
                    return 0;
                }


                bool
                f_10094_44204_44489(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                substitution, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArgument, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                ignoreTypeConstraintsDependentOnTypeParametersOpt)
                {
                    var return_v = CheckConstraints(containingSymbol, conversions, substitution, typeParameter, typeArgument, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnosticsBuilder, ignoreTypeConstraintsDependentOnTypeParametersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 44204, 44489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 42827, 44627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 42827, 44627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CheckConstraints(
                    Symbol containingSymbol,
                    ConversionsBase conversions,
                    TypeMap substitution,
                    TypeParameterSymbol typeParameter,
                    TypeWithAnnotations typeArgument,
                    CSharpCompilation currentCompilation,
                    ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                    ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder,
                    HashSet<TypeParameterSymbol> ignoreTypeConstraintsDependentOnTypeParametersOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 44688, 59353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45354, 45389);

                f_10094_45354_45388(substitution != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45517, 45616);

                f_10094_45517_45615(f_10094_45530_45614(f_10094_45546_45576(typeParameter), f_10094_45578_45613(containingSymbol)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45632, 45728) || true) && (f_10094_45636_45667(typeArgument.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 45632, 45728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45701, 45713);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 45632, 45728);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45744, 46153) || true) && (f_10094_45748_45794(typeArgument.Type) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 45748, 45829) || typeArgument.IsRestrictedType()) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 45748, 45858) || typeArgument.IsVoidType()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 45744, 46153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 45964, 46107);

                    f_10094_45964_46106(                // "The type '{0}' may not be used as a type argument"
                                    diagnosticsBuilder, f_10094_45987_46105(typeParameter, f_10094_46034_46104(ErrorCode.ERR_BadTypeArgument, typeArgument.Type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46125, 46138);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 45744, 46153);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46169, 46500) || true) && (typeArgument.IsStatic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 46169, 46500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46303, 46454);

                    f_10094_46303_46453(                // "'{0}': static types cannot be used as type arguments"
                                    diagnosticsBuilder, f_10094_46326_46452(typeParameter, f_10094_46373_46451(ErrorCode.ERR_GenericArgIsStaticClass, typeArgument.Type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46472, 46485);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 46169, 46500);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46516, 47087) || true) && (f_10094_46520_46560(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 46516, 47087);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46594, 47072) || true) && (f_10094_46598_46632_M(!typeArgument.Type.IsReferenceType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 46594, 47072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 46814, 47018);

                        f_10094_46814_47017(                    // "The type '{2}' must be a reference type in order to use it as parameter '{1}' in the generic type or method '{0}'"
                                            diagnosticsBuilder, f_10094_46837_47016(typeParameter, f_10094_46884_47015(ErrorCode.ERR_RefConstraintNotSatisfied, f_10094_46946_46980(containingSymbol), typeParameter, typeArgument.Type)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47040, 47053);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 46594, 47072);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 46516, 47087);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47103, 47201);

                f_10094_47103_47200(containingSymbol, typeParameter, typeArgument, nullabilityDiagnosticsBuilderOpt);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47217, 49374) || true) && (f_10094_47221_47261(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 47217, 49374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47295, 47356);

                    HashSet<DiagnosticInfo>
                    managedKindUseSiteDiagnostics = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47374, 47460);

                    var
                    managedKind = f_10094_47392_47459(typeArgument.Type, ref managedKindUseSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47478, 47580);

                    f_10094_47478_47579(managedKindUseSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47600, 49359) || true) && (managedKind == ManagedKind.Managed || (DynAbs.Tracing.TraceSender.Expression_False(10094, 47604, 47685) || !f_10094_47643_47685(typeArgument.Type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 47600, 49359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 47924, 48134);

                        f_10094_47924_48133(                    // "The type '{2}' must be a non-nullable value type, along with all fields at any level of nesting, in order to use it as parameter '{1}' in the generic type or method '{0}'"
                                            diagnosticsBuilder, f_10094_47947_48132(typeParameter, f_10094_47994_48131(ErrorCode.ERR_UnmanagedConstraintNotSatisfied, f_10094_48062_48096(containingSymbol), typeParameter, typeArgument.Type)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 48156, 48169);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 47600, 49359);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 47600, 49359);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 48211, 49359) || true) && (managedKind == ManagedKind.UnmanagedWithGenerics)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 48211, 49359);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 48836, 49340) || true) && (!(currentCompilation is null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 48836, 49340);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 48919, 49046);

                                var
                                csDiagnosticInfo = f_10094_48942_49045(MessageID.IDS_FeatureUnmanagedConstructedTypes, currentCompilation)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49072, 49317) || true) && (csDiagnosticInfo != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 49072, 49317);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49158, 49247);

                                    f_10094_49158_49246(diagnosticsBuilder, f_10094_49181_49245(typeParameter, csDiagnosticInfo));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49277, 49290);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 49072, 49317);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 48836, 49340);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 48211, 49359);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 47600, 49359);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 47217, 49374);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49390, 49906) || true) && (f_10094_49394_49430(typeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 49394, 49477) && !f_10094_49435_49477(typeArgument.Type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 49390, 49906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49656, 49860);

                    f_10094_49656_49859(                // "The type '{2}' must be a non-nullable value type in order to use it as parameter '{1}' in the generic type or method '{0}'"
                                    diagnosticsBuilder, f_10094_49679_49858(typeParameter, f_10094_49726_49857(ErrorCode.ERR_ValConstraintNotSatisfied, f_10094_49788_49822(containingSymbol), typeParameter, typeArgument.Type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 49878, 49891);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 49390, 49906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50413, 50483);

                var
                constraintTypes = f_10094_50435_50482()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50497, 50547);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50561, 50811);

                f_10094_50561_50810(substitution, typeParameter, f_10094_50639_50724(typeParameter, ref useSiteDiagnostics), constraintTypes, ignoreTypeConstraintsDependentOnTypeParametersOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50825, 50847);

                bool
                hasError = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50863, 51166);
                    foreach (var constraintType in f_10094_50894_50909_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 50863, 51166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 50943, 51151);

                        f_10094_50943_51150(containingSymbol, conversions, typeParameter, typeArgument, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnostics, constraintType, ref hasError);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 50863, 51166);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51180, 51203);

                f_10094_51180_51202(constraintTypes);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51219, 51378) || true) && (f_10094_51223_51313(useSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 51219, 51378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51347, 51363);

                    hasError = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 51219, 51378);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51444, 51994) || true) && (f_10094_51448_51486(typeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 51448, 51540) && !f_10094_51491_51540(typeArgument.Type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 51444, 51994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51744, 51948);

                    f_10094_51744_51947(                // "'{2}' must be a non-abstract type with a public parameterless constructor in order to use it as parameter '{1}' in the generic type or method '{0}'"
                                    diagnosticsBuilder, f_10094_51767_51946(typeParameter, f_10094_51814_51945(ErrorCode.ERR_NewConstraintNotSatisfied, f_10094_51876_51910(containingSymbol), typeParameter, typeArgument.Type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 51966, 51979);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 51444, 51994);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 52010, 52027);

                return !hasError;

                static void checkNullability(
                                Symbol containingSymbol,
                                TypeParameterSymbol typeParameter,
                                TypeWithAnnotations typeArgument,
                                ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 52043, 53474);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 52343, 53459) || true) && (nullabilityDiagnosticsBuilderOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 52343, 53459);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 52429, 52885) || true) && (f_10094_52433_52467(typeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 52433, 52526) && f_10094_52471_52526(typeArgument.GetValueNullableAnnotation())) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 52433, 52573) && !f_10094_52531_52573(typeArgument.Type)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 52429, 52885);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 52623, 52862);

                                f_10094_52623_52861(nullabilityDiagnosticsBuilderOpt, f_10094_52660_52860(typeParameter, f_10094_52707_52859(ErrorCode.WRN_NullabilityMismatchInTypeParameterNotNullConstraint, f_10094_52795_52829(containingSymbol), typeParameter, typeArgument)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 52429, 52885);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 52909, 53440) || true) && (f_10094_52913_52953(typeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 52913, 53038) && f_10094_52982_53029(typeParameter) == false) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 52913, 53122) && f_10094_53067_53122(typeArgument.GetValueNullableAnnotation())))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 52909, 53440);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 53172, 53417);

                                f_10094_53172_53416(nullabilityDiagnosticsBuilderOpt, f_10094_53209_53415(typeParameter, f_10094_53256_53414(ErrorCode.WRN_NullabilityMismatchInTypeParameterReferenceTypeConstraint, f_10094_53350_53384(containingSymbol), typeParameter, typeArgument)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 52909, 53440);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 52343, 53459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 52043, 53474);

                        bool
                        f_10094_52433_52467(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.HasNotNullConstraint;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 52433, 52467);
                            return return_v;
                        }


                        bool
                        f_10094_52471_52526(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                        annotation)
                        {
                            var return_v = annotation.IsAnnotated();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52471, 52526);
                            return return_v;
                        }


                        bool
                        f_10094_52531_52573(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        typeArgument)
                        {
                            var return_v = typeArgument.IsNonNullableValueType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52531, 52573);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10094_52795_52829(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = symbol.ConstructedFrom();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52795, 52829);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10094_52707_52859(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, params object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52707, 52859);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        f_10094_52660_52860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        diagnosticInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52660, 52860);
                            return return_v;
                        }


                        int
                        f_10094_52623_52861(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 52623, 52861);
                            return 0;
                        }


                        bool
                        f_10094_52913_52953(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.HasReferenceTypeConstraint;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 52913, 52953);
                            return return_v;
                        }


                        bool?
                        f_10094_52982_53029(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ReferenceTypeConstraintIsNullable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 52982, 53029);
                            return return_v;
                        }


                        bool
                        f_10094_53067_53122(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                        annotation)
                        {
                            var return_v = annotation.IsAnnotated();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 53067, 53122);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10094_53350_53384(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = symbol.ConstructedFrom();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 53350, 53384);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10094_53256_53414(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, params object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 53256, 53414);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        f_10094_53209_53415(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        diagnosticInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 53209, 53415);
                            return return_v;
                        }


                        int
                        f_10094_53172_53416(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 53172, 53416);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 52043, 53474);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 52043, 53474);
                    }
                }

                static void checkConstraintType(
                                Symbol containingSymbol,
                                ConversionsBase conversions,
                                TypeParameterSymbol typeParameter,
                                TypeWithAnnotations typeArgument,
                                CSharpCompilation currentCompilation,
                                ArrayBuilder<TypeParameterDiagnosticInfo> diagnosticsBuilder,
                                ArrayBuilder<TypeParameterDiagnosticInfo> nullabilityDiagnosticsBuilderOpt,
                                ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                                TypeWithAnnotations constraintType,
                                ref bool hasError)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 53490, 56260);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 54127, 55007) || true) && (f_10094_54131_54244(f_10094_54155_54189(conversions, false), typeArgument, constraintType, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 54127, 55007);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 54286, 54959) || true) && (nullabilityDiagnosticsBuilderOpt != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 54286, 54959);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 54380, 54936) || true) && (!f_10094_54385_54497(f_10094_54409_54442(conversions, true), typeArgument, constraintType, ref useSiteDiagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 54384, 54603) || !f_10094_54531_54603(constraintType, f_10094_54568_54602(typeArgument))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 54380, 54936);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 54661, 54909);

                                    f_10094_54661_54908(nullabilityDiagnosticsBuilderOpt, f_10094_54698_54907(typeParameter, f_10094_54745_54906(ErrorCode.WRN_NullabilityMismatchInTypeParameterConstraint, f_10094_54826_54860(containingSymbol), constraintType, typeParameter, typeArgument)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 54380, 54936);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 54286, 54959);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 54981, 54988);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 54127, 55007);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55027, 55047);

                        ErrorCode
                        errorCode
                        = default(ErrorCode);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55065, 55855) || true) && (f_10094_55069_55102(typeArgument.Type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55065, 55855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55144, 55207);

                            errorCode = ErrorCode.ERR_GenericConstraintNotSatisfiedRefType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55065, 55855);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55065, 55855);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55249, 55855) || true) && (typeArgument.IsNullableType())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55249, 55855);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55324, 55495);

                                errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 55336, 55373) || ((f_10094_55336_55373(constraintType.Type) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 55376, 55436)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 55439, 55494))) ? ErrorCode.ERR_GenericConstraintNotSatisfiedNullableInterface : ErrorCode.ERR_GenericConstraintNotSatisfiedNullableEnum;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55249, 55855);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55249, 55855);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55537, 55855) || true) && (typeArgument.TypeKind == TypeKind.TypeParameter)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55537, 55855);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55630, 55691);

                                    errorCode = ErrorCode.ERR_GenericConstraintNotSatisfiedTyVar;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55537, 55855);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 55537, 55855);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55773, 55836);

                                    errorCode = ErrorCode.ERR_GenericConstraintNotSatisfiedValType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55537, 55855);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55249, 55855);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 55065, 55855);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 55875, 55995);

                        SymbolDistinguisher
                        distinguisher = f_10094_55911_55994(currentCompilation, constraintType.Type, typeArgument.Type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56013, 56211);

                        f_10094_56013_56210(diagnosticsBuilder, f_10094_56036_56209(typeParameter, f_10094_56083_56208(errorCode, f_10094_56115_56149(containingSymbol), f_10094_56151_56170(distinguisher), typeParameter, f_10094_56187_56207(distinguisher))));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56229, 56245);

                        hasError = true;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 53490, 56260);

                        Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        f_10094_54155_54189(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, bool
                        includeNullability)
                        {
                            var return_v = this_param.WithNullability(includeNullability);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54155, 54189);
                            return return_v;
                        }


                        bool
                        f_10094_54131_54244(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeArgument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        constraintType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = SatisfiesConstraintType(conversions, typeArgument, constraintType, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54131, 54244);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        f_10094_54409_54442(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, bool
                        includeNullability)
                        {
                            var return_v = this_param.WithNullability(includeNullability);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54409, 54442);
                            return return_v;
                        }


                        bool
                        f_10094_54385_54497(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeArgument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        constraintType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = SatisfiesConstraintType(conversions, typeArgument, constraintType, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54385, 54497);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        f_10094_54568_54602(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeWithAnnotations)
                        {
                            var return_v = getTypeArgumentState(typeWithAnnotations);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54568, 54602);
                            return return_v;
                        }


                        bool
                        f_10094_54531_54603(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeWithAnnotations, Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        state)
                        {
                            var return_v = constraintTypeAllows(typeWithAnnotations, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54531, 54603);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10094_54826_54860(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = symbol.ConstructedFrom();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54826, 54860);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10094_54745_54906(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, params object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54745, 54906);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        f_10094_54698_54907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        diagnosticInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54698, 54907);
                            return return_v;
                        }


                        int
                        f_10094_54661_54908(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 54661, 54908);
                            return 0;
                        }


                        bool
                        f_10094_55069_55102(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsReferenceType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 55069, 55102);
                            return return_v;
                        }


                        bool
                        f_10094_55336_55373(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsInterfaceType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 55336, 55373);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                        f_10094_55911_55994(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        compilation, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        symbol0, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        symbol1)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol0, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol1);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 55911, 55994);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10094_56115_56149(Microsoft.CodeAnalysis.CSharp.Symbol
                        symbol)
                        {
                            var return_v = symbol.ConstructedFrom();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56115, 56149);
                            return return_v;
                        }


                        System.IFormattable
                        f_10094_56151_56170(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                        this_param)
                        {
                            var return_v = this_param.First;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 56151, 56170);
                            return return_v;
                        }


                        System.IFormattable
                        f_10094_56187_56207(Microsoft.CodeAnalysis.CSharp.SymbolDistinguisher
                        this_param)
                        {
                            var return_v = this_param.Second;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 56187, 56207);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10094_56083_56208(Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, params object[]
                        args)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56083, 56208);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        f_10094_56036_56209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        diagnosticInfo)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56036, 56209);
                            return return_v;
                        }


                        int
                        f_10094_56013_56210(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56013, 56210);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 53490, 56260);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 53490, 56260);
                    }
                }

                static NullableFlowState getTypeArgumentState(in TypeWithAnnotations typeWithAnnotations)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 56276, 58055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56398, 56434);

                        var
                        type = typeWithAnnotations.Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56452, 56562) || true) && (type is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 56452, 56562);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56510, 56543);

                            return NullableFlowState.NotNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 56452, 56562);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56580, 56763) || true) && (f_10094_56584_56600(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 56580, 56763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56642, 56744);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 56649, 56685) || ((f_10094_56649_56685(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 56688, 56715)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 56718, 56743))) ? NullableFlowState.MaybeNull : NullableFlowState.NotNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 56580, 56763);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56781, 57186);

                        switch (typeWithAnnotations.NullableAnnotation)
                        {

                            case NullableAnnotation.Annotated:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 56781, 57186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 56929, 57052);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 56936, 56988) || ((f_10094_56936_56988(type) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 56991, 57021)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 57024, 57051))) ? NullableFlowState.MaybeDefault : NullableFlowState.MaybeNull;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 56781, 57186);

                            case NullableAnnotation.Oblivious:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 56781, 57186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57134, 57167);

                                return NullableFlowState.NotNull;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 56781, 57186);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57204, 57252);

                        var
                        typeParameter = type as TypeParameterSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57270, 57428) || true) && (typeParameter is null || (DynAbs.Tracing.TraceSender.Expression_False(10094, 57274, 57334) || f_10094_57299_57326(typeParameter) == true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 57270, 57428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57376, 57409);

                            return NullableFlowState.NotNull;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 57270, 57428);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57446, 57479);

                        NullableFlowState?
                        result = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57497, 57977);
                            foreach (var constraintType in f_10094_57528_57577_I(f_10094_57528_57577(typeParameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 57497, 57977);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57619, 57678);

                                var
                                constraintState = f_10094_57641_57677(constraintType)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57700, 57958) || true) && (result == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 57700, 57958);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57768, 57793);

                                    result = constraintState;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 57700, 57958);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 57700, 57958);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57891, 57935);

                                    result = f_10094_57900_57934(f_10094_57900_57912(result), constraintState);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 57700, 57958);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 57497, 57977);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 481);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 481);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 57995, 58040);

                        return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.NullableFlowState?>(10094, 58002, 58039) ?? NullableFlowState.MaybeNull);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 56276, 58055);

                        bool
                        f_10094_56584_56600(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsValueType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 56584, 56600);
                            return return_v;
                        }


                        bool
                        f_10094_56649_56685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsNullableTypeOrTypeParameter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56649, 56685);
                            return return_v;
                        }


                        bool
                        f_10094_56936_56988(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsTypeParameterDisallowingAnnotationInCSharp8();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 56936, 56988);
                            return return_v;
                        }


                        bool?
                        f_10094_57299_57326(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsNotNullable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 57299, 57326);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10094_57528_57577(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 57528, 57577);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        f_10094_57641_57677(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeWithAnnotations)
                        {
                            var return_v = getTypeArgumentState(typeWithAnnotations);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 57641, 57677);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        f_10094_57900_57912(Microsoft.CodeAnalysis.CSharp.NullableFlowState?
                        this_param)
                        {
                            var return_v = this_param.Value;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 57900, 57912);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        f_10094_57900_57934(Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        a, Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        b)
                        {
                            var return_v = a.Meet(b);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 57900, 57934);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10094_57528_57577_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 57528, 57577);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 56276, 58055);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 56276, 58055);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static bool constraintTypeAllows(in TypeWithAnnotations typeWithAnnotations, NullableFlowState state)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 58071, 59342);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58205, 58316) || true) && (state == NullableFlowState.NotNull)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 58205, 58316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58285, 58297);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 58205, 58316);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58334, 58370);

                        var
                        type = typeWithAnnotations.Type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58388, 58497) || true) && (type is null || (DynAbs.Tracing.TraceSender.Expression_False(10094, 58392, 58424) || f_10094_58408_58424(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 58388, 58497);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58466, 58478);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 58388, 58497);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58515, 58750);

                        switch (typeWithAnnotations.NullableAnnotation)
                        {

                            case NullableAnnotation.Oblivious:
                            case NullableAnnotation.Annotated:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 58515, 58750);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58719, 58731);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 58515, 58750);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58768, 58816);

                        var
                        typeParameter = type as TypeParameterSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58834, 58972) || true) && (typeParameter is null || (DynAbs.Tracing.TraceSender.Expression_False(10094, 58838, 58898) || f_10094_58863_58890(typeParameter) == true))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 58834, 58972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58940, 58953);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 58834, 58972);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 58990, 59265);
                            foreach (var constraintType in f_10094_59021_59070_I(f_10094_59021_59070(typeParameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 58990, 59265);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59112, 59246) || true) && (!f_10094_59117_59160(constraintType, state))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 59112, 59246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59210, 59223);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 59112, 59246);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 58990, 59265);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 276);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 276);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59283, 59327);

                        return state == NullableFlowState.MaybeNull;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 58071, 59342);

                        bool
                        f_10094_58408_58424(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsValueType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 58408, 58424);
                            return return_v;
                        }


                        bool?
                        f_10094_58863_58890(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsNotNullable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 58863, 58890);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10094_59021_59070(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 59021, 59070);
                            return return_v;
                        }


                        bool
                        f_10094_59117_59160(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeWithAnnotations, Microsoft.CodeAnalysis.CSharp.NullableFlowState
                        state)
                        {
                            var return_v = constraintTypeAllows(typeWithAnnotations, state);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 59117, 59160);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10094_59021_59070_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 59021, 59070);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 58071, 59342);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 58071, 59342);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 44688, 59353);

                int
                f_10094_45354_45388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45354, 45388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_45546_45576(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 45546, 45576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_45578_45613(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 45578, 45613);
                    return return_v;
                }


                bool
                f_10094_45530_45614(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45530, 45614);
                    return return_v;
                }


                int
                f_10094_45517_45615(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45517, 45615);
                    return 0;
                }


                bool
                f_10094_45636_45667(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45636, 45667);
                    return return_v;
                }


                bool
                f_10094_45748_45794(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45748, 45794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_46034_46104(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46034, 46104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_45987_46105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45987, 46105);
                    return return_v;
                }


                int
                f_10094_45964_46106(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 45964, 46106);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_46373_46451(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46373, 46451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_46326_46452(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46326, 46452);
                    return return_v;
                }


                int
                f_10094_46303_46453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46303, 46453);
                    return 0;
                }


                bool
                f_10094_46520_46560(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 46520, 46560);
                    return return_v;
                }


                bool
                f_10094_46598_46632_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 46598, 46632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_46946_46980(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46946, 46980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_46884_47015(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46884, 47015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_46837_47016(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46837, 47016);
                    return return_v;
                }


                int
                f_10094_46814_47017(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 46814, 47017);
                    return 0;
                }


                int
                f_10094_47103_47200(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArgument, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt)
                {
                    checkNullability(containingSymbol, typeParameter, typeArgument, nullabilityDiagnosticsBuilderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47103, 47200);
                    return 0;
                }


                bool
                f_10094_47221_47261(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 47221, 47261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ManagedKind
                f_10094_47392_47459(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetManagedKind(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47392, 47459);
                    return return_v;
                }


                bool
                f_10094_47478_47579(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder)
                {
                    var return_v = AppendUseSiteDiagnostics(useSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47478, 47579);
                    return return_v;
                }


                bool
                f_10094_47643_47685(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47643, 47685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_48062_48096(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 48062, 48096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_47994_48131(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47994, 48131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_47947_48132(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47947, 48132);
                    return return_v;
                }


                int
                f_10094_47924_48133(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 47924, 48133);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                f_10094_48942_49045(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = feature.GetFeatureAvailabilityDiagnosticInfo(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 48942, 49045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_49181_49245(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49181, 49245);
                    return return_v;
                }


                int
                f_10094_49158_49246(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49158, 49246);
                    return 0;
                }


                bool
                f_10094_49394_49430(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 49394, 49430);
                    return return_v;
                }


                bool
                f_10094_49435_49477(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49435, 49477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_49788_49822(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49788, 49822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_49726_49857(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49726, 49857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_49679_49858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49679, 49858);
                    return return_v;
                }


                int
                f_10094_49656_49859(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 49656, 49859);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_50435_50482()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 50435, 50482);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_50639_50724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ConstraintTypesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 50639, 50724);
                    return return_v;
                }


                int
                f_10094_50561_50810(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                owner, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                result, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                ignoreTypesDependentOnTypeParametersOpt)
                {
                    this_param.SubstituteConstraintTypesDistinctWithoutModifiers(owner, original, result, ignoreTypesDependentOnTypeParametersOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 50561, 50810);
                    return 0;
                }


                int
                f_10094_50943_51150(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArgument, Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                nullabilityDiagnosticsBuilderOpt, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, ref bool
                hasError)
                {
                    checkConstraintType(containingSymbol, conversions, typeParameter, typeArgument, currentCompilation, diagnosticsBuilder, nullabilityDiagnosticsBuilderOpt, ref useSiteDiagnostics, constraintType, ref hasError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 50943, 51150);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_50894_50909_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 50894, 50909);
                    return return_v;
                }


                int
                f_10094_51180_51202(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51180, 51202);
                    return 0;
                }


                bool
                f_10094_51223_51313(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                useSiteDiagnosticsBuilder)
                {
                    var return_v = AppendUseSiteDiagnostics(useSiteDiagnostics, typeParameter, ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51223, 51313);
                    return return_v;
                }


                bool
                f_10094_51448_51486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 51448, 51486);
                    return return_v;
                }


                bool
                f_10094_51491_51540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = SatisfiesConstructorConstraint(typeArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51491, 51540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10094_51876_51910(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ConstructedFrom();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51876, 51910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_51814_51945(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51814, 51945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_51767_51946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51767, 51946);
                    return return_v;
                }


                int
                f_10094_51744_51947(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 51744, 51947);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 44688, 59353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 44688, 59353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AppendUseSiteDiagnostics(
                    HashSet<DiagnosticInfo> useSiteDiagnostics,
                    TypeParameterSymbol typeParameter,
                    ref ArrayBuilder<TypeParameterDiagnosticInfo> useSiteDiagnosticsBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 59365, 60318);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59626, 59726) || true) && (f_10094_59630_59664(useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 59626, 59726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59698, 59711);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 59626, 59726);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59742, 59904) || true) && (useSiteDiagnosticsBuilder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 59742, 59904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59813, 59889);

                    useSiteDiagnosticsBuilder = f_10094_59841_59888();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 59742, 59904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59920, 59943);

                bool
                hasErrors = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 59959, 60274);
                    foreach (var info in f_10094_59980_59998_I(useSiteDiagnostics))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 59959, 60274);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60032, 60155) || true) && (f_10094_60036_60049(info) == DiagnosticSeverity.Error)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 60032, 60155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60119, 60136);

                            hasErrors = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 60032, 60155);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60175, 60259);

                        f_10094_60175_60258(
                                        useSiteDiagnosticsBuilder, f_10094_60205_60257(typeParameter, info));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 59959, 60274);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60290, 60307);

                return hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 59365, 60318);

                bool
                f_10094_59630_59664(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 59630, 59664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10094_59841_59888()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 59841, 59888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10094_60036_60049(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 60036, 60049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_60205_60257(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.DiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 60205, 60257);
                    return return_v;
                }


                int
                f_10094_60175_60258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 60175, 60258);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10094_59980_59998_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 59980, 59998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 59365, 60318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 59365, 60318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool SatisfiesConstraintType(
                    ConversionsBase conversions,
                    TypeWithAnnotations typeArgument,
                    TypeWithAnnotations constraintType,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 60330, 62796);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60598, 60697) || true) && (f_10094_60602_60635(constraintType.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 60598, 60697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60669, 60682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 60598, 60697);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 60947, 61128) || true) && (f_10094_60951_61067(conversions, typeArgument.Type, constraintType.Type, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 60947, 61128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 61101, 61113);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 60947, 61128);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 61351, 61702) || true) && (f_10094_61355_61384(typeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 61355, 61641) && f_10094_61405_61641(conversions, (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 61437, 61471) || ((f_10094_61437_61471(typeArgument.Type) && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 61474, 61526)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 61529, 61546))) ? f_10094_61474_61526(((NamedTypeSymbol)typeArgument.Type)) : typeArgument.Type, constraintType.Type, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 61351, 61702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 61675, 61687);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 61351, 61702);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 61718, 62756) || true) && (typeArgument.TypeKind == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 61718, 62756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 61803, 61862);

                    var
                    typeParameter = (TypeParameterSymbol)typeArgument.Type
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62016, 62199) || true) && (f_10094_62020_62126(conversions, typeParameter, constraintType.Type, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 62016, 62199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62168, 62180);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 62016, 62199);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62367, 62741);
                        foreach (var typeArgumentConstraint in f_10094_62406_62491_I(f_10094_62406_62491(typeParameter, ref useSiteDiagnostics)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 62367, 62741);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62533, 62722) || true) && (f_10094_62537_62637(conversions, typeArgumentConstraint, constraintType, ref useSiteDiagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 62533, 62722);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62687, 62699);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 62533, 62722);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 62367, 62741);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 375);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 61718, 62756);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62772, 62785);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 60330, 62796);

                bool
                f_10094_60602_60635(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 60602, 60635);
                    return return_v;
                }


                bool
                f_10094_60951_61067(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 60951, 61067);
                    return return_v;
                }


                bool
                f_10094_61355_61384(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 61355, 61384);
                    return return_v;
                }


                bool
                f_10094_61437_61471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 61437, 61471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_61474_61526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 61474, 61526);
                    return return_v;
                }


                bool
                f_10094_61405_61641(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 61405, 61641);
                    return return_v;
                }


                bool
                f_10094_62020_62126(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 62020, 62126);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_62406_62491(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ConstraintTypesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 62406, 62491);
                    return return_v;
                }


                bool
                f_10094_62537_62637(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeArgument, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = SatisfiesConstraintType(conversions, typeArgument, constraintType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 62537, 62637);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10094_62406_62491_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 62406, 62491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 60330, 62796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 60330, 62796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsReferenceType(TypeParameterSymbol typeParameter, ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 62808, 63099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 62956, 63088);

                return f_10094_62963_63003(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 62963, 63087) || f_10094_63007_63087(constraintTypes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 62808, 63099);

                bool
                f_10094_62963_63003(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 62963, 63003);
                    return return_v;
                }


                bool
                f_10094_63007_63087(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterSymbol.CalculateIsReferenceTypeFromConstraintTypes(constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 63007, 63087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 62808, 63099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 62808, 63099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValueType(TypeParameterSymbol typeParameter, ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 63111, 63390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 63255, 63379);

                return f_10094_63262_63298(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 63262, 63378) || f_10094_63302_63378(constraintTypes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 63111, 63390);

                bool
                f_10094_63262_63298(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 63262, 63298);
                    return return_v;
                }


                bool
                f_10094_63302_63378(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = TypeParameterSymbol.CalculateIsValueTypeFromConstraintTypes(constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 63302, 63378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 63111, 63390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 63111, 63390);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeParameterDiagnosticInfo GenerateConflictingConstraintsError(TypeParameterSymbol typeParameter, TypeSymbol deducedBase, bool classConflict)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 63402, 63861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 63672, 63850);

                return f_10094_63679_63849(typeParameter, f_10094_63726_63848(ErrorCode.ERR_BaseConstraintConflict, typeParameter, deducedBase, (DynAbs.Tracing.TraceSender.Conditional_F1(10094, 63813, 63826) || ((classConflict && DynAbs.Tracing.TraceSender.Conditional_F2(10094, 63829, 63836)) || DynAbs.Tracing.TraceSender.Conditional_F3(10094, 63839, 63847))) ? "class" : "struct"));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 63402, 63861);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10094_63726_63848(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 63726, 63848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo
                f_10094_63679_63849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                diagnosticInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo(typeParameter, (Microsoft.CodeAnalysis.DiagnosticInfo)diagnosticInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 63679, 63849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 63402, 63861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 63402, 63861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddInterfaces(ArrayBuilder<NamedTypeSymbol> builder, ImmutableArray<NamedTypeSymbol> interfaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 63873, 64145);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64014, 64134);
                    foreach (var @interface in f_10094_64041_64051_I(interfaces))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64014, 64134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64085, 64119);

                        f_10094_64085_64118(builder, @interface);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64014, 64134);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 63873, 64145);

                int
                f_10094_64085_64118(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface)
                {
                    AddInterface(builder, @interface);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 64085, 64118);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10094_64041_64051_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 64041, 64051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 63873, 64145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 63873, 64145);
            }
        }

        private static void AddInterface(ArrayBuilder<NamedTypeSymbol> builder, NamedTypeSymbol @interface)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 64157, 64398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64281, 64387) || true) && (!f_10094_64286_64314(builder, @interface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64281, 64387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64348, 64372);

                    f_10094_64348_64371(builder, @interface);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64281, 64387);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 64157, 64398);

                bool
                f_10094_64286_64314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 64286, 64314);
                    return return_v;
                }


                int
                f_10094_64348_64371(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 64348, 64371);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 64157, 64398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 64157, 64398);
            }
        }

        private static bool SatisfiesConstructorConstraint(TypeSymbol typeArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 64410, 65428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64510, 65417);

                switch (f_10094_64518_64539(typeArgument))
                {

                    case TypeKind.Struct:
                    case TypeKind.Enum:
                    case TypeKind.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64510, 65417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64693, 64705);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64510, 65417);

                    case TypeKind.Class:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64510, 65417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64767, 64867);

                        return f_10094_64774_64838(typeArgument) && (DynAbs.Tracing.TraceSender.Expression_True(10094, 64774, 64866) && f_10094_64842_64866_M(!typeArgument.IsAbstract));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64510, 65417);

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64510, 65417);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 64964, 65018);

                            var
                            typeParameter = (TypeParameterSymbol)typeArgument
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65044, 65119);

                            return f_10094_65051_65089(typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 65051, 65118) || f_10094_65093_65118(typeParameter));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64510, 65417);

                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64510, 65417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65275, 65339);

                        throw f_10094_65281_65338(f_10094_65316_65337(typeArgument));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64510, 65417);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 64510, 65417);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65389, 65402);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 64510, 65417);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 64410, 65428);

                Microsoft.CodeAnalysis.TypeKind
                f_10094_64518_64539(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 64518, 64539);
                    return return_v;
                }


                bool
                f_10094_64774_64838(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = HasPublicParameterlessConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 64774, 64838);
                    return return_v;
                }


                bool
                f_10094_64842_64866_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 64842, 64866);
                    return return_v;
                }


                bool
                f_10094_65051_65089(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65051, 65089);
                    return return_v;
                }


                bool
                f_10094_65093_65118(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65093, 65118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10094_65316_65337(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65316, 65337);
                    return return_v;
                }


                System.Exception
                f_10094_65281_65338(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 65281, 65338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 64410, 65428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 64410, 65428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasPublicParameterlessConstructor(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 65570, 66031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65670, 65716);

                f_10094_65670_65715(f_10094_65683_65696(type) == TypeKind.Class);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65730, 65993);
                    foreach (var constructor in f_10094_65758_65783_I(f_10094_65758_65783(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 65730, 65993);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65817, 65978) || true) && (f_10094_65821_65847(constructor) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 65817, 65978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 65894, 65959);

                            return f_10094_65901_65934(constructor) == Accessibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 65817, 65978);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 65730, 65993);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10094, 1, 264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10094, 1, 264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66007, 66020);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 65570, 66031);

                Microsoft.CodeAnalysis.TypeKind
                f_10094_65683_65696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65683, 65696);
                    return return_v;
                }


                int
                f_10094_65670_65715(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 65670, 65715);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10094_65758_65783(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65758, 65783);
                    return return_v;
                }


                int
                f_10094_65821_65847(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65821, 65847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10094_65901_65934(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 65901, 65934);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10094_65758_65783_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 65758, 65783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 65570, 66031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 65570, 66031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEncompassedBy(ConversionsBase conversions, TypeSymbol a, TypeSymbol b, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 66207, 66837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66372, 66418);

                f_10094_66372_66417(f_10094_66385_66416(a));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66432, 66478);

                f_10094_66432_66477(f_10094_66445_66476(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66609, 66655);

                f_10094_66609_66654(!conversions.IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66671, 66826);

                return f_10094_66678_66760(conversions, a, b, ref useSiteDiagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 66678, 66825) || f_10094_66764_66825(conversions, a, b, ref useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 66207, 66837);

                bool
                f_10094_66385_66416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsValidEncompassedByArgument(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66385, 66416);
                    return return_v;
                }


                int
                f_10094_66372_66417(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66372, 66417);
                    return 0;
                }


                bool
                f_10094_66445_66476(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsValidEncompassedByArgument(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66445, 66476);
                    return return_v;
                }


                int
                f_10094_66432_66477(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66432, 66477);
                    return 0;
                }


                int
                f_10094_66609_66654(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66609, 66654);
                    return 0;
                }


                bool
                f_10094_66678_66760(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66678, 66760);
                    return return_v;
                }


                bool
                f_10094_66764_66825(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 66764, 66825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 66207, 66837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 66207, 66837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsValidEncompassedByArgument(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 66849, 67290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 66939, 67279);

                switch (f_10094_66947_66960(type))
                {

                    case TypeKind.Array:
                    case TypeKind.Class:
                    case TypeKind.Delegate:
                    case TypeKind.Enum:
                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 66939, 67279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67191, 67203);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 66939, 67279);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 66939, 67279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67251, 67264);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 66939, 67279);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 66849, 67290);

                Microsoft.CodeAnalysis.TypeKind
                f_10094_66947_66960(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 66947, 66960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 66849, 67290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 66849, 67290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool RequiresChecking(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 67302, 67977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67384, 67465) || true) && (f_10094_67388_67398(type) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 67384, 67465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67437, 67450);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 67384, 67465);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67727, 67839) || true) && (f_10094_67731_67777(f_10094_67747_67770(type), type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 67727, 67839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67811, 67824);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 67727, 67839);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67855, 67940);

                f_10094_67855_67939(!f_10094_67869_67938(f_10094_67869_67889(type), type, TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 67954, 67966);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 67302, 67977);

                int
                f_10094_67388_67398(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 67388, 67398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_67747_67770(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 67747, 67770);
                    return return_v;
                }


                bool
                f_10094_67731_67777(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 67731, 67777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10094_67869_67889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 67869, 67889);
                    return return_v;
                }


                bool
                f_10094_67869_67938(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 67869, 67938);
                    return return_v;
                }


                int
                f_10094_67855_67939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 67855, 67939);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 67302, 67977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 67302, 67977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool RequiresChecking(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 67989, 68639);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68070, 68159) || true) && (f_10094_68074_68097_M(!method.IsGenericMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 68070, 68159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68131, 68144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 68070, 68159);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68423, 68539) || true) && (f_10094_68427_68477(f_10094_68443_68468(method), method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 68423, 68539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68511, 68524);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 68423, 68539);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68555, 68602);

                f_10094_68555_68601(f_10094_68568_68590(method) != method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68616, 68628);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 67989, 68639);

                bool
                f_10094_68074_68097_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 68074, 68097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10094_68443_68468(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 68443, 68468);
                    return return_v;
                }


                bool
                f_10094_68427_68477(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 68427, 68477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10094_68568_68590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 68568, 68590);
                    return return_v;
                }


                int
                f_10094_68555_68601(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 68555, 68601);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 67989, 68639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 67989, 68639);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void CheckEffectiveAndDeducedBaseTypes(ConversionsBase conversions, TypeSymbol effectiveBase, TypeSymbol deducedBase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 68651, 69346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68840, 68882);

                f_10094_68840_68881((object)deducedBase != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68896, 68940);

                f_10094_68896_68939((object)effectiveBase != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 68954, 69004);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69018, 69335);

                f_10094_69018_69334(f_10094_69031_69056(deducedBase) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 69031, 69104) || f_10094_69077_69104(effectiveBase)) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 69031, 69229) || f_10094_69125_69229(conversions, deducedBase, effectiveBase, ref useSiteDiagnostics)) || (DynAbs.Tracing.TraceSender.Expression_False(10094, 69031, 69333) || f_10094_69250_69333(conversions, deducedBase, effectiveBase, ref useSiteDiagnostics)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 68651, 69346);

                int
                f_10094_68840_68881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 68840, 68881);
                    return 0;
                }


                int
                f_10094_68896_68939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 68896, 68939);
                    return 0;
                }


                bool
                f_10094_69031_69056(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69031, 69056);
                    return return_v;
                }


                bool
                f_10094_69077_69104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69077, 69104);
                    return return_v;
                }


                bool
                f_10094_69125_69229(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69125, 69229);
                    return return_v;
                }


                bool
                f_10094_69250_69333(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69250, 69333);
                    return return_v;
                }


                int
                f_10094_69018_69334(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69018, 69334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 68651, 69346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 68651, 69346);
            }
        }

        internal static TypeWithAnnotations ConstraintWithMostSignificantNullability(TypeWithAnnotations type1, TypeWithAnnotations type2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 69358, 70121);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69513, 70110);

                switch (type2.NullableAnnotation)
                {

                    case NullableAnnotation.Annotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 69513, 70110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69635, 69648);

                        return type1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 69513, 70110);

                    case NullableAnnotation.NotAnnotated:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 69513, 70110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69725, 69738);

                        return type2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 69513, 70110);

                    case NullableAnnotation.Oblivious:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 69513, 70110);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69812, 69943) || true) && (f_10094_69816_69857(type1.NullableAnnotation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 69812, 69943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69907, 69920);

                            return type1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 69812, 69943);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 69967, 69980);

                        return type2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 69513, 70110);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 69513, 70110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70028, 70095);

                        throw f_10094_70034_70094(type2.NullableAnnotation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 69513, 70110);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 69358, 70121);

                bool
                f_10094_69816_69857(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsNotAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 69816, 69857);
                    return return_v;
                }


                System.Exception
                f_10094_70034_70094(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 70034, 70094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 69358, 70121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 69358, 70121);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsObjectConstraint(TypeWithAnnotations type, ref TypeWithAnnotations bestObjectConstraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 70133, 71037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70269, 70997) || true) && (type.SpecialType == SpecialType.System_Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 70269, 70997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70352, 70950);

                    switch (type.NullableAnnotation)
                    {

                        case NullableAnnotation.Annotated:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 70352, 70950);
                            DynAbs.Tracing.TraceSender.TraceBreak(10094, 70485, 70491);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 70352, 70950);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 70352, 70950);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70547, 70899) || true) && (f_10094_70551_70580_M(!bestObjectConstraint.HasType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 70547, 70899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70638, 70666);

                                bestObjectConstraint = type;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 70547, 70899);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 70547, 70899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70780, 70872);

                                bestObjectConstraint = f_10094_70803_70871(bestObjectConstraint, type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 70547, 70899);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10094, 70925, 70931);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 70352, 70950);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 70970, 70982);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 70269, 70997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71013, 71026);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 70133, 71037);

                bool
                f_10094_70551_70580_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10094, 70551, 70580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10094_70803_70871(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type2)
                {
                    var return_v = ConstraintWithMostSignificantNullability(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 70803, 70871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 70133, 71037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 70133, 71037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsObjectConstraintSignificant(bool? isNotNullable, TypeWithAnnotations objectConstraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10094, 71049, 71556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71183, 71517);

                switch (isNotNullable)
                {

                    case true:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 71183, 71517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71270, 71283);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 71183, 71517);

                    case null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 71183, 71517);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71333, 71472) || true) && (f_10094_71337_71386(objectConstraint.NullableAnnotation))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10094, 71333, 71472);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71436, 71449);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 71333, 71472);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10094, 71496, 71502);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10094, 71183, 71517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 71533, 71545);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10094, 71049, 71556);

                bool
                f_10094_71337_71386(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10094, 71337, 71386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10094, 71049, 71556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 71049, 71556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConstraintsHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10094, 3321, 71563);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10094, 27903, 27998);
            s_checkConstraintsSingleTypeFunc = (type, arg, unused) => CheckConstraintsSingleType(type, arg); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10094, 3321, 71563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10094, 3321, 71563);
        }

    }
}
