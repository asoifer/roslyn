// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class AnalyzerDriver : IDisposable
    {
        internal class CompilationData
        {
            private readonly Dictionary<SyntaxReference, DeclarationAnalysisData> _declarationAnalysisDataMap;

            public CompilationData(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(221, 611, 1103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 567, 594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1119, 1185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1199, 1274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 691, 771);

                    f_221_691_770(f_221_704_737(compilation) is CachingSemanticModelProvider);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 791, 879);

                    SemanticModelProvider = (CachingSemanticModelProvider)f_221_845_878(compilation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 897, 981);

                    this.SuppressMessageAttributeState = f_221_934_980(compilation);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 999, 1088);

                    _declarationAnalysisDataMap = f_221_1029_1087();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(221, 611, 1103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(221, 611, 1103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(221, 611, 1103);
                }
            }

            public CachingSemanticModelProvider SemanticModelProvider { get; }

            public SuppressMessageAttributeState SuppressMessageAttributeState { get; }

            internal DeclarationAnalysisData GetOrComputeDeclarationAnalysisData(
                            SyntaxReference declaration,
                            Func<DeclarationAnalysisData> computeDeclarationAnalysisData,
                            bool cacheAnalysisData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(221, 1290, 2528);
                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData cachedData = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData);
                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData existingData = default(Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1558, 1681) || true) && (!cacheAnalysisData)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(221, 1558, 1681);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1622, 1662);

                        return f_221_1629_1661(computeDeclarationAnalysisData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(221, 1558, 1681);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1707, 1734);

                    lock (_declarationAnalysisDataMap)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1776, 1943) || true) && (f_221_1780_1852(_declarationAnalysisDataMap, declaration, out cachedData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(221, 1776, 1943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1902, 1920);

                            return cachedData;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(221, 1776, 1943);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 1982, 2046);

                    DeclarationAnalysisData
                    data = f_221_2013_2045(computeDeclarationAnalysisData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2072, 2099);

                    lock (_declarationAnalysisDataMap)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2141, 2462) || true) && (!f_221_2146_2220(_declarationAnalysisDataMap, declaration, out existingData))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(221, 2141, 2462);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2270, 2321);

                            f_221_2270_2320(_declarationAnalysisDataMap, declaration, data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(221, 2141, 2462);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(221, 2141, 2462);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2419, 2439);

                            data = existingData;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(221, 2141, 2462);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2501, 2513);

                    return data;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(221, 1290, 2528);

                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                    f_221_1629_1661(System.Func<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param)
                    {
                        var return_v = this_param.Invoke();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 1629, 1661);
                        return return_v;
                    }


                    bool
                    f_221_1780_1852(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param, Microsoft.CodeAnalysis.SyntaxReference
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 1780, 1852);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                    f_221_2013_2045(System.Func<Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param)
                    {
                        var return_v = this_param.Invoke();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 2013, 2045);
                        return return_v;
                    }


                    bool
                    f_221_2146_2220(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param, Microsoft.CodeAnalysis.SyntaxReference
                    key, out Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 2146, 2220);
                        return return_v;
                    }


                    int
                    f_221_2270_2320(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param, Microsoft.CodeAnalysis.SyntaxReference
                    key, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 2270, 2320);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(221, 1290, 2528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(221, 1290, 2528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void ClearDeclarationAnalysisData(SyntaxReference declaration)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(221, 2544, 2805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2654, 2681);
                    lock (_declarationAnalysisDataMap)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(221, 2723, 2771);

                        f_221_2723_2770(_declarationAnalysisDataMap, declaration);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(221, 2544, 2805);

                    bool
                    f_221_2723_2770(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
                    this_param, Microsoft.CodeAnalysis.SyntaxReference
                    key)
                    {
                        var return_v = this_param.Remove(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 2723, 2770);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(221, 2544, 2805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(221, 2544, 2805);
                }
            }

            static CompilationData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(221, 442, 2816);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(221, 442, 2816);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(221, 442, 2816);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(221, 442, 2816);

            static Microsoft.CodeAnalysis.SemanticModelProvider?
            f_221_704_737(Microsoft.CodeAnalysis.Compilation
            this_param)
            {
                var return_v = this_param.SemanticModelProvider;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(221, 704, 737);
                return return_v;
            }


            static int
            f_221_691_770(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 691, 770);
                return 0;
            }


            static Microsoft.CodeAnalysis.SemanticModelProvider
            f_221_845_878(Microsoft.CodeAnalysis.Compilation
            this_param)
            {
                var return_v = this_param.SemanticModelProvider;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(221, 845, 878);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState
            f_221_934_980(Microsoft.CodeAnalysis.Compilation
            compilation)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState(compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 934, 980);
                return return_v;
            }


            static System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>
            f_221_1029_1087()
            {
                var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.SyntaxReference, Microsoft.CodeAnalysis.Diagnostics.AnalyzerDriver.DeclarationAnalysisData>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(221, 1029, 1087);
                return return_v;
            }

        }

        static AnalyzerDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(221, 365, 2823);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 1099, 1118);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 1325, 1370);
            s_IsCompilerAnalyzerFunc = IsCompilerAnalyzer; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 1480, 1535);
            s_getTopmostNodeForAnalysis = GetTopmostNodeForAnalysis; DynAbs.Tracing.TraceSender.TraceSimpleStatement(222, 7069, 7186);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(221, 365, 2823);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(221, 365, 2823);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(221, 365, 2823);
    }
}
