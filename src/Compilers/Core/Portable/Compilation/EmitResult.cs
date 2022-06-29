// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.Emit
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public class EmitResult
    {
        public bool Success { get; }

        public ImmutableArray<Diagnostic> Diagnostics { get; }

        internal EmitResult(bool success, ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(150, 1090, 1257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 763, 791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1188, 1206);

                Success = success;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1220, 1246);

                Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(150, 1090, 1257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(150, 1090, 1257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(150, 1090, 1257);
            }
        }

        protected virtual string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(150, 1269, 1681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1339, 1399);

                string
                result = "Success = " + ((DynAbs.Tracing.TraceSender.Conditional_F1(150, 1371, 1378) || ((f_150_1371_1378() && DynAbs.Tracing.TraceSender.Conditional_F2(150, 1381, 1387)) || DynAbs.Tracing.TraceSender.Conditional_F3(150, 1390, 1397))) ? "true" : "false")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1413, 1640) || true) && (f_150_1417_1428() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(150, 1413, 1640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1470, 1526);

                    result += ", Diagnostics.Count = " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_150_1507_1518().Length).ToString(), 150, 1507, 1525);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(150, 1413, 1640);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(150, 1413, 1640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1592, 1625);

                    result += ", Diagnostics = null";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(150, 1413, 1640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(150, 1656, 1670);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(150, 1269, 1681);

                bool
                f_150_1371_1378()
                {
                    var return_v = Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(150, 1371, 1378);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_150_1417_1428()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(150, 1417, 1428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_150_1507_1518()
                {
                    var return_v = Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(150, 1507, 1518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(150, 1269, 1681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(150, 1269, 1681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EmitResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(150, 411, 1688);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(150, 411, 1688);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(150, 411, 1688);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(150, 411, 1688);
    }
}
