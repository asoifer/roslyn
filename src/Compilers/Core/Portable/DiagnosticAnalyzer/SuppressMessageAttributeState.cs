// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class SuppressMessageAttributeState
    {
        private static readonly SmallDictionary<string, TargetScope> s_suppressMessageScopeTypes;

        private static bool TryGetTargetScope(SuppressMessageInfo info, out TargetScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 1281, 1362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1284, 1362);
                return f_270_1284_1362(s_suppressMessageScopeTypes, info.Scope ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(270, 1324, 1350) ?? string.Empty), out scope); DynAbs.Tracing.TraceSender.TraceExitMethod(270, 1281, 1362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 1281, 1362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 1281, 1362);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_270_1284_1362(Microsoft.CodeAnalysis.SmallDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope>
            this_param, string
            key, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
            value)
            {
                var return_v = this_param.TryGetValue(key, out value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 1284, 1362);
                return return_v;
            }

        }

        private readonly Compilation _compilation;

        private GlobalSuppressions _lazyGlobalSuppressions;

        private readonly ConcurrentDictionary<ISymbol, ImmutableDictionary<string, SuppressMessageInfo>> _localSuppressionsBySymbol;

        private ISymbol _lazySuppressMessageAttribute;
        private class GlobalSuppressions
        {
            private readonly Dictionary<string, SuppressMessageInfo> _compilationWideSuppressions;

            private readonly Dictionary<ISymbol, Dictionary<string, SuppressMessageInfo>> _globalSymbolSuppressions;

            public void AddCompilationWideSuppression(SuppressMessageInfo info)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 2074, 2237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2174, 2222);

                    f_270_2174_2221(info, _compilationWideSuppressions);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(270, 2074, 2237);

                    int
                    f_270_2174_2221(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                    info, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    builder)
                    {
                        AddOrUpdate(info, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>)builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 2174, 2221);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 2074, 2237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 2074, 2237);
                }
            }

            public void AddGlobalSymbolSuppression(ISymbol symbol, SuppressMessageInfo info)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 2253, 2851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2366, 2419);

                    Dictionary<string, SuppressMessageInfo>
                    suppressions
                    = default(Dictionary<string, SuppressMessageInfo>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2437, 2836) || true) && (f_270_2441_2504(_globalSymbolSuppressions, symbol, out suppressions))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 2437, 2836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2546, 2578);

                        f_270_2546_2577(info, suppressions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 2437, 2836);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 2437, 2836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2660, 2743);

                        suppressions = new Dictionary<string, SuppressMessageInfo>() { { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => info.Id, 270, 2675, 2742), info } };
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2765, 2817);

                        f_270_2765_2816(_globalSymbolSuppressions, symbol, suppressions);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 2437, 2836);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(270, 2253, 2851);

                    bool
                    f_270_2441_2504(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 2441, 2504);
                        return return_v;
                    }


                    int
                    f_270_2546_2577(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                    info, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    builder)
                    {
                        AddOrUpdate(info, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>)builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 2546, 2577);
                        return 0;
                    }


                    int
                    f_270_2765_2816(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 2765, 2816);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 2253, 2851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 2253, 2851);
                }
            }

            public bool HasCompilationWideSuppression(string id, out SuppressMessageInfo info)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 2867, 3059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 2982, 3044);

                    return f_270_2989_3043(_compilationWideSuppressions, id, out info);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(270, 2867, 3059);

                    bool
                    f_270_2989_3043(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    this_param, string
                    key, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 2989, 3043);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 2867, 3059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 2867, 3059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public bool HasGlobalSymbolSuppression(ISymbol symbol, string id, bool isImmediatelyContainingSymbol, out SuppressMessageInfo info)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 3075, 4571);
                    Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope targetScope = default(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3239, 3268);

                    f_270_3239_3267(symbol != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3286, 3339);

                    Dictionary<string, SuppressMessageInfo>
                    suppressions
                    = default(Dictionary<string, SuppressMessageInfo>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3357, 4469) || true) && (f_270_3361_3424(_globalSymbolSuppressions, symbol, out suppressions) && (DynAbs.Tracing.TraceSender.Expression_True(270, 3361, 3487) && f_270_3449_3487(suppressions, id, out info)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 3357, 4469);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3529, 3653) || true) && (f_270_3533_3544(symbol) != SymbolKind.Namespace)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 3529, 3653);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3618, 3630);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 3529, 3653);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3677, 4450) || true) && (f_270_3681_3733(info, out targetScope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 3677, 4450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 3783, 4427);

                            switch (targetScope)
                            {

                                case TargetScope.Namespace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 3783, 4427);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4244, 4281);

                                    return isImmediatelyContainingSymbol;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 3783, 4427);

                                case TargetScope.NamespaceAndDescendants:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 3783, 4427);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4388, 4400);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 3783, 4427);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 3677, 4450);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 3357, 4469);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4489, 4525);

                    info = default(SuppressMessageInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4543, 4556);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(270, 3075, 4571);

                    int
                    f_270_3239_3267(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 3239, 3267);
                        return 0;
                    }


                    bool
                    f_270_3361_3424(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    key, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 3361, 3424);
                        return return_v;
                    }


                    bool
                    f_270_3449_3487(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                    this_param, string
                    key, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 3449, 3487);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_270_3533_3544(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 3533, 3544);
                        return return_v;
                    }


                    bool
                    f_270_3681_3733(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                    info, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                    scope)
                    {
                        var return_v = TryGetTargetScope(info, out scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 3681, 3733);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 3075, 4571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 3075, 4571);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GlobalSuppressions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(270, 1680, 4582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1794, 1870);
                this._compilationWideSuppressions = f_270_1825_1870(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1963, 2057);
                this._globalSymbolSuppressions = f_270_1991_2057(); DynAbs.Tracing.TraceSender.TraceExitConstructor(270, 1680, 4582);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 1680, 4582);
            }


            static GlobalSuppressions()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(270, 1680, 4582);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(270, 1680, 4582);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 1680, 4582);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(270, 1680, 4582);

            System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
            f_270_1825_1870()
            {
                var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 1825, 1870);
                return return_v;
            }


            System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
            f_270_1991_2057()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 1991, 2057);
                return return_v;
            }

        }

        internal SuppressMessageAttributeState(Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(270, 4594, 4849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1404, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1454, 1477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1585, 1611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 1638, 1667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4682, 4709);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4723, 4838);

                _localSuppressionsBySymbol = f_270_4752_4837();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(270, 4594, 4849);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 4594, 4849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 4594, 4849);
            }
        }

        public Diagnostic ApplySourceSuppressions(Diagnostic diagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 4861, 5420);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 4950, 5109) || true) && (f_270_4954_4977(diagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 4950, 5109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5076, 5094);

                    return diagnostic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 4950, 5109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5125, 5150);

                SuppressMessageInfo
                info
                = default(SuppressMessageInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5164, 5375) || true) && (f_270_5168_5212(this, diagnostic, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 5164, 5375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5313, 5360);

                    diagnostic = f_270_5326_5359(diagnostic, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 5164, 5375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5391, 5409);

                return diagnostic;
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 4861, 5420);

                bool
                f_270_4954_4977(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 4954, 4977);
                    return return_v;
                }


                bool
                f_270_5168_5212(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.IsDiagnosticSuppressed(diagnostic, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 5168, 5212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_270_5326_5359(Microsoft.CodeAnalysis.Diagnostic
                this_param, bool
                isSuppressed)
                {
                    var return_v = this_param.WithIsSuppressed(isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 5326, 5359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 4861, 5420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 4861, 5420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsDiagnosticSuppressed(Diagnostic diagnostic, out AttributeData suppressingAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 5432, 5840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5554, 5579);

                SuppressMessageInfo
                info
                = default(SuppressMessageInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5593, 5758) || true) && (f_270_5597_5641(this, diagnostic, out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 5593, 5758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5675, 5713);

                    suppressingAttribute = info.Attribute;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5731, 5743);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 5593, 5758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5774, 5802);

                suppressingAttribute = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5816, 5829);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 5432, 5840);

                bool
                f_270_5597_5641(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diagnostic, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.IsDiagnosticSuppressed(diagnostic, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 5597, 5641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 5432, 5840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 5432, 5840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDiagnosticSuppressed(Diagnostic diagnostic, out SuppressMessageInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 5852, 8622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5965, 5980);

                info = default;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 5996, 6211) || true) && (f_270_6000_6064(f_270_6000_6021(diagnostic), WellKnownDiagnosticTags.Compiler))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 5996, 6211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6183, 6196);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 5996, 6211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6227, 6250);

                var
                id = f_270_6236_6249(diagnostic)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6264, 6299);

                var
                location = f_270_6279_6298(diagnostic)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6315, 6485) || true) && (f_270_6319_6424(this, id, symbolOpt: null, isImmediatelyContainingSymbol: false, info: out info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 6315, 6485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6458, 6470);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 6315, 6485);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6602, 7959) || true) && (f_270_6606_6625(location))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 6602, 7959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6659, 6722);

                    var
                    model = f_270_6671_6721(_compilation, f_270_6701_6720(location))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6740, 6782);

                    bool
                    inImmediatelyContainingSymbol = true
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6811, 6907);

                        for (var
        node = f_270_6818_6907(f_270_6818_6847(f_270_6818_6837(location)), f_270_6857_6876(location), getInnermostNodeForTie: true)
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6802, 7944) || true) && (node != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 6965, 6983)
        , node = f_270_6972_6983(node), DynAbs.Tracing.TraceSender.TraceExitCondition(270, 6802, 7944))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 6802, 7944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7025, 7085);

                            var
                            declaredSymbols = f_270_7047_7084(model, node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7107, 7145);

                            f_270_7107_7144(declaredSymbols != null);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7169, 7762);
                                foreach (var symbol in f_270_7192_7207_I(declaredSymbols))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 7169, 7762);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7257, 7739) || true) && (f_270_7261_7272(symbol) == SymbolKind.Namespace)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 7257, 7739);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7354, 7442);

                                        return f_270_7361_7441(symbol, inImmediatelyContainingSymbol);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 7257, 7739);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 7257, 7739);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7500, 7739) || true) && (f_270_7504_7555(this, id, symbol, out info) || (DynAbs.Tracing.TraceSender.Expression_False(270, 7504, 7642) || f_270_7559_7642(this, id, symbol, inImmediatelyContainingSymbol, out info)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 7500, 7739);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7700, 7712);

                                            return true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 7500, 7739);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 7257, 7739);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 7169, 7762);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 594);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 594);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7786, 7925) || true) && (f_270_7790_7814_M(!declaredSymbols.IsEmpty))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 7786, 7925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7864, 7902);

                                inImmediatelyContainingSymbol = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(270, 7786, 7925);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 1143);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 1143);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 6602, 7959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 7975, 7988);

                return false;

                bool hasNamespaceSuppression(INamespaceSymbol namespaceSymbol, bool inImmediatelyContainingSymbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 8004, 8611);
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 8135, 8563);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8178, 8356) || true) && (f_270_8182_8271(this, id, namespaceSymbol, inImmediatelyContainingSymbol, out _))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 8178, 8356);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8321, 8333);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 8178, 8356);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8380, 8434);

                                    namespaceSymbol = f_270_8398_8433(namespaceSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8456, 8494);

                                    inImmediatelyContainingSymbol = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 8135, 8563);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8135, 8563) || true) && (namespaceSymbol != null)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 8135, 8563);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(270, 8135, 8563);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8583, 8596);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(270, 8004, 8611);

                        bool
                        f_270_8182_8271(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                        this_param, string
                        id, Microsoft.CodeAnalysis.INamespaceSymbol
                        symbolOpt, bool
                        isImmediatelyContainingSymbol, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                        info)
                        {
                            var return_v = this_param.IsDiagnosticGloballySuppressed(id, (Microsoft.CodeAnalysis.ISymbol)symbolOpt, isImmediatelyContainingSymbol, out info);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 8182, 8271);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.INamespaceSymbol
                        f_270_8398_8433(Microsoft.CodeAnalysis.INamespaceSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 8398, 8433);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 8004, 8611);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 8004, 8611);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 5852, 8622);

                System.Collections.Generic.IReadOnlyList<string>
                f_270_6000_6021(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.CustomTags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6000, 6021);
                    return return_v;
                }


                bool
                f_270_6000_6064(System.Collections.Generic.IReadOnlyList<string>
                list, string
                item)
                {
                    var return_v = list.Contains<string>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 6000, 6064);
                    return return_v;
                }


                string
                f_270_6236_6249(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6236, 6249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_270_6279_6298(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6279, 6298);
                    return return_v;
                }


                bool
                f_270_6319_6424(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, string
                id, Microsoft.CodeAnalysis.ISymbol
                symbolOpt, bool
                isImmediatelyContainingSymbol, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.IsDiagnosticGloballySuppressed(id, symbolOpt: symbolOpt, isImmediatelyContainingSymbol: isImmediatelyContainingSymbol, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 6319, 6424);
                    return return_v;
                }


                bool
                f_270_6606_6625(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6606, 6625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_270_6701_6720(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6701, 6720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_270_6671_6721(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 6671, 6721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_270_6818_6837(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6818, 6837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_270_6818_6847(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 6818, 6847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_270_6857_6876(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6857, 6876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_270_6818_6907(Microsoft.CodeAnalysis.SyntaxNode
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, bool
                getInnermostNodeForTie)
                {
                    var return_v = this_param.FindNode(span, getInnermostNodeForTie: getInnermostNodeForTie);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 6818, 6907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_270_6972_6983(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 6972, 6983);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_270_7047_7084(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = this_param.GetDeclaredSymbolsForNode(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7047, 7084);
                    return return_v;
                }


                int
                f_270_7107_7144(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7107, 7144);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_270_7261_7272(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 7261, 7272);
                    return return_v;
                }


                bool
                f_270_7361_7441(Microsoft.CodeAnalysis.ISymbol
                namespaceSymbol, bool
                inImmediatelyContainingSymbol)
                {
                    var return_v = hasNamespaceSuppression((Microsoft.CodeAnalysis.INamespaceSymbol)namespaceSymbol, inImmediatelyContainingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7361, 7441);
                    return return_v;
                }


                bool
                f_270_7504_7555(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, string
                id, Microsoft.CodeAnalysis.ISymbol
                symbol, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.IsDiagnosticLocallySuppressed(id, symbol, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7504, 7555);
                    return return_v;
                }


                bool
                f_270_7559_7642(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, string
                id, Microsoft.CodeAnalysis.ISymbol
                symbolOpt, bool
                isImmediatelyContainingSymbol, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.IsDiagnosticGloballySuppressed(id, symbolOpt, isImmediatelyContainingSymbol, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7559, 7642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_270_7192_7207_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 7192, 7207);
                    return return_v;
                }


                bool
                f_270_7790_7814_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 7790, 7814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 5852, 8622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 5852, 8622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDiagnosticGloballySuppressed(string id, ISymbol symbolOpt, bool isImmediatelyContainingSymbol, out SuppressMessageInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 8634, 9091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8798, 8843);

                f_270_8798_8842(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 8857, 9080);

                return f_270_8864_8931(_lazyGlobalSuppressions, id, out info) || (DynAbs.Tracing.TraceSender.Expression_False(270, 8864, 9079) || symbolOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(270, 8952, 9079) && f_270_8973_9079(_lazyGlobalSuppressions, symbolOpt, id, isImmediatelyContainingSymbol, out info)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 8634, 9091);

                int
                f_270_8798_8842(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param)
                {
                    this_param.DecodeGlobalSuppressMessageAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 8798, 8842);
                    return 0;
                }


                bool
                f_270_8864_8931(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                this_param, string
                id, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.HasCompilationWideSuppression(id, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 8864, 8931);
                    return return_v;
                }


                bool
                f_270_8973_9079(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                id, bool
                isImmediatelyContainingSymbol, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = this_param.HasGlobalSymbolSuppression(symbol, id, isImmediatelyContainingSymbol, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 8973, 9079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 8634, 9091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 8634, 9091);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsDiagnosticLocallySuppressed(string id, ISymbol symbol, out SuppressMessageInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 9103, 9404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9227, 9333);

                var
                suppressions = f_270_9246_9332(_localSuppressionsBySymbol, symbol, this.DecodeLocalSuppressMessageAttributes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9347, 9393);

                return f_270_9354_9392(suppressions, id, out info);
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 9103, 9404);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                f_270_9246_9332(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
                this_param, Microsoft.CodeAnalysis.ISymbol
                key, System.Func<Microsoft.CodeAnalysis.ISymbol, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 9246, 9332);
                    return return_v;
                }


                bool
                f_270_9354_9392(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                this_param, string
                key, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 9354, 9392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 9103, 9404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 9103, 9404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ISymbol SuppressMessageAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 9481, 9818);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9517, 9746) || true) && (_lazySuppressMessageAttribute == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 9517, 9746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9600, 9727);

                        _lazySuppressMessageAttribute = f_270_9632_9726(_compilation, "System.Diagnostics.CodeAnalysis.SuppressMessageAttribute");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 9517, 9746);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9766, 9803);

                    return _lazySuppressMessageAttribute;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(270, 9481, 9818);

                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_270_9632_9726(Microsoft.CodeAnalysis.Compilation
                    this_param, string
                    fullyQualifiedMetadataName)
                    {
                        var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 9632, 9726);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 9416, 9829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 9416, 9829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void DecodeGlobalSuppressMessageAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 9841, 10468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9918, 10457) || true) && (_lazyGlobalSuppressions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 9918, 10457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 9987, 10031);

                    var
                    suppressions = f_270_10006_10030()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10049, 10138);

                    f_270_10049_10137(this, _compilation, f_270_10101_10122(_compilation), suppressions);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10158, 10345);
                        foreach (var module in f_270_10181_10210_I(f_270_10181_10210(f_270_10181_10202(_compilation))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 10158, 10345);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10252, 10326);

                            f_270_10252_10325(this, _compilation, module, suppressions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 10158, 10345);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 188);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 188);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10365, 10442);

                    f_270_10365_10441(ref _lazyGlobalSuppressions, suppressions, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 9918, 10457);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 9841, 10468);

                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                f_270_10006_10030()
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10006, 10030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_270_10101_10122(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 10101, 10122);
                    return return_v;
                }


                int
                f_270_10049_10137(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IAssemblySymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                globalSuppressions)
                {
                    this_param.DecodeGlobalSuppressMessageAttributes(compilation, (Microsoft.CodeAnalysis.ISymbol)symbol, globalSuppressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10049, 10137);
                    return 0;
                }


                Microsoft.CodeAnalysis.IAssemblySymbol
                f_270_10181_10202(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 10181, 10202);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                f_270_10181_10210(Microsoft.CodeAnalysis.IAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 10181, 10210);
                    return return_v;
                }


                int
                f_270_10252_10325(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.IModuleSymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                globalSuppressions)
                {
                    this_param.DecodeGlobalSuppressMessageAttributes(compilation, (Microsoft.CodeAnalysis.ISymbol)symbol, globalSuppressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10252, 10325);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                f_270_10181_10210_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.IModuleSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10181, 10210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions?
                f_270_10365_10441(ref Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions?
                location1, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                value, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10365, 10441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 9841, 10468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 9841, 10468);
            }
        }

        private ImmutableDictionary<string, SuppressMessageInfo> DecodeLocalSuppressMessageAttributes(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 10480, 10805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10614, 10716);

                var
                attributes = f_270_10631_10653(symbol).Where(a => a.AttributeClass == this.SuppressMessageAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10730, 10794);

                return f_270_10737_10793(symbol, attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 10480, 10805);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                f_270_10631_10653(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10631, 10653);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                f_270_10737_10793(Microsoft.CodeAnalysis.ISymbol
                symbol, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                attributes)
                {
                    var return_v = DecodeLocalSuppressMessageAttributes(symbol, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 10737, 10793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 10480, 10805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 10480, 10805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableDictionary<string, SuppressMessageInfo> DecodeLocalSuppressMessageAttributes(ISymbol symbol, IEnumerable<AttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(270, 10817, 11454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 10997, 11076);

                var
                builder = f_270_11011_11075()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11090, 11398);
                    foreach (var attribute in f_270_11116_11126_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 11090, 11398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11160, 11185);

                        SuppressMessageInfo
                        info
                        = default(SuppressMessageInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11203, 11336) || true) && (!f_270_11208_11266(attribute, out info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 11203, 11336);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11308, 11317);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 11203, 11336);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11356, 11383);

                        f_270_11356_11382(info, builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 11090, 11398);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11414, 11443);

                return f_270_11421_11442(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(270, 10817, 11454);

                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>.Builder
                f_270_11011_11075()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<string, SuppressMessageInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11011, 11075);
                    return return_v;
                }


                bool
                f_270_11208_11266(Microsoft.CodeAnalysis.AttributeData
                attribute, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = TryDecodeSuppressMessageAttributeData(attribute, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11208, 11266);
                    return return_v;
                }


                int
                f_270_11356_11382(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>.Builder
                builder)
                {
                    AddOrUpdate(info, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>)builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11356, 11382);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                f_270_11116_11126_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11116, 11126);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                f_270_11421_11442(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11421, 11442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 10817, 11454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 10817, 11454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddOrUpdate(SuppressMessageInfo info, IDictionary<string, SuppressMessageInfo> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(270, 11466, 11978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11798, 11830);

                SuppressMessageInfo
                currentInfo
                = default(SuppressMessageInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11844, 11967) || true) && (!f_270_11849_11894(builder, info.Id, out currentInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 11844, 11967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 11928, 11952);

                    builder[info.Id] = info;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 11844, 11967);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(270, 11466, 11978);

                bool
                f_270_11849_11894(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>
                this_param, string
                key, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 11849, 11894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 11466, 11978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 11466, 11978);
            }
        }

        private void DecodeGlobalSuppressMessageAttributes(Compilation compilation, ISymbol symbol, GlobalSuppressions globalSuppressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(270, 11990, 12446);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12145, 12212);

                f_270_12145_12211(symbol is IAssemblySymbol || (DynAbs.Tracing.TraceSender.Expression_False(270, 12158, 12210) || symbol is IModuleSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12228, 12330);

                var
                attributes = f_270_12245_12267(symbol).Where(a => a.AttributeClass == this.SuppressMessageAttribute)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12344, 12435);

                f_270_12344_12434(compilation, symbol, globalSuppressions, attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(270, 11990, 12446);

                int
                f_270_12145_12211(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12145, 12211);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AttributeData>
                f_270_12245_12267(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12245, 12267);
                    return return_v;
                }


                int
                f_270_12344_12434(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                globalSuppressions, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                attributes)
                {
                    DecodeGlobalSuppressMessageAttributes(compilation, symbol, globalSuppressions, attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12344, 12434);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 11990, 12446);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 11990, 12446);
            }
        }

        private static void DecodeGlobalSuppressMessageAttributes(Compilation compilation, ISymbol symbol, GlobalSuppressions globalSuppressions, IEnumerable<AttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(270, 12458, 13893);
                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope scope = default(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12659, 13882);
                    foreach (var instance in f_270_12684_12694_I(attributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 12659, 13882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12728, 12753);

                        SuppressMessageInfo
                        info
                        = default(SuppressMessageInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12771, 12903) || true) && (!f_270_12776_12833(instance, out info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 12771, 12903);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12875, 12884);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 12771, 12903);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 12923, 13503) || true) && (f_270_12927_12973(info, out scope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 12923, 13503);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13015, 13345) || true) && ((scope == TargetScope.Module || (DynAbs.Tracing.TraceSender.Expression_False(270, 13020, 13076) || scope == TargetScope.None)) && (DynAbs.Tracing.TraceSender.Expression_True(270, 13019, 13100) && info.Target == null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 13015, 13345);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13232, 13287);

                                f_270_13232_13286(                        // This suppression is applies to the entire compilation
                                                        globalSuppressions, info);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13313, 13322);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(270, 13015, 13345);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 12923, 13503);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 12923, 13503);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13475, 13484);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 12923, 13503);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13557, 13650) || true) && (info.Target == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 13557, 13650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13622, 13631);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(270, 13557, 13650);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13670, 13867);
                            foreach (var target in f_270_13693_13746_I(f_270_13693_13746(compilation, info.Target, scope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 13670, 13867);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 13788, 13848);

                                f_270_13788_13847(globalSuppressions, target, info);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(270, 13670, 13867);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 198);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 198);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 12659, 13882);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(270, 1, 1224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(270, 1, 1224);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(270, 12458, 13893);

                bool
                f_270_12776_12833(Microsoft.CodeAnalysis.AttributeData
                attribute, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    var return_v = TryDecodeSuppressMessageAttributeData(attribute, out info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12776, 12833);
                    return return_v;
                }


                bool
                f_270_12927_12973(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info, out Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                scope)
                {
                    var return_v = TryGetTargetScope(info, out scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12927, 12973);
                    return return_v;
                }


                int
                f_270_13232_13286(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                this_param, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    this_param.AddCompilationWideSuppression(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 13232, 13286);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_270_13693_13746(Microsoft.CodeAnalysis.Compilation
                compilation, string
                target, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                scope)
                {
                    var return_v = ResolveTargetSymbols(compilation, target, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 13693, 13746);
                    return return_v;
                }


                int
                f_270_13788_13847(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.GlobalSuppressions
                this_param, Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo
                info)
                {
                    this_param.AddGlobalSymbolSuppression(symbol, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 13788, 13847);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_270_13693_13746_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 13693, 13746);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                f_270_12684_12694_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.AttributeData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 12684, 12694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 12458, 13893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 12458, 13893);
            }
        }

        internal static ImmutableArray<ISymbol> ResolveTargetSymbols(Compilation compilation, string target, TargetScope scope)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(270, 13905, 14570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14049, 14559);

                switch (scope)
                {

                    case TargetScope.Namespace:
                    case TargetScope.Type:
                    case TargetScope.Member:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 14049, 14559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14227, 14302);

                        return f_270_14234_14286(compilation, scope, target).Resolve(out _);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 14049, 14559);

                    case TargetScope.NamespaceAndDescendants:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 14049, 14559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14385, 14457);

                        return f_270_14392_14456(compilation, target, TargetScope.Namespace);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 14049, 14559);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 14049, 14559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14507, 14544);

                        return ImmutableArray<ISymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(270, 14049, 14559);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(270, 13905, 14570);

                Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver
                f_270_14234_14286(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                scope, string
                fullyQualifiedName)
                {
                    var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver(compilation, scope, fullyQualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 14234, 14286);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_270_14392_14456(Microsoft.CodeAnalysis.Compilation
                compilation, string
                target, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                scope)
                {
                    var return_v = ResolveTargetSymbols(compilation, target, scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 14392, 14456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 13905, 14570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 13905, 14570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryDecodeSuppressMessageAttributeData(AttributeData attribute, out SuppressMessageInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(270, 14582, 16171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14719, 14755);

                info = default(SuppressMessageInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 14955, 15068) || true) && (attribute.CommonConstructorArguments.Length < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 14955, 15068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15040, 15053);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 14955, 15068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15260, 15334);

                info.Id = f_270_15270_15306(attribute)[1].ValueInternal as string;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15348, 15429) || true) && (info.Id == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 15348, 15429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15401, 15414);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 15348, 15429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15606, 15648);

                var
                separatorIndex = f_270_15627_15647(info.Id, ':')
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15662, 15776) || true) && (separatorIndex != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(270, 15662, 15776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15720, 15761);

                    info.Id = f_270_15730_15760(info.Id, separatorIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(270, 15662, 15776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15792, 15879);

                info.Scope = f_270_15805_15878(attribute, "Scope", SpecialType.System_String);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15893, 15982);

                info.Target = f_270_15907_15981(attribute, "Target", SpecialType.System_String);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 15996, 16091);

                info.MessageId = f_270_16013_16090(attribute, "MessageId", SpecialType.System_String);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 16105, 16132);

                info.Attribute = attribute;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 16148, 16160);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(270, 14582, 16171);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_270_15270_15306(Microsoft.CodeAnalysis.AttributeData
                this_param)
                {
                    var return_v = this_param.CommonConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 15270, 15306);
                    return return_v;
                }


                int
                f_270_15627_15647(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 15627, 15647);
                    return return_v;
                }


                string
                f_270_15730_15760(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Remove(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 15730, 15760);
                    return return_v;
                }


                string?
                f_270_15805_15878(Microsoft.CodeAnalysis.AttributeData
                this_param, string
                name, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.DecodeNamedArgument<string>(name, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 15805, 15878);
                    return return_v;
                }


                string?
                f_270_15907_15981(Microsoft.CodeAnalysis.AttributeData
                this_param, string
                name, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.DecodeNamedArgument<string>(name, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 15907, 15981);
                    return return_v;
                }


                string?
                f_270_16013_16090(Microsoft.CodeAnalysis.AttributeData
                this_param, string
                name, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.DecodeNamedArgument<string>(name, specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 16013, 16090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(270, 14582, 16171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 14582, 16171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SuppressMessageAttributeState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(270, 506, 16178);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(270, 636, 1168);
            s_suppressMessageScopeTypes = new SmallDictionary<string, TargetScope>(f_270_707_739())
            {
                { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => string.Empty,270,666,1168),TargetScope.None },                { "module", TargetScope.Module },                { "namespace", TargetScope.Namespace },                { "resource", TargetScope.Resource },                { "type", TargetScope.Type },                { "member", TargetScope.Member },                { "namespaceanddescendants", TargetScope.NamespaceAndDescendants }
            }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 617, 642);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(270, 506, 16178);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(270, 506, 16178);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(270, 506, 16178);

        static System.StringComparer
        f_270_707_739()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(270, 707, 739);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>
        f_270_4752_4837()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.ISymbol, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageInfo>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(270, 4752, 4837);
            return return_v;
        }

    }
}
