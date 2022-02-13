// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class CSDiagnostic : DiagnosticWithInfo
    {
        internal CSDiagnostic(DiagnosticInfo info, Location location, bool isSuppressed = false)
        : base(f_10605_580_584_C(info), location, isSuppressed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10605, 471, 631);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10605, 471, 631);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10605, 471, 631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 471, 631);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10605, 643, 767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 701, 756);

                return f_10605_708_755(f_10605_708_742(), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10605, 643, 767);

                Microsoft.CodeAnalysis.CSharp.CSharpDiagnosticFormatter
                f_10605_708_742()
                {
                    var return_v = CSharpDiagnosticFormatter.Instance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 708, 742);
                    return return_v;
                }


                string
                f_10605_708_755(Microsoft.CodeAnalysis.CSharp.CSharpDiagnosticFormatter
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diagnostic)
                {
                    var return_v = this_param.Format((Microsoft.CodeAnalysis.Diagnostic)diagnostic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 708, 755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10605, 643, 767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 643, 767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithLocation(Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10605, 779, 1180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 864, 983) || true) && (location == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10605, 864, 983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 918, 968);

                    throw f_10605_924_967(nameof(location));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10605, 864, 983);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 999, 1141) || true) && (location != f_10605_1015_1028(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10605, 999, 1141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1062, 1126);

                    return f_10605_1069_1125(f_10605_1086_1095(this), location, f_10605_1107_1124(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10605, 999, 1141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1157, 1169);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10605, 779, 1180);

                System.ArgumentNullException
                f_10605_924_967(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 924, 967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10605_1015_1028(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1015, 1028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10605_1086_1095(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1086, 1095);
                    return return_v;
                }


                bool
                f_10605_1107_1124(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1107, 1124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10605_1069_1125(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 1069, 1125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10605, 779, 1180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 779, 1180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithSeverity(DiagnosticSeverity severity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10605, 1192, 1507);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1287, 1468) || true) && (f_10605_1291_1304(this) != severity)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10605, 1287, 1468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1350, 1453);

                    return f_10605_1357_1452(f_10605_1374_1417(f_10605_1374_1383(this), severity), f_10605_1419_1432(this), f_10605_1434_1451(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10605, 1287, 1468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1484, 1496);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10605, 1192, 1507);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10605_1291_1304(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1291, 1304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10605_1374_1383(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1374, 1383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10605_1374_1417(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param, Microsoft.CodeAnalysis.DiagnosticSeverity
                severity)
                {
                    var return_v = this_param.GetInstanceWithSeverity(severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 1374, 1417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10605_1419_1432(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1419, 1432);
                    return return_v;
                }


                bool
                f_10605_1434_1451(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1434, 1451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10605_1357_1452(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 1357, 1452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10605, 1192, 1507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 1192, 1507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Diagnostic WithIsSuppressed(bool isSuppressed)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10605, 1519, 1797);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1608, 1758) || true) && (f_10605_1612_1629(this) != isSuppressed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10605, 1608, 1758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1679, 1743);

                    return f_10605_1686_1742(f_10605_1703_1712(this), f_10605_1714_1727(this), isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10605, 1608, 1758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10605, 1774, 1786);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10605, 1519, 1797);

                bool
                f_10605_1612_1629(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.IsSuppressed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1612, 1629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10605_1703_1712(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1703, 1712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10605_1714_1727(Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10605, 1714, 1727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10605_1686_1742(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location, bool
                isSuppressed)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location, isSuppressed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10605, 1686, 1742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10605, 1519, 1797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 1519, 1797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSDiagnostic()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10605, 399, 1804);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10605, 399, 1804);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10605, 399, 1804);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10605, 399, 1804);

        static Microsoft.CodeAnalysis.DiagnosticInfo
        f_10605_580_584_C(Microsoft.CodeAnalysis.DiagnosticInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10605, 471, 631);
            return return_v;
        }

    }
}
