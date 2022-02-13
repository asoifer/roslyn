// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal static class NullableTypeDecoder
    {
        internal static TypeWithAnnotations TransformType(
                    TypeWithAnnotations metadataType,
                    EntityHandle targetSymbolToken,
                    PEModuleSymbol containingModule,
                    Symbol accessSymbol,
                    Symbol nullableContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10702, 734, 2295);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1018, 1053);

                f_10702_1018_1052(metadataType.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1067, 1107);

                f_10702_1067_1106(f_10702_1080_1105(accessSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1121, 1193);

                f_10702_1121_1192((object)f_10702_1142_1171(accessSymbol) == containingModule);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1437, 1504);

                _ = f_10702_1441_1503(accessSymbol, out _);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1528, 1554);

                byte
                defaultTransformFlag
                = default(byte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1568, 1612);

                ImmutableArray<byte>
                nullableTransformFlags
                = default(ImmutableArray<byte>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1626, 2036) || true) && (!f_10702_1631_1748(f_10702_1631_1654(containingModule), targetSymbolToken, out defaultTransformFlag, out nullableTransformFlags))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10702, 1626, 2036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1782, 1838);

                    byte?
                    value = f_10702_1796_1837(nullableContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1856, 1954) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10702, 1856, 1954);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1915, 1935);

                        return metadataType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10702, 1856, 1954);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 1972, 2021);

                    defaultTransformFlag = f_10702_1995_2020(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10702, 1626, 2036);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2052, 2187) || true) && (!f_10702_2057_2118(containingModule, accessSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10702, 2052, 2187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2152, 2172);

                    return metadataType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10702, 2052, 2187);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2203, 2284);

                return f_10702_2210_2283(metadataType, defaultTransformFlag, nullableTransformFlags);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10702, 734, 2295);

                int
                f_10702_1018_1052(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1018, 1052);
                    return 0;
                }


                bool
                f_10702_1080_1105(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10702, 1080, 1105);
                    return return_v;
                }


                int
                f_10702_1067_1106(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1067, 1106);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10702_1142_1171(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10702, 1142, 1171);
                    return return_v;
                }


                int
                f_10702_1121_1192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1121, 1192);
                    return 0;
                }


                bool
                f_10702_1441_1503(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, out bool
                isInternal)
                {
                    var return_v = AccessCheck.IsEffectivelyPublicOrInternal(symbol, out isInternal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1441, 1503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_10702_1631_1654(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10702, 1631, 1654);
                    return return_v;
                }


                bool
                f_10702_1631_1748(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, out byte
                defaultTransform, out System.Collections.Immutable.ImmutableArray<byte>
                nullableTransforms)
                {
                    var return_v = this_param.HasNullableAttribute(token, out defaultTransform, out nullableTransforms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1631, 1748);
                    return return_v;
                }


                byte?
                f_10702_1796_1837(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1796, 1837);
                    return return_v;
                }


                byte
                f_10702_1995_2020(byte?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 1995, 2020);
                    return return_v;
                }


                bool
                f_10702_2057_2118(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.ShouldDecodeNullableAttributes(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 2057, 2118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10702_2210_2283(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                metadataType, byte
                defaultTransformFlag, System.Collections.Immutable.ImmutableArray<byte>
                nullableTransformFlags)
                {
                    var return_v = TransformType(metadataType, defaultTransformFlag, nullableTransformFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10702, 2210, 2283);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10702, 734, 2295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10702, 734, 2295);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeWithAnnotations TransformType(TypeWithAnnotations metadataType, byte defaultTransformFlag, ImmutableArray<byte> nullableTransformFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10702, 2307, 3154);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2487, 2621) || true) && (nullableTransformFlags.IsDefault && (DynAbs.Tracing.TraceSender.Expression_True(10702, 2491, 2552) && defaultTransformFlag == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10702, 2487, 2621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2586, 2606);

                    return metadataType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10702, 2487, 2621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2637, 2654);

                int
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2668, 2695);

                TypeWithAnnotations
                result
                = default(TypeWithAnnotations);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2709, 2984) || true) && (metadataType.ApplyNullableTransforms(defaultTransformFlag, nullableTransformFlags, ref position, out result) && (DynAbs.Tracing.TraceSender.Expression_True(10702, 2713, 2921) && (nullableTransformFlags.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10702, 2843, 2920) || position == nullableTransformFlags.Length))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10702, 2709, 2984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 2955, 2969);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10702, 2709, 2984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10702, 3123, 3143);

                return metadataType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10702, 2307, 3154);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10702, 2307, 3154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10702, 2307, 3154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NullableTypeDecoder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10702, 398, 3161);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10702, 398, 3161);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10702, 398, 3161);
        }

    }
}
