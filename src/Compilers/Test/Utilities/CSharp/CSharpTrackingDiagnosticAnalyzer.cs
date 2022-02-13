// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Test.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Test.Utilities
{
    public class CSharpTrackingDiagnosticAnalyzer : TrackingDiagnosticAnalyzer<SyntaxKind>
    {
        private static readonly Regex s_omittedSyntaxKindRegex;

        protected override bool IsOnCodeBlockSupported(SymbolKind symbolKind, MethodKind methodKind, bool returnsVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21005, 868, 1125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21005, 1003, 1114);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsOnCodeBlockSupported(symbolKind, methodKind, returnsVoid), 21005, 1010, 1074) && (DynAbs.Tracing.TraceSender.Expression_True(21005, 1010, 1113) && methodKind != MethodKind.EventRaise);
                DynAbs.Tracing.TraceSender.TraceExitMethod(21005, 868, 1125);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21005, 868, 1125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21005, 868, 1125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsAnalyzeNodeSupported(SyntaxKind syntaxKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21005, 1137, 1349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21005, 1231, 1338);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.IsAnalyzeNodeSupported(syntaxKind), 21005, 1238, 1277) && (DynAbs.Tracing.TraceSender.Expression_True(21005, 1238, 1337) && !f_21005_1282_1337(s_omittedSyntaxKindRegex, f_21005_1315_1336(syntaxKind)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(21005, 1137, 1349);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21005, 1137, 1349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21005, 1137, 1349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CSharpTrackingDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(21005, 500, 1356);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(21005, 500, 1356);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21005, 500, 1356);
        }


        static CSharpTrackingDiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21005, 500, 1356);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21005, 633, 855);
            s_omittedSyntaxKindRegex = f_21005_673_855(@"Using|Extern|Parameter|Constraint|Specifier|Initializer|Global|Method|Destructor|MemberBindingExpression|ElementBindingExpression|ArrowExpressionClause|NameOfExpression"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21005, 500, 1356);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21005, 500, 1356);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21005, 500, 1356);

        static System.Text.RegularExpressions.Regex
        f_21005_673_855(string
        pattern)
        {
            var return_v = new System.Text.RegularExpressions.Regex(pattern);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21005, 673, 855);
            return return_v;
        }


        string
        f_21005_1315_1336(Microsoft.CodeAnalysis.CSharp.SyntaxKind
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21005, 1315, 1336);
            return return_v;
        }


        bool
        f_21005_1282_1337(System.Text.RegularExpressions.Regex
        this_param, string
        input)
        {
            var return_v = this_param.IsMatch(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21005, 1282, 1337);
            return return_v;
        }

    }
}
