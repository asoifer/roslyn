// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WithMethodTypeParametersBinder : WithTypeParametersBinder
    {
        private readonly MethodSymbol _methodSymbol;

        private MultiDictionary<string, TypeParameterSymbol> _lazyTypeParameterMap;

        internal WithMethodTypeParametersBinder(MethodSymbol methodSymbol, Binder next)
        : base(f_10379_814_818_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10379, 714, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 603, 616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 680, 701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 844, 873);

                _methodSymbol = methodSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10379, 714, 884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 714, 884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 714, 884);
            }
        }

        protected override bool InExecutableBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10379, 939, 947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 942, 947);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10379, 939, 947);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 939, 947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 939, 947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10379, 1034, 1106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1070, 1091);

                    return _methodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10379, 1034, 1106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 960, 1117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 960, 1117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override MultiDictionary<string, TypeParameterSymbol> TypeParameterMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10379, 1234, 1784);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1270, 1720) || true) && (_lazyTypeParameterMap == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10379, 1270, 1720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1345, 1409);

                        var
                        result = f_10379_1358_1408()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1431, 1608);
                            foreach (var typeParameter in f_10379_1461_1489_I(f_10379_1461_1489(_methodSymbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10379, 1431, 1608);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1539, 1585);

                                f_10379_1539_1584(result, f_10379_1550_1568(typeParameter), typeParameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10379, 1431, 1608);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10379, 1, 178);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10379, 1, 178);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1632, 1701);

                        f_10379_1632_1700(ref _lazyTypeParameterMap, result, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10379, 1270, 1720);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1740, 1769);

                    return _lazyTypeParameterMap;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10379, 1234, 1784);

                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10379_1358_1408()
                    {
                        var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 1358, 1408);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10379_1461_1489(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10379, 1461, 1489);
                        return return_v;
                    }


                    string
                    f_10379_1550_1568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10379, 1550, 1568);
                        return return_v;
                    }


                    bool
                    f_10379_1539_1584(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param, string
                    k, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    v)
                    {
                        var return_v = this_param.Add(k, v);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 1539, 1584);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10379_1461_1489_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 1461, 1489);
                        return return_v;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    f_10379_1632_1700(ref Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    location1, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    value, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 1632, 1700);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 1129, 1795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 1129, 1795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override LookupOptions LookupMask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10379, 1875, 2013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 1911, 1998);

                    return LookupOptions.NamespaceAliasesOnly | LookupOptions.MustNotBeMethodTypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10379, 1875, 2013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 1807, 2024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 1807, 2024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10379, 2036, 2599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 2191, 2588) || true) && (f_10379_2195_2229(this, options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10379, 2191, 2588);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 2263, 2573);
                        foreach (var parameter in f_10379_2289_2317_I(f_10379_2289_2317(_methodSymbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10379, 2263, 2573);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 2359, 2554) || true) && (f_10379_2363_2434(originalBinder, parameter, options, result, null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10379, 2359, 2554);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10379, 2484, 2531);

                                f_10379_2484_2530(result, parameter, f_10379_2512_2526(parameter), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10379, 2359, 2554);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10379, 2263, 2573);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10379, 1, 311);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10379, 1, 311);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10379, 2191, 2588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10379, 2036, 2599);

                bool
                f_10379_2195_2229(Microsoft.CodeAnalysis.CSharp.WithMethodTypeParametersBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = this_param.CanConsiderTypeParameters(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 2195, 2229);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10379_2289_2317(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10379, 2289, 2317);
                    return return_v;
                }


                bool
                f_10379_2363_2434(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 2363, 2434);
                    return return_v;
                }


                string
                f_10379_2512_2526(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10379, 2512, 2526);
                    return return_v;
                }


                int
                f_10379_2484_2530(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 2484, 2530);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10379_2289_2317_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10379, 2289, 2317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10379, 2036, 2599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 2036, 2599);
            }
        }

        static WithMethodTypeParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10379, 477, 2606);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10379, 477, 2606);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10379, 477, 2606);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10379, 477, 2606);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10379_814_818_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10379, 714, 884);
            return return_v;
        }

    }
}
