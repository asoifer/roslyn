// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class PEPropertyOrEventHelpers
    {
        internal static ISet<PropertySymbol> GetPropertiesForExplicitlyImplementedAccessor(MethodSymbol accessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10146, 693, 910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 823, 899);

                return f_10146_830_898(accessor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10146, 693, 910);

                System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                f_10146_830_898(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    var return_v = GetSymbolsForExplicitlyImplementedAccessor<PropertySymbol>(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 830, 898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10146, 693, 910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 693, 910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ISet<EventSymbol> GetEventsForExplicitlyImplementedAccessor(MethodSymbol accessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10146, 922, 1129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1045, 1118);

                return f_10146_1052_1117(accessor);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10146, 922, 1129);

                System.Collections.Generic.ISet<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                f_10146_1052_1117(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    var return_v = GetSymbolsForExplicitlyImplementedAccessor<EventSymbol>(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 1052, 1117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10146, 922, 1129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 922, 1129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ISet<T> GetSymbolsForExplicitlyImplementedAccessor<T>(MethodSymbol accessor) where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10146, 1244, 2272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1377, 1498) || true) && ((object)accessor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 1377, 1498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1439, 1483);

                    return f_10146_1446_1482<T>();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 1377, 1498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1514, 1608);

                ImmutableArray<MethodSymbol>
                implementedAccessors = f_10146_1566_1607<T>(accessor)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1622, 1751) || true) && (implementedAccessors.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 1622, 1751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1692, 1736);

                    return f_10146_1699_1735<T>();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 1622, 1751);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1767, 1831);

                var
                symbolsForExplicitlyImplementedAccessors = f_10146_1814_1830<T>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1845, 2199);
                    foreach (var implementedAccessor in f_10146_1881_1901_I(implementedAccessors))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 1845, 2199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 1935, 2002);

                        var
                        associatedProperty = f_10146_1960_1996<T>(implementedAccessor) as T
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2020, 2184) || true) && ((object)associatedProperty != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 2020, 2184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2100, 2165);

                            f_10146_2100_2164<T>(symbolsForExplicitlyImplementedAccessors, associatedProperty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 2020, 2184);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 1845, 2199);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10146, 1, 355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10146, 1, 355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2213, 2261);

                return symbolsForExplicitlyImplementedAccessors;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10146, 1244, 2272);

                System.Collections.Generic.ISet<T>
                f_10146_1446_1482<T>() where T : Symbol

                {
                    var return_v = SpecializedCollections.EmptySet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 1446, 1482);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10146_1566_1607<T>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.ExplicitInterfaceImplementations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 1566, 1607);
                    return return_v;
                }


                System.Collections.Generic.ISet<T>
                f_10146_1699_1735<T>() where T : Symbol

                {
                    var return_v = SpecializedCollections.EmptySet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 1699, 1735);
                    return return_v;
                }


                System.Collections.Generic.HashSet<T>
                f_10146_1814_1830<T>() where T : Symbol

                {
                    var return_v = new System.Collections.Generic.HashSet<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 1814, 1830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10146_1960_1996<T>(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 1960, 1996);
                    return return_v;
                }


                bool
                f_10146_2100_2164<T>(System.Collections.Generic.HashSet<T>
                this_param, T
                item) where T : Symbol

                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 2100, 2164);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10146_1881_1901_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 1881, 1901);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10146, 1244, 2272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 1244, 2272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Accessibility GetDeclaredAccessibilityFromAccessors(MethodSymbol accessor1, MethodSymbol accessor2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10146, 2570, 3161);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2710, 3023) || true) && ((object)accessor1 == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 2710, 3023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2773, 2872);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10146, 2780, 2807) || ((((object)accessor2 == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10146, 2810, 2837)) || DynAbs.Tracing.TraceSender.Conditional_F3(10146, 2840, 2871))) ? Accessibility.NotApplicable : f_10146_2840_2871(accessor2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 2710, 3023);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 2710, 3023);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2906, 3023) || true) && ((object)accessor2 == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10146, 2906, 3023);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 2969, 3008);

                        return f_10146_2976_3007(accessor1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 2906, 3023);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10146, 2710, 3023);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 3039, 3150);

                return f_10146_3046_3149(f_10146_3084_3115(accessor1), f_10146_3117_3148(accessor2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10146, 2570, 3161);

                Microsoft.CodeAnalysis.Accessibility
                f_10146_2840_2871(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 2840, 2871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10146_2976_3007(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 2976, 3007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10146_3084_3115(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 3084, 3115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10146_3117_3148(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10146, 3117, 3148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10146_3046_3149(Microsoft.CodeAnalysis.Accessibility
                accessibility1, Microsoft.CodeAnalysis.Accessibility
                accessibility2)
                {
                    var return_v = GetDeclaredAccessibilityFromAccessors(accessibility1, accessibility2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10146, 3046, 3149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10146, 2570, 3161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 2570, 3161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Accessibility GetDeclaredAccessibilityFromAccessors(Accessibility accessibility1, Accessibility accessibility2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10146, 3173, 3740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 3325, 3416);

                var
                minAccessibility = (DynAbs.Tracing.TraceSender.Conditional_F1(10146, 3348, 3381) || (((accessibility1 > accessibility2) && DynAbs.Tracing.TraceSender.Conditional_F2(10146, 3384, 3398)) || DynAbs.Tracing.TraceSender.Conditional_F3(10146, 3401, 3415))) ? accessibility2 : accessibility1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 3430, 3521);

                var
                maxAccessibility = (DynAbs.Tracing.TraceSender.Conditional_F1(10146, 3453, 3486) || (((accessibility1 > accessibility2) && DynAbs.Tracing.TraceSender.Conditional_F2(10146, 3489, 3503)) || DynAbs.Tracing.TraceSender.Conditional_F3(10146, 3506, 3520))) ? accessibility1 : accessibility2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10146, 3537, 3729);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10146, 3544, 3639) || ((((minAccessibility == Accessibility.Protected) && (DynAbs.Tracing.TraceSender.Expression_True(10146, 3545, 3638) && (maxAccessibility == Accessibility.Internal)))
                && DynAbs.Tracing.TraceSender.Conditional_F2(10146, 3659, 3692)) || DynAbs.Tracing.TraceSender.Conditional_F3(10146, 3712, 3728))) ? Accessibility.ProtectedOrInternal
                : maxAccessibility;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10146, 3173, 3740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10146, 3173, 3740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 3173, 3740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEPropertyOrEventHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10146, 630, 3747);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10146, 630, 3747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10146, 630, 3747);
        }

    }
}
