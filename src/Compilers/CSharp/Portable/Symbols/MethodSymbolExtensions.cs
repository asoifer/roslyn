// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class MethodSymbolExtensions
    {
        public static bool IsParams(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 625, 805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 703, 794);

                return f_10120_710_731(method) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10120, 710, 793) && f_10120_740_793(f_10120_740_757(method)[f_10120_758_779(method) - 1]));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 625, 805);

                int
                f_10120_710_731(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 710, 731);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10120_740_757(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 740, 757);
                    return return_v;
                }


                int
                f_10120_758_779(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 758, 779);
                    return return_v;
                }


                bool
                f_10120_740_793(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 740, 793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 625, 805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 625, 805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsSynthesizedLambda(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 817, 1058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 908, 945);

                f_10120_908_944((object)method != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 959, 1047);

                return f_10120_966_993(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 966, 1046) && f_10120_997_1014(method) == MethodKind.AnonymousFunction);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 817, 1058);

                int
                f_10120_908_944(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 908, 944);
                    return 0;
                }


                bool
                f_10120_966_993(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 966, 993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10120_997_1014(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 997, 1014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 817, 1058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 817, 1058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsRuntimeFinalizer(this MethodSymbol method, bool skipFirstMethodKindCheck = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 1830, 4092);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 2371, 2654) || true) && ((object)method == null || (DynAbs.Tracing.TraceSender.Expression_False(10120, 2375, 2451) || f_10120_2401_2412(method) != WellKnownMemberNames.DestructorName) || (DynAbs.Tracing.TraceSender.Expression_False(10120, 2375, 2498) || f_10120_2472_2493(method) != 0) || (DynAbs.Tracing.TraceSender.Expression_False(10120, 2375, 2519) || f_10120_2502_2514(method) != 0) || (DynAbs.Tracing.TraceSender.Expression_False(10120, 2375, 2592) || !f_10120_2524_2592(method, ignoreInterfaceImplementationChanges: true)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 2371, 2654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 2626, 2639);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 2371, 2654);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 2670, 4052) || true) && ((object)method != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 2670, 4052);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 2733, 3634) || true) && (!skipFirstMethodKindCheck && (DynAbs.Tracing.TraceSender.Expression_True(10120, 2737, 2808) && f_10120_2766_2783(method) == MethodKind.Destructor))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 2733, 3634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3178, 3190);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 2733, 3634);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 2733, 3634);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3232, 3634) || true) && (f_10120_3236_3269(f_10120_3236_3257(method)) == SpecialType.System_Object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 3232, 3634);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3340, 3352);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 3232, 3634);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 3232, 3634);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3394, 3634) || true) && (f_10120_3398_3466(method, ignoreInterfaceImplementationChanges: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 3394, 3634);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3602, 3615);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 3394, 3634);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 3232, 3634);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 2733, 3634);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 3916, 3986);

                        method = f_10120_3925_3985(method, out _);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 4004, 4037);

                        skipFirstMethodKindCheck = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 2670, 4052);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10120, 2670, 4052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10120, 2670, 4052);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 4068, 4081);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 1830, 4092);

                string
                f_10120_2401_2412(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 2401, 2412);
                    return return_v;
                }


                int
                f_10120_2472_2493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 2472, 2493);
                    return return_v;
                }


                int
                f_10120_2502_2514(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 2502, 2514);
                    return return_v;
                }


                bool
                f_10120_2524_2592(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataVirtual(ignoreInterfaceImplementationChanges: ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 2524, 2592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10120_2766_2783(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 2766, 2783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10120_3236_3257(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 3236, 3257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10120_3236_3269(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 3236, 3269);
                    return return_v;
                }


                bool
                f_10120_3398_3466(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, bool
                ignoreInterfaceImplementationChanges)
                {
                    var return_v = this_param.IsMetadataNewSlot(ignoreInterfaceImplementationChanges: ignoreInterfaceImplementationChanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 3398, 3466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10120_3925_3985(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, out bool
                wasAmbiguous)
                {
                    var return_v = method.GetFirstRuntimeOverriddenMethodIgnoringNewSlot(out wasAmbiguous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 3925, 3985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 1830, 4092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 1830, 4092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MethodSymbol ConstructIfGeneric(this MethodSymbol method, ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 4256, 4568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 4403, 4470);

                f_10120_4403_4469(f_10120_4416_4438(method) == (typeArguments.Length > 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 4484, 4557);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10120, 4491, 4513) || ((f_10120_4491_4513(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10120, 4516, 4547)) || DynAbs.Tracing.TraceSender.Conditional_F3(10120, 4550, 4556))) ? f_10120_4516_4547(method, typeArguments) : method;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 4256, 4568);

                bool
                f_10120_4416_4438(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 4416, 4438);
                    return return_v;
                }


                int
                f_10120_4403_4469(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 4403, 4469);
                    return 0;
                }


                bool
                f_10120_4491_4513(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 4491, 4513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10120_4516_4547(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 4516, 4547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 4256, 4568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 4256, 4568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanBeHiddenByMemberKind(this MethodSymbol hiddenMethod, SymbolKind hidingMemberKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 4873, 5882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5001, 5044);

                f_10120_5001_5043((object)hiddenMethod != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5141, 5255) || true) && (f_10120_5145_5168(hiddenMethod) == MethodKind.Destructor)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 5141, 5255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5227, 5240);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 5141, 5255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5271, 5871);

                switch (hidingMemberKind)
                {

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                    case SymbolKind.Method:
                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 5271, 5871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5505, 5560);

                        return f_10120_5512_5559(hiddenMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 5271, 5871);

                    case SymbolKind.Field:
                    case SymbolKind.Event: // Events are not covered by CSemanticChecker::FindSymHiddenByMethPropAgg.
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 5271, 5871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5737, 5749);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 5271, 5871);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 5271, 5871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 5797, 5856);

                        throw f_10120_5803_5855(hidingMemberKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 5271, 5871);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 4873, 5882);

                int
                f_10120_5001_5043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 5001, 5043);
                    return 0;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10120_5145_5168(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 5145, 5168);
                    return return_v;
                }


                bool
                f_10120_5512_5559(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = CanBeHiddenByMethodPropertyOrType(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 5512, 5559);
                    return return_v;
                }


                System.Exception
                f_10120_5803_5855(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 5803, 5855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 4873, 5882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 4873, 5882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool CanBeHiddenByMethodPropertyOrType(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 6118, 6936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 6217, 6925);

                switch (f_10120_6225_6242(method))
                {

                    case MethodKind.Destructor:
                    case MethodKind.Constructor:
                    case MethodKind.StaticConstructor:
                    case MethodKind.UserDefinedOperator:
                    case MethodKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 6217, 6925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 6592, 6605);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 6217, 6925);

                    case MethodKind.EventAdd:
                    case MethodKind.EventRemove:
                    case MethodKind.PropertyGet:
                    case MethodKind.PropertySet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 6217, 6925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 6808, 6850);

                        return f_10120_6815_6849(method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 6217, 6925);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 6217, 6925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 6898, 6910);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 6217, 6925);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 6118, 6936);

                Microsoft.CodeAnalysis.MethodKind
                f_10120_6225_6242(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 6225, 6242);
                    return return_v;
                }


                bool
                f_10120_6815_6849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol)
                {
                    var return_v = methodSymbol.IsIndexedPropertyAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 6815, 6849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 6118, 6936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 6118, 6936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAsyncReturningVoid(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 7063, 7208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 7153, 7197);

                return f_10120_7160_7174(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 7160, 7196) && f_10120_7178_7196(method));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 7063, 7208);

                bool
                f_10120_7160_7174(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7160, 7174);
                    return return_v;
                }


                bool
                f_10120_7178_7196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7178, 7196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 7063, 7208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 7063, 7208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAsyncReturningTask(this MethodSymbol method, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 7337, 7563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 7458, 7552);

                return f_10120_7465_7479(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 7465, 7551) && f_10120_7500_7551(f_10120_7500_7517(method), compilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 7337, 7563);

                bool
                f_10120_7465_7479(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7465, 7479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10120_7500_7517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7500, 7517);
                    return return_v;
                }


                bool
                f_10120_7500_7551(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsNonGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 7500, 7551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 7337, 7563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 7337, 7563);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAsyncReturningGenericTask(this MethodSymbol method, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 7700, 7930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 7828, 7919);

                return f_10120_7835_7849(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 7835, 7918) && f_10120_7870_7918(f_10120_7870_7887(method), compilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 7700, 7930);

                bool
                f_10120_7835_7849(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7835, 7849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10120_7870_7887(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 7870, 7887);
                    return return_v;
                }


                bool
                f_10120_7870_7918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 7870, 7918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 7700, 7930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 7700, 7930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAsyncReturningIAsyncEnumerable(this MethodSymbol method, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 8074, 8314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 8207, 8303);

                return f_10120_8214_8228(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 8214, 8302) && f_10120_8249_8302(f_10120_8249_8266(method), compilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 8074, 8314);

                bool
                f_10120_8214_8228(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 8214, 8228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10120_8249_8266(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 8249, 8266);
                    return return_v;
                }


                bool
                f_10120_8249_8302(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsIAsyncEnumerableType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 8249, 8302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 8074, 8314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 8074, 8314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAsyncReturningIAsyncEnumerator(this MethodSymbol method, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 8458, 8698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 8591, 8687);

                return f_10120_8598_8612(method) && (DynAbs.Tracing.TraceSender.Expression_True(10120, 8598, 8686) && f_10120_8633_8686(f_10120_8633_8650(method), compilation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 8458, 8698);

                bool
                f_10120_8598_8612(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 8598, 8612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10120_8633_8650(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 8633, 8650);
                    return return_v;
                }


                bool
                f_10120_8633_8686(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsIAsyncEnumeratorType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 8633, 8686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 8458, 8698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 8458, 8698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CSharpSyntaxNode ExtractReturnTypeSyntax(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10120, 8710, 9626);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 8817, 8986) || true) && (method is SynthesizedSimpleProgramEntryPointSymbol synthesized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 8817, 8986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 8917, 8971);

                    return (CSharpSyntaxNode)f_10120_8942_8970(synthesized);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 8817, 8986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9002, 9050);

                method = f_10120_9011_9039(method) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(10120, 9011, 9049) ?? method);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9064, 9541);
                    foreach (var reference in f_10120_9090_9122_I(f_10120_9090_9122(method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 9064, 9541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9156, 9196);

                        SyntaxNode
                        node = f_10120_9174_9195(reference)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9214, 9526) || true) && (node is MethodDeclarationSyntax methodDeclaration)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 9214, 9526);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9309, 9345);

                            return f_10120_9316_9344(methodDeclaration);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 9214, 9526);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 9214, 9526);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9387, 9526) || true) && (node is LocalFunctionStatementSyntax statement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10120, 9387, 9526);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9479, 9507);

                                return f_10120_9486_9506(statement);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 9387, 9526);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 9214, 9526);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10120, 9064, 9541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10120, 1, 478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10120, 1, 478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10120, 9557, 9615);

                return (CSharpSyntaxNode)f_10120_9582_9614(CSharpSyntaxTree.Dummy);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10120, 8710, 9626);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10120_8942_8970(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 8942, 8970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10120_9011_9039(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 9011, 9039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10120_9090_9122(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 9090, 9122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10120_9174_9195(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 9174, 9195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10120_9316_9344(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 9316, 9344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10120_9486_9506(Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10120, 9486, 9506);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10120_9090_9122_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 9090, 9122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10120_9582_9614(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10120, 9582, 9614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10120, 8710, 9626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 8710, 9626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodSymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10120, 564, 9633);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10120, 564, 9633);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10120, 564, 9633);
        }

    }
}
