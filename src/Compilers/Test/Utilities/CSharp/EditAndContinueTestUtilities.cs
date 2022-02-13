// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.UnitTests
{
    public static class EditAndContinueTestUtilities
    {
        public static int GetMethodOrdinal(this EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21008, 759, 785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21008, 762, 785);
                return debugInfo.MethodOrdinal; DynAbs.Tracing.TraceSender.TraceExitMethod(21008, 759, 785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21008, 759, 785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 759, 785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> InspectLocalSlots(this EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21008, 917, 1087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21008, 920, 1087);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(21008, 920, 950) || ((debugInfo.LocalSlots.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(21008, 953, 957)) || DynAbs.Tracing.TraceSender.Conditional_F3(21008, 976, 1087))) ? null : debugInfo.LocalSlots.Select(s => $"Offset={s.Id.SyntaxOffset} Ordinal={s.Id.Ordinal} Kind={s.SynthesizedKind}"); DynAbs.Tracing.TraceSender.TraceExitMethod(21008, 917, 1087);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21008, 917, 1087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 917, 1087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> InspectLambdas(this EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21008, 1216, 1404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21008, 1219, 1404);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(21008, 1219, 1246) || ((debugInfo.Lambdas.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(21008, 1249, 1253)) || DynAbs.Tracing.TraceSender.Conditional_F3(21008, 1272, 1404))) ? null : debugInfo.Lambdas.Select(l => $"Offset={l.SyntaxOffset} Id={l.LambdaId.Generation}#{l.LambdaId.Ordinal} Closure={l.ClosureOrdinal}"); DynAbs.Tracing.TraceSender.TraceExitMethod(21008, 1216, 1404);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21008, 1216, 1404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 1216, 1404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static IEnumerable<string> InspectClosures(this EditAndContinueMethodDebugInformation debugInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21008, 1534, 1699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21008, 1537, 1699);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(21008, 1537, 1565) || ((debugInfo.Closures.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(21008, 1568, 1572)) || DynAbs.Tracing.TraceSender.Conditional_F3(21008, 1591, 1699))) ? null : debugInfo.Closures.Select(c => $"Offset={c.SyntaxOffset} Id={c.ClosureId.Generation}#{c.ClosureId.Ordinal}"); DynAbs.Tracing.TraceSender.TraceExitMethod(21008, 1534, 1699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21008, 1534, 1699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 1534, 1699);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EmitBaseline GetInitialEmitBaseline(this EmitBaseline baseline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21008, 1803, 1830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21008, 1806, 1830);
                return f_21008_1806_1830(baseline); DynAbs.Tracing.TraceSender.TraceExitMethod(21008, 1803, 1830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21008, 1803, 1830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 1803, 1830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EditAndContinueTestUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21008, 373, 1860);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21008, 373, 1860);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21008, 373, 1860);
        }


        static Microsoft.CodeAnalysis.Emit.EmitBaseline
        f_21008_1806_1830(Microsoft.CodeAnalysis.Emit.EmitBaseline
        this_param)
        {
            var return_v = this_param.InitialBaseline;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21008, 1806, 1830);
            return return_v;
        }

    }
}
