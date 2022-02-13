// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
    internal struct MemberAnalysisResult
    {

        public readonly ImmutableArray<Conversion> ConversionsOpt;

        public readonly ImmutableArray<int> BadArgumentsOpt;

        public readonly ImmutableArray<int> ArgsToParamsOpt;

        public readonly ImmutableArray<TypeParameterDiagnosticInfo> ConstraintFailureDiagnostics;

        public readonly int BadParameter;

        public readonly MemberResolutionKind Kind;

        public readonly bool HasAnyRefOmittedArgument;

        private MemberAnalysisResult(
                    MemberResolutionKind kind,
                    ImmutableArray<int> badArgumentsOpt = default,
                    ImmutableArray<int> argsToParamsOpt = default,
                    ImmutableArray<Conversion> conversionsOpt = default,
                    int missingParameter = -1,
                    bool hasAnyRefOmittedArgument = false,
                    ImmutableArray<TypeParameterDiagnosticInfo> constraintFailureDiagnosticsOpt = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10869, 1436, 2311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 1908, 1925);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 1939, 1978);

                this.BadArgumentsOpt = badArgumentsOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 1992, 2031);

                this.ArgsToParamsOpt = argsToParamsOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2045, 2082);

                this.ConversionsOpt = conversionsOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2096, 2133);

                this.BadParameter = missingParameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2147, 2204);

                this.HasAnyRefOmittedArgument = hasAnyRefOmittedArgument;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2218, 2300);

                this.ConstraintFailureDiagnostics = constraintFailureDiagnosticsOpt.NullToEmpty();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10869, 1436, 2311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 1436, 2311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 1436, 2311);
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 2323, 2435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2387, 2424);

                throw f_10869_2393_2423();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 2323, 2435);

                System.Exception
                f_10869_2393_2423()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10869, 2393, 2423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 2323, 2435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 2323, 2435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 2447, 2553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2505, 2542);

                throw f_10869_2511_2541();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 2447, 2553);

                System.Exception
                f_10869_2511_2541()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10869, 2511, 2541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 2447, 2553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 2447, 2553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ConversionForArg(int arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 2565, 2801);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2633, 2742) || true) && (this.ConversionsOpt.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 2633, 2742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2700, 2727);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 2633, 2742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2758, 2790);

                return this.ConversionsOpt[arg];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 2565, 2801);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 2565, 2801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 2565, 2801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int ParameterFromArgument(int arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 2813, 3115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2879, 2902);

                f_10869_2879_2901(arg >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2916, 3005) || true) && (ArgsToParamsOpt.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 2916, 3005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 2979, 2990);

                    return arg;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 2916, 3005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3019, 3062);

                f_10869_3019_3061(arg < ArgsToParamsOpt.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3076, 3104);

                return ArgsToParamsOpt[arg];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 2813, 3115);

                int
                f_10869_2879_2901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 2879, 2901);
                    return 0;
                }


                int
                f_10869_3019_3061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 3019, 3061);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 2813, 3115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 2813, 3115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsApplicable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 3247, 3713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3283, 3698);

                    switch (this.Kind)
                    {

                        case MemberResolutionKind.ApplicableInNormalForm:
                        case MemberResolutionKind.ApplicableInExpandedForm:
                        case MemberResolutionKind.Worse:
                        case MemberResolutionKind.Worst:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 3283, 3698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3598, 3610);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 3283, 3698);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 3283, 3698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3666, 3679);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 3283, 3698);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 3247, 3713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 3198, 3724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 3198, 3724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 3780, 4138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 3816, 4123);

                    switch (this.Kind)
                    {

                        case MemberResolutionKind.ApplicableInNormalForm:
                        case MemberResolutionKind.ApplicableInExpandedForm:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 3816, 4123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 4023, 4035);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 3816, 4123);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 3816, 4123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 4091, 4104);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 3816, 4123);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 3780, 4138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 3736, 4149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 3736, 4149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasUseSiteDiagnosticToReportFor(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10869, 4402, 4799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 4651, 4788);

                return !SuppressUseSiteDiagnosticsForKind(this.Kind) && (DynAbs.Tracing.TraceSender.Expression_True(10869, 4658, 4746) && (object)symbol != null) && (DynAbs.Tracing.TraceSender.Expression_True(10869, 4658, 4787) && f_10869_4750_4779(symbol) != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10869, 4402, 4799);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10869_4750_4779(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 4750, 4779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 4402, 4799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 4402, 4799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool SuppressUseSiteDiagnosticsForKind(MemberResolutionKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 4811, 5774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 4916, 5763);

                switch (kind)
                {

                    case MemberResolutionKind.UnsupportedMetadata:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 4916, 5763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 5030, 5042);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 4916, 5763);

                    case MemberResolutionKind.NoCorrespondingParameter:
                    case MemberResolutionKind.NoCorrespondingNamedParameter:
                    case MemberResolutionKind.DuplicateNamedArgument:
                    case MemberResolutionKind.NameUsedForPositional:
                    case MemberResolutionKind.RequiredParameterMissing:
                    case MemberResolutionKind.LessDerived:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 4916, 5763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 5675, 5687);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 4916, 5763);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 4916, 5763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 5735, 5748);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 4916, 5763);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 4811, 5774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 4811, 5774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 4811, 5774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult ArgumentParameterMismatch(ArgumentAnalysisResult argAnalysis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 5786, 7041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 5907, 7030);

                switch (argAnalysis.Kind)
                {

                    case ArgumentAnalysisResultKind.NoCorrespondingParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6044, 6106);

                        return NoCorrespondingParameter(argAnalysis.ArgumentPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    case ArgumentAnalysisResultKind.NoCorrespondingNamedParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6208, 6275);

                        return NoCorrespondingNamedParameter(argAnalysis.ArgumentPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    case ArgumentAnalysisResultKind.DuplicateNamedArgument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6370, 6430);

                        return DuplicateNamedArgument(argAnalysis.ArgumentPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    case ArgumentAnalysisResultKind.RequiredParameterMissing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6527, 6590);

                        return RequiredParameterMissing(argAnalysis.ParameterPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    case ArgumentAnalysisResultKind.NameUsedForPositional:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6684, 6743);

                        return NameUsedForPositional(argAnalysis.ArgumentPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    case ArgumentAnalysisResultKind.BadNonTrailingNamedArgument:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6843, 6908);

                        return BadNonTrailingNamedArgument(argAnalysis.ArgumentPosition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10869, 5907, 7030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 6956, 7015);

                        throw f_10869_6962_7014(argAnalysis.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10869, 5907, 7030);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 5786, 7041);

                System.Exception
                f_10869_6962_7014(Microsoft.CodeAnalysis.CSharp.ArgumentAnalysisResultKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 6962, 7014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 5786, 7041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 5786, 7041);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult NameUsedForPositional(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 7053, 7341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 7156, 7330);

                return f_10869_7163_7329(MemberResolutionKind.NameUsedForPositional, badArgumentsOpt: f_10869_7284_7328(argumentPosition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 7053, 7341);

                System.Collections.Immutable.ImmutableArray<int>
                f_10869_7284_7328(int
                item)
                {
                    var return_v = ImmutableArray.Create<int>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7284, 7328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_7163_7329(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt: badArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7163, 7329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 7053, 7341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 7053, 7341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult BadNonTrailingNamedArgument(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 7353, 7653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 7462, 7642);

                return f_10869_7469_7641(MemberResolutionKind.BadNonTrailingNamedArgument, badArgumentsOpt: f_10869_7596_7640(argumentPosition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 7353, 7653);

                System.Collections.Immutable.ImmutableArray<int>
                f_10869_7596_7640(int
                item)
                {
                    var return_v = ImmutableArray.Create<int>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7596, 7640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_7469_7641(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt: badArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7469, 7641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 7353, 7653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 7353, 7653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult NoCorrespondingParameter(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 7665, 7959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 7771, 7948);

                return f_10869_7778_7947(MemberResolutionKind.NoCorrespondingParameter, badArgumentsOpt: f_10869_7902_7946(argumentPosition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 7665, 7959);

                System.Collections.Immutable.ImmutableArray<int>
                f_10869_7902_7946(int
                item)
                {
                    var return_v = ImmutableArray.Create<int>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7902, 7946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_7778_7947(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt: badArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 7778, 7947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 7665, 7959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 7665, 7959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult NoCorrespondingNamedParameter(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 7971, 8275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 8082, 8264);

                return f_10869_8089_8263(MemberResolutionKind.NoCorrespondingNamedParameter, badArgumentsOpt: f_10869_8218_8262(argumentPosition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 7971, 8275);

                System.Collections.Immutable.ImmutableArray<int>
                f_10869_8218_8262(int
                item)
                {
                    var return_v = ImmutableArray.Create<int>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8218, 8262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_8089_8263(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt: badArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8089, 8263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 7971, 8275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 7971, 8275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult DuplicateNamedArgument(int argumentPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 8287, 8577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 8391, 8566);

                return f_10869_8398_8565(MemberResolutionKind.DuplicateNamedArgument, badArgumentsOpt: f_10869_8520_8564(argumentPosition));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 8287, 8577);

                System.Collections.Immutable.ImmutableArray<int>
                f_10869_8520_8564(int
                item)
                {
                    var return_v = ImmutableArray.Create<int>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8520, 8564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_8398_8565(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt: badArgumentsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8398, 8565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 8287, 8577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 8287, 8577);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult RequiredParameterMissing(int parameterPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 8589, 8858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 8696, 8847);

                return f_10869_8703_8846(MemberResolutionKind.RequiredParameterMissing, missingParameter: parameterPosition);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 8589, 8858);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_8703_8846(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, int
                missingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, missingParameter: missingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8703, 8846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 8589, 8858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 8589, 8858);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult UseSiteError()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 8870, 9022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 8944, 9011);

                return f_10869_8951_9010(MemberResolutionKind.UseSiteError);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 8870, 9022);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_8951_9010(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 8951, 9010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 8870, 9022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 8870, 9022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult UnsupportedMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 9034, 9200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9115, 9189);

                return f_10869_9122_9188(MemberResolutionKind.UnsupportedMetadata);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 9034, 9200);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_9122_9188(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9122, 9188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 9034, 9200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 9034, 9200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult BadArgumentConversions(ImmutableArray<int> argsToParamsOpt, ImmutableArray<int> badArguments, ImmutableArray<Conversion> conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 9212, 9710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9405, 9443);

                f_10869_9405_9442(conversions.Length != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9457, 9496);

                f_10869_9457_9495(badArguments.Length != 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9510, 9699);

                return f_10869_9517_9698(MemberResolutionKind.BadArgumentConversion, badArguments, argsToParamsOpt, conversions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 9212, 9710);

                int
                f_10869_9405_9442(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9405, 9442);
                    return 0;
                }


                int
                f_10869_9457_9495(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9457, 9495);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_9517_9698(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                conversionsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt, argsToParamsOpt, conversionsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9517, 9698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 9212, 9710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 9212, 9710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult InaccessibleTypeArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 9722, 9898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9808, 9887);

                return f_10869_9815_9886(MemberResolutionKind.InaccessibleTypeArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 9722, 9898);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_9815_9886(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9815, 9886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 9722, 9898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 9722, 9898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult TypeInferenceFailed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 9910, 10076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 9991, 10065);

                return f_10869_9998_10064(MemberResolutionKind.TypeInferenceFailed);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 9910, 10076);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_9998_10064(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 9998, 10064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 9910, 10076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 9910, 10076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult TypeInferenceExtensionInstanceArgumentFailed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 10088, 10298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 10194, 10287);

                return f_10869_10201_10286(MemberResolutionKind.TypeInferenceExtensionInstanceArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 10088, 10298);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_10201_10286(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 10201, 10286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 10088, 10298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 10088, 10298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult StaticInstanceMismatch()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 10310, 10482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 10394, 10471);

                return f_10869_10401_10470(MemberResolutionKind.StaticInstanceMismatch);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 10310, 10482);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_10401_10470(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 10401, 10470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 10310, 10482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 10310, 10482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult ConstructedParameterFailedConstraintsCheck(int parameterPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 10494, 10798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 10619, 10787);

                return f_10869_10626_10786(MemberResolutionKind.ConstructedParameterFailedConstraintCheck, missingParameter: parameterPosition);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 10494, 10798);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_10626_10786(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, int
                missingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, missingParameter: missingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 10626, 10786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 10494, 10798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 10494, 10798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult WrongRefKind()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 10810, 10962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 10884, 10951);

                return f_10869_10891_10950(MemberResolutionKind.WrongRefKind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 10810, 10962);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_10891_10950(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 10891, 10950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 10810, 10962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 10810, 10962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult WrongReturnType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 10974, 11132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 11051, 11121);

                return f_10869_11058_11120(MemberResolutionKind.WrongReturnType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 10974, 11132);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_11058_11120(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 11058, 11120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 10974, 11132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 10974, 11132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult LessDerived()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 11144, 11294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 11217, 11283);

                return f_10869_11224_11282(MemberResolutionKind.LessDerived);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 11144, 11294);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_11224_11282(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 11224, 11282);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 11144, 11294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 11144, 11294);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult NormalForm(ImmutableArray<int> argsToParamsOpt, ImmutableArray<Conversion> conversions, bool hasAnyRefOmittedArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 11306, 11684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 11484, 11673);

                return f_10869_11491_11672(MemberResolutionKind.ApplicableInNormalForm, default(ImmutableArray<int>), argsToParamsOpt, conversions, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 11306, 11684);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_11491_11672(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                conversionsOpt, bool
                hasAnyRefOmittedArgument)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt, argsToParamsOpt, conversionsOpt, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 11491, 11672);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 11306, 11684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 11306, 11684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult ExpandedForm(ImmutableArray<int> argsToParamsOpt, ImmutableArray<Conversion> conversions, bool hasAnyRefOmittedArgument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 11696, 12078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 11876, 12067);

                return f_10869_11883_12066(MemberResolutionKind.ApplicableInExpandedForm, default(ImmutableArray<int>), argsToParamsOpt, conversions, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 11696, 12078);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_11883_12066(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<int>
                badArgumentsOpt, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                conversionsOpt, bool
                hasAnyRefOmittedArgument)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, badArgumentsOpt, argsToParamsOpt, conversionsOpt, hasAnyRefOmittedArgument: hasAnyRefOmittedArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 11883, 12066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 11696, 12078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 11696, 12078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult Worse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 12090, 12228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 12157, 12217);

                return f_10869_12164_12216(MemberResolutionKind.Worse);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 12090, 12228);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_12164_12216(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 12164, 12216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 12090, 12228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 12090, 12228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static MemberAnalysisResult Worst()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 12240, 12378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 12307, 12367);

                return f_10869_12314_12366(MemberResolutionKind.Worst);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 12240, 12378);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_12314_12366(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 12314, 12366);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 12240, 12378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 12240, 12378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MemberAnalysisResult ConstraintFailure(ImmutableArray<TypeParameterDiagnosticInfo> constraintFailureDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 12390, 12689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 12543, 12678);

                return f_10869_12550_12677(MemberResolutionKind.ConstraintFailure, constraintFailureDiagnosticsOpt: constraintFailureDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 12390, 12689);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_12550_12677(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterDiagnosticInfo>
                constraintFailureDiagnosticsOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind, constraintFailureDiagnosticsOpt: constraintFailureDiagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 12550, 12677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 12390, 12689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 12390, 12689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MemberAnalysisResult WrongCallingConvention()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10869, 12701, 12875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10869, 12787, 12864);

                return f_10869_12794_12863(MemberResolutionKind.WrongCallingConvention);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10869, 12701, 12875);

                Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult
                f_10869_12794_12863(Microsoft.CodeAnalysis.CSharp.MemberResolutionKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MemberAnalysisResult(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10869, 12794, 12863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10869, 12701, 12875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 12701, 12875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static MemberAnalysisResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10869, 454, 12882);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10869, 454, 12882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10869, 454, 12882);
        }
    }
}
