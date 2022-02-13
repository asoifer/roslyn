// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SubstitutedPropertySymbol : WrappedPropertySymbol
    {
        private readonly SubstitutedNamedTypeSymbol _containingType;

        private TypeWithAnnotations.Boxed _lazyType;

        private ImmutableArray<ParameterSymbol> _lazyParameters;

        internal SubstitutedPropertySymbol(SubstitutedNamedTypeSymbol containingType, PropertySymbol originalDefinition)
        : base(f_10161_764_782_C(originalDefinition))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10161, 631, 852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 481, 496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 543, 552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3679, 3709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 808, 841);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10161, 631, 852);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 631, 852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 631, 852);
            }
        }

        public override TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 944, 1327);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 980, 1269) || true) && (_lazyType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 980, 1269);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1043, 1142);

                        var
                        type = f_10161_1054_1141(f_10161_1054_1086(_containingType), f_10161_1102_1140(f_10161_1102_1120()))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1164, 1250);

                        f_10161_1164_1249(ref _lazyType, f_10161_1207_1242(type), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 980, 1269);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1289, 1312);

                    return _lazyType.Value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 944, 1327);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10161_1054_1086(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSubstitution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 1054, 1086);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_1102_1120()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 1102, 1120);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10161_1102_1140(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 1102, 1140);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10161_1054_1141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    previous)
                    {
                        var return_v = this_param.SubstituteType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 1054, 1141);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    f_10161_1207_1242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 1207, 1242);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    f_10161_1164_1249(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 1164, 1249);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 864, 1338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 864, 1338);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 1414, 1488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1450, 1473);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 1414, 1488);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 1350, 1499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 1350, 1499);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 1582, 1656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1618, 1641);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 1582, 1656);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 1511, 1667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 1511, 1667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PropertySymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 1753, 1831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1789, 1816);

                    return _underlyingProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 1753, 1831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 1679, 1842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 1679, 1842);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 1854, 1999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 1946, 1988);

                return f_10161_1953_1987(f_10161_1953_1971());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 1854, 1999);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10161_1953_1971()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 1953, 1971);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10161_1953_1987(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 1953, 1987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 1854, 1999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 1854, 1999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 2101, 2214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2107, 2212);

                    return f_10161_2114_2211(f_10161_2114_2146(_containingType), f_10161_2173_2210(f_10161_2173_2191()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 2101, 2214);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10161_2114_2146(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSubstitution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 2114, 2146);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_2173_2191()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 2173, 2191);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10161_2173_2210(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 2173, 2210);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10161_2114_2211(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    customModifiers)
                    {
                        var return_v = this_param.SubstituteCustomModifiers(customModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 2114, 2211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 2011, 2225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 2011, 2225);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 2320, 2639);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2356, 2581) || true) && (_lazyParameters.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 2356, 2581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2427, 2562);

                        f_10161_2427_2561(ref _lazyParameters, f_10161_2496_2518(this), default(ImmutableArray<ParameterSymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 2356, 2581);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2601, 2624);

                    return _lazyParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 2320, 2639);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10161_2496_2518(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SubstituteParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 2496, 2518);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10161_2427_2561(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 2427, 2561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 2237, 2650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 2237, 2650);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol GetMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 2725, 2950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2761, 2823);

                    MethodSymbol
                    originalGetMethod = f_10161_2794_2822(f_10161_2794_2812())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 2841, 2935);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10161, 2848, 2881) || (((object)originalGetMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10161, 2884, 2888)) || DynAbs.Tracing.TraceSender.Conditional_F3(10161, 2891, 2934))) ? null : f_10161_2891_2934(originalGetMethod, _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 2725, 2950);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_2794_2812()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 2794, 2812);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10161_2794_2822(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 2794, 2822);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10161_2891_2934(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 2891, 2934);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 2662, 2961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 2662, 2961);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 3036, 3261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3072, 3134);

                    MethodSymbol
                    originalSetMethod = f_10161_3105_3133(f_10161_3105_3123())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3152, 3246);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10161, 3159, 3192) || (((object)originalSetMethod == null && DynAbs.Tracing.TraceSender.Conditional_F2(10161, 3195, 3199)) || DynAbs.Tracing.TraceSender.Conditional_F3(10161, 3202, 3245))) ? null : f_10161_3202_3245(originalSetMethod, _containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 3036, 3261);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_3105_3123()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 3105, 3123);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10161_3105_3133(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.SetMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 3105, 3133);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10161_3202_3245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    newOwner)
                    {
                        var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 3202, 3245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 2973, 3272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 2973, 3272);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 3365, 3433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3371, 3431);

                    return f_10161_3378_3430(f_10161_3378_3396());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 3365, 3433);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_3378_3396()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 3378, 3396);
                        return return_v;
                    }


                    bool
                    f_10161_3378_3430(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitInterfaceImplementation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 3378, 3430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 3284, 3444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 3284, 3444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<PropertySymbol> _lazyExplicitInterfaceImplementations;

        private OverriddenOrHiddenMembersResult _lazyOverriddenOrHiddenMembers;

        public override ImmutableArray<PropertySymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 3826, 4416);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3862, 4338) || true) && (_lazyExplicitInterfaceImplementations.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 3862, 4338);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 3955, 4319);

                        f_10161_3955_4318(ref _lazyExplicitInterfaceImplementations, f_10161_4097_4251(f_10161_4165_4216(f_10161_4165_4183()), f_10161_4218_4250(_containingType)), default(ImmutableArray<PropertySymbol>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 3862, 4338);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 4356, 4401);

                    return _lazyExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 3826, 4416);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_4165_4183()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 4165, 4183);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10161_4165_4216(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 4165, 4216);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10161_4218_4250(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeSubstitution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 4218, 4250);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10161_4097_4251(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    unsubstitutedExplicitInterfaceImplementations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    map)
                    {
                        var return_v = ExplicitInterfaceHelpers.SubstituteExplicitInterfaceImplementations(unsubstitutedExplicitInterfaceImplementations, map);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 4097, 4251);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10161_3955_4318(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 3955, 4318);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 3722, 4427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 3722, 4427);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 4510, 4568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 4516, 4566);

                    return f_10161_4523_4565(f_10161_4523_4541());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 4510, 4568);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10161_4523_4541()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 4523, 4541);
                        return return_v;
                    }


                    bool
                    f_10161_4523_4565(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MustCallMethodsDirectly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 4523, 4565);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 4439, 4579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 4439, 4579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 4691, 5011);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 4727, 4938) || true) && (_lazyOverriddenOrHiddenMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 4727, 4938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 4811, 4919);

                        f_10161_4811_4918(ref _lazyOverriddenOrHiddenMembers, f_10161_4875_4911(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 4727, 4938);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 4958, 4996);

                    return _lazyOverriddenOrHiddenMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 4691, 5011);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10161_4875_4911(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedPropertySymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 4875, 4911);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    f_10161_4811_4918(ref Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    location1, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    value, Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 4811, 4918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 4591, 5022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 4591, 5022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> SubstituteParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10161, 5034, 5777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5121, 5181);

                var
                unsubstitutedParameters = f_10161_5151_5180(f_10161_5151_5169())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5197, 5766) || true) && (unsubstitutedParameters.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 5197, 5766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5266, 5297);

                    return unsubstitutedParameters;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 5197, 5766);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 5197, 5766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5363, 5406);

                    int
                    count = unsubstitutedParameters.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5424, 5469);

                    var
                    substituted = new ParameterSymbol[count]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5496, 5501);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5487, 5694) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5514, 5517)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 5487, 5694))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10161, 5487, 5694);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5559, 5675);

                            substituted[i] = f_10161_5576_5674(this, f_10161_5613_5645(_containingType), unsubstitutedParameters[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10161, 1, 208);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10161, 1, 208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10161, 5712, 5751);

                    return f_10161_5719_5750(substituted);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10161, 5197, 5766);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10161, 5034, 5777);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10161_5151_5169()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 5151, 5169);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10161_5151_5180(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 5151, 5180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10161_5613_5645(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10161, 5613, 5645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol
                f_10161_5576_5674(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedPropertySymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                map, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                originalParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)containingSymbol, map, originalParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 5576, 5674);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10161_5719_5750(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10161, 5719, 5750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10161, 5034, 5777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 5034, 5777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10161, 349, 5784);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10161, 349, 5784);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10161, 349, 5784);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10161, 349, 5784);

        static Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        f_10161_764_782_C(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10161, 631, 852);
            return return_v;
        }

    }
}
