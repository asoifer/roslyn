// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class CSDiagnosticInfo : DiagnosticInfoWithSymbols
    {
        public static readonly DiagnosticInfo EmptyErrorInfo;

        public static readonly DiagnosticInfo VoidDiagnosticInfo;

        private readonly IReadOnlyList<Location> _additionalLocations;

        internal CSDiagnosticInfo(ErrorCode code)
        : this(f_10606_834_838_C(code), f_10606_840_861(), ImmutableArray<Symbol>.Empty, ImmutableArray<Location>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10606, 772, 946);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10606, 772, 946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 772, 946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 772, 946);
            }
        }

        internal CSDiagnosticInfo(ErrorCode code, params object[] args)
        : this(f_10606_1042_1046_C(code), args, ImmutableArray<Symbol>.Empty, ImmutableArray<Location>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10606, 958, 1137);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10606, 958, 1137);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 958, 1137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 958, 1137);
            }
        }

        internal CSDiagnosticInfo(ErrorCode code, ImmutableArray<Symbol> symbols, object[] args)
        : this(f_10606_1258_1262_C(code), args, symbols, ImmutableArray<Location>.Empty)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10606, 1149, 1332);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10606, 1149, 1332);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 1149, 1332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 1149, 1332);
            }
        }

        internal CSDiagnosticInfo(ErrorCode code, object[] args, ImmutableArray<Symbol> symbols, ImmutableArray<Location> additionalLocations)
        : base(f_10606_1499_1503_C(code), args, symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10606, 1344, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 739, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 1655, 1705);

                f_10606_1655_1704(code != ErrorCode.ERR_InternalError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 1719, 1856);

                _additionalLocations = (DynAbs.Tracing.TraceSender.Conditional_F1(10606, 1742, 1778) || ((additionalLocations.IsDefaultOrEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10606, 1781, 1833)) || DynAbs.Tracing.TraceSender.Conditional_F3(10606, 1836, 1855))) ? f_10606_1781_1833() : additionalLocations;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10606, 1344, 1867);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 1344, 1867);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 1344, 1867);
            }
        }

        public override IReadOnlyList<Location> AdditionalLocations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10606, 1939, 1962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 1942, 1962);
                    return _additionalLocations; DynAbs.Tracing.TraceSender.TraceExitMethod(10606, 1939, 1962);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 1939, 1962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 1939, 1962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal new ErrorCode Code
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10606, 2003, 2026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 2006, 2026);
                    return (ErrorCode)DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Code, 10606, 2017, 2026); DynAbs.Tracing.TraceSender.TraceExitMethod(10606, 2003, 2026);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 2003, 2026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 2003, 2026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool IsEmpty(DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10606, 2089, 2122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 2092, 2122);
                return (object)info == EmptyErrorInfo; DynAbs.Tracing.TraceSender.TraceExitMethod(10606, 2089, 2122);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10606, 2089, 2122);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 2089, 2122);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSDiagnosticInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10606, 418, 2130);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 539, 579);
            EmptyErrorInfo = f_10606_556_579(0); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10606, 628, 685);
            VoidDiagnosticInfo = f_10606_649_685(ErrorCode.Void); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10606, 418, 2130);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10606, 418, 2130);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10606, 418, 2130);

        static Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10606_556_579(int
        code)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10606, 556, 579);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
        f_10606_649_685(Microsoft.CodeAnalysis.CSharp.ErrorCode
        code)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10606, 649, 685);
            return return_v;
        }


        static object[]
        f_10606_840_861()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10606, 840, 861);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.ErrorCode
        f_10606_834_838_C(Microsoft.CodeAnalysis.CSharp.ErrorCode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10606, 772, 946);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.ErrorCode
        f_10606_1042_1046_C(Microsoft.CodeAnalysis.CSharp.ErrorCode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10606, 958, 1137);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.ErrorCode
        f_10606_1258_1262_C(Microsoft.CodeAnalysis.CSharp.ErrorCode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10606, 1149, 1332);
            return return_v;
        }


        int
        f_10606_1655_1704(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10606, 1655, 1704);
            return 0;
        }


        System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Location>
        f_10606_1781_1833()
        {
            var return_v = SpecializedCollections.EmptyReadOnlyList<Location>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10606, 1781, 1833);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.ErrorCode
        f_10606_1499_1503_C(Microsoft.CodeAnalysis.CSharp.ErrorCode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10606, 1344, 1867);
            return return_v;
        }

    }
}
