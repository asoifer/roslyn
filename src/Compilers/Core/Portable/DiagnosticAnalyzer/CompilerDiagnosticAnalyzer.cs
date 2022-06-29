// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class CompilerDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        internal abstract CommonMessageProvider MessageProvider { get; }

        internal abstract ImmutableArray<int> GetSupportedErrorCodes();

        public sealed override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(253, 773, 1605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1005, 1048);

                    var
                    messageProvider = f_253_1027_1047(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1066, 1113);

                    var
                    errorCodes = f_253_1083_1112(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1131, 1215);

                    var
                    builder = f_253_1145_1214(errorCodes.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1233, 1450);
                        foreach (var errorCode in f_253_1259_1269_I(errorCodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(253, 1233, 1450);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1311, 1385);

                            var
                            descriptor = f_253_1328_1384(errorCode, messageProvider)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1407, 1431);

                            f_253_1407_1430(builder, descriptor);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(253, 1233, 1450);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(253, 1, 218);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(253, 1, 218);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1470, 1543);

                    f_253_1470_1542(
                                    builder, f_253_1482_1541());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1561, 1590);

                    return f_253_1568_1589(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(253, 773, 1605);

                    Microsoft.CodeAnalysis.CommonMessageProvider
                    f_253_1027_1047(Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer
                    this_param)
                    {
                        var return_v = this_param.MessageProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(253, 1027, 1047);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_253_1083_1112(Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer
                    this_param)
                    {
                        var return_v = this_param.GetSupportedErrorCodes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1083, 1112);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>.Builder
                    f_253_1145_1214(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<DiagnosticDescriptor>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1145, 1214);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_253_1328_1384(int
                    errorCode, Microsoft.CodeAnalysis.CommonMessageProvider
                    messageProvider)
                    {
                        var return_v = DiagnosticInfo.GetDescriptor(errorCode, messageProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1328, 1384);
                        return return_v;
                    }


                    int
                    f_253_1407_1430(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>.Builder
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1407, 1430);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_253_1259_1269_I(System.Collections.Immutable.ImmutableArray<int>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1259, 1269);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticDescriptor
                    f_253_1482_1541()
                    {
                        var return_v = AnalyzerExecutor.GetAnalyzerExceptionDiagnosticDescriptor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1482, 1541);
                        return return_v;
                    }


                    int
                    f_253_1470_1542(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>.Builder
                    this_param, Microsoft.CodeAnalysis.DiagnosticDescriptor
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1470, 1542);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>
                    f_253_1568_1589(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticDescriptor>.Builder
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1568, 1589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(253, 668, 1616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(253, 668, 1616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override void Initialize(AnalysisContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(253, 1628, 2225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1716, 1752);

                f_253_1716_1751(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1766, 1888);

                f_253_1766_1887(context, GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(253, 1904, 2214);

                f_253_1904_2213(
                            context, c =>
                            {
                                var analyzer = new CompilationAnalyzer(c.Compilation);
                                c.RegisterSyntaxTreeAction(analyzer.AnalyzeSyntaxTree);
                                c.RegisterSemanticModelAction(CompilationAnalyzer.AnalyzeSemanticModel);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(253, 1628, 2225);

                int
                f_253_1716_1751(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param)
                {
                    this_param.EnableConcurrentExecution();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1716, 1751);
                    return 0;
                }


                int
                f_253_1766_1887(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, Microsoft.CodeAnalysis.Diagnostics.GeneratedCodeAnalysisFlags
                analysisMode)
                {
                    this_param.ConfigureGeneratedCodeAnalysis(analysisMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1766, 1887);
                    return 0;
                }


                int
                f_253_1904_2213(Microsoft.CodeAnalysis.Diagnostics.AnalysisContext
                this_param, System.Action<Microsoft.CodeAnalysis.Diagnostics.CompilationStartAnalysisContext>
                action)
                {
                    this_param.RegisterCompilationStartAction(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(253, 1904, 2213);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(253, 1628, 2225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(253, 1628, 2225);
            }
        }
    }
}
