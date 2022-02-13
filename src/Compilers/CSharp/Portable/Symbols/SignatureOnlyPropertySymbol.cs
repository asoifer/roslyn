// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SignatureOnlyPropertySymbol : PropertySymbol
    {
        private readonly string _name;

        private readonly TypeSymbol _containingType;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private readonly RefKind _refKind;

        private readonly TypeWithAnnotations _type;

        private readonly ImmutableArray<CustomModifier> _refCustomModifiers;

        private readonly bool _isStatic;

        private readonly ImmutableArray<PropertySymbol> _explicitInterfaceImplementations;

        public SignatureOnlyPropertySymbol(
                    string name,
                    TypeSymbol containingType,
                    ImmutableArray<ParameterSymbol> parameters,
                    RefKind refKind,
                    TypeWithAnnotations type,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    bool isStatic,
                    ImmutableArray<PropertySymbol> explicitInterfaceImplementations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10154, 1202, 1981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 750, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 794, 809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 916, 924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1088, 1097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1624, 1643);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1657, 1670);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1684, 1725);

                _refCustomModifiers = refCustomModifiers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1739, 1760);

                _isStatic = isStatic;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1774, 1799);

                _parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1813, 1896);

                _explicitInterfaceImplementations = explicitInterfaceImplementations.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1910, 1943);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 1957, 1970);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10154, 1202, 1981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 1202, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 1202, 1981);
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2027, 2051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2033, 2049);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2027, 2051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 1993, 2053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 1993, 2053);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2123, 2144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2129, 2142);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2123, 2144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2065, 2146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2065, 2146);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2226, 2261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2232, 2259);

                    return _refCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2226, 2261);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2158, 2263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2158, 2263);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2307, 2332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2313, 2330);

                    return _isStatic;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2307, 2332);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2275, 2334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2275, 2334);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2407, 2434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2413, 2432);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2407, 2434);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2346, 2436);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2346, 2436);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2530, 2579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2536, 2577);

                    return _explicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2530, 2579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2448, 2581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2448, 2581);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2635, 2666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2641, 2664);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2635, 2666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2593, 2668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2593, 2668);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2710, 2731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2716, 2729);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2710, 2731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2680, 2733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2680, 2733);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2842, 2887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2848, 2885);

                    throw f_10154_2854_2884();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2842, 2887);

                    System.Exception
                    f_10154_2854_2884()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 2854, 2884);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2802, 2889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2802, 2889);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 2961, 3006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 2967, 3004);

                    throw f_10154_2973_3003();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 2961, 3006);

                    System.Exception
                    f_10154_2973_3003()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 2973, 3003);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 2901, 3008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 2901, 3008);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3073, 3118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3079, 3116);

                    throw f_10154_3085_3115();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3073, 3118);

                    System.Exception
                    f_10154_3085_3115()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3085, 3115);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3020, 3120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3020, 3120);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3208, 3253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3214, 3251);

                    throw f_10154_3220_3250();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3208, 3253);

                    System.Exception
                    f_10154_3220_3250()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3220, 3250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3132, 3255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3132, 3255);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3321, 3366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3327, 3364);

                    throw f_10154_3333_3363();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3321, 3366);

                    System.Exception
                    f_10154_3333_3363()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3333, 3363);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3267, 3368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3267, 3368);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3413, 3458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3419, 3456);

                    throw f_10154_3425_3455();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3413, 3458);

                    System.Exception
                    f_10154_3425_3455()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3425, 3455);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3380, 3460);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3380, 3460);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3504, 3512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3507, 3512);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3504, 3512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3504, 3512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3504, 3512);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3559, 3604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3565, 3602);

                    throw f_10154_3571_3601();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3559, 3604);

                    System.Exception
                    f_10154_3571_3601()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3571, 3601);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3525, 3606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3525, 3606);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3650, 3695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3656, 3693);

                    throw f_10154_3662_3692();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3650, 3695);

                    System.Exception
                    f_10154_3662_3692()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3662, 3692);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3618, 3697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3618, 3697);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3741, 3786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3747, 3784);

                    throw f_10154_3753_3783();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3741, 3786);

                    System.Exception
                    f_10154_3753_3783()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3753, 3783);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3709, 3788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3709, 3788);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3864, 3909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3870, 3907);

                    throw f_10154_3876_3906();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3864, 3909);

                    System.Exception
                    f_10154_3876_3906()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3876, 3906);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3800, 3911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3800, 3911);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 3975, 4020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 3981, 4018);

                    throw f_10154_3987_4017();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 3975, 4020);

                    System.Exception
                    f_10154_3987_4017()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 3987, 4017);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 3923, 4022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 3923, 4022);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 4084, 4129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 4090, 4127);

                    throw f_10154_4096_4126();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 4084, 4129);

                    System.Exception
                    f_10154_4096_4126()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 4096, 4126);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 4034, 4131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 4034, 4131);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 4192, 4237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 4198, 4235);

                    throw f_10154_4204_4234();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 4192, 4237);

                    System.Exception
                    f_10154_4204_4234()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 4204, 4234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 4143, 4239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 4143, 4239);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 4292, 4337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 4298, 4335);

                    throw f_10154_4304_4334();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 4292, 4337);

                    System.Exception
                    f_10154_4304_4334()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 4304, 4334);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 4251, 4339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 4251, 4339);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 4392, 4437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 4398, 4435);

                    throw f_10154_4404_4434();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 4392, 4437);

                    System.Exception
                    f_10154_4404_4434()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 4404, 4434);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 4351, 4439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 4351, 4439);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10154, 4484, 4529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10154, 4490, 4527);

                    throw f_10154_4496_4526();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10154, 4484, 4529);

                    System.Exception
                    f_10154_4496_4526()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10154, 4496, 4526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10154, 4451, 4531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 4451, 4531);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SignatureOnlyPropertySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10154, 643, 4598);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10154, 643, 4598);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10154, 643, 4598);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10154, 643, 4598);
    }
}
