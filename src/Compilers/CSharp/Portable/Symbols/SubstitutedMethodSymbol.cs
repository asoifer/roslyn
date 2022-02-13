// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SubstitutedMethodSymbol : WrappedMethodSymbol
    {
        private readonly NamedTypeSymbol _containingType;

        private readonly MethodSymbol _underlyingMethod;

        private readonly TypeMap _inputMap;

        private readonly MethodSymbol _constructedFrom;

        private TypeWithAnnotations.Boxed _lazyReturnType;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        private TypeMap _lazyMap;

        private ImmutableArray<TypeParameterSymbol> _lazyTypeParameters;

        private ImmutableArray<MethodSymbol> _lazyExplicitInterfaceImplementations;

        private OverriddenOrHiddenMembersResult _lazyOverriddenOrHiddenMembers;

        private int _hashCode;

        internal SubstitutedMethodSymbol(NamedTypeSymbol containingSymbol, MethodSymbol originalDefinition)
        : this(f_10158_1754_1770_C(containingSymbol), f_10158_1772_1805(containingSymbol), originalDefinition, constructedFrom: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10158, 1634, 2151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1874, 1985);

                f_10158_1874_1984(containingSymbol is SubstitutedNamedTypeSymbol || (DynAbs.Tracing.TraceSender.Expression_False(10158, 1887, 1983) || containingSymbol is SubstitutedErrorTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1999, 2140);

                f_10158_1999_2139(f_10158_2012_2138(f_10158_2030_2063(originalDefinition), f_10158_2065_2100(containingSymbol), TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10158, 1634, 2151);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 1634, 2151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 1634, 2151);
            }
        }

        protected SubstitutedMethodSymbol(NamedTypeSymbol containingSymbol, TypeMap map, MethodSymbol originalDefinition, MethodSymbol constructedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10158, 2163, 3008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 890, 905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 946, 963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 999, 1008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1049, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1112, 1127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1220, 1228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1535, 1565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 1590, 1599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2331, 2380);

                f_10158_2331_2379((object)originalDefinition != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2394, 2440);

                f_10158_2394_2439(f_10158_2407_2438(originalDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2454, 2489);

                _containingType = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2503, 2542);

                _underlyingMethod = originalDefinition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2556, 2572);

                _inputMap = map;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2586, 2997) || true) && ((object)constructedFrom != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 2586, 2997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2655, 2690);

                    _constructedFrom = constructedFrom;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2708, 2788);

                    f_10158_2708_2787(f_10158_2721_2786(f_10158_2737_2768(constructedFrom), constructedFrom));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2806, 2859);

                    _lazyTypeParameters = f_10158_2828_2858(constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2877, 2892);

                    _lazyMap = map;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 2586, 2997);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 2586, 2997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 2958, 2982);

                    _constructedFrom = this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 2586, 2997);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10158, 2163, 3008);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 2163, 3008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 2163, 3008);
            }
        }

        public override MethodSymbol UnderlyingMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 3090, 3166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3126, 3151);

                    return _underlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 3090, 3166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 3020, 3177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 3020, 3177);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 3258, 3333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3294, 3318);

                    return _constructedFrom;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 3258, 3333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 3189, 3344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 3189, 3344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeMap Map
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 3400, 3514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3436, 3465);

                    f_10158_3436_3464(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3483, 3499);

                    return _lazyMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 3400, 3514);

                    int
                    f_10158_3436_3464(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        this_param.EnsureMapAndTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 3436, 3464);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 3356, 3525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 3356, 3525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 3635, 3760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3671, 3700);

                    f_10158_3671_3699(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3718, 3745);

                    return _lazyTypeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 3635, 3760);

                    int
                    f_10158_3671_3699(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        this_param.EnsureMapAndTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 3671, 3699);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 3537, 3771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 3537, 3771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureMapAndTypeParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 3783, 4914);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3849, 3939) || true) && (f_10158_3853_3883_M(!_lazyTypeParameters.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 3849, 3939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3917, 3924);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 3849, 3939);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 3955, 4006);

                ImmutableArray<TypeParameterSymbol>
                typeParameters
                = default(ImmutableArray<TypeParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4020, 4074);

                f_10158_4020_4073(f_10158_4033_4072(_constructedFrom, this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4192, 4282);

                var
                newMap = f_10158_4205_4281(_inputMap, f_10158_4231_4254(this), this, out typeParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4298, 4368);

                var
                prevMap = f_10158_4312_4367(ref _lazyMap, newMap, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4382, 4696) || true) && (prevMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 4382, 4696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4591, 4681);

                    typeParameters = f_10158_4608_4680(prevMap, f_10158_4641_4679(f_10158_4641_4664(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 4382, 4696);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4712, 4847);

                f_10158_4712_4846(ref _lazyTypeParameters, typeParameters, default(ImmutableArray<TypeParameterSymbol>));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 4861, 4903);

                f_10158_4861_4902(_lazyTypeParameters != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 3783, 4914);

                bool
                f_10158_3853_3883_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 3853, 3883);
                    return return_v;
                }


                bool
                f_10158_4033_4072(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4033, 4072);
                    return return_v;
                }


                int
                f_10158_4020_4073(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4020, 4073);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_4231_4254(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 4231, 4254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10158_4205_4281(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                newTypeParameters)
                {
                    var return_v = this_param.WithAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4205, 4281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10158_4312_4367(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4312, 4367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_4641_4664(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 4641, 4664);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10158_4641_4679(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 4641, 4679);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10158_4608_4680(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                original)
                {
                    var return_v = this_param.SubstituteTypeParameters(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4608, 4680);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10158_4712_4846(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                comparand)
                {
                    var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4712, 4846);
                    return return_v;
                }


                int
                f_10158_4861_4902(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 4861, 4902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 3783, 4914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 3783, 4914);
            }
        }

        public sealed override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 5007, 5103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5043, 5088);

                    return f_10158_5050_5087(f_10158_5050_5068());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 5007, 5103);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_5050_5068()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5050, 5068);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10158_5050_5087(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5050, 5087);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 4926, 5114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 4926, 5114);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 5231, 5324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5267, 5309);

                    return f_10158_5274_5308(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 5231, 5324);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10158_5274_5308(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 5274, 5308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 5126, 5335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 5126, 5335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override MethodSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 5426, 5502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5462, 5487);

                    return _underlyingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 5426, 5502);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 5347, 5513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 5347, 5513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override MethodSymbol CallsiteReducedFromMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 5613, 5819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5649, 5693);

                    var
                    method = f_10158_5662_5692(f_10158_5662_5680())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5711, 5804);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10158, 5718, 5742) || ((((object)method == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10158, 5745, 5749)) || DynAbs.Tracing.TraceSender.Conditional_F3(10158, 5752, 5803))) ? null : f_10158_5752_5803(method, f_10158_5769_5802(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 5613, 5819);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_5662_5680()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5662, 5680);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_5662_5692(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReducedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5662, 5692);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10158_5769_5802(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5769, 5802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_5752_5803(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 5752, 5803);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 5525, 5830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 5525, 5830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeSymbol ReceiverType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 5906, 6189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 5942, 5987);

                    var
                    reduced = f_10158_5956_5986(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6005, 6120) || true) && ((object)reduced == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 6005, 6120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6074, 6101);

                        return f_10158_6081_6100(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 6005, 6120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6140, 6174);

                    return f_10158_6147_6173(f_10158_6147_6165(reduced)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 5906, 6189);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_5956_5986(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallsiteReducedFromMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 5956, 5986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10158_6081_6100(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6081, 6100);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10158_6147_6165(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6147, 6165);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10158_6147_6173(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6147, 6173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 5842, 6200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 5842, 6200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeSymbol GetTypeInferredDuringReduction(TypeParameterSymbol reducedFromTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 6212, 6742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6443, 6533);

                var
                notUsed = f_10158_6457_6532(f_10158_6457_6475(), reducedFromTypeParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6549, 6637);

                f_10158_6549_6636((object)notUsed == null && (DynAbs.Tracing.TraceSender.Expression_True(10158, 6562, 6635) && (object)f_10158_6597_6627(f_10158_6597_6615()) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6651, 6731);

                return f_10158_6658_6691(this)[f_10158_6692_6724(reducedFromTypeParameter)].Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 6212, 6742);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_6457_6475()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6457, 6475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10158_6457_6532(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                reducedFromTypeParameter)
                {
                    var return_v = this_param.GetTypeInferredDuringReduction(reducedFromTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 6457, 6532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_6597_6615()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6597, 6615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_6597_6627(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReducedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6597, 6627);
                    return return_v;
                }


                int
                f_10158_6549_6636(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 6549, 6636);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10158_6658_6691(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6658, 6691);
                    return return_v;
                }


                int
                f_10158_6692_6724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6692, 6724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 6212, 6742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 6212, 6742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override MethodSymbol ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 6826, 6915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 6862, 6900);

                    return f_10158_6869_6899(f_10158_6869_6887());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 6826, 6915);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_6869_6887()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6869, 6887);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_6869_6899(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReducedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 6869, 6899);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 6754, 6926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 6754, 6926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7009, 7083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7045, 7068);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7009, 7083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 6938, 7094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 6938, 7094);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7177, 7251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7213, 7236);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7177, 7251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 7106, 7262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 7106, 7262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7274, 7431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7373, 7420);

                return f_10158_7380_7419(f_10158_7380_7403(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7274, 7431);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_7380_7403(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 7380, 7403);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10158_7380_7419(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 7380, 7419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 7274, 7431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 7274, 7431);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7443, 7613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7545, 7602);

                return f_10158_7552_7601(f_10158_7552_7575(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7443, 7613);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_7552_7575(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 7552, 7575);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10158_7552_7601(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetReturnTypeAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 7552, 7601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 7443, 7613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 7443, 7613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7754, 7832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7757, 7832);
                return f_10158_7757_7832(f_10158_7757_7780(this), forceComplete); DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7754, 7832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 7754, 7832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 7754, 7832);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10158_7757_7780(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
            this_param)
            {
                var return_v = this_param.OriginalDefinition;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 7757, 7780);
                return return_v;
            }


            Microsoft.CodeAnalysis.UnmanagedCallersOnlyAttributeData?
            f_10158_7757_7832(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param, bool
            forceComplete)
            {
                var return_v = this_param.GetUnmanagedCallersOnlyAttributeData(forceComplete);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 7757, 7832);
                return return_v;
            }

        }

        public sealed override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 7916, 8128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 7952, 8008);

                    Symbol
                    underlying = f_10158_7972_8007(f_10158_7972_7990())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8026, 8113);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10158, 8033, 8061) || ((((object)underlying == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10158, 8064, 8068)) || DynAbs.Tracing.TraceSender.Conditional_F3(10158, 8071, 8112))) ? null : f_10158_8071_8112(underlying, f_10158_8097_8111());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 7916, 8128);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_7972_7990()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 7972, 7990);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10158_7972_8007(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 7972, 8007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10158_8097_8111()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8097, 8111);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10158_8071_8112(Microsoft.CodeAnalysis.CSharp.Symbol
                    s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = s.SymbolAsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 8071, 8112);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 7845, 8139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 7845, 8139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 8244, 8632);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8280, 8570) || true) && (_lazyReturnType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 8280, 8570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8349, 8431);

                        var
                        returnType = f_10158_8366_8430(f_10158_8366_8369(), f_10158_8385_8429(f_10158_8385_8403()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8453, 8551);

                        f_10158_8453_8550(ref _lazyReturnType, f_10158_8502_8543(returnType), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 8280, 8570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8588, 8617);

                    return _lazyReturnType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 8244, 8632);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10158_8366_8369()
                    {
                        var return_v = Map;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8366, 8369);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_8385_8403()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8385, 8403);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10158_8385_8429(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8385, 8429);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10158_8366_8430(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 8366, 8430);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10158_8502_8543(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 8502, 8543);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10158_8453_8550(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 8453, 8550);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 8151, 8643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 8151, 8643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 8754, 8881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 8790, 8866);

                    return f_10158_8797_8865(f_10158_8797_8800(), f_10158_8827_8864(f_10158_8827_8845()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 8754, 8881);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10158_8797_8800()
                    {
                        var return_v = Map;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8797, 8800);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_8827_8845()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8827, 8845);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10158_8827_8864(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 8827, 8864);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10158_8797_8865(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    customModifiers)
                    {
                        var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 8797, 8865);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 8657, 8892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 8657, 8892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 8994, 9313);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9030, 9255) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 9030, 9255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9101, 9236);

                        f_10158_9101_9235(ref _lazyParameters, f_10158_9170_9192(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 9030, 9255);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9275, 9298);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 8994, 9313);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10158_9170_9192(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.SubstituteParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 9170, 9192);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10158_9101_9235(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 9101, 9235);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 8904, 9324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 8904, 9324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 9424, 9497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9430, 9495);

                    return f_10158_9437_9494(f_10158_9437_9460(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 9424, 9497);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_9437_9460(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 9437, 9460);
                        return return_v;
                    }


                    bool
                    f_10158_9437_9494(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 9437, 9494);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 9336, 9508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 9336, 9508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 9629, 10364);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9665, 9816) || true) && (!f_10158_9670_9713(f_10158_9686_9706(this), this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 9665, 9816);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9755, 9797);

                        return ImmutableArray<MethodSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 9665, 9816);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9836, 10286) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 9836, 10286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 9929, 10267);

                        f_10158_9929_10266(ref _lazyExplicitInterfaceImplementations, f_10158_10071_10201(f_10158_10139_10195(f_10158_10139_10162(this)), f_10158_10197_10200()), default(ImmutableArray<MethodSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 9836, 10286);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 10304, 10349);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 9629, 10364);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_9686_9706(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 9686, 9706);
                        return return_v;
                    }


                    bool
                    f_10158_9670_9713(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 9670, 9713);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10158_10139_10162(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 10139, 10162);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10158_10139_10195(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 10139, 10195);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10158_10197_10200()
                    {
                        var return_v = Map;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 10197, 10200);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10158_10071_10201(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    unsubstitutedExplicitInterfaceImplementations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    map)
                    {
                        var return_v = ExplicitInterfaceHelpers.SubstituteExplicitInterfaceImplementations(unsubstitutedExplicitInterfaceImplementations, map);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 10071, 10201);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10158_9929_10266(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 9929, 10266);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 9520, 10375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 9520, 10375);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 10494, 11076);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 10530, 11005) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 10530, 11005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 10878, 10986);

                        f_10158_10878_10985(ref _lazyOverriddenOrHiddenMembers, f_10158_10942_10978(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 10530, 11005);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 11023, 11061);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 10494, 11076);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10158_10942_10978(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 10942, 10978);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10158_10878_10985(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 10878, 10985);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 10387, 11087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 10387, 11087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool CallsAreOmitted(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 11099, 11257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 11192, 11246);

                return f_10158_11199_11245(f_10158_11199_11217(), syntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 11099, 11257);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_11199_11217()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 11199, 11217);
                    return return_v;
                }


                bool
                f_10158_11199_11245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 11199, 11245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 11099, 11257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 11099, 11257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override TypeMap TypeSubstitution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 11343, 11367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 11349, 11365);

                    return f_10158_11356_11364(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 11343, 11367);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10158_11356_11364(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Map;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 11356, 11364);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 11269, 11378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 11269, 11378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 11390, 12297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 11894, 11932);

                ParameterSymbol
                originalThisParameter
                = default(ParameterSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 11946, 12117) || true) && (!f_10158_11951_12016(f_10158_11951_11969(), out originalThisParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 11946, 12117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12050, 12071);

                    thisParameter = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12089, 12102);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 11946, 12117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12133, 12260);

                thisParameter = (DynAbs.Tracing.TraceSender.Conditional_F1(10158, 12149, 12186) || (((object)originalThisParameter != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10158, 12206, 12235)) || DynAbs.Tracing.TraceSender.Conditional_F3(10158, 12255, 12259))) ? f_10158_12206_12235(this) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12274, 12286);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 11390, 12297);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_11951_11969()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 11951, 11969);
                    return return_v;
                }


                bool
                f_10158_11951_12016(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                thisParameter)
                {
                    var return_v = this_param.TryGetThisParameter(out thisParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 11951, 12016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                f_10158_12206_12235(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                forMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)forMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 12206, 12235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 11390, 12297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 11390, 12297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<ParameterSymbol> SubstituteParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 12309, 13059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12396, 12456);

                var
                unsubstitutedParameters = f_10158_12426_12455(f_10158_12426_12444())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12470, 12513);

                int
                count = unsubstitutedParameters.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12529, 13048) || true) && (count == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 12529, 13048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12577, 12622);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 12529, 13048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 12529, 13048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12688, 12755);

                    var
                    substituted = f_10158_12706_12754(count)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12773, 12791);

                    TypeMap
                    map = f_10158_12787_12790()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12809, 12973);
                        foreach (var p in f_10158_12827_12850_I(unsubstitutedParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 12809, 12973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12892, 12954);

                            f_10158_12892_12953(substituted, f_10158_12908_12952(this, map, p));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 12809, 12973);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10158, 1, 165);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10158, 1, 165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 12993, 13033);

                    return f_10158_13000_13032(substituted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 12529, 13048);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 12309, 13059);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_12426_12444()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 12426, 12444);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10158_12426_12455(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 12426, 12455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10158_12706_12754(int
                capacity)
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 12706, 12754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10158_12787_12790()
                {
                    var return_v = Map;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 12787, 12790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                f_10158_12908_12952(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                map, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                originalParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containingSymbol, map, originalParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 12908, 12952);
                    return return_v;
                }


                int
                f_10158_12892_12953(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 12892, 12953);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10158_12827_12850_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 12827, 12850);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10158_13000_13032(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 13000, 13032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 12309, 13059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 12309, 13059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 13071, 13233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 13185, 13222);

                throw f_10158_13191_13221();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 13071, 13233);

                System.Exception
                f_10158_13191_13221()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 13191, 13221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 13071, 13233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 13071, 13233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 13296, 13335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 13299, 13335);
                throw f_10158_13305_13335(); DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 13296, 13335);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 13296, 13335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 13296, 13335);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10158_13305_13335()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 13305, 13335);
                return return_v;
            }

        }

        private int ComputeHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 13348, 16091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 13402, 13451);

                int
                code = f_10158_13413_13450(f_10158_13413_13436(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 13874, 13929);

                var
                containingHashCode = f_10158_13899_13928(_containingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 13943, 14137) || true) && (containingHashCode == f_10158_13969_14021(f_10158_13969_14007(f_10158_13969_13992(this))) && (DynAbs.Tracing.TraceSender.Expression_True(10158, 13947, 14076) && f_10158_14042_14076(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 13943, 14137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 14110, 14122);

                    return code;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 13943, 14137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 14153, 14199);

                code = f_10158_14160_14198(containingHashCode, code);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 14934, 15176) || true) && ((object)f_10158_14946_14961() != (object)this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 14934, 15176);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15011, 15161);
                        foreach (var arg in f_10158_15031_15064_I(f_10158_15031_15064(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 15011, 15161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15106, 15142);

                            code = f_10158_15113_15141(arg.Type, code);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 15011, 15161);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10158, 1, 151);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10158, 1, 151);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 14934, 15176);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15326, 15395) || true) && (code == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 15326, 15395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15373, 15380);

                    code++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 15326, 15395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15411, 15423);

                return code;

                static bool wasConstructedForAnnotations(SubstitutedMethodSymbol method)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10158, 15439, 16080);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15544, 15600);

                        var
                        typeArguments = f_10158_15564_15599(method)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15618, 15680);

                        var
                        typeParameters = f_10158_15639_15679(f_10158_15639_15664(method))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15709, 15714);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15700, 16033) || true) && (i < typeArguments.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15742, 15745)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 15700, 16033))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 15700, 16033);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15787, 16014) || true) && (!f_10158_15792_15928(typeParameters[i], typeArguments[i].Type, TypeCompareKind.ConsiderEverything))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 15787, 16014);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 15978, 15991);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 15787, 16014);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10158, 1, 334);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10158, 1, 334);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16053, 16065);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10158, 15439, 16080);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10158_15564_15599(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeArgumentsWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 15564, 15599);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10158_15639_15664(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 15639, 15664);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10158_15639_15679(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeParameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 15639, 15679);
                            return return_v;
                        }


                        bool
                        f_10158_15792_15928(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        t2, Microsoft.CodeAnalysis.TypeCompareKind
                        comparison)
                        {
                            var return_v = this_param.Equals(t2, comparison);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 15792, 15928);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 15439, 16080);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 15439, 16080);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 13348, 16091);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_13413_13436(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 13413, 13436);
                    return return_v;
                }


                int
                f_10158_13413_13450(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 13413, 13450);
                    return return_v;
                }


                int
                f_10158_13899_13928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 13899, 13928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_13969_13992(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 13969, 13992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10158_13969_14007(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 13969, 14007);
                    return return_v;
                }


                int
                f_10158_13969_14021(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 13969, 14021);
                    return return_v;
                }


                bool
                f_10158_14042_14076(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                method)
                {
                    var return_v = wasConstructedForAnnotations(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 14042, 14076);
                    return return_v;
                }


                int
                f_10158_14160_14198(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 14160, 14198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_14946_14961()
                {
                    var return_v = ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 14946, 14961);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10158_15031_15064(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 15031, 15064);
                    return return_v;
                }


                int
                f_10158_15113_15141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 15113, 15141);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10158_15031_15064_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 15031, 15064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 13348, 16091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 13348, 16091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 16103, 17838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16203, 16244);

                MethodSymbol
                other = obj as MethodSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16258, 16298) || true) && ((object)other == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 16258, 16298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16285, 16298);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 16258, 16298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16314, 16519) || true) && ((object)f_10158_16326_16349(this) != (object)f_10158_16361_16385(other) && (DynAbs.Tracing.TraceSender.Expression_True(10158, 16318, 16457) && f_10158_16406_16429(this) != f_10158_16433_16457(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 16314, 16519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16491, 16504);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 16314, 16519);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16706, 16799) || true) && (!f_10158_16711_16784(f_10158_16729_16748(this), f_10158_16750_16770(other), compareKind))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 16706, 16799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16786, 16799);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 16706, 16799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 16972, 17042);

                bool
                selfIsDeclaration = (object)this == (object)f_10158_17021_17041(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17056, 17129);

                bool
                otherIsDeclaration = (object)other == (object)f_10158_17107_17128(other)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17245, 17382) || true) && (selfIsDeclaration | otherIsDeclaration)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 17245, 17382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17321, 17367);

                    return selfIsDeclaration & otherIsDeclaration;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 17245, 17382);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17509, 17532);

                int
                arity = f_10158_17521_17531(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17555, 17560);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17546, 17799) || true) && (i < arity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17573, 17576)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 17546, 17799))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 17546, 17799);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17610, 17784) || true) && (!f_10158_17615_17648(this)[i].Equals(f_10158_17659_17693(other)[i], compareKind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 17610, 17784);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17752, 17765);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 17610, 17784);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10158, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10158, 1, 254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17815, 17827);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 16103, 17838);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_16326_16349(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16326, 16349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_16361_16385(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16361, 16385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_16406_16429(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16406, 16429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_16433_16457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16433, 16457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10158_16729_16748(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16729, 16748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10158_16750_16770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 16750, 16770);
                    return return_v;
                }


                bool
                f_10158_16711_16784(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 16711, 16784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_17021_17041(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 17021, 17041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10158_17107_17128(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 17107, 17128);
                    return return_v;
                }


                int
                f_10158_17521_17531(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 17521, 17531);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10158_17615_17648(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 17615, 17648);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10158_17659_17693(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 17659, 17693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 16103, 17838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 16103, 17838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10158, 17850, 18104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17908, 17929);

                int
                code = _hashCode
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17943, 18065) || true) && (code == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10158, 17943, 18065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 17990, 18015);

                    code = f_10158_17997_18014(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 18033, 18050);

                    _hashCode = code;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10158, 17943, 18065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10158, 18081, 18093);

                return code;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10158, 17850, 18104);

                int
                f_10158_17997_18014(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param)
                {
                    var return_v = this_param.ComputeHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 17997, 18014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10158, 17850, 18104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 17850, 18104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10158, 780, 18111);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10158, 780, 18111);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10158, 780, 18111);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10158, 780, 18111);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10158_1772_1805(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeSubstitution;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 1772, 1805);
            return return_v;
        }


        int
        f_10158_1874_1984(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 1874, 1984);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10158_2030_2063(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 2030, 2063);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10158_2065_2100(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 2065, 2100);
            return return_v;
        }


        bool
        f_10158_2012_2138(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        right, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 2012, 2138);
            return return_v;
        }


        int
        f_10158_1999_2139(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 1999, 2139);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10158_1754_1770_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10158, 1634, 2151);
            return return_v;
        }


        int
        f_10158_2331_2379(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 2331, 2379);
            return 0;
        }


        bool
        f_10158_2407_2438(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 2407, 2438);
            return return_v;
        }


        int
        f_10158_2394_2439(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 2394, 2439);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10158_2737_2768(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ConstructedFrom;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 2737, 2768);
            return return_v;
        }


        bool
        f_10158_2721_2786(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        objB)
        {
            var return_v = ReferenceEquals((object)objA, (object)objB);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 2721, 2786);
            return return_v;
        }


        int
        f_10158_2708_2787(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10158, 2708, 2787);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10158_2828_2858(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10158, 2828, 2858);
            return return_v;
        }

    }
}
