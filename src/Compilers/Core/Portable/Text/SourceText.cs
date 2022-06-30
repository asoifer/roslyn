// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    public abstract class SourceText
    {
        private const int
        CharBufferSize = 32 * 1024
        ;

        private const int
        CharBufferCount = 5
        ;

        internal const int
        LargeObjectHeapLimitInChars = 40 * 1024
        ;

        private static readonly ObjectPool<char[]> s_charArrayPool;

        private readonly SourceHashAlgorithm _checksumAlgorithm;

        private SourceTextContainer? _lazyContainer;

        private TextLineCollection? _lazyLineInfo;

        private ImmutableArray<byte> _lazyChecksum;

        private ImmutableArray<byte> _precomputedEmbeddedTextBlob;

        private static readonly Encoding s_utf8EncodingWithNoBOM;

        protected SourceText(ImmutableArray<byte> checksum = default(ImmutableArray<byte>), SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1, SourceTextContainer? container = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(720, 1540, 2192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1126, 1144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1184, 1198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1237, 1250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1753, 1798);

                f_720_1753_1797(checksumAlgorithm);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1814, 2046) || true) && (f_720_1818_1837_M(!checksum.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(720, 1818, 1916) && checksum.Length != f_720_1860_1916(checksumAlgorithm)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 1814, 2046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1950, 2031);

                    throw f_720_1956_2030(f_720_1978_2011(), nameof(checksum));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 1814, 2046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2062, 2101);

                _checksumAlgorithm = checksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2115, 2140);

                _lazyChecksum = checksum;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2154, 2181);

                _lazyContainer = container;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(720, 1540, 2192);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 1540, 2192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 1540, 2192);
            }
        }

        internal SourceText(ImmutableArray<byte> checksum, SourceHashAlgorithm checksumAlgorithm, ImmutableArray<byte> embeddedTextBlob)
        : this(f_720_2353_2361_C(checksum), checksumAlgorithm, container: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(720, 2204, 3110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2530, 2594);

                f_720_2530_2593(embeddedTextBlob.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(720, 2543, 2592) || f_720_2573_2592_M(!checksum.IsDefault)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2610, 3099) || true) && (f_720_2614_2633_M(!checksum.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(720, 2614, 2663) && embeddedTextBlob.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 2610, 3099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 2912, 2970);

                    _precomputedEmbeddedTextBlob = ImmutableArray<byte>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 2610, 3099);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 2610, 3099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 3036, 3084);

                    _precomputedEmbeddedTextBlob = embeddedTextBlob;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 2610, 3099);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(720, 2204, 3110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 2204, 3110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 2204, 3110);
            }
        }

        internal static void ValidateChecksumAlgorithm(SourceHashAlgorithm checksumAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 3122, 3460);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 3232, 3449) || true) && (!f_720_3237_3297(checksumAlgorithm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 3232, 3449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 3331, 3434);

                    throw f_720_3337_3433(f_720_3359_3405(), nameof(checksumAlgorithm));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 3232, 3449);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 3122, 3460);

                bool
                f_720_3237_3297(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithm)
                {
                    var return_v = SourceHashAlgorithms.IsSupportedAlgorithm(algorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 3237, 3297);
                    return return_v;
                }


                string
                f_720_3359_3405()
                {
                    var return_v = CodeAnalysisResources.UnsupportedHashAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 3359, 3405);
                    return return_v;
                }


                System.ArgumentException
                f_720_3337_3433(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 3337, 3433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 3122, 3460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 3122, 3460);
            }
        }

        public static SourceText From(string text, Encoding? encoding = null, SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 4476, 4850);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 4636, 4747) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 4636, 4747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 4686, 4732);

                    throw f_720_4692_4731(nameof(text));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 4636, 4747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 4763, 4839);

                return f_720_4770_4838(text, encoding, checksumAlgorithm: checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 4476, 4850);

                System.ArgumentNullException
                f_720_4692_4731(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 4692, 4731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.StringText
                f_720_4770_4838(string
                source, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringText(source, encodingOpt, checksumAlgorithm: checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 4770, 4838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 4476, 4850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 4476, 4850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static SourceText From(
                    TextReader reader,
                    int length,
                    Encoding? encoding = null,
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 5968, 6716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6199, 6314) || true) && (reader == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 6199, 6314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6251, 6299);

                    throw f_720_6257_6298(nameof(reader));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 6199, 6314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6436, 6595) || true) && (length >= LargeObjectHeapLimitInChars)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 6436, 6595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6511, 6580);

                    return f_720_6518_6579(reader, length, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 6436, 6595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6611, 6644);

                string
                text = f_720_6625_6643(reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6658, 6705);

                return f_720_6665_6704(text, encoding, checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 5968, 6716);

                System.ArgumentNullException
                f_720_6257_6298(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 6257, 6298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_6518_6579(System.IO.TextReader
                reader, int
                length, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = LargeText.Decode(reader, length, encodingOpt, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 6518, 6579);
                    return return_v;
                }


                string
                f_720_6625_6643(System.IO.TextReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 6625, 6643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_6665_6704(string
                text, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 6665, 6704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 5968, 6716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 5968, 6716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SourceText From(Stream stream, Encoding? encoding, SourceHashAlgorithm checksumAlgorithm, bool throwIfBinaryDetected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 6977, 7066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 6980, 7066);
                return f_720_6980_7066(stream, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded: false); DynAbs.Tracing.TraceSender.TraceExitMethod(720, 6977, 7066);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 6977, 7066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 6977, 7066);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Text.SourceText
            f_720_6980_7066(System.IO.Stream
            stream, System.Text.Encoding?
            encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
            checksumAlgorithm, bool
            throwIfBinaryDetected, bool
            canBeEmbedded)
            {
                var return_v = From(stream, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded: canBeEmbedded);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 6980, 7066);
                return return_v;
            }

        }

        public static SourceText From(
                    Stream stream,
                    Encoding? encoding = null,
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1,
                    bool throwIfBinaryDetected = false,
                    bool canBeEmbedded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 8814, 10702);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9106, 9221) || true) && (stream == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 9106, 9221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9158, 9206);

                    throw f_720_9164_9205(nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 9106, 9221);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9237, 9401) || true) && (f_720_9241_9256_M(!stream.CanRead))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 9237, 9401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9290, 9386);

                    throw f_720_9296_9385(f_720_9318_9368(), nameof(stream));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 9237, 9401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9417, 9462);

                f_720_9417_9461(checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9478, 9525);

                encoding = encoding ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(720, 9489, 9524) ?? s_utf8EncodingWithNoBOM);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9541, 9958) || true) && (f_720_9545_9559(stream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 9541, 9958);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9703, 9943) || true) && (f_720_9707_9752(encoding, stream) >= LargeObjectHeapLimitInChars)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 9703, 9943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9825, 9924);

                        return f_720_9832_9923(stream, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 9703, 9943);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 9541, 9958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 9974, 10027);

                string
                text = f_720_9988_10026(stream, encoding, out encoding)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10041, 10166) || true) && (throwIfBinaryDetected && (DynAbs.Tracing.TraceSender.Expression_True(720, 10045, 10084) && f_720_10070_10084(text)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 10041, 10166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10118, 10151);

                    throw f_720_10124_10150();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 10041, 10166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10415, 10475);

                var
                checksum = f_720_10430_10474(stream, checksumAlgorithm)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10489, 10592);

                var
                embeddedTextBlob = (DynAbs.Tracing.TraceSender.Conditional_F1(720, 10512, 10525) || ((canBeEmbedded && DynAbs.Tracing.TraceSender.Conditional_F2(720, 10528, 10559)) || DynAbs.Tracing.TraceSender.Conditional_F3(720, 10562, 10591))) ? f_720_10528_10559(stream) : default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10606, 10691);

                return f_720_10613_10690(text, encoding, checksum, checksumAlgorithm, embeddedTextBlob);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 8814, 10702);

                System.ArgumentNullException
                f_720_9164_9205(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9164, 9205);
                    return return_v;
                }


                bool
                f_720_9241_9256_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 9241, 9256);
                    return return_v;
                }


                string
                f_720_9318_9368()
                {
                    var return_v = CodeAnalysisResources.StreamMustSupportReadAndSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 9318, 9368);
                    return return_v;
                }


                System.ArgumentException
                f_720_9296_9385(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9296, 9385);
                    return return_v;
                }


                int
                f_720_9417_9461(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    ValidateChecksumAlgorithm(checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9417, 9461);
                    return 0;
                }


                bool
                f_720_9545_9559(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 9545, 9559);
                    return return_v;
                }


                int
                f_720_9707_9752(System.Text.Encoding
                encoding, System.IO.Stream
                stream)
                {
                    var return_v = encoding.GetMaxCharCountOrThrowIfHuge(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9707, 9752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_9832_9923(System.IO.Stream
                stream, System.Text.Encoding
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, bool
                throwIfBinaryDetected, bool
                canBeEmbedded)
                {
                    var return_v = LargeText.Decode(stream, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9832, 9923);
                    return return_v;
                }


                string
                f_720_9988_10026(System.IO.Stream
                stream, System.Text.Encoding
                encoding, out System.Text.Encoding?
                actualEncoding)
                {
                    var return_v = Decode(stream, encoding, out actualEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 9988, 10026);
                    return return_v;
                }


                bool
                f_720_10070_10084(string
                text)
                {
                    var return_v = IsBinary(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10070, 10084);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_720_10124_10150()
                {
                    var return_v = new System.IO.InvalidDataException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10124, 10150);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_10430_10474(System.IO.Stream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CalculateChecksum(stream, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10430, 10474);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_10528_10559(System.IO.Stream
                stream)
                {
                    var return_v = EmbeddedText.CreateBlob(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10528, 10559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.StringText
                f_720_10613_10690(string
                source, System.Text.Encoding
                encodingOpt, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                embeddedTextBlob)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringText(source, encodingOpt, checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10613, 10690);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 8814, 10702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 8814, 10702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SourceText From(byte[] buffer, int length, Encoding? encoding, SourceHashAlgorithm checksumAlgorithm, bool throwIfBinaryDetected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 10977, 11074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 10980, 11074);
                return f_720_10980_11074(buffer, length, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded: false); DynAbs.Tracing.TraceSender.TraceExitMethod(720, 10977, 11074);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 10977, 11074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 10977, 11074);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Text.SourceText
            f_720_10980_11074(byte[]
            buffer, int
            length, System.Text.Encoding?
            encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
            checksumAlgorithm, bool
            throwIfBinaryDetected, bool
            canBeEmbedded)
            {
                var return_v = From(buffer, length, encoding, checksumAlgorithm, throwIfBinaryDetected, canBeEmbedded: canBeEmbedded);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 10980, 11074);
                return return_v;
            }

        }

        public static SourceText From(
                    byte[] buffer,
                    int length,
                    Encoding? encoding = null,
                    SourceHashAlgorithm checksumAlgorithm = SourceHashAlgorithm.Sha1,
                    bool throwIfBinaryDetected = false,
                    bool canBeEmbedded = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 12819, 14296);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13136, 13251) || true) && (buffer == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 13136, 13251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13188, 13236);

                    throw f_720_13194_13235(nameof(buffer));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 13136, 13251);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13267, 13410) || true) && (length < 0 || (DynAbs.Tracing.TraceSender.Expression_False(720, 13271, 13307) || length > f_720_13294_13307(buffer)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 13267, 13410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13341, 13395);

                    throw f_720_13347_13394(nameof(length));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 13267, 13410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13426, 13471);

                f_720_13426_13470(checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13487, 13575);

                string
                text = f_720_13501_13574(buffer, length, encoding ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(720, 13524, 13559) ?? s_utf8EncodingWithNoBOM), out encoding)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13589, 13714) || true) && (throwIfBinaryDetected && (DynAbs.Tracing.TraceSender.Expression_True(720, 13593, 13632) && f_720_13618_13632(text)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 13589, 13714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13666, 13699);

                    throw f_720_13672_13698();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 13589, 13714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 13963, 14034);

                var
                checksum = f_720_13978_14033(buffer, 0, length, checksumAlgorithm)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 14048, 14186);

                var
                embeddedTextBlob = (DynAbs.Tracing.TraceSender.Conditional_F1(720, 14071, 14084) || ((canBeEmbedded && DynAbs.Tracing.TraceSender.Conditional_F2(720, 14087, 14153)) || DynAbs.Tracing.TraceSender.Conditional_F3(720, 14156, 14185))) ? f_720_14087_14153(f_720_14111_14152(buffer, 0, length)) : default(ImmutableArray<byte>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 14200, 14285);

                return f_720_14207_14284(text, encoding, checksum, checksumAlgorithm, embeddedTextBlob);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 12819, 14296);

                System.ArgumentNullException
                f_720_13194_13235(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13194, 13235);
                    return return_v;
                }


                int
                f_720_13294_13307(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 13294, 13307);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_720_13347_13394(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13347, 13394);
                    return return_v;
                }


                int
                f_720_13426_13470(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    ValidateChecksumAlgorithm(checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13426, 13470);
                    return 0;
                }


                string
                f_720_13501_13574(byte[]
                buffer, int
                length, System.Text.Encoding
                encoding, out System.Text.Encoding?
                actualEncoding)
                {
                    var return_v = Decode(buffer, length, encoding, out actualEncoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13501, 13574);
                    return return_v;
                }


                bool
                f_720_13618_13632(string
                text)
                {
                    var return_v = IsBinary(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13618, 13632);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_720_13672_13698()
                {
                    var return_v = new System.IO.InvalidDataException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13672, 13698);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_13978_14033(byte[]
                buffer, int
                offset, int
                count, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CalculateChecksum(buffer, offset, count, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 13978, 14033);
                    return return_v;
                }


                System.ArraySegment<byte>
                f_720_14111_14152(byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = new System.ArraySegment<byte>(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 14111, 14152);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_14087_14153(System.ArraySegment<byte>
                bytes)
                {
                    var return_v = EmbeddedText.CreateBlob(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 14087, 14153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.StringText
                f_720_14207_14284(string
                source, System.Text.Encoding
                encodingOpt, System.Collections.Immutable.ImmutableArray<byte>
                checksum, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm, System.Collections.Immutable.ImmutableArray<byte>
                embeddedTextBlob)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringText(source, encodingOpt, checksum, checksumAlgorithm, embeddedTextBlob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 14207, 14284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 12819, 14296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 12819, 14296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string Decode(Stream stream, Encoding encoding, out Encoding actualEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 14862, 16348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 14978, 15013);

                f_720_14978_15012(stream != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15027, 15064);

                f_720_15027_15063(encoding != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15078, 15109);

                const int
                maxBufferSize = 4096
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15123, 15154);

                int
                bufferSize = maxBufferSize
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15170, 15549) || true) && (f_720_15174_15188(stream))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 15170, 15549);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15222, 15255);

                    f_720_15222_15254(stream, 0, SeekOrigin.Begin);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15275, 15307);

                    int
                    length = (int)f_720_15293_15306(stream)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15325, 15469) || true) && (length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 15325, 15469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15382, 15408);

                        actualEncoding = encoding;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15430, 15450);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 15325, 15469);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 15489, 15534);

                    bufferSize = f_720_15502_15533(maxBufferSize, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 15170, 15549);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 16032, 16337);
                using (var
                reader = f_720_16052_16167(stream, encoding, detectEncodingFromByteOrderMarks: true, bufferSize: bufferSize, leaveOpen: true)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 16201, 16234);

                    string
                    text = f_720_16215_16233(reader)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 16252, 16292);

                    actualEncoding = f_720_16269_16291(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 16310, 16322);

                    return text;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(720, 16032, 16337);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 14862, 16348);

                int
                f_720_14978_15012(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 14978, 15012);
                    return 0;
                }


                int
                f_720_15027_15063(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 15027, 15063);
                    return 0;
                }


                bool
                f_720_15174_15188(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 15174, 15188);
                    return return_v;
                }


                long
                f_720_15222_15254(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 15222, 15254);
                    return return_v;
                }


                long
                f_720_15293_15306(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 15293, 15306);
                    return return_v;
                }


                int
                f_720_15502_15533(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 15502, 15533);
                    return return_v;
                }


                System.IO.StreamReader
                f_720_16052_16167(System.IO.Stream
                stream, System.Text.Encoding
                encoding, bool
                detectEncodingFromByteOrderMarks, int
                bufferSize, bool
                leaveOpen)
                {
                    var return_v = new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks: detectEncodingFromByteOrderMarks, bufferSize: bufferSize, leaveOpen: leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 16052, 16167);
                    return return_v;
                }


                string
                f_720_16215_16233(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.ReadToEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 16215, 16233);
                    return return_v;
                }


                System.Text.Encoding
                f_720_16269_16291(System.IO.StreamReader
                this_param)
                {
                    var return_v = this_param.CurrentEncoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 16269, 16291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 14862, 16348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 14862, 16348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string Decode(byte[] buffer, int length, Encoding encoding, out Encoding actualEncoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 17019, 17472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17147, 17182);

                f_720_17147_17181(buffer != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17196, 17233);

                f_720_17196_17232(encoding != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17247, 17266);

                int
                preambleLength
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17280, 17366);

                actualEncoding = f_720_17297_17353(buffer, length, out preambleLength) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Text.Encoding?>(720, 17297, 17365) ?? encoding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17380, 17461);

                return f_720_17387_17460(actualEncoding, buffer, preambleLength, length - preambleLength);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 17019, 17472);

                int
                f_720_17147_17181(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 17147, 17181);
                    return 0;
                }


                int
                f_720_17196_17232(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 17196, 17232);
                    return 0;
                }


                System.Text.Encoding?
                f_720_17297_17353(byte[]
                source, int
                length, out int
                preambleLength)
                {
                    var return_v = TryReadByteOrderMark(source, length, out preambleLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 17297, 17353);
                    return return_v;
                }


                string
                f_720_17387_17460(System.Text.Encoding
                this_param, byte[]
                bytes, int
                index, int
                count)
                {
                    var return_v = this_param.GetString(bytes, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 17387, 17460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 17019, 17472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 17019, 17472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBinary(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 17814, 18389);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17969, 17974);
                    // PERF: We can advance two chars at a time unless we find a NUL.
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 17960, 18349) || true) && (i < f_720_17980_17991(text))
        ; DynAbs.Tracing.TraceSender.TraceExitCondition(720, 17960, 18349))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 17960, 18349);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18026, 18334) || true) && (f_720_18030_18037(text, i) == '\0')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 18026, 18334);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18087, 18195) || true) && (f_720_18091_18102(text, i - 1) == '\0')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 18087, 18195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18160, 18172);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 18087, 18195);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18219, 18226);

                            i += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 18026, 18334);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 18026, 18334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18308, 18315);

                            i += 2;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 18026, 18334);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 1, 390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(720, 1, 390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18365, 18378);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 17814, 18389);

                int
                f_720_17980_17991(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 17980, 17991);
                    return return_v;
                }


                char
                f_720_18030_18037(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 18030, 18037);
                    return return_v;
                }


                char
                f_720_18091_18102(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 18091, 18102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 17814, 18389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 17814, 18389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceHashAlgorithm ChecksumAlgorithm
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 18583, 18604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 18586, 18604);
                    return _checksumAlgorithm; DynAbs.Tracing.TraceSender.TraceExitMethod(720, 18583, 18604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 18583, 18604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 18583, 18604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract Encoding? Encoding { get; }

        public abstract int Length { get; }

        internal virtual int StorageSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 19560, 19587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 19566, 19585);

                    return f_720_19573_19584(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 19560, 19587);

                    int
                    f_720_19573_19584(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 19573, 19584);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 19503, 19598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 19503, 19598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<SourceText> Segments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 19687, 19735);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 19693, 19733);

                    return ImmutableArray<SourceText>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 19687, 19735);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 19610, 19746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 19610, 19746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual SourceText StorageKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 19821, 19841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 19827, 19839);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 19821, 19841);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 19758, 19852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 19758, 19852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool CanBeEmbedded
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 20432, 21007);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 20468, 20830) || true) && (_precomputedEmbeddedTextBlob.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 20468, 20830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 20787, 20811);

                        return f_720_20794_20802() != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 20468, 20830);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 20947, 20992);

                    return f_720_20954_20991_M(!_precomputedEmbeddedTextBlob.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 20432, 21007);

                    System.Text.Encoding?
                    f_720_20794_20802()
                    {
                        var return_v = Encoding;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 20794, 20802);
                        return return_v;
                    }


                    bool
                    f_720_20954_20991_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 20954, 20991);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 20382, 21018);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 20382, 21018);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<byte> PrecomputedEmbeddedTextBlob
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 21546, 21577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 21549, 21577);
                    return _precomputedEmbeddedTextBlob; DynAbs.Tracing.TraceSender.TraceExitMethod(720, 21546, 21577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 21546, 21577);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 21546, 21577);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Returns a character at given position.
        /// </summary>
        /// <param name="position">The position to get the character from.</param>
        /// <returns>The character.</returns>
        /// <exception cref="ArgumentOutOfRangeException">When position is negative or 
        /// greater than <see cref="Length"/>.</exception>
        public abstract char this[int position] { get; }

        public abstract void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);

        public virtual SourceTextContainer Container
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 22448, 22709);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22484, 22652) || true) && (_lazyContainer == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 22484, 22652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22552, 22633);

                        f_720_22552_22632(ref _lazyContainer, f_720_22600_22625(this), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 22484, 22652);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22672, 22694);

                    return _lazyContainer;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 22448, 22709);

                    Microsoft.CodeAnalysis.Text.SourceText.StaticContainer
                    f_720_22600_22625(Microsoft.CodeAnalysis.Text.SourceText
                    text)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Text.SourceText.StaticContainer(text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 22600, 22625);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.SourceTextContainer?
                    f_720_22552_22632(ref Microsoft.CodeAnalysis.Text.SourceTextContainer?
                    location1, Microsoft.CodeAnalysis.Text.SourceText.StaticContainer
                    value, Microsoft.CodeAnalysis.Text.SourceTextContainer?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.Text.SourceTextContainer)value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 22552, 22632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 22379, 22720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 22379, 22720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void CheckSubSpan(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 22732, 23008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22798, 22854);

                f_720_22798_22853(0 <= span.Start && (DynAbs.Tracing.TraceSender.Expression_True(720, 22811, 22852) && span.Start <= span.End));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22870, 22997) || true) && (span.End > f_720_22885_22896(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 22870, 22997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 22930, 22982);

                    throw f_720_22936_22981(nameof(span));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 22870, 22997);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 22732, 23008);

                int
                f_720_22798_22853(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 22798, 22853);
                    return 0;
                }


                int
                f_720_22885_22896(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 22885, 22896);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_720_22936_22981(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 22936, 22981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 22732, 23008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 22732, 23008);
            }
        }

        public virtual SourceText GetSubText(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 23177, 23711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23253, 23272);

                f_720_23253_23271(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23288, 23317);

                int
                spanLength = span.Length
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23331, 23700) || true) && (spanLength == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 23331, 23700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23384, 23460);

                    return f_720_23391_23459(string.Empty, f_720_23421_23434(this), f_720_23436_23458(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 23331, 23700);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 23331, 23700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23494, 23700) || true) && (spanLength == f_720_23512_23523(this) && (DynAbs.Tracing.TraceSender.Expression_True(720, 23498, 23542) && span.Start == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 23494, 23700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23576, 23588);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 23494, 23700);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 23494, 23700);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23654, 23685);

                        return f_720_23661_23684(this, span);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 23494, 23700);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 23331, 23700);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 23177, 23711);

                int
                f_720_23253_23271(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 23253, 23271);
                    return 0;
                }


                System.Text.Encoding?
                f_720_23421_23434(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 23421, 23434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_720_23436_23458(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 23436, 23458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_23391_23459(string
                text, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = SourceText.From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 23391, 23459);
                    return return_v;
                }


                int
                f_720_23512_23523(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 23512, 23523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SubText
                f_720_23661_23684(Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SubText(text, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 23661, 23684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 23177, 23711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 23177, 23711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceText GetSubText(int start)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 23893, 24328);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 23957, 24095) || true) && (start < 0 || (DynAbs.Tracing.TraceSender.Expression_False(720, 23961, 23993) || start > f_720_23982_23993(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 23957, 24095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24027, 24080);

                    throw f_720_24033_24079(nameof(start));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 23957, 24095);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24111, 24317) || true) && (start == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 24111, 24317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24159, 24171);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 24111, 24317);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 24111, 24317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24237, 24302);

                    return f_720_24244_24301(this, f_720_24260_24300(start, f_720_24280_24291(this) - start));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 24111, 24317);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 23893, 24328);

                int
                f_720_23982_23993(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 23982, 23993);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_720_24033_24079(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24033, 24079);
                    return return_v;
                }


                int
                f_720_24280_24291(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 24280, 24291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_24260_24300(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24260, 24300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_24244_24301(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24244, 24301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 23893, 24328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 23893, 24328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Write(TextWriter textWriter, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 24454, 24668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24585, 24657);

                f_720_24585_24656(this, textWriter, f_720_24608_24636(0, f_720_24624_24635(this)), cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 24454, 24668);

                int
                f_720_24624_24635(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 24624, 24635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_24608_24636(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24608, 24636);
                    return return_v;
                }


                int
                f_720_24585_24656(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.IO.TextWriter
                writer, Microsoft.CodeAnalysis.Text.TextSpan
                span, System.Threading.CancellationToken
                cancellationToken)
                {
                    this_param.Write(writer, span, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24585, 24656);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 24454, 24668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 24454, 24668);
            }
        }

        public virtual void Write(TextWriter writer, TextSpan span, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 24779, 25611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24929, 24948);

                f_720_24929_24947(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 24964, 25004);

                var
                buffer = f_720_24977_25003(s_charArrayPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25054, 25078);

                    int
                    offset = span.Start
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25096, 25115);

                    int
                    end = span.End
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25133, 25487) || true) && (offset < end)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 25133, 25487);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25194, 25243);

                            cancellationToken.ThrowIfCancellationRequested();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25267, 25317);

                            int
                            count = f_720_25279_25316(f_720_25288_25301(buffer), end - offset)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25339, 25377);

                            f_720_25339_25376(this, offset, buffer, 0, count);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25399, 25430);

                            f_720_25399_25429(writer, buffer, 0, count);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25452, 25468);

                            offset += count;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 25133, 25487);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 25133, 25487);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(720, 25133, 25487);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(720, 25516, 25600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25556, 25585);

                    f_720_25556_25584(s_charArrayPool, buffer);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(720, 25516, 25600);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 24779, 25611);

                int
                f_720_24929_24947(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24929, 24947);
                    return 0;
                }


                char[]
                f_720_24977_25003(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 24977, 25003);
                    return return_v;
                }


                int
                f_720_25288_25301(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 25288, 25301);
                    return return_v;
                }


                int
                f_720_25279_25316(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25279, 25316);
                    return return_v;
                }


                int
                f_720_25339_25376(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25339, 25376);
                    return 0;
                }


                int
                f_720_25399_25429(System.IO.TextWriter
                this_param, char[]
                buffer, int
                index, int
                count)
                {
                    this_param.Write(buffer, index, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25399, 25429);
                    return 0;
                }


                int
                f_720_25556_25584(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param, char[]
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25556, 25584);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 24779, 25611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 24779, 25611);
            }
        }

        public ImmutableArray<byte> GetChecksum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 25623, 26061);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25689, 26013) || true) && (_lazyChecksum.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 25689, 26013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25750, 25998);
                    using (var
                    stream = f_720_25770_25828(this, useDefaultEncodingIfNull: true)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 25870, 25979);

                        f_720_25870_25978(ref _lazyChecksum, f_720_25932_25977(stream, _checksumAlgorithm));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(720, 25750, 25998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 25689, 26013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26029, 26050);

                return _lazyChecksum;
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 25623, 26061);

                Microsoft.CodeAnalysis.Text.SourceTextStream
                f_720_25770_25828(Microsoft.CodeAnalysis.Text.SourceText
                source, bool
                useDefaultEncodingIfNull)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SourceTextStream(source, useDefaultEncodingIfNull: useDefaultEncodingIfNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25770, 25828);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_25932_25977(Microsoft.CodeAnalysis.Text.SourceTextStream
                stream, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CalculateChecksum((System.IO.Stream)stream, algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25932, 25977);
                    return return_v;
                }


                bool
                f_720_25870_25978(ref System.Collections.Immutable.ImmutableArray<byte>
                location, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 25870, 25978);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 25623, 26061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 25623, 26061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> CalculateChecksum(byte[] buffer, int offset, int count, SourceHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 26073, 26491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26223, 26480);
                using (var
                algorithm = f_720_26246_26300(algorithmId)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26334, 26372);

                    f_720_26334_26371(algorithm != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26390, 26465);

                    return f_720_26397_26464(f_720_26419_26463(algorithm, buffer, offset, count));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(720, 26223, 26480);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 26073, 26491);

                System.Security.Cryptography.HashAlgorithm?
                f_720_26246_26300(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CryptographicHashProvider.TryGetAlgorithm(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26246, 26300);
                    return return_v;
                }


                int
                f_720_26334_26371(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26334, 26371);
                    return 0;
                }


                byte[]
                f_720_26419_26463(System.Security.Cryptography.HashAlgorithm
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.ComputeHash(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26419, 26463);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_26397_26464(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26397, 26464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 26073, 26491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 26073, 26491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<byte> CalculateChecksum(Stream stream, SourceHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 26503, 27013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26630, 27002);
                using (var
                algorithm = f_720_26653_26707(algorithmId)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26741, 26779);

                    f_720_26741_26778(algorithm != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26797, 26909) || true) && (f_720_26801_26815(stream))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 26797, 26909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26857, 26890);

                        f_720_26857_26889(stream, 0, SeekOrigin.Begin);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 26797, 26909);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 26927, 26987);

                    return f_720_26934_26986(f_720_26956_26985(algorithm, stream));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(720, 26630, 27002);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 26503, 27013);

                System.Security.Cryptography.HashAlgorithm?
                f_720_26653_26707(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                algorithmId)
                {
                    var return_v = CryptographicHashProvider.TryGetAlgorithm(algorithmId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26653, 26707);
                    return return_v;
                }


                int
                f_720_26741_26778(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26741, 26778);
                    return 0;
                }


                bool
                f_720_26801_26815(System.IO.Stream
                this_param)
                {
                    var return_v = this_param.CanSeek;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 26801, 26815);
                    return return_v;
                }


                long
                f_720_26857_26889(System.IO.Stream
                this_param, int
                offset, System.IO.SeekOrigin
                origin)
                {
                    var return_v = this_param.Seek((long)offset, origin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26857, 26889);
                    return return_v;
                }


                byte[]
                f_720_26956_26985(System.Security.Cryptography.HashAlgorithm
                this_param, System.IO.Stream
                inputStream)
                {
                    var return_v = this_param.ComputeHash(inputStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26956, 26985);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_720_26934_26986(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 26934, 26986);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 26503, 27013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 26503, 27013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 27137, 27252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27195, 27241);

                return f_720_27202_27240(this, f_720_27211_27239(0, f_720_27227_27238(this)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 27137, 27252);

                int
                f_720_27227_27238(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 27227, 27238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_27211_27239(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27211, 27239);
                    return return_v;
                }


                string
                f_720_27202_27240(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27202, 27240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 27137, 27252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 27137, 27252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual string ToString(TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 27500, 28329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27570, 27589);

                f_720_27570_27588(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27673, 27707);

                var
                builder = f_720_27687_27706()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27721, 27772);

                var
                buffer = new char[f_720_27743_27770(span.Length, 1024)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27788, 27850);

                int
                position = f_720_27803_27849(f_720_27812_27845(span.Start, f_720_27833_27844(this)), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27864, 27920);

                int
                length = f_720_27877_27908(span.End, f_720_27896_27907(this)) - position
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 27936, 28276) || true) && (position < f_720_27954_27965(this) && (DynAbs.Tracing.TraceSender.Expression_True(720, 27943, 27979) && length > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 27936, 28276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28013, 28062);

                        int
                        copyLength = f_720_28030_28061(f_720_28039_28052(buffer), length)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28080, 28125);

                        f_720_28080_28124(this, position, buffer, 0, copyLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28143, 28181);

                        f_720_28143_28180(builder, buffer, 0, copyLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28199, 28220);

                        length -= copyLength;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28238, 28261);

                        position += copyLength;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 27936, 28276);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 27936, 28276);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(720, 27936, 28276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28292, 28318);

                return f_720_28299_28317(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 27500, 28329);

                int
                f_720_27570_27588(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    this_param.CheckSubSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27570, 27588);
                    return 0;
                }


                System.Text.StringBuilder
                f_720_27687_27706()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27687, 27706);
                    return return_v;
                }


                int
                f_720_27743_27770(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27743, 27770);
                    return return_v;
                }


                int
                f_720_27833_27844(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 27833, 27844);
                    return return_v;
                }


                int
                f_720_27812_27845(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27812, 27845);
                    return return_v;
                }


                int
                f_720_27803_27849(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27803, 27849);
                    return return_v;
                }


                int
                f_720_27896_27907(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 27896, 27907);
                    return return_v;
                }


                int
                f_720_27877_27908(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 27877, 27908);
                    return return_v;
                }


                int
                f_720_27954_27965(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 27954, 27965);
                    return return_v;
                }


                int
                f_720_28039_28052(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 28039, 28052);
                    return return_v;
                }


                int
                f_720_28030_28061(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28030, 28061);
                    return return_v;
                }


                int
                f_720_28080_28124(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28080, 28124);
                    return 0;
                }


                System.Text.StringBuilder
                f_720_28143_28180(System.Text.StringBuilder
                this_param, char[]
                value, int
                startIndex, int
                charCount)
                {
                    var return_v = this_param.Append(value, startIndex, charCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28143, 28180);
                    return return_v;
                }


                string
                f_720_28299_28317(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28299, 28317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 27500, 28329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 27500, 28329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SourceText WithChanges(IEnumerable<TextChange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 28499, 32293);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28594, 28711) || true) && (changes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 28594, 28711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28647, 28696);

                    throw f_720_28653_28695(nameof(changes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 28594, 28711);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28727, 28806) || true) && (!f_720_28732_28745(changes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 28727, 28806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28779, 28791);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 28727, 28806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28822, 28876);

                var
                segments = f_720_28837_28875()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 28890, 28953);

                var
                changeRanges = f_720_28909_28952()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29003, 29020);

                    int
                    position = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29040, 31352);
                        foreach (var change in f_720_29063_29070_I(changes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 29040, 31352);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29112, 29278) || true) && (change.Span.End > f_720_29134_29145(this))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 29112, 29278);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29172, 29278);

                                throw f_720_29178_29277(f_720_29200_29259(), nameof(changes));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 29112, 29278);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29362, 30332) || true) && (change.Span.Start < position)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 29362, 30332);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29765, 30191) || true) && (change.Span.End <= f_720_29788_29807(changeRanges).Span.Start)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 29765, 30191);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 29876, 30106);

                                    changes = f_720_29886_30105((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from c in changes
                                                                                                                         where !c.Span.IsEmpty || c.NewText?.Length > 0
                                                                                                                         orderby c.Span
                                                                                                                         select c, 720, 29887, 30095)));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30136, 30164);

                                    return f_720_30143_30163(this, changes);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 29765, 30191);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30219, 30309);

                                throw f_720_30225_30308(f_720_30247_30290(), nameof(changes));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 29362, 30332);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30356, 30404);

                            var
                            newTextLength = f_720_30376_30398_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(change.NewText, 720, 30376, 30398)?.Length) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(720, 30376, 30403) ?? 0)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30494, 30579) || true) && (change.Span.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(720, 30498, 30543) && newTextLength == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 30494, 30579);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30570, 30579);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 30494, 30579);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30657, 30917) || true) && (change.Span.Start > position)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 30657, 30917);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30739, 30823);

                                var
                                subText = f_720_30753_30822(this, f_720_30769_30821(position, change.Span.Start - position))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30849, 30894);

                                f_720_30849_30893(segments, subText);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 30657, 30917);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 30941, 31192) || true) && (newTextLength > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 30941, 31192);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31012, 31098);

                                var
                                segment = f_720_31026_31097(change.NewText!, f_720_31059_31072(this), f_720_31074_31096(this))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31124, 31169);

                                f_720_31124_31168(segments, segment);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 30941, 31192);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31216, 31243);

                            position = change.Span.End;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31267, 31333);

                            f_720_31267_31332(
                                                changeRanges, f_720_31284_31331(change.Span, newTextLength));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 29040, 31352);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 1, 2313);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(720, 1, 2313);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31422, 31535) || true) && (position == 0 && (DynAbs.Tracing.TraceSender.Expression_True(720, 31426, 31462) && f_720_31443_31457(segments) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 31422, 31535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31504, 31516);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 31422, 31535);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31555, 31787) || true) && (position < f_720_31570_31581(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 31555, 31787);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31623, 31701);

                        var
                        subText = f_720_31637_31700(this, f_720_31653_31699(position, f_720_31676_31687(this) - position))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31723, 31768);

                        f_720_31723_31767(segments, subText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 31555, 31787);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31807, 31886);

                    var
                    newText = f_720_31821_31885(segments, this, adjustSegments: true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31904, 32144) || true) && (newText != this)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 31904, 32144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 31965, 32031);

                        return f_720_31972_32030(this, newText, f_720_32003_32029(changeRanges));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 31904, 32144);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 31904, 32144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 32113, 32125);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 31904, 32144);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(720, 32173, 32282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 32213, 32229);

                    f_720_32213_32228(segments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 32247, 32267);

                    f_720_32247_32266(changeRanges);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(720, 32173, 32282);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 28499, 32293);

                System.ArgumentNullException
                f_720_28653_28695(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28653, 28695);
                    return return_v;
                }


                bool
                f_720_28732_28745(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.Text.TextChange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28732, 28745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                f_720_28837_28875()
                {
                    var return_v = ArrayBuilder<SourceText>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28837, 28875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_28909_28952()
                {
                    var return_v = ArrayBuilder<TextChangeRange>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 28909, 28952);
                    return return_v;
                }


                int
                f_720_29134_29145(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 29134, 29145);
                    return return_v;
                }


                string
                f_720_29200_29259()
                {
                    var return_v = CodeAnalysisResources.ChangesMustBeWithinBoundsOfSourceText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 29200, 29259);
                    return return_v;
                }


                System.ArgumentException
                f_720_29178_29277(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 29178, 29277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_720_29788_29807(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.Last();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 29788, 29807);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>
                f_720_29886_30105(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.Text.TextChange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 29886, 30105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_30143_30163(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                changes)
                {
                    var return_v = this_param.WithChanges(changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 30143, 30163);
                    return return_v;
                }


                string
                f_720_30247_30290()
                {
                    var return_v = CodeAnalysisResources.ChangesMustNotOverlap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 30247, 30290);
                    return return_v;
                }


                System.ArgumentException
                f_720_30225_30308(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 30225, 30308);
                    return return_v;
                }


                int?
                f_720_30376_30398_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 30376, 30398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_30769_30821(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 30769, 30821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_30753_30822(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 30753, 30822);
                    return return_v;
                }


                int
                f_720_30849_30893(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    CompositeText.AddSegments(segments, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 30849, 30893);
                    return 0;
                }


                System.Text.Encoding?
                f_720_31059_31072(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 31059, 31072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_720_31074_31096(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 31074, 31096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_31026_31097(string
                text, System.Text.Encoding?
                encoding, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = SourceText.From(text, encoding, checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31026, 31097);
                    return return_v;
                }


                int
                f_720_31124_31168(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    CompositeText.AddSegments(segments, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31124, 31168);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_720_31284_31331(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31284, 31331);
                    return return_v;
                }


                int
                f_720_31267_31332(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param, Microsoft.CodeAnalysis.Text.TextChangeRange
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31267, 31332);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                f_720_29063_29070_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 29063, 29070);
                    return return_v;
                }


                int
                f_720_31443_31457(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 31443, 31457);
                    return return_v;
                }


                int
                f_720_31570_31581(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 31570, 31581);
                    return return_v;
                }


                int
                f_720_31676_31687(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 31676, 31687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_31653_31699(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31653, 31699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_31637_31700(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetSubText(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31637, 31700);
                    return return_v;
                }


                int
                f_720_31723_31767(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.SourceText
                text)
                {
                    CompositeText.AddSegments(segments, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31723, 31767);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_31821_31885(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                segments, Microsoft.CodeAnalysis.Text.SourceText
                original, bool
                adjustSegments)
                {
                    var return_v = CompositeText.ToSourceText(segments, original, adjustSegments: adjustSegments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31821, 31885);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_32003_32029(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 32003, 32029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.ChangedText
                f_720_31972_32030(Microsoft.CodeAnalysis.Text.SourceText
                oldText, Microsoft.CodeAnalysis.Text.SourceText
                newText, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                changeRanges)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.ChangedText(oldText, newText, changeRanges);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 31972, 32030);
                    return return_v;
                }


                int
                f_720_32213_32228(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.SourceText>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 32213, 32228);
                    return 0;
                }


                int
                f_720_32247_32266(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 32247, 32266);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 28499, 32293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 28499, 32293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceText WithChanges(params TextChange[] changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 32873, 33025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 32956, 33014);

                return f_720_32963_33013(this, changes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 32873, 33025);

                Microsoft.CodeAnalysis.Text.SourceText
                f_720_32963_33013(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextChange[]
                changes)
                {
                    var return_v = this_param.WithChanges((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChange>)changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 32963, 33013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 32873, 33025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 32873, 33025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceText Replace(TextSpan span, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 33186, 33333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 33267, 33322);

                return f_720_33274_33321(this, f_720_33291_33320(span, newText));
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 33186, 33333);

                Microsoft.CodeAnalysis.Text.TextChange
                f_720_33291_33320(Microsoft.CodeAnalysis.Text.TextSpan
                span, string
                newText)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChange(span, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 33291, 33320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_33274_33321(Microsoft.CodeAnalysis.Text.SourceText
                this_param, params Microsoft.CodeAnalysis.Text.TextChange[]
                changes)
                {
                    var return_v = this_param.WithChanges(changes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 33274, 33321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 33186, 33333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 33186, 33333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SourceText Replace(int start, int length, string newText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 33495, 33653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 33584, 33642);

                return f_720_33591_33641(this, f_720_33604_33631(start, length), newText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 33495, 33653);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_33604_33631(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 33604, 33631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_720_33591_33641(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span, string
                newText)
                {
                    var return_v = this_param.Replace(span, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 33591, 33641);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 33495, 33653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 33495, 33653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual IReadOnlyList<TextChangeRange> GetChangeRanges(SourceText oldText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 33955, 34468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34061, 34178) || true) && (oldText == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 34061, 34178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34114, 34163);

                    throw f_720_34120_34162(nameof(oldText));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 34061, 34178);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34194, 34457) || true) && (oldText == this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 34194, 34457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34247, 34280);

                    return TextChangeRange.NoChanges;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 34194, 34457);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 34194, 34457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34346, 34442);

                    return f_720_34353_34441(f_720_34375_34440(f_720_34395_34426(0, f_720_34411_34425(oldText)), f_720_34428_34439(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 34194, 34457);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 33955, 34468);

                System.ArgumentNullException
                f_720_34120_34162(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34120, 34162);
                    return return_v;
                }


                int
                f_720_34411_34425(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 34411, 34425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_34395_34426(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34395, 34426);
                    return return_v;
                }


                int
                f_720_34428_34439(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 34428, 34439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChangeRange
                f_720_34375_34440(Microsoft.CodeAnalysis.Text.TextSpan
                span, int
                newLength)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChangeRange(span, newLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34375, 34440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_34353_34441(Microsoft.CodeAnalysis.Text.TextChangeRange
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34353, 34441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 33955, 34468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 33955, 34468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual IReadOnlyList<TextChange> GetTextChanges(SourceText oldText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 34770, 35777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34870, 34890);

                int
                newPosDelta = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34906, 34958);

                var
                ranges = f_720_34919_34957(f_720_34919_34948(this, oldText))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 34972, 35025);

                var
                textChanges = f_720_34990_35024(f_720_35011_35023(ranges))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35041, 35705);
                    foreach (var range in f_720_35063_35069_I(ranges))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 35041, 35705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35103, 35147);

                        var
                        newPos = range.Span.Start + newPosDelta
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35235, 35247);

                        string
                        newt
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35265, 35549) || true) && (range.NewLength > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 35265, 35549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35330, 35379);

                            var
                            span = f_720_35341_35378(newPos, range.NewLength)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35401, 35428);

                            newt = f_720_35408_35427(this, span);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 35265, 35549);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 35265, 35549);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35510, 35530);

                            newt = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 35265, 35549);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35569, 35619);

                        f_720_35569_35618(
                                        textChanges, f_720_35585_35617(range.Span, newt));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35639, 35690);

                        newPosDelta += range.NewLength - range.Span.Length;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 35041, 35705);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 1, 665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(720, 1, 665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 35721, 35766);

                return f_720_35728_35765(textChanges);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 34770, 35777);

                System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_34919_34948(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                oldText)
                {
                    var return_v = this_param.GetChangeRanges(oldText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34919, 34948);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_34919_34957(System.Collections.Generic.IReadOnlyList<Microsoft.CodeAnalysis.Text.TextChangeRange>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.Text.TextChangeRange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34919, 34957);
                    return return_v;
                }


                int
                f_720_35011_35023(System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChangeRange>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 35011, 35023);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>
                f_720_34990_35024(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 34990, 35024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_720_35341_35378(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35341, 35378);
                    return return_v;
                }


                string
                f_720_35408_35427(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.ToString(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35408, 35427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextChange
                f_720_35585_35617(Microsoft.CodeAnalysis.Text.TextSpan
                span, string
                newText)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextChange(span, newText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35585, 35617);
                    return return_v;
                }


                int
                f_720_35569_35618(System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>
                this_param, Microsoft.CodeAnalysis.Text.TextChange
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35569, 35618);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChangeRange>
                f_720_35063_35069_I(System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChangeRange>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35063, 35069);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChange>
                f_720_35728_35765(System.Collections.Generic.List<Microsoft.CodeAnalysis.Text.TextChange>
                items)
                {
                    var return_v = items.ToImmutableArrayOrEmpty<Microsoft.CodeAnalysis.Text.TextChange>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 35728, 35765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 34770, 35777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 34770, 35777);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TextLineCollection Lines
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 35993, 36186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36029, 36054);

                    var
                    info = _lazyLineInfo
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36072, 36171);

                    return info ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Text.TextLineCollection?>(720, 36079, 36170) ?? f_720_36087_36162(ref _lazyLineInfo, info = f_720_36141_36155(this), null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Text.TextLineCollection?>(720, 36087, 36170) ?? info));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 35993, 36186);

                    Microsoft.CodeAnalysis.Text.TextLineCollection
                    f_720_36141_36155(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.GetLinesCore();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 36141, 36155);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextLineCollection?
                    f_720_36087_36162(ref Microsoft.CodeAnalysis.Text.TextLineCollection?
                    location1, Microsoft.CodeAnalysis.Text.TextLineCollection
                    value, Microsoft.CodeAnalysis.Text.TextLineCollection?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 36087, 36162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 35937, 36197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 35937, 36197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool TryGetLines([NotNullWhen(returnValue: true)] out TextLineCollection? lines)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 36209, 36391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36323, 36345);

                lines = _lazyLineInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36359, 36380);

                return lines != null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 36209, 36391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 36209, 36391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 36209, 36391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual TextLineCollection GetLinesCore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 36709, 36841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36785, 36830);

                return f_720_36792_36829(this, f_720_36811_36828(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 36709, 36841);

                int[]
                f_720_36811_36828(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ParseLineStarts();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 36811, 36828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText.LineInfo
                f_720_36792_36829(Microsoft.CodeAnalysis.Text.SourceText
                text, int[]
                lineStarts)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.SourceText.LineInfo(text, lineStarts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 36792, 36829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 36709, 36841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 36709, 36841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class LineInfo : TextLineCollection
        {
            private readonly SourceText _text;

            private readonly int[] _lineStarts;

            private int _lastLineNumber;

            public LineInfo(SourceText text, int[] lineStarts)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(720, 37070, 37224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 36957, 36962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37000, 37011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37038, 37053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37153, 37166);

                    _text = text;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37184, 37209);

                    _lineStarts = lineStarts;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(720, 37070, 37224);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 37070, 37224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 37070, 37224);
                }
            }

            public override int Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 37266, 37287);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37269, 37287);
                        return f_720_37269_37287(_lineStarts); DynAbs.Tracing.TraceSender.TraceExitMethod(720, 37266, 37287);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 37266, 37287);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 37266, 37287);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TextLine this[int index]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 37377, 38091);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37421, 37591) || true) && (index < 0 || (DynAbs.Tracing.TraceSender.Expression_False(720, 37425, 37465) || index >= f_720_37447_37465(_lineStarts)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 37421, 37591);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37515, 37568);

                            throw f_720_37521_37567(nameof(index));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 37421, 37591);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37615, 37646);

                        int
                        start = _lineStarts[index]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37668, 38072) || true) && (index == f_720_37681_37699(_lineStarts) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 37668, 38072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37753, 37827);

                            return TextLine.FromSpan(_text, TextSpan.FromBounds(start, f_720_37812_37824(_text)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 37668, 38072);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 37668, 38072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37925, 37958);

                            int
                            end = _lineStarts[index + 1]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 37984, 38049);

                            return TextLine.FromSpan(_text, TextSpan.FromBounds(start, end));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 37668, 38072);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(720, 37377, 38091);

                        int
                        f_720_37447_37465(int[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 37447, 37465);
                            return return_v;
                        }


                        System.ArgumentOutOfRangeException
                        f_720_37521_37567(string
                        paramName)
                        {
                            var return_v = new System.ArgumentOutOfRangeException(paramName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 37521, 37567);
                            return return_v;
                        }


                        int
                        f_720_37681_37699(int[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 37681, 37699);
                            return return_v;
                        }


                        int
                        f_720_37812_37824(Microsoft.CodeAnalysis.Text.SourceText
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 37812, 37824);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 37377, 38091);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 37377, 38091);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int IndexOf(int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 38122, 39630);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38196, 38356) || true) && (position < 0 || (DynAbs.Tracing.TraceSender.Expression_False(720, 38200, 38239) || position > f_720_38227_38239(_text)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 38196, 38356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38281, 38337);

                        throw f_720_38287_38336(nameof(position));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 38196, 38356);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38376, 38391);

                    int
                    lineNumber
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38542, 38579);

                    var
                    lastLineNumber = _lastLineNumber
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38597, 39140) || true) && (position >= _lineStarts[lastLineNumber])
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 38597, 39140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38682, 38743);

                        var
                        limit = f_720_38694_38742(f_720_38703_38721(_lineStarts), lastLineNumber + 4)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38774, 38792);
                            for (int
        i = lastLineNumber
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38765, 39121) || true) && (i < limit)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38805, 38808)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(720, 38765, 39121))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 38765, 39121);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38858, 39098) || true) && (position < _lineStarts[i])
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 38858, 39098);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38945, 38964);

                                    lineNumber = i - 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 38994, 39023);

                                    _lastLineNumber = lineNumber;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39053, 39071);

                                    return lineNumber;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 38858, 39098);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 1, 357);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(720, 1, 357);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 38597, 39140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39354, 39402);

                    lineNumber = f_720_39367_39401(_lineStarts, position);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39420, 39530) || true) && (lineNumber < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 39420, 39530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39480, 39511);

                        lineNumber = (~lineNumber) - 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 39420, 39530);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39550, 39579);

                    _lastLineNumber = lineNumber;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39597, 39615);

                    return lineNumber;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 38122, 39630);

                    int
                    f_720_38227_38239(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 38227, 38239);
                        return return_v;
                    }


                    System.ArgumentOutOfRangeException
                    f_720_38287_38336(string
                    paramName)
                    {
                        var return_v = new System.ArgumentOutOfRangeException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 38287, 38336);
                        return return_v;
                    }


                    int
                    f_720_38703_38721(int[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 38703, 38721);
                        return return_v;
                    }


                    int
                    f_720_38694_38742(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 38694, 38742);
                        return return_v;
                    }


                    int
                    f_720_39367_39401(int[]
                    array, int
                    value)
                    {
                        var return_v = array.BinarySearch(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 39367, 39401);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 38122, 39630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 38122, 39630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override TextLine GetLineFromPosition(int position)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 39646, 39783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39737, 39768);

                    return f_720_39744_39767(this, f_720_39749_39766(this, position));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(720, 39646, 39783);

                    int
                    f_720_39749_39766(Microsoft.CodeAnalysis.Text.SourceText.LineInfo
                    this_param, int
                    position)
                    {
                        var return_v = this_param.IndexOf(position);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 39749, 39766);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Text.TextLine
                    f_720_39744_39767(Microsoft.CodeAnalysis.Text.SourceText.LineInfo
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 39744, 39767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 39646, 39783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 39646, 39783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LineInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(720, 36853, 39794);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(720, 36853, 39794);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 36853, 39794);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(720, 36853, 39794);

            int
            f_720_37269_37287(int[]
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 37269, 37287);
                return return_v;
            }

        }

        private void EnumerateChars(Action<int, char[], int> action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 39806, 40482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39891, 39908);

                var
                position = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39922, 39962);

                var
                buffer = f_720_39935_39961(s_charArrayPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 39978, 40003);

                var
                length = f_720_39991_40002(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40017, 40321) || true) && (position < length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 40017, 40321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40075, 40138);

                        var
                        contentLength = f_720_40095_40137(length - position, f_720_40123_40136(buffer))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40156, 40204);

                        f_720_40156_40203(this, position, buffer, 0, contentLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40222, 40262);

                        f_720_40222_40261(action, position, buffer, contentLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40280, 40306);

                        position += contentLength;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 40017, 40321);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 40017, 40321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(720, 40017, 40321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40398, 40426);

                f_720_40398_40425(action, position, buffer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40442, 40471);

                f_720_40442_40470(
                            s_charArrayPool, buffer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 39806, 40482);

                char[]
                f_720_39935_39961(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 39935, 39961);
                    return return_v;
                }


                int
                f_720_39991_40002(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 39991, 40002);
                    return return_v;
                }


                int
                f_720_40123_40136(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 40123, 40136);
                    return return_v;
                }


                int
                f_720_40095_40137(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40095, 40137);
                    return return_v;
                }


                int
                f_720_40156_40203(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40156, 40203);
                    return 0;
                }


                int
                f_720_40222_40261(System.Action<int, char[], int>
                this_param, int
                arg1, char[]
                arg2, int
                arg3)
                {
                    this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40222, 40261);
                    return 0;
                }


                int
                f_720_40398_40425(System.Action<int, char[], int>
                this_param, int
                arg1, char[]
                arg2, int
                arg3)
                {
                    this_param.Invoke(arg1, arg2, arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40398, 40425);
                    return 0;
                }


                int
                f_720_40442_40470(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param, char[]
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40442, 40470);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 39806, 40482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 39806, 40482);
            }
        }

        private int[] ParseLineStarts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 40494, 42861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40584, 40672) || true) && (0 == f_720_40593_40604(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 40584, 40672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40638, 40657);

                    return new[] { 0 };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 40584, 40672);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40688, 40737);

                var
                lineStarts = f_720_40705_40736()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40751, 40769);

                f_720_40751_40768(lineStarts, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 40819, 40841);

                var
                lastWasCR = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 41074, 42799);

                f_720_41074_42798(this, (int position, char[] buffer, int length) =>
                            {
                                var index = 0;
                                if (lastWasCR)
                                {
                                    if (length > 0 && buffer[0] == '\n')
                                    {
                                        index++;
                                    }

                                    lineStarts.Add(position + index);
                                    lastWasCR = false;
                                }

                                while (index < length)
                                {
                                    char c = buffer[index];
                                    index++;

                    // Common case - ASCII & not a line break
                    // if (c > '\r' && c <= 127)
                    // if (c >= ('\r'+1) && c <= 127)
                    const uint bias = '\r' + 1;
                                    if (unchecked(c - bias) <= (127 - bias))
                                    {
                                        continue;
                                    }

                    // Assumes that the only 2-char line break sequence is CR+LF
                    if (c == '\r')
                                    {
                                        if (index < length && buffer[index] == '\n')
                                        {
                                            index++;
                                        }
                                        else if (index >= length)
                                        {
                                            lastWasCR = true;
                                            continue;
                                        }
                                    }
                                    else if (!TextUtilities.IsAnyLineBreakCharacter(c))
                                    {
                                        continue;
                                    }

                    // next line starts at index
                    lineStarts.Add(position + index);
                                }
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 42815, 42850);

                return f_720_42822_42849(lineStarts);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 40494, 42861);

                int
                f_720_40593_40604(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 40593, 40604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                f_720_40705_40736()
                {
                    var return_v = ArrayBuilder<int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40705, 40736);
                    return return_v;
                }


                int
                f_720_40751_40768(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param, int
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 40751, 40768);
                    return 0;
                }


                int
                f_720_41074_42798(Microsoft.CodeAnalysis.Text.SourceText
                this_param, System.Action<int, char[], int>
                action)
                {
                    this_param.EnumerateChars(action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 41074, 42798);
                    return 0;
                }


                int[]
                f_720_42822_42849(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<int>
                this_param)
                {
                    var return_v = this_param.ToArrayAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 42822, 42849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 40494, 42861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 40494, 42861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ContentEquals(SourceText other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 43024, 43746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43092, 43185) || true) && (f_720_43096_43124(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 43092, 43185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43158, 43170);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 43092, 43185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43311, 43361);

                ImmutableArray<byte>
                leftChecksum = _lazyChecksum
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43375, 43432);

                ImmutableArray<byte>
                rightChecksum = other._lazyChecksum
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43446, 43687) || true) && (f_720_43450_43473_M(!leftChecksum.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(720, 43450, 43501) && f_720_43477_43501_M(!rightChecksum.IsDefault)) && (DynAbs.Tracing.TraceSender.Expression_True(720, 43450, 43536) && f_720_43505_43518(this) == f_720_43522_43536(other)) && (DynAbs.Tracing.TraceSender.Expression_True(720, 43450, 43589) && f_720_43540_43562(this) == f_720_43566_43589(other)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 43446, 43687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43623, 43672);

                    return leftChecksum.SequenceEqual(rightChecksum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 43446, 43687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 43703, 43735);

                return f_720_43710_43734(this, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 43024, 43746);

                bool
                f_720_43096_43124(Microsoft.CodeAnalysis.Text.SourceText
                objA, Microsoft.CodeAnalysis.Text.SourceText
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 43096, 43124);
                    return return_v;
                }


                bool
                f_720_43450_43473_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43450, 43473);
                    return return_v;
                }


                bool
                f_720_43477_43501_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43477, 43501);
                    return return_v;
                }


                System.Text.Encoding?
                f_720_43505_43518(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43505, 43518);
                    return return_v;
                }


                System.Text.Encoding?
                f_720_43522_43536(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Encoding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43522, 43536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_720_43540_43562(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43540, 43562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                f_720_43566_43589(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.ChecksumAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 43566, 43589);
                    return return_v;
                }


                bool
                f_720_43710_43734(Microsoft.CodeAnalysis.Text.SourceText
                this_param, Microsoft.CodeAnalysis.Text.SourceText
                other)
                {
                    var return_v = this_param.ContentEqualsImpl(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 43710, 43734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 43024, 43746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 43024, 43746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool ContentEqualsImpl(SourceText other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 43920, 45255);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44003, 44082) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44003, 44082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44054, 44067);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44003, 44082);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44098, 44191) || true) && (f_720_44102_44130(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44098, 44191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44164, 44176);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44098, 44191);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44207, 44300) || true) && (f_720_44211_44222(this) != f_720_44226_44238(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44207, 44300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44272, 44285);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44207, 44300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44316, 44357);

                var
                buffer1 = f_720_44330_44356(s_charArrayPool)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44371, 44412);

                var
                buffer2 = f_720_44385_44411(s_charArrayPool)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44462, 44479);

                    int
                    position = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44497, 45050) || true) && (position < f_720_44515_44526(this))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44497, 45050);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44568, 44625);

                            int
                            n = f_720_44576_44624(f_720_44585_44596(this) - position, f_720_44609_44623(buffer1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44647, 44684);

                            f_720_44647_44683(this, position, buffer1, 0, n);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44706, 44744);

                            f_720_44706_44743(other, position, buffer2, 0, n);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44777, 44782);

                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44768, 44993) || true) && (i < n)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44791, 44794)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44768, 44993))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44768, 44993);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44844, 44970) || true) && (buffer1[i] != buffer2[i])
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 44844, 44970);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 44930, 44943);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44844, 44970);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 1, 226);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(720, 1, 226);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45017, 45031);

                            position += n;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 44497, 45050);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(720, 44497, 45050);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(720, 44497, 45050);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45070, 45082);

                    return true;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(720, 45111, 45244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45151, 45181);

                    f_720_45151_45180(s_charArrayPool, buffer2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45199, 45229);

                    f_720_45199_45228(s_charArrayPool, buffer1);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(720, 45111, 45244);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(720, 43920, 45255);

                bool
                f_720_44102_44130(Microsoft.CodeAnalysis.Text.SourceText
                objA, Microsoft.CodeAnalysis.Text.SourceText
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44102, 44130);
                    return return_v;
                }


                int
                f_720_44211_44222(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 44211, 44222);
                    return return_v;
                }


                int
                f_720_44226_44238(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 44226, 44238);
                    return return_v;
                }


                char[]
                f_720_44330_44356(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44330, 44356);
                    return return_v;
                }


                char[]
                f_720_44385_44411(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44385, 44411);
                    return return_v;
                }


                int
                f_720_44515_44526(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 44515, 44526);
                    return return_v;
                }


                int
                f_720_44585_44596(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 44585, 44596);
                    return return_v;
                }


                int
                f_720_44609_44623(char[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 44609, 44623);
                    return return_v;
                }


                int
                f_720_44576_44624(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44576, 44624);
                    return return_v;
                }


                int
                f_720_44647_44683(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44647, 44683);
                    return 0;
                }


                int
                f_720_44706_44743(Microsoft.CodeAnalysis.Text.SourceText
                this_param, int
                sourceIndex, char[]
                destination, int
                destinationIndex, int
                count)
                {
                    this_param.CopyTo(sourceIndex, destination, destinationIndex, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 44706, 44743);
                    return 0;
                }


                int
                f_720_45151_45180(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param, char[]
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 45151, 45180);
                    return 0;
                }


                int
                f_720_45199_45228(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
                this_param, char[]
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 45199, 45228);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 43920, 45255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 43920, 45255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Encoding? TryReadByteOrderMark(byte[] source, int length, out int preambleLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(720, 45744, 47020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45866, 45901);

                f_720_45866_45900(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45915, 45953);

                f_720_45915_45952(length <= f_720_45938_45951(source));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 45969, 46948) || true) && (length >= 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 45969, 46948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46018, 46933);

                    switch (source[0])
                    {

                        case 0xFE:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46018, 46933);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46113, 46301) || true) && (source[1] == 0xFF)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46113, 46301);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46192, 46211);

                                preambleLength = 2;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46241, 46274);

                                return f_720_46248_46273();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46113, 46301);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(720, 46329, 46335);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46018, 46933);

                        case 0xFF:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46018, 46933);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46395, 46574) || true) && (source[1] == 0xFE)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46395, 46574);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46474, 46493);

                                preambleLength = 2;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46523, 46547);

                                return f_720_46530_46546();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46395, 46574);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(720, 46602, 46608);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46018, 46933);

                        case 0xEF:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46018, 46933);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46668, 46880) || true) && (source[1] == 0xBB && (DynAbs.Tracing.TraceSender.Expression_True(720, 46672, 46704) && length >= 3) && (DynAbs.Tracing.TraceSender.Expression_True(720, 46672, 46725) && source[2] == 0xBF))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(720, 46668, 46880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46783, 46802);

                                preambleLength = 3;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46832, 46853);

                                return f_720_46839_46852();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46668, 46880);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(720, 46908, 46914);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(720, 46018, 46933);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(720, 45969, 46948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46964, 46983);

                preambleLength = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 46997, 47009);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(720, 45744, 47020);

                int
                f_720_45866_45900(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 45866, 45900);
                    return 0;
                }


                int
                f_720_45938_45951(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 45938, 45951);
                    return return_v;
                }


                int
                f_720_45915_45952(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 45915, 45952);
                    return 0;
                }


                System.Text.Encoding
                f_720_46248_46273()
                {
                    var return_v = Encoding.BigEndianUnicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 46248, 46273);
                    return return_v;
                }


                System.Text.Encoding
                f_720_46530_46546()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 46530, 46546);
                    return return_v;
                }


                System.Text.Encoding
                f_720_46839_46852()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 46839, 46852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 45744, 47020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 45744, 47020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class StaticContainer : SourceTextContainer
        {
            private readonly SourceText _text;

            public StaticContainer(SourceText text)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(720, 47158, 47258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 47136, 47141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 47230, 47243);

                    _text = text;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(720, 47158, 47258);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 47158, 47258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 47158, 47258);
                }
            }

            public override SourceText CurrentText
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 47313, 47321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 47316, 47321);
                        return _text; DynAbs.Tracing.TraceSender.TraceExitMethod(720, 47313, 47321);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 47313, 47321);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 47313, 47321);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override event EventHandler<TextChangeEventArgs> TextChanged
            {

                add
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 47438, 47514);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(720, 47438, 47514);
                        // do nothing
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 47438, 47514);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 47438, 47514);
                    }
                }

                remove
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(720, 47534, 47613);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(720, 47534, 47613);
                        // do nothing
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(720, 47534, 47613);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 47534, 47613);
                    }
                }
            }

            static StaticContainer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(720, 47032, 47639);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(720, 47032, 47639);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 47032, 47639);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(720, 47032, 47639);
        }

        static SourceText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(720, 713, 47646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 780, 806);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 835, 854);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 884, 923);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 987, 1076);
            s_charArrayPool = f_720_1005_1076(() => new char[CharBufferSize], CharBufferCount); DynAbs.Tracing.TraceSender.TraceSimpleStatement(720, 1417, 1527);
            s_utf8EncodingWithNoBOM = f_720_1443_1527(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(720, 713, 47646);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(720, 713, 47646);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(720, 713, 47646);

        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>
        f_720_1005_1076(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>.Factory
        factory, int
        size)
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<char[]>(factory, size);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 1005, 1076);
            return return_v;
        }


        static System.Text.UTF8Encoding
        f_720_1443_1527(bool
        encoderShouldEmitUTF8Identifier, bool
        throwOnInvalidBytes)
        {
            var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier: encoderShouldEmitUTF8Identifier, throwOnInvalidBytes: throwOnInvalidBytes);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 1443, 1527);
            return return_v;
        }


        static int
        f_720_1753_1797(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        checksumAlgorithm)
        {
            ValidateChecksumAlgorithm(checksumAlgorithm);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 1753, 1797);
            return 0;
        }


        bool
        f_720_1818_1837_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 1818, 1837);
            return return_v;
        }


        static int
        f_720_1860_1916(Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
        algorithmId)
        {
            var return_v = CryptographicHashProvider.GetHashSize(algorithmId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 1860, 1916);
            return return_v;
        }


        static string
        f_720_1978_2011()
        {
            var return_v = CodeAnalysisResources.InvalidHash;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 1978, 2011);
            return return_v;
        }


        static System.ArgumentException
        f_720_1956_2030(string
        message, string
        paramName)
        {
            var return_v = new System.ArgumentException(message, paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 1956, 2030);
            return return_v;
        }


        bool
        f_720_2573_2592_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 2573, 2592);
            return return_v;
        }


        static int
        f_720_2530_2593(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(720, 2530, 2593);
            return 0;
        }


        bool
        f_720_2614_2633_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(720, 2614, 2633);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_720_2353_2361_C(System.Collections.Immutable.ImmutableArray<byte>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(720, 2204, 3110);
            return return_v;
        }

    }
}
