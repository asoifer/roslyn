// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    internal class NameAndArityComparer
            : IComparer<NamedTypeSymbol>
    {
        public int Compare(NamedTypeSymbol x, NamedTypeSymbol y) // Implements IComparer<NamedTypeSymbol).Compare
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21017, 555, 901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 685, 755);

                int
                result = f_21017_698_754(f_21017_698_730(), f_21017_739_745(x), f_21017_747_753(y))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 771, 849) || true) && (result != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21017, 771, 849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 820, 834);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21017, 771, 849);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 865, 890);

                return f_21017_872_879(x) - f_21017_882_889(y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21017, 555, 901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 555, 901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 555, 901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NameAndArityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21017, 465, 908);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21017, 465, 908);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 465, 908);
        }


        static NameAndArityComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21017, 465, 908);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21017, 465, 908);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 465, 908);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21017, 465, 908);

        System.StringComparer
        f_21017_698_730()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21017, 698, 730);
            return return_v;
        }


        string
        f_21017_739_745(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21017, 739, 745);
            return return_v;
        }


        string
        f_21017_747_753(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21017, 747, 753);
            return return_v;
        }


        int
        f_21017_698_754(System.StringComparer
        this_param, string
        x, string
        y)
        {
            var return_v = this_param.Compare(x, y);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 698, 754);
            return return_v;
        }


        int
        f_21017_872_879(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21017, 872, 879);
            return return_v;
        }


        int
        f_21017_882_889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21017, 882, 889);
            return return_v;
        }

    }
    internal static class SymbolUtilities
    {
        public static NamespaceSymbol ChildNamespace(this NamespaceSymbol ns, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 970, 1239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 1077, 1228);

                return f_21017_1084_1227(f_21017_1084_1197(f_21017_1084_1099(ns).Where(n => n.Name.Equals(name))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 970, 1239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 970, 1239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 970, 1239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol ChildType(this NamespaceSymbol ns, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 1251, 1488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 1353, 1477);

                return f_21017_1360_1476(f_21017_1360_1375(ns).OfType<NamedTypeSymbol>(), n => n.Name.Equals(name));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 1251, 1488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 1251, 1488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 1251, 1488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static NamedTypeSymbol ChildType(this NamespaceSymbol ns, string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 1500, 1768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 1613, 1757);

                return f_21017_1620_1756(f_21017_1620_1635(ns).OfType<NamedTypeSymbol>(), n => n.Name.Equals(name) && n.Arity == arity);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 1500, 1768);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 1500, 1768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 1500, 1768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Symbol ChildSymbol(this NamespaceOrTypeSymbol parent, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 1780, 1935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 1885, 1924);

                return f_21017_1892_1915(parent, name).First();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 1780, 1935);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 1780, 1935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 1780, 1935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static T GetIndexer<T>(this NamespaceOrTypeSymbol type, string name) where T : PropertySymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 1947, 2254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2072, 2178);

                T
                member = f_21017_2083_2172<T>(f_21017_2083_2128<T>(type, WellKnownMemberNames.Indexer).Where(i => i.MetadataName == name)) as T
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2192, 2215);

                f_21017_2192_2214<T>(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2229, 2243);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 1947, 2254);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 1947, 2254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 1947, 2254);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ListToSortedString(this List<string> list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 2266, 2567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2354, 2371);

                string
                text = ""
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2385, 2397);

                f_21017_2385_2396(list);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2413, 2530);
                    foreach (var element in f_21017_2437_2441_I(list))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21017, 2413, 2530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2475, 2515);

                        text = text + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ('\n').ToString(), 21017, 2489, 2493) + f_21017_2496_2514(element);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21017, 2413, 2530);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21017, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21017, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2544, 2556);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 2266, 2567);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 2266, 2567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 2266, 2567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ListToSortedString<TSymbol>(this List<TSymbol> listOfSymbols) where TSymbol : ISymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 2579, 3058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2710, 2727);

                string
                text = ""
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2741, 2835);

                List<string>
                listOfSymbolString = f_21017_2775_2834<TSymbol>(f_21017_2775_2825<TSymbol>(listOfSymbols, e => e.ToTestDisplayString()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2849, 2875);

                f_21017_2849_2874<TSymbol>(listOfSymbolString);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2891, 3021);
                    foreach (var symbolString in f_21017_2920_2938_I(listOfSymbolString))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(21017, 2891, 3021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 2972, 3006);

                        text = text + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ('\n').ToString(), 21017, 2986, 2990) + symbolString;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(21017, 2891, 3021);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(21017, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(21017, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3035, 3047);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 2579, 3058);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 2579, 3058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 2579, 3058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SymbolDisplayFormat GetDisplayFormat(bool includeNonNullable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 3070, 3549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3171, 3215);

                var
                format = SymbolDisplayFormat.TestFormat
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3229, 3508) || true) && (includeNonNullable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21017, 3229, 3508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3285, 3493);

                    format = f_21017_3294_3492(f_21017_3294_3399(format, SymbolDisplayMiscellaneousOptions.IncludeNotNullableReferenceTypeModifier), SymbolDisplayCompilerInternalOptions.None);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21017, 3229, 3508);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3524, 3538);

                return format;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 3070, 3549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 3070, 3549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 3070, 3549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToTestDisplayString(this TypeWithAnnotations type, bool includeNonNullable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 3561, 3817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3690, 3756);

                SymbolDisplayFormat
                format = f_21017_3719_3755(includeNonNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3770, 3806);

                return type.ToDisplayString(format);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 3561, 3817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 3561, 3817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 3561, 3817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] ToTestDisplayStrings(this IEnumerable<TypeWithAnnotations> types)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 3829, 4013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 3942, 4002);

                return f_21017_3949_4001(f_21017_3949_3991(types, t => t.ToTestDisplayString()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 3829, 4013);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 3829, 4013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 3829, 4013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] ToTestDisplayStrings(this IEnumerable<ISymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 4025, 4201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4128, 4190);

                return f_21017_4135_4189(f_21017_4135_4179(symbols, s => s.ToTestDisplayString()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 4025, 4201);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 4025, 4201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 4025, 4201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string[] ToTestDisplayStrings(this IEnumerable<Symbol> symbols, SymbolDisplayFormat format = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 4213, 4481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4350, 4392);

                format ??= SymbolDisplayFormat.TestFormat;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4406, 4470);

                return f_21017_4413_4469(f_21017_4413_4459(symbols, s => s.ToDisplayString(format)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 4213, 4481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 4213, 4481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 4213, 4481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToTestDisplayString(this ISymbol symbol, bool includeNonNullable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 4493, 4733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4604, 4670);

                SymbolDisplayFormat
                format = f_21017_4633_4669(includeNonNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4684, 4722);

                return f_21017_4691_4721(symbol, format);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 4493, 4733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 4493, 4733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 4493, 4733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static string ToTestDisplayString(this Symbol symbol, bool includeNonNullable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21017, 4745, 4984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4855, 4921);

                SymbolDisplayFormat
                format = f_21017_4884_4920(includeNonNullable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21017, 4935, 4973);

                return f_21017_4942_4972(symbol, format);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21017, 4745, 4984);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21017, 4745, 4984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 4745, 4984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21017, 916, 4991);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21017, 916, 4991);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21017, 916, 4991);
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21017_1084_1099(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1084, 1099);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
        f_21017_1084_1197(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
        source)
        {
            var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1084, 1197);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_21017_1084_1227(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
        source)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1084, 1227);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21017_1360_1375(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1360, 1375);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21017_1360_1476(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
        predicate)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1360, 1476);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21017_1620_1635(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.GetMembers();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1620, 1635);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21017_1620_1756(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
        predicate)
        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(predicate);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1620, 1756);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21017_1892_1915(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param, string
        name)
        {
            var return_v = this_param.GetMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 1892, 1915);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_21017_2083_2128<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
        this_param, string
        name) where T : PropertySymbol

        {
            var return_v = this_param.GetMembers(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2083, 2128);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_21017_2083_2172<T>(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
        source) where T : PropertySymbol

        {
            var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2083, 2172);
            return return_v;
        }


        static int
        f_21017_2192_2214<T>(T?
        @object) where T : PropertySymbol

        {
            Assert.NotNull((object?)@object);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2192, 2214);
            return 0;
        }


        static int
        f_21017_2385_2396(System.Collections.Generic.List<string>
        this_param)
        {
            this_param.Sort();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2385, 2396);
            return 0;
        }


        static string
        f_21017_2496_2514(string
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2496, 2514);
            return return_v;
        }


        static System.Collections.Generic.List<string>
        f_21017_2437_2441_I(System.Collections.Generic.List<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2437, 2441);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_21017_2775_2825<TSymbol>(System.Collections.Generic.List<TSymbol>
        source, System.Func<TSymbol, string>
        selector) where TSymbol : ISymbol

        {
            var return_v = source.Select<TSymbol, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2775, 2825);
            return return_v;
        }


        static System.Collections.Generic.List<string>
        f_21017_2775_2834<TSymbol>(System.Collections.Generic.IEnumerable<string>
        source) where TSymbol : ISymbol

        {
            var return_v = source.ToList<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2775, 2834);
            return return_v;
        }


        static int
        f_21017_2849_2874<TSymbol>(System.Collections.Generic.List<string>
        this_param) where TSymbol : ISymbol

        {
            this_param.Sort();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2849, 2874);
            return 0;
        }


        static System.Collections.Generic.List<string>
        f_21017_2920_2938_I(System.Collections.Generic.List<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 2920, 2938);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21017_3294_3399(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        options)
        {
            var return_v = this_param.AddMiscellaneousOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 3294, 3399);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21017_3294_3492(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param, Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        options)
        {
            var return_v = this_param.WithCompilerInternalOptions(options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 3294, 3492);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21017_3719_3755(bool
        includeNonNullable)
        {
            var return_v = GetDisplayFormat(includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 3719, 3755);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_21017_3949_3991(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, string>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 3949, 3991);
            return return_v;
        }


        static string[]
        f_21017_3949_4001(System.Collections.Generic.IEnumerable<string>
        source)
        {
            var return_v = source.ToArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 3949, 4001);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_21017_4135_4179(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
        source, System.Func<Microsoft.CodeAnalysis.ISymbol, string>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.ISymbol, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4135, 4179);
            return return_v;
        }


        static string[]
        f_21017_4135_4189(System.Collections.Generic.IEnumerable<string>
        source)
        {
            var return_v = source.ToArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4135, 4189);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<string>
        f_21017_4413_4459(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
        source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, string>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.CSharp.Symbol, string>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4413, 4459);
            return return_v;
        }


        static string[]
        f_21017_4413_4469(System.Collections.Generic.IEnumerable<string>
        source)
        {
            var return_v = source.ToArray<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4413, 4469);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21017_4633_4669(bool
        includeNonNullable)
        {
            var return_v = GetDisplayFormat(includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4633, 4669);
            return return_v;
        }


        static string
        f_21017_4691_4721(Microsoft.CodeAnalysis.ISymbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4691, 4721);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_21017_4884_4920(bool
        includeNonNullable)
        {
            var return_v = GetDisplayFormat(includeNonNullable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4884, 4920);
            return return_v;
        }


        static string
        f_21017_4942_4972(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
        format)
        {
            var return_v = this_param.ToDisplayString(format);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21017, 4942, 4972);
            return return_v;
        }

    }
}
