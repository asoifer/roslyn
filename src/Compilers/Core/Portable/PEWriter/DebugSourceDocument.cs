// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System;
using System.Threading.Tasks;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;

namespace Microsoft.Cci
{
    internal sealed class DebugSourceDocument
    {
        internal static readonly Guid CorSymLanguageTypeCSharp;

        internal static readonly Guid CorSymLanguageTypeBasic;

        private static readonly Guid s_corSymLanguageVendorMicrosoft;

        private static readonly Guid s_corSymDocumentTypeText;

        private readonly string _location;

        private readonly Guid _language;

        private readonly bool _isComputedChecksum;

        private readonly Task<DebugSourceInfo>? _sourceInfo;

        public DebugSourceDocument(string location, Guid language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(481, 1151, 1398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 973, 982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1057, 1076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1127, 1138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1234, 1271);

                f_481_1234_1270(location != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1287, 1308);

                _location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1366, 1387);

                _language = language;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(481, 1151, 1398);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 1151, 1398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 1151, 1398);
            }
        }

        public DebugSourceDocument(string location, Guid language, Func<DebugSourceInfo> sourceInfo)
        : this(f_481_1665_1673_C(location), language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(481, 1552, 1796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1709, 1744);

                _sourceInfo = f_481_1723_1743(sourceInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 1758, 1785);

                _isComputedChecksum = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(481, 1552, 1796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 1552, 1796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 1552, 1796);
            }
        }

        public DebugSourceDocument(string location, Guid language, ImmutableArray<byte> checksum, Guid algorithm)
        : this(f_481_2085_2093_C(location), language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(481, 1959, 2212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2129, 2201);

                _sourceInfo = f_481_2143_2200(f_481_2159_2199(checksum, algorithm));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(481, 1959, 2212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 1959, 2212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 1959, 2212);
            }
        }

        public Guid DocumentType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 2273, 2313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2279, 2311);

                    return s_corSymDocumentTypeText;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(481, 2273, 2313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2224, 2324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2224, 2324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Guid Language
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 2381, 2406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2387, 2404);

                    return _language;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(481, 2381, 2406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2336, 2417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2336, 2417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Guid LanguageVendor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 2480, 2527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2486, 2525);

                    return s_corSymLanguageVendorMicrosoft;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(481, 2480, 2527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2429, 2538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2429, 2538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Location
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 2597, 2622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2603, 2620);

                    return _location;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(481, 2597, 2622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2550, 2633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2550, 2633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DebugSourceInfo GetSourceInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 2645, 2774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 2708, 2763);

                return f_481_2715_2734_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_sourceInfo, 481, 2715, 2734)?.Result) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.DebugSourceInfo?>(481, 2715, 2762) ?? default(DebugSourceInfo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(481, 2645, 2774);

                Microsoft.Cci.DebugSourceInfo?
                f_481_2715_2734_M(Microsoft.Cci.DebugSourceInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(481, 2715, 2734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2645, 2774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2645, 2774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsComputedChecksum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(481, 3047, 3125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 3083, 3110);

                    return _isComputedChecksum;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(481, 3047, 3125);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(481, 2990, 3136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 2990, 3136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DebugSourceDocument()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(481, 413, 3143);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 501, 578);
            CorSymLanguageTypeCSharp = f_481_528_578("{3f5162f8-07c6-11d3-9053-00c04fa302a1}"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 619, 695);
            CorSymLanguageTypeBasic = f_481_645_695("{3a12d0b8-c26c-11d0-b442-00a0244a1dd2}"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 735, 819);
            s_corSymLanguageVendorMicrosoft = f_481_769_819("{994b45c4-e6e9-11d2-903f-00c04fa302a1}"); DynAbs.Tracing.TraceSender.TraceSimpleStatement(481, 859, 936);
            s_corSymDocumentTypeText = f_481_886_936("{5a869d0b-6611-11d3-bd2a-0000f80849bd}"); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(481, 413, 3143);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(481, 413, 3143);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(481, 413, 3143);

        static System.Guid
        f_481_528_578(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 528, 578);
            return return_v;
        }


        static System.Guid
        f_481_645_695(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 645, 695);
            return return_v;
        }


        static System.Guid
        f_481_769_819(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 769, 819);
            return return_v;
        }


        static System.Guid
        f_481_886_936(string
        g)
        {
            var return_v = new System.Guid(g);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 886, 936);
            return return_v;
        }


        static int
        f_481_1234_1270(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 1234, 1270);
            return 0;
        }


        static System.Threading.Tasks.Task<Microsoft.Cci.DebugSourceInfo>
        f_481_1723_1743(System.Func<Microsoft.Cci.DebugSourceInfo>
        function)
        {
            var return_v = Task.Run(function);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 1723, 1743);
            return return_v;
        }


        static string
        f_481_1665_1673_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(481, 1552, 1796);
            return return_v;
        }


        static Microsoft.Cci.DebugSourceInfo
        f_481_2159_2199(System.Collections.Immutable.ImmutableArray<byte>
        checksum, System.Guid
        checksumAlgorithmId)
        {
            var return_v = new Microsoft.Cci.DebugSourceInfo(checksum, checksumAlgorithmId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 2159, 2199);
            return return_v;
        }


        static System.Threading.Tasks.Task<Microsoft.Cci.DebugSourceInfo>
        f_481_2143_2200(Microsoft.Cci.DebugSourceInfo
        result)
        {
            var return_v = Task.FromResult(result);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(481, 2143, 2200);
            return return_v;
        }


        static string
        f_481_2085_2093_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(481, 1959, 2212);
            return return_v;
        }

    }
}
