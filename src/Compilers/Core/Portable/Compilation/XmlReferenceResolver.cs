// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.IO;

namespace Microsoft.CodeAnalysis
{
    public abstract class XmlReferenceResolver
    {
        protected XmlReferenceResolver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(171, 454, 508);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(171, 454, 508);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(171, 454, 508);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(171, 454, 508);
            }
        }

        public abstract override bool Equals(object? other);

        public abstract override int GetHashCode();

        public abstract string? ResolveReference(string path, string? baseFilePath);

        public abstract Stream OpenRead(string resolvedPath);

        internal Stream OpenReadChecked(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(171, 1930, 2288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(171, 2003, 2035);

                var
                stream = f_171_2016_2034(this, fullPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(171, 2051, 2247) || true) && (stream == null || (DynAbs.Tracing.TraceSender.Expression_False(171, 2055, 2088) || f_171_2073_2088_M(!stream.CanRead)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(171, 2051, 2247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(171, 2122, 2232);

                    throw f_171_2128_2231(f_171_2158_2230());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(171, 2051, 2247);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(171, 2263, 2277);

                return stream;
                DynAbs.Tracing.TraceSender.TraceExitMethod(171, 1930, 2288);

                System.IO.Stream
                f_171_2016_2034(Microsoft.CodeAnalysis.XmlReferenceResolver
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.OpenRead(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(171, 2016, 2034);
                    return return_v;
                }


                bool
                f_171_2073_2088_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(171, 2073, 2088);
                    return return_v;
                }


                string
                f_171_2158_2230()
                {
                    var return_v = CodeAnalysisResources.ReferenceResolverShouldReturnReadableNonNullStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(171, 2158, 2230);
                    return return_v;
                }


                System.InvalidOperationException
                f_171_2128_2231(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(171, 2128, 2231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(171, 1930, 2288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(171, 1930, 2288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static XmlReferenceResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(171, 395, 2295);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(171, 395, 2295);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(171, 395, 2295);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(171, 395, 2295);
    }
}
