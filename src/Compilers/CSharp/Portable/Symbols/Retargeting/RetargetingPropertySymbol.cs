// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingPropertySymbol : WrappedPropertySymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private ImmutableArray<PropertySymbol> _lazyExplicitInterfaceImplementations;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        private TypeWithAnnotations.Boxed _lazyType;

        public RetargetingPropertySymbol(RetargetingModuleSymbol retargetingModule, PropertySymbol underlyingProperty)
        : base(f_10602_1575_1593_C(underlyingProperty))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10602, 1444, 1812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 747, 765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1290, 1346);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1422, 1431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1619, 1667);

                f_10602_1619_1666((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1681, 1746);

                f_10602_1681_1745(!(underlyingProperty is RetargetingPropertySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1762, 1801);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10602, 1444, 1812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 1444, 1812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 1444, 1812);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 1930, 2029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 1966, 2014);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 1930, 2029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 1824, 2040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 1824, 2040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RetargetingModuleSymbol RetargetingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 2125, 2202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2161, 2187);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 2125, 2202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 2052, 2213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 2052, 2213);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 2305, 2945);
                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol? asDynamic = default(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2341, 2889) || true) && (_lazyType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 2341, 2889);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2404, 2542);

                        var
                        type = f_10602_2415_2541(f_10602_2415_2441(this), f_10602_2451_2490(_underlyingProperty), RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2564, 2762) || true) && (f_10602_2568_2644(type.Type, f_10602_2598_2617(this), out asDynamic))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 2564, 2762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2694, 2739);

                            type = TypeWithAnnotations.Create(asDynamic);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 2564, 2762);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2784, 2870);

                        f_10602_2784_2869(ref _lazyType, f_10602_2827_2862(type), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 2341, 2889);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 2907, 2930);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 2305, 2945);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10602_2415_2441(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 2415, 2441);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10602_2451_2490(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 2451, 2490);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10602_2415_2541(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 2415, 2541);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10602_2598_2617(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 2598, 2617);
                        return return_v;
                    }


                    bool
                    f_10602_2568_2644(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    containingType, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    result)
                    {
                        var return_v = type.TryAsDynamicIfNoPia(containingType, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 2568, 2644);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10602_2827_2862(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 2827, 2862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10602_2784_2869(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 2784, 2869);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 2225, 2956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 2225, 2956);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 3058, 3225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3094, 3210);

                    return f_10602_3101_3209(f_10602_3101_3122(), f_10602_3141_3179(_underlyingProperty), ref _lazyRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 3058, 3225);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10602_3101_3122()
                    {
                        var return_v = RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 3101, 3122);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10602_3141_3179(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 3141, 3179);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10602_3101_3209(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    lazyCustomModifiers)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, ref lazyCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 3101, 3209);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 2968, 3236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 2968, 3236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 3331, 3653);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3367, 3595) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 3367, 3595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3438, 3576);

                        f_10602_3438_3575(ref _lazyParameters, f_10602_3507_3532(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 3367, 3595);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3615, 3638);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 3331, 3653);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10602_3507_3532(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 3507, 3532);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10602_3438_3575(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 3438, 3575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 3248, 3664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 3248, 3664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> RetargetParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 3676, 4339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3761, 3803);

                var
                list = f_10602_3772_3802(_underlyingProperty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3817, 3841);

                int
                count = list.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3857, 4328) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 3857, 4328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 3905, 3950);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 3857, 4328);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 3857, 4328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4016, 4074);

                    ParameterSymbol[]
                    parameters = new ParameterSymbol[count]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4103, 4108);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4094, 4255) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4121, 4124)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 4094, 4255))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 4094, 4255);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4166, 4236);

                            parameters[i] = f_10602_4182_4235(this, list[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10602, 1, 162);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10602, 1, 162);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4275, 4313);

                    return f_10602_4282_4312(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 3857, 4328);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 3676, 4339);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10602_3772_3802(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 3772, 3802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertyParameterSymbol
                f_10602_4182_4235(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                retargetingProperty, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlyingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertyParameterSymbol(retargetingProperty, underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 4182, 4235);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10602_4282_4312(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 4282, 4312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 3676, 4339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 3676, 4339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MethodSymbol GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 4414, 4636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4450, 4621);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10602, 4457, 4502) || (((object)f_10602_4465_4494(_underlyingProperty) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10602, 4526, 4530)) || DynAbs.Tracing.TraceSender.Conditional_F3(10602, 4554, 4620))) ? null
                    : f_10602_4554_4620(f_10602_4554_4580(this), f_10602_4590_4619(_underlyingProperty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 4414, 4636);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4465_4494(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4465, 4494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10602_4554_4580(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4554, 4580);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4590_4619(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4590, 4619);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4554_4620(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 4554, 4620);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 4351, 4647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 4351, 4647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol SetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 4722, 4944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 4758, 4929);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10602, 4765, 4810) || (((object)f_10602_4773_4802(_underlyingProperty) == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10602, 4834, 4838)) || DynAbs.Tracing.TraceSender.Conditional_F3(10602, 4862, 4928))) ? null
                    : f_10602_4862_4928(f_10602_4862_4888(this), f_10602_4898_4927(_underlyingProperty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 4722, 4944);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4773_4802(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4773, 4802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10602_4862_4888(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4862, 4888);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4898_4927(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 4898, 4927);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10602_4862_4928(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 4862, 4928);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 4659, 4955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 4659, 4955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 5048, 5160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5084, 5145);

                    return f_10602_5091_5144(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 5048, 5160);

                    bool
                    f_10602_5091_5144(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 5091, 5144);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 4967, 5171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 4967, 5171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 5287, 5770);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5323, 5692) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 5323, 5692);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5416, 5673);

                        f_10602_5416_5672(ref _lazyExplicitInterfaceImplementations, f_10602_5558_5605(this), default(ImmutableArray<PropertySymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 5323, 5692);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5710, 5755);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 5287, 5770);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10602_5558_5605(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetExplicitInterfaceImplementations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 5558, 5605);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10602_5416_5672(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 5416, 5672);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 5183, 5781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 5183, 5781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<PropertySymbol> RetargetExplicitInterfaceImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 5793, 6727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5899, 5964);

                var
                impls = f_10602_5911_5963(_underlyingProperty)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 5980, 6108) || true) && (impls.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 5980, 6108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6031, 6062);

                    f_10602_6031_6061(f_10602_6044_6060_M(!impls.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6080, 6093);

                    return impls;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 5980, 6108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6243, 6300);

                var
                builder = f_10602_6257_6299()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6325, 6330);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6316, 6664) || true) && (i < impls.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6350, 6353)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 6316, 6664))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 6316, 6664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6387, 6516);

                        var
                        retargeted = f_10602_6404_6515(f_10602_6404_6430(this), impls[i], MemberSignatureComparer.RetargetedExplicitImplementationComparer)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6534, 6649) || true) && ((object)retargeted != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 6534, 6649);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6606, 6630);

                            f_10602_6606_6629(builder, retargeted);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 6534, 6649);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10602, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10602, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6680, 6716);

                return f_10602_6687_6715(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 5793, 6727);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10602_5911_5963(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 5911, 5963);
                    return return_v;
                }


                bool
                f_10602_6044_6060_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 6044, 6060);
                    return return_v;
                }


                int
                f_10602_6031_6061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6031, 6061);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10602_6257_6299()
                {
                    var return_v = ArrayBuilder<PropertySymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6257, 6299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10602_6404_6430(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 6404, 6430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10602_6404_6515(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                retargetedPropertyComparer)
                {
                    var return_v = this_param.Retarget(property, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>)retargetedPropertyComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6404, 6515);
                    return return_v;
                }


                int
                f_10602_6606_6629(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6606, 6629);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10602_6687_6715(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6687, 6715);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 5793, 6727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 5793, 6727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 6803, 6935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 6839, 6920);

                    return f_10602_6846_6919(f_10602_6846_6872(this), f_10602_6882_6918(_underlyingProperty));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 6803, 6935);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10602_6846_6872(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 6846, 6872);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10602_6882_6918(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 6882, 6918);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10602_6846_6919(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 6846, 6919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 6739, 6946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 6739, 6946);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 7032, 7128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 7068, 7113);

                    return f_10602_7075_7112(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 7032, 7128);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10602_7075_7112(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 7075, 7112);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 6958, 7139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 6958, 7139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 7223, 7300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 7259, 7285);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 7223, 7300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 7151, 7311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 7151, 7311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 7323, 7548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 7415, 7537);

                return f_10602_7422_7536(f_10602_7422_7448(this), f_10602_7473_7508(_underlyingProperty), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 7323, 7548);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10602_7422_7448(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 7422, 7448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10602_7473_7508(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 7473, 7508);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10602_7422_7536(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 7422, 7536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 7323, 7548);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 7323, 7548);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 7560, 7818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 7692, 7807);

                return f_10602_7699_7806(f_10602_7699_7725(this), f_10602_7745_7805(_underlyingProperty, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 7560, 7818);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10602_7699_7725(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 7699, 7725);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10602_7745_7805(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 7745, 7805);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10602_7699_7806(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 7699, 7806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 7560, 7818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 7560, 7818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool MustCallMethodsDirectly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 7901, 8003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 7937, 7988);

                    return f_10602_7944_7987(_underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 7901, 8003);

                    bool
                    f_10602_7944_7987(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MustCallMethodsDirectly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10602, 7944, 7987);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 7830, 8014);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 7830, 8014);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 8026, 8424);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8106, 8367) || true) && (f_10602_8110_8182(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10602, 8106, 8367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8216, 8245);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8263, 8302);

                    f_10602_8263_8301(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8320, 8352);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10602, 8106, 8367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8383, 8413);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 8026, 8424);

                bool
                f_10602_8110_8182(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 8110, 8182);
                    return return_v;
                }


                bool
                f_10602_8263_8301(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 8263, 8301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 8026, 8424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 8026, 8424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10602, 8549, 8569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10602, 8555, 8567);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10602, 8549, 8569);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10602, 8436, 8580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 8436, 8580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10602, 526, 8587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10602, 526, 8587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10602, 526, 8587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10602, 526, 8587);

        int
        f_10602_1619_1666(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 1619, 1666);
            return 0;
        }


        int
        f_10602_1681_1745(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10602, 1681, 1745);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        f_10602_1575_1593_C(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10602, 1444, 1812);
            return return_v;
        }

    }
}
