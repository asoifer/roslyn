// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal abstract partial class CompilerDiagnosticAnalyzer : DiagnosticAnalyzer
    {
        private const string
        Origin = nameof(Origin)
        ;

        private const string
        Syntactic = nameof(Syntactic)
        ;

        private const string
        Declaration = nameof(Declaration)
        ;

        private static readonly ImmutableDictionary<string, string?> s_syntactic;

        private static readonly ImmutableDictionary<string, string?> s_declaration;
        private class CompilationAnalyzer
        {
            private readonly Compilation _compilation;

            public CompilationAnalyzer(Compilation compilation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(252, 1204, 1330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1175, 1187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1288, 1315);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(252, 1204, 1330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 1204, 1330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 1204, 1330);
                }
            }

            public void AnalyzeSyntaxTree(SyntaxTreeAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 1346, 1745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1443, 1507);

                    var
                    semanticModel = f_252_1463_1506(_compilation, context.Tree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1525, 1624);

                    var
                    diagnostics = f_252_1543_1623(semanticModel, cancellationToken: context.CancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1642, 1730);

                    f_252_1642_1729(diagnostics, context.ReportDiagnostic, IsSourceLocation, s_syntactic);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(252, 1346, 1745);

                    Microsoft.CodeAnalysis.SemanticModel
                    f_252_1463_1506(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.SyntaxTree
                    syntaxTree)
                    {
                        var return_v = this_param.GetSemanticModel(syntaxTree);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 1463, 1506);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_252_1543_1623(Microsoft.CodeAnalysis.SemanticModel
                    this_param, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = this_param.GetSyntaxDiagnostics(cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 1543, 1623);
                        return return_v;
                    }


                    int
                    f_252_1642_1729(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Location, bool>
                    locationFilter, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties)
                    {
                        ReportDiagnostics(diagnostics, reportDiagnostic, locationFilter, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 1642, 1729);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 1346, 1745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 1346, 1745);
                }
            }

            public static void AnalyzeSemanticModel(SemanticModelAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(252, 1761, 2346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 1871, 1987);

                    var
                    declDiagnostics = f_252_1893_1986(context.SemanticModel, cancellationToken: context.CancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2005, 2120);

                    var
                    bodyDiagnostics = f_252_2027_2119(context.SemanticModel, cancellationToken: context.CancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2140, 2234);

                    f_252_2140_2233(declDiagnostics, context.ReportDiagnostic, IsSourceLocation, s_declaration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2252, 2331);

                    f_252_2252_2330(bodyDiagnostics, context.ReportDiagnostic, IsSourceLocation);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(252, 1761, 2346);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_252_1893_1986(Microsoft.CodeAnalysis.SemanticModel
                    this_param, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = this_param.GetDeclarationDiagnostics(cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 1893, 1986);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_252_2027_2119(Microsoft.CodeAnalysis.SemanticModel
                    this_param, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = this_param.GetMethodBodyDiagnostics(cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 2027, 2119);
                        return return_v;
                    }


                    int
                    f_252_2140_2233(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Location, bool>
                    locationFilter, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties)
                    {
                        ReportDiagnostics(diagnostics, reportDiagnostic, locationFilter, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 2140, 2233);
                        return 0;
                    }


                    int
                    f_252_2252_2330(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Location, bool>
                    locationFilter)
                    {
                        ReportDiagnostics(diagnostics, reportDiagnostic, locationFilter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 2252, 2330);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 1761, 2346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 1761, 2346);
                }
            }

            public static void AnalyzeCompilation(CompilationAnalysisContext context)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(252, 2362, 2724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2468, 2578);

                    var
                    diagnostics = f_252_2486_2577(context.Compilation, cancellationToken: context.CancellationToken)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2596, 2709);

                    f_252_2596_2708(diagnostics, context.ReportDiagnostic, location => !IsSourceLocation(location), s_declaration);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(252, 2362, 2724);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_252_2486_2577(Microsoft.CodeAnalysis.Compilation
                    this_param, System.Threading.CancellationToken
                    cancellationToken)
                    {
                        var return_v = this_param.GetDeclarationDiagnostics(cancellationToken: cancellationToken);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 2486, 2577);
                        return return_v;
                    }


                    int
                    f_252_2596_2708(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    diagnostics, System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    reportDiagnostic, System.Func<Microsoft.CodeAnalysis.Location, bool>
                    locationFilter, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties)
                    {
                        ReportDiagnostics(diagnostics, reportDiagnostic, locationFilter, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 2596, 2708);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 2362, 2724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 2362, 2724);
                }
            }

            private static bool IsSourceLocation(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(252, 2740, 2911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 2828, 2896);

                    return location != null && (DynAbs.Tracing.TraceSender.Expression_True(252, 2835, 2895) && f_252_2855_2868(location) == LocationKind.SourceFile);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(252, 2740, 2911);

                    Microsoft.CodeAnalysis.LocationKind
                    f_252_2855_2868(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 2855, 2868);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 2740, 2911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 2740, 2911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void ReportDiagnostics(
                            ImmutableArray<Diagnostic> diagnostics,
                            Action<Diagnostic> reportDiagnostic,
                            Func<Location, bool> locationFilter,
                            ImmutableDictionary<string, string?>? properties = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(252, 2927, 3687);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3237, 3672);
                        foreach (var diagnostic in f_252_3264_3275_I(diagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(252, 3237, 3672);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3317, 3653) || true) && (f_252_3321_3356(locationFilter, f_252_3336_3355(diagnostic)) && (DynAbs.Tracing.TraceSender.Expression_True(252, 3321, 3433) && f_252_3385_3404(diagnostic) != DiagnosticSeverity.Hidden))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(252, 3317, 3653);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3483, 3578);

                                var
                                current = (DynAbs.Tracing.TraceSender.Conditional_F1(252, 3497, 3515) || ((properties == null && DynAbs.Tracing.TraceSender.Conditional_F2(252, 3518, 3528)) || DynAbs.Tracing.TraceSender.Conditional_F3(252, 3531, 3577))) ? diagnostic : f_252_3531_3577(diagnostic, properties)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3604, 3630);

                                f_252_3604_3629(reportDiagnostic, current);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(252, 3317, 3653);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(252, 3237, 3672);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(252, 1, 436);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(252, 1, 436);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(252, 2927, 3687);

                    Microsoft.CodeAnalysis.Location
                    f_252_3336_3355(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 3336, 3355);
                        return return_v;
                    }


                    bool
                    f_252_3321_3356(System.Func<Microsoft.CodeAnalysis.Location, bool>
                    this_param, Microsoft.CodeAnalysis.Location
                    arg)
                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 3321, 3356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticSeverity
                    f_252_3385_3404(Microsoft.CodeAnalysis.Diagnostic
                    this_param)
                    {
                        var return_v = this_param.Severity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 3385, 3404);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic
                    f_252_3531_3577(Microsoft.CodeAnalysis.Diagnostic
                    original, System.Collections.Immutable.ImmutableDictionary<string, string?>
                    properties)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic(original, properties);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 3531, 3577);
                        return return_v;
                    }


                    int
                    f_252_3604_3629(System.Action<Microsoft.CodeAnalysis.Diagnostic>
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 3604, 3629);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    f_252_3264_3275_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 3264, 3275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 2927, 3687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 2927, 3687);
                }
            }
            private class CompilerDiagnostic : Diagnostic
            {
                private readonly Diagnostic _original;

                private readonly ImmutableDictionary<string, string?> _properties;

                public CompilerDiagnostic(Diagnostic original, ImmutableDictionary<string, string?> properties)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(252, 3923, 4146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3809, 3818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 3891, 3902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4059, 4080);

                        _original = original;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4102, 4127);

                        _properties = properties;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(252, 3923, 4146);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 3923, 4146);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 3923, 4146);
                    }
                }

                public override DiagnosticDescriptor Descriptor
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4286, 4309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4289, 4309);
                            return f_252_4289_4309(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4286, 4309);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4286, 4309);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4286, 4309);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal override int Code
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4390, 4407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4393, 4407);
                            return f_252_4393_4407(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4390, 4407);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4390, 4407);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4390, 4407);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                internal override IReadOnlyList<object?> Arguments
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4477, 4499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4480, 4499);
                            return f_252_4480_4499(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4477, 4499);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4477, 4499);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4477, 4499);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override string Id
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4546, 4561);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4549, 4561);
                            return f_252_4549_4561(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4546, 4561);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4546, 4561);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4546, 4561);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override DiagnosticSeverity Severity
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4624, 4645);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4627, 4645);
                            return f_252_4627_4645(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4624, 4645);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4624, 4645);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4624, 4645);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override int WarningLevel
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4697, 4722);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4700, 4722);
                            return f_252_4700_4722(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4697, 4722);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4697, 4722);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4697, 4722);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override Location Location
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4775, 4796);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4778, 4796);
                            return f_252_4778_4796(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4775, 4796);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4775, 4796);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4775, 4796);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override IReadOnlyList<Location> AdditionalLocations
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4875, 4907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4878, 4907);
                            return f_252_4878_4907(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4875, 4907);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4875, 4907);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4875, 4907);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override bool IsSuppressed
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 4960, 4985);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 4963, 4985);
                            return f_252_4963_4985(_original); DynAbs.Tracing.TraceSender.TraceExitMethod(252, 4960, 4985);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 4960, 4985);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 4960, 4985);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override ImmutableDictionary<string, string?> Properties
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5068, 5082);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5071, 5082);
                            return _properties; DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5068, 5082);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5068, 5082);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5068, 5082);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                public override string GetMessage(IFormatProvider? formatProvider = null)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5103, 5280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5217, 5261);

                        return f_252_5224_5260(_original, formatProvider);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5103, 5280);

                        string
                        f_252_5224_5260(Microsoft.CodeAnalysis.Diagnostic
                        this_param, System.IFormatProvider?
                        formatProvider)
                        {
                            var return_v = this_param.GetMessage(formatProvider);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5224, 5260);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5103, 5280);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5103, 5280);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool Equals(object? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5300, 5429);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5381, 5410);

                        return f_252_5388_5409(_original, obj);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5300, 5429);

                        bool
                        f_252_5388_5409(Microsoft.CodeAnalysis.Diagnostic
                        this_param, object?
                        obj)
                        {
                            var return_v = this_param.Equals(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5388, 5409);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5300, 5429);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5300, 5429);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override int GetHashCode()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5449, 5573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5523, 5554);

                        return f_252_5530_5553(_original);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5449, 5573);

                        int
                        f_252_5530_5553(Microsoft.CodeAnalysis.Diagnostic
                        this_param)
                        {
                            var return_v = this_param.GetHashCode();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5530, 5553);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5449, 5573);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5449, 5573);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override bool Equals(Diagnostic? obj)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5593, 5726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5678, 5707);

                        return f_252_5685_5706(_original, obj);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5593, 5726);

                        bool
                        f_252_5685_5706(Microsoft.CodeAnalysis.Diagnostic
                        this_param, Microsoft.CodeAnalysis.Diagnostic?
                        obj)
                        {
                            var return_v = this_param.Equals(obj);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5685, 5706);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5593, 5726);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5593, 5726);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override Diagnostic WithLocation(Location location)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5746, 5943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 5847, 5924);

                        return f_252_5854_5923(f_252_5877_5909(_original, location), _properties);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5746, 5943);

                        Microsoft.CodeAnalysis.Diagnostic
                        f_252_5877_5909(Microsoft.CodeAnalysis.Diagnostic
                        this_param, Microsoft.CodeAnalysis.Location
                        location)
                        {
                            var return_v = this_param.WithLocation(location);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5877, 5909);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic
                        f_252_5854_5923(Microsoft.CodeAnalysis.Diagnostic
                        original, System.Collections.Immutable.ImmutableDictionary<string, string?>
                        properties)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic(original, properties);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 5854, 5923);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5746, 5943);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5746, 5943);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 5963, 6170);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 6074, 6151);

                        return f_252_6081_6150(f_252_6104_6136(_original, severity), _properties);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 5963, 6170);

                        Microsoft.CodeAnalysis.Diagnostic
                        f_252_6104_6136(Microsoft.CodeAnalysis.Diagnostic
                        this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                        severity)
                        {
                            var return_v = this_param.WithSeverity(severity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 6104, 6136);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic
                        f_252_6081_6150(Microsoft.CodeAnalysis.Diagnostic
                        original, System.Collections.Immutable.ImmutableDictionary<string, string?>
                        properties)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic(original, properties);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 6081, 6150);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 5963, 6170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 5963, 6170);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                internal override Diagnostic WithIsSuppressed(bool isSuppressed)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(252, 6190, 6399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 6295, 6380);

                        return f_252_6302_6379(f_252_6325_6365(_original, isSuppressed), _properties);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(252, 6190, 6399);

                        Microsoft.CodeAnalysis.Diagnostic
                        f_252_6325_6365(Microsoft.CodeAnalysis.Diagnostic
                        this_param, bool
                        isSuppressed)
                        {
                            var return_v = this_param.WithIsSuppressed(isSuppressed);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 6325, 6365);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic
                        f_252_6302_6379(Microsoft.CodeAnalysis.Diagnostic
                        original, System.Collections.Immutable.ImmutableDictionary<string, string?>
                        properties)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.CompilerDiagnosticAnalyzer.CompilationAnalyzer.CompilerDiagnostic(original, properties);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 6302, 6379);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(252, 6190, 6399);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 6190, 6399);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static CompilerDiagnostic()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(252, 3703, 6414);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(252, 3703, 6414);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 3703, 6414);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(252, 3703, 6414);

                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_252_4289_4309(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Descriptor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4289, 4309);
                    return return_v;
                }


                int
                f_252_4393_4407(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4393, 4407);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_252_4480_4499(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4480, 4499);
                    return return_v;
                }


                string
                f_252_4549_4561(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4549, 4561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_252_4627_4645(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4627, 4645);
                    return return_v;
                }


                int
                f_252_4700_4722(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4700, 4722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_252_4778_4796(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4778, 4796);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
                f_252_4878_4907(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.AdditionalLocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4878, 4907);
                    return return_v;
                }


                bool
                f_252_4963_4985(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(252, 4963, 4985);
                    return return_v;
                }

            }

            static CompilationAnalyzer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(252, 1088, 6425);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(252, 1088, 6425);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 1088, 6425);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(252, 1088, 6425);
        }

        public CompilerDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(252, 350, 6432);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(252, 350, 6432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 350, 6432);
        }


        static CompilerDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(252, 350, 6432);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 467, 490);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 522, 551);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 583, 616);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 690, 769);
            s_syntactic = f_252_704_769(ImmutableDictionary<string, string?>.Empty, Origin, Syntactic); DynAbs.Tracing.TraceSender.TraceSimpleStatement(252, 841, 924);
            s_declaration = f_252_857_924(ImmutableDictionary<string, string?>.Empty, Origin, Declaration); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(252, 350, 6432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(252, 350, 6432);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(252, 350, 6432);

        static System.Collections.Immutable.ImmutableDictionary<string, string?>
        f_252_704_769(System.Collections.Immutable.ImmutableDictionary<string, string?>
        this_param, string
        key, string
        value)
        {
            var return_v = this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 704, 769);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableDictionary<string, string?>
        f_252_857_924(System.Collections.Immutable.ImmutableDictionary<string, string?>
        this_param, string
        key, string
        value)
        {
            var return_v = this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(252, 857, 924);
            return return_v;
        }

    }
}
