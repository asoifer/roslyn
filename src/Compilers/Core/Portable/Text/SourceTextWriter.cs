// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;
using System.Text;

namespace Microsoft.CodeAnalysis.Text
{
    internal abstract class SourceTextWriter : TextWriter
    {
        public abstract SourceText ToSourceText();

        public static SourceTextWriter Create(Encoding? encoding, SourceHashAlgorithm checksumAlgorithm, int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(724, 418, 857);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(724, 551, 846) || true) && (length < SourceText.LargeObjectHeapLimitInChars)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(724, 551, 846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(724, 636, 701);

                    return f_724_643_700(encoding, checksumAlgorithm, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(724, 551, 846);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(724, 551, 846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(724, 767, 831);

                    return f_724_774_830(encoding, checksumAlgorithm, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(724, 551, 846);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(724, 418, 857);

                Microsoft.CodeAnalysis.Text.StringTextWriter
                f_724_643_700(System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, int
                capacity)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringTextWriter(encoding, checksumAlgorithm, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(724, 643, 700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LargeTextWriter
                f_724_774_830(System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LargeTextWriter(encoding, checksumAlgorithm, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(724, 774, 830);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(724, 418, 857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(724, 418, 857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(724, 294, 864);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(724, 294, 864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(724, 294, 864);
        }


        static SourceTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(724, 294, 864);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(724, 294, 864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(724, 294, 864);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(724, 294, 864);
    }
}
