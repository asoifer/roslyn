// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class UnsupportedMetadataTypeSymbol : ErrorTypeSymbol
    {
        private readonly BadImageFormatException? _mrEx;

        internal UnsupportedMetadataTypeSymbol(BadImageFormatException? mrEx = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10084, 479, 604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10084, 461, 466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10084, 580, 593);

                _mrEx = mrEx;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10084, 479, 604);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10084, 479, 604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10084, 479, 604);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10084, 616, 740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10084, 717, 729);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10084, 616, 740);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10084, 616, 740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10084, 616, 740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo ErrorInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10084, 819, 937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10084, 855, 922);

                    return f_10084_862_921(ErrorCode.ERR_BogusType, string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10084, 819, 937);

                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10084_862_921(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10084, 862, 921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10084, 752, 948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10084, 752, 948);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10084, 1018, 1082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10084, 1054, 1067);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10084, 1018, 1082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10084, 960, 1093);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10084, 960, 1093);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static UnsupportedMetadataTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10084, 333, 1100);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10084, 333, 1100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10084, 333, 1100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10084, 333, 1100);
    }
}
