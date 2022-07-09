// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
    internal abstract class CommonEmbeddedTypesManager
    {
        public abstract bool IsFrozen { get; }

        public abstract ImmutableArray<Cci.INamespaceTypeDefinition> GetTypes(DiagnosticBag diagnostics, HashSet<string> namesOfTopLevelTypes);

        public CommonEmbeddedTypesManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(778, 533, 790);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(778, 533, 790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 533, 790);
        }


        static CommonEmbeddedTypesManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(778, 533, 790);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(778, 533, 790);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 533, 790);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(778, 533, 790);
    }
    internal abstract partial class EmbeddedTypesManager<
            TPEModuleBuilder,
            TModuleCompilationState,
            TEmbeddedTypesManager,
            TSyntaxNode,
            TAttributeData,
            TSymbol,
            TAssemblySymbol,
            TNamedTypeSymbol,
            TFieldSymbol,
            TMethodSymbol,
            TEventSymbol,
            TPropertySymbol,
            TParameterSymbol,
            TTypeParameterSymbol,
            TEmbeddedType,
            TEmbeddedField,
            TEmbeddedMethod,
            TEmbeddedEvent,
            TEmbeddedProperty,
            TEmbeddedParameter,
            TEmbeddedTypeParameter> : CommonEmbeddedTypesManager
            where TPEModuleBuilder : CommonPEModuleBuilder
            where TModuleCompilationState : CommonModuleCompilationState
            where TEmbeddedTypesManager : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
            where TSyntaxNode : SyntaxNode
            where TAttributeData : AttributeData, Cci.ICustomAttribute
            where TAssemblySymbol : class
            where TNamedTypeSymbol : class, TSymbol, Cci.INamespaceTypeReference
            where TFieldSymbol : class, TSymbol, Cci.IFieldReference
            where TMethodSymbol : class, TSymbol, Cci.IMethodReference
            where TEventSymbol : class, TSymbol, Cci.ITypeMemberReference
            where TPropertySymbol : class, TSymbol, Cci.ITypeMemberReference
            where TParameterSymbol : class, TSymbol, Cci.IParameterListEntry, Cci.INamedEntity
            where TTypeParameterSymbol : class, TSymbol, Cci.IGenericMethodParameterReference
            where TEmbeddedType : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
            where TEmbeddedField : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedField
            where TEmbeddedMethod : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMethod
            where TEmbeddedEvent : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedEvent
            where TEmbeddedProperty : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedProperty
            where TEmbeddedParameter : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedParameter
            where TEmbeddedTypeParameter : EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedTypeParameter
    {
        public readonly TPEModuleBuilder ModuleBeingBuilt;

        public readonly ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType> EmbeddedTypesMap;

        public readonly ConcurrentDictionary<TFieldSymbol, TEmbeddedField> EmbeddedFieldsMap;

        public readonly ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod> EmbeddedMethodsMap;

        public readonly ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty> EmbeddedPropertiesMap;

        public readonly ConcurrentDictionary<TEventSymbol, TEmbeddedEvent> EmbeddedEventsMap;

        private ImmutableArray<TEmbeddedType> _frozen;

        protected EmbeddedTypesManager(TPEModuleBuilder moduleBeingBuilt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(778, 6882, 7024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 5827, 5843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 5926, 6038);
                this.EmbeddedTypesMap = f_778_5945_6038(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 6116, 6226);
                this.EmbeddedFieldsMap = f_778_6136_6226(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 6306, 6419);
                this.EmbeddedMethodsMap = f_778_6327_6419(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 6503, 6623);
                this.EmbeddedPropertiesMap = f_778_6527_6623(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 6701, 6811);
                this.EmbeddedEventsMap = f_778_6721_6811(ReferenceEqualityComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 6972, 7013);

                this.ModuleBeingBuilt = moduleBeingBuilt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(778, 6882, 7024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 6882, 7024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 6882, 7024);
            }
        }

        public override bool IsFrozen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 7090, 7167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7126, 7152);

                    return f_778_7133_7151_M(!_frozen.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(778, 7090, 7167);

                    bool
                    f_778_7133_7151_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 7133, 7151);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 7036, 7178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 7036, 7178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Cci.INamespaceTypeDefinition> GetTypes(DiagnosticBag diagnostics, HashSet<string> namesOfTopLevelTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 7190, 9329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7349, 9240) || true) && (_frozen.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 7349, 9240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7404, 7460);

                    var
                    builder = f_778_7418_7459()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7478, 7520);

                    f_778_7478_7519(builder, f_778_7495_7518(EmbeddedTypesMap));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7538, 7574);

                    f_778_7538_7573(builder, TypeComparer.Instance);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7594, 9225) || true) && (f_778_7598_7683(ref _frozen, f_778_7654_7682(builder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 7594, 9225);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7725, 9206) || true) && (_frozen.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 7725, 9206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7797, 7844);

                            Cci.INamespaceTypeDefinition
                            prev = _frozen[0]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7870, 7958);

                            bool
                            reportedDuplicate = f_778_7895_7957(this, namesOfTopLevelTypes, _frozen[0], diagnostics)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7995, 8000);

                                for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 7986, 9113) || true) && (i < _frozen.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8022, 8025)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(778, 7986, 9113))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 7986, 9113);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8083, 8133);

                                    Cci.INamespaceTypeDefinition
                                    current = _frozen[i]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8165, 9086) || true) && (f_778_8169_8187(prev) == f_778_8191_8212(current) && (DynAbs.Tracing.TraceSender.Expression_True(778, 8169, 8274) && f_778_8249_8258(prev) == f_778_8262_8274(current)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 8165, 9086);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8340, 8793) || true) && (!reportedDuplicate)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 8340, 8793);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8436, 8473);

                                            f_778_8436_8472(_frozen[i - 1] == prev);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8614, 8695);

                                            f_778_8614_8694(this, _frozen[i - 1], _frozen[i], diagnostics);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8733, 8758);

                                            reportedDuplicate = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(778, 8340, 8793);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(778, 8165, 9086);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 8165, 9086);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8923, 8938);

                                        prev = current;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 8972, 9055);

                                        reportedDuplicate = f_778_8992_9054(this, namesOfTopLevelTypes, _frozen[i], diagnostics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(778, 8165, 9086);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(778, 1, 1128);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(778, 1, 1128);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9141, 9183);

                            f_778_9141_9182(this, _frozen, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(778, 7725, 9206);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(778, 7594, 9225);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 7349, 9240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9256, 9318);

                return f_778_9263_9317(_frozen);
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 7190, 9329);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TEmbeddedType>
                f_778_7418_7459()
                {
                    var return_v = ArrayBuilder<TEmbeddedType>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7418, 7459);
                    return return_v;
                }


                System.Collections.Generic.ICollection<TEmbeddedType>
                f_778_7495_7518(System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 7495, 7518);
                    return return_v;
                }


                int
                f_778_7478_7519(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TEmbeddedType>
                this_param, System.Collections.Generic.ICollection<TEmbeddedType>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<TEmbeddedType>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7478, 7519);
                    return 0;
                }


                int
                f_778_7538_7573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TEmbeddedType>
                this_param, Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.TypeComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<TEmbeddedType>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7538, 7573);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TEmbeddedType>
                f_778_7654_7682(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TEmbeddedType>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7654, 7682);
                    return return_v;
                }


                bool
                f_778_7598_7683(ref System.Collections.Immutable.ImmutableArray<TEmbeddedType>
                location, System.Collections.Immutable.ImmutableArray<TEmbeddedType>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7598, 7683);
                    return return_v;
                }


                bool
                f_778_7895_7957(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, System.Collections.Generic.HashSet<string>
                namesOfTopLevelTypes, TEmbeddedType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.HasNameConflict(namesOfTopLevelTypes, type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 7895, 7957);
                    return return_v;
                }


                string
                f_778_8169_8187(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 8169, 8187);
                    return return_v;
                }


                string
                f_778_8191_8212(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 8191, 8212);
                    return return_v;
                }


                string?
                f_778_8249_8258(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 8249, 8258);
                    return return_v;
                }


                string?
                f_778_8262_8274(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 8262, 8274);
                    return return_v;
                }


                int
                f_778_8436_8472(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 8436, 8472);
                    return 0;
                }


                int
                f_778_8614_8694(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                typeA, TEmbeddedType
                typeB, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportNameCollisionBetweenEmbeddedTypes(typeA, typeB, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 8614, 8694);
                    return 0;
                }


                bool
                f_778_8992_9054(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, System.Collections.Generic.HashSet<string>
                namesOfTopLevelTypes, TEmbeddedType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.HasNameConflict(namesOfTopLevelTypes, type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 8992, 9054);
                    return return_v;
                }


                int
                f_778_9141_9182(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, System.Collections.Immutable.ImmutableArray<TEmbeddedType>
                types, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.OnGetTypesCompleted(types, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 9141, 9182);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.INamespaceTypeDefinition>
                f_778_9263_9317(System.Collections.Immutable.ImmutableArray<TEmbeddedType>
                from)
                {
                    var return_v = StaticCast<Cci.INamespaceTypeDefinition>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 9263, 9317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 7190, 9329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 7190, 9329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasNameConflict(HashSet<string> namesOfTopLevelTypes, TEmbeddedType type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 9341, 9881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9479, 9519);

                Cci.INamespaceTypeDefinition
                def = type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9535, 9841) || true) && (f_778_9539_9633(namesOfTopLevelTypes, f_778_9569_9632(f_778_9604_9621(def), f_778_9623_9631(def))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 9535, 9841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9734, 9796);

                    f_778_9734_9795(this, type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9814, 9826);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 9535, 9841);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 9857, 9870);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 9341, 9881);

                string
                f_778_9604_9621(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 9604, 9621);
                    return return_v;
                }


                string?
                f_778_9623_9631(Microsoft.Cci.INamespaceTypeDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 9623, 9631);
                    return return_v;
                }


                string
                f_778_9569_9632(string
                qualifier, string?
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 9569, 9632);
                    return return_v;
                }


                bool
                f_778_9539_9633(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 9539, 9633);
                    return return_v;
                }


                int
                f_778_9734_9795(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportNameCollisionWithAlreadyDeclaredType(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 9734, 9795);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 9341, 9881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 9341, 9881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract int GetTargetAttributeSignatureIndex(TSymbol underlyingSymbol, TAttributeData attrData, AttributeDescription description);

        internal bool IsTargetAttribute(TSymbol underlyingSymbol, TAttributeData attrData, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 10045, 10284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 10186, 10273);

                return f_778_10193_10266(this, underlyingSymbol, attrData, description) != -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 10045, 10284);

                int
                f_778_10193_10266(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TSymbol
                underlyingSymbol, TAttributeData
                attrData, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(underlyingSymbol, attrData, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 10193, 10266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 10045, 10284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 10045, 10284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract TAttributeData CreateSynthesizedAttribute(WellKnownMember constructor, TAttributeData attrData, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract void ReportIndirectReferencesToLinkedAssemblies(TAssemblySymbol assembly, DiagnosticBag diagnostics);

        protected abstract void OnGetTypesCompleted(ImmutableArray<TEmbeddedType> types, DiagnosticBag diagnostics);

        protected abstract void ReportNameCollisionBetweenEmbeddedTypes(TEmbeddedType typeA, TEmbeddedType typeB, DiagnosticBag diagnostics);

        protected abstract void ReportNameCollisionWithAlreadyDeclaredType(TEmbeddedType type, DiagnosticBag diagnostics);

        protected abstract TAttributeData CreateCompilerGeneratedAttribute();
        private sealed class TypeComparer : IComparer<TEmbeddedType>
        {
            public static readonly TypeComparer Instance;

            private TypeComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(778, 11238, 11290);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(778, 11238, 11290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 11238, 11290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 11238, 11290);
                }
            }

            public int Compare(TEmbeddedType x, TEmbeddedType y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 11306, 12018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11391, 11427);

                    Cci.INamespaceTypeDefinition
                    dx = x
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11445, 11481);

                    Cci.INamespaceTypeDefinition
                    dy = y
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11501, 11591);

                    int
                    result = f_778_11514_11590(f_778_11529_11545(dx), f_778_11547_11563(dy), StringComparison.Ordinal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11611, 11969) || true) && (result == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 11611, 11969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11668, 11736);

                        result = f_778_11677_11735(f_778_11692_11699(dx), f_778_11701_11708(dy), StringComparison.Ordinal);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11760, 11950) || true) && (result == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 11760, 11950);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11878, 11927);

                            result = f_778_11887_11905(x) - f_778_11908_11926(y);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(778, 11760, 11950);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(778, 11611, 11969);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11989, 12003);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(778, 11306, 12018);

                    string
                    f_778_11529_11545(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11529, 11545);
                        return return_v;
                    }


                    string
                    f_778_11547_11563(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11547, 11563);
                        return return_v;
                    }


                    int
                    f_778_11514_11590(string
                    strA, string
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11514, 11590);
                        return return_v;
                    }


                    string?
                    f_778_11692_11699(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11692, 11699);
                        return return_v;
                    }


                    string?
                    f_778_11701_11708(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11701, 11708);
                        return return_v;
                    }


                    int
                    f_778_11677_11735(string?
                    strA, string?
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11677, 11735);
                        return return_v;
                    }


                    int
                    f_778_11887_11905(TEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.AssemblyRefIndex;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11887, 11905);
                        return return_v;
                    }


                    int
                    f_778_11908_11926(TEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.AssemblyRefIndex;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(778, 11908, 11926);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 11306, 12018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 11306, 12018);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static TypeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(778, 11071, 12029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 11192, 11221);
                Instance = f_778_11203_11221(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(778, 11071, 12029);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 11071, 12029);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(778, 11071, 12029);

            static Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.TypeComparer
            f_778_11203_11221()
            {
                var return_v = new Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.TypeComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 11203, 11221);
                return return_v;
            }

        }

        protected void EmbedReferences(Cci.ITypeDefinitionMember embeddedMember, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 12041, 12413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 12192, 12353);

                var
                noPiaIndexer = f_778_12211_12352(f_778_12240_12351(ModuleBeingBuilt, syntaxNodeOpt, diagnostics, metadataOnly: false, includePrivateMembers: true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 12367, 12402);

                f_778_12367_12401(noPiaIndexer, embeddedMember);
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 12041, 12413);

                Microsoft.CodeAnalysis.Emit.EmitContext
                f_778_12240_12351(TPEModuleBuilder
                module, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 12240, 12351);
                    return return_v;
                }


                Microsoft.Cci.TypeReferenceIndexer
                f_778_12211_12352(Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = new Microsoft.Cci.TypeReferenceIndexer(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 12211, 12352);
                    return return_v;
                }


                int
                f_778_12367_12401(Microsoft.Cci.TypeReferenceIndexer
                this_param, Microsoft.Cci.ITypeDefinitionMember
                typeMember)
                {
                    this_param.Visit(typeMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 12367, 12401);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 12041, 12413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 12041, 12413);
            }
        }

        protected abstract TEmbeddedType GetEmbeddedTypeForMember(TSymbol member, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract TEmbeddedField EmbedField(TEmbeddedType type, TFieldSymbol field, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract TEmbeddedMethod EmbedMethod(TEmbeddedType type, TMethodSymbol method, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract TEmbeddedProperty EmbedProperty(TEmbeddedType type, TPropertySymbol property, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

        internal abstract TEmbeddedEvent EmbedEvent(TEmbeddedType type, TEventSymbol @event, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding);

        internal Cci.IFieldReference EmbedFieldIfNeedTo(TFieldSymbol fieldSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 13337, 13764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 13489, 13576);

                TEmbeddedType
                type = f_778_13510_13575(this, fieldSymbol, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 13590, 13720) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 13590, 13720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 13640, 13705);

                    return f_778_13647_13704(this, type, fieldSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 13590, 13720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 13734, 13753);

                return fieldSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 13337, 13764);

                TEmbeddedType
                f_778_13510_13575(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TFieldSymbol
                member, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypeForMember((TSymbol)member, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 13510, 13575);
                    return return_v;
                }


                TEmbeddedField
                f_778_13647_13704(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                type, TFieldSymbol
                field, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedField(type, field, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 13647, 13704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 13337, 13764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 13337, 13764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IMethodReference EmbedMethodIfNeedTo(TMethodSymbol methodSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 13776, 14211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 13932, 14020);

                TEmbeddedType
                type = f_778_13953_14019(this, methodSymbol, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14034, 14166) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 14034, 14166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14084, 14151);

                    return f_778_14091_14150(this, type, methodSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 14034, 14166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14180, 14200);

                return methodSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 13776, 14211);

                TEmbeddedType
                f_778_13953_14019(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TMethodSymbol
                member, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypeForMember((TSymbol)member, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 13953, 14019);
                    return return_v;
                }


                TEmbeddedMethod
                f_778_14091_14150(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                type, TMethodSymbol
                method, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethod(type, method, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 14091, 14150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 13776, 14211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 13776, 14211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void EmbedEventIfNeedTo(TEventSymbol eventSymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 14223, 14662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14396, 14483);

                TEmbeddedType
                type = f_778_14417_14482(this, eventSymbol, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14497, 14651) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 14497, 14651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14547, 14636);

                    f_778_14547_14635(this, type, eventSymbol, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 14497, 14651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 14223, 14662);

                TEmbeddedType
                f_778_14417_14482(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEventSymbol
                member, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypeForMember((TSymbol)member, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 14417, 14482);
                    return return_v;
                }


                TEmbeddedEvent
                f_778_14547_14635(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                type, TEventSymbol
                @event, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isUsedForComAwareEventBinding)
                {
                    var return_v = this_param.EmbedEvent(type, @event, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 14547, 14635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 14223, 14662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 14223, 14662);
            }
        }

        internal void EmbedPropertyIfNeedTo(TPropertySymbol propertySymbol, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(778, 14674, 15064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14820, 14910);

                TEmbeddedType
                type = f_778_14841_14909(this, propertySymbol, syntaxNodeOpt, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14924, 15053) || true) && (type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(778, 14924, 15053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(778, 14974, 15038);

                    f_778_14974_15037(this, type, propertySymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(778, 14924, 15053);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(778, 14674, 15064);

                TEmbeddedType
                f_778_14841_14909(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TPropertySymbol
                member, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypeForMember((TSymbol)member, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 14841, 14909);
                    return return_v;
                }


                TEmbeddedProperty
                f_778_14974_15037(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>
                this_param, TEmbeddedType
                type, TPropertySymbol
                property, TSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedProperty(type, property, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 14974, 15037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(778, 14674, 15064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(778, 14674, 15064);
            }
        }

        System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType>
        f_778_5945_6038(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TNamedTypeSymbol, TEmbeddedType>((System.Collections.Generic.IEqualityComparer<TNamedTypeSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 5945, 6038);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<TFieldSymbol, TEmbeddedField>
        f_778_6136_6226(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TFieldSymbol, TEmbeddedField>((System.Collections.Generic.IEqualityComparer<TFieldSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6136, 6226);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod>
        f_778_6327_6419(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod>((System.Collections.Generic.IEqualityComparer<TMethodSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6327, 6419);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty>
        f_778_6527_6623(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty>((System.Collections.Generic.IEqualityComparer<TPropertySymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6527, 6623);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<TEventSymbol, TEmbeddedEvent>
        f_778_6721_6811(Roslyn.Utilities.ReferenceEqualityComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<TEventSymbol, TEmbeddedEvent>((System.Collections.Generic.IEqualityComparer<TEventSymbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(778, 6721, 6811);
            return return_v;
        }

    }
}
