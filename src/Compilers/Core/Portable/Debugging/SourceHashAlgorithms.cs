// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Debugging
{
    internal static class SourceHashAlgorithms
    {
        private static readonly Guid s_guidSha1;

        private static readonly Guid s_guidSha256;

        public static bool IsSupportedAlgorithm(SourceHashAlgorithm algorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(172, 958, 1139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 961, 1139);
                return algorithm switch
                {
                    SourceHashAlgorithm.Sha1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1010, 1042) && DynAbs.Tracing.TraceSender.Expression_True(172, 1010, 1042))
    => true,
                    SourceHashAlgorithm.Sha256 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1061, 1095) && DynAbs.Tracing.TraceSender.Expression_True(172, 1061, 1095))
    => true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1114, 1124) && DynAbs.Tracing.TraceSender.Expression_True(172, 1114, 1124))
    => false
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(172, 958, 1139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(172, 958, 1139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(172, 958, 1139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Guid GetAlgorithmGuid(SourceHashAlgorithm algorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(172, 1232, 1474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1235, 1474);
                return algorithm switch
                {
                    SourceHashAlgorithm.Sha1 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1284, 1322) && DynAbs.Tracing.TraceSender.Expression_True(172, 1284, 1322))
    => s_guidSha1,
                    SourceHashAlgorithm.Sha256 when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1341, 1383) && DynAbs.Tracing.TraceSender.Expression_True(172, 1341, 1383))
    => s_guidSha256,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1402, 1458) && DynAbs.Tracing.TraceSender.Expression_True(172, 1402, 1458))
    => throw f_172_1413_1458(algorithm),
                }; DynAbs.Tracing.TraceSender.TraceExitMethod(172, 1232, 1474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(172, 1232, 1474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(172, 1232, 1474);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_172_1413_1458(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
            o)
            {
                var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(172, 1413, 1458);
                return return_v;
            }

        }

        public static SourceHashAlgorithm GetSourceHashAlgorithm(Guid guid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(172, 1568, 1731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 1571, 1731);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(172, 1571, 1593) || (((guid == s_guidSha256) && DynAbs.Tracing.TraceSender.Conditional_F2(172, 1596, 1622)) || DynAbs.Tracing.TraceSender.Conditional_F3(172, 1641, 1731))) ? SourceHashAlgorithm.Sha256 : (DynAbs.Tracing.TraceSender.Conditional_F1(172, 1641, 1661) || (((guid == s_guidSha1) && DynAbs.Tracing.TraceSender.Conditional_F2(172, 1664, 1688)) || DynAbs.Tracing.TraceSender.Conditional_F3(172, 1707, 1731))) ? SourceHashAlgorithm.Sha1 : SourceHashAlgorithm.None; DynAbs.Tracing.TraceSender.TraceExitMethod(172, 1568, 1731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(172, 1568, 1731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(172, 1568, 1731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceHashAlgorithms()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(172, 498, 1739);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 586, 706);
            s_guidSha1 = unchecked(f_172_609_705((uint)0xff1816ec, (short)0xaa5e, 0x4d10, 0x87, 0xf7, 0x6f, 0x49, 0x63, 0x83, 0x34, 0x60)); DynAbs.Tracing.TraceSender.TraceSimpleStatement(172, 746, 861);
            s_guidSha256 = unchecked(f_172_771_860((uint)0x8829d00f, 0x11b8, 0x4213, 0x87, 0x8b, 0x77, 0x0e, 0x85, 0x97, 0xac, 0x16)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(172, 498, 1739);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(172, 498, 1739);
        }


        static System.Guid
        f_172_609_705(uint
        a, int
        b, int
        c, int
        d, int
        e, int
        f, int
        g, int
        h, int
        i, int
        j, int
        k)
        {
            var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(172, 609, 705);
            return return_v;
        }


        static System.Guid
        f_172_771_860(uint
        a, int
        b, int
        c, int
        d, int
        e, int
        f, int
        g, int
        h, int
        i, int
        j, int
        k)
        {
            var return_v = new System.Guid((int)a, (short)b, (short)c, (byte)d, (byte)e, (byte)f, (byte)g, (byte)h, (byte)i, (byte)j, (byte)k);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(172, 771, 860);
            return return_v;
        }

    }
}
