// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.Test.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static class DiagnosticExtensions
    {
        public static void Verify(this IEnumerable<DiagnosticInfo> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21006, 476, 704);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21006, 608, 693);

                f_21006_608_692(f_21006_608_675(actual, info => new CSDiagnostic(info, NoLocation.Singleton)), expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21006, 476, 704);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21006, 476, 704);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21006, 476, 704);
            }
        }

        public static void Verify(this ImmutableArray<DiagnosticInfo> actual, params DiagnosticDescription[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21006, 716, 947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21006, 851, 936);

                f_21006_851_935(actual.Select(info => new CSDiagnostic(info, NoLocation.Singleton)), expected);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21006, 716, 947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21006, 716, 947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21006, 716, 947);
            }
        }

        public static string ToLocalizedString(this MessageID id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21006, 959, 1113);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21006, 1041, 1102);

                return f_21006_1048_1080(id).ToString(null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21006, 959, 1113);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21006, 959, 1113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21006, 959, 1113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DiagnosticExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21006, 417, 1120);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21006, 417, 1120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21006, 417, 1120);
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
        f_21006_608_675(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.DiagnosticInfo>
        source, System.Func<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.DiagnosticInfo, Microsoft.CodeAnalysis.CSharp.CSDiagnostic>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21006, 608, 675);
            return return_v;
        }


        static int
        f_21006_608_692(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
        actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            actual.Verify(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21006, 608, 692);
            return 0;
        }


        static int
        f_21006_851_935(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.CSDiagnostic>
        actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
        expected)
        {
            actual.Verify(expected);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21006, 851, 935);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
        f_21006_1048_1080(Microsoft.CodeAnalysis.CSharp.MessageID
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument(id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21006, 1048, 1080);
            return return_v;
        }

    }
}
