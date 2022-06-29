// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed class SuppressionDescriptor : IEquatable<SuppressionDescriptor?>
    {
        public string Id { get; }

        public string SuppressedDiagnosticId { get; }

        public LocalizableString Justification { get; }

        public SuppressionDescriptor(
                    string id,
                    string suppressedDiagnosticId,
                    string justification)
        : this(f_202_2102_2104_C(id), suppressedDiagnosticId, (LocalizableString)justification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(202, 1949, 2185);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(202, 1949, 2185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 1949, 2185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 1949, 2185);
            }
        }

        public SuppressionDescriptor(
                    string id,
                    string suppressedDiagnosticId,
                    LocalizableString justification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(202, 2874, 3673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 706, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 878, 923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 1046, 1093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3042, 3223) || true) && (f_202_3046_3075(id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(202, 3042, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3109, 3208);

                    throw f_202_3115_3207(f_202_3137_3194(), nameof(id));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(202, 3042, 3223);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3239, 3459) || true) && (f_202_3243_3292(suppressedDiagnosticId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(202, 3239, 3459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3326, 3444);

                    throw f_202_3332_3443(f_202_3354_3410(), nameof(suppressedDiagnosticId));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(202, 3239, 3459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3475, 3488);

                this.Id = id;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3502, 3555);

                this.SuppressedDiagnosticId = suppressedDiagnosticId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3569, 3662);

                this.Justification = justification ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.LocalizableString>(202, 3590, 3661) ?? throw f_202_3613_3661(nameof(justification)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(202, 2874, 3673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 2874, 3673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 2874, 3673);
            }
        }

        public bool Equals(SuppressionDescriptor? other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(202, 3685, 4103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3758, 3851) || true) && (f_202_3762_3790(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(202, 3758, 3851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3824, 3836);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(202, 3758, 3851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 3867, 4092);

                return
                                other != null && (DynAbs.Tracing.TraceSender.Expression_True(202, 3891, 3944) && f_202_3925_3932(this) == f_202_3936_3944(other)) && (DynAbs.Tracing.TraceSender.Expression_True(202, 3891, 4024) && f_202_3965_3992(this) == f_202_3996_4024(other)) && (DynAbs.Tracing.TraceSender.Expression_True(202, 3891, 4091) && f_202_4045_4091(f_202_4045_4063(this), f_202_4071_4090(other)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(202, 3685, 4103);

                bool
                f_202_3762_3790(Microsoft.CodeAnalysis.SuppressionDescriptor
                objA, Microsoft.CodeAnalysis.SuppressionDescriptor?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3762, 3790);
                    return return_v;
                }


                string
                f_202_3925_3932(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3925, 3932);
                    return return_v;
                }


                string
                f_202_3936_3944(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3936, 3944);
                    return return_v;
                }


                string
                f_202_3965_3992(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.SuppressedDiagnosticId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3965, 3992);
                    return return_v;
                }


                string
                f_202_3996_4024(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.SuppressedDiagnosticId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3996, 4024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_202_4045_4063(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Justification;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4045, 4063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_202_4071_4090(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Justification;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4071, 4090);
                    return return_v;
                }


                bool
                f_202_4045_4091(Microsoft.CodeAnalysis.LocalizableString
                this_param, Microsoft.CodeAnalysis.LocalizableString
                other)
                {
                    var return_v = this_param.Equals(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4045, 4091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 3685, 4103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 3685, 4103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(202, 4115, 4235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 4180, 4224);

                return f_202_4187_4223(this, obj as SuppressionDescriptor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(202, 4115, 4235);

                bool
                f_202_4187_4223(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param, object?
                other)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.SuppressionDescriptor?)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4187, 4223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 4115, 4235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 4115, 4235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(202, 4247, 4470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 4305, 4459);

                return f_202_4312_4458(f_202_4325_4346(f_202_4325_4332(this)), f_202_4368_4457(f_202_4381_4422(f_202_4381_4408(this)), f_202_4424_4456(f_202_4424_4442(this))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(202, 4247, 4470);

                string
                f_202_4325_4332(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4325, 4332);
                    return return_v;
                }


                int
                f_202_4325_4346(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4325, 4346);
                    return return_v;
                }


                string
                f_202_4381_4408(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.SuppressedDiagnosticId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4381, 4408);
                    return return_v;
                }


                int
                f_202_4381_4422(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4381, 4422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_202_4424_4442(Microsoft.CodeAnalysis.SuppressionDescriptor
                this_param)
                {
                    var return_v = this_param.Justification;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4424, 4442);
                    return return_v;
                }


                int
                f_202_4424_4456(Microsoft.CodeAnalysis.LocalizableString
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4424, 4456);
                    return return_v;
                }


                int
                f_202_4368_4457(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4368, 4457);
                    return return_v;
                }


                int
                f_202_4312_4458(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4312, 4458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 4247, 4470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 4247, 4470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsDisabled(CompilationOptions compilationOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(202, 4721, 5135);
                Microsoft.CodeAnalysis.ReportDiagnostic reportDiagnostic = default(Microsoft.CodeAnalysis.ReportDiagnostic);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 4809, 4948) || true) && (compilationOptions == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(202, 4809, 4948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 4873, 4933);

                    throw f_202_4879_4932(nameof(compilationOptions));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(202, 4809, 4948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(202, 4964, 5124);

                return f_202_4971_5057(f_202_4971_5015(compilationOptions), f_202_5028_5030(), out reportDiagnostic) && (DynAbs.Tracing.TraceSender.Expression_True(202, 4971, 5123) && reportDiagnostic == ReportDiagnostic.Suppress);
                DynAbs.Tracing.TraceSender.TraceExitMethod(202, 4721, 5135);

                System.ArgumentNullException
                f_202_4879_4932(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4879, 4932);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_202_4971_5015(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 4971, 5015);
                    return return_v;
                }


                string
                f_202_5028_5030()
                {
                    var return_v = Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 5028, 5030);
                    return return_v;
                }


                bool
                f_202_4971_5057(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                this_param, string
                key, out Microsoft.CodeAnalysis.ReportDiagnostic
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 4971, 5057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(202, 4721, 5135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 4721, 5135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SuppressionDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(202, 509, 5142);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(202, 509, 5142);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(202, 509, 5142);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(202, 509, 5142);

        static string
        f_202_2102_2104_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(202, 1949, 2185);
            return return_v;
        }


        static bool
        f_202_3046_3075(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3046, 3075);
            return return_v;
        }


        static string
        f_202_3137_3194()
        {
            var return_v = CodeAnalysisResources.SuppressionIdCantBeNullOrWhitespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3137, 3194);
            return return_v;
        }


        static System.ArgumentException
        f_202_3115_3207(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3115, 3207);
            return return_v;
        }


        static bool
        f_202_3243_3292(string
        value)
        {
            var return_v = string.IsNullOrWhiteSpace(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3243, 3292);
            return return_v;
        }


        static string
        f_202_3354_3410()
        {
            var return_v = CodeAnalysisResources.DiagnosticIdCantBeNullOrWhitespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(202, 3354, 3410);
            return return_v;
        }


        static System.ArgumentException
        f_202_3332_3443(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3332, 3443);
            return return_v;
        }


        static System.ArgumentNullException
        f_202_3613_3661(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(202, 3613, 3661);
            return return_v;
        }

    }
}
