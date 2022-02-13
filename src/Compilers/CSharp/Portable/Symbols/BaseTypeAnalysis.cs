// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class BaseTypeAnalysis
    {
        internal static bool TypeDependsOn(NamedTypeSymbol depends, NamedTypeSymbol on)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 517, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 621, 659);

                f_10090_621_658((object)depends != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 673, 706);

                f_10090_673_705((object)on != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 720, 750);

                f_10090_720_749(f_10090_733_748(on));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 766, 811);

                var
                hs = f_10090_775_810()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 825, 887);

                f_10090_825_886(depends, f_10090_853_881(depends), hs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 903, 932);

                var
                result = f_10090_916_931(hs, on)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 946, 956);

                f_10090_946_955(hs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 972, 986);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 517, 997);

                int
                f_10090_621_658(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 621, 658);
                    return 0;
                }


                int
                f_10090_673_705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 673, 705);
                    return 0;
                }


                bool
                f_10090_733_748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 733, 748);
                    return return_v;
                }


                int
                f_10090_720_749(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 720, 749);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_775_810()
                {
                    var return_v = PooledHashSet<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 775, 810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10090_853_881(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 853, 881);
                    return return_v;
                }


                int
                f_10090_825_886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure)
                {
                    TypeDependsClosure(type, currentCompilation, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>)partialClosure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 825, 886);
                    return 0;
                }


                bool
                f_10090_916_931(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 916, 931);
                    return return_v;
                }


                int
                f_10090_946_955(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 946, 955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 517, 997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 517, 997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void TypeDependsClosure(NamedTypeSymbol type, CSharpCompilation currentCompilation, HashSet<Symbol> partialClosure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 1009, 2139);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1164, 1244) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1164, 1244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1222, 1229);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1164, 1244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1260, 1291);

                type = f_10090_1267_1290(type);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1305, 2128) || true) && (f_10090_1309_1333(partialClosure, type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1305, 2128);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1367, 1800) || true) && (f_10090_1371_1387(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1367, 1800);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1429, 1612);
                            foreach (var bt in f_10090_1448_1480_I(f_10090_1448_1480(type, null)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1429, 1612);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1530, 1589);

                                f_10090_1530_1588(bt, currentCompilation, partialClosure);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1429, 1612);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10090, 1, 184);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10090, 1, 184);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1367, 1800);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1367, 1800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1694, 1781);

                        f_10090_1694_1780(f_10090_1713_1743(type, null), currentCompilation, partialClosure);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1367, 1800);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 1900, 2113) || true) && (currentCompilation != null && (DynAbs.Tracing.TraceSender.Expression_True(10090, 1904, 1976) && f_10090_1934_1976(type, currentCompilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 1900, 2113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2018, 2094);

                        f_10090_2018_2093(f_10090_2037_2056(type), currentCompilation, partialClosure);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1900, 2113);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 1305, 2128);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 1009, 2139);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10090_1267_1290(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 1267, 1290);
                    return return_v;
                }


                bool
                f_10090_1309_1333(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1309, 1333);
                    return return_v;
                }


                bool
                f_10090_1371_1387(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 1371, 1387);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10090_1448_1480(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1448, 1480);
                    return return_v;
                }


                int
                f_10090_1530_1588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure)
                {
                    TypeDependsClosure(type, currentCompilation, partialClosure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1530, 1588);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10090_1448_1480_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1448, 1480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10090_1713_1743(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1713, 1743);
                    return return_v;
                }


                int
                f_10090_1694_1780(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure)
                {
                    TypeDependsClosure(type, currentCompilation, partialClosure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1694, 1780);
                    return 0;
                }


                bool
                f_10090_1934_1976(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.IsFromCompilation(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 1934, 1976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10090_2037_2056(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 2037, 2056);
                    return return_v;
                }


                int
                f_10090_2018_2093(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                currentCompilation, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure)
                {
                    TypeDependsClosure(type, currentCompilation, partialClosure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2018, 2093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 1009, 2139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 1009, 2139);
            }
        }

        internal static bool StructDependsOn(NamedTypeSymbol depends, NamedTypeSymbol on)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 2151, 2609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2257, 2295);

                f_10090_2257_2294((object)depends != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2309, 2342);

                f_10090_2309_2341((object)on != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2356, 2386);

                f_10090_2356_2385(f_10090_2369_2384(on));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2402, 2447);

                var
                hs = f_10090_2411_2446()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2461, 2499);

                f_10090_2461_2498(depends, hs, on);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2515, 2544);

                var
                result = f_10090_2528_2543(hs, on)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2558, 2568);

                f_10090_2558_2567(hs);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2584, 2598);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 2151, 2609);

                int
                f_10090_2257_2294(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2257, 2294);
                    return 0;
                }


                int
                f_10090_2309_2341(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2309, 2341);
                    return 0;
                }


                bool
                f_10090_2369_2384(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 2369, 2384);
                    return return_v;
                }


                int
                f_10090_2356_2385(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2356, 2385);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_2411_2446()
                {
                    var return_v = PooledHashSet<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2411, 2446);
                    return return_v;
                }


                int
                f_10090_2461_2498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                on)
                {
                    StructDependsClosure(type, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>)partialClosure, on);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2461, 2498);
                    return 0;
                }


                bool
                f_10090_2528_2543(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2528, 2543);
                    return return_v;
                }


                int
                f_10090_2558_2567(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2558, 2567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 2151, 2609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 2151, 2609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void StructDependsClosure(NamedTypeSymbol type, HashSet<Symbol> partialClosure, NamedTypeSymbol on)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 2621, 3786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2760, 2795);

                f_10090_2760_2794((object)type != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 2811, 3199) || true) && ((object)f_10090_2823_2846(type) == on)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 2811, 3199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3136, 3159);

                    f_10090_3136_3158(                // found a possibly expanding cycle, for example
                                                      //     struct X<T> { public T t; }
                                                      //     struct W<T> { X<W<W<T>>> x; }
                                                      // while not explicitly forbidden by the spec, it should be.
                                    partialClosure, on);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3177, 3184);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 2811, 3199);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3215, 3775) || true) && (f_10090_3219_3243(partialClosure, type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 3215, 3775);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3277, 3760);
                        foreach (var member in f_10090_3300_3326_I(f_10090_3300_3326(type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 3277, 3760);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3368, 3402);

                            var
                            field = member as FieldSymbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3424, 3464);

                            // LAFHIS
                            var
                            fieldType = f_10090_3446_3463(field)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3486, 3648) || true) && (fieldType is null || (DynAbs.Tracing.TraceSender.Expression_False(10090, 3490, 3548) || f_10090_3511_3529(fieldType) != TypeKind.Struct) || (DynAbs.Tracing.TraceSender.Expression_False(10090, 3490, 3566) || f_10090_3552_3566(field)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 3486, 3648);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3616, 3625);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 3486, 3648);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 3672, 3741);

                            f_10090_3672_3740(fieldType, partialClosure, on);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 3277, 3760);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10090, 1, 484);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10090, 1, 484);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 3215, 3775);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 2621, 3786);

                int
                f_10090_2760_2794(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 2760, 2794);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10090_2823_2846(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 2823, 2846);
                    return return_v;
                }


                bool
                f_10090_3136_3158(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3136, 3158);
                    return return_v;
                }


                bool
                f_10090_3219_3243(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3219, 3243);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_3300_3326(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3300, 3326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10090_3446_3463(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = field?.NonPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3446, 3463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10090_3511_3529(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 3511, 3529);
                    return return_v;
                }


                bool
                f_10090_3552_3566(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 3552, 3566);
                    return return_v;
                }


                int
                f_10090_3672_3740(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                on)
                {
                    StructDependsClosure((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, partialClosure, on);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3672, 3740);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_3300_3326_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 3300, 3326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 2621, 3786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 2621, 3786);
            }
        }

        internal static ManagedKind GetManagedKind(NamedTypeSymbol type, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 4939, 6037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5076, 5133);

                var (isManaged, hasGenerics) = f_10090_5107_5132(type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5147, 5200);

                var
                definitelyManaged = isManaged == ThreeState.True
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5214, 5692) || true) && (isManaged == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 5214, 5692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5379, 5424);

                    var
                    hs = f_10090_5388_5423()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5442, 5520);

                    var
                    result = f_10090_5455_5519(type, hs, ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5538, 5583);

                    definitelyManaged = result.definitelyManaged;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5601, 5649);

                    hasGenerics = hasGenerics || (DynAbs.Tracing.TraceSender.Expression_False(10090, 5615, 5648) || result.hasGenerics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5667, 5677);

                    f_10090_5667_5676(hs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 5214, 5692);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5710, 6026) || true) && (definitelyManaged)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 5710, 6026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5765, 5792);

                    return ManagedKind.Managed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 5710, 6026);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 5710, 6026);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5826, 6026) || true) && (hasGenerics)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 5826, 6026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5875, 5916);

                        return ManagedKind.UnmanagedWithGenerics;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 5826, 6026);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 5826, 6026);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 5982, 6011);

                        return ManagedKind.Unmanaged;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 5826, 6026);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 5710, 6026);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 4939, 6037);

                (Microsoft.CodeAnalysis.ThreeState isManaged, bool hasGenerics)
                f_10090_5107_5132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = IsManagedTypeHelper(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 5107, 5132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_5388_5423()
                {
                    var return_v = PooledHashSet<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 5388, 5423);
                    return return_v;
                }


                (bool definitelyManaged, bool hasGenerics)
                f_10090_5455_5519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = DependsOnDefinitelyManagedType(type, (System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>)partialClosure, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 5455, 5519);
                    return return_v;
                }


                int
                f_10090_5667_5676(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 5667, 5676);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 4939, 6037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 4939, 6037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol NonPointerType(this FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10090, 6337, 6393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6353, 6393);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10090, 6353, 6373) || ((f_10090_6353_6373(field) && DynAbs.Tracing.TraceSender.Conditional_F2(10090, 6376, 6380)) || DynAbs.Tracing.TraceSender.Conditional_F3(10090, 6383, 6393))) ? null : f_10090_6383_6393(field); DynAbs.Tracing.TraceSender.TraceExitMethod(10090, 6337, 6393);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 6337, 6393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 6337, 6393);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10090_6353_6373(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param)
            {
                var return_v = this_param.HasPointerType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 6353, 6373);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10090_6383_6393(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 6383, 6393);
                return return_v;
            }

        }

        private static (bool definitelyManaged, bool hasGenerics) DependsOnDefinitelyManagedType(NamedTypeSymbol type, HashSet<Symbol> partialClosure, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 6406, 10031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6621, 6656);

                f_10090_6621_6655((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6672, 6696);

                var
                hasGenerics = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6710, 9976) || true) && (f_10090_6714_6738(partialClosure, type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 6710, 9976);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6772, 9961);
                        foreach (var member in f_10090_6795_6828_I(f_10090_6795_6828(type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 6772, 9961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 6965, 6983);

                            FieldSymbol
                            field
                            = default(FieldSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7005, 7702);

                            switch (f_10090_7013_7024(member))
                            {

                                case SymbolKind.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 7005, 7702);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7126, 7154);

                                    field = (FieldSymbol)member;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7184, 7365);

                                    f_10090_7184_7364((object)(f_10090_7206_7228(field) as EventSymbol) == null, "Didn't expect to find a field-like event backing field in the member list.");
                                    DynAbs.Tracing.TraceSender.TraceBreak(10090, 7395, 7401);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 7005, 7702);

                                case SymbolKind.Event:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 7005, 7702);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7479, 7525);

                                    field = f_10090_7487_7524(((EventSymbol)member));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10090, 7555, 7561);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 7005, 7702);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 7005, 7702);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7625, 7679);

                                    throw f_10090_7631_7678(f_10090_7666_7677(member));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 7005, 7702);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7726, 7833) || true) && ((object)field == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 7726, 7833);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7801, 7810);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 7726, 7833);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7857, 7903);

                            TypeSymbol
                            fieldType = f_10090_7880_7902(field)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 7925, 8079) || true) && (fieldType is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 7925, 8079);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8047, 8056);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 7925, 8079);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8103, 8159);

                            f_10090_8103_8158(
                                                fieldType, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8181, 8243);

                            NamedTypeSymbol
                            fieldNamedType = fieldType as NamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8265, 9942) || true) && ((object)fieldNamedType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8265, 9942);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8349, 8512) || true) && (f_10090_8353_8400(fieldType, ref useSiteDiagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8349, 8512);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8458, 8485);

                                    return (true, hasGenerics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8349, 8512);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8265, 9942);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8265, 9942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8610, 8659);

                                var
                                result = f_10090_8623_8658(fieldNamedType)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8685, 8733);

                                hasGenerics = hasGenerics || (DynAbs.Tracing.TraceSender.Expression_False(10090, 8699, 8732) || result.hasGenerics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 8909, 9919);

                                switch (result.isManaged)
                                {

                                    case ThreeState.True:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8909, 9919);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9046, 9073);

                                        return (true, hasGenerics);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8909, 9919);

                                    case ThreeState.False:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8909, 9919);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9161, 9170);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8909, 9919);

                                    case ThreeState.Unknown:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 8909, 9919);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9260, 9849) || true) && (f_10090_9264_9318_M(!f_10090_9265_9298(fieldNamedType).KnownCircularStruct))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 9260, 9849);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9392, 9523);

                                            var (definitelyManaged, childHasGenerics) = f_10090_9436_9522(fieldNamedType, partialClosure, ref useSiteDiagnostics);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9561, 9607);

                                            hasGenerics = hasGenerics || (DynAbs.Tracing.TraceSender.Expression_False(10090, 9575, 9606) || childHasGenerics);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9645, 9814) || true) && (definitelyManaged)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 9645, 9814);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9748, 9775);

                                                return (true, hasGenerics);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 9645, 9814);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 9260, 9849);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9883, 9892);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8909, 9919);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 8265, 9942);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 6772, 9961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10090, 1, 3190);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10090, 1, 3190);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 6710, 9976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 9992, 10020);

                return (false, hasGenerics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 6406, 10031);

                int
                f_10090_6621_6655(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 6621, 6655);
                    return 0;
                }


                bool
                f_10090_6714_6738(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 6714, 6738);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_6795_6828(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetInstanceFieldsAndEvents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 6795, 6828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10090_7013_7024(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 7013, 7024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10090_7206_7228(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 7206, 7228);
                    return return_v;
                }


                int
                f_10090_7184_7364(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 7184, 7364);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10090_7487_7524(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 7487, 7524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10090_7666_7677(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 7666, 7677);
                    return return_v;
                }


                System.Exception
                f_10090_7631_7678(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 7631, 7678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10090_7880_7902(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = field.NonPointerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 7880, 7902);
                    return return_v;
                }


                int
                f_10090_8103_8158(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 8103, 8158);
                    return 0;
                }


                bool
                f_10090_8353_8400(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsManagedType(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 8353, 8400);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.ThreeState isManaged, bool hasGenerics)
                f_10090_8623_8658(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = IsManagedTypeHelper(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 8623, 8658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10090_9265_9298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 9265, 9298);
                    return return_v;
                }


                bool
                f_10090_9264_9318_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 9264, 9318);
                    return return_v;
                }


                (bool definitelyManaged, bool hasGenerics)
                f_10090_9436_9522(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                partialClosure, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = DependsOnDefinitelyManagedType(type, partialClosure, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 9436, 9522);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10090_6795_6828_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 6795, 6828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 6406, 10031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 6406, 10031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static (ThreeState isManaged, bool hasGenerics) IsManagedTypeHelper(NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10090, 10307, 12363);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 10503, 10609) || true) && (f_10090_10507_10524(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 10503, 10609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 10558, 10594);

                    type = f_10090_10565_10593(type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 10503, 10609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 10669, 11946);

                switch (f_10090_10677_10693(type))
                {

                    case SpecialType.System_Void:
                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                    case SpecialType.System_TypedReference:
                    case SpecialType.System_ArgIterator:
                    case SpecialType.System_RuntimeArgumentHandle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 10669, 11946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 11683, 11716);

                        return (ThreeState.False, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 10669, 11946);

                    case SpecialType.None:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 10669, 11946);
                        DynAbs.Tracing.TraceSender.TraceBreak(10090, 11890, 11896);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 10669, 11946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 11962, 12000);

                bool
                hasGenerics = f_10090_11981_11999(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 12014, 12352);

                switch (f_10090_12022_12035(type))
                {

                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 12014, 12352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 12110, 12149);

                        return (ThreeState.False, hasGenerics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 12014, 12352);

                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 12014, 12352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 12210, 12251);

                        return (ThreeState.Unknown, hasGenerics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 12014, 12352);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10090, 12014, 12352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10090, 12299, 12337);

                        return (ThreeState.True, hasGenerics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10090, 12014, 12352);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10090, 10307, 12363);

                bool
                f_10090_10507_10524(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 10507, 10524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10090_10565_10593(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10090, 10565, 10593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10090_10677_10693(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 10677, 10693);
                    return return_v;
                }


                bool
                f_10090_11981_11999(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 11981, 11999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10090_12022_12035(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10090, 12022, 12035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10090, 10307, 12363);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 10307, 12363);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BaseTypeAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10090, 462, 12370);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10090, 462, 12370);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10090, 462, 12370);
        }

    }
}
