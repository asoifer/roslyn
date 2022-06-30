// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    public abstract class MetadataReferenceResolver
    {
        public abstract override bool Equals(object? other);

        public abstract override int GetHashCode();

        public abstract ImmutableArray<PortableExecutableReference> ResolveReference(string reference, string? baseFilePath, MetadataReferenceProperties properties);

        public virtual bool ResolveMissingAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(433, 1197, 1205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(433, 1200, 1205);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(433, 1197, 1205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(433, 1197, 1205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(433, 1197, 1205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual PortableExecutableReference? ResolveMissingAssembly(MetadataReference definition, AssemblyIdentity referenceIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(433, 1920, 1927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(433, 1923, 1927);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(433, 1920, 1927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(433, 1920, 1927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(433, 1920, 1927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MetadataReferenceResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(433, 424, 1935);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(433, 424, 1935);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(433, 424, 1935);
        }


        static MetadataReferenceResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(433, 424, 1935);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(433, 424, 1935);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(433, 424, 1935);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(433, 424, 1935);
    }
}
