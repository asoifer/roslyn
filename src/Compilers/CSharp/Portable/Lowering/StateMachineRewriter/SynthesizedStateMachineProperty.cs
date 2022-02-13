// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class SynthesizedStateMachineProperty : PropertySymbol, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly SynthesizedStateMachineMethod _getter;

        private readonly string _name;

        internal SynthesizedStateMachineProperty(
                    MethodSymbol interfacePropertyGetter,
                    StateMachineTypeSymbol stateMachineType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10546, 706, 1485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 646, 653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 688, 693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 877, 1036);

                _name = f_10546_885_1035(f_10546_924_969(f_10546_924_964(interfacePropertyGetter)), f_10546_971_1009(interfacePropertyGetter), aliasQualifierOpt: null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1050, 1201);

                var
                getterName = f_10546_1067_1200(f_10546_1106_1134(interfacePropertyGetter), f_10546_1136_1174(interfacePropertyGetter), aliasQualifierOpt: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1217, 1474);

                _getter = f_10546_1227_1473(getterName, interfacePropertyGetter, stateMachineType, associatedProperty: this, hasMethodBodyDependency: false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10546, 706, 1485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 706, 1485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 706, 1485);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 1549, 1570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1555, 1568);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 1549, 1570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 1497, 1581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 1497, 1581);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 1649, 1677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1655, 1675);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 1649, 1677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 1593, 1688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 1593, 1688);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 1780, 1829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1786, 1827);

                    return f_10546_1793_1826(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 1780, 1829);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10546_1793_1826(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 1793, 1826);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 1700, 1840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 1700, 1840);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 1942, 1984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 1948, 1982);

                    return f_10546_1955_1981(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 1942, 1984);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10546_1955_1981(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 1955, 1981);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 1852, 1995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 1852, 1995);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2090, 2124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2096, 2122);

                    return f_10546_2103_2121(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2090, 2124);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10546_2103_2121(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 2103, 2121);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2007, 2135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2007, 2135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsIndexer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2202, 2245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2208, 2243);

                    return f_10546_2215_2242_M(!_getter.Parameters.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2202, 2245);

                    bool
                    f_10546_2215_2242_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 2215, 2242);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2147, 2256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2147, 2256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2330, 2351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2336, 2349);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2330, 2351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2268, 2362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2268, 2362);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2437, 2460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2443, 2458);

                    return _getter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2437, 2460);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2374, 2471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2374, 2471);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2546, 2566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2552, 2564);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2546, 2566);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2483, 2577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2483, 2577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2671, 2712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2677, 2710);

                    return f_10546_2684_2709(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2671, 2712);

                    Microsoft.Cci.CallingConvention
                    f_10546_2684_2709(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.CallingConvention;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 2684, 2709);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2589, 2723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2589, 2723);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2806, 2827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2812, 2825);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2806, 2827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2735, 2838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2735, 2838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PropertySymbol ImplementedProperty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 2917, 3052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 2953, 3037);

                    return (PropertySymbol)f_10546_2976_3036(f_10546_2976_3016(_getter)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 2917, 3052);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10546_2976_3016(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 2976, 3016);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10546_2976_3036(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 2976, 3036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 2850, 3063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 2850, 3063);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3179, 3237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3185, 3235);

                    return f_10546_3192_3234(f_10546_3214_3233());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3179, 3237);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10546_3214_3233()
                    {
                        var return_v = ImplementedProperty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 3214, 3233);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10546_3192_3234(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10546, 3192, 3234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3075, 3248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3075, 3248);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3324, 3364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3330, 3362);

                    return f_10546_3337_3361(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3324, 3364);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10546_3337_3361(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 3337, 3361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3260, 3375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3260, 3375);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3462, 3508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3468, 3506);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3462, 3508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3387, 3519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3387, 3519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3629, 3682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3635, 3680);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3629, 3682);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3531, 3693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3531, 3693);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3781, 3826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3787, 3824);

                    return f_10546_3794_3823(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3781, 3826);

                    Microsoft.CodeAnalysis.Accessibility
                    f_10546_3794_3823(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.DeclaredAccessibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 3794, 3823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3705, 3837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3705, 3837);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 3903, 3935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 3909, 3933);

                    return f_10546_3916_3932(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 3903, 3935);

                    bool
                    f_10546_3916_3932(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 3916, 3932);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3849, 3946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3849, 3946);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4013, 4046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4019, 4044);

                    return f_10546_4026_4043(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4013, 4046);

                    bool
                    f_10546_4026_4043(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.IsVirtual;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 4026, 4043);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 3958, 4057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 3958, 4057);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4125, 4146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4131, 4144);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4125, 4146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4069, 4157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4069, 4157);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4225, 4246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4231, 4244);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4225, 4246);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4169, 4257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4169, 4257);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4323, 4344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4329, 4342);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4323, 4344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4269, 4355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4269, 4355);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4421, 4442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4427, 4440);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4421, 4442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4367, 4453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4367, 4453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4551, 4571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4557, 4569);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4551, 4571);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4465, 4582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4465, 4582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4690, 4737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4696, 4735);

                    return f_10546_4703_4734(_getter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4690, 4737);

                    bool
                    f_10546_4703_4734(Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineMethod
                    this_param)
                    {
                        var return_v = this_param.HasMethodBodyDependency;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 4703, 4734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4594, 4748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4594, 4748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10546, 4856, 4941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10546, 4862, 4939);

                    return f_10546_4869_4938(((ISynthesizedMethodBodyImplementationSymbol)f_10546_4914_4930()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10546, 4856, 4941);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10546_4914_4930()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 4914, 4930);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                    f_10546_4869_4938(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 4869, 4938);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10546, 4760, 4952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 4760, 4952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedStateMachineProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10546, 475, 4959);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10546, 475, 4959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10546, 475, 4959);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10546, 475, 4959);

        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10546_924_964(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.AssociatedSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 924, 964);
            return return_v;
        }


        string
        f_10546_924_969(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 924, 969);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10546_971_1009(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 971, 1009);
            return return_v;
        }


        string
        f_10546_885_1035(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        explicitInterfaceTypeOpt, string
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberName(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)explicitInterfaceTypeOpt, aliasQualifierOpt: aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10546, 885, 1035);
            return return_v;
        }


        string
        f_10546_1106_1134(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 1106, 1134);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10546_1136_1174(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10546, 1136, 1174);
            return return_v;
        }


        string
        f_10546_1067_1200(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        explicitInterfaceTypeOpt, string
        aliasQualifierOpt)
        {
            var return_v = ExplicitInterfaceHelpers.GetMemberName(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)explicitInterfaceTypeOpt, aliasQualifierOpt: aliasQualifierOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10546, 1067, 1200);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod
        f_10546_1227_1473(string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        interfaceMethod, Microsoft.CodeAnalysis.CSharp.StateMachineTypeSymbol
        stateMachineType, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStateMachineProperty
        associatedProperty, bool
        hasMethodBodyDependency)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedStateMachineDebuggerHiddenMethod(name, interfaceMethod, stateMachineType, associatedProperty: (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)associatedProperty, hasMethodBodyDependency: hasMethodBodyDependency);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10546, 1227, 1473);
            return return_v;
        }

    }
}
