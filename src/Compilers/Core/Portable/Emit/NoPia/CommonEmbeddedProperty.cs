// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
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
        internal abstract class CommonEmbeddedProperty : CommonEmbeddedMember<TPropertySymbol>, Cci.IPropertyDefinition
        {
            private readonly ImmutableArray<TEmbeddedParameter> _parameters;

            private readonly TEmbeddedMethod _getter;

            private readonly TEmbeddedMethod _setter;

            protected CommonEmbeddedProperty(TPropertySymbol underlyingProperty, TEmbeddedMethod getter, TEmbeddedMethod setter) : base(f_775_1541_1559_C<TPropertySymbol>(underlyingProperty))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(775, 1400, 1775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1321, 1328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1376, 1383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1593, 1640);

                    f_775_1593_1639(getter != null || (DynAbs.Tracing.TraceSender.Expression_False(775, 1606, 1638) || setter != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1660, 1677);

                    _getter = getter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1695, 1712);

                    _setter = setter;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1730, 1760);

                    _parameters = f_775_1744_1759(this);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(775, 1400, 1775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 1400, 1775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 1400, 1775);
                }
            }

            internal override TEmbeddedTypesManager TypeManager
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 1875, 1968);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 1919, 1949);

                        return f_775_1926_1948(f_775_1926_1936());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 1875, 1968);

                        TEmbeddedMethod
                        f_775_1926_1936()
                        {
                            var return_v = AnAccessor;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 1926, 1936);
                            return return_v;
                        }


                        TEmbeddedTypesManager
                        f_775_1926_1948(TEmbeddedMethod
                        this_param)
                        {
                            var return_v = this_param.TypeManager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 1926, 1948);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 1791, 1983);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 1791, 1983);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            protected abstract ImmutableArray<TEmbeddedParameter> GetParameters();

            protected abstract bool IsRuntimeSpecial { get; }

            protected abstract bool IsSpecialName { get; }

            protected abstract Cci.ISignature UnderlyingPropertySignature { get; }

            protected abstract TEmbeddedType ContainingType { get; }

            protected abstract Cci.TypeMemberVisibility Visibility { get; }

            protected abstract string Name { get; }

            public TPropertySymbol UnderlyingProperty
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 2566, 2658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 2610, 2639);

                        return this.UnderlyingSymbol;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 2566, 2658);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 2492, 2673);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 2492, 2673);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMethodReference Cci.IPropertyDefinition.Getter
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 2773, 2796);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 2779, 2794);

                        return _getter;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 2773, 2796);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 2689, 2811);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 2689, 2811);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.IMethodReference Cci.IPropertyDefinition.Setter
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 2911, 2934);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 2917, 2932);

                        return _setter;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 2911, 2934);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 2827, 2949);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 2827, 2949);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            IEnumerable<Cci.IMethodReference> Cci.IPropertyDefinition.GetAccessors(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 2965, 3326);

                    var listYield = new List<Cci.IMethodReference>();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3089, 3190) || true) && (_getter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(775, 3089, 3190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3150, 3171);

                        listYield.Add(_getter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(775, 3089, 3190);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3210, 3311) || true) && (_setter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(775, 3210, 3311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3271, 3292);

                        listYield.Add(_setter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(775, 3210, 3311);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(775, 2965, 3326);

                    return listYield;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 2965, 3326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 2965, 3326);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            bool Cci.IPropertyDefinition.HasDefaultValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 3419, 3440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3425, 3438);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 3419, 3440);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 3342, 3455);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 3342, 3455);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            MetadataConstant Cci.IPropertyDefinition.DefaultValue
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 3557, 3577);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3563, 3575);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 3557, 3577);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 3471, 3592);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 3471, 3592);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IPropertyDefinition.IsRuntimeSpecial
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 3686, 3718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3692, 3716);

                        return f_775_3699_3715();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 3686, 3718);

                        bool
                        f_775_3699_3715()
                        {
                            var return_v = IsRuntimeSpecial;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 3699, 3715);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 3608, 3733);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 3608, 3733);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.IPropertyDefinition.IsSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 3824, 3908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 3868, 3889);

                        return f_775_3875_3888();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 3824, 3908);

                        bool
                        f_775_3875_3888()
                        {
                            var return_v = IsSpecialName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 3875, 3888);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 3749, 3923);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 3749, 3923);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<Cci.IParameterDefinition> Cci.IPropertyDefinition.Parameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 4047, 4117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 4053, 4115);

                        return f_775_4060_4114(_parameters);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 4047, 4117);

                        System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterDefinition>
                        f_775_4060_4114(System.Collections.Immutable.ImmutableArray<TEmbeddedParameter>
                        from)
                        {
                            var return_v = StaticCast<Cci.IParameterDefinition>.From(from);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 4060, 4114);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 3939, 4132);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 3939, 4132);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.CallingConvention Cci.ISignature.CallingConvention
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 4235, 4351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 4279, 4332);

                        return f_775_4286_4331(f_775_4286_4313());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 4235, 4351);

                        Microsoft.Cci.ISignature
                        f_775_4286_4313()
                        {
                            var return_v = UnderlyingPropertySignature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 4286, 4313);
                            return return_v;
                        }


                        Microsoft.Cci.CallingConvention
                        f_775_4286_4331(Microsoft.Cci.ISignature
                        this_param)
                        {
                            var return_v = this_param.CallingConvention;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 4286, 4331);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 4148, 4366);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 4148, 4366);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ushort Cci.ISignature.ParameterCount
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 4451, 4493);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 4457, 4491);

                        return (ushort)_parameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 4451, 4493);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 4382, 4508);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 4382, 4508);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<Cci.IParameterTypeInformation> Cci.ISignature.GetParameters(EmitContext context)
		{
			try
            {
DynAbs.Tracing.TraceSender.TraceEnterMethod(775,4524,4734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(775,4652,4719);

return f_775_4659_4718(_parameters);
DynAbs.Tracing.TraceSender.TraceExitMethod(775,4524,4734);

System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
f_775_4659_4718(System.Collections.Immutable.ImmutableArray<TEmbeddedParameter>
from)
{
var return_v = StaticCast<Cci.IParameterTypeInformation>.From( from);
DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 4659, 4718);
return return_v;
}

            }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775,4524,4734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775,4524,4734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

            ImmutableArray<Cci.ICustomModifier> Cci.ISignature.ReturnValueCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 4860, 4985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 4904, 4966);

                        return f_775_4911_4965(f_775_4911_4938());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 4860, 4985);

                        Microsoft.Cci.ISignature
                        f_775_4911_4938()
                        {
                            var return_v = UnderlyingPropertySignature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 4911, 4938);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                        f_775_4911_4965(Microsoft.Cci.ISignature
                        this_param)
                        {
                            var return_v = this_param.ReturnValueCustomModifiers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 4911, 4965);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 4750, 5000);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 4750, 5000);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            ImmutableArray<Cci.ICustomModifier> Cci.ISignature.RefCustomModifiers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 5118, 5235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 5162, 5216);

                        return f_775_5169_5215(f_775_5169_5196());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 5118, 5235);

                        Microsoft.Cci.ISignature
                        f_775_5169_5196()
                        {
                            var return_v = UnderlyingPropertySignature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5169, 5196);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                        f_775_5169_5215(Microsoft.Cci.ISignature
                        this_param)
                        {
                            var return_v = this_param.RefCustomModifiers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5169, 5215);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 5016, 5250);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 5016, 5250);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            bool Cci.ISignature.ReturnValueIsByRef
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 5337, 5454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 5381, 5435);

                        return f_775_5388_5434(f_775_5388_5415());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 5337, 5454);

                        Microsoft.Cci.ISignature
                        f_775_5388_5415()
                        {
                            var return_v = UnderlyingPropertySignature;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5388, 5415);
                            return return_v;
                        }


                        bool
                        f_775_5388_5434(Microsoft.Cci.ISignature
                        this_param)
                        {
                            var return_v = this_param.ReturnValueIsByRef;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5388, 5434);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 5266, 5469);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 5266, 5469);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ISignature.GetType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 5485, 5647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 5580, 5632);

                    return f_775_5587_5631(f_775_5587_5614(), context);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(775, 5485, 5647);

                    Microsoft.Cci.ISignature
                    f_775_5587_5614()
                    {
                        var return_v = UnderlyingPropertySignature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5587, 5614);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeReference
                    f_775_5587_5631(Microsoft.Cci.ISignature
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetType(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 5587, 5631);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 5485, 5647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 5485, 5647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected TEmbeddedMethod AnAccessor
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 5732, 5821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 5776, 5802);

                        return _getter ?? (DynAbs.Tracing.TraceSender.Expression_Null<TEmbeddedMethod>(775, 5783, 5801) ?? _setter);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 5732, 5821);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 5663, 5836);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 5663, 5836);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 5955, 5985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 5961, 5983);

                        return f_775_5968_5982();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 5955, 5985);

                        TEmbeddedType
                        f_775_5968_5982()
                        {
                            var return_v = ContainingType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 5968, 5982);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 5852, 6000);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 5852, 6000);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 6110, 6191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 6154, 6172);

                        return f_775_6161_6171();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 6110, 6191);

                        Microsoft.Cci.TypeMemberVisibility
                        f_775_6161_6171()
                        {
                            var return_v = Visibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 6161, 6171);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 6016, 6206);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 6016, 6206);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Cci.ITypeReference Cci.ITypeMemberReference.GetContainingType(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 6222, 6374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 6337, 6359);

                    return f_775_6344_6358();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(775, 6222, 6374);

                    TEmbeddedType
                    f_775_6344_6358()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 6344, 6358);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 6222, 6374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 6222, 6374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 6390, 6540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 6480, 6525);

                    f_775_6480_6524(visitor, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(775, 6390, 6540);

                    int
                    f_775_6480_6524(Microsoft.Cci.MetadataVisitor
                    this_param, Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedProperty
                    propertyDefinition)
                    {
                        this_param.Visit((Microsoft.Cci.IPropertyDefinition)propertyDefinition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 6480, 6524);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 6390, 6540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 6390, 6540);
                }
            }

            Cci.IDefinition Cci.IReference.AsDefinition(EmitContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 6556, 6680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 6653, 6665);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(775, 6556, 6680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 6556, 6680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 6556, 6680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            string Cci.INamedEntity.Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(775, 6757, 6832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(775, 6801, 6813);

                        return f_775_6808_6812();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(775, 6757, 6832);

                        string
                        f_775_6808_6812()
                        {
                            var return_v = Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(775, 6808, 6812);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(775, 6696, 6847);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 6696, 6847);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static CommonEmbeddedProperty()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(775, 1074, 6858);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(775, 1074, 6858);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(775, 1074, 6858);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(775, 1074, 6858);

            static int
            f_775_1593_1639(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 1593, 1639);
                return 0;
            }


            static System.Collections.Immutable.ImmutableArray<TEmbeddedParameter>
            f_775_1744_1759(Microsoft.CodeAnalysis.Emit.NoPia.EmbeddedTypesManager<TPEModuleBuilder, TModuleCompilationState, TEmbeddedTypesManager, TSyntaxNode, TAttributeData, TSymbol, TAssemblySymbol, TNamedTypeSymbol, TFieldSymbol, TMethodSymbol, TEventSymbol, TPropertySymbol, TParameterSymbol, TTypeParameterSymbol, TEmbeddedType, TEmbeddedField, TEmbeddedMethod, TEmbeddedEvent, TEmbeddedProperty, TEmbeddedParameter, TEmbeddedTypeParameter>.CommonEmbeddedProperty
            this_param)
            {
                var return_v = this_param.GetParameters();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(775, 1744, 1759);
                return return_v;
            }


            static TPropertySymbol
            f_775_1541_1559_C<TPropertySymbol>(TPropertySymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(775, 1400, 1775);
                return return_v;
            }

        }
    }
}
