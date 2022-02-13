// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.DiaSymReader;

namespace Roslyn.Test.PdbUtilities
{
    internal class SymUnmanagedWriterWithoutSourceLinkSupport : DelegatingSymUnmanagedWriter
    {
        public SymUnmanagedWriterWithoutSourceLinkSupport(ISymWriterMetadataProvider metadataProvider)
        : base(f_24015_540_596_C(f_24015_540_596(metadataProvider)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24015, 425, 619);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24015, 425, 619);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24015, 425, 619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24015, 425, 619);
            }
        }

        public override void SetSourceLinkData(byte[] data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24015, 696, 786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24015, 699, 786);
                throw f_24015_705_786("xxx", f_24015_744_771(), "<lib name>"); DynAbs.Tracing.TraceSender.TraceExitMethod(24015, 696, 786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24015, 696, 786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24015, 696, 786);
            }
        }

        static SymUnmanagedWriterWithoutSourceLinkSupport()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24015, 320, 794);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24015, 320, 794);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24015, 320, 794);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(24015, 320, 794);

        static Microsoft.DiaSymReader.SymUnmanagedWriter
        f_24015_540_596(Microsoft.DiaSymReader.ISymWriterMetadataProvider
        metadataProvider)
        {
            var return_v = SymUnmanagedWriterFactory.CreateWriter(metadataProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24015, 540, 596);
            return return_v;
        }


        static Microsoft.DiaSymReader.SymUnmanagedWriter
        f_24015_540_596_C(Microsoft.DiaSymReader.SymUnmanagedWriter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(24015, 425, 619);
            return return_v;
        }


        System.NotSupportedException
        f_24015_744_771()
        {
            var return_v = new System.NotSupportedException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24015, 744, 771);
            return return_v;
        }


        Microsoft.DiaSymReader.SymUnmanagedWriterException
        f_24015_705_786(string
        message, System.NotSupportedException
        innerException, string
        implementationModuleName)
        {
            var return_v = new Microsoft.DiaSymReader.SymUnmanagedWriterException(message, (System.Exception)innerException, implementationModuleName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(24015, 705, 786);
            return return_v;
        }

    }
}
