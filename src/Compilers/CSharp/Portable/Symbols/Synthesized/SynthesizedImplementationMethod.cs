// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedImplementationMethod : SynthesizedInstanceMethodSymbol
    {
        private readonly MethodSymbol _interfaceMethod;

        private readonly NamedTypeSymbol _implementingType;

        private readonly bool _generateDebugInfo;

        private readonly PropertySymbol _associatedProperty;

        private readonly ImmutableArray<MethodSymbol> _explicitInterfaceImplementations;

        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly string _name;

        public SynthesizedImplementationMethod(
                    MethodSymbol interfaceMethod,
                    NamedTypeSymbol implementingType,
                    string name = null,
                    bool generateDebugInfo = true,
                    PropertySymbol associatedProperty = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10680, 1070, 2343);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 565, 581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 625, 642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 675, 693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 736, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1052, 1057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1430, 1474);

                f_10680_1430_1473(f_10680_1443_1472(implementingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1490, 1624);

                _name = name ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10680, 1498, 1623) ?? f_10680_1506_1623(f_10680_1545_1565(interfaceMethod), f_10680_1567_1597(interfaceMethod), aliasQualifierOpt: null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1638, 1675);

                _implementingType = implementingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1689, 1728);

                _generateDebugInfo = generateDebugInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1742, 1783);

                _associatedProperty = associatedProperty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1797, 1886);

                _explicitInterfaceImplementations = f_10680_1833_1885(interfaceMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 1975, 2054);

                var
                typeMap = f_10680_1989_2036(f_10680_1989_2019(interfaceMethod)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap>(10680, 1989, 2053) ?? f_10680_2040_2053())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2068, 2136);

                f_10680_2068_2135(typeMap, interfaceMethod, this, out _typeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2152, 2236);

                _interfaceMethod = interfaceMethod.ConstructIfGeneric(f_10680_2206_2234());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2250, 2332);

                _parameters = f_10680_2264_2331(_interfaceMethod, this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10680, 1070, 2343);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 1070, 2343);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 1070, 2343);
            }
        }

        public sealed override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 2463, 2504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2469, 2502);

                    return f_10680_2476_2501(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 2463, 2504);

                    bool
                    f_10680_2476_2501(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsVararg;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2476, 2501);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 2402, 2515);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 2402, 2515);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 2584, 2622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2590, 2620);

                    return f_10680_2597_2619(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 2584, 2622);

                    int
                    f_10680_2597_2619(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2597, 2619);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 2527, 2633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 2527, 2633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 2709, 2753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2715, 2751);

                    return f_10680_2722_2750(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 2709, 2753);

                    bool
                    f_10680_2722_2750(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnsVoid;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2722, 2750);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 2645, 2764);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 2645, 2764);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 2865, 2915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 2871, 2913);

                    return f_10680_2878_2912(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 2865, 2915);

                    Microsoft.Cci.CallingConvention
                    f_10680_2878_2912(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2878, 2912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 2776, 2926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 2776, 2926);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3035, 3086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3041, 3084);

                    return f_10680_3048_3083(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3035, 3086);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10680_3048_3083(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 3048, 3083);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 2938, 3097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 2938, 3097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3203, 3237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3209, 3235);

                    return _generateDebugInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3203, 3237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3131, 3248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3131, 3248);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3358, 3389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3364, 3387);

                    return _typeParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3358, 3389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3260, 3400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3260, 3400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3524, 3574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3530, 3572);

                    return f_10680_3537_3571(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3524, 3574);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10680_3537_3571(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 3537, 3571);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3412, 3585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3412, 3585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3653, 3693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3659, 3691);

                    return f_10680_3666_3690(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3653, 3693);

                    Microsoft.CodeAnalysis.RefKind
                    f_10680_3666_3690(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 3666, 3690);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3597, 3704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3597, 3704);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3809, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3815, 3865);

                    return f_10680_3822_3864(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3809, 3867);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10680_3822_3864(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 3822, 3864);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3716, 3878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3716, 3878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 3971, 4002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 3974, 4002);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 3971, 4002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 3971, 4002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 3971, 4002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4095, 4128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4098, 4128);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4095, 4128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4095, 4128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4095, 4128);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4224, 4251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4230, 4249);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4224, 4251);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4141, 4262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4141, 4262);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4338, 4371);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4344, 4369);

                    return _implementingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4338, 4371);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4274, 4382);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4274, 4382);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4465, 4541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4501, 4526);

                    return _implementingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4465, 4541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4394, 4552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4394, 4552);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4645, 4665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4651, 4663);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4645, 4665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4564, 4676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4564, 4676);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4790, 4839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4796, 4837);

                    return _explicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4790, 4839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4688, 4850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4688, 4850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 4924, 5025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 4960, 5010);

                    return MethodKind.ExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 4924, 5025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 4862, 5036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 4862, 5036);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5124, 5161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5130, 5159);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5124, 5161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5048, 5172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5048, 5172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5248, 5283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5254, 5281);

                    return _associatedProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5248, 5283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5184, 5294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5184, 5294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5374, 5395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5380, 5393);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5374, 5395);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5306, 5406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5306, 5406);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5493, 5539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5499, 5537);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5493, 5539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5418, 5550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5418, 5550);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5616, 5637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5622, 5635);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5616, 5637);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5562, 5648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5562, 5648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5713, 5734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5719, 5732);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5713, 5734);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5660, 5745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5660, 5745);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5812, 5833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5818, 5831);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5812, 5833);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5757, 5844);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5757, 5844);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 5912, 5933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 5918, 5931);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 5912, 5933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5856, 5944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5856, 5944);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6012, 6033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6018, 6031);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6012, 6033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 5956, 6044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 5956, 6044);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6110, 6131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6116, 6129);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6110, 6131);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6056, 6142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6056, 6142);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6208, 6229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6214, 6227);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6208, 6229);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6154, 6240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6154, 6240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6315, 6336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6321, 6334);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6315, 6336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6252, 6347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6252, 6347);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6411, 6432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6417, 6430);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6411, 6432);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6359, 6443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6359, 6443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6524, 6571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6530, 6569);

                    return f_10680_6537_6568(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6524, 6571);

                    bool
                    f_10680_6537_6568(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.HasSpecialName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 6537, 6568);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6455, 6582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6455, 6582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6707, 6770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6713, 6768);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6707, 6770);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6594, 6781);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6594, 6781);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6870, 6925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 6876, 6923);

                    return f_10680_6883_6922(_interfaceMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6870, 6925);

                    bool
                    f_10680_6883_6922(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RequiresSecurityObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 6883, 6922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6793, 6936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6793, 6936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 6948, 7094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7071, 7083);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 6948, 7094);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 6948, 7094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 6948, 7094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7169, 7232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7205, 7217);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7169, 7232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7106, 7243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7106, 7243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7255, 7401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7378, 7390);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7255, 7401);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7255, 7401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7255, 7401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7413, 7509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7486, 7498);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7413, 7509);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7413, 7509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7413, 7509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7630, 7650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7636, 7648);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7630, 7650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7521, 7661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7521, 7661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7743, 7764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7749, 7762);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7743, 7764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7673, 7775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7673, 7775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7787, 7947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 7899, 7936);

                throw f_10680_7905_7935();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7787, 7947);

                System.Exception
                f_10680_7905_7935()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 7905, 7935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7787, 7947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7787, 7947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10680, 7959, 8102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10680, 8055, 8091);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10680, 7959, 8102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10680, 7959, 8102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 7959, 8102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedImplementationMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10680, 411, 8109);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10680, 411, 8109);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10680, 411, 8109);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10680, 411, 8109);

        bool
        f_10680_1443_1472(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 1443, 1472);
            return return_v;
        }


        int
        f_10680_1430_1473(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 1430, 1473);
            return 0;
        }


        string
        f_10680_1545_1565(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 1545, 1565);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10680_1567_1597(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 1567, 1597);
            return return_v;
        }


        string
        f_10680_1506_1623(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        explicitInterfaceTypeOpt, string
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberName(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)explicitInterfaceTypeOpt, aliasQualifierOpt: aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 1506, 1623);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10680_1833_1885(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        item)
        {
            var return_v = ImmutableArray.Create<MethodSymbol>(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 1833, 1885);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10680_1989_2019(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 1989, 2019);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10680_1989_2036(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeSubstitution;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 1989, 2036);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10680_2040_2053()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2040, 2053);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10680_2068_2135(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters)
        {
            var return_v = this_param.WithAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 2068, 2135);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10680_2206_2234()
        {
            var return_v = TypeArgumentsWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10680, 2206, 2234);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10680_2264_2331(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedImplementationMethod
        destinationMethod)
        {
            var return_v = SynthesizedParameterSymbol.DeriveParameters(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10680, 2264, 2331);
            return return_v;
        }

    }
}
