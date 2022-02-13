// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class LazyArrayElementCantBeRefAnyDiagnosticInfo : LazyDiagnosticInfo
    {
        private readonly TypeWithAnnotations _possiblyRestrictedTypeSymbol;

        internal LazyArrayElementCantBeRefAnyDiagnosticInfo(TypeWithAnnotations possiblyRestrictedTypeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10611, 558, 756);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10611, 684, 745);

                _possiblyRestrictedTypeSymbol = possiblyRestrictedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10611, 558, 756);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10611, 558, 756);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10611, 558, 756);
            }
        }

        protected override DiagnosticInfo ResolveInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10611, 768, 1084);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10611, 840, 1045) || true) && (_possiblyRestrictedTypeSymbol.IsRestrictedType())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10611, 840, 1045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10611, 926, 1030);

                    return f_10611_933_1029(ErrorCode.ERR_ArrayElementCantBeRefAny, _possiblyRestrictedTypeSymbol.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10611, 840, 1045);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10611, 1061, 1073);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10611, 768, 1084);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10611_933_1029(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10611, 933, 1029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10611, 768, 1084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10611, 768, 1084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LazyArrayElementCantBeRefAnyDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10611, 377, 1091);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10611, 377, 1091);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10611, 377, 1091);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10611, 377, 1091);
    }
}
