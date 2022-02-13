// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal enum ObsoleteDiagnosticKind
    {
        NotObsolete,
        Suppressed,
        Diagnostic,
        Lazy,
        LazyPotentiallySuppressed,
    }
    internal static class ObsoleteAttributeHelpers
    {
        internal static void InitializeObsoleteDataFromMetadata(ref ObsoleteAttributeData data, EntityHandle token, PEModuleSymbol containingModule, bool ignoreByRefLikeMarker)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10139, 951, 1504);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 1144, 1493) || true) && (f_10139_1148_1206(data, ObsoleteAttributeData.Uninitialized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 1144, 1493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 1240, 1362);

                    ObsoleteAttributeData
                    obsoleteAttributeData = f_10139_1286_1361(token, containingModule, ignoreByRefLikeMarker)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 1380, 1478);

                    f_10139_1380_1477(ref data, obsoleteAttributeData, ObsoleteAttributeData.Uninitialized);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 1144, 1493);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10139, 951, 1504);

                bool
                f_10139_1148_1206(Microsoft.CodeAnalysis.ObsoleteAttributeData
                objA, Microsoft.CodeAnalysis.ObsoleteAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 1148, 1206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10139_1286_1361(System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingModule, bool
                ignoreByRefLikeMarker)
                {
                    var return_v = GetObsoleteDataFromMetadata(token, containingModule, ignoreByRefLikeMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 1286, 1361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10139_1380_1477(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                location1, Microsoft.CodeAnalysis.ObsoleteAttributeData
                value, Microsoft.CodeAnalysis.ObsoleteAttributeData
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 1380, 1477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10139, 951, 1504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 951, 1504);
            }
        }

        internal static ObsoleteAttributeData GetObsoleteDataFromMetadata(EntityHandle token, PEModuleSymbol containingModule, bool ignoreByRefLikeMarker)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10139, 1792, 2288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 1963, 2134);

                var
                obsoleteAttributeData = f_10139_1991_2133(f_10139_1991_2014(containingModule), token, f_10139_2072_2109(containingModule), ignoreByRefLikeMarker)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 2148, 2234);

                f_10139_2148_2233(obsoleteAttributeData == null || (DynAbs.Tracing.TraceSender.Expression_False(10139, 2161, 2232) || f_10139_2194_2232_M(!obsoleteAttributeData.IsUninitialized)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 2248, 2277);

                return obsoleteAttributeData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10139, 1792, 2288);

                Microsoft.CodeAnalysis.PEModule
                f_10139_1991_2014(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 1991, 2014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10139_2072_2109(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 2072, 2109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10139_1991_2133(Microsoft.CodeAnalysis.PEModule
                this_param, System.Reflection.Metadata.EntityHandle
                token, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                decoder, bool
                ignoreByRefLikeMarker)
                {
                    var return_v = this_param.TryGetDeprecatedOrExperimentalOrObsoleteAttribute(token, (Microsoft.CodeAnalysis.IAttributeNamedArgumentDecoder)decoder, ignoreByRefLikeMarker);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 1991, 2133);
                    return return_v;
                }


                bool
                f_10139_2194_2232_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 2194, 2232);
                    return return_v;
                }


                int
                f_10139_2148_2233(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 2148, 2233);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10139, 1792, 2288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 1792, 2288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ThreeState GetObsoleteContextState(Symbol symbol, bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10139, 2753, 4077);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 2862, 4026) || true) && ((object)symbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 2862, 4026);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 2925, 3333) || true) && (f_10139_2929_2940(symbol) == SymbolKind.Field)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 2925, 3333);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3095, 3157);

                            var
                            associatedSymbol = f_10139_3118_3156(((FieldSymbol)symbol))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3179, 3314) || true) && ((object)associatedSymbol != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 3179, 3314);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3265, 3291);

                                symbol = associatedSymbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 3179, 3314);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 2925, 3333);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3353, 3471) || true) && (forceComplete)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 3353, 3471);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3412, 3452);

                            f_10139_3412_3451(symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 3353, 3471);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3491, 3524);

                        var
                        state = f_10139_3503_3523(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3542, 3645) || true) && (state != ThreeState.False)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 3542, 3645);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3613, 3626);

                            return state;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 3542, 3645);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3763, 4011) || true) && (f_10139_3767_3786(symbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 3763, 4011);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3828, 3877);

                            symbol = f_10139_3837_3876(((MethodSymbol)symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 3763, 4011);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 3763, 4011);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 3959, 3992);

                            symbol = f_10139_3968_3991(symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 3763, 4011);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 2862, 4026);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10139, 2862, 4026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10139, 2862, 4026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4042, 4066);

                return ThreeState.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10139, 2753, 4077);

                Microsoft.CodeAnalysis.SymbolKind
                f_10139_2929_2940(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 2929, 2940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10139_3118_3156(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 3118, 3156);
                    return return_v;
                }


                int
                f_10139_3412_3451(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    this_param.ForceCompleteObsoleteAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 3412, 3451);
                    return 0;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10139_3503_3523(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ObsoleteState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 3503, 3523);
                    return return_v;
                }


                bool
                f_10139_3767_3786(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 3767, 3786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10139_3837_3876(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 3837, 3876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10139_3968_3991(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 3968, 3991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10139, 2753, 4077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 2753, 4077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ObsoleteDiagnosticKind GetObsoleteDiagnosticKind(Symbol symbol, Symbol containingMember, bool forceComplete = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10139, 4089, 5706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4246, 4980);

                switch (f_10139_4254_4273(symbol))
                {

                    case ObsoleteAttributeKind.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4246, 4980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4361, 4403);

                        return ObsoleteDiagnosticKind.NotObsolete;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4246, 4980);

                    case ObsoleteAttributeKind.Experimental:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4246, 4980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4483, 4524);

                        return ObsoleteDiagnosticKind.Diagnostic;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4246, 4980);

                    case ObsoleteAttributeKind.Uninitialized:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4246, 4980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4930, 4965);

                        return ObsoleteDiagnosticKind.Lazy;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4246, 4980);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 4996, 5695);

                switch (f_10139_5004_5060(containingMember, forceComplete))
                {

                    case ThreeState.False:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4996, 5695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 5138, 5179);

                        return ObsoleteDiagnosticKind.Diagnostic;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4996, 5695);

                    case ThreeState.True:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4996, 5695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 5392, 5433);

                        return ObsoleteDiagnosticKind.Suppressed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4996, 5695);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 4996, 5695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 5624, 5680);

                        return ObsoleteDiagnosticKind.LazyPotentiallySuppressed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 4996, 5695);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10139, 4089, 5706);

                Microsoft.CodeAnalysis.ObsoleteAttributeKind
                f_10139_4254_4273(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ObsoleteKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 4254, 4273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10139_5004_5060(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                forceComplete)
                {
                    var return_v = GetObsoleteContextState(symbol, forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 5004, 5060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10139, 4089, 5706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 4089, 5706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DiagnosticInfo CreateObsoleteDiagnostic(Symbol symbol, BinderFlags location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10139, 5913, 8397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6030, 6070);

                var
                data = f_10139_6041_6069(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6084, 6111);

                f_10139_6084_6110(data != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6127, 6204) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 6127, 6204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6177, 6189);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 6127, 6204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6352, 6388);

                f_10139_6352_6387(f_10139_6365_6386_M(!data.IsUninitialized));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6492, 6610) || true) && (f_10139_6496_6549(location, BinderFlags.SuppressObsoleteChecks))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 6492, 6610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6583, 6595);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 6492, 6610);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6626, 7035) || true) && (data.Kind == ObsoleteAttributeKind.Experimental)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10139, 6626, 7035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6711, 6746);

                    f_10139_6711_6745(data.Message == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6764, 6792);

                    f_10139_6764_6791(!data.IsError);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 6889, 7020);

                    return f_10139_6896_7019(ErrorCode.WRN_Experimental, f_10139_6945_7018(symbol, f_10139_6973_7017()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10139, 6626, 7035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7141, 7219);

                var
                isColInit = f_10139_7157_7218(location, BinderFlags.CollectionInitializerAddMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7233, 8113);

                var
                errorCode = (message: data.Message, isError: data.IsError, isColInit) switch
                {
    // dev11 had a bug in this area (i.e. always produce a warning when there's no message) and we have to match it.
    (message: null, isError: _, isColInit: true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7476, 7565) && DynAbs.Tracing.TraceSender.Expression_True(10139, 7476, 7565))
=> ErrorCode.WRN_DeprecatedCollectionInitAdd,
                    (message: null, isError: _, isColInit: false) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7584, 7663) && DynAbs.Tracing.TraceSender.Expression_True(10139, 7584, 7663))
=> ErrorCode.WRN_DeprecatedSymbol,
                    (message: { }, isError: true, isColInit: true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7682, 7776) && DynAbs.Tracing.TraceSender.Expression_True(10139, 7682, 7776))
=> ErrorCode.ERR_DeprecatedCollectionInitAddStr,
                    (message: { }, isError: true, isColInit: false) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7795, 7879) && DynAbs.Tracing.TraceSender.Expression_True(10139, 7795, 7879))
=> ErrorCode.ERR_DeprecatedSymbolStr,
                    (message: { }, isError: false, isColInit: true) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 7898, 7993) && DynAbs.Tracing.TraceSender.Expression_True(10139, 7898, 7993))
=> ErrorCode.WRN_DeprecatedCollectionInitAddStr,
                    (message: { }, isError: false, isColInit: false) when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 8012, 8097) && DynAbs.Tracing.TraceSender.Expression_True(10139, 8012, 8097))
=> ErrorCode.WRN_DeprecatedSymbolStr
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 8129, 8271);

                // LAFHIS: message
                var
                arguments = (DynAbs.Tracing.TraceSender.Conditional_F1(10139, 8145, 8175) || ((data.Message is string message
                && DynAbs.Tracing.TraceSender.Conditional_F2(10139, 8195, 8227)) || DynAbs.Tracing.TraceSender.Conditional_F3(10139, 8247, 8270))) ? new object[] { symbol, (string)(data.Message) }
                : new object[] { symbol }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10139, 8287, 8386);

                return f_10139_8294_8385(MessageProvider.Instance, errorCode, data, arguments);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10139, 5913, 8397);

                Microsoft.CodeAnalysis.ObsoleteAttributeData
                f_10139_6041_6069(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 6041, 6069);
                    return return_v;
                }


                int
                f_10139_6084_6110(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6084, 6110);
                    return 0;
                }


                bool
                f_10139_6365_6386_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 6365, 6386);
                    return return_v;
                }


                int
                f_10139_6352_6387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6352, 6387);
                    return 0;
                }


                bool
                f_10139_6496_6549(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6496, 6549);
                    return return_v;
                }


                int
                f_10139_6711_6745(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6711, 6745);
                    return 0;
                }


                int
                f_10139_6764_6791(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6764, 6791);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10139_6973_7017()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10139, 6973, 7017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FormattedSymbol
                f_10139_6945_7018(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                symbolDisplayFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.FormattedSymbol((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)symbol, symbolDisplayFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6945, 7018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10139_6896_7019(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 6896, 7019);
                    return return_v;
                }


                bool
                f_10139_7157_7218(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 7157, 7218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo
                f_10139_8294_8385(Microsoft.CodeAnalysis.CSharp.MessageProvider
                messageProvider, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, Microsoft.CodeAnalysis.ObsoleteAttributeData
                data, params object[]
                arguments)
                {
                    var return_v = new Microsoft.CodeAnalysis.CustomObsoleteDiagnosticInfo((Microsoft.CodeAnalysis.CommonMessageProvider)messageProvider, (int)errorCode, data, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10139, 8294, 8385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10139, 5913, 8397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 5913, 8397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ObsoleteAttributeHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10139, 605, 8404);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10139, 605, 8404);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10139, 605, 8404);
        }

    }
}
