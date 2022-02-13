// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal void LookupSymbolsSimpleName(
                    LookupResult result,
                    NamespaceOrTypeSymbol qualifierOpt,
                    string plainName,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 942, 1750);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 1322, 1739) || true) && (f_10312_1326_1357(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 1322, 1739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 1391, 1519);

                    f_10312_1391_1518(this, result, qualifierOpt, plainName, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 1322, 1739);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 1322, 1739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 1585, 1724);

                    f_10312_1585_1723(this, result, qualifierOpt, plainName, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 1322, 1739);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 942, 1750);

                bool
                f_10312_1326_1357(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 1326, 1357);
                    return return_v;
                }


                int
                f_10312_1391_1518(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupAttributeType(result, qualifierOpt, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 1391, 1518);
                    return 0;
                }


                int
                f_10312_1585_1723(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsOrMembersInternal(result, qualifierOpt, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 1585, 1723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 942, 1750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 942, 1750);
            }
        }

        internal void LookupExtensionMethods(LookupResult result, string name, int arity, LookupOptions options, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 1762, 2155);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 1939, 2144);
                    foreach (var scope in f_10312_1961_1992_I(f_10312_1961_1992(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 1939, 2144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 2026, 2129);

                        f_10312_2026_2128(this, scope, result, name, arity, options, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 1939, 2144);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 206);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 1762, 2155);

                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopes
                f_10312_1961_1992(Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopes(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 1961, 1992);
                    return return_v;
                }


                int
                f_10312_2026_2128(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope
                scope, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupExtensionMethodsInSingleBinder(scope, result, name, arity, options, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 2026, 2128);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopes
                f_10312_1961_1992_I(Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopes
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 1961, 1992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 1762, 2155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 1762, 2155);
            }
        }

        private Binder LookupSymbolsWithFallback(LookupResult result, string name, int arity, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved = null, LookupOptions options = LookupOptions.Default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 2483, 3633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 2736, 2769);

                f_10312_2736_2768(f_10312_2749_2767(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 2854, 3005);

                var
                binder = f_10312_2867_3004(this, result, name, arity, basesBeingResolved, options, diagnose: false, useSiteDiagnostics: ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3019, 3068);

                f_10312_3019_3067((binder != null) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 3032, 3066) || f_10312_3052_3066(result)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3084, 3501) || true) && (f_10312_3088_3099(result) != LookupResultKind.Viable && (DynAbs.Tracing.TraceSender.Expression_True(10312, 3088, 3167) && f_10312_3130_3141(result) != LookupResultKind.Empty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 3084, 3501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3201, 3216);

                    f_10312_3201_3215(result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3277, 3432);

                    var
                    otherBinder = f_10312_3295_3431(this, result, name, arity, basesBeingResolved, options, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3450, 3486);

                    f_10312_3450_3485(binder == otherBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 3084, 3501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3517, 3594);

                f_10312_3517_3593(f_10312_3530_3550(result) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 3530, 3568) || f_10312_3554_3568(result)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 3530, 3592) || f_10312_3572_3584(result) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3608, 3622);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 2483, 3633);

                bool
                f_10312_2749_2767(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 2749, 2767);
                    return return_v;
                }


                int
                f_10312_2736_2768(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 2736, 2768);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10312_2867_3004(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LookupSymbolsInternal(result, name, arity, basesBeingResolved, options, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 2867, 3004);
                    return return_v;
                }


                bool
                f_10312_3052_3066(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3052, 3066);
                    return return_v;
                }


                int
                f_10312_3019_3067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3019, 3067);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10312_3088_3099(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3088, 3099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10312_3130_3141(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3130, 3141);
                    return return_v;
                }


                int
                f_10312_3201_3215(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3201, 3215);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10312_3295_3431(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LookupSymbolsInternal(result, name, arity, basesBeingResolved, options, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3295, 3431);
                    return return_v;
                }


                int
                f_10312_3450_3485(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3450, 3485);
                    return 0;
                }


                bool
                f_10312_3530_3550(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3530, 3550);
                    return return_v;
                }


                bool
                f_10312_3554_3568(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3554, 3568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10312_3572_3584(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3572, 3584);
                    return return_v;
                }


                int
                f_10312_3517_3593(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3517, 3593);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 2483, 3633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 2483, 3633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder LookupSymbolsInternal(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 3645, 5112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3892, 3921);

                f_10312_3892_3920(f_10312_3905_3919(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3935, 3968);

                f_10312_3935_3967(f_10312_3948_3966(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 3984, 4005);

                Binder
                binder = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4028, 4040);
                    for (var
        scope = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4019, 5073) || true) && (scope != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 4042, 4080) && f_10312_4059_4080_M(!result.IsMultiViable)))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4082, 4100)
        , scope = f_10312_4090_4100(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 4019, 5073))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 4019, 5073);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4134, 4806) || true) && (binder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 4134, 4806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4194, 4231);

                            var
                            tmp = f_10312_4204_4230()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4253, 4374);

                            f_10312_4253_4373(scope, tmp, name, arity, basesBeingResolved, options, this, diagnose, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4396, 4419);

                            f_10312_4396_4418(result, tmp);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4441, 4452);

                            f_10312_4441_4451(tmp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 4134, 4806);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 4134, 4806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4534, 4658);

                            f_10312_4534_4657(scope, result, name, arity, basesBeingResolved, options, this, diagnose, ref useSiteDiagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4680, 4787) || true) && (f_10312_4684_4699_M(!result.IsClear))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 4680, 4787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4749, 4764);

                                binder = scope;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 4680, 4787);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 4134, 4806);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 4826, 5058) || true) && ((options & LookupOptions.LabelsOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 4830, 4907) && f_10312_4875_4907(scope)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 4826, 5058);
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 5033, 5039);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 4826, 5058);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 1055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 1055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 5087, 5101);

                return binder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 3645, 5112);

                bool
                f_10312_3905_3919(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 3905, 3919);
                    return return_v;
                }


                int
                f_10312_3892_3920(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3892, 3920);
                    return 0;
                }


                bool
                f_10312_3948_3966(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3948, 3966);
                    return return_v;
                }


                int
                f_10312_3935_3967(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 3935, 3967);
                    return 0;
                }


                bool
                f_10312_4059_4080_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 4059, 4080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10312_4090_4100(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 4090, 4100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_4204_4230()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4204, 4230);
                    return return_v;
                }


                int
                f_10312_4253_4373(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsInSingleBinder(result, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4253, 4373);
                    return 0;
                }


                int
                f_10312_4396_4418(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.MergeEqual(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4396, 4418);
                    return 0;
                }


                int
                f_10312_4441_4451(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4441, 4451);
                    return 0;
                }


                int
                f_10312_4534_4657(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsInSingleBinder(result, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4534, 4657);
                    return 0;
                }


                bool
                f_10312_4684_4699_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 4684, 4699);
                    return return_v;
                }


                bool
                f_10312_4875_4907(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsLastBinderWithinMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 4875, 4907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 3645, 5112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 3645, 5112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 5124, 5404);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 5124, 5404);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 5124, 5404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 5124, 5404);
            }
        }

        private void LookupSymbolsOrMembersInternal(
                    LookupResult result,
                    NamespaceOrTypeSymbol qualifierOpt,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 5663, 6444);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 6044, 6433) || true) && ((object)qualifierOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 6044, 6433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 6110, 6221);

                    f_10312_6110_6220(this, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 6044, 6433);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 6044, 6433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 6287, 6418);

                    f_10312_6287_6417(this, result, qualifierOpt, name, arity, basesBeingResolved, options, this, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 6044, 6433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 5663, 6444);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10312_6110_6220(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.LookupSymbolsInternal(result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 6110, 6220);
                    return return_v;
                }


                int
                f_10312_6287_6417(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, nsOrType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 6287, 6417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 5663, 6444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 5663, 6444);
            }
        }

        private void LookupMembersWithFallback(LookupResult result, NamespaceOrTypeSymbol nsOrType, string name, int arity, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved = null, LookupOptions options = LookupOptions.Default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 6586, 7603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 6869, 6902);

                f_10312_6869_6901(f_10312_6882_6900(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 6977, 7147);

                f_10312_6977_7146(
                            // don't create diagnosis unless lookup fails
                            this, result, nsOrType, name, arity, basesBeingResolved, options, originalBinder: this, diagnose: false, useSiteDiagnostics: ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7161, 7499) || true) && (f_10312_7165_7186_M(!result.IsMultiViable) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 7165, 7205) && f_10312_7190_7205_M(!result.IsClear)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 7161, 7499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7239, 7254);

                    f_10312_7239_7253(result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7315, 7484);

                    f_10312_7315_7483(                // retry to get diagnosis
                                    this, result, nsOrType, name, arity, basesBeingResolved, options, originalBinder: this, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 7161, 7499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7515, 7592);

                f_10312_7515_7591(f_10312_7528_7548(result) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 7528, 7566) || f_10312_7552_7566(result)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 7528, 7590) || f_10312_7570_7582(result) != null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 6586, 7603);

                bool
                f_10312_6882_6900(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 6882, 6900);
                    return return_v;
                }


                int
                f_10312_6869_6901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 6869, 6901);
                    return 0;
                }


                int
                f_10312_6977_7146(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, nsOrType, name, arity, basesBeingResolved, options, originalBinder: originalBinder, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 6977, 7146);
                    return 0;
                }


                bool
                f_10312_7165_7186_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7165, 7186);
                    return return_v;
                }


                bool
                f_10312_7190_7205_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7190, 7205);
                    return return_v;
                }


                int
                f_10312_7239_7253(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7239, 7253);
                    return 0;
                }


                int
                f_10312_7315_7483(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, nsOrType, name, arity, basesBeingResolved, options, originalBinder: originalBinder, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7315, 7483);
                    return 0;
                }


                bool
                f_10312_7528_7548(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7528, 7548);
                    return return_v;
                }


                bool
                f_10312_7552_7566(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7552, 7566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10312_7570_7582(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7570, 7582);
                    return return_v;
                }


                int
                f_10312_7515_7591(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7515, 7591);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 6586, 7603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 6586, 7603);
            }
        }

        protected void LookupMembersInternal(LookupResult result, NamespaceOrTypeSymbol nsOrType, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 7615, 8420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7903, 7936);

                f_10312_7903_7935(f_10312_7916_7934(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7952, 7977);

                f_10312_7952_7976(arity >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 7991, 8409) || true) && (f_10312_7995_8015(nsOrType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 7991, 8409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 8049, 8181);

                    f_10312_8049_8180(result, nsOrType, name, arity, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 7991, 8409);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 7991, 8409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 8247, 8394);

                    f_10312_8247_8393(this, result, nsOrType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 7991, 8409);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 7615, 8420);

                bool
                f_10312_7916_7934(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7916, 7934);
                    return return_v;
                }


                int
                f_10312_7903_7935(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7903, 7935);
                    return 0;
                }


                int
                f_10312_7952_7976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 7952, 7976);
                    return 0;
                }


                bool
                f_10312_7995_8015(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 7995, 8015);
                    return return_v;
                }


                int
                f_10312_8049_8180(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                ns, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    LookupMembersInNamespace(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)ns, name, arity, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 8049, 8180);
                    return 0;
                }


                int
                f_10312_8247_8393(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInType(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 8247, 8393);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 7615, 8420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 7615, 8420);
            }
        }

        protected void LookupMembersInType(LookupResult result, TypeSymbol type, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 8508, 10685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 8779, 10524);

                switch (f_10312_8787_8800(type))
                {

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 8884, 9045);

                        f_10312_8884_9044(this, result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 9067, 9073);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 9139, 9292);

                        f_10312_9139_9291(this, result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 9314, 9320);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Enum:
                    case TypeKind.Delegate:
                    case TypeKind.Array:
                    case TypeKind.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 9577, 9709);

                        f_10312_9577_9708(this, result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 9731, 9737);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 9804, 9942);

                        f_10312_9804_9941(this, result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 9964, 9970);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 10032, 10180);

                        f_10312_10032_10179(this, result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 10202, 10208);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Pointer:
                    case TypeKind.FunctionPointer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 10320, 10335);

                        f_10312_10320_10334(result);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 10357, 10363);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);

                    case TypeKind.Unknown:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 8779, 10524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 10453, 10509);

                        throw f_10312_10459_10508(f_10312_10494_10507(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 8779, 10524);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 8508, 10685);

                Microsoft.CodeAnalysis.TypeKind
                f_10312_8787_8800(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 8787, 8800);
                    return return_v;
                }


                int
                f_10312_8884_9044(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                current, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeParameter, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInTypeParameter(current, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 8884, 9044);
                    return 0;
                }


                int
                f_10312_9139_9291(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                current, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInInterface(current, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 9139, 9291);
                    return 0;
                }


                int
                f_10312_9577_9708(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInClass(result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 9577, 9708);
                    return 0;
                }


                int
                f_10312_9804_9941(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                submissionClass, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInSubmissions(result, submissionClass, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 9804, 9941);
                    return 0;
                }


                int
                f_10312_10032_10179(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                errorType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInErrorType(result, (Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol)errorType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 10032, 10179);
                    return 0;
                }


                int
                f_10312_10320_10334(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 10320, 10334);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10312_10494_10507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 10494, 10507);
                    return return_v;
                }


                System.Exception
                f_10312_10459_10508(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 10459, 10508);
                    return return_v;
                }


                // TODO: Diagnose ambiguity problems here, and conflicts between non-method and method? Or is that
                // done in the caller?
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 8508, 10685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 8508, 10685);
            }
        }

        private void LookupMembersInErrorType(LookupResult result, ErrorTypeSymbol errorType, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 10697, 11932);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 10981, 11890) || true) && (f_10312_10985_11022_M(!errorType.CandidateSymbols.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 10985, 11064) && errorType.CandidateSymbols.Length == 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 10981, 11890);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11359, 11875) || true) && (f_10312_11363_11383(errorType) == LookupResultKind.Inaccessible)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 11359, 11875);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11458, 11534);

                        TypeSymbol
                        candidateType = errorType.CandidateSymbols.First() as TypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11556, 11856) || true) && ((object)candidateType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 11556, 11856);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11639, 11774);

                            f_10312_11639_11773(this, result, candidateType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11800, 11807);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 11556, 11856);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 11359, 11875);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 10981, 11890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 11906, 11921);

                f_10312_11906_11920(
                            result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 10697, 11932);

                bool
                f_10312_10985_11022_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 10985, 11022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10312_11363_11383(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 11363, 11383);
                    return return_v;
                }


                int
                f_10312_11639_11773(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInType(result, type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 11639, 11773);
                    return 0;
                }


                int
                f_10312_11906_11920(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 11906, 11920);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 10697, 11932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 10697, 11932);
            }
        }

        private void LookupMembersInSubmissions(LookupResult result, TypeSymbol submissionClass, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 12924, 18919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13211, 13271);

                LookupResult
                submissionSymbols = f_10312_13244_13270()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13285, 13337);

                LookupResult
                nonViable = f_10312_13310_13336()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13351, 13396);

                SymbolKind?
                lookingForOverloadsOfKind = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13521, 13545);

                    // TODO: optimize lookup (there might be many interactions in the chain)
                    for (CSharpCompilation
        submission = f_10312_13534_13545()
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13498, 18716) || true) && (submission != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13567, 13609)
        , submission = f_10312_13580_13609(submission), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 13498, 18716))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 13498, 18716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13643, 13669);

                        f_10312_13643_13668(submissionSymbols);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13689, 13741);

                        var
                        isCurrentSubmission = submission == f_10312_13729_13740()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13759, 13853);

                        var
                        considerUsings = !(isCurrentSubmission && (DynAbs.Tracing.TraceSender.Expression_True(10312, 13782, 13851) && f_10312_13805_13851(this.Flags, BinderFlags.InScriptUsing)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13873, 13899);

                        Imports
                        submissionImports
                        = default(Imports);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13917, 14504) || true) && (!considerUsings)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 13917, 14504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 13978, 14012);

                            submissionImports = Imports.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 13917, 14504);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 13917, 14504);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14054, 14504) || true) && (!f_10312_14059_14110(this.Flags, BinderFlags.InLoadedSyntaxTree))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 14054, 14504);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14152, 14206);

                                submissionImports = f_10312_14172_14205(submission);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 14054, 14504);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 14054, 14504);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14248, 14504) || true) && (isCurrentSubmission)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 14248, 14504);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14313, 14369);

                                    submissionImports = f_10312_14333_14368(this, basesBeingResolved);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 14248, 14504);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 14248, 14504);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14451, 14485);

                                    submissionImports = Imports.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 14248, 14504);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 14054, 14504);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 13917, 14504);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14709, 16301) || true) && ((options & LookupOptions.NamespaceAliasesOnly) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 14713, 14806) && (object)f_10312_14776_14798(submission) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 14709, 16301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 14848, 15032);

                            f_10312_14848_15031(submissionSymbols, f_10312_14899_14921(submission), name, arity, options, originalBinder, submissionClass, diagnose, ref useSiteDiagnostics, basesBeingResolved);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 15196, 16282) || true) && (f_10312_15200_15231(submissionSymbols) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 15200, 15274) && considerUsings) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 15200, 15377) && f_10312_15303_15377(submissionImports, name, f_10312_15340_15376(originalBinder))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 15196, 16282);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 15587, 15649);

                                Symbol
                                existingDefinition = f_10312_15615_15648(f_10312_15615_15640(submissionSymbols))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 15675, 16259) || true) && (f_10312_15679_15702(existingDefinition) != SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10312, 15679, 15740) || arity == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 15675, 16259);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 15798, 15932);

                                    CSDiagnosticInfo
                                    diagInfo = f_10312_15826_15931(ErrorCode.ERR_ConflictingAliasAndDefinition, name, f_10312_15898_15930(existingDefinition))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 15962, 16072);

                                    var
                                    error = f_10312_15974_16071((NamespaceOrTypeSymbol)null, name, arity, diagInfo, unreported: true)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 16102, 16143);

                                    f_10312_16102_16142(result, f_10312_16117_16141(error));
                                    DynAbs.Tracing.TraceSender.TraceBreak(10312, 16226, 16232);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 15675, 16259);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 15196, 16282);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 14709, 16301);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 16321, 16987) || true) && (f_10312_16325_16357_M(!submissionSymbols.IsMultiViable) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 16325, 16375) && considerUsings))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 16321, 16987);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 16417, 16606) || true) && (!isCurrentSubmission)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 16417, 16606);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 16491, 16583);

                                submissionImports = f_10312_16511_16582(submissionImports, f_10312_16570_16581());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 16417, 16606);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 16817, 16968);

                            f_10312_16817_16967(
                                                // NB: We diverge from InContainerBinder here and only look in aliases.
                                                // In submissions, regular usings are bubbled up to the outermost scope.
                                                submissionImports, originalBinder, submissionSymbols, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 16321, 16987);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17007, 18701) || true) && (lookingForOverloadsOfKind == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 17007, 18701);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17086, 17408) || true) && (f_10312_17090_17122_M(!submissionSymbols.IsMultiViable))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 17086, 17408);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17304, 17350);

                                f_10312_17304_17349(                        // skip non-viable members, but remember them in case no viable members are found in previous submissions:
                                                        nonViable, submissionSymbols);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17376, 17385);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 17086, 17408);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17432, 17469);

                            f_10312_17432_17468(
                                                result, submissionSymbols);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17493, 17548);

                            Symbol
                            firstSymbol = f_10312_17514_17547(f_10312_17514_17539(submissionSymbols))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17570, 17684) || true) && (!f_10312_17575_17605(firstSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 17570, 17684);
                                DynAbs.Tracing.TraceSender.TraceBreak(10312, 17655, 17661);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 17570, 17684);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17823, 17922);

                            options = options & ~(LookupOptions.MustBeInvocableIfMember | LookupOptions.NamespacesOrTypesOnly);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 17944, 17989);

                            lookingForOverloadsOfKind = f_10312_17972_17988(firstSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 17007, 18701);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 17007, 18701);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18146, 18341) || true) && (f_10312_18150_18181(f_10312_18150_18175(submissionSymbols)) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 18150, 18262) && f_10312_18189_18227(f_10312_18189_18222(f_10312_18189_18214(submissionSymbols))) != f_10312_18231_18262(lookingForOverloadsOfKind)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 18146, 18341);
                                DynAbs.Tracing.TraceSender.TraceBreak(10312, 18312, 18318);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 18146, 18341);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18414, 18682) || true) && (f_10312_18418_18449(submissionSymbols))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 18414, 18682);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18544, 18596);

                                f_10312_18544_18595(f_10312_18557_18594(f_10312_18557_18571(result), IsMethodOrIndexer));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18622, 18659);

                                f_10312_18622_18658(result, submissionSymbols);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 18414, 18682);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 17007, 18701);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 5219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 5219);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18732, 18836) || true) && (f_10312_18736_18756(f_10312_18736_18750(result)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 18732, 18836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18795, 18821);

                    f_10312_18795_18820(result, nonViable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 18732, 18836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18852, 18877);

                f_10312_18852_18876(
                            submissionSymbols);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 18891, 18908);

                f_10312_18891_18907(nonViable);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 12924, 18919);

                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_13244_13270()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 13244, 13270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_13310_13336()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 13310, 13336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_13534_13545()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 13534, 13545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10312_13580_13609(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 13580, 13609);
                    return return_v;
                }


                int
                f_10312_13643_13668(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 13643, 13668);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_13729_13740()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 13729, 13740);
                    return return_v;
                }


                bool
                f_10312_13805_13851(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 13805, 13851);
                    return return_v;
                }


                bool
                f_10312_14059_14110(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 14059, 14110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10312_14172_14205(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionImports();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 14172, 14205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10312_14333_14368(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 14333, 14368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10312_14776_14798(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 14776, 14798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_14899_14921(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 14899, 14921);
                    return return_v;
                }


                int
                f_10312_14848_15031(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    LookupMembersWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 14848, 15031);
                    return 0;
                }


                bool
                f_10312_15200_15231(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 15200, 15231);
                    return return_v;
                }


                bool
                f_10312_15340_15376(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsSemanticModelBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 15340, 15376);
                    return return_v;
                }


                bool
                f_10312_15303_15377(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, string
                name, bool
                callerIsSemanticModel)
                {
                    var return_v = this_param.IsUsingAlias(name, callerIsSemanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 15303, 15377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_15615_15640(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 15615, 15640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_15615_15648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.First();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 15615, 15648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_15679_15702(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 15679, 15702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_15898_15930(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetKindText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 15898, 15930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_15826_15931(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 15826, 15931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10312_15974_16071(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                containingSymbol, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(containingSymbol, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 15974, 16071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_16117_16141(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                symbol)
                {
                    var return_v = LookupResult.Good((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 16117, 16141);
                    return return_v;
                }


                int
                f_10312_16102_16142(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 16102, 16142);
                    return 0;
                }


                bool
                f_10312_16325_16357_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 16325, 16357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_16570_16581()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 16570, 16581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10312_16511_16582(Microsoft.CodeAnalysis.CSharp.Imports
                previousSubmissionImports, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                newSubmission)
                {
                    var return_v = Imports.ExpandPreviousSubmissionImports(previousSubmissionImports, newSubmission);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 16511, 16582);
                    return return_v;
                }


                int
                f_10312_16817_16967(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolInAliases(originalBinder, result, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 16817, 16967);
                    return 0;
                }


                bool
                f_10312_17090_17122_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 17090, 17122);
                    return return_v;
                }


                int
                f_10312_17304_17349(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.MergePrioritized(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 17304, 17349);
                    return 0;
                }


                int
                f_10312_17432_17468(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.MergeEqual(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 17432, 17468);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_17514_17539(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 17514, 17539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_17514_17547(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.First();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 17514, 17547);
                    return return_v;
                }


                bool
                f_10312_17575_17605(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsMethodOrIndexer(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 17575, 17605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_17972_17988(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 17972, 17988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_18150_18175(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18150, 18175);
                    return return_v;
                }


                int
                f_10312_18150_18181(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18150, 18181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_18189_18214(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18189, 18214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_18189_18222(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.First();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18189, 18222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_18189_18227(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18189, 18227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_18231_18262(Microsoft.CodeAnalysis.SymbolKind?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18231, 18262);
                    return return_v;
                }


                bool
                f_10312_18418_18449(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18418, 18449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_18557_18571(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18557, 18571);
                    return return_v;
                }


                bool
                f_10312_18557_18594(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, bool>
                predicate)
                {
                    var return_v = builder.All<Microsoft.CodeAnalysis.CSharp.Symbol>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18557, 18594);
                    return return_v;
                }


                int
                f_10312_18544_18595(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18544, 18595);
                    return 0;
                }


                int
                f_10312_18622_18658(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.MergeEqual(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18622, 18658);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_18736_18750(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18736, 18750);
                    return return_v;
                }


                int
                f_10312_18736_18756(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 18736, 18756);
                    return return_v;
                }


                int
                f_10312_18795_18820(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18795, 18820);
                    return 0;
                }


                int
                f_10312_18852_18876(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18852, 18876);
                    return 0;
                }


                int
                f_10312_18891_18907(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 18891, 18907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 12924, 18919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 12924, 18919);
            }
        }

        private static void LookupMembersInNamespace(LookupResult result, NamespaceSymbol ns, string name, int arity, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 18931, 19542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 19174, 19243);

                var
                members = f_10312_19188_19242(ns, name, options, originalBinder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 19259, 19531);
                    foreach (Symbol member in f_10312_19285_19292_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 19259, 19531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 19326, 19460);

                        SingleLookupResult
                        resultOfThisMember = f_10312_19366_19459(originalBinder, member, arity, options, null, diagnose, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 19478, 19516);

                        f_10312_19478_19515(result, resultOfThisMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 19259, 19531);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 273);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 18931, 19542);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_19188_19242(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                nsOrType, string
                name, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 19188, 19242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_19366_19459(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability(symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 19366, 19459);
                    return return_v;
                }


                int
                f_10312_19478_19515(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 19478, 19515);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_19285_19292_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 19285, 19292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 18931, 19542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 18931, 19542);
            }
        }

        private void LookupExtensionMethodsInSingleBinder(ExtensionMethodScope scope, LookupResult result, string name, int arity, LookupOptions options, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 19908, 20683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20126, 20181);

                var
                methods = f_10312_20140_20180()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20195, 20221);

                var
                binder = scope.Binder
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20235, 20340);

                f_10312_20235_20339(binder, scope.SearchUsingsNotNamespace, methods, name, arity, options, this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20356, 20641);
                    foreach (var method in f_10312_20379_20386_I(methods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 20356, 20641);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20420, 20570);

                        SingleLookupResult
                        resultOfThisMember = f_10312_20460_20569(this, method, arity, options, null, diagnose: true, useSiteDiagnostics: ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20588, 20626);

                        f_10312_20588_20625(result, resultOfThisMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 20356, 20641);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 20657, 20672);

                f_10312_20657_20671(
                            methods);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 19908, 20683);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10312_20140_20180()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20140, 20180);
                    return return_v;
                }


                int
                f_10312_20235_20339(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, bool
                searchUsingsNotNamespace, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.GetCandidateExtensionMethods(searchUsingsNotNamespace, methods, name, arity, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20235, 20339);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_20460_20569(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose: diagnose, useSiteDiagnostics: ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20460, 20569);
                    return return_v;
                }


                int
                f_10312_20588_20625(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20588, 20625);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10312_20379_20386_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20379, 20386);
                    return return_v;
                }


                int
                f_10312_20657_20671(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 20657, 20671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 19908, 20683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 19908, 20683);
            }
        }

        private void LookupAttributeType(
                    LookupResult result,
                    NamespaceOrTypeSymbol qualifierOpt,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 21434, 26383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 21804, 21833);

                f_10312_21804_21832(f_10312_21817_21831(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 21847, 21880);

                f_10312_21847_21879(f_10312_21860_21878(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 21894, 21940);

                f_10312_21894_21939(f_10312_21907_21938(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23302, 23431);

                f_10312_23302_23430(this, result, qualifierOpt, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23504, 23531);

                Symbol
                symbolWithoutSuffix
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23545, 23641);

                bool
                resultWithoutSuffixIsViable = f_10312_23580_23640(this, result, out symbolWithoutSuffix)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23704, 23754);

                f_10312_23704_23753(arity == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10312, 23717, 23752) || f_10312_23731_23752_M(!result.IsMultiViable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23824, 23861);

                LookupResult
                resultWithSuffix = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23875, 23906);

                Symbol
                symbolWithSuffix = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23920, 23958);

                bool
                resultWithSuffixIsViable = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 23972, 24525) || true) && (!f_10312_23977_24020(options))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 23972, 24525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24054, 24100);

                    resultWithSuffix = f_10312_24073_24099();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24118, 24276);

                    f_10312_24118_24275(this, resultWithSuffix, qualifierOpt, name + "Attribute", arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24294, 24389);

                    resultWithSuffixIsViable = f_10312_24321_24388(this, resultWithSuffix, out symbolWithSuffix);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24460, 24510);

                    f_10312_24460_24509(arity == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10312, 24473, 24508) || f_10312_24487_24508_M(!result.IsMultiViable)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 23972, 24525);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24541, 26331) || true) && (resultWithoutSuffixIsViable && (DynAbs.Tracing.TraceSender.Expression_True(10312, 24545, 24600) && resultWithSuffixIsViable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 24541, 26331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24827, 24863);

                    f_10312_24827_24862(                // Single viable lookup symbol found both with and without Attribute suffix.
                                                        // We merge both results, ambiguity error will be reported later in ResultSymbol.
                                    result, resultWithSuffix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 24541, 26331);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 24541, 26331);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 24897, 26331) || true) && (resultWithoutSuffixIsViable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 24897, 26331);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 24897, 26331);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 24897, 26331);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25078, 26331) || true) && (resultWithSuffixIsViable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25078, 26331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25140, 25179);

                            f_10312_25140_25178(resultWithSuffix != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25306, 25339);

                            f_10312_25306_25338(
                                            // Single viable lookup symbol only found with Attribute suffix, return resultWithSuffix.
                                            result, resultWithSuffix);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25078, 26331);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25078, 26331);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25476, 25803) || true) && (f_10312_25480_25495_M(!result.IsClear))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25476, 25803);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25537, 25784) || true) && ((object)symbolWithoutSuffix != null)
                                ) // was not ambiguous, but not viable

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25537, 25784);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25663, 25761);

                                    f_10312_25663_25760(result, f_10312_25678_25759(this, symbolWithoutSuffix, f_10312_25736_25748(result), diagnose));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25537, 25784);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25476, 25803);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25823, 26316) || true) && (resultWithSuffix != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25823, 26316);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25893, 26231) || true) && (f_10312_25897_25922_M(!resultWithSuffix.IsClear))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25893, 26231);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 25972, 26208) || true) && ((object)symbolWithSuffix != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 25972, 26208);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26066, 26181);

                                        f_10312_26066_26180(resultWithSuffix, f_10312_26091_26179(this, symbolWithSuffix, f_10312_26146_26168(resultWithSuffix), diagnose));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25972, 26208);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25893, 26231);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26255, 26297);

                                f_10312_26255_26296(
                                                    result, resultWithSuffix);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25823, 26316);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 25078, 26331);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 24897, 26331);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 24541, 26331);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26347, 26372);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(resultWithSuffix, 10312, 26347, 26371)?.Free(), 10312, 26364, 26371);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 21434, 26383);

                bool
                f_10312_21817_21831(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 21817, 21831);
                    return return_v;
                }


                int
                f_10312_21804_21832(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 21804, 21832);
                    return 0;
                }


                bool
                f_10312_21860_21878(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 21860, 21878);
                    return return_v;
                }


                int
                f_10312_21847_21879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 21847, 21879);
                    return 0;
                }


                bool
                f_10312_21907_21938(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 21907, 21938);
                    return return_v;
                }


                int
                f_10312_21894_21939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 21894, 21939);
                    return 0;
                }


                int
                f_10312_23302_23430(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsOrMembersInternal(result, qualifierOpt, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 23302, 23430);
                    return 0;
                }


                bool
                f_10312_23580_23640(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, out Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsSingleViableAttributeType(result, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 23580, 23640);
                    return return_v;
                }


                bool
                f_10312_23731_23752_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 23731, 23752);
                    return return_v;
                }


                int
                f_10312_23704_23753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 23704, 23753);
                    return 0;
                }


                bool
                f_10312_23977_24020(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsVerbatimNameAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 23977, 24020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_24073_24099()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 24073, 24099);
                    return return_v;
                }


                int
                f_10312_24118_24275(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                qualifierOpt, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupSymbolsOrMembersInternal(result, qualifierOpt, name, arity, basesBeingResolved, options, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 24118, 24275);
                    return 0;
                }


                bool
                f_10312_24321_24388(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, out Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsSingleViableAttributeType(result, out symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 24321, 24388);
                    return return_v;
                }


                bool
                f_10312_24487_24508_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 24487, 24508);
                    return return_v;
                }


                int
                f_10312_24460_24509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 24460, 24509);
                    return 0;
                }


                int
                f_10312_24827_24862(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult?
                other)
                {
                    this_param.MergeEqual(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 24827, 24862);
                    return 0;
                }


                int
                f_10312_25140_25178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 25140, 25178);
                    return 0;
                }


                int
                f_10312_25306_25338(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 25306, 25338);
                    return 0;
                }


                bool
                f_10312_25480_25495_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 25480, 25495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10312_25736_25748(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 25736, 25748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_25678_25759(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                diagInfo, bool
                diagnose)
                {
                    var return_v = this_param.GenerateNonViableAttributeTypeResult(symbol, diagInfo, diagnose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 25678, 25759);
                    return return_v;
                }


                int
                f_10312_25663_25760(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 25663, 25760);
                    return 0;
                }


                bool
                f_10312_25897_25922_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 25897, 25922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10312_26146_26168(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 26146, 26168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_26091_26179(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                diagInfo, bool
                diagnose)
                {
                    var return_v = this_param.GenerateNonViableAttributeTypeResult(symbol, diagInfo, diagnose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 26091, 26179);
                    return return_v;
                }


                int
                f_10312_26066_26180(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 26066, 26180);
                    return 0;
                }


                int
                f_10312_26255_26296(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.MergePrioritized(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 26255, 26296);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 21434, 26383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 21434, 26383);
            }
        }

        private bool IsAmbiguousResult(LookupResult result, out Symbol resultSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 26395, 27702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26496, 26516);

                resultSymbol = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26530, 26559);

                var
                symbols = f_10312_26544_26558(result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26575, 27691);

                switch (f_10312_26583_26596(symbols))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 26575, 27691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26659, 26672);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 26575, 27691);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 26575, 27691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26719, 26745);

                        resultSymbol = f_10312_26734_26744(symbols, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 26767, 26780);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 26575, 27691);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 26575, 27691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27550, 27618);

                        resultSymbol = f_10312_27565_27617(this, symbols);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27640, 27676);

                        return (object)resultSymbol == null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 26575, 27691);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 26395, 27702);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_26544_26558(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 26544, 26558);
                    return return_v;
                }


                int
                f_10312_26583_26596(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 26583, 26596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_26734_26744(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 26734, 26744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_27565_27617(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = this_param.ResolveMultipleSymbolsInAttributeTypeLookup(symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 27565, 27617);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 26395, 27702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 26395, 27702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol ResolveMultipleSymbolsInAttributeTypeLookup(ArrayBuilder<Symbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 27714, 28809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27827, 27860);

                f_10312_27827_27859(f_10312_27840_27853(symbols) >= 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27876, 27920);

                var
                originalSymbols = f_10312_27898_27919(symbols)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27945, 27950);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27936, 28073) || true) && (i < f_10312_27956_27969(symbols))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 27971, 27974)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 27936, 28073))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 27936, 28073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28008, 28058);

                        symbols[i] = f_10312_28021_28057(f_10312_28046_28056(symbols, i));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28089, 28115);

                BestSymbolInfo
                secondBest
                = default(BestSymbolInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28129, 28194);

                BestSymbolInfo
                best = f_10312_28151_28193(this, symbols, out secondBest)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28210, 28237);

                f_10312_28210_28236(f_10312_28223_28235_M(!best.IsNone));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28251, 28284);

                f_10312_28251_28283(f_10312_28264_28282_M(!secondBest.IsNone));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28300, 28770) || true) && (best.IsFromCompilation && (DynAbs.Tracing.TraceSender.Expression_True(10312, 28304, 28359) && f_10312_28330_28359_M(!secondBest.IsFromCompilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 28300, 28770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28393, 28429);

                    var
                    srcSymbol = f_10312_28409_28428(symbols, best.Index)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28447, 28488);

                    var
                    mdSymbol = f_10312_28462_28487(symbols, secondBest.Index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28606, 28755) || true) && (f_10312_28610_28659(srcSymbol, mdSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 28606, 28755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28701, 28736);

                        return originalSymbols[best.Index];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 28606, 28755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 28300, 28770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28786, 28798);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 27714, 28809);

                int
                f_10312_27840_27853(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 27840, 27853);
                    return return_v;
                }


                int
                f_10312_27827_27859(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 27827, 27859);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_27898_27919(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 27898, 27919);
                    return return_v;
                }


                int
                f_10312_27956_27969(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 27956, 27969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_28046_28056(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28046, 28056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_28021_28057(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapAliasNoDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28021, 28057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                f_10312_28151_28193(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, out Microsoft.CodeAnalysis.CSharp.Binder.BestSymbolInfo
                secondBest)
                {
                    var return_v = this_param.GetBestSymbolInfo(symbols, out secondBest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28151, 28193);
                    return return_v;
                }


                bool
                f_10312_28223_28235_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28223, 28235);
                    return return_v;
                }


                int
                f_10312_28210_28236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28210, 28236);
                    return 0;
                }


                bool
                f_10312_28264_28282_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28264, 28282);
                    return return_v;
                }


                int
                f_10312_28251_28283(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28251, 28283);
                    return 0;
                }


                bool
                f_10312_28330_28359_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28330, 28359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_28409_28428(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28409, 28428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_28462_28487(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 28462, 28487);
                    return return_v;
                }


                bool
                f_10312_28610_28659(Microsoft.CodeAnalysis.CSharp.Symbol
                x, Microsoft.CodeAnalysis.CSharp.Symbol
                y)
                {
                    var return_v = NameAndArityMatchRecursively(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28610, 28659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 27714, 28809);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 27714, 28809);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NameAndArityMatchRecursively(Symbol x, Symbol y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 28821, 29532);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28914, 29396) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 28914, 29396);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 28959, 29050) || true) && (f_10312_28963_28972(x))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 28959, 29050);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29014, 29031);

                            return f_10312_29021_29030(y);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 28959, 29050);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29068, 29155) || true) && (f_10312_29072_29081(y))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 29068, 29155);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29123, 29136);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 29068, 29155);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29173, 29299) || true) && (f_10312_29177_29183(x) != f_10312_29187_29193(y) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 29177, 29225) || f_10312_29197_29209(x) != f_10312_29213_29225(y)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 29173, 29299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29267, 29280);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 29173, 29299);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29317, 29340);

                        x = f_10312_29321_29339(x);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29358, 29381);

                        y = f_10312_29362_29380(y);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 28914, 29396);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 28914, 29396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 28914, 29396);
                }
                static bool isRoot(Symbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 29446, 29520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29449, 29520);
                        return symbol is null || (DynAbs.Tracing.TraceSender.Expression_False(10312, 29449, 29520) || symbol is NamespaceSymbol { IsGlobalNamespace: true }); DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 29446, 29520);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 29446, 29520);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 29446, 29520);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 28821, 29532);

                bool
                f_10312_28963_28972(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = isRoot(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 28963, 28972);
                    return return_v;
                }


                bool
                f_10312_29021_29030(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = isRoot(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29021, 29030);
                    return return_v;
                }


                bool
                f_10312_29072_29081(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = isRoot(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29072, 29081);
                    return return_v;
                }


                string
                f_10312_29177_29183(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 29177, 29183);
                    return return_v;
                }


                string
                f_10312_29187_29193(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 29187, 29193);
                    return return_v;
                }


                int
                f_10312_29197_29209(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29197, 29209);
                    return return_v;
                }


                int
                f_10312_29213_29225(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29213, 29225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_29321_29339(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 29321, 29339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_29362_29380(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 29362, 29380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 28821, 29532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 28821, 29532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSingleViableAttributeType(LookupResult result, out Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 29544, 30100);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29649, 29752) || true) && (f_10312_29653_29690(this, result, out symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 29649, 29752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29724, 29737);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 29649, 29752);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29768, 29916) || true) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(10312, 29772, 29828) || f_10312_29790_29801(result) != LookupResultKind.Viable) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 29772, 29854) || (object)symbol == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 29768, 29916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29888, 29901);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 29768, 29916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29932, 29964);

                DiagnosticInfo
                discarded = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 29978, 30089);

                return f_10312_29985_30088(this, f_10312_30013_30045(symbol), diagnose: false, diagInfo: ref discarded);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 29544, 30100);

                bool
                f_10312_29653_29690(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, out Microsoft.CodeAnalysis.CSharp.Symbol
                resultSymbol)
                {
                    var return_v = this_param.IsAmbiguousResult(result, out resultSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29653, 29690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10312_29790_29801(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 29790, 29801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_30013_30045(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapAliasNoDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30013, 30045);
                    return return_v;
                }


                bool
                f_10312_29985_30088(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                diagnose, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                diagInfo)
                {
                    var return_v = this_param.CheckAttributeTypeViability(symbol, diagnose: diagnose, diagInfo: ref diagInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 29985, 30088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 29544, 30100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 29544, 30100);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SingleLookupResult GenerateNonViableAttributeTypeResult(Symbol symbol, DiagnosticInfo diagInfo, bool diagnose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 30112, 30506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30255, 30292);

                f_10312_30255_30291((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30308, 30350);

                symbol = f_10312_30317_30349(symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30364, 30424);

                f_10312_30364_30423(this, symbol, diagnose, ref diagInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30438, 30495);

                return f_10312_30445_30494(symbol, diagInfo);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 30112, 30506);

                int
                f_10312_30255_30291(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30255, 30291);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_30317_30349(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = UnwrapAliasNoDiagnostics(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30317, 30349);
                    return return_v;
                }


                bool
                f_10312_30364_30423(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                diagnose, ref Microsoft.CodeAnalysis.DiagnosticInfo
                diagInfo)
                {
                    var return_v = this_param.CheckAttributeTypeViability(symbol, diagnose, ref diagInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30364, 30423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_30445_30494(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = LookupResult.NotAnAttributeType(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30445, 30494);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 30112, 30506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 30112, 30506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckAttributeTypeViability(Symbol symbol, bool diagnose, ref DiagnosticInfo diagInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 30518, 32462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30642, 30679);

                f_10312_30642_30678((object)symbol != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30695, 32315) || true) && (f_10312_30699_30710(symbol) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 30695, 32315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30768, 30808);

                    var
                    namedType = (NamedTypeSymbol)symbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30826, 32300) || true) && (f_10312_30830_30853(namedType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 30826, 32300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 30956, 31052);

                        diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 30967, 30975) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 30978, 31044)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 31047, 31051))) ? f_10312_30978_31044(ErrorCode.ERR_AttributeCantBeGeneric, symbol) : null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31074, 31087);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 30826, 32300);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 30826, 32300);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31129, 32300) || true) && (f_10312_31133_31153(namedType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 31129, 32300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31255, 31351);

                            diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 31266, 31274) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 31277, 31343)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 31346, 31350))) ? f_10312_31277_31343(ErrorCode.ERR_AbstractAttributeClass, symbol) : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31373, 31386);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 31129, 32300);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 31129, 32300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31468, 31518);

                            HashSet<DiagnosticInfo>
                            useSiteDiagnostics = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31542, 31804) || true) && (f_10312_31546_31659(f_10312_31546_31557(), namedType, WellKnownType.System_Attribute, ref useSiteDiagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 31542, 31804);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31769, 31781);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 31542, 31804);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31828, 32281) || true) && (diagnose && (DynAbs.Tracing.TraceSender.Expression_True(10312, 31832, 31879) && !f_10312_31845_31879(useSiteDiagnostics)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 31828, 32281);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 31929, 32258);
                                    foreach (var info in f_10312_31950_31968_I(useSiteDiagnostics))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 31929, 32258);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32026, 32231) || true) && (f_10312_32030_32043(info) == DiagnosticSeverity.Error)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 32026, 32231);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32137, 32153);

                                            diagInfo = info;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32187, 32200);

                                            return false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 32026, 32231);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 31929, 32258);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 330);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 330);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 31828, 32281);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 31129, 32300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 30826, 32300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 30695, 32315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32331, 32424);

                diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 32342, 32350) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 32353, 32416)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 32419, 32423))) ? f_10312_32353_32416(ErrorCode.ERR_NotAnAttributeClass, symbol) : null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32438, 32451);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 30518, 32462);

                int
                f_10312_30642_30678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30642, 30678);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_30699_30710(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 30699, 30710);
                    return return_v;
                }


                bool
                f_10312_30830_30853(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 30830, 30853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_30978_31044(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 30978, 31044);
                    return return_v;
                }


                bool
                f_10312_31133_31153(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 31133, 31153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_31277_31343(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 31277, 31343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_31546_31557()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 31546, 31557);
                    return return_v;
                }


                bool
                f_10312_31546_31659(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.WellKnownType
                wellKnownType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsEqualOrDerivedFromWellKnownClass((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, wellKnownType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 31546, 31659);
                    return return_v;
                }


                bool
                f_10312_31845_31879(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 31845, 31879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10312_32030_32043(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 32030, 32043);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10312_31950_31968_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 31950, 31968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_32353_32416(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 32353, 32416);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 30518, 32462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 30518, 32462);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool SupportsExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 32567, 32588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 32573, 32586);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 32567, 32588);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 32496, 32599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 32496, 32599);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void GetCandidateExtensionMethods(
                    bool searchUsingsNotNamespace,
                    ArrayBuilder<MethodSymbol> methods,
                    string name,
                    int arity,
                    LookupOptions options,
                    Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 33218, 33506);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 33218, 33506);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 33218, 33506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 33218, 33506);
            }
        }

        protected static void LookupMembersWithoutInheritance(LookupResult result, TypeSymbol type, string name, int arity,
                    LookupOptions options, Binder originalBinder, TypeSymbol accessThroughType, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 33602, 34585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 33935, 34006);

                var
                members = f_10312_33949_34005(type, name, options, originalBinder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 34022, 34574);
                    foreach (Symbol member in f_10312_34048_34055_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 34022, 34574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 34336, 34503);

                        SingleLookupResult
                        resultOfThisMember = f_10312_34376_34502(originalBinder, member, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 34521, 34559);

                        f_10312_34521_34558(result, resultOfThisMember);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 34022, 34574);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 553);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 33602, 34585);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_33949_34005(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nsOrType, string
                name, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 33949, 34005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_34376_34502(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.CheckViability(symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 34376, 34502);
                    return return_v;
                }


                int
                f_10312_34521_34558(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 34521, 34558);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_34048_34055_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 34048, 34055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 33602, 34585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 33602, 34585);
            }
        }

        private void LookupMembersInClass(
                    LookupResult result,
                    TypeSymbol type,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    Binder originalBinder,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 34659, 35191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35047, 35180);

                f_10312_35047_35179(this, result, type, name, arity, basesBeingResolved, options, originalBinder, type, diagnose, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 34659, 35191);

                int
                f_10312_35047_35179(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInClass(result, type, name, arity, basesBeingResolved, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 35047, 35179);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 34659, 35191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 34659, 35191);
            }
        }

        private void LookupMembersInClass(
                    LookupResult result,
                    TypeSymbol type,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    Binder originalBinder,
                    TypeSymbol accessThroughType,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 35265, 38808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35696, 35731);

                f_10312_35696_35730((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35745, 35826);

                f_10312_35745_35825(!f_10312_35759_35781(type) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 35758, 35824) && f_10312_35785_35798(type) != TypeKind.TypeParameter));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35842, 35872);

                TypeSymbol
                currentType = type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35888, 35925);

                var
                tmp = f_10312_35898_35924()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35939, 35985);

                PooledHashSet<NamedTypeSymbol>
                visited = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 35999, 38740) || true) && ((object)currentType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 35999, 38740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36067, 36079);

                        f_10312_36067_36078(tmp);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36097, 36258);

                        f_10312_36097_36257(tmp, currentType, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36278, 36360);

                        f_10312_36278_36359(result, tmp, basesBeingResolved, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36566, 36625);

                        NamedTypeSymbol
                        namedType = currentType as NamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36643, 36855) || true) && (f_10312_36647_36679_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(namedType, 10312, 36647, 36679)?.ShouldAddWinRTMembers) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 36643, 36855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 36729, 36836);

                            f_10312_36729_36835(this, result, namedType, name, arity, options, originalBinder, diagnose, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 36643, 36855);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37029, 37117);

                        bool
                        tmpHidesMethodOrIndexers = f_10312_37061_37078(tmp) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 37061, 37116) && !f_10312_37083_37116(f_10312_37101_37115(f_10312_37101_37112(tmp), 0)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37254, 37416) || true) && (f_10312_37258_37278(result) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 37258, 37349) && (tmpHidesMethodOrIndexers || (DynAbs.Tracing.TraceSender.Expression_False(10312, 37283, 37348) || !f_10312_37312_37348(f_10312_37330_37347(f_10312_37330_37344(result), 0))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 37254, 37416);
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 37391, 37397);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 37254, 37416);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37436, 37988) || true) && (basesBeingResolved != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 37440, 37531) && f_10312_37470_37531(basesBeingResolved, f_10312_37507_37530(type))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 37436, 37988);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37573, 37633);

                            var
                            other = f_10312_37585_37632(basesBeingResolved, type)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37655, 37732);

                            var
                            diagInfo = f_10312_37670_37731(ErrorCode.ERR_CircularBase, type, other)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37754, 37853);

                            var
                            error = f_10312_37766_37852(f_10312_37794_37810(this), name, arity, diagInfo, unreported: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 37875, 37916);

                            f_10312_37875_37915(result, f_10312_37890_37914(error));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 37436, 37988);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38286, 38405) || true) && (f_10312_38290_38338(originalBinder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 38286, 38405);
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 38380, 38386);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 38286, 38405);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38425, 38538);

                        currentType = f_10312_38439_38537(currentType, basesBeingResolved, f_10312_38507_38523(this), ref visited);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38556, 38725) || true) && ((object)currentType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 38556, 38725);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38629, 38706);

                            f_10312_38629_38705(f_10312_38629_38659(currentType), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 38556, 38725);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 35999, 38740);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 35999, 38740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 35999, 38740);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38756, 38772);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(visited, 10312, 38756, 38771)?.Free(), 10312, 38764, 38771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 38786, 38797);

                f_10312_38786_38796(tmp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 35265, 38808);

                int
                f_10312_35696_35730(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 35696, 35730);
                    return 0;
                }


                bool
                f_10312_35759_35781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 35759, 35781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10312_35785_35798(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 35785, 35798);
                    return return_v;
                }


                int
                f_10312_35745_35825(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 35745, 35825);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_35898_35924()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 35898, 35924);
                    return return_v;
                }


                int
                f_10312_36067_36078(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 36067, 36078);
                    return 0;
                }


                int
                f_10312_36097_36257(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    LookupMembersWithoutInheritance(result, type, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 36097, 36257);
                    return 0;
                }


                int
                f_10312_36278_36359(Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHiding, Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHidden, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    MergeHidingLookupResults(resultHiding, resultHidden, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 36278, 36359);
                    return 0;
                }


                bool?
                f_10312_36647_36679_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 36647, 36679);
                    return return_v;
                }


                int
                f_10312_36729_36835(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AddWinRTMembers(result, type, name, arity, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 36729, 36835);
                    return 0;
                }


                bool
                f_10312_37061_37078(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37061, 37078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_37101_37112(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37101, 37112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_37101_37115(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37101, 37115);
                    return return_v;
                }


                bool
                f_10312_37083_37116(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsMethodOrIndexer(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37083, 37116);
                    return return_v;
                }


                bool
                f_10312_37258_37278(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37258, 37278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_37330_37344(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37330, 37344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_37330_37347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37330, 37347);
                    return return_v;
                }


                bool
                f_10312_37312_37348(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsMethodOrIndexer(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37312, 37348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_37507_37530(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37507, 37530);
                    return return_v;
                }


                bool
                f_10312_37470_37531(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37470, 37531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_37585_37632(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = GetNearestOtherSymbol(list, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37585, 37632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_37670_37731(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37670, 37731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_37794_37810(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 37794, 37810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10312_37766_37852(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                errorInfo, bool
                unreported)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name, arity, (Microsoft.CodeAnalysis.DiagnosticInfo)errorInfo, unreported: unreported);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37766, 37852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_37890_37914(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                symbol)
                {
                    var return_v = LookupResult.Good((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37890, 37914);
                    return return_v;
                }


                int
                f_10312_37875_37915(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 37875, 37915);
                    return 0;
                }


                bool
                f_10312_38290_38338(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InCrefButNotParameterOrReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 38290, 38338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_38507_38523(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 38507, 38523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_38439_38537(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                visited)
                {
                    var return_v = type.GetNextBaseTypeNoUseSiteDiagnostics(basesBeingResolved, compilation, ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 38439, 38537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_38629_38659(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 38629, 38659);
                    return return_v;
                }


                int
                f_10312_38629_38705(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 38629, 38705);
                    return 0;
                }


                int
                f_10312_38786_38796(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 38786, 38796);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 35265, 38808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 35265, 38808);
            }
        }

        private void AddWinRTMembers(
                    LookupResult result,
                    NamedTypeSymbol type,
                    string name,
                    int arity,
                    LookupOptions options,
                    Binder originalBinder,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 39536, 43340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40431, 40493);

                var
                comparer = MemberSignatureComparer.CSharpOverrideComparer
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40509, 40556);

                var
                allMembers = f_10312_40526_40555(comparer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40570, 40625);

                var
                conflictingMembers = f_10312_40595_40624(comparer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40697, 41175) || true) && (f_10312_40701_40721(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 40697, 41175);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40755, 41160);
                        foreach (var sym in f_10312_40775_40789_I(f_10312_40775_40789(result)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 40755, 41160);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 40980, 41141) || true) && (f_10312_40984_40992(sym) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10312, 40984, 41048) || f_10312_41017_41025(sym) == SymbolKind.Property))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 40980, 41141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41098, 41118);

                                f_10312_41098_41117(allMembers, sym);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 40980, 41141);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 40755, 41160);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 406);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 406);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 40697, 41175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41191, 41228);

                var
                tmp = f_10312_41201_41227()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41244, 41343);

                NamedTypeSymbol
                idictSymbol
                = default(NamedTypeSymbol),
                iroDictSymbol
                = default(NamedTypeSymbol),
                iListSymbol
                = default(NamedTypeSymbol),
                iCollectionSymbol
                = default(NamedTypeSymbol),
                inccSymbol
                = default(NamedTypeSymbol),
                inpcSymbol
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41357, 41499);

                f_10312_41357_41498(this, out idictSymbol, out iroDictSymbol, out iListSymbol, out iCollectionSymbol, out inccSymbol, out inpcSymbol);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41590, 42536);
                    foreach (var iface in f_10312_41612_41686_I(f_10312_41612_41686(type, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 41590, 42536);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41720, 42521) || true) && (f_10312_41724_41848(iface, idictSymbol, iroDictSymbol, iListSymbol, iCollectionSymbol, inccSymbol, inpcSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 41720, 42521);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 41890, 42039);

                            f_10312_41890_42038(tmp, iface, name, arity, options, originalBinder, iface, diagnose, ref useSiteDiagnostics, basesBeingResolved: null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42109, 42468) || true) && (f_10312_42113_42130(tmp))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42109, 42468);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42180, 42445);
                                    foreach (var sym in f_10312_42200_42211_I(f_10312_42200_42211(tmp)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42180, 42445);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42269, 42418) || true) && (!f_10312_42274_42293(allMembers, sym))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42269, 42418);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42359, 42387);

                                            f_10312_42359_42386(conflictingMembers, sym);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42269, 42418);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42180, 42445);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 266);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 266);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42109, 42468);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42490, 42502);

                            f_10312_42490_42501(tmp);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 41720, 42521);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 41590, 42536);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 947);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42550, 42561);

                f_10312_42550_42560(tmp);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42575, 42964) || true) && (f_10312_42579_42599(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42575, 42964);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42633, 42949);
                        foreach (var sym in f_10312_42653_42667_I(f_10312_42653_42667(result)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42633, 42949);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42709, 42930) || true) && (f_10312_42713_42721(sym) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10312, 42713, 42777) || f_10312_42746_42754(sym) == SymbolKind.Property))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42709, 42930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42827, 42850);

                                f_10312_42827_42849(allMembers, sym);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42876, 42907);

                                f_10312_42876_42906(conflictingMembers, sym);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42709, 42930);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42633, 42949);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 317);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42575, 42964);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 42978, 43329);
                    foreach (var sym in f_10312_42998_43008_I(allMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 42978, 43329);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43042, 43314) || true) && (!f_10312_43047_43079(conflictingMembers, sym))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 43042, 43314);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43217, 43295);

                            f_10312_43217_43294(                    // since we only added viable members, every lookupresult should be viable
                                                result, f_10312_43235_43293(LookupResultKind.Viable, sym, null));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 43042, 43314);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 42978, 43329);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 352);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 39536, 43340);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_40526_40555(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 40526, 40555);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_40595_40624(Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 40595, 40624);
                    return return_v;
                }


                bool
                f_10312_40701_40721(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 40701, 40721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_40775_40789(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 40775, 40789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_40984_40992(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 40984, 40992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_41017_41025(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 41017, 41025);
                    return return_v;
                }


                bool
                f_10312_41098_41117(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41098, 41117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_40775_40789_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 40775, 40789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_41201_41227()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41201, 41227);
                    return return_v;
                }


                int
                f_10312_41357_41498(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                idictSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iroDictSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iListSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iCollectionSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inccSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inpcSymbol)
                {
                    this_param.GetWellKnownWinRTMemberInterfaces(out idictSymbol, out iroDictSymbol, out iListSymbol, out iCollectionSymbol, out inccSymbol, out inpcSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41357, 41498);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_41612_41686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41612, 41686);
                    return return_v;
                }


                bool
                f_10312_41724_41848(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iface, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                idictSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iroDictSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iListSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iCollectionSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inccSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inpcSymbol)
                {
                    var return_v = ShouldAddWinRTMembersForInterface(iface, idictSymbol, iroDictSymbol, iListSymbol, iCollectionSymbol, inccSymbol, inpcSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41724, 41848);
                    return return_v;
                }


                int
                f_10312_41890_42038(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    LookupMembersWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, options, originalBinder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41890, 42038);
                    return 0;
                }


                bool
                f_10312_42113_42130(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42113, 42130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_42200_42211(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42200, 42211);
                    return return_v;
                }


                bool
                f_10312_42274_42293(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42274, 42293);
                    return return_v;
                }


                bool
                f_10312_42359_42386(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42359, 42386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_42200_42211_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42200, 42211);
                    return return_v;
                }


                int
                f_10312_42490_42501(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42490, 42501);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_41612_41686_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 41612, 41686);
                    return return_v;
                }


                int
                f_10312_42550_42560(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42550, 42560);
                    return 0;
                }


                bool
                f_10312_42579_42599(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsMultiViable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42579, 42599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_42653_42667(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Symbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42653, 42667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_42713_42721(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42713, 42721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_42746_42754(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 42746, 42754);
                    return return_v;
                }


                bool
                f_10312_42827_42849(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42827, 42849);
                    return return_v;
                }


                bool
                f_10312_42876_42906(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42876, 42906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_42653_42667_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42653, 42667);
                    return return_v;
                }


                bool
                f_10312_43047_43079(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43047, 43079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_43235_43293(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43235, 43293);
                    return return_v;
                }


                int
                f_10312_43217_43294(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43217, 43294);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_42998_43008_I(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 42998, 43008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 39536, 43340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 39536, 43340);
            }
        }

        private void GetWellKnownWinRTMemberInterfaces(out NamedTypeSymbol idictSymbol, out NamedTypeSymbol iroDictSymbol, out NamedTypeSymbol iListSymbol, out NamedTypeSymbol iCollectionSymbol, out NamedTypeSymbol inccSymbol, out NamedTypeSymbol inpcSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 43352, 44311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43627, 43727);

                idictSymbol = f_10312_43641_43726(f_10312_43641_43652(), WellKnownType.System_Collections_Generic_IDictionary_KV);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43741, 43851);

                iroDictSymbol = f_10312_43757_43850(f_10312_43757_43768(), WellKnownType.System_Collections_Generic_IReadOnlyDictionary_KV);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43865, 43948);

                iListSymbol = f_10312_43879_43947(f_10312_43879_43890(), WellKnownType.System_Collections_IList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 43962, 44057);

                iCollectionSymbol = f_10312_43982_44056(f_10312_43982_43993(), WellKnownType.System_Collections_ICollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 44071, 44184);

                inccSymbol = f_10312_44084_44183(f_10312_44084_44095(), WellKnownType.System_Collections_Specialized_INotifyCollectionChanged);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 44198, 44300);

                inpcSymbol = f_10312_44211_44299(f_10312_44211_44222(), WellKnownType.System_ComponentModel_INotifyPropertyChanged);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 43352, 44311);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_43641_43652()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 43641, 43652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_43641_43726(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43641, 43726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_43757_43768()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 43757, 43768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_43757_43850(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43757, 43850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_43879_43890()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 43879, 43890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_43879_43947(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43879, 43947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_43982_43993()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 43982, 43993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_43982_44056(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 43982, 44056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_44084_44095()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 44084, 44095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_44084_44183(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 44084, 44183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_44211_44222()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 44211, 44222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_44211_44299(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 44211, 44299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 43352, 44311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 43352, 44311);
            }
        }

        private static bool ShouldAddWinRTMembersForInterface(NamedTypeSymbol iface, NamedTypeSymbol idictSymbol, NamedTypeSymbol iroDictSymbol, NamedTypeSymbol iListSymbol, NamedTypeSymbol iCollectionSymbol, NamedTypeSymbol inccSymbol, NamedTypeSymbol inpcSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 44323, 46003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 44604, 44649);

                var
                iFaceOriginal = f_10312_44624_44648(iface)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 44663, 44708);

                var
                iFaceSpecial = f_10312_44682_44707(iFaceOriginal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 44820, 45992);

                return iFaceSpecial == SpecialType.System_Collections_Generic_IEnumerable_T || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 44981) || iFaceSpecial == SpecialType.System_Collections_Generic_IList_T) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45073) || iFaceSpecial == SpecialType.System_Collections_Generic_ICollection_T) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45179) || f_10312_45097_45179(iFaceOriginal, idictSymbol, TypeCompareKind.ConsiderEverything2)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45273) || iFaceSpecial == SpecialType.System_Collections_Generic_IReadOnlyList_T) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45373) || iFaceSpecial == SpecialType.System_Collections_Generic_IReadOnlyCollection_T) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45481) || f_10312_45397_45481(iFaceOriginal, iroDictSymbol, TypeCompareKind.ConsiderEverything2)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45563) || iFaceSpecial == SpecialType.System_Collections_IEnumerable) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45669) || f_10312_45587_45669(iFaceOriginal, iListSymbol, TypeCompareKind.ConsiderEverything2)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45781) || f_10312_45693_45781(iFaceOriginal, iCollectionSymbol, TypeCompareKind.ConsiderEverything2)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45886) || f_10312_45805_45886(iFaceOriginal, inccSymbol, TypeCompareKind.ConsiderEverything2)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 44827, 45991) || f_10312_45910_45991(iFaceOriginal, inpcSymbol, TypeCompareKind.ConsiderEverything2));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 44323, 46003);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_44624_44648(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 44624, 44648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10312_44682_44707(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 44682, 44707);
                    return return_v;
                }


                bool
                f_10312_45097_45179(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45097, 45179);
                    return return_v;
                }


                bool
                f_10312_45397_45481(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45397, 45481);
                    return return_v;
                }


                bool
                f_10312_45587_45669(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45587, 45669);
                    return return_v;
                }


                bool
                f_10312_45693_45781(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45693, 45781);
                    return return_v;
                }


                bool
                f_10312_45805_45886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45805, 45886);
                    return return_v;
                }


                bool
                f_10312_45910_45991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 45910, 45991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 44323, 46003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 44323, 46003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Symbol GetNearestOtherSymbol(ConsList<TypeSymbol> list, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 46131, 46961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46243, 46267);

                TypeSymbol
                other = type
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46283, 46921) || true) && (list != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 46290, 46340) && list != ConsList<TypeSymbol>.Empty))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46342, 46358)
        , list = f_10312_46349_46358(list), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 46283, 46921))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 46283, 46921);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46392, 46906) || true) && (f_10312_46396_46486(f_10312_46414_46423(list), f_10312_46425_46448(type), TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 46392, 46906);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46528, 46759) || true) && (f_10312_46532_46599(other, type, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 46532, 46620) && f_10312_46603_46612(list) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 46532, 46663) && f_10312_46624_46633(list) != ConsList<TypeSymbol>.Empty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 46528, 46759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46713, 46736);

                                other = f_10312_46721_46735(f_10312_46721_46730(list));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 46528, 46759);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 46781, 46787);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 46392, 46906);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 46392, 46906);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46869, 46887);

                            other = f_10312_46877_46886(list);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 46392, 46906);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 639);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 46937, 46950);

                return other;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 46131, 46961);

                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10312_46349_46358(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Tail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46349, 46358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_46414_46423(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46414, 46423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_46425_46448(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46425, 46448);
                    return return_v;
                }


                bool
                f_10312_46396_46486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 46396, 46486);
                    return return_v;
                }


                bool
                f_10312_46532_46599(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 46532, 46599);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10312_46603_46612(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Tail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46603, 46612);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10312_46624_46633(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Tail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46624, 46633);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10312_46721_46730(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Tail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46721, 46730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_46721_46735(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46721, 46735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_46877_46886(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    var return_v = this_param.Head;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 46877, 46886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 46131, 46961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 46131, 46961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LookupMembersInInterfaceOnly(
                    LookupResult current,
                    NamedTypeSymbol type,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    Binder originalBinder,
                    TypeSymbol accessThroughType,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 47038, 48180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 47490, 47525);

                f_10312_47490_47524((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 47539, 47570);

                f_10312_47539_47569(f_10312_47552_47568(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 47586, 47744);

                f_10312_47586_47743(current, type, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 47758, 48169) || true) && ((options & LookupOptions.NamespaceAliasesOnly) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 47762, 47866) && f_10312_47817_47866_M(!originalBinder.InCrefButNotParameterOrReturnType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 47758, 48169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 47900, 48154);

                    f_10312_47900_48153(current, f_10312_47953_48020(type, basesBeingResolved, ref useSiteDiagnostics), name, arity, basesBeingResolved, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 47758, 48169);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 47038, 48180);

                int
                f_10312_47490_47524(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 47490, 47524);
                    return 0;
                }


                bool
                f_10312_47552_47568(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 47552, 47568);
                    return return_v;
                }


                int
                f_10312_47539_47569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 47539, 47569);
                    return 0;
                }


                int
                f_10312_47586_47743(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    LookupMembersWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 47586, 47743);
                    return 0;
                }


                bool
                f_10312_47817_47866_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 47817, 47866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_47953_48020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetBaseInterfaces(type, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 47953, 48020);
                    return return_v;
                }


                int
                f_10312_47900_48153(Microsoft.CodeAnalysis.CSharp.LookupResult
                current, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    LookupMembersInInterfacesWithoutInheritance(current, interfaces, name, arity, basesBeingResolved, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 47900, 48153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 47038, 48180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 47038, 48180);
            }
        }

        private static ImmutableArray<NamedTypeSymbol> GetBaseInterfaces(NamedTypeSymbol type, ConsList<TypeSymbol> basesBeingResolved, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 48192, 52661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48392, 48560) || true) && (f_10312_48396_48421_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(basesBeingResolved, 10312, 48396, 48421)?.Any()) != true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 48392, 48560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48463, 48545);

                    return f_10312_48470_48544(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 48392, 48560);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48576, 48735) || true) && (f_10312_48580_48641(basesBeingResolved, f_10312_48617_48640(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 48576, 48735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48675, 48720);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 48576, 48735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48751, 48815);

                var
                interfaces = f_10312_48768_48814(type, basesBeingResolved)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48831, 48947) || true) && (interfaces.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 48831, 48947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 48887, 48932);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 48831, 48947);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50427, 50509);

                var
                cycleGuard = f_10312_50444_50508(ConsList<NamedTypeSymbol>.Empty, f_10312_50484_50507(type))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50697, 50754);

                var
                result = f_10312_50710_50753()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50768, 50862);

                var
                visited = f_10312_50782_50861(Symbols.SymbolEqualityComparer.ConsiderEverything)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50887, 50912);

                    for (int
        i = interfaces.Length - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50878, 51055) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50922, 50925)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 50878, 51055))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 50878, 51055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 50959, 51040);

                        f_10312_50959_51039(interfaces[i], visited, result, basesBeingResolved, cycleGuard);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51071, 51096);

                f_10312_51071_51095(
                            result);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51112, 51268);
                    foreach (var candidate in f_10312_51138_51144_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 51112, 51268);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51178, 51253);

                        f_10312_51178_51252(f_10312_51178_51206(candidate), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 51112, 51268);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51284, 51319);

                return f_10312_51291_51318(result);

                static void addAllInterfaces(NamedTypeSymbol @interface, HashSet<NamedTypeSymbol> visited, ArrayBuilder<NamedTypeSymbol> result, ConsList<TypeSymbol> basesBeingResolved, ConsList<NamedTypeSymbol> cycleGuard)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 51335, 52650);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51575, 51610);

                        NamedTypeSymbol
                        originalDefinition
                        = default(NamedTypeSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51630, 52635) || true) && (f_10312_51634_51656(@interface) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 51634, 51741) && !f_10312_51661_51741(cycleGuard, originalDefinition = f_10312_51711_51740(@interface))) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 51634, 51768) && f_10312_51745_51768(visited, @interface)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 51630, 52635);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51810, 52569) || true) && (!f_10312_51815_51871(basesBeingResolved, originalDefinition))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 51810, 52569);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 51921, 52023);

                                ImmutableArray<NamedTypeSymbol>
                                baseInterfaces = f_10312_51970_52022(@interface, basesBeingResolved)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52051, 52546) || true) && (f_10312_52055_52078_M(!baseInterfaces.IsEmpty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 52051, 52546);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52136, 52188);

                                    cycleGuard = f_10312_52149_52187(cycleGuard, originalDefinition);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52227, 52256);
                                        for (int
            i = baseInterfaces.Length - 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52218, 52519) || true) && (i >= 0)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52266, 52269)
            , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 52218, 52519))

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 52218, 52519);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52335, 52373);

                                            var
                                            baseInterface = baseInterfaces[i]
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52407, 52488);

                                            f_10312_52407_52487(baseInterface, visited, result, basesBeingResolved, cycleGuard);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 302);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 302);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 52051, 52546);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 51810, 52569);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 52593, 52616);

                            f_10312_52593_52615(
                                                result, @interface);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 51630, 52635);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 51335, 52650);

                        bool
                        f_10312_51634_51656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.IsInterface;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 51634, 51656);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10312_51711_51740(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 51711, 51740);
                            return return_v;
                        }


                        bool
                        f_10312_51661_51741(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        element)
                        {
                            var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(element);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51661, 51741);
                            return return_v;
                        }


                        bool
                        f_10312_51745_51768(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51745, 51768);
                            return return_v;
                        }


                        bool
                        f_10312_51815_51871(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        element)
                        {
                            var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)element);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51815, 51871);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10312_51970_52022(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        basesBeingResolved)
                        {
                            var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51970, 52022);
                            return return_v;
                        }


                        bool
                        f_10312_52055_52078_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 52055, 52078);
                            return return_v;
                        }


                        Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        f_10312_52149_52187(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        head)
                        {
                            var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(head);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 52149, 52187);
                            return return_v;
                        }


                        int
                        f_10312_52407_52487(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        @interface, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        visited, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        result, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                        basesBeingResolved, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        cycleGuard)
                        {
                            addAllInterfaces(@interface, visited, result, basesBeingResolved, cycleGuard);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 52407, 52487);
                            return 0;
                        }


                        int
                        f_10312_52593_52615(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 52593, 52615);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 51335, 52650);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 51335, 52650);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 48192, 52661);

                bool?
                f_10312_48396_48421_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 48396, 48421);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_48470_48544(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 48470, 48544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_48617_48640(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 48617, 48640);
                    return return_v;
                }


                bool
                f_10312_48580_48641(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 48580, 48641);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_48768_48814(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredInterfaces(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 48768, 48814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_50484_50507(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 50484, 50507);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_50444_50508(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 50444, 50508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_50710_50753()
                {
                    var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 50710, 50753);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_50782_50861(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 50782, 50861);
                    return return_v;
                }


                int
                f_10312_50959_51039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @interface, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                visited, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                result, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                cycleGuard)
                {
                    addAllInterfaces(@interface, visited, result, basesBeingResolved, cycleGuard);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 50959, 51039);
                    return 0;
                }


                int
                f_10312_51071_51095(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.ReverseContents();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51071, 51095);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_51178_51206(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 51178, 51206);
                    return return_v;
                }


                int
                f_10312_51178_51252(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51178, 51252);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_51138_51144_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51138, 51144);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_51291_51318(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 51291, 51318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 48192, 52661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 48192, 52661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LookupMembersInInterfacesWithoutInheritance(
                    LookupResult current,
                    ImmutableArray<NamedTypeSymbol> interfaces,
                    string name,
                    int arity,
                    ConsList<TypeSymbol> basesBeingResolved,
                    LookupOptions options,
                    Binder originalBinder,
                    TypeSymbol accessThroughType,
                    bool diagnose,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 52673, 54156);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53162, 54145) || true) && (interfaces.Length > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 53162, 54145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53221, 53258);

                    var
                    tmp = f_10312_53231_53257()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53276, 53323);

                    HashSet<NamedTypeSymbol>
                    seenInterfaces = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53341, 53522) || true) && (interfaces.Length > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 53341, 53522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53408, 53503);

                        seenInterfaces = f_10312_53425_53502(Symbols.SymbolEqualityComparer.IgnoringNullable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 53341, 53522);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53542, 54101);
                        foreach (NamedTypeSymbol baseInterface in f_10312_53584_53594_I(interfaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 53542, 54101);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53636, 54082) || true) && (seenInterfaces is null || (DynAbs.Tracing.TraceSender.Expression_False(10312, 53640, 53699) || f_10312_53666_53699(seenInterfaces, baseInterface)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 53636, 54082);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53749, 53912);

                                f_10312_53749_53911(tmp, baseInterface, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 53938, 54021);

                                f_10312_53938_54020(current, tmp, basesBeingResolved, ref useSiteDiagnostics);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54047, 54059);

                                f_10312_54047_54058(tmp);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 53636, 54082);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 53542, 54101);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 560);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 560);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54119, 54130);

                    f_10312_54119_54129(tmp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 53162, 54145);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 52673, 54156);

                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_53231_53257()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53231, 53257);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_53425_53502(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53425, 53502);
                    return return_v;
                }


                bool
                f_10312_53666_53699(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53666, 53699);
                    return return_v;
                }


                int
                f_10312_53749_53911(Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    LookupMembersWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, options, originalBinder, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53749, 53911);
                    return 0;
                }


                int
                f_10312_53938_54020(Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHiding, Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHidden, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    MergeHidingLookupResults(resultHiding, resultHidden, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53938, 54020);
                    return 0;
                }


                int
                f_10312_54047_54058(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54047, 54058);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_53584_53594_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 53584, 53594);
                    return return_v;
                }


                int
                f_10312_54119_54129(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54119, 54129);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 52673, 54156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 52673, 54156);
            }
        }

        private void LookupMembersInInterface(LookupResult current, NamedTypeSymbol type, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 54252, 55377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54532, 54567);

                f_10312_54532_54566((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54581, 54612);

                f_10312_54581_54611(f_10312_54594_54610(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54628, 54770);

                f_10312_54628_54769(current, type, name, arity, basesBeingResolved, options, originalBinder, type, diagnose, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54786, 55366) || true) && (f_10312_54790_54839_M(!originalBinder.InCrefButNotParameterOrReturnType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 54786, 55366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 54873, 54910);

                    var
                    tmp = f_10312_54883_54909()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55032, 55221);

                    f_10312_55032_55220(                // NB: we assume use-site-errors on System.Object, if any, have been reported earlier.
                                    this, tmp, f_10312_55063_55121(f_10312_55063_55079(this), SpecialType.System_Object), name, arity, basesBeingResolved, options, originalBinder, type, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55239, 55322);

                    f_10312_55239_55321(current, tmp, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55340, 55351);

                    f_10312_55340_55350(tmp);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 54786, 55366);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 54252, 55377);

                int
                f_10312_54532_54566(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54532, 54566);
                    return 0;
                }


                bool
                f_10312_54594_54610(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 54594, 54610);
                    return return_v;
                }


                int
                f_10312_54581_54611(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54581, 54611);
                    return 0;
                }


                int
                f_10312_54628_54769(Microsoft.CodeAnalysis.CSharp.LookupResult
                current, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    LookupMembersInInterfaceOnly(current, type, name, arity, basesBeingResolved, options, originalBinder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54628, 54769);
                    return 0;
                }


                bool
                f_10312_54790_54839_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 54790, 54839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10312_54883_54909()
                {
                    var return_v = LookupResult.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 54883, 54909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_55063_55079(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 55063, 55079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_55063_55121(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 55063, 55121);
                    return return_v;
                }


                int
                f_10312_55032_55220(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInClass(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, basesBeingResolved, options, originalBinder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 55032, 55220);
                    return 0;
                }


                int
                f_10312_55239_55321(Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHiding, Microsoft.CodeAnalysis.CSharp.LookupResult
                resultHidden, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    MergeHidingLookupResults(resultHiding, resultHidden, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 55239, 55321);
                    return 0;
                }


                int
                f_10312_55340_55350(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 55340, 55350);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 54252, 55377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 54252, 55377);
            }
        }

        private void LookupMembersInTypeParameter(LookupResult current, TypeParameterSymbol typeParameter, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 55433, 56914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55730, 55774);

                f_10312_55730_55773((object)typeParameter != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55790, 55941) || true) && ((options & (LookupOptions.NamespaceAliasesOnly | LookupOptions.NamespacesOrTypesOnly)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 55790, 55941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 55919, 55926);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 55790, 55941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 56064, 56160);

                f_10312_56064_56159(f_10312_56077_56099_M(!originalBinder.InCref), "Can't dot into type parameters, so how can this happen?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 56449, 56629);

                f_10312_56449_56628(this, current, f_10312_56479_56535(typeParameter, ref useSiteDiagnostics), name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 56643, 56903);

                f_10312_56643_56902(current, f_10312_56696_56788(typeParameter, ref useSiteDiagnostics), name, arity, basesBeingResolved: null, options, originalBinder, typeParameter, diagnose, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 55433, 56914);

                int
                f_10312_55730_55773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 55730, 55773);
                    return 0;
                }


                bool
                f_10312_56077_56099_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 56077, 56099);
                    return return_v;
                }


                int
                f_10312_56064_56159(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 56064, 56159);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_56479_56535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 56479, 56535);
                    return return_v;
                }


                int
                f_10312_56449_56628(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInClass(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 56449, 56628);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_56696_56788(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 56696, 56788);
                    return return_v;
                }


                int
                f_10312_56643_56902(Microsoft.CodeAnalysis.CSharp.LookupResult
                current, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                interfaces, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    LookupMembersInInterfacesWithoutInheritance(current, interfaces, name, arity, basesBeingResolved: basesBeingResolved, options, originalBinder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 56643, 56902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 55433, 56914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 55433, 56914);
            }
        }

        private static bool IsDerivedType(NamedTypeSymbol baseType, NamedTypeSymbol derivedType, ConsList<TypeSymbol> basesBeingResolved, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 56926, 57711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57128, 57221);

                f_10312_57128_57220(!f_10312_57142_57219(baseType, derivedType, TypeCompareKind.ConsiderEverything2));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57256, 57336);
                    for (NamedTypeSymbol
        b = f_10312_57260_57336(derivedType, ref useSiteDiagnostics)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57235, 57561) || true) && ((object)b != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57357, 57427)
        , b = f_10312_57361_57427(b, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 57235, 57561))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 57235, 57561);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57461, 57546) || true) && (f_10312_57465_57532(b, baseType, TypeCompareKind.ConsiderEverything2))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 57461, 57546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57534, 57546);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 57461, 57546);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 57575, 57700);

                return f_10312_57582_57602(baseType) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 57582, 57699) && f_10312_57606_57680(derivedType, basesBeingResolved, ref useSiteDiagnostics).Contains(baseType));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 56926, 57711);

                bool
                f_10312_57142_57219(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57142, 57219);
                    return return_v;
                }


                int
                f_10312_57128_57220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57128, 57220);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_57260_57336(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57260, 57336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_57361_57427(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57361, 57427);
                    return return_v;
                }


                bool
                f_10312_57465_57532(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57465, 57532);
                    return return_v;
                }


                bool
                f_10312_57582_57602(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 57582, 57602);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_57606_57680(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = GetBaseInterfaces(type, basesBeingResolved, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 57606, 57680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 56926, 57711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 56926, 57711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // Merge resultHidden into resultHiding, whereby viable results in resultHiding should hide results
        // in resultHidden if the owner of the symbol in resultHiding is a subtype of the owner of the symbol
        // in resultHidden. We merge together methods [indexers], but non-methods [non-indexers] hide everything and methods [indexers] hide non-methods [non-indexers].
        private static void MergeHidingLookupResults(LookupResult resultHiding, LookupResult resultHidden, ConsList<TypeSymbol> basesBeingResolved, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            // Methods hide non-methods, non-methods hide everything.

            if (resultHiding.IsMultiViable && resultHidden.IsMultiViable)
            {
                // Check if resultHiding has any non-methods. If so, it hides everything in resultHidden.
                var hidingSymbols = resultHiding.Symbols;
                var hidingCount = hidingSymbols.Count;
                var hiddenSymbols = resultHidden.Symbols;
                var hiddenCount = hiddenSymbols.Count;
                for (int i = 0; i < hiddenCount; i++)
                {
                    var sym = hiddenSymbols[i];
                    var hiddenContainer = sym.ContainingType;

                    // see if sym is hidden
                    for (int j = 0; j < hidingCount; j++)
                    {
                        var hidingSym = hidingSymbols[j];
                        var hidingContainer = hidingSym.ContainingType;
                        var hidingContainerIsInterface = hidingContainer.IsInterface;

                        if (hidingContainerIsInterface)
                        {
                            // SPEC: For the purposes of member lookup [...] if T is an
                            // SPEC: interface type, the base types of T are the base interfaces
                            // SPEC: of T and the class type object. 

                            if (!IsDerivedType(baseType: hiddenContainer, derivedType: hidingSym.ContainingType, basesBeingResolved, useSiteDiagnostics: ref useSiteDiagnostics) &&
                                hiddenContainer.SpecialType != SpecialType.System_Object)
                            {
                                continue; // not in inheritance relationship, so it cannot hide
                            }
                        }

                        if (!IsMethodOrIndexer(hidingSym) || !IsMethodOrIndexer(sym))
                        {
                            // any non-method [non-indexer] hides everything in the hiding scope
                            // any method [indexer] hides non-methods [non-indexers].
                            goto symIsHidden;
                        }

                        // Note: We do not implement hiding by signature in non-interfaces here; that is handled later in overload lookup.
                    }

                    hidingSymbols.Add(sym); // not hidden
symIsHidden:;
                }
            }
            else
            {
                resultHiding.MergePrioritized(resultHidden);
            }
        }

        private static bool IsMethodOrIndexer(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 61319, 61469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 61396, 61458);

                return f_10312_61403_61414(symbol) == SymbolKind.Method || (DynAbs.Tracing.TraceSender.Expression_False(10312, 61403, 61457) || f_10312_61439_61457(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 61319, 61469);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_61403_61414(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 61403, 61414);
                    return return_v;
                }


                bool
                f_10312_61439_61457(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 61439, 61457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 61319, 61469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 61319, 61469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<Symbol> GetCandidateMembers(NamespaceOrTypeSymbol nsOrType, string name, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 61481, 62338);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 61655, 62327) || true) && ((options & LookupOptions.NamespacesOrTypesOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 61659, 61737) && nsOrType is TypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 61655, 62327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 61771, 61840);

                    return f_10312_61778_61807(nsOrType, name).Cast<NamedTypeSymbol, Symbol>();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 61655, 62327);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 61655, 62327);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 61874, 62327) || true) && (f_10312_61878_61891(nsOrType) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10312, 61878, 61956) && f_10312_61919_61956(originalBinder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 61874, 62327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 61990, 62064);

                        return f_10312_61997_62063(((NamedTypeSymbol)nsOrType), name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 61874, 62327);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 61874, 62327);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62098, 62327) || true) && ((options & LookupOptions.LabelsOnly) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62098, 62327);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62177, 62213);

                            return ImmutableArray<Symbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62098, 62327);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62098, 62327);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62279, 62312);

                            return f_10312_62286_62311(nsOrType, name);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62098, 62327);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 61874, 62327);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 61655, 62327);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 61481, 62338);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_61778_61807(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 61778, 61807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_61878_61891(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 61878, 61891);
                    return return_v;
                }


                bool
                f_10312_61919_61956(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsEarlyAttributeBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 61919, 61956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_61997_62063(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 61997, 62063);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_62286_62311(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 62286, 62311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 61481, 62338);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 61481, 62338);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<Symbol> GetCandidateMembers(NamespaceOrTypeSymbol nsOrType, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 62350, 63193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62511, 63182) || true) && ((options & LookupOptions.NamespacesOrTypesOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 62515, 62593) && nsOrType is TypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62511, 63182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62627, 62694);

                    return f_10312_62634_62693(f_10312_62658_62692(nsOrType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62511, 63182);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62511, 63182);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62728, 63182) || true) && (f_10312_62732_62745(nsOrType) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10312, 62732, 62810) && f_10312_62773_62810(originalBinder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62728, 63182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62844, 62914);

                        return f_10312_62851_62913(((NamedTypeSymbol)nsOrType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62728, 63182);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62728, 63182);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 62948, 63182) || true) && ((options & LookupOptions.LabelsOnly) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62948, 63182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 63027, 63063);

                            return ImmutableArray<Symbol>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62948, 63182);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 62948, 63182);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 63129, 63167);

                            return f_10312_63136_63166(nsOrType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62948, 63182);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62728, 63182);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 62511, 63182);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 62350, 63193);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_62658_62692(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 62658, 62692);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_62634_62693(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                from)
                {
                    var return_v = StaticCast<Symbol>.From(from);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 62634, 62693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_62732_62745(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 62732, 62745);
                    return return_v;
                }


                bool
                f_10312_62773_62810(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsEarlyAttributeBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 62773, 62810);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_62851_62913(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetEarlyAttributeDecodingMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 62851, 62913);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_63136_63166(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 63136, 63166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 62350, 63193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 62350, 63193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SingleLookupResult CheckViability(Symbol symbol, int arity, LookupOptions options, TypeSymbol accessThroughType, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 63381, 70761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 63638, 63668);

                bool
                inaccessibleViaQualifier
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 63682, 63706);

                DiagnosticInfo
                diagInfo
                = default(DiagnosticInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 63859, 64015);

                var
                unwrappedSymbol = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 63881, 63912) || ((f_10312_63881_63892(symbol) == SymbolKind.Alias
                && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 63932, 63988)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 64008, 64014))) ? f_10312_63932_63988(((AliasSymbol)symbol), basesBeingResolved) : symbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 64121, 69285) || true) && (!f_10312_64126_64196(f_10312_64126_64155(f_10312_64126_64142(this)), f_10312_64163_64195(unwrappedSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 64125, 64257) && f_10312_64200_64257(unwrappedSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64121, 69285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 64291, 64319);

                    return f_10312_64298_64318();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64121, 69285);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64121, 69285);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 64353, 69285) || true) && (f_10312_64357_64415(symbol, arity, diagnose, options, out diagInfo))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64353, 69285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 64449, 64498);

                        return f_10312_64456_64497(symbol, diagInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64353, 69285);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64353, 69285);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 64532, 69285) || true) && (f_10312_64536_64543_M(!InCref) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 64536, 64610) && f_10312_64547_64610_M(!unwrappedSymbol.CanBeReferencedByNameIgnoringIllegalCharacters)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64532, 69285);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65019, 65123);

                            diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 65030, 65038) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 65041, 65115)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 65118, 65122))) ? f_10312_65041_65115(ErrorCode.ERR_CantCallSpecialMethod, unwrappedSymbol) : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65141, 65195);

                            return f_10312_65148_65194(symbol, diagInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64532, 69285);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 64532, 69285);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65229, 69285) || true) && ((options & LookupOptions.NamespacesOrTypesOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 65233, 65332) && !(unwrappedSymbol is NamespaceOrTypeSymbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65229, 69285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65366, 65440);

                                return f_10312_65373_65439(unwrappedSymbol, symbol, diagnose);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65229, 69285);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65229, 69285);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65474, 69285) || true) && ((options & LookupOptions.MustBeInvocableIfMember) != 0
                                && (DynAbs.Tracing.TraceSender.Expression_True(10312, 65478, 65590) && f_10312_65553_65590(this, unwrappedSymbol)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65474, 69285);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65624, 65692);

                                    return f_10312_65631_65691(unwrappedSymbol, symbol, diagnose);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65474, 69285);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65474, 69285);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65726, 69285) || true) && (f_10312_65730_65736() && (DynAbs.Tracing.TraceSender.Expression_True(10312, 65730, 65779) && !f_10312_65741_65779(this, unwrappedSymbol)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65726, 69285);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65813, 65883);

                                        var
                                        unwrappedSymbols = f_10312_65836_65882(unwrappedSymbol)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 65901, 66074);

                                        diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 65912, 65920) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 65923, 66066)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 66069, 66073))) ? f_10312_65923_66066(ErrorCode.ERR_BadAccess, new[] { unwrappedSymbol }, unwrappedSymbols, additionalLocations: ImmutableArray<Location>.Empty) : null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66092, 66143);

                                        return f_10312_66099_66142(symbol, diagInfo);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65726, 69285);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 65726, 69285);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66177, 69285) || true) && (f_10312_66181_66188_M(!InCref) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 66181, 66540) && !f_10312_66215_66540(this, unwrappedSymbol, f_10312_66291_66342(options, accessThroughType), out inaccessibleViaQualifier, ref useSiteDiagnostics, basesBeingResolved)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66177, 69285);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66574, 67477) || true) && (!diagnose)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66574, 67477);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66629, 66645);

                                                diagInfo = null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66574, 67477);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66574, 67477);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66687, 67477) || true) && (inaccessibleViaQualifier)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66687, 67477);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66757, 66880);

                                                    diagInfo = f_10312_66768_66879(ErrorCode.ERR_BadProtectedAccess, unwrappedSymbol, accessThroughType, f_10312_66859_66878(this));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66687, 67477);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66687, 67477);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66922, 67477) || true) && (f_10312_66926_66949())
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66922, 67477);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 66991, 67191);

                                                        diagInfo = f_10312_67002_67190(ErrorCode.ERR_FriendRefNotEqualToThis, f_10312_67062_67116(f_10312_67062_67105(f_10312_67062_67096(unwrappedSymbol))), f_10312_67118_67189(f_10312_67153_67188(f_10312_67153_67178(f_10312_67153_67169(this)))));
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66922, 67477);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66922, 67477);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67273, 67458);

                                                        diagInfo = f_10312_67284_67457(ErrorCode.ERR_BadAccess, new[] { unwrappedSymbol }, f_10312_67357_67403(unwrappedSymbol), additionalLocations: ImmutableArray<Location>.Empty);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66922, 67477);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66687, 67477);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66574, 67477);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67497, 67548);

                                            return f_10312_67504_67547(symbol, diagInfo);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66177, 69285);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 66177, 69285);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67582, 69285) || true) && (f_10312_67586_67593_M(!InCref) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 67586, 67638) && f_10312_67597_67638(unwrappedSymbol)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 67582, 69285);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67672, 67752);

                                                diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 67683, 67691) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 67694, 67744)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 67747, 67751))) ? f_10312_67694_67744(this, unwrappedSymbol) : null;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67770, 67824);

                                                return f_10312_67777_67823(symbol, diagInfo);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 67582, 69285);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 67582, 69285);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67858, 69285) || true) && ((options & LookupOptions.MustBeInstance) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 67862, 67939) && !f_10312_67912_67939(unwrappedSymbol)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 67858, 69285);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 67973, 68070);

                                                    diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 67984, 67992) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 67995, 68062)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 68065, 68069))) ? f_10312_67995_68062(ErrorCode.ERR_ObjectRequired, unwrappedSymbol) : null;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68088, 68149);

                                                    return f_10312_68095_68148(symbol, diagInfo);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 67858, 69285);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 67858, 69285);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68183, 69285) || true) && ((options & LookupOptions.MustNotBeInstance) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 68187, 68266) && f_10312_68239_68266(unwrappedSymbol)))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68183, 69285);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68300, 68399);

                                                        diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 68311, 68319) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 68322, 68391)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 68394, 68398))) ? f_10312_68322_68391(ErrorCode.ERR_ObjectProhibited, unwrappedSymbol) : null;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68417, 68478);

                                                        return f_10312_68424_68477(symbol, diagInfo);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68183, 69285);
                                                    }

                                                    else
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68183, 69285);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68512, 69285) || true) && ((options & LookupOptions.MustNotBeNamespace) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 68516, 68613) && f_10312_68569_68589(unwrappedSymbol) == SymbolKind.Namespace))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68512, 69285);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68647, 68773);

                                                            diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 68658, 68666) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 68669, 68765)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 68768, 68772))) ? f_10312_68669_68765(ErrorCode.ERR_BadSKunknown, unwrappedSymbol, f_10312_68735_68764(unwrappedSymbol)) : null;
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68791, 68848);

                                                            return f_10312_68798_68847(symbol, diagInfo);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68512, 69285);
                                                        }

                                                        else
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68512, 69285);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 68882, 69285) || true) && ((options & LookupOptions.LabelsOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 68886, 68971) && f_10312_68931_68951(unwrappedSymbol) != SymbolKind.Label))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68882, 69285);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 69005, 69106);

                                                                diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 69016, 69024) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 69027, 69098)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 69101, 69105))) ? f_10312_69027_69098(ErrorCode.ERR_LabelNotFound, f_10312_69077_69097(unwrappedSymbol)) : null;
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 69124, 69171);

                                                                return f_10312_69131_69170(symbol, diagInfo);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68882, 69285);
                                                            }

                                                            else

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 68882, 69285);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 69237, 69270);

                                                                return f_10312_69244_69269(symbol);
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68882, 69285);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68512, 69285);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 68183, 69285);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 67858, 69285);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 67582, 69285);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 66177, 69285);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65726, 69285);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65474, 69285);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 65229, 69285);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64532, 69285);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64353, 69285);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 64121, 69285);
                }

                bool IsBadIvtSpecification()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 69301, 70750);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 69565, 70704) || true) && ((f_10312_69570_69607(unwrappedSymbol) == Accessibility.Internal || (DynAbs.Tracing.TraceSender.Expression_False(10312, 69570, 69733) || f_10312_69658_69695(unwrappedSymbol) == Accessibility.ProtectedAndInternal) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 69570, 69832) || f_10312_69758_69795(unwrappedSymbol) == Accessibility.ProtectedOrInternal))
                        && (DynAbs.Tracing.TraceSender.Expression_True(10312, 69569, 69890) && !f_10312_69859_69890(options)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 69565, 70704);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 69932, 69981);

                            var
                            assemblyName = f_10312_69951_69980(f_10312_69951_69967(this))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70003, 70113) || true) && (assemblyName == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 70003, 70113);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70077, 70090);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 70003, 70113);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70135, 70227);

                            var
                            keys = f_10312_70146_70226(f_10312_70146_70180(unwrappedSymbol), assemblyName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70249, 70350) || true) && (!f_10312_70254_70264(keys))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 70249, 70350);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70314, 70327);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 70249, 70350);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70372, 70651);
                                foreach (ImmutableArray<byte> key in f_10312_70409_70413_I(keys))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 70372, 70651);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70463, 70628) || true) && (key.SequenceEqual(f_10312_70485_70529(f_10312_70485_70519(f_10312_70485_70510(f_10312_70485_70501(this))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 70463, 70628);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70588, 70601);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 70463, 70628);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 70372, 70651);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 280);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 280);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70673, 70685);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 69565, 70704);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70722, 70735);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 69301, 70750);

                        Microsoft.CodeAnalysis.Accessibility
                        f_10312_69570_69607(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69570, 69607);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Accessibility
                        f_10312_69658_69695(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69658, 69695);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Accessibility
                        f_10312_69758_69795(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69758, 69795);
                            return return_v;
                        }


                        bool
                        f_10312_69859_69890(Microsoft.CodeAnalysis.CSharp.LookupOptions
                        options)
                        {
                            var return_v = options.IsAttributeTypeLookup();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 69859, 69890);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10312_69951_69967(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69951, 69967);
                            return return_v;
                        }


                        string?
                        f_10312_69951_69980(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.AssemblyName;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69951, 69980);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10312_70146_70180(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingAssembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 70146, 70180);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                        f_10312_70146_70226(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param, string
                        simpleName)
                        {
                            var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 70146, 70226);
                            return return_v;
                        }


                        bool
                        f_10312_70254_70264(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                        source)
                        {
                            var return_v = source.Any<System.Collections.Immutable.ImmutableArray<byte>>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 70254, 70264);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10312_70485_70501(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 70485, 70501);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        f_10312_70485_70510(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.Assembly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 70485, 70510);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.AssemblyIdentity
                        f_10312_70485_70519(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                        this_param)
                        {
                            var return_v = this_param.Identity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 70485, 70519);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<byte>
                        f_10312_70485_70529(Microsoft.CodeAnalysis.AssemblyIdentity
                        this_param)
                        {
                            var return_v = this_param.PublicKey;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 70485, 70529);
                            return return_v;
                        }


                        System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                        f_10312_70409_70413_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 70409, 70413);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 69301, 70750);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 69301, 70750);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 63381, 70761);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_63881_63892(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 63881, 63892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10312_63932_63988(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 63932, 63988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_64126_64142(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 64126, 64142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10312_64126_64155(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 64126, 64155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10312_64163_64195(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 64163, 64195);
                    return return_v;
                }


                bool
                f_10312_64126_64196(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 64126, 64196);
                    return return_v;
                }


                bool
                f_10312_64200_64257(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsHiddenByCodeAnalysisEmbeddedAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 64200, 64257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_64298_64318()
                {
                    var return_v = LookupResult.Empty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 64298, 64318);
                    return return_v;
                }


                bool
                f_10312_64357_64415(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, int
                arity, bool
                diagnose, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, out Microsoft.CodeAnalysis.DiagnosticInfo
                diagInfo)
                {
                    var return_v = WrongArity(symbol, arity, diagnose, options, out diagInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 64357, 64415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_64456_64497(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = LookupResult.WrongArity(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 64456, 64497);
                    return return_v;
                }


                bool
                f_10312_64536_64543_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 64536, 64543);
                    return return_v;
                }


                bool
                f_10312_64547_64610_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 64547, 64610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_65041_65115(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65041, 65115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_65148_65194(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.NotReferencable(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65148, 65194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_65373_65439(Microsoft.CodeAnalysis.CSharp.Symbol
                unwrappedSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                diagnose)
                {
                    var return_v = LookupResult.NotTypeOrNamespace(unwrappedSymbol, symbol, diagnose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65373, 65439);
                    return return_v;
                }


                bool
                f_10312_65553_65590(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsNonInvocableMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65553, 65590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_65631_65691(Microsoft.CodeAnalysis.CSharp.Symbol
                unwrappedSymbol, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, bool
                diagnose)
                {
                    var return_v = LookupResult.NotInvocable(unwrappedSymbol, symbol, diagnose);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65631, 65691);
                    return return_v;
                }


                bool
                f_10312_65730_65736()
                {
                    var return_v = InCref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 65730, 65736);
                    return return_v;
                }


                bool
                f_10312_65741_65779(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsCrefAccessible(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65741, 65779);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_65836_65882(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65836, 65882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_65923_66066(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Symbol[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, (object[])args, symbols, additionalLocations: additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 65923, 66066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_66099_66142(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.Inaccessible(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 66099, 66142);
                    return return_v;
                }


                bool
                f_10312_66181_66188_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 66181, 66188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_66291_66342(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = RefineAccessThroughType(options, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 66291, 66342);
                    return return_v;
                }


                bool
                f_10312_66215_66540(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.IsAccessible(symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 66215, 66540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10312_66859_66878(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 66859, 66878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_66768_66879(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 66768, 66879);
                    return return_v;
                }


                bool
                f_10312_66926_66949()
                {
                    var return_v = IsBadIvtSpecification();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 66926, 66949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10312_67062_67096(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67062, 67096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10312_67062_67105(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67062, 67105);
                    return return_v;
                }


                string
                f_10312_67062_67116(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67062, 67116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_67153_67169(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67153, 67169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10312_67153_67178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67153, 67178);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_10312_67153_67188(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.PublicKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67153, 67188);
                    return return_v;
                }


                string
                f_10312_67118_67189(System.Collections.Immutable.ImmutableArray<byte>
                key)
                {
                    var return_v = AssemblyIdentity.PublicKeyToString(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67118, 67189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_67002_67190(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67002, 67190);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_67357_67403(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67357, 67403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_67284_67457(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Symbol[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, (object[])args, symbols, additionalLocations: additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67284, 67457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_67504_67547(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.Inaccessible(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67504, 67547);
                    return return_v;
                }


                bool
                f_10312_67586_67593_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 67586, 67593);
                    return return_v;
                }


                bool
                f_10312_67597_67638(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.MustCallMethodsDirectly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67597, 67638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_67694_67744(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.MakeCallMethodsDirectlyDiagnostic(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67694, 67744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_67777_67823(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.NotReferencable(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67777, 67823);
                    return return_v;
                }


                bool
                f_10312_67912_67939(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsInstance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67912, 67939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_67995_68062(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 67995, 68062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_68095_68148(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.StaticInstanceMismatch(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68095, 68148);
                    return return_v;
                }


                bool
                f_10312_68239_68266(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsInstance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68239, 68266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_68322_68391(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68322, 68391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_68424_68477(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.StaticInstanceMismatch(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68424, 68477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_68569_68589(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 68569, 68589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_68735_68764(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetKindText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68735, 68764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_68669_68765(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68669, 68765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_68798_68847(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.NotTypeOrNamespace(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 68798, 68847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_68931_68951(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 68931, 68951);
                    return return_v;
                }


                string
                f_10312_69077_69097(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 69077, 69097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_69027_69098(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 69027, 69098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_69131_69170(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    var return_v = LookupResult.NotLabel(symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 69131, 69170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_69244_69269(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = LookupResult.Good(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 69244, 69269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 63381, 70761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 63381, 70761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSDiagnosticInfo MakeCallMethodsDirectlyDiagnostic(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 70773, 72117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70871, 70918);

                f_10312_70871_70917(f_10312_70884_70916(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70934, 70955);

                MethodSymbol
                method1
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 70969, 70990);

                MethodSymbol
                method2
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71006, 71828);

                switch (f_10312_71014_71025(symbol))
                {

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 71006, 71828);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71133, 71221);

                            var
                            property = f_10312_71148_71220(((PropertySymbol)symbol), f_10312_71200_71219(this))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71247, 71276);

                            method1 = f_10312_71257_71275(property);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71302, 71331);

                            method2 = f_10312_71312_71330(property);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 71376, 71382);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 71006, 71828);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 71006, 71828);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71471, 71551);

                            var
                            @event = f_10312_71484_71550(((EventSymbol)symbol), f_10312_71530_71549(this))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71577, 71604);

                            method1 = f_10312_71587_71603(@event);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71630, 71660);

                            method2 = f_10312_71640_71659(@event);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 71705, 71711);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 71006, 71828);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 71006, 71828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71759, 71813);

                        throw f_10312_71765_71812(f_10312_71800_71811(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 71006, 71828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 71844, 72106);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 71851, 71907) || (((((object)method1 != null) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 71852, 71906) && ((object)method2 != null))) && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 71927, 72005)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 72025, 72105))) ? f_10312_71927_72005(ErrorCode.ERR_BindToBogusProp2, symbol, method1, method2) : f_10312_72025_72105(ErrorCode.ERR_BindToBogusProp1, symbol, method1 ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?>(10312, 72086, 72104) ?? method2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 70773, 72117);

                bool
                f_10312_70884_70916(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.MustCallMethodsDirectly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 70884, 70916);
                    return return_v;
                }


                int
                f_10312_70871_70917(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 70871, 70917);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_71014_71025(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71014, 71025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10312_71200_71219(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71200, 71219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10312_71148_71220(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenProperty(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 71148, 71220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10312_71257_71275(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71257, 71275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10312_71312_71330(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71312, 71330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10312_71530_71549(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71530, 71549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10312_71484_71550(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenEvent(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 71484, 71550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10312_71587_71603(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71587, 71603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10312_71640_71659(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71640, 71659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_71800_71811(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 71800, 71811);
                    return return_v;
                }


                System.Exception
                f_10312_71765_71812(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 71765, 71812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_71927_72005(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 71927, 72005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_72025_72105(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 72025, 72105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 70773, 72117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 70773, 72117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void CheckViability<TSymbol>(LookupResult result, ImmutableArray<TSymbol> symbols, int arity, LookupOptions options, TypeSymbol accessThroughType, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved) where TSymbol : Symbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 72129, 72694);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 72436, 72683);
                    foreach (var symbol in f_10312_72459_72466_I<TSymbol>(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 72436, 72683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 72500, 72627);

                        var
                        res = f_10312_72510_72626<TSymbol>(this, symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 72645, 72668);

                        f_10312_72645_72667<TSymbol>(result, res);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 72436, 72683);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 248);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 72129, 72694);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10312_72510_72626<TSymbol>(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, TSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved) where TSymbol : Symbol

                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 72510, 72626);
                    return return_v;
                }


                int
                f_10312_72645_72667<TSymbol>(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result) where TSymbol : Symbol

                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 72645, 72667);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<TSymbol>
                f_10312_72459_72466_I<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
                i) where TSymbol : Symbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 72459, 72466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 72129, 72694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 72129, 72694);
            }
        }

        internal bool CanAddLookupSymbolInfo(Symbol symbol, LookupOptions options, LookupSymbolsInfo info, TypeSymbol accessThroughType, AliasSymbol aliasSymbol = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 73109, 75239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73294, 73404);

                f_10312_73294_73403(f_10312_73307_73318(symbol) != SymbolKind.Alias, "It is the caller's responsibility to unwrap aliased symbols.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73418, 73518);

                f_10312_73418_73517(aliasSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(10312, 73431, 73516) || f_10312_73454_73506(aliasSymbol, basesBeingResolved: null) == symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73532, 73565);

                f_10312_73532_73564(f_10312_73545_73563(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73579, 73629);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73645, 73709);

                var
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 73656, 73675) || ((aliasSymbol != null && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 73678, 73694)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 73697, 73708))) ? f_10312_73678_73694(aliasSymbol) : f_10312_73697_73708(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73723, 73811) || true) && (!f_10312_73728_73749(info, name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 73723, 73811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73783, 73796);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 73723, 73811);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73827, 75228) || true) && ((options & LookupOptions.NamespacesOrTypesOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 73831, 73921) && !(symbol is NamespaceOrTypeSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 73827, 75228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 73955, 73968);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 73827, 75228);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 73827, 75228);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74002, 75228) || true) && ((options & LookupOptions.MustBeInvocableIfMember) != 0
                    && (DynAbs.Tracing.TraceSender.Expression_True(10312, 74006, 74109) && f_10312_74081_74109(this, symbol)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74002, 75228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74143, 74156);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74002, 75228);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74002, 75228);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74190, 75228) || true) && ((DynAbs.Tracing.TraceSender.Conditional_F1(10312, 74194, 74200) || ((f_10312_74194_74200() && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 74203, 74233)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 74265, 74368))) ? !f_10312_74204_74233(this, symbol) : !f_10312_74266_74368(this, symbol, ref useSiteDiagnostics, f_10312_74316_74367(options, accessThroughType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74190, 75228);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74402, 74415);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74190, 75228);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74190, 75228);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74449, 75228) || true) && ((options & LookupOptions.MustBeInstance) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 74453, 74521) && !f_10312_74503_74521(symbol)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74449, 75228);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74555, 74568);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74449, 75228);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74449, 75228);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74602, 75228) || true) && ((options & LookupOptions.MustNotBeInstance) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 74606, 74676) && f_10312_74658_74676(symbol)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74602, 75228);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74710, 74723);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74602, 75228);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74602, 75228);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74757, 75228) || true) && ((options & LookupOptions.MustNotBeNamespace) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 74761, 74851) && (f_10312_74815_74826(symbol) == SymbolKind.Namespace)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74757, 75228);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 74885, 74898);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74757, 75228);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 74757, 75228);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 75201, 75213);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74757, 75228);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74602, 75228);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74449, 75228);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74190, 75228);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 74002, 75228);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 73827, 75228);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 73109, 75239);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_73307_73318(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 73307, 73318);
                    return return_v;
                }


                int
                f_10312_73294_73403(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73294, 73403);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10312_73454_73506(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetAliasTarget(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73454, 73506);
                    return return_v;
                }


                int
                f_10312_73418_73517(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73418, 73517);
                    return 0;
                }


                bool
                f_10312_73545_73563(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.AreValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73545, 73563);
                    return return_v;
                }


                int
                f_10312_73532_73564(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73532, 73564);
                    return 0;
                }


                string
                f_10312_73678_73694(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 73678, 73694);
                    return return_v;
                }


                string
                f_10312_73697_73708(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 73697, 73708);
                    return return_v;
                }


                bool
                f_10312_73728_73749(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, string
                name)
                {
                    var return_v = this_param.CanBeAdded(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 73728, 73749);
                    return return_v;
                }


                bool
                f_10312_74081_74109(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsNonInvocableMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74081, 74109);
                    return return_v;
                }


                bool
                f_10312_74194_74200()
                {
                    var return_v = InCref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 74194, 74200);
                    return return_v;
                }


                bool
                f_10312_74204_74233(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsCrefAccessible(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74204, 74233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_74316_74367(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = RefineAccessThroughType(options, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74316, 74367);
                    return return_v;
                }


                bool
                f_10312_74266_74368(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.IsAccessible(symbol, ref useSiteDiagnostics, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74266, 74368);
                    return return_v;
                }


                bool
                f_10312_74503_74521(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsInstance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74503, 74521);
                    return return_v;
                }


                bool
                f_10312_74658_74676(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsInstance(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 74658, 74676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_74815_74826(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 74815, 74826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 73109, 75239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 73109, 75239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol RefineAccessThroughType(LookupOptions options, TypeSymbol accessThroughType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 75251, 75877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 75735, 75866);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 75742, 75804) || ((((options & LookupOptions.UseBaseReferenceAccessibility) != 0)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 75824, 75828)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 75848, 75865))) ? null
                : accessThroughType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 75251, 75877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 75251, 75877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 75251, 75877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsCrefAccessible(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 76112, 76287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76181, 76276);

                return !f_10312_76189_76217(symbol) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 76188, 76275) || f_10312_76221_76246(symbol) == f_10312_76250_76275(f_10312_76250_76266(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 76112, 76287);

                bool
                f_10312_76189_76217(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = IsEffectivelyPrivate(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 76189, 76217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10312_76221_76246(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 76221, 76246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_76250_76266(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 76250, 76266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10312_76250_76275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 76250, 76275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 76112, 76287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 76112, 76287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsEffectivelyPrivate(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 76299, 76658);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76391, 76401);
                    for (Symbol
        s = symbol
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76379, 76618) || true) && ((object)s != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76422, 76444)
        , s = f_10312_76426_76444(s), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 76379, 76618))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 76379, 76618);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76478, 76603) || true) && (f_10312_76482_76505(s) == Accessibility.Private)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 76478, 76603);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76572, 76584);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 76478, 76603);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 76634, 76647);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 76299, 76658);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10312_76426_76444(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 76426, 76444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10312_76482_76505(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 76482, 76505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 76299, 76658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 76299, 76658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAccessible(Symbol symbol, ref HashSet<DiagnosticInfo> useSiteDiagnostics, TypeSymbol accessThroughType = null, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 76852, 77223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77051, 77079);

                bool
                failedThroughTypeCheck
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77093, 77212);

                return f_10312_77100_77211(this, symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 76852, 77223);

                bool
                f_10312_77100_77211(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.IsAccessible(symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 77100, 77211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 76852, 77223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 76852, 77223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsAccessible(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 77501, 78044);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77726, 77892) || true) && (f_10312_77730_77782(this.Flags, BinderFlags.IgnoreAccessibility))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 77726, 77892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77816, 77847);

                    failedThroughTypeCheck = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77865, 77877);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 77726, 77892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 77908, 78033);

                return f_10312_77915_78032(this, symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 77501, 78044);

                bool
                f_10312_77730_77782(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 77730, 77782);
                    return return_v;
                }


                bool
                f_10312_77915_78032(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.IsAccessibleHelper(symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 77915, 78032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 77501, 78044);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 77501, 78044);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsAccessibleHelper(Symbol symbol, TypeSymbol accessThroughType, out bool failedThroughTypeCheck, ref HashSet<DiagnosticInfo> useSiteDiagnostics, ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 78346, 78783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 78642, 78772);

                return f_10312_78649_78771(f_10312_78649_78653(), symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 78346, 78783);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10312_78649_78653()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 78649, 78653);
                    return return_v;
                }


                bool
                f_10312_78649_78771(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, out bool
                failedThroughTypeCheck, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.IsAccessibleHelper(symbol, accessThroughType, out failedThroughTypeCheck, ref useSiteDiagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 78649, 78771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 78346, 78783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 78346, 78783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNonInvocableMember(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 78795, 79257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 78869, 79246);

                switch (f_10312_78877_78888(symbol))
                {

                    case SymbolKind.Method:
                    case SymbolKind.Field:
                    case SymbolKind.Property:
                    case SymbolKind.NamedType:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 78869, 79246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79134, 79168);

                        return !f_10312_79142_79167(this, symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 78869, 79246);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 78869, 79246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79218, 79231);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 78869, 79246);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 78795, 79257);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_78877_78888(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 78877, 78888);
                    return return_v;
                }


                bool
                f_10312_79142_79167(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.IsInvocableMember(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 79142, 79167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 78795, 79257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 78795, 79257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsInvocableMember(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 79269, 80222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79538, 79561);

                TypeSymbol
                type = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79577, 80092);

                switch (f_10312_79585_79596(symbol))
                {

                    case SymbolKind.Method:
                    case SymbolKind.Event: // Spec says it doesn't matter whether it is field-like
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 79577, 80092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79771, 79783);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 79577, 80092);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 79577, 80092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 79847, 79917);

                        type = f_10312_79854_79911(((FieldSymbol)symbol), f_10312_79889_79910(this)).Type;
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 79939, 79945);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 79577, 80092);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 79577, 80092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 80012, 80049);

                        type = f_10312_80019_80048(((PropertySymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 80071, 80077);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 79577, 80092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 80108, 80211);

                return (object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 80115, 80210) && (f_10312_80140_80161(type) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 80140, 80181) || f_10312_80165_80181(type)) || (DynAbs.Tracing.TraceSender.Expression_False(10312, 80140, 80209) || f_10312_80185_80209(type))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 79269, 80222);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_79585_79596(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 79585, 79596);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10312_79889_79910(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.FieldsBeingBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 79889, 79910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10312_79854_79911(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 79854, 79911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_80019_80048(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 80019, 80048);
                    return return_v;
                }


                bool
                f_10312_80140_80161(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 80140, 80161);
                    return return_v;
                }


                bool
                f_10312_80165_80181(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 80165, 80181);
                    return return_v;
                }


                bool
                f_10312_80185_80209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 80185, 80209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 79269, 80222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 79269, 80222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInstance(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 80234, 80653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 80304, 80642);

                switch (f_10312_80312_80323(symbol))
                {

                    case SymbolKind.Field:
                    case SymbolKind.Property:
                    case SymbolKind.Method:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 80304, 80642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 80525, 80566);

                        return f_10312_80532_80565(symbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 80304, 80642);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 80304, 80642);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 80614, 80627);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 80304, 80642);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 80234, 80653);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_80312_80323(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 80312, 80323);
                    return return_v;
                }


                bool
                f_10312_80532_80565(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.RequiresInstanceReceiver();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 80532, 80565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 80234, 80653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 80234, 80653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool WrongArity(Symbol symbol, int arity, bool diagnose, LookupOptions options, out DiagnosticInfo diagInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 80947, 84104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81095, 84034);

                switch (f_10312_81103_81114(symbol))
                {

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81095, 84034);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81196, 82523) || true) && (arity != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10312, 81200, 81269) || (options & LookupOptions.AllNamedTypesOnArityZero) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81196, 82523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81319, 81371);

                            NamedTypeSymbol
                            namedType = (NamedTypeSymbol)symbol
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81495, 81570);

                            f_10312_81495_81569(f_10312_81508_81568(f_10312_81531_81556(namedType), namedType));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81596, 82500) || true) && (f_10312_81600_81615(namedType) != arity || (DynAbs.Tracing.TraceSender.Expression_False(10312, 81600, 81673) || f_10312_81628_81659(options) && (DynAbs.Tracing.TraceSender.Expression_True(10312, 81628, 81673) && arity != 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81596, 82500);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81731, 82431) || true) && (f_10312_81735_81750(namedType) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81731, 82431);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 81918, 82042);

                                    diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 81929, 81937) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 81940, 82034)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 82037, 82041))) ? f_10312_81940_82034(ErrorCode.ERR_HasNoTypeVars, namedType, f_10312_82001_82033(MessageID.IDS_SK_TYPE)) : null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81731, 82431);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81731, 82431);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82264, 82400);

                                    diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 82275, 82283) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 82286, 82392)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 82395, 82399))) ? f_10312_82286_82392(ErrorCode.ERR_BadArity, namedType, f_10312_82342_82374(MessageID.IDS_SK_TYPE), f_10312_82376_82391(namedType)) : null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81731, 82431);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82461, 82473);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81596, 82500);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81196, 82523);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 82545, 82551);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81095, 84034);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81095, 84034);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82616, 83672) || true) && (arity != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10312, 82620, 82686) || (options & LookupOptions.AllMethodsOnArityZero) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 82616, 83672);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82736, 82779);

                            MethodSymbol
                            method = (MethodSymbol)symbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82805, 83649) || true) && (f_10312_82809_82821(method) != arity)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 82805, 83649);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 82888, 83580) || true) && (f_10312_82892_82904(method) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 82888, 83580);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83072, 83195);

                                    diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 83083, 83091) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 83094, 83187)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 83190, 83194))) ? f_10312_83094_83187(ErrorCode.ERR_HasNoTypeVars, method, f_10312_83152_83186(MessageID.IDS_SK_METHOD)) : null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 82888, 83580);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 82888, 83580);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83417, 83549);

                                    diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 83428, 83436) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 83439, 83541)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 83544, 83548))) ? f_10312_83439_83541(ErrorCode.ERR_BadArity, method, f_10312_83492_83526(MessageID.IDS_SK_METHOD), f_10312_83528_83540(method)) : null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 82888, 83580);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83610, 83622);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 82805, 83649);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 82616, 83672);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 83694, 83700);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81095, 84034);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 81095, 84034);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83750, 83991) || true) && (arity != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 83750, 83991);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83814, 83930);

                            diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 83825, 83833) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 83836, 83922)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 83925, 83929))) ? f_10312_83836_83922(ErrorCode.ERR_TypeArgsNotAllowed, symbol, f_10312_83899_83921(f_10312_83899_83910(symbol))) : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 83956, 83968);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 83750, 83991);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 84013, 84019);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 81095, 84034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84050, 84066);

                diagInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84080, 84093);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 80947, 84104);

                Microsoft.CodeAnalysis.SymbolKind
                f_10312_81103_81114(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 81103, 81114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_81531_81556(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 81531, 81556);
                    return return_v;
                }


                bool
                f_10312_81508_81568(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 81508, 81568);
                    return return_v;
                }


                int
                f_10312_81495_81569(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 81495, 81569);
                    return 0;
                }


                int
                f_10312_81600_81615(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 81600, 81615);
                    return return_v;
                }


                bool
                f_10312_81628_81659(Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    var return_v = options.IsAttributeTypeLookup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 81628, 81659);
                    return return_v;
                }


                int
                f_10312_81735_81750(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 81735, 81750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_82001_82033(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 82001, 82033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_81940_82034(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 81940, 82034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_82342_82374(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 82342, 82374);
                    return return_v;
                }


                int
                f_10312_82376_82391(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 82376, 82391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_82286_82392(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 82286, 82392);
                    return return_v;
                }


                int
                f_10312_82809_82821(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 82809, 82821);
                    return return_v;
                }


                int
                f_10312_82892_82904(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 82892, 82904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_83152_83186(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83152, 83186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_83094_83187(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83094, 83187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_83492_83526(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83492, 83526);
                    return return_v;
                }


                int
                f_10312_83528_83540(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 83528, 83540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_83439_83541(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83439, 83541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10312_83899_83910(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 83899, 83910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10312_83899_83921(Microsoft.CodeAnalysis.SymbolKind
                kind)
                {
                    var return_v = kind.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83899, 83921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10312_83836_83922(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 83836, 83922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 80947, 84104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 80947, 84104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void AddLookupSymbolsInfo(LookupSymbolsInfo result, LookupOptions options = LookupOptions.Default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 84200, 84780);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84341, 84353);
                    for (var
        scope = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84332, 84769) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84370, 84388)
        , scope = f_10312_84378_84388(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 84332, 84769))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 84332, 84769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84422, 84502);

                        f_10312_84422_84501(scope, result, options, originalBinder: this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 84522, 84754) || true) && ((options & LookupOptions.LabelsOnly) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 84526, 84603) && f_10312_84571_84603(scope)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 84522, 84754);
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 84729, 84735);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 84522, 84754);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 438);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 84200, 84780);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10312_84378_84388(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 84378, 84388);
                    return return_v;
                }


                int
                f_10312_84422_84501(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddLookupSymbolsInfoInSingleBinder(info, options, originalBinder: originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 84422, 84501);
                    return 0;
                }


                bool
                f_10312_84571_84603(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsLastBinderWithinMember();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 84571, 84603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 84200, 84780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 84200, 84780);
            }
        }

        protected virtual void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo info, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 84792, 84985);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 84792, 84985);
                // overridden in other binders
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 84792, 84985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 84792, 84985);
            }
        }

        internal void AddMemberLookupSymbolsInfo(LookupSymbolsInfo result, NamespaceOrTypeSymbol nsOrType, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 85083, 85593);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 85252, 85582) || true) && (f_10312_85256_85276(nsOrType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85252, 85582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 85310, 85408);

                    f_10312_85310_85407(result, nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85252, 85582);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85252, 85582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 85474, 85567);

                    f_10312_85474_85566(this, result, nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85252, 85582);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 85083, 85593);

                bool
                f_10312_85256_85276(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 85256, 85276);
                    return return_v;
                }


                int
                f_10312_85310_85407(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                ns, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    AddMemberLookupSymbolsInfoInNamespace(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)ns, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 85310, 85407);
                    return 0;
                }


                int
                f_10312_85474_85566(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddMemberLookupSymbolsInfoInType(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 85474, 85566);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 85083, 85593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 85083, 85593);
            }
        }

        private void AddMemberLookupSymbolsInfoInType(LookupSymbolsInfo result, TypeSymbol type, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 85605, 86760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 85764, 86749);

                switch (f_10312_85772_85785(type))
                {

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85764, 86749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 85869, 85976);

                        f_10312_85869_85975(this, result, type, options, originalBinder);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 85998, 86004);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85764, 86749);

                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85764, 86749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 86070, 86158);

                        f_10312_86070_86157(this, result, type, options, originalBinder, type);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 86180, 86186);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85764, 86749);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Enum:
                    case TypeKind.Delegate:
                    case TypeKind.Array:
                    case TypeKind.Dynamic:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85764, 86749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 86443, 86527);

                        f_10312_86443_86526(this, result, type, options, originalBinder, type);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 86549, 86555);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85764, 86749);

                    case TypeKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 85764, 86749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 86622, 86706);

                        f_10312_86622_86705(this, result, type, options, originalBinder);
                        DynAbs.Tracing.TraceSender.TraceBreak(10312, 86728, 86734);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 85764, 86749);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 85605, 86760);

                Microsoft.CodeAnalysis.TypeKind
                f_10312_85772_85785(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 85772, 85785);
                    return return_v;
                }


                int
                f_10312_85869_85975(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddMemberLookupSymbolsInfoInTypeParameter(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)type, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 85869, 85975);
                    return 0;
                }


                int
                f_10312_86070_86157(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    this_param.AddMemberLookupSymbolsInfoInInterface(result, type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 86070, 86157);
                    return 0;
                }


                int
                f_10312_86443_86526(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    this_param.AddMemberLookupSymbolsInfoInClass(result, type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 86443, 86526);
                    return 0;
                }


                int
                f_10312_86622_86705(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                scriptClass, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddMemberLookupSymbolsInfoInSubmissions(result, scriptClass, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 86622, 86705);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 85605, 86760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 85605, 86760);
            }
        }

        private void AddMemberLookupSymbolsInfoInSubmissions(LookupSymbolsInfo result, TypeSymbol scriptClass, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 86772, 88392);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87090, 87114);
                    // TODO: we need tests
                    // TODO: optimize lookup (there might be many interactions in the chain)
                    for (CSharpCompilation
        submission = f_10312_87103_87114()
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87067, 88381) || true) && (submission != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87136, 87178)
        , submission = f_10312_87149_87178(submission), DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 87067, 88381))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 87067, 88381);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87212, 87430) || true) && ((object)f_10312_87224_87246(submission) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 87212, 87430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87296, 87411);

                            f_10312_87296_87410(result, f_10312_87349_87371(submission), options, originalBinder, scriptClass);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 87212, 87430);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87450, 87503);

                        bool
                        isCurrentSubmission = submission == f_10312_87491_87502()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87623, 88366) || true) && ((options & LookupOptions.LabelsOnly) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10312, 87627, 87744) && !(isCurrentSubmission && (DynAbs.Tracing.TraceSender.Expression_True(10312, 87674, 87743) && f_10312_87697_87743(this.Flags, BinderFlags.InScriptUsing)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 87623, 88366);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87786, 87844);

                            var
                            submissionImports = f_10312_87810_87843(submission)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87866, 88055) || true) && (!isCurrentSubmission)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 87866, 88055);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 87940, 88032);

                                submissionImports = f_10312_87960_88031(submissionImports, f_10312_88019_88030());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 87866, 88055);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 88266, 88347);

                            f_10312_88266_88346(
                                                // NB: We diverge from InContainerBinder here and only look in aliases.
                                                // In submissions, regular usings are bubbled up to the outermost scope.
                                                submissionImports, result, options, originalBinder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 87623, 88366);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 1315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 1315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 86772, 88392);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_87103_87114()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 87103, 87114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation?
                f_10312_87149_87178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.PreviousSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 87149, 87178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10312_87224_87246(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 87224, 87246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_87349_87371(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 87349, 87371);
                    return return_v;
                }


                int
                f_10312_87296_87410(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 87296, 87410);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_87491_87502()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 87491, 87502);
                    return return_v;
                }


                bool
                f_10312_87697_87743(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 87697, 87743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10312_87810_87843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetSubmissionImports();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 87810, 87843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_88019_88030()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 88019, 88030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10312_87960_88031(Microsoft.CodeAnalysis.CSharp.Imports
                previousSubmissionImports, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                newSubmission)
                {
                    var return_v = Imports.ExpandPreviousSubmissionImports(previousSubmissionImports, newSubmission);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 87960, 88031);
                    return return_v;
                }


                int
                f_10312_88266_88346(Microsoft.CodeAnalysis.CSharp.Imports
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddLookupSymbolsInfoInAliases(result, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88266, 88346);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 86772, 88392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 86772, 88392);
            }
        }

        private static void AddMemberLookupSymbolsInfoInNamespace(LookupSymbolsInfo result, NamespaceSymbol ns, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 88404, 89051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 88578, 88748);

                var
                candidateMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 88601, 88626) || ((f_10312_88601_88618(result) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 88629, 88696)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 88699, 88747))) ? f_10312_88629_88696(ns, f_10312_88653_88670(result), options, originalBinder) : f_10312_88699_88747(ns, options, originalBinder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 88762, 89040);
                    foreach (var symbol in f_10312_88785_88801_I(candidateMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 88762, 89040);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 88835, 89025) || true) && (f_10312_88839_88907(originalBinder, symbol, options, result, null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 88835, 89025);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 88949, 89006);

                            f_10312_88949_89005(result, symbol, f_10312_88974_88985(symbol), f_10312_88987_89004(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 88835, 89025);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 88762, 89040);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 279);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 88404, 89051);

                string?
                f_10312_88601_88618(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    var return_v = this_param.FilterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 88601, 88618);
                    return return_v;
                }


                string
                f_10312_88653_88670(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    var return_v = this_param.FilterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 88653, 88670);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_88629_88696(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                nsOrType, string
                name, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88629, 88696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_88699_88747(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                nsOrType, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88699, 88747);
                    return return_v;
                }


                bool
                f_10312_88839_88907(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo(symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88839, 88907);
                    return return_v;
                }


                string
                f_10312_88974_88985(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 88974, 88985);
                    return return_v;
                }


                int
                f_10312_88987_89004(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88987, 89004);
                    return return_v;
                }


                int
                f_10312_88949_89005(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol(symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88949, 89005);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_88785_88801_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 88785, 88801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 88404, 89051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 88404, 89051);
            }
        }

        private static void AddMemberLookupSymbolsInfoWithoutInheritance(LookupSymbolsInfo result, TypeSymbol type, LookupOptions options, Binder originalBinder, TypeSymbol accessThroughType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10312, 89063, 89761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 89271, 89445);

                var
                candidateMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(10312, 89294, 89319) || ((f_10312_89294_89311(result) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10312, 89322, 89391)) || DynAbs.Tracing.TraceSender.Conditional_F3(10312, 89394, 89444))) ? f_10312_89322_89391(type, f_10312_89348_89365(result), options, originalBinder) : f_10312_89394_89444(type, options, originalBinder)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 89459, 89750);
                    foreach (var symbol in f_10312_89482_89498_I(candidateMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 89459, 89750);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 89532, 89735) || true) && (f_10312_89536_89617(originalBinder, symbol, options, result, accessThroughType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 89532, 89735);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 89659, 89716);

                            f_10312_89659_89715(result, symbol, f_10312_89684_89695(symbol), f_10312_89697_89714(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 89532, 89735);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 89459, 89750);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 292);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10312, 89063, 89761);

                string?
                f_10312_89294_89311(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    var return_v = this_param.FilterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 89294, 89311);
                    return return_v;
                }


                string
                f_10312_89348_89365(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param)
                {
                    var return_v = this_param.FilterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 89348, 89365);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_89322_89391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nsOrType, string
                name, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89322, 89391);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_89394_89444(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nsOrType, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    var return_v = GetCandidateMembers((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89394, 89444);
                    return return_v;
                }


                bool
                f_10312_89536_89617(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                info, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    var return_v = this_param.CanAddLookupSymbolInfo(symbol, options, info, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89536, 89617);
                    return return_v;
                }


                string
                f_10312_89684_89695(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 89684, 89695);
                    return return_v;
                }


                int
                f_10312_89697_89714(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89697, 89714);
                    return return_v;
                }


                int
                f_10312_89659_89715(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, string
                name, int
                arity)
                {
                    this_param.AddSymbol(symbol, name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89659, 89715);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10312_89482_89498_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 89482, 89498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 89063, 89761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 89063, 89761);
            }
        }

        private void AddWinRTMembersLookupSymbolsInfo(LookupSymbolsInfo result, NamedTypeSymbol type, LookupOptions options, Binder originalBinder, TypeSymbol accessThroughType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 89773, 90726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 89967, 90066);

                NamedTypeSymbol
                idictSymbol
                = default(NamedTypeSymbol),
                iroDictSymbol
                = default(NamedTypeSymbol),
                iListSymbol
                = default(NamedTypeSymbol),
                iCollectionSymbol
                = default(NamedTypeSymbol),
                inccSymbol
                = default(NamedTypeSymbol),
                inpcSymbol
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 90080, 90222);

                f_10312_90080_90221(this, out idictSymbol, out iroDictSymbol, out iListSymbol, out iCollectionSymbol, out inccSymbol, out inpcSymbol);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 90313, 90715);
                    foreach (var iface in f_10312_90335_90373_I(f_10312_90335_90373(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 90313, 90715);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 90407, 90700) || true) && (f_10312_90411_90535(iface, idictSymbol, iroDictSymbol, iListSymbol, iCollectionSymbol, inccSymbol, inpcSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 90407, 90700);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 90577, 90681);

                            f_10312_90577_90680(result, iface, options, originalBinder, accessThroughType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 90407, 90700);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 90313, 90715);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 403);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 89773, 90726);

                int
                f_10312_90080_90221(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                idictSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iroDictSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iListSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iCollectionSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inccSymbol, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inpcSymbol)
                {
                    this_param.GetWellKnownWinRTMemberInterfaces(out idictSymbol, out iroDictSymbol, out iListSymbol, out iCollectionSymbol, out inccSymbol, out inpcSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 90080, 90221);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_90335_90373(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 90335, 90373);
                    return return_v;
                }


                bool
                f_10312_90411_90535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iface, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                idictSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iroDictSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iListSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                iCollectionSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inccSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                inpcSymbol)
                {
                    var return_v = ShouldAddWinRTMembersForInterface(iface, idictSymbol, iroDictSymbol, iListSymbol, iCollectionSymbol, inccSymbol, inpcSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 90411, 90535);
                    return return_v;
                }


                int
                f_10312_90577_90680(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 90577, 90680);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_90335_90373_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 90335, 90373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 89773, 90726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 89773, 90726);
            }
        }

        private void AddMemberLookupSymbolsInfoInClass(LookupSymbolsInfo result, TypeSymbol type, LookupOptions options, Binder originalBinder, TypeSymbol accessThroughType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 90738, 92411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 90928, 90974);

                PooledHashSet<NamedTypeSymbol>
                visited = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 91148, 92368) || true) && ((object)type != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 91155, 91197) && !f_10312_91180_91197(type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 91148, 92368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 91231, 91334);

                        f_10312_91231_91333(result, type, options, originalBinder, accessThroughType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 91540, 91592);

                        NamedTypeSymbol
                        namedType = type as NamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 91610, 91831) || true) && ((object)namedType != null && (DynAbs.Tracing.TraceSender.Expression_True(10312, 91614, 91674) && f_10312_91643_91674(namedType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 91610, 91831);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 91716, 91812);

                            f_10312_91716_91811(this, result, namedType, options, originalBinder, accessThroughType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 91610, 91831);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92129, 92248) || true) && (f_10312_92133_92181(originalBinder))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 92129, 92248);
                            DynAbs.Tracing.TraceSender.TraceBreak(10312, 92223, 92229);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 92129, 92248);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92268, 92353);

                        type = f_10312_92275_92352(type, null, f_10312_92322_92338(this), ref visited);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 91148, 92368);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 91148, 92368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 91148, 92368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92384, 92400);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(visited, 10312, 92384, 92399)?.Free(), 10312, 92392, 92399);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 90738, 92411);

                bool
                f_10312_91180_91197(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 91180, 91197);
                    return return_v;
                }


                int
                f_10312_91231_91333(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 91231, 91333);
                    return 0;
                }


                bool
                f_10312_91643_91674(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ShouldAddWinRTMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 91643, 91674);
                    return return_v;
                }


                int
                f_10312_91716_91811(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    this_param.AddWinRTMembersLookupSymbolsInfo(result, type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 91716, 91811);
                    return 0;
                }


                bool
                f_10312_92133_92181(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.InCrefButNotParameterOrReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 92133, 92181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_92322_92338(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 92322, 92338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10312_92275_92352(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                visited)
                {
                    var return_v = type.GetNextBaseTypeNoUseSiteDiagnostics(basesBeingResolved, compilation, ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 92275, 92352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 90738, 92411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 90738, 92411);
            }
        }

        private void AddMemberLookupSymbolsInfoInInterface(LookupSymbolsInfo result, TypeSymbol type, LookupOptions options, Binder originalBinder, TypeSymbol accessThroughType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 92423, 93256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92617, 92720);

                f_10312_92617_92719(result, type, options, originalBinder, accessThroughType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92736, 93245) || true) && (f_10312_92740_92789_M(!originalBinder.InCrefButNotParameterOrReturnType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 92736, 93245);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92823, 93064);
                        foreach (var baseInterface in f_10312_92853_92891_I(f_10312_92853_92891(type)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 92823, 93064);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 92933, 93045);

                            f_10312_92933_93044(result, baseInterface, options, originalBinder, accessThroughType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 92823, 93064);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 242);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 242);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93084, 93230);

                    f_10312_93084_93229(
                                    this, result, f_10312_93131_93184(f_10312_93131_93142(), SpecialType.System_Object), options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 92736, 93245);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 92423, 93256);

                int
                f_10312_92617_92719(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 92617, 92719);
                    return 0;
                }


                bool
                f_10312_92740_92789_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 92740, 92789);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_92853_92891(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.AllInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 92853, 92891);
                    return return_v;
                }


                int
                f_10312_92933_93044(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 92933, 93044);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_92853_92891_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 92853, 92891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10312_93131_93142()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 93131, 93142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_93131_93184(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 93131, 93184);
                    return return_v;
                }


                int
                f_10312_93084_93229(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType)
                {
                    this_param.AddMemberLookupSymbolsInfoInClass(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 93084, 93229);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 92423, 93256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 92423, 93256);
            }
        }

        private void AddMemberLookupSymbolsInfoInTypeParameter(LookupSymbolsInfo result, TypeParameterSymbol type, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10312, 93268, 94123);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93445, 93553) || true) && (f_10312_93449_93471(type) == TypeParameterKind.Cref)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 93445, 93553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93531, 93538);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 93445, 93553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93569, 93650);

                NamedTypeSymbol
                effectiveBaseClass = f_10312_93606_93649(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93664, 93776);

                f_10312_93664_93775(this, result, effectiveBaseClass, options, originalBinder, effectiveBaseClass);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93792, 94112);
                    foreach (var baseInterface in f_10312_93822_93869_I(f_10312_93822_93869(type)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10312, 93792, 94112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10312, 93979, 94097);

                        f_10312_93979_94096(result, baseInterface, options, originalBinder, accessThroughType: type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10312, 93792, 94112);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10312, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10312, 1, 321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10312, 93268, 94123);

                Microsoft.CodeAnalysis.TypeParameterKind
                f_10312_93449_93471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameterKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 93449, 93471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10312_93606_93649(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.EffectiveBaseClassNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 93606, 93649);
                    return return_v;
                }


                int
                f_10312_93664_93775(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessThroughType)
                {
                    this_param.AddMemberLookupSymbolsInfoInClass(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 93664, 93775);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_93822_93869(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.AllEffectiveInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10312, 93822, 93869);
                    return return_v;
                }


                int
                f_10312_93979_94096(Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                accessThroughType)
                {
                    AddMemberLookupSymbolsInfoWithoutInheritance(result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, options, originalBinder, accessThroughType: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)accessThroughType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 93979, 94096);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10312_93822_93869_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10312, 93822, 93869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10312, 93268, 94123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10312, 93268, 94123);
            }
        }
    }
}
