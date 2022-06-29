// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class CommonDiagnosticComparer : IEqualityComparer<Diagnostic>
    {
        internal static readonly CommonDiagnosticComparer Instance;

        private CommonDiagnosticComparer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(177, 510, 566);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(177, 510, 566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(177, 510, 566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(177, 510, 566);
            }
        }

        public bool Equals(Diagnostic? x, Diagnostic? y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(177, 578, 923);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 651, 744) || true) && (f_177_655_683(x, y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(177, 651, 744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 717, 729);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(177, 651, 744);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 760, 848) || true) && (x == null || (DynAbs.Tracing.TraceSender.Expression_False(177, 764, 786) || y == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(177, 760, 848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 820, 833);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(177, 760, 848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 864, 912);

                return f_177_871_881(x) == f_177_885_895(y) && (DynAbs.Tracing.TraceSender.Expression_True(177, 871, 911) && f_177_899_903(x) == f_177_907_911(y));
                DynAbs.Tracing.TraceSender.TraceExitMethod(177, 578, 923);

                bool
                f_177_655_683(Microsoft.CodeAnalysis.Diagnostic?
                objA, Microsoft.CodeAnalysis.Diagnostic?
                objB)
                {
                    var return_v = object.ReferenceEquals((object?)objA, (object?)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(177, 655, 683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_177_871_881(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 871, 881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_177_885_895(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 885, 895);
                    return return_v;
                }


                string
                f_177_899_903(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 899, 903);
                    return return_v;
                }


                string
                f_177_907_911(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 907, 911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(177, 578, 923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(177, 578, 923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(Diagnostic obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(177, 935, 1176);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 998, 1093) || true) && (f_177_1002_1035(obj, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(177, 998, 1093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 1069, 1078);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(177, 998, 1093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 1109, 1165);

                return f_177_1116_1164(f_177_1129_1141(obj), f_177_1143_1163(f_177_1143_1149(obj)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(177, 935, 1176);

                bool
                f_177_1002_1035(Microsoft.CodeAnalysis.Diagnostic
                objA, object?
                objB)
                {
                    var return_v = object.ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(177, 1002, 1035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_177_1129_1141(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 1129, 1141);
                    return return_v;
                }


                string
                f_177_1143_1149(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(177, 1143, 1149);
                    return return_v;
                }


                int
                f_177_1143_1163(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(177, 1143, 1163);
                    return return_v;
                }


                int
                f_177_1116_1164(Microsoft.CodeAnalysis.Location
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(177, 1116, 1164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(177, 935, 1176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(177, 935, 1176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommonDiagnosticComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(177, 311, 1183);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(177, 456, 497);
            Instance = f_177_467_497(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(177, 311, 1183);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(177, 311, 1183);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(177, 311, 1183);

        static Microsoft.CodeAnalysis.CommonDiagnosticComparer
        f_177_467_497()
        {
            var return_v = new Microsoft.CodeAnalysis.CommonDiagnosticComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(177, 467, 497);
            return return_v;
        }

    }
}
