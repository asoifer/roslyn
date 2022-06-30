// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Reflection.Metadata;
using System.Security.Cryptography;
using Microsoft.Cci;

namespace Microsoft.CodeAnalysis
{
    public abstract class StrongNameProvider
    {
        protected StrongNameProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(564, 500, 552);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(564, 500, 552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(564, 500, 552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(564, 500, 552);
            }
        }

        public abstract override int GetHashCode();

        public abstract override bool Equals(object? other);

        internal abstract StrongNameFileSystem FileSystem { get; }

        internal abstract void SignFile(StrongNameKeys keys, string filePath);

        internal abstract void SignBuilder(ExtendedPEBuilder peBuilder, BlobBuilder peBlob, RSAParameters privateKey);

        internal abstract StrongNameKeys CreateKeys(string? keyFilePath, string? keyContainerName, bool hasCounterSignature, CommonMessageProvider messageProvider);

        static StrongNameProvider()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(564, 443, 1559);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(564, 443, 1559);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(564, 443, 1559);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(564, 443, 1559);
    }
}
