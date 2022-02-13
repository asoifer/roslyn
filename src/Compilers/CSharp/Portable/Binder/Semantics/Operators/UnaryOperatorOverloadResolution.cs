// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class OverloadResolution
    {
        private NamedTypeSymbol MakeNullable(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 559, 729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 637, 718);

                return f_10862_644_717(f_10862_644_701(f_10862_644_655(), SpecialType.System_Nullable_T), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 559, 729);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10862_644_655()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 644, 655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_644_701(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 644, 701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_644_717(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 644, 717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 559, 729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 559, 729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void UnaryOperatorOverloadResolution(UnaryOperatorKind kind, BoundExpression operand, UnaryOperatorOverloadResolutionResult result, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 741, 2865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 952, 982);

                f_10862_952_981(operand != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 996, 1036);

                f_10862_996_1035(f_10862_1009_1029(result.Results) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 1141, 1185);

                f_10862_1141_1184(this, kind, operand, result);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 1199, 1283) || true) && (f_10862_1203_1223(result.Results) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 1199, 1283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 1261, 1268);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 1199, 1283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 1665, 1775);

                bool
                hadUserDefinedCandidate = f_10862_1696_1774(this, kind, operand, result.Results, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 2159, 2355) || true) && (!hadUserDefinedCandidate)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 2159, 2355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 2221, 2244);

                    f_10862_2221_2243(result.Results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 2262, 2340);

                    f_10862_2262_2339(this, kind, operand, result.Results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 2159, 2355);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 2781, 2854);

                f_10862_2781_2853(this, operand, result, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 741, 2865);

                int
                f_10862_952_981(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 952, 981);
                    return 0;
                }


                int
                f_10862_1009_1029(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 1009, 1029);
                    return return_v;
                }


                int
                f_10862_996_1035(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 996, 1035);
                    return 0;
                }


                int
                f_10862_1141_1184(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                result)
                {
                    this_param.UnaryOperatorEasyOut(kind, operand, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 1141, 1184);
                    return 0;
                }


                int
                f_10862_1203_1223(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 1203, 1223);
                    return return_v;
                }


                bool
                f_10862_1696_1774(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetUserDefinedOperators(kind, operand, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 1696, 1774);
                    return return_v;
                }


                int
                f_10862_2221_2243(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 2221, 2243);
                    return 0;
                }


                int
                f_10862_2262_2339(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllBuiltInOperators(kind, operand, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 2262, 2339);
                    return 0;
                }


                int
                f_10862_2781_2853(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.UnaryOperatorOverloadResolution(operand, result, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 2781, 2853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 741, 2865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 741, 2865);
            }
        }

        private void UnaryOperatorOverloadResolution(
                    BoundExpression operand,
                    UnaryOperatorOverloadResolutionResult result,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 3021, 5881);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 3503, 3583) || true) && (f_10862_3507_3527(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 3503, 3583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 3561, 3568);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 3503, 3583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4145, 4177);

                var
                candidates = result.Results
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4243, 4329);

                int
                bestIndex = f_10862_4259_4328(this, operand, candidates, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4343, 4817) || true) && (bestIndex != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 4343, 4817);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4460, 4469);
                        // Mark all other candidates as worse
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4451, 4775) || true) && (index < f_10862_4479_4495(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4497, 4504)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 4451, 4775))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 4451, 4775);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4546, 4756) || true) && (candidates[index].Kind != OperatorAnalysisResultKind.Inapplicable && (DynAbs.Tracing.TraceSender.Expression_True(10862, 4550, 4637) && index != bestIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 4546, 4756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4687, 4733);

                                candidates[index] = candidates[index].Worse();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 4546, 4756);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 325);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4795, 4802);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 4343, 4817);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4842, 4847);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4833, 5870) || true) && (i < f_10862_4853_4869(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4871, 4874)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 4833, 5870))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 4833, 5870);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 4908, 5041) || true) && (candidates[i].Kind != OperatorAnalysisResultKind.Applicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 4908, 5041);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5013, 5022);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 4908, 5041);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5161, 5166);

                            // Is this applicable operator better than every other applicable method?
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5152, 5855) || true) && (j < i)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5175, 5178)
            , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 5152, 5855))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 5152, 5855);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5220, 5367) || true) && (candidates[j].Kind == OperatorAnalysisResultKind.Inapplicable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 5220, 5367);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5335, 5344);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 5220, 5367);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5391, 5502);

                                var
                                better = f_10862_5404_5501(this, candidates[i].Signature, candidates[j].Signature, operand, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5524, 5836) || true) && (better == BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 5524, 5836);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5605, 5643);

                                    candidates[j] = candidates[j].Worse();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 5524, 5836);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 5524, 5836);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5693, 5836) || true) && (better == BetterResult.Right)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 5693, 5836);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 5775, 5813);

                                        candidates[i] = candidates[i].Worse();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 5693, 5836);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 5524, 5836);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 704);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 704);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 1038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 1038);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 3021, 5881);

                bool
                f_10862_3507_3527(Microsoft.CodeAnalysis.CSharp.UnaryOperatorOverloadResolutionResult
                this_param)
                {
                    var return_v = this_param.SingleValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 3507, 3527);
                    return return_v;
                }


                int
                f_10862_4259_4328(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                candidates, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetTheBestCandidateIndex(operand, candidates, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 4259, 4328);
                    return return_v;
                }


                int
                f_10862_4479_4495(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 4479, 4495);
                    return return_v;
                }


                int
                f_10862_4853_4869(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 4853, 4869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10862_5404_5501(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, operand, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 5404, 5501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 3021, 5881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 3021, 5881);
            }
        }

        private int GetTheBestCandidateIndex(
                    BoundExpression operand,
                    ArrayBuilder<UnaryOperatorAnalysisResult> candidates,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 5893, 7961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6121, 6147);

                int
                currentBestIndex = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6170, 6179);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6161, 7249) || true) && (index < f_10862_6189_6205(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6207, 6214)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6161, 7249))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6161, 7249);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6248, 6385) || true) && (candidates[index].Kind != OperatorAnalysisResultKind.Applicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6248, 6385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6357, 6366);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6248, 6385);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6492, 7234) || true) && (currentBestIndex == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6492, 7234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6560, 6585);

                            currentBestIndex = index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6492, 7234);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6492, 7234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6667, 6797);

                            var
                            better = f_10862_6680_6796(this, candidates[currentBestIndex].Signature, candidates[index].Signature, operand, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6819, 7215) || true) && (better == BetterResult.Right)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6819, 7215);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 6955, 6980);

                                currentBestIndex = index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6819, 7215);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 6819, 7215);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7030, 7215) || true) && (better != BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 7030, 7215);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7170, 7192);

                                    currentBestIndex = -1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 7030, 7215);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6819, 7215);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 6492, 7234);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 1089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 1089);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7353, 7362);

                    // Make sure that every candidate up to the current best is worse
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7344, 7910) || true) && (index < currentBestIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7390, 7397)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 7344, 7910))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 7344, 7910);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7431, 7570) || true) && (candidates[index].Kind == OperatorAnalysisResultKind.Inapplicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 7431, 7570);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7542, 7551);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 7431, 7570);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7590, 7720);

                        var
                        better = f_10862_7603_7719(this, candidates[currentBestIndex].Signature, candidates[index].Signature, operand, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7738, 7895) || true) && (better != BetterResult.Left)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 7738, 7895);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7866, 7876);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 7738, 7895);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 7926, 7950);

                return currentBestIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 5893, 7961);

                int
                f_10862_6189_6205(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 6189, 6205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10862_6680_6796(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, operand, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 6680, 6796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10862_7603_7719(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, operand, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 7603, 7719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 5893, 7961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 5893, 7961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterOperator(UnaryOperatorSignature op1, UnaryOperatorSignature op2, BoundExpression operand, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 7973, 10752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 8309, 8429);

                BetterResult
                better = f_10862_8331_8428(this, operand, op1.OperandType, op2.OperandType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 8445, 8571) || true) && (better == BetterResult.Left || (DynAbs.Tracing.TraceSender.Expression_False(10862, 8449, 8508) || better == BetterResult.Right))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 8445, 8571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 8542, 8556);

                    return better;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 8445, 8571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 8949, 10298) || true) && (f_10862_8953_9020(op1.OperandType, op2.OperandType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 8949, 10298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 9933, 9968);

                    bool
                    lifted1 = f_10862_9948_9967(op1.Kind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 9986, 10021);

                    bool
                    lifted2 = f_10862_10001_10020(op2.Kind)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10041, 10283) || true) && (lifted1 && (DynAbs.Tracing.TraceSender.Expression_True(10862, 10045, 10064) && !lifted2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10041, 10283);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10106, 10132);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10041, 10283);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10041, 10283);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10174, 10283) || true) && (!lifted1 && (DynAbs.Tracing.TraceSender.Expression_True(10862, 10178, 10197) && lifted2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10174, 10283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10239, 10264);

                            return BetterResult.Left;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10174, 10283);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10041, 10283);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 8949, 10298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10409, 10697) || true) && (op1.RefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10862, 10413, 10469) && op2.RefKind == RefKind.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10409, 10697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10503, 10528);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10409, 10697);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10409, 10697);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10562, 10697) || true) && (op2.RefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10862, 10566, 10622) && op1.RefKind == RefKind.In))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 10562, 10697);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10656, 10682);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10562, 10697);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 10409, 10697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 10713, 10741);

                return BetterResult.Neither;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 7973, 10752);

                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10862_8331_8428(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 8331, 8428);
                    return return_v;
                }


                bool
                f_10862_8953_9020(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 8953, 9020);
                    return return_v;
                }


                bool
                f_10862_9948_9967(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 9948, 9967);
                    return return_v;
                }


                bool
                f_10862_10001_10020(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 10001, 10020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 7973, 10752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 7973, 10752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetAllBuiltInOperators(UnaryOperatorKind kind, BoundExpression operand, ArrayBuilder<UnaryOperatorAnalysisResult> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 10764, 12630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 11994, 12061);

                var
                operators = f_10862_12010_12060()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12075, 12240);

                f_10862_12075_12239(f_10862_12075_12091(this).builtInOperators, kind, operators, skipNativeIntegerOperators: !f_10862_12181_12238(f_10862_12181_12193(operand)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12256, 12300);

                f_10862_12256_12299(this, kind, operand, operators);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12316, 12373);

                var
                pointerOperator = f_10862_12338_12372(kind, operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12387, 12500) || true) && (pointerOperator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 12387, 12500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12448, 12485);

                    f_10862_12448_12484(operators, pointerOperator.Value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 12387, 12500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12516, 12588);

                f_10862_12516_12587(this, operators, operand, results, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12602, 12619);

                f_10862_12602_12618(operators);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 10764, 12630);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                f_10862_12010_12060()
                {
                    var return_v = ArrayBuilder<UnaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12010, 12060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10862_12075_12091(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 12075, 12091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10862_12181_12193(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 12181, 12193);
                    return return_v;
                }


                bool
                f_10862_12181_12238(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNativeIntegerOrNullableNativeIntegerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12181, 12238);
                    return return_v;
                }


                int
                f_10862_12075_12239(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators, bool
                skipNativeIntegerOperators)
                {
                    this_param.GetSimpleBuiltInOperators(kind, operators, skipNativeIntegerOperators: skipNativeIntegerOperators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12075, 12239);
                    return 0;
                }


                int
                f_10862_12256_12299(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators)
                {
                    this_param.GetEnumOperations(kind, operand, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12256, 12299);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature?
                f_10862_12338_12372(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = GetPointerOperation(kind, operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12338, 12372);
                    return return_v;
                }


                int
                f_10862_12448_12484(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12448, 12484);
                    return 0;
                }


                bool
                f_10862_12516_12587(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, operand, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12516, 12587);
                    return return_v;
                }


                int
                f_10862_12602_12618(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12602, 12618);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 10764, 12630);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 10764, 12630);
            }
        }

        private bool CandidateOperators(ArrayBuilder<UnaryOperatorSignature> operators, BoundExpression operand, ArrayBuilder<UnaryOperatorAnalysisResult> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 12708, 13580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12936, 12963);

                bool
                anyApplicable = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 12977, 13532);
                    foreach (var op in f_10862_12996_13005_I(operators))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 12977, 13532);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13039, 13150);

                        var
                        conversion = f_10862_13056_13149(f_10862_13056_13067(), operand, op.OperandType, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13168, 13517) || true) && (conversion.IsImplicit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 13168, 13517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13235, 13256);

                            anyApplicable = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13278, 13346);

                            f_10862_13278_13345(results, UnaryOperatorAnalysisResult.Applicable(op, conversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 13168, 13517);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 13168, 13517);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13428, 13498);

                            f_10862_13428_13497(results, UnaryOperatorAnalysisResult.Inapplicable(op, conversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 13168, 13517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 12977, 13532);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 556);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13548, 13569);

                return anyApplicable;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 12708, 13580);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10862_13056_13067()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 13056, 13067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10862_13056_13149(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13056, 13149);
                    return return_v;
                }


                int
                f_10862_13278_13345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13278, 13345);
                    return 0;
                }


                int
                f_10862_13428_13497(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13428, 13497);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                f_10862_12996_13005_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 12996, 13005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 12708, 13580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 12708, 13580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetEnumOperations(UnaryOperatorKind kind, BoundExpression operand, ArrayBuilder<UnaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 13592, 14778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13744, 13774);

                f_10862_13744_13773(operand != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13790, 13818);

                var
                enumType = f_10862_13805_13817(operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13832, 13916) || true) && ((object)enumType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 13832, 13916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13894, 13901);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 13832, 13916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13932, 13967);

                enumType = f_10862_13943_13966(enumType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 13981, 14068) || true) && (!f_10862_13986_14012(enumType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 13981, 14068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14046, 14053);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 13981, 14068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14084, 14126);

                var
                nullableEnum = f_10862_14103_14125(this, enumType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14142, 14767);

                switch (kind)
                {

                    case UnaryOperatorKind.PostfixIncrement:
                    case UnaryOperatorKind.PostfixDecrement:
                    case UnaryOperatorKind.PrefixIncrement:
                    case UnaryOperatorKind.PrefixDecrement:
                    case UnaryOperatorKind.BitwiseComplement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 14142, 14767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14481, 14574);

                        f_10862_14481_14573(operators, f_10862_14495_14572(kind | UnaryOperatorKind.Enum, enumType, enumType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14596, 14724);

                        f_10862_14596_14723(operators, f_10862_14610_14722(kind | UnaryOperatorKind.Lifted | UnaryOperatorKind.Enum, nullableEnum, nullableEnum));
                        DynAbs.Tracing.TraceSender.TraceBreak(10862, 14746, 14752);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 14142, 14767);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 13592, 14778);

                int
                f_10862_13744_13773(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13744, 13773);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10862_13805_13817(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 13805, 13817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10862_13943_13966(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13943, 13966);
                    return return_v;
                }


                bool
                f_10862_13986_14012(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 13986, 14012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_14103_14125(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14103, 14125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10862_14495_14572(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature(kind, operandType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14495, 14572);
                    return return_v;
                }


                int
                f_10862_14481_14573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14481, 14573);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10862_14610_14722(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)operandType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14610, 14722);
                    return return_v;
                }


                int
                f_10862_14596_14723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14596, 14723);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 13592, 14778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 13592, 14778);
            }
        }

        private static UnaryOperatorSignature? GetPointerOperation(UnaryOperatorKind kind, BoundExpression operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10862, 14790, 15640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14922, 14952);

                f_10862_14922_14951(operand != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 14968, 15020);

                var
                pointerType = f_10862_14986_14998(operand) as PointerTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15034, 15126) || true) && ((object)pointerType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 15034, 15126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15099, 15111);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 15034, 15126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15142, 15176);

                UnaryOperatorSignature?
                op = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15190, 15605);

                switch (kind)
                {

                    case UnaryOperatorKind.PostfixIncrement:
                    case UnaryOperatorKind.PostfixDecrement:
                    case UnaryOperatorKind.PrefixIncrement:
                    case UnaryOperatorKind.PrefixDecrement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 15190, 15605);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15470, 15562);

                        op = f_10862_15475_15561(kind | UnaryOperatorKind.Pointer, pointerType, pointerType);
                        DynAbs.Tracing.TraceSender.TraceBreak(10862, 15584, 15590);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 15190, 15605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15619, 15629);

                return op;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10862, 14790, 15640);

                int
                f_10862_14922_14951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 14922, 14951);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10862_14986_14998(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 14986, 14998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10862_15475_15561(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)operandType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 15475, 15561);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 14790, 15640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 14790, 15640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetUserDefinedOperators(UnaryOperatorKind kind, BoundExpression operand, ArrayBuilder<UnaryOperatorAnalysisResult> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 15718, 22046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15927, 15957);

                f_10862_15927_15956(operand != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 15973, 16282) || true) && ((object)f_10862_15985_15997(operand) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 15973, 16282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 16254, 16267);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 15973, 16282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18080, 18127);

                TypeSymbol
                type0 = f_10862_18099_18126(f_10862_18099_18111(operand))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18245, 18367) || true) && (f_10862_18249_18305(type0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 18245, 18367);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18339, 18352);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 18245, 18367);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18383, 18451);

                string
                name = f_10862_18397_18450(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18465, 18532);

                var
                operators = f_10862_18481_18531()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18546, 18583);

                bool
                hadApplicableCandidates = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18599, 18650);

                NamedTypeSymbol
                current = type0 as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18664, 18821) || true) && ((object)current == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 18664, 18821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18725, 18806);

                    current = f_10862_18735_18805(type0, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 18664, 18821);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18837, 19022) || true) && ((object)current == null && (DynAbs.Tracing.TraceSender.Expression_True(10862, 18841, 18891) && f_10862_18868_18891(type0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 18837, 19022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 18925, 19007);

                    current = f_10862_18935_19006(((TypeParameterSymbol)type0), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 18837, 19022);
                }
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19038, 19553) || true) && ((object)current != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19070, 19152)
        , current = f_10862_19080_19152(current, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19038, 19553))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19038, 19553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19186, 19204);

                        f_10862_19186_19203(operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19222, 19291);

                        f_10862_19222_19290(this, current, kind, name, operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19309, 19325);

                        f_10862_19309_19324(results);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19343, 19538) || true) && (f_10862_19347_19418(this, operators, operand, results, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19343, 19538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19460, 19491);

                            hadApplicableCandidates = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10862, 19513, 19519);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19343, 19538);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 516);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19656, 21955) || true) && (!hadApplicableCandidates)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19656, 21955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19718, 19771);

                    ImmutableArray<NamedTypeSymbol>
                    interfaces = default
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19789, 20198) || true) && (f_10862_19793_19816(type0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19789, 20198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19858, 19947);

                        interfaces = f_10862_19871_19946(type0, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19789, 20198);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19789, 20198);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 19989, 20198) || true) && (f_10862_19993_20016(type0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 19989, 20198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20058, 20179);

                            interfaces = f_10862_20071_20178(((TypeParameterSymbol)type0), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19989, 20198);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19789, 20198);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20218, 21940) || true) && (f_10862_20222_20250_M(!interfaces.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 20218, 21940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20292, 20362);

                        var
                        shadowedInterfaces = f_10862_20317_20361()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20384, 20467);

                        var
                        resultsFromInterface = f_10862_20411_20466()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20489, 20505);

                        f_10862_20489_20504(results);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20529, 21821);
                            foreach (NamedTypeSymbol @interface in f_10862_20568_20578_I(interfaces))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 20529, 21821);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20628, 20830) || true) && (f_10862_20632_20655_M(!@interface.IsInterface))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 20628, 20830);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20794, 20803);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 20628, 20830);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 20858, 21079) || true) && (f_10862_20862_20901(shadowedInterfaces, @interface))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 20858, 21079);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21043, 21052);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 20858, 21079);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21107, 21125);

                                f_10862_21107_21124(
                                                        operators);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21151, 21180);

                                f_10862_21151_21179(resultsFromInterface);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21206, 21278);

                                f_10862_21206_21277(this, @interface, kind, name, operators);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21304, 21798) || true) && (f_10862_21308_21392(this, operators, operand, resultsFromInterface, ref useSiteDiagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 21304, 21798);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21450, 21481);

                                    hadApplicableCandidates = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21511, 21550);

                                    f_10862_21511_21549(results, resultsFromInterface);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21663, 21771);

                                    shadowedInterfaces.AddAll(f_10862_21689_21769(@interface, ref useSiteDiagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 21304, 21798);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 20529, 21821);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 1293);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 1293);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21845, 21871);

                        f_10862_21845_21870(
                                            shadowedInterfaces);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21893, 21921);

                        f_10862_21893_21920(resultsFromInterface);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 20218, 21940);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 19656, 21955);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 21971, 21988);

                f_10862_21971_21987(
                            operators);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22004, 22035);

                return hadApplicableCandidates;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 15718, 22046);

                int
                f_10862_15927_15956(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 15927, 15956);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10862_15985_15997(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 15985, 15997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10862_18099_18111(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 18099, 18111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10862_18099_18126(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18099, 18126);
                    return return_v;
                }


                bool
                f_10862_18249_18305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = OperatorFacts.DefinitelyHasNoUserDefinedOperators(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18249, 18305);
                    return return_v;
                }


                string
                f_10862_18397_18450(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = OperatorFacts.UnaryOperatorNameFromOperatorKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18397, 18450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                f_10862_18481_18531()
                {
                    var return_v = ArrayBuilder<UnaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18481, 18531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_18735_18805(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18735, 18805);
                    return return_v;
                }


                bool
                f_10862_18868_18891(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18868, 18891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_18935_19006(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 18935, 19006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_19080_19152(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19080, 19152);
                    return return_v;
                }


                int
                f_10862_19186_19203(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19186, 19203);
                    return 0;
                }


                int
                f_10862_19222_19290(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators)
                {
                    this_param.GetUserDefinedUnaryOperatorsFromType(type, kind, name, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19222, 19290);
                    return 0;
                }


                int
                f_10862_19309_19324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19309, 19324);
                    return 0;
                }


                bool
                f_10862_19347_19418(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, operand, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19347, 19418);
                    return return_v;
                }


                bool
                f_10862_19793_19816(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19793, 19816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10862_19871_19946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19871, 19946);
                    return return_v;
                }


                bool
                f_10862_19993_20016(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 19993, 20016);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10862_20071_20178(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20071, 20178);
                    return return_v;
                }


                bool
                f_10862_20222_20250_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 20222, 20250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10862_20317_20361()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20317, 20361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                f_10862_20411_20466()
                {
                    var return_v = ArrayBuilder<UnaryOperatorAnalysisResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20411, 20466);
                    return return_v;
                }


                int
                f_10862_20489_20504(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20489, 20504);
                    return 0;
                }


                bool
                f_10862_20632_20655_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 20632, 20655);
                    return return_v;
                }


                bool
                f_10862_20862_20901(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20862, 20901);
                    return return_v;
                }


                int
                f_10862_21107_21124(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21107, 21124);
                    return 0;
                }


                int
                f_10862_21151_21179(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21151, 21179);
                    return 0;
                }


                int
                f_10862_21206_21277(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators)
                {
                    this_param.GetUserDefinedUnaryOperatorsFromType(type, kind, name, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21206, 21277);
                    return 0;
                }


                bool
                f_10862_21308_21392(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, operand, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21308, 21392);
                    return return_v;
                }


                int
                f_10862_21511_21549(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21511, 21549);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10862_21689_21769(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21689, 21769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10862_20568_20578_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 20568, 20578);
                    return return_v;
                }


                int
                f_10862_21845_21870(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21845, 21870);
                    return 0;
                }


                int
                f_10862_21893_21920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21893, 21920);
                    return 0;
                }


                int
                f_10862_21971_21987(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 21971, 21987);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 15718, 22046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 15718, 22046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetUserDefinedUnaryOperatorsFromType(
                    NamedTypeSymbol type,
                    UnaryOperatorKind kind,
                    string name,
                    ArrayBuilder<UnaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10862, 22058, 24281);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22292, 24270);
                    foreach (MethodSymbol op in f_10862_22320_22343_I(f_10862_22320_22343(type, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 22292, 24270);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22470, 22584) || true) && (f_10862_22474_22491(op) != 1 || (DynAbs.Tracing.TraceSender.Expression_False(10862, 22474, 22514) || f_10862_22500_22514(op)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 22470, 22584);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22556, 22565);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 22470, 22584);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22604, 22652);

                        TypeSymbol
                        operandType = f_10862_22629_22651(op, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22670, 22708);

                        TypeSymbol
                        resultType = f_10862_22694_22707(op)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 22728, 22837);

                        f_10862_22728_22836(
                                        operators, f_10862_22742_22835(UnaryOperatorKind.UserDefined | kind, operandType, resultType, op));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 23202, 24255);

                        switch (kind)
                        {

                            case UnaryOperatorKind.UnaryPlus:
                            case UnaryOperatorKind.PrefixDecrement:
                            case UnaryOperatorKind.PrefixIncrement:
                            case UnaryOperatorKind.UnaryMinus:
                            case UnaryOperatorKind.PostfixDecrement:
                            case UnaryOperatorKind.PostfixIncrement:
                            case UnaryOperatorKind.LogicalNegation:
                            case UnaryOperatorKind.BitwiseComplement:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 23202, 24255);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 23741, 24204) || true) && (f_10862_23745_23768(operandType) && (DynAbs.Tracing.TraceSender.Expression_True(10862, 23745, 23801) && !f_10862_23773_23801(operandType)) && (DynAbs.Tracing.TraceSender.Expression_True(10862, 23745, 23856) && f_10862_23834_23856(resultType)) && (DynAbs.Tracing.TraceSender.Expression_True(10862, 23745, 23888) && !f_10862_23861_23888(resultType)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10862, 23741, 24204);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10862, 23946, 24177);

                                    f_10862_23946_24176(operators, f_10862_23960_24175(UnaryOperatorKind.Lifted | UnaryOperatorKind.UserDefined | kind, f_10862_24119_24144(this, operandType), f_10862_24146_24170(this, resultType), op));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 23741, 24204);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10862, 24230, 24236);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 23202, 24255);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10862, 22292, 24270);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10862, 1, 1979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10862, 1, 1979);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10862, 22058, 24281);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10862_22320_22343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetOperators(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 22320, 22343);
                    return return_v;
                }


                int
                f_10862_22474_22491(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 22474, 22491);
                    return return_v;
                }


                bool
                f_10862_22500_22514(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 22500, 22514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10862_22629_22651(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 22629, 22651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10862_22694_22707(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 22694, 22707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10862_22742_22835(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature(kind, operandType, returnType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 22742, 22835);
                    return return_v;
                }


                int
                f_10862_22728_22836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 22728, 22836);
                    return 0;
                }


                bool
                f_10862_23745_23768(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 23745, 23768);
                    return return_v;
                }


                bool
                f_10862_23773_23801(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 23773, 23801);
                    return return_v;
                }


                bool
                f_10862_23834_23856(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10862, 23834, 23856);
                    return return_v;
                }


                bool
                f_10862_23861_23888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 23861, 23888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_24119_24144(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 24119, 24144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10862_24146_24170(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 24146, 24170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                f_10862_23960_24175(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                operandType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)operandType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 23960, 24175);
                    return return_v;
                }


                int
                f_10862_23946_24176(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 23946, 24176);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10862_22320_22343_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10862, 22320, 22343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10862, 22058, 24281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10862, 22058, 24281);
            }
        }
    }
}
