// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        internal sealed class AnonymousTypeParameterSymbol : TypeParameterSymbol
        {
            private readonly Symbol _container;

            private readonly int _ordinal;

            private readonly string _name;

            public AnonymousTypeParameterSymbol(Symbol container, int ordinal, string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10431, 795, 1133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 680, 690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 726, 734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 773, 778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 907, 947);

                    f_10431_907_946((object)container != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 965, 1007);

                    f_10431_965_1006(!f_10431_979_1005(name));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1027, 1050);

                    _container = container;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1068, 1087);

                    _ordinal = ordinal;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1105, 1118);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10431, 795, 1133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 795, 1133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 795, 1133);
                }
            }

            public override TypeParameterKind TypeParameterKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 1233, 1326);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1277, 1307);

                        return TypeParameterKind.Type;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 1233, 1326);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1149, 1341);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1149, 1341);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 1440, 1486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1446, 1484);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 1440, 1486);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1357, 1501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1357, 1501);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 1623, 1731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1667, 1712);

                        return ImmutableArray<SyntaxReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 1623, 1731);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1517, 1746);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1517, 1746);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Ordinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 1822, 1846);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1828, 1844);

                        return _ordinal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 1822, 1846);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1762, 1861);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1762, 1861);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 1937, 1958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 1943, 1956);

                        return _name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 1937, 1958);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1877, 1973);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1877, 1973);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasConstructorConstraint
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2067, 2088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2073, 2086);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2067, 2088);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 1989, 2103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 1989, 2103);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasReferenceTypeConstraint
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2199, 2220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2205, 2218);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2199, 2220);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2119, 2235);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2119, 2235);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsReferenceTypeFromConstraintTypes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2339, 2360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2345, 2358);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2339, 2360);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2251, 2375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2251, 2375);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool? ReferenceTypeConstraintIsNullable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2481, 2502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2487, 2500);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2481, 2502);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2391, 2517);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2391, 2517);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasNotNullConstraint
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2575, 2583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2578, 2583);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2575, 2583);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2575, 2583);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2575, 2583);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool? IsNotNullable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2638, 2645);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2641, 2645);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2638, 2645);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2638, 2645);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2638, 2645);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasValueTypeConstraint
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2738, 2759);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2744, 2757);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2738, 2759);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2662, 2774);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2662, 2774);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsValueTypeFromConstraintTypes
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 2874, 2895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 2880, 2893);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 2874, 2895);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2790, 2910);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2790, 2910);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool HasUnmanagedTypeConstraint
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3006, 3027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3012, 3025);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3006, 3027);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 2926, 3042);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 2926, 3042);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsImplicitlyDeclared
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3132, 3152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3138, 3150);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3132, 3152);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3058, 3167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3058, 3167);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override VarianceKind Variance
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3253, 3286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3259, 3284);

                        return VarianceKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3253, 3286);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3183, 3301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3183, 3301);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void EnsureAllConstraintsAreResolved()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3317, 3403);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3317, 3403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3317, 3403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3317, 3403);
                }
            }

            internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3419, 3630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3566, 3615);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3419, 3630);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3419, 3630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3419, 3630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3718, 3744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3724, 3742);

                        return _container;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3718, 3744);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3646, 3759);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3646, 3759);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3775, 3973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 3913, 3958);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3775, 3973);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3775, 3973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3775, 3973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 3989, 4146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 4119, 4131);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 3989, 4146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 3989, 4146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 3989, 4146);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10431, 4162, 4311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10431, 4284, 4296);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10431, 4162, 4311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10431, 4162, 4311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 4162, 4311);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AnonymousTypeParameterSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10431, 559, 4322);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10431, 559, 4322);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10431, 559, 4322);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10431, 559, 4322);

            int
            f_10431_907_946(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10431, 907, 946);
                return 0;
            }


            bool
            f_10431_979_1005(string
            value)
            {
                var return_v = string.IsNullOrEmpty(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10431, 979, 1005);
                return return_v;
            }


            int
            f_10431_965_1006(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10431, 965, 1006);
                return 0;
            }

        }
    }
}
