// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace Roslyn.Test.Utilities
{
    internal class PinnedMetadata : IDisposable
    {
        private GCHandle _bytes;

        public readonly MetadataReader Reader;

        public readonly IntPtr Pointer;

        public readonly int Size;

        public unsafe PinnedMetadata(ImmutableArray<byte> metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25094, 731, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 636, 642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 714, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 815, 900);

                _bytes = GCHandle.Alloc(metadata.DangerousGetUnderlyingArray(), GCHandleType.Pinned);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 914, 957);

                this.Pointer = _bytes.AddrOfPinnedObject();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 971, 999);

                this.Size = metadata.Length;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 1013, 1112);

                this.Reader = f_25094_1027_1111(this.Pointer, this.Size, MetadataReaderOptions.None, null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25094, 731, 1123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25094, 731, 1123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25094, 731, 1123);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25094, 1135, 1206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25094, 1181, 1195);

                _bytes.Free();
                DynAbs.Tracing.TraceSender.TraceExitMethod(25094, 1135, 1206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25094, 1135, 1206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25094, 1135, 1206);
            }
        }

        static PinnedMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25094, 453, 1213);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25094, 453, 1213);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25094, 453, 1213);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25094, 453, 1213);

        static unsafe System.Reflection.Metadata.MetadataReader
        f_25094_1027_1111(System.IntPtr
        metadata, int
        length, System.Reflection.Metadata.MetadataReaderOptions
        options, System.Reflection.Metadata.MetadataStringDecoder?
        utf8Decoder)
        {
            var return_v = new System.Reflection.Metadata.MetadataReader((byte*)metadata, length, options, utf8Decoder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25094, 1027, 1111);
            return return_v;
        }

    }
}
