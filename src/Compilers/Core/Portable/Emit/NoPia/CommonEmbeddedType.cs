// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.Emit.NoPia
{
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
            TEmbeddedTypeParameter>
    {
        internal abstract class CommonEmbeddedType : Cci.INamespaceTypeDefinition
        {
            public readonly TEmbeddedTypesManager TypeManager;

            public readonly TNamedTypeSymbol UnderlyingNamedType;

            private ImmutableArray<Cci.IFieldDefinition> _lazyFields;

            private ImmutableArray<Cci.IMethodDefinition> _lazyMethods;

            private ImmutableArray<Cci.IPropertyDefinition> _lazyProperties;

            private ImmutableArray<Cci.IEventDefinition> _lazyEvents;

            private ImmutableArray<TAttributeData> _lazyAttributes;

            private int _lazyAssemblyRefIndex;

            protected CommonEmbeddedType(TEmbeddedTypesManager typeManager, TNamedTypeSymbol underlyingNamedType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(776, 1799, 2044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 1287, 1298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 1346, 1365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 1756, 1782);
                    this._lazyAssemblyRefIndex = -1; DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 1933, 1964);

                    this.TypeManager = typeManager;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 1982, 2029);

                    this.UnderlyingNamedType = underlyingNamedType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(776, 1799, 2044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 1799, 2044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 1799, 2044);
                }
            }

            protected abstract int GetAssemblyRefIndex();

            protected abstract IEnumerable<TFieldSymbol> GetFieldsToEmit();

            protected abstract IEnumerable<TMethodSymbol> GetMethodsToEmit();

            protected abstract IEnumerable<TEventSymbol> GetEventsToEmit();

            protected abstract IEnumerable<TPropertySymbol> GetPropertiesToEmit();

            protected abstract bool IsPublic { get; }

            protected abstract bool IsAbstract { get; }

            protected abstract Cci.ITypeReference GetBaseClass(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            protected abstract IEnumerable<Cci.TypeReferenceWithAttributes> GetInterfaces(EmitContext context);

            protected abstract bool IsBeforeFieldInit { get; }

            protected abstract bool IsComImport { get; }

            protected abstract bool IsInterface { get; }

            protected abstract bool IsDelegate { get; }

            protected abstract bool IsSerializable { get; }

            protected abstract bool IsSpecialName { get; }

            protected abstract bool IsWindowsRuntimeImport { get; }

            protected abstract bool IsSealed { get; }

            protected abstract TypeLayout? GetTypeLayoutIfStruct();

            protected abstract System.Runtime.InteropServices.CharSet StringFormat { get; }

            protected abstract TAttributeData CreateTypeIdentifierAttribute(bool hasGuid, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            protected abstract void EmbedDefaultMembers(string defaultMember, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            protected abstract IEnumerable<TAttributeData> GetCustomAttributesToEmit(TPEModuleBuilder moduleBuilder);

            protected abstract void ReportMissingAttribute(AttributeDescription description, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            private bool IsTargetAttribute(TAttributeData attrData, AttributeDescription description)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 4008, 4226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 4130, 4211);

                    return f_776_4137_4210(TypeManager, UnderlyingNamedType, attrData, description);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 4008, 4226);

                    bool
                    f_776_4137_4210(TEmbeddedTypesManager
                    this_param, TNamedTypeSymbol
                    underlyingSymbol, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute((TSymbol)underlyingSymbol, attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 4137, 4210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 4008, 4226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 4008, 4226);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<TAttributeData> GetAttributes(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 4242, 12661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 4413, 4470);

                    var
                    builder = f_776_4427_4469()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 4669, 4737);

                    f_776_4669_4736(
                                    // Put the CompilerGenerated attribute on the NoPIA types we define so that 
                                    // static analysis tools (e.g. fxcop) know that they can be skipped
                                    builder, f_776_4689_4735(TypeManager));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 4808, 4829);

                    bool
                    hasGuid = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 4847, 4890);

                    bool
                    hasComEventInterfaceAttribute = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5185, 10468);
                        foreach (var attrData in f_776_5210_5250_I(f_776_5210_5250(this, moduleBuilder)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5185, 10468);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5292, 10449) || true) && (f_776_5296_5359(this, attrData, AttributeDescription.GuidAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5292, 10449);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5409, 5427);

                                string
                                guidString
                                = default(string);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5453, 5887) || true) && (f_776_5457_5506(attrData, out guidString))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5453, 5887);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5649, 5664);

                                    hasGuid = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5694, 5860);

                                    f_776_5694_5859(builder, f_776_5714_5858(TypeManager, WellKnownMember.System_Runtime_InteropServices_GuidAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5453, 5887);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5292, 10449);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5292, 10449);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 5937, 10449) || true) && (f_776_5941_6017(this, attrData, AttributeDescription.ComEventInterfaceAttribute))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5937, 10449);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6067, 6449) || true) && (attrData.CommonConstructorArguments.Length == 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 6067, 6449);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6176, 6213);

                                        hasComEventInterfaceAttribute = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6243, 6422);

                                        f_776_6243_6421(builder, f_776_6263_6420(TypeManager, WellKnownMember.System_Runtime_InteropServices_ComEventInterfaceAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 6067, 6449);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5937, 10449);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 5937, 10449);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6547, 6689);

                                    int
                                    signatureIndex = f_776_6568_6688(TypeManager, UnderlyingNamedType, attrData, AttributeDescription.InterfaceTypeAttribute)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6715, 10426) || true) && (signatureIndex != -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 6715, 10426);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6797, 6854);

                                        f_776_6797_6853(signatureIndex == 0 || (DynAbs.Tracing.TraceSender.Expression_False(776, 6810, 6852) || signatureIndex == 1));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 6884, 7402) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 6884, 7402);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 7001, 7371);

                                            f_776_7001_7370(builder, f_776_7021_7369(TypeManager, (DynAbs.Tracing.TraceSender.Conditional_F1(776, 7060, 7079) || ((signatureIndex == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(776, 7082, 7162)) || DynAbs.Tracing.TraceSender.Conditional_F3(776, 7202, 7293))) ? WellKnownMember.System_Runtime_InteropServices_InterfaceTypeAttribute__ctorInt16 : WellKnownMember.System_Runtime_InteropServices_InterfaceTypeAttribute__ctorComInterfaceType, attrData, syntaxNodeOpt, diagnostics));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 6884, 7402);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 6715, 10426);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 6715, 10426);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 7460, 10426) || true) && (f_776_7464_7537(this, attrData, AttributeDescription.BestFitMappingAttribute))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 7460, 10426);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 7595, 7919) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 7595, 7919);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 7712, 7888);

                                                f_776_7712_7887(builder, f_776_7732_7886(TypeManager, WellKnownMember.System_Runtime_InteropServices_BestFitMappingAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 7595, 7919);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 7460, 10426);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 7460, 10426);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 7977, 10426) || true) && (f_776_7981_8047(this, attrData, AttributeDescription.CoClassAttribute))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 7977, 10426);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8105, 8422) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8105, 8422);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8222, 8391);

                                                    f_776_8222_8390(builder, f_776_8242_8389(TypeManager, WellKnownMember.System_Runtime_InteropServices_CoClassAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8105, 8422);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 7977, 10426);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 7977, 10426);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8480, 10426) || true) && (f_776_8484_8548(this, attrData, AttributeDescription.FlagsAttribute))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8480, 10426);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8606, 8927) || true) && (attrData.CommonConstructorArguments.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(776, 8610, 8687) && f_776_8661_8687(UnderlyingNamedType)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8606, 8927);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8753, 8896);

                                                        f_776_8753_8895(builder, f_776_8773_8894(TypeManager, WellKnownMember.System_FlagsAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8606, 8927);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8480, 10426);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8480, 10426);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 8985, 10426) || true) && (f_776_8989_9061(this, attrData, AttributeDescription.DefaultMemberAttribute))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8985, 10426);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9119, 9862) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 9119, 9862);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9236, 9398);

                                                            f_776_9236_9397(builder, f_776_9256_9396(TypeManager, WellKnownMember.System_Reflection_DefaultMemberAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9514, 9600);

                                                            string
                                                            defaultMember = f_776_9537_9572(attrData)[0].ValueInternal as string
                                                            ;

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9634, 9831) || true) && (defaultMember != null)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 9634, 9831);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9733, 9796);

                                                                f_776_9733_9795(this, defaultMember, syntaxNodeOpt, diagnostics);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 9634, 9831);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 9119, 9862);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8985, 10426);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 8985, 10426);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 9920, 10426) || true) && (f_776_9924_10007(this, attrData, AttributeDescription.UnmanagedFunctionPointerAttribute))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 9920, 10426);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 10065, 10399) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 10065, 10399);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 10182, 10368);

                                                                f_776_10182_10367(builder, f_776_10202_10366(TypeManager, WellKnownMember.System_Runtime_InteropServices_UnmanagedFunctionPointerAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 10065, 10399);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 9920, 10426);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8985, 10426);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 8480, 10426);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 7977, 10426);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 7460, 10426);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 6715, 10426);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5937, 10449);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5292, 10449);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 5185, 10468);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(776, 1, 5284);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(776, 1, 5284);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 11035, 12195) || true) && (f_776_11039_11050() && (DynAbs.Tracing.TraceSender.Expression_True(776, 11039, 11084) && !hasComEventInterfaceAttribute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 11035, 12195);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 11126, 12176) || true) && (f_776_11130_11142_M(!IsComImport))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 11126, 12176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 11506, 11598);

                            f_776_11506_11597(this, AttributeDescription.ComImportAttribute, syntaxNodeOpt, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 11126, 12176);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 11126, 12176);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 11648, 12176) || true) && (!hasGuid)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 11648, 12176);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12066, 12153);

                                f_776_12066_12152(this, AttributeDescription.GuidAttribute, syntaxNodeOpt, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 11648, 12176);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 11126, 12176);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 11035, 12195);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12487, 12590);

                    f_776_12487_12589(
                                    // Note, this logic should match the one in RetargetingSymbolTranslator.RetargetNoPiaLocalType
                                    // when we try to predict what attributes we will emit on embedded type, which corresponds the 
                                    // type we are retargeting.

                                    builder, f_776_12507_12588(this, hasGuid && (DynAbs.Tracing.TraceSender.Expression_True(776, 12537, 12559) && f_776_12548_12559()), syntaxNodeOpt, diagnostics));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12610, 12646);

                    return f_776_12617_12645(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 4242, 12661);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    f_776_4427_4469()
                    {
                        var return_v = ArrayBuilder<TAttributeData>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 4427, 4469);
                        return return_v;
                    }


                    TAttributeData
                    f_776_4689_4735(TEmbeddedTypesManager
                    this_param)
                    {
                        var return_v = this_param.CreateCompilerGeneratedAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 4689, 4735);
                        return return_v;
                    }


                    int
                    f_776_4669_4736(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 4669, 4736);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TAttributeData>
                    f_776_5210_5250(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TPEModuleBuilder
                    moduleBuilder)
                    {
                        var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5210, 5250);
                        return return_v;
                    }


                    bool
                    f_776_5296_5359(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5296, 5359);
                        return return_v;
                    }


                    bool
                    f_776_5457_5506(TAttributeData
                    attrData, out string
                    guidString)
                    {
                        var return_v = attrData.TryGetGuidAttributeValue(out guidString);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5457, 5506);
                        return return_v;
                    }


                    TAttributeData
                    f_776_5714_5858(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5714, 5858);
                        return return_v;
                    }


                    int
                    f_776_5694_5859(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5694, 5859);
                        return 0;
                    }


                    bool
                    f_776_5941_6017(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5941, 6017);
                        return return_v;
                    }


                    TAttributeData
                    f_776_6263_6420(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 6263, 6420);
                        return return_v;
                    }


                    int
                    f_776_6243_6421(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 6243, 6421);
                        return 0;
                    }


                    int
                    f_776_6568_6688(TEmbeddedTypesManager
                    this_param, TNamedTypeSymbol
                    underlyingSymbol, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.GetTargetAttributeSignatureIndex((TSymbol)underlyingSymbol, attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 6568, 6688);
                        return return_v;
                    }


                    int
                    f_776_6797_6853(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 6797, 6853);
                        return 0;
                    }


                    TAttributeData
                    f_776_7021_7369(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7021, 7369);
                        return return_v;
                    }


                    int
                    f_776_7001_7370(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7001, 7370);
                        return 0;
                    }


                    bool
                    f_776_7464_7537(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7464, 7537);
                        return return_v;
                    }


                    TAttributeData
                    f_776_7732_7886(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7732, 7886);
                        return return_v;
                    }


                    int
                    f_776_7712_7887(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7712, 7887);
                        return 0;
                    }


                    bool
                    f_776_7981_8047(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 7981, 8047);
                        return return_v;
                    }


                    TAttributeData
                    f_776_8242_8389(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8242, 8389);
                        return return_v;
                    }


                    int
                    f_776_8222_8390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8222, 8390);
                        return 0;
                    }


                    bool
                    f_776_8484_8548(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8484, 8548);
                        return return_v;
                    }


                    bool
                    f_776_8661_8687(TNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsEnum;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 8661, 8687);
                        return return_v;
                    }


                    TAttributeData
                    f_776_8773_8894(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8773, 8894);
                        return return_v;
                    }


                    int
                    f_776_8753_8895(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8753, 8895);
                        return 0;
                    }


                    bool
                    f_776_8989_9061(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 8989, 9061);
                        return return_v;
                    }


                    TAttributeData
                    f_776_9256_9396(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 9256, 9396);
                        return return_v;
                    }


                    int
                    f_776_9236_9397(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 9236, 9397);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_776_9537_9572(TAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonConstructorArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 9537, 9572);
                        return return_v;
                    }


                    int
                    f_776_9733_9795(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, string
                    defaultMember, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.EmbedDefaultMembers(defaultMember, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 9733, 9795);
                        return 0;
                    }


                    bool
                    f_776_9924_10007(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute(attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 9924, 10007);
                        return return_v;
                    }


                    TAttributeData
                    f_776_10202_10366(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 10202, 10366);
                        return return_v;
                    }


                    int
                    f_776_10182_10367(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 10182, 10367);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TAttributeData>
                    f_776_5210_5250_I(System.Collections.Generic.IEnumerable<TAttributeData>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 5210, 5250);
                        return return_v;
                    }


                    bool
                    f_776_11039_11050()
                    {
                        var return_v = IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 11039, 11050);
                        return return_v;
                    }


                    bool
                    f_776_11130_11142_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 11130, 11142);
                        return return_v;
                    }


                    int
                    f_776_11506_11597(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, Microsoft.CodeAnalysis.AttributeDescription
                    description, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.ReportMissingAttribute(description, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 11506, 11597);
                        return 0;
                    }


                    int
                    f_776_12066_12152(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, Microsoft.CodeAnalysis.AttributeDescription
                    description, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        this_param.ReportMissingAttribute(description, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12066, 12152);
                        return 0;
                    }


                    bool
                    f_776_12548_12559()
                    {
                        var return_v = IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 12548, 12559);
                        return return_v;
                    }


                    TAttributeData
                    f_776_12507_12588(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, bool
                    hasGuid, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateTypeIdentifierAttribute(hasGuid, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12507, 12588);
                        return return_v;
                    }


                    int
                    f_776_12487_12589(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12487, 12589);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<TAttributeData>
                    f_776_12617_12645(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12617, 12645);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 4242, 12661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 4242, 12661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public int AssemblyRefIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 12737, 13068);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12781, 12998) || true) && (_lazyAssemblyRefIndex == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 12781, 12998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12862, 12908);

                            _lazyAssemblyRefIndex = f_776_12886_12907(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 12934, 12975);

                            f_776_12934_12974(_lazyAssemblyRefIndex >= 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 12781, 12998);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13020, 13049);

                        return _lazyAssemblyRefIndex;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 12737, 13068);

                        int
                        f_776_12886_12907(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                        this_param)
                        {
                            var return_v = this_param.GetAssemblyRefIndex();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12886, 12907);
                            return return_v;
                        }


                        int
                        f_776_12934_12974(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 12934, 12974);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 12677, 13083);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 12677, 13083);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.INamespaceTypeDefinition.IsPublic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 13174, 13253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13218, 13234);

                        return f_776_13225_13233();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 13174, 13253);

                        bool
                        f_776_13225_13233()
                        {
                            var return_v = IsPublic;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 13225, 13233);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 13099, 13268);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 13099, 13268);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ITypeDefinition.GetBaseClass(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 13284, 13515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13389, 13500);

                    return f_776_13396_13499(this, context.Module, context.SyntaxNodeOpt, context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 13284, 13515);

                    Microsoft.Cci.ITypeReference
                    f_776_13396_13499(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                    moduleBuilder, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetBaseClass((TPEModuleBuilder)moduleBuilder, (TSyntaxNode)syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13396, 13499);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 13284, 13515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 13284, 13515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.IEventDefinition> Cci.ITypeDefinition.GetEvents(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 13531, 14377);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13648, 14323) || true) && (_lazyEvents.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 13648, 14323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13715, 13750);

                        f_776_13715_13749(f_776_13728_13748(TypeManager));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13774, 13837);

                        var
                        builder = f_776_13788_13836()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13861, 14190);
                            foreach (var e in f_776_13879_13896_I(f_776_13879_13896(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 13861, 14190);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13946, 13970);

                                TEmbeddedEvent
                                embedded
                                = default(TEmbeddedEvent);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 13998, 14167) || true) && (f_776_14002_14060(TypeManager.EmbeddedEventsMap, e, out embedded))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 13998, 14167);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14118, 14140);

                                    f_776_14118_14139(builder, embedded);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 13998, 14167);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 13861, 14190);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(776, 1, 330);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(776, 1, 330);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14214, 14304);

                        f_776_14214_14303(ref _lazyEvents, f_776_14274_14302(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 13648, 14323);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14343, 14362);

                    return _lazyEvents;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 13531, 14377);

                    bool
                    f_776_13728_13748(TEmbeddedTypesManager
                    this_param)
                    {
                        var return_v = this_param.IsFrozen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 13728, 13748);
                        return return_v;
                    }


                    int
                    f_776_13715_13749(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13715, 13749);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IEventDefinition>
                    f_776_13788_13836()
                    {
                        var return_v = ArrayBuilder<Cci.IEventDefinition>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13788, 13836);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TEventSymbol>
                    f_776_13879_13896(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.GetEventsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13879, 13896);
                        return return_v;
                    }


                    bool
                    f_776_14002_14060(System.Collections.Concurrent.ConcurrentDictionary<TEventSymbol, TEmbeddedEvent>
                    this_param, TEventSymbol
                    key, out TEmbeddedEvent
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14002, 14060);
                        return return_v;
                    }


                    int
                    f_776_14118_14139(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IEventDefinition>
                    this_param, TEmbeddedEvent
                    item)
                    {
                        this_param.Add((Microsoft.Cci.IEventDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14118, 14139);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TEventSymbol>
                    f_776_13879_13896_I(System.Collections.Generic.IEnumerable<TEventSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 13879, 13896);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IEventDefinition>
                    f_776_14274_14302(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IEventDefinition>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14274, 14302);
                        return return_v;
                    }


                    bool
                    f_776_14214_14303(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IEventDefinition>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IEventDefinition>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14214, 14303);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 13531, 14377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 13531, 14377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.MethodImplementation> Cci.ITypeDefinition.GetExplicitImplementationOverrides(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 14393, 14628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14539, 14613);

                    return f_776_14546_14612();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 14393, 14628);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
                    f_776_14546_14612()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<Cci.MethodImplementation>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14546, 14612);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 14393, 14628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 14393, 14628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.IFieldDefinition> Cci.ITypeDefinition.GetFields(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 14644, 15490);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14761, 15436) || true) && (_lazyFields.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 14761, 15436);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14828, 14863);

                        f_776_14828_14862(f_776_14841_14861(TypeManager));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14887, 14950);

                        var
                        builder = f_776_14901_14949()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 14974, 15303);
                            foreach (var f in f_776_14992_15009_I(f_776_14992_15009(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 14974, 15303);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15059, 15083);

                                TEmbeddedField
                                embedded
                                = default(TEmbeddedField);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15111, 15280) || true) && (f_776_15115_15173(TypeManager.EmbeddedFieldsMap, f, out embedded))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 15111, 15280);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15231, 15253);

                                    f_776_15231_15252(builder, embedded);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 15111, 15280);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 14974, 15303);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(776, 1, 330);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(776, 1, 330);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15327, 15417);

                        f_776_15327_15416(ref _lazyFields, f_776_15387_15415(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 14761, 15436);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15456, 15475);

                    return _lazyFields;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 14644, 15490);

                    bool
                    f_776_14841_14861(TEmbeddedTypesManager
                    this_param)
                    {
                        var return_v = this_param.IsFrozen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 14841, 14861);
                        return return_v;
                    }


                    int
                    f_776_14828_14862(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14828, 14862);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFieldDefinition>
                    f_776_14901_14949()
                    {
                        var return_v = ArrayBuilder<Cci.IFieldDefinition>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14901, 14949);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TFieldSymbol>
                    f_776_14992_15009(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.GetFieldsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14992, 15009);
                        return return_v;
                    }


                    bool
                    f_776_15115_15173(System.Collections.Concurrent.ConcurrentDictionary<TFieldSymbol, TEmbeddedField>
                    this_param, TFieldSymbol
                    key, out TEmbeddedField
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15115, 15173);
                        return return_v;
                    }


                    int
                    f_776_15231_15252(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFieldDefinition>
                    this_param, TEmbeddedField
                    item)
                    {
                        this_param.Add((Microsoft.Cci.IFieldDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15231, 15252);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TFieldSymbol>
                    f_776_14992_15009_I(System.Collections.Generic.IEnumerable<TFieldSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 14992, 15009);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFieldDefinition>
                    f_776_15387_15415(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IFieldDefinition>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15387, 15415);
                        return return_v;
                    }


                    bool
                    f_776_15327_15416(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFieldDefinition>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IFieldDefinition>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15327, 15416);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 14644, 15490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 14644, 15490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.IGenericTypeParameter> Cci.ITypeDefinition.GenericParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 15615, 15753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15659, 15734);

                        return f_776_15666_15733();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 15615, 15753);

                        System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
                        f_776_15666_15733()
                        {
                            var return_v = SpecializedCollections.EmptyEnumerable<Cci.IGenericTypeParameter>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 15666, 15733);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 15506, 15768);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 15506, 15768);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ushort Cci.ITypeDefinition.GenericParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 15865, 15937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 15909, 15918);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 15865, 15937);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 15784, 15952);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 15784, 15952);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.HasDeclarativeSecurity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 16048, 16210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 16178, 16191);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 16048, 16210);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 15968, 16225);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 15968, 16225);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.TypeReferenceWithAttributes> Cci.ITypeDefinition.Interfaces(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 16241, 16415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 16370, 16400);

                    return f_776_16377_16399(this, context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 16241, 16415);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
                    f_776_16377_16399(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetInterfaces(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 16377, 16399);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 16241, 16415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 16241, 16415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool Cci.ITypeDefinition.IsAbstract
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 16499, 16580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 16543, 16561);

                        return f_776_16550_16560();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 16499, 16580);

                        bool
                        f_776_16550_16560()
                        {
                            var return_v = IsAbstract;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16550, 16560);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 16431, 16595);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 16431, 16595);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsBeforeFieldInit
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 16686, 16774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 16730, 16755);

                        return f_776_16737_16754();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 16686, 16774);

                        bool
                        f_776_16737_16754()
                        {
                            var return_v = IsBeforeFieldInit;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16737, 16754);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 16611, 16789);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 16611, 16789);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsComObject
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 16874, 16971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 16918, 16952);

                        return f_776_16925_16936() || (DynAbs.Tracing.TraceSender.Expression_False(776, 16925, 16951) || f_776_16940_16951());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 16874, 16971);

                        bool
                        f_776_16925_16936()
                        {
                            var return_v = IsInterface;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16925, 16936);
                            return return_v;
                        }


                        bool
                        f_776_16940_16951()
                        {
                            var return_v = IsComImport;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 16940, 16951);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 16805, 16986);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 16805, 16986);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsGeneric
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17069, 17145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 17113, 17126);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17069, 17145);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17002, 17160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17002, 17160);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsInterface
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17245, 17327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 17289, 17308);

                        return f_776_17296_17307();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17245, 17327);

                        bool
                        f_776_17296_17307()
                        {
                            var return_v = IsInterface;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17296, 17307);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17176, 17342);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17176, 17342);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsDelegate
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17426, 17507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 17470, 17488);

                        return f_776_17477_17487();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17426, 17507);

                        bool
                        f_776_17477_17487()
                        {
                            var return_v = IsDelegate;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17477, 17487);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17358, 17522);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17358, 17522);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsRuntimeSpecial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17612, 17688);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 17656, 17669);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17612, 17688);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17538, 17703);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17538, 17703);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsSerializable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17791, 17876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 17835, 17857);

                        return f_776_17842_17856();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17791, 17876);

                        bool
                        f_776_17842_17856()
                        {
                            var return_v = IsSerializable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 17842, 17856);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17719, 17891);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17719, 17891);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 17978, 18062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18022, 18043);

                        return f_776_18029_18042();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 17978, 18062);

                        bool
                        f_776_18029_18042()
                        {
                            var return_v = IsSpecialName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18029, 18042);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 17907, 18077);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 17907, 18077);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsWindowsRuntimeImport
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 18173, 18266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18217, 18247);

                        return f_776_18224_18246();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 18173, 18266);

                        bool
                        f_776_18224_18246()
                        {
                            var return_v = IsWindowsRuntimeImport;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18224, 18246);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 18093, 18281);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 18093, 18281);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeDefinition.IsSealed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 18363, 18442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18407, 18423);

                        return f_776_18414_18422();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 18363, 18442);

                        bool
                        f_776_18414_18422()
                        {
                            var return_v = IsSealed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18414, 18422);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 18297, 18457);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 18297, 18457);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            System.Runtime.InteropServices.LayoutKind Cci.ITypeDefinition.Layout
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 18574, 18766);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18618, 18655);

                        var
                        layout = f_776_18631_18654(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18677, 18747);

                        return f_776_18684_18696_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 18684, 18696)?.Kind) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.LayoutKind?>(776, 18684, 18746) ?? System.Runtime.InteropServices.LayoutKind.Auto);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 18574, 18766);

                        Microsoft.CodeAnalysis.TypeLayout?
                        f_776_18631_18654(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                        this_param)
                        {
                            var return_v = this_param.GetTypeLayoutIfStruct();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 18631, 18654);
                            return return_v;
                        }


                        System.Runtime.InteropServices.LayoutKind?
                        f_776_18684_18696_M(System.Runtime.InteropServices.LayoutKind?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18684, 18696);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 18473, 18781);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 18473, 18781);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ushort Cci.ITypeDefinition.Alignment
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 18866, 19028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18910, 18947);

                        var
                        layout = f_776_18923_18946(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 18969, 19009);

                        return (ushort)(f_776_18985_19002_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 18985, 19002)?.Alignment) ?? (DynAbs.Tracing.TraceSender.Expression_Null<short?>(776, 18985, 19007) ?? 0));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 18866, 19028);

                        Microsoft.CodeAnalysis.TypeLayout?
                        f_776_18923_18946(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                        this_param)
                        {
                            var return_v = this_param.GetTypeLayoutIfStruct();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 18923, 18946);
                            return return_v;
                        }


                        short?
                        f_776_18985_19002_M(short?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 18985, 19002);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 18797, 19043);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 18797, 19043);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            uint Cci.ITypeDefinition.SizeOf
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 19123, 19278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19167, 19204);

                        var
                        layout = f_776_19180_19203(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19226, 19259);

                        return (uint)(f_776_19240_19252_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(layout, 776, 19240, 19252)?.Size) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(776, 19240, 19257) ?? 0));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 19123, 19278);

                        Microsoft.CodeAnalysis.TypeLayout?
                        f_776_19180_19203(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                        this_param)
                        {
                            var return_v = this_param.GetTypeLayoutIfStruct();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19180, 19203);
                            return return_v;
                        }


                        int?
                        f_776_19240_19252_M(int?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 19240, 19252);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 19059, 19293);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 19059, 19293);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.IMethodDefinition> Cci.ITypeDefinition.GetMethods(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 19309, 20988);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19428, 20933) || true) && (_lazyMethods.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19428, 20933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19496, 19531);

                        f_776_19496_19530(f_776_19509_19529(TypeManager));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19555, 19619);

                        var
                        builder = f_776_19569_19618()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19643, 19660);

                        int
                        gapIndex = 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19682, 19698);

                        int
                        gapSize = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19722, 20799);
                            foreach (var method in f_776_19745_19763_I(f_776_19745_19763(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19722, 20799);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19813, 20776) || true) && ((object)method != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19813, 20776);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19897, 19922);

                                    TEmbeddedMethod
                                    embedded
                                    = default(TEmbeddedMethod);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 19954, 20625) || true) && (f_776_19958_20022(TypeManager.EmbeddedMethodsMap, method, out embedded))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19954, 20625);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20088, 20396) || true) && (gapSize > 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 20088, 20396);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20177, 20262);

                                            f_776_20177_20261(builder, f_776_20189_20260(this, f_776_20207_20259(gapIndex, gapSize)));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20300, 20311);

                                            gapIndex++;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20349, 20361);

                                            gapSize = 0;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 20088, 20396);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20432, 20454);

                                        f_776_20432_20453(
                                                                        builder, embedded);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19954, 20625);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19954, 20625);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20584, 20594);

                                        gapSize++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19954, 20625);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19813, 20776);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 19813, 20776);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20739, 20749);

                                    gapSize++;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19813, 20776);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19722, 20799);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(776, 1, 1078);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(776, 1, 1078);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20823, 20914);

                        f_776_20823_20913(ref _lazyMethods, f_776_20884_20912(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 19428, 20933);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 20953, 20973);

                    return _lazyMethods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 19309, 20988);

                    bool
                    f_776_19509_19529(TEmbeddedTypesManager
                    this_param)
                    {
                        var return_v = this_param.IsFrozen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 19509, 19529);
                        return return_v;
                    }


                    int
                    f_776_19496_19530(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19496, 19530);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMethodDefinition>
                    f_776_19569_19618()
                    {
                        var return_v = ArrayBuilder<Cci.IMethodDefinition>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19569, 19618);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TMethodSymbol>
                    f_776_19745_19763(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.GetMethodsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19745, 19763);
                        return return_v;
                    }


                    bool
                    f_776_19958_20022(System.Collections.Concurrent.ConcurrentDictionary<TMethodSymbol, TEmbeddedMethod>
                    this_param, TMethodSymbol
                    key, out TEmbeddedMethod
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19958, 20022);
                        return return_v;
                    }


                    string
                    f_776_20207_20259(int
                    sequenceNumber, int
                    countOfSlots)
                    {
                        var return_v = ModuleExtensions.GetVTableGapName(sequenceNumber, countOfSlots);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20207, 20259);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Emit.NoPia.VtblGap
                    f_776_20189_20260(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    containingType, string
                    name)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Emit.NoPia.VtblGap((Microsoft.Cci.ITypeDefinition)containingType, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20189, 20260);
                        return return_v;
                    }


                    int
                    f_776_20177_20261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMethodDefinition>
                    this_param, Microsoft.CodeAnalysis.Emit.NoPia.VtblGap
                    item)
                    {
                        this_param.Add((Microsoft.Cci.IMethodDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20177, 20261);
                        return 0;
                    }


                    int
                    f_776_20432_20453(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMethodDefinition>
                    this_param, TEmbeddedMethod
                    item)
                    {
                        this_param.Add((Microsoft.Cci.IMethodDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20432, 20453);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TMethodSymbol>
                    f_776_19745_19763_I(System.Collections.Generic.IEnumerable<TMethodSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 19745, 19763);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMethodDefinition>
                    f_776_20884_20912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IMethodDefinition>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20884, 20912);
                        return return_v;
                    }


                    bool
                    f_776_20823_20913(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMethodDefinition>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMethodDefinition>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 20823, 20913);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 19309, 20988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 19309, 20988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.INestedTypeDefinition> Cci.ITypeDefinition.GetNestedTypes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 21004, 21221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21131, 21206);

                    return f_776_21138_21205();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 21004, 21221);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                    f_776_21138_21205()
                    {
                        var return_v = SpecializedCollections.EmptyEnumerable<Cci.INestedTypeDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21138, 21205);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 21004, 21221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 21004, 21221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.IPropertyDefinition> Cci.ITypeDefinition.GetProperties(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 21237, 22116);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21361, 22058) || true) && (_lazyProperties.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 21361, 22058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21432, 21467);

                        f_776_21432_21466(f_776_21445_21465(TypeManager));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21491, 21557);

                        var
                        builder = f_776_21505_21556()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21581, 21921);
                            foreach (var p in f_776_21599_21620_I(f_776_21599_21620(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 21581, 21921);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21670, 21697);

                                TEmbeddedProperty
                                embedded
                                = default(TEmbeddedProperty);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21725, 21898) || true) && (f_776_21729_21791(TypeManager.EmbeddedPropertiesMap, p, out embedded))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 21725, 21898);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21849, 21871);

                                    f_776_21849_21870(builder, embedded);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(776, 21725, 21898);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(776, 21581, 21921);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(776, 1, 341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(776, 1, 341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 21945, 22039);

                        f_776_21945_22038(ref _lazyProperties, f_776_22009_22037(builder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 21361, 22058);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22078, 22101);

                    return _lazyProperties;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 21237, 22116);

                    bool
                    f_776_21445_21465(TEmbeddedTypesManager
                    this_param)
                    {
                        var return_v = this_param.IsFrozen;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 21445, 21465);
                        return return_v;
                    }


                    int
                    f_776_21432_21466(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21432, 21466);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IPropertyDefinition>
                    f_776_21505_21556()
                    {
                        var return_v = ArrayBuilder<Cci.IPropertyDefinition>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21505, 21556);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TPropertySymbol>
                    f_776_21599_21620(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param)
                    {
                        var return_v = this_param.GetPropertiesToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21599, 21620);
                        return return_v;
                    }


                    bool
                    f_776_21729_21791(System.Collections.Concurrent.ConcurrentDictionary<TPropertySymbol, TEmbeddedProperty>
                    this_param, TPropertySymbol
                    key, out TEmbeddedProperty
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21729, 21791);
                        return return_v;
                    }


                    int
                    f_776_21849_21870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IPropertyDefinition>
                    this_param, TEmbeddedProperty
                    item)
                    {
                        this_param.Add((Microsoft.Cci.IPropertyDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21849, 21870);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TPropertySymbol>
                    f_776_21599_21620_I(System.Collections.Generic.IEnumerable<TPropertySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21599, 21620);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IPropertyDefinition>
                    f_776_22009_22037(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IPropertyDefinition>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 22009, 22037);
                        return return_v;
                    }


                    bool
                    f_776_21945_22038(ref System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IPropertyDefinition>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IPropertyDefinition>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 21945, 22038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 21237, 22116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 21237, 22116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.SecurityAttribute> Cci.ITypeDefinition.SecurityAttributes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 22238, 22458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22368, 22439);

                        return f_776_22375_22438();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 22238, 22458);

                        System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                        f_776_22375_22438()
                        {
                            var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 22375, 22438);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 22132, 22473);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 22132, 22473);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            System.Runtime.InteropServices.CharSet Cci.ITypeDefinition.StringFormat
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 22593, 22676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22637, 22657);

                        return f_776_22644_22656();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 22593, 22676);

                        System.Runtime.InteropServices.CharSet
                        f_776_22644_22656()
                        {
                            var return_v = StringFormat;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 22644, 22656);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 22489, 22691);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 22489, 22691);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 22707, 23484);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22823, 23426) || true) && (_lazyAttributes.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 22823, 23426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22894, 22940);

                        var
                        diagnostics = f_776_22912_22939()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 22962, 23076);

                        var
                        attributes = f_776_22979_23075(this, context.Module, context.SyntaxNodeOpt, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23100, 23364) || true) && (f_776_23104_23179(ref _lazyAttributes, attributes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(776, 23100, 23364);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23299, 23341);

                            f_776_23299_23340(                        // Save any diagnostics that we encountered.
                                                    context.Diagnostics, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(776, 23100, 23364);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23388, 23407);

                        f_776_23388_23406(
                                            diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(776, 22823, 23426);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23446, 23469);

                    return _lazyAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 22707, 23484);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_776_22912_22939()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 22912, 22939);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TAttributeData>
                    f_776_22979_23075(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedType
                    this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                    moduleBuilder, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetAttributes((TPEModuleBuilder)moduleBuilder, (TSyntaxNode)syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 22979, 23075);
                        return return_v;
                    }


                    bool
                    f_776_23104_23179(ref System.Collections.Immutable.ImmutableArray<TAttributeData>
                    location, System.Collections.Immutable.ImmutableArray<TAttributeData>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 23104, 23179);
                        return return_v;
                    }


                    int
                    f_776_23299_23340(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        this_param.AddRange(bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 23299, 23340);
                        return 0;
                    }


                    int
                    f_776_23388_23406(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 23388, 23406);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 22707, 23484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 22707, 23484);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 23500, 23642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23590, 23627);

                    throw f_776_23596_23626();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 23500, 23642);

                    System.Exception
                    f_776_23596_23626()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 23596, 23626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 23500, 23642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 23500, 23642);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 23658, 23782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23755, 23767);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 23658, 23782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 23658, 23782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 23658, 23782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 23870, 23877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 23873, 23877);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(776, 23870, 23877);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 23870, 23877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 23870, 23877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool Cci.ITypeReference.IsEnum
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 23957, 24054);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 24001, 24035);

                        return f_776_24008_24034(UnderlyingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 23957, 24054);

                        bool
                        f_776_24008_24034(TNamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsEnum;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 24008, 24034);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 23894, 24069);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 23894, 24069);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ITypeReference.IsValueType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 24153, 24255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 24197, 24236);

                        return f_776_24204_24235(UnderlyingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 24153, 24255);

                        bool
                        f_776_24204_24235(TNamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsValueType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 24204, 24235);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 24085, 24270);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 24085, 24270);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeDefinition Cci.ITypeReference.GetResolvedType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 24286, 24421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 24394, 24406);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 24286, 24421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 24286, 24421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 24286, 24421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Cci.PrimitiveTypeCode Cci.ITypeReference.TypeCode
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 24519, 24624);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 24563, 24605);

                        return Cci.PrimitiveTypeCode.NotPrimitive;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 24519, 24624);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 24437, 24639);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 24437, 24639);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            TypeDefinitionHandle Cci.ITypeReference.TypeDef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 24735, 24835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 24779, 24816);

                        return default(TypeDefinitionHandle);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 24735, 24835);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 24655, 24850);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 24655, 24850);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IGenericMethodParameterReference Cci.ITypeReference.AsGenericMethodParameterReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 24988, 25063);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 25032, 25044);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 24988, 25063);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 24866, 25078);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 24866, 25078);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IGenericTypeInstanceReference Cci.ITypeReference.AsGenericTypeInstanceReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 25210, 25285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 25254, 25266);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 25210, 25285);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 25094, 25300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 25094, 25300);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IGenericTypeParameterReference Cci.ITypeReference.AsGenericTypeParameterReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 25434, 25509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 25478, 25490);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 25434, 25509);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 25316, 25524);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 25316, 25524);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.INamespaceTypeDefinition Cci.ITypeReference.AsNamespaceTypeDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 25540, 25694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 25667, 25679);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 25540, 25694);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 25540, 25694);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 25540, 25694);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Cci.INamespaceTypeReference Cci.ITypeReference.AsNamespaceTypeReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 25814, 25889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 25858, 25870);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 25814, 25889);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 25710, 25904);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 25710, 25904);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.INestedTypeDefinition Cci.ITypeReference.AsNestedTypeDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 25920, 26068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26041, 26053);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 25920, 26068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 25920, 26068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 25920, 26068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Cci.INestedTypeReference Cci.ITypeReference.AsNestedTypeReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 26182, 26257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26226, 26238);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 26182, 26257);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 26084, 26272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 26084, 26272);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ISpecializedNestedTypeReference Cci.ITypeReference.AsSpecializedNestedTypeReference
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 26408, 26483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26452, 26464);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 26408, 26483);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 26288, 26498);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 26288, 26498);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeDefinition Cci.ITypeReference.AsTypeDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 26514, 26650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26623, 26635);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 26514, 26650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 26514, 26650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 26514, 26650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            ushort Cci.INamedTypeReference.GenericParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 26751, 26823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26795, 26804);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 26751, 26823);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 26666, 26838);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 26666, 26838);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.INamedTypeReference.MangleName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 26926, 27027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 26970, 27008);

                        return f_776_26977_27007(UnderlyingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 26926, 27027);

                        bool
                        f_776_26977_27007(TNamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.MangleName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 26977, 27007);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 26854, 27042);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 26854, 27042);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 27119, 27214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 27163, 27195);

                        return f_776_27170_27194(UnderlyingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 27119, 27214);

                        string?
                        f_776_27170_27194(TNamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 27170, 27194);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 27058, 27229);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 27058, 27229);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IUnitReference Cci.INamespaceTypeReference.GetUnit(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 27245, 27404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 27353, 27389);

                    return TypeManager.ModuleBeingBuilt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 27245, 27404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 27245, 27404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 27245, 27404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamespaceTypeReference.NamespaceName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 27501, 27605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 27545, 27586);

                        return f_776_27552_27585(UnderlyingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(776, 27501, 27605);

                        string
                        f_776_27552_27585(TNamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.NamespaceName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 27552, 27585);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 27420, 27620);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 27420, 27620);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            /// <remarks>
            /// This is only used for testing.
            /// </remarks>
            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 27739, 27939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 27805, 27924);

                    return f_776_27812_27923(f_776_27812_27864(f_776_27812_27851(UnderlyingNamedType)), SymbolDisplayFormat.ILVisualizationFormat);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 27739, 27939);

                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_776_27812_27851(TNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetInternalSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 27812, 27851);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_776_27812_27864(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    this_param)
                    {
                        var return_v = this_param.GetISymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 27812, 27864);
                        return return_v;
                    }


                    string
                    f_776_27812_27923(Microsoft.CodeAnalysis.ISymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(776, 27812, 27923);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 27739, 27939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 27739, 27939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public sealed override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 27955, 28250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 28181, 28235);

                    throw f_776_28187_28234();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 27955, 28250);

                    System.Exception
                    f_776_28187_28234()
                    {
                        var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 28187, 28234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 27955, 28250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 27955, 28250);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public sealed override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(776, 28266, 28555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(776, 28486, 28540);

                    throw f_776_28492_28539();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(776, 28266, 28555);

                    System.Exception
                    f_776_28492_28539()
                    {
                        var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(776, 28492, 28539);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(776, 28266, 28555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 28266, 28555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CommonEmbeddedType()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(776, 1151, 28566);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(776, 1151, 28566);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(776, 1151, 28566);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(776, 1151, 28566);
        }
    }
}
