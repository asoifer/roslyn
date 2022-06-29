// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{

    public struct Suppression : IEquatable<Suppression>
    {

        private Suppression(SuppressionDescriptor descriptor, Diagnostic suppressedDiagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(269, 577, 1444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 688, 767);

                Descriptor = descriptor ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.SuppressionDescriptor>(269, 701, 766) ?? throw f_269_721_766(nameof(descriptor)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 781, 890);

                SuppressedDiagnostic = suppressedDiagnostic ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Diagnostic>(269, 804, 889) ?? throw f_269_834_889(nameof(suppressedDiagnostic)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 904, 975);

                f_269_904_974(f_269_917_965(suppressedDiagnostic) == null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 991, 1433) || true) && (f_269_995_1028(descriptor) != f_269_1032_1055(suppressedDiagnostic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(269, 991, 1433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 1215, 1363);

                    var
                    message = f_269_1229_1362(f_269_1243_1301(), f_269_1303_1326(suppressedDiagnostic), f_269_1328_1361(descriptor))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 1381, 1418);

                    throw f_269_1387_1417(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(269, 991, 1433);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(269, 577, 1444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 577, 1444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 577, 1444);
            }
        }

        public static Suppression Create(SuppressionDescriptor descriptor, Diagnostic suppressedDiagnostic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(269, 2276, 2328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 2279, 2328);
                return f_269_2279_2328(descriptor, suppressedDiagnostic); DynAbs.Tracing.TraceSender.TraceExitMethod(269, 2276, 2328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 2276, 2328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 2276, 2328);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Diagnostics.Suppression
            f_269_2279_2328(Microsoft.CodeAnalysis.SuppressionDescriptor
            descriptor, Microsoft.CodeAnalysis.Diagnostic
            suppressedDiagnostic)
            {
                var return_v = new Microsoft.CodeAnalysis.Diagnostics.Suppression(descriptor, suppressedDiagnostic);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 2279, 2328);
                return return_v;
            }

        }

        public SuppressionDescriptor Descriptor { get; }

        public Diagnostic SuppressedDiagnostic { get; }

        public static bool operator ==(Suppression left, Suppression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(269, 2656, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 2748, 2774);

                return left.Equals(right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(269, 2656, 2785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 2656, 2785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 2656, 2785);
            }
        }

        public static bool operator !=(Suppression left, Suppression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(269, 2797, 2924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 2889, 2913);

                return !(left == right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(269, 2797, 2924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 2797, 2924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 2797, 2924);
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(269, 2936, 3090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 3001, 3079);

                return obj is Suppression suppression
                && (DynAbs.Tracing.TraceSender.Expression_True(269, 3008, 3078) && Equals(suppression));
                DynAbs.Tracing.TraceSender.TraceExitMethod(269, 2936, 3090);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 2936, 3090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 2936, 3090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(Suppression other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(269, 3102, 3381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 3164, 3370);

                return f_269_3171_3255(f_269_3171_3218(), Descriptor, other.Descriptor) && (DynAbs.Tracing.TraceSender.Expression_True(269, 3171, 3369) && f_269_3276_3369(f_269_3276_3312(), SuppressedDiagnostic, other.SuppressedDiagnostic));
                DynAbs.Tracing.TraceSender.TraceExitMethod(269, 3102, 3381);

                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_269_3171_3218()
                {
                    var return_v = EqualityComparer<SuppressionDescriptor>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 3171, 3218);
                    return return_v;
                }


                bool
                f_269_3171_3255(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.SuppressionDescriptor>
                this_param, Microsoft.CodeAnalysis.SuppressionDescriptor
                x, Microsoft.CodeAnalysis.SuppressionDescriptor
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 3171, 3255);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Diagnostic>
                f_269_3276_3312()
                {
                    var return_v = EqualityComparer<Diagnostic>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 3276, 3312);
                    return return_v;
                }


                bool
                f_269_3276_3369(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                x, Microsoft.CodeAnalysis.Diagnostic
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 3276, 3369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 3102, 3381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 3102, 3381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(269, 3393, 3662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(269, 3451, 3651);

                return f_269_3458_3650(f_269_3489_3560(f_269_3489_3536(), Descriptor), f_269_3579_3649(f_269_3579_3615(), SuppressedDiagnostic));
                DynAbs.Tracing.TraceSender.TraceExitMethod(269, 3393, 3662);

                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.SuppressionDescriptor>
                f_269_3489_3536()
                {
                    var return_v = EqualityComparer<SuppressionDescriptor>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 3489, 3536);
                    return return_v;
                }


                int
                f_269_3489_3560(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.SuppressionDescriptor>
                this_param, Microsoft.CodeAnalysis.SuppressionDescriptor
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 3489, 3560);
                    return return_v;
                }


                System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Diagnostic>
                f_269_3579_3615()
                {
                    var return_v = EqualityComparer<Diagnostic>.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 3579, 3615);
                    return return_v;
                }


                int
                f_269_3579_3649(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.Diagnostic>
                this_param, Microsoft.CodeAnalysis.Diagnostic
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 3579, 3649);
                    return return_v;
                }


                int
                f_269_3458_3650(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 3458, 3650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(269, 3393, 3662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 3393, 3662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static Suppression()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(269, 509, 3669);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(269, 509, 3669);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(269, 509, 3669);
        }

        static System.ArgumentNullException
        f_269_721_766(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 721, 766);
            return return_v;
        }


        static System.ArgumentNullException
        f_269_834_889(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 834, 889);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.ProgrammaticSuppressionInfo?
        f_269_917_965(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.ProgrammaticSuppressionInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 917, 965);
            return return_v;
        }


        static int
        f_269_904_974(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 904, 974);
            return 0;
        }


        static string
        f_269_995_1028(Microsoft.CodeAnalysis.SuppressionDescriptor
        this_param)
        {
            var return_v = this_param.SuppressedDiagnosticId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 995, 1028);
            return return_v;
        }


        static string
        f_269_1032_1055(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 1032, 1055);
            return return_v;
        }


        static string
        f_269_1243_1301()
        {
            var return_v = CodeAnalysisResources.InvalidDiagnosticSuppressionReported;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 1243, 1301);
            return return_v;
        }


        static string
        f_269_1303_1326(Microsoft.CodeAnalysis.Diagnostic
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 1303, 1326);
            return return_v;
        }


        static string
        f_269_1328_1361(Microsoft.CodeAnalysis.SuppressionDescriptor
        this_param)
        {
            var return_v = this_param.SuppressedDiagnosticId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(269, 1328, 1361);
            return return_v;
        }


        static string
        f_269_1229_1362(string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format(format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 1229, 1362);
            return return_v;
        }


        static System.ArgumentException
        f_269_1387_1417(string
        message)
        {
            var return_v = new System.ArgumentException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(269, 1387, 1417);
            return return_v;
        }

    }
}
