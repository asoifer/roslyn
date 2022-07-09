// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

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
        internal abstract class CommonEmbeddedMember
        {
            internal abstract TEmbeddedTypesManager TypeManager { get; }

            public CommonEmbeddedMember()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(772, 1050, 1190);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(772, 1050, 1190);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 1050, 1190);
            }


            static CommonEmbeddedMember()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(772, 1050, 1190);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(772, 1050, 1190);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 1050, 1190);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(772, 1050, 1190);
        }
        internal abstract class CommonEmbeddedMember<TMember> : CommonEmbeddedMember, Cci.IReference
                    where TMember : TSymbol, Cci.ITypeMemberReference
        {
            protected readonly TMember UnderlyingSymbol;

            private ImmutableArray<TAttributeData> _lazyAttributes;

            protected CommonEmbeddedMember(TMember underlyingSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(772, 1511, 1656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 1409, 1425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 1600, 1641);

                    this.UnderlyingSymbol = underlyingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(772, 1511, 1656);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 1511, 1656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 1511, 1656);
                }
            }

            protected abstract IEnumerable<TAttributeData> GetCustomAttributesToEmit(TPEModuleBuilder moduleBuilder);

            protected virtual TAttributeData PortAttributeIfNeedTo(TAttributeData attrData, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 1793, 1986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 1959, 1971);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 1793, 1986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 1793, 1986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 1793, 1986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<TAttributeData> GetAttributes(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 2002, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 2173, 2230);

                    var
                    builder = f_772_2187_2229()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 2576, 3357);
                        foreach (var attrData in f_772_2601_2641_I(f_772_2601_2641(this, moduleBuilder)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 2576, 3357);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 2683, 3338) || true) && (f_772_2687_2782(f_772_2687_2698(), UnderlyingSymbol, attrData, AttributeDescription.DispIdAttribute))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 2683, 3338);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 2832, 3136) || true) && (attrData.CommonConstructorArguments.Length == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 2832, 3136);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 2941, 3109);

                                    f_772_2941_3108(builder, f_772_2961_3107(f_772_2961_2972(), WellKnownMember.System_Runtime_InteropServices_DispIdAttribute__ctor, attrData, syntaxNodeOpt, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(772, 2832, 3136);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(772, 2683, 3338);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 2683, 3338);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3234, 3315);

                                f_772_3234_3314(builder, f_772_3254_3313(this, attrData, syntaxNodeOpt, diagnostics));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(772, 2683, 3338);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(772, 2576, 3357);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(772, 1, 782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(772, 1, 782);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3377, 3413);

                    return f_772_3384_3412(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 2002, 3428);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    f_772_2187_2229()
                    {
                        var return_v = ArrayBuilder<TAttributeData>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2187, 2229);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<TAttributeData>
                    f_772_2601_2641(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMember<TMember>
                    this_param, TPEModuleBuilder
                    moduleBuilder)
                    {
                        var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2601, 2641);
                        return return_v;
                    }


                    TEmbeddedTypesManager
                    f_772_2687_2698()
                    {
                        var return_v = TypeManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 2687, 2698);
                        return return_v;
                    }


                    bool
                    f_772_2687_2782(TEmbeddedTypesManager
                    this_param, TMember
                    underlyingSymbol, TAttributeData
                    attrData, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.IsTargetAttribute((TSymbol)underlyingSymbol, attrData, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2687, 2782);
                        return return_v;
                    }


                    TEmbeddedTypesManager
                    f_772_2961_2972()
                    {
                        var return_v = TypeManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 2961, 2972);
                        return return_v;
                    }


                    TAttributeData
                    f_772_2961_3107(TEmbeddedTypesManager
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateSynthesizedAttribute(constructor, attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2961, 3107);
                        return return_v;
                    }


                    int
                    f_772_2941_3108(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2941, 3108);
                        return 0;
                    }


                    TAttributeData
                    f_772_3254_3313(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMember<TMember>
                    this_param, TAttributeData
                    attrData, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.PortAttributeIfNeedTo(attrData, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3254, 3313);
                        return return_v;
                    }


                    int
                    f_772_3234_3314(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    builder, TAttributeData
                    item)
                    {
                        builder.AddOptional<TAttributeData>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3234, 3314);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<TAttributeData>
                    f_772_2601_2641_I(System.Collections.Generic.IEnumerable<TAttributeData>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 2601, 2641);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TAttributeData>
                    f_772_3384_3412(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<TAttributeData>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3384, 3412);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 2002, 3428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 2002, 3428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 3444, 4221);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3560, 4163) || true) && (_lazyAttributes.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 3560, 4163);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3631, 3677);

                        var
                        diagnostics = f_772_3649_3676()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3699, 3813);

                        var
                        attributes = f_772_3716_3812(this, context.Module, context.SyntaxNodeOpt, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 3837, 4101) || true) && (f_772_3841_3916(ref _lazyAttributes, attributes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(772, 3837, 4101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4036, 4078);

                            f_772_4036_4077(                        // Save any diagnostics that we encountered.
                                                    context.Diagnostics, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(772, 3837, 4101);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4125, 4144);

                        f_772_4125_4143(
                                            diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(772, 3560, 4163);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4183, 4206);

                    return _lazyAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 3444, 4221);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_772_3649_3676()
                    {
                        var return_v = DiagnosticBag.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3649, 3676);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TAttributeData>
                    f_772_3716_3812(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedMember<TMember>
                    this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                    moduleBuilder, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetAttributes((TPEModuleBuilder)moduleBuilder, (TSyntaxNode)syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3716, 3812);
                        return return_v;
                    }


                    bool
                    f_772_3841_3916(ref System.Collections.Immutable.ImmutableArray<TAttributeData>
                    location, System.Collections.Immutable.ImmutableArray<TAttributeData>
                    value)
                    {
                        var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 3841, 3916);
                        return return_v;
                    }


                    int
                    f_772_4036_4077(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.DiagnosticBag
                    bag)
                    {
                        this_param.AddRange(bag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 4036, 4077);
                        return 0;
                    }


                    int
                    f_772_4125_4143(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(772, 4125, 4143);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 3444, 4221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 3444, 4221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 4237, 4379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4327, 4364);

                    throw f_772_4333_4363();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 4237, 4379);

                    System.Exception
                    f_772_4333_4363()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4333, 4363);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 4237, 4379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 4237, 4379);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 4395, 4544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4492, 4529);

                    throw f_772_4498_4528();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 4395, 4544);

                    System.Exception
                    f_772_4498_4528()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4498, 4528);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 4395, 4544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 4395, 4544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 4619, 4626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4622, 4626);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(772, 4619, 4626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 4619, 4626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 4619, 4626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public sealed override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 4643, 4938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 4869, 4923);

                    throw f_772_4875_4922();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 4643, 4938);

                    System.Exception
                    f_772_4875_4922()
                    {
                        var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 4875, 4922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 4643, 4938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 4643, 4938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public sealed override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(772, 4954, 5243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(772, 5174, 5228);

                    throw f_772_5180_5227();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(772, 4954, 5243);

                    System.Exception
                    f_772_5180_5227()
                    {
                        var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(772, 5180, 5227);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(772, 4954, 5243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(772, 4954, 5243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
