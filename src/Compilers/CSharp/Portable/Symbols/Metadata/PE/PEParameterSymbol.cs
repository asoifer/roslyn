// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal class PEParameterSymbol : ParameterSymbol
    {
        [Flags]
        private enum WellKnownAttributeFlags
        {
            HasIDispatchConstantAttribute = 0x1 << 0,
            HasIUnknownConstantAttribute = 0x1 << 1,
            HasCallerFilePathAttribute = 0x1 << 2,
            HasCallerLineNumberAttribute = 0x1 << 3,
            HasCallerMemberNameAttribute = 0x1 << 4,
            IsCallerFilePath = 0x1 << 5,
            IsCallerLineNumber = 0x1 << 6,
            IsCallerMemberName = 0x1 << 7,
        }

        private struct PackedFlags
        {

            private const int
            WellKnownAttributeDataOffset = 0
            ;

            private const int
            WellKnownAttributeCompletionFlagOffset = 8
            ;

            private const int
            RefKindOffset = 16
            ;

            private const int
            FlowAnalysisAnnotationsOffset = 20
            ;

            private const int
            RefKindMask = 0x3
            ;

            private const int
            WellKnownAttributeDataMask = 0xFF
            ;

            private const int
            WellKnownAttributeCompletionFlagMask = WellKnownAttributeDataMask
            ;

            private const int
            FlowAnalysisAnnotationsMask = 0xFF
            ;

            private const int
            HasNameInMetadataBit = 0x1 << 18
            ;

            private const int
            FlowAnalysisAnnotationsCompletionBit = 0x1 << 19
            ;

            private const int
            AllWellKnownAttributesCompleteNoData = WellKnownAttributeCompletionFlagMask << WellKnownAttributeCompletionFlagOffset
            ;

            private int _bits;

            public RefKind RefKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 2765, 2830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2771, 2828);

                        return (RefKind)((_bits >> RefKindOffset) & RefKindMask);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 2765, 2830);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 2710, 2845);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 2710, 2845);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool HasNameInMetadata
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 2923, 2974);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2929, 2972);

                        return (_bits & HasNameInMetadataBit) != 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 2923, 2974);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 2861, 2989);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 2861, 2989);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static PackedFlags()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10712, 3016, 3447);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 1851, 1883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 1916, 1958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 1991, 2009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2042, 2076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2111, 2128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2161, 2194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2227, 2292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2325, 2359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2394, 2426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2459, 2507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 2542, 2659);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3129, 3228);

                    f_10712_3129_3227(f_10712_3142_3226(WellKnownAttributeDataMask));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3246, 3314);

                    f_10712_3246_3313(f_10712_3259_3312(RefKindMask));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3332, 3432);

                    f_10712_3332_3431(f_10712_3345_3430(FlowAnalysisAnnotationsMask));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10712, 3016, 3447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 3016, 3447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 3016, 3447);
                }
            }

            public PackedFlags(RefKind refKind, bool attributesAreComplete, bool hasNameInMetadata)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10712, 3471, 3944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3591, 3655);

                    int
                    refKindBits = ((int)refKind & RefKindMask) << RefKindOffset
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3673, 3758);

                    int
                    attributeBits = (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 3693, 3714) || ((attributesAreComplete && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 3717, 3753)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 3756, 3757))) ? AllWellKnownAttributesCompleteNoData : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3776, 3849);

                    int
                    hasNameInMetadataBits = (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 3804, 3821) || ((hasNameInMetadata && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 3824, 3844)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 3847, 3848))) ? HasNameInMetadataBit : 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 3869, 3929);

                    _bits = refKindBits | attributeBits | hasNameInMetadataBits;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10712, 3471, 3944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 3471, 3944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 3471, 3944);
                }
            }

            public bool SetWellKnownAttribute(WellKnownAttributeFlags flag, bool value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 3960, 4486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4114, 4182);

                    int
                    bitsToSet = (int)flag << WellKnownAttributeCompletionFlagOffset
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4200, 4369) || true) && (value)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 4200, 4369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4293, 4350);

                        bitsToSet |= ((int)flag << WellKnownAttributeDataOffset);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 4200, 4369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4389, 4440);

                    f_10712_4389_4439(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4458, 4471);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 3960, 4486);

                    bool
                    f_10712_4389_4439(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 4389, 4439);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 3960, 4486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 3960, 4486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetWellKnownAttribute(WellKnownAttributeFlags flag, out bool value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 4502, 4919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4617, 4637);

                    int
                    theBits = _bits
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4739, 4808);

                    value = (theBits & ((int)flag << WellKnownAttributeDataOffset)) != 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 4826, 4904);

                    return (theBits & ((int)flag << WellKnownAttributeCompletionFlagOffset)) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 4502, 4919);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 4502, 4919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 4502, 4919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool SetFlowAnalysisAnnotations(FlowAnalysisAnnotations value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 4935, 5261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5037, 5170);

                    int
                    bitsToSet = FlowAnalysisAnnotationsCompletionBit | (((int)value & FlowAnalysisAnnotationsMask) << FlowAnalysisAnnotationsOffset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5188, 5246);

                    return f_10712_5195_5245(ref _bits, bitsToSet);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 4935, 5261);

                    bool
                    f_10712_5195_5245(ref int
                    flags, int
                    toSet)
                    {
                        var return_v = ThreadSafeFlagOperations.Set(ref flags, toSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 5195, 5245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 4935, 5261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 4935, 5261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool TryGetFlowAnalysisAnnotations(out FlowAnalysisAnnotations value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 5277, 5801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5386, 5406);

                    int
                    theBits = _bits
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5508, 5616);

                    value = (FlowAnalysisAnnotations)((theBits >> FlowAnalysisAnnotationsOffset) & FlowAnalysisAnnotationsMask);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5634, 5701);

                    var
                    result = (theBits & FlowAnalysisAnnotationsCompletionBit) != 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5719, 5754);

                    f_10712_5719_5753(value == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10712, 5732, 5752) || result));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5772, 5786);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 5277, 5801);

                    int
                    f_10712_5719_5753(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 5719, 5753);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 5277, 5801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 5277, 5801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static bool
            f_10712_3142_3226(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<WellKnownAttributeFlags>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3142, 3226);
                return return_v;
            }


            static int
            f_10712_3129_3227(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3129, 3227);
                return 0;
            }


            static bool
            f_10712_3259_3312(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<RefKind>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3259, 3312);
                return return_v;
            }


            static int
            f_10712_3246_3313(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3246, 3313);
                return 0;
            }


            static bool
            f_10712_3345_3430(int
            mask)
            {
                var return_v = EnumUtilities.ContainsAllValues<FlowAnalysisAnnotations>(mask);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3345, 3430);
                return return_v;
            }


            static int
            f_10712_3332_3431(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 3332, 3431);
                return 0;
            }

        }

        private readonly Symbol _containingSymbol;

        private readonly string _name;

        private readonly TypeWithAnnotations _typeWithAnnotations;

        private readonly ParameterHandle _handle;

        private readonly ParameterAttributes _flags;

        private readonly PEModuleSymbol _moduleSymbol;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private ConstantValue _lazyDefaultValue;

        private ThreeState _lazyIsParams;

        private ImmutableArray<CSharpAttributeData> _lazyHiddenAttributes;

        private readonly ushort _ordinal;

        private PackedFlags _packedFlags;

        internal static PEParameterSymbol Create(
                    PEModuleSymbol moduleSymbol,
                    PEMethodSymbol containingSymbol,
                    bool isContainingSymbolVirtual,
                    int ordinal,
                    ParamInfo<TypeSymbol> parameterInfo,
                    Symbol nullableContext,
                    bool isReturn,
                    out bool isBad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10712, 6638, 7320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 7007, 7309);

                return f_10712_7014_7308(moduleSymbol, containingSymbol, isContainingSymbolVirtual, ordinal, parameterInfo.IsByRef, parameterInfo.RefCustomModifiers, parameterInfo.Type, parameterInfo.Handle, nullableContext, parameterInfo.CustomModifiers, isReturn, out isBad);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10712, 6638, 7320);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10712_7014_7308(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                containingSymbol, bool
                isContainingSymbolVirtual, int
                ordinal, bool
                isByRef, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Reflection.Metadata.ParameterHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers, bool
                isReturn, out bool
                isBad)
                {
                    var return_v = Create(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, isContainingSymbolVirtual, ordinal, isByRef, refCustomModifiers, type, handle, nullableContext, customModifiers, isReturn, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 7014, 7308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 6638, 7320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 6638, 7320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PEParameterSymbol Create(
                    PEModuleSymbol moduleSymbol,
                    PEPropertySymbol containingSymbol,
                    bool isContainingSymbolVirtual,
                    int ordinal,
                    ParameterHandle handle,
                    ParamInfo<TypeSymbol> parameterInfo,
                    Symbol nullableContext,
                    out bool isBad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10712, 7928, 8614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 8308, 8603);

                return f_10712_8315_8602(moduleSymbol, containingSymbol, isContainingSymbolVirtual, ordinal, parameterInfo.IsByRef, parameterInfo.RefCustomModifiers, parameterInfo.Type, handle, nullableContext, parameterInfo.CustomModifiers, isReturn: false, out isBad);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10712, 7928, 8614);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10712_8315_8602(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEPropertySymbol
                containingSymbol, bool
                isContainingSymbolVirtual, int
                ordinal, bool
                isByRef, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Reflection.Metadata.ParameterHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers, bool
                isReturn, out bool
                isBad)
                {
                    var return_v = Create(moduleSymbol, (Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol, isContainingSymbolVirtual, ordinal, isByRef, refCustomModifiers, type, handle, nullableContext, customModifiers, isReturn: isReturn, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 8315, 8602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 7928, 8614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 7928, 8614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PEParameterSymbol(
                    PEModuleSymbol moduleSymbol,
                    Symbol containingSymbol,
                    int ordinal,
                    bool isByRef,
                    TypeWithAnnotations typeWithAnnotations,
                    ParameterHandle handle,
                    Symbol nullableContext,
                    int countOfCustomModifiers,
                    out bool isBad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10712, 8626, 12932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5848, 5865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 5900, 5905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 6072, 6078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 6121, 6134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 6245, 6284);
                this._lazyDefaultValue = f_10712_6265_6284(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 6314, 6327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 6572, 6580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9008, 9051);

                f_10712_9008_9050((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9065, 9112);

                f_10712_9065_9111((object)containingSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9126, 9153);

                f_10712_9126_9152(ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9167, 9209);

                f_10712_9167_9208(typeWithAnnotations.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9225, 9239);

                isBad = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9253, 9282);

                _moduleSymbol = moduleSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9296, 9333);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9347, 9374);

                _ordinal = (ushort)ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9390, 9407);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9423, 9454);

                RefKind
                refKind = RefKind.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9470, 12321) || true) && (handle.IsNil)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 9470, 12321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9520, 9567);

                    refKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 9530, 9537) || ((isByRef && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 9540, 9551)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 9554, 9566))) ? RefKind.Ref : RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9585, 9641);

                    byte?
                    value = f_10712_9599_9640(nullableContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9659, 9851) || true) && (f_10712_9663_9677(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 9659, 9851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9719, 9832);

                        typeWithAnnotations = f_10712_9741_9831(typeWithAnnotations, f_10712_9796_9821(value), default);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 9659, 9851);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9869, 9935);

                    _lazyCustomAttributes = ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 9953, 10019);

                    _lazyHiddenAttributes = ImmutableArray<CSharpAttributeData>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10037, 10084);

                    _lazyDefaultValue = ConstantValue.NotAvailable;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10102, 10135);

                    _lazyIsParams = ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 9470, 12321);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 9470, 12321);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10245, 10317);

                        f_10712_10245_10316(f_10712_10245_10264(moduleSymbol), handle, out _name, out _flags);
                    }
                    catch (BadImageFormatException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10712, 10354, 10458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10426, 10439);

                        isBad = true;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10712, 10354, 10458);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10478, 11098) || true) && (isByRef)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 10478, 11098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10531, 10624);

                        ParameterAttributes
                        inOutFlags = _flags & (ParameterAttributes.Out | ParameterAttributes.In)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10648, 11079) || true) && (inOutFlags == ParameterAttributes.Out)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 10648, 11079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10739, 10761);

                            refKind = RefKind.Out;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 10648, 11079);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 10648, 11079);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10811, 11079) || true) && (f_10712_10815_10865(f_10712_10815_10834(moduleSymbol), handle))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 10811, 11079);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 10915, 10936);

                                refKind = RefKind.In;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 10811, 11079);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 10811, 11079);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 11034, 11056);

                                refKind = RefKind.Ref;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 10811, 11079);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 10648, 11079);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 10478, 11098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 11118, 11249);

                    var
                    typeSymbol = DynamicTypeDecoder.TransformType(typeWithAnnotations.Type, countOfCustomModifiers, handle, moduleSymbol, refKind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 11267, 11353);

                    typeSymbol = NativeIntegerTypeDecoder.TransformType(typeSymbol, handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 11371, 11483);

                    typeWithAnnotations = typeWithAnnotations.WithTypeAndModifiers(typeSymbol, typeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 11879, 11998);

                    var
                    accessSymbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 11898, 11942) || ((f_10712_11898_11919(containingSymbol) == SymbolKind.Property && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 11945, 11978)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 11981, 11997))) ? f_10712_11945_11978(containingSymbol) : containingSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12016, 12177);

                    typeWithAnnotations = f_10712_12038_12176(typeWithAnnotations, handle, moduleSymbol, accessSymbol: accessSymbol, nullableContext: nullableContext);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12195, 12306);

                    typeWithAnnotations = TupleTypeDecoder.DecodeTupleTypesIfApplicable(typeWithAnnotations, handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 9470, 12321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12337, 12380);

                _typeWithAnnotations = typeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12396, 12450);

                bool
                hasNameInMetadata = !f_10712_12422_12449(_name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12464, 12664) || true) && (!hasNameInMetadata)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 12464, 12664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12633, 12649);

                    _name = "value";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 12464, 12664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12680, 12795);

                _packedFlags = f_10712_12695_12794(refKind, attributesAreComplete: handle.IsNil, hasNameInMetadata: hasNameInMetadata);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12811, 12849);

                f_10712_12811_12848(refKind == f_10712_12835_12847(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 12863, 12921);

                f_10712_12863_12920(hasNameInMetadata == f_10712_12897_12919(this));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10712, 8626, 12932);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 8626, 12932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 8626, 12932);
            }
        }

        private bool HasNameInMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 12999, 13088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 13035, 13073);

                    return _packedFlags.HasNameInMetadata;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 12999, 13088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 12944, 13099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 12944, 13099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static PEParameterSymbol Create(
                    PEModuleSymbol moduleSymbol,
                    Symbol containingSymbol,
                    bool isContainingSymbolVirtual,
                    int ordinal,
                    bool isByRef,
                    ImmutableArray<ModifierInfo<TypeSymbol>> refCustomModifiers,
                    TypeSymbol type,
                    ParameterHandle handle,
                    Symbol nullableContext,
                    ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers,
                    bool isReturn,
                    out bool isBad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10712, 13111, 15165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 13733, 13854);

                var
                typeWithModifiers = TypeWithAnnotations.Create(type, customModifiers: f_10712_13807_13852(customModifiers))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 13870, 14306);

                PEParameterSymbol
                parameter = (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 13900, 13971) || ((customModifiers.IsDefaultOrEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10712, 13900, 13971) && refCustomModifiers.IsDefaultOrEmpty
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 13991, 14120)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 14140, 14305))) ? f_10712_13991_14120(moduleSymbol, containingSymbol, ordinal, isByRef, typeWithModifiers, handle, nullableContext, 0, out isBad) : f_10712_14140_14305(moduleSymbol, containingSymbol, ordinal, isByRef, refCustomModifiers, typeWithModifiers, handle, nullableContext, out isBad)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14322, 14406);

                bool
                hasInAttributeModifier = parameter.RefCustomModifiers.HasInAttributeModifier()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14422, 15121) || true) && (isReturn)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 14422, 15121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14567, 14645);

                    isBad |= (f_10712_14577_14594(parameter) == RefKind.RefReadOnly) != hasInAttributeModifier;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 14422, 15121);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 14422, 15121);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14679, 15121) || true) && (f_10712_14683_14700(parameter) == RefKind.In)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 14679, 15121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14867, 14928);

                        isBad |= isContainingSymbolVirtual != hasInAttributeModifier;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 14679, 15121);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 14679, 15121);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 14962, 15121) || true) && (hasInAttributeModifier)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 14962, 15121);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 15093, 15106);

                            isBad = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 14962, 15121);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 14679, 15121);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 14422, 15121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 15137, 15154);

                return parameter;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10712, 13111, 15165);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10712_13807_13852(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                customModifiers)
                {
                    var return_v = CSharpCustomModifier.Convert(customModifiers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 13807, 13852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                f_10712_13991_14120(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, int
                ordinal, bool
                isByRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, System.Reflection.Metadata.ParameterHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext, int
                countOfCustomModifiers, out bool
                isBad)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol(moduleSymbol, containingSymbol, ordinal, isByRef, typeWithAnnotations, handle, nullableContext, countOfCustomModifiers, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 13991, 14120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol.PEParameterSymbolWithCustomModifiers
                f_10712_14140_14305(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, int
                ordinal, bool
                isByRef, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
                refCustomModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, System.Reflection.Metadata.ParameterHandle
                handle, Microsoft.CodeAnalysis.CSharp.Symbol
                nullableContext, out bool
                isBad)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol.PEParameterSymbolWithCustomModifiers(moduleSymbol, containingSymbol, ordinal, isByRef, refCustomModifiers, type, handle, nullableContext, out isBad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 14140, 14305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10712_14577_14594(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 14577, 14594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10712_14683_14700(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 14683, 14700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 13111, 15165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 13111, 15165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class PEParameterSymbolWithCustomModifiers : PEParameterSymbol
        {
            private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

            public PEParameterSymbolWithCustomModifiers(
                            PEModuleSymbol moduleSymbol,
                            Symbol containingSymbol,
                            int ordinal,
                            bool isByRef,
                            ImmutableArray<ModifierInfo<TypeSymbol>> refCustomModifiers,
                            TypeWithAnnotations type,
                            ParameterHandle handle,
                            Symbol nullableContext,
                            out bool isBad) : base(f_10712_15821_15833_C(moduleSymbol), containingSymbol, ordinal, isByRef, type, handle, nullableContext, refCustomModifiers.NullToEmpty().Length + type.CustomModifiers.Length, out isBad)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10712, 15363, 16227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16068, 16139);

                    _refCustomModifiers = f_10712_16090_16138(refCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16159, 16212);

                    f_10712_16159_16211(_refCustomModifiers.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10712, 16172, 16210) || isByRef));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10712, 15363, 16227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 15363, 16227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 15363, 16227);
                }
            }

            public override ImmutableArray<CustomModifier> RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 16341, 16431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16385, 16412);

                        return _refCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 16341, 16431);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 16243, 16446);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 16243, 16446);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static PEParameterSymbolWithCustomModifiers()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10712, 15177, 16457);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10712, 15177, 16457);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 15177, 16457);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10712, 15177, 16457);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            f_10712_16090_16138(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModifierInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
            customModifiers)
            {
                var return_v = CSharpCustomModifier.Convert(customModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 16090, 16138);
                return return_v;
            }


            int
            f_10712_16159_16211(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 16159, 16211);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            f_10712_15821_15833_C(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10712, 15363, 16227);
                return return_v;
            }

        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 16525, 16604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16561, 16589);

                    return _packedFlags.RefKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 16525, 16604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 16469, 16615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 16469, 16615);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 16679, 16743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16715, 16728);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 16679, 16743);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 16627, 16754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 16627, 16754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 16826, 16925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 16862, 16910);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 16869, 16886) || ((f_10712_16869_16886() && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 16889, 16894)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 16897, 16909))) ? _name : string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 16826, 16925);

                    bool
                    f_10712_16869_16886()
                    {
                        var return_v = HasNameInMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 16869, 16886);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 16766, 16936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 16766, 16936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ParameterAttributes Flags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17007, 17072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17043, 17057);

                    return _flags;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17007, 17072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 16948, 17083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 16948, 17083);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17147, 17214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17183, 17199);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17147, 17214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 17095, 17225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 17095, 17225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDiscard
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17292, 17356);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17328, 17341);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17292, 17356);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 17237, 17367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 17237, 17367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ParameterHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17460, 17526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17496, 17511);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17460, 17526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 17404, 17537);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 17404, 17537);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17613, 17689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17649, 17674);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17613, 17689);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 17549, 17700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 17549, 17700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasMetadataConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 17784, 17889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 17820, 17874);

                    return (_flags & ParameterAttributes.HasDefault) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 17784, 17889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 17712, 17900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 17712, 17900);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ConstantValue ImportConstantValue(bool ignoreAttributes = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 18064, 18886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18162, 18191);

                f_10712_18162_18190(f_10712_18175_18189_M(!_handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18499, 18526);

                ConstantValue
                value = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18542, 18700) || true) && ((_flags & ParameterAttributes.HasDefault) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 18542, 18700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18626, 18685);

                    value = f_10712_18634_18684(f_10712_18634_18654(_moduleSymbol), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 18542, 18700);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18716, 18846) || true) && (value == null && (DynAbs.Tracing.TraceSender.Expression_True(10712, 18720, 18754) && !ignoreAttributes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 18716, 18846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18788, 18831);

                    value = f_10712_18796_18830(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 18716, 18846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 18862, 18875);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 18064, 18886);

                bool
                f_10712_18175_18189_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 18175, 18189);
                    return return_v;
                }


                int
                f_10712_18162_18190(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 18162, 18190);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10712_18634_18654(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 18634, 18654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10712_18634_18684(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                param)
                {
                    var return_v = this_param.GetParamDefaultValue(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 18634, 18684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10712_18796_18830(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetDefaultDecimalOrDateTimeValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 18796, 18830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 18064, 18886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 18064, 18886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 18983, 19879);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 19152, 19819) || true) && (_lazyDefaultValue == f_10712_19177_19196())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 19152, 19819);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 19618, 19699);

                        ConstantValue
                        value = f_10712_19640_19698(this, ignoreAttributes: f_10712_19678_19697_M(!IsMetadataOptional))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 19721, 19800);

                        f_10712_19721_19799(ref _lazyDefaultValue, value, f_10712_19779_19798());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 19152, 19819);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 19839, 19864);

                    return _lazyDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 18983, 19879);

                    Microsoft.CodeAnalysis.ConstantValue
                    f_10712_19177_19196()
                    {
                        var return_v = ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 19177, 19196);
                        return return_v;
                    }


                    bool
                    f_10712_19678_19697_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 19678, 19697);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10712_19640_19698(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    this_param, bool
                    ignoreAttributes)
                    {
                        var return_v = this_param.ImportConstantValue(ignoreAttributes: ignoreAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 19640, 19698);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10712_19779_19798()
                    {
                        var return_v = ConstantValue.Unset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 19779, 19798);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10712_19721_19799(ref Microsoft.CodeAnalysis.ConstantValue
                    location1, Microsoft.CodeAnalysis.ConstantValue
                    value, Microsoft.CodeAnalysis.ConstantValue
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 19721, 19799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 18898, 19890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 18898, 19890);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ConstantValue GetDefaultDecimalOrDateTimeValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 19902, 20853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 19983, 20012);

                f_10712_19983_20011(f_10712_19996_20010_M(!_handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20026, 20053);

                ConstantValue
                value = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20299, 20434) || true) && (f_10712_20303_20372(f_10712_20303_20323(_moduleSymbol), _handle, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 20299, 20434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20406, 20419);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 20299, 20434);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20679, 20813) || true) && (f_10712_20683_20751(f_10712_20683_20703(_moduleSymbol), _handle, out value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 20679, 20813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20785, 20798);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 20679, 20813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20829, 20842);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 19902, 20853);

                bool
                f_10712_19996_20010_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 19996, 20010);
                    return return_v;
                }


                int
                f_10712_19983_20011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 19983, 20011);
                    return 0;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10712_20303_20323(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 20303, 20323);
                    return return_v;
                }


                bool
                f_10712_20303_20372(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, out Microsoft.CodeAnalysis.ConstantValue
                defaultValue)
                {
                    var return_v = this_param.HasDateTimeConstantAttribute((System.Reflection.Metadata.EntityHandle)token, out defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 20303, 20372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10712_20683_20703(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 20683, 20703);
                    return return_v;
                }


                bool
                f_10712_20683_20751(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, out Microsoft.CodeAnalysis.ConstantValue
                defaultValue)
                {
                    var return_v = this_param.HasDecimalConstantAttribute((System.Reflection.Metadata.EntityHandle)token, out defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 20683, 20751);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 19902, 20853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 19902, 20853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 20931, 21034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 20967, 21019);

                    return (_flags & ParameterAttributes.Optional) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 20931, 21034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 20865, 21045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 20865, 21045);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 21124, 21633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21160, 21251);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.HasIDispatchConstantAttribute
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21271, 21282);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21300, 21587) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 21300, 21587);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21401, 21568);

                        value = _packedFlags.SetWellKnownAttribute(flag, f_10712_21450_21566(f_10712_21450_21470(_moduleSymbol), _handle, AttributeDescription.IDispatchConstantAttribute));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 21300, 21587);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21605, 21618);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 21124, 21633);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_21450_21470(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 21450, 21470);
                        return return_v;
                    }


                    bool
                    f_10712_21450_21566(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 21450, 21566);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 21057, 21644);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 21057, 21644);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 21722, 22229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21758, 21848);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.HasIUnknownConstantAttribute
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21868, 21879);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21897, 22183) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 21897, 22183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 21998, 22164);

                        value = _packedFlags.SetWellKnownAttribute(flag, f_10712_22047_22162(f_10712_22047_22067(_moduleSymbol), _handle, AttributeDescription.IUnknownConstantAttribute));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 21897, 22183);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22201, 22214);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 21722, 22229);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_22047_22067(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 22047, 22067);
                        return return_v;
                    }


                    bool
                    f_10712_22047_22162(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 22047, 22162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 21656, 22240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 21656, 22240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerLineNumberAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 22318, 22825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22354, 22444);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.HasCallerLineNumberAttribute
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22464, 22475);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22493, 22779) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 22493, 22779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22594, 22760);

                        value = _packedFlags.SetWellKnownAttribute(flag, f_10712_22643_22758(f_10712_22643_22663(_moduleSymbol), _handle, AttributeDescription.CallerLineNumberAttribute));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 22493, 22779);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22797, 22810);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 22318, 22825);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_22643_22663(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 22643, 22663);
                        return return_v;
                    }


                    bool
                    f_10712_22643_22758(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 22643, 22758);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 22252, 22836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 22252, 22836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerFilePathAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 22912, 23415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 22948, 23036);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.HasCallerFilePathAttribute
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23056, 23067);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23085, 23369) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 23085, 23369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23186, 23350);

                        value = _packedFlags.SetWellKnownAttribute(flag, f_10712_23235_23348(f_10712_23235_23255(_moduleSymbol), _handle, AttributeDescription.CallerFilePathAttribute));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 23085, 23369);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23387, 23400);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 22912, 23415);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_23235_23255(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 23235, 23255);
                        return return_v;
                    }


                    bool
                    f_10712_23235_23348(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 23235, 23348);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 22848, 23426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 22848, 23426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasCallerMemberNameAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 23504, 24011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23540, 23630);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.HasCallerMemberNameAttribute
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23650, 23661);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23679, 23965) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 23679, 23965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23780, 23946);

                        value = _packedFlags.SetWellKnownAttribute(flag, f_10712_23829_23944(f_10712_23829_23849(_moduleSymbol), _handle, AttributeDescription.CallerMemberNameAttribute));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 23679, 23965);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 23983, 23996);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 23504, 24011);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_23829_23849(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 23829, 23849);
                        return return_v;
                    }


                    bool
                    f_10712_23829_23944(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 23829, 23944);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 23438, 24022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 23438, 24022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 24100, 24784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24136, 24216);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.IsCallerLineNumber
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24236, 24247);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24265, 24738) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 24265, 24738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24366, 24416);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24438, 24626);

                        bool
                        isCallerLineNumber = f_10712_24464_24492() && (DynAbs.Tracing.TraceSender.Expression_True(10712, 24464, 24625) && f_10712_24521_24625(f_10712_24521_24560(f_10712_24541_24559()), f_10712_24591_24600(this), ref useSiteDiagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24650, 24719);

                        value = _packedFlags.SetWellKnownAttribute(flag, isCallerLineNumber);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 24265, 24738);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24756, 24769);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 24100, 24784);

                    bool
                    f_10712_24464_24492()
                    {
                        var return_v = HasCallerLineNumberAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 24464, 24492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10712_24541_24559()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 24541, 24559);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.TypeConversions
                    f_10712_24521_24560(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 24521, 24560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10712_24591_24600(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 24591, 24600);
                        return return_v;
                    }


                    bool
                    f_10712_24521_24625(Microsoft.CodeAnalysis.CSharp.TypeConversions
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.HasCallerLineNumberConversion(destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 24521, 24625);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 24034, 24795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 24034, 24795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 24871, 25605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 24907, 24985);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.IsCallerFilePath
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25005, 25016);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25034, 25559) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 25034, 25559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25135, 25185);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25207, 25449);

                        bool
                        isCallerFilePath = f_10712_25231_25260_M(!HasCallerLineNumberAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10712, 25231, 25315) && f_10712_25289_25315()) && (DynAbs.Tracing.TraceSender.Expression_True(10712, 25231, 25448) && f_10712_25344_25448(f_10712_25344_25383(f_10712_25364_25382()), f_10712_25414_25423(this), ref useSiteDiagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25473, 25540);

                        value = _packedFlags.SetWellKnownAttribute(flag, isCallerFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 25034, 25559);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25577, 25590);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 24871, 25605);

                    bool
                    f_10712_25231_25260_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 25231, 25260);
                        return return_v;
                    }


                    bool
                    f_10712_25289_25315()
                    {
                        var return_v = HasCallerFilePathAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 25289, 25315);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10712_25364_25382()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 25364, 25382);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.TypeConversions
                    f_10712_25344_25383(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 25344, 25383);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10712_25414_25423(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 25414, 25423);
                        return return_v;
                    }


                    bool
                    f_10712_25344_25448(Microsoft.CodeAnalysis.CSharp.TypeConversions
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.HasCallerInfoStringConversion(destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 25344, 25448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 24807, 25616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 24807, 25616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 25694, 26492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25730, 25810);

                    const WellKnownAttributeFlags
                    flag = WellKnownAttributeFlags.IsCallerMemberName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25830, 25841);

                    bool
                    value
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25859, 26446) || true) && (!_packedFlags.TryGetWellKnownAttribute(flag, out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 25859, 26446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 25960, 26010);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26032, 26334);

                        bool
                        isCallerMemberName = f_10712_26058_26087_M(!HasCallerLineNumberAttribute) && (DynAbs.Tracing.TraceSender.Expression_True(10712, 26058, 26143) && f_10712_26116_26143_M(!HasCallerFilePathAttribute)) && (DynAbs.Tracing.TraceSender.Expression_True(10712, 26058, 26200) && f_10712_26172_26200()) && (DynAbs.Tracing.TraceSender.Expression_True(10712, 26058, 26333) && f_10712_26229_26333(f_10712_26229_26268(f_10712_26249_26267()), f_10712_26299_26308(this), ref useSiteDiagnostics))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26358, 26427);

                        value = _packedFlags.SetWellKnownAttribute(flag, isCallerMemberName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 25859, 26446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26464, 26477);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 25694, 26492);

                    bool
                    f_10712_26058_26087_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26058, 26087);
                        return return_v;
                    }


                    bool
                    f_10712_26116_26143_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26116, 26143);
                        return return_v;
                    }


                    bool
                    f_10712_26172_26200()
                    {
                        var return_v = HasCallerMemberNameAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26172, 26200);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10712_26249_26267()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26249, 26267);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.TypeConversions
                    f_10712_26229_26268(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    corLibrary)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.TypeConversions(corLibrary);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 26229, 26268);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10712_26299_26308(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26299, 26308);
                        return return_v;
                    }


                    bool
                    f_10712_26229_26333(Microsoft.CodeAnalysis.CSharp.TypeConversions
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.HasCallerInfoStringConversion(destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 26229, 26333);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 25628, 26503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 25628, 26503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 26605, 26991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26641, 26671);

                    FlowAnalysisAnnotations
                    value
                    = default(FlowAnalysisAnnotations);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26689, 26945) || true) && (!_packedFlags.TryGetFlowAnalysisAnnotations(out value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 26689, 26945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26789, 26857);

                        value = f_10712_26797_26856(f_10712_26826_26846(_moduleSymbol), _handle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26879, 26926);

                        _packedFlags.SetFlowAnalysisAnnotations(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 26689, 26945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 26963, 26976);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 26605, 26991);

                    Microsoft.CodeAnalysis.PEModule
                    f_10712_26826_26846(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 26826, 26846);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FlowAnalysisAnnotations
                    f_10712_26797_26856(Microsoft.CodeAnalysis.PEModule
                    module, System.Reflection.Metadata.ParameterHandle
                    handle)
                    {
                        var return_v = DecodeFlowAnalysisAttributes(module, handle);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 26797, 26856);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 26515, 27002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 26515, 27002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static FlowAnalysisAnnotations DecodeFlowAnalysisAttributes(PEModule module, ParameterHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10712, 27014, 28854);
                bool when = default(bool);
                bool condition = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27147, 27214);

                FlowAnalysisAnnotations
                annotations = FlowAnalysisAnnotations.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27228, 27351) || true) && (f_10712_27232_27300(module, handle, AttributeDescription.AllowNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 27228, 27351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27302, 27351);

                    annotations |= FlowAnalysisAnnotations.AllowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 27228, 27351);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27365, 27494) || true) && (f_10712_27369_27440(module, handle, AttributeDescription.DisallowNullAttribute))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 27365, 27494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27442, 27494);

                    annotations |= FlowAnalysisAnnotations.DisallowNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 27365, 27494);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27510, 27993) || true) && (f_10712_27514_27582(module, handle, AttributeDescription.MaybeNullAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 27510, 27993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27616, 27665);

                    annotations |= FlowAnalysisAnnotations.MaybeNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 27510, 27993);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 27510, 27993);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27699, 27993) || true) && (f_10712_27703_27833(module, handle, AttributeDescription.MaybeNullWhenAttribute, out when))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 27699, 27993);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 27867, 27978);

                        annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10712, 27883, 27887) || ((when && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 27890, 27931)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 27934, 27976))) ? FlowAnalysisAnnotations.MaybeNullWhenTrue : FlowAnalysisAnnotations.MaybeNullWhenFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 27699, 27993);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 27510, 27993);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28009, 28482) || true) && (f_10712_28013_28079(module, handle, AttributeDescription.NotNullAttribute))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 28009, 28482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28113, 28160);

                    annotations |= FlowAnalysisAnnotations.NotNull;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 28009, 28482);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 28009, 28482);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28194, 28482) || true) && (f_10712_28198_28326(module, handle, AttributeDescription.NotNullWhenAttribute, out when))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 28194, 28482);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28360, 28467);

                        annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10712, 28376, 28380) || ((when && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 28383, 28422)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 28425, 28465))) ? FlowAnalysisAnnotations.NotNullWhenTrue : FlowAnalysisAnnotations.NotNullWhenFalse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 28194, 28482);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 28009, 28482);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28498, 28808) || true) && (f_10712_28502_28639(module, handle, AttributeDescription.DoesNotReturnIfAttribute, out condition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 28498, 28808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28673, 28793);

                    annotations |= ((DynAbs.Tracing.TraceSender.Conditional_F1(10712, 28689, 28698) || ((condition && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 28701, 28744)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 28747, 28791))) ? FlowAnalysisAnnotations.DoesNotReturnIfTrue : FlowAnalysisAnnotations.DoesNotReturnIfFalse);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 28498, 28808);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28824, 28843);

                return annotations;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10712, 27014, 28854);

                bool
                f_10712_27232_27300(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 27232, 27300);
                    return return_v;
                }


                bool
                f_10712_27369_27440(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 27369, 27440);
                    return return_v;
                }


                bool
                f_10712_27514_27582(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 27514, 27582);
                    return return_v;
                }


                bool
                f_10712_27703_27833(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out bool
                when)
                {
                    var return_v = this_param.HasMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute((System.Reflection.Metadata.EntityHandle)token, description, out when);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 27703, 27833);
                    return return_v;
                }


                bool
                f_10712_28013_28079(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.HasAttribute((System.Reflection.Metadata.EntityHandle)token, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 28013, 28079);
                    return return_v;
                }


                bool
                f_10712_28198_28326(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out bool
                when)
                {
                    var return_v = this_param.HasMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute((System.Reflection.Metadata.EntityHandle)token, description, out when);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 28198, 28326);
                    return return_v;
                }


                bool
                f_10712_28502_28639(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.ParameterHandle
                token, Microsoft.CodeAnalysis.AttributeDescription
                description, out bool
                when)
                {
                    var return_v = this_param.HasMaybeNullWhenOrNotNullWhenOrDoesNotReturnIfAttribute((System.Reflection.Metadata.EntityHandle)token, description, out when);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 28502, 28639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 27014, 28854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 27014, 28854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 28959, 29603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 28995, 29028);

                    var
                    attributes = f_10712_29012_29027(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29046, 29090);

                    var
                    result = ImmutableHashSet<string>.Empty
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29108, 29554);
                        foreach (var attribute in f_10712_29134_29144_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 29108, 29554);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29186, 29535) || true) && (f_10712_29190_29271(attribute, this, AttributeDescription.NotNullIfNotNullAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 29186, 29535);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29321, 29512) || true) && (f_10712_29325_29368(attribute) is string parameterName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 29321, 29512);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29450, 29485);

                                    result = f_10712_29459_29484(result, parameterName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 29321, 29512);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 29186, 29535);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 29108, 29554);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10712, 1, 447);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10712, 1, 447);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29574, 29588);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 28959, 29603);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10712_29012_29027(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 29012, 29027);
                        return return_v;
                    }


                    bool
                    f_10712_29190_29271(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                    targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 29190, 29271);
                        return return_v;
                    }


                    string?
                    f_10712_29325_29368(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    attribute)
                    {
                        var return_v = attribute.DecodeNotNullIfNotNullAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 29325, 29368);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableHashSet<string>
                    f_10712_29459_29484(System.Collections.Immutable.ImmutableHashSet<string>
                    this_param, string
                    item)
                    {
                        var return_v = this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 29459, 29484);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10712_29134_29144_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 29134, 29144);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 28866, 29614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 28866, 29614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 29706, 29785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29742, 29770);

                    return _typeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 29706, 29785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 29626, 29796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 29626, 29796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 29898, 29993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 29934, 29978);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 29898, 29993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 29808, 30004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 29808, 30004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 30076, 30130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 30082, 30128);

                    return (_flags & ParameterAttributes.In) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 30076, 30130);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 30016, 30141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 30016, 30141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 30214, 30269);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 30220, 30267);

                    return (_flags & ParameterAttributes.Out) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 30214, 30269);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 30153, 30280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 30153, 30280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 30362, 30472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 30398, 30457);

                    return (_flags & ParameterAttributes.HasFieldMarshal) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 30362, 30472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 30292, 30483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 30292, 30483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 30593, 30770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 30743, 30755);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 30593, 30770);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 30495, 30781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 30495, 30781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 30878, 31211);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 30914, 31067) || true) && ((_flags & ParameterAttributes.HasFieldMarshal) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 30914, 31067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31011, 31048);

                        return default(ImmutableArray<byte>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 30914, 31067);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31087, 31116);

                    f_10712_31087_31115(f_10712_31100_31114_M(!_handle.IsNil));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31134, 31196);

                    return f_10712_31141_31195(f_10712_31141_31161(_moduleSymbol), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 30878, 31211);

                    bool
                    f_10712_31100_31114_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 31100, 31114);
                        return return_v;
                    }


                    int
                    f_10712_31087_31115(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 31087, 31115);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10712_31141_31161(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 31141, 31161);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10712_31141_31195(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    fieldOrParameterToken)
                    {
                        var return_v = this_param.GetMarshallingDescriptor((System.Reflection.Metadata.EntityHandle)fieldOrParameterToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 31141, 31195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 30793, 31222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 30793, 31222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override UnmanagedType MarshallingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 31306, 31605);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31342, 31467) || true) && ((_flags & ParameterAttributes.HasFieldMarshal) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 31342, 31467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31439, 31448);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 31342, 31467);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31487, 31516);

                    f_10712_31487_31515(f_10712_31500_31514_M(!_handle.IsNil));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31534, 31590);

                    return f_10712_31541_31589(f_10712_31541_31561(_moduleSymbol), _handle);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 31306, 31605);

                    bool
                    f_10712_31500_31514_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 31500, 31514);
                        return return_v;
                    }


                    int
                    f_10712_31487_31515(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 31487, 31515);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10712_31541_31561(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 31541, 31561);
                        return return_v;
                    }


                    System.Runtime.InteropServices.UnmanagedType
                    f_10712_31541_31589(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    fieldOrParameterToken)
                    {
                        var return_v = this_param.GetMarshallingType((System.Reflection.Metadata.EntityHandle)fieldOrParameterToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 31541, 31589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 31234, 31616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 31234, 31616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 31682, 32151);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31919, 32089) || true) && (!f_10712_31924_31948(_lazyIsParams))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 31919, 32089);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 31990, 32070);

                        _lazyIsParams = f_10712_32006_32069(f_10712_32006_32054(f_10712_32006_32026(_moduleSymbol), _handle));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 31919, 32089);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32107, 32136);

                    return f_10712_32114_32135(_lazyIsParams);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 31682, 32151);

                    bool
                    f_10712_31924_31948(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.HasValue();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 31924, 31948);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10712_32006_32026(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 32006, 32026);
                        return return_v;
                    }


                    bool
                    f_10712_32006_32054(Microsoft.CodeAnalysis.PEModule
                    this_param, System.Reflection.Metadata.ParameterHandle
                    token)
                    {
                        var return_v = this_param.HasParamsAttribute((System.Reflection.Metadata.EntityHandle)token);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 32006, 32054);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ThreeState
                    f_10712_32006_32069(bool
                    value)
                    {
                        var return_v = value.ToThreeState();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 32006, 32069);
                        return return_v;
                    }


                    bool
                    f_10712_32114_32135(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 32114, 32135);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 31628, 32162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 31628, 32162);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 32249, 32335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32285, 32320);

                    return f_10712_32292_32319(_containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 32249, 32335);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10712_32292_32319(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 32292, 32319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 32174, 32346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 32174, 32346);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 32456, 32552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32492, 32537);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 32456, 32552);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 32358, 32563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 32358, 32563);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 32575, 36907);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32667, 36790) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 32667, 36790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32736, 32765);

                    f_10712_32736_32764(f_10712_32749_32763_M(!_handle.IsNil));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 32783, 32852);

                    var
                    containingPEModuleSymbol = (PEModuleSymbol)f_10712_32830_32851(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33018, 33107);

                    bool
                    filterOutParamArrayAttribute = (!f_10712_33056_33080(_lazyIsParams) || (DynAbs.Tracing.TraceSender.Expression_False(10712, 33055, 33105) || f_10712_33084_33105(_lazyIsParams)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33127, 33190);

                    ConstantValue
                    defaultValue = f_10712_33156_33189(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33208, 33299);

                    AttributeDescription
                    filterOutConstantAttributeDescription = default(AttributeDescription)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33319, 33903) || true) && ((object)defaultValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 33319, 33903);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33393, 33884) || true) && (f_10712_33397_33423(defaultValue) == ConstantValueTypeDiscriminator.DateTime)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 33393, 33884);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33516, 33603);

                            filterOutConstantAttributeDescription = AttributeDescription.DateTimeConstantAttribute;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 33393, 33884);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 33393, 33884);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33653, 33884) || true) && (f_10712_33657_33683(defaultValue) == ConstantValueTypeDiscriminator.Decimal)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 33653, 33884);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33775, 33861);

                                filterOutConstantAttributeDescription = AttributeDescription.DecimalConstantAttribute;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 33653, 33884);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 33393, 33884);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 33319, 33903);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 33923, 33983);

                    bool
                    filterIsReadOnlyAttribute = f_10712_33956_33968(this) == RefKind.In
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 34003, 36775) || true) && (filterOutParamArrayAttribute || (DynAbs.Tracing.TraceSender.Expression_False(10712, 34007, 34095) || filterOutConstantAttributeDescription.Signatures != null) || (DynAbs.Tracing.TraceSender.Expression_False(10712, 34007, 34124) || filterIsReadOnlyAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 34003, 36775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 34166, 34208);

                        CustomAttributeHandle
                        paramArrayAttribute
                        = default(CustomAttributeHandle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 34230, 34270);

                        CustomAttributeHandle
                        constantAttribute
                        = default(CustomAttributeHandle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 34292, 34334);

                        CustomAttributeHandle
                        isReadOnlyAttribute
                        = default(CustomAttributeHandle);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 34358, 35047);

                        ImmutableArray<CSharpAttributeData>
                        attributes =
                        f_10712_34432_35046(containingPEModuleSymbol, _handle, out paramArrayAttribute, (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 34607, 34635) || ((filterOutParamArrayAttribute && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 34638, 34678)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 34681, 34688))) ? AttributeDescription.ParamArrayAttribute : default, out constantAttribute, filterOutConstantAttributeDescription, out isReadOnlyAttribute, (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 34893, 34918) || ((filterIsReadOnlyAttribute && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 34921, 34961)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 34964, 34971))) ? AttributeDescription.IsReadOnlyAttribute : default, out _, default)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35071, 36045) || true) && (f_10712_35075_35101_M(!paramArrayAttribute.IsNil) || (DynAbs.Tracing.TraceSender.Expression_False(10712, 35075, 35129) || f_10712_35105_35129_M(!constantAttribute.IsNil)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 35071, 36045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35179, 35241);

                            var
                            builder = f_10712_35193_35240()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35269, 35464) || true) && (f_10712_35273_35299_M(!paramArrayAttribute.IsNil))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 35269, 35464);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35357, 35437);

                                f_10712_35357_35436(builder, f_10712_35369_35435(containingPEModuleSymbol, paramArrayAttribute));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 35269, 35464);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35492, 35683) || true) && (f_10712_35496_35520_M(!constantAttribute.IsNil))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 35492, 35683);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35578, 35656);

                                f_10712_35578_35655(builder, f_10712_35590_35654(containingPEModuleSymbol, constantAttribute));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 35492, 35683);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35711, 35811);

                            f_10712_35711_35810(ref _lazyHiddenAttributes, f_10712_35781_35809(builder));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 35071, 36045);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 35071, 36045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 35909, 36022);

                            f_10712_35909_36021(ref _lazyHiddenAttributes, ImmutableArray<CSharpAttributeData>.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 35071, 36045);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36069, 36300) || true) && (!f_10712_36074_36098(_lazyIsParams))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 36069, 36300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36148, 36191);

                            f_10712_36148_36190(filterOutParamArrayAttribute);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36217, 36277);

                            _lazyIsParams = f_10712_36233_36276((f_10712_36234_36260_M(!paramArrayAttribute.IsNil)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 36069, 36300);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36324, 36457);

                        f_10712_36324_36456(ref _lazyCustomAttributes, attributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 34003, 36775);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 34003, 36775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36539, 36652);

                        f_10712_36539_36651(ref _lazyHiddenAttributes, ImmutableArray<CSharpAttributeData>.Empty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36674, 36756);

                        f_10712_36674_36755(containingPEModuleSymbol, _handle, ref _lazyCustomAttributes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 34003, 36775);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 32667, 36790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36806, 36853);

                f_10712_36806_36852(f_10712_36819_36851_M(!_lazyHiddenAttributes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 36867, 36896);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 32575, 36907);

                bool
                f_10712_32749_32763_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 32749, 32763);
                    return return_v;
                }


                int
                f_10712_32736_32764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 32736, 32764);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10712_32830_32851(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 32830, 32851);
                    return return_v;
                }


                bool
                f_10712_33056_33080(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 33056, 33080);
                    return return_v;
                }


                bool
                f_10712_33084_33105(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.Value();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 33084, 33105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10712_33156_33189(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitDefaultConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 33156, 33189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10712_33397_33423(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 33397, 33423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10712_33657_33683(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 33657, 33683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10712_33956_33968(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 33956, 33968);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_34432_35046(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.ParameterHandle
                token, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute1, Microsoft.CodeAnalysis.AttributeDescription
                filterOut1, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute2, Microsoft.CodeAnalysis.AttributeDescription
                filterOut2, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute3, Microsoft.CodeAnalysis.AttributeDescription
                filterOut3, out System.Reflection.Metadata.CustomAttributeHandle
                filteredOutAttribute4, Microsoft.CodeAnalysis.AttributeDescription
                filterOut4)
                {
                    var return_v = this_param.GetCustomAttributesForToken((System.Reflection.Metadata.EntityHandle)token, out filteredOutAttribute1, filterOut1, out filteredOutAttribute2, filterOut2, out filteredOutAttribute3, filterOut3, out filteredOutAttribute4, filterOut4);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 34432, 35046);
                    return return_v;
                }


                bool
                f_10712_35075_35101_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 35075, 35101);
                    return return_v;
                }


                bool
                f_10712_35105_35129_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 35105, 35129);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_35193_35240()
                {
                    var return_v = ArrayBuilder<CSharpAttributeData>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35193, 35240);
                    return return_v;
                }


                bool
                f_10712_35273_35299_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 35273, 35299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                f_10712_35369_35435(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData(moduleSymbol, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35369, 35435);
                    return return_v;
                }


                int
                f_10712_35357_35436(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35357, 35436);
                    return 0;
                }


                bool
                f_10712_35496_35520_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 35496, 35520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                f_10712_35590_35654(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, System.Reflection.Metadata.CustomAttributeHandle
                handle)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData(moduleSymbol, handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35590, 35654);
                    return return_v;
                }


                int
                f_10712_35578_35655(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35578, 35655);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_35781_35809(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35781, 35809);
                    return return_v;
                }


                bool
                f_10712_35711_35810(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35711, 35810);
                    return return_v;
                }


                bool
                f_10712_35909_36021(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 35909, 36021);
                    return return_v;
                }


                bool
                f_10712_36074_36098(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36074, 36098);
                    return return_v;
                }


                int
                f_10712_36148_36190(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36148, 36190);
                    return 0;
                }


                bool
                f_10712_36234_36260_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 36234, 36260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10712_36233_36276(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36233, 36276);
                    return return_v;
                }


                bool
                f_10712_36324_36456(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36324, 36456);
                    return return_v;
                }


                bool
                f_10712_36539_36651(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36539, 36651);
                    return return_v;
                }


                int
                f_10712_36674_36755(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.ParameterHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes((System.Reflection.Metadata.EntityHandle)token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36674, 36755);
                    return 0;
                }


                bool
                f_10712_36819_36851_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 36819, 36851);
                    return return_v;
                }


                int
                f_10712_36806_36852(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 36806, 36852);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 32575, 36907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 32575, 36907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 36919, 37414);

                var listYield = new List<CSharpAttributeData>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37051, 37180);
                    foreach (CSharpAttributeData attribute in f_10712_37093_37108_I(f_10712_37093_37108(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 37051, 37180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37142, 37165);

                        listYield.Add(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 37051, 37180);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10712, 1, 130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10712, 1, 130);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37268, 37403);
                    foreach (CSharpAttributeData attribute in f_10712_37310_37331_I(_lazyHiddenAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10712, 37268, 37403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37365, 37388);

                        listYield.Add(attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10712, 37268, 37403);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10712, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10712, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 36919, 37414);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_37093_37108(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 37093, 37108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_37093_37108_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 37093, 37108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10712_37310_37331_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 37310, 37331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 36919, 37414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 36919, 37414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 37539, 37559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37545, 37557);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 37539, 37559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 37426, 37570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 37426, 37570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10712, 37582, 37844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10712, 37684, 37833);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10712, 37691, 37732) || ((other is NativeIntegerParameterSymbol nps && DynAbs.Tracing.TraceSender.Conditional_F2(10712, 37752, 37781)) || DynAbs.Tracing.TraceSender.Conditional_F3(10712, 37801, 37832))) ? f_10712_37752_37781((NativeIntegerParameterSymbol)other, this, compareKind) : DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other, compareKind), 10712, 37801, 37832);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10712, 37582, 37844);

                bool
                f_10712_37752_37781(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 37752, 37781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10712, 37582, 37844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 37582, 37844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10712, 771, 37851);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10712, 771, 37851);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10712, 771, 37851);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10712, 771, 37851);

        Microsoft.CodeAnalysis.ConstantValue
        f_10712_6265_6284()
        {
            var return_v = ConstantValue.Unset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 6265, 6284);
            return return_v;
        }


        int
        f_10712_9008_9050(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9008, 9050);
            return 0;
        }


        int
        f_10712_9065_9111(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9065, 9111);
            return 0;
        }


        int
        f_10712_9126_9152(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9126, 9152);
            return 0;
        }


        int
        f_10712_9167_9208(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9167, 9208);
            return 0;
        }


        byte?
        f_10712_9599_9640(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.GetNullableContextValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9599, 9640);
            return return_v;
        }


        bool
        f_10712_9663_9677(byte?
        this_param)
        {
            var return_v = this_param.HasValue;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 9663, 9677);
            return return_v;
        }


        byte
        f_10712_9796_9821(byte?
        this_param)
        {
            var return_v = this_param.GetValueOrDefault();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9796, 9821);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10712_9741_9831(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        metadataType, byte
        defaultTransformFlag, System.Collections.Immutable.ImmutableArray<byte>
        nullableTransformFlags)
        {
            var return_v = NullableTypeDecoder.TransformType(metadataType, defaultTransformFlag, nullableTransformFlags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 9741, 9831);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10712_10245_10264(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 10245, 10264);
            return return_v;
        }


        int
        f_10712_10245_10316(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.ParameterHandle
        parameterDef, out string
        name, out System.Reflection.ParameterAttributes
        flags)
        {
            this_param.GetParamPropsOrThrow(parameterDef, out name, out flags);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 10245, 10316);
            return 0;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10712_10815_10834(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 10815, 10834);
            return return_v;
        }


        bool
        f_10712_10815_10865(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.ParameterHandle
        token)
        {
            var return_v = this_param.HasIsReadOnlyAttribute((System.Reflection.Metadata.EntityHandle)token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 10815, 10865);
            return return_v;
        }


        Microsoft.CodeAnalysis.SymbolKind
        f_10712_11898_11919(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 11898, 11919);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10712_11945_11978(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 11945, 11978);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10712_12038_12176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        metadataType, System.Reflection.Metadata.ParameterHandle
        targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        containingModule, Microsoft.CodeAnalysis.CSharp.Symbol
        accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
        nullableContext)
        {
            var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: accessSymbol, nullableContext: nullableContext);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 12038, 12176);
            return return_v;
        }


        bool
        f_10712_12422_12449(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 12422, 12449);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol.PackedFlags
        f_10712_12695_12794(Microsoft.CodeAnalysis.RefKind
        refKind, bool
        attributesAreComplete, bool
        hasNameInMetadata)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol.PackedFlags(refKind, attributesAreComplete: attributesAreComplete, hasNameInMetadata: hasNameInMetadata);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 12695, 12794);
            return return_v;
        }


        Microsoft.CodeAnalysis.RefKind
        f_10712_12835_12847(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.RefKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 12835, 12847);
            return return_v;
        }


        int
        f_10712_12811_12848(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 12811, 12848);
            return 0;
        }


        bool
        f_10712_12897_12919(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEParameterSymbol
        this_param)
        {
            var return_v = this_param.HasNameInMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10712, 12897, 12919);
            return return_v;
        }


        int
        f_10712_12863_12920(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10712, 12863, 12920);
            return 0;
        }

    }
}
