// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        private bool ValidateLambdaParameterNameConflictsInScope(Location location, string name, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10313, 432, 654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 572, 643);

                return f_10313_579_642(this, null, location, name, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10313, 432, 654);

                bool
                f_10313_579_642(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                symbol, Microsoft.CodeAnalysis.Location
                location, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateNameConflictsInScope(symbol, location, name, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 579, 642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 432, 654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 432, 654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ValidateDeclarationNameConflictsInScope(Symbol symbol, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10313, 666, 931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 786, 826);

                Location
                location = f_10313_806_825(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 840, 920);

                return f_10313_847_919(this, symbol, location, f_10313_894_905(symbol), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10313, 666, 931);

                Microsoft.CodeAnalysis.Location
                f_10313_806_825(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetLocation(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 806, 825);
                    return return_v;
                }


                string
                f_10313_894_905(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 894, 905);
                    return return_v;
                }


                bool
                f_10313_847_919(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.Location
                location, string
                name, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateNameConflictsInScope(symbol, location, name, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 847, 919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 666, 931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 666, 931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Location GetLocation(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10313, 943, 1159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1018, 1051);

                var
                locations = f_10313_1034_1050(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1065, 1148);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10313, 1072, 1093) || ((locations.Length != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10313, 1096, 1108)) || DynAbs.Tracing.TraceSender.Conditional_F3(10313, 1111, 1147))) ? locations[0] : f_10313_1111_1144(f_10313_1111_1134(symbol))[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10313, 943, 1159);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10313_1034_1050(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 1034, 1050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10313_1111_1134(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 1111, 1134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10313_1111_1144(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 1111, 1144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 943, 1159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 943, 1159);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ValidateParameterNameConflicts(
                    ImmutableArray<TypeParameterSymbol> typeParameters,
                    ImmutableArray<ParameterSymbol> parameters,
                    bool allowShadowingNames,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10313, 1171, 3563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1442, 1480);

                PooledHashSet<string>?
                tpNames = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1494, 2257) || true) && (f_10313_1498_1530_M(!typeParameters.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 1494, 2257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1564, 1610);

                    tpNames = f_10313_1574_1609();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1628, 2242);
                        foreach (var tp in f_10313_1647_1661_I(typeParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 1628, 2242);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1703, 1722);

                            var
                            name = f_10313_1714_1721(tp)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1744, 1856) || true) && (f_10313_1748_1774(name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 1744, 1856);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1824, 1833);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 1744, 1856);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 1880, 2223) || true) && (!f_10313_1885_1902(tpNames, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 1880, 2223);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 1880, 2223);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 1880, 2223);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2069, 2223) || true) && (!allowShadowingNames)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 2069, 2223);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2143, 2200);

                                    f_10313_2143_2199(this, tp, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 2069, 2223);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 1880, 2223);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 1628, 2242);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10313, 1, 615);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10313, 1, 615);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 1494, 2257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2273, 2310);

                PooledHashSet<string>?
                pNames = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2324, 3491) || true) && (f_10313_2328_2356_M(!parameters.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 2324, 3491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2390, 2435);

                    pNames = f_10313_2399_2434();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2453, 3476);
                        foreach (var p in f_10313_2471_2481_I(parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 2453, 3476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2523, 2541);

                            var
                            name = f_10313_2534_2540(p)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2563, 2675) || true) && (f_10313_2567_2593(name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 2563, 2675);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2643, 2652);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 2563, 2675);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2699, 3019) || true) && (tpNames != null && (DynAbs.Tracing.TraceSender.Expression_True(10313, 2703, 2744) && f_10313_2722_2744(tpNames, name)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 2699, 3019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 2918, 2996);

                                f_10313_2918_2995(                        // CS0412: 'X': a parameter or local variable cannot have the same name as a method type parameter
                                                        diagnostics, ErrorCode.ERR_LocalSameNameAsTypeParam, f_10313_2974_2988(p), name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 2699, 3019);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3043, 3457) || true) && (!f_10313_3048_3064(pNames, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 3043, 3457);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3182, 3254);

                                f_10313_3182_3253(                        // The parameter name '{0}' is a duplicate
                                                        diagnostics, ErrorCode.ERR_DuplicateParamName, f_10313_3232_3246(p), name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 3043, 3457);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 3043, 3457);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3304, 3457) || true) && (!allowShadowingNames)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 3304, 3457);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3378, 3434);

                                    f_10313_3378_3433(this, p, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 3304, 3457);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 3043, 3457);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 2453, 3476);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10313, 1, 1024);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10313, 1, 1024);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 2324, 3491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3507, 3523);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(tpNames, 10313, 3507, 3522)?.Free(), 10313, 3515, 3522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3537, 3552);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(pNames, 10313, 3537, 3551)?.Free(), 10313, 3544, 3551);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10313, 1171, 3563);

                bool
                f_10313_1498_1530_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 1498, 1530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10313_1574_1609()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 1574, 1609);
                    return return_v;
                }


                string
                f_10313_1714_1721(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 1714, 1721);
                    return return_v;
                }


                bool
                f_10313_1748_1774(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 1748, 1774);
                    return return_v;
                }


                bool
                f_10313_1885_1902(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 1885, 1902);
                    return return_v;
                }


                bool
                f_10313_2143_2199(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2143, 2199);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10313_1647_1661_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 1647, 1661);
                    return return_v;
                }


                bool
                f_10313_2328_2356_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 2328, 2356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10313_2399_2434()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2399, 2434);
                    return return_v;
                }


                string
                f_10313_2534_2540(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 2534, 2540);
                    return return_v;
                }


                bool
                f_10313_2567_2593(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2567, 2593);
                    return return_v;
                }


                bool
                f_10313_2722_2744(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2722, 2744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10313_2974_2988(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = GetLocation((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2974, 2988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10313_2918_2995(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2918, 2995);
                    return return_v;
                }


                bool
                f_10313_3048_3064(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3048, 3064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10313_3232_3246(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = GetLocation((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3232, 3246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10313_3182_3253(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3182, 3253);
                    return return_v;
                }


                bool
                f_10313_3378_3433(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3378, 3433);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10313_2471_2481_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 2471, 2481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 1171, 3563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 1171, 3563);
            }
        }

        private bool ValidateNameConflictsInScope(Symbol? symbol, Location location, string name, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10313, 3691, 5083);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3832, 3924) || true) && (f_10313_3836_3862(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 3832, 3924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3896, 3909);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 3832, 3924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 3940, 4044);

                bool
                allowShadowing = f_10313_3962_4043(f_10313_3962_3973(), MessageID.IDS_FeatureNameShadowingInNestedFunctions)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4073, 4086);

                    for (Binder?
        binder = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4060, 5043) || true) && (binder != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4104, 4124)
        , binder = f_10313_4113_4124(binder), DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 4060, 5043))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 4060, 5043);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4210, 4315) || true) && (binder is InContainerBinder)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 4210, 4315);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4283, 4296);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 4210, 4315);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4335, 4374);

                        var
                        scope = binder as LocalScopeBinder
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4392, 4543) || true) && (f_10313_4396_4462_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(scope, 10313, 4396, 4462)?.EnsureSingleDefinition(symbol, name, location, diagnostics)) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 4392, 4543);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4512, 4524);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 4392, 4543);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4676, 4801) || true) && (allowShadowing && (DynAbs.Tracing.TraceSender.Expression_True(10313, 4680, 4727) && f_10313_4698_4727(binder)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 4676, 4801);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4769, 4782);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 4676, 4801);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4821, 5028) || true) && (f_10313_4825_4858(binder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 4821, 5028);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 4996, 5009);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 4821, 5028);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10313, 1, 984);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10313, 1, 984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 5059, 5072);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10313, 3691, 5083);

                bool
                f_10313_3836_3862(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3836, 3862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10313_3962_3973()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 3962, 3973);
                    return return_v;
                }


                bool
                f_10313_3962_4043(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = compilation.IsFeatureEnabled(feature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 3962, 4043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10313_4113_4124(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 4113, 4124);
                    return return_v;
                }


                bool?
                f_10313_4396_4462_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 4396, 4462);
                    return return_v;
                }


                bool
                f_10313_4698_4727(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsNestedFunctionBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 4698, 4727);
                    return return_v;
                }


                bool
                f_10313_4825_4858(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsLastBinderWithinMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10313, 4825, 4858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 3691, 5083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 3691, 5083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsLastBinderWithinMember()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10313, 5095, 5688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 5159, 5220);

                var
                containingMemberOrLambda = f_10313_5190_5219(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 5236, 5677);

                switch (f_10313_5244_5274_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingMemberOrLambda, 10313, 5244, 5274)?.Kind))
                {

                    case null:
                    case SymbolKind.NamedType:
                    case SymbolKind.Namespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 5236, 5677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 5428, 5440);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 5236, 5677);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10313, 5236, 5677);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10313, 5488, 5662);

                        return f_10313_5495_5542_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10313_5495_5536(containingMemberOrLambda), 10313, 5495, 5542)?.Kind) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10313, 5495, 5661) && f_10313_5598_5633_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10313_5598_5607(this), 10313, 5598, 5633)?.ContainingMemberOrLambda) != containingMemberOrLambda);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10313, 5236, 5677);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10313, 5095, 5688);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10313_5190_5219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5190, 5219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10313_5244_5274_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5244, 5274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10313_5495_5536(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5495, 5536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10313_5495_5542_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5495, 5542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10313_5598_5607(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5598, 5607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10313_5598_5633_M(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10313, 5598, 5633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10313, 5095, 5688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10313, 5095, 5688);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
