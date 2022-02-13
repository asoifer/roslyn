// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class ErrorTypeSymbol
    {
        protected sealed class ErrorTypeParameterSymbol : TypeParameterSymbol
        {
            private readonly ErrorTypeSymbol _container;

            private readonly string _name;

            private readonly int _ordinal;

            public ErrorTypeParameterSymbol(ErrorTypeSymbol container, string name, int ordinal)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10106, 660, 883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 545, 555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 594, 599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 635, 643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 777, 800);

                    _container = container;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 818, 831);

                    _name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 849, 868);

                    _ordinal = ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10106, 660, 883);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 660, 883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 660, 883);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 959, 1035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1003, 1016);

                        return _name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 959, 1035);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 899, 1050);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 899, 1050);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeParameterKind TypeParameterKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 1150, 1243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1194, 1224);

                        return TypeParameterKind.Type;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 1150, 1243);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 1066, 1258);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 1066, 1258);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 1346, 1427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1390, 1408);

                        return _container;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 1346, 1427);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 1274, 1442);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 1274, 1442);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 1536, 1612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1580, 1593);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 1536, 1612);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 1458, 1627);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 1458, 1627);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 1723, 1799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1767, 1780);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 1723, 1799);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 1643, 1814);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 1643, 1814);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 1918, 1994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 1962, 1975);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 1918, 1994);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 1830, 2009);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 1830, 2009);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2115, 2191);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2159, 2172);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2115, 2191);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2025, 2206);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2025, 2206);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2264, 2272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2267, 2272);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2264, 2272);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2264, 2272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2264, 2272);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2327, 2334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2330, 2334);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2327, 2334);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2327, 2334);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2327, 2334);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2427, 2503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2471, 2484);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2427, 2503);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2351, 2518);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2351, 2518);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2618, 2694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2662, 2675);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2618, 2694);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2534, 2709);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2534, 2709);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2805, 2881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 2849, 2862);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2805, 2881);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2725, 2896);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2725, 2896);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 2972, 3051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 3016, 3032);

                        return _ordinal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 2972, 3051);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 2912, 3066);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 2912, 3066);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 3165, 3266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 3209, 3247);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 3165, 3266);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 3082, 3281);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 3082, 3281);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 3403, 3511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 3447, 3492);

                        return ImmutableArray<SyntaxReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 3403, 3511);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 3297, 3526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 3297, 3526);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 3612, 3700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 3656, 3681);

                        return VarianceKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 3612, 3700);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 3542, 3715);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 3542, 3715);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 3805, 3880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 3849, 3861);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 3805, 3880);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 3731, 3895);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 3731, 3895);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void EnsureAllConstraintsAreResolved()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 3911, 3997);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 3911, 3997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 3911, 3997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 3911, 3997);
                }
            }

            internal override ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4013, 4224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 4160, 4209);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4013, 4224);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4013, 4224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4013, 4224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4240, 4438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 4378, 4423);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4240, 4438);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4240, 4438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4240, 4438);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol? GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4454, 4612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 4585, 4597);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4454, 4612);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4454, 4612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4454, 4612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TypeSymbol? GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4628, 4778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 4751, 4763);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4628, 4778);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4628, 4778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4628, 4778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4794, 4931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 4860, 4916);

                    return f_10106_4867_4915(f_10106_4880_4904(_container), _ordinal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4794, 4931);

                    int
                    f_10106_4880_4904(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10106, 4880, 4904);
                        return return_v;
                    }


                    int
                    f_10106_4867_4915(int
                    newKey, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKey, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10106, 4867, 4915);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4794, 4931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4794, 4931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool Equals(TypeSymbol? t2, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10106, 4947, 5417);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 5053, 5155) || true) && (f_10106_5057_5082(this, t2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10106, 5053, 5155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 5124, 5136);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10106, 5053, 5155);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 5175, 5218);

                    var
                    other = t2 as ErrorTypeParameterSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10106, 5236, 5402);

                    return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10106, 5243, 5316) && other._ordinal == _ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(10106, 5243, 5401) && f_10106_5341_5401(f_10106_5341_5361(other), f_10106_5369_5388(this), comparison));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10106, 4947, 5417);

                    bool
                    f_10106_5057_5082(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol.ErrorTypeParameterSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10106, 5057, 5082);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10106_5341_5361(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol.ErrorTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10106, 5341, 5361);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10106_5369_5388(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol.ErrorTypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10106, 5369, 5388);
                        return return_v;
                    }


                    bool
                    f_10106_5341_5401(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    t2, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10106, 5341, 5401);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10106, 4947, 5417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 4947, 5417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ErrorTypeParameterSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10106, 418, 5428);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10106, 418, 5428);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10106, 418, 5428);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10106, 418, 5428);
        }
    }
}
