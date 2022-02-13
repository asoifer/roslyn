// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WithClassTypeParametersBinder : WithTypeParametersBinder
    {
        private readonly NamedTypeSymbol _namedType;

        private MultiDictionary<string, TypeParameterSymbol> _lazyTypeParameterMap;

        internal WithClassTypeParametersBinder(NamedTypeSymbol container, Binder next)
        : base(f_10376_898_902_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10376, 799, 1016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 691, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 765, 786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 928, 968);

                f_10376_928_967((object)container != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 982, 1005);

                _namedType = container;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10376, 799, 1016);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10376, 799, 1016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10376, 799, 1016);
            }
        }

        internal override bool IsAccessibleHelper(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10376, 1028, 1425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1261, 1414);

                return f_10376_1268_1413(this, symbol, _namedType, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10376, 1028, 1425);

                bool
                f_10376_1268_1413(Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                throughTypeOpt, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.IsSymbolAccessibleConditional(symbol, within, throughTypeOpt, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 1268, 1413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10376, 1028, 1425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10376, 1028, 1425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override MultiDictionary<string, TypeParameterSymbol> TypeParameterMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10376, 1542, 2071);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1578, 2009) || true) && (_lazyTypeParameterMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10376, 1578, 2009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1653, 1717);

                        var
                        result = f_10376_1666_1716()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1739, 1899);
                            foreach (TypeParameterSymbol tps in f_10376_1775_1800_I(f_10376_1775_1800(_namedType)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10376, 1739, 1899);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1850, 1876);

                                f_10376_1850_1875(result, f_10376_1861_1869(tps), tps);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10376, 1739, 1899);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10376, 1, 161);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10376, 1, 161);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 1921, 1990);

                        f_10376_1921_1989(ref _lazyTypeParameterMap, result, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10376, 1578, 2009);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 2027, 2056);

                    return _lazyTypeParameterMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10376, 1542, 2071);

                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10376_1666_1716()
                    {
                        var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 1666, 1716);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10376_1775_1800(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10376, 1775, 1800);
                        return return_v;
                    }


                    string
                    f_10376_1861_1869(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10376, 1861, 1869);
                        return return_v;
                    }


                    bool
                    f_10376_1850_1875(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param, string
                    k, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    v)
                    {
                        var return_v = this_param.Add(k, v);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 1850, 1875);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10376_1775_1800_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 1775, 1800);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    f_10376_1921_1989(ref Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    location1, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 1921, 1989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10376, 1437, 2082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10376, 1437, 2082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10376, 2094, 2654);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 2249, 2643) || true) && (f_10376_2253_2287(this, options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10376, 2249, 2643);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 2321, 2628);
                        foreach (var parameter in f_10376_2347_2372_I(f_10376_2347_2372(_namedType)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10376, 2321, 2628);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 2414, 2609) || true) && (f_10376_2418_2489(originalBinder, parameter, options, result, null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10376, 2414, 2609);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10376, 2539, 2586);

                                f_10376_2539_2585(result, parameter, f_10376_2567_2581(parameter), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10376, 2414, 2609);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10376, 2321, 2628);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10376, 1, 308);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10376, 1, 308);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10376, 2249, 2643);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10376, 2094, 2654);

                bool
                f_10376_2253_2287(Microsoft.CodeAnalysis.CSharp.WithClassTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.CanConsiderTypeParameters(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 2253, 2287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10376_2347_2372(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10376, 2347, 2372);
                    return return_v;
                }


                bool
                f_10376_2418_2489(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 2418, 2489);
                    return return_v;
                }


                string
                f_10376_2567_2581(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10376, 2567, 2581);
                    return return_v;
                }


                int
                f_10376_2539_2585(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 2539, 2585);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10376_2347_2372_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 2347, 2372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10376, 2094, 2654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10376, 2094, 2654);
            }
        }

        static WithClassTypeParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10376, 563, 2661);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10376, 563, 2661);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10376, 563, 2661);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10376, 563, 2661);

        int
        f_10376_928_967(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10376, 928, 967);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10376_898_902_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10376, 799, 1016);
            return return_v;
        }

    }
}
