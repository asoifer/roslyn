// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Immutable;

namespace Microsoft.Cci
{

    internal struct DebugSourceInfo
    {

        public readonly Guid ChecksumAlgorithmId;

        public readonly ImmutableArray<byte> Checksum;

        public readonly ImmutableArray<byte> EmbeddedTextBlob;

        public DebugSourceInfo(
                    ImmutableArray<byte> checksum,
                    SourceHashAlgorithm checksumAlgorithm,
                    ImmutableArray<byte> embeddedTextBlob = default)
        : this(f_482_1325_1333_C(checksum), f_482_1335_1391(checksumAlgorithm), embeddedTextBlob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(482, 1123, 1432);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(482, 1123, 1432);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(482, 1123, 1432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(482, 1123, 1432);
            }
        }

        public DebugSourceInfo(
                    ImmutableArray<byte> checksum,
                    Guid checksumAlgorithmId,
                    ImmutableArray<byte> embeddedTextBlob = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(482, 1444, 1774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(482, 1637, 1679);

                ChecksumAlgorithmId = checksumAlgorithmId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(482, 1693, 1713);

                Checksum = checksum;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(482, 1727, 1763);

                EmbeddedTextBlob = embeddedTextBlob;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(482, 1444, 1774);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(482, 1444, 1774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(482, 1444, 1774);
            }
        }
        static DebugSourceInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(482, 583, 1781);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(482, 583, 1781);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(482, 583, 1781);
        }

        static System.Guid
        f_482_1335_1391(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        algorithm)
        {
            var return_v = SourceHashAlgorithms.GetAlgorithmGuid(algorithm);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(482, 1335, 1391);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_482_1325_1333_C(System.Collections.Immutable.ImmutableArray<byte>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(482, 1123, 1432);
            return return_v;
        }

    }
}
