// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    public abstract class SourceReferenceResolver
    {
        protected SourceReferenceResolver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(164, 530, 587);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(164, 530, 587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(164, 530, 587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(164, 530, 587);
            }
        }

        public abstract override bool Equals(object? other);

        public abstract override int GetHashCode();

        public abstract string? NormalizePath(string path, string? baseFilePath);

        public abstract string? ResolveReference(string path, string? baseFilePath);

        public abstract Stream OpenRead(string resolvedPath);

        internal Stream OpenReadChecked(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(164, 2596, 2954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 2669, 2701);

                var
                stream = f_164_2682_2700(this, fullPath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 2717, 2913) || true) && (stream == null || (DynAbs.Tracing.TraceSender.Expression_False(164, 2721, 2754) || f_164_2739_2754_M(!stream.CanRead)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(164, 2717, 2913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 2788, 2898);

                    throw f_164_2794_2897(f_164_2824_2896());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(164, 2717, 2913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 2929, 2943);

                return stream;
                DynAbs.Tracing.TraceSender.TraceExitMethod(164, 2596, 2954);

                System.IO.Stream
                f_164_2682_2700(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.OpenRead(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(164, 2682, 2700);
                    return return_v;
                }


                bool
                f_164_2739_2754_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(164, 2739, 2754);
                    return return_v;
                }


                string
                f_164_2824_2896()
                {
                    var return_v = CodeAnalysisResources.ReferenceResolverShouldReturnReadableNonNullStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(164, 2824, 2896);
                    return return_v;
                }


                System.InvalidOperationException
                f_164_2794_2897(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(164, 2794, 2897);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(164, 2596, 2954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(164, 2596, 2954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SourceText ReadText(string resolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(164, 3233, 3455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 3313, 3444);
                using (var
                stream = f_164_3333_3355(this, resolvedPath)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(164, 3389, 3429);

                    return f_164_3396_3428(stream);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(164, 3313, 3444);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(164, 3233, 3455);

                System.IO.Stream
                f_164_3333_3355(Microsoft.CodeAnalysis.SourceReferenceResolver
                this_param, string
                resolvedPath)
                {
                    var return_v = this_param.OpenRead(resolvedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(164, 3333, 3355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_164_3396_3428(System.IO.Stream
                stream)
                {
                    var return_v = EncodedStringText.Create(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(164, 3396, 3428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(164, 3233, 3455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(164, 3233, 3455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SourceReferenceResolver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(164, 468, 3462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(164, 468, 3462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(164, 468, 3462);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(164, 468, 3462);
    }
}
