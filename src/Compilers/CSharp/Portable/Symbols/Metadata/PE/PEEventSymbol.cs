// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.DocumentationComments;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEEventSymbol : EventSymbol
    {
        private readonly string _name;

        private readonly PENamedTypeSymbol _containingType;

        private readonly EventDefinitionHandle _handle;

        private readonly TypeWithAnnotations _eventTypeWithAnnotations;

        private readonly PEMethodSymbol _addMethod;

        private readonly PEMethodSymbol _removeMethod;

        private readonly PEFieldSymbol? _associatedFieldOpt;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private Tuple<CultureInfo, string>? _lazyDocComment;

        private DiagnosticInfo? _lazyUseSiteDiagnostic;

        private ObsoleteAttributeData _lazyObsoleteAttributeData;

        private const int
        UnsetAccessibility = -1
        ;

        private int _lazyDeclaredAccessibility;

        private readonly Flags _flags;
        [Flags]
        private enum Flags : byte
        {
            IsSpecialName = 1,
            IsRuntimeSpecialName = 2,
            CallMethodsDirectly = 4
        }

        internal PEEventSymbol(
                    PEModuleSymbol moduleSymbol,
                    PENamedTypeSymbol containingType,
                    EventDefinitionHandle handle,
                    PEMethodSymbol addMethod,
                    PEMethodSymbol removeMethod,
                    MultiDictionary<string, PEFieldSymbol> privateFieldNameToSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10704, 2033, 6344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 879, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 930, 945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1118, 1128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1171, 1184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1227, 1246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1369, 1384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1419, 1475);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1547, 1611);
                this._lazyObsoleteAttributeData = ObsoleteAttributeData.Uninitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1749, 1796);
                this._lazyDeclaredAccessibility = UnsetAccessibility; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1832, 1838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2373, 2422);

                f_10704_2373_2421((object)moduleSymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2436, 2487);

                f_10704_2436_2486((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2501, 2529);

                f_10704_2501_2528(f_10704_2514_2527_M(!handle.IsNil));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2543, 2589);

                f_10704_2543_2588((object)addMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2603, 2652);

                f_10704_2603_2651((object)removeMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2668, 2691);

                _addMethod = addMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2705, 2734);

                _removeMethod = removeMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2748, 2765);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2779, 2812);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2828, 2856);

                EventAttributes
                mdFlags = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2870, 2917);

                EntityHandle
                eventType = default(EntityHandle)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 2969, 3002);

                    var
                    module = f_10704_2982_3001(moduleSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3020, 3098);

                    f_10704_3020_3097(module, handle, out _name, out mdFlags, out eventType);
                }
                catch (BadImageFormatException mrEx)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10704, 3127, 3534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3196, 3226);

                    _name = _name ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10704, 3204, 3225) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3244, 3323);

                    _lazyUseSiteDiagnostic = f_10704_3269_3322(ErrorCode.ERR_BindToBogus, this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3343, 3519) || true) && (eventType.IsNil)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 3343, 3519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3404, 3500);

                        _eventTypeWithAnnotations = TypeWithAnnotations.Create(f_10704_3459_3498(mrEx));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 3343, 3519);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10704, 3127, 3534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3550, 3612);

                TypeSymbol
                originalEventType = _eventTypeWithAnnotations.Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3626, 4979) || true) && (f_10704_3630_3664_M(!_eventTypeWithAnnotations.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 3626, 4979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3698, 3770);

                    var
                    metadataDecoder = f_10704_3720_3769(moduleSymbol, containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3788, 3850);

                    originalEventType = f_10704_3808_3849(metadataDecoder, eventType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3870, 3916);

                    const int
                    targetSymbolCustomModifierCount = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 3934, 4058);

                    var
                    typeSymbol = DynamicTypeDecoder.TransformType(originalEventType, targetSymbolCustomModifierCount, handle, moduleSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 4076, 4162);

                    typeSymbol = NativeIntegerTypeDecoder.TransformType(typeSymbol, handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 4259, 4309);

                    var
                    type = TypeWithAnnotations.Create(typeSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 4680, 4814);

                    type = f_10704_4687_4813(type, handle, moduleSymbol, accessSymbol: _containingType, nullableContext: _containingType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 4832, 4913);

                    type = TupleTypeDecoder.DecodeTupleTypesIfApplicable(type, handle, moduleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 4931, 4964);

                    _eventTypeWithAnnotations = type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 3626, 4979);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5096, 5147);

                bool
                isWindowsRuntimeEvent = f_10704_5125_5146()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5161, 5372);

                bool
                callMethodsDirectly = (DynAbs.Tracing.TraceSender.Conditional_F1(10704, 5188, 5209) || ((isWindowsRuntimeEvent
                && DynAbs.Tracing.TraceSender.Conditional_F2(10704, 5229, 5273)) || DynAbs.Tracing.TraceSender.Conditional_F3(10704, 5293, 5371))) ? !f_10704_5230_5273(_addMethod, _removeMethod) : !f_10704_5294_5371(moduleSymbol, originalEventType, _addMethod, _removeMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5388, 6038) || true) && (callMethodsDirectly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 5388, 6038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5445, 5481);

                    _flags |= Flags.CallMethodsDirectly;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 5388, 6038);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 5388, 6038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5547, 5604);

                    f_10704_5547_5603(_addMethod, this, MethodKind.EventAdd);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5622, 5685);

                    f_10704_5622_5684(_removeMethod, this, MethodKind.EventRemove);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5705, 5807);

                    PEFieldSymbol?
                    associatedField = f_10704_5738_5806(this, privateFieldNameToSymbols, isWindowsRuntimeEvent)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5825, 6023) || true) && ((object?)associatedField != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 5825, 6023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5903, 5941);

                        _associatedFieldOpt = associatedField;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 5963, 6004);

                        f_10704_5963_6003(associatedField, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 5825, 6023);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 5388, 6038);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 6054, 6181) || true) && ((mdFlags & EventAttributes.SpecialName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 6054, 6181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 6136, 6166);

                    _flags |= Flags.IsSpecialName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 6054, 6181);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 6197, 6333) || true) && ((mdFlags & EventAttributes.RTSpecialName) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 6197, 6333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 6281, 6318);

                    _flags |= Flags.IsRuntimeSpecialName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 6197, 6333);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10704, 2033, 6344);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 2033, 6344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 2033, 6344);
            }
        }

        private PEFieldSymbol? GetAssociatedField(MultiDictionary<string, PEFieldSymbol> privateFieldNameToSymbols, bool isWindowsRuntimeEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 6801, 8564);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7050, 8525);
                    foreach (PEFieldSymbol candidateAssociatedField in f_10704_7101_7133_I(f_10704_7101_7133(privateFieldNameToSymbols, _name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 7050, 8525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7167, 7253);

                        f_10704_7167_7252(f_10704_7180_7226(candidateAssociatedField) == Accessibility.Private);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7419, 7491);

                        TypeSymbol
                        candidateAssociatedFieldType = f_10704_7461_7490(candidateAssociatedField)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7511, 8510) || true) && (isWindowsRuntimeEvent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 7511, 8510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7578, 7698);

                            NamedTypeSymbol
                            eventRegistrationTokenTable_T = f_10704_7626_7697(((PEModuleSymbol)(f_10704_7644_7665(this))))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 7720, 8184) || true) && (f_10704_7724_7858(eventRegistrationTokenTable_T, f_10704_7773_7820(candidateAssociatedFieldType), TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 7724, 8079) && f_10704_7887_8079(_eventTypeWithAnnotations.Type, f_10704_7937_8033(((NamedTypeSymbol)candidateAssociatedFieldType))[0].Type, TypeCompareKind.ConsiderEverything2)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 7720, 8184);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 8129, 8161);

                                return candidateAssociatedField;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 7720, 8184);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 7511, 8510);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 7511, 8510);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 8266, 8491) || true) && (f_10704_8270_8386(candidateAssociatedFieldType, _eventTypeWithAnnotations.Type, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 8266, 8491);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 8436, 8468);

                                return candidateAssociatedField;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 8266, 8491);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 7511, 8510);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 7050, 8525);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10704, 1, 1476);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10704, 1, 1476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 8541, 8553);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 6801, 8564);

                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>.ValueSet
                f_10704_7101_7133(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7101, 7133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10704_7180_7226(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7180, 7226);
                    return return_v;
                }


                int
                f_10704_7167_7252(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 7167, 7252);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10704_7461_7490(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7461, 7490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10704_7644_7665(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7644, 7665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10704_7626_7697(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param)
                {
                    var return_v = this_param.EventRegistrationTokenTable_T;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7626, 7697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10704_7773_7820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7773, 7820);
                    return return_v;
                }


                bool
                f_10704_7724_7858(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 7724, 7858);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10704_7937_8033(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 7937, 8033);
                    return return_v;
                }


                bool
                f_10704_7887_8079(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 7887, 8079);
                    return return_v;
                }


                bool
                f_10704_8270_8386(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 8270, 8386);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>.ValueSet
                f_10704_7101_7133_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 7101, 7133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 6801, 8564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 6801, 8564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsWindowsRuntimeEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 8643, 9720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 8679, 8768);

                    NamedTypeSymbol
                    token = f_10704_8703_8767(((PEModuleSymbol)(f_10704_8721_8742(this))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 9359, 9705);

                    return
                    f_10704_9387_9471(f_10704_9405_9426(_addMethod), token, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 9387, 9526) && f_10704_9496_9521(_addMethod) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 9387, 9584) && f_10704_9551_9579(_removeMethod) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 9387, 9704) && f_10704_9609_9704(f_10704_9627_9659(f_10704_9627_9651(_removeMethod)[0]), token, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 8643, 9720);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10704_8721_8742(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 8721, 8742);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10704_8703_8767(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.EventRegistrationToken;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 8703, 8767);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10704_9405_9426(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 9405, 9426);
                        return return_v;
                    }


                    bool
                    f_10704_9387_9471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 9387, 9471);
                        return return_v;
                    }


                    int
                    f_10704_9496_9521(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 9496, 9521);
                        return return_v;
                    }


                    int
                    f_10704_9551_9579(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 9551, 9579);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10704_9627_9651(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 9627, 9651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10704_9627_9659(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 9627, 9659);
                        return return_v;
                    }


                    bool
                    f_10704_9609_9704(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 9609, 9704);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 8576, 9731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 8576, 9731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FieldSymbol? AssociatedField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 9814, 9892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 9850, 9877);

                    return _associatedFieldOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 9814, 9892);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 9743, 9903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 9743, 9903);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 9979, 10053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10015, 10038);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 9979, 10053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 9915, 10064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 9915, 10064);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10147, 10221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10183, 10206);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10147, 10221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10076, 10232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10076, 10232);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10296, 10317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10302, 10315);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10296, 10317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10244, 10328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10244, 10328);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10402, 10453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10408, 10451);

                    return (_flags & Flags.IsSpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10402, 10453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10340, 10464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10340, 10464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasRuntimeSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10545, 10603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10551, 10601);

                    return (_flags & Flags.IsRuntimeSpecialName) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10545, 10603);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10476, 10614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10476, 10614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal EventDefinitionHandle Handle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10688, 10754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10724, 10739);

                    return _handle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10688, 10754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10626, 10765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10626, 10765);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 10853, 11328);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10889, 11244) || true) && (_lazyDeclaredAccessibility == UnsetAccessibility)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 10889, 11244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 10983, 11103);

                        Accessibility
                        accessibility = f_10704_11013_11102(_addMethod, _removeMethod)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 11125, 11225);

                        f_10704_11125_11224(ref _lazyDeclaredAccessibility, accessibility, UnsetAccessibility);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 10889, 11244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 11264, 11313);

                    return (Accessibility)_lazyDeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 10853, 11328);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10704_11013_11102(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    accessor1, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    accessor2)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetDeclaredAccessibilityFromAccessors((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)accessor1, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)accessor2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 11013, 11102);
                        return return_v;
                    }


                    int
                    f_10704_11125_11224(ref int
                    location1, Microsoft.CodeAnalysis.Accessibility
                    value, int
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, (int)value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 11125, 11224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 10777, 11339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 10777, 11339);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 11405, 11551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 11483, 11536);

                    return f_10704_11490_11509(_addMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 11490, 11535) || f_10704_11513_11535(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 11405, 11551);

                    bool
                    f_10704_11490_11509(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11490, 11509);
                        return return_v;
                    }


                    bool
                    f_10704_11513_11535(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExtern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11513, 11535);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 11351, 11562);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 11351, 11562);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 11630, 11782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 11710, 11767);

                    return f_10704_11717_11738(_addMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 11717, 11766) || f_10704_11742_11766(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 11630, 11782);

                    bool
                    f_10704_11717_11738(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11717, 11738);
                        return return_v;
                    }


                    bool
                    f_10704_11742_11766(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAbstract;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11742, 11766);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 11574, 11793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 11574, 11793);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 11859, 12031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 11963, 12016);

                    return f_10704_11970_11989(_addMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 11970, 12015) || f_10704_11993_12015(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 11859, 12031);

                    bool
                    f_10704_11970_11989(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11970, 11989);
                        return return_v;
                    }


                    bool
                    f_10704_11993_12015(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSealed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 11993, 12015);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 11805, 12042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 11805, 12042);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 12109, 12338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 12236, 12323);

                    return f_10704_12243_12254_M(!IsOverride) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 12243, 12269) && f_10704_12258_12269_M(!IsAbstract)) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 12243, 12322) && (f_10704_12274_12294(_addMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 12274, 12321) || f_10704_12298_12321(_removeMethod))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 12109, 12338);

                    bool
                    f_10704_12243_12254_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12243, 12254);
                        return return_v;
                    }


                    bool
                    f_10704_12258_12269_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12258, 12269);
                        return return_v;
                    }


                    bool
                    f_10704_12274_12294(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12274, 12294);
                        return return_v;
                    }


                    bool
                    f_10704_12298_12321(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12298, 12321);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 12054, 12349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 12054, 12349);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 12417, 12569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 12497, 12554);

                    return f_10704_12504_12525(_addMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 12504, 12553) || f_10704_12529_12553(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 12417, 12569);

                    bool
                    f_10704_12504_12525(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12504, 12525);
                        return return_v;
                    }


                    bool
                    f_10704_12529_12553(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12529, 12553);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 12361, 12580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 12361, 12580);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 12646, 12792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 12724, 12777);

                    return f_10704_12731_12750(_addMethod) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 12731, 12776) && f_10704_12754_12776(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 12646, 12792);

                    bool
                    f_10704_12731_12750(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12731, 12750);
                        return return_v;
                    }


                    bool
                    f_10704_12754_12776(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 12754, 12776);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 12592, 12803);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 12592, 12803);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 12895, 12936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 12901, 12934);

                    return _eventTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 12895, 12936);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 12815, 12947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 12815, 12947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol AddMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 13022, 13048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13028, 13046);

                    return _addMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 13022, 13048);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 12959, 13059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 12959, 13059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol RemoveMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 13137, 13166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13143, 13164);

                    return _removeMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 13137, 13166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 13071, 13177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 13071, 13177);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 13264, 13409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13300, 13394);

                    return f_10704_13307_13341(_containingType).MetadataLocation.Cast<MetadataLocation, Location>();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 13264, 13409);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10704_13307_13341(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 13307, 13341);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 13189, 13420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 13189, 13420);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 13530, 13626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13566, 13611);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 13530, 13626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 13432, 13637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 13432, 13637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 13649, 14048);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13741, 13994) || true) && (_lazyCustomAttributes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 13741, 13994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13810, 13879);

                    var
                    containingPEModuleSymbol = (PEModuleSymbol)f_10704_13857_13878(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 13897, 13979);

                    f_10704_13897_13978(containingPEModuleSymbol, _handle, ref _lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 13741, 13994);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14008, 14037);

                return _lazyCustomAttributes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 13649, 14048);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10704_13857_13878(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 13857, 13878);
                    return return_v;
                }


                int
                f_10704_13897_13978(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                this_param, System.Reflection.Metadata.EventDefinitionHandle
                token, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                customAttributes)
                {
                    this_param.LoadCustomAttributes((System.Reflection.Metadata.EntityHandle)token, ref customAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 13897, 13978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 13649, 14048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 13649, 14048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 14060, 14226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14192, 14215);

                return f_10704_14199_14214(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 14060, 14226);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10704_14199_14214(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 14199, 14214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 14060, 14226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 14060, 14226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<EventSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 14577, 15399);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14613, 14857) || true) && (_addMethod.ExplicitInterfaceImplementations.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10704, 14617, 14755) && _removeMethod.ExplicitInterfaceImplementations.Length == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 14613, 14857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14797, 14838);

                        return ImmutableArray<EventSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 14613, 14857);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14877, 14980);

                    var
                    implementedEvents = f_10704_14901_14979(_addMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 14998, 15113);

                    f_10704_14998_15112(implementedEvents, f_10704_15030_15111(_removeMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15133, 15187);

                    var
                    builder = f_10704_15147_15186()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15207, 15328);
                        foreach (var @event in f_10704_15230_15247_I(implementedEvents))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 15207, 15328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15289, 15309);

                            f_10704_15289_15308(builder, @event);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 15207, 15328);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10704, 1, 122);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10704, 1, 122);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15348, 15384);

                    return f_10704_15355_15383(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 14577, 15399);

                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10704_14901_14979(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    accessor)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetEventsForExplicitlyImplementedAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)accessor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 14901, 14979);
                        return return_v;
                    }


                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10704_15030_15111(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                    accessor)
                    {
                        var return_v = PEPropertyOrEventHelpers.GetEventsForExplicitlyImplementedAccessor((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)accessor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15030, 15111);
                        return return_v;
                    }


                    int
                    f_10704_14998_15112(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    this_param, System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    other)
                    {
                        this_param.IntersectWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 14998, 15112);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10704_15147_15186()
                    {
                        var return_v = ArrayBuilder<EventSymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15147, 15186);
                        return return_v;
                    }


                    int
                    f_10704_15289_15308(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15289, 15308);
                        return 0;
                    }


                    System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10704_15230_15247_I(System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15230, 15247);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10704_15355_15383(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15355, 15383);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 14476, 15410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 14476, 15410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 15493, 15550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15499, 15548);

                    return (_flags & Flags.CallMethodsDirectly) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 15493, 15550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 15422, 15561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 15422, 15561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static bool DoSignaturesMatch(
                    PEModuleSymbol moduleSymbol,
                    TypeSymbol eventType,
                    PEMethodSymbol addMethod,
                    PEMethodSymbol removeMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10704, 15573, 16100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 15794, 16089);

                return
                                (f_10704_15819_15845(eventType) || (DynAbs.Tracing.TraceSender.Expression_False(10704, 15819, 15872) || f_10704_15849_15872(eventType))) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 15818, 15948) && f_10704_15894_15948(moduleSymbol, eventType, addMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 15818, 16026) && f_10704_15969_16026(moduleSymbol, eventType, removeMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 15818, 16088) && f_10704_16047_16088(addMethod, removeMethod));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10704, 15573, 16100);

                bool
                f_10704_15819_15845(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15819, 15845);
                    return return_v;
                }


                bool
                f_10704_15849_15872(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15849, 15872);
                    return return_v;
                }


                bool
                f_10704_15894_15948(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                eventType, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                method)
                {
                    var return_v = DoesSignatureMatch(moduleSymbol, eventType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15894, 15948);
                    return return_v;
                }


                bool
                f_10704_15969_16026(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                eventType, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                method)
                {
                    var return_v = DoesSignatureMatch(moduleSymbol, eventType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 15969, 16026);
                    return return_v;
                }


                bool
                f_10704_16047_16088(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                addMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                removeMethod)
                {
                    var return_v = DoModifiersMatch(addMethod, removeMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 16047, 16088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 15573, 16100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 15573, 16100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DoModifiersMatch(PEMethodSymbol addMethod, PEMethodSymbol removeMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10704, 16112, 17097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 16515, 17086);

                return
                                (f_10704_16540_16558(addMethod) == f_10704_16562_16583(removeMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10704, 16539, 17085) &&                // (addMethod.IsAbstract == removeMethod.IsAbstract) && // NOTE: Dev10 accepts one abstract accessor (same as for events)
                                                                                                                                                                                            // (addMethod.IsSealed == removeMethod.IsSealed) && // NOTE: Dev10 accepts one sealed accessor (for events, not for properties)
                                                                                                                                                                                            // (addMethod.IsOverride == removeMethod.IsOverride) && // NOTE: Dev10 accepts one override accessor (for events, not for properties)
                                (f_10704_17041_17059(addMethod) == f_10704_17063_17084(removeMethod)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10704, 16112, 17097);

                bool
                f_10704_16540_16558(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 16540, 16558);
                    return return_v;
                }


                bool
                f_10704_16562_16583(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 16562, 16583);
                    return return_v;
                }


                bool
                f_10704_17041_17059(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 17041, 17059);
                    return return_v;
                }


                bool
                f_10704_17063_17084(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 17063, 17084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 16112, 17097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 16112, 17097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool DoesSignatureMatch(
                    PEModuleSymbol moduleSymbol,
                    TypeSymbol eventType,
                    PEMethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10704, 17109, 17885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17397, 17461);

                var
                metadataDecoder = f_10704_17419_17460(moduleSymbol, method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17475, 17507);

                SignatureHeader
                signatureHeader
                = default(SignatureHeader);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17521, 17551);

                BadImageFormatException?
                mrEx
                = default(BadImageFormatException?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17565, 17692);

                var
                methodParams = f_10704_17584_17691(metadataDecoder, f_10704_17622_17635(method), out signatureHeader, out mrEx, setParamHandles: false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17708, 17786) || true) && (mrEx != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 17708, 17786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17758, 17771);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 17708, 17786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 17802, 17874);

                return f_10704_17809_17873(metadataDecoder, eventType, methodParams);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10704, 17109, 17885);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                f_10704_17419_17460(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 17419, 17460);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinitionHandle
                f_10704_17622_17635(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
                this_param)
                {
                    var return_v = this_param.Handle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 17622, 17635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                f_10704_17584_17691(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.MethodDefinitionHandle
                methodDef, out System.Reflection.Metadata.SignatureHeader
                signatureHeader, out System.BadImageFormatException?
                metadataException, bool
                setParamHandles)
                {
                    var return_v = this_param.GetSignatureForMethod(methodDef, out signatureHeader, out metadataException, setParamHandles: setParamHandles);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 17584, 17691);
                    return return_v;
                }


                bool
                f_10704_17809_17873(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                eventType, Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>[]
                methodParams)
                {
                    var return_v = this_param.DoesSignatureMatchEvent(eventType, methodParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 17809, 17873);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 17109, 17885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 17109, 17885);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 17897, 18274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18104, 18263);

                return f_10704_18111_18262(this, f_10704_18169_18203(_containingType), preferredCulture, cancellationToken, ref _lazyDocComment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 17897, 18274);

                Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                f_10704_18169_18203(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingPEModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 18169, 18203);
                    return return_v;
                }


                string
                f_10704_18111_18262(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                containingPEModule, System.Globalization.CultureInfo?
                preferredCulture, System.Threading.CancellationToken
                cancellationToken, ref System.Tuple<System.Globalization.CultureInfo, string>?
                lazyDocComment)
                {
                    var return_v = PEDocumentationCommentUtils.GetDocumentationComment((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, containingPEModule, preferredCulture, cancellationToken, ref lazyDocComment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 18111, 18262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 17897, 18274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 17897, 18274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 18286, 18686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18367, 18629) || true) && (f_10704_18371_18443(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10704, 18367, 18629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18477, 18507);

                    DiagnosticInfo?
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18525, 18564);

                    f_10704_18525_18563(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18582, 18614);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10704, 18367, 18629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18645, 18675);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 18286, 18686);

                bool
                f_10704_18371_18443(Microsoft.CodeAnalysis.DiagnosticInfo?
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 18371, 18443);
                    return return_v;
                }


                bool
                f_10704_18525_18563(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 18525, 18563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 18286, 18686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 18286, 18686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 18784, 19059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 18820, 18992);

                    f_10704_18820_18991(ref _lazyObsoleteAttributeData, _handle, (f_10704_18938_18959(this)), ignoreByRefLikeMarker: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 19010, 19044);

                    return _lazyObsoleteAttributeData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 18784, 19059);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10704_18938_18959(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 18938, 18959);
                        return return_v;
                    }


                    int
                    f_10704_18820_18991(ref Microsoft.CodeAnalysis.ObsoleteAttributeData
                    data, System.Reflection.Metadata.EventDefinitionHandle
                    token, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    containingModule, bool
                    ignoreByRefLikeMarker)
                    {
                        ObsoleteAttributeHelpers.InitializeObsoleteDataFromMetadata(ref data, (System.Reflection.Metadata.EntityHandle)token, (Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol)containingModule, ignoreByRefLikeMarker: ignoreByRefLikeMarker);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 18820, 18991);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 18698, 19070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 18698, 19070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation? DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10704, 19196, 19216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 19202, 19214);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10704, 19196, 19216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10704, 19082, 19227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 19082, 19227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEEventSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10704, 789, 19234);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10704, 1703, 1726);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10704, 789, 19234);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10704, 789, 19234);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10704, 789, 19234);

        int
        f_10704_2373_2421(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 2373, 2421);
            return 0;
        }


        int
        f_10704_2436_2486(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 2436, 2486);
            return 0;
        }


        bool
        f_10704_2514_2527_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 2514, 2527);
            return return_v;
        }


        int
        f_10704_2501_2528(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 2501, 2528);
            return 0;
        }


        int
        f_10704_2543_2588(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 2543, 2588);
            return 0;
        }


        int
        f_10704_2603_2651(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 2603, 2651);
            return 0;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10704_2982_3001(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 2982, 3001);
            return return_v;
        }


        int
        f_10704_3020_3097(Microsoft.CodeAnalysis.PEModule
        this_param, System.Reflection.Metadata.EventDefinitionHandle
        eventDef, out string
        name, out System.Reflection.EventAttributes
        flags, out System.Reflection.Metadata.EntityHandle
        type)
        {
            this_param.GetEventDefPropsOrThrow(eventDef, out name, out flags, out type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 3020, 3097);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10704_3269_3322(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code, params object[]
        args)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 3269, 3322);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
        f_10704_3459_3498(System.BadImageFormatException
        mrEx)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol(mrEx);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 3459, 3498);
            return return_v;
        }


        bool
        f_10704_3630_3664_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 3630, 3664);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        f_10704_3720_3769(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        context)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol, context);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 3720, 3769);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        f_10704_3808_3849(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        this_param, System.Reflection.Metadata.EntityHandle
        token)
        {
            var return_v = this_param.GetTypeOfToken(token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 3808, 3849);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10704_4687_4813(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        metadataType, System.Reflection.Metadata.EventDefinitionHandle
        targetSymbolToken, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        containingModule, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        accessSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
        nullableContext)
        {
            var return_v = NullableTypeDecoder.TransformType(metadataType, (System.Reflection.Metadata.EntityHandle)targetSymbolToken, containingModule, accessSymbol: (Microsoft.CodeAnalysis.CSharp.Symbol)accessSymbol, nullableContext: (Microsoft.CodeAnalysis.CSharp.Symbol)nullableContext);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 4687, 4813);
            return return_v;
        }


        bool
        f_10704_5125_5146()
        {
            var return_v = IsWindowsRuntimeEvent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10704, 5125, 5146);
            return return_v;
        }


        bool
        f_10704_5230_5273(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        addMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        removeMethod)
        {
            var return_v = DoModifiersMatch(addMethod, removeMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5230, 5273);
            return return_v;
        }


        bool
        f_10704_5294_5371(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        eventType, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        addMethod, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        removeMethod)
        {
            var return_v = DoSignaturesMatch(moduleSymbol, eventType, addMethod, removeMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5294, 5371);
            return return_v;
        }


        bool
        f_10704_5547_5603(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
        eventSymbol, Microsoft.CodeAnalysis.MethodKind
        methodKind)
        {
            var return_v = this_param.SetAssociatedEvent(eventSymbol, methodKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5547, 5603);
            return return_v;
        }


        bool
        f_10704_5622_5684(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEMethodSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
        eventSymbol, Microsoft.CodeAnalysis.MethodKind
        methodKind)
        {
            var return_v = this_param.SetAssociatedEvent(eventSymbol, methodKind);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5622, 5684);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol?
        f_10704_5738_5806(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
        this_param, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol>
        privateFieldNameToSymbols, bool
        isWindowsRuntimeEvent)
        {
            var return_v = this_param.GetAssociatedField(privateFieldNameToSymbols, isWindowsRuntimeEvent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5738, 5806);
            return return_v;
        }


        int
        f_10704_5963_6003(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEFieldSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEEventSymbol
        eventSymbol)
        {
            this_param.SetAssociatedEvent(eventSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10704, 5963, 6003);
            return 0;
        }

    }
}
