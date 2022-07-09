// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cci = Microsoft.Cci;

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
        internal abstract class CommonEmbeddedEvent : CommonEmbeddedMember<TEventSymbol>, Cci.IEventDefinition
        {
            private readonly TEmbeddedMethod _adder;

            private readonly TEmbeddedMethod _remover;

            private readonly TEmbeddedMethod _caller;

            private int _isUsedForComAwareEventBinding;

            protected CommonEmbeddedEvent(TEventSymbol underlyingEvent, TEmbeddedMethod adder, TEmbeddedMethod remover, TEmbeddedMethod caller) : base(f_770_1532_1547_C<TEventSymbol>(underlyingEvent))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(770, 1376, 1750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1183, 1189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1237, 1245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1293, 1300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1329, 1359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1581, 1628);

                    f_770_1581_1627(adder != null || (DynAbs.Tracing.TraceSender.Expression_False(770, 1594, 1626) || remover != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1648, 1663);

                    _adder = adder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1681, 1700);

                    _remover = remover;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1718, 1735);

                    _caller = caller;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(770, 1376, 1750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 1376, 1750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 1376, 1750);
                }
            }

            internal override TEmbeddedTypesManager TypeManager
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 1850, 1943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 1894, 1924);

                        return f_770_1901_1923(f_770_1901_1911());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 1850, 1943);

                        TEmbeddedMethod
                        f_770_1901_1911()
                        {
                            var return_v = AnAccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 1901, 1911);
                            return return_v;
                        }


                        TEmbeddedTypesManager
                        f_770_1901_1923(TEmbeddedMethod
                        this_param)
                        {
                            var return_v = this_param.TypeManager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 1901, 1923);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 1766, 1958);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 1766, 1958);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract bool IsRuntimeSpecial { get; }

            protected abstract bool IsSpecialName { get; }

            protected abstract Cci.ITypeReference GetType(TPEModuleBuilder moduleBuilder, TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics);

            protected abstract TEmbeddedType ContainingType { get; }

            protected abstract Cci.TypeMemberVisibility Visibility { get; }

            protected abstract string Name { get; }

            public TEventSymbol UnderlyingEvent
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 2513, 2605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 2557, 2586);

                        return this.UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 2513, 2605);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 2445, 2620);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 2445, 2620);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract void EmbedCorrespondingComEventInterfaceMethodInternal(TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding);

            internal void EmbedCorrespondingComEventInterfaceMethod(TSyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics, bool isUsedForComAwareEventBinding)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 2816, 3587);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 2994, 3468) || true) && (_isUsedForComAwareEventBinding == 0 && (DynAbs.Tracing.TraceSender.Expression_True(770, 2998, 3190) && (!isUsedForComAwareEventBinding || (DynAbs.Tracing.TraceSender.Expression_False(770, 3059, 3189) || f_770_3115_3184(ref _isUsedForComAwareEventBinding, 1, 0) == 0))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(770, 2994, 3468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3232, 3316);

                        f_770_3232_3315(!isUsedForComAwareEventBinding || (DynAbs.Tracing.TraceSender.Expression_False(770, 3245, 3314) || _isUsedForComAwareEventBinding != 0));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3340, 3449);

                        f_770_3340_3448(this, syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(770, 2994, 3468);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3488, 3572);

                    f_770_3488_3571(!isUsedForComAwareEventBinding || (DynAbs.Tracing.TraceSender.Expression_False(770, 3501, 3570) || _isUsedForComAwareEventBinding != 0));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 2816, 3587);

                    int
                    f_770_3115_3184(ref int
                    location1, int
                    value, int
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 3115, 3184);
                        return return_v;
                    }


                    int
                    f_770_3232_3315(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 3232, 3315);
                        return 0;
                    }


                    int
                    f_770_3340_3448(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedEvent
                    this_param, TSyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, bool
                    isUsedForComAwareEventBinding)
                    {
                        this_param.EmbedCorrespondingComEventInterfaceMethodInternal(syntaxNodeOpt, diagnostics, isUsedForComAwareEventBinding);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 3340, 3448);
                        return 0;
                    }


                    int
                    f_770_3488_3571(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 3488, 3571);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 2816, 3587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 2816, 3587);
                }
            }

            Cci.IMethodReference Cci.IEventDefinition.Adder
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 3683, 3705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3689, 3703);

                        return _adder;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 3683, 3705);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 3603, 3720);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 3603, 3720);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMethodReference Cci.IEventDefinition.Remover
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 3818, 3842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3824, 3840);

                        return _remover;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 3818, 3842);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 3736, 3857);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 3736, 3857);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMethodReference Cci.IEventDefinition.Caller
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 3954, 3977);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 3960, 3975);

                        return _caller;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 3954, 3977);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 3873, 3992);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 3873, 3992);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.IMethodReference> Cci.IEventDefinition.GetAccessors(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 4008, 4487);

                    var listYield = new List<Cci.IMethodReference>();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4129, 4228) || true) && (_adder != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(770, 4129, 4228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4189, 4209);

                        listYield.Add(_adder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(770, 4129, 4228);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4248, 4351) || true) && (_remover != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(770, 4248, 4351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4310, 4332);

                        listYield.Add(_remover);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(770, 4248, 4351);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4371, 4472) || true) && (_caller != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(770, 4371, 4472);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4432, 4453);

                        listYield.Add(_caller);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(770, 4371, 4472);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 4008, 4487);

                    return listYield;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 4008, 4487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 4008, 4487);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool Cci.IEventDefinition.IsRuntimeSpecial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 4578, 4665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4622, 4646);

                        return f_770_4629_4645();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 4578, 4665);

                        bool
                        f_770_4629_4645()
                        {
                            var return_v = IsRuntimeSpecial;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 4629, 4645);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 4503, 4680);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 4503, 4680);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IEventDefinition.IsSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 4768, 4852);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4812, 4833);

                        return f_770_4819_4832();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 4768, 4852);

                        bool
                        f_770_4819_4832()
                        {
                            var return_v = IsSpecialName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 4819, 4832);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 4696, 4867);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 4696, 4867);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.IEventDefinition.GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 4883, 5105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 4984, 5090);

                    return f_770_4991_5089(this, context.Module, context.SyntaxNodeOpt, context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 4883, 5105);

                    Microsoft.Cci.ITypeReference
                    f_770_4991_5089(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedEvent
                    this_param, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                    moduleBuilder, Microsoft.CodeAnalysis.SyntaxNode
                    syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetType((TPEModuleBuilder)moduleBuilder, (TSyntaxNode)syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 4991, 5089);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 4883, 5105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 4883, 5105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected TEmbeddedMethod AnAccessor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 5190, 5279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 5234, 5260);

                        return _adder ?? (DynAbs.Tracing.TraceSender.Expression_Null<TEmbeddedMethod>(770, 5241, 5259) ?? _remover);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 5190, 5279);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 5121, 5294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 5121, 5294);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeDefinition Cci.ITypeDefinitionMember.ContainingTypeDefinition
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 5413, 5443);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 5419, 5441);

                        return f_770_5426_5440();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 5413, 5443);

                        TEmbeddedType
                        f_770_5426_5440()
                        {
                            var return_v = ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 5426, 5440);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 5310, 5458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 5310, 5458);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.TypeMemberVisibility Cci.ITypeDefinitionMember.Visibility
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 5568, 5649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 5612, 5630);

                        return f_770_5619_5629();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 5568, 5649);

                        Microsoft.Cci.TypeMemberVisibility
                        f_770_5619_5629()
                        {
                            var return_v = Visibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 5619, 5629);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 5474, 5664);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 5474, 5664);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 5680, 5832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 5795, 5817);

                    return f_770_5802_5816();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 5680, 5832);

                    TEmbeddedType
                    f_770_5802_5816()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 5802, 5816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 5680, 5832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 5680, 5832);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 5848, 5995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 5938, 5980);

                    f_770_5938_5979(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 5848, 5995);

                    int
                    f_770_5938_5979(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedEvent
                    eventDefinition)
                    {
                        this_param.Visit((Microsoft.Cci.IEventDefinition)eventDefinition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 5938, 5979);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 5848, 5995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 5848, 5995);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 6011, 6135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 6108, 6120);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(770, 6011, 6135);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 6011, 6135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 6011, 6135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(770, 6212, 6287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(770, 6256, 6268);

                        return f_770_6263_6267();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(770, 6212, 6287);

                        string
                        f_770_6263_6267()
                        {
                            var return_v = Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(770, 6263, 6267);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(770, 6151, 6302);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 6151, 6302);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static CommonEmbeddedEvent()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(770, 1023, 6313);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(770, 1023, 6313);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 1023, 6313);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(770, 1023, 6313);

            static int
            f_770_1581_1627(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(770, 1581, 1627);
                return 0;
            }


            static TEventSymbol
            f_770_1532_1547_C<TEventSymbol>(TEventSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(770, 1376, 1750);
                return return_v;
            }

        }

        static EmbeddedTypesManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(770, 398, 6320);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(770, 398, 6320);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(770, 398, 6320);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(770, 398, 6320);
    }
}
