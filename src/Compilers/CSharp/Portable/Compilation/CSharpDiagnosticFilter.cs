// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class CSharpDiagnosticFilter
    {
        private static readonly ErrorCode[] s_alinkWarnings;

        internal static Diagnostic? Filter(
                    Diagnostic d,
                    int warningLevelOption,
                    NullableContextOptions nullableOption,
                    ReportDiagnostic generalDiagnosticOption,
                    IDictionary<string, ReportDiagnostic> specificDiagnosticOptions,
                    SyntaxTreeOptionsProvider? syntaxTreeOptions,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10917, 1839, 5461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2257, 2897) || true) && (d == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2257, 2897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2304, 2313);

                    return d;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2257, 2897);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2257, 2897);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2347, 2897) || true) && (f_10917_2351_2372(d))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2347, 2897);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2406, 2753) || true) && (f_10917_2410_2430(d))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2406, 2753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2556, 2565);

                            return d;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2406, 2753);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2406, 2753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2722, 2734);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2406, 2753);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2347, 2897);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2347, 2897);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2787, 2897) || true) && (f_10917_2791_2801(d) == InternalDiagnosticSeverity.Void)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 2787, 2897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 2870, 2882);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2787, 2897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2347, 2897);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 2257, 2897);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 3698, 3728);

                ReportDiagnostic
                reportAction
                = default(ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 3742, 3768);

                bool
                hasPragmaSuppression
                = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 3782, 5272) || true) && (f_10917_3786_3829(s_alinkWarnings, f_10917_3822_3828(d)) && (DynAbs.Tracing.TraceSender.Expression_True(10917, 3786, 3970) && f_10917_3850_3970(f_10917_3850_3880(specificDiagnosticOptions), f_10917_3890_3969(CSharp.MessageProvider.Instance, ErrorCode.WRN_ALinkWarn))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 3782, 5272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 4004, 4672);

                    reportAction = f_10917_4019_4671(f_10917_4039_4086(ErrorCode.WRN_ALinkWarn), f_10917_4109_4129(d), f_10917_4152_4231(CSharp.MessageProvider.Instance, ErrorCode.WRN_ALinkWarn), f_10917_4254_4305(ErrorCode.WRN_ALinkWarn), f_10917_4328_4338(d), f_10917_4361_4371(d), warningLevelOption, nullableOption, generalDiagnosticOption, specificDiagnosticOptions, syntaxTreeOptions, cancellationToken, out hasPragmaSuppression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 3782, 5272);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 3782, 5272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 4738, 5257);

                    reportAction = f_10917_4753_5256(f_10917_4773_4783(d), f_10917_4806_4826(d), f_10917_4849_4853(d), f_10917_4876_4890(d), f_10917_4913_4923(d), f_10917_4946_4956(d), warningLevelOption, nullableOption, generalDiagnosticOption, specificDiagnosticOptions, syntaxTreeOptions, cancellationToken, out hasPragmaSuppression);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 3782, 5272);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 5288, 5390) || true) && (hasPragmaSuppression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 5288, 5390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 5346, 5375);

                    d = f_10917_5350_5374(d, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 5288, 5390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 5406, 5450);

                return f_10917_5413_5449(d, reportAction);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10917, 1839, 5461);

                bool
                f_10917_2351_2372(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsNotConfigurable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 2351, 2372);
                    return return_v;
                }


                bool
                f_10917_2410_2430(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 2410, 2430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10917_2791_2801(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 2791, 2801);
                    return return_v;
                }


                int
                f_10917_3822_3828(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 3822, 3828);
                    return return_v;
                }


                bool
                f_10917_3786_3829(Microsoft.CodeAnalysis.CSharp.ErrorCode[]
                list, int
                item)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.ErrorCode>((Microsoft.CodeAnalysis.CSharp.ErrorCode)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 3786, 3829);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_10917_3850_3880(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 3850, 3880);
                    return return_v;
                }


                string
                f_10917_3890_3969(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 3890, 3969);
                    return return_v;
                }


                bool
                f_10917_3850_3970(System.Collections.Generic.ICollection<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 3850, 3970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10917_4039_4086(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = ErrorFacts.GetSeverity(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 4039, 4086);
                    return return_v;
                }


                bool
                f_10917_4109_4129(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4109, 4129);
                    return return_v;
                }


                string
                f_10917_4152_4231(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 4152, 4231);
                    return return_v;
                }


                int
                f_10917_4254_4305(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = ErrorFacts.GetWarningLevel(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 4254, 4305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10917_4328_4338(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4328, 4338);
                    return return_v;
                }


                string
                f_10917_4361_4371(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4361, 4371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10917_4019_4671(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, bool
                isEnabledByDefault, string
                id, int
                diagnosticWarningLevel, Microsoft.CodeAnalysis.Location
                location, string
                category, int
                warningLevelOption, Microsoft.CodeAnalysis.NullableContextOptions
                nullableOption, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificDiagnosticOptions, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                syntaxTreeOptions, System.Threading.CancellationToken
                cancellationToken, out bool
                hasPragmaSuppression)
                {
                    var return_v = GetDiagnosticReport(severity, isEnabledByDefault, id, diagnosticWarningLevel, location, category, warningLevelOption, nullableOption, generalDiagnosticOption, specificDiagnosticOptions, syntaxTreeOptions, cancellationToken, out hasPragmaSuppression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 4019, 4671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10917_4773_4783(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4773, 4783);
                    return return_v;
                }


                bool
                f_10917_4806_4826(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.IsEnabledByDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4806, 4826);
                    return return_v;
                }


                string
                f_10917_4849_4853(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4849, 4853);
                    return return_v;
                }


                int
                f_10917_4876_4890(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4876, 4890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10917_4913_4923(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4913, 4923);
                    return return_v;
                }


                string
                f_10917_4946_4956(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 4946, 4956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10917_4753_5256(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, bool
                isEnabledByDefault, string
                id, int
                diagnosticWarningLevel, Microsoft.CodeAnalysis.Location
                location, string
                category, int
                warningLevelOption, Microsoft.CodeAnalysis.NullableContextOptions
                nullableOption, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificDiagnosticOptions, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                syntaxTreeOptions, System.Threading.CancellationToken
                cancellationToken, out bool
                hasPragmaSuppression)
                {
                    var return_v = GetDiagnosticReport(severity, isEnabledByDefault, id, diagnosticWarningLevel, location, category, warningLevelOption, nullableOption, generalDiagnosticOption, specificDiagnosticOptions, syntaxTreeOptions, cancellationToken, out hasPragmaSuppression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 4753, 5256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10917_5350_5374(Microsoft.CodeAnalysis.Diagnostic
                this_param, bool
                isSuppressed)
                {
                    var return_v = this_param.WithIsSuppressed(isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 5350, 5374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic?
                f_10917_5413_5449(Microsoft.CodeAnalysis.Diagnostic
                this_param, Microsoft.CodeAnalysis.ReportDiagnostic
                reportAction)
                {
                    var return_v = this_param.WithReportDiagnostic(reportAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 5413, 5449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10917, 1839, 5461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10917, 1839, 5461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ReportDiagnostic GetDiagnosticReport(
                    DiagnosticSeverity severity,
                    bool isEnabledByDefault,
                    string id,
                    int diagnosticWarningLevel,
                    Location location,
                    string category,
                    int warningLevelOption,
                    NullableContextOptions nullableOption,
                    ReportDiagnostic generalDiagnosticOption,
                    IDictionary<string, ReportDiagnostic> specificDiagnosticOptions,
                    SyntaxTreeOptionsProvider? syntaxTreeOptions,
                    CancellationToken cancellationToken,
                    out bool hasPragmaSuppression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10917, 6281, 14712);
                Microsoft.CodeAnalysis.ReportDiagnostic reportFromSyntaxTreeOptions = default(Microsoft.CodeAnalysis.ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 6941, 6970);

                hasPragmaSuppression = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 6986, 7071);

                f_10917_6986_7070(f_10917_6999_7018(location) is null || (DynAbs.Tracing.TraceSender.Expression_False(10917, 6999, 7069) || f_10917_7030_7049(location) is CSharpSyntaxTree));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7085, 7136);

                var
                tree = f_10917_7096_7115(location) as CSharpSyntaxTree
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7150, 7191);

                var
                position = location.SourceSpan.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7207, 7285);

                bool
                isNullableFlowAnalysisWarning = f_10917_7244_7284(ErrorFacts.NullableWarnings, id)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7299, 8385) || true) && (isNullableFlowAnalysisWarning)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 7299, 8385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7393, 7523);

                    Syntax.NullableContextState.State?
                    warningsState = (DynAbs.Tracing.TraceSender.Conditional_F1(10917, 7444, 7460) || ((tree is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10917, 7463, 7515)) || DynAbs.Tracing.TraceSender.Conditional_F3(10917, 7518, 7522))) ? f_10917_7463_7501(tree, position).WarningsState : null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7541, 8228);

                    var
                    nullableWarningsEnabled = warningsState switch
                    {
                        Syntax.NullableContextState.State.Enabled when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7632, 7681) && DynAbs.Tracing.TraceSender.Expression_True(10917, 7632, 7681))
=> true,
                        Syntax.NullableContextState.State.Disabled when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7704, 7755) && DynAbs.Tracing.TraceSender.Expression_True(10917, 7704, 7755))
=> false,
                        Syntax.NullableContextState.State.ExplicitlyRestored when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7778, 7866) && DynAbs.Tracing.TraceSender.Expression_True(10917, 7778, 7866))
=> f_10917_7834_7866(nullableOption),
                        Syntax.NullableContextState.State.Unknown when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 7889, 8062) && DynAbs.Tracing.TraceSender.Expression_True(10917, 7889, 8062))
=>
f_10917_7959_8018_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(tree, 10917, 7959, 8018)?.IsGeneratedCode(syntaxTreeOptions, cancellationToken)) != true && (DynAbs.Tracing.TraceSender.Expression_True(10917, 7959, 8062) && f_10917_8030_8062(nullableOption)),
                        null when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8085, 8125) && DynAbs.Tracing.TraceSender.Expression_True(10917, 8085, 8125))
=> f_10917_8093_8125(nullableOption),
                        _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8148, 8208) && DynAbs.Tracing.TraceSender.Expression_True(10917, 8148, 8208))
=> throw f_10917_8159_8208(warningsState)
                    }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8248, 8370) || true) && (!nullableWarningsEnabled)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 8248, 8370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8318, 8351);

                        return ReportDiagnostic.Suppress;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 8248, 8370);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 7299, 8385);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8434, 8591) || true) && (diagnosticWarningLevel > warningLevelOption)
                )  // honor the warning level

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 8434, 8591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8543, 8576);

                    return ReportDiagnostic.Suppress;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 8434, 8591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8607, 8631);

                ReportDiagnostic
                report
                = default(ReportDiagnostic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8645, 8670);

                bool
                isSpecified = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8684, 8723);

                bool
                specifiedWarnAsErrorMinus = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8739, 9203) || true) && (f_10917_8743_8796(specificDiagnosticOptions, id, out report))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 8739, 9203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 8898, 8917);

                    isSpecified = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 9056, 9188) || true) && (report == ReportDiagnostic.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 9056, 9188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 9136, 9169);

                        specifiedWarnAsErrorMinus = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 9056, 9188);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 8739, 9203);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 9277, 10607) || true) && (syntaxTreeOptions != null && (DynAbs.Tracing.TraceSender.Expression_True(10917, 9281, 9370) && (!isSpecified || (DynAbs.Tracing.TraceSender.Expression_False(10917, 9328, 9369) || specifiedWarnAsErrorMinus))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 9277, 10607);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 9698, 10592) || true) && ((tree != null && (DynAbs.Tracing.TraceSender.Expression_True(10917, 9703, 9824) && f_10917_9719_9824(syntaxTreeOptions, tree, id, cancellationToken, out reportFromSyntaxTreeOptions)) || (DynAbs.Tracing.TraceSender.Expression_False(10917, 9703, 9950) || f_10917_9849_9950(syntaxTreeOptions, id, cancellationToken, out reportFromSyntaxTreeOptions))) && (DynAbs.Tracing.TraceSender.Expression_True(10917, 9702, 10103) && !(specifiedWarnAsErrorMinus && (DynAbs.Tracing.TraceSender.Expression_True(10917, 9978, 10045) && severity == DiagnosticSeverity.Warning) && (DynAbs.Tracing.TraceSender.Expression_True(10917, 9978, 10102) && reportFromSyntaxTreeOptions == ReportDiagnostic.Error))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 9698, 10592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10145, 10164);

                        isSpecified = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10186, 10223);

                        report = reportFromSyntaxTreeOptions;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10350, 10573) || true) && (!specifiedWarnAsErrorMinus && (DynAbs.Tracing.TraceSender.Expression_True(10917, 10354, 10415) && report == ReportDiagnostic.Warn) && (DynAbs.Tracing.TraceSender.Expression_True(10917, 10354, 10468) && generalDiagnosticOption == ReportDiagnostic.Error))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 10350, 10573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10518, 10550);

                            report = ReportDiagnostic.Error;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 10350, 10573);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 9698, 10592);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 9277, 10607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10623, 10771) || true) && (!isSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 10623, 10771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10673, 10756);

                    report = (DynAbs.Tracing.TraceSender.Conditional_F1(10917, 10682, 10700) || ((isEnabledByDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10917, 10703, 10727)) || DynAbs.Tracing.TraceSender.Conditional_F3(10917, 10730, 10755))) ? ReportDiagnostic.Default : ReportDiagnostic.Suppress;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 10623, 10771);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10787, 10908) || true) && (report == ReportDiagnostic.Suppress)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 10787, 10908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10860, 10893);

                    return ReportDiagnostic.Suppress;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 10787, 10908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 10995, 11108);

                var
                pragmaWarningState = f_10917_11020_11070_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(tree, 10917, 11020, 11070)?.GetPragmaDirectiveWarningState(id, position)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState?>(10917, 11020, 11107) ?? Syntax.PragmaWarningState.Default)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11122, 11259) || true) && (pragmaWarningState == Syntax.PragmaWarningState.Disabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11122, 11259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11216, 11244);

                    hasPragmaSuppression = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11122, 11259);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11374, 12637) || true) && (pragmaWarningState == Syntax.PragmaWarningState.Enabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11374, 12637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11467, 12455);

                    switch (report)
                    {

                        case ReportDiagnostic.Error:
                        case ReportDiagnostic.Hidden:
                        case ReportDiagnostic.Info:
                        case ReportDiagnostic.Warn:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11467, 12455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11825, 11839);

                            return report;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11467, 12455);

                        case ReportDiagnostic.Suppress:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11467, 12455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 11967, 11999);

                            return ReportDiagnostic.Default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11467, 12455);

                        case ReportDiagnostic.Default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11467, 12455);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12079, 12269) || true) && (generalDiagnosticOption == ReportDiagnostic.Error && (DynAbs.Tracing.TraceSender.Expression_True(10917, 12083, 12154) && f_10917_12136_12154()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 12079, 12269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12212, 12242);

                                return ReportDiagnostic.Error;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 12079, 12269);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12297, 12329);

                            return ReportDiagnostic.Default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11467, 12455);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11467, 12455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12387, 12436);

                            throw f_10917_12393_12435(report);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11467, 12455);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11374, 12637);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 11374, 12637);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12489, 12637) || true) && (report == ReportDiagnostic.Suppress)
                    ) // check options (/nowarn)

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 12489, 12637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12589, 12622);

                        return ReportDiagnostic.Suppress;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 12489, 12637);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 11374, 12637);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12860, 14017) || true) && (report == ReportDiagnostic.Default)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 12860, 14017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 12932, 14002);

                    switch (generalDiagnosticOption)
                    {

                        case ReportDiagnostic.Error:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 12932, 14002);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 13059, 13196) || true) && (f_10917_13063_13081())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 13059, 13196);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 13139, 13169);

                                return ReportDiagnostic.Error;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 13059, 13196);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10917, 13222, 13228);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 12932, 14002);

                        case ReportDiagnostic.Suppress:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 12932, 14002);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 13701, 13951) || true) && (severity == DiagnosticSeverity.Warning || (DynAbs.Tracing.TraceSender.Expression_False(10917, 13705, 13782) || severity == DiagnosticSeverity.Info))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10917, 13701, 13951);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 13840, 13875);

                                report = ReportDiagnostic.Suppress;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 13905, 13924);

                                isSpecified = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 13701, 13951);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10917, 13977, 13983);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 12932, 14002);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10917, 12860, 14017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 14033, 14047);

                return report;

                bool promoteToAnError()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10917, 14063, 14701);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 14119, 14168);

                        f_10917_14119_14167(report == ReportDiagnostic.Default);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 14186, 14250);

                        f_10917_14186_14249(generalDiagnosticOption == ReportDiagnostic.Error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 14401, 14684);

                        return severity == DiagnosticSeverity.Warning && (DynAbs.Tracing.TraceSender.Expression_True(10917, 14408, 14683) &&                       // In the case where /warnaserror+ is followed by /warnaserror-:<n> on the command line,
                                                                                                                                                                   // do not promote the warning specified in <n> to an error.
                                               !isSpecified);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10917, 14063, 14701);

                        int
                        f_10917_14119_14167(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 14119, 14167);
                            return 0;
                        }


                        int
                        f_10917_14186_14249(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 14186, 14249);
                            return 0;
                        }


                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10917, 14063, 14701);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10917, 14063, 14701);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10917, 6281, 14712);

                Microsoft.CodeAnalysis.SyntaxTree?
                f_10917_6999_7018(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 6999, 7018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10917_7030_7049(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 7030, 7049);
                    return return_v;
                }


                int
                f_10917_6986_7070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 6986, 7070);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10917_7096_7115(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10917, 7096, 7115);
                    return return_v;
                }


                bool
                f_10917_7244_7284(System.Collections.Immutable.ImmutableHashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 7244, 7284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState
                f_10917_7463_7501(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, int
                position)
                {
                    var return_v = this_param.GetNullableContextState(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 7463, 7501);
                    return return_v;
                }


                bool
                f_10917_7834_7866(Microsoft.CodeAnalysis.NullableContextOptions
                context)
                {
                    var return_v = context.WarningsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 7834, 7866);
                    return return_v;
                }


                bool?
                f_10917_7959_8018_I(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 7959, 8018);
                    return return_v;
                }


                bool
                f_10917_8030_8062(Microsoft.CodeAnalysis.NullableContextOptions
                context)
                {
                    var return_v = context.WarningsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 8030, 8062);
                    return return_v;
                }


                bool
                f_10917_8093_8125(Microsoft.CodeAnalysis.NullableContextOptions
                context)
                {
                    var return_v = context.WarningsEnabled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 8093, 8125);
                    return return_v;
                }


                System.Exception
                f_10917_8159_8208(Microsoft.CodeAnalysis.CSharp.Syntax.NullableContextState.State?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 8159, 8208);
                    return return_v;
                }


                bool
                f_10917_8743_8796(System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 8743, 8796);
                    return return_v;
                }


                bool
                f_10917_9719_9824(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                tree, string
                diagnosticId, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = this_param.TryGetDiagnosticValue((Microsoft.CodeAnalysis.SyntaxTree)tree, diagnosticId, cancellationToken, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 9719, 9824);
                    return return_v;
                }


                bool
                f_10917_9849_9950(Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider
                this_param, string
                diagnosticId, System.Threading.CancellationToken
                cancellationToken, out Microsoft.CodeAnalysis.ReportDiagnostic
                severity)
                {
                    var return_v = this_param.TryGetGlobalDiagnosticValue(diagnosticId, cancellationToken, out severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 9849, 9950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState?
                f_10917_11020_11070_I(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 11020, 11070);
                    return return_v;
                }


                bool
                f_10917_12136_12154()
                {
                    var return_v = promoteToAnError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 12136, 12154);
                    return return_v;
                }


                System.Exception
                f_10917_12393_12435(Microsoft.CodeAnalysis.ReportDiagnostic
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 12393, 12435);
                    return return_v;
                }


                bool
                f_10917_13063_13081()
                {
                    var return_v = promoteToAnError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10917, 13063, 13081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10917, 6281, 14712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10917, 6281, 14712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpDiagnosticFilter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10917, 552, 14719);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10917, 649, 907);
            s_alinkWarnings = new ErrorCode[]{ ErrorCode.WRN_ConflictingMachineAssembly,
                                                              ErrorCode.WRN_RefCultureMismatch,
                                                              ErrorCode.WRN_InvalidVersionFormat }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10917, 552, 14719);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10917, 552, 14719);
        }

    }
}
