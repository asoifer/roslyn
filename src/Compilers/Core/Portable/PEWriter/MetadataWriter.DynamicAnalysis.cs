// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Collections;

namespace Microsoft.Cci
{
    internal class DynamicAnalysisDataWriter
    {
        private struct DocumentRow
        {

            public BlobHandle Name;

            public GuidHandle HashAlgorithm;

            public BlobHandle Hash;
            static DocumentRow()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(500, 594, 762);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(500, 594, 762);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 594, 762);
            }
        }

        private struct MethodRow
        {

            public BlobHandle Spans;
            static MethodRow()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(500, 774, 858);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(500, 774, 858);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 774, 858);
            }
        }

        private readonly Dictionary<ImmutableArray<byte>, BlobHandle> _blobs;

        private int _blobHeapSize;

        private readonly Dictionary<Guid, GuidHandle> _guids;

        private readonly BlobBuilder _guidWriter;

        private readonly List<DocumentRow> _documentTable;

        private readonly List<MethodRow> _methodTable;

        private readonly Dictionary<DebugSourceDocument, int> _documentIndex;

        public DynamicAnalysisDataWriter(int documentCountEstimate, int methodCountEstimate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(500, 1368, 2439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 955, 961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 984, 997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1079, 1085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1125, 1136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1204, 1218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1262, 1274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1341, 1355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1689, 1831);

                _blobs = f_500_1698_1830(1 + methodCountEstimate + 4 * documentCountEstimate, ByteSequenceComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1896, 1920);

                const int
                guidSize = 16
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 1934, 1999);

                _guids = f_500_1943_1998(documentCountEstimate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2013, 2077);

                _guidWriter = f_500_2027_2076(guidSize * documentCountEstimate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2093, 2155);

                _documentTable = f_500_2110_2154(documentCountEstimate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2169, 2250);

                _documentIndex = f_500_2186_2249(documentCountEstimate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2264, 2320);

                _methodTable = f_500_2279_2319(methodCountEstimate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2336, 2396);

                f_500_2336_2395(
                            _blobs, ImmutableArray<byte>.Empty, default(BlobHandle));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2410, 2428);

                _blobHeapSize = 1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(500, 1368, 2439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 1368, 2439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 1368, 2439);
            }
        }

        internal void SerializeMethodDynamicAnalysisData(IMethodBody bodyOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 2451, 2887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2545, 2585);

                var
                data = f_500_2556_2584_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(bodyOpt, 500, 2556, 2584)?.DynamicAnalysisData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2601, 2728) || true) && (data == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 2601, 2728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2651, 2688);

                    f_500_2651_2687(_methodTable, default(MethodRow));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2706, 2713);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 2601, 2728);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2744, 2809);

                BlobHandle
                spanBlob = f_500_2766_2808(this, data.Spans, _documentIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 2823, 2876);

                f_500_2823_2875(_methodTable, new MethodRow { Spans = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => spanBlob, 500, 2840, 2874) });
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 2451, 2887);

                Microsoft.CodeAnalysis.CodeGen.DynamicAnalysisMethodBodyData?
                f_500_2556_2584_M(Microsoft.CodeAnalysis.CodeGen.DynamicAnalysisMethodBodyData?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 2556, 2584);
                    return return_v;
                }


                int
                f_500_2651_2687(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
                this_param, Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2651, 2687);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_2766_2808(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                spans, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                documentIndex)
                {
                    var return_v = this_param.SerializeSpans(spans, documentIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2766, 2808);
                    return return_v;
                }


                int
                f_500_2823_2875(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
                this_param, Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2823, 2875);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 2451, 2887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 2451, 2887);
            }
        }

        private BlobHandle GetOrAddBlob(BlobBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 2924, 3134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3075, 3123);

                return f_500_3082_3122(this, f_500_3095_3121(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 2924, 3134);

                System.Collections.Immutable.ImmutableArray<byte>
                f_500_3095_3121(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.ToImmutableArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3095, 3121);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_3082_3122(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = this_param.GetOrAddBlob(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3082, 3122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 2924, 3134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 2924, 3134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobHandle GetOrAddBlob(ImmutableArray<byte> blob)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 3146, 3571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3229, 3246);

                BlobHandle
                index
                = default(BlobHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3260, 3531) || true) && (!f_500_3265_3300(_blobs, blob, out index))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 3260, 3531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3334, 3383);

                    index = f_500_3342_3382(_blobHeapSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3401, 3425);

                    f_500_3401_3424(_blobs, blob, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3445, 3516);

                    _blobHeapSize += f_500_3462_3501(blob.Length) + blob.Length;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 3260, 3531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3547, 3560);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 3146, 3571);

                bool
                f_500_3265_3300(System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                key, out System.Reflection.Metadata.BlobHandle
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3265, 3300);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_3342_3382(int
                offset)
                {
                    var return_v = MetadataTokens.BlobHandle(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3342, 3382);
                    return return_v;
                }


                int
                f_500_3401_3424(System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                key, System.Reflection.Metadata.BlobHandle
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3401, 3424);
                    return 0;
                }


                int
                f_500_3462_3501(int
                length)
                {
                    var return_v = GetCompressedIntegerLength(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3462, 3501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 3146, 3571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 3146, 3571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetCompressedIntegerLength(int length)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(500, 3583, 3735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3665, 3724);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(500, 3672, 3688) || (((length <= 0x7f) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 3691, 3692)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 3695, 3723))) ? 1 : ((DynAbs.Tracing.TraceSender.Conditional_F1(500, 3696, 3714) || (((length <= 0x3fff) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 3717, 3718)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 3721, 3722))) ? 2 : 4);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(500, 3583, 3735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 3583, 3735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 3583, 3735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GuidHandle GetOrAddGuid(Guid guid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 3747, 4279);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3814, 3912) || true) && (guid == Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 3814, 3912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3870, 3897);

                    return default(GuidHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 3814, 3912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3928, 3946);

                GuidHandle
                result
                = default(GuidHandle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 3960, 4063) || true) && (f_500_3964_4000(_guids, guid, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 3960, 4063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4034, 4048);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 3960, 4063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4079, 4144);

                result = f_500_4088_4143((f_500_4115_4132(_guidWriter) >> 4) + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4158, 4183);

                f_500_4158_4182(_guids, guid, result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4197, 4240);

                f_500_4197_4239(_guidWriter, guid.ToByteArray());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4254, 4268);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 3747, 4279);

                bool
                f_500_3964_4000(System.Collections.Generic.Dictionary<System.Guid, System.Reflection.Metadata.GuidHandle>
                this_param, System.Guid
                key, out System.Reflection.Metadata.GuidHandle
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 3964, 4000);
                    return return_v;
                }


                int
                f_500_4115_4132(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 4115, 4132);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_500_4088_4143(int
                offset)
                {
                    var return_v = MetadataTokens.GuidHandle(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4088, 4143);
                    return return_v;
                }


                int
                f_500_4158_4182(System.Collections.Generic.Dictionary<System.Guid, System.Reflection.Metadata.GuidHandle>
                this_param, System.Guid
                key, System.Reflection.Metadata.GuidHandle
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4158, 4182);
                    return 0;
                }


                int
                f_500_4197_4239(System.Reflection.Metadata.BlobBuilder
                this_param, byte[]
                buffer)
                {
                    this_param.WriteBytes(buffer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4197, 4239);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 3747, 4279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 3747, 4279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BlobHandle SerializeSpans(
                    ImmutableArray<SourceSpan> spans,
                    Dictionary<DebugSourceDocument, int> documentIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 4338, 6364);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4509, 4606) || true) && (spans.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 4509, 4606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4564, 4591);

                    return default(BlobHandle);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 4509, 4606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4710, 4761);

                var
                writer = f_500_4723_4760(4 + spans.Length * 4)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4777, 4804);

                int
                previousStartLine = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4818, 4847);

                int
                previousStartColumn = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4861, 4918);

                DebugSourceDocument
                previousDocument = spans[0].Document
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 4958, 5039);

                f_500_4958_5038(
                            // header:
                            writer, f_500_4988_5037(this, previousDocument, documentIndex));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5064, 5069);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5055, 6309) || true) && (i < spans.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5089, 5092)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(500, 5055, 6309))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 5055, 6309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5126, 5166);

                        var
                        currentDocument = spans[i].Document
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5184, 5464) || true) && (previousDocument != currentDocument)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 5184, 5464);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5265, 5286);

                            f_500_5265_5285(writer, 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5308, 5388);

                            f_500_5308_5387(writer, f_500_5338_5386(this, currentDocument, documentIndex));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5410, 5445);

                            previousDocument = currentDocument;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(500, 5184, 5464);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5527, 5575);

                        f_500_5527_5574(this, writer, spans[i]);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5644, 6174) || true) && (previousStartLine < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 5644, 6174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5711, 5749);

                            f_500_5711_5748(previousStartColumn < 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5771, 5821);

                            f_500_5771_5820(writer, spans[i].StartLine);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5843, 5895);

                            f_500_5843_5894(writer, spans[i].StartColumn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(500, 5644, 6174);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 5644, 6174);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 5977, 6053);

                            f_500_5977_6052(writer, spans[i].StartLine - previousStartLine);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6075, 6155);

                            f_500_6075_6154(writer, spans[i].StartColumn - previousStartColumn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(500, 5644, 6174);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6194, 6233);

                        previousStartLine = spans[i].StartLine;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6251, 6294);

                        previousStartColumn = spans[i].StartColumn;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 1255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 1255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6325, 6353);

                return f_500_6332_6352(this, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 4338, 6364);

                System.Reflection.Metadata.BlobBuilder
                f_500_4723_4760(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4723, 4760);
                    return return_v;
                }


                int
                f_500_4988_5037(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                index)
                {
                    var return_v = this_param.GetOrAddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4988, 5037);
                    return return_v;
                }


                int
                f_500_4958_5038(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 4958, 5038);
                    return 0;
                }


                int
                f_500_5265_5285(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt16((short)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5265, 5285);
                    return 0;
                }


                int
                f_500_5338_5386(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                index)
                {
                    var return_v = this_param.GetOrAddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5338, 5386);
                    return return_v;
                }


                int
                f_500_5308_5387(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5308, 5387);
                    return 0;
                }


                int
                f_500_5527_5574(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.CodeAnalysis.CodeGen.SourceSpan
                span)
                {
                    this_param.SerializeDeltaLinesAndColumns(writer, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5527, 5574);
                    return 0;
                }


                int
                f_500_5711_5748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5711, 5748);
                    return 0;
                }


                int
                f_500_5771_5820(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5771, 5820);
                    return 0;
                }


                int
                f_500_5843_5894(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5843, 5894);
                    return 0;
                }


                int
                f_500_5977_6052(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 5977, 6052);
                    return 0;
                }


                int
                f_500_6075_6154(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6075, 6154);
                    return 0;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_6332_6352(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                builder)
                {
                    var return_v = this_param.GetOrAddBlob(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6332, 6352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 4338, 6364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 4338, 6364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SerializeDeltaLinesAndColumns(BlobBuilder writer, SourceSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 6376, 7018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6480, 6527);

                int
                deltaLines = span.EndLine - span.StartLine
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6541, 6594);

                int
                deltaColumns = span.EndColumn - span.StartColumn
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6654, 6705);

                f_500_6654_6704(deltaLines != 0 || (DynAbs.Tracing.TraceSender.Expression_False(500, 6667, 6703) || deltaColumns != 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6721, 6763);

                f_500_6721_6762(
                            writer, deltaLines);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6779, 7007) || true) && (deltaLines == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 6779, 7007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6832, 6876);

                    f_500_6832_6875(writer, deltaColumns);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 6779, 7007);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 6779, 7007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 6942, 6992);

                    f_500_6942_6991(writer, deltaColumns);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 6779, 7007);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 6376, 7018);

                int
                f_500_6654_6704(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6654, 6704);
                    return 0;
                }


                int
                f_500_6721_6762(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6721, 6762);
                    return 0;
                }


                int
                f_500_6832_6875(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6832, 6875);
                    return 0;
                }


                int
                f_500_6942_6991(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedSignedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 6942, 6991);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 6376, 7018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 6376, 7018);
            }
        }

        internal int GetOrAddDocument(DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 7081, 7226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7165, 7215);

                return f_500_7172_7214(this, document, _documentIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 7081, 7226);

                int
                f_500_7172_7214(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, Microsoft.Cci.DebugSourceDocument
                document, System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                index)
                {
                    var return_v = this_param.GetOrAddDocument(document, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7172, 7214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 7081, 7226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 7081, 7226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int GetOrAddDocument(DebugSourceDocument document, Dictionary<DebugSourceDocument, int> index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 7238, 8120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7365, 7383);

                int
                documentRowId
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7397, 8072) || true) && (!f_500_7402_7448(index, document, out documentRowId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 7397, 8072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7482, 7523);

                    documentRowId = f_500_7498_7518(_documentTable) + 1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7541, 7576);

                    f_500_7541_7575(index, document, documentRowId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7596, 7638);

                    var
                    sourceInfo = f_500_7613_7637(document)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 7656, 8057);

                    f_500_7656_8056(_documentTable, new DocumentRow
                    {
                        Name = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_500_7738_7778(this, f_500_7760_7777(document)), 500, 7675, 8055),
                        HashAlgorithm = ((DynAbs.Tracing.TraceSender.Conditional_F1(500, 7818, 7847) || ((sourceInfo.Checksum.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(500, 7850, 7869)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 7872, 7916))) ? default(GuidHandle) : f_500_7872_7916(this, sourceInfo.ChecksumAlgorithmId)),
                        Hash = (DynAbs.Tracing.TraceSender.Conditional_F1(500, 7947, 7978) || (((sourceInfo.Checksum.IsDefault) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 7981, 8000)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 8003, 8036))) ? default(BlobHandle) : f_500_8003_8036(this, sourceInfo.Checksum)
                    });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(500, 7397, 8072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8088, 8109);

                return documentRowId;
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 7238, 8120);

                bool
                f_500_7402_7448(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7402, 7448);
                    return return_v;
                }


                int
                f_500_7498_7518(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 7498, 7518);
                    return return_v;
                }


                int
                f_500_7541_7575(System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
                this_param, Microsoft.Cci.DebugSourceDocument
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7541, 7575);
                    return 0;
                }


                Microsoft.Cci.DebugSourceInfo
                f_500_7613_7637(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.GetSourceInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7613, 7637);
                    return return_v;
                }


                string
                f_500_7760_7777(Microsoft.Cci.DebugSourceDocument
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 7760, 7777);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_7738_7778(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, string
                name)
                {
                    var return_v = this_param.SerializeDocumentName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7738, 7778);
                    return return_v;
                }


                System.Reflection.Metadata.GuidHandle
                f_500_7872_7916(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Guid
                guid)
                {
                    var return_v = this_param.GetOrAddGuid(guid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7872, 7916);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_8003_8036(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = this_param.GetOrAddBlob(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8003, 8036);
                    return return_v;
                }


                int
                f_500_7656_8056(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
                this_param, Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 7656, 8056);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 7238, 8120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 7238, 8120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_separator1;

        private static readonly char[] s_separator2;

        private BlobHandle SerializeDocumentName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 8263, 9165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8341, 8368);

                f_500_8341_8367(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8384, 8422);

                int
                c1 = f_500_8393_8421(name, s_separator1[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8436, 8474);

                int
                c2 = f_500_8445_8473(name, s_separator2[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8488, 8548);

                char[]
                separator = (DynAbs.Tracing.TraceSender.Conditional_F1(500, 8507, 8517) || (((c1 >= c2) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 8520, 8532)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 8535, 8547))) ? s_separator1 : s_separator2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8661, 8716);

                var
                writer = f_500_8674_8715(1 + f_500_8694_8710(c1, c2) * 2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8732, 8769);

                f_500_8732_8768(
                            writer, separator[0]);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8825, 9110);
                    foreach (var part in f_500_8846_8867_I(f_500_8846_8867(name, separator)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 8825, 9110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8901, 9006);

                        BlobHandle
                        partIndex = f_500_8924_9005(this, f_500_8937_9004(f_500_8959_9003(MetadataWriter.s_utf8Encoding, part)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9024, 9095);

                        f_500_9024_9094(writer, f_500_9054_9093(partIndex));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(500, 8825, 9110);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9126, 9154);

                return f_500_9133_9153(this, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 8263, 9165);

                int
                f_500_8341_8367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8341, 8367);
                    return 0;
                }


                int
                f_500_8393_8421(string
                str, char
                c)
                {
                    var return_v = Count(str, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8393, 8421);
                    return return_v;
                }


                int
                f_500_8445_8473(string
                str, char
                c)
                {
                    var return_v = Count(str, c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8445, 8473);
                    return return_v;
                }


                int
                f_500_8694_8710(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8694, 8710);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_500_8674_8715(int
                capacity)
                {
                    var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8674, 8715);
                    return return_v;
                }


                int
                f_500_8732_8768(System.Reflection.Metadata.BlobBuilder
                this_param, char
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8732, 8768);
                    return 0;
                }


                string[]
                f_500_8846_8867(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8846, 8867);
                    return return_v;
                }


                byte[]
                f_500_8959_9003(System.Text.Encoding
                this_param, string
                s)
                {
                    var return_v = this_param.GetBytes(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8959, 9003);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_500_8937_9004(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8937, 9004);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_8924_9005(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                blob)
                {
                    var return_v = this_param.GetOrAddBlob(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8924, 9005);
                    return return_v;
                }


                int
                f_500_9054_9093(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 9054, 9093);
                    return return_v;
                }


                int
                f_500_9024_9094(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteCompressedInteger(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 9024, 9094);
                    return 0;
                }


                string[]
                f_500_8846_8867_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 8846, 8867);
                    return return_v;
                }


                System.Reflection.Metadata.BlobHandle
                f_500_9133_9153(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                builder)
                {
                    var return_v = this_param.GetOrAddBlob(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 9133, 9153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 8263, 9165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 8263, 9165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int Count(string str, char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(500, 9177, 9482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9246, 9260);

                int
                count = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9283, 9288);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9274, 9442) || true) && (i < f_500_9294_9304(str))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9306, 9309)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(500, 9274, 9442))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 9274, 9442);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9343, 9427) || true) && (f_500_9347_9353(str, i) == c)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 9343, 9427);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9400, 9408);

                            count++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(500, 9343, 9427);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9458, 9471);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(500, 9177, 9482);

                int
                f_500_9294_9304(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 9294, 9304);
                    return return_v;
                }


                char
                f_500_9347_9353(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 9347, 9353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 9177, 9482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 9177, 9482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private struct Sizes
        {

            public readonly int BlobHeapSize;

            public readonly int GuidHeapSize;

            public readonly int BlobIndexSize;

            public readonly int GuidIndexSize;

            public Sizes(int blobHeapSize, int guidHeapSize)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(500, 9794, 10116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9875, 9903);

                    BlobHeapSize = blobHeapSize;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9921, 9949);

                    GuidHeapSize = guidHeapSize;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 9967, 10025);

                    BlobIndexSize = (DynAbs.Tracing.TraceSender.Conditional_F1(500, 9983, 10016) || (((blobHeapSize <= ushort.MaxValue) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 10019, 10020)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 10023, 10024))) ? 2 : 4;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10043, 10101);

                    GuidIndexSize = (DynAbs.Tracing.TraceSender.Conditional_F1(500, 10059, 10092) || (((guidHeapSize <= ushort.MaxValue) && DynAbs.Tracing.TraceSender.Conditional_F2(500, 10095, 10096)) || DynAbs.Tracing.TraceSender.Conditional_F3(500, 10099, 10100))) ? 2 : 4;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(500, 9794, 10116);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 9794, 10116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 9794, 10116);
                }
            }
            static Sizes()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(500, 9555, 10127);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(500, 9555, 10127);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 9555, 10127);
            }
        }

        internal void SerializeMetadataTables(BlobBuilder writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 10139, 10569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10221, 10277);

                var
                sizes = f_500_10233_10276(_blobHeapSize, f_500_10258_10275(_guidWriter))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10293, 10324);

                f_500_10293_10323(this, writer, sizes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10364, 10402);

                f_500_10364_10401(this, writer, sizes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10416, 10452);

                f_500_10416_10451(this, writer, sizes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10491, 10522);

                f_500_10491_10521(
                            // heaps:
                            writer, _guidWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10536, 10558);

                f_500_10536_10557(this, writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 10139, 10569);

                int
                f_500_10258_10275(System.Reflection.Metadata.BlobBuilder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 10258, 10275);
                    return return_v;
                }


                Microsoft.Cci.DynamicAnalysisDataWriter.Sizes
                f_500_10233_10276(int
                blobHeapSize, int
                guidHeapSize)
                {
                    var return_v = new Microsoft.Cci.DynamicAnalysisDataWriter.Sizes(blobHeapSize, guidHeapSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10233, 10276);
                    return return_v;
                }


                int
                f_500_10293_10323(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.DynamicAnalysisDataWriter.Sizes
                sizes)
                {
                    this_param.SerializeHeader(writer, sizes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10293, 10323);
                    return 0;
                }


                int
                f_500_10364_10401(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.DynamicAnalysisDataWriter.Sizes
                sizes)
                {
                    this_param.SerializeDocumentTable(writer, sizes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10364, 10401);
                    return 0;
                }


                int
                f_500_10416_10451(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                writer, Microsoft.Cci.DynamicAnalysisDataWriter.Sizes
                sizes)
                {
                    this_param.SerializeMethodTable(writer, sizes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10416, 10451);
                    return 0;
                }


                int
                f_500_10491_10521(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.BlobBuilder
                suffix)
                {
                    this_param.LinkSuffix(suffix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10491, 10521);
                    return 0;
                }


                int
                f_500_10536_10557(Microsoft.Cci.DynamicAnalysisDataWriter
                this_param, System.Reflection.Metadata.BlobBuilder
                builder)
                {
                    this_param.WriteBlobHeap(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10536, 10557);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 10139, 10569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 10139, 10569);
            }
        }

        private void WriteBlobHeap(BlobBuilder builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 10581, 11452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 10653, 10718);

                var
                writer = f_500_10666_10717(f_500_10681_10716(builder, _blobHeapSize))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11116, 11441);
                    foreach (var entry in f_500_11138_11144_I(_blobs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 11116, 11441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11178, 11237);

                        int
                        heapOffset = f_500_11195_11236(entry.Value)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11255, 11276);

                        var
                        blob = entry.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11296, 11323);

                        writer.Offset = heapOffset;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11341, 11384);

                        writer.WriteCompressedInteger(blob.Length);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11402, 11426);

                        writer.WriteBytes(blob);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(500, 11116, 11441);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 326);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 10581, 11452);

                System.Reflection.Metadata.Blob
                f_500_10681_10716(System.Reflection.Metadata.BlobBuilder
                this_param, int
                byteCount)
                {
                    var return_v = this_param.ReserveBytes(byteCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10681, 10716);
                    return return_v;
                }


                System.Reflection.Metadata.BlobWriter
                f_500_10666_10717(System.Reflection.Metadata.Blob
                blob)
                {
                    var return_v = new System.Reflection.Metadata.BlobWriter(blob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 10666, 10717);
                    return return_v;
                }


                int
                f_500_11195_11236(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11195, 11236);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
                f_500_11138_11144_I(System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11138, 11144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 10581, 11452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 10581, 11452);
            }
        }

        private void SerializeHeader(BlobBuilder writer, Sizes sizes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 11464, 12117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11577, 11605);

                f_500_11577_11604(            // signature:
                            writer, 'D');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11619, 11647);

                f_500_11619_11646(writer, 'A');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11661, 11689);

                f_500_11661_11688(writer, 'M');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11703, 11731);

                f_500_11703_11730(writer, 'D');
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11776, 11796);

                f_500_11776_11795(
                            // version: 0.2
                            writer, 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11810, 11830);

                f_500_11810_11829(writer, 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11875, 11915);

                f_500_11875_11914(
                            // table sizes:
                            writer, f_500_11893_11913(_documentTable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 11929, 11967);

                f_500_11929_11966(writer, f_500_11947_11965(_methodTable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12016, 12054);

                f_500_12016_12053(
                            // blob heap sizes:
                            writer, sizes.GuidHeapSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12068, 12106);

                f_500_12068_12105(writer, sizes.BlobHeapSize);
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 11464, 12117);

                int
                f_500_11577_11604(System.Reflection.Metadata.BlobBuilder
                this_param, char
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11577, 11604);
                    return 0;
                }


                int
                f_500_11619_11646(System.Reflection.Metadata.BlobBuilder
                this_param, char
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11619, 11646);
                    return 0;
                }


                int
                f_500_11661_11688(System.Reflection.Metadata.BlobBuilder
                this_param, char
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11661, 11688);
                    return 0;
                }


                int
                f_500_11703_11730(System.Reflection.Metadata.BlobBuilder
                this_param, char
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11703, 11730);
                    return 0;
                }


                int
                f_500_11776_11795(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11776, 11795);
                    return 0;
                }


                int
                f_500_11810_11829(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11810, 11829);
                    return 0;
                }


                int
                f_500_11893_11913(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 11893, 11913);
                    return return_v;
                }


                int
                f_500_11875_11914(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11875, 11914);
                    return 0;
                }


                int
                f_500_11947_11965(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(500, 11947, 11965);
                    return return_v;
                }


                int
                f_500_11929_11966(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 11929, 11966);
                    return 0;
                }


                int
                f_500_12016_12053(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12016, 12053);
                    return 0;
                }


                int
                f_500_12068_12105(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12068, 12105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 11464, 12117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 11464, 12117);
            }
        }

        private void SerializeDocumentTable(BlobBuilder writer, Sizes sizes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 12129, 12658);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12222, 12647);
                    foreach (var row in f_500_12242_12256_I(_documentTable))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 12222, 12647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12290, 12389);

                        f_500_12290_12388(writer, f_500_12312_12350(row.Name), isSmall: (sizes.BlobIndexSize == 2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12407, 12515);

                        f_500_12407_12514(writer, f_500_12429_12476(row.HashAlgorithm), isSmall: (sizes.GuidIndexSize == 2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12533, 12632);

                        f_500_12533_12631(writer, f_500_12555_12593(row.Hash), isSmall: (sizes.BlobIndexSize == 2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(500, 12222, 12647);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 426);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 12129, 12658);

                int
                f_500_12312_12350(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12312, 12350);
                    return return_v;
                }


                int
                f_500_12290_12388(System.Reflection.Metadata.BlobBuilder
                this_param, int
                reference, bool
                isSmall)
                {
                    this_param.WriteReference(reference, isSmall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12290, 12388);
                    return 0;
                }


                int
                f_500_12429_12476(System.Reflection.Metadata.GuidHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12429, 12476);
                    return return_v;
                }


                int
                f_500_12407_12514(System.Reflection.Metadata.BlobBuilder
                this_param, int
                reference, bool
                isSmall)
                {
                    this_param.WriteReference(reference, isSmall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12407, 12514);
                    return 0;
                }


                int
                f_500_12555_12593(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12555, 12593);
                    return return_v;
                }


                int
                f_500_12533_12631(System.Reflection.Metadata.BlobBuilder
                this_param, int
                reference, bool
                isSmall)
                {
                    this_param.WriteReference(reference, isSmall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12533, 12631);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
                f_500_12242_12256_I(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12242, 12256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 12129, 12658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 12129, 12658);
            }
        }

        private void SerializeMethodTable(BlobBuilder writer, Sizes sizes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(500, 12670, 12953);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12761, 12942);
                    foreach (var row in f_500_12781_12793_I(_methodTable))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(500, 12761, 12942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 12827, 12927);

                        f_500_12827_12926(writer, f_500_12849_12888(row.Spans), isSmall: (sizes.BlobIndexSize == 2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(500, 12761, 12942);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(500, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(500, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(500, 12670, 12953);

                int
                f_500_12849_12888(System.Reflection.Metadata.BlobHandle
                handle)
                {
                    var return_v = MetadataTokens.GetHeapOffset(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12849, 12888);
                    return return_v;
                }


                int
                f_500_12827_12926(System.Reflection.Metadata.BlobBuilder
                this_param, int
                reference, bool
                isSmall)
                {
                    this_param.WriteReference(reference, isSmall);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12827, 12926);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
                f_500_12781_12793_I(System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 12781, 12793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(500, 12670, 12953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 12670, 12953);
            }
        }

        static DynamicAnalysisDataWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(500, 537, 12982);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8163, 8185);
            s_separator1 = new char[] { '/' }; DynAbs.Tracing.TraceSender.TraceSimpleStatement(500, 8227, 8250);
            s_separator2 = new char[] { '\\' }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(500, 537, 12982);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(500, 537, 12982);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(500, 537, 12982);

        static System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
        f_500_1698_1830(int
        capacity, Microsoft.CodeAnalysis.Collections.ByteSequenceComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>(capacity, (System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableArray<byte>>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 1698, 1830);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<System.Guid, System.Reflection.Metadata.GuidHandle>
        f_500_1943_1998(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Reflection.Metadata.GuidHandle>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 1943, 1998);
            return return_v;
        }


        static System.Reflection.Metadata.BlobBuilder
        f_500_2027_2076(int
        capacity)
        {
            var return_v = new System.Reflection.Metadata.BlobBuilder(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2027, 2076);
            return return_v;
        }


        static System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>
        f_500_2110_2154(int
        capacity)
        {
            var return_v = new System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.DocumentRow>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2110, 2154);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>
        f_500_2186_2249(int
        capacity)
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.Cci.DebugSourceDocument, int>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2186, 2249);
            return return_v;
        }


        static System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>
        f_500_2279_2319(int
        capacity)
        {
            var return_v = new System.Collections.Generic.List<Microsoft.Cci.DynamicAnalysisDataWriter.MethodRow>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2279, 2319);
            return return_v;
        }


        static int
        f_500_2336_2395(System.Collections.Generic.Dictionary<System.Collections.Immutable.ImmutableArray<byte>, System.Reflection.Metadata.BlobHandle>
        this_param, System.Collections.Immutable.ImmutableArray<byte>
        key, System.Reflection.Metadata.BlobHandle
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(500, 2336, 2395);
            return 0;
        }

    }
}
