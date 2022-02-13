// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
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
        public void BinaryOperatorOverloadResolution(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, BinaryOperatorOverloadResolutionResult result, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 574, 1184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 897, 965);

                f_10853_897_964(this, kind, left, right, result);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 979, 1063) || true) && (f_10853_983_1003(result.Results) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 979, 1063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1041, 1048);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 979, 1063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1079, 1173);

                f_10853_1079_1172(this, kind, left, right, result, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 574, 1184);

                int
                f_10853_897_964(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                result)
                {
                    this_param.BinaryOperatorOverloadResolution_EasyOut(kind, left, right, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 897, 964);
                    return 0;
                }


                int
                f_10853_983_1003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 983, 1003);
                    return return_v;
                }


                int
                f_10853_1079_1172(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.BinaryOperatorOverloadResolution_NoEasyOut(kind, left, right, result, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 1079, 1172);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 574, 1184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 574, 1184);
            }
        }

        internal void BinaryOperatorOverloadResolution_EasyOut(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, BinaryOperatorOverloadResolutionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 1196, 1973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1392, 1419);

                f_10853_1392_1418(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1433, 1461);

                f_10853_1433_1460(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1475, 1515);

                f_10853_1475_1514(f_10853_1488_1508(result.Results) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1816, 1887);

                BinaryOperatorKind
                underlyingKind = kind & ~BinaryOperatorKind.Logical
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 1903, 1962);

                f_10853_1903_1961(this, underlyingKind, left, right, result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 1196, 1973);

                int
                f_10853_1392_1418(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 1392, 1418);
                    return 0;
                }


                int
                f_10853_1433_1460(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 1433, 1460);
                    return 0;
                }


                int
                f_10853_1488_1508(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 1488, 1508);
                    return return_v;
                }


                int
                f_10853_1475_1514(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 1475, 1514);
                    return 0;
                }


                int
                f_10853_1903_1961(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                result)
                {
                    this_param.BinaryOperatorEasyOut(kind, left, right, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 1903, 1961);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 1196, 1973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 1196, 1973);
            }
        }

        internal void BinaryOperatorOverloadResolution_NoEasyOut(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, BinaryOperatorOverloadResolutionResult result, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 1985, 10552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 2231, 2258);

                f_10853_2231_2257(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 2272, 2300);

                f_10853_2272_2299(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 2314, 2354);

                f_10853_2314_2353(f_10853_2327_2347(result.Results) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 2847, 2908);

                TypeSymbol
                leftOperatorSourceOpt = f_10853_2892_2907(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10853_2882_2891(left), 10853, 2882, 2907))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 2922, 2985);

                TypeSymbol
                rightOperatorSourceOpt = f_10853_2969_2984(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10853_2958_2968(right), 10853, 2958, 2984))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 3022, 3128);

                bool
                leftSourceIsInterface = leftOperatorSourceOpt is not null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 3051, 3127) && f_10853_3088_3127(leftOperatorSourceOpt))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 3142, 3251);

                bool
                rightSourceIsInterface = rightOperatorSourceOpt is not null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 3172, 3250) && f_10853_3210_3250(rightOperatorSourceOpt))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 4980, 5017);

                bool
                hadApplicableCandidates = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5134, 5512) || true) && ((object)leftOperatorSourceOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 5138, 5201) && !leftSourceIsInterface))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 5134, 5512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5235, 5367);

                    hadApplicableCandidates = f_10853_5261_5366(this, kind, leftOperatorSourceOpt, left, right, result.Results, ref useSiteDiagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5385, 5497) || true) && (!hadApplicableCandidates)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 5385, 5497);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5455, 5478);

                        f_10853_5455_5477(result.Results);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 5385, 5497);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 5134, 5512);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5528, 6118) || true) && ((object)rightOperatorSourceOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 5532, 5597) && !rightSourceIsInterface) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 5532, 5654) && !f_10853_5602_5654(rightOperatorSourceOpt, leftOperatorSourceOpt)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 5528, 6118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5688, 5766);

                    var
                    rightOperators = f_10853_5709_5765()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5784, 6061) || true) && (f_10853_5788_5894(this, kind, rightOperatorSourceOpt, left, right, rightOperators, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 5784, 6061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5936, 5967);

                        hadApplicableCandidates = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 5989, 6042);

                        f_10853_5989_6041(result.Results, rightOperators);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 5784, 6061);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6081, 6103);

                    f_10853_6081_6102(
                                    rightOperators);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 5528, 6118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6134, 6203);

                f_10853_6134_6202((f_10853_6148_6168(result.Results) == 0) != hadApplicableCandidates);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6607, 8120) || true) && (!hadApplicableCandidates && (DynAbs.Tracing.TraceSender.Expression_True(10853, 6611, 6688) && kind != BinaryOperatorKind.Equal) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 6611, 6727) && kind != BinaryOperatorKind.NotEqual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 6607, 8120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6761, 6784);

                    f_10853_6761_6783(result.Results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6804, 6873);

                    string
                    name = f_10853_6818_6872(kind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6891, 6965);

                    var
                    lookedInInterfaces = f_10853_6916_6964()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 6985, 7211);

                    hadApplicableCandidates = f_10853_7011_7210(this, kind, name, leftOperatorSourceOpt, leftSourceIsInterface, left, right, ref useSiteDiagnostics, lookedInInterfaces, result.Results);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7229, 7341) || true) && (!hadApplicableCandidates)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 7229, 7341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7299, 7322);

                        f_10853_7299_7321(result.Results);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 7229, 7341);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7361, 8059) || true) && ((object)rightOperatorSourceOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 7365, 7460) && !f_10853_7408_7460(rightOperatorSourceOpt, leftOperatorSourceOpt)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 7361, 8059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7502, 7580);

                        var
                        rightOperators = f_10853_7523_7579()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7602, 7994) || true) && (f_10853_7606_7811(this, kind, name, rightOperatorSourceOpt, rightSourceIsInterface, left, right, ref useSiteDiagnostics, lookedInInterfaces, rightOperators))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 7602, 7994);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7861, 7892);

                            hadApplicableCandidates = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 7918, 7971);

                            f_10853_7918_7970(result.Results, rightOperators);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 7602, 7994);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 8018, 8040);

                        f_10853_8018_8039(
                                            rightOperators);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 7361, 8059);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 8079, 8105);

                    f_10853_8079_8104(
                                    lookedInInterfaces);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 6607, 8120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 9749, 9818);

                f_10853_9749_9817((f_10853_9763_9783(result.Results) == 0) != hadApplicableCandidates);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 9834, 10034) || true) && (!hadApplicableCandidates)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 9834, 10034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 9896, 9919);

                    f_10853_9896_9918(result.Results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 9937, 10019);

                    f_10853_9937_10018(this, kind, left, right, result.Results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 9834, 10034);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 10463, 10541);

                f_10853_10463_10540(this, left, right, result, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 1985, 10552);

                int
                f_10853_2231_2257(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 2231, 2257);
                    return 0;
                }


                int
                f_10853_2272_2299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 2272, 2299);
                    return 0;
                }


                int
                f_10853_2327_2347(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 2327, 2347);
                    return return_v;
                }


                int
                f_10853_2314_2353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 2314, 2353);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_2882_2891(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 2882, 2891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_2892_2907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 2892, 2907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_2958_2968(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 2958, 2968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_2969_2984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 2969, 2984);
                    return return_v;
                }


                bool
                f_10853_3088_3127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 3088, 3127);
                    return return_v;
                }


                bool
                f_10853_3210_3250(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 3210, 3250);
                    return return_v;
                }


                bool
                f_10853_5261_5366(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetUserDefinedOperators(kind, type0, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5261, 5366);
                    return return_v;
                }


                int
                f_10853_5455_5477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5455, 5477);
                    return 0;
                }


                bool
                f_10853_5602_5654(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5602, 5654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10853_5709_5765()
                {
                    var return_v = ArrayBuilder<BinaryOperatorAnalysisResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5709, 5765);
                    return return_v;
                }


                bool
                f_10853_5788_5894(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetUserDefinedOperators(kind, type0, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5788, 5894);
                    return return_v;
                }


                int
                f_10853_5989_6041(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                result, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                additionalOperators)
                {
                    AddDistinctOperators(result, additionalOperators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 5989, 6041);
                    return 0;
                }


                int
                f_10853_6081_6102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 6081, 6102);
                    return 0;
                }


                int
                f_10853_6148_6168(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 6148, 6168);
                    return return_v;
                }


                int
                f_10853_6134_6202(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 6134, 6202);
                    return 0;
                }


                int
                f_10853_6761_6783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 6761, 6783);
                    return 0;
                }


                string
                f_10853_6818_6872(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = OperatorFacts.BinaryOperatorNameFromOperatorKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 6818, 6872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                f_10853_6916_6964()
                {
                    var return_v = PooledDictionary<TypeSymbol, bool>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 6916, 6964);
                    return return_v;
                }


                bool
                f_10853_7011_7210(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                operatorSourceOpt, bool
                sourceIsInterface, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                lookedInInterfaces, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                candidates)
                {
                    var return_v = this_param.GetUserDefinedBinaryOperatorsFromInterfaces(kind, name, operatorSourceOpt, sourceIsInterface, left, right, ref useSiteDiagnostics, (System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>)lookedInInterfaces, candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7011, 7210);
                    return return_v;
                }


                int
                f_10853_7299_7321(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7299, 7321);
                    return 0;
                }


                bool
                f_10853_7408_7460(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7408, 7460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10853_7523_7579()
                {
                    var return_v = ArrayBuilder<BinaryOperatorAnalysisResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7523, 7579);
                    return return_v;
                }


                bool
                f_10853_7606_7811(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                operatorSourceOpt, bool
                sourceIsInterface, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                lookedInInterfaces, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                candidates)
                {
                    var return_v = this_param.GetUserDefinedBinaryOperatorsFromInterfaces(kind, name, operatorSourceOpt, sourceIsInterface, left, right, ref useSiteDiagnostics, (System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>)lookedInInterfaces, candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7606, 7811);
                    return return_v;
                }


                int
                f_10853_7918_7970(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                result, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                additionalOperators)
                {
                    AddDistinctOperators(result, additionalOperators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 7918, 7970);
                    return 0;
                }


                int
                f_10853_8018_8039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 8018, 8039);
                    return 0;
                }


                int
                f_10853_8079_8104(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 8079, 8104);
                    return 0;
                }


                int
                f_10853_9763_9783(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 9763, 9783);
                    return return_v;
                }


                int
                f_10853_9749_9817(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 9749, 9817);
                    return 0;
                }


                int
                f_10853_9896_9918(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 9896, 9918);
                    return 0;
                }


                int
                f_10853_9937_10018(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllBuiltInOperators(kind, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 9937, 10018);
                    return 0;
                }


                int
                f_10853_10463_10540(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                result, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.BinaryOperatorOverloadResolution(left, right, result, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 10463, 10540);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 1985, 10552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 1985, 10552);
            }
        }

        private bool GetUserDefinedBinaryOperatorsFromInterfaces(BinaryOperatorKind kind, string name,
                    TypeSymbol operatorSourceOpt, bool sourceIsInterface,
                    BoundExpression left, BoundExpression right, ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    Dictionary<TypeSymbol, bool> lookedInInterfaces, ArrayBuilder<BinaryOperatorAnalysisResult> candidates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 10564, 15144);
                bool hadUserDefinedCandidate = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 10973, 11009);

                f_10853_10973_11008(f_10853_10986_11002(candidates) == 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11025, 11124) || true) && ((object)operatorSourceOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 11025, 11124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11096, 11109);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 11025, 11124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11140, 11191);

                bool
                hadUserDefinedCandidateFromInterfaces = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11205, 11258);

                ImmutableArray<NamedTypeSymbol>
                interfaces = default
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11274, 12571) || true) && (sourceIsInterface)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 11274, 12571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11331, 12316) || true) && (!f_10853_11336_11392(lookedInInterfaces, operatorSourceOpt, out _))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 11331, 12316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11434, 11502);

                        var
                        operators = f_10853_11450_11501()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11524, 11621);

                        f_10853_11524_11620(this, operatorSourceOpt, kind, name, operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11643, 11762);

                        hadUserDefinedCandidateFromInterfaces = f_10853_11683_11761(this, operators, left, right, candidates, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11784, 11801);

                        f_10853_11784_11800(operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11823, 11909);

                        f_10853_11823_11908(hadUserDefinedCandidateFromInterfaces == f_10853_11877_11907(candidates, r => r.IsValid));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 11933, 12014);

                        f_10853_11933_12013(
                                            lookedInInterfaces, operatorSourceOpt, hadUserDefinedCandidateFromInterfaces);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12036, 12297) || true) && (!hadUserDefinedCandidateFromInterfaces)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 12036, 12297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12128, 12147);

                            f_10853_12128_12146(candidates);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12173, 12274);

                            interfaces = f_10853_12186_12273(operatorSourceOpt, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 12036, 12297);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 11331, 12316);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 11274, 12571);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 11274, 12571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12350, 12571) || true) && (f_10853_12354_12389(operatorSourceOpt))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 12350, 12571);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12423, 12556);

                        interfaces = f_10853_12436_12555(((TypeParameterSymbol)operatorSourceOpt), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 12350, 12571);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 11274, 12571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12587, 15072) || true) && (f_10853_12591_12619_M(!interfaces.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 12587, 15072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12653, 12721);

                    var
                    operators = f_10853_12669_12720()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12739, 12810);

                    var
                    results = f_10853_12753_12809()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12828, 12898);

                    var
                    shadowedInterfaces = f_10853_12853_12897()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 12918, 14943);
                        foreach (NamedTypeSymbol @interface in f_10853_12957_12967_I(interfaces))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 12918, 14943);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13009, 13195) || true) && (f_10853_13013_13036_M(!@interface.IsInterface))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 13009, 13195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13163, 13172);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 13009, 13195);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13219, 13424) || true) && (f_10853_13223_13262(shadowedInterfaces, @interface))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 13219, 13424);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13392, 13401);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 13219, 13424);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13448, 14019) || true) && (f_10853_13452_13528(lookedInInterfaces, @interface, out hadUserDefinedCandidate))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 13448, 14019);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13578, 13879) || true) && (hadUserDefinedCandidate)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 13578, 13879);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13744, 13852);

                                    shadowedInterfaces.AddAll(f_10853_13770_13850(@interface, ref useSiteDiagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 13578, 13879);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 13987, 13996);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 13448, 14019);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14043, 14061);

                            f_10853_14043_14060(
                                                operators);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14083, 14099);

                            f_10853_14083_14098(results);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14121, 14194);

                            f_10853_14121_14193(this, @interface, kind, name, operators);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14216, 14318);

                            hadUserDefinedCandidate = f_10853_14242_14317(this, operators, left, right, results, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14340, 14409);

                            f_10853_14340_14408(hadUserDefinedCandidate == f_10853_14380_14407(results, r => r.IsValid));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14431, 14491);

                            f_10853_14431_14490(lookedInInterfaces, @interface, hadUserDefinedCandidate);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14513, 14924) || true) && (hadUserDefinedCandidate)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 14513, 14924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14590, 14635);

                                hadUserDefinedCandidateFromInterfaces = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14661, 14690);

                                f_10853_14661_14689(candidates, results);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14793, 14901);

                                shadowedInterfaces.AddAll(f_10853_14819_14899(@interface, ref useSiteDiagnostics));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 14513, 14924);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 12918, 14943);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 2026);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 2026);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14963, 14980);

                    f_10853_14963_14979(
                                    operators);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 14998, 15013);

                    f_10853_14998_15012(results);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 15031, 15057);

                    f_10853_15031_15056(shadowedInterfaces);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 12587, 15072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 15088, 15133);

                return hadUserDefinedCandidateFromInterfaces;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 10564, 15144);

                int
                f_10853_10986_11002(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 10986, 11002);
                    return return_v;
                }


                int
                f_10853_10973_11008(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 10973, 11008);
                    return 0;
                }


                bool
                f_10853_11336_11392(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11336, 11392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                f_10853_11450_11501()
                {
                    var return_v = ArrayBuilder<BinaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11450, 11501);
                    return return_v;
                }


                int
                f_10853_11524_11620(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetUserDefinedBinaryOperatorsFromType((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, kind, name, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11524, 11620);
                    return 0;
                }


                bool
                f_10853_11683_11761(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11683, 11761);
                    return return_v;
                }


                int
                f_10853_11784_11800(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11784, 11800);
                    return 0;
                }


                bool
                f_10853_11877_11907(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11877, 11907);
                    return return_v;
                }


                int
                f_10853_11823_11908(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11823, 11908);
                    return 0;
                }


                int
                f_10853_11933_12013(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                key, bool
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 11933, 12013);
                    return 0;
                }


                int
                f_10853_12128_12146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12128, 12146);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_12186_12273(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12186, 12273);
                    return return_v;
                }


                bool
                f_10853_12354_12389(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12354, 12389);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_12436_12555(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12436, 12555);
                    return return_v;
                }


                bool
                f_10853_12591_12619_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 12591, 12619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                f_10853_12669_12720()
                {
                    var return_v = ArrayBuilder<BinaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12669, 12720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10853_12753_12809()
                {
                    var return_v = ArrayBuilder<BinaryOperatorAnalysisResult>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12753, 12809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_12853_12897()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12853, 12897);
                    return return_v;
                }


                bool
                f_10853_13013_13036_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 13013, 13036);
                    return return_v;
                }


                bool
                f_10853_13223_13262(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 13223, 13262);
                    return return_v;
                }


                bool
                f_10853_13452_13528(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out bool
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 13452, 13528);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_13770_13850(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 13770, 13850);
                    return return_v;
                }


                int
                f_10853_14043_14060(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14043, 14060);
                    return 0;
                }


                int
                f_10853_14083_14098(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14083, 14098);
                    return 0;
                }


                int
                f_10853_14121_14193(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetUserDefinedBinaryOperatorsFromType(type, kind, name, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14121, 14193);
                    return 0;
                }


                bool
                f_10853_14242_14317(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14242, 14317);
                    return return_v;
                }


                bool
                f_10853_14380_14407(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14380, 14407);
                    return return_v;
                }


                int
                f_10853_14340_14408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14340, 14408);
                    return 0;
                }


                int
                f_10853_14431_14490(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol, bool>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, bool
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14431, 14490);
                    return 0;
                }


                int
                f_10853_14661_14689(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14661, 14689);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_14819_14899(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14819, 14899);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10853_12957_12967_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 12957, 12967);
                    return return_v;
                }


                int
                f_10853_14963_14979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14963, 14979);
                    return 0;
                }


                int
                f_10853_14998_15012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 14998, 15012);
                    return 0;
                }


                int
                f_10853_15031_15056(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15031, 15056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 10564, 15144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 10564, 15144);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddDelegateOperation(BinaryOperatorKind kind, TypeSymbol delegateType,
                    ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 15156, 15996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 15326, 15985);

                switch (kind)
                {

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 15326, 15985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 15475, 15638);

                        f_10853_15475_15637(operators, f_10853_15489_15636(kind | BinaryOperatorKind.Delegate, delegateType, delegateType, f_10853_15581_15635(f_10853_15581_15592(), SpecialType.System_Boolean)));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 15660, 15666);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 15326, 15985);

                    case BinaryOperatorKind.Addition:
                    case BinaryOperatorKind.Subtraction:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 15326, 15985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 15821, 15942);

                        f_10853_15821_15941(operators, f_10853_15835_15940(kind | BinaryOperatorKind.Delegate, delegateType, delegateType, delegateType));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 15964, 15970);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 15326, 15985);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 15156, 15996);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_15581_15592()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 15581, 15592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_15581_15635(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15581, 15635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_15489_15636(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15489, 15636);
                    return return_v;
                }


                int
                f_10853_15475_15637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15475, 15637);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_15835_15940(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15835, 15940);
                    return return_v;
                }


                int
                f_10853_15821_15941(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 15821, 15941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 15156, 15996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 15156, 15996);
            }
        }

        private void GetDelegateOperations(BinaryOperatorKind kind, BoundExpression left, BoundExpression right,
                    ArrayBuilder<BinaryOperatorSignature> operators, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 16008, 22619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 16247, 16274);

                f_10853_16247_16273(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 16288, 16316);

                f_10853_16288_16315(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 16330, 16353);

                f_10853_16330_16352(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 16369, 17575);

                switch (kind)
                {

                    case BinaryOperatorKind.Multiplication:
                    case BinaryOperatorKind.Division:
                    case BinaryOperatorKind.Remainder:
                    case BinaryOperatorKind.RightShift:
                    case BinaryOperatorKind.LeftShift:
                    case BinaryOperatorKind.And:
                    case BinaryOperatorKind.Or:
                    case BinaryOperatorKind.Xor:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                    case BinaryOperatorKind.LessThanOrEqual:
                    case BinaryOperatorKind.LogicalAnd:
                    case BinaryOperatorKind.LogicalOr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 16369, 17575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17150, 17157);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 16369, 17575);

                    case BinaryOperatorKind.Addition:
                    case BinaryOperatorKind.Subtraction:
                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 16369, 17575);
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 17385, 17391);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 16369, 17575);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 16369, 17575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17513, 17560);

                        throw f_10853_17519_17559(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 16369, 17575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17591, 17616);

                var
                leftType = f_10853_17606_17615(left)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17630, 17703);

                var
                leftDelegate = (object)leftType != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 17649, 17702) && f_10853_17677_17702(leftType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17717, 17744);

                var
                rightType = f_10853_17733_17743(right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17758, 17834);

                var
                rightDelegate = (object)rightType != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 17778, 17833) && f_10853_17807_17833(rightType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 17919, 19350) || true) && (!leftDelegate && (DynAbs.Tracing.TraceSender.Expression_True(10853, 17923, 17954) && !rightDelegate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 17919, 19350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 18487, 19308);

                    switch (f_10853_18495_18532(kind))
                    {

                        case BinaryOperatorKind.Equal:
                        case BinaryOperatorKind.NotEqual:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 18487, 19308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 18685, 18826);

                            TypeSymbol
                            systemDelegateType = f_10853_18717_18825(_binder, SpecialType.System_Delegate, f_10853_18769_18811(f_10853_18769_18788(_binder)), left.Syntax)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 18854, 19255) || true) && (f_10853_18858_18960(f_10853_18858_18869(), left, systemDelegateType, ref useSiteDiagnostics).IsValid && (DynAbs.Tracing.TraceSender.Expression_True(10853, 18858, 19112) && f_10853_19001_19104(f_10853_19001_19012(), right, systemDelegateType, ref useSiteDiagnostics).IsValid))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 18854, 19255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 19170, 19228);

                                f_10853_19170_19227(this, kind, systemDelegateType, operators);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 18854, 19255);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10853, 19283, 19289);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 18487, 19308);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 19328, 19335);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 17919, 19350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 21248, 22116) || true) && (leftDelegate && (DynAbs.Tracing.TraceSender.Expression_True(10853, 21252, 21281) && rightDelegate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 21248, 22116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 21408, 21456);

                    f_10853_21408_21455(this, kind, leftType, operators);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 21729, 21830);

                    bool
                    useIdentityConversion = kind == BinaryOperatorKind.Equal || (DynAbs.Tracing.TraceSender.Expression_False(10853, 21758, 21829) || kind == BinaryOperatorKind.NotEqual)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 21850, 22074) || true) && (!((DynAbs.Tracing.TraceSender.Conditional_F1(10853, 21856, 21877) || ((useIdentityConversion && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 21880, 21934)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 21937, 21963))) ? f_10853_21880_21934(leftType, rightType) : f_10853_21937_21963(leftType, rightType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 21850, 22074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22006, 22055);

                        f_10853_22006_22054(this, kind, rightType, operators);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 21850, 22074);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22094, 22101);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 21248, 22116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22193, 22255);

                TypeSymbol
                delegateType = (DynAbs.Tracing.TraceSender.Conditional_F1(10853, 22219, 22231) || ((leftDelegate && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 22234, 22242)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 22245, 22254))) ? leftType : rightType
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22269, 22327);

                BoundExpression
                nonDelegate = (DynAbs.Tracing.TraceSender.Conditional_F1(10853, 22299, 22311) || ((leftDelegate && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 22314, 22319)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 22322, 22326))) ? right : left
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22343, 22540) || true) && ((kind == BinaryOperatorKind.Equal || (DynAbs.Tracing.TraceSender.Expression_False(10853, 22348, 22419) || kind == BinaryOperatorKind.NotEqual))
                && (DynAbs.Tracing.TraceSender.Expression_True(10853, 22347, 22484) && f_10853_22441_22457(nonDelegate) == BoundKind.UnboundLambda))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 22343, 22540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22518, 22525);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 22343, 22540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22556, 22608);

                f_10853_22556_22607(this, kind, delegateType, operators);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 16008, 22619);

                int
                f_10853_16247_16273(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 16247, 16273);
                    return 0;
                }


                int
                f_10853_16288_16315(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 16288, 16315);
                    return 0;
                }


                int
                f_10853_16330_16352(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    AssertNotChecked(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 16330, 16352);
                    return 0;
                }


                System.Exception
                f_10853_17519_17559(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 17519, 17559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_17606_17615(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 17606, 17615);
                    return return_v;
                }


                bool
                f_10853_17677_17702(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 17677, 17702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_17733_17743(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 17733, 17743);
                    return return_v;
                }


                bool
                f_10853_17807_17833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 17807, 17833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10853_18495_18532(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 18495, 18532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_18769_18788(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 18769, 18788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10853_18769_18811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.DeclarationDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 18769, 18811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_18717_18825(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 18717, 18825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10853_18858_18869()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 18858, 18869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10853_18858_18960(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 18858, 18960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10853_19001_19012()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 19001, 19012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10853_19001_19104(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 19001, 19104);
                    return return_v;
                }


                int
                f_10853_19170_19227(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.AddDelegateOperation(kind, delegateType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 19170, 19227);
                    return 0;
                }


                int
                f_10853_21408_21455(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                delegateType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.AddDelegateOperation(kind, delegateType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 21408, 21455);
                    return 0;
                }


                bool
                f_10853_21880_21934(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 21880, 21934);
                    return return_v;
                }


                bool
                f_10853_21937_21963(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                obj)
                {
                    var return_v = this_param.Equals((object?)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 21937, 21963);
                    return return_v;
                }


                int
                f_10853_22006_22054(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                delegateType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.AddDelegateOperation(kind, delegateType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 22006, 22054);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10853_22441_22457(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 22441, 22457);
                    return return_v;
                }


                int
                f_10853_22556_22607(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                delegateType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.AddDelegateOperation(kind, delegateType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 22556, 22607);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 16008, 22619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 16008, 22619);
            }
        }

        private void GetEnumOperation(BinaryOperatorKind kind, TypeSymbol enumType, BoundExpression left, BoundExpression right, ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 22631, 28226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22825, 22864);

                f_10853_22825_22863((object)enumType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22878, 22901);

                f_10853_22878_22900(kind);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22917, 23004) || true) && (!f_10853_22922_22948(enumType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 22917, 23004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 22982, 22989);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 22917, 23004);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23020, 23070);

                var
                underlying = f_10853_23037_23069(enumType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23084, 23125);

                f_10853_23084_23124((object)underlying != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23139, 23196);

                f_10853_23139_23195(f_10853_23152_23174(underlying) != SpecialType.None);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23212, 23285);

                var
                nullable = f_10853_23227_23284(f_10853_23227_23238(), SpecialType.System_Nullable_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23299, 23347);

                var
                nullableEnum = f_10853_23318_23346(nullable, enumType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23361, 23417);

                var
                nullableUnderlying = f_10853_23386_23416(nullable, underlying)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23433, 28215);

                switch (kind)
                {

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 23433, 28215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23534, 23655);

                        f_10853_23534_23654(operators, f_10853_23548_23653(BinaryOperatorKind.EnumAndUnderlyingAddition, enumType, underlying, enumType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23677, 23798);

                        f_10853_23677_23797(operators, f_10853_23691_23796(BinaryOperatorKind.UnderlyingAndEnumAddition, underlying, enumType, enumType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23820, 23963);

                        f_10853_23820_23962(operators, f_10853_23834_23961(BinaryOperatorKind.LiftedEnumAndUnderlyingAddition, nullableEnum, nullableUnderlying, nullableEnum));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 23985, 24128);

                        f_10853_23985_24127(operators, f_10853_23999_24126(BinaryOperatorKind.LiftedUnderlyingAndEnumAddition, nullableUnderlying, nullableEnum, nullableEnum));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 24150, 24156);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 23433, 28215);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 23433, 28215);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 24232, 26983) || true) && (f_10853_24236_24242())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 24232, 26983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 24292, 24403);

                            f_10853_24292_24402(operators, f_10853_24306_24401(BinaryOperatorKind.EnumSubtraction, enumType, enumType, underlying));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 24429, 24553);

                            f_10853_24429_24552(operators, f_10853_24443_24551(BinaryOperatorKind.EnumAndUnderlyingSubtraction, enumType, underlying, enumType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 24579, 24712);

                            f_10853_24579_24711(operators, f_10853_24593_24710(BinaryOperatorKind.LiftedEnumSubtraction, nullableEnum, nullableEnum, nullableUnderlying));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 24738, 24884);

                            f_10853_24738_24883(operators, f_10853_24752_24882(BinaryOperatorKind.LiftedEnumAndUnderlyingSubtraction, nullableEnum, nullableUnderlying, nullableEnum));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 24232, 26983);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 24232, 26983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 25477, 25598);

                            bool
                            isExactSubtraction = f_10853_25503_25597(f_10853_25532_25547(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10853_25521_25531(right), 10853, 25521, 25547)), underlying, TypeCompareKind.ConsiderEverything2)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 25624, 25777);

                            f_10853_25624_25776(operators, new BinaryOperatorSignature(BinaryOperatorKind.EnumSubtraction, enumType, enumType, underlying)
                            { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 2, 10853, 25638, 25775) });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 25803, 25994);

                            f_10853_25803_25993(operators, new BinaryOperatorSignature(BinaryOperatorKind.EnumAndUnderlyingSubtraction, enumType, underlying, enumType)
                            { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(10853, 25964, 25982) || ((isExactSubtraction && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 25985, 25986)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 25989, 25990))) ? 1 : 3, 10853, 25817, 25992) });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 26020, 26196);

                            f_10853_26020_26195(operators, new BinaryOperatorSignature(BinaryOperatorKind.LiftedEnumSubtraction, nullableEnum, nullableEnum, nullableUnderlying)
                            { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 12, 10853, 26034, 26194) });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 26222, 26437);

                            f_10853_26222_26436(operators, new BinaryOperatorSignature(BinaryOperatorKind.LiftedEnumAndUnderlyingSubtraction, nullableEnum, nullableUnderlying, nullableEnum)
                            { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(10853, 26405, 26423) || ((isExactSubtraction && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 26426, 26428)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 26431, 26433))) ? 11 : 13, 10853, 26236, 26435) });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 26579, 26745);

                            f_10853_26579_26744(
                                                    // Due to a bug, the native compiler allows "underlying - enum", so Roslyn does as well.
                                                    operators, new BinaryOperatorSignature(BinaryOperatorKind.UnderlyingAndEnumSubtraction, underlying, enumType, enumType)
                                                    { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 4, 10853, 26593, 26743) });
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 26771, 26960);

                            f_10853_26771_26959(operators, new BinaryOperatorSignature(BinaryOperatorKind.LiftedUnderlyingAndEnumSubtraction, nullableUnderlying, nullableEnum, nullableEnum)
                            { Priority = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => 14, 10853, 26785, 26958) });
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 24232, 26983);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 27005, 27011);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 23433, 28215);

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 23433, 28215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 27356, 27425);

                        var
                        boolean = f_10853_27370_27424(f_10853_27370_27381(), SpecialType.System_Boolean)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 27447, 27551);

                        f_10853_27447_27550(operators, f_10853_27461_27549(kind | BinaryOperatorKind.Enum, enumType, enumType, boolean));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 27573, 27713);

                        f_10853_27573_27712(operators, f_10853_27587_27711(kind | BinaryOperatorKind.Lifted | BinaryOperatorKind.Enum, nullableEnum, nullableEnum, boolean));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 27735, 27741);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 23433, 28215);

                    case BinaryOperatorKind.And:
                    case BinaryOperatorKind.Or:
                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 23433, 28215);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 27900, 28005);

                        f_10853_27900_28004(operators, f_10853_27914_28003(kind | BinaryOperatorKind.Enum, enumType, enumType, enumType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28027, 28172);

                        f_10853_28027_28171(operators, f_10853_28041_28170(kind | BinaryOperatorKind.Lifted | BinaryOperatorKind.Enum, nullableEnum, nullableEnum, nullableEnum));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 28194, 28200);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 23433, 28215);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 22631, 28226);

                int
                f_10853_22825_22863(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 22825, 22863);
                    return 0;
                }


                int
                f_10853_22878_22900(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    AssertNotChecked(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 22878, 22900);
                    return 0;
                }


                bool
                f_10853_22922_22948(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 22922, 22948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10853_23037_23069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23037, 23069);
                    return return_v;
                }


                int
                f_10853_23084_23124(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23084, 23124);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10853_23152_23174(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 23152, 23174);
                    return return_v;
                }


                int
                f_10853_23139_23195(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23139, 23195);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_23227_23238()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 23227, 23238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_23227_23284(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23227, 23284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_23318_23346(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23318, 23346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_23386_23416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23386, 23416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_23548_23653(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23548, 23653);
                    return return_v;
                }


                int
                f_10853_23534_23654(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23534, 23654);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_23691_23796(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, rightType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23691, 23796);
                    return return_v;
                }


                int
                f_10853_23677_23797(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23677, 23797);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_23834_23961(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23834, 23961);
                    return return_v;
                }


                int
                f_10853_23820_23962(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23820, 23962);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_23999_24126(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23999, 24126);
                    return return_v;
                }


                int
                f_10853_23985_24127(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 23985, 24127);
                    return 0;
                }


                bool
                f_10853_24236_24242()
                {
                    var return_v = Strict;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 24236, 24242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_24306_24401(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24306, 24401);
                    return return_v;
                }


                int
                f_10853_24292_24402(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24292, 24402);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_24443_24551(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24443, 24551);
                    return return_v;
                }


                int
                f_10853_24429_24552(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24429, 24552);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_24593_24710(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24593, 24710);
                    return return_v;
                }


                int
                f_10853_24579_24711(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24579, 24711);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_24752_24882(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24752, 24882);
                    return return_v;
                }


                int
                f_10853_24738_24883(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 24738, 24883);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_25521_25531(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 25521, 25531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_25532_25547(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 25532, 25547);
                    return return_v;
                }


                bool
                f_10853_25503_25597(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 25503, 25597);
                    return return_v;
                }


                int
                f_10853_25624_25776(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 25624, 25776);
                    return 0;
                }


                int
                f_10853_25803_25993(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 25803, 25993);
                    return 0;
                }


                int
                f_10853_26020_26195(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 26020, 26195);
                    return 0;
                }


                int
                f_10853_26222_26436(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 26222, 26436);
                    return 0;
                }


                int
                f_10853_26579_26744(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 26579, 26744);
                    return 0;
                }


                int
                f_10853_26771_26959(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 26771, 26959);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_27370_27381()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 27370, 27381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_27370_27424(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27370, 27424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_27461_27549(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27461, 27549);
                    return return_v;
                }


                int
                f_10853_27447_27550(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27447, 27550);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_27587_27711(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27587, 27711);
                    return return_v;
                }


                int
                f_10853_27573_27712(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27573, 27712);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_27914_28003(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27914, 28003);
                    return return_v;
                }


                int
                f_10853_27900_28004(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 27900, 28004);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_28041_28170(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28041, 28170);
                    return return_v;
                }


                int
                f_10853_28027_28171(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28027, 28171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 22631, 28226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 22631, 28226);
            }
        }

        private void GetPointerArithmeticOperators(
                    BinaryOperatorKind kind,
                    PointerTypeSymbol pointerType,
                    ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 28238, 31218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28450, 28492);

                f_10853_28450_28491((object)pointerType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28506, 28529);

                f_10853_28506_28528(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28545, 31207);

                switch (kind)
                {

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 28545, 31207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28646, 28811);

                        f_10853_28646_28810(operators, f_10853_28660_28809(BinaryOperatorKind.PointerAndIntAddition, pointerType, f_10853_28743_28795(f_10853_28743_28754(), SpecialType.System_Int32), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 28833, 29000);

                        f_10853_28833_28999(operators, f_10853_28847_28998(BinaryOperatorKind.PointerAndUIntAddition, pointerType, f_10853_28931_28984(f_10853_28931_28942(), SpecialType.System_UInt32), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29022, 29188);

                        f_10853_29022_29187(operators, f_10853_29036_29186(BinaryOperatorKind.PointerAndLongAddition, pointerType, f_10853_29120_29172(f_10853_29120_29131(), SpecialType.System_Int64), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29210, 29378);

                        f_10853_29210_29377(operators, f_10853_29224_29376(BinaryOperatorKind.PointerAndULongAddition, pointerType, f_10853_29309_29362(f_10853_29309_29320(), SpecialType.System_UInt64), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29400, 29565);

                        f_10853_29400_29564(operators, f_10853_29414_29563(BinaryOperatorKind.IntAndPointerAddition, f_10853_29484_29536(f_10853_29484_29495(), SpecialType.System_Int32), pointerType, pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29587, 29754);

                        f_10853_29587_29753(operators, f_10853_29601_29752(BinaryOperatorKind.UIntAndPointerAddition, f_10853_29672_29725(f_10853_29672_29683(), SpecialType.System_UInt32), pointerType, pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29776, 29942);

                        f_10853_29776_29941(operators, f_10853_29790_29940(BinaryOperatorKind.LongAndPointerAddition, f_10853_29861_29913(f_10853_29861_29872(), SpecialType.System_Int64), pointerType, pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 29964, 30132);

                        f_10853_29964_30131(operators, f_10853_29978_30130(BinaryOperatorKind.ULongAndPointerAddition, f_10853_30050_30103(f_10853_30050_30061(), SpecialType.System_UInt64), pointerType, pointerType));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 30154, 30160);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 28545, 31207);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 28545, 31207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 30236, 30404);

                        f_10853_30236_30403(operators, f_10853_30250_30402(BinaryOperatorKind.PointerAndIntSubtraction, pointerType, f_10853_30336_30388(f_10853_30336_30347(), SpecialType.System_Int32), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 30426, 30596);

                        f_10853_30426_30595(operators, f_10853_30440_30594(BinaryOperatorKind.PointerAndUIntSubtraction, pointerType, f_10853_30527_30580(f_10853_30527_30538(), SpecialType.System_UInt32), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 30618, 30787);

                        f_10853_30618_30786(operators, f_10853_30632_30785(BinaryOperatorKind.PointerAndLongSubtraction, pointerType, f_10853_30719_30771(f_10853_30719_30730(), SpecialType.System_Int64), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 30809, 30980);

                        f_10853_30809_30979(operators, f_10853_30823_30978(BinaryOperatorKind.PointerAndULongSubtraction, pointerType, f_10853_30911_30964(f_10853_30911_30922(), SpecialType.System_UInt64), pointerType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 31002, 31164);

                        f_10853_31002_31163(operators, f_10853_31016_31162(BinaryOperatorKind.PointerSubtraction, pointerType, pointerType, f_10853_31109_31161(f_10853_31109_31120(), SpecialType.System_Int64)));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 31186, 31192);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 28545, 31207);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 28238, 31218);

                int
                f_10853_28450_28491(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28450, 28491);
                    return 0;
                }


                int
                f_10853_28506_28528(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    AssertNotChecked(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28506, 28528);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_28743_28754()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 28743, 28754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_28743_28795(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28743, 28795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_28660_28809(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28660, 28809);
                    return return_v;
                }


                int
                f_10853_28646_28810(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28646, 28810);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_28931_28942()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 28931, 28942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_28931_28984(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28931, 28984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_28847_28998(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28847, 28998);
                    return return_v;
                }


                int
                f_10853_28833_28999(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 28833, 28999);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_29120_29131()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 29120, 29131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_29120_29172(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29120, 29172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29036_29186(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29036, 29186);
                    return return_v;
                }


                int
                f_10853_29022_29187(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29022, 29187);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_29309_29320()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 29309, 29320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_29309_29362(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29309, 29362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29224_29376(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29224, 29376);
                    return return_v;
                }


                int
                f_10853_29210_29377(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29210, 29377);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_29484_29495()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 29484, 29495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_29484_29536(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29484, 29536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29414_29563(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29414, 29563);
                    return return_v;
                }


                int
                f_10853_29400_29564(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29400, 29564);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_29672_29683()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 29672, 29683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_29672_29725(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29672, 29725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29601_29752(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29601, 29752);
                    return return_v;
                }


                int
                f_10853_29587_29753(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29587, 29753);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_29861_29872()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 29861, 29872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_29861_29913(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29861, 29913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29790_29940(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29790, 29940);
                    return return_v;
                }


                int
                f_10853_29776_29941(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29776, 29941);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_30050_30061()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 30050, 30061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_30050_30103(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30050, 30103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_29978_30130(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29978, 30130);
                    return return_v;
                }


                int
                f_10853_29964_30131(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 29964, 30131);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_30336_30347()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 30336, 30347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_30336_30388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30336, 30388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_30250_30402(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30250, 30402);
                    return return_v;
                }


                int
                f_10853_30236_30403(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30236, 30403);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_30527_30538()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 30527, 30538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_30527_30580(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30527, 30580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_30440_30594(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30440, 30594);
                    return return_v;
                }


                int
                f_10853_30426_30595(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30426, 30595);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_30719_30730()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 30719, 30730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_30719_30771(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30719, 30771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_30632_30785(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30632, 30785);
                    return return_v;
                }


                int
                f_10853_30618_30786(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30618, 30786);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_30911_30922()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 30911, 30922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_30911_30964(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30911, 30964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_30823_30978(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30823, 30978);
                    return return_v;
                }


                int
                f_10853_30809_30979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 30809, 30979);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_31109_31120()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 31109, 31120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_31109_31161(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31109, 31161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_31016_31162(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31016, 31162);
                    return return_v;
                }


                int
                f_10853_31002_31163(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31002, 31163);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 28238, 31218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 28238, 31218);
            }
        }

        private void GetPointerComparisonOperators(
                    BinaryOperatorKind kind,
                    ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 31230, 32140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 31398, 32129);

                switch (kind)
                {

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 31398, 32129);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 31771, 31896);

                        var
                        voidPointerType = f_10853_31793_31895(TypeWithAnnotations.Create(f_10853_31842_31893(f_10853_31842_31853(), SpecialType.System_Void)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 31918, 32086);

                        f_10853_31918_32085(operators, f_10853_31932_32084(kind | BinaryOperatorKind.Pointer, voidPointerType, voidPointerType, f_10853_32029_32083(f_10853_32029_32040(), SpecialType.System_Boolean)));
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 32108, 32114);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 31398, 32129);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 31230, 32140);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_31842_31853()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 31842, 31853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_31842_31893(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31842, 31893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                f_10853_31793_31895(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                pointedAtType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31793, 31895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_32029_32040()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 32029, 32040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_32029_32083(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 32029, 32083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_31932_32084(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31932, 32084);
                    return return_v;
                }


                int
                f_10853_31918_32085(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 31918, 32085);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 31230, 32140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 31230, 32140);
            }
        }

        private void GetEnumOperations(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, ArrayBuilder<BinaryOperatorSignature> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 32152, 35862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32324, 32351);

                f_10853_32324_32350(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32365, 32393);

                f_10853_32365_32392(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32407, 32430);

                f_10853_32407_32429(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32489, 32931);

                switch (kind)
                {

                    case BinaryOperatorKind.Multiplication:
                    case BinaryOperatorKind.Division:
                    case BinaryOperatorKind.Remainder:
                    case BinaryOperatorKind.RightShift:
                    case BinaryOperatorKind.LeftShift:
                    case BinaryOperatorKind.LogicalAnd:
                    case BinaryOperatorKind.LogicalOr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 32489, 32931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32909, 32916);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 32489, 32931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32947, 32972);

                var
                leftType = f_10853_32962_32971(left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 32986, 33098) || true) && ((object)leftType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 32986, 33098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33048, 33083);

                    leftType = f_10853_33059_33082(leftType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 32986, 33098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33114, 33141);

                var
                rightType = f_10853_33130_33140(right)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33155, 33270) || true) && ((object)rightType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33155, 33270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33218, 33255);

                    rightType = f_10853_33230_33254(rightType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33155, 33270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33286, 33313);

                bool
                useIdentityConversion
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33327, 35409);

                switch (kind)
                {

                    case BinaryOperatorKind.And:
                    case BinaryOperatorKind.Or:
                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33327, 35409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 33778, 33808);

                        useIdentityConversion = false;
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 33830, 33836);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33327, 35409);

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33327, 35409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 34149, 34178);

                        useIdentityConversion = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 34200, 34206);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33327, 35409);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33327, 35409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 34558, 34587);

                        useIdentityConversion = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 34609, 34615);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33327, 35409);

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33327, 35409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35171, 35200);

                        useIdentityConversion = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10853, 35222, 35228);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33327, 35409);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 33327, 35409);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35347, 35394);

                        throw f_10853_35353_35393(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 33327, 35409);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35425, 35557) || true) && ((object)leftType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 35425, 35557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35487, 35542);

                    f_10853_35487_35541(this, kind, leftType, left, right, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 35425, 35557);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35573, 35851) || true) && ((object)rightType != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 35577, 35746) && ((object)leftType == null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 35607, 35745) || !((DynAbs.Tracing.TraceSender.Conditional_F1(10853, 35637, 35658) || ((useIdentityConversion && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 35661, 35715)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 35718, 35744))) ? f_10853_35661_35715(rightType, leftType) : f_10853_35718_35744(rightType, leftType))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 35573, 35851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 35780, 35836);

                    f_10853_35780_35835(this, kind, rightType, left, right, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 35573, 35851);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 32152, 35862);

                int
                f_10853_32324_32350(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 32324, 32350);
                    return 0;
                }


                int
                f_10853_32365_32392(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 32365, 32392);
                    return 0;
                }


                int
                f_10853_32407_32429(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    AssertNotChecked(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 32407, 32429);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_32962_32971(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 32962, 32971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_33059_33082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 33059, 33082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_33130_33140(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 33130, 33140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_33230_33254(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 33230, 33254);
                    return return_v;
                }


                System.Exception
                f_10853_35353_35393(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 35353, 35393);
                    return return_v;
                }


                int
                f_10853_35487_35541(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                enumType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetEnumOperation(kind, enumType, left, right, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 35487, 35541);
                    return 0;
                }


                bool
                f_10853_35661_35715(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 35661, 35715);
                    return return_v;
                }


                bool
                f_10853_35718_35744(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 35718, 35744);
                    return return_v;
                }


                int
                f_10853_35780_35835(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                enumType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetEnumOperation(kind, enumType, left, right, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 35780, 35835);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 32152, 35862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 32152, 35862);
            }
        }

        private void GetPointerOperators(
                    BinaryOperatorKind kind,
                    BoundExpression left,
                    BoundExpression right,
                    ArrayBuilder<BinaryOperatorSignature> results)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 35874, 37342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36101, 36128);

                f_10853_36101_36127(left != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36142, 36170);

                f_10853_36142_36169(right != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36184, 36207);

                f_10853_36184_36206(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36223, 36269);

                var
                leftType = f_10853_36238_36247(left) as PointerTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36283, 36331);

                var
                rightType = f_10853_36299_36309(right) as PointerTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36347, 36479) || true) && ((object)leftType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 36347, 36479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36409, 36464);

                    f_10853_36409_36463(this, kind, leftType, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 36347, 36479);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36777, 37000) || true) && ((object)rightType != null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 36781, 36895) && ((object)leftType == null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 36811, 36894) || !f_10853_36840_36894(rightType, leftType)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 36777, 37000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 36929, 36985);

                    f_10853_36929_36984(this, kind, rightType, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 36777, 37000);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37016, 37331) || true) && ((object)leftType != null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 37020, 37073) || (object)rightType != null) || (DynAbs.Tracing.TraceSender.Expression_False(10853, 37020, 37115) || f_10853_37077_37086(left) is FunctionPointerTypeSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10853, 37020, 37158) || f_10853_37119_37129(right) is FunctionPointerTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 37016, 37331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37271, 37316);

                    f_10853_37271_37315(this, kind, results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 37016, 37331);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 35874, 37342);

                int
                f_10853_36101_36127(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36101, 36127);
                    return 0;
                }


                int
                f_10853_36142_36169(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36142, 36169);
                    return 0;
                }


                int
                f_10853_36184_36206(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    AssertNotChecked(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36184, 36206);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_36238_36247(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 36238, 36247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_36299_36309(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 36299, 36309);
                    return return_v;
                }


                int
                f_10853_36409_36463(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                pointerType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetPointerArithmeticOperators(kind, pointerType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36409, 36463);
                    return 0;
                }


                bool
                f_10853_36840_36894(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36840, 36894);
                    return return_v;
                }


                int
                f_10853_36929_36984(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                pointerType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetPointerArithmeticOperators(kind, pointerType, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 36929, 36984);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_37077_37086(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 37077, 37086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_37119_37129(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 37119, 37129);
                    return return_v;
                }


                int
                f_10853_37271_37315(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetPointerComparisonOperators(kind, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 37271, 37315);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 35874, 37342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 35874, 37342);
            }
        }

        private void GetAllBuiltInOperators(BinaryOperatorKind kind, BoundExpression left, BoundExpression right, ArrayBuilder<BinaryOperatorAnalysisResult> results, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 37354, 40373);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37730, 37764);

                kind = f_10853_37737_37763(kind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37778, 37846);

                var
                operators = f_10853_37794_37845()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37860, 37950);

                bool
                isEquality = kind == BinaryOperatorKind.Equal || (DynAbs.Tracing.TraceSender.Expression_False(10853, 37878, 37949) || kind == BinaryOperatorKind.NotEqual)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 37964, 39272) || true) && (isEquality && (DynAbs.Tracing.TraceSender.Expression_True(10853, 37968, 38056) && f_10853_37982_38056(f_10853_38007_38018(), left, right, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 37964, 39272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 38374, 38412);

                    f_10853_38374_38411(this, kind, operators);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 37964, 39272);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 37964, 39272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 38478, 38700);

                    f_10853_38478_38699(f_10853_38478_38494(this).builtInOperators, kind, operators, skipNativeIntegerOperators: !f_10853_38584_38638(f_10853_38584_38593(left)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 38583, 38698) && !f_10853_38643_38698(f_10853_38643_38653(right))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 38966, 39042);

                    f_10853_38966_39041(this, kind, left, right, operators, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 39060, 39108);

                    f_10853_39060_39107(this, kind, left, right, operators);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 39207, 39257);

                    f_10853_39207_39256(this, kind, left, right, operators);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 37964, 39272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 39288, 39364);

                f_10853_39288_39363(this, operators, left, right, results, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 39378, 39395);

                f_10853_39378_39394(operators);

                static bool useOnlyReferenceEquality(Conversions conversions, BoundExpression left, BoundExpression right, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10853, 39411, 40362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 39736, 40347);

                        return
                        f_10853_39764_39952(conversions, f_10853_39816_39825(left), f_10853_39827_39847(left), leftIsDefault: false, f_10853_39871_39881(right), f_10853_39883_39904(right), rightIsDefault: false, ref useSiteDiagnostics) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 39764, 40147) && ((object)f_10853_39986_39995(left) == null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 39978, 40146) || (!f_10853_40009_40035(f_10853_40009_40018(left)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 40008, 40089) && f_10853_40039_40060(f_10853_40039_40048(left)) != SpecialType.System_String) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 40008, 40145) && f_10853_40093_40114(f_10853_40093_40102(left)) != SpecialType.System_Delegate))))) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 39764, 40346) && ((object)f_10853_40181_40191(right) == null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 40173, 40345) || (!f_10853_40205_40232(f_10853_40205_40215(right)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 40204, 40287) && f_10853_40236_40258(f_10853_40236_40246(right)) != SpecialType.System_String) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 40204, 40344) && f_10853_40291_40313(f_10853_40291_40301(right)) != SpecialType.System_Delegate)))));
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10853, 39411, 40362);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10853_39816_39825(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 39816, 39825);
                            return return_v;
                        }


                        bool
                        f_10853_39827_39847(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        node)
                        {
                            var return_v = node.IsLiteralNull();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39827, 39847);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10853_39871_39881(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 39871, 39881);
                            return return_v;
                        }


                        bool
                        f_10853_39883_39904(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        node)
                        {
                            var return_v = node.IsLiteralNull();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39883, 39904);
                            return return_v;
                        }


                        bool
                        f_10853_39764_39952(Microsoft.CodeAnalysis.CSharp.Conversions
                        Conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        leftType, bool
                        leftIsNull, bool
                        leftIsDefault, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        rightType, bool
                        rightIsNull, bool
                        rightIsDefault, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = BuiltInOperators.IsValidObjectEquality(Conversions, leftType, leftIsNull, leftIsDefault: leftIsDefault, rightType, rightIsNull, rightIsDefault: rightIsDefault, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39764, 39952);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10853_39986_39995(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 39986, 39995);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40009_40018(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40009, 40018);
                            return return_v;
                        }


                        bool
                        f_10853_40009_40035(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsDelegateType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40009, 40035);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40039_40048(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40039, 40048);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10853_40039_40060(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40039, 40060);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40093_40102(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40093, 40102);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10853_40093_40114(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40093, 40114);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10853_40181_40191(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40181, 40191);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40205_40215(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40205, 40215);
                            return return_v;
                        }


                        bool
                        f_10853_40205_40232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsDelegateType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40205, 40232);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40236_40246(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40236, 40246);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10853_40236_40258(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40236, 40258);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10853_40291_40301(Microsoft.CodeAnalysis.CSharp.BoundExpression
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40291, 40301);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SpecialType
                        f_10853_40291_40313(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        this_param)
                        {
                            var return_v = this_param.SpecialType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40291, 40313);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 39411, 40362);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 39411, 40362);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 37354, 40373);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10853_37737_37763(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperatorWithLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 37737, 37763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                f_10853_37794_37845()
                {
                    var return_v = ArrayBuilder<BinaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 37794, 37845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10853_38007_38018()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 38007, 38018);
                    return return_v;
                }


                bool
                f_10853_37982_38056(Microsoft.CodeAnalysis.CSharp.Conversions
                conversions, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = useOnlyReferenceEquality(conversions, left, right, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 37982, 38056);
                    return return_v;
                }


                int
                f_10853_38374_38411(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetReferenceEquality(kind, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 38374, 38411);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_38478_38494(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 38478, 38494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_38584_38593(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 38584, 38593);
                    return return_v;
                }


                bool
                f_10853_38584_38638(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNativeIntegerOrNullableNativeIntegerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 38584, 38638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10853_38643_38653(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 38643, 38653);
                    return return_v;
                }


                bool
                f_10853_38643_38698(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNativeIntegerOrNullableNativeIntegerType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 38643, 38698);
                    return return_v;
                }


                int
                f_10853_38478_38699(Microsoft.CodeAnalysis.CSharp.BuiltInOperators
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, bool
                skipNativeIntegerOperators)
                {
                    this_param.GetSimpleBuiltInOperators(kind, operators, skipNativeIntegerOperators: skipNativeIntegerOperators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 38478, 38699);
                    return 0;
                }


                int
                f_10853_38966_39041(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetDelegateOperations(kind, left, right, operators, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 38966, 39041);
                    return 0;
                }


                int
                f_10853_39060_39107(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                results)
                {
                    this_param.GetEnumOperations(kind, left, right, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39060, 39107);
                    return 0;
                }


                int
                f_10853_39207_39256(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                results)
                {
                    this_param.GetPointerOperators(kind, left, right, results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39207, 39256);
                    return 0;
                }


                bool
                f_10853_39288_39363(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39288, 39363);
                    return return_v;
                }


                int
                f_10853_39378_39394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 39378, 39394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 37354, 40373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 37354, 40373);
            }
        }

        private void GetReferenceEquality(BinaryOperatorKind kind, ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 40385, 40761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 40517, 40585);

                var
                @object = f_10853_40531_40584(f_10853_40531_40542(), SpecialType.System_Object)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 40599, 40750);

                f_10853_40599_40749(operators, f_10853_40613_40748(kind | BinaryOperatorKind.Object, @object, @object, f_10853_40693_40747(f_10853_40693_40704(), SpecialType.System_Boolean)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 40385, 40761);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_40531_40542()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40531, 40542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_40531_40584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40531, 40584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10853_40693_40704()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 40693, 40704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_40693_40747(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40693, 40747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_40613_40748(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40613, 40748);
                    return return_v;
                }


                int
                f_10853_40599_40749(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 40599, 40749);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 40385, 40761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 40385, 40761);
            }
        }

        private bool CandidateOperators(
                    ArrayBuilder<BinaryOperatorSignature> operators,
                    BoundExpression left,
                    BoundExpression right,
                    ArrayBuilder<BinaryOperatorAnalysisResult> results,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 40773, 41916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41089, 41125);

                bool
                hadApplicableCandidate = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41139, 41861);
                    foreach (var op in f_10853_41158_41167_I(operators))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 41139, 41861);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41201, 41304);

                        var
                        convLeft = f_10853_41216_41303(f_10853_41216_41227(), left, op.LeftType, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41322, 41428);

                        var
                        convRight = f_10853_41338_41427(f_10853_41338_41349(), right, op.RightType, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41446, 41846) || true) && (convLeft.IsImplicit && (DynAbs.Tracing.TraceSender.Expression_True(10853, 41450, 41493) && convRight.IsImplicit))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 41446, 41846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41535, 41613);

                            f_10853_41535_41612(results, BinaryOperatorAnalysisResult.Applicable(op, convLeft, convRight));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41635, 41665);

                            hadApplicableCandidate = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 41446, 41846);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 41446, 41846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41747, 41827);

                            f_10853_41747_41826(results, BinaryOperatorAnalysisResult.Inapplicable(op, convLeft, convRight));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 41446, 41846);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 41139, 41861);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 41875, 41905);

                return hadApplicableCandidate;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 40773, 41916);

                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10853_41216_41227()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 41216, 41227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10853_41216_41303(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 41216, 41303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10853_41338_41349()
                {
                    var return_v = Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 41338, 41349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10853_41338_41427(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 41338, 41427);
                    return return_v;
                }


                int
                f_10853_41535_41612(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 41535, 41612);
                    return 0;
                }


                int
                f_10853_41747_41826(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 41747, 41826);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                f_10853_41158_41167_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 41158, 41167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 40773, 41916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 40773, 41916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddDistinctOperators(ArrayBuilder<BinaryOperatorAnalysisResult> result, ArrayBuilder<BinaryOperatorAnalysisResult> additionalOperators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10853, 41928, 43781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42108, 42140);

                int
                initialCount = f_10853_42127_42139(result)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42156, 43458);
                    foreach (var op in f_10853_42175_42194_I(additionalOperators))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 42156, 43458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42228, 42262);

                        bool
                        equivalentToExisting = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42291, 42296);

                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42282, 43322) || true) && (i < initialCount)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42316, 42319)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 42282, 43322))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 42282, 43322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42361, 42405);

                                var
                                existingSignature = result[i].Signature
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42429, 42509);

                                f_10853_42429_42508(f_10853_42442_42470(op.Signature.Kind) == f_10853_42474_42507(existingSignature.Kind));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 42641, 43303) || true) && (op.Signature.Kind == existingSignature.Kind && (DynAbs.Tracing.TraceSender.Expression_True(10853, 42645, 42806) && f_10853_42729_42806(op.Signature.ReturnType, existingSignature.ReturnType)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 42645, 42918) && f_10853_42835_42918(op.Signature.LeftType, existingSignature.LeftType)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 42645, 43032) && f_10853_42947_43032(op.Signature.RightType, existingSignature.RightType)) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 42645, 43170) && f_10853_43061_43170(f_10853_43094_43128(op.Signature.Method), f_10853_43130_43169(existingSignature.Method))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 42641, 43303);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 43220, 43248);

                                    equivalentToExisting = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10853, 43274, 43280);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 42641, 43303);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 1041);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 1041);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 43342, 43443) || true) && (!equivalentToExisting)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 43342, 43443);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 43409, 43424);

                            f_10853_43409_43423(result, op);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 43342, 43443);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 42156, 43458);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 1303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 1303);
                }
                static bool equalsIgnoringNullable(TypeSymbol a, TypeSymbol b)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 43537, 43593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 43540, 43593);
                        return f_10853_43540_43593(a, b, TypeCompareKind.AllNullableIgnoreOptions); DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 43537, 43593);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 43537, 43593);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 43537, 43593);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static bool equalsIgnoringNullableAndDynamic(TypeSymbol a, TypeSymbol b)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 43681, 43769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 43684, 43769);
                        return f_10853_43684_43769(a, b, TypeCompareKind.AllNullableIgnoreOptions | TypeCompareKind.IgnoreDynamic); DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 43681, 43769);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 43681, 43769);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 43681, 43769);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10853, 41928, 43781);

                int
                f_10853_42127_42139(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 42127, 42139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10853_42442_42470(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42442, 42470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10853_42474_42507(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42474, 42507);
                    return return_v;
                }


                int
                f_10853_42429_42508(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42429, 42508);
                    return 0;
                }


                bool
                f_10853_42729_42806(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b)
                {
                    var return_v = equalsIgnoringNullable(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42729, 42806);
                    return return_v;
                }


                bool
                f_10853_42835_42918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b)
                {
                    var return_v = equalsIgnoringNullableAndDynamic(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42835, 42918);
                    return return_v;
                }


                bool
                f_10853_42947_43032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                b)
                {
                    var return_v = equalsIgnoringNullableAndDynamic(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42947, 43032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_43094_43128(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 43094, 43128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_43130_43169(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 43130, 43169);
                    return return_v;
                }


                bool
                f_10853_43061_43170(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                a, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                b)
                {
                    var return_v = equalsIgnoringNullableAndDynamic((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)a, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 43061, 43170);
                    return return_v;
                }


                int
                f_10853_43409_43423(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 43409, 43423);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                f_10853_42175_42194_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 42175, 42194);
                    return return_v;
                }


                static bool
                f_10853_43540_43593(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 43540, 43593);
                    return return_v;
                }


                static bool
                f_10853_43684_43769(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 43684, 43769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 41928, 43781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 41928, 43781);
            }
        }

        private bool GetUserDefinedOperators(
                    BinaryOperatorKind kind,
                    TypeSymbol type0,
                    BoundExpression left,
                    BoundExpression right,
                    ArrayBuilder<BinaryOperatorAnalysisResult> results,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 43793, 46921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 44121, 44154);

                f_10853_44121_44153(f_10853_44134_44147(results) == 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 44168, 44315) || true) && ((object)type0 == null || (DynAbs.Tracing.TraceSender.Expression_False(10853, 44172, 44253) || f_10853_44197_44253(type0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 44168, 44315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 44287, 44300);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 44168, 44315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45570, 45639);

                string
                name = f_10853_45584_45638(kind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45653, 45721);

                var
                operators = f_10853_45669_45720()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45735, 45772);

                bool
                hadApplicableCandidates = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45788, 45839);

                NamedTypeSymbol
                current = type0 as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45853, 46010) || true) && ((object)current == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 45853, 46010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 45914, 45995);

                    current = f_10853_45924_45994(type0, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 45853, 46010);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46026, 46211) || true) && ((object)current == null && (DynAbs.Tracing.TraceSender.Expression_True(10853, 46030, 46080) && f_10853_46057_46080(type0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 46026, 46211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46114, 46196);

                    current = f_10853_46124_46195(((TypeParameterSymbol)type0), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 46026, 46211);
                }
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46227, 46747) || true) && ((object)current != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46259, 46341)
        , current = f_10853_46269_46341(current, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 46227, 46747))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 46227, 46747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46375, 46393);

                        f_10853_46375_46392(operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46411, 46481);

                        f_10853_46411_46480(this, current, kind, name, operators);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46499, 46515);

                        f_10853_46499_46514(results);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46533, 46732) || true) && (f_10853_46537_46612(this, operators, left, right, results, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 46533, 46732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46654, 46685);

                            hadApplicableCandidates = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(10853, 46707, 46713);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 46533, 46732);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 521);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 521);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46763, 46780);

                f_10853_46763_46779(
                            operators);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46796, 46865);

                f_10853_46796_46864(hadApplicableCandidates == f_10853_46836_46863(results, r => r.IsValid));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 46879, 46910);

                return hadApplicableCandidates;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 43793, 46921);

                int
                f_10853_44134_44147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 44134, 44147);
                    return return_v;
                }


                int
                f_10853_44121_44153(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 44121, 44153);
                    return 0;
                }


                bool
                f_10853_44197_44253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = OperatorFacts.DefinitelyHasNoUserDefinedOperators(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 44197, 44253);
                    return return_v;
                }


                string
                f_10853_45584_45638(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = OperatorFacts.BinaryOperatorNameFromOperatorKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 45584, 45638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                f_10853_45669_45720()
                {
                    var return_v = ArrayBuilder<BinaryOperatorSignature>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 45669, 45720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_45924_45994(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 45924, 45994);
                    return return_v;
                }


                bool
                f_10853_46057_46080(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46057, 46080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_46124_46195(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46124, 46195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_46269_46341(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46269, 46341);
                    return return_v;
                }


                int
                f_10853_46375_46392(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46375, 46392);
                    return 0;
                }


                int
                f_10853_46411_46480(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, string
                name, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators)
                {
                    this_param.GetUserDefinedBinaryOperatorsFromType(type, kind, name, operators);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46411, 46480);
                    return 0;
                }


                int
                f_10853_46499_46514(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46499, 46514);
                    return 0;
                }


                bool
                f_10853_46537_46612(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                operators, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                results, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CandidateOperators(operators, left, right, results, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46537, 46612);
                    return return_v;
                }


                int
                f_10853_46763_46779(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46763, 46779);
                    return 0;
                }


                bool
                f_10853_46836_46863(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46836, 46863);
                    return return_v;
                }


                int
                f_10853_46796_46864(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 46796, 46864);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 43793, 46921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 43793, 46921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetUserDefinedBinaryOperatorsFromType(
                    NamedTypeSymbol type,
                    BinaryOperatorKind kind,
                    string name,
                    ArrayBuilder<BinaryOperatorSignature> operators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 46933, 48736);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47170, 48725);
                    foreach (MethodSymbol op in f_10853_47198_47221_I(f_10853_47198_47221(type, name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 47170, 48725);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47348, 47462) || true) && (f_10853_47352_47369(op) != 2 || (DynAbs.Tracing.TraceSender.Expression_False(10853, 47352, 47392) || f_10853_47378_47392(op)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 47348, 47462);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47434, 47443);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 47348, 47462);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47482, 47534);

                        TypeSymbol
                        leftOperandType = f_10853_47511_47533(op, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47552, 47605);

                        TypeSymbol
                        rightOperandType = f_10853_47582_47604(op, 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47623, 47661);

                        TypeSymbol
                        resultType = f_10853_47647_47660(op)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47681, 47814);

                        f_10853_47681_47813(
                                        operators, f_10853_47695_47812(BinaryOperatorKind.UserDefined | kind, leftOperandType, rightOperandType, resultType, op));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47834, 47948);

                        LiftingResult
                        lifting = f_10853_47858_47947(leftOperandType, rightOperandType, resultType, kind)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 47968, 48710) || true) && (lifting == LiftingResult.LiftOperandsAndResult)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 47968, 48710);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 48060, 48314);

                            f_10853_48060_48313(operators, f_10853_48074_48312(BinaryOperatorKind.Lifted | BinaryOperatorKind.UserDefined | kind, f_10853_48220_48249(this, leftOperandType), f_10853_48251_48281(this, rightOperandType), f_10853_48283_48307(this, resultType), op));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 47968, 48710);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 47968, 48710);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 48356, 48710) || true) && (lifting == LiftingResult.LiftOperandsButNotResult)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 48356, 48710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 48451, 48691);

                                f_10853_48451_48690(operators, f_10853_48465_48689(BinaryOperatorKind.Lifted | BinaryOperatorKind.UserDefined | kind, f_10853_48611_48640(this, leftOperandType), f_10853_48642_48672(this, rightOperandType), resultType, op));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 48356, 48710);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 47968, 48710);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 47170, 48725);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 1556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 1556);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 46933, 48736);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10853_47198_47221(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetOperators(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47198, 47221);
                    return return_v;
                }


                int
                f_10853_47352_47369(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 47352, 47369);
                    return return_v;
                }


                bool
                f_10853_47378_47392(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 47378, 47392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_47511_47533(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47511, 47533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_47582_47604(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, int
                index)
                {
                    var return_v = this_param.GetParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47582, 47604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_47647_47660(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 47647, 47660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_47695_47812(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, leftType, rightType, returnType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47695, 47812);
                    return return_v;
                }


                int
                f_10853_47681_47813(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47681, 47813);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.OverloadResolution.LiftingResult
                f_10853_47858_47947(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                result, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = UserDefinedBinaryOperatorCanBeLifted(left, right, result, kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47858, 47947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_48220_48249(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48220, 48249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_48251_48281(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48251, 48281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_48283_48307(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48283, 48307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_48074_48312(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)returnType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48074, 48312);
                    return return_v;
                }


                int
                f_10853_48060_48313(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48060, 48313);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_48611_48640(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48611, 48640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_48642_48672(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48642, 48672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                f_10853_48465_48689(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                leftType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                rightType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)leftType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)rightType, returnType, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48465, 48689);
                    return return_v;
                }


                int
                f_10853_48451_48690(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature>
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 48451, 48690);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10853_47198_47221_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 47198, 47221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 46933, 48736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 46933, 48736);
            }
        }

        private enum LiftingResult
        {
            NotLifted,
            LiftOperandsAndResult,
            LiftOperandsButNotResult
        }

        private static LiftingResult UserDefinedBinaryOperatorCanBeLifted(TypeSymbol left, TypeSymbol right, TypeSymbol result, BinaryOperatorKind kind)
        {
            // SPEC: For the binary operators + - * / % & | ^ << >> a lifted form of the
            // SPEC: operator exists if the operand and result types are all non-nullable
            // SPEC: value types. The lifted form is constructed by adding a single ?
            // SPEC: modifier to each operand and result type. 
            //
            // SPEC: For the equality operators == != a lifted form of the operator exists
            // SPEC: if the operand types are both non-nullable value types and if the 
            // SPEC: result type is bool. The lifted form is constructed by adding
            // SPEC: a single ? modifier to each operand type.
            //
            // SPEC: For the relational operators > < >= <= a lifted form of the 
            // SPEC: operator exists if the operand types are both non-nullable value
            // SPEC: types and if the result type is bool. The lifted form is 
            // SPEC: constructed by adding a single ? modifier to each operand type.

            if (!left.IsValueType ||
                left.IsNullableType() ||
                !right.IsValueType ||
                right.IsNullableType())
            {
                return LiftingResult.NotLifted;
            }

            switch (kind)
            {
                case BinaryOperatorKind.Equal:
                case BinaryOperatorKind.NotEqual:
                    // Spec violation: can't lift unless the types match.
                    // The spec doesn't require this, but dev11 does and it reduces ambiguity in some cases.
                    if (!TypeSymbol.Equals(left, right, TypeCompareKind.ConsiderEverything2)) return LiftingResult.NotLifted;
                    goto case BinaryOperatorKind.GreaterThan;
                case BinaryOperatorKind.GreaterThan:
                case BinaryOperatorKind.GreaterThanOrEqual:
                case BinaryOperatorKind.LessThan:
                case BinaryOperatorKind.LessThanOrEqual:
                    return result.SpecialType == SpecialType.System_Boolean ?
                        LiftingResult.LiftOperandsButNotResult :
                        LiftingResult.NotLifted;
                default:
                    return result.IsValueType && !result.IsNullableType() ?
                        LiftingResult.LiftOperandsAndResult :
                        LiftingResult.NotLifted;
            }
        }

        private void BinaryOperatorOverloadResolution(
                    BoundExpression left,
                    BoundExpression right,
                    BinaryOperatorOverloadResolutionResult result,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 51667, 54570);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 52184, 52264) || true) && (f_10853_52188_52208(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 52184, 52264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 52242, 52249);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 52184, 52264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 52826, 52858);

                var
                candidates = result.Results
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 52924, 53014);

                int
                bestIndex = f_10853_52940_53013(this, left, right, candidates, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53028, 53502) || true) && (bestIndex != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53028, 53502);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53145, 53154);
                        // Mark all other candidates as worse
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53136, 53460) || true) && (index < f_10853_53164_53180(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53182, 53189)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53136, 53460))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53136, 53460);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53231, 53441) || true) && (candidates[index].Kind != OperatorAnalysisResultKind.Inapplicable && (DynAbs.Tracing.TraceSender.Expression_True(10853, 53235, 53322) && index != bestIndex))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53231, 53441);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53372, 53418);

                                candidates[index] = candidates[index].Worse();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53231, 53441);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 325);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 325);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53480, 53487);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53028, 53502);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53527, 53532);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53518, 54559) || true) && (i < f_10853_53538_53554(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53556, 53559)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53518, 54559))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53518, 54559);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53593, 53726) || true) && (candidates[i].Kind != OperatorAnalysisResultKind.Applicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53593, 53726);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53698, 53707);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53593, 53726);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53846, 53851);

                            // Is this applicable operator better than every other applicable method?
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53837, 54544) || true) && (j < i)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53860, 53863)
            , ++j, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53837, 54544))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53837, 54544);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 53905, 54052) || true) && (candidates[j].Kind == OperatorAnalysisResultKind.Inapplicable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 53905, 54052);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54020, 54029);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 53905, 54052);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54076, 54191);

                                var
                                better = f_10853_54089_54190(this, candidates[i].Signature, candidates[j].Signature, left, right, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54213, 54525) || true) && (better == BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 54213, 54525);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54294, 54332);

                                    candidates[j] = candidates[j].Worse();
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 54213, 54525);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 54213, 54525);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54382, 54525) || true) && (better == BetterResult.Right)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 54382, 54525);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54464, 54502);

                                        candidates[i] = candidates[i].Worse();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 54382, 54525);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 54213, 54525);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 708);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 708);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 1042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 51667, 54570);

                bool
                f_10853_52188_52208(Microsoft.CodeAnalysis.CSharp.BinaryOperatorOverloadResolutionResult
                this_param)
                {
                    var return_v = this_param.SingleValid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 52188, 52208);
                    return return_v;
                }


                int
                f_10853_52940_53013(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                candidates, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetTheBestCandidateIndex(left, right, candidates, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 52940, 53013);
                    return return_v;
                }


                int
                f_10853_53164_53180(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 53164, 53180);
                    return return_v;
                }


                int
                f_10853_53538_53554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 53538, 53554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_54089_54190(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, left, right, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 54089, 54190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 51667, 54570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 51667, 54570);
            }
        }

        private int GetTheBestCandidateIndex(
                    BoundExpression left,
                    BoundExpression right,
                    ArrayBuilder<BinaryOperatorAnalysisResult> candidates,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 54582, 56692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54844, 54870);

                int
                currentBestIndex = -1
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54893, 54902);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54884, 55976) || true) && (index < f_10853_54912_54928(candidates))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54930, 54937)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 54884, 55976))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 54884, 55976);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 54971, 55108) || true) && (candidates[index].Kind != OperatorAnalysisResultKind.Applicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 54971, 55108);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55080, 55089);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 54971, 55108);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55215, 55961) || true) && (currentBestIndex == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 55215, 55961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55283, 55308);

                            currentBestIndex = index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 55215, 55961);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 55215, 55961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55390, 55524);

                            var
                            better = f_10853_55403_55523(this, candidates[currentBestIndex].Signature, candidates[index].Signature, left, right, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55546, 55942) || true) && (better == BetterResult.Right)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 55546, 55942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55682, 55707);

                                currentBestIndex = index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 55546, 55942);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 55546, 55942);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55757, 55942) || true) && (better != BetterResult.Left)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 55757, 55942);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 55897, 55919);

                                    currentBestIndex = -1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 55757, 55942);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 55546, 55942);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 55215, 55961);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 1093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 1093);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56080, 56089);

                    // Make sure that every candidate up to the current best is worse
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56071, 56641) || true) && (index < currentBestIndex)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56117, 56124)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 56071, 56641))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 56071, 56641);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56158, 56297) || true) && (candidates[index].Kind == OperatorAnalysisResultKind.Inapplicable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 56158, 56297);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56269, 56278);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 56158, 56297);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56317, 56451);

                        var
                        better = f_10853_56330_56450(this, candidates[currentBestIndex].Signature, candidates[index].Signature, left, right, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56469, 56626) || true) && (better != BetterResult.Left)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 56469, 56626);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56597, 56607);

                            return -1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 56469, 56626);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10853, 1, 571);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10853, 1, 571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 56657, 56681);

                return currentBestIndex;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 54582, 56692);

                int
                f_10853_54912_54928(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 54912, 54928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_55403_55523(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, left, right, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 55403, 55523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_56330_56450(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op2, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterOperator(op1, op2, left, right, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 56330, 56450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 54582, 56692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 54582, 56692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult BetterOperator(BinaryOperatorSignature op1, BinaryOperatorSignature op2, BoundExpression left, BoundExpression right, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 56704, 63576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 57000, 57061);

                f_10853_57000_57060(f_10853_57013_57034(op1.Priority) == f_10853_57038_57059(op2.Priority));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 57075, 57339) || true) && (f_10853_57079_57100(op1.Priority) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 57079, 57172) && f_10853_57104_57136(op1.Priority) != f_10853_57140_57172(op2.Priority)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 57075, 57339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 57206, 57324);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10853, 57213, 57282) || (((f_10853_57214_57246(op1.Priority) < f_10853_57249_57281(op2.Priority)) && DynAbs.Tracing.TraceSender.Conditional_F2(10853, 57285, 57302)) || DynAbs.Tracing.TraceSender.Conditional_F3(10853, 57305, 57323))) ? BetterResult.Left : BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 57075, 57339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 57355, 57470);

                BetterResult
                leftBetter = f_10853_57381_57469(this, left, op1.LeftType, op2.LeftType, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 57484, 57603);

                BetterResult
                rightBetter = f_10853_57511_57602(this, right, op1.RightType, op2.RightType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 58952, 59187) || true) && (leftBetter == BetterResult.Left && (DynAbs.Tracing.TraceSender.Expression_True(10853, 58956, 59024) && rightBetter != BetterResult.Right) || (DynAbs.Tracing.TraceSender.Expression_False(10853, 58956, 59113) || leftBetter != BetterResult.Right && (DynAbs.Tracing.TraceSender.Expression_True(10853, 59045, 59113) && rightBetter == BetterResult.Left)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 58952, 59187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 59147, 59172);

                    return BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 58952, 59187);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 59203, 59439) || true) && (leftBetter == BetterResult.Right && (DynAbs.Tracing.TraceSender.Expression_True(10853, 59207, 59275) && rightBetter != BetterResult.Left) || (DynAbs.Tracing.TraceSender.Expression_False(10853, 59207, 59364) || leftBetter != BetterResult.Left && (DynAbs.Tracing.TraceSender.Expression_True(10853, 59296, 59364) && rightBetter == BetterResult.Right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 59203, 59439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 59398, 59424);

                    return BetterResult.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 59203, 59439);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 59817, 62134) || true) && (f_10853_59821_59882(op1.LeftType, op2.LeftType) && (DynAbs.Tracing.TraceSender.Expression_True(10853, 59821, 59966) && f_10853_59903_59966(op1.RightType, op2.RightType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 59817, 62134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61357, 61434);

                    BetterResult
                    result = f_10853_61379_61433(this, op1, op2, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61452, 61590) || true) && (result == BetterResult.Left || (DynAbs.Tracing.TraceSender.Expression_False(10853, 61456, 61515) || result == BetterResult.Right))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 61452, 61590);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61557, 61571);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 61452, 61590);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61769, 61804);

                    bool
                    lifted1 = f_10853_61784_61803(op1.Kind)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61822, 61857);

                    bool
                    lifted2 = f_10853_61837_61856(op2.Kind)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61877, 62119) || true) && (lifted1 && (DynAbs.Tracing.TraceSender.Expression_True(10853, 61881, 61900) && !lifted2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 61877, 62119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 61942, 61968);

                        return BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 61877, 62119);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 61877, 62119);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62010, 62119) || true) && (!lifted1 && (DynAbs.Tracing.TraceSender.Expression_True(10853, 62014, 62033) && lifted2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62010, 62119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62075, 62100);

                            return BetterResult.Left;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62010, 62119);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 61877, 62119);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 59817, 62134);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62245, 62278);

                BetterResult
                valOverInPreference
                = default(BetterResult);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62294, 62737) || true) && (op1.LeftRefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10853, 62298, 62362) && op2.LeftRefKind == RefKind.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62294, 62737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62396, 62436);

                    valOverInPreference = BetterResult.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62294, 62737);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62294, 62737);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62470, 62737) || true) && (op2.LeftRefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10853, 62474, 62538) && op1.LeftRefKind == RefKind.In))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62470, 62737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62572, 62613);

                        valOverInPreference = BetterResult.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62470, 62737);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62470, 62737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62679, 62722);

                        valOverInPreference = BetterResult.Neither;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62470, 62737);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62294, 62737);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62753, 63522) || true) && (op1.RightRefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10853, 62757, 62823) && op2.RightRefKind == RefKind.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62753, 63522);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62857, 63113) || true) && (valOverInPreference == BetterResult.Right)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62857, 63113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 62944, 62972);

                        return BetterResult.Neither;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62857, 63113);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62857, 63113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63054, 63094);

                        valOverInPreference = BetterResult.Left;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62857, 63113);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62753, 63522);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 62753, 63522);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63147, 63522) || true) && (op2.RightRefKind == RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10853, 63151, 63217) && op1.RightRefKind == RefKind.In))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 63147, 63522);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63251, 63507) || true) && (valOverInPreference == BetterResult.Left)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 63251, 63507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63337, 63365);

                            return BetterResult.Neither;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 63251, 63507);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 63251, 63507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63447, 63488);

                            valOverInPreference = BetterResult.Right;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 63251, 63507);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 63147, 63522);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 62753, 63522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63538, 63565);

                return valOverInPreference;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 56704, 63576);

                bool
                f_10853_57013_57034(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 57013, 57034);
                    return return_v;
                }


                bool
                f_10853_57038_57059(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 57038, 57059);
                    return return_v;
                }


                int
                f_10853_57000_57060(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57000, 57060);
                    return 0;
                }


                bool
                f_10853_57079_57100(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 57079, 57100);
                    return return_v;
                }


                int
                f_10853_57104_57136(int?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57104, 57136);
                    return return_v;
                }


                int
                f_10853_57140_57172(int?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57140, 57172);
                    return return_v;
                }


                int
                f_10853_57214_57246(int?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57214, 57246);
                    return return_v;
                }


                int
                f_10853_57249_57281(int?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57249, 57281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_57381_57469(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57381, 57469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_57511_57602(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BetterConversionFromExpression(node, t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 57511, 57602);
                    return return_v;
                }


                bool
                f_10853_59821_59882(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 59821, 59882);
                    return return_v;
                }


                bool
                f_10853_59903_59966(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = Conversions.HasIdentityConversion(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 59903, 59966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_61379_61433(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op1, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                op2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.MoreSpecificOperator(op1, op2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 61379, 61433);
                    return return_v;
                }


                bool
                f_10853_61784_61803(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 61784, 61803);
                    return return_v;
                }


                bool
                f_10853_61837_61856(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 61837, 61856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 56704, 63576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 56704, 63576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BetterResult MoreSpecificOperator(BinaryOperatorSignature op1, BinaryOperatorSignature op2, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10853, 63588, 65382);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63760, 63808);

                TypeSymbol
                op1Left
                = default(TypeSymbol),
                op1Right
                = default(TypeSymbol),
                op2Left
                = default(TypeSymbol),
                op2Right
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63822, 64354) || true) && ((object)op1.Method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 63822, 64354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63886, 63940);

                    var
                    p = f_10853_63894_63939(f_10853_63894_63923(op1.Method))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63958, 63978);

                    op1Left = f_10853_63968_63977(p[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 63996, 64017);

                    op1Right = f_10853_64007_64016(p[1]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64035, 64207) || true) && (f_10853_64039_64058(op1.Kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 64035, 64207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64100, 64132);

                        op1Left = f_10853_64110_64131(this, op1Left);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64154, 64188);

                        op1Right = f_10853_64165_64187(this, op1Right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 64035, 64207);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 63822, 64354);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 63822, 64354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64273, 64296);

                    op1Left = op1.LeftType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64314, 64339);

                    op1Right = op1.RightType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 63822, 64354);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64370, 64902) || true) && ((object)op2.Method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 64370, 64902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64434, 64488);

                    var
                    p = f_10853_64442_64487(f_10853_64442_64471(op2.Method))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64506, 64526);

                    op2Left = f_10853_64516_64525(p[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64544, 64565);

                    op2Right = f_10853_64555_64564(p[1]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64583, 64755) || true) && (f_10853_64587_64606(op2.Kind))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 64583, 64755);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64648, 64680);

                        op2Left = f_10853_64658_64679(this, op2Left);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64702, 64736);

                        op2Right = f_10853_64713_64735(this, op2Right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 64583, 64755);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 64370, 64902);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10853, 64370, 64902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64821, 64844);

                    op2Left = op2.LeftType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64862, 64887);

                    op2Right = op2.RightType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10853, 64370, 64902);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64918, 64971);

                var
                uninst1 = f_10853_64932_64970()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 64985, 65038);

                var
                uninst2 = f_10853_64999_65037()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65054, 65075);

                f_10853_65054_65074(
                            uninst1, op1Left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65089, 65111);

                f_10853_65089_65110(uninst1, op1Right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65127, 65148);

                f_10853_65127_65147(
                            uninst2, op2Left);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65162, 65184);

                f_10853_65162_65183(uninst2, op2Right);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65200, 65281);

                BetterResult
                result = f_10853_65222_65280(uninst1, uninst2, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65297, 65312);

                f_10853_65297_65311(
                            uninst1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65326, 65341);

                f_10853_65326_65340(uninst2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65357, 65371);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10853, 63588, 65382);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10853_63894_63923(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 63894, 63923);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10853_63894_63939(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 63894, 63939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_63968_63977(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 63968, 63977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_64007_64016(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 64007, 64016);
                    return return_v;
                }


                bool
                f_10853_64039_64058(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64039, 64058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_64110_64131(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64110, 64131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_64165_64187(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64165, 64187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10853_64442_64471(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 64442, 64471);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10853_64442_64487(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64442, 64487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_64516_64525(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 64516, 64525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10853_64555_64564(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10853, 64555, 64564);
                    return return_v;
                }


                bool
                f_10853_64587_64606(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64587, 64606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_64658_64679(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64658, 64679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10853_64713_64735(Microsoft.CodeAnalysis.CSharp.OverloadResolution
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.MakeNullable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64713, 64735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10853_64932_64970()
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64932, 64970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10853_64999_65037()
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 64999, 65037);
                    return return_v;
                }


                int
                f_10853_65054_65074(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65054, 65074);
                    return 0;
                }


                int
                f_10853_65089_65110(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65089, 65110);
                    return 0;
                }


                int
                f_10853_65127_65147(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65127, 65147);
                    return 0;
                }


                int
                f_10853_65162_65183(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65162, 65183);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BetterResult
                f_10853_65222_65280(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t1, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                t2, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = MoreSpecificType(t1, t2, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65222, 65280);
                    return return_v;
                }


                int
                f_10853_65297_65311(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65297, 65311);
                    return 0;
                }


                int
                f_10853_65326_65340(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65326, 65340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 63588, 65382);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 63588, 65382);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void AssertNotChecked(BinaryOperatorKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10853, 65394, 65661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10853, 65512, 65650);

                f_10853_65512_65649((kind & ~BinaryOperatorKind.Checked) == kind, "Did not expect operator to be checked.  Consider using .Operator() to mask.");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10853, 65394, 65661);

                int
                f_10853_65512_65649(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10853, 65512, 65649);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10853, 65394, 65661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10853, 65394, 65661);
            }
        }
    }
}
