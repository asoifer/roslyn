// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PETypeParameterSymbol
            : TypeParameterSymbol
    {
        private readonly Symbol _containingSymbol;

        private readonly GenericParameterHandle _handle;

        private readonly string _name;

        private readonly ushort _ordinal;

        private DiagnosticInfo _lazyConstraintsUseSiteErrorInfo;

        private readonly GenericParameterAttributes _flags;

        private ThreeState _lazyHasIsUnmanagedConstraint;

        private TypeParameterBounds _lazyBounds;

        private ImmutableArray<TypeWithAnnotations> _lazyDeclaredConstraintTypes;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        internal PETypeParameterSymbol(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol definingNamedType,
                    ushort ordinal,
                    GenericParameterHandle handle)
        : this(f_10714_1913_1925_C(moduleSymbol), (Symbol)definingNamedType, ordinal, handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10714, 1696, 1992);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10714, 1696, 1992);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 1696, 1992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 1696, 1992);
            }
        }

        internal PETypeParameterSymbol(
                    PEModuleSymbol moduleSymbol,
                    PEMethodSymbol definingMethod,
                    ushort ordinal,
                    GenericParameterHandle handle)
        : this(f_10714_2215_2227_C(moduleSymbol), (Symbol)definingMethod, ordinal, handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10714, 2004, 2291);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10714, 2004, 2291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 2004, 2291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 2004, 2291);
            }
        }

        private PETypeParameterSymbol(
                    PEModuleSymbol moduleSymbol,
                    Symbol definingSymbol,
                    ushort ordinal,
                    GenericParameterHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10714, 2303, 3642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 824, 841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1000, 1005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1040, 1048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1230, 1296);
                this._lazyConstraintsUseSiteErrorInfo = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1381, 1387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1417, 1446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 1485, 1524);
                this._lazyBounds = TypeParameterBounds.Unset; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2509, 2552);

                f_10714_2509_2551((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2566, 2611);

                f_10714_2566_2610((object)definingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2625, 2652);

                f_10714_2625_2651(ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2666, 2694);

                f_10714_2666_2693(f_10714_2679_2692_M(!handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2710, 2745);

                _containingSymbol = definingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2761, 2798);

                GenericParameterAttributes
                flags = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 2850, 2928);

                    f_10714_2850_2927(f_10714_2850_2869(moduleSymbol), handle, out _name, out flags);
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10714, 2957, 3252);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3021, 3128) || true) && ((object)_name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 3021, 3128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3088, 3109);

                        _name = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 3021, 3128);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3148, 3237);

                    _lazyConstraintsUseSiteErrorInfo = f_10714_3183_3236(ErrorCode.ERR_BindToBogus, this);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10714, 2957, 3252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3404, 3565);

                _flags = (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 3413, 3487) || ((((flags & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 3490, 3495)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 3498, 3564))) ? flags : (flags & ~GenericParameterAttributes.DefaultConstructorConstraint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3581, 3600);

                _ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3614, 3631);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10714, 2303, 3642);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 2303, 3642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 2303, 3642);
            }
        }

        public override TypeParameterKind TypeParameterKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 3730, 3930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 3766, 3915);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 3773, 3820) || ((f_10714_3773_3799(f_10714_3773_3794(this)) == SymbolKind.Method
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 3844, 3868)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 3892, 3914))) ? TypeParameterKind.Method
                    : TypeParameterKind.Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 3730, 3930);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10714_3773_3794(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 3773, 3794);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10714_3773_3799(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 3773, 3799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 3654, 3941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 3654, 3941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4005, 4029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4011, 4027);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4005, 4029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 3953, 4040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 3953, 4040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4104, 4168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4140, 4153);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4104, 4168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 4052, 4179);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 4052, 4179);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal GenericParameterHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4254, 4320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4290, 4305);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4254, 4320);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 4191, 4331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 4191, 4331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4407, 4440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4413, 4438);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4407, 4440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 4343, 4451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 4343, 4451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4537, 4632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4573, 4617);

                    return f_10714_4580_4616(_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4537, 4632);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10714_4580_4616(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 4580, 4616);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 4463, 4643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 4463, 4643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<TypeWithAnnotations> GetDeclaredConstraintTypes(ConsList<PETypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 4655, 9828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4794, 4844);

                f_10714_4794_4843(!f_10714_4808_4842(inProgress, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4858, 4966);

                f_10714_4858_4965(!f_10714_4872_4888(inProgress) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 4871, 4964) || f_10714_4892_4964(f_10714_4908_4940(f_10714_4908_4923(inProgress)), f_10714_4942_4963(this))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 4982, 9765) || true) && (_lazyDeclaredConstraintTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 4982, 9765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5058, 5118);

                    ImmutableArray<TypeWithAnnotations>
                    declaredConstraintTypes
                    = default(ImmutableArray<TypeWithAnnotations>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5138, 5197);

                    var
                    moduleSymbol = ((PEModuleSymbol)f_10714_5174_5195(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5215, 5255);

                    PEModule
                    peModule = f_10714_5235_5254(moduleSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5273, 5370);

                    GenericParameterConstraintHandleCollection
                    constraints = f_10714_5330_5369(this, peModule)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5390, 5429);

                    bool
                    hasUnmanagedModreqPattern = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5449, 8792) || true) && (constraints.Count > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 5449, 8792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5516, 5585);

                        var
                        symbolsBuilder = f_10714_5537_5584()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5607, 5681);

                        MetadataDecoder
                        tokenDecoder = f_10714_5638_5680(this, moduleSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5705, 5756);

                        TypeWithAnnotations
                        bestObjectConstraint = default
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5780, 5825);

                        var
                        metadataReader = f_10714_5801_5824(peModule)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5847, 6690);
                            foreach (var constraintHandle in f_10714_5880_5891_I(constraints))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 5847, 6690);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 5941, 6088);

                                TypeWithAnnotations
                                type = f_10714_5968_6087(this, moduleSymbol, metadataReader, tokenDecoder, constraintHandle, ref hasUnmanagedModreqPattern)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6116, 6354) || true) && (f_10714_6120_6133_M(!type.HasType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 6116, 6354);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6318, 6327);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 6116, 6354);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6448, 6614) || true) && (f_10714_6452_6520(type, ref bestObjectConstraint))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 6448, 6614);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6578, 6587);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 6448, 6614);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6642, 6667);

                                f_10714_6642_6666(
                                                        symbolsBuilder, type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 5847, 6690);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10714, 1, 844);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10714, 1, 844);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6714, 8537) || true) && (bestObjectConstraint.HasType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 6714, 8537);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 6939, 8514) || true) && (f_10714_6943_7060(f_10714_6991_7037(this), bestObjectConstraint))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 6939, 8514);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7118, 7181);

                                f_10714_7118_7180(f_10714_7131_7152_M(!HasNotNullConstraint) && (DynAbs.Tracing.TraceSender.Expression_True(10714, 7131, 7179) && f_10714_7156_7179_M(!HasValueTypeConstraint)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7211, 8279) || true) && (f_10714_7215_7235(symbolsBuilder) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 7211, 8279);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7306, 7534) || true) && (f_10714_7310_7363(bestObjectConstraint.NullableAnnotation) && (DynAbs.Tracing.TraceSender.Expression_True(10714, 7310, 7394) && f_10714_7367_7394_M(!HasReferenceTypeConstraint)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 7306, 7534);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7468, 7499);

                                        bestObjectConstraint = default;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 7306, 7534);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 7211, 8279);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 7211, 8279);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7664, 7702);

                                    inProgress = f_10714_7677_7701(inProgress, this);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7736, 8248);
                                        foreach (TypeWithAnnotations constraintType in f_10714_7783_7797_I(symbolsBuilder))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 7736, 8248);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 7871, 8213) || true) && (!f_10714_7876_8013(f_10714_7924_7990(constraintType, inProgress, out _), bestObjectConstraint))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 7871, 8213);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8095, 8126);

                                                bestObjectConstraint = default;
                                                DynAbs.Tracing.TraceSender.TraceBreak(10714, 8168, 8174);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 7871, 8213);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 7736, 8248);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10714, 1, 513);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10714, 1, 513);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 7211, 8279);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8311, 8487) || true) && (bestObjectConstraint.HasType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 8311, 8487);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8409, 8456);

                                    f_10714_8409_8455(symbolsBuilder, 0, bestObjectConstraint);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 8311, 8487);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 6939, 8514);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 6714, 8537);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8561, 8623);

                        declaredConstraintTypes = f_10714_8587_8622(symbolsBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 5449, 8792);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 5449, 8792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8705, 8773);

                        declaredConstraintTypes = ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 5449, 8792);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 8987, 9537) || true) && (hasUnmanagedModreqPattern && (DynAbs.Tracing.TraceSender.Expression_True(10714, 8991, 9093) && (_flags & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 8991, 9188) || hasUnmanagedModreqPattern != f_10714_9147_9188(peModule, _handle)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 8987, 9537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9308, 9342);

                        hasUnmanagedModreqPattern = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9364, 9518);

                        f_10714_9364_9517(ref _lazyConstraintsUseSiteErrorInfo, f_10714_9430_9483(ErrorCode.ERR_BindToBogus, this), CSDiagnosticInfo.EmptyErrorInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 8987, 9537);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9557, 9630);

                    _lazyHasIsUnmanagedConstraint = f_10714_9589_9629(hasUnmanagedModreqPattern);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9648, 9750);

                    f_10714_9648_9749(ref _lazyDeclaredConstraintTypes, declaredConstraintTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 4982, 9765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9781, 9817);

                return _lazyDeclaredConstraintTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 4655, 9828);

                bool
                f_10714_4808_4842(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 4808, 4842);
                    return return_v;
                }


                int
                f_10714_4794_4843(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 4794, 4843);
                    return 0;
                }


                bool
                f_10714_4872_4888(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 4872, 4888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                f_10714_4908_4923(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 4908, 4923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_4908_4940(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 4908, 4940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_4942_4963(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 4942, 4963);
                    return return_v;
                }


                bool
                f_10714_4892_4964(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 4892, 4964);
                    return return_v;
                }


                int
                f_10714_4858_4965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 4858, 4965);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10714_5174_5195(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 5174, 5195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10714_5235_5254(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 5235, 5254);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                f_10714_5330_5369(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module)
                {
                    var return_v = this_param.GetConstraintHandleCollection(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 5330, 5369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_5537_5584()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 5537, 5584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10714_5638_5680(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = this_param.GetDecoderForConstraintTypes(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 5638, 5680);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_10714_5801_5824(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 5801, 5824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10714_5968_6087(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.MetadataReader
                metadataReader, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                tokenDecoder, System.Reflection.Metadata.GenericParameterConstraintHandle
                constraintHandle, ref bool
                hasUnmanagedModreqPattern)
                {
                    var return_v = this_param.GetConstraintTypeOrDefault(moduleSymbol, metadataReader, tokenDecoder, constraintHandle, ref hasUnmanagedModreqPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 5968, 6087);
                    return return_v;
                }


                bool
                f_10714_6120_6133_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 6120, 6133);
                    return return_v;
                }


                bool
                f_10714_6452_6520(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                bestObjectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraint(type, ref bestObjectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 6452, 6520);
                    return return_v;
                }


                int
                f_10714_6642_6666(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 6642, 6666);
                    return 0;
                }


                System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                f_10714_5880_5891_I(System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 5880, 5891);
                    return return_v;
                }


                bool?
                f_10714_6991_7037(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.CalculateIsNotNullableFromNonTypeConstraints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 6991, 7037);
                    return return_v;
                }


                bool
                f_10714_6943_7060(bool?
                isNotNullable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraintSignificant(isNotNullable, objectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 6943, 7060);
                    return return_v;
                }


                bool
                f_10714_7131_7152_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 7131, 7152);
                    return return_v;
                }


                bool
                f_10714_7156_7179_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 7156, 7179);
                    return return_v;
                }


                int
                f_10714_7118_7180(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7118, 7180);
                    return 0;
                }


                int
                f_10714_7215_7235(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 7215, 7235);
                    return return_v;
                }


                bool
                f_10714_7310_7363(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7310, 7363);
                    return return_v;
                }


                bool
                f_10714_7367_7394_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 7367, 7394);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                f_10714_7677_7701(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>(head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7677, 7701);
                    return return_v;
                }


                bool?
                f_10714_7924_7990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintType(constraintType, inProgress, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7924, 7990);
                    return return_v;
                }


                bool
                f_10714_7876_8013(bool?
                isNotNullable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                objectConstraint)
                {
                    var return_v = ConstraintsHelper.IsObjectConstraintSignificant(isNotNullable, objectConstraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7876, 8013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_7783_7797_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 7783, 7797);
                    return return_v;
                }


                int
                f_10714_8409_8455(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                index, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 8409, 8455);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_8587_8622(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 8587, 8622);
                    return return_v;
                }


                bool
                f_10714_9147_9188(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.GenericParameterHandle
                token)
                {
                    var return_v = this_param.HasIsUnmanagedAttribute((System.Reflection.Metadata.EntityHandle)token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 9147, 9188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10714_9430_9483(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 9430, 9483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10714_9364_9517(ref Microsoft.CodeAnalysis.DiagnosticInfo
                location1, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                value, Microsoft.CodeAnalysis.DiagnosticInfo
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.DiagnosticInfo)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 9364, 9517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10714_9589_9629(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 9589, 9629);
                    return return_v;
                }


                bool
                f_10714_9648_9749(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 9648, 9749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 4655, 9828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 4655, 9828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MetadataDecoder GetDecoderForConstraintTypes(PEModuleSymbol moduleSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 9840, 10369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9946, 9975);

                MetadataDecoder
                tokenDecoder
                = default(MetadataDecoder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 9989, 10322) || true) && (f_10714_9993_10015(_containingSymbol) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 9989, 10322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10070, 10154);

                    tokenDecoder = f_10714_10085_10153(moduleSymbol, (PEMethodSymbol)_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 9989, 10322);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 9989, 10322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10220, 10307);

                    tokenDecoder = f_10714_10235_10306(moduleSymbol, (PENamedTypeSymbol)_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 9989, 10322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10338, 10358);

                return tokenDecoder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 9840, 10369);

                Microsoft.CodeAnalysis.SymbolKind
                f_10714_9993_10015(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 9993, 10015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10714_10085_10153(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol)context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 10085, 10153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10714_10235_10306(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol)context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 10235, 10306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 9840, 10369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 9840, 10369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations GetConstraintTypeOrDefault(PEModuleSymbol moduleSymbol, MetadataReader metadataReader, MetadataDecoder tokenDecoder, GenericParameterConstraintHandle constraintHandle, ref bool hasUnmanagedModreqPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 10381, 12927);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>> modifiers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10637, 10717);

                var
                constraint = f_10714_10654_10716(metadataReader, constraintHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10731, 10867);

                var
                typeSymbol = f_10714_10748_10866(tokenDecoder, constraint.Type, out modifiers)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10883, 12557) || true) && (f_10714_10887_10914_M(!modifiers.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10714, 10887, 10938) && modifiers.Length > 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 10883, 12557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 10972, 11021);

                    typeSymbol = f_10714_10985_11020();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 10883, 12557);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 10883, 12557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11055, 12557) || true) && (f_10714_11059_11081(typeSymbol) == SpecialType.System_ValueType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 11055, 12557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11298, 11919) || true) && (f_10714_11302_11329_M(!modifiers.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 11298, 11919);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11371, 11419);

                            ModifierInfo<TypeSymbol>
                            m = modifiers.Single()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11441, 11900) || true) && (!m.IsOptional && (DynAbs.Tracing.TraceSender.Expression_True(10714, 11445, 11503) && f_10714_11462_11503(m.Modifier)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 11441, 11900);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11553, 11586);

                                hasUnmanagedModreqPattern = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 11441, 11900);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 11441, 11900);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 11828, 11877);

                                typeSymbol = f_10714_11841_11876();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 11441, 11900);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 11298, 11919);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12049, 12262) || true) && (f_10714_12053_12075(typeSymbol) == SpecialType.System_ValueType && (DynAbs.Tracing.TraceSender.Expression_True(10714, 12053, 12186) && ((_flags & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 12049, 12262);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12228, 12243);

                            return default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 12049, 12262);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 11055, 12557);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 11055, 12557);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12296, 12557) || true) && (f_10714_12300_12327_M(!modifiers.IsDefaultOrEmpty))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 12296, 12557);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12493, 12542);

                            typeSymbol = f_10714_12506_12541();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 12296, 12557);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 11055, 12557);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 10883, 12557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12573, 12623);

                var
                type = TypeWithAnnotations.Create(typeSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12637, 12785);

                type = f_10714_12644_12784(type, constraintHandle, moduleSymbol, accessSymbol: _containingSymbol, nullableContext: _containingSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12799, 12890);

                type = TupleTypeDecoder.DecodeTupleTypesIfApplicable(type, constraintHandle, moduleSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 12904, 12916);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 10381, 12927);

                System.Reflection.Metadata.GenericParameterConstraint
                f_10714_10654_10716(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GenericParameterConstraintHandle
                handle)
                {
                    var return_v = this_param.GetGenericParameterConstraint(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 10654, 10716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10714_10748_10866(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.EntityHandle
                token, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                modifiers)
                {
                    var return_v = this_param.DecodeGenericParameterConstraint(token, out modifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 10748, 10866);
                    return return_v;
                }


                bool
                f_10714_10887_10914_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 10887, 10914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10714_10985_11020()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 10985, 11020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10714_11059_11081(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 11059, 11081);
                    return return_v;
                }


                bool
                f_10714_11302_11329_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 11302, 11329);
                    return return_v;
                }


                bool
                f_10714_11462_11503(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsWellKnownTypeUnmanagedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 11462, 11503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10714_11841_11876()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 11841, 11876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10714_12053_12075(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 12053, 12075);
                    return return_v;
                }


                bool
                f_10714_12300_12327_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 12300, 12327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                f_10714_12506_12541()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 12506, 12541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10714_12644_12784(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                metadataType, System.Reflection.Metadata.GenericParameterConstraintHandle
                targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext)
                {
                    var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: accessSymbol, nullableContext: nullableContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 12644, 12784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 10381, 12927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 10381, 12927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool? IsNotNullableFromConstraintType(TypeWithAnnotations constraintType, ConsList<PETypeParameterSymbol> inProgress, out bool isNonNullableValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10714, 12939, 14120);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13129, 13498) || true) && (!(constraintType.Type is PETypeParameterSymbol typeParameter) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 13133, 13289) || (object)f_10714_13223_13253(typeParameter) != f_10714_13257_13289(f_10714_13257_13272(inProgress))) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 13133, 13366) || f_10714_13310_13355(typeParameter).Count == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 13129, 13498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13400, 13483);

                    return f_10714_13407_13482(constraintType, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 13129, 13498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13514, 13613);

                bool?
                isNotNullable = f_10714_13536_13612(typeParameter, inProgress, out isNonNullableValueType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13629, 13770) || true) && (isNonNullableValueType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 13629, 13770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13689, 13725);

                    f_10714_13689_13724(isNotNullable == true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13743, 13755);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 13629, 13770);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13786, 14081) || true) && (f_10714_13790_13837(constraintType.NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 13790, 13863) || isNotNullable == false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 13786, 14081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13897, 13910);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 13786, 14081);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 13786, 14081);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 13944, 14081) || true) && (f_10714_13948_13995(constraintType.NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 13948, 14020) || isNotNullable == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 13944, 14081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14054, 14066);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 13944, 14081);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 13786, 14081);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14097, 14109);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10714, 12939, 14120);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_13223_13253(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 13223, 13253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                f_10714_13257_13272(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 13257, 13272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_13257_13289(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 13257, 13289);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                f_10714_13310_13355(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetConstraintHandleCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13310, 13355);
                    return return_v;
                }


                bool?
                f_10714_13407_13482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintType(constraintType, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13407, 13482);
                    return return_v;
                }


                bool?
                f_10714_13536_13612(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress, out bool
                isNonNullableValueType)
                {
                    var return_v = this_param.CalculateIsNotNullable(inProgress, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13536, 13612);
                    return return_v;
                }


                int
                f_10714_13689_13724(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13689, 13724);
                    return 0;
                }


                bool
                f_10714_13790_13837(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13790, 13837);
                    return return_v;
                }


                bool
                f_10714_13948_13995(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 13948, 13995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 12939, 14120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 12939, 14120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool? CalculateIsNotNullable(ConsList<PETypeParameterSymbol> inProgress, out bool isNonNullableValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 14132, 15565);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14270, 14419) || true) && (f_10714_14274_14308(inProgress, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 14270, 14419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14342, 14373);

                    isNonNullableValueType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14391, 14404);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 14270, 14419);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14435, 14575) || true) && (f_10714_14439_14466(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 14435, 14575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14500, 14530);

                    isNonNullableValueType = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14548, 14560);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 14435, 14575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14591, 14669);

                bool?
                fromNonTypeConstraints = f_10714_14622_14668(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14685, 14783);

                ImmutableArray<TypeWithAnnotations>
                constraintTypes = f_10714_14739_14782(this, inProgress)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14799, 14954) || true) && (constraintTypes.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 14799, 14954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14860, 14891);

                    isNonNullableValueType = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14909, 14939);

                    return fromNonTypeConstraints;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 14799, 14954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 14970, 15078);

                bool?
                fromTypes = f_10714_14988_15077(constraintTypes, inProgress, out isNonNullableValueType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15094, 15231) || true) && (isNonNullableValueType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 15094, 15231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15154, 15186);

                    f_10714_15154_15185(fromTypes == true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15204, 15216);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 15094, 15231);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15247, 15369) || true) && (fromTypes == true || (DynAbs.Tracing.TraceSender.Expression_False(10714, 15251, 15303) || fromNonTypeConstraints == false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 15247, 15369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15337, 15354);

                    return fromTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 15247, 15369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15385, 15464);

                f_10714_15385_15463(fromNonTypeConstraints == null || (DynAbs.Tracing.TraceSender.Expression_False(10714, 15398, 15462) || fromNonTypeConstraints == true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15478, 15510);

                f_10714_15478_15509(fromTypes != true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15524, 15554);

                return fromNonTypeConstraints;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 14132, 15565);

                bool
                f_10714_14274_14308(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 14274, 14308);
                    return return_v;
                }


                bool
                f_10714_14439_14466(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 14439, 14466);
                    return return_v;
                }


                bool?
                f_10714_14622_14668(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.CalculateIsNotNullableFromNonTypeConstraints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 14622, 14668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_14739_14782(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetDeclaredConstraintTypes(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 14739, 14782);
                    return return_v;
                }


                bool?
                f_10714_14988_15077(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintTypes(constraintTypes, inProgress, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 14988, 15077);
                    return return_v;
                }


                int
                f_10714_15154_15185(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 15154, 15185);
                    return 0;
                }


                int
                f_10714_15385_15463(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 15385, 15463);
                    return 0;
                }


                int
                f_10714_15478_15509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 15478, 15509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 14132, 15565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 14132, 15565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool? IsNotNullableFromConstraintTypes(ImmutableArray<TypeWithAnnotations> constraintTypes, ConsList<PETypeParameterSymbol> inProgress, out bool isNonNullableValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10714, 15577, 16610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15785, 15833);

                f_10714_15785_15832(f_10714_15798_15831_M(!constraintTypes.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15849, 15880);

                isNonNullableValueType = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15894, 15915);

                bool?
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 15929, 16569);
                    foreach (TypeWithAnnotations constraintType in f_10714_15976_15991_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 15929, 16569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16025, 16130);

                        bool?
                        fromType = f_10714_16042_16129(constraintType, inProgress, out isNonNullableValueType)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16150, 16302) || true) && (isNonNullableValueType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 16150, 16302);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16218, 16249);

                            f_10714_16218_16248(fromType == true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16271, 16283);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 16150, 16302);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16322, 16554) || true) && (fromType == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 16322, 16554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16384, 16398);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 16322, 16554);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 16322, 16554);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16440, 16554) || true) && (fromType == null && (DynAbs.Tracing.TraceSender.Expression_True(10714, 16444, 16479) && result == false))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 16440, 16554);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16521, 16535);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 16440, 16554);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 16322, 16554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 15929, 16569);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10714, 1, 641);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10714, 1, 641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16585, 16599);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10714, 15577, 16610);

                bool
                f_10714_15798_15831_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 15798, 15831);
                    return return_v;
                }


                int
                f_10714_15785_15832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 15785, 15832);
                    return 0;
                }


                bool?
                f_10714_16042_16129(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintType(constraintType, inProgress, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 16042, 16129);
                    return return_v;
                }


                int
                f_10714_16218_16248(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 16218, 16248);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_15976_15991_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 15976, 15991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 15577, 16610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 15577, 16610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GenericParameterConstraintHandleCollection GetConstraintHandleCollection(PEModule module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 16622, 17325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16744, 16799);

                GenericParameterConstraintHandleCollection
                constraints
                = default(GenericParameterConstraintHandleCollection);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 16851, 16933);

                    constraints = f_10714_16865_16915(f_10714_16865_16886(module), _handle).GetConstraints();
                }
                catch (BadImageFormatException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10714, 16962, 17279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17026, 17092);

                    constraints = default(GenericParameterConstraintHandleCollection);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17110, 17264);

                    f_10714_17110_17263(ref _lazyConstraintsUseSiteErrorInfo, f_10714_17176_17229(ErrorCode.ERR_BindToBogus, this), CSDiagnosticInfo.EmptyErrorInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10714, 16962, 17279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17295, 17314);

                return constraints;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 16622, 17325);

                System.Reflection.Metadata.MetadataReader
                f_10714_16865_16886(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 16865, 16886);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameter
                f_10714_16865_16915(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.GenericParameterHandle
                handle)
                {
                    var return_v = this_param.GetGenericParameter(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 16865, 16915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10714_17176_17229(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 17176, 17229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10714_17110_17263(ref Microsoft.CodeAnalysis.DiagnosticInfo
                location1, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                value, Microsoft.CodeAnalysis.DiagnosticInfo
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.DiagnosticInfo)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 17110, 17263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 16622, 17325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 16622, 17325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GenericParameterConstraintHandleCollection GetConstraintHandleCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 17337, 17540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17444, 17529);

                return f_10714_17451_17528(this, f_10714_17481_17527(((PEModuleSymbol)f_10714_17498_17519(this))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 17337, 17540);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10714_17498_17519(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 17498, 17519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10714_17481_17527(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 17481, 17527);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                f_10714_17451_17528(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.PEModule
                module)
                {
                    var return_v = this_param.GetConstraintHandleCollection(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 17451, 17528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 17337, 17540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 17337, 17540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 17627, 17713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17663, 17698);

                    return f_10714_17670_17697(_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 17627, 17713);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10714_17670_17697(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 17670, 17697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 17552, 17724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 17552, 17724);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 17834, 17930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 17870, 17915);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 17834, 17930);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 17736, 17941);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 17736, 17941);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasConstructorConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 18023, 18153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 18059, 18138);

                    return (_flags & GenericParameterAttributes.DefaultConstructorConstraint) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 18023, 18153);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 17953, 18164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 17953, 18164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasReferenceTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 18248, 18373);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 18284, 18358);

                    return (_flags & GenericParameterAttributes.ReferenceTypeConstraint) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 18248, 18373);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 18176, 18384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 18176, 18384);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReferenceTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 18476, 18615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 18512, 18600);

                    return f_10714_18519_18599(f_10714_18563_18598());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 18476, 18615);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_18563_18598()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 18563, 18598);
                        return return_v;
                    }


                    bool
                    f_10714_18519_18599(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsReferenceTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 18519, 18599);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 18396, 18626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 18396, 18626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private byte GetNullableAttributeValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 18857, 19168);
                byte value = default(byte);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 18922, 19087) || true) && (f_10714_18926_19025(f_10714_18926_18972(((PEModuleSymbol)f_10714_18943_18964(this))), _handle, out value, out _))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 18922, 19087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19059, 19072);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 18922, 19087);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19101, 19157);

                return f_10714_19108_19151(_containingSymbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<byte?>(10714, 19108, 19156) ?? 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 18857, 19168);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10714_18943_18964(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 18943, 18964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10714_18926_18972(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 18926, 18972);
                    return return_v;
                }


                bool
                f_10714_18926_19025(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.GenericParameterHandle
                token, out byte
                defaultTransform, out System.Collections.Immutable.ImmutableArray<byte>
                nullableTransforms)
                {
                    var return_v = this_param.HasNullableAttribute((System.Reflection.Metadata.EntityHandle)token, out defaultTransform, out nullableTransforms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 18926, 19025);
                    return return_v;
                }


                byte?
                f_10714_19108_19151(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 19108, 19151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 18857, 19168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 18857, 19168);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool? ReferenceTypeConstraintIsNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 19262, 19784);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19298, 19403) || true) && (f_10714_19302_19329_M(!HasReferenceTypeConstraint))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 19298, 19403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19371, 19384);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 19298, 19403);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19423, 19737);

                    switch (f_10714_19431_19458(this))
                    {

                        case NullableAnnotationExtensions.AnnotatedAttributeValue:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 19423, 19737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19584, 19596);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 19423, 19737);

                        case NullableAnnotationExtensions.NotAnnotatedAttributeValue:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 19423, 19737);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19705, 19718);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 19423, 19737);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19757, 19769);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 19262, 19784);

                    bool
                    f_10714_19302_19329_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 19302, 19329);
                        return return_v;
                    }


                    byte
                    f_10714_19431_19458(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetNullableAttributeValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 19431, 19458);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 19180, 19795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 19180, 19795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasNotNullConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 19873, 20174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 19909, 20159);

                    return (_flags & (GenericParameterAttributes.NotNullableValueTypeConstraint | GenericParameterAttributes.ReferenceTypeConstraint)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10714, 19916, 20158) && f_10714_20072_20099(this) == NullableAnnotationExtensions.NotAnnotatedAttributeValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 19873, 20174);

                    byte
                    f_10714_20072_20099(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetNullableAttributeValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 20072, 20099);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 19807, 20185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 19807, 20185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool? IsNotNullable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 20259, 22509);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20295, 22442) || true) && ((_flags & (GenericParameterAttributes.NotNullableValueTypeConstraint | GenericParameterAttributes.ReferenceTypeConstraint)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10714, 20299, 20473) && f_10714_20452_20473_M(!HasNotNullConstraint)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 20295, 22442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20515, 20574);

                        var
                        moduleSymbol = ((PEModuleSymbol)f_10714_20551_20572(this))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20596, 20634);

                        PEModule
                        module = f_10714_20614_20633(moduleSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20656, 20751);

                        GenericParameterConstraintHandleCollection
                        constraints = f_10714_20713_20750(this, module)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20775, 22423) || true) && (constraints.Count == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 20775, 22423);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20851, 21036) || true) && (f_10714_20855_20882(this) == NullableAnnotationExtensions.AnnotatedAttributeValue)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 20851, 21036);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 20996, 21009);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 20851, 21036);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21064, 21076);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 20775, 22423);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 20775, 22423);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21126, 22423) || true) && (f_10714_21130_21195(this, ConsList<PETypeParameterSymbol>.Empty).IsEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 21126, 22423);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21370, 21439);

                                var
                                symbolsBuilder = f_10714_21391_21438()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21465, 21539);

                                MetadataDecoder
                                tokenDecoder = f_10714_21496_21538(this, moduleSymbol)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21567, 21606);

                                bool
                                hasUnmanagedModreqPattern = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21632, 21675);

                                var
                                metadataReader = f_10714_21653_21674(module)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21701, 22295);
                                    foreach (var constraintHandle in f_10714_21734_21745_I(constraints))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 21701, 22295);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21803, 21950);

                                        TypeWithAnnotations
                                        type = f_10714_21830_21949(this, moduleSymbol, metadataReader, tokenDecoder, constraintHandle, ref hasUnmanagedModreqPattern)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 21982, 22058);

                                        f_10714_21982_22057(type.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10714, 21995, 22056) && type.SpecialType == SpecialType.System_Object));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22088, 22211) || true) && (f_10714_22092_22105_M(!type.HasType))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 22088, 22211);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22171, 22180);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 22088, 22211);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22243, 22268);

                                        f_10714_22243_22267(
                                                                    symbolsBuilder, type);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 21701, 22295);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10714, 1, 595);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10714, 1, 595);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22323, 22400);

                                return f_10714_22330_22399(f_10714_22363_22398(symbolsBuilder));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 21126, 22423);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 20775, 22423);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 20295, 22442);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22462, 22494);

                    return f_10714_22469_22493(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 20259, 22509);

                    bool
                    f_10714_20452_20473_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 20452, 20473);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10714_20551_20572(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 20551, 20572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10714_20614_20633(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 20614, 20633);
                        return return_v;
                    }


                    System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                    f_10714_20713_20750(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param, Microsoft.CodeAnalysis.PEModule
                    module)
                    {
                        var return_v = this_param.GetConstraintHandleCollection(module);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 20713, 20750);
                        return return_v;
                    }


                    byte
                    f_10714_20855_20882(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetNullableAttributeValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 20855, 20882);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_21130_21195(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetDeclaredConstraintTypes(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21130, 21195);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_21391_21438()
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21391, 21438);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    f_10714_21496_21538(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol)
                    {
                        var return_v = this_param.GetDecoderForConstraintTypes(moduleSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21496, 21538);
                        return return_v;
                    }


                    System.Reflection.Metadata.MetadataReader
                    f_10714_21653_21674(Microsoft.CodeAnalysis.PEModule
                    this_param)
                    {
                        var return_v = this_param.MetadataReader;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 21653, 21674);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10714_21830_21949(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    moduleSymbol, System.Reflection.Metadata.MetadataReader
                    metadataReader, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                    tokenDecoder, System.Reflection.Metadata.GenericParameterConstraintHandle
                    constraintHandle, ref bool
                    hasUnmanagedModreqPattern)
                    {
                        var return_v = this_param.GetConstraintTypeOrDefault(moduleSymbol, metadataReader, tokenDecoder, constraintHandle, ref hasUnmanagedModreqPattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21830, 21949);
                        return return_v;
                    }


                    int
                    f_10714_21982_22057(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21982, 22057);
                        return 0;
                    }


                    bool
                    f_10714_22092_22105_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 22092, 22105);
                        return return_v;
                    }


                    int
                    f_10714_22243_22267(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22243, 22267);
                        return 0;
                    }


                    System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                    f_10714_21734_21745_I(System.Reflection.Metadata.GenericParameterConstraintHandleCollection
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 21734, 21745);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_22363_22398(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22363, 22398);
                        return return_v;
                    }


                    bool?
                    f_10714_22330_22399(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = IsNotNullableFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22330, 22399);
                        return return_v;
                    }


                    bool?
                    f_10714_22469_22493(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.CalculateIsNotNullable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22469, 22493);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 20197, 22520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 20197, 22520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasValueTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 22600, 22732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22636, 22717);

                    return (_flags & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 22600, 22732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 22532, 22743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 22532, 22743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueTypeFromConstraintTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 22831, 23022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22867, 22905);

                    f_10714_22867_22904(f_10714_22880_22903_M(!HasValueTypeConstraint));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 22923, 23007);

                    return f_10714_22930_23006(f_10714_22970_23005());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 22831, 23022);

                    bool
                    f_10714_22880_22903_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 22880, 22903);
                        return return_v;
                    }


                    int
                    f_10714_22867_22904(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22867, 22904);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_22970_23005()
                    {
                        var return_v = ConstraintTypesNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 22970, 23005);
                        return return_v;
                    }


                    bool
                    f_10714_22930_23006(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    constraintTypes)
                    {
                        var return_v = CalculateIsValueTypeFromConstraintTypes(constraintTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 22930, 23006);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 22755, 23033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 22755, 23033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasUnmanagedTypeConstraint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 23117, 23302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23153, 23219);

                    f_10714_23153_23218(this, ConsList<PETypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23237, 23287);

                    return f_10714_23244_23286(this._lazyHasIsUnmanagedConstraint);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 23117, 23302);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10714_23153_23218(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetDeclaredConstraintTypes(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 23153, 23218);
                        return return_v;
                    }


                    bool
                    f_10714_23244_23286(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 23244, 23286);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 23045, 23313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 23045, 23313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override VarianceKind Variance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 23387, 23510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23423, 23495);

                    return (VarianceKind)(_flags & GenericParameterAttributes.VarianceMask);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 23387, 23510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 23325, 23521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 23325, 23521);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void EnsureAllConstraintsAreResolved()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 23533, 23982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23614, 23971) || true) && (!f_10714_23619_23638(_lazyBounds))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 23614, 23971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23672, 23890);

                    var
                    typeParameters = (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 23693, 23738) || (((f_10714_23694_23716(_containingSymbol) == SymbolKind.Method) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 23762, 23812)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 23836, 23889))) ? f_10714_23762_23812(((PEMethodSymbol)_containingSymbol)) : f_10714_23836_23889(((PENamedTypeSymbol)_containingSymbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 23908, 23956);

                    f_10714_23908_23955(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 23614, 23971);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 23533, 23982);

                bool
                f_10714_23619_23638(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                boundsOpt)
                {
                    var return_v = boundsOpt.IsSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 23619, 23638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10714_23694_23716(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 23694, 23716);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10714_23762_23812(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 23762, 23812);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10714_23836_23889(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 23836, 23889);
                    return return_v;
                }


                int
                f_10714_23908_23955(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    EnsureAllConstraintsAreResolved(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 23908, 23955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 23533, 23982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 23533, 23982);
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 23994, 24291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24133, 24173);

                var
                bounds = f_10714_24146_24172(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24187, 24280);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 24194, 24210) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 24213, 24235)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 24238, 24279))) ? bounds.ConstraintTypes : ImmutableArray<TypeWithAnnotations>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 23994, 24291);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_24146_24172(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 24146, 24172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 23994, 24291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 23994, 24291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 24303, 24582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24433, 24473);

                var
                bounds = f_10714_24446_24472(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24487, 24571);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 24494, 24510) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 24513, 24530)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 24533, 24570))) ? bounds.Interfaces : ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 24303, 24582);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_24446_24472(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 24446, 24472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 24303, 24582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 24303, 24582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 24594, 24861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24716, 24756);

                var
                bounds = f_10714_24729_24755(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24770, 24850);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 24777, 24793) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 24796, 24821)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 24824, 24849))) ? bounds.EffectiveBaseClass : f_10714_24824_24849(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 24594, 24861);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_24729_24755(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 24729, 24755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10714_24824_24849(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetDefaultBaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 24824, 24849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 24594, 24861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 24594, 24861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 24873, 25129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 24987, 25027);

                var
                bounds = f_10714_25000_25026(this, inProgress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25041, 25118);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 25048, 25064) || (((bounds != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 25067, 25089)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 25092, 25117))) ? bounds.DeducedBaseType : f_10714_25092_25117(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 24873, 25129);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_25000_25026(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetBounds(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 25000, 25026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10714_25092_25117(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetDefaultBaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 25092, 25117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 24873, 25129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 24873, 25129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 25141, 25877);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25233, 25821) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 25233, 25821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25302, 25371);

                    var
                    containingPEModuleSymbol = (PEModuleSymbol)f_10714_25349_25370(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25391, 25692);

                    var
                    loadedCustomAttributes = f_10714_25420_25691(containingPEModuleSymbol, f_10714_25495_25501(), out _, (DynAbs.Tracing.TraceSender.Conditional_F1(10714, 25610, 25636) || ((f_10714_25610_25636() && DynAbs.Tracing.TraceSender.Conditional_F2(10714, 25639, 25680)) || DynAbs.Tracing.TraceSender.Conditional_F3(10714, 25683, 25690))) ? AttributeDescription.IsUnmanagedAttribute : default)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25712, 25806);

                    f_10714_25712_25805(ref _lazyCustomAttributes, loadedCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 25233, 25821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25837, 25866);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 25141, 25877);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10714_25349_25370(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 25349, 25370);
                    return return_v;
                }


                System.Reflection.Metadata.GenericParameterHandle
                f_10714_25495_25501()
                {
                    var return_v = Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 25495, 25501);
                    return return_v;
                }


                bool
                f_10714_25610_25636()
                {
                    var return_v = HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 25610, 25636);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10714_25420_25691(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.GenericParameterHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1)
                {
                    var return_v = this_param.GetCustomAttributesForToken((System.Reflection.Metadata.EntityHandle)token, out filteredOutAttribute1, filterOut1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 25420, 25691);
                    return return_v;
                }


                bool
                f_10714_25712_25805(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 25712, 25805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 25141, 25877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 25141, 25877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterBounds GetBounds(ConsList<TypeParameterSymbol> inProgress)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 25889, 28335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 25993, 26043);

                f_10714_25993_26042(!f_10714_26007_26041(inProgress, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26057, 26165);

                f_10714_26057_26164(!f_10714_26071_26087(inProgress) || (DynAbs.Tracing.TraceSender.Expression_False(10714, 26070, 26163) || f_10714_26091_26163(f_10714_26107_26139(f_10714_26107_26122(inProgress)), f_10714_26141_26162(this))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26181, 28177) || true) && (_lazyBounds == TypeParameterBounds.Unset)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 26181, 28177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26259, 26347);

                    var
                    constraintTypes = f_10714_26281_26346(this, ConsList<PETypeParameterSymbol>.Empty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26365, 26406);

                    f_10714_26365_26405(f_10714_26378_26404_M(!constraintTypes.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26426, 26500);

                    var
                    diagnostics = f_10714_26444_26499()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26518, 26593);

                    ArrayBuilder<TypeParameterDiagnosticInfo>
                    useSiteDiagnosticsBuilder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26611, 26722);

                    bool
                    inherited = (f_10714_26629_26651(_containingSymbol) == SymbolKind.Method) && (DynAbs.Tracing.TraceSender.Expression_True(10714, 26628, 26721) && f_10714_26677_26721(((MethodSymbol)_containingSymbol)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 26740, 27028);

                    var
                    bounds = f_10714_26753_27027(this, f_10714_26772_26806(f_10714_26772_26795(this)), f_10714_26808_26832(inProgress, this), constraintTypes, inherited, currentCompilation: null, diagnosticsBuilder: diagnostics, useSiteDiagnosticsBuilder: ref useSiteDiagnosticsBuilder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27046, 27078);

                    DiagnosticInfo
                    errorInfo = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27098, 27895) || true) && (f_10714_27102_27119(diagnostics) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27098, 27895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27165, 27207);

                        errorInfo = diagnostics[0].DiagnosticInfo;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27098, 27895);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27098, 27895);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27249, 27895) || true) && (useSiteDiagnosticsBuilder != null && (DynAbs.Tracing.TraceSender.Expression_True(10714, 27253, 27325) && f_10714_27290_27321(useSiteDiagnosticsBuilder) > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27249, 27895);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27367, 27876);
                                foreach (var diag in f_10714_27388_27413_I(useSiteDiagnosticsBuilder))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27367, 27876);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27463, 27853) || true) && (f_10714_27467_27495(diag.DiagnosticInfo) == DiagnosticSeverity.Error)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27463, 27853);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27581, 27613);

                                        errorInfo = diag.DiagnosticInfo;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10714, 27643, 27649);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27463, 27853);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27463, 27853);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27707, 27853) || true) && ((object)errorInfo == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10714, 27707, 27853);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27794, 27826);

                                            errorInfo = diag.DiagnosticInfo;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27707, 27853);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27463, 27853);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27367, 27876);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10714, 1, 510);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10714, 1, 510);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27249, 27895);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 27098, 27895);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27915, 27934);

                    f_10714_27915_27933(
                                    diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 27954, 28064);

                    f_10714_27954_28063(ref _lazyConstraintsUseSiteErrorInfo, errorInfo, CSDiagnosticInfo.EmptyErrorInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28082, 28162);

                    f_10714_28082_28161(ref _lazyBounds, bounds, TypeParameterBounds.Unset);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10714, 26181, 28177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28193, 28291);

                f_10714_28193_28290(!f_10714_28207_28289(_lazyConstraintsUseSiteErrorInfo, CSDiagnosticInfo.EmptyErrorInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28305, 28324);

                return _lazyBounds;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 25889, 28335);

                bool
                f_10714_26007_26041(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26007, 26041);
                    return return_v;
                }


                int
                f_10714_25993_26042(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 25993, 26042);
                    return 0;
                }


                bool
                f_10714_26071_26087(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26071, 26087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10714_26107_26122(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26107, 26122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_26107_26139(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26107, 26139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10714_26141_26162(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26141, 26162);
                    return return_v;
                }


                bool
                f_10714_26091_26163(Microsoft.CodeAnalysis.CSharp.Symbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26091, 26163);
                    return return_v;
                }


                int
                f_10714_26057_26164(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26057, 26164);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10714_26281_26346(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetDeclaredConstraintTypes(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26281, 26346);
                    return return_v;
                }


                bool
                f_10714_26378_26404_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26378, 26404);
                    return return_v;
                }


                int
                f_10714_26365_26405(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26365, 26405);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10714_26444_26499()
                {
                    var return_v = ArrayBuilder<TypeParameterDiagnosticInfo>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26444, 26499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10714_26629_26651(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26629, 26651);
                    return return_v;
                }


                bool
                f_10714_26677_26721(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26677, 26721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10714_26772_26795(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26772, 26795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10714_26772_26806(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 26772, 26806);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10714_26808_26832(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26808, 26832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_26753_27027(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                typeParameter, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                corLibrary, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes, bool
                inherited, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                diagnosticsBuilder, ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>?
                useSiteDiagnosticsBuilder)
                {
                    var return_v = typeParameter.ResolveBounds(corLibrary, inProgress, constraintTypes, inherited, currentCompilation: currentCompilation, diagnosticsBuilder: diagnosticsBuilder, useSiteDiagnosticsBuilder: ref useSiteDiagnosticsBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 26753, 27027);
                    return return_v;
                }


                int
                f_10714_27102_27119(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 27102, 27119);
                    return return_v;
                }


                int
                f_10714_27290_27321(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 27290, 27321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10714_27467_27495(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 27467, 27495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                f_10714_27388_27413_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 27388, 27413);
                    return return_v;
                }


                int
                f_10714_27915_27933(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 27915, 27933);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10714_27954_28063(ref Microsoft.CodeAnalysis.DiagnosticInfo
                location1, Microsoft.CodeAnalysis.DiagnosticInfo?
                value, Microsoft.CodeAnalysis.DiagnosticInfo
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 27954, 28063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                f_10714_28082_28161(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterBounds
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28082, 28161);
                    return return_v;
                }


                bool
                f_10714_28207_28289(Microsoft.CodeAnalysis.DiagnosticInfo?
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28207, 28289);
                    return return_v;
                }


                int
                f_10714_28193_28290(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28193, 28290);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 25889, 28335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 25889, 28335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetConstraintsUseSiteErrorInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 28347, 28648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28437, 28471);

                f_10714_28437_28470(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28485, 28583);

                f_10714_28485_28582(!f_10714_28499_28581(_lazyConstraintsUseSiteErrorInfo, CSDiagnosticInfo.EmptyErrorInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28597, 28637);

                return _lazyConstraintsUseSiteErrorInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 28347, 28648);

                int
                f_10714_28437_28470(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    this_param.EnsureAllConstraintsAreResolved();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28437, 28470);
                    return 0;
                }


                bool
                f_10714_28499_28581(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28499, 28581);
                    return return_v;
                }


                int
                f_10714_28485_28582(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28485, 28582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 28347, 28648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 28347, 28648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDefaultBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 28660, 28813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28729, 28802);

                return f_10714_28736_28801(f_10714_28736_28759(this), SpecialType.System_Object);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 28660, 28813);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10714_28736_28759(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PETypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 28736, 28759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10714_28736_28801(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 28736, 28801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 28660, 28813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 28660, 28813);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10714, 28938, 28958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10714, 28944, 28956);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10714, 28938, 28958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10714, 28825, 28969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 28825, 28969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PETypeParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10714, 709, 28976);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10714, 709, 28976);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10714, 709, 28976);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10714, 709, 28976);

        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10714_1913_1925_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10714, 1696, 1992);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10714_2215_2227_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10714, 2004, 2291);
            return return_v;
        }


        int
        f_10714_2509_2551(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 2509, 2551);
            return 0;
        }


        int
        f_10714_2566_2610(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 2566, 2610);
            return 0;
        }


        int
        f_10714_2625_2651(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 2625, 2651);
            return 0;
        }


        bool
        f_10714_2679_2692_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 2679, 2692);
            return return_v;
        }


        int
        f_10714_2666_2693(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 2666, 2693);
            return 0;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10714_2850_2869(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10714, 2850, 2869);
            return return_v;
        }


        int
        f_10714_2850_2927(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.GenericParameterHandle
        handle, out string
        name, out System.Reflection.GenericParameterAttributes
        flags)
        {
            this_param.GetGenericParamPropsOrThrow(handle, out name, out flags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 2850, 2927);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10714_3183_3236(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10714, 3183, 3236);
            return return_v;
        }

    }
}
