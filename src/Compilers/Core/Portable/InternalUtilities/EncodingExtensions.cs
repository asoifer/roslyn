// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Roslyn.Utilities
{
    internal static class EncodingExtensions
    {
        internal static int GetMaxCharCountOrThrowIfHuge(this Encoding encoding, Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(323, 657, 1273);
                int maxCharCount = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 769, 798);

                f_323_769_797(f_323_782_796(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 812, 840);

                long
                length = f_323_826_839(stream)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 856, 986) || true) && (f_323_860_917(encoding, length, out maxCharCount))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(323, 856, 986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 951, 971);

                    return maxCharCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(323, 856, 986);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1193, 1254);

#if CODE_STYLE
            throw new IOException(CodeStyleResources.Stream_is_too_long);
#elif WORKSPACE
            throw new IOException(WorkspacesResources.Stream_is_too_long);
#else
                // LAFHIS
                var temp = CodeAnalysisResources.StreamIsTooLong;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(323, 1215, 1252);
                
                throw f_323_1199_1253(temp);
#endif
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(323, 657, 1273);

                bool
                f_323_782_796(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(323, 782, 796);
                    return return_v;
                }


                int
                f_323_769_797(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(323, 769, 797);
                    return 0;
                }


                long
                f_323_826_839(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(323, 826, 839);
                    return return_v;
                }


                bool
                f_323_860_917(System.Text.Encoding
                encoding, long
                length, out int
                maxCharCount)
                {
                    var return_v = encoding.TryGetMaxCharCount(length, out maxCharCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(323, 860, 917);
                    return return_v;
                }


                // LAFHIS (preprocessor directives)
                //string
                //f_323_1215_1252()
                //{
                //    var return_v = CodeAnalysisResources.StreamIsTooLong;
                //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(323, 1215, 1252);
                //    return return_v;
                //}


                System.IO.IOException
                f_323_1199_1253(string
                message)
                {
                    var return_v = new System.IO.IOException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(323, 1199, 1253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(323, 657, 1273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(323, 657, 1273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryGetMaxCharCount(this Encoding encoding, long length, out int maxCharCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(323, 1285, 2023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1408, 1425);

                maxCharCount = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1441, 1983) || true) && (length <= int.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(323, 1441, 1983);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1545, 1598);

                        maxCharCount = f_323_1560_1597(encoding, length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1620, 1632);

                        return true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(323, 1669, 1968);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(323, 1669, 1968);
                        // Encoding does not provide a way to predict that max byte count would not
                        // fit in Int32 and we must therefore catch ArgumentOutOfRange to handle that
                        // case.
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(323, 1441, 1983);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(323, 1999, 2012);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(323, 1285, 2023);

                int
                f_323_1560_1597(System.Text.Encoding
                this_param, long
                byteCount)
                {
                    var return_v = this_param.GetMaxCharCount((int)byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(323, 1560, 1597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(323, 1285, 2023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(323, 1285, 2023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EncodingExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(323, 356, 2030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(323, 356, 2030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(323, 356, 2030);
        }

    }
}
