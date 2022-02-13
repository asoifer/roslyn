// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static class VarianceSafety
    {
        internal static void CheckInterfaceVarianceSafety(this NamedTypeSymbol interfaceType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 1109, 2786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 1246, 1319);

                f_10180_1246_1318((object)interfaceType != null && (DynAbs.Tracing.TraceSender.Expression_True(10180, 1259, 1317) && f_10180_1292_1317(interfaceType)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 1335, 1813);
                    foreach (NamedTypeSymbol baseInterface in f_10180_1377_1423_I(f_10180_1377_1423(interfaceType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1335, 1813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 1457, 1798);

                        f_10180_1457_1797(baseInterface, requireOutputSafety: true, requireInputSafety: false, context: baseInterface, locationProvider: i => null, locationArg: baseInterface, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1335, 1813);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 479);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 479);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 1829, 2775);
                    foreach (Symbol member in f_10180_1855_1890_I(f_10180_1855_1890(interfaceType)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1829, 2775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 1924, 2760);

                        switch (f_10180_1932_1943(member))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1924, 2760);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 2034, 2204) || true) && (!f_10180_2039_2058(member))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 2034, 2204);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 2116, 2177);

                                    f_10180_2116_2176(member, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 2034, 2204);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10180, 2230, 2236);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1924, 2760);

                            case SymbolKind.Property:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1924, 2760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 2309, 2374);

                                f_10180_2309_2373(member, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10180, 2400, 2406);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1924, 2760);

                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1924, 2760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 2476, 2535);

                                f_10180_2476_2534(member, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10180, 2561, 2567);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1924, 2760);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 1924, 2760);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 2641, 2709);

                                f_10180_2641_2708(member, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceBreak(10180, 2735, 2741);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1924, 2760);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 1829, 2775);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 947);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 1109, 2786);

                bool
                f_10180_1292_1317(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 1292, 1317);
                    return return_v;
                }


                int
                f_10180_1246_1318(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1246, 1318);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10180_1377_1423(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1377, 1423);
                    return return_v;
                }


                bool
                f_10180_1457_1797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(namedType, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: (Microsoft.CodeAnalysis.CSharp.Symbol)context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1457, 1797);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10180_1377_1423_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1377, 1423);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10180_1855_1890(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1855, 1890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10180_1932_1943(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 1932, 1943);
                    return return_v;
                }


                bool
                f_10180_2039_2058(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 2039, 2058);
                    return return_v;
                }


                int
                f_10180_2116_2176(Microsoft.CodeAnalysis.CSharp.Symbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ((MethodSymbol)method).CheckMethodVarianceSafety(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 2116, 2176);
                    return 0;
                }


                int
                f_10180_2309_2373(Microsoft.CodeAnalysis.CSharp.Symbol
                property, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckPropertyVarianceSafety((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 2309, 2373);
                    return 0;
                }


                int
                f_10180_2476_2534(Microsoft.CodeAnalysis.CSharp.Symbol
                @event, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckEventVarianceSafety((Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol)@event, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 2476, 2534);
                    return 0;
                }


                int
                f_10180_2641_2708(Microsoft.CodeAnalysis.CSharp.Symbol
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckNestedTypeVarianceSafety((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)member, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 2641, 2708);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10180_1855_1890_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 1855, 1890);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 1109, 2786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 1109, 2786);
            }
        }

        private static void CheckNestedTypeVarianceSafety(NamedTypeSymbol member, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 2910, 3867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3035, 3449);

                switch (f_10180_3043_3058(member))
                {

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 3035, 3449);
                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 3210, 3216);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 3035, 3449);

                    case TypeKind.Interface:
                    case TypeKind.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 3035, 3449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3321, 3328);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 3035, 3449);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 3035, 3449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3376, 3434);

                        throw f_10180_3382_3433(f_10180_3417_3432(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 3035, 3449);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3465, 3530);

                NamedTypeSymbol
                container = f_10180_3493_3529(member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3546, 3856) || true) && (container is object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 3546, 3856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3603, 3645);

                    f_10180_3603_3644(f_10180_3616_3643(container));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3663, 3746);

                    f_10180_3663_3745(container.TypeParameters.Any(tp => tp.Variance != VarianceKind.None));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3764, 3841);

                    f_10180_3764_3840(diagnostics, ErrorCode.ERR_VarianceInterfaceNesting, f_10180_3820_3836(member)[0]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 3546, 3856);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 2910, 3867);

                Microsoft.CodeAnalysis.TypeKind
                f_10180_3043_3058(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 3043, 3058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10180_3417_3432(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 3417, 3432);
                    return return_v;
                }


                System.Exception
                f_10180_3382_3433(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3382, 3433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10180_3493_3529(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                member)
                {
                    var return_v = GetEnclosingVariantInterface((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3493, 3529);
                    return return_v;
                }


                bool
                f_10180_3616_3643(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3616, 3643);
                    return return_v;
                }


                int
                f_10180_3603_3644(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3603, 3644);
                    return 0;
                }


                int
                f_10180_3663_3745(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3663, 3745);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10180_3820_3836(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 3820, 3836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10180_3764_3840(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 3764, 3840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 2910, 3867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 2910, 3867);
            }
        }

        internal static NamedTypeSymbol GetEnclosingVariantInterface(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 3879, 4833);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3988, 4021);
                    for (var
        container = f_10180_4000_4021(member)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 3979, 4794) || true) && (container is object)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4044, 4080)
        , container = f_10180_4056_4080(container), DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 3979, 4794))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 3979, 4794);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4114, 4457) || true) && (!f_10180_4119_4146(container))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 4114, 4457);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4188, 4230);

                            f_10180_4188_4229(!f_10180_4202_4228(container));
                            DynAbs.Tracing.TraceSender.TraceBreak(10180, 4432, 4438);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 4114, 4457);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4477, 4688) || true) && (container.TypeParameters.Any(tp => tp.Variance != VarianceKind.None))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 4477, 4688);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4652, 4669);

                            return container;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 4477, 4688);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 4810, 4822);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 3879, 4833);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10180_4000_4021(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 4000, 4021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10180_4056_4080(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 4056, 4080);
                    return return_v;
                }


                bool
                f_10180_4119_4146(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 4119, 4146);
                    return return_v;
                }


                bool
                f_10180_4202_4228(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 4202, 4228);
                    return return_v;
                }


                int
                f_10180_4188_4229(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 4188, 4229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 3879, 4833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 3879, 4833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void CheckDelegateVarianceSafety(this SourceDelegateMethodSymbol method, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 4974, 5474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 5114, 5463);

                f_10180_5114_5462(method, returnTypeLocationProvider: m =>
                        {
                            var syntax = m.GetDeclaringSyntax<DelegateDeclarationSyntax>();
                            return (syntax == null) ? null : syntax.ReturnType.Location;
                        }, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 4974, 5474);

                int
                f_10180_5114_5462(Microsoft.CodeAnalysis.CSharp.Symbols.SourceDelegateMethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                returnTypeLocationProvider, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    method.CheckMethodVarianceSafety(returnTypeLocationProvider: returnTypeLocationProvider, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 5114, 5462);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 4974, 5474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 4974, 5474);
            }
        }

        private static void CheckMethodVarianceSafety(this MethodSymbol method, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 5624, 6105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 5747, 6094);

                f_10180_5747_6093(method, returnTypeLocationProvider: m =>
                        {
                            var syntax = m.GetDeclaringSyntax<MethodDeclarationSyntax>();
                            return (syntax == null) ? null : syntax.ReturnType.Location;
                        }, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 5624, 6105);

                int
                f_10180_5747_6093(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                returnTypeLocationProvider, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    method.CheckMethodVarianceSafety(returnTypeLocationProvider: returnTypeLocationProvider, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 5747, 6093);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 5624, 6105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 5624, 6105);
            }
        }

        private static void CheckMethodVarianceSafety(this MethodSymbol method, LocationProvider<MethodSymbol> returnTypeLocationProvider, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 6117, 7238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 6299, 6391) || true) && (f_10180_6303_6335(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 6299, 6391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 6369, 6376);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 6299, 6391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 6607, 6685);

                f_10180_6607_6684(f_10180_6641_6662(method), method, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 6796, 7141);

                f_10180_6796_7140(f_10180_6831_6848(method), requireOutputSafety: true, requireInputSafety: f_10180_6931_6945(method) != RefKind.None, context: method, locationProvider: returnTypeLocationProvider, locationArg: method, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7157, 7227);

                f_10180_7157_7226(f_10180_7187_7204(method), method, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 6117, 7238);

                bool
                f_10180_6303_6335(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = SkipVarianceSafetyChecks((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 6303, 6335);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10180_6641_6662(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 6641, 6662);
                    return return_v;
                }


                int
                f_10180_6607_6684(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                context, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckTypeParametersVarianceSafety(typeParameters, context, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 6607, 6684);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10180_6831_6848(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 6831, 6848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10180_6931_6945(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 6931, 6945);
                    return return_v;
                }


                bool
                f_10180_6796_7140(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: (Microsoft.CodeAnalysis.CSharp.Symbol)context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 6796, 7140);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10180_7187_7204(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 7187, 7204);
                    return return_v;
                }


                int
                f_10180_7157_7226(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                context, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckParametersVarianceSafety(parameters, (Microsoft.CodeAnalysis.CSharp.Symbol)context, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 7157, 7226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 6117, 7238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 6117, 7238);
            }
        }

        private static bool SkipVarianceSafetyChecks(Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 7250, 7575);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7334, 7535) || true) && (f_10180_7338_7353(member))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 7334, 7535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7387, 7520);

                    return f_10180_7394_7472(MessageID.IDS_FeatureVarianceSafetyForStaticInterfaceMembers) <= f_10180_7476_7519(f_10180_7476_7503(member));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 7334, 7535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7551, 7564);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 7250, 7575);

                bool
                f_10180_7338_7353(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 7338, 7353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10180_7394_7472(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 7394, 7472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10180_7476_7503(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 7476, 7503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10180_7476_7519(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 7476, 7519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 7250, 7575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 7250, 7575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckPropertyVarianceSafety(PropertySymbol property, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 7727, 8889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7851, 7945) || true) && (f_10180_7855_7889(property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 7851, 7945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7923, 7930);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 7851, 7945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 7961, 8013);

                bool
                hasGetter = (object)f_10180_7986_8004(property) != null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 8027, 8079);

                bool
                hasSetter = (object)f_10180_8052_8070(property) != null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 8093, 8788) || true) && (hasGetter || (DynAbs.Tracing.TraceSender.Expression_False(10180, 8097, 8119) || hasSetter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 8093, 8788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 8153, 8773);

                    f_10180_8153_8772(f_10180_8192_8205(property), requireOutputSafety: hasGetter, requireInputSafety: hasSetter || (DynAbs.Tracing.TraceSender.Expression_False(10180, 8301, 8360) || !(f_10180_8316_8343_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10180_8316_8334(property), 10180, 8316, 8343)?.RefKind) == RefKind.None)), context: property, locationProvider: p =>
                                                {
                                                    var syntax = p.GetDeclaringSyntax<BasePropertyDeclarationSyntax>();
                                                    return (syntax == null) ? null : syntax.Type.Location;
                                                }, locationArg: property, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 8093, 8788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 8804, 8878);

                f_10180_8804_8877(f_10180_8834_8853(property), property, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 7727, 8889);

                bool
                f_10180_7855_7889(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                member)
                {
                    var return_v = SkipVarianceSafetyChecks((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 7855, 7889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10180_7986_8004(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 7986, 8004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10180_8052_8070(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 8052, 8070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10180_8192_8205(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 8192, 8205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10180_8316_8334(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 8316, 8334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind?
                f_10180_8316_8343_M(Microsoft.CodeAnalysis.RefKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 8316, 8343);
                    return return_v;
                }


                bool
                f_10180_8153_8772(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: (Microsoft.CodeAnalysis.CSharp.Symbol)context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 8153, 8772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10180_8834_8853(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 8834, 8853);
                    return return_v;
                }


                int
                f_10180_8804_8877(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                context, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    CheckParametersVarianceSafety(parameters, (Microsoft.CodeAnalysis.CSharp.Symbol)context, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 8804, 8877);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 7727, 8889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 7727, 8889);
            }
        }

        private static void CheckEventVarianceSafety(EventSymbol @event, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 9038, 9580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 9154, 9246) || true) && (f_10180_9158_9190(@event))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 9154, 9246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 9224, 9231);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 9154, 9246);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 9262, 9569);

                f_10180_9262_9568(f_10180_9297_9308(@event), requireOutputSafety: false, requireInputSafety: true, context: @event, locationProvider: e => e.Locations[0], locationArg: @event, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 9038, 9580);

                bool
                f_10180_9158_9190(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                member)
                {
                    var return_v = SkipVarianceSafetyChecks((Microsoft.CodeAnalysis.CSharp.Symbol)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 9158, 9190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10180_9297_9308(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 9297, 9308);
                    return return_v;
                }


                bool
                f_10180_9262_9568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: (Microsoft.CodeAnalysis.CSharp.Symbol)context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 9262, 9568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 9038, 9580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 9038, 9580);
            }
        }

        private static void CheckParametersVarianceSafety(ImmutableArray<ParameterSymbol> parameters, Symbol context, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 9749, 10578);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 9910, 10567);
                    foreach (ParameterSymbol param in f_10180_9944_9954_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 9910, 10567);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 9988, 10552);

                        f_10180_9988_10551(f_10180_10027_10037(param), requireOutputSafety: f_10180_10081_10094(param) != RefKind.None, requireInputSafety: true, context: context, locationProvider: p =>
                                                 {
                                                     var syntax = p.GetDeclaringSyntax<ParameterSyntax>();
                                                     return (syntax == null) ? null : syntax.Type.Location;
                                                 }, locationArg: param, diagnostics: diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 9910, 10567);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 658);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 9749, 10578);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10180_10027_10037(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 10027, 10037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10180_10081_10094(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 10081, 10094);
                    return return_v;
                }


                bool
                f_10180_9988_10551(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 9988, 10551);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10180_9944_9954_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 9944, 9954);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 9749, 10578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 9749, 10578);
            }
        }

        private static void CheckTypeParametersVarianceSafety(ImmutableArray<TypeParameterSymbol> typeParameters, MethodSymbol context, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 10744, 11553);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 10923, 11542);
                    foreach (TypeParameterSymbol typeParameter in f_10180_10969_10983_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 10923, 11542);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 11017, 11527);
                            foreach (TypeWithAnnotations constraintType in f_10180_11064_11113_I(f_10180_11064_11113(typeParameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 11017, 11527);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 11155, 11508);

                                f_10180_11155_11507(constraintType.Type, requireOutputSafety: false, requireInputSafety: true, context: context, locationProvider: t => t.Locations[0], locationArg: typeParameter, diagnostics: diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 11017, 11527);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 511);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 511);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 10923, 11542);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 620);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 10744, 11553);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10180_11064_11113(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 11064, 11113);
                    return return_v;
                }


                bool
                f_10180_11155_11507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                locationProvider, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety: requireOutputSafety, requireInputSafety: requireInputSafety, context: (Microsoft.CodeAnalysis.CSharp.Symbol)context, locationProvider: locationProvider, locationArg: locationArg, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 11155, 11507);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10180_11064_11113_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 11064, 11113);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10180_10969_10983_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 10969, 10983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 10744, 11553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 10744, 11553);
            }
        }

        private static bool IsVarianceUnsafe<T>(
                    TypeSymbol type,
                    bool requireOutputSafety,
                    bool requireInputSafety,
                    Symbol context,
                    LocationProvider<T> locationProvider,
                    T locationArg,
                    DiagnosticBag diagnostics)
                    where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 12200, 15215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 12550, 12606);

                f_10180_12550_12605<T>(requireOutputSafety || (DynAbs.Tracing.TraceSender.Expression_False(10180, 12563, 12604) || requireInputSafety));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 12714, 15204);

                switch (f_10180_12722_12731<T>(type))
                {

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12714, 15204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 12892, 12950);

                        TypeParameterSymbol
                        typeParam = (TypeParameterSymbol)type
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 12972, 14445) || true) && (requireInputSafety && (DynAbs.Tracing.TraceSender.Expression_True(10180, 12976, 13017) && requireOutputSafety) && (DynAbs.Tracing.TraceSender.Expression_True(10180, 12976, 13060) && f_10180_13021_13039<T>(typeParam) != VarianceKind.None))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12972, 14445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13399, 13506);

                            f_10180_13399_13505<T>(                        // This sub-case isn't mentioned in the spec, because it's not required for
                                                                           // the definition.  It just allows us to give a better error message for
                                                                           // type parameters that are both output-unsafe and input-unsafe.
                                                    diagnostics, typeParam, context, locationProvider, locationArg, MessageID.IDS_Invariantly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13532, 13544);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12972, 14445);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12972, 14445);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13594, 14445) || true) && (requireOutputSafety && (DynAbs.Tracing.TraceSender.Expression_True(10180, 13598, 13658) && f_10180_13621_13639<T>(typeParam) == VarianceKind.In))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 13594, 14445);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13781, 13888);

                                f_10180_13781_13887<T>(                        // The is output-unsafe case (1) from the spec.
                                                        diagnostics, typeParam, context, locationProvider, locationArg, MessageID.IDS_Covariantly);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13914, 13926);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 13594, 14445);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 13594, 14445);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 13976, 14445) || true) && (requireInputSafety && (DynAbs.Tracing.TraceSender.Expression_True(10180, 13980, 14040) && f_10180_14002_14020<T>(typeParam) == VarianceKind.Out))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 13976, 14445);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14162, 14273);

                                    f_10180_14162_14272<T>(                        // The is input-unsafe case (1) from the spec.
                                                            diagnostics, typeParam, context, locationProvider, locationArg, MessageID.IDS_Contravariantly);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14299, 14311);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 13976, 14445);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 13976, 14445);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14409, 14422);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 13976, 14445);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 13594, 14445);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12972, 14445);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12714, 15204);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12714, 15204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14607, 14762);

                        return f_10180_14614_14761<T>(f_10180_14631_14666<T>(((ArrayTypeSymbol)type)), requireOutputSafety, requireInputSafety, context, locationProvider, locationArg, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12714, 15204);

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12714, 15204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14872, 14910);

                        var
                        namedType = (NamedTypeSymbol)type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 14999, 15128);

                        return f_10180_15006_15127<T>(namedType, requireOutputSafety, requireInputSafety, context, locationProvider, locationArg, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12714, 15204);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 12714, 15204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 15176, 15189);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 12714, 15204);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 12200, 15215);

                int
                f_10180_12550_12605<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 12550, 12605);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10180_12722_12731<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 12722, 12731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_13021_13039<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 13021, 13039);
                    return return_v;
                }


                int
                f_10180_13399_13505<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                unsafeTypeParameter, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.CSharp.MessageID
                expectedVariance) where T : Symbol

                {
                    diagnostics.AddVarianceError<T>(unsafeTypeParameter, context, locationProvider, locationArg, expectedVariance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 13399, 13505);
                    return 0;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_13621_13639<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 13621, 13639);
                    return return_v;
                }


                int
                f_10180_13781_13887<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                unsafeTypeParameter, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.CSharp.MessageID
                expectedVariance) where T : Symbol

                {
                    diagnostics.AddVarianceError<T>(unsafeTypeParameter, context, locationProvider, locationArg, expectedVariance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 13781, 13887);
                    return 0;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_14002_14020<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 14002, 14020);
                    return return_v;
                }


                int
                f_10180_14162_14272<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                unsafeTypeParameter, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.CSharp.MessageID
                expectedVariance) where T : Symbol

                {
                    diagnostics.AddVarianceError<T>(unsafeTypeParameter, context, locationProvider, locationArg, expectedVariance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 14162, 14272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10180_14631_14666<T>(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 14631, 14666);
                    return return_v;
                }


                bool
                f_10180_14614_14761<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : Symbol

                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety, requireInputSafety, context, locationProvider, locationArg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 14614, 14761);
                    return return_v;
                }


                bool
                f_10180_15006_15127<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedType, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : Symbol

                {
                    var return_v = IsVarianceUnsafe(namedType, requireOutputSafety, requireInputSafety, context, locationProvider, locationArg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 15006, 15127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 12200, 15215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 12200, 15215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsVarianceUnsafe<T>(
                    NamedTypeSymbol namedType,
                    bool requireOutputSafety,
                    bool requireInputSafety,
                    Symbol context,
                    LocationProvider<T> locationProvider,
                    T locationArg,
                    DiagnosticBag diagnostics)
                    where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 16063, 18781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 16423, 16479);

                f_10180_16423_16478<T>(requireOutputSafety || (DynAbs.Tracing.TraceSender.Expression_False(10180, 16436, 16477) || requireInputSafety));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 16495, 16927);

                switch (f_10180_16503_16521<T>(namedType))
                {

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Enum: // Can't be generic, but can be nested in generic.
                    case TypeKind.Interface:
                    case TypeKind.Delegate:
                    case TypeKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 16495, 16927);
                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 16845, 16851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 16495, 16927);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 16495, 16927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 16899, 16912);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 16495, 16927);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 16943, 18741) || true) && ((object)namedType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 16943, 18741);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17018, 17023);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17009, 18669) || true) && (i < f_10180_17029_17044<T>(namedType))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17046, 17049)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 17009, 18669))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 17009, 18669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17091, 17151);

                                TypeParameterSymbol
                                typeParam = f_10180_17123_17147<T>(namedType)[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17173, 17261);

                                TypeSymbol
                                typeArg = f_10180_17194_17252<T>(namedType)[i].Type
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17285, 17301);

                                bool
                                requireOut
                                = default(bool);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17323, 17338);

                                bool
                                requireIn
                                = default(bool);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17362, 18436);

                                switch (f_10180_17370_17388<T>(typeParam))
                                {

                                    case VarianceKind.Out:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 17362, 18436);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17582, 17615);

                                        requireOut = requireOutputSafety;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17645, 17676);

                                        requireIn = requireInputSafety;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 17706, 17712);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 17362, 18436);

                                    case VarianceKind.In:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 17362, 18436);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17885, 17917);

                                        requireOut = requireInputSafety;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 17947, 17979);

                                        requireIn = requireOutputSafety;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 18009, 18015);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 17362, 18436);

                                    case VarianceKind.None:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 17362, 18436);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18187, 18204);

                                        requireIn = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18234, 18252);

                                        requireOut = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 18282, 18288);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 17362, 18436);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 17362, 18436);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18352, 18413);

                                        throw f_10180_18358_18412<T>(f_10180_18393_18411<T>(typeParam));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 17362, 18436);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18460, 18650) || true) && (f_10180_18464_18565<T>(typeArg, requireOut, requireIn, context, locationProvider, locationArg, diagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 18460, 18650);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18615, 18627);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 18460, 18650);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 1, 1661);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 1, 1661);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18689, 18726);

                        namedType = f_10180_18701_18725<T>(namedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 16943, 18741);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10180, 16943, 18741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10180, 16943, 18741);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 18757, 18770);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 16063, 18781);

                int
                f_10180_16423_16478<T>(bool
                condition) where T : Symbol

                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 16423, 16478);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10180_16503_16521<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 16503, 16521);
                    return return_v;
                }


                int
                f_10180_17029_17044<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 17029, 17044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10180_17123_17147<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 17123, 17147);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10180_17194_17252<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 17194, 17252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_17370_17388<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 17370, 17388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_18393_18411<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 18393, 18411);
                    return return_v;
                }


                System.Exception
                f_10180_18358_18412<T>(Microsoft.CodeAnalysis.VarianceKind
                o) where T : Symbol

                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 18358, 18412);
                    return return_v;
                }


                bool
                f_10180_18464_18565<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                requireOutputSafety, bool
                requireInputSafety, Microsoft.CodeAnalysis.CSharp.Symbol
                context, Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                locationProvider, T
                locationArg, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics) where T : Symbol

                {
                    var return_v = IsVarianceUnsafe(type, requireOutputSafety, requireInputSafety, context, locationProvider, locationArg, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 18464, 18565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10180_18701_18725<T>(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 18701, 18725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 16063, 18781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 16063, 18781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }



        private delegate Location LocationProvider<T>(T arg);

        private static void AddVarianceError<T>(
                    this DiagnosticBag diagnostics,
                    TypeParameterSymbol unsafeTypeParameter,
                    Symbol context,
                    LocationProvider<T> locationProvider,
                    T locationArg,
                    MessageID expectedVariance)
                    where T : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 19559, 21992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 19902, 19927);

                MessageID
                actualVariance
                = default(MessageID);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 19941, 20392);

                switch (f_10180_19949_19977<T>(unsafeTypeParameter))
                {

                    case VarianceKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 19941, 20392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 20054, 20099);

                        actualVariance = MessageID.IDS_Contravariant;
                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 20121, 20127);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 19941, 20392);

                    case VarianceKind.Out:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 19941, 20392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 20189, 20230);

                        actualVariance = MessageID.IDS_Covariant;
                        DynAbs.Tracing.TraceSender.TraceBreak(10180, 20252, 20258);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 19941, 20392);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 19941, 20392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 20306, 20377);

                        throw f_10180_20312_20376<T>(f_10180_20347_20375<T>(unsafeTypeParameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 19941, 20392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 20873, 20954);

                var
                location = f_10180_20888_20917<T>(locationProvider, locationArg) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location>(10180, 20888, 20953) ?? f_10180_20921_20950<T>(unsafeTypeParameter)[0])
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 21366, 21981) || true) && (!(context is TypeSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10180, 21370, 21414) && f_10180_21398_21414<T>(context)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 21366, 21981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 21448, 21754);

                    f_10180_21448_21753<T>(diagnostics, ErrorCode.ERR_UnexpectedVarianceStaticMember, location, context, unsafeTypeParameter, f_10180_21550_21575<T>(actualVariance), f_10180_21577_21604<T>(expectedVariance), f_10180_21639_21752<T>(f_10180_21673_21751<T>(MessageID.IDS_FeatureVarianceSafetyForStaticInterfaceMembers)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 21366, 21981);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 21366, 21981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 21820, 21966);

                    f_10180_21820_21965<T>(diagnostics, ErrorCode.ERR_UnexpectedVariance, location, context, unsafeTypeParameter, f_10180_21910_21935<T>(actualVariance), f_10180_21937_21964<T>(expectedVariance));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 21366, 21981);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 19559, 21992);

                Microsoft.CodeAnalysis.VarianceKind
                f_10180_19949_19977<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 19949, 19977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10180_20347_20375<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 20347, 20375);
                    return return_v;
                }


                System.Exception
                f_10180_20312_20376<T>(Microsoft.CodeAnalysis.VarianceKind
                o) where T : Symbol

                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 20312, 20376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10180_20888_20917<T>(Microsoft.CodeAnalysis.CSharp.Symbols.VarianceSafety.LocationProvider<T>
                this_param, T
                arg) where T : Symbol

                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 20888, 20917);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10180_20921_20950<T>(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 20921, 20950);
                    return return_v;
                }


                bool
                f_10180_21398_21414<T>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where T : Symbol

                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 21398, 21414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10180_21550_21575<T>(Microsoft.CodeAnalysis.CSharp.MessageID
                id) where T : Symbol

                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21550, 21575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10180_21577_21604<T>(Microsoft.CodeAnalysis.CSharp.MessageID
                id) where T : Symbol

                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21577, 21604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10180_21673_21751<T>(Microsoft.CodeAnalysis.CSharp.MessageID
                feature) where T : Symbol

                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21673, 21751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10180_21639_21752<T>(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version) where T : Symbol

                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21639, 21752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10180_21448_21753<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args) where T : Symbol

                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21448, 21753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10180_21910_21935<T>(Microsoft.CodeAnalysis.CSharp.MessageID
                id) where T : Symbol

                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21910, 21935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10180_21937_21964<T>(Microsoft.CodeAnalysis.CSharp.MessageID
                id) where T : Symbol

                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21937, 21964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10180_21820_21965<T>(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args) where T : Symbol

                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 21820, 21965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 19559, 21992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 19559, 21992);
            }
        }

        private static T GetDeclaringSyntax<T>(this Symbol symbol) where T : SyntaxNode
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10180, 22004, 22322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 22108, 22158);

                var
                syntaxRefs = f_10180_22125_22157<T>(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 22172, 22259) || true) && (syntaxRefs.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10180, 22172, 22259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 22232, 22244);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10180, 22172, 22259);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10180, 22273, 22311);

                return f_10180_22280_22305<T>(syntaxRefs[0]) as T;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10180, 22004, 22322);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                f_10180_22125_22157<T>(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param) where T : SyntaxNode

                {
                    var return_v = this_param.DeclaringSyntaxReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10180, 22125, 22157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10180_22280_22305<T>(Microsoft.CodeAnalysis.SyntaxReference
                this_param) where T : SyntaxNode

                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10180, 22280, 22305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10180, 22004, 22322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 22004, 22322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VarianceSafety()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10180, 880, 22370);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10180, 880, 22370);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10180, 880, 22370);
        }

    }
}
