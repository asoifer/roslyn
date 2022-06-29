// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{
    internal class NoThrowStreamDisposer : IDisposable
    {
        private bool? _failed;

        private readonly string _filePath;

        private readonly DiagnosticBag _diagnostics;

        private readonly CommonMessageProvider _messageProvider;

        public Stream Stream { get; }

        public bool HasFailedToDispose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(349, 1248, 1388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1284, 1320);

                    f_349_1284_1319(_failed != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1338, 1373);

                    return f_349_1345_1372(_failed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(349, 1248, 1388);

                    int
                    f_349_1284_1319(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(349, 1284, 1319);
                        return 0;
                    }


                    bool
                    f_349_1345_1372(bool?
                    this_param)
                    {
                        var return_v = this_param.GetValueOrDefault();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(349, 1345, 1372);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(349, 1193, 1399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(349, 1193, 1399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NoThrowStreamDisposer(
                    Stream stream,
                    string filePath,
                    DiagnosticBag diagnostics,
                    CommonMessageProvider messageProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(349, 1411, 1796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 696, 703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 800, 809);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 851, 863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 913, 929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1020, 1049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1615, 1631);

                Stream = stream;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1645, 1660);

                _failed = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1674, 1695);

                _filePath = filePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1709, 1736);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1750, 1785);

                _messageProvider = messageProvider;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(349, 1411, 1796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(349, 1411, 1796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(349, 1411, 1796);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(349, 1808, 2354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1854, 1890);

                f_349_1854_1889(_failed == null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1940, 1957);

                    f_349_1940_1956(f_349_1940_1946());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 1975, 2071) || true) && (_failed == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(349, 1975, 2071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 2036, 2052);

                        _failed = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(349, 1975, 2071);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(349, 2100, 2343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 2152, 2224);

                    f_349_2152_2223(_messageProvider, e, _filePath, _diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(349, 2313, 2328);

                    _failed = true;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(349, 2100, 2343);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(349, 1808, 2354);

                int
                f_349_1854_1889(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(349, 1854, 1889);
                    return 0;
                }


                System.IO.Stream
                f_349_1940_1946()
                {
                    var return_v = Stream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(349, 1940, 1946);
                    return return_v;
                }


                int
                f_349_1940_1956(System.IO.Stream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(349, 1940, 1956);
                    return 0;
                }


                int
                f_349_2152_2223(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, System.Exception
                e, string
                filePath, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportStreamWriteException(e, filePath, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(349, 2152, 2223);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(349, 1808, 2354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(349, 1808, 2354);
            }
        }

        static NoThrowStreamDisposer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(349, 615, 2361);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(349, 615, 2361);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(349, 615, 2361);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(349, 615, 2361);
    }
}
