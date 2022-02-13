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
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingMethodSymbol : WrappedMethodSymbol
    {
        private readonly RetargetingModuleSymbol _retargetingModule;

        private readonly MethodSymbol _underlyingMethod;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private ImmutableArray<CustomModifier> _lazyRefCustomModifiers;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        private ImmutableArray<CSharpAttributeData> _lazyReturnTypeCustomAttributes;

        private ImmutableArray<MethodSymbol> _lazyExplicitInterfaceImplementations;

        private DiagnosticInfo _lazyUseSiteDiagnostic;

        private TypeWithAnnotations.Boxed _lazyReturnType;

        private UnmanagedCallersOnlyAttributeData _lazyUnmanagedAttributeData;

        public RetargetingMethodSymbol(RetargetingModuleSymbol retargetingModule, MethodSymbol underlyingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10597, 2278, 2708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 1123, 1141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 1273, 1290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 1986, 2042);
                this._lazyUseSiteDiagnostic = CSDiagnosticInfo.EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2118, 2133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2188, 2265);
                this._lazyUnmanagedAttributeData = UnmanagedCallersOnlyAttributeData.Uninitialized; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2407, 2455);

                f_10597_2407_2454((object)retargetingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2469, 2516);

                f_10597_2469_2515((object)underlyingMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2530, 2591);

                f_10597_2530_2590(!(underlyingMethod is RetargetingMethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2607, 2646);

                _retargetingModule = retargetingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2660, 2697);

                _underlyingMethod = underlyingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10597, 2278, 2708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 2278, 2708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 2278, 2708);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 2826, 2925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 2862, 2910);

                    return _retargetingModule.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 2826, 2925);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 2720, 2936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 2720, 2936);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 3021, 3098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3057, 3083);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 3021, 3098);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 2948, 3109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 2948, 3109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol UnderlyingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 3191, 3267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3227, 3252);

                    return _underlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 3191, 3267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 3121, 3278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 3121, 3278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 3381, 4047);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3417, 3985) || true) && (_lazyTypeParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 3417, 3985);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3492, 3966) || true) && (f_10597_3496_3512_M(!IsGenericMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 3492, 3966);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3562, 3626);

                            _lazyTypeParameters = ImmutableArray<TypeParameterSymbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 3492, 3966);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 3492, 3966);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 3724, 3943);

                            f_10597_3724_3942(ref _lazyTypeParameters, f_10597_3826_3895(f_10597_3826_3852(this), f_10597_3862_3894(_underlyingMethod)), default(ImmutableArray<TypeParameterSymbol>));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 3492, 3966);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 3417, 3985);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4005, 4032);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 3381, 4047);

                    bool
                    f_10597_3496_3512_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 3496, 3512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_3826_3852(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 3826, 3852);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10597_3862_3894(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 3862, 3894);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10597_3826_3895(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    list)
                    {
                        var return_v = this_param.Retarget(list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 3826, 3895);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10597_3724_3942(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 3724, 3942);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 3290, 4058);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 3290, 4058);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 4175, 4479);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4211, 4464) || true) && (f_10597_4215_4230())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 4211, 4464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4272, 4314);

                        return f_10597_4279_4313(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 4211, 4464);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 4211, 4464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4396, 4445);

                        return ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 4211, 4464);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 4175, 4479);

                    bool
                    f_10597_4215_4230()
                    {
                        var return_v = IsGenericMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 4215, 4230);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10597_4279_4313(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 4279, 4313);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 4070, 4490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 4070, 4490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 4588, 5111);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4624, 5049) || true) && (_lazyReturnType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 4624, 5049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 4693, 5030);

                        f_10597_4693_5029(ref _lazyReturnType, f_10597_4791_4973(f_10597_4821_4972(f_10597_4821_4847(this), f_10597_4857_4900(_underlyingMethod), RetargetOptions.RetargetPrimitiveTypesByTypeCode, f_10597_4952_4971(this))), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 4624, 5049);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5067, 5096);

                    return _lazyReturnType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 4588, 5111);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_4821_4847(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 4821, 4847);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10597_4857_4900(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 4857, 4900);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10597_4952_4971(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 4952, 4971);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10597_4821_4972(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    asDynamicIfNoPiaContainingType)
                    {
                        var return_v = this_param.Retarget(underlyingType, options, asDynamicIfNoPiaContainingType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 4821, 4972);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10597_4791_4973(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 4791, 4973);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10597_4693_5029(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 4693, 5029);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 4502, 5122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 4502, 5122);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 5224, 5389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5260, 5374);

                    return f_10597_5267_5373(f_10597_5267_5288(), f_10597_5307_5343(_underlyingMethod), ref _lazyRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 5224, 5389);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_5267_5288()
                    {
                        var return_v = RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 5267, 5288);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10597_5307_5343(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 5307, 5343);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10597_5267_5373(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    lazyCustomModifiers)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, ref lazyCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 5267, 5373);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 5134, 5400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 5134, 5400);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 5495, 5817);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5531, 5759) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 5531, 5759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5602, 5740);

                        f_10597_5602_5739(ref _lazyParameters, f_10597_5671_5696(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 5531, 5759);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5779, 5802);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 5495, 5817);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10597_5671_5696(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 5671, 5696);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10597_5602_5739(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 5602, 5739);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 5412, 5828);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 5412, 5828);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> RetargetParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 5840, 6499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5925, 5965);

                var
                list = f_10597_5936_5964(_underlyingMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 5979, 6003);

                int
                count = list.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6019, 6488) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 6019, 6488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6067, 6112);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 6019, 6488);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 6019, 6488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6178, 6236);

                    ParameterSymbol[]
                    parameters = new ParameterSymbol[count]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6265, 6270);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6256, 6415) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6283, 6286)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 6256, 6415))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 6256, 6415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6328, 6396);

                            parameters[i] = f_10597_6344_6395(this, list[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10597, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10597, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6435, 6473);

                    return f_10597_6442_6472(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 6019, 6488);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 5840, 6499);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10597_5936_5964(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 5936, 5964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodParameterSymbol
                f_10597_6344_6395(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                retargetingMethod, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlyingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodParameterSymbol(retargetingMethod, underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 6344, 6395);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10597_6442_6472(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 6442, 6472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 5840, 6499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 5840, 6499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 6575, 6832);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6611, 6678);

                    var
                    associatedPropertyOrEvent = f_10597_6643_6677(_underlyingMethod)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6696, 6817);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10597, 6703, 6744) || (((object)associatedPropertyOrEvent == null && DynAbs.Tracing.TraceSender.Conditional_F2(10597, 6747, 6751)) || DynAbs.Tracing.TraceSender.Conditional_F3(10597, 6754, 6816))) ? null : f_10597_6754_6816(f_10597_6754_6780(this), associatedPropertyOrEvent);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 6575, 6832);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10597_6643_6677(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 6643, 6677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_6754_6780(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 6754, 6780);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10597_6754_6816(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 6754, 6816);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 6511, 6843);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 6511, 6843);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 6919, 7049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 6955, 7034);

                    return f_10597_6962_7033(f_10597_6962_6988(this), f_10597_6998_7032(_underlyingMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 6919, 7049);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_6962_6988(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 6962, 6988);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10597_6998_7032(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 6998, 7032);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10597_6962_7033(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 6962, 7033);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 6855, 7060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 6855, 7060);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 7181, 7342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 7217, 7327);

                    return f_10597_7224_7326(_retargetingModule.RetargetingTranslator, f_10597_7274_7325(_underlyingMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 7181, 7342);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10597_7274_7325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 7274, 7325);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10597_7224_7326(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    marshallingInfo)
                    {
                        var return_v = this_param.Retarget(marshallingInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 7224, 7326);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 7072, 7353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 7072, 7353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 7365, 7588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 7457, 7577);

                return f_10597_7464_7576(f_10597_7464_7490(this), f_10597_7515_7548(_underlyingMethod), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 7365, 7588);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10597_7464_7490(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 7464, 7490);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_7515_7548(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 7515, 7548);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_7464_7576(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 7464, 7576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 7365, 7588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 7365, 7588);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<CSharpAttributeData> GetCustomAttributesToEmit(PEModuleBuilder moduleBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 7600, 7856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 7732, 7845);

                return f_10597_7739_7844(f_10597_7739_7765(this), f_10597_7785_7843(_underlyingMethod, moduleBuilder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 7600, 7856);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10597_7739_7765(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 7739, 7765);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_7785_7843(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 7785, 7843);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_7739_7844(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                attributes)
                {
                    var return_v = this_param.RetargetAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 7739, 7844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 7600, 7856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 7600, 7856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 7907, 8160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 8009, 8149);

                return f_10597_8016_8148(f_10597_8016_8042(this), f_10597_8067_8110(_underlyingMethod), ref _lazyReturnTypeCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 7907, 8160);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10597_8016_8042(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 8016, 8042);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_8067_8110(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8067, 8110);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10597_8016_8148(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8016, 8148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 7907, 8160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 7907, 8160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 8190, 9803);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 8324, 9741) || true) && (f_10597_8328_8421(_lazyUnmanagedAttributeData, UnmanagedCallersOnlyAttributeData.Uninitialized))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 8324, 9741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 8455, 8536);

                    var
                    data = f_10597_8466_8535(_underlyingMethod, forceComplete)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 8554, 8963) || true) && (f_10597_8558_8628(data, UnmanagedCallersOnlyAttributeData.Uninitialized) || (DynAbs.Tracing.TraceSender.Expression_False(10597, 8558, 8738) || f_10597_8653_8738(data, UnmanagedCallersOnlyAttributeData.AttributePresentDataNotBound)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 8554, 8963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 8932, 8944);

                        return data;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 8554, 8963);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9010, 9590) || true) && (data != null && (DynAbs.Tracing.TraceSender.Expression_True(10597, 9014, 9074) && f_10597_9030_9065(data.CallingConventionTypes) == false))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 9010, 9590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9116, 9184);

                        var
                        builder = f_10597_9130_9183()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9206, 9432);
                            foreach (var identifier in f_10597_9233_9260_I(data.CallingConventionTypes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 9206, 9432);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9310, 9409);

                                f_10597_9310_9408(builder, f_10597_9348_9407(f_10597_9348_9369(), (NamedTypeSymbol)identifier));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 9206, 9432);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10597, 1, 227);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10597, 1, 227);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9456, 9534);

                        data = f_10597_9463_9533(f_10597_9504_9532(builder));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9556, 9571);

                        f_10597_9556_9570(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 9010, 9590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9610, 9726);

                    f_10597_9610_9725(ref _lazyUnmanagedAttributeData, data, UnmanagedCallersOnlyAttributeData.Uninitialized);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 8324, 9741);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9757, 9792);

                return _lazyUnmanagedAttributeData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 8190, 9803);

                bool
                f_10597_8328_8421(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8328, 8421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10597_8466_8535(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                forceComplete)
                {
                    var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8466, 8535);
                    return return_v;
                }


                bool
                f_10597_8558_8628(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8558, 8628);
                    return return_v;
                }


                bool
                f_10597_8653_8738(Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                objA, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                objB)
                {
                    var return_v = ReferenceEquals((object?)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 8653, 8738);
                    return return_v;
                }


                bool
                f_10597_9030_9065(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                this_param)
                {
                    var return_v = this_param.IsEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 9030, 9065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                f_10597_9130_9183()
                {
                    var return_v = PooledHashSet<INamedTypeSymbolInternal>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9130, 9183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10597_9348_9369()
                {
                    var return_v = RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 9348, 9369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10597_9348_9407(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.Retarget((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9348, 9407);
                    return return_v;
                }


                bool
                f_10597_9310_9408(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9310, 9408);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                f_10597_9233_9260_I(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9233, 9260);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                f_10597_9504_9532(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9504, 9532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                f_10597_9463_9533(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                callingConventionTypes)
                {
                    var return_v = UnmanagedCallersOnlyAttributeData.Create(callingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9463, 9533);
                    return return_v;
                }


                int
                f_10597_9556_9570(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9556, 9570);
                    return 0;
                }


                Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                f_10597_9610_9725(ref Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                location1, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
                value, Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 9610, 9725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 8190, 9803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 8190, 9803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 9908, 10004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 9944, 9989);

                    return f_10597_9951_9988(_retargetingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 9908, 10004);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10597_9951_9988(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 9951, 9988);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 9834, 10015);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 9834, 10015);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 10099, 10176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 10135, 10161);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 10099, 10176);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 10027, 10187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 10027, 10187);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 10280, 10347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 10286, 10345);

                    return f_10597_10293_10344(_underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 10280, 10347);

                    bool
                    f_10597_10293_10344(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 10293, 10344);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 10199, 10358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 10199, 10358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 10472, 10953);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 10508, 10875) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 10508, 10875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 10601, 10856);

                        f_10597_10601_10855(ref _lazyExplicitInterfaceImplementations, f_10597_10743_10790(this), default(ImmutableArray<MethodSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 10508, 10875);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 10893, 10938);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 10472, 10953);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10597_10743_10790(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetExplicitInterfaceImplementations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 10743, 10790);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10597_10601_10855(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 10601, 10855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 10370, 10964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 10370, 10964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<MethodSymbol> RetargetExplicitInterfaceImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 10976, 11855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11080, 11143);

                var
                impls = f_10597_11092_11142(_underlyingMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11159, 11238) || true) && (impls.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 11159, 11238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11210, 11223);

                    return impls;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 11159, 11238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11373, 11428);

                var
                builder = f_10597_11387_11427()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11453, 11458);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11444, 11792) || true) && (i < impls.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11478, 11481)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 11444, 11792))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 11444, 11792);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11515, 11644);

                        var
                        retargeted = f_10597_11532_11643(f_10597_11532_11558(this), impls[i], MemberSignatureComparer.RetargetedExplicitImplementationComparer)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11662, 11777) || true) && ((object)retargeted != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 11662, 11777);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11734, 11758);

                            f_10597_11734_11757(builder, retargeted);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 11662, 11777);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10597, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10597, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 11808, 11844);

                return f_10597_11815_11843(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 10976, 11855);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10597_11092_11142(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 11092, 11142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10597_11387_11427()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 11387, 11427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10597_11532_11558(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 11532, 11558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10597_11532_11643(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                retargetedMethodComparer)
                {
                    var return_v = this_param.Retarget(method, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>)retargetedMethodComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 11532, 11643);
                    return return_v;
                }


                int
                f_10597_11734_11757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 11734, 11757);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10597_11815_11843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 11815, 11843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 10976, 11855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 10976, 11855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodSymbol ExplicitlyOverriddenClassMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 12114, 12440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12150, 12425);

                    return
                    (DynAbs.Tracing.TraceSender.Conditional_F1(10597, 12178, 12227) || ((f_10597_12178_12227(_underlyingMethod, out _) && DynAbs.Tracing.TraceSender.Conditional_F2(10597, 12255, 12392)) || DynAbs.Tracing.TraceSender.Conditional_F3(10597, 12420, 12424))) ? f_10597_12255_12392(f_10597_12255_12281(this), f_10597_12291_12325(_underlyingMethod), MemberSignatureComparer.RetargetedExplicitImplementationComparer) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 12114, 12440);

                    bool
                    f_10597_12178_12227(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, out bool
                    warnAmbiguous)
                    {
                        var return_v = method.RequiresExplicitOverride(out warnAmbiguous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 12178, 12227);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    f_10597_12255_12281(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RetargetingTranslator;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 12255, 12281);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10597_12291_12325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 12291, 12325);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10597_12255_12392(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                    retargetedMethodComparer)
                    {
                        var return_v = this_param.Retarget(method, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>)retargetedMethodComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 12255, 12392);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 12036, 12451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 12036, 12451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 12463, 12861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12543, 12804) || true) && (f_10597_12547_12619(_lazyUseSiteDiagnostic, CSDiagnosticInfo.EmptyErrorInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10597, 12543, 12804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12653, 12682);

                    DiagnosticInfo
                    result = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12700, 12739);

                    f_10597_12700_12738(this, ref result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12757, 12789);

                    _lazyUseSiteDiagnostic = result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10597, 12543, 12804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12820, 12850);

                return _lazyUseSiteDiagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 12463, 12861);

                bool
                f_10597_12547_12619(Microsoft.CodeAnalysis.DiagnosticInfo
                objA, Microsoft.CodeAnalysis.DiagnosticInfo
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 12547, 12619);
                    return return_v;
                }


                bool
                f_10597_12700_12738(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result)
                {
                    var return_v = this_param.CalculateUseSiteDiagnostic(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 12700, 12738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 12463, 12861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 12463, 12861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 12986, 13006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 12992, 13004);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 12986, 13006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 12873, 13017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 12873, 13017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 13094, 13115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 13100, 13113);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 13094, 13115);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 13029, 13126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 13029, 13126);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 13138, 13432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 13384, 13421);

                throw f_10597_13390_13420();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 13138, 13432);

                System.Exception
                f_10597_13390_13420()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 13390, 13420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 13138, 13432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 13138, 13432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10597, 13495, 13534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10597, 13498, 13534);
                throw f_10597_13504_13534(); DynAbs.Tracing.TraceSender.TraceExitMethod(10597, 13495, 13534);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10597, 13495, 13534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 13495, 13534);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10597_13504_13534()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10597, 13504, 13534);
                return return_v;
            }

        }

        static RetargetingMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10597, 906, 13542);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10597, 906, 13542);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10597, 906, 13542);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10597, 906, 13542);

        int
        f_10597_2407_2454(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 2407, 2454);
            return 0;
        }


        int
        f_10597_2469_2515(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 2469, 2515);
            return 0;
        }


        int
        f_10597_2530_2590(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10597, 2530, 2590);
            return 0;
        }

    }
}
