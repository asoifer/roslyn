// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public class RuleSet
    {
        private readonly string _filePath;

        public string FilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 757, 782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 763, 780);

                    return _filePath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(537, 757, 782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 710, 793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 710, 793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ReportDiagnostic _generalDiagnosticOption;

        public ReportDiagnostic GeneralDiagnosticOption
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 1057, 1097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 1063, 1095);

                    return _generalDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(537, 1057, 1097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 985, 1108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 985, 1108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ImmutableDictionary<string, ReportDiagnostic> _specificDiagnosticOptions;

        public ImmutableDictionary<string, ReportDiagnostic> SpecificDiagnosticOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 1433, 1475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 1439, 1473);

                    return _specificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(537, 1433, 1475);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 1330, 1486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 1330, 1486);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly ImmutableArray<RuleSetInclude> _includes;

        public ImmutableArray<RuleSetInclude> Includes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 1740, 1765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 1746, 1763);

                    return _includes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(537, 1740, 1765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 1669, 1776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 1669, 1776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public RuleSet(string filePath, ReportDiagnostic generalOption, ImmutableDictionary<string, ReportDiagnostic> specificOptions, ImmutableArray<RuleSetInclude> includes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(537, 1866, 2333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 595, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 839, 863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 1183, 1209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2058, 2079);

                _filePath = filePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2093, 2134);

                _generalDiagnosticOption = generalOption;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2148, 2273);

                _specificDiagnosticOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(537, 2177, 2200) || ((specificOptions == null && DynAbs.Tracing.TraceSender.Conditional_F2(537, 2203, 2254)) || DynAbs.Tracing.TraceSender.Conditional_F3(537, 2257, 2272))) ? ImmutableDictionary<string, ReportDiagnostic>.Empty : specificOptions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2287, 2322);

                _includes = includes.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(537, 1866, 2333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 1866, 2333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 1866, 2333);
            }
        }

        public RuleSet? WithEffectiveAction(ReportDiagnostic action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 2468, 3865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2553, 2716) || true) && (f_537_2557_2575_M(!_includes.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 2553, 2716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2609, 2701);

                    throw f_537_2615_2700("Effective action cannot be applied to rulesets with Includes");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 2553, 2716);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2732, 3854);

                switch (action)
                {

                    case ReportDiagnostic.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 2732, 3854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2832, 2844);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 2732, 3854);

                    case ReportDiagnostic.Suppress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 2732, 3854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 2915, 2927);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 2732, 3854);

                    case ReportDiagnostic.Error:
                    case ReportDiagnostic.Warn:
                    case ReportDiagnostic.Info:
                    case ReportDiagnostic.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 2732, 3854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3132, 3241);

                        var
                        generalOption = (DynAbs.Tracing.TraceSender.Conditional_F1(537, 3152, 3204) || ((_generalDiagnosticOption == ReportDiagnostic.Default && DynAbs.Tracing.TraceSender.Conditional_F2(537, 3207, 3231)) || DynAbs.Tracing.TraceSender.Conditional_F3(537, 3234, 3240))) ? ReportDiagnostic.Default : action
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3263, 3324);

                        var
                        specificOptions = f_537_3285_3323(_specificDiagnosticOptions)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3346, 3671);
                            foreach (var item in f_537_3367_3393_I(_specificDiagnosticOptions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 3346, 3671);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3443, 3648) || true) && (item.Value != ReportDiagnostic.Suppress && (DynAbs.Tracing.TraceSender.Expression_True(537, 3447, 3528) && item.Value != ReportDiagnostic.Default))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 3443, 3648);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3586, 3621);

                                    specificOptions[item.Key] = action;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 3443, 3648);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(537, 3346, 3671);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 326);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 326);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3693, 3779);

                        return f_537_3700_3778(f_537_3712_3720(), generalOption, f_537_3737_3766(specificOptions), _includes);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 2732, 3854);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 2732, 3854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 3827, 3839);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 2732, 3854);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(537, 2468, 3865);

                bool
                f_537_2557_2575_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 2557, 2575);
                    return return_v;
                }


                System.ArgumentException
                f_537_2615_2700(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 2615, 2700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                f_537_3285_3323(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param)
                {
                    var return_v = this_param.ToBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 3285, 3323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_3367_3393_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 3367, 3393);
                    return return_v;
                }


                string
                f_537_3712_3720()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 3712, 3720);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_3737_3766(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 3737, 3766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_537_3700_3778(string
                filePath, Microsoft.CodeAnalysis.ReportDiagnostic
                generalOption, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                includes)
                {
                    var return_v = new Microsoft.CodeAnalysis.RuleSet(filePath, generalOption, specificOptions, includes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 3700, 3778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 2468, 3865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 2468, 3865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RuleSet GetEffectiveRuleSet(HashSet<string> includedRulesetPaths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 4006, 7560);
                Microsoft.CodeAnalysis.ReportDiagnostic value = default(Microsoft.CodeAnalysis.ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4104, 4158);

                var
                effectiveGeneralOption = _generalDiagnosticOption
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4172, 4246);

                var
                effectiveSpecificOptions = f_537_4203_4245()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4340, 4422) || true) && (_includes.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 4340, 4422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4395, 4407);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 4340, 4422);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4438, 6818);
                    foreach (var ruleSetInclude in f_537_4469_4478_I(_includes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 4438, 6818);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4595, 4719) || true) && (f_537_4599_4620(ruleSetInclude) == ReportDiagnostic.Suppress)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 4595, 4719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4691, 4700);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 4595, 4719);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4739, 4786);

                        var
                        ruleSet = f_537_4753_4785(ruleSetInclude, this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4892, 4981) || true) && (ruleSet == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 4892, 4981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 4953, 4962);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 4892, 4981);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5083, 5223) || true) && (f_537_5087_5153(includedRulesetPaths, f_537_5117_5152(f_537_5117_5133(ruleSet))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 5083, 5223);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5195, 5204);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 5083, 5223);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5243, 5305);

                        f_537_5243_5304(
                                        includedRulesetPaths, f_537_5268_5303(f_537_5268_5284(ruleSet)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5464, 5542);

                        RuleSet?
                        effectiveRuleset = f_537_5492_5541(ruleSet, includedRulesetPaths)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5623, 5702);

                        effectiveRuleset = f_537_5642_5701(effectiveRuleset, f_537_5679_5700(ruleSetInclude));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5720, 5761);

                        f_537_5720_5760(effectiveRuleset is object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 5891, 6102) || true) && (f_537_5895_5975(f_537_5910_5950(effectiveRuleset), effectiveGeneralOption))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 5891, 6102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6017, 6083);

                            effectiveGeneralOption = f_537_6042_6082(effectiveRuleset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 5891, 6102);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6222, 6803);
                            foreach (var item in f_537_6243_6285_I(f_537_6243_6285(effectiveRuleset)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 6222, 6803);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6327, 6784) || true) && (f_537_6331_6392(effectiveSpecificOptions, item.Key, out value))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 6327, 6784);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6442, 6612) || true) && (f_537_6446_6479(item.Value, value))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 6442, 6612);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6537, 6585);

                                        effectiveSpecificOptions[item.Key] = item.Value;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 6442, 6612);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 6327, 6784);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 6327, 6784);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 6710, 6761);

                                    f_537_6710_6760(effectiveSpecificOptions, item.Key, item.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 6327, 6784);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(537, 6222, 6803);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 582);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 582);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 4438, 6818);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 2381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 2381);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7003, 7391);
                    foreach (var item in f_537_7024_7050_I(_specificDiagnosticOptions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 7003, 7391);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7084, 7376) || true) && (f_537_7088_7134(effectiveSpecificOptions, item.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 7084, 7376);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7176, 7224);

                            effectiveSpecificOptions[item.Key] = item.Value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 7084, 7376);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 7084, 7376);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7306, 7357);

                            f_537_7306_7356(effectiveSpecificOptions, item.Key, item.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 7084, 7376);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 7003, 7391);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7407, 7549);

                return f_537_7414_7548(_filePath, effectiveGeneralOption, f_537_7461_7509(effectiveSpecificOptions), ImmutableArray<RuleSetInclude>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(537, 4006, 7560);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_4203_4245()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 4203, 4245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_4599_4620(Microsoft.CodeAnalysis.RuleSetInclude
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 4599, 4620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet?
                f_537_4753_4785(Microsoft.CodeAnalysis.RuleSetInclude
                this_param, Microsoft.CodeAnalysis.RuleSet
                parent)
                {
                    var return_v = this_param.LoadRuleSet(parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 4753, 4785);
                    return return_v;
                }


                string
                f_537_5117_5133(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 5117, 5133);
                    return return_v;
                }


                string
                f_537_5117_5152(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5117, 5152);
                    return return_v;
                }


                bool
                f_537_5087_5153(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5087, 5153);
                    return return_v;
                }


                string
                f_537_5268_5284(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 5268, 5284);
                    return return_v;
                }


                string
                f_537_5268_5303(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5268, 5303);
                    return return_v;
                }


                bool
                f_537_5243_5304(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5243, 5304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_537_5492_5541(Microsoft.CodeAnalysis.RuleSet
                this_param, System.Collections.Generic.HashSet<string>
                includedRulesetPaths)
                {
                    var return_v = this_param.GetEffectiveRuleSet(includedRulesetPaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5492, 5541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_5679_5700(Microsoft.CodeAnalysis.RuleSetInclude
                this_param)
                {
                    var return_v = this_param.Action;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 5679, 5700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet?
                f_537_5642_5701(Microsoft.CodeAnalysis.RuleSet
                this_param, Microsoft.CodeAnalysis.ReportDiagnostic
                action)
                {
                    var return_v = this_param.WithEffectiveAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5642, 5701);
                    return return_v;
                }


                int
                f_537_5720_5760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5720, 5760);
                    return 0;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_5910_5950(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 5910, 5950);
                    return return_v;
                }


                bool
                f_537_5895_5975(Microsoft.CodeAnalysis.ReportDiagnostic
                action1, Microsoft.CodeAnalysis.ReportDiagnostic
                action2)
                {
                    var return_v = IsStricterThan(action1, action2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 5895, 5975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_6042_6082(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 6042, 6082);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_6243_6285(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 6243, 6285);
                    return return_v;
                }


                bool
                f_537_6331_6392(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 6331, 6392);
                    return return_v;
                }


                bool
                f_537_6446_6479(Microsoft.CodeAnalysis.ReportDiagnostic
                action1, Microsoft.CodeAnalysis.ReportDiagnostic
                action2)
                {
                    var return_v = IsStricterThan(action1, action2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 6446, 6479);
                    return return_v;
                }


                int
                f_537_6710_6760(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 6710, 6760);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_6243_6285_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 6243, 6285);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                f_537_4469_4478_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 4469, 4478);
                    return return_v;
                }


                bool
                f_537_7088_7134(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7088, 7134);
                    return return_v;
                }


                int
                f_537_7306_7356(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7306, 7356);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_7024_7050_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7024, 7050);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_7461_7509(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                source)
                {
                    var return_v = source.ToImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7461, 7509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_537_7414_7548(string
                filePath, Microsoft.CodeAnalysis.ReportDiagnostic
                generalOption, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                includes)
                {
                    var return_v = new Microsoft.CodeAnalysis.RuleSet(filePath, generalOption, specificOptions, includes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7414, 7548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 4006, 7560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 4006, 7560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<string> GetEffectiveIncludes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 7686, 7938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7764, 7822);

                var
                arrayBuilder = f_537_7783_7821()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7838, 7877);

                f_537_7838_7876(this, arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 7893, 7927);

                return f_537_7900_7926(arrayBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(537, 7686, 7938);

                System.Collections.Immutable.ImmutableArray<string>.Builder
                f_537_7783_7821()
                {
                    var return_v = ImmutableArray.CreateBuilder<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7783, 7821);
                    return return_v;
                }


                int
                f_537_7838_7876(Microsoft.CodeAnalysis.RuleSet
                this_param, System.Collections.Immutable.ImmutableArray<string>.Builder
                arrayBuilder)
                {
                    this_param.GetEffectiveIncludesCore(arrayBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7838, 7876);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_537_7900_7926(System.Collections.Immutable.ImmutableArray<string>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 7900, 7926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 7686, 7938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 7686, 7938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetEffectiveIncludesCore(ImmutableArray<string>.Builder arrayBuilder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(537, 7950, 8735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8057, 8089);

                f_537_8057_8088(arrayBuilder, f_537_8074_8087(this));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8105, 8724);
                    foreach (var ruleSetInclude in f_537_8136_8145_I(_includes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8105, 8724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8179, 8226);

                        var
                        ruleSet = f_537_8193_8225(ruleSetInclude, this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8332, 8421) || true) && (ruleSet == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8332, 8421);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8393, 8402);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8332, 8421);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8523, 8709) || true) && (!f_537_8528_8601(arrayBuilder, f_537_8550_8566(ruleSet), f_537_8568_8600()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8523, 8709);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8643, 8690);

                            f_537_8643_8689(ruleSet, arrayBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8523, 8709);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8105, 8724);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 620);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(537, 7950, 8735);

                string
                f_537_8074_8087(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 8074, 8087);
                    return return_v;
                }


                int
                f_537_8057_8088(System.Collections.Immutable.ImmutableArray<string>.Builder
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 8057, 8088);
                    return 0;
                }


                Microsoft.CodeAnalysis.RuleSet?
                f_537_8193_8225(Microsoft.CodeAnalysis.RuleSetInclude
                this_param, Microsoft.CodeAnalysis.RuleSet
                parent)
                {
                    var return_v = this_param.LoadRuleSet(parent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 8193, 8225);
                    return return_v;
                }


                string
                f_537_8550_8566(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 8550, 8566);
                    return return_v;
                }


                System.StringComparer
                f_537_8568_8600()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 8568, 8600);
                    return return_v;
                }


                bool
                f_537_8528_8601(System.Collections.Immutable.ImmutableArray<string>.Builder
                list, string
                item, System.StringComparer
                comparer)
                {
                    var return_v = list.Contains<string>(item, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 8528, 8601);
                    return return_v;
                }


                int
                f_537_8643_8689(Microsoft.CodeAnalysis.RuleSet
                this_param, System.Collections.Immutable.ImmutableArray<string>.Builder
                arrayBuilder)
                {
                    this_param.GetEffectiveIncludesCore(arrayBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 8643, 8689);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                f_537_8136_8145_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RuleSetInclude>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 8136, 8145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 7950, 8735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 7950, 8735);
            }
        }

        private static bool IsStricterThan(ReportDiagnostic action1, ReportDiagnostic action2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 8861, 9909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 8972, 9898);

                switch (action2)
                {

                    case ReportDiagnostic.Suppress:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9074, 9086);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    case ReportDiagnostic.Default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9156, 9307);

                        return action1 == ReportDiagnostic.Warn || (DynAbs.Tracing.TraceSender.Expression_False(537, 9163, 9232) || action1 == ReportDiagnostic.Error) || (DynAbs.Tracing.TraceSender.Expression_False(537, 9163, 9268) || action1 == ReportDiagnostic.Info) || (DynAbs.Tracing.TraceSender.Expression_False(537, 9163, 9306) || action1 == ReportDiagnostic.Hidden);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    case ReportDiagnostic.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9376, 9489);

                        return action1 == ReportDiagnostic.Warn || (DynAbs.Tracing.TraceSender.Expression_False(537, 9383, 9452) || action1 == ReportDiagnostic.Error) || (DynAbs.Tracing.TraceSender.Expression_False(537, 9383, 9488) || action1 == ReportDiagnostic.Info);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    case ReportDiagnostic.Info:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9556, 9633);

                        return action1 == ReportDiagnostic.Warn || (DynAbs.Tracing.TraceSender.Expression_False(537, 9563, 9632) || action1 == ReportDiagnostic.Error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    case ReportDiagnostic.Warn:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9700, 9741);

                        return action1 == ReportDiagnostic.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    case ReportDiagnostic.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9809, 9822);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 8972, 9898);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 9870, 9883);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 8972, 9898);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 8861, 9909);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 8861, 9909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 8861, 9909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RuleSet LoadEffectiveRuleSetFromFile(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 10351, 10580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 10443, 10497);

                var
                ruleSet = f_537_10457_10496(filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 10511, 10569);

                return f_537_10518_10568(ruleSet, f_537_10546_10567());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 10351, 10580);

                Microsoft.CodeAnalysis.RuleSet
                f_537_10457_10496(string
                filePath)
                {
                    var return_v = RuleSetProcessor.LoadFromFile(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 10457, 10496);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_537_10546_10567()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 10546, 10567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_537_10518_10568(Microsoft.CodeAnalysis.RuleSet
                this_param, System.Collections.Generic.HashSet<string>
                includedRulesetPaths)
                {
                    var return_v = this_param.GetEffectiveRuleSet(includedRulesetPaths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 10518, 10568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 10351, 10580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 10351, 10580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ImmutableArray<string> GetEffectiveIncludesFromFile(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 10952, 11296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 11059, 11113);

                var
                ruleSet = f_537_11073_11112(filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 11127, 11233) || true) && (ruleSet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 11127, 11233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 11180, 11218);

                    return f_537_11187_11217(ruleSet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 11127, 11233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 11249, 11285);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 10952, 11296);

                Microsoft.CodeAnalysis.RuleSet
                f_537_11073_11112(string
                filePath)
                {
                    var return_v = RuleSetProcessor.LoadFromFile(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 11073, 11112);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_537_11187_11217(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.GetEffectiveIncludes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 11187, 11217);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 10952, 11296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 10952, 11296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static ReportDiagnostic GetDiagnosticOptionsFromRulesetFile(string? rulesetFileFullPath, out Dictionary<string, ReportDiagnostic> specificDiagnosticOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 11752, 12058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 11940, 12047);

                return f_537_11947_12046(rulesetFileFullPath, out specificDiagnosticOptions, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 11752, 12058);

                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_11947_12046(string?
                rulesetFileFullPath, out System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                diagnosticOptions, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>?
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider?
                messageProviderOpt)
                {
                    var return_v = GetDiagnosticOptionsFromRulesetFile(rulesetFileFullPath, out diagnosticOptions, diagnosticsOpt, messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 11947, 12046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 11752, 12058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 11752, 12058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ReportDiagnostic GetDiagnosticOptionsFromRulesetFile(string? rulesetFileFullPath, out Dictionary<string, ReportDiagnostic> diagnosticOptions, IList<Diagnostic>? diagnosticsOpt, CommonMessageProvider? messageProviderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 12070, 12665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12330, 12393);

                diagnosticOptions = f_537_12350_12392();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12407, 12519) || true) && (rulesetFileFullPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 12407, 12519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12472, 12504);

                    return ReportDiagnostic.Default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(537, 12407, 12519);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12535, 12654);

                return f_537_12542_12653(diagnosticOptions, rulesetFileFullPath, diagnosticsOpt, messageProviderOpt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 12070, 12665);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_12350_12392()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 12350, 12392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_12542_12653(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                diagnosticOptions, string
                resolvedPath, System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>?
                diagnosticsOpt, Microsoft.CodeAnalysis.CommonMessageProvider?
                messageProviderOpt)
                {
                    var return_v = GetDiagnosticOptionsFromRulesetFile(diagnosticOptions, resolvedPath, diagnosticsOpt, messageProviderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 12542, 12653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 12070, 12665);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 12070, 12665);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ReportDiagnostic GetDiagnosticOptionsFromRulesetFile(Dictionary<string, ReportDiagnostic> diagnosticOptions, string resolvedPath, IList<Diagnostic>? diagnosticsOpt, CommonMessageProvider? messageProviderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(537, 12677, 14714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12924, 12959);

                f_537_12924_12958(resolvedPath != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 12975, 13030);

                var
                generalDiagnosticOption = ReportDiagnostic.Default
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13080, 13145);

                    var
                    ruleSet = f_537_13094_13144(resolvedPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13163, 13221);

                    generalDiagnosticOption = f_537_13189_13220(ruleSet);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13239, 13398);
                        foreach (var rule in f_537_13260_13293_I(f_537_13260_13293(ruleSet)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 13239, 13398);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13335, 13379);

                            f_537_13335_13378(diagnosticOptions, rule.Key, rule.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 13239, 13398);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(537, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(537, 1, 160);
                    }
                }
                catch (InvalidRuleSetException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(537, 13427, 13752);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13493, 13737) || true) && (diagnosticsOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(537, 13497, 13549) && messageProviderOpt != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 13493, 13737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13591, 13718);

                        f_537_13591_13717(diagnosticsOpt, f_537_13610_13716(messageProviderOpt, f_537_13648_13690(messageProviderOpt), resolvedPath, f_537_13706_13715(e)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 13493, 13737);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(537, 13427, 13752);
                }
                catch (IOException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(537, 13766, 14656);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13820, 14641) || true) && (e is FileNotFoundException || (DynAbs.Tracing.TraceSender.Expression_False(537, 13824, 13902) || f_537_13854_13870(f_537_13854_13865(e)) == "DirectoryNotFoundException"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 13820, 14641);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 13944, 14284) || true) && (diagnosticsOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(537, 13948, 14000) && messageProviderOpt != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 13944, 14284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 14050, 14261);

                            f_537_14050_14260(diagnosticsOpt, f_537_14069_14259(messageProviderOpt, f_537_14107_14149(messageProviderOpt), resolvedPath, f_537_14165_14258(nameof(CodeAnalysisResources.FileNotFound))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 13944, 14284);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 13820, 14641);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 13820, 14641);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 14366, 14622) || true) && (diagnosticsOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(537, 14370, 14422) && messageProviderOpt != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(537, 14366, 14622);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 14472, 14599);

                            f_537_14472_14598(diagnosticsOpt, f_537_14491_14597(messageProviderOpt, f_537_14529_14571(messageProviderOpt), resolvedPath, f_537_14587_14596(e)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(537, 14366, 14622);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(537, 13820, 14641);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(537, 13766, 14656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(537, 14672, 14703);

                return generalDiagnosticOption;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(537, 12677, 14714);

                int
                f_537_12924_12958(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 12924, 12958);
                    return 0;
                }


                Microsoft.CodeAnalysis.RuleSet
                f_537_13094_13144(string
                filePath)
                {
                    var return_v = RuleSet.LoadEffectiveRuleSetFromFile(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13094, 13144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_537_13189_13220(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 13189, 13220);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_13260_13293(Microsoft.CodeAnalysis.RuleSet
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 13260, 13293);
                    return return_v;
                }


                int
                f_537_13335_13378(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13335, 13378);
                    return 0;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_537_13260_13293_I(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13260, 13293);
                    return return_v;
                }


                int
                f_537_13648_13690(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantReadRulesetFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 13648, 13690);
                    return return_v;
                }


                string
                f_537_13706_13715(Microsoft.CodeAnalysis.InvalidRuleSetException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 13706, 13715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_537_13610_13716(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13610, 13716);
                    return return_v;
                }


                int
                f_537_13591_13717(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13591, 13717);
                    return 0;
                }


                System.Type
                f_537_13854_13865(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 13854, 13865);
                    return return_v;
                }


                string
                f_537_13854_13870(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 13854, 13870);
                    return return_v;
                }


                int
                f_537_14107_14149(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantReadRulesetFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 14107, 14149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument
                f_537_14165_14258(string
                targetResourceId)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeAnalysisResourcesLocalizableErrorArgument(targetResourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 14165, 14258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_537_14069_14259(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 14069, 14259);
                    return return_v;
                }


                int
                f_537_14050_14260(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 14050, 14260);
                    return 0;
                }


                int
                f_537_14529_14571(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.ERR_CantReadRulesetFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 14529, 14571);
                    return return_v;
                }


                string
                f_537_14587_14596(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(537, 14587, 14596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_537_14491_14597(Microsoft.CodeAnalysis.CommonMessageProvider
                messageProvider, int
                errorCode, params object[]
                arguments)
                {
                    var return_v = Diagnostic.Create(messageProvider, errorCode, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 14491, 14597);
                    return return_v;
                }


                int
                f_537_14472_14598(System.Collections.Generic.IList<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(537, 14472, 14598);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(537, 12677, 14714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 12677, 14714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuleSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(537, 534, 14721);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(537, 534, 14721);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(537, 534, 14721);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(537, 534, 14721);
    }
}
