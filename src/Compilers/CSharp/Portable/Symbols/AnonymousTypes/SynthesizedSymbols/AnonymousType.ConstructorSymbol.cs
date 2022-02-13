// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed partial class AnonymousTypeConstructorSymbol : SynthesizedMethodBase
        {
            private readonly ImmutableArray<ParameterSymbol> _parameters;

            internal AnonymousTypeConstructorSymbol(NamedTypeSymbol container, ImmutableArray<AnonymousTypePropertySymbol> properties)
            : base(f_10422_840_849_C(container), WellKnownMemberNames.InstanceConstructorName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10422, 693, 1729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 979, 1015);

                    int
                    fieldsCount = properties.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1033, 1714) || true) && (fieldsCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10422, 1033, 1714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1094, 1157);

                        ParameterSymbol[]
                        paramsArr = new ParameterSymbol[fieldsCount]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1188, 1197);
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1179, 1495) || true) && (index < fieldsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1220, 1227)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10422, 1179, 1495))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10422, 1179, 1495);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1277, 1321);

                                PropertySymbol
                                property = properties[index]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1347, 1472);

                                paramsArr[index] = f_10422_1366_1471(this, f_10422_1406_1434(property), index, RefKind.None, f_10422_1457_1470(property));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10422, 1, 317);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10422, 1, 317);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1517, 1561);

                        _parameters = f_10422_1531_1560(paramsArr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10422, 1033, 1714);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10422, 1033, 1714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1643, 1695);

                        _parameters = ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10422, 1033, 1714);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10422, 693, 1729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 693, 1729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 693, 1729);
                }
            }

            public override MethodKind MethodKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 1815, 1853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1821, 1851);

                        return MethodKind.Constructor;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 1815, 1853);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 1745, 1868);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 1745, 1868);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool ReturnsVoid
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 1949, 1969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 1955, 1967);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 1949, 1969);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 1884, 1984);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 1884, 1984);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2064, 2092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2070, 2090);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2064, 2092);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2000, 2107);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2000, 2107);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2217, 2285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2223, 2283);

                        return TypeWithAnnotations.Create(f_10422_2257_2281(f_10422_2257_2269(this)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2217, 2285);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        f_10422_2257_2269(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                        this_param)
                        {
                            var return_v = this_param.Manager;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 2257, 2269);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10422_2257_2281(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.System_Void;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 2257, 2281);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2123, 2300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2123, 2300);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2407, 2434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2413, 2432);

                        return _parameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2407, 2434);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2316, 2449);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2316, 2449);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2529, 2550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2535, 2548);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2529, 2550);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2465, 2565);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2465, 2565);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2581, 2740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2712, 2725);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2581, 2740);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2581, 2740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2581, 2740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool IsMetadataFinal
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 2827, 2903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 2871, 2884);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 2827, 2903);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2756, 2918);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2756, 2918);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10422, 3017, 3225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10422, 3167, 3206);

                        return f_10422_3174_3205(f_10422_3174_3195(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10422, 3017, 3225);

                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10422_3174_3195(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 3174, 3195);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10422_3174_3205(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 3174, 3205);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10422, 2934, 3240);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10422, 2934, 3240);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10422_1406_1434(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.TypeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 1406, 1434);
                return return_v;
            }


            string
            f_10422_1457_1470(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10422, 1457, 1470);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10422_1366_1471(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10422, 1366, 1471);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10422_1531_1560(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol[]
            items)
            {
                var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10422, 1531, 1560);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10422_840_849_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10422, 693, 1729);
                return return_v;
            }

        }
    }
}
