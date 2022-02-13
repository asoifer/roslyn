// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public static class CompilationUtils
    {
        internal static void CheckISymbols<TSymbol>(ImmutableArray<TSymbol> symbols, params string[] descriptions)
                    where TSymbol : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 937, 1571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1105, 1161);

                f_21001_1105_1160<TSymbol>(f_21001_1124_1143<TSymbol>(descriptions), symbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1177, 1308);

                string[]
                symbolDescriptions = f_21001_1207_1307<TSymbol>((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from s in symbols select s.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat), 21001, 1208, 1296)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1322, 1347);

                f_21001_1322_1346<TSymbol>(descriptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1361, 1392);

                f_21001_1361_1391<TSymbol>(symbolDescriptions);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1417, 1422);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1408, 1560) || true) && (i < f_21001_1428_1447<TSymbol>(descriptions))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1449, 1452)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 1408, 1560))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 1408, 1560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1486, 1545);

                        f_21001_1486_1544<TSymbol>(symbolDescriptions[i], descriptions[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 937, 1571);

                int
                f_21001_1124_1143<TSymbol>(string[]
                this_param) where TSymbol : ISymbol

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 1124, 1143);
                    return return_v;
                }


                bool
                f_21001_1105_1160<TSymbol>(int
                expected, int
                actual) where TSymbol : ISymbol

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1105, 1160);
                    return return_v;
                }


                string[]
                f_21001_1207_1307<TSymbol>(System.Collections.Generic.IEnumerable<string>
                source) where TSymbol : ISymbol

                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1207, 1307);
                    return return_v;
                }


                int
                f_21001_1322_1346<TSymbol>(string[]
                array) where TSymbol : ISymbol

                {
                    Array.Sort(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1322, 1346);
                    return 0;
                }


                int
                f_21001_1361_1391<TSymbol>(string[]
                array) where TSymbol : ISymbol

                {
                    Array.Sort(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1361, 1391);
                    return 0;
                }


                int
                f_21001_1428_1447<TSymbol>(string[]
                this_param) where TSymbol : ISymbol

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 1428, 1447);
                    return return_v;
                }


                bool
                f_21001_1486_1544<TSymbol>(string
                expected, string
                actual) where TSymbol : ISymbol

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1486, 1544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 937, 1571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 937, 1571);
            }
        }

        internal static void CheckSymbols<TSymbol>(ImmutableArray<TSymbol> symbols, params string[] descriptions)
                    where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 1583, 2215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1749, 1805);

                f_21001_1749_1804<TSymbol>(f_21001_1768_1787<TSymbol>(descriptions), symbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1821, 1952);

                string[]
                symbolDescriptions = f_21001_1851_1951<TSymbol>((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from s in symbols select s.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat), 21001, 1852, 1940)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 1966, 1991);

                f_21001_1966_1990<TSymbol>(descriptions);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2005, 2036);

                f_21001_2005_2035<TSymbol>(symbolDescriptions);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2061, 2066);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2052, 2204) || true) && (i < f_21001_2072_2091<TSymbol>(descriptions))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2093, 2096)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 2052, 2204))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 2052, 2204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2130, 2189);

                        f_21001_2130_2188<TSymbol>(symbolDescriptions[i], descriptions[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 1583, 2215);

                int
                f_21001_1768_1787<TSymbol>(string[]
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 1768, 1787);
                    return return_v;
                }


                bool
                f_21001_1749_1804<TSymbol>(int
                expected, int
                actual) where TSymbol : Symbol

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1749, 1804);
                    return return_v;
                }


                string[]
                f_21001_1851_1951<TSymbol>(System.Collections.Generic.IEnumerable<string>
                source) where TSymbol : Symbol

                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1851, 1951);
                    return return_v;
                }


                int
                f_21001_1966_1990<TSymbol>(string[]
                array) where TSymbol : Symbol

                {
                    Array.Sort(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 1966, 1990);
                    return 0;
                }


                int
                f_21001_2005_2035<TSymbol>(string[]
                array) where TSymbol : Symbol

                {
                    Array.Sort(array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2005, 2035);
                    return 0;
                }


                int
                f_21001_2072_2091<TSymbol>(string[]
                this_param) where TSymbol : Symbol

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 2072, 2091);
                    return return_v;
                }


                bool
                f_21001_2130_2188<TSymbol>(string
                expected, string
                actual) where TSymbol : Symbol

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2130, 2188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 1583, 2215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 1583, 2215);
            }
        }

        public static void CheckSymbolsUnordered<TSymbol>(ImmutableArray<TSymbol> symbols, params string[] descriptions)
                    where TSymbol : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 2227, 2600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2401, 2457);

                f_21001_2401_2456<TSymbol>(f_21001_2420_2439<TSymbol>(descriptions), symbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2471, 2589);

                f_21001_2471_2588<TSymbol>(symbols.Select(s => s.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)), descriptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 2227, 2600);

                int
                f_21001_2420_2439<TSymbol>(string[]
                this_param) where TSymbol : ISymbol

                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 2420, 2439);
                    return return_v;
                }


                bool
                f_21001_2401_2456<TSymbol>(int
                expected, int
                actual) where TSymbol : ISymbol

                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2401, 2456);
                    return return_v;
                }


                int
                f_21001_2471_2588<TSymbol>(System.Collections.Generic.IEnumerable<string>
                actual, params string[]
                expected) where TSymbol : ISymbol

                {
                    AssertEx.SetEqual(actual, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2471, 2588);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 2227, 2600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 2227, 2600);
            }
        }

        public static void CheckSymbols<TSymbol>(TSymbol[] symbols, params string[] descriptions)
                    where TSymbol : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 2612, 2831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2763, 2820);

                f_21001_2763_2819<TSymbol>(f_21001_2777_2804<TSymbol>(symbols), descriptions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 2612, 2831);

                System.Collections.Immutable.ImmutableArray<TSymbol>
                f_21001_2777_2804<TSymbol>(TSymbol[]
                items) where TSymbol : ISymbol

                {
                    var return_v = items.AsImmutableOrNull<TSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2777, 2804);
                    return return_v;
                }


                int
                f_21001_2763_2819<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
                symbols, params string[]
                descriptions) where TSymbol : ISymbol

                {
                    CheckISymbols(symbols, descriptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2763, 2819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 2612, 2831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 2612, 2831);
            }
        }

        public static void CheckSymbol(ISymbol symbol, string description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 2843, 3047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 2934, 3036);

                f_21001_2934_3035(f_21001_2953_3021(symbol, f_21001_2976_3020()), description);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 2843, 3047);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_21001_2976_3020()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 2976, 3020);
                    return return_v;
                }


                string
                f_21001_2953_3021(Microsoft.CodeAnalysis.ISymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2953, 3021);
                    return return_v;
                }


                bool
                f_21001_2934_3035(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 2934, 3035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 2843, 3047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 2843, 3047);
            }
        }

        internal static void CheckSymbol(Symbol symbol, string description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 3059, 3264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 3151, 3253);

                f_21001_3151_3252(f_21001_3170_3238(symbol, f_21001_3193_3237()), description);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 3059, 3264);

                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_21001_3193_3237()
                {
                    var return_v = SymbolDisplayFormat.MinimallyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 3193, 3237);
                    return return_v;
                }


                string
                f_21001_3170_3238(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3170, 3238);
                    return return_v;
                }


                bool
                f_21001_3151_3252(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3151, 3252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 3059, 3264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 3059, 3264);
            }
        }

        internal static void CheckConstraints(ITypeParameterSymbol symbol, TypeParameterConstraintKind constraints, params string[] constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 3276, 3590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 3441, 3510);

                f_21001_3441_3509(constraints, f_21001_3473_3508(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 3524, 3579);

                f_21001_3524_3578(f_21001_3538_3560(symbol), constraintTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 3276, 3590);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                f_21001_3473_3508(Microsoft.CodeAnalysis.ITypeParameterSymbol
                typeParameter)
                {
                    var return_v = GetTypeParameterConstraints(typeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3473, 3508);
                    return return_v;
                }


                bool
                f_21001_3441_3509(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterConstraintKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3441, 3509);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                f_21001_3538_3560(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 3538, 3560);
                    return return_v;
                }


                int
                f_21001_3524_3578(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                symbols, params string[]
                descriptions)
                {
                    CheckISymbols(symbols, descriptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3524, 3578);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 3276, 3590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 3276, 3590);
            }
        }

        internal static void CheckReducedExtensionMethod(
                    MethodSymbol reducedMethod,
                    string reducedMethodDescription,
                    string reducedFromDescription,
                    string constructedFromDescription,
                    string reducedAndConstructedFromDescription)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 3602, 5071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 3913, 3957);

                var
                reducedFrom = f_21001_3931_3956(reducedMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 3971, 4027);

                f_21001_3971_4026(reducedMethod, reducedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4041, 4148);

                f_21001_4041_4147(f_21001_4060_4118(f_21001_4060_4110(f_21001_4060_4099(reducedMethod))[0]), f_21001_4120_4146(reducedMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4164, 4216);

                var
                constructedFrom = f_21001_4186_4215(reducedMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4230, 4285);

                f_21001_4230_4284(reducedMethod, constructedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4301, 4361);

                var
                reducedAndConstructedFrom = f_21001_4333_4360(constructedFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4375, 4447);

                f_21001_4375_4446(constructedFrom, reducedAndConstructedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4461, 4519);

                f_21001_4461_4518(reducedFrom, reducedAndConstructedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4535, 4596);

                var
                constructedAndExtendedFrom = f_21001_4568_4595(reducedFrom)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4610, 4674);

                f_21001_4610_4673(reducedFrom, constructedAndExtendedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4690, 4743);

                f_21001_4690_4742(reducedMethod, reducedMethodDescription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4757, 4806);

                f_21001_4757_4805(reducedFrom, reducedFromDescription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4820, 4877);

                f_21001_4820_4876(constructedFrom, constructedFromDescription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4891, 4968);

                f_21001_4891_4967(reducedAndConstructedFrom, reducedAndConstructedFromDescription);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 4982, 5060);

                f_21001_4982_5059(constructedAndExtendedFrom, reducedAndConstructedFromDescription);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 3602, 5071);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_21001_3931_3956(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReducedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 3931, 3956);
                    return return_v;
                }


                int
                f_21001_3971_4026(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                reducedMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                reducedFrom)
                {
                    CheckReducedExtensionMethod(reducedMethod, reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 3971, 4026);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_21001_4060_4099(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.CallsiteReducedFromMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4060, 4099);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_21001_4060_4110(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4060, 4110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21001_4060_4118(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4060, 4118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_21001_4120_4146(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReceiverType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4120, 4146);
                    return return_v;
                }


                bool
                f_21001_4041_4147(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4041, 4147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_21001_4186_4215(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4186, 4215);
                    return return_v;
                }


                int
                f_21001_4230_4284(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructedMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructedFrom)
                {
                    CheckConstructedMethod(constructedMethod, constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4230, 4284);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_21001_4333_4360(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReducedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4333, 4360);
                    return return_v;
                }


                int
                f_21001_4375_4446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                reducedMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                reducedFrom)
                {
                    CheckReducedExtensionMethod(reducedMethod, reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4375, 4446);
                    return 0;
                }


                bool
                f_21001_4461_4518(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4461, 4518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_21001_4568_4595(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 4568, 4595);
                    return return_v;
                }


                int
                f_21001_4610_4673(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructedMethod, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructedFrom)
                {
                    CheckConstructedMethod(constructedMethod, constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4610, 4673);
                    return 0;
                }


                int
                f_21001_4690_4742(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, string
                description)
                {
                    CheckSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4690, 4742);
                    return 0;
                }


                int
                f_21001_4757_4805(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, string
                description)
                {
                    CheckSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4757, 4805);
                    return 0;
                }


                int
                f_21001_4820_4876(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, string
                description)
                {
                    CheckSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4820, 4876);
                    return 0;
                }


                int
                f_21001_4891_4967(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, string
                description)
                {
                    CheckSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4891, 4967);
                    return 0;
                }


                int
                f_21001_4982_5059(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, string
                description)
                {
                    CheckSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 4982, 5059);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 3602, 5071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 3602, 5071);
            }
        }

        public static void CheckReducedExtensionMethod(IMethodSymbol reducedMethod, IMethodSymbol reducedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 5083, 5950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5210, 5244);

                f_21001_5210_5243(reducedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5258, 5317);

                f_21001_5258_5316(f_21001_5277_5302(reducedMethod), reducedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5331, 5374);

                f_21001_5331_5373(f_21001_5349_5372(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5390, 5439);

                f_21001_5390_5438(f_21001_5408_5437(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5453, 5504);

                f_21001_5453_5503(f_21001_5471_5502(reducedMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5518, 5607);

                f_21001_5518_5606(f_21001_5537_5571(reducedMethod), f_21001_5573_5605(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5621, 5712);

                f_21001_5621_5711(f_21001_5640_5675(reducedMethod), f_21001_5677_5710(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5728, 5769);

                int
                n = f_21001_5736_5768(reducedMethod.Parameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5783, 5841);

                f_21001_5783_5840(f_21001_5802_5832(reducedFrom.Parameters), n + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5857, 5892);

                f_21001_5857_5891(reducedMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 5906, 5939);

                f_21001_5906_5938(reducedFrom);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 5083, 5950);

                bool
                f_21001_5210_5243(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5210, 5243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_5277_5302(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReducedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5277, 5302);
                    return return_v;
                }


                bool
                f_21001_5258_5316(Microsoft.CodeAnalysis.IMethodSymbol?
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5258, 5316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_5349_5372(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReducedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5349, 5372);
                    return return_v;
                }


                bool
                f_21001_5331_5373(Microsoft.CodeAnalysis.IMethodSymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5331, 5373);
                    return return_v;
                }


                bool
                f_21001_5408_5437(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5408, 5437);
                    return return_v;
                }


                bool
                f_21001_5390_5438(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5390, 5438);
                    return return_v;
                }


                bool
                f_21001_5471_5502(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5471, 5502);
                    return return_v;
                }


                bool
                f_21001_5453_5503(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5453, 5503);
                    return return_v;
                }


                bool
                f_21001_5537_5571(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5537, 5571);
                    return return_v;
                }


                bool
                f_21001_5573_5605(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5573, 5605);
                    return return_v;
                }


                bool
                f_21001_5518_5606(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5518, 5606);
                    return return_v;
                }


                bool
                f_21001_5640_5675(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CanBeReferencedByName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5640, 5675);
                    return return_v;
                }


                bool
                f_21001_5677_5710(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CanBeReferencedByName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 5677, 5710);
                    return return_v;
                }


                bool
                f_21001_5621_5711(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5621, 5711);
                    return return_v;
                }


                int
                f_21001_5736_5768(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.IParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5736, 5768);
                    return return_v;
                }


                int
                f_21001_5802_5832(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.IParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5802, 5832);
                    return return_v;
                }


                bool
                f_21001_5783_5840(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5783, 5840);
                    return return_v;
                }


                int
                f_21001_5857_5891(Microsoft.CodeAnalysis.IMethodSymbol
                method)
                {
                    CheckTypeParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5857, 5891);
                    return 0;
                }


                int
                f_21001_5906_5938(Microsoft.CodeAnalysis.IMethodSymbol
                method)
                {
                    CheckTypeParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 5906, 5938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 5083, 5950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 5083, 5950);
            }
        }

        internal static void CheckReducedExtensionMethod(MethodSymbol reducedMethod, MethodSymbol reducedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 5962, 6192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6089, 6181);

                f_21001_6089_6180(f_21001_6117_6148(reducedMethod), f_21001_6150_6179(reducedFrom));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 5962, 6192);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_6117_6148(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6117, 6148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_6150_6179(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6150, 6179);
                    return return_v;
                }


                int
                f_21001_6089_6180(Microsoft.CodeAnalysis.IMethodSymbol
                reducedMethod, Microsoft.CodeAnalysis.IMethodSymbol
                reducedFrom)
                {
                    CheckReducedExtensionMethod(reducedMethod, reducedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6089, 6180);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 5962, 6192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 5962, 6192);
            }
        }

        public static void CheckConstructedMethod(IMethodSymbol constructedMethod, IMethodSymbol constructedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 6204, 6831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6334, 6372);

                f_21001_6334_6371(constructedFrom);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6388, 6458);

                f_21001_6388_6457(constructedFrom, f_21001_6423_6456(constructedMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6472, 6545);

                f_21001_6472_6544(constructedFrom, f_21001_6507_6543(constructedMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6561, 6629);

                f_21001_6561_6628(constructedFrom, f_21001_6596_6627(constructedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6643, 6714);

                f_21001_6643_6713(constructedFrom, f_21001_6678_6712(constructedFrom));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6730, 6769);

                f_21001_6730_6768(constructedMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6783, 6820);

                f_21001_6783_6819(constructedFrom);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 6204, 6831);

                bool
                f_21001_6334_6371(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6334, 6371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_21001_6423_6456(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 6423, 6456);
                    return return_v;
                }


                bool
                f_21001_6388_6457(Microsoft.CodeAnalysis.IMethodSymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6388, 6457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_21001_6507_6543(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 6507, 6543);
                    return return_v;
                }


                bool
                f_21001_6472_6544(Microsoft.CodeAnalysis.IMethodSymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6472, 6544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_21001_6596_6627(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 6596, 6627);
                    return return_v;
                }


                bool
                f_21001_6561_6628(Microsoft.CodeAnalysis.IMethodSymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6561, 6628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_21001_6678_6712(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 6678, 6712);
                    return return_v;
                }


                bool
                f_21001_6643_6713(Microsoft.CodeAnalysis.IMethodSymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6643, 6713);
                    return return_v;
                }


                int
                f_21001_6730_6768(Microsoft.CodeAnalysis.IMethodSymbol
                method)
                {
                    CheckTypeParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6730, 6768);
                    return 0;
                }


                int
                f_21001_6783_6819(Microsoft.CodeAnalysis.IMethodSymbol
                method)
                {
                    CheckTypeParameters(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6783, 6819);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 6204, 6831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 6204, 6831);
            }
        }

        internal static void CheckConstructedMethod(MethodSymbol constructedMethod, MethodSymbol constructedFrom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 6843, 7079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 6973, 7068);

                f_21001_6973_7067(f_21001_6996_7031(constructedMethod), f_21001_7033_7066(constructedFrom));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 6843, 7079);

                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_6996_7031(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6996, 7031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_7033_7066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 7033, 7066);
                    return return_v;
                }


                int
                f_21001_6973_7067(Microsoft.CodeAnalysis.IMethodSymbol
                constructedMethod, Microsoft.CodeAnalysis.IMethodSymbol
                constructedFrom)
                {
                    CheckConstructedMethod(constructedMethod, constructedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 6973, 7067);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 6843, 7079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 6843, 7079);
            }
        }

        private static void CheckTypeParameters(IMethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 7091, 7478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7177, 7222);

                var
                constructedFrom = f_21001_7199_7221(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7236, 7274);

                f_21001_7236_7273(constructedFrom);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7290, 7467);
                    foreach (var typeParameter in f_21001_7320_7341_I(f_21001_7320_7341(method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 7290, 7467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7375, 7452);

                        f_21001_7375_7451(f_21001_7403_7433(typeParameter), constructedFrom);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 7290, 7467);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 7091, 7478);

                Microsoft.CodeAnalysis.IMethodSymbol
                f_21001_7199_7221(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 7199, 7221);
                    return return_v;
                }


                bool
                f_21001_7236_7273(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 7236, 7273);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                f_21001_7320_7341(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 7320, 7341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_21001_7403_7433(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 7403, 7433);
                    return return_v;
                }


                bool
                f_21001_7375_7451(Microsoft.CodeAnalysis.ISymbol
                expected, Microsoft.CodeAnalysis.IMethodSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal<ISymbol>(expected, (Microsoft.CodeAnalysis.ISymbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 7375, 7451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                f_21001_7320_7341_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 7320, 7341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 7091, 7478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 7091, 7478);
            }
        }

        internal static TypeParameterConstraintKind GetTypeParameterConstraints(ITypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 7490, 8197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7622, 7673);

                var
                constraints = TypeParameterConstraintKind.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7687, 7833) || true) && (f_21001_7691_7729(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 7687, 7833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7763, 7818);

                    constraints |= TypeParameterConstraintKind.Constructor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 7687, 7833);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7847, 7997) || true) && (f_21001_7851_7891(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 7847, 7997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 7925, 7982);

                    constraints |= TypeParameterConstraintKind.ReferenceType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 7847, 7997);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8011, 8153) || true) && (f_21001_8015_8051(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 8011, 8153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8085, 8138);

                    constraints |= TypeParameterConstraintKind.ValueType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 8011, 8153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8167, 8186);

                return constraints;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 7490, 8197);

                bool
                f_21001_7691_7729(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 7691, 7729);
                    return return_v;
                }


                bool
                f_21001_7851_7891(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 7851, 7891);
                    return return_v;
                }


                bool
                f_21001_8015_8051(Microsoft.CodeAnalysis.ITypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 8015, 8051);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 7490, 8197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 7490, 8197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeParameterConstraintKind GetTypeParameterConstraints(TypeParameterSymbol typeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 8209, 8915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8340, 8391);

                var
                constraints = TypeParameterConstraintKind.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8405, 8551) || true) && (f_21001_8409_8447(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 8405, 8551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8481, 8536);

                    constraints |= TypeParameterConstraintKind.Constructor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 8405, 8551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8565, 8715) || true) && (f_21001_8569_8609(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 8565, 8715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8643, 8700);

                    constraints |= TypeParameterConstraintKind.ReferenceType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 8565, 8715);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8729, 8871) || true) && (f_21001_8733_8769(typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 8729, 8871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8803, 8856);

                    constraints |= TypeParameterConstraintKind.ValueType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 8729, 8871);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8885, 8904);

                return constraints;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 8209, 8915);

                bool
                f_21001_8409_8447(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasConstructorConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 8409, 8447);
                    return return_v;
                }


                bool
                f_21001_8569_8609(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 8569, 8609);
                    return return_v;
                }


                bool
                f_21001_8733_8769(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 8733, 8769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 8209, 8915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 8209, 8915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        public class SemanticInfoSummary
        {
            public ISymbol Symbol;

            public CandidateReason CandidateReason;

            public ImmutableArray<ISymbol> CandidateSymbols;

            public ITypeSymbol Type;

            public NullabilityInfo Nullability;

            public ITypeSymbol ConvertedType;

            public NullabilityInfo ConvertedNullability;

            public Conversion ImplicitConversion;

            public IAliasSymbol Alias;

            public Optional<object> ConstantValue;

            public bool IsCompileTimeConstant
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 9591, 9629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9597, 9627);

                        return ConstantValue.HasValue;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 9591, 9629);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 9555, 9631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 9555, 9631);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public ImmutableArray<ISymbol> MemberGroup;

            public ImmutableArray<IMethodSymbol> MethodGroup
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 9820, 9936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9826, 9934);

                        return this.MemberGroup.WhereAsArray(s => s.Kind == SymbolKind.Method).SelectAsArray(s => (IMethodSymbol)s);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 9820, 9936);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 9739, 9951);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 9739, 9951);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public SemanticInfoSummary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21001, 8927, 9962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 8999, 9005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9043, 9058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9104, 9155);
                this.CandidateSymbols = f_21001_9123_9155(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9189, 9193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9276, 9289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9380, 9420);
                this.ImplicitConversion = default(Conversion); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9455, 9460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9499, 9540);
                this.ConstantValue = default(Optional<object>); DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 9676, 9722);
                this.MemberGroup = f_21001_9690_9722(); DynAbs.Tracing.TraceSender.TraceExitConstructor(21001, 8927, 9962);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 8927, 9962);
            }


            static SemanticInfoSummary()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21001, 8927, 9962);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21001, 8927, 9962);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 8927, 9962);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21001, 8927, 9962);

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
            f_21001_9123_9155()
            {
                var return_v = ImmutableArray.Create<ISymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 9123, 9155);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
            f_21001_9690_9722()
            {
                var return_v = ImmutableArray.Create<ISymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 9690, 9722);
                return return_v;
            }

        }

        public static SemanticInfoSummary GetSemanticInfoSummary(this SemanticModel semanticModel, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 9974, 13516);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10106, 10162);

                SemanticInfoSummary
                summary = f_21001_10136_10161()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10269, 10309);

                SymbolInfo
                symbolInfo = SymbolInfo.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10323, 13124) || true) && (node is ExpressionSyntax expr)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 10323, 13124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10390, 10437);

                    symbolInfo = f_21001_10403_10436(semanticModel, expr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10455, 10516);

                    summary.ConstantValue = f_21001_10479_10515(semanticModel, expr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10534, 10581);

                    var
                    typeInfo = f_21001_10549_10580(semanticModel, expr)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10599, 10628);

                    summary.Type = typeInfo.Type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10646, 10693);

                    summary.ConvertedType = typeInfo.ConvertedType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10711, 10754);

                    summary.Nullability = typeInfo.Nullability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10772, 10833);

                    summary.ConvertedNullability = typeInfo.ConvertedNullability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10851, 10914);

                    summary.ImplicitConversion = f_21001_10880_10913(semanticModel, expr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 10932, 10989);

                    summary.MemberGroup = f_21001_10954_10988(semanticModel, expr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 10323, 13124);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 10323, 13124);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11023, 13124) || true) && (node is AttributeSyntax attribute)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11023, 13124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11094, 11146);

                        symbolInfo = f_21001_11107_11145(semanticModel, attribute);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11164, 11216);

                        var
                        typeInfo = f_21001_11179_11215(semanticModel, attribute)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11234, 11263);

                        summary.Type = typeInfo.Type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11281, 11328);

                        summary.ConvertedType = typeInfo.ConvertedType;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11346, 11414);

                        summary.ImplicitConversion = f_21001_11375_11413(semanticModel, attribute);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11432, 11494);

                        summary.MemberGroup = f_21001_11454_11493(semanticModel, attribute);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11023, 13124);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11023, 13124);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11528, 13124) || true) && (node is OrderingSyntax ordering)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11528, 13124);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11597, 11648);

                            symbolInfo = f_21001_11610_11647(semanticModel, ordering);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11528, 13124);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11528, 13124);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11682, 13124) || true) && (node is SelectOrGroupClauseSyntax selectOrGroupClause)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11682, 13124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11773, 11835);

                                symbolInfo = f_21001_11786_11834(semanticModel, selectOrGroupClause);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11682, 13124);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11682, 13124);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11869, 13124) || true) && (node is ConstructorInitializerSyntax initializer)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11869, 13124);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 11955, 12009);

                                    symbolInfo = f_21001_11968_12008(semanticModel, initializer);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12027, 12081);

                                    var
                                    typeInfo = f_21001_12042_12080(semanticModel, initializer)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12099, 12128);

                                    summary.Type = typeInfo.Type;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12146, 12193);

                                    summary.ConvertedType = typeInfo.ConvertedType;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12211, 12281);

                                    summary.ImplicitConversion = f_21001_12240_12280(semanticModel, initializer);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12299, 12363);

                                    summary.MemberGroup = f_21001_12321_12362(semanticModel, initializer);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11869, 13124);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 11869, 13124);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12397, 13124) || true) && (node is PatternSyntax pattern)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 12397, 13124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12464, 12514);

                                        symbolInfo = f_21001_12477_12513(semanticModel, pattern);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12532, 12582);

                                        var
                                        typeInfo = f_21001_12547_12581(semanticModel, pattern)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12600, 12629);

                                        summary.Type = typeInfo.Type;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12647, 12694);

                                        summary.ConvertedType = typeInfo.ConvertedType;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12712, 12755);

                                        summary.Nullability = typeInfo.Nullability;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12773, 12834);

                                        summary.ConvertedNullability = typeInfo.ConvertedNullability;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12852, 12918);

                                        summary.ImplicitConversion = f_21001_12881_12917(semanticModel, pattern);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 12936, 12996);

                                        summary.MemberGroup = f_21001_12958_12995(semanticModel, pattern);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 12397, 13124);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 12397, 13124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13062, 13109);

                                        throw f_21001_13068_13108(node);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 12397, 13124);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11869, 13124);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11682, 13124);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11528, 13124);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 11023, 13124);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 10323, 13124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13140, 13175);

                summary.Symbol = symbolInfo.Symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13189, 13242);

                summary.CandidateReason = symbolInfo.CandidateReason;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13256, 13311);

                summary.CandidateSymbols = symbolInfo.CandidateSymbols;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13327, 13474) || true) && (node is IdentifierNameSyntax identifier)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 13327, 13474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13404, 13459);

                    summary.Alias = f_21001_13420_13458(semanticModel, identifier);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 13327, 13474);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13490, 13505);

                return summary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 9974, 13516);

                Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
                f_21001_10136_10161()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10136, 10161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_10403_10436(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10403, 10436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object?>
                f_21001_10479_10515(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetConstantValue((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10479, 10515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_21001_10549_10580(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10549, 10580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_21001_10880_10913(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = semanticModel.GetConversion((Microsoft.CodeAnalysis.SyntaxNode)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10880, 10913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_10954_10988(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberGroup((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 10954, 10988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_11107_11145(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11107, 11145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_21001_11179_11215(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11179, 11215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_21001_11375_11413(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                expression)
                {
                    var return_v = semanticModel.GetConversion((Microsoft.CodeAnalysis.SyntaxNode)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11375, 11413);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_11454_11493(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetMemberGroup((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11454, 11493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_11610_11647(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11610, 11647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_11786_11834(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11786, 11834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_11968_12008(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 11968, 12008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_21001_12042_12080(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12042, 12080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_21001_12240_12280(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                expression)
                {
                    var return_v = semanticModel.GetConversion((Microsoft.CodeAnalysis.SyntaxNode)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12240, 12280);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_12321_12362(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                node)
                {
                    var return_v = this_param.GetMemberGroup((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12321, 12362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_12477_12513(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12477, 12513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_21001_12547_12581(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12547, 12581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_21001_12881_12917(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                expression)
                {
                    var return_v = semanticModel.GetConversion((Microsoft.CodeAnalysis.SyntaxNode)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12881, 12917);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_12958_12995(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PatternSyntax
                node)
                {
                    var return_v = this_param.GetMemberGroup((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 12958, 12995);
                    return return_v;
                }


                System.Exception
                f_21001_13068_13108(Microsoft.CodeAnalysis.SyntaxNode
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 13068, 13108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_21001_13420_13458(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                nameSyntax)
                {
                    var return_v = this_param.GetAliasInfo((Microsoft.CodeAnalysis.SyntaxNode)nameSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 13420, 13458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 9974, 13516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 9974, 13516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SemanticInfoSummary GetSpeculativeSemanticInfoSummary(this SemanticModel semanticModel, int position, SyntaxNode node, SpeculativeBindingOption bindingOption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 13528, 15669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13725, 13781);

                SemanticInfoSummary
                summary = f_21001_13755_13780()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13888, 13929);

                SymbolInfo
                symbolInfo = f_21001_13912_13928()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 13943, 15236) || true) && (node is ExpressionSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 13943, 15236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14005, 14052);

                    ExpressionSyntax
                    expr = (ExpressionSyntax)node
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14070, 14153);

                    symbolInfo = f_21001_14083_14152(semanticModel, position, expr, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14263, 14346);

                    var
                    typeInfo = f_21001_14278_14345(semanticModel, position, expr, bindingOption)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14364, 14393);

                    summary.Type = typeInfo.Type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14411, 14458);

                    summary.ConvertedType = typeInfo.ConvertedType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14476, 14519);

                    summary.Nullability = typeInfo.Nullability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14537, 14598);

                    summary.ConvertedNullability = typeInfo.ConvertedNullability;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14616, 14715);

                    summary.ImplicitConversion = f_21001_14645_14714(semanticModel, position, expr, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 13943, 15236);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 13943, 15236);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14837, 15236) || true) && (node is ConstructorInitializerSyntax)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 14837, 15236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14911, 14964);

                        var
                        initializer = (ConstructorInitializerSyntax)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 14982, 15057);

                        symbolInfo = f_21001_14995_15056(semanticModel, position, initializer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 14837, 15236);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 14837, 15236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15123, 15221);

                        throw f_21001_15129_15220("Type of syntax node is not supported by GetSemanticInfoSummary");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 14837, 15236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 13943, 15236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15252, 15287);

                summary.Symbol = symbolInfo.Symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15301, 15354);

                summary.CandidateReason = symbolInfo.CandidateReason;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15368, 15423);

                summary.CandidateSymbols = symbolInfo.CandidateSymbols;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15439, 15627) || true) && (node is IdentifierNameSyntax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 15439, 15627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15505, 15612);

                    summary.Alias = f_21001_15521_15611(semanticModel, position, (IdentifierNameSyntax)node, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 15439, 15627);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15643, 15658);

                return summary;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 13528, 15669);

                Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary
                f_21001_13755_13780()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.CompilationUtils.SemanticInfoSummary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 13755, 13780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_13912_13928()
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 13912, 13928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_14083_14152(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeSymbolInfo(position, (Microsoft.CodeAnalysis.SyntaxNode)expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 14083, 14152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_21001_14278_14345(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeTypeInfo(position, (Microsoft.CodeAnalysis.SyntaxNode)expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 14278, 14345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_21001_14645_14714(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = semanticModel.GetSpeculativeConversion(position, expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 14645, 14714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_21001_14995_15056(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer)
                {
                    var return_v = semanticModel.GetSpeculativeSymbolInfo(position, constructorInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 14995, 15056);
                    return return_v;
                }


                System.NotSupportedException
                f_21001_15129_15220(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 15129, 15220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_21001_15521_15611(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                nameSyntax, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeAliasInfo(position, (Microsoft.CodeAnalysis.SyntaxNode)nameSyntax, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 15521, 15611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 13528, 15669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 13528, 15669);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static List<string> LookupNames(this SemanticModel model, int position, INamespaceOrTypeSymbol container = null, bool namespacesAndTypesOnly = false, bool useBaseReferenceAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 15681, 16448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15906, 15985);

                f_21001_15906_15984(!useBaseReferenceAccessibility || (DynAbs.Tracing.TraceSender.Expression_False(21001, 15924, 15983) || (object)container == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 15999, 16076);

                f_21001_15999_16075(!useBaseReferenceAccessibility || (DynAbs.Tracing.TraceSender.Expression_False(21001, 16017, 16074) || !namespacesAndTypesOnly));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16090, 16368);

                var
                symbols = (DynAbs.Tracing.TraceSender.Conditional_F1(21001, 16104, 16133) || ((useBaseReferenceAccessibility
                && DynAbs.Tracing.TraceSender.Conditional_F2(21001, 16153, 16186)) || DynAbs.Tracing.TraceSender.Conditional_F3(21001, 16206, 16367))) ? f_21001_16153_16186(model, position) : (DynAbs.Tracing.TraceSender.Conditional_F1(21001, 16206, 16228) || ((namespacesAndTypesOnly
                && DynAbs.Tracing.TraceSender.Conditional_F2(21001, 16252, 16303)) || DynAbs.Tracing.TraceSender.Conditional_F3(21001, 16327, 16367))) ? f_21001_16252_16303(model, position, container) : f_21001_16327_16367(model, position, container)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16382, 16437);

                return f_21001_16389_16436(f_21001_16389_16427(symbols.Select(s => s.Name)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 15681, 16448);

                bool
                f_21001_15906_15984(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 15906, 15984);
                    return return_v;
                }


                bool
                f_21001_15999_16075(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 15999, 16075);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_16153_16186(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.LookupBaseMembers(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16153, 16186);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_16252_16303(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container)
                {
                    var return_v = this_param.LookupNamespacesAndTypes(position, container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16252, 16303);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_21001_16327_16367(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.INamespaceOrTypeSymbol?
                container)
                {
                    var return_v = this_param.LookupSymbols(position, container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16327, 16367);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_21001_16389_16427(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.Distinct<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16389, 16427);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_21001_16389_16436(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16389, 16436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 15681, 16448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 15681, 16448);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeInfo GetTypeInfoAndVerifyIOperation(this SemanticModel model, SyntaxNode expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 16460, 20265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16589, 16634);

                var
                typeInfo = f_21001_16604_16633(model, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16648, 16690);

                var
                iop = f_21001_16658_16689(model, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16704, 17613) || true) && (typeInfo.Type is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 16704, 17613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16763, 16797);

                    f_21001_16763_16796(iop, typeInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 16704, 17613);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 16704, 17613);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16831, 17613) || true) && (iop is { Type: { } })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 16831, 17613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 16889, 16971);

                        f_21001_16889_16970(f_21001_16908_16940(typeInfo.Type), f_21001_16942_16969(f_21001_16942_16950(iop)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 16831, 17613);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 16831, 17613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17037, 17087);

                        f_21001_17037_17086(f_21001_17055_17085(expression));

                        static bool
                        f_21001_17569_17596(Microsoft.CodeAnalysis.CSharp.Syntax.RefTypeSyntax
                        expression)
                        {
                            var return_v = isValidDeclaration((Microsoft.CodeAnalysis.SyntaxNode)expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 17569, 17596);
                            return return_v;
                        }


                        bool
                        f_21001_17055_17085(Microsoft.CodeAnalysis.SyntaxNode
                        expression)
                        {
                            var return_v = isValidDeclaration(expression);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 17055, 17085);
                            return return_v;
                        }

                        static bool isValidDeclaration(SyntaxNode expression)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 17182, 17597);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17185, 17597);
                                return (f_21001_17186_17203(expression) is VariableDeclarationSyntax decl && (DynAbs.Tracing.TraceSender.Expression_True(21001, 17186, 17264) && f_21001_17241_17250(decl) == expression)) || (DynAbs.Tracing.TraceSender.Expression_False(21001, 17185, 17376) || (f_21001_17294_17311(expression) is ForEachStatementSyntax forEach && (DynAbs.Tracing.TraceSender.Expression_True(21001, 17294, 17375) && f_21001_17349_17361(forEach) == expression))) || (DynAbs.Tracing.TraceSender.Expression_False(21001, 17185, 17494) || (f_21001_17405_17422(expression) is DeclarationExpressionSyntax declExpr && (DynAbs.Tracing.TraceSender.Expression_True(21001, 17405, 17493) && f_21001_17466_17479(declExpr) == expression))) || (DynAbs.Tracing.TraceSender.Expression_False(21001, 17185, 17597) || (f_21001_17523_17540(expression) is RefTypeSyntax refType && (DynAbs.Tracing.TraceSender.Expression_True(21001, 17523, 17596) && f_21001_17569_17596(refType)))); DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 17182, 17597);
                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 17182, 17597);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 17182, 17597);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 16831, 17613);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 16704, 17613);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17629, 17761) || true) && (iop is { Parent: IConversionOperation parentConversion })
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 17629, 17761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17723, 17746);

                    iop = parentConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 17629, 17761);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17777, 18072) || true) && (typeInfo.ConvertedType is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 17777, 18072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17845, 17874);

                    f_21001_17845_17873(f_21001_17863_17872_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(iop, 21001, 17863, 17872)?.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 17777, 18072);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 17777, 18072);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17908, 18072) || true) && (iop is { Type: { } })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 17908, 18072);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 17966, 18057);

                        f_21001_17966_18056(f_21001_17985_18026(typeInfo.ConvertedType), f_21001_18028_18055(f_21001_18028_18036(iop)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 17908, 18072);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 17777, 18072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 18088, 18104);

                return typeInfo;

                static IOperation getOperation(SemanticModel model, SyntaxNode expression)
                {
                    while (true)
                    {
                        // Nullable suppressions and parenthesized expressions are not directly represented in the bound tree.
                        // Rather, they are set as flags on the bound node underlying the node. Therefore, there is similarly
                        // no representation in the IOperation tree, and we should retrieve the IOperation node underlying
                        // the expression.
                        switch (expression)
                        {
                            case PostfixUnaryExpressionSyntax { RawKind: (int)SyntaxKind.SuppressNullableWarningExpression, Operand: { } operand }:
                                expression = operand;
                                continue;

                            case ParenthesizedExpressionSyntax { Expression: { } nested }:
                                expression = nested;
                                continue;

                            default:
                                goto getOperation;
                        }
                    }

getOperation:
                    return model.GetOperation(expression);
                }

                static void assertTypeInfoNull(IOperation iop, TypeInfo typeInfo)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 19373, 20254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 19471, 20239);

                        switch (iop)
                        {

                            case ITupleOperation { NaturalType: null }:
                            case ISwitchExpressionOperation _:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 19471, 20239);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 19975, 20069);

                                f_21001_19975_20068(f_21001_19993_20021_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_21001_19993_20001(iop), 21001, 19993, 20021)?.NullableAnnotation) == f_21001_20025_20067_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(typeInfo.ConvertedType, 21001, 20025, 20067)?.NullableAnnotation));
                                DynAbs.Tracing.TraceSender.TraceBreak(21001, 20095, 20101);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 19471, 20239);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 19471, 20239);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20159, 20188);

                                f_21001_20159_20187(f_21001_20177_20186_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(iop, 21001, 20177, 20186)?.Type));
                                DynAbs.Tracing.TraceSender.TraceBreak(21001, 20214, 20220);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 19471, 20239);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 19373, 20254);

                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_21001_19993_20001(Microsoft.CodeAnalysis.IOperation
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 19993, 20001);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.NullableAnnotation?
                        f_21001_19993_20021_M(Microsoft.CodeAnalysis.NullableAnnotation?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 19993, 20021);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.NullableAnnotation?
                        f_21001_20025_20067_M(Microsoft.CodeAnalysis.NullableAnnotation?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 20025, 20067);
                            return return_v;
                        }


                        bool
                        f_21001_19975_20068(bool
                        condition)
                        {
                            var return_v = CustomAssert.True(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 19975, 20068);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.ITypeSymbol?
                        f_21001_20177_20186_M(Microsoft.CodeAnalysis.ITypeSymbol?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 20177, 20186);
                            return return_v;
                        }


                        bool
                        f_21001_20159_20187(Microsoft.CodeAnalysis.ITypeSymbol?
                        @object)
                        {
                            var return_v = CustomAssert.Null((object?)@object);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20159, 20187);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 19373, 20254);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 19373, 20254);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 16460, 20265);

                Microsoft.CodeAnalysis.TypeInfo
                f_21001_16604_16633(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetTypeInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16604, 16633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation
                f_21001_16658_16689(Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                expression)
                {
                    var return_v = getOperation(model, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16658, 16689);
                    return return_v;
                }


                int
                f_21001_16763_16796(Microsoft.CodeAnalysis.IOperation
                iop, Microsoft.CodeAnalysis.TypeInfo
                typeInfo)
                {
                    assertTypeInfoNull(iop, typeInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16763, 16796);
                    return 0;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_21001_16908_16940(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 16908, 16940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_21001_16942_16950(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 16942, 16950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableAnnotation
                f_21001_16942_16969(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 16942, 16969);
                    return return_v;
                }


                bool
                f_21001_16889_16970(Microsoft.CodeAnalysis.NullableAnnotation
                expected, Microsoft.CodeAnalysis.NullableAnnotation
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 16889, 16970);
                    return return_v;
                }


                bool
                f_21001_17037_17086(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 17037, 17086);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxNode?
                f_21001_17186_17203(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17186, 17203);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_21001_17241_17250(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17241, 17250);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxNode?
                f_21001_17294_17311(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17294, 17311);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_21001_17349_17361(Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17349, 17361);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxNode?
                f_21001_17405_17422(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17405, 17422);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_21001_17466_17479(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17466, 17479);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SyntaxNode?
                f_21001_17523_17540(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17523, 17540);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.ITypeSymbol?
                f_21001_17863_17872_M(Microsoft.CodeAnalysis.ITypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17863, 17872);
                    return return_v;
                }


                static bool
                f_21001_17845_17873(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 17845, 17873);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.NullableAnnotation
                f_21001_17985_18026(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 17985, 18026);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.ITypeSymbol
                f_21001_18028_18036(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 18028, 18036);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.NullableAnnotation
                f_21001_18028_18055(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.NullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 18028, 18055);
                    return return_v;
                }


                static bool
                f_21001_17966_18056(Microsoft.CodeAnalysis.NullableAnnotation
                expected, Microsoft.CodeAnalysis.NullableAnnotation
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 17966, 18056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 16460, 20265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 16460, 20265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void VerifyTypes(this CSharpCompilation compilation, SyntaxTree tree = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21001, 20535, 26426);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20652, 20892) || true) && (tree == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 20652, 20892);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20702, 20850);
                        foreach (var syntaxTree in f_21001_20729_20752_I(f_21001_20729_20752(compilation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 20702, 20850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20794, 20831);

                            f_21001_20794_20830(compilation, syntaxTree);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 20702, 20850);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 149);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20870, 20877);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 20652, 20892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 20908, 21021);

                f_21001_20908_21020(f_21001_20926_21019(compilation, tree, f_21001_20990_21018(0, f_21001_21006_21017(tree))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21037, 21063);

                var
                root = f_21001_21048_21062(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21077, 21119);

                var
                allAnnotations = f_21001_21098_21118(root)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21133, 21215) || true) && (allAnnotations.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 21133, 21215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21193, 21200);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 21133, 21215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21231, 21278);

                var
                model = f_21001_21243_21277(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21292, 21446);

                var
                annotationsByMethod = f_21001_21318_21445(f_21001_21318_21435(ref allAnnotations, annotation => annotation.Expression.Ancestors().OfType<BaseMethodDeclarationSyntax>().First()))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21460, 22972);
                    foreach (var annotations in f_21001_21488_21507_I(annotationsByMethod))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 21460, 22972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21541, 21576);

                        var
                        methodSyntax = f_21001_21560_21575(annotations)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21594, 21645);

                        var
                        method = f_21001_21607_21644(model, methodSyntax)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21665, 21742);

                        var
                        expectedTypes = f_21001_21685_21741(annotations, annotation => annotation.Text)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 21760, 22769);

                        var
                        actualTypes = f_21001_21778_22768(annotations, annotation =>
                                            {
                                                var typeInfo = model.GetTypeInfoAndVerifyIOperation(annotation.Expression);
                                                CustomAssert.NotEqual(CodeAnalysis.NullableFlowState.None, typeInfo.Nullability.FlowState);
                        // https://github.com/dotnet/roslyn/issues/35035: After refactoring symboldisplay, we should be able to just call something like typeInfo.Type.ToDisplayString(typeInfo.Nullability.FlowState, TypeWithState.TestDisplayFormat)
                        var type = TypeWithState.Create(
                                                    (annotation.IsConverted ? typeInfo.ConvertedType : typeInfo.Type).GetSymbol(),
                                                    (annotation.IsConverted ? typeInfo.ConvertedNullability : typeInfo.Nullability).FlowState.ToInternalFlowState()).ToTypeWithAnnotations(compilation);
                                                return type.ToDisplayString(TypeWithAnnotations.TestDisplayFormat);
                                            })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 22875, 22957);

                        f_21001_22875_22956(expectedTypes, actualTypes, message: f_21001_22927_22955(method));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 21460, 22972);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 1513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 1513);
                }
                ImmutableArray<(ExpressionSyntax Expression, string Text, bool IsConverted)> getAnnotations(SyntaxNode rootNode)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 22988, 24687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23133, 23208);

                        var
                        builder = f_21001_23147_23207()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23226, 24618);
                            foreach (var token in f_21001_23248_23275_I(f_21001_23248_23275(rootNode)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 23226, 24618);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23317, 24599);
                                    foreach (var trivia in f_21001_23340_23360_I(token.TrailingTrivia))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 23317, 24599);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23410, 24576) || true) && (trivia.Kind() == SyntaxKind.MultiLineCommentTrivia)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 23410, 24576);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23522, 23555);

                                            var
                                            text = trivia.ToFullString()
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23585, 23618);

                                            const string
                                            typePrefix = "/*T:"
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23648, 23687);

                                            const string
                                            convertedPrefix = "/*CT:"
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23717, 23744);

                                            const string
                                            suffix = "*/"
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23774, 23830);

                                            bool
                                            startsWithTypePrefix = f_21001_23802_23829(text, typePrefix)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 23860, 24549) || true) && (f_21001_23864_23885(text, suffix) && (DynAbs.Tracing.TraceSender.Expression_True(21001, 23864, 23947) && (startsWithTypePrefix || (DynAbs.Tracing.TraceSender.Expression_False(21001, 23890, 23946) || f_21001_23914_23946(text, convertedPrefix)))))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 23860, 24549);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24013, 24078);

                                                var
                                                prefix = (DynAbs.Tracing.TraceSender.Conditional_F1(21001, 24026, 24046) || ((startsWithTypePrefix && DynAbs.Tracing.TraceSender.Conditional_F2(21001, 24049, 24059)) || DynAbs.Tracing.TraceSender.Conditional_F3(21001, 24062, 24077))) ? typePrefix : convertedPrefix
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24112, 24163);

                                                var
                                                expr = f_21001_24123_24162(token, rootNode)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24197, 24307);

                                                f_21001_24197_24306(expr != null, $"VerifyTypes could not find a matching expression for annotation '{text}'.");
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24343, 24432);

                                                var
                                                content = f_21001_24357_24431(text, f_21001_24372_24385(prefix), f_21001_24387_24398(text) - f_21001_24401_24414(prefix) - f_21001_24417_24430(suffix))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24466, 24518);

                                                f_21001_24466_24517(builder, (expr, content, !startsWithTypePrefix));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 23860, 24549);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 23410, 24576);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 23317, 24599);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 1283);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 1283);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 23226, 24618);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 1, 1393);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 1, 1393);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24636, 24672);

                        return f_21001_24643_24671(builder);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 22988, 24687);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, string, bool)>
                        f_21001_23147_23207()
                        {
                            var return_v = ArrayBuilder<(ExpressionSyntax, string, bool)>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23147, 23207);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                        f_21001_23248_23275(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.DescendantTokens();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23248, 23275);
                            return return_v;
                        }


                        bool
                        f_21001_23802_23829(string
                        this_param, string
                        value)
                        {
                            var return_v = this_param.StartsWith(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23802, 23829);
                            return return_v;
                        }


                        bool
                        f_21001_23864_23885(string
                        this_param, string
                        value)
                        {
                            var return_v = this_param.EndsWith(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23864, 23885);
                            return return_v;
                        }


                        bool
                        f_21001_23914_23946(string
                        this_param, string
                        value)
                        {
                            var return_v = this_param.StartsWith(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23914, 23946);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_21001_24123_24162(Microsoft.CodeAnalysis.SyntaxToken
                        token, Microsoft.CodeAnalysis.SyntaxNode
                        rootNode)
                        {
                            var return_v = getEnclosingExpression(token, rootNode);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24123, 24162);
                            return return_v;
                        }


                        bool
                        f_21001_24197_24306(bool
                        condition, string
                        userMessage)
                        {
                            var return_v = CustomAssert.True(condition, userMessage);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24197, 24306);
                            return return_v;
                        }


                        int
                        f_21001_24372_24385(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 24372, 24385);
                            return return_v;
                        }


                        int
                        f_21001_24387_24398(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 24387, 24398);
                            return return_v;
                        }


                        int
                        f_21001_24401_24414(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 24401, 24414);
                            return return_v;
                        }


                        int
                        f_21001_24417_24430(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 24417, 24430);
                            return return_v;
                        }


                        string
                        f_21001_24357_24431(string
                        this_param, int
                        startIndex, int
                        length)
                        {
                            var return_v = this_param.Substring(startIndex, length);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24357, 24431);
                            return return_v;
                        }


                        int
                        f_21001_24466_24517(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, string, bool)>
                        this_param, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax? expr, string content, bool)
                        item)
                        {
                            this_param.Add(((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, string, bool))item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24466, 24517);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SyntaxTriviaList
                        f_21001_23340_23360_I(Microsoft.CodeAnalysis.SyntaxTriviaList
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23340, 23360);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                        f_21001_23248_23275_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 23248, 23275);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, string, bool)>
                        f_21001_24643_24671(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax, string, bool)>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24643, 24671);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 22988, 24687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 22988, 24687);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                ExpressionSyntax getEnclosingExpression(SyntaxToken token, SyntaxNode rootNode)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 24703, 25289);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24815, 24839);

                        var
                        node = token.Parent
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24857, 25244) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 24857, 25244);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24910, 24940);

                                var
                                expr = f_21001_24921_24939(node)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 24962, 25063) || true) && (expr != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 24962, 25063);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25028, 25040);

                                    return expr;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 24962, 25063);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25085, 25184) || true) && (node == rootNode)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25085, 25184);
                                    DynAbs.Tracing.TraceSender.TraceBreak(21001, 25155, 25161);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25085, 25184);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25206, 25225);

                                node = f_21001_25213_25224(node);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 24857, 25244);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 24857, 25244);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 24857, 25244);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25262, 25274);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 24703, 25289);

                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_21001_24921_24939(Microsoft.CodeAnalysis.SyntaxNode?
                        node)
                        {
                            var return_v = asExpression(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 24921, 24939);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SyntaxNode?
                        f_21001_25213_25224(Microsoft.CodeAnalysis.SyntaxNode?
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 25213, 25224);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 24703, 25289);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 24703, 25289);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                ExpressionSyntax asExpression(SyntaxNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(21001, 25305, 26415);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25384, 26400) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25384, 26400);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25437, 26381);

                                switch (node)
                                {

                                    case null:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25539, 25551);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);

                                    case ParenthesizedExpressionSyntax paren:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25648, 25672);

                                        return f_21001_25655_25671(paren);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);

                                    case IdentifierNameSyntax id when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25727, 25815) || true) && (f_21001_25732_25741(id) is MemberAccessExpressionSyntax memberAccess && (DynAbs.Tracing.TraceSender.Expression_True(21001, 25732, 25815) && f_21001_25790_25807(memberAccess) == node)) && (DynAbs.Tracing.TraceSender.Expression_True(21001, 25727, 25815) || true)
                                :
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25846, 25866);

                                        node = memberAccess;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25896, 25905);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);

                                    case ExpressionSyntax expr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 25958, 26044) || true) && (f_21001_25963_25974(expr) is ConditionalAccessExpressionSyntax cond && (DynAbs.Tracing.TraceSender.Expression_True(21001, 25963, 26044) && f_21001_26020_26036(cond) == node)) && (DynAbs.Tracing.TraceSender.Expression_True(21001, 25958, 26044) || true)
                                :
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 26075, 26087);

                                        node = cond;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 26117, 26126);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);

                                    case ExpressionSyntax expr:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 26209, 26221);

                                        return expr;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);

                                    case { Parent: var parent }:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21001, 25437, 26381);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 26305, 26319);

                                        node = parent;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21001, 26349, 26358);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25437, 26381);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(21001, 25384, 26400);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(21001, 25384, 26400);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(21001, 25384, 26400);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(21001, 25305, 26415);

                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_21001_25655_25671(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Expression;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 25655, 25671);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_21001_25732_25741(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 25732, 25741);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                        f_21001_25790_25807(Microsoft.CodeAnalysis.CSharp.Syntax.MemberAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 25790, 25807);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                        f_21001_25963_25974(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.Parent;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 25963, 25974);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                        f_21001_26020_26036(Microsoft.CodeAnalysis.CSharp.Syntax.ConditionalAccessExpressionSyntax
                        this_param)
                        {
                            var return_v = this_param.WhenNotNull;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 26020, 26036);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 25305, 26415);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 25305, 26415);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21001, 20535, 26426);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21001_20729_20752(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 20729, 20752);
                    return return_v;
                }


                int
                f_21001_20794_20830(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    compilation.VerifyTypes(tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20794, 20830);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_21001_20729_20752_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20729, 20752);
                    return return_v;
                }


                int
                f_21001_21006_21017(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 21006, 21017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_21001_20990_21018(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20990, 21018);
                    return return_v;
                }


                bool
                f_21001_20926_21019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree)tree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20926, 21019);
                    return return_v;
                }


                bool
                f_21001_20908_21020(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 20908, 21020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_21001_21048_21062(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21048, 21062);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>
                f_21001_21098_21118(Microsoft.CodeAnalysis.SyntaxNode
                rootNode)
                {
                    var return_v = getAnnotations(rootNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21098, 21118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_21001_21243_21277(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21243, 21277);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>>
                f_21001_21318_21435(ref System.Collections.Immutable.ImmutableArray<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>
                source, System.Func<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>
                keySelector)
                {
                    var return_v = source.GroupBy<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21318, 21435);
                    return return_v;
                }


                System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>[]
                f_21001_21318_21445(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>>
                source)
                {
                    var return_v = source.ToArray<System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21318, 21445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                f_21001_21560_21575(System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>
                this_param)
                {
                    var return_v = this_param.Key;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21001, 21560, 21575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_21001_21607_21644(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21607, 21644);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_21001_21685_21741(System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>
                source, System.Func<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), string>
                selector)
                {
                    var return_v = source.SelectAsArray<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21685, 21741);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_21001_21778_22768(System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>
                source, System.Func<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), string>
                selector)
                {
                    var return_v = source.SelectAsArray<(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted), string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21778, 22768);
                    return return_v;
                }


                string
                f_21001_22927_22955(Microsoft.CodeAnalysis.IMethodSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 22927, 22955);
                    return return_v;
                }


                int
                f_21001_22875_22956(System.Collections.Immutable.ImmutableArray<string>
                expected, System.Collections.Immutable.ImmutableArray<string>
                actual, string
                message)
                {
                    AssertEx.Equal(expected, actual, message: message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 22875, 22956);
                    return 0;
                }


                System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>[]
                f_21001_21488_21507_I(System.Linq.IGrouping<Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax Expression, string Text, bool IsConverted)>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(21001, 21488, 21507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21001, 20535, 26426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 20535, 26426);
            }
        }

        static CompilationUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21001, 884, 26433);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21001, 884, 26433);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21001, 884, 26433);
        }

    }
}
