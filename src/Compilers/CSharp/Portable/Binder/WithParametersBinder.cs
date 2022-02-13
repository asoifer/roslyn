// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WithParametersBinder : Binder
    {
        private readonly ImmutableArray<ParameterSymbol> _parameters;

        internal WithParametersBinder(ImmutableArray<ParameterSymbol> parameters, Binder next)
        : base(f_10381_913_917_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10381, 806, 1036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 943, 986);

                f_10381_943_985(f_10381_956_984_M(!parameters.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1000, 1025);

                _parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10381, 806, 1036);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10381, 806, 1036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10381, 806, 1036);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10381, 1048, 1587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1203, 1576) || true) && (f_10381_1207_1234(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 1203, 1576);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1268, 1561);
                        foreach (var parameter in f_10381_1294_1305_I(_parameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 1268, 1561);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1347, 1542) || true) && (f_10381_1351_1422(originalBinder, parameter, options, result, null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 1347, 1542);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1472, 1519);

                                f_10381_1472_1518(result, parameter, f_10381_1500_1514(parameter), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 1347, 1542);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 1268, 1561);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10381, 1, 294);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10381, 1, 294);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 1203, 1576);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10381, 1048, 1587);

                bool
                f_10381_1207_1234(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderLocals();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 1207, 1234);
                    return return_v;
                }


                bool
                f_10381_1351_1422(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 1351, 1422);
                    return return_v;
                }


                string
                f_10381_1500_1514(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10381, 1500, 1514);
                    return return_v;
                }


                int
                f_10381_1472_1518(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 1472, 1518);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10381_1294_1305_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 1294, 1305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10381, 1048, 1587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10381, 1048, 1587);
            }
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10381, 1599, 2409);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 1883, 2036) || true) && ((options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.MustBeInvocableIfMember)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 1883, 2036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 2014, 2021);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 1883, 2036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 2052, 2081);

                f_10381_2052_2080(f_10381_2065_2079(result));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 2097, 2398);
                    foreach (ParameterSymbol parameter in f_10381_2135_2146_I(_parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 2097, 2398);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 2180, 2383) || true) && (f_10381_2184_2198(parameter) == name)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10381, 2180, 2383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10381, 2248, 2364);

                            f_10381_2248_2363(result, f_10381_2266_2362(originalBinder, parameter, arity, options, null, diagnose, ref useSiteDiagnostics));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 2180, 2383);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10381, 2097, 2398);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10381, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10381, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10381, 1599, 2409);

                bool
                f_10381_2065_2079(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10381, 2065, 2079);
                    return return_v;
                }


                int
                f_10381_2052_2080(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 2052, 2080);
                    return 0;
                }


                string
                f_10381_2184_2198(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10381, 2184, 2198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10381_2266_2362(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 2266, 2362);
                    return return_v;
                }


                int
                f_10381_2248_2363(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 2248, 2363);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10381_2135_2146_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 2135, 2146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10381, 1599, 2409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10381, 1599, 2409);
            }
        }

        static WithParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10381, 665, 2416);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10381, 665, 2416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10381, 665, 2416);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10381, 665, 2416);

        bool
        f_10381_956_984_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10381, 956, 984);
            return return_v;
        }


        int
        f_10381_943_985(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10381, 943, 985);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10381_913_917_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10381, 806, 1036);
            return return_v;
        }

    }
}
