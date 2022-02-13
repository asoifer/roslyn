// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal class WithLambdaParametersBinder : LocalScopeBinder
    {
        protected readonly LambdaSymbol lambdaSymbol;

        protected readonly MultiDictionary<string, ParameterSymbol> parameterMap;

        private SmallDictionary<string, ParameterSymbol> _definitionMap;

        public WithLambdaParametersBinder(LambdaSymbol lambdaSymbol, Binder enclosing)
        : base(f_10378_899_908_C(enclosing))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10378, 800, 2106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 618, 630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 701, 713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 773, 787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 934, 967);

                this.lambdaSymbol = lambdaSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 981, 1048);

                this.parameterMap = f_10378_1001_1047();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1064, 1105);

                var
                parameters = f_10378_1081_1104(lambdaSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1119, 1504) || true) && (f_10378_1123_1151_M(!parameters.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1119, 1504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1185, 1215);

                    f_10378_1185_1214(parameters);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1233, 1489);
                        foreach (var parameter in f_10378_1259_1282_I(f_10378_1259_1282(lambdaSymbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1233, 1489);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1324, 1470) || true) && (f_10378_1328_1348_M(!parameter.IsDiscard))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1324, 1470);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1398, 1447);

                                f_10378_1398_1446(this.parameterMap, f_10378_1420_1434(parameter), parameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1324, 1470);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1233, 1489);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10378, 1, 257);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10378, 1, 257);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1119, 1504);
                }

                int
                f_10378_1185_1214(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                definitions)
                {
                    recordDefinitions(definitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1185, 1214);
                    return 0;
                }

                void recordDefinitions(ImmutableArray<ParameterSymbol> definitions)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 1520, 2095);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1647, 1760) || true) && (_definitionMap == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1647, 1760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1696, 1760);

                            _definitionMap = f_10378_1713_1759();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1647, 1760);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1778, 1814);

                        var
                        declarationMap = _definitionMap
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1832, 2080);
                            foreach (var s in f_10378_1850_1861_I(definitions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1832, 2080);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 1903, 2061) || true) && (f_10378_1907_1919_M(!s.IsDiscard) && (DynAbs.Tracing.TraceSender.Expression_True(10378, 1907, 1958) && !f_10378_1924_1958(declarationMap, f_10378_1951_1957(s))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 1903, 2061);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2008, 2038);

                                    f_10378_2008_2037(declarationMap, f_10378_2027_2033(s), s);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1903, 2061);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 1832, 2080);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10378, 1, 249);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10378, 1, 249);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 1520, 2095);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 1520, 2095);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 1520, 2095);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10378, 800, 2106);

                Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10378_1713_1759()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1713, 1759);
                    return return_v;
                }


                bool
                f_10378_1907_1919_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1907, 1919);
                    return return_v;
                }


                string
                f_10378_1951_1957(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1951, 1957);
                    return return_v;
                }


                bool
                f_10378_1924_1958(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1924, 1958);
                    return return_v;
                }


                string
                f_10378_2027_2033(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 2027, 2033);
                    return return_v;
                }


                int
                f_10378_2008_2037(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 2008, 2037);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10378_1850_1861_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1850, 1861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 800, 2106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 800, 2106);
            }
        }

        protected override TypeSymbol GetCurrentReturnType(out RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2118, 2301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2214, 2245);

                refKind = f_10378_2224_2244(lambdaSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2259, 2290);

                return f_10378_2266_2289(lambdaSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2118, 2301);

                Microsoft.CodeAnalysis.RefKind
                f_10378_2224_2244(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 2224, 2244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10378_2266_2289(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 2266, 2289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2118, 2301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2118, 2301);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Symbol ContainingMemberOrLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2387, 2463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2423, 2448);

                    return this.lambdaSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2387, 2463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2313, 2474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2313, 2474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNestedFunctionBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2532, 2539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2535, 2539);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2532, 2539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2532, 2539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2532, 2539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDirectlyInIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2620, 2684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2656, 2669);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2620, 2684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2552, 2695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2552, 2695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetIteratorElementType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2779, 2930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 2866, 2919);

                return TypeWithAnnotations.Create(f_10378_2900_2917(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2779, 2930);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10378_2900_2917(Microsoft.CodeAnalysis.CSharp.WithLambdaParametersBinder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 2900, 2917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2779, 2930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2779, 2930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ValidateYield(YieldStatementSyntax node, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 2942, 3214);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3058, 3203) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 3058, 3203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3108, 3188);

                    f_10378_3108_3187(diagnostics, ErrorCode.ERR_YieldInAnonMeth, node.YieldKeyword.GetLocation());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 3058, 3203);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 2942, 3214);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10378_3108_3187(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 3108, 3187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 2942, 3214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 2942, 3214);
            }
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 3226, 3914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3510, 3539);

                f_10378_3510_3538(f_10378_3523_3537(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3555, 3666) || true) && ((options & LookupOptions.NamespaceAliasesOnly) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 3555, 3666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3644, 3651);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 3555, 3666);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3682, 3903);
                    foreach (var parameterSymbol in f_10378_3714_3732_I(f_10378_3714_3732(parameterMap, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 3682, 3903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 3766, 3888);

                        f_10378_3766_3887(result, f_10378_3784_3886(originalBinder, parameterSymbol, arity, options, null, diagnose, ref useSiteDiagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 3682, 3903);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10378, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10378, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 3226, 3914);

                bool
                f_10378_3523_3537(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 3523, 3537);
                    return return_v;
                }


                int
                f_10378_3510_3538(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 3510, 3538);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                f_10378_3714_3732(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 3714, 3732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10378_3784_3886(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 3784, 3886);
                    return return_v;
                }


                int
                f_10378_3766_3887(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 3766, 3887);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                f_10378_3714_3732_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 3714, 3732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 3226, 3914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 3226, 3914);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 3926, 4478);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4081, 4467) || true) && (f_10378_4085_4113(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 4081, 4467);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4147, 4452);
                        foreach (var parameter in f_10378_4173_4196_I(f_10378_4173_4196(lambdaSymbol)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 4147, 4452);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4238, 4433) || true) && (f_10378_4242_4313(originalBinder, parameter, options, result, null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 4238, 4433);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4363, 4410);

                                f_10378_4363_4409(result, parameter, f_10378_4391_4405(parameter), 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 4238, 4433);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 4147, 4452);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10378, 1, 306);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10378, 1, 306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 4081, 4467);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 3926, 4478);

                bool
                f_10378_4085_4113(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.CanConsiderMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 4085, 4113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10378_4173_4196(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 4173, 4196);
                    return return_v;
                }


                bool
                f_10378_4242_4313(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 4242, 4313);
                    return return_v;
                }


                string
                f_10378_4391_4405(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 4391, 4405);
                    return return_v;
                }


                int
                f_10378_4363_4409(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 4363, 4409);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10378_4173_4196_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 4173, 4196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 3926, 4478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 3926, 4478);
            }
        }

        private static bool ReportConflictWithParameter(ParameterSymbol parameter, Symbol newSymbol, string name, Location newLocation, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10378, 4490, 6497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4669, 4710);

                var
                oldLocation = f_10378_4687_4706(parameter)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4724, 4905) || true) && (oldLocation == newLocation)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 4724, 4905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 4877, 4890);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 4724, 4905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5002, 5095);

                SymbolKind
                newSymbolKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10378, 5029, 5054) || (((object)newSymbol == null && DynAbs.Tracing.TraceSender.Conditional_F2(10378, 5057, 5077)) || DynAbs.Tracing.TraceSender.Conditional_F3(10378, 5080, 5094))) ? SymbolKind.Parameter : f_10378_5080_5094(newSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5111, 6308);

                switch (newSymbolKind)
                {

                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 5111, 6308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5214, 5226);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 5111, 6308);

                    case SymbolKind.Parameter:
                    case SymbolKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 5111, 6308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5516, 5590);

                        f_10378_5516_5589(                    // Error: A local or parameter named '{0}' cannot be declared in this scope because that name is used in an enclosing local scope to define a local or parameter
                                            diagnostics, ErrorCode.ERR_LocalIllegallyOverrides, newLocation, name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5612, 5624);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 5111, 6308);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 5111, 6308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 5802, 5815);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 5111, 6308);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 5111, 6308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6000, 6013);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 5111, 6308);

                    case SymbolKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 5111, 6308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6181, 6259);

                        f_10378_6181_6258(                    // The range variable '{0}' conflicts with a previous declaration of '{0}'
                                            diagnostics, ErrorCode.ERR_QueryRangeVariableOverrides, newLocation, name);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6281, 6293);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 5111, 6308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6324, 6387);

                f_10378_6324_6386(false, "what else could be defined in a lambda?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6401, 6459);

                f_10378_6401_6458(diagnostics, ErrorCode.ERR_InternalError, newLocation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6473, 6486);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10378, 4490, 6497);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10378_4687_4706(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 4687, 4706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10378_5080_5094(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 5080, 5094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10378_5516_5589(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 5516, 5589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10378_6181_6258(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 6181, 6258);
                    return return_v;
                }


                int
                f_10378_6324_6386(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 6324, 6386);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10378_6401_6458(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 6401, 6458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 4490, 6497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 4490, 6497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool EnsureSingleDefinition(Symbol symbol, string name, Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 6509, 6989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6653, 6689);

                ParameterSymbol
                existingDeclaration
                = default(ParameterSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6703, 6728);

                var
                map = _definitionMap
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6742, 6949) || true) && (map != null && (DynAbs.Tracing.TraceSender.Expression_True(10378, 6746, 6807) && f_10378_6761_6807(map, name, out existingDeclaration)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10378, 6742, 6949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6841, 6934);

                    return f_10378_6848_6933(existingDeclaration, symbol, name, location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10378, 6742, 6949);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 6965, 6978);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 6509, 6989);

                bool
                f_10378_6761_6807(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 6761, 6807);
                    return return_v;
                }


                bool
                f_10378_6848_6933(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.Symbol
                newSymbol, string
                name, Microsoft.CodeAnalysis.Location
                newLocation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ReportConflictWithParameter(parameter, newSymbol, name, newLocation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 6848, 6933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 6509, 6989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 6509, 6989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 7001, 7173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 7125, 7162);

                throw f_10378_7131_7161();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 7001, 7173);

                System.Exception
                f_10378_7131_7161()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 7131, 7161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 7001, 7173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 7001, 7173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 7185, 7379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 7331, 7368);

                throw f_10378_7337_7367();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 7185, 7379);

                System.Exception
                f_10378_7337_7367()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 7337, 7367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 7185, 7379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 7185, 7379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override uint LocalScopeDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10378, 7430, 7453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10378, 7433, 7453);
                    return Binder.TopLevelScope; DynAbs.Tracing.TraceSender.TraceExitMethod(10378, 7430, 7453);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10378, 7430, 7453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 7430, 7453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static WithLambdaParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10378, 509, 7461);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10378, 509, 7461);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10378, 509, 7461);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10378, 509, 7461);

        Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10378_1001_1047()
        {
            var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1001, 1047);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10378_1081_1104(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1081, 1104);
            return return_v;
        }


        bool
        f_10378_1123_1151_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1123, 1151);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10378_1259_1282(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1259, 1282);
            return return_v;
        }


        bool
        f_10378_1328_1348_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1328, 1348);
            return return_v;
        }


        string
        f_10378_1420_1434(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10378, 1420, 1434);
            return return_v;
        }


        bool
        f_10378_1398_1446(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        this_param, string
        k, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
        v)
        {
            var return_v = this_param.Add(k, v);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1398, 1446);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10378_1259_1282_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10378, 1259, 1282);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10378_899_908_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10378, 800, 2106);
            return return_v;
        }

    }
}
