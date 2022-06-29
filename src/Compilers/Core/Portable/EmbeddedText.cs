// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    public sealed class EmbeddedText
    {
        internal const int
        CompressionThreshold = 200
        ;

        public string FilePath { get; }

        public SourceHashAlgorithm ChecksumAlgorithm { get; }

        public ImmutableArray<byte> Checksum { get; }

        private EmbeddedText(string filePath, ImmutableArray<byte> checksum, SourceHashAlgorithm checksumAlgorithm, ImmutableArray<byte> blob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(14, 2012, 2527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 1545, 1576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 1725, 1778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2171, 2205);

                f_14_2171_2204(f_14_2184_2199(filePath) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2219, 2294);

                f_14_2219_2293(f_14_2232_2292(checksumAlgorithm));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2308, 2368);

                f_14_2308_2367(f_14_2321_2336_M(!blob.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(14, 2321, 2366) && blob.Length >= sizeof(int)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2384, 2404);

                FilePath = filePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2418, 2438);

                Checksum = checksum;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2452, 2490);

                ChecksumAlgorithm = checksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 2504, 2516);

                Blob = blob;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(14, 2012, 2527);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 2012, 2527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 2012, 2527);
            }
        }

        internal ImmutableArray<byte> Blob { get; }

        public static EmbeddedText FromSource(string filePath, SourceText text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 4299, 5076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4395, 4422);

                f_14_4395_4421(filePath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4438, 4549) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 4438, 4549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4488, 4534);

                    throw f_14_4494_4533(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 4438, 4549);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4565, 4729) || true) && (f_14_4569_4588_M(!text.CanBeEmbedded))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 4565, 4729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4622, 4714);

                    throw f_14_4628_4713(f_14_4650_4698(), nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 4565, 4729);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4745, 4953) || true) && (f_14_4749_4792_M(!text.PrecomputedEmbeddedTextBlob.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 4745, 4953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4826, 4938);

                    return f_14_4833_4937(filePath, f_14_4860_4878(text), f_14_4880_4902(text), f_14_4904_4936(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 4745, 4953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 4969, 5065);

                return f_14_4976_5064(filePath, f_14_5003_5021(text), f_14_5023_5045(text), f_14_5047_5063(text));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 4299, 5076);

                int
                f_14_4395_4421(string
                filePath)
                {
                    ValidateFilePath(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4395, 4421);
                    return 0;
                }


                System.ArgumentNullException
                f_14_4494_4533(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4494, 4533);
                    return return_v;
                }


                bool
                f_14_4569_4588_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 4569, 4588);
                    return return_v;
                }


                string
                f_14_4650_4698()
                {
                    var return_v = CodeAnalysisResources.SourceTextCannotBeEmbedded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 4650, 4698);
                    return return_v;
                }


                System.ArgumentException
                f_14_4628_4713(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4628, 4713);
                    return return_v;
                }


                bool
                f_14_4749_4792_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 4749, 4792);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_4860_4878(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.GetChecksum();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4860, 4878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_14_4880_4902(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 4880, 4902);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_4904_4936(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.PrecomputedEmbeddedTextBlob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 4904, 4936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_14_4833_4937(string
                filePath, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText(filePath, checksum, checksumAlgorithm, blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4833, 4937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_5003_5021(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.GetChecksum();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 5003, 5021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_14_5023_5045(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 5023, 5045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_5047_5063(Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    var return_v = CreateBlob(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 5047, 5063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_14_4976_5064(string
                filePath, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText(filePath, checksum, checksumAlgorithm, blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 4976, 5064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 4299, 5076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 4299, 5076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EmbeddedText FromStream(string filePath, Stream stream, SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 6113, 6928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6273, 6300);

                f_14_6273_6299(filePath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6316, 6431) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 6316, 6431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6368, 6416);

                    throw f_14_6374_6415(nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 6316, 6431);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6447, 6630) || true) && (f_14_6451_6466_M(!stream.CanRead) || (DynAbs.Tracing.TraceSender.Expression_False(14, 6451, 6485) || f_14_6470_6485_M(!stream.CanSeek)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 6447, 6630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6519, 6615);

                    throw f_14_6525_6614(f_14_6547_6597(), nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 6447, 6630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6646, 6702);

                f_14_6646_6701(checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 6718, 6917);

                return f_14_6725_6916(filePath, f_14_6787_6842(stream, checksumAlgorithm), checksumAlgorithm, f_14_6897_6915(stream));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 6113, 6928);

                int
                f_14_6273_6299(string
                filePath)
                {
                    ValidateFilePath(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6273, 6299);
                    return 0;
                }


                System.ArgumentNullException
                f_14_6374_6415(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6374, 6415);
                    return return_v;
                }


                bool
                f_14_6451_6466_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 6451, 6466);
                    return return_v;
                }


                bool
                f_14_6470_6485_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 6470, 6485);
                    return return_v;
                }


                string
                f_14_6547_6597()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportReadAndSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 6547, 6597);
                    return return_v;
                }


                System.ArgumentException
                f_14_6525_6614(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6525, 6614);
                    return return_v;
                }


                int
                f_14_6646_6701(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    SourceText.ValidateChecksumAlgorithm(checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6646, 6701);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_6787_6842(System.IO.Stream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = SourceText.CalculateChecksum(stream, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6787, 6842);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_6897_6915(System.IO.Stream
                stream)
                {
                    var return_v = CreateBlob(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6897, 6915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_14_6725_6916(string
                filePath, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText(filePath, checksum, checksumAlgorithm, blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 6725, 6916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 6113, 6928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 6113, 6928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static EmbeddedText FromBytes(string filePath, ArraySegment<byte> bytes, SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 7893, 8554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8063, 8090);

                f_14_8063_8089(filePath);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8106, 8225) || true) && (bytes.Array == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 8106, 8225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8163, 8210);

                    throw f_14_8169_8209(nameof(bytes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 8106, 8225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8241, 8297);

                f_14_8241_8296(checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8313, 8543);

                return f_14_8320_8542(filePath, f_14_8382_8469(bytes.Array, bytes.Offset, bytes.Count, checksumAlgorithm), checksumAlgorithm, f_14_8524_8541(bytes));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 7893, 8554);

                int
                f_14_8063_8089(string
                filePath)
                {
                    ValidateFilePath(filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8063, 8089);
                    return 0;
                }


                System.ArgumentNullException
                f_14_8169_8209(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8169, 8209);
                    return return_v;
                }


                int
                f_14_8241_8296(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    SourceText.ValidateChecksumAlgorithm(checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8241, 8296);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_8382_8469(byte[]
                buffer, int
                offset, int
                count, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = SourceText.CalculateChecksum(buffer, offset, count, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8382, 8469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_8524_8541(System.ArraySegment<byte>
                bytes)
                {
                    var return_v = CreateBlob(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8524, 8541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText
                f_14_8320_8542(string
                filePath, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText(filePath, checksum, checksumAlgorithm, blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8320, 8542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 7893, 8554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 7893, 8554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ValidateFilePath(string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 8767, 9155);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8845, 8964) || true) && (filePath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 8845, 8964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8899, 8949);

                    throw f_14_8905_8948(nameof(filePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 8845, 8964);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 8980, 9144) || true) && (f_14_8984_8999(filePath) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 8980, 9144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9038, 9129);

                    throw f_14_9044_9128(f_14_9066_9109(), nameof(filePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 8980, 9144);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 8767, 9155);

                System.ArgumentNullException
                f_14_8905_8948(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 8905, 8948);
                    return return_v;
                }


                int
                f_14_8984_8999(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 8984, 8999);
                    return return_v;
                }


                string
                f_14_9066_9109()
                {
                    var return_v = CodeAnalysisResources.ArgumentCannotBeEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 9066, 9109);
                    return return_v;
                }


                System.ArgumentException
                f_14_9044_9128(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9044, 9128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 8767, 9155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 8767, 9155);
            }
        }

        internal static ImmutableArray<byte> CreateBlob(Stream stream)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 9268, 11034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9355, 9390);

                f_14_9355_9389(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9404, 9439);

                f_14_9404_9438(f_14_9423_9437(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9453, 9488);

                f_14_9453_9487(f_14_9472_9486(stream));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9504, 9536);

                long
                longLength = f_14_9522_9535(stream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9550, 9580);

                f_14_9550_9579(longLength >= 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9596, 9735) || true) && (longLength > int.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 9596, 9735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9659, 9720);

                    throw f_14_9665_9719(f_14_9681_9718());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 9596, 9735);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9751, 9784);

                f_14_9751_9783(
                            stream, 0, SeekOrigin.Begin);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9798, 9827);

                int
                length = (int)longLength
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9843, 11023) || true) && (length < CompressionThreshold)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 9843, 11023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 9910, 10342);
                    using (var
                    builder = f_14_9931_9966()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10008, 10030);

                        f_14_10008_10029(builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10052, 10109);

                        int
                        bytesWritten = f_14_10071_10108(builder, stream, length)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10133, 10265) || true) && (length != bytesWritten)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 10133, 10265);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10209, 10242);

                            throw f_14_10215_10241();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(14, 10133, 10265);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10289, 10323);

                        return f_14_10296_10322(builder);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(14, 9910, 10342);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 9843, 11023);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 9843, 11023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10408, 11008);
                    using (var
                    builder = f_14_10429_10461()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10503, 10530);

                        f_14_10503_10529(builder, length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10554, 10931);
                        using (var
                        deflater = f_14_10576_10653(builder, CompressionLevel.Optimal, leaveOpen: true)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10703, 10727);

                            f_14_10703_10726(stream, deflater);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10755, 10908) || true) && (length != f_14_10769_10790(deflater))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 10755, 10908);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10848, 10881);

                                throw f_14_10854_10880();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(14, 10755, 10908);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(14, 10554, 10931);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 10955, 10989);

                        return f_14_10962_10988(builder);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(14, 10408, 11008);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 9843, 11023);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 9268, 11034);

                int
                f_14_9355_9389(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9355, 9389);
                    return 0;
                }


                bool
                f_14_9423_9437(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanRead;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 9423, 9437);
                    return return_v;
                }


                int
                f_14_9404_9438(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9404, 9438);
                    return 0;
                }


                bool
                f_14_9472_9486(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 9472, 9486);
                    return return_v;
                }


                int
                f_14_9453_9487(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9453, 9487);
                    return 0;
                }


                long
                f_14_9522_9535(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 9522, 9535);
                    return return_v;
                }


                int
                f_14_9550_9579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9550, 9579);
                    return 0;
                }


                string
                f_14_9681_9718()
                {
                    var return_v = CodeAnalysisResources.StreamIsTooLong;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 9681, 9718);
                    return return_v;
                }


                System.IO.IOException
                f_14_9665_9719(string
                message)
                {
                    var return_v = new System.IO.IOException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9665, 9719);
                    return return_v;
                }


                long
                f_14_9751_9783(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9751, 9783);
                    return return_v;
                }


                Microsoft.Cci.PooledBlobBuilder
                f_14_9931_9966()
                {
                    var return_v = Cci.PooledBlobBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 9931, 9966);
                    return return_v;
                }


                int
                f_14_10008_10029(Microsoft.Cci.PooledBlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10008, 10029);
                    return 0;
                }


                int
                f_14_10071_10108(Microsoft.Cci.PooledBlobBuilder
                this_param, System.IO.Stream
                source, int
                byteCount)
                {
                    var return_v = this_param.TryWriteBytes(source, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10071, 10108);
                    return return_v;
                }


                System.IO.EndOfStreamException
                f_14_10215_10241()
                {
                    var return_v = new System.IO.EndOfStreamException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10215, 10241);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_10296_10322(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10296, 10322);
                    return return_v;
                }


                Roslyn.Utilities.BlobBuildingStream
                f_14_10429_10461()
                {
                    var return_v = BlobBuildingStream.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10429, 10461);
                    return return_v;
                }


                int
                f_14_10503_10529(Roslyn.Utilities.BlobBuildingStream
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10503, 10529);
                    return 0;
                }


                Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                f_14_10576_10653(Roslyn.Utilities.BlobBuildingStream
                stream, System.IO.Compression.CompressionLevel
                compressionLevel, bool
                leaveOpen)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream((System.IO.Stream)stream, compressionLevel, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10576, 10653);
                    return return_v;
                }


                int
                f_14_10703_10726(System.IO.Stream
                this_param, Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                destination)
                {
                    this_param.CopyTo((System.IO.Stream)destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10703, 10726);
                    return 0;
                }


                int
                f_14_10769_10790(Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                this_param)
                {
                    var return_v = this_param.BytesWritten;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 10769, 10790);
                    return return_v;
                }


                System.IO.EndOfStreamException
                f_14_10854_10880()
                {
                    var return_v = new System.IO.EndOfStreamException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10854, 10880);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_10962_10988(Roslyn.Utilities.BlobBuildingStream
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 10962, 10988);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 9268, 11034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 9268, 11034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> CreateBlob(ArraySegment<byte> bytes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 11046, 12095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11144, 11184);

                f_14_11144_11183(bytes.Array != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11200, 12084) || true) && (bytes.Count < CompressionThreshold)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 11200, 12084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11272, 11548);
                    using (var
                    builder = f_14_11293_11328()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11370, 11392);

                        f_14_11370_11391(builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11414, 11473);

                        f_14_11414_11472(builder, bytes.Array, bytes.Offset, bytes.Count);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11495, 11529);

                        return f_14_11502_11528(builder);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(14, 11272, 11548);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 11200, 12084);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 11200, 12084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11614, 12069);
                    using (var
                    builder = f_14_11635_11667()
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11709, 11741);

                        f_14_11709_11740(builder, bytes.Count);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11765, 11992);
                        using (var
                        deflater = f_14_11787_11864(builder, CompressionLevel.Optimal, leaveOpen: true)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 11914, 11969);

                            f_14_11914_11968(deflater, bytes.Array, bytes.Offset, bytes.Count);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(14, 11765, 11992);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12016, 12050);

                        return f_14_12023_12049(builder);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(14, 11614, 12069);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(14, 11200, 12084);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 11046, 12095);

                int
                f_14_11144_11183(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11144, 11183);
                    return 0;
                }


                Microsoft.Cci.PooledBlobBuilder
                f_14_11293_11328()
                {
                    var return_v = Cci.PooledBlobBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11293, 11328);
                    return return_v;
                }


                int
                f_14_11370_11391(Microsoft.Cci.PooledBlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11370, 11391);
                    return 0;
                }


                int
                f_14_11414_11472(Microsoft.Cci.PooledBlobBuilder
                this_param, byte[]
                buffer, int
                start, int
                byteCount)
                {
                    this_param.WriteBytes(buffer, start, byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11414, 11472);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_11502_11528(Microsoft.Cci.PooledBlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11502, 11528);
                    return return_v;
                }


                Roslyn.Utilities.BlobBuildingStream
                f_14_11635_11667()
                {
                    var return_v = BlobBuildingStream.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11635, 11667);
                    return return_v;
                }


                int
                f_14_11709_11740(Roslyn.Utilities.BlobBuildingStream
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11709, 11740);
                    return 0;
                }


                Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                f_14_11787_11864(Roslyn.Utilities.BlobBuildingStream
                stream, System.IO.Compression.CompressionLevel
                compressionLevel, bool
                leaveOpen)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream((System.IO.Stream)stream, compressionLevel, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11787, 11864);
                    return return_v;
                }


                int
                f_14_11914_11968(Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    this_param.Write(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 11914, 11968);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_12023_12049(Roslyn.Utilities.BlobBuildingStream
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12023, 12049);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 11046, 12095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 11046, 12095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ImmutableArray<byte> CreateBlob(SourceText text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(14, 12107, 14050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12195, 12228);

                f_14_12195_12227(text != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12242, 12281);

                f_14_12242_12280(f_14_12261_12279(text));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12295, 12337);

                f_14_12295_12336(f_14_12314_12327(text) != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12351, 12414);

                f_14_12351_12413(text.PrecomputedEmbeddedTextBlob.IsDefault);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12430, 12447);

                int
                maxByteCount
                = default(int);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12497, 12555);

                    maxByteCount = f_14_12512_12554(f_14_12512_12525(text), f_14_12542_12553(text));
                }
                catch (ArgumentOutOfRangeException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(14, 12584, 12909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12866, 12894);

                    maxByteCount = int.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(14, 12584, 12909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 12925, 14039);
                using (var
                builder = f_14_12946_12978()
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13012, 13970) || true) && (maxByteCount < CompressionThreshold)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 13012, 13970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13093, 13115);

                        f_14_13093_13114(builder, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13139, 13346);
                        using (var
                        writer = f_14_13159_13254(builder, f_14_13185_13198(text), bufferSize: f_14_13212_13236(1, f_14_13224_13235(text)), leaveOpen: true)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13304, 13323);

                            f_14_13304_13322(text, writer);
                            DynAbs.Tracing.TraceSender.TraceExitUsing(14, 13139, 13346);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(14, 13012, 13970);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(14, 13012, 13970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13428, 13468);

                        Blob
                        reserved = f_14_13444_13467(builder, 4)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13492, 13951);
                        using (var
                        deflater = f_14_13514_13591(builder, CompressionLevel.Optimal, leaveOpen: true)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13641, 13841);
                            using (var
                            writer = f_14_13661_13737(deflater, f_14_13688_13701(text), bufferSize: 1024, leaveOpen: true)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13795, 13814);

                                f_14_13795_13813(text, writer);
                                DynAbs.Tracing.TraceSender.TraceExitUsing(14, 13641, 13841);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13869, 13928);

                            f_14_13869_13893(reserved).WriteInt32(f_14_13905_13926(deflater));
                            DynAbs.Tracing.TraceSender.TraceExitUsing(14, 13492, 13951);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(14, 13012, 13970);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 13990, 14024);

                    return f_14_13997_14023(builder);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(14, 12925, 14039);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(14, 12107, 14050);

                int
                f_14_12195_12227(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12195, 12227);
                    return 0;
                }


                bool
                f_14_12261_12279(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.CanBeEmbedded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 12261, 12279);
                    return return_v;
                }


                int
                f_14_12242_12280(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12242, 12280);
                    return 0;
                }


                System.Text.Encoding?
                f_14_12314_12327(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 12314, 12327);
                    return return_v;
                }


                int
                f_14_12295_12336(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12295, 12336);
                    return 0;
                }


                int
                f_14_12351_12413(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12351, 12413);
                    return 0;
                }


                System.Text.Encoding
                f_14_12512_12525(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 12512, 12525);
                    return return_v;
                }


                int
                f_14_12542_12553(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 12542, 12553);
                    return return_v;
                }


                int
                f_14_12512_12554(System.Text.Encoding
                this_param, int
                charCount)
                {
                    var return_v = this_param.GetMaxByteCount(charCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12512, 12554);
                    return return_v;
                }


                Roslyn.Utilities.BlobBuildingStream
                f_14_12946_12978()
                {
                    var return_v = BlobBuildingStream.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 12946, 12978);
                    return return_v;
                }


                int
                f_14_13093_13114(Roslyn.Utilities.BlobBuildingStream
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13093, 13114);
                    return 0;
                }


                System.Text.Encoding
                f_14_13185_13198(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 13185, 13198);
                    return return_v;
                }


                int
                f_14_13224_13235(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 13224, 13235);
                    return return_v;
                }


                int
                f_14_13212_13236(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13212, 13236);
                    return return_v;
                }


                System.IO.StreamWriter
                f_14_13159_13254(Roslyn.Utilities.BlobBuildingStream
                stream, System.Text.Encoding
                encoding, int
                bufferSize, bool
                leaveOpen)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding, bufferSize: bufferSize, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13159, 13254);
                    return return_v;
                }


                int
                f_14_13304_13322(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.IO.StreamWriter
                textWriter)
                {
                    this_param.Write((System.IO.TextWriter)textWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13304, 13322);
                    return 0;
                }


                System.Reflection.Metadata.Blob
                f_14_13444_13467(Roslyn.Utilities.BlobBuildingStream
                this_param, int
                byteCount)
                {
                    var return_v = this_param.ReserveBytes(byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13444, 13467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                f_14_13514_13591(Roslyn.Utilities.BlobBuildingStream
                stream, System.IO.Compression.CompressionLevel
                compressionLevel, bool
                leaveOpen)
                {
                    var return_v = new Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream((System.IO.Stream)stream, compressionLevel, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13514, 13591);
                    return return_v;
                }


                System.Text.Encoding
                f_14_13688_13701(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 13688, 13701);
                    return return_v;
                }


                System.IO.StreamWriter
                f_14_13661_13737(Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                stream, System.Text.Encoding
                encoding, int
                bufferSize, bool
                leaveOpen)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding, bufferSize: bufferSize, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13661, 13737);
                    return return_v;
                }


                int
                f_14_13795_13813(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.IO.StreamWriter
                textWriter)
                {
                    this_param.Write((System.IO.TextWriter)textWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13795, 13813);
                    return 0;
                }


                System.Reflection.Metadata.BlobWriter
                f_14_13869_13893(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13869, 13893);
                    return return_v;
                }


                int
                f_14_13905_13926(Microsoft.CodeAnalysis.EmbeddedText.CountingDeflateStream
                this_param)
                {
                    var return_v = this_param.BytesWritten;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 13905, 13926);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_13997_14023(Roslyn.Utilities.BlobBuildingStream
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 13997, 14023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 12107, 14050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 12107, 14050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.DebugSourceInfo GetDebugSourceInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(14, 14062, 14213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 14136, 14202);

                return f_14_14143_14201(f_14_14167_14175(), f_14_14177_14194(), f_14_14196_14200());
                DynAbs.Tracing.TraceSender.TraceExitMethod(14, 14062, 14213);

                System.Collections.Immutable.ImmutableArray<byte>
                f_14_14167_14175()
                {
                    var return_v = Checksum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 14167, 14175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_14_14177_14194()
                {
                    var return_v = ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 14177, 14194);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_14_14196_14200()
                {
                    var return_v = Blob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 14196, 14200);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceInfo
                f_14_14143_14201(System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                embeddedTextBlob)
                {
                    var return_v = new Microsoft.Cci.DebugSourceInfo(checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 14143, 14201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 14062, 14213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 14062, 14213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class CountingDeflateStream : DeflateStream
        {
            public CountingDeflateStream(Stream stream, CompressionLevel compressionLevel, bool leaveOpen)
            : base(f_14_14427_14433_C(stream), compressionLevel, leaveOpen)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(14, 14308, 14493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 14509, 14554);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(14, 14308, 14493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 14308, 14493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 14308, 14493);
                }
            }

            public int BytesWritten { get; private set; }

            public override void Write(byte[] array, int offset, int count)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(14, 14570, 15094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 14666, 14699);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Write(array, offset, count), 14, 14666, 14698);

                    // checked arithmetic is release-enabled quasi-assert. We start with at most 
                    // int.MaxValue chars so compression or encoding would have to be abysmal for
                    // this to overflow. We'd probably be lucky to even get this far but if we do
                    // we should fail fast.
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 15055, 15077);

                        BytesWritten += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => count, 14, 15055, 15067);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(14, 14570, 15094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 14570, 15094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 14570, 15094);
                }
            }

            public override void WriteByte(byte value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(14, 15110, 15338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 15185, 15207);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteByte(value), 14, 15185, 15206);

                    // same rationale for checked arithmetic as above.
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 15305, 15320);

                        f_14_15305_15319_M(BytesWritten++);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 15322, 15323);
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(14, 15110, 15338);

                    int
                    f_14_15305_15319_M(int
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 15305, 15319);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 15110, 15338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 15110, 15338);
                }
            }

            public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(14, 15354, 15545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 15493, 15530);

                    throw f_14_15499_15529();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(14, 15354, 15545);

                    System.Exception
                    f_14_15499_15529()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 15499, 15529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(14, 15354, 15545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 15354, 15545);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CountingDeflateStream()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(14, 14225, 15556);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(14, 14225, 15556);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 14225, 15556);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(14, 14225, 15556);

            static System.IO.Stream
            f_14_14427_14433_C(System.IO.Stream
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(14, 14308, 14493);
                return return_v;
            }

        }

        static EmbeddedText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(14, 660, 15563);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(14, 1169, 1195);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(14, 660, 15563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(14, 660, 15563);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(14, 660, 15563);

        static int
        f_14_2184_2199(string
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 2184, 2199);
            return return_v;
        }


        static int
        f_14_2171_2204(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 2171, 2204);
            return 0;
        }


        static bool
        f_14_2232_2292(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        algorithm)
        {
            var return_v = SourceHashAlgorithms.IsSupportedAlgorithm(algorithm);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 2232, 2292);
            return return_v;
        }


        static int
        f_14_2219_2293(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 2219, 2293);
            return 0;
        }


        bool
        f_14_2321_2336_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(14, 2321, 2336);
            return return_v;
        }


        static int
        f_14_2308_2367(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(14, 2308, 2367);
            return 0;
        }

    }
}
